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
    public partial class Pencarian : Form
    {
        private readonly ResepController resepController;
        public Pencarian()
        {
            InitializeComponent();
            resepController = new ResepController(); // Instance dari ResepController
        }



        private void BtnCari_Click_1(object sender, EventArgs e)
        {
            // Ambil data input dari pengguna
            string idResep = txtIdResep.Text.Trim();
            string idPasien = txtIdPasien.Text.Trim();

            // Validasi ID Resep atau ID Pasien
            if (string.IsNullOrEmpty(idResep) && string.IsNullOrEmpty(idPasien))
            {
                MessageBox.Show("Masukkan ID Resep atau ID Pasien untuk melakukan pencarian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi ID Resep
            if (!string.IsNullOrEmpty(idResep) && !Validasi.ValidasiIdResep(idResep))
            {
                return;
            }

            // Validasi ID Pasien
            if (!string.IsNullOrEmpty(idPasien) && !Validasi.ValidasiIdPasien(idPasien))
            {
                return;
            }

            // Buat instance form CariResep
            CariResep cariResep = new CariResep();

            try
            {
                DataTable hasilPencarian;

                // Cari berdasarkan ID Resep atau ID Pasien
                if (!string.IsNullOrEmpty(idResep))
                {
                    hasilPencarian = resepController.CariResepById(idResep);
                }
                else
                {
                    hasilPencarian = resepController.CariResepByPasien(idPasien);
                }

                // Jika hasil pencarian ditemukan, tampilkan di form CariResep
                if (hasilPencarian.Rows.Count > 0)
                {
                    cariResep.SetData(hasilPencarian); // Kirim data ke form CariResep
                    cariResep.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data resep tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            CariResep cariResep = new CariResep();
            cariResep.Show();
            this.Hide();
        }
    }
 }

