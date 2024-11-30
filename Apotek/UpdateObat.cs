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
    public partial class UpdateObat : Form
    {
        public UpdateObat()
        {
            InitializeComponent();
            txtIdObat.PasswordChar = '*';
        }

 
        private void UpdateObatData()
        { // Ambil data dari input pengguna
            string idObat = txtIdObat.Text.Trim();
            string namaObat = txtNamaObat.Text.Trim();
            string kategori = txtKategori.Text.Trim();
            string jumlahText = txtJumlah.Text.Trim();
            string hargaText = txtHarga.Text.Trim();

            // Lakukan validasi menggunakan kelas Validasi
            if (!Validasi.ValidasiIdStok(idObat) ||
                !Validasi.ValidasiNamaObat(namaObat) ||
                !Validasi.ValidasiKategori(kategori) ||
                !Validasi.ValidasiJumlah(jumlahText) ||
                !Validasi.ValidasiHarga(hargaText))
            {
                // Jika salah satu validasi gagal, hentikan proses
                return;
            }

            // Konversi jumlah dan harga karena validasi sudah memastikan formatnya valid
            int jumlah = int.Parse(jumlahText);
            decimal harga = decimal.Parse(hargaText);

            try
            {
                // Panggil metode update di controller
                StokController stokController = new StokController();
                bool isUpdated = stokController.UpdateStok(idObat, jumlah, namaObat, kategori, harga);

                if (isUpdated)
                {
                    MessageBox.Show("Data stok obat berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Bersihkan input dan kembali ke form sebelumnya
                    ClearForm();
                    this.Hide();
                    ManajemenStokObat manajemenStok = new ManajemenStokObat();
                    manajemenStok.Show();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data stok. Pastikan ID Obat benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            txtIdObat.Clear();
            txtNamaObat.Clear();
            txtKategori.Clear();
            txtJumlah.Clear();
            txtHarga.Clear();
        }



        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateObatData();
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
                ManajemenStokObat manajemenStokObat = new ManajemenStokObat(); // Form untuk kembali
                manajemenStokObat.Show();
            }
        }

    }
}
