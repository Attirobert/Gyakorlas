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
    public partial class BeosztasokForm : Form
    {
        private DataTable originalDataTable; // Az eredeti adatokat tartalmazó DataTable
        private DataTable changesDataTable; // A módosításokat tartalmazó DataTable
        private DataTable insertDataTable; 
        private DataTable deleteDataTable; 
        private DataTable updateDataTable; 

        public BeosztasokForm()
        {
            InitializeComponent();
        }

        private void BeosztasokForm_Load(object sender, EventArgs e)
        {
            // Eredeti adatok lekérése és DataGridView feltöltése
            originalDataTable = GetDataTable("string"); // Nem értem, miért nem jó neki az osztályban deklarált metódus!!!! 
            changesDataTable = originalDataTable.Copy();

            dataGridView1.DataSource = changesDataTable;
        }

        private DataTable GetDataTable(string v)
        {
            //
            DataTable dt = null;

            return dt;
        }

        private void FillSaveDataTables()
        {
            // Végig megyünk a changesDataTable-en és a jelölők alapján feltöltjük a három adattáblát
            // Ellenőrizzük, hogy valóban történtek-e módosítások
            //if (originalDataTable != null && changesDataTable != null && originalDataTable.Rows.Count == changesDataTable.Rows.Count)
            //{
            //    for (int i = 0; i < originalDataTable.Rows.Count; i++)
            //    {
            //        DataRow originalRow = originalDataTable.Rows[i];
            //        DataRow changesRow = changesDataTable.Rows[i];

            //        // Ellenőrzés, hogy a sorban történt-e módosítás
            //        if (!DataRowComparer.Default.Equals(originalRow, changesRow))
            //        {
            //            // Itt hajtsd végre az adatbázis módosításokat, például UPDATE parancs használatával
            //            // Példa: UpdateQuery($"UPDATE yourTableName SET yourColumn = '{changesRow["yourColumn"]}' WHERE yourCondition");

            //            // Ellenőrzés után töröljük a változásokat a tárolóból
            //            changesRow.ItemArray = originalRow.ItemArray;
            //        }
            //    }

            //    MessageBox.Show("Mentve!");
            //}
            //else
            //{
            //    MessageBox.Show("Nincs változás a mentendő adatokban.");
            //}
            // Update táblák ürítése
            string queryString = "";
            if (insertDataTable != null) insertDataTable.Clear();
            FilterDataTable(originalDataTable, insertDataTable, queryString);

            queryString = "";
            if (updateDataTable != null) updateDataTable.Clear();
            FilterDataTable(originalDataTable, updateDataTable, queryString);

            queryString = "";
            if (deleteDataTable != null) deleteDataTable.Clear();
            FilterDataTable(originalDataTable, deleteDataTable, queryString);

            // Új adatok feltöltése
                        
        }

        private void FilterDataTable(DataTable originalDataTable, DataTable filteredDataTable, string filterExpression)
        {
            // Szűrt DataTable létrehozása a filterExpression alapján
            DataRow[] filteredRows = originalDataTable.Select(filterExpression);
            //filteredDataTable = originalDataTable.Clone();

            foreach (DataRow row in filteredRows)
            {
                filteredDataTable.ImportRow(row);
            }
        }
    }
}
