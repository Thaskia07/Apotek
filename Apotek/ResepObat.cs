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
    public partial class ResepObat : Form
    {
        private ResepController resepController;
        public ResepObat()
        {
            resepController = new ResepController();
            InitializeComponent();
        }

      

        private void ResepObat_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            TampilDataPasien();
        }


        private void TampilDataPasien()
        {
            dtResepObat.DataSource = resepController.TampilPasien();
            dtResepObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tampilan tampilan = new Tampilan();
            tampilan.Show();
            this.Hide(); // Hanya menyembunyikan form saat ini
        }

      

     

        private void BtnAddPasien_Click_1(object sender, EventArgs e)
        {
            Pasien pasien = new Pasien();
            pasien.Show();
            this.Hide();
        }

        private void BtnCariResep_Click_1(object sender, EventArgs e)
        {
            CariResep cariResep = new CariResep();
            cariResep.Show();
            this.Hide();
        }

        private void BtnDetailResep_Click_1(object sender, EventArgs e)
        {

            DetailResep detailResep = new DetailResep();
            detailResep.Show();
            this.Hide();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Tampilan tampilan = new Tampilan();
            tampilan.Show();
            this.Hide();
        }
    }
}
