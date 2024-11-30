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
    public partial class DataPenjualan : Form
    {
        public DataPenjualan()
        {
            InitializeComponent();
        }


        // Fungsi untuk mendapatkan detail penjualan, bisa disesuaikan dengan cara Anda menangani detail penjualan (misalnya, dari DataGridView)
        private DataTable GetDetailPenjualan()
        {
            // Inisialisasi DataTable untuk menyimpan detail penjualan
            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("id_obat", typeof(string));
            dtDetail.Columns.Add("jumlah", typeof(int));
            dtDetail.Columns.Add("subtotal", typeof(decimal));

            // Misalnya, kita mendapatkan data dari DataGridView atau sumber lain
            // Berikut adalah contoh penambahan data secara manual
            dtDetail.Rows.Add("OB001", 2, 50000); // Contoh data obat dan jumlah
            dtDetail.Rows.Add("OB002", 1, 25000); // Contoh data obat dan jumlah

            return dtDetail;
        }


  

        private void BtnAddPenjualan_Click_1(object sender, EventArgs e)
        {
            // Ambil data dari input user
            string idPenjualan = txtIdPenjualan.Text;
            string idKaryawan = txtIdKaryawan.Text;
            string tanggalPenjualan = txtTglPenjualan.Text;
            string totalTransaksi = txtTotalTransaksi.Text;

            Validasi validasi = new Validasi();
            if (!validasi.ValidasiIdPenjualan(idPenjualan)) return;
            if (!Validasi.ValidasiIdKaryawan(idKaryawan)) return;
            if (!validasi.ValidasiTanggalPenjualan(DateTime.Parse(tanggalPenjualan))) return;
            if (!validasi.ValidasiTotalTransaksi(decimal.Parse(totalTransaksi))) return;


            try
            {
                decimal decimalTotalTransaksi = decimal.Parse(totalTransaksi);
                DateTime dateTanggalPenjualan = DateTime.Parse(tanggalPenjualan);

                PenjualanController controller = new PenjualanController();
                DataTable detailPenjualan = GetDetailPenjualan();  // Anda harus menambahkan logika untuk mengambil detail penjualan
                controller.TambahPenjualan(idPenjualan, idKaryawan, dateTanggalPenjualan, decimalTotalTransaksi, detailPenjualan);

                MessageBox.Show("Penjualan berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kembali ke form DataPenjualan setelah menambah data
            Penjualan penjualan = new Penjualan();
            penjualan.Show();
            this.Hide();
        }

        private void BtnDeletePenjualan_Click_1(object sender, EventArgs e)
        {

            DeletePenjualan deletePenjualan = new DeletePenjualan();
            deletePenjualan.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            Penjualan penjualan = new Penjualan();
            penjualan.Show();
        }
    }
}
