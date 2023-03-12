using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ megoldás *****\n");
            Queryoverstrings();
            Console.ReadLine();
        }

        static void Queryoverstrings()
        {
            // A játékok neveit tartalmazó tömbünk.
            string[] currentvideoGames = { "Morrowind", "BioShock", "Half Life 2: Episode 1", "The Darkness", "Daxter", "system shock 2"};

            /* Készítünk egy lekérdező kifejezést, amely azokat az elemeket reprezentálja a tömbben, amelyek több, mint hat betűt tartalmaznak.

            /* Késleltetett futtatás */
            // A lekérdezés csak akkor hajtódik végre, amikor felhasználásra kerül
            // Explicit típus megadással
            IEnumerable<string> subset = from g in currentvideoGames
                                         where g.Length > 6
                                         orderby g
                                         select g;

            // Implicit típus megadással
            var subset2 = from g in currentvideoGames
                                         where g.Length > 6
                                         orderby g
                                         select g;
            // Ugyanez lambda kifejezéssel
            var subsetLambda = currentvideoGames
                .Where(game => game.Length > 6)
                .OrderBy(game => game)
                .Select(game => game);


            // írjuk ki az eredményt.
            // Csak ekkor számítódik ki az eredmény!
            Console.WriteLine("*********************");
            Console.WriteLine("Késleltetett futtatás");
            Console.WriteLine("*********************");
            Console.WriteLine("Explicit típus megadással");
            foreach (string s in subset)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

            Console.WriteLine("Implicit típus megadással LINQ kifejezéssel");
            foreach (string s in subset2)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

            Console.WriteLine("Implicit típus megadással lambda kifejezéssel");
            foreach (string s in subsetLambda)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();


            /* Azonnali futtatás */
            // Az eredményhalmaz már a deklarációkor létre jön a ToArray<>(T) bővítő metódus hatására.  Ilyen metódus még a ToList<T>(), ToDictionary<TSource, TKey>().  A generikus típusokat csak akkor kell megadni, ha a fordítónak nem egyértelmű az eredmény típusa.
            Console.WriteLine("*********************");
            Console.WriteLine("Azonnali futtatás");
            Console.WriteLine("*********************");
            Console.WriteLine("Explicit típus megadással");

            Console.WriteLine("Explicit típus megadással: string[]");
            //Az adatokat pont MOST kapjuk meg egy int[] tömbbe.
            string[] subset3 = (from g in currentvideoGames where g.Length > 6 orderby g select g).ToArray();
            foreach (string s in subset3)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

            Console.WriteLine("Explicit típus megadással: List<string>");
            //Az adatokat pont MOST kapjuk meg egy List<string> listába.
            List<string> subset4 = (from g in currentvideoGames where g.Length > 6 orderby g select g).ToList<string>();
            foreach (string s in subset4)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

        }
    }

}
