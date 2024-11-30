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
    public partial class Penjualan : Form
    {
        private PenjualanController penjualanController;
        public Penjualan()
        {
            penjualanController = new PenjualanController();
            InitializeComponent();
        }

      

        private void Penjualan_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            TampilDataPenjualan();
        }

        private void TampilDataPenjualan()
        {
            dtPenjualan.DataSource = penjualanController.TampilPenjualan();
            dtPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

     

        private void BtnPenjualan_Click_1(object sender, EventArgs e)
        {

            DataPenjualan dataPenjualan = new DataPenjualan();
            dataPenjualan.Show();
            this.Hide();
        }

        private void BtnDetailPenjualan_Click_1(object sender, EventArgs e)
        {
            DetailPenjualan detailPenjualan = new DetailPenjualan();
            detailPenjualan.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Tampilan tampilan = new Tampilan();
            tampilan.Show();
            this.Hide();
        }
    }
}
