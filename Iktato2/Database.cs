using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using GetDBConnection;

namespace Iktato2
{
    internal class Database 
    { 
        public MySqlConnection mySqlConnection = new MySqlConnection(DBConnectionsClass.GetConnectionString_1("MyDbConnection"));

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
            if (mySqlConnection != null & mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
