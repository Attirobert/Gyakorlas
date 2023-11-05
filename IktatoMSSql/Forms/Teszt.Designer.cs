namespace IktatoMSSql.Forms
{
    partial class Teszt
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.beosztasTesztDS = new IktatoMSSql.DataSets.BeosztasTesztDS();
            this.beosztasTesztDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beosztasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beosztasokTableAdapter = new IktatoMSSql.DataSets.BeosztasTesztDSTableAdapters.BeosztasokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasTesztDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasTesztDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.beosztasokBindingSource;
            this.comboBox1.DisplayMember = "Beosztas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id_Beosztas";
            // 
            // beosztasTesztDS
            // 
            this.beosztasTesztDS.DataSetName = "BeosztasTesztDS";
            this.beosztasTesztDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beosztasTesztDSBindingSource
            // 
            this.beosztasTesztDSBindingSource.DataSource = this.beosztasTesztDS;
            this.beosztasTesztDSBindingSource.Position = 0;
            // 
            // beosztasokBindingSource
            // 
            this.beosztasokBindingSource.DataMember = "Beosztasok";
            this.beosztasokBindingSource.DataSource = this.beosztasTesztDS;
            // 
            // beosztasokTableAdapter
            // 
            this.beosztasokTableAdapter.ClearBeforeFill = true;
            // 
            // Teszt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Name = "Teszt";
            this.Text = "ComboBox Teszt";
            this.Load += new System.EventHandler(this.Teszt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beosztasTesztDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasTesztDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beosztasokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource beosztasTesztDSBindingSource;
        private DataSets.BeosztasTesztDS beosztasTesztDS;
        private System.Windows.Forms.BindingSource beosztasokBindingSource;
        private DataSets.BeosztasTesztDSTableAdapters.BeosztasokTableAdapter beosztasokTableAdapter;
    }
}