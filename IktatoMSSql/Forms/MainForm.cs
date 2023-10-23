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
            IktatForm frm = new IktatForm();
            frm.ShowDialog();
        }

        private void iktatóLapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatEgyesForm frm = new IktatEgyesForm();
            frm.ShowDialog();
        }
    }
}
