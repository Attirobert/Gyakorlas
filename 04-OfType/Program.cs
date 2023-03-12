using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mystuff = new ArrayList();
            mystuff.AddRange(new object[] { 10, 400, 8, false, "string data"});

            // Feladat: Nyerjük ki az integer értékeket az ArrayListből.
            // Először egész típusú generikussá teszem a gyüjteményt.  Ez kiejti a nem int típusúakat.
            // 
            IEnumerable<int> myints = mystuff.OfType<int>();
            // Kiíratás
            foreach (int i in myints)
            {
                Console.WriteLine("Int value: {O}", i);
            }
        }
    }
}
