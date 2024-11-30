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
    public partial class DataKaryawan : Form
    {
        private KaryawanController karyawanController;
        public DataKaryawan()
        {
            karyawanController = new KaryawanController();
            InitializeComponent();
        }

        private void DataKaryawan_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            TampilDataKaryawan();
        }

        private void TampilDataKaryawan()
        {
            KaryawanController karyawanController = new KaryawanController();
            dtKaryawan.DataSource = karyawanController.TampilKaryawan(); // Tampilkan data ke DataGridView
        }


        private void BtnAddKaryawan_Click_1(object sender, EventArgs e)
        {
            AddKaryawan addKaryawan = new AddKaryawan();
            addKaryawan.Show();
            this.Hide();
        }

        private void BtnDeleteKaryawan_Click_1(object sender, EventArgs e)
        {
            DeleteKaryawan deleteKaryawan = new DeleteKaryawan();
            deleteKaryawan.Show();
            this.Hide();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Tampilan tampilan = new Tampilan();
            tampilan.Show();
            this.Hide(); // Hanya menyembunyikan form saat ini
        }
    }
    }

