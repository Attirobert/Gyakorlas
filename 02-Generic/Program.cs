using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** More fun with LINQ Expressions *****\n");
            // Hozzunk létre a Car.objektumok egy listáját(List<>)
            // az objektuminicializáló szintaxis használatával.
            List<Car> mycars = new List<Car>()
{
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

            // Metódus hívása
            GetFastCars(mycars);

            Console.ReadKey();
        }

        static void GetFastCars(List<Car> mycars)
        {
            //  A gyors autók lekérdezése.
            var fastcars = from c in mycars 
                           where c.Speed > 55 
                           select c;
            foreach (var car in fastcars)
                Console.WriteLine("{0} gyors autó!", car.PetName);
            Console.WriteLine();

            // 90-nél gyorsabb BMW-k
            var fs = from c in mycars
                     where c.Speed > 90 && c.Make == "BMW"
                     select c;
            foreach (var car in fs)
                Console.WriteLine("A {0} BMW 90-nél gyorsabb!", car.PetName);
        }
    }
}

