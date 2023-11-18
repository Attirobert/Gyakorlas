using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDBConnection
{
    // Ez a library és a tartalmazott osztály és metódus(ok) az alkalmazás-független adatbázis kapcsolat kezelésének példája
    public class DBConnectionsClass
    {
        public static string GetConnectionString(string connectionName)
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

    }
}
