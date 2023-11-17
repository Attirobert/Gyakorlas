using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DBConnectPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = GetConnectionString("MyDbConnection");

            if (!string.IsNullOrEmpty(connectionString))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Kapcsolódva az adatbázishoz!");

                        // Itt folytathatod az adatbázisműveleteket
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hiba történt: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nem található kapcsolati karakterlánc az App.config fájlban.");
            }

            Console.ReadLine();
        }
        static string GetConnectionString(string connectionName)
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
