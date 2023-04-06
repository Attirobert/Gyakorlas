using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambdaTutorialHu
{
    internal class Program
    {
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
            // https://csharptutorial.hu/docs/hellovilag-hellocsharp/8-nyelvi-szolgaltatasok/linq-sorozat-es-elem-muveletek/

            #endregion Aggregáció

            // 



            Console.ReadKey();
        }
    }
}
