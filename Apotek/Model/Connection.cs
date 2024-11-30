using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataSet ds;
        public MySqlConnection Conn;

        public MySqlConnection GetConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;user=root;database=apotek_nakii";

            try
            {
                Conn.Open();
                return Conn;  // Mengembalikan koneksi yang terbuka
            }
            catch (Exception ex)
            {
                MessageBox.Show("koneksi gagal" + ex.Message);
                return null;  // Mengembalikan null jika koneksi gagal

            }
           
        }
        // Menutup koneksi setelah selesai digunakan
        public void CloseConn()
        {
            if (Conn != null && Conn.State == ConnectionState.Open)
            {
                Conn.Close();  // Menutup koneksi
            }
        }

    }
}
