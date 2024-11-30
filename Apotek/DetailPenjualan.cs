using Apotek.Controller;
using Apotek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Apotek
{
    public partial class DetailPenjualan : Form
    {
         private Connection dbConnection;


        public DetailPenjualan()
        {
           
            InitializeComponent();
            dbConnection = new Connection(); // Inisialisasi dbConnection N

        }


        private void DetailPenjualan_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            TampilDetailPenjualan(); // Tampilkan data saat form dimuat

        }

        private void TampilDetailPenjualan()
        {
            string query = @"
                SELECT dp.id_detail_penjualan, dp.id_penjualan, dp.id_obat, dp.jumlah, dp.subtotal, o.nama_obat 
                FROM detail_penjualan dp
                JOIN stok_obat o ON dp.id_obat = o.id_obat";

            try
            {
                using (MySqlConnection conn = dbConnection.GetConn())
                {
                    if (conn != null)
                    {
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // Mengisi data ke DataTable
                        dtDetailPenjualan.DataSource = dataTable;
                        dtDetailPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        MessageBox.Show("Gagal terhubung ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Kesalahan koneksi database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan detail penjualan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void BtnDetailPenjualan_Click_1(object sender, EventArgs e)
        {
            CatatanPenjualan catatanPenjualan = new CatatanPenjualan();
            catatanPenjualan.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            Penjualan penjualan = new Penjualan();
            penjualan.Show();
        }

        private void dtDetailPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
