using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan10.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter ad;
        public MySqlConnection conn;

        public MySqlConnection getcon()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=db_contoh";

            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal " + ex.Message);
            }
            return conn;
        }
    }
}
