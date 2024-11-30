using Apotek.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek.Controller
{

    internal class PenjualanController
    {
        // Membuat instance dari koneksi
        private readonly Connection connection = new Connection();

        // Menampilkan data penjualan
        public DataTable TampilPenjualan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM penjualan"; // Query untuk menampilkan data penjualan

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt); // Mengisi DataTable dengan data penjualan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data penjualan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi setelah selesai
            }

            return dt;
        }

        // Menambahkan transaksi penjualan ke database
        public void TambahPenjualan(string idPenjualan, string idKaryawan, DateTime tanggalPenjualan, decimal totalTransaksi, DataTable detailPenjualan)
        {
            if (totalTransaksi <= 0)
            {
                MessageBox.Show("Total transaksi tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRow row in detailPenjualan.Rows)
            {
                string idObat = row["id_obat"].ToString();
                int jumlah = Convert.ToInt32(row["jumlah"]);

                // Memeriksa stok obat
                int stokSekarang = GetStokObat(idObat);
                if (stokSekarang < jumlah)
                {
                    MessageBox.Show($"Stok obat {idObat} tidak mencukupi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string query = @"
                INSERT INTO penjualan (id_penjualan, id_karyawan, tanggal_penjualan, total_transaksi)
                VALUES (@id_penjualan, @id_karyawan, @tanggal_penjualan, @total_transaksi)";

            try
            {
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_penjualan", idPenjualan);
                cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);
                cmd.Parameters.AddWithValue("@tanggal_penjualan", tanggalPenjualan);
                cmd.Parameters.AddWithValue("@total_transaksi", totalTransaksi);
                cmd.ExecuteNonQuery();

                foreach (DataRow row in detailPenjualan.Rows)
                {
                    string queryDetail = @"
                        INSERT INTO detail_penjualan (id_penjualan, id_obat, jumlah, subtotal)
                        VALUES (@id_penjualan, @id_obat, @jumlah, @subtotal)";
                    MySqlCommand cmdDetail = new MySqlCommand(queryDetail, conn);
                    cmdDetail.Parameters.AddWithValue("@id_penjualan", idPenjualan);
                    cmdDetail.Parameters.AddWithValue("@id_obat", row["id_obat"]);
                    cmdDetail.Parameters.AddWithValue("@jumlah", row["jumlah"]);
                    cmdDetail.Parameters.AddWithValue("@subtotal", row["subtotal"]);
                    cmdDetail.ExecuteNonQuery();
                }

                MessageBox.Show("Penjualan berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan penjualan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close();
            }
        }

        // Menghapus data penjualan berdasarkan ID Penjualan
        public void HapusPenjualan(string idPenjualan)
        {
            if (string.IsNullOrEmpty(idPenjualan))
            {
                MessageBox.Show("ID Penjualan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM penjualan WHERE id_penjualan = @id_penjualan";

            try
            {
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_penjualan", idPenjualan);

                var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus penjualan dengan ID: {idPenjualan}?",
                                              "Konfirmasi Hapus",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data penjualan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data penjualan tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus data penjualan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close();
            }
        }

        // Fungsi untuk mendapatkan stok obat berdasarkan ID obat
        private int GetStokObat(string idObat)
        {
            int stok = 0;
            string query = "SELECT jumlah FROM stok_obat WHERE id_obat = @id_obat";

            try
            {
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_obat", idObat);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    stok = reader.GetInt32("jumlah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memeriksa stok obat: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close();
            }

            return stok;
        }




        public void TambahDetailPenjualan(string idPenjualan, string idObat, int jumlah, decimal subtotal)
        {
            if (jumlah <= 0 || subtotal <= 0)
            {
                MessageBox.Show("Jumlah atau Subtotal tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
        INSERT INTO detail_penjualan (id_penjualan, id_obat, jumlah, subtotal)
        VALUES (@id_penjualan, @id_obat, @jumlah, @subtotal)";

            try
            {
                using (MySqlConnection conn = connection.GetConn()) // Gunakan blok using
                {
                    conn.Close();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_penjualan", idPenjualan);
                    cmd.Parameters.AddWithValue("@id_obat", idObat);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Detail penjualan berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan detail penjualan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        public void TampilDetailPenjualan(DataGridView dataGrid, string idPenjualan)
        {
            string query = @"
        SELECT 
            dp.id_detail_penjualan AS 'ID Detail',
            dp.id_obat AS 'ID Obat',
            s.nama_obat AS 'Nama Obat',
            dp.jumlah AS 'Jumlah',
            dp.subtotal AS 'Subtotal'
        FROM detail_penjualan dp
        JOIN stok_obat s ON dp.id_obat = s.id_obat
        WHERE dp.id_penjualan = @id_penjualan";

            try
            {
                using (MySqlConnection conn = connection.GetConn()) // Pastikan koneksi ditutup otomatis
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_penjualan", idPenjualan);

                    conn.Open(); // Buka koneksi
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Masukkan data ke DataGridView
                    dataGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menampilkan detail penjualan: " + ex.Message);
            }
        }
        // Menghapus detail penjualan
        public void HapusDetailPenjualan(string idDetailPenjualan)
        {
            if (string.IsNullOrEmpty(idDetailPenjualan))
            {
                MessageBox.Show("ID Detail Penjualan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM detail_penjualan WHERE id_detail_penjualan = @id_detail_penjualan";

            try
            {
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_detail_penjualan", idDetailPenjualan);

                var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus detail penjualan dengan ID: {idDetailPenjualan}?",
                                              "Konfirmasi Hapus",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data detail penjualan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data detail penjualan tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus detail penjualan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close();
            }
        }
    }
}