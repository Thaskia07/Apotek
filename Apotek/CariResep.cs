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
    public partial class CariResep : Form
    {
        private ResepController resepController;


        public CariResep()
        {
            resepController = new ResepController();
            InitializeComponent();
        }


        private void CariResep_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            
        }

        public void SetData(DataTable data)
        {
            dtCariPasien.DataSource = data; // Mengatur data ke DataGridView
            dtCariPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Mengatur ukuran kolom otomatis
        }


        private void BtnCariResep_Click_1(object sender, EventArgs e)
        {

            Pencarian pencarian = new Pencarian();
            pencarian.Show();
            this.Hide();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {

            ResepObat resepObat = new ResepObat();
            resepObat.Show();
            this.Hide(); // Hanya menyembunyikan form saat ini
        }
    }
}
