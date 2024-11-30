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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtId.PasswordChar='*';
        }



        private void BtnSignUp_Click_1(object sender, EventArgs e)
        {

            // Ambil data dari input form
            string id = txtId.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi id, username, dan password menggunakan validasi class
            if (Validasi.ValidasiId(id) && Validasi.ValidasiUsername(username) && Validasi.ValidasiPassword(password))
            {
                // Jika validasi berhasil, lanjutkan dengan menambahkan user ke database
                ApotekController admin = new ApotekController();
                try
                {
                    // Tambahkan pengguna ke database
                    admin.tambahUser(id, username, password);

                    // Tampilkan pesan sukses
                    MessageBox.Show("Pengguna baru berhasil ditambahkan! Selamat datang, " + username,
                                    "Pendaftaran Berhasil",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Pindah ke menu selanjutnya (Tampilan)
                    this.Hide(); // Sembunyikan form saat ini
                    Tampilan tampilan = new Tampilan();
                    tampilan.Show(); // Tampilkan menu selanjutnya
                }
                catch (Exception ex)
                {
                    // Tampilkan pesan error jika terjadi kesalahan
                    MessageBox.Show("Terjadi kesalahan saat menambahkan pengguna: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("are you sure you want to exit?", "confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnSignIn_Click_1(object sender, EventArgs e)
        {
            //ambil data dari input form 
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //validasi usernmae dan password menggunaka validasi class
            if (Validasi.ValidasiUsername(username) && Validasi.ValidasiPassword(password))
            {
                ApotekController admin = new ApotekController();
                try
                {
                    //periksa apakah user dan password ada di database
                    if (admin.LoginUser(username, password))
                    {
                        MessageBox.Show("Login berhasil! selamat datang, " + username, "Login sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Tampilan tampilan = new Tampilan();
                        tampilan.Show();

                    }
                    else
                    {
                        MessageBox.Show("Login gagal! Username atau password salah.", "login gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

        