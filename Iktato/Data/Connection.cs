using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktato.Data
{
    internal class Connection
    {
        private MySqlConnection connection;

        private string server, 
            database,
            uid,
            password;

        public void Initialize()
        {
            server = "127.0.0.1"; 
            database = "iktato"; 
            uid = "root"; 
            password = ""; 
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void FillDataGridView(DataGridView dgv)
        {
            string query = "SELECT * FROM yourTableName"; // helyettesítsd a tábla nevével

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgv.DataSource = dataTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
