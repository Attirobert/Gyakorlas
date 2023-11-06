using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IktatoMSSql.Forms
{
    public partial class LevelekDatumonkentForm : Form
    {
        public LevelekDatumonkentForm()
        {
            InitializeComponent();
            //SetDatumComboFilter();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.levelekDatumonkentDS);

        }

        private void LevelekDatumonkentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datumComboDS.DatumComboFill' table. You can move, or remove it, as needed.
            this.datumComboFillTableAdapter.Fill(this.datumComboDS.DatumComboFill);
            // TODO: This line of code loads data into the 'levelekDatumonkentDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.levelekDatumonkentDS.Temak);
            // TODO: This line of code loads data into the 'levelekDatumonkentDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.levelekDatumonkentDS.Users);
            // TODO: This line of code loads data into the 'levelekDatumonkentDS.Iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.levelekDatumonkentDS.Iktat);

        }

        private void cbxDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDatumComboFilter();
        }

        private void SetDatumComboFilter()
        {
            iktatBindingSource.Filter = $"(Datum='{cbxDatum.Text}')";
        }
    }
}
