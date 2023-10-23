namespace IktatoMSSql.Forms
{
    partial class TemakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemakForm));
            this.temakDS = new IktatoMSSql.DataSets.TemakDS();
            this.temakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temakTableAdapter = new IktatoMSSql.DataSets.TemakDSTableAdapters.TemakTableAdapter();
            this.tableAdapterManager = new IktatoMSSql.DataSets.TemakDSTableAdapters.TableAdapterManager();
            this.temakBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.temakBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.temakDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.temakDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingNavigator)).BeginInit();
            this.temakBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temakDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // temakDS
            // 
            this.temakDS.DataSetName = "TemakDS";
            this.temakDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temakBindingSource
            // 
            this.temakBindingSource.DataMember = "Temak";
            this.temakBindingSource.DataSource = this.temakDS;
            // 
            // temakTableAdapter
            // 
            this.temakTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TemakTableAdapter = this.temakTableAdapter;
            this.tableAdapterManager.UpdateOrder = IktatoMSSql.DataSets.TemakDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // temakBindingNavigator
            // 
            this.temakBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.temakBindingNavigator.BindingSource = this.temakBindingSource;
            this.temakBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.temakBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.temakBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.temakBindingNavigatorSaveItem});
            this.temakBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.temakBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.temakBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.temakBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.temakBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.temakBindingNavigator.Name = "temakBindingNavigator";
            this.temakBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.temakBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.temakBindingNavigator.TabIndex = 0;
            this.temakBindingNavigator.Text = "bindingNavigator1";
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
            // temakBindingNavigatorSaveItem
            // 
            this.temakBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.temakBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("temakBindingNavigatorSaveItem.Image")));
            this.temakBindingNavigatorSaveItem.Name = "temakBindingNavigatorSaveItem";
            this.temakBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.temakBindingNavigatorSaveItem.Text = "Save Data";
            this.temakBindingNavigatorSaveItem.Click += new System.EventHandler(this.temakBindingNavigatorSaveItem_Click);
            // 
            // temakDataGridView
            // 
            this.temakDataGridView.AutoGenerateColumns = false;
            this.temakDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temakDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgcTema});
            this.temakDataGridView.DataSource = this.temakBindingSource;
            this.temakDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temakDataGridView.Location = new System.Drawing.Point(0, 25);
            this.temakDataGridView.Name = "temakDataGridView";
            this.temakDataGridView.Size = new System.Drawing.Size(800, 425);
            this.temakDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Tema";
            this.dataGridViewTextBoxColumn1.HeaderText = "Azonosító";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgcTema
            // 
            this.dgcTema.DataPropertyName = "Tema";
            this.dgcTema.HeaderText = "Téma";
            this.dgcTema.Name = "dgcTema";
            // 
            // TemakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temakDataGridView);
            this.Controls.Add(this.temakBindingNavigator);
            this.Name = "TemakForm";
            this.Text = "Levél témák";
            this.Load += new System.EventHandler(this.TemakForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temakDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temakBindingNavigator)).EndInit();
            this.temakBindingNavigator.ResumeLayout(false);
            this.temakBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temakDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.TemakDS temakDS;
        private System.Windows.Forms.BindingSource temakBindingSource;
        private DataSets.TemakDSTableAdapters.TemakTableAdapter temakTableAdapter;
        private DataSets.TemakDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator temakBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton temakBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView temakDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTema;
    }
}