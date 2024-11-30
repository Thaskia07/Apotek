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
    public partial class AddObat : Form
    {
        public AddObat()
        {
           
            InitializeComponent();
        }

     


        private void AddObat_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            //ambil data dari input user 
            string idObat = txtIdObat.Text;
            string namaObat = txtNamaObat.Text;
            string kategori = txtKategori.Text;
            string jumlahText = txtJumlah.Text;
            string hargaText = txtHarga.Text;

            //validasi id obat
            if (!Validasi.ValidasiIdStok(idObat)) return;

            //validasi nama obat
            if (!Validasi.ValidasiNamaObat(namaObat)) return;

            // validasi kategori
            if (!Validasi.ValidasiKategori(kategori)) return;

            //validasi jumlah
            if (!Validasi.ValidasiJumlah(jumlahText)) return;

            //validasi harga
            if (!Validasi.ValidasiHarga(hargaText)) return;


            //konversi jumlah dan harga
            int jumlah = int.Parse(jumlahText);
            decimal harga = decimal.Parse(hargaText);

            //panggil metode tambahObat untuk meyimpan data obat ke database
            StokController stokController = new StokController();
            stokController.TambahObat(idObat, namaObat, kategori, jumlah, harga);

            ManajemenStokObat manajemenStokObat = new ManajemenStokObat();
            manajemenStokObat.Show();
            this.Hide();

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
                this.Hide(); 
                ManajemenStokObat manajemenStokObat = new ManajemenStokObat();
                manajemenStokObat.Show();

            }
        }
    }
}