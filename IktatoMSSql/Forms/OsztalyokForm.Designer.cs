﻿namespace IktatoMSSql.Forms
{
    partial class OsztalyokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsztalyokForm));
            this.osztalyokDS = new IktatoMSSql.DataSets.OsztalyokDS();
            this.osztalyokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osztalyokTableAdapter = new IktatoMSSql.DataSets.OsztalyokDSTableAdapters.OsztalyokTableAdapter();
            this.tableAdapterManager = new IktatoMSSql.DataSets.OsztalyokDSTableAdapters.TableAdapterManager();
            this.osztalyokBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.osztalyokBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.osztalyokDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOsztaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokBindingNavigator)).BeginInit();
            this.osztalyokBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // osztalyokDS
            // 
            this.osztalyokDS.DataSetName = "OsztalyokDS";
            this.osztalyokDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osztalyokBindingSource
            // 
            this.osztalyokBindingSource.DataMember = "Osztalyok";
            this.osztalyokBindingSource.DataSource = this.osztalyokDS;
            // 
            // osztalyokTableAdapter
            // 
            this.osztalyokTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OsztalyokTableAdapter = this.osztalyokTableAdapter;
            this.tableAdapterManager.UpdateOrder = IktatoMSSql.DataSets.OsztalyokDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // osztalyokBindingNavigator
            // 
            this.osztalyokBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.osztalyokBindingNavigator.BindingSource = this.osztalyokBindingSource;
            this.osztalyokBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.osztalyokBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.osztalyokBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.osztalyokBindingNavigatorSaveItem});
            this.osztalyokBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.osztalyokBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.osztalyokBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.osztalyokBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.osztalyokBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.osztalyokBindingNavigator.Name = "osztalyokBindingNavigator";
            this.osztalyokBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.osztalyokBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.osztalyokBindingNavigator.TabIndex = 0;
            this.osztalyokBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // osztalyokBindingNavigatorSaveItem
            // 
            this.osztalyokBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.osztalyokBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("osztalyokBindingNavigatorSaveItem.Image")));
            this.osztalyokBindingNavigatorSaveItem.Name = "osztalyokBindingNavigatorSaveItem";
            this.osztalyokBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.osztalyokBindingNavigatorSaveItem.Text = "Save Data";
            this.osztalyokBindingNavigatorSaveItem.Click += new System.EventHandler(this.osztalyokBindingNavigatorSaveItem_Click);
            // 
            // osztalyokDataGridView
            // 
            this.osztalyokDataGridView.AutoGenerateColumns = false;
            this.osztalyokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.osztalyokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgcOsztaly});
            this.osztalyokDataGridView.DataSource = this.osztalyokBindingSource;
            this.osztalyokDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osztalyokDataGridView.Location = new System.Drawing.Point(0, 25);
            this.osztalyokDataGridView.Name = "osztalyokDataGridView";
            this.osztalyokDataGridView.Size = new System.Drawing.Size(800, 425);
            this.osztalyokDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Osztaly";
            this.dataGridViewTextBoxColumn1.HeaderText = "Azonosító";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgcOsztaly
            // 
            this.dgcOsztaly.DataPropertyName = "Osztaly";
            this.dgcOsztaly.HeaderText = "Osztály";
            this.dgcOsztaly.Name = "dgcOsztaly";
            // 
            // OsztalyokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osztalyokDataGridView);
            this.Controls.Add(this.osztalyokBindingNavigator);
            this.Name = "OsztalyokForm";
            this.Text = "Osztályok";
            this.Load += new System.EventHandler(this.OsztalyokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokBindingNavigator)).EndInit();
            this.osztalyokBindingNavigator.ResumeLayout(false);
            this.osztalyokBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.OsztalyokDS osztalyokDS;
        private System.Windows.Forms.BindingSource osztalyokBindingSource;
        private DataSets.OsztalyokDSTableAdapters.OsztalyokTableAdapter osztalyokTableAdapter;
        private DataSets.OsztalyokDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator osztalyokBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton osztalyokBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView osztalyokDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOsztaly;
    }
}