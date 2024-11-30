using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek
{
    public partial class Tampilan : Form
    {
        public Tampilan()
        {
            InitializeComponent();
        }

        private void btnDataKaryawan_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka form DataKaryawan
                DataKaryawan dataKaryawan = new DataKaryawan();

                // Mengatur properti Owner jika Anda ingin kembali ke form Tampilan nanti
                dataKaryawan.Owner = this; // Menandakan bahwa form Tampilan adalah pemilik form DataKaryawan

                // Menampilkan form DataKaryawan sebagai form baru
                dataKaryawan.Show();

                // Menyembunyikan form Tampilan
                this.Hide();
            }
            catch (Exception ex)
            {
                // Menangani error saat membuka form
                MessageBox.Show("Terjadi kesalahan saat membuka form DataKaryawan: " + ex.Message,
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }




        private void BtnPenjualan_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka form Penjualan
                Penjualan penjualanForm = new Penjualan();  // Membuat objek form Penjualan
                penjualanForm.Show();  // Menampilkan form Penjualan
                this.Hide();  // Menyembunyikan form Tampilan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka form Penjualan: " + ex.Message,
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void BtnResep_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka form ManajemenStokObat
                ResepObat resepObat = new ResepObat();
                resepObat.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka form: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnManajemenObat_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka form ManajemenStokObat
                ManajemenStokObat manajemenStokObat = new ManajemenStokObat();
                manajemenStokObat.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka form: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnDataKaryawan_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Membuka form DataKaryawan
                DataKaryawan dataKaryawan = new DataKaryawan();

                // Mengatur properti Owner jika Anda ingin kembali ke form Tampilan nanti
                dataKaryawan.Owner = this; // Menandakan bahwa form Tampilan adalah pemilik form DataKaryawan

                // Menampilkan form DataKaryawan sebagai form baru
                dataKaryawan.Show();

                // Menyembunyikan form Tampilan
                this.Hide();
            }
            catch (Exception ex)
            {
                // Menangani error saat membuka form
                MessageBox.Show("Terjadi kesalahan saat membuka form DataKaryawan: " + ex.Message,
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
              "Apakah Anda yakin ingin kembali ke menu sebelumnya?",
              "Konfirmasi Keluar",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            // Jika pengguna memilih Yes, kembali ke form sebelumnya
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Sembunyikan form saat ini
                Form1 loginForm = new Form1(); // Contoh: Form1 adalah form Sign In/Sign Up
                loginForm.Show();

            }
        }
    }
}

