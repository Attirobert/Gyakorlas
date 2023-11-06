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
    public partial class LevelekSzureseForm : Form
    {
        public LevelekSzureseForm()
        {
            InitializeComponent();
        }

        private void iktatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iktatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.levelekOsszetettSzureseDS);

        }

        private void LevelekSzureseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'levelekOsszetettSzureseDS.Temak' table. You can move, or remove it, as needed.
            this.temakTableAdapter.Fill(this.levelekOsszetettSzureseDS.Temak);
            // TODO: This line of code loads data into the 'levelekOsszetettSzureseDS.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.levelekOsszetettSzureseDS.Users);
            // TODO: This line of code loads data into the 'levelekOsszetettSzureseDS.Iktat' table. You can move, or remove it, as needed.
            this.iktatTableAdapter.Fill(this.levelekOsszetettSzureseDS.Iktat);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvtxtFilter.Text != String.Empty)
            {
                iktatBindingSource.Filter = $"((Iktatoszam like '%{dgvtxtFilter.Text}%') or (Leiras like '%{dgvtxtFilter.Text}%'))";
            }
        }

        private void dgvtxtFilter_Enter(object sender, EventArgs e)
        {
            dgvtxtFilter.Text = String.Empty ;
        }
    }
}
