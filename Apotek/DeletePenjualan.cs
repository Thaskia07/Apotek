using Apotek.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek
{
    public partial class DeletePenjualan : Form
    {

        // Buat instance PenjualanController
        private readonly PenjualanController penjualanController = new PenjualanController();


        public DeletePenjualan()
        {
            
            penjualanController = new PenjualanController();
            InitializeComponent();
        }



        // Fungsi validasi ID Penjualan di dalam form
        private bool ValidasiIdPenjualan(string idPenjualan)
        {
            // Memastikan ID Penjualan tidak kosong
            if (string.IsNullOrWhiteSpace(idPenjualan))
            {
                MessageBox.Show("ID Penjualan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Memeriksa apakah ID Penjualan sesuai dengan format tertentu (misalnya 2 huruf + 3 angka)
            if (!Regex.IsMatch(idPenjualan, @"^[A-Za-z]{2}\d{3}$"))
            {
                MessageBox.Show("ID Penjualan harus terdiri dari 2 huruf di depan dan 3 angka di belakang (misalnya AB123).", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Jika validasi berhasil
        }




      


        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string idPenjualan = txtIdPenjualan.Text;

            // Validasi ID Penjualan sebelum melanjutkan
            if (!ValidasiIdPenjualan(idPenjualan))
            {
                return; // Jika validasi gagal, hentikan proses
            }

            // Lanjutkan proses hapus jika validasi berhasil
            // Misalnya, panggil metode untuk menghapus penjualan di controller
            PenjualanController penjualanController = new PenjualanController();
            penjualanController.HapusPenjualan(idPenjualan);
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            Penjualan penjualan = new Penjualan();
            penjualan.Show();
        }
    }
    }
    

