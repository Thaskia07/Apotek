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
    public partial class DeleteObat : Form
    {
        public DeleteObat()
        {
            InitializeComponent();
        }

        private void DeleteObat_Load(object sender, EventArgs e)
        {

        }


        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string idObat = txtIdObat.Text.Trim(); // Ambil input ID Obat

            // Validasi input ID Obat
            if (string.IsNullOrEmpty(idObat))
            {
                MessageBox.Show("ID Obat tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi penghapusan
            var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus obat dengan ID: {idObat}?",
                                          "Konfirmasi Hapus",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Panggil metode delete di StokController
                    StokController stokController = new StokController();
                    stokController.DeleteStok(idObat); // Menghapus obat berdasarkan ID

                    // Bersihkan input setelah berhasil
                    txtIdObat.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            // Menampilkan konfirmasi sebelum kembali
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin kembali?",
                                                 "Konfirmasi Kembali",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                ManajemenStokObat manajemenStokObat = new ManajemenStokObat();
                manajemenStokObat.Show();
            }
        }
    }
}
