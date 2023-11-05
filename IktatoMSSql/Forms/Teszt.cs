using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IktatoMSSql.Forms
{
    public partial class Teszt : Form
    {
        public Teszt()
        {
            InitializeComponent();
        }

        private void beosztasokBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.beosztasokBindingSource.EndEdit();

        }

        private void Teszt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beosztasTesztDS.Beosztasok' table. You can move, or remove it, as needed.
            this.beosztasokTableAdapter.Fill(this.beosztasTesztDS.Beosztasok);
            // TODO: This line of code loads data into the 'beosztasTesztDS.Beosztasok' table. You can move, or remove it, as needed.
            this.beosztasokTableAdapter.Fill(this.beosztasTesztDS.Beosztasok);

        }
    }
}
