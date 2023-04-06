using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambdaTutorialHu
{
    internal class Program
    {
        #region Alapadatok
        struct Pelda
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        struct Pelda2
        {
            public int Y { get; set; }
            public int Z { get; set; }
        }

        static void Main(string[] args)
        {
            var elemek = new List<Pelda>
            {
                new Pelda { X = 10, Y = 20 },
                new Pelda { X = 11, Y = 23 },
                new Pelda { X = 44, Y = 42 },
                new Pelda { X = 7, Y = 1 },
                new Pelda { X = 9, Y = 12 },
            };

            var elemek2 = new List<Pelda2>
            {
                new Pelda2 { Z = 88, Y = 20 },
                new Pelda2 { Z = 14, Y = 23 },
                new Pelda2 { Z = 63, Y = 42 },
                new Pelda2 { Z = 11, Y = 1 },
                new Pelda2 { Z = 4, Y = 12 },
            };
        #endregion Alapadatok

            #region Kiválasztás
            // LINQ szintaxissal
            var linqSelect = from elem in elemek
                             select elem.X;

            //ugyan ez, lambda szintaxissal:
            var lambdaSelect = elemek.Select(i => i.X);

            foreach (var item in linqSelect)
                Console.WriteLine(item);

            #endregion Kiválasztás

            #region Projekció (leképezés)
            // LINQ szintaxissal
            var linqProj = from elem in elemek
                           select new
                           {
                               X2 = elem.X * 2,
                               Y2 = elem.Y * 2
                           };

            //ugyan ez, lambda szintaxissal:
            var lambdaProj = elemek.Select(i => new
            {
                X2 = i.X * 2,
                Y2 = i.Y * 2
            });

            foreach (var item in linqProj)
                Console.WriteLine("{0}, {1}", item.X2, item.Y2);
            #endregion Projekció (leképezés)

            #region Szűrés
            var linqSzures = from elem in elemek
                             where elem.X > 10
                             select elem.X;

            //ugyan ez, lambda szintaxissal:
            var lambdaSzures = elemek.Where(i => i.X > 10).Select(i => i.X);

            foreach (var item in linqSzures)
                Console.WriteLine(item);

            #endregion Szűrés

            #region Rendezés
            var linqOrder = from elem in elemek
                            orderby elem.X ascending
                            select elem;

            //ugyan ez, lambda szintaxissal:
            var lambdaOrder = elemek.OrderBy(i => i.X);

            foreach (var item in linqOrder)
                Console.WriteLine("{0}, {1}", item.X, item.Y);

            #endregion Rendezés

            #region JOIN
            var linqJoin = from elem in elemek
                           join elem2 in elemek2 on
                                          elem.Y equals elem2.Y
                           select new
                           {
                               X = elem.X,
                               Y = elem.Y,
                               Z = elem2.Z
                           };

            //ugyan ez, lambda szintaxissal:
            var lambdaJoin = elemek.Join(elemek2, i => i.Y, j => j.Y, (i, j) => new
            {
                X = i.X,
                Y = i.Y,
                Z = j.Z
            });

            foreach (var item in linqJoin)
                Console.WriteLine("{0}, {1}, {2}", item.X, item.Y, item.Z);

            #endregion JOIN

            #region Csoportosítás
            var linqGroup = from elem in elemek
                            group elem
                            by elem.Y into csoport
                            select csoport;

            //ugyan ez, lambda szintaxissal:
            var lambdaGroup = elemek.GroupBy(i => i.Y);

            foreach (var group in linqGroup)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                    Console.WriteLine("{0}, {1}", item.X, item.Y);
            }

            #endregion Csoportosítás

            #region Kiválasztás
            /* Első elem: First() - ha nincs, hibát dob
             *            FirstOrDefault() - ha nincs, akkor az alapértelmezett értéket adja vissza
             *            
             * Utolsó elem: Last(), LastOrDefault(): hasonló az előzőhöz
             * 
             * Megadott sorszámú elem: ElementAt() - ha nincs, hibát dob
             *            ElementAtOrDefault() - ha nincs, akkor az alapértelmezett értéket adja vissza
             * 
             * .NET 6 óta 2. paraméterként megadható a visszatérési érték a default helyett 
             * var alap = new Pelda { X = int.MaxValue, Y = int.MaxValue };

                //alap változó értékét adja vissza, mivel nincs ilyen a listában
                var eredmeny4 = elemek.FirstOrDefault(i => i.Y == 99, alap);

                //szintén alap változó értékét adja vissza, mivel nincs ilyen a listában
                var eredmeny5 = elemek.LastOrDefault(i => i.Y == 99, alap);
             */

            //egy olyan Pelda objektum lesz, amiben X = 0, Y = 0
            //mivel nincs ilyen a listában 
            var eredmeny = elemek.FirstOrDefault(i => i.Y == 99);

            //Pelda { X = 7, Y = 1 } objektum lesz
            var eredmeny2 = elemek.Last(i => i.Y == 1);

            //Pelda { X = 44, Y = 42 }, objektum lesz, mivel ő a 2. indexel rendelkező
            var eredmeny3 = elemek.ElementAt(2);

            #endregion Kiválasztás

            #region Distinct
            //olyan IEnumerable<Pelda> lesz, amiben minden Pelda 
            //egyedi X értékkel rendelkezik ismétlődés nélkül
            var egyediX = elemek.Distinct();

            // .NET 6 óta lehetőségünk van egy objektum bizonyos tulajdonsága alapján az ismétlődések kiszűrésére a DistinctBy művelettel. Ennek egy lambda kifejezést kell megadnunk, ami alapján egyedi értékekre vagyunk kíváncsiak.
            // var egyediX = elemek.DistinctBy(i => i.X);

            #endregion Distinct

            #region Aggregáció
            //Összes elem számának meghatározása
            var osszes = elemek.Count();
            //Összes olyan elem számának meghatározása, ahol x páros
            var parosx = elemek.Count(i => i.X % 2 == 0);

            //X maximumának meghatározása, értéke 44
            var MaxX = elemek.Max(i => i.X);
            //Y minimumának meghatározása, értéke 1
            var MinY = elemek.Min(i => i.Y);
            //Átlag terület meghatározása
            var avg = elemek.Average(i => i.Y * i.X);

            /* .NET 6. 
             * //Pelda 
                var Max = elemek.MaxBy(i => i.X); // Max = { X = 44, Y = 42 } objektum
                //Pelda
                var Min = elemek.MinBy(i => i.Y);   // Min =  { X = 7, Y = 1 } objektum
             */
            #endregion Aggregáció

            #region Konvertáló metódusok
            /* ToArray(); ToList(); ToDictionary()
            class Kontakt
                {
                    public string Nev { get; set; }
                    public int Telefonszam { get; set; }
                }
            kontaktok: Kontakt típusokat tartalmazólista.  Ebből készítünk szótárt
            var dictionary = kontaktok.ToDictionary(x => x.Nev, x => x.Telefonszam);
            */
            #endregion Konvertáló metódusok

            #region Halmaz műveletek
            // Elemi típusokon
            // Alapadatok
            int[] ints1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
            int[] ints2 = { 8, 3, 6, 4, 4, 9, 1, 0 };

            // Két halmaz elemei ismétlődések nélkül: 5,3,9,7,8,6,4,1,0
            IEnumerable<int> union = ints1.Union(ints2);
            // Az első halmaz azon elemei, amelyek szerepelnek a második halmazban is, ismétlődések nélkül: 3,9
            IEnumerable<int> intersect = ints1.Intersect(ints2);
            // Az első halmaz azon elemei, amelyek nem szerepelnek a második halmazban, ismétlődések nélkül: 5,7
            IEnumerable<int> except = ints1.Except(ints2);

            /*
             * .NET 6 óta lehetőségünk van a IntersectBy és a UnionBy műveletek használatára is. Ezek kifejezetten hasznosak összetett típusok alapján, mivel egy lamda kifejezéssel mondhatjuk meg, hogy mi alapján szeretnénk uniót vagy metszetet képezni.

                struct Pelda
                {
                    public int X { get; set; }
                    public int Y { get; set; }
                }

                var elemek = new List<Pelda>
                {
                    new Pelda { X = 10, Y = 20 },
                    new Pelda { X = 11, Y = 23 },
                };

                var elemek2 = new List<Pelda>
                {
                    new Pelda { X = 10, Y = 12 },
                    new Pelda { X = 44, Y = 20 },
                };

                // {10, 20}, {11, 23}, {44, 20}
                var union = elemek.UnionBy(elemek2, x => x.X);
                //szintén helyes:
                var union2 = elemek.UnionBy(elemek2, x => x.X > 5);

                // {10, 20}
                var intersect = elemek.IntersectBy(elemek2.Select(x => x.X), x => x.X);
                // {11, 23}
                var except = elemek.ExceptBy(elemek2.Select(x => x.X), x => x.X);
                Az IntersectBy és a ExceptBy metódusok definíciói eltérnek a UnionBy által használttól. Ennek okai abban keresendők, hogy az unió csak azonos típusok esetén működik, míg a metszet és különbség két különböző típus alapján is működhet. Ezért kell a IntersectBy és a ExceptBy esetén az első kollekció elemeinek megfeleltethetőnek kell lenniük a második kollekcó elemeinek.
             */

            // Összefűzés; elemi adattípusoknál
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };

            // 1, 2, 3, 4, 5, 6
            var result = a.Concat(b);

            // Szeletelés
            int[] az = { 1, 2, 3, 4 };
            #endregion Halmaz műveletek

            Console.ReadKey();
        }
    }
}
