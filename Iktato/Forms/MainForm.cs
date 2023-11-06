using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktato
{
    public partial class MainForm : Form
    {
        Data.Connection con=new Data.Connection();
        public MainForm()
        {
            InitializeComponent();
            label1.Text= String.Empty;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Connection.dataSource();
                con.connOpen();
                label1.Text = "Sikeres kapcsolódás!";

            }
            catch (Exception) {
                label1.Text = "Sikertelen kapcsolódás!";

            }
            finally
            {
                con.connClose();
                label1.Visible = true;
           }
        }
    }
}
