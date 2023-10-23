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
    public partial class IktatasGridForm : Form
    {
        public IktatasGridForm()
        {
            InitializeComponent();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktatoGridDS);

        }

        private void IktatasGridForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatoGridDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.iktatoGridDS.Temak);
            // TODO: This line of code loads data into the 'iktatoGridDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktatoGridDS.Users);
            // TODO: This line of code loads data into the 'iktatoGridDS.Iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatoGridDS.Iktat);

        }
    }
}
