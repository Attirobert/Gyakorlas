using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Projekt neve: TobbElem
Írjunk olyan programot, amely addig kér be egész számokat a billentyűzetről, 
amíg azok összege meg nem haladja a 100-at. 
A beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt páratlan.
 */

namespace TobbElem
{
    class ParosPlan
    {
        public ParosPlan()
        {
        }

        public bool Paros(int s)
        {

            return s%2 == 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Változók
            int beSzam = 0, // Ebbe konvertáljuk a konzolról beolvasott számot
                paros = 0, // Páros számok gyüjtője
                plan = 0, // Páratlan számok gyüjtője
                hatar = 100;    // A számok bekérésének határértéke

            // Osztály példányosítása ( Objektum létrehozása
            ParosPlan pp = new ParosPlan();

            while (paros+plan < hatar)
            {
                Console.WriteLine("Adjon meg egy egész számot");
                try
                {
                    beSzam = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hiba: " + e.Message);
                }

                if (pp.Paros(beSzam)) paros += beSzam;
                else plan += beSzam;
            }

            // Záró műveletek
            Console.WriteLine($"Páros számok összege: {paros}");
            Console.WriteLine("Páratlan számok összege: {0}", plan);
            Console.ReadKey();
        }
    }
}
