/* Feladat
 * Projekt név: Lotto
 * 
 * Egy lottó játékra kell fogadási tippeket adni.  A játékban két számmezőn (táblán) kell tippeket adni.
 * Az eredeti játékban az első számmezőn az 1-90 tartományban kell 5 tippet adni, a második számmezőn 1-12 tartományban kell 2 tippet adni.
 * A tippeléshez nem kell a teljes számtartományokat figyelembe venni, hanem az eddigi sorsolási eredmények alapján az első számmezőhöz 10 db { 10, 22, 27, 28, 34, 35, 36, 46, 48, 49 }, 
 * a másodikhoz 4 db { 8, 9, 11, 12 } szám lett kiválasztva.  Ezekből kell véletlen szerűen tippelni.
 * Az előállított tippek közül az első számmező tippjeit ellenőrizni kell, hogy nem lett-e már kisorsolva régebben.  Ehhez az eddigi sorsolások eredménye rendelkezésre áll a cstolt eurojackpotHuzasok.csv fájlban.
 * A fájlban egy sor egy sorsolás első számmezőjének eredményét tartalmazza a számok növekvő sorrendjében.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tippSzam1 = 5,  // Az első számmezőn adandó tippek száma
                tippSzam2 = 2;  // A második számmezőn adandó tippek száma

            int[] aTomb = { 10, 22, 27, 28, 34, 35, 36, 46, 48, 49 },   // Az első számmező számfogadás számjegyei.  Az eddig leggyakrabban kihúzott számok: 20, 34, 35, 46, 48, 49; a legritkábban kihúzott számok: 10, 22, 27, 28, 36.
                bTomb = { 8, 9, 11, 12 },   // A második számmező leggyakrabban kihúzott számai:8, 9; a legritkábban kihúzott számai: 11, 12.
                eTomb = new int[tippSzam1],         // Eredmény tömb az első számmező számaihoz
                eTomb2 = new int[tippSzam2];        // Eredmény tömb a második számmező számaihoz

            //string fNev = @"C:\Users\kovac\source\repos\Attirobert\CsharpGyak\Gyakorlas\Lotto\eurojackpotHuzasok.csv"; // filenév az abszolut elérési úttal
            string fNev = @"..\..\eurojackpotHuzasok.csv"; // filenév a relatív elérési úttal


            /////////////////////
            // Az első számmező sorozat 
            // Szerepel-e a tipp az előző sorsolások között?
            do Sorsol(aTomb, eTomb);
            while (VoltTipp(eTomb, fNev));
            // Eredmény kiíratása
            Kiir(eTomb, "Első sorozat");


            /////////////////////
            // Második sorozat 
            Sorsol(bTomb, eTomb2);
            Kiir(eTomb2, "Második sorozat");


            Console.ReadKey();
        }

        // Tippek kiíratása
        static void Kiir(int[] tomb, string cim)
        {
            Console.WriteLine(cim);
            for (int i = 0; i < tomb.Length; i++) Console.WriteLine(tomb[i]);

            Console.WriteLine();    // Soremelés
        }

        // Ellenőrizzük, hogy ez a kombináció még nem volt kisorsolva
        static bool VoltTipp(int[] tomb, string filenev) {
            // tomb: a tippek
            // filenev: ahol az eddigi húzások eredményei vannak

            int[] fTomb = new int[tomb.Length];   // A fájlból olvasott tippeknek. A méretének azonosnak kell lennie az általunk adott tipp tömbbel. A fájlban rendezettek a tippek!
            string[] sor = null;
            bool egyezik = true;    

            using (StreamReader sr = new StreamReader(filenev))
            {
                while (!sr.EndOfStream)
                {
                    // Sor beolvasása és beírása a tömbbe.
                    sor = sr.ReadLine().Split(';');
                    for (int i = 0; i < fTomb.Length; i++) fTomb[i] = Convert.ToInt32(sor[i]);

                    // Megnézzük, hogy egyezik-e a tippünk ezzel.  Mind a két tömb rendezett!
                    for (int i = 0; i < fTomb.Length; i++)
                    {
                        if (fTomb[i] != tomb[i])
                        {
                            egyezik = false;
                            break;
                        }
                    }

                    // Ha az előző ciklus végig ment, akkor egyezett a két tömb, tehát volt már ilyen tipp, ezért nem kell tovább vizsgálni.
                    if (egyezik) break;
                }
                
                sr.Close();
            }
            return egyezik; 
        }

        // Sorsolás
        static void Sorsol(int[] tomb, int[] etomb)
        {
            Random random = new Random();
            DateTime dt = DateTime.Now;

            int i = 0,  // tömbindex 
                j = 0,  // tippek számolása
                k = 0,  // végtelen ciklus megakadályozása
                tl = tomb.Length - 1,
                eTombLength = etomb.Length;     // Az eredmények száma, vagyis az eredmény tömb mérete

            // Tippek előállítása
            while (j < eTombLength && k < 1000)
            {
                // Véletlen eltolás előállítása, hogy a véletlenszám generátort ténylegesen véletlenné tegyük
                i = (random.Next(0, tl) + (int)dt.Millisecond % 100) % tl;

                if (tomb[i] > 0)
                {
                    etomb[j] = tomb[i];
                    tomb[i] = 0;           // Kiszedem a tömbből a kisorsolt számot 
                    j++;
                }

                k++;
            }

            // Tippek sorba rendezése
            Array.Sort(etomb);
        }

    }
}
