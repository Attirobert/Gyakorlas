using System;
using System.Configuration;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlConnectionStringBuilder = System.Data.SqlClient.SqlConnectionStringBuilder;

namespace GetDBConnection
{
    // Ez a library és a tartalmazott osztály és metódus(ok) az alkalmazás-független adatbázis kapcsolat kezelésének példája
    public class DBConnectionsClass
    {
        public static string GetConnectionString_1(string connectionName)
        {
            try
            {
                // Az App.config-ban megadott kapcsolati karakterlánc elérése
                string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

                // Az adatbázis jelszót érdemes lehet elrejteni biztonságosabb módon, például titkosítással
                // connectionString = DecryptConnectionString(connectionString);

                return connectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                return null;
            }
        }

        // Ha szükséges, implementálhatjuk a kapcsolati karakterlánc titkosítását és visszafejtését
        // private static string DecryptConnectionString(string encryptedConnectionString) { ... }
        // private static string EncryptConnectionString(string plainConnectionString) { ... }

        public static string GetConnectionString_2() {
            // Az App.config-hoz kapcsolati karakterlánc létrehozása
            SqlConnectionStringBuilder cnstrBuilder = new SqlConnectionStringBuilder();
            cnstrBuilder.DataSource = ConfigurationManager.AppSettings["server"];
            cnstrBuilder.InitialCatalog = ConfigurationManager.AppSettings["database"];
            cnstrBuilder.UserID = ConfigurationManager.AppSettings["user"];
            cnstrBuilder.Password = ConfigurationManager.AppSettings["password"];

            cnstrBuilder.ConnectTimeout = 30;
            cnstrBuilder.IntegratedSecurity = true;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnstrBuilder.ConnectionString;

            return cn.ConnectionString;

        }

    }
}
