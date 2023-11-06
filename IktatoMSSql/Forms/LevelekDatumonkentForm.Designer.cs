namespace IktatoMSSql.Forms
{
    partial class LevelekDatumonkentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label datumLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelekDatumonkentDS = new IktatoMSSql.DataSets.LevelekDatumonkentDS();
            this.iktatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iktatTableAdapter = new IktatoMSSql.DataSets.LevelekDatumonkentDSTableAdapters.IktatTableAdapter();
            this.tableAdapterManager = new IktatoMSSql.DataSets.LevelekDatumonkentDSTableAdapters.TableAdapterManager();
            this.datumComboBox = new System.Windows.Forms.ComboBox();
            this.iktatDataGridView = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new IktatoMSSql.DataSets.LevelekDatumonkentDSTableAdapters.UsersTableAdapter();
            this.temakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temakTableAdapter = new IktatoMSSql.DataSets.LevelekDatumonkentDSTableAdapters.TemakTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            datumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelekDatumonkentDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(datumLabel);
            this.panel1.Controls.Add(this.datumComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iktatDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 392);
            this.panel2.TabIndex = 1;
            // 
            // levelekDatumonkentDS
            // 
            this.levelekDatumonkentDS.DataSetName = "LevelekDatumonkentDS";
            this.levelekDatumonkentDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iktatBindingSource
            // 
            this.iktatBindingSource.DataMember = "Iktat";
            this.iktatBindingSource.DataSource = this.levelekDatumonkentDS;
            // 
            // iktatTableAdapter
            // 
            this.iktatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IktatTableAdapter = this.iktatTableAdapter;
            this.tableAdapterManager.TemakTableAdapter = this.temakTableAdapter;
            this.tableAdapterManager.UpdateOrder = IktatoMSSql.DataSets.LevelekDatumonkentDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(175, 20);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 0;
            datumLabel.Text = "Datum:";
            // 
            // datumComboBox
            // 
            this.datumComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Datum", true));
            this.datumComboBox.FormattingEnabled = true;
            this.datumComboBox.Location = new System.Drawing.Point(222, 17);
            this.datumComboBox.Name = "datumComboBox";
            this.datumComboBox.Size = new System.Drawing.Size(121, 21);
            this.datumComboBox.TabIndex = 1;
            // 
            // iktatDataGridView
            // 
            this.iktatDataGridView.AutoGenerateColumns = false;
            this.iktatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iktatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iktatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.iktatDataGridView.DataSource = this.iktatBindingSource;
            this.iktatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iktatDataGridView.Location = new System.Drawing.Point(0, 0);
            this.iktatDataGridView.Name = "iktatDataGridView";
            this.iktatDataGridView.Size = new System.Drawing.Size(800, 392);
            this.iktatDataGridView.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.levelekDatumonkentDS;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // temakBindingSource
            // 
            this.temakBindingSource.DataMember = "Temak";
            this.temakBindingSource.DataSource = this.levelekDatumonkentDS;
            // 
            // temakTableAdapter
            // 
            this.temakTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Iktat";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Iktat";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Iktatoszam";
            this.dataGridViewTextBoxColumn2.HeaderText = "Iktatoszam";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdUser";
            this.dataGridViewTextBoxColumn3.DataSource = this.usersBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nev";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdUser";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id_User";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdTema";
            this.dataGridViewTextBoxColumn5.DataSource = this.temakBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Tema";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdTema";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Id_Tema";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Leiras";
            this.dataGridViewTextBoxColumn6.HeaderText = "Leiras";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // LevelekDatumonkentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LevelekDatumonkentForm";
            this.Text = "Levelek iktatási dátumonként";
            this.Load += new System.EventHandler(this.LevelekDatumonkentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelekDatumonkentDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DataSets.LevelekDatumonkentDS levelekDatumonkentDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private DataSets.LevelekDatumonkentDSTableAdapters.IktatTableAdapter iktatTableAdapter;
        private DataSets.LevelekDatumonkentDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox datumComboBox;
        private System.Windows.Forms.DataGridView iktatDataGridView;
        private DataSets.LevelekDatumonkentDSTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSets.LevelekDatumonkentDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}