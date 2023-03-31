using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utems
{
    // Adatszerkezet megadása
    struct Utem
    {
        public DateTime Idopont;    // Mikor kell jelezni
        public string Szoveg;       // Mit kell kiírni
    }

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // Osztályváltozók
        private string file = @"..\..\adatok.csv";
        private List<Utem> utems = new List<Utem>();

        private const string OSZTALY = "Bemutató óra 11 / A";

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            #region Ütemezés beolvasása
            string[] darabol;
            Utem utem;
            DateTime dt = new DateTime(2023, 03, 20);    // Napi dátum

            using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
            {
                sr.ReadLine();  // Az első sor fejléc - eldobjuk

                while (!sr.EndOfStream)
                {
                    darabol = sr.ReadLine().Split(';');
                    dt = dt.AddHours(Convert.ToDouble(darabol[0])).AddMinutes(Convert.ToDouble(darabol[1]));
                    utem.Idopont = dt;
                    utem.Szoveg = darabol[2];

                    utems.Add(utem);
                }

            }
            #endregion Ütemezés beolvasása
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = OSZTALY + DateTime.Now.ToString();

            if (DateTime.Compare(utems[0].Idopont,DateTime.Now) <= 0)
            {
                timer1.Enabled = false; // leállítom a timert, hogy addig ne menjen, amíg az üzenetet jóvá nem hagyom
                MessageBox.Show(utems[0].Szoveg + " bejegyzés: " + utems.Count);
                timer1.Enabled = true;  // újra indulhat a timer
                utems.Remove(utems[0]);
                if (utems.Count == 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Vége a feladatnak!");
                }
            }
        }
    }
}