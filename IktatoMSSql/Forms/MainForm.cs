using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IktatoMSSql.Forms;

namespace IktatoMSSql
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void személyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.ShowDialog();
        }

        private void osztályokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OsztalyokForm frm = new OsztalyokForm();
            frm.ShowDialog();
        }

        private void beosztásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeosztasokForm frm = new BeosztasokForm();
            frm.ShowDialog();
        }

        private void levelezésiTémákToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemakForm frm = new TemakForm();
            frm.ShowDialog();
        }

        private void iktatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatasGridForm frm = new IktatasGridForm();
            frm.ShowDialog();
        }

        private void iktatóLapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatasTetelForm frm = new IktatasTetelForm();
            frm.ShowDialog();
        }

        private void tesztToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teszt frm = new Teszt();
            frm.ShowDialog();
        }

        private void címzettekLeveleiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CimzettekLeveleiForm frm = new CimzettekLeveleiForm();
            frm.ShowDialog();
        }

        private void levelekDátumSzerintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelekDatumonkentForm frm = new LevelekDatumonkentForm();
            frm.ShowDialog();
        }

        private void levelekBármelyDátumSzerintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelekDatumonkent2Form frm = new LevelekDatumonkent2Form();
            frm.ShowDialog();
        }

        private void összetettKeresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelekSzureseForm frm = new LevelekSzureseForm();
            frm.ShowDialog();
        }
    }
}
