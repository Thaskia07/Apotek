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
    public partial class ManajemenStokObat : Form
    {

        private StokController stokController;
        public ManajemenStokObat()
        {
            stokController = new StokController();
            InitializeComponent();
        }

       

        private void ManajemenStokObat_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            TampilDataObat();
        }

        private void TampilDataObat()
        {
            dtStok.DataSource = stokController.TampilObat();
            dtStok.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }

    
     
        private void dtStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            AddObat addObat = new AddObat();
            addObat.Show();
            this.Hide();
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateObat updateObat = new UpdateObat();
            updateObat.Show();
            this.Hide();
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteObat deleteObat = new DeleteObat();
            deleteObat.Show();
            this.Hide();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {

            Tampilan tampilan = new Tampilan();
            tampilan.Show();
            this.Hide(); // Hanya menyembunyikan form saat ini
        }
    }
}
