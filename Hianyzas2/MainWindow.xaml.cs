using System;
using System.Collections.Generic;
using System.IO;
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

namespace Hianyzas2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // A gombokat tartalmazótömb
        private Button[] buttons = new Button[6];

        // Hiányzások struktúrája
        struct Hianyzok
        {
            public string Nev,
                Osztaly;
            public int Elso,
                Utolso,
                M_Orak;
        }

        // Beolvasott hiányzások tárolása
        List<Hianyzok> adatok = new List<Hianyzok>();

        string inFile = @"..\..\..\szeptember.csv",
            outFile = @"..\..\..\osszesites.csv";


        public MainWindow()
        {
            InitializeComponent();

            // Gombok tömb feltöltése, beállítása
            gombFeltolt();
            gombAllit(false);

        }

        // Gombok feltöltése
        private void gombFeltolt()
        {
            buttons[0] = btnF1;
            buttons[1] = btnF2;
            buttons[2] = btnF3;
            buttons[3] = btnF4;
            buttons[4] = btnF5;
            buttons[5] = btnF6;
        }

        // Gombok elérhetőségének állítása
        private void gombAllit(bool b)
        {
            for (int i = 1; i < 9; i++)
                buttons[i].IsEnabled = b;
        }

        private void btnF1_Click(object sender, RoutedEventArgs e)
        {
            Hianyzok adat = new Hianyzok();

            string[] darabol;

            using (StreamReader sr = new StreamReader(inFile, Encoding.Default))
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
                btnF1.IsEnabled = false;

                // Többi gomb elérése
                gombAllit(true);
            }

        }
    }
}
