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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDS);

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDS.Users);

        }
    }
}
