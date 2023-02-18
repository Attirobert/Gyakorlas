﻿using System;
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
            // írjuk ki az eredményt.
            // Csak ekkor számítódik ki az eredmény!
            Console.WriteLine("*********************");
            Console.WriteLine("Késleltetett futtatás");
            Console.WriteLine("*********************");
            Console.WriteLine("Explicit típus megadással");
            foreach (string s in subset)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

            Console.WriteLine("Implicit típus megadással");
            foreach (string s in subset2)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();


            /* Azonnali futtatás */
            // Az eredményhalmaz már a deklarációkor létre jön.
            Console.WriteLine("*********************");
            Console.WriteLine("Azonnali futtatás");
            Console.WriteLine("*********************");

            string[] subset3 = (from g in currentvideoGames where g.Length > 6 orderby g select g).ToArray();

            Console.WriteLine("Explicit típus megadással");
            foreach (string s in subset3)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

            List<string> subset4 = (from g in currentvideoGames where g.Length > 6 orderby g select g).ToList<string>();

            Console.WriteLine("Explicit típus megadással: List<string>");
            foreach (string s in subset4)
                Console.WriteLine("Játék: {0}", s);
            Console.WriteLine();

        }
    }

}
