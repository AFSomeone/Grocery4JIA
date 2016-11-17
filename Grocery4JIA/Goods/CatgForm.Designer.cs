namespace UI
{
    partial class CatgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatgForm));
            this.dtgvCatg = new System.Windows.Forms.DataGridView();
            this.colCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtMdfyName = new System.Windows.Forms.TextBox();
            this.lblMdfyName = new System.Windows.Forms.Label();
            this.lblMdfySt = new System.Windows.Forms.Label();
            this.rbtnMdfyInvalid = new System.Windows.Forms.RadioButton();
            this.rbtnMdfyValid = new System.Windows.Forms.RadioButton();
            this.gboxModify = new System.Windows.Forms.GroupBox();
            this.gboxAdd = new System.Windows.Forms.GroupBox();
            this.rbtnAddInvalid = new System.Windows.Forms.RadioButton();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnAddValid = new System.Windows.Forms.RadioButton();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddSt = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatg)).BeginInit();
            this.gboxModify.SuspendLayout();
            this.gboxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCatg
            // 
            this.dtgvCatg.AllowUserToAddRows = false;
            this.dtgvCatg.AllowUserToDeleteRows = false;
            this.dtgvCatg.AllowUserToResizeColumns = false;
            this.dtgvCatg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCatg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCId,
            this.colName,
            this.colSt,
            this.colStEnum});
            this.dtgvCatg.Location = new System.Drawing.Point(14, 14);
            this.dtgvCatg.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvCatg.Name = "dtgvCatg";
            this.dtgvCatg.ReadOnly = true;
            this.dtgvCatg.RowTemplate.Height = 27;
            this.dtgvCatg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvCatg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCatg.Size = new System.Drawing.Size(588, 395);
            this.dtgvCatg.TabIndex = 0;
            this.dtgvCatg.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvCatg_CellFormatting);
            this.dtgvCatg.SelectionChanged += new System.EventHandler(this.dtgvCatg_SelectionChanged);
            // 
            // colCId
            // 
            this.colCId.DataPropertyName = "CId__PK";
            this.colCId.HeaderText = "分类编号";
            this.colCId.MaxInputLength = 100;
            this.colCId.Name = "colCId";
            this.colCId.ReadOnly = true;
            this.colCId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "CName";
            this.colName.FillWeight = 200F;
            this.colName.HeaderText = "分类名称";
            this.colName.MaxInputLength = 200;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.Width = 200;
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            this.colSt.HeaderText = "状态";
            this.colSt.MaxInputLength = 20;
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            this.colSt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colStEnum
            // 
            this.colStEnum.DataPropertyName = "ST";
            this.colStEnum.FillWeight = 10F;
            this.colStEnum.HeaderText = "stEnum";
            this.colStEnum.MaxInputLength = 10;
            this.colStEnum.Name = "colStEnum";
            this.colStEnum.ReadOnly = true;
            this.colStEnum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStEnum.Visible = false;
            this.colStEnum.Width = 10;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(497, 28);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 30);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtMdfyName
            // 
            this.txtMdfyName.Location = new System.Drawing.Point(90, 28);
            this.txtMdfyName.Name = "txtMdfyName";
            this.txtMdfyName.Size = new System.Drawing.Size(180, 25);
            this.txtMdfyName.TabIndex = 4;
            // 
            // lblMdfyName
            // 
            this.lblMdfyName.AutoSize = true;
            this.lblMdfyName.Location = new System.Drawing.Point(5, 33);
            this.lblMdfyName.Name = "lblMdfyName";
            this.lblMdfyName.Size = new System.Drawing.Size(82, 15);
            this.lblMdfyName.TabIndex = 5;
            this.lblMdfyName.Text = "分类名称：";
            // 
            // lblMdfySt
            // 
            this.lblMdfySt.AutoSize = true;
            this.lblMdfySt.Location = new System.Drawing.Point(293, 33);
            this.lblMdfySt.Name = "lblMdfySt";
            this.lblMdfySt.Size = new System.Drawing.Size(52, 15);
            this.lblMdfySt.TabIndex = 6;
            this.lblMdfySt.Text = "状态：";
            // 
            // rbtnMdfyInvalid
            // 
            this.rbtnMdfyInvalid.AutoSize = true;
            this.rbtnMdfyInvalid.Location = new System.Drawing.Point(405, 32);
            this.rbtnMdfyInvalid.Name = "rbtnMdfyInvalid";
            this.rbtnMdfyInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbtnMdfyInvalid.TabIndex = 1;
            this.rbtnMdfyInvalid.TabStop = true;
            this.rbtnMdfyInvalid.Text = "废弃";
            this.rbtnMdfyInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnMdfyValid
            // 
            this.rbtnMdfyValid.AutoSize = true;
            this.rbtnMdfyValid.Location = new System.Drawing.Point(341, 32);
            this.rbtnMdfyValid.Name = "rbtnMdfyValid";
            this.rbtnMdfyValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnMdfyValid.TabIndex = 0;
            this.rbtnMdfyValid.TabStop = true;
            this.rbtnMdfyValid.Text = "有效";
            this.rbtnMdfyValid.UseVisualStyleBackColor = true;
            // 
            // gboxModify
            // 
            this.gboxModify.Controls.Add(this.rbtnMdfyInvalid);
            this.gboxModify.Controls.Add(this.txtMdfyName);
            this.gboxModify.Controls.Add(this.btnModify);
            this.gboxModify.Controls.Add(this.rbtnMdfyValid);
            this.gboxModify.Controls.Add(this.lblMdfyName);
            this.gboxModify.Controls.Add(this.lblMdfySt);
            this.gboxModify.Location = new System.Drawing.Point(14, 417);
            this.gboxModify.Name = "gboxModify";
            this.gboxModify.Size = new System.Drawing.Size(588, 77);
            this.gboxModify.TabIndex = 10;
            this.gboxModify.TabStop = false;
            this.gboxModify.Text = "修改分类";
            // 
            // gboxAdd
            // 
            this.gboxAdd.Controls.Add(this.rbtnAddInvalid);
            this.gboxAdd.Controls.Add(this.txtAddName);
            this.gboxAdd.Controls.Add(this.btnAdd);
            this.gboxAdd.Controls.Add(this.rbtnAddValid);
            this.gboxAdd.Controls.Add(this.lblAddName);
            this.gboxAdd.Controls.Add(this.lblAddSt);
            this.gboxAdd.Location = new System.Drawing.Point(14, 502);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Size = new System.Drawing.Size(588, 77);
            this.gboxAdd.TabIndex = 11;
            this.gboxAdd.TabStop = false;
            this.gboxAdd.Text = "增加分类";
            // 
            // rbtnAddInvalid
            // 
            this.rbtnAddInvalid.AutoSize = true;
            this.rbtnAddInvalid.Enabled = false;
            this.rbtnAddInvalid.Location = new System.Drawing.Point(405, 32);
            this.rbtnAddInvalid.Name = "rbtnAddInvalid";
            this.rbtnAddInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbtnAddInvalid.TabIndex = 1;
            this.rbtnAddInvalid.Text = "废弃";
            this.rbtnAddInvalid.UseVisualStyleBackColor = true;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(90, 28);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(180, 25);
            this.txtAddName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnAddValid
            // 
            this.rbtnAddValid.AutoSize = true;
            this.rbtnAddValid.Checked = true;
            this.rbtnAddValid.Enabled = false;
            this.rbtnAddValid.Location = new System.Drawing.Point(341, 32);
            this.rbtnAddValid.Name = "rbtnAddValid";
            this.rbtnAddValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnAddValid.TabIndex = 0;
            this.rbtnAddValid.TabStop = true;
            this.rbtnAddValid.Text = "有效";
            this.rbtnAddValid.UseVisualStyleBackColor = true;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(5, 33);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(82, 15);
            this.lblAddName.TabIndex = 5;
            this.lblAddName.Text = "分类名称：";
            // 
            // lblAddSt
            // 
            this.lblAddSt.AutoSize = true;
            this.lblAddSt.Location = new System.Drawing.Point(293, 33);
            this.lblAddSt.Name = "lblAddSt";
            this.lblAddSt.Size = new System.Drawing.Size(52, 15);
            this.lblAddSt.TabIndex = 6;
            this.lblAddSt.Text = "状态：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(511, 588);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CatgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 630);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxAdd);
            this.Controls.Add(this.gboxModify);
            this.Controls.Add(this.dtgvCatg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "综合分类";
            this.Load += new System.EventHandler(this.CatgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCatg)).EndInit();
            this.gboxModify.ResumeLayout(false);
            this.gboxModify.PerformLayout();
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCatg;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtMdfyName;
        private System.Windows.Forms.Label lblMdfyName;
        private System.Windows.Forms.Label lblMdfySt;
        private System.Windows.Forms.RadioButton rbtnMdfyInvalid;
        private System.Windows.Forms.RadioButton rbtnMdfyValid;
        private System.Windows.Forms.GroupBox gboxModify;
        private System.Windows.Forms.GroupBox gboxAdd;
        private System.Windows.Forms.RadioButton rbtnAddInvalid;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnAddValid;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStEnum;
        private System.Windows.Forms.Button btnClose;
    }
}