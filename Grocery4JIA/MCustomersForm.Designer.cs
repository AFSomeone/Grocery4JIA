namespace UI
{
    partial class MCustomersForm
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
            this.lblCName = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.lblLinkMan = new System.Windows.Forms.Label();
            this.txtLinkMan = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvCustomers = new System.Windows.Forms.DataGridView();
            this.colCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGradeEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSt = new System.Windows.Forms.Label();
            this.cboxSt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(10, 18);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(98, 15);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "客户  名称：";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(113, 13);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(150, 25);
            this.txtCName.TabIndex = 1;
            // 
            // lblLinkMan
            // 
            this.lblLinkMan.AutoSize = true;
            this.lblLinkMan.Location = new System.Drawing.Point(294, 18);
            this.lblLinkMan.Name = "lblLinkMan";
            this.lblLinkMan.Size = new System.Drawing.Size(67, 15);
            this.lblLinkMan.TabIndex = 0;
            this.lblLinkMan.Text = "联系人：";
            // 
            // txtLinkMan
            // 
            this.txtLinkMan.Location = new System.Drawing.Point(367, 13);
            this.txtLinkMan.Name = "txtLinkMan";
            this.txtLinkMan.Size = new System.Drawing.Size(150, 25);
            this.txtLinkMan.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(838, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(952, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加客户";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvCustomers
            // 
            this.dtgvCustomers.AllowUserToAddRows = false;
            this.dtgvCustomers.AllowUserToDeleteRows = false;
            this.dtgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCID,
            this.colCName,
            this.colAddress,
            this.colTel,
            this.colPhone,
            this.colFax,
            this.colEmail,
            this.colLinkMan,
            this.colGrade,
            this.colSt,
            this.colRemark,
            this.colStEnum,
            this.colGradeEnum});
            this.dtgvCustomers.Location = new System.Drawing.Point(4, 55);
            this.dtgvCustomers.Name = "dtgvCustomers";
            this.dtgvCustomers.ReadOnly = true;
            this.dtgvCustomers.RowTemplate.Height = 27;
            this.dtgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCustomers.Size = new System.Drawing.Size(1293, 522);
            this.dtgvCustomers.TabIndex = 7;
            this.dtgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomers_CellDoubleClick);
            this.dtgvCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvCustomers_CellFormatting);
            // 
            // colCID
            // 
            this.colCID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCID.DataPropertyName = "CID__PK";
            this.colCID.HeaderText = "客户ID";
            this.colCID.MaxInputLength = 100;
            this.colCID.Name = "colCID";
            this.colCID.ReadOnly = true;
            // 
            // colCName
            // 
            this.colCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCName.DataPropertyName = "CName";
            this.colCName.HeaderText = "客户名称";
            this.colCName.MaxInputLength = 100;
            this.colCName.Name = "colCName";
            this.colCName.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "地址";
            this.colAddress.MaxInputLength = 100;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colTel
            // 
            this.colTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTel.DataPropertyName = "Tel";
            this.colTel.HeaderText = "电话";
            this.colTel.MaxInputLength = 100;
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "手机";
            this.colPhone.MaxInputLength = 100;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colFax
            // 
            this.colFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFax.DataPropertyName = "Fax";
            this.colFax.HeaderText = "传真";
            this.colFax.MaxInputLength = 100;
            this.colFax.Name = "colFax";
            this.colFax.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MaxInputLength = 100;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colLinkMan
            // 
            this.colLinkMan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLinkMan.DataPropertyName = "LinkMan";
            this.colLinkMan.HeaderText = "联系人";
            this.colLinkMan.MaxInputLength = 200;
            this.colLinkMan.Name = "colLinkMan";
            this.colLinkMan.ReadOnly = true;
            // 
            // colGrade
            // 
            this.colGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGrade.DataPropertyName = "Grade";
            this.colGrade.HeaderText = "层级";
            this.colGrade.MaxInputLength = 100;
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // colSt
            // 
            this.colSt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSt.DataPropertyName = "St";
            this.colSt.HeaderText = "状态";
            this.colSt.MaxInputLength = 50;
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colStEnum
            // 
            this.colStEnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStEnum.DataPropertyName = "St";
            this.colStEnum.HeaderText = "StEnum";
            this.colStEnum.MaxInputLength = 10;
            this.colStEnum.Name = "colStEnum";
            this.colStEnum.ReadOnly = true;
            this.colStEnum.Visible = false;
            // 
            // colGradeEnum
            // 
            this.colGradeEnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGradeEnum.DataPropertyName = "Grade";
            this.colGradeEnum.HeaderText = "GradeEnum";
            this.colGradeEnum.MaxInputLength = 100;
            this.colGradeEnum.Name = "colGradeEnum";
            this.colGradeEnum.ReadOnly = true;
            this.colGradeEnum.Visible = false;
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(551, 18);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(52, 15);
            this.lblSt.TabIndex = 0;
            this.lblSt.Text = "状态：";
            // 
            // cboxSt
            // 
            this.cboxSt.FormattingEnabled = true;
            this.cboxSt.Location = new System.Drawing.Point(609, 14);
            this.cboxSt.Name = "cboxSt";
            this.cboxSt.Size = new System.Drawing.Size(150, 23);
            this.cboxSt.TabIndex = 4;
            // 
            // MCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 580);
            this.Controls.Add(this.cboxSt);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.dtgvCustomers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtLinkMan);
            this.Controls.Add(this.lblLinkMan);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.lblCName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MCustomersForm";
            this.Text = "MCustomersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label lblLinkMan;
        private System.Windows.Forms.TextBox txtLinkMan;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvCustomers;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.ComboBox cboxSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStEnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGradeEnum;
    }
}