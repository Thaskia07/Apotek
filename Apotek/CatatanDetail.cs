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
    public partial class CatatanDetail : Form
    {
        public CatatanDetail()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string idResep = txtIdResep.Text; // Ambil ID Resep dari input pengguna
            string idObat = txtIdObat.Text; // Ambil ID Obat
            int jumlah = 0;
            string dosis = txtDosis.Text; // Ambil Dosis dari input pengguna

            // Validasi ID Resep
            if (string.IsNullOrWhiteSpace(idResep))
            {
                MessageBox.Show("ID Resep tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Jumlah harus berupa angka positif!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi dosis
            if (string.IsNullOrWhiteSpace(dosis))
            {
                MessageBox.Show("Dosis tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil controller untuk menyimpan data
            ResepController controller = new ResepController();
            controller.TambahDetailResep(idResep, idObat, jumlah, dosis);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        { // Ambil ID detail resep dari input pengguna
            string idDetailResep = txtIdDetail.Text; // ID Detail Resep dari input pengguna

            // Validasi ID Detail Resep
            if (string.IsNullOrWhiteSpace(idDetailResep))
            {
                MessageBox.Show("ID Detail Resep tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Panggil controller untuk menghapus detail resep
                ResepController controller = new ResepController();
                controller.HapusDetailResep(idDetailResep);

                // Berikan informasi keberhasilan
                MessageBox.Show("Detail resep berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh tampilan data atau kembali ke form DetailResep
                this.Hide();
                DetailResep detailResep = new DetailResep();
                detailResep.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            DetailResep detailResep = new DetailResep();
            detailResep.Show();
        }
    }
}
