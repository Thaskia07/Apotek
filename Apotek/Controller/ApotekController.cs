using Apotek.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek.Controller
{
    internal class ApotekController : Model.Connection
    {
       Connection koneksi = new Connection();

        public DataTable getList(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            cmd.Connection = koneksi.GetConn();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public void tambahUser(string id, string user, string pass)
        {
            string tambah = "INSERT INTO ADMIN(id,username,password) VALUES (@id,@username,@password)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(tambah, koneksi.GetConn());
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;
                cmd.ExecuteNonQuery();

                MessageBox.Show("data user berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal: " + ex.Message);
            }
        }

        //fungsi loginuser : periksa username dan password di database 
        public bool LoginUser(string username, string password) 
        {
            string query = "SELECT COUNT(*) FROM ADMIN WHERE username =@username AND password =@password";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //EKSEKUSI QUERY DAN CEK HASILNYA
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; //jika ada data yang cocok, login berhasil
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error saat login:" + ex.Message);
                return false;

            }
        }

        }

      

    }


