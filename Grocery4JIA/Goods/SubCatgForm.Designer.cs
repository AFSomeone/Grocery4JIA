namespace UI
{
    partial class SubCatgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubCatgForm));
            this.dtgvSubCatg = new System.Windows.Forms.DataGridView();
            this.colCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinYin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxMdfy = new System.Windows.Forms.GroupBox();
            this.btnMdfy = new System.Windows.Forms.Button();
            this.rbtnMdfyInvalid = new System.Windows.Forms.RadioButton();
            this.rbtnMdfyValid = new System.Windows.Forms.RadioButton();
            this.lblMdfySt = new System.Windows.Forms.Label();
            this.txtMdfyAbbr = new System.Windows.Forms.TextBox();
            this.lblMdfyAbbr = new System.Windows.Forms.Label();
            this.txtMdfyPinyin = new System.Windows.Forms.TextBox();
            this.lblMdfyPinyin = new System.Windows.Forms.Label();
            this.cboxMdfySuperName = new System.Windows.Forms.ComboBox();
            this.lblMdfySuperName = new System.Windows.Forms.Label();
            this.txtMdfyCName = new System.Windows.Forms.TextBox();
            this.lblMdfyCName = new System.Windows.Forms.Label();
            this.gboxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnAddInvalid = new System.Windows.Forms.RadioButton();
            this.rbtnAddValid = new System.Windows.Forms.RadioButton();
            this.lblAddSt = new System.Windows.Forms.Label();
            this.txtAddAbbr = new System.Windows.Forms.TextBox();
            this.lblAddAbbr = new System.Windows.Forms.Label();
            this.txtAddPinyin = new System.Windows.Forms.TextBox();
            this.lblAddPinyin = new System.Windows.Forms.Label();
            this.cboxAddSuperName = new System.Windows.Forms.ComboBox();
            this.lblAddSuperName = new System.Windows.Forms.Label();
            this.txtAddCName = new System.Windows.Forms.TextBox();
            this.lblAddCName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubCatg)).BeginInit();
            this.gboxMdfy.SuspendLayout();
            this.gboxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSubCatg
            // 
            this.dtgvSubCatg.AllowUserToAddRows = false;
            this.dtgvSubCatg.AllowUserToDeleteRows = false;
            this.dtgvSubCatg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubCatg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCID,
            this.colCName,
            this.colSuperCName,
            this.colPinYin,
            this.colAbbr,
            this.colSt,
            this.colSuperID,
            this.colStEnum});
            this.dtgvSubCatg.Location = new System.Drawing.Point(12, 12);
            this.dtgvSubCatg.MultiSelect = false;
            this.dtgvSubCatg.Name = "dtgvSubCatg";
            this.dtgvSubCatg.ReadOnly = true;
            this.dtgvSubCatg.RowTemplate.Height = 27;
            this.dtgvSubCatg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvSubCatg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSubCatg.Size = new System.Drawing.Size(875, 405);
            this.dtgvSubCatg.TabIndex = 0;
            this.dtgvSubCatg.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvSubCatg_CellFormatting);
            this.dtgvSubCatg.SelectionChanged += new System.EventHandler(this.dtgvSubCatg_SelectionChanged);
            // 
            // colCID
            // 
            this.colCID.DataPropertyName = "CId__PK";
            this.colCID.HeaderText = "分类编码";
            this.colCID.MaxInputLength = 100;
            this.colCID.Name = "colCID";
            this.colCID.ReadOnly = true;
            this.colCID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCName
            // 
            this.colCName.DataPropertyName = "CName";
            this.colCName.HeaderText = "分类名称";
            this.colCName.MaxInputLength = 100;
            this.colCName.Name = "colCName";
            this.colCName.ReadOnly = true;
            this.colCName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSuperCName
            // 
            this.colSuperCName.DataPropertyName = "SuperName";
            this.colSuperCName.HeaderText = "综合分类";
            this.colSuperCName.MaxInputLength = 100;
            this.colSuperCName.Name = "colSuperCName";
            this.colSuperCName.ReadOnly = true;
            this.colSuperCName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPinYin
            // 
            this.colPinYin.DataPropertyName = "PinYin";
            this.colPinYin.HeaderText = "拼音";
            this.colPinYin.MaxInputLength = 100;
            this.colPinYin.Name = "colPinYin";
            this.colPinYin.ReadOnly = true;
            this.colPinYin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colAbbr
            // 
            this.colAbbr.DataPropertyName = "Abbr";
            this.colAbbr.HeaderText = "字母缩写";
            this.colAbbr.MaxInputLength = 100;
            this.colAbbr.Name = "colAbbr";
            this.colAbbr.ReadOnly = true;
            this.colAbbr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSt
            // 
            this.colSt.DataPropertyName = "St";
            this.colSt.HeaderText = "状态";
            this.colSt.MaxInputLength = 100;
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            this.colSt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSuperID
            // 
            this.colSuperID.DataPropertyName = "SuperId";
            this.colSuperID.FillWeight = 20F;
            this.colSuperID.HeaderText = "SuperID";
            this.colSuperID.MaxInputLength = 20;
            this.colSuperID.Name = "colSuperID";
            this.colSuperID.ReadOnly = true;
            this.colSuperID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSuperID.Visible = false;
            this.colSuperID.Width = 20;
            // 
            // colStEnum
            // 
            this.colStEnum.DataPropertyName = "St";
            this.colStEnum.FillWeight = 10F;
            this.colStEnum.HeaderText = "StEnum";
            this.colStEnum.MaxInputLength = 10;
            this.colStEnum.Name = "colStEnum";
            this.colStEnum.ReadOnly = true;
            this.colStEnum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStEnum.Visible = false;
            this.colStEnum.Width = 10;
            // 
            // gboxMdfy
            // 
            this.gboxMdfy.Controls.Add(this.btnMdfy);
            this.gboxMdfy.Controls.Add(this.rbtnMdfyInvalid);
            this.gboxMdfy.Controls.Add(this.rbtnMdfyValid);
            this.gboxMdfy.Controls.Add(this.lblMdfySt);
            this.gboxMdfy.Controls.Add(this.txtMdfyAbbr);
            this.gboxMdfy.Controls.Add(this.lblMdfyAbbr);
            this.gboxMdfy.Controls.Add(this.txtMdfyPinyin);
            this.gboxMdfy.Controls.Add(this.lblMdfyPinyin);
            this.gboxMdfy.Controls.Add(this.cboxMdfySuperName);
            this.gboxMdfy.Controls.Add(this.lblMdfySuperName);
            this.gboxMdfy.Controls.Add(this.txtMdfyCName);
            this.gboxMdfy.Controls.Add(this.lblMdfyCName);
            this.gboxMdfy.Location = new System.Drawing.Point(12, 433);
            this.gboxMdfy.Name = "gboxMdfy";
            this.gboxMdfy.Size = new System.Drawing.Size(875, 136);
            this.gboxMdfy.TabIndex = 1;
            this.gboxMdfy.TabStop = false;
            this.gboxMdfy.Text = "修改分类";
            // 
            // btnMdfy
            // 
            this.btnMdfy.Location = new System.Drawing.Point(779, 86);
            this.btnMdfy.Name = "btnMdfy";
            this.btnMdfy.Size = new System.Drawing.Size(90, 30);
            this.btnMdfy.TabIndex = 7;
            this.btnMdfy.Text = "修改";
            this.btnMdfy.UseVisualStyleBackColor = true;
            this.btnMdfy.Click += new System.EventHandler(this.btnMdfy_Click);
            // 
            // rbtnMdfyInvalid
            // 
            this.rbtnMdfyInvalid.AutoSize = true;
            this.rbtnMdfyInvalid.Location = new System.Drawing.Point(485, 89);
            this.rbtnMdfyInvalid.Name = "rbtnMdfyInvalid";
            this.rbtnMdfyInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbtnMdfyInvalid.TabIndex = 6;
            this.rbtnMdfyInvalid.TabStop = true;
            this.rbtnMdfyInvalid.Text = "废弃";
            this.rbtnMdfyInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnMdfyValid
            // 
            this.rbtnMdfyValid.AutoSize = true;
            this.rbtnMdfyValid.Location = new System.Drawing.Point(386, 89);
            this.rbtnMdfyValid.Name = "rbtnMdfyValid";
            this.rbtnMdfyValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnMdfyValid.TabIndex = 5;
            this.rbtnMdfyValid.TabStop = true;
            this.rbtnMdfyValid.Text = "有效";
            this.rbtnMdfyValid.UseVisualStyleBackColor = true;
            // 
            // lblMdfySt
            // 
            this.lblMdfySt.AutoSize = true;
            this.lblMdfySt.Location = new System.Drawing.Point(328, 91);
            this.lblMdfySt.Name = "lblMdfySt";
            this.lblMdfySt.Size = new System.Drawing.Size(52, 15);
            this.lblMdfySt.TabIndex = 8;
            this.lblMdfySt.Text = "状态：";
            // 
            // txtMdfyAbbr
            // 
            this.txtMdfyAbbr.Location = new System.Drawing.Point(709, 37);
            this.txtMdfyAbbr.Name = "txtMdfyAbbr";
            this.txtMdfyAbbr.Size = new System.Drawing.Size(160, 25);
            this.txtMdfyAbbr.TabIndex = 3;
            // 
            // lblMdfyAbbr
            // 
            this.lblMdfyAbbr.AutoSize = true;
            this.lblMdfyAbbr.Location = new System.Drawing.Point(623, 42);
            this.lblMdfyAbbr.Name = "lblMdfyAbbr";
            this.lblMdfyAbbr.Size = new System.Drawing.Size(82, 15);
            this.lblMdfyAbbr.TabIndex = 6;
            this.lblMdfyAbbr.Text = "字母缩写：";
            // 
            // txtMdfyPinyin
            // 
            this.txtMdfyPinyin.Location = new System.Drawing.Point(383, 37);
            this.txtMdfyPinyin.Name = "txtMdfyPinyin";
            this.txtMdfyPinyin.Size = new System.Drawing.Size(160, 25);
            this.txtMdfyPinyin.TabIndex = 2;
            // 
            // lblMdfyPinyin
            // 
            this.lblMdfyPinyin.AutoSize = true;
            this.lblMdfyPinyin.Location = new System.Drawing.Point(328, 42);
            this.lblMdfyPinyin.Name = "lblMdfyPinyin";
            this.lblMdfyPinyin.Size = new System.Drawing.Size(52, 15);
            this.lblMdfyPinyin.TabIndex = 4;
            this.lblMdfyPinyin.Text = "拼音：";
            // 
            // cboxMdfySuperName
            // 
            this.cboxMdfySuperName.FormattingEnabled = true;
            this.cboxMdfySuperName.Location = new System.Drawing.Point(92, 87);
            this.cboxMdfySuperName.Name = "cboxMdfySuperName";
            this.cboxMdfySuperName.Size = new System.Drawing.Size(160, 23);
            this.cboxMdfySuperName.TabIndex = 4;
            // 
            // lblMdfySuperName
            // 
            this.lblMdfySuperName.AutoSize = true;
            this.lblMdfySuperName.Location = new System.Drawing.Point(7, 91);
            this.lblMdfySuperName.Name = "lblMdfySuperName";
            this.lblMdfySuperName.Size = new System.Drawing.Size(82, 15);
            this.lblMdfySuperName.TabIndex = 2;
            this.lblMdfySuperName.Text = "综合分类：";
            // 
            // txtMdfyCName
            // 
            this.txtMdfyCName.Location = new System.Drawing.Point(92, 37);
            this.txtMdfyCName.Name = "txtMdfyCName";
            this.txtMdfyCName.Size = new System.Drawing.Size(160, 25);
            this.txtMdfyCName.TabIndex = 1;
            // 
            // lblMdfyCName
            // 
            this.lblMdfyCName.AutoSize = true;
            this.lblMdfyCName.Location = new System.Drawing.Point(6, 42);
            this.lblMdfyCName.Name = "lblMdfyCName";
            this.lblMdfyCName.Size = new System.Drawing.Size(82, 15);
            this.lblMdfyCName.TabIndex = 0;
            this.lblMdfyCName.Text = "分类名称：";
            // 
            // gboxAdd
            // 
            this.gboxAdd.Controls.Add(this.btnAdd);
            this.gboxAdd.Controls.Add(this.rbtnAddInvalid);
            this.gboxAdd.Controls.Add(this.rbtnAddValid);
            this.gboxAdd.Controls.Add(this.lblAddSt);
            this.gboxAdd.Controls.Add(this.txtAddAbbr);
            this.gboxAdd.Controls.Add(this.lblAddAbbr);
            this.gboxAdd.Controls.Add(this.txtAddPinyin);
            this.gboxAdd.Controls.Add(this.lblAddPinyin);
            this.gboxAdd.Controls.Add(this.cboxAddSuperName);
            this.gboxAdd.Controls.Add(this.lblAddSuperName);
            this.gboxAdd.Controls.Add(this.txtAddCName);
            this.gboxAdd.Controls.Add(this.lblAddCName);
            this.gboxAdd.Location = new System.Drawing.Point(12, 575);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Size = new System.Drawing.Size(875, 136);
            this.gboxAdd.TabIndex = 2;
            this.gboxAdd.TabStop = false;
            this.gboxAdd.Text = "增加分类";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(779, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnAddInvalid
            // 
            this.rbtnAddInvalid.AutoSize = true;
            this.rbtnAddInvalid.Enabled = false;
            this.rbtnAddInvalid.Location = new System.Drawing.Point(485, 89);
            this.rbtnAddInvalid.Name = "rbtnAddInvalid";
            this.rbtnAddInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbtnAddInvalid.TabIndex = 13;
            this.rbtnAddInvalid.Text = "废弃";
            this.rbtnAddInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnAddValid
            // 
            this.rbtnAddValid.AutoSize = true;
            this.rbtnAddValid.Checked = true;
            this.rbtnAddValid.Enabled = false;
            this.rbtnAddValid.Location = new System.Drawing.Point(386, 89);
            this.rbtnAddValid.Name = "rbtnAddValid";
            this.rbtnAddValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnAddValid.TabIndex = 12;
            this.rbtnAddValid.TabStop = true;
            this.rbtnAddValid.Text = "有效";
            this.rbtnAddValid.UseVisualStyleBackColor = true;
            // 
            // lblAddSt
            // 
            this.lblAddSt.AutoSize = true;
            this.lblAddSt.Location = new System.Drawing.Point(328, 91);
            this.lblAddSt.Name = "lblAddSt";
            this.lblAddSt.Size = new System.Drawing.Size(52, 15);
            this.lblAddSt.TabIndex = 8;
            this.lblAddSt.Text = "状态：";
            // 
            // txtAddAbbr
            // 
            this.txtAddAbbr.Location = new System.Drawing.Point(709, 37);
            this.txtAddAbbr.Name = "txtAddAbbr";
            this.txtAddAbbr.Size = new System.Drawing.Size(160, 25);
            this.txtAddAbbr.TabIndex = 10;
            // 
            // lblAddAbbr
            // 
            this.lblAddAbbr.AutoSize = true;
            this.lblAddAbbr.Location = new System.Drawing.Point(623, 42);
            this.lblAddAbbr.Name = "lblAddAbbr";
            this.lblAddAbbr.Size = new System.Drawing.Size(82, 15);
            this.lblAddAbbr.TabIndex = 6;
            this.lblAddAbbr.Text = "字母缩写：";
            // 
            // txtAddPinyin
            // 
            this.txtAddPinyin.Location = new System.Drawing.Point(383, 37);
            this.txtAddPinyin.Name = "txtAddPinyin";
            this.txtAddPinyin.Size = new System.Drawing.Size(160, 25);
            this.txtAddPinyin.TabIndex = 9;
            // 
            // lblAddPinyin
            // 
            this.lblAddPinyin.AutoSize = true;
            this.lblAddPinyin.Location = new System.Drawing.Point(328, 42);
            this.lblAddPinyin.Name = "lblAddPinyin";
            this.lblAddPinyin.Size = new System.Drawing.Size(52, 15);
            this.lblAddPinyin.TabIndex = 4;
            this.lblAddPinyin.Text = "拼音：";
            // 
            // cboxAddSuperName
            // 
            this.cboxAddSuperName.FormattingEnabled = true;
            this.cboxAddSuperName.Location = new System.Drawing.Point(92, 87);
            this.cboxAddSuperName.Name = "cboxAddSuperName";
            this.cboxAddSuperName.Size = new System.Drawing.Size(160, 23);
            this.cboxAddSuperName.TabIndex = 11;
            // 
            // lblAddSuperName
            // 
            this.lblAddSuperName.AutoSize = true;
            this.lblAddSuperName.Location = new System.Drawing.Point(7, 91);
            this.lblAddSuperName.Name = "lblAddSuperName";
            this.lblAddSuperName.Size = new System.Drawing.Size(82, 15);
            this.lblAddSuperName.TabIndex = 2;
            this.lblAddSuperName.Text = "综合分类：";
            // 
            // txtAddCName
            // 
            this.txtAddCName.Location = new System.Drawing.Point(92, 37);
            this.txtAddCName.Name = "txtAddCName";
            this.txtAddCName.Size = new System.Drawing.Size(160, 25);
            this.txtAddCName.TabIndex = 8;
            // 
            // lblAddCName
            // 
            this.lblAddCName.AutoSize = true;
            this.lblAddCName.Location = new System.Drawing.Point(6, 42);
            this.lblAddCName.Name = "lblAddCName";
            this.lblAddCName.Size = new System.Drawing.Size(82, 15);
            this.lblAddCName.TabIndex = 0;
            this.lblAddCName.Text = "分类名称：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(791, 727);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SubCatgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 771);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxAdd);
            this.Controls.Add(this.gboxMdfy);
            this.Controls.Add(this.dtgvSubCatg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubCatgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品分类";
            this.Load += new System.EventHandler(this.SubCatgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubCatg)).EndInit();
            this.gboxMdfy.ResumeLayout(false);
            this.gboxMdfy.PerformLayout();
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSubCatg;
        private System.Windows.Forms.GroupBox gboxMdfy;
        private System.Windows.Forms.TextBox txtMdfyAbbr;
        private System.Windows.Forms.Label lblMdfyAbbr;
        private System.Windows.Forms.TextBox txtMdfyPinyin;
        private System.Windows.Forms.Label lblMdfyPinyin;
        private System.Windows.Forms.ComboBox cboxMdfySuperName;
        private System.Windows.Forms.Label lblMdfySuperName;
        private System.Windows.Forms.TextBox txtMdfyCName;
        private System.Windows.Forms.Label lblMdfyCName;
        private System.Windows.Forms.RadioButton rbtnMdfyInvalid;
        private System.Windows.Forms.RadioButton rbtnMdfyValid;
        private System.Windows.Forms.Label lblMdfySt;
        private System.Windows.Forms.Button btnMdfy;
        private System.Windows.Forms.GroupBox gboxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnAddInvalid;
        private System.Windows.Forms.RadioButton rbtnAddValid;
        private System.Windows.Forms.Label lblAddSt;
        private System.Windows.Forms.TextBox txtAddAbbr;
        private System.Windows.Forms.Label lblAddAbbr;
        private System.Windows.Forms.TextBox txtAddPinyin;
        private System.Windows.Forms.Label lblAddPinyin;
        private System.Windows.Forms.ComboBox cboxAddSuperName;
        private System.Windows.Forms.Label lblAddSuperName;
        private System.Windows.Forms.TextBox txtAddCName;
        private System.Windows.Forms.Label lblAddCName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPinYin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStEnum;
    }
}