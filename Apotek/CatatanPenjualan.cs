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
    public partial class CatatanPenjualan : Form
    {
        public CatatanPenjualan()
        {
            InitializeComponent();
        }

        private void BtnAddPenjualan_Click_1(object sender, EventArgs e)
        {
            string idPenjualan = txtIdDetailPenjualan.Text; // Ambil ID dari input pengguna
            string idObat = txtIdObat.Text; // Ambil ID Obat
            int jumlah = 0;
            decimal subtotal = 0;



            // Validasi ID Penjualan
            if (string.IsNullOrWhiteSpace(idPenjualan))
            {
                MessageBox.Show("ID Penjualan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi ID Obat
            if (string.IsNullOrWhiteSpace(idObat))
            {
                MessageBox.Show("ID Obat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Validasi input jumlah
            if (!int.TryParse(txtJumlah.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka positif!",
                                "Validasi Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validasi input subtotal
            if (!decimal.TryParse(txtSubtotal.Text, out subtotal) || subtotal <= 0)
            {
                MessageBox.Show("Subtotal harus berupa angka positif!",
                                "Validasi Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Panggil controller untuk menyimpan data
            PenjualanController controller = new PenjualanController();
            controller.TambahDetailPenjualan(idPenjualan, idObat, jumlah, subtotal);

        }

        private void BtnDeleteDetail_Click(object sender, EventArgs e)
        {// Ambil ID detail penjualan dari input pengguna
            string idDetailPenjualan = txtIdDetailPenjualan.Text; // ID Detail Penjualan dari input pengguna

            // Validasi ID Detail Penjualan
            if (string.IsNullOrWhiteSpace(idDetailPenjualan))
            {
                MessageBox.Show("ID Detail Penjualan tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Panggil controller untuk menghapus detail penjualan
                PenjualanController controller = new PenjualanController();
                controller.HapusDetailPenjualan(idDetailPenjualan);

                // Berikan informasi keberhasilan
                MessageBox.Show("Detail penjualan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh tampilan data atau kembali ke form DetailPenjualan
                this.Hide();
                DetailPenjualan detailPenjualan = new DetailPenjualan();
                detailPenjualan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            DetailPenjualan detailPenjualan = new DetailPenjualan();
            detailPenjualan.Show();
        }
    }
    }

