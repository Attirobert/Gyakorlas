using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** More fun with LINQ Expressions *****\n");
            // Hozzunk létre a Car objektumok egy tömbjét.
            // Ez nem generikus gyüjtemény!
            ArrayList mycars = new ArrayList(){
            new Car
            {PetName = "Henry",
                Color = "silver",
                Speed = 100,
                Make = "BMW"},
            new Car
            {PetName = "Daisy",
                Color = "Tan",
                Speed = 90,
                Make = "BMW" },
            new Car
            {PetName = "Mary",
                Color = "Black",
                Speed = 55,
                Make = "VW" },
            new Car
            {PetName = "clunker",
                Color = "Rust",
                Speed =5,
                Make ="Yugo" },
            new Car
            {PetName = "Melvin",
                Color = "white",
                Speed= 43,
                Make ="Ford" }
            };

            // Nem Generikus gyüjtemény használata
            Console.WriteLine("Nem Generikus gyüjtemény használata");
            GetFastCars(mycars);

            Console.ReadKey();
        }

        #region Nem Generikus gyüjteményre
        static void GetFastCars(ArrayList mycars)
        {
            //Az ArrayList típust alakítsuk át egy IEnumerable<T>-kompatibilis típussá.
            IEnumerable<Car> mycarsEnum = mycars.OfType<Car>();
            // Ezután használható ugyanazok a lekérdezések mint a generikusnál

            //  A gyors autók lekérdezése.
            var fastcars = from c in mycarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var car in fastcars)
                Console.WriteLine("{0} gyors autó!", car.PetName);
            Console.WriteLine();

            // 90-nél gyorsabb BMW-k
            var fs = from c in mycarsEnum
                     where c.Speed > 90 && c.Make == "BMW"
                     select c;
            foreach (var car in fs)
                Console.WriteLine("A {0} BMW 90-nél gyorsabb!", car.PetName);
        }
        #endregion

    }
}
