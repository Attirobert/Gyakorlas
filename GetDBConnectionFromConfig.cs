using System;

public class DBConnectionClass
{
	public DBConnectionClass()
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
