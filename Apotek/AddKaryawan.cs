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
    public partial class AddKaryawan : Form
    {
        public AddKaryawan()
        {
            InitializeComponent();
        }

        private void BtnAddDataKaryawan_Click_1(object sender, EventArgs e)
        {

            // Ambil data dari input user
            string idKaryawan = txtIdKaryawan.Text;
            string namaKaryawan = txtNamaKaryawan.Text;
            string jabatan = txtJabatan.Text;
            string alamatKaryawan = txtAlamat.Text;
            string teleponKaryawan = txtNoTelp.Text;
            string gaji = txtGaji.Text;
            string tanggalMasuk = txtTglMasuk.Text;

            // Validasi data input
            if (!Validasi.ValidasiIdKaryawan(idKaryawan)) return;
            if (!Validasi.ValidasiNamaObat(namaKaryawan)) return;
            if (!Validasi.ValidasiKategori(jabatan)) return;
            if (!Validasi.ValidasiAlamat(alamatKaryawan)) return;
            if (!Validasi.ValidasiTelepon(teleponKaryawan)) return;
            if (!Validasi.ValidasiGaji(gaji)) return;
            if (!Validasi.ValidasiTanggalMasuk(tanggalMasuk)) return;

            try
            {
                decimal decimalGaji = decimal.Parse(gaji);
                DateTime dateTanggalMasuk = DateTime.Parse(tanggalMasuk);

                KaryawanController controller = new KaryawanController();
                controller.TambahKaryawan(idKaryawan, namaKaryawan, jabatan, alamatKaryawan, teleponKaryawan, decimalGaji, dateTanggalMasuk);

                MessageBox.Show("Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataKaryawan dataKaryawan = new DataKaryawan();
            dataKaryawan.Show();
            this.Hide();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            DataKaryawan dataKaryawan = new DataKaryawan();
            dataKaryawan.Show();
        }

      
    }
}
