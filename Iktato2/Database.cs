using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Iktato2
{
    internal class Database
    {
        static readonly string server = "127.0.0.1",
            user = "root",
            password = "",
            database="iktato";

        public static string connection_string = $"SERVER='{server}'; USER='{user}'; DATABASE='{database}'; PASSWORD='{password}'";
        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);

        public Database() { }

        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
