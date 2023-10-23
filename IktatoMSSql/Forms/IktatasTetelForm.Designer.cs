namespace IktatoMSSql.Forms
{
    partial class IktatasTetelForm
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
            System.Windows.Forms.Label id_IktatLabel;
            System.Windows.Forms.Label iktatoszamLabel;
            System.Windows.Forms.Label idUserLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label idTemaLabel;
            System.Windows.Forms.Label leirasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IktatasTetelForm));
            this.iktatoTetelDS = new IktatoMSSql.DataSets.IktatoTetelDS();
            this.iktatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iktatTableAdapter = new IktatoMSSql.DataSets.IktatoTetelDSTableAdapters.IktatTableAdapter();
            this.tableAdapterManager = new IktatoMSSql.DataSets.IktatoTetelDSTableAdapters.TableAdapterManager();
            this.temakTableAdapter = new IktatoMSSql.DataSets.IktatoTetelDSTableAdapters.TemakTableAdapter();
            this.usersTableAdapter = new IktatoMSSql.DataSets.IktatoTetelDSTableAdapters.UsersTableAdapter();
            this.iktatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iktatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_IktatLabel1 = new System.Windows.Forms.Label();
            this.iktatoszamTextBox = new System.Windows.Forms.TextBox();
            this.idUserComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTemaComboBox = new System.Windows.Forms.ComboBox();
            this.temakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            id_IktatLabel = new System.Windows.Forms.Label();
            iktatoszamLabel = new System.Windows.Forms.Label();
            idUserLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            idTemaLabel = new System.Windows.Forms.Label();
            leirasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iktatoTetelDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingNavigator)).BeginInit();
            this.iktatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_IktatLabel
            // 
            id_IktatLabel.AutoSize = true;
            id_IktatLabel.Location = new System.Drawing.Point(18, 64);
            id_IktatLabel.Name = "id_IktatLabel";
            id_IktatLabel.Size = new System.Drawing.Size(43, 13);
            id_IktatLabel.TabIndex = 1;
            id_IktatLabel.Text = "Id Iktat:";
            // 
            // iktatoszamLabel
            // 
            iktatoszamLabel.AutoSize = true;
            iktatoszamLabel.Location = new System.Drawing.Point(18, 93);
            iktatoszamLabel.Name = "iktatoszamLabel";
            iktatoszamLabel.Size = new System.Drawing.Size(61, 13);
            iktatoszamLabel.TabIndex = 3;
            iktatoszamLabel.Text = "Iktatoszam:";
            // 
            // idUserLabel
            // 
            idUserLabel.AutoSize = true;
            idUserLabel.Location = new System.Drawing.Point(18, 119);
            idUserLabel.Name = "idUserLabel";
            idUserLabel.Size = new System.Drawing.Size(44, 13);
            idUserLabel.TabIndex = 5;
            idUserLabel.Text = "Id User:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(18, 147);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(41, 13);
            datumLabel.TabIndex = 7;
            datumLabel.Text = "Datum:";
            // 
            // idTemaLabel
            // 
            idTemaLabel.AutoSize = true;
            idTemaLabel.Location = new System.Drawing.Point(18, 172);
            idTemaLabel.Name = "idTemaLabel";
            idTemaLabel.Size = new System.Drawing.Size(49, 13);
            idTemaLabel.TabIndex = 9;
            idTemaLabel.Text = "Id Tema:";
            // 
            // leirasLabel
            // 
            leirasLabel.AutoSize = true;
            leirasLabel.Location = new System.Drawing.Point(18, 199);
            leirasLabel.Name = "leirasLabel";
            leirasLabel.Size = new System.Drawing.Size(38, 13);
            leirasLabel.TabIndex = 11;
            leirasLabel.Text = "Leiras:";
            // 
            // iktatoTetelDS
            // 
            this.iktatoTetelDS.DataSetName = "IktatoTetelDS";
            this.iktatoTetelDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iktatBindingSource
            // 
            this.iktatBindingSource.DataMember = "Iktat";
            this.iktatBindingSource.DataSource = this.iktatoTetelDS;
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
            this.tableAdapterManager.UpdateOrder = IktatoMSSql.DataSets.IktatoTetelDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // temakTableAdapter
            // 
            this.temakTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // iktatBindingNavigator
            // 
            this.iktatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iktatBindingNavigator.BindingSource = this.iktatBindingSource;
            this.iktatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iktatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iktatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.iktatBindingNavigatorSaveItem});
            this.iktatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iktatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iktatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iktatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iktatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iktatBindingNavigator.Name = "iktatBindingNavigator";
            this.iktatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iktatBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.iktatBindingNavigator.TabIndex = 0;
            this.iktatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iktatBindingNavigatorSaveItem
            // 
            this.iktatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iktatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iktatBindingNavigatorSaveItem.Image")));
            this.iktatBindingNavigatorSaveItem.Name = "iktatBindingNavigatorSaveItem";
            this.iktatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.iktatBindingNavigatorSaveItem.Text = "Save Data";
            this.iktatBindingNavigatorSaveItem.Click += new System.EventHandler(this.iktatBindingNavigatorSaveItem_Click);
            // 
            // id_IktatLabel1
            // 
            this.id_IktatLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Id_Iktat", true));
            this.id_IktatLabel1.Location = new System.Drawing.Point(85, 64);
            this.id_IktatLabel1.Name = "id_IktatLabel1";
            this.id_IktatLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_IktatLabel1.TabIndex = 2;
            this.id_IktatLabel1.Text = "label1";
            // 
            // iktatoszamTextBox
            // 
            this.iktatoszamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Iktatoszam", true));
            this.iktatoszamTextBox.Location = new System.Drawing.Point(85, 90);
            this.iktatoszamTextBox.Name = "iktatoszamTextBox";
            this.iktatoszamTextBox.Size = new System.Drawing.Size(200, 20);
            this.iktatoszamTextBox.TabIndex = 4;
            // 
            // idUserComboBox
            // 
            this.idUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "IdUser", true));
            this.idUserComboBox.DataSource = this.usersBindingSource;
            this.idUserComboBox.DisplayMember = "Nev";
            this.idUserComboBox.FormattingEnabled = true;
            this.idUserComboBox.Location = new System.Drawing.Point(85, 116);
            this.idUserComboBox.Name = "idUserComboBox";
            this.idUserComboBox.Size = new System.Drawing.Size(200, 21);
            this.idUserComboBox.TabIndex = 6;
            this.idUserComboBox.ValueMember = "Id_User";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.iktatoTetelDS;
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iktatBindingSource, "Datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(85, 143);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 8;
            // 
            // idTemaComboBox
            // 
            this.idTemaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "IdTema", true));
            this.idTemaComboBox.DataSource = this.temakBindingSource;
            this.idTemaComboBox.DisplayMember = "Tema";
            this.idTemaComboBox.FormattingEnabled = true;
            this.idTemaComboBox.Location = new System.Drawing.Point(85, 169);
            this.idTemaComboBox.Name = "idTemaComboBox";
            this.idTemaComboBox.Size = new System.Drawing.Size(200, 21);
            this.idTemaComboBox.TabIndex = 10;
            this.idTemaComboBox.ValueMember = "Id_Tema";
            // 
            // temakBindingSource
            // 
            this.temakBindingSource.DataMember = "Temak";
            this.temakBindingSource.DataSource = this.iktatoTetelDS;
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iktatBindingSource, "Leiras", true));
            this.leirasTextBox.Location = new System.Drawing.Point(85, 196);
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(200, 20);
            this.leirasTextBox.TabIndex = 12;
            // 
            // IktatasTetelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_IktatLabel);
            this.Controls.Add(this.id_IktatLabel1);
            this.Controls.Add(iktatoszamLabel);
            this.Controls.Add(this.iktatoszamTextBox);
            this.Controls.Add(idUserLabel);
            this.Controls.Add(this.idUserComboBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(idTemaLabel);
            this.Controls.Add(this.idTemaComboBox);
            this.Controls.Add(leirasLabel);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.iktatBindingNavigator);
            this.Name = "IktatasTetelForm";
            this.Text = "Iktatás tételenként";
            this.Load += new System.EventHandler(this.IktatasTetelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iktatoTetelDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iktatBindingNavigator)).EndInit();
            this.iktatBindingNavigator.ResumeLayout(false);
            this.iktatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.IktatoTetelDS iktatoTetelDS;
        private System.Windows.Forms.BindingSource iktatBindingSource;
        private DataSets.IktatoTetelDSTableAdapters.IktatTableAdapter iktatTableAdapter;
        private DataSets.IktatoTetelDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iktatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton iktatBindingNavigatorSaveItem;
        private DataSets.IktatoTetelDSTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label id_IktatLabel1;
        private System.Windows.Forms.TextBox iktatoszamTextBox;
        private System.Windows.Forms.ComboBox idUserComboBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.ComboBox idTemaComboBox;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSets.IktatoTetelDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private System.Windows.Forms.BindingSource temakBindingSource;
    }
}