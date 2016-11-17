namespace UI
{
    partial class MCustAcntForm
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
            this.cboxCust = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxGrade = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvAcnt = new System.Windows.Forms.DataGridView();
            this.colAcntNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcntTypeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatformDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcntType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcnt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(256, 21);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(52, 15);
            this.lblCName.TabIndex = 2;
            this.lblCName.Text = "客户：";
            // 
            // cboxCust
            // 
            this.cboxCust.FormattingEnabled = true;
            this.cboxCust.Location = new System.Drawing.Point(314, 17);
            this.cboxCust.Name = "cboxCust";
            this.cboxCust.Size = new System.Drawing.Size(250, 23);
            this.cboxCust.TabIndex = 2;
            this.cboxCust.SelectedIndexChanged += new System.EventHandler(this.cboxCust_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "层级：";
            // 
            // cboxGrade
            // 
            this.cboxGrade.FormattingEnabled = true;
            this.cboxGrade.Location = new System.Drawing.Point(66, 17);
            this.cboxGrade.Name = "cboxGrade";
            this.cboxGrade.Size = new System.Drawing.Size(160, 23);
            this.cboxGrade.TabIndex = 1;
            this.cboxGrade.SelectedIndexChanged += new System.EventHandler(this.cboxGrade_SelectedIndexChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(610, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(734, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "增加账户";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvAcnt
            // 
            this.dtgvAcnt.AllowUserToAddRows = false;
            this.dtgvAcnt.AllowUserToDeleteRows = false;
            this.dtgvAcnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAcnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAcnt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAcntNO,
            this.colAcntTypeDesc,
            this.colPlatformDesc,
            this.colStDesc,
            this.colID,
            this.colAcntType,
            this.colPlatform,
            this.colSt,
            this.colCustID});
            this.dtgvAcnt.Location = new System.Drawing.Point(0, 57);
            this.dtgvAcnt.Name = "dtgvAcnt";
            this.dtgvAcnt.ReadOnly = true;
            this.dtgvAcnt.RowTemplate.Height = 27;
            this.dtgvAcnt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAcnt.Size = new System.Drawing.Size(1196, 587);
            this.dtgvAcnt.TabIndex = 5;
            this.dtgvAcnt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcnt_CellDoubleClick);
            this.dtgvAcnt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvAcnt_CellFormatting);
            // 
            // colAcntNO
            // 
            this.colAcntNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAcntNO.DataPropertyName = "AcntNO";
            this.colAcntNO.FillWeight = 120F;
            this.colAcntNO.HeaderText = "账户";
            this.colAcntNO.Name = "colAcntNO";
            this.colAcntNO.ReadOnly = true;
            // 
            // colAcntTypeDesc
            // 
            this.colAcntTypeDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAcntTypeDesc.DataPropertyName = "AcntType";
            this.colAcntTypeDesc.HeaderText = "账户类型";
            this.colAcntTypeDesc.Name = "colAcntTypeDesc";
            this.colAcntTypeDesc.ReadOnly = true;
            // 
            // colPlatformDesc
            // 
            this.colPlatformDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlatformDesc.DataPropertyName = "Platform";
            this.colPlatformDesc.HeaderText = "支付平台";
            this.colPlatformDesc.Name = "colPlatformDesc";
            this.colPlatformDesc.ReadOnly = true;
            // 
            // colStDesc
            // 
            this.colStDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStDesc.DataPropertyName = "St";
            this.colStDesc.HeaderText = "状态";
            this.colStDesc.Name = "colStDesc";
            this.colStDesc.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID__PK";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colAcntType
            // 
            this.colAcntType.DataPropertyName = "AcntType";
            this.colAcntType.HeaderText = "AcntType";
            this.colAcntType.Name = "colAcntType";
            this.colAcntType.ReadOnly = true;
            this.colAcntType.Visible = false;
            // 
            // colPlatform
            // 
            this.colPlatform.DataPropertyName = "Platform";
            this.colPlatform.HeaderText = "Platform";
            this.colPlatform.Name = "colPlatform";
            this.colPlatform.ReadOnly = true;
            this.colPlatform.Visible = false;
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            this.colSt.HeaderText = "ST";
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            this.colSt.Visible = false;
            // 
            // colCustID
            // 
            this.colCustID.DataPropertyName = "CustID";
            this.colCustID.HeaderText = "CustID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            this.colCustID.Visible = false;
            // 
            // MCustAcntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 644);
            this.Controls.Add(this.dtgvAcnt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cboxGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCust);
            this.Controls.Add(this.lblCName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MCustAcntForm";
            this.Text = "MCustAcntForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.ComboBox cboxCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxGrade;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvAcnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcntNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcntTypeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatformDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcntType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
    }
}