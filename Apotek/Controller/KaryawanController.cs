using Apotek.Controller;
using Apotek;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apotek.Model;

namespace Apotek.Controller
{
    internal class KaryawanController 
    {
        private readonly Model.Connection connection = new Model.Connection();

        public DataTable TampilKaryawan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM karyawan"; // Query untuk mengambil semua data karyawan

            try
            {
                // Membuka koneksi ke database
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt); // Mengisi DataTable dengan hasil query
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika gagal
                MessageBox.Show("Gagal menampilkan data karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Pastikan koneksi ditutup setelah digunakan
            }

            return dt; // Mengembalikan DataTable berisi data karyawan
        }


        public void TambahKaryawan(string idKaryawan, string namaKaryawan, string jabatan, string alamatKaryawan, string teleponKaryawan, decimal gaji, DateTime tanggalMasuk)
        {
            string query = "INSERT INTO karyawan (id_karyawan, nama_karyawan, jabatan, alamat_karyawan, telepon_karyawan, gaji, tanggal_masuk) " +
                           "VALUES (@id_karyawan, @nama_karyawan, @jabatan, @alamat_karyawan, @telepon_karyawan, @gaji, @tanggal_masuk)";

            try
            {
                // Membuka koneksi ke database
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Menambahkan parameter ke query
                cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);
                cmd.Parameters.AddWithValue("@nama_karyawan", namaKaryawan);
                cmd.Parameters.AddWithValue("@jabatan", jabatan);
                cmd.Parameters.AddWithValue("@alamat_karyawan", alamatKaryawan);
                cmd.Parameters.AddWithValue("@telepon_karyawan", teleponKaryawan);
                cmd.Parameters.AddWithValue("@gaji", gaji);
                cmd.Parameters.AddWithValue("@tanggal_masuk", tanggalMasuk);

                // Menjalankan query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Karyawan berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika gagal
                MessageBox.Show("Gagal menambahkan karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Menutup koneksi setelah selesai
            }
        }

        // Metode untuk menghapus karyawan berdasarkan ID Karyawan
        public void HapusKaryawan(string idKaryawan)
        {
            // Validasi ID Karyawan
            if (string.IsNullOrEmpty(idKaryawan))
            {
                MessageBox.Show("ID Karyawan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM karyawan WHERE id_karyawan = @id_karyawan";

            try
            {
                // Membuka koneksi
                MySqlConnection conn = connection.GetConn();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Tambahkan parameter ID Karyawan
                cmd.Parameters.AddWithValue("@id_karyawan", idKaryawan);

                // Konfirmasi penghapusan
                var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus karyawan dengan ID: {idKaryawan}?",
                                              "Konfirmasi Hapus",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    int rowsAffected = cmd.ExecuteNonQuery(); // Eksekusi query

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Karyawan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Karyawan tidak ditemukan atau sudah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghapus karyawan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Conn.Close(); // Tutup koneksi
            }
        }



    }
}


