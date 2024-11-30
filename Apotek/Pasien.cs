using Apotek.Controller;
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
    public partial class Pasien : Form
    {
        public Pasien()
        {
            InitializeComponent();
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Menampilkan konfirmasi untuk kembali
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
                ResepObat resepObat = new ResepObat(); // Ganti dengan form yang sesuai
                resepObat.Show();
            }


        }

        private void BtnAddPasien_Click_1(object sender, EventArgs e)
        {

            // Ambil data dari input user
            string idPasien = txtIdPasien.Text;
            string namaPasien = txtNamaPasien.Text;
            string alamatPasien = txtAlamat.Text;
            string telponPasien = txtTelpon.Text;

            // Validasi ID Pasien
            if (!Validasi.ValidasiIdPasien(idPasien)) return;

            // Validasi Nama Pasien
            if (!Validasi.ValidasiNamaPasien(namaPasien)) return;

            // Validasi Alamat Pasien
            if (!Validasi.ValidasiAlamat(alamatPasien)) return;

            // Validasi Telpon Pasien
            if (!Validasi.ValidasiTelepon(telponPasien)) return;

            // Panggil metode TambahPasien untuk menyimpan data pasien ke database
            ResepController resepController = new ResepController();
            resepController.TambahPasien(idPasien, namaPasien, alamatPasien, telponPasien);

            // Setelah berhasil, buka form ManajemenPasien
            ResepObat resepObat = new ResepObat();
            resepObat.Show();
            this.Hide();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            ResepObat resepObat = new ResepObat();
            resepObat.Show();
        }
    }
}
