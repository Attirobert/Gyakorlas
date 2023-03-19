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

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // Osztályváltozók
        private string file = @"..\..\adatok.csv";
        private List<Utem> utems = new List<Utem>();

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region Ütemezés beolvasása
            string[] darabol;
            Utem utem;
            DateTime dt = DateTime.Today;   // Napi dátum

            using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
            {
                sr.ReadLine();  // Az első sor fejléc - eldobjuk

                while (!sr.EndOfStream)
                {
                    darabol = sr.ReadLine().Split(';');
                    dt.AddHours(Convert.ToInt32(darabol[0]));
                    dt.AddMinutes(Convert.ToInt32(darabol[1]));
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
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (utems[0].Idopont <= DateTime.Now)
            {
                MessageBox.Show(utems[0].Szoveg);
                utems.Remove(utems[0]);
                if (utems.Count == 0) timer1.Enabled = false;
            }
        }
    }
}