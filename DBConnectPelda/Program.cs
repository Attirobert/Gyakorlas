using System;
using MySql.Data.MySqlClient;
using GetDBConnection;

namespace DBConnectPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = DBConnectionsClass.GetConnectionString_1("MyDbConnection");
            string connectionString = DBConnectionsClass.GetConnectionString_2();

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
