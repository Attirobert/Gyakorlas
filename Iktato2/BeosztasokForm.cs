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
using GetDBConnection;

namespace Iktato2
{
    public partial class BeosztasokForm : Form
    {
        private MySqlConnection connection;
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private BindingSource bindingSource;
        private BeosztasClass beosztasClass;

        private string TableName = "beosztasok";
        public BeosztasokForm()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeDataGridView();
            InitializeBindingNavigator();
            connection.Close();
            beosztasClass = new BeosztasClass(DBConnectionsClass.GetConnectionString_1("MyDbConnection"));
        }

        private void InitializeDatabase()
        {
            // Az adatbáziskapcsolat inicializálása
            connection = new MySqlConnection(DBConnectionsClass.GetConnectionString_1("MyDbConnection"));

            // Az adatbáziskapcsolat nyitása
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a kapcsolat megnyitásakor: {ex.Message}");
            }
        }

        private void InitializeDataGridView()
        {
            // DataSet inicializálása
            dataSet = new DataSet();

            // DataTable létrehozása
            DataTable dataTable = new DataTable(TableName);

            // Adatok lekérdezése az adatbázisból és feltöltése a táblába
            string query = $"SELECT * FROM {TableName}";
            dataAdapter = new MySqlDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);

            // Adatok feltöltése a DataSet-be
            dataSet.Tables.Add(dataTable);


            // BindingSource inicializálása és beállítása
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables[TableName];



            // DataGridView inicializálása és adatforrás beállítása
            dataGridView.DataSource = bindingSource;
        }

        private void SaveChanges()
        {
            // Változtatások mentése az adatbázisba
            foreach (DataRow row in dataSet.Tables[TableName].Rows) {
                switch (row.RowState)
                {
                    case DataRowState.Added: beosztasClass.dataInsert(row, connection); break;
                    case DataRowState.Deleted: beosztasClass.dataDelete(row, connection); break;
                    case DataRowState.Modified: beosztasClass.dataUpdate(row, connection); break;
                }
            }

        }

        private void InitializeBindingNavigator()
        {
            // BindingNavigator inicializálása és beállítása
            bindingNavigator.BindingSource = bindingSource;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            MessageBox.Show("Változtatások mentve!");
        }

        private void BeosztasokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Adatbáziskapcsolat bezárása a program leállításakor
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
