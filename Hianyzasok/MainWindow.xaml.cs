using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Hianyzasok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnSearch.IsEnabled = false;
        }

        // Adatszerkezet megadása
        struct hianyzok
        {
            public string Nev,
                Osztaly;
            public int Elso,
                Utolso,
                M_Orak;
        }

        string file = @"..\..\..\szeptember.csv",
            outFile = @"..\..\..\osszesites.csv";


        // Diákok eltárolására
        List<hianyzok> adatok = new List<hianyzok>();

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            hianyzok adat = new hianyzok(); // 

            string[] darabol;

            using (StreamReader sr = new StreamReader(file, Encoding.Default))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    darabol = sr.ReadLine().Split(";");
                    adat.Nev = darabol[0];
                    adat.Osztaly = darabol[1];
                    adat.Elso = Convert.ToInt32(darabol[2]);
                    adat.Utolso = Convert.ToInt32(darabol[3]);
                    adat.M_Orak = Convert.ToInt32(darabol[4]);

                    adatok.Add(adat);
                }
                sr.Close();

                // Ismételt olvasás letiltása
                btnRead.IsEnabled = false;

                btnSearch.IsEnabled = true;
            }

            // 2. feladat megoldása (az 1.-n belül)
            lblFeladat2.Content += "\n\tÖsszes mulasztott órák száma:" + adatok.Sum(x => x.M_Orak) + " óra.";
        }

        // 4. feladat
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int mNap = Convert.ToInt32(tbxNap.Text);
            string mNev = tbxNev.Text;

            // Mezők alaphelyzetbe állítása - nem kell, mert így kitörlöm a 6. feladat előtt
            //tbxNap.Clear();
            //tbxNev.Clear();

            if (adatok.Count(x => x.Nev == mNev) > 0)
            {
                lblFeladat4.Content = "4. feladat\n\tA tanuló hiányzott szeptemberben";
            }
            else
            {
                lblFeladat4.Content = "4. feladat\n\tA tanuló nem hiányzott szeptemberben";
            }

        }

        // 3. feladat - adat ellenőrzés
        private void tbxNap_LostFocus(object sender, RoutedEventArgs e)
        {
            int nap = 0;
            try
            {
                nap = Convert.ToInt32(tbxNap.Text);
                if (nap < 1 || nap > 30)
                {
                    MessageBox.Show("A hónap napjának [1, 30] tartományba kell esnie!");
                    tbxNap.Text = "1";
                    tbxNap.Focus();
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void btnFeladat5_Click(object sender, RoutedEventArgs e)
        {
            // Egy adott napon hiányzók kiszűrése
            int nap = Convert.ToInt32(tbxNap.Text);
            var eredm = adatok
                .Where(x => x.Elso <= nap && x.Utolso >= nap)
                .Select(x => x.Nev)
                .ToArray();

            tbxFeladat5.Clear();
            if (eredm.Length > 0)
                foreach (var item in eredm)
                    tbxFeladat5.Text += item.ToString() + "\n";
        }

        private void btnFeladat6_Click(object sender, RoutedEventArgs e)
        {
            // Kiszedem az osztályokat és sorba rendezem
            string[] osztalyok = adatok.Select(x => x.Osztaly).Distinct().ToArray();
            Array.Sort(osztalyok);

            // Külön tömbbe kigyüjtöm a hiányzásokat
            tbxFeladat6.Clear();
            int[] osztHianyzas = new int[osztalyok.Length];
            for (int i = 0; i < osztalyok.Length; i++)
                for (int j = 0; j < adatok.Count; j++)
                    if (adatok[j].Osztaly == osztalyok[i])
                        osztHianyzas[i] += (adatok[j].M_Orak);

            // Kiíratás képernyőre
            for (int i = 0; i < osztalyok.Length; i++)
                tbxFeladat6.Text += osztalyok[i] + ": " + Convert.ToString(osztHianyzas[i]) + "\n";

            // Kiíratás fájlba
            using (StreamWriter sw = new StreamWriter(outFile))
            {
                for (int i = 0; i < osztalyok.Length; i++)
                    sw.WriteLine(osztalyok[i] + ": " + Convert.ToString(osztHianyzas[i]));

                sw.Close();
            }
        }
    }
}
