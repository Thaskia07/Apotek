using Apotek.Model;
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
    internal class ResepController
    {
        // Koneksi dari model
        private readonly Model.Connection connection = new Model.Connection();
        // Menampilkan data pasien
        public DataTable TampilPasien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM pasien"; // Query menampilkan data pasien

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt); // Isi DataTable dengan data pasien
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data pasien: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi setelah selesai
            }

            return dt;
        }

        // Menambahkan pasien ke database
        public void TambahPasien(string idPasien, string namaPasien, string alamat, string telepon)
        {
            string query = "INSERT INTO pasien (id_pasien, nama_pasien, alamat, telepon) VALUES (@id_pasien, @nama_pasien, @alamat, @telepon)";

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Menambahkan parameter ke query
                cmd.Parameters.AddWithValue("@id_pasien", idPasien);
                cmd.Parameters.AddWithValue("@nama_pasien", namaPasien);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@telepon", telepon);

                cmd.ExecuteNonQuery(); // Eksekusi query
                MessageBox.Show("Pasien berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan pasien: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi
            }
        }

        // Menampilkan semua resep obat
        public DataTable TampilResep()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            r.id_resep AS 'ID Resep',
            p.nama_pasien AS 'Nama Pasien',
            r.tanggal_resep AS 'Tanggal Resep'
        FROM resep_obat r
        JOIN pasien p ON r.id_pasien = p.id_pasien";

            try
            {
                // Pastikan Anda sudah memiliki kelas `connection` dengan metode `GetConn()` yang mengembalikan objek MySqlConnection.
                using (MySqlConnection conn = connection.GetConn())
                {
                    conn.Open(); // Buka koneksi ke database
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt); // Isi DataTable dengan hasil query
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Tangkap MySQL-specific error
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Tangkap error umum
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }


        // Metode untuk mencari resep berdasarkan ID Resep
        public DataTable CariResepById(string idResep)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    r.id_resep AS 'ID Resep',
                    p.nama_pasien AS 'Nama Pasien',
                    p.alamat AS 'Alamat',
                    p.telepon AS 'Telepon',
                    o.nama_obat AS 'Nama Obat',
                    d.jumlah AS 'Jumlah',
                    d.dosis AS 'Dosis',
                    r.tanggal_resep AS 'Tanggal Resep'
                FROM resep_obat r
                JOIN pasien p ON r.id_pasien = p.id_pasien
                JOIN detail_resep d ON r.id_resep = d.id_resep
                JOIN stok_obat o ON d.id_obat = o.id_obat
                WHERE r.id_resep = @id_resep";

            try
            {
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_resep", idResep);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt); // Isi DataTable dengan hasil query
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close();
            }

            return dt;
        }

        // Metode untuk mencari resep berdasarkan ID Pasien
        public DataTable CariResepByPasien(string idPasien)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    r.id_resep AS 'ID Resep',
                    p.nama_pasien AS 'Nama Pasien',
                    p.alamat AS 'Alamat',
                    p.telepon AS 'Telepon',
                    o.nama_obat AS 'Nama Obat',
                    d.jumlah AS 'Jumlah',
                    d.dosis AS 'Dosis',
                    r.tanggal_resep AS 'Tanggal Resep'
                FROM resep_obat r
                JOIN pasien p ON r.id_pasien = p.id_pasien
                JOIN detail_resep d ON r.id_resep = d.id_resep
                JOIN stok_obat o ON d.id_obat = o.id_obat
                WHERE p.id_pasien = @id_pasien";

            try
            {
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_pasien", idPasien);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt); // Isi DataTable dengan hasil query
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close();
            }

            return dt;
        }


        // Menampilkan detail resep
        //public void TampilDetailResep(DataGridView dataGrid, string idResep)
        //{
        //    string query = @"
        //        SELECT 
        //            dr.id_detail_resep AS 'ID Detail',
        //            dr.id_obat AS 'ID Obat',
        //            o.nama_obat AS 'Nama Obat',
        //            dr.jumlah AS 'Jumlah',
        //            dr.keterangan AS 'Keterangan'
        //        FROM detail_resep dr
        //        JOIN obat o ON dr.id_obat = o.id_obat
        //        WHERE dr.id_resep = @id_resep";

        //    try
        //    {
        //        using (MySqlConnection conn = connection.GetConn()) // Pastikan koneksi ditutup otomatis
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@id_resep", idResep);

        //            conn.Open(); // Buka koneksi
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();
        //            adapter.Fill(dt);

        //            // Masukkan data ke DataGridView
        //            dataGrid.DataSource = dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal menampilkan detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// Menambah detail resep
        //public void TambahDetailResep(string idResep, string idObat, int jumlah, string keterangan)
        //{
        //    if (jumlah <= 0)
        //    {
        //        MessageBox.Show("Jumlah tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    string query = @"
        //        INSERT INTO detail_resep (id_resep, id_obat, jumlah, keterangan)
        //        VALUES (@id_resep, @id_obat, @jumlah, @keterangan)";

        //    try
        //    {
        //        using (MySqlConnection conn = connection.GetConn()) // Gunakan blok using
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@id_resep", idResep);
        //            cmd.Parameters.AddWithValue("@id_obat", idObat);
        //            cmd.Parameters.AddWithValue("@jumlah", jumlah);
        //            cmd.Parameters.AddWithValue("@keterangan", keterangan);

        //            conn.Open();
        //            cmd.ExecuteNonQuery();

        //            MessageBox.Show("Detail resep berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal menambahkan detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




        //public void HapusDetailResep(string idDetailResep)
        //{
        //    string query = "DELETE FROM detail_resep WHERE id_detail_resep = @id_detail_resep";

        //    try
        //    {
        //        using (MySqlConnection conn = connection.GetConn())
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@id_detail_resep", idDetailResep);

        //            conn.Open();
        //            cmd.ExecuteNonQuery();

        //            MessageBox.Show("Detail resep berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal menghapus detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //public void TambahDetailResep(string idDetailResep, string idResep, string idObat, int jumlah, string dosis)
        //{
        //    string query = @"INSERT INTO detail_resep (id_detail_resep, id_resep, id_obat, jumlah, dosis)
        //                     VALUES (@id_detail_resep, @id_resep, @id_obat, @jumlah, @dosis)";

        //    using (MySqlConnection conn = connection.GetConn())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@id_detail_resep", idDetailResep);
        //        cmd.Parameters.AddWithValue("@id_resep", idResep);
        //        cmd.Parameters.AddWithValue("@id_obat", idObat);
        //        cmd.Parameters.AddWithValue("@jumlah", jumlah);
        //        cmd.Parameters.AddWithValue("@dosis", dosis);

        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public void HapusDetailResep(string idDetailResep)
        //{
        //    string query = "DELETE FROM detail_resep WHERE id_detail_resep = @id_detail_resep";

        //    using (MySqlConnection conn = connection.GetConn())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@id_detail_resep", idDetailResep);

        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public DataTable GetDetailResepData()
        //{
        //    string query = "SELECT * FROM detail_resep";

        //    using (MySqlConnection conn = connection.GetConn())
        //    {
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //    }
        //}



        // Metode untuk menambah detail resep
        public void TambahDetailResep(string idResep, string idObat, int jumlah, string dosis)
        {
            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
            INSERT INTO detail_resep (id_resep, id_obat, jumlah, dosis)
            VALUES (@id_resep, @id_obat, @jumlah, @dosis)";

            try
            {
                using (MySqlConnection conn = connection.GetConn())
                {
                    conn.Close();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_resep", idResep);
                    cmd.Parameters.AddWithValue("@id_obat", idObat);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@dosis", dosis);

                    conn.Open(); // Buka koneksi
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Detail resep berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode untuk menampilkan detail resep
        public void TampilDetailResep(DataGridView dataGrid, string idResep)
        {
            string query = @"
            SELECT 
                dr.id_detail AS 'ID Detail',
                dr.id_resep AS 'ID Resep',
                dr.id_obat AS 'ID Obat',
                s.nama_obat AS 'Nama Obat',
                dr.jumlah AS 'Jumlah',
                dr.dosis AS 'Dosis'
            FROM detail_resep dr
            JOIN stok_obat s ON dr.id_obat = s.id_obat
            WHERE dr.id_resep = @id_resep";

            try
            {
                using (MySqlConnection conn = connection.GetConn())
                {
                 
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_resep", idResep);

                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGrid.DataSource = dt; // Mengisi DataGridView dengan data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode untuk menghapus detail resep
        public void HapusDetailResep(string idDetailResep)
        {
            if (string.IsNullOrEmpty(idDetailResep))
            {
                MessageBox.Show("ID Detail Resep tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM detail_resep WHERE id_detail = @id_detail";

            try
            {
                using (MySqlConnection conn = connection.GetConn())
                {

                    conn.Close();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_detail", idDetailResep);

                    var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus detail resep dengan ID: {idDetailResep}?",
                                                  "Konfirmasi Hapus",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data detail resep berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data detail resep tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus detail resep: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}


