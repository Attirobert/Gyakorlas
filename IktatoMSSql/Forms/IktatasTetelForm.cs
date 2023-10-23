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
    public partial class IktatasTetelForm : Form
    {
        public IktatasTetelForm()
        {
            InitializeComponent();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iktatoTetelDS);

        }

        private void IktatasTetelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iktatoTetelDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.iktatoTetelDS.Temak);
            // TODO: This line of code loads data into the 'iktatoTetelDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iktatoTetelDS.Users);
            // TODO: This line of code loads data into the 'iktatoTetelDS.Iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.iktatoTetelDS.Iktat);

        }
    }
}
