using Apotek.Controller;
using Apotek.Model;
using System;
using MySqlConnector;
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
    public partial class DetailResep : Form
    {
        private readonly Connection dbConnection; // Koneksi database

        public DetailResep()
        {
            dbConnection = new Connection(); // Inisialisasi koneksi
            InitializeComponent();
        }

   
        private void DetailResep_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            TampilDetailResep();
        }

        //private void TampilDetailResep()
        //{
        //    string query = @"
        //SELECT 
        //    dr.id_detail_resep AS 'ID Detail Resep',
        //    dr.id_resep AS 'ID Resep',
        //    dr.id_obat AS 'ID Obat',
        //    o.nama_obat AS 'Nama Obat',
        //    dr.jumlah AS 'Jumlah',
        //    dr.keterangan AS 'Keterangan'
        //FROM detail_resep dr
        //JOIN stok_obat o ON dr.id_obat = o.id_obat";

        //    try
        //    {
        //        using (MySqlConnection conn = dbConnection.GetConn())
        //        {
        //            if (conn != null)
        //            {
        //                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
        //                DataTable dataTable = new DataTable();
        //                dataAdapter.Fill(dataTable);

        //                if (dataTable.Rows.Count > 0)
        //                {
        //                    dtDetailResep.DataSource = dataTable;  // Mengikat data ke DataGridView
        //                    dtDetailResep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Tidak ada data detail resep.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Gagal terhubung ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Gagal menampilkan detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void TampilDetailResep()
        {
            string query = @"
                SELECT dr.id_detail, dr.id_resep, dr.id_obat, dr.jumlah, dr.dosis, o.nama_obat 
                FROM detail_resep dr
                JOIN stok_obat o ON dr.id_obat = o.id_obat";

            try
            {
                using (MySqlConnection conn = dbConnection.GetConn())
                {
                    if (conn != null)
                    {
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable); // Mengisi data ke DataTable
                        dtDetailResep.DataSource = dataTable;
                        dtDetailResep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                MessageBox.Show("Gagal menampilkan detail resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnDetailResep_Click_1(object sender, EventArgs e)
        {
            CatatanDetail catatanDetail = new CatatanDetail();
            catatanDetail.Show();
            this.Hide();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            // Kembali ke form utama atau form sebelumnya
            this.Hide();
            ResepObat resepObat = new ResepObat();
            resepObat.Show();
        }
    }
}
