using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek.Controller
{
    internal class StokController
    {
        // Koneksi dari model
        private readonly Model.Connection connection = new Model.Connection();

        // Menampilkan data obat
        public DataTable TampilObat()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM stok_obat"; // Query menampilkan data

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt); // Isi DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi setelah selesai
            }

            return dt;
        }

        // Menambahkan obat ke database
        public void TambahObat(string idObat, string namaObat, string kategori, int jumlah, decimal harga)
        {
            string query = "INSERT INTO stok_obat (id_obat, nama_obat, kategori, jumlah, harga) VALUES (@id_obat, @nama_obat, @kategori, @jumlah, @harga)";

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Menambahkan parameter ke query
                cmd.Parameters.AddWithValue("@id_obat", idObat);
                cmd.Parameters.AddWithValue("@nama_obat", namaObat);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@harga", harga);

                cmd.ExecuteNonQuery(); // Eksekusi query
                MessageBox.Show("Obat berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan obat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi
            }
        }

        // Mengupdate data stok obat di database
        public bool UpdateStok(string idObat, int jumlah, string namaObat, string kategori, decimal harga)
        {
            string query = @"UPDATE stok_obat 
                             SET nama_obat = @nama_obat, kategori = @kategori, jumlah = @jumlah, harga = @harga 
                             WHERE id_obat = @id_obat";

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Menambahkan parameter ke query
                cmd.Parameters.AddWithValue("@id_obat", idObat);
                cmd.Parameters.AddWithValue("@nama_obat", namaObat);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@harga", harga);

                int rowsAffected = cmd.ExecuteNonQuery(); // Eksekusi query
                return rowsAffected > 0; // Return true jika ada baris yang diperbarui
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi
            }
        }

        // Metode untuk menghapus stok berdasarkan ID Obat
        public void DeleteStok(string idObat)
        {
            // Pastikan ID Obat tidak kosong
            if (string.IsNullOrEmpty(idObat))
            {
                MessageBox.Show("ID Obat tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM stok_obat WHERE id_obat = @id_obat";

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Tambahkan parameter ID Obat
                cmd.Parameters.AddWithValue("@id_obat", idObat);

                // Konfirmasi penghapusan
                var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus stok dengan ID: {idObat}?",
                                              "Konfirmasi Hapus",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery(); // Eksekusi query

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stok berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Stok tidak ditemukan atau sudah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghapus stok: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Tutup koneksi
            }
        }
    }


    }



