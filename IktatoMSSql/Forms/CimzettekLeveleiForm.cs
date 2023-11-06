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
    public partial class CimzettekLeveleiForm : Form
    {
        public CimzettekLeveleiForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cimzettekLeveleiDS);

        }

        private void CimzettekLeveleiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cimzettekLeveleiDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.cimzettekLeveleiDS.Temak);
            // TODO: This line of code loads data into the 'cimzettekLeveleiDS.Iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.cimzettekLeveleiDS.Iktat);
            // TODO: This line of code loads data into the 'cimzettekLeveleiDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.cimzettekLeveleiDS.Users);

        }
    }
}
