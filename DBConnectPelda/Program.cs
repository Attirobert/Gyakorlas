using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using GetDBConnection;

namespace DBConnectPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = DBConnectionsClass.GetConnectionString("MyDbConnection");

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
    }
}
