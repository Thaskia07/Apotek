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
    public partial class DeleteKaryawan : Form
    {
        private KaryawanController karyawanController;
        public DeleteKaryawan()
        {

            karyawanController = new KaryawanController();
            InitializeComponent();
        }

        private void DeleteKaryawan_Load(object sender, EventArgs e)
            {
                this.DoubleBuffered = true;
            }

        private void BtnDeleteKaryawan_Click_1(object sender, EventArgs e)
        {
            string idKaryawan = txtIdKaryawan.Text.Trim(); // Ambil input ID Karyawan

            // Validasi input ID Karyawan
            if (string.IsNullOrEmpty(idKaryawan))
            {
                MessageBox.Show("ID Karyawan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi penghapusan
            var confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus karyawan dengan ID: {idKaryawan}?",
                                          "Konfirmasi Hapus",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Panggil metode hapus di KaryawanController
                    KaryawanController karyawanController = new KaryawanController();
                    karyawanController.HapusKaryawan(idKaryawan);

                    // Bersihkan input setelah berhasil
                    txtIdKaryawan.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            DataKaryawan dataKaryawan = new DataKaryawan();
            dataKaryawan.Show();
        }
    }
    }

