using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktato2
{
    public partial class BeosztasokForm : Form
    {
        public BeosztasokForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData("SELECT * FROM beosztasok", dataGridView);
        }

        private void loadData(string query, DataGridView dgv)
        {
            Database database = new Database();
            if (database.connect_db())
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.CommandType = CommandType.Text;
                mySqlCommand.CommandText = query;
                mySqlCommand.Connection = database.mySqlConnection;

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dgv.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show($"Nem sikerült kapcsolódni az adatbázishoz!");
            }
        }
    }
}
