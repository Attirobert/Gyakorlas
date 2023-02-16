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

        string file = @"..\..\szeptember.csv";

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            // Diákok eltárolására
            List<hianyzok> adatok = new List<hianyzok>();
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            int mNap = Convert.ToInt32(tbxNap.Text);
            string mNev = tbxNev.Text;


        }
    }
}
