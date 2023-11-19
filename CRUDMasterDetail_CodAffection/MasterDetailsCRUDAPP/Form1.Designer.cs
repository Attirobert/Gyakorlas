namespace MasterDetailsCRUDAPP
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImageClear = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.rbtContractual = new System.Windows.Forms.RadioButton();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.rbtRegular = new System.Windows.Forms.RadioButton();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.dgvEmpCompany = new System.Windows.Forms.DataGridView();
            this.dgvtxtEmpCompID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCompany)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(774, 606);
            this.tabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnImageClear);
            this.tabPage1.Controls.Add(this.btnImageBrowse);
            this.tabPage1.Controls.Add(this.rbtContractual);
            this.tabPage1.Controls.Add(this.txtEmpName);
            this.tabPage1.Controls.Add(this.rbtRegular);
            this.tabPage1.Controls.Add(this.txtEmpCode);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pbxPhoto);
            this.tabPage1.Controls.Add(this.cmbPosition);
            this.tabPage1.Controls.Add(this.dgvEmpCompany);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtpDOB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(6, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 49);
            this.panel1.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnReset.Location = new System.Drawing.Point(425, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnDelete.Location = new System.Drawing.Point(339, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnSave.Location = new System.Drawing.Point(253, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImageClear
            // 
            this.btnImageClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnImageClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnImageClear.Location = new System.Drawing.Point(546, 287);
            this.btnImageClear.Name = "btnImageClear";
            this.btnImageClear.Size = new System.Drawing.Size(80, 27);
            this.btnImageClear.TabIndex = 9;
            this.btnImageClear.Text = "Clear";
            this.btnImageClear.UseVisualStyleBackColor = false;
            this.btnImageClear.Click += new System.EventHandler(this.btnImageClear_Click);
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(233)))), ((int)(((byte)(246)))));
            this.btnImageBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(62)))), ((int)(((byte)(96)))));
            this.btnImageBrowse.Location = new System.Drawing.Point(460, 287);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(80, 27);
            this.btnImageBrowse.TabIndex = 8;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = false;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // rbtContractual
            // 
            this.rbtContractual.AutoSize = true;
            this.rbtContractual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtContractual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.rbtContractual.Location = new System.Drawing.Point(225, 258);
            this.rbtContractual.Name = "rbtContractual";
            this.rbtContractual.Size = new System.Drawing.Size(109, 24);
            this.rbtContractual.TabIndex = 7;
            this.rbtContractual.TabStop = true;
            this.rbtContractual.Text = "Contractual";
            this.rbtContractual.UseVisualStyleBackColor = true;
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(127, 78);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(251, 26);
            this.txtEmpName.TabIndex = 2;
            // 
            // rbtRegular
            // 
            this.rbtRegular.AutoSize = true;
            this.rbtRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRegular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.rbtRegular.Location = new System.Drawing.Point(136, 258);
            this.rbtRegular.Name = "rbtRegular";
            this.rbtRegular.Size = new System.Drawing.Size(83, 24);
            this.rbtRegular.TabIndex = 6;
            this.rbtRegular.TabStop = true;
            this.rbtRegular.Text = "Regular";
            this.rbtRegular.UseVisualStyleBackColor = true;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.Location = new System.Drawing.Point(127, 30);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(251, 26);
            this.txtEmpCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(73, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "State";
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(460, 6);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(275, 275);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 6;
            this.pbxPhoto.TabStop = false;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(127, 124);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(251, 28);
            this.cmbPosition.TabIndex = 3;
            // 
            // dgvEmpCompany
            // 
            this.dgvEmpCompany.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.dgvEmpCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtEmpCompID,
            this.dgvtxtCompanyName,
            this.dgvcmbPosition,
            this.dgvtxtYear});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpCompany.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpCompany.Location = new System.Drawing.Point(6, 337);
            this.dgvEmpCompany.Name = "dgvEmpCompany";
            this.dgvEmpCompany.Size = new System.Drawing.Size(754, 158);
            this.dgvEmpCompany.TabIndex = 10;
            this.dgvEmpCompany.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmpCompany_UserDeletingRow);
            // 
            // dgvtxtEmpCompID
            // 
            this.dgvtxtEmpCompID.DataPropertyName = "EmpCmpID";
            this.dgvtxtEmpCompID.HeaderText = "EmpCompID";
            this.dgvtxtEmpCompID.Name = "dgvtxtEmpCompID";
            this.dgvtxtEmpCompID.Visible = false;
            // 
            // dgvtxtCompanyName
            // 
            this.dgvtxtCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtCompanyName.DataPropertyName = "CompanyName";
            this.dgvtxtCompanyName.HeaderText = "Company Name";
            this.dgvtxtCompanyName.Name = "dgvtxtCompanyName";
            // 
            // dgvcmbPosition
            // 
            this.dgvcmbPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcmbPosition.DataPropertyName = "PositionID";
            this.dgvcmbPosition.HeaderText = "Position";
            this.dgvcmbPosition.Name = "dgvcmbPosition";
            this.dgvcmbPosition.Width = 71;
            // 
            // dgvtxtYear
            // 
            this.dgvtxtYear.DataPropertyName = "ExpYear";
            this.dgvtxtYear.HeaderText = "Year";
            this.dgvtxtYear.Name = "dgvtxtYear";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(127, 218);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(251, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(127, 172);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(251, 26);
            this.dtpDOB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Emp. Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Emp. Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(58, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.tabPage2.Controls.Add(this.dgvEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Register";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.Location = new System.Drawing.Point(17, 17);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 30;
            this.dgvEmployee.Size = new System.Drawing.Size(729, 534);
            this.dgvEmployee.TabIndex = 3;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(797, 626);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "C# Master Details CRUD APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCompany)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImageClear;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.RadioButton rbtContractual;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.RadioButton rbtRegular;
        private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DataGridView dgvEmpCompany;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmpCompID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCompanyName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtYear;

    }
}

