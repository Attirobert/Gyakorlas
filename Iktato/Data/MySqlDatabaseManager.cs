using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktato
{
    public class MySqlDatabaseManager
    {
        private MySqlConnection connection;

        private string connectionString;

        public MySqlDatabaseManager(string server, string database, string uid, string password)
        {
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

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

        public DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        public int ExecuteNonQuery(string query)
        {
            int result = 0;

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public void FillDataGridView(DataGridView dgv, string query)
        {
                dgv.DataSource = GetDataTable(query); 
        }


    }
}
