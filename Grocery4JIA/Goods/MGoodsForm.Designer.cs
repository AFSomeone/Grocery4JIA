namespace UI
{
    partial class MGoodsForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvMGoods = new System.Windows.Forms.DataGridView();
            this.colGId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCatg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLifeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCatgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStEnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGId = new System.Windows.Forms.Label();
            this.txtGId = new System.Windows.Forms.TextBox();
            this.lblGName = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.lblSt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSt = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboxCatg = new System.Windows.Forms.ComboBox();
            this.dgvPager = new dgv_pager.DGVPager();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1160, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加商品";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvMGoods
            // 
            this.dtgvMGoods.AllowUserToAddRows = false;
            this.dtgvMGoods.AllowUserToDeleteRows = false;
            this.dtgvMGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGId,
            this.colGName,
            this.colAbbr,
            this.colSpecs,
            this.colSubCatg,
            this.colShelfLifeDesc,
            this.colSt,
            this.colRemark,
            this.colSubCatgId,
            this.colStEnum,
            this.colShelfLife});
            this.dtgvMGoods.Location = new System.Drawing.Point(2, 62);
            this.dtgvMGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvMGoods.Name = "dtgvMGoods";
            this.dtgvMGoods.ReadOnly = true;
            this.dtgvMGoods.RowTemplate.Height = 27;
            this.dtgvMGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMGoods.Size = new System.Drawing.Size(1252, 572);
            this.dtgvMGoods.TabIndex = 7;
            this.dtgvMGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMGoods_CellDoubleClick);
            this.dtgvMGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvMGoods_CellFormatting);
            // 
            // colGId
            // 
            this.colGId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGId.DataPropertyName = "GID__PK";
            this.colGId.HeaderText = "商品编号";
            this.colGId.MaxInputLength = 100;
            this.colGId.Name = "colGId";
            this.colGId.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.DataPropertyName = "GName";
            this.colGName.HeaderText = "商品名称";
            this.colGName.MaxInputLength = 100;
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colAbbr
            // 
            this.colAbbr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAbbr.DataPropertyName = "Abbr";
            this.colAbbr.HeaderText = "字母简写";
            this.colAbbr.MaxInputLength = 100;
            this.colAbbr.Name = "colAbbr";
            this.colAbbr.ReadOnly = true;
            // 
            // colSpecs
            // 
            this.colSpecs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpecs.DataPropertyName = "Specs";
            this.colSpecs.HeaderText = "规格";
            this.colSpecs.MaxInputLength = 100;
            this.colSpecs.Name = "colSpecs";
            this.colSpecs.ReadOnly = true;
            // 
            // colSubCatg
            // 
            this.colSubCatg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubCatg.DataPropertyName = "CatgName";
            this.colSubCatg.HeaderText = "品类";
            this.colSubCatg.MaxInputLength = 100;
            this.colSubCatg.Name = "colSubCatg";
            this.colSubCatg.ReadOnly = true;
            // 
            // colShelfLifeDesc
            // 
            this.colShelfLifeDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShelfLifeDesc.DataPropertyName = "ShelfLife";
            this.colShelfLifeDesc.HeaderText = "保质期";
            this.colShelfLifeDesc.MaxInputLength = 100;
            this.colShelfLifeDesc.Name = "colShelfLifeDesc";
            this.colShelfLifeDesc.ReadOnly = true;
            // 
            // colSt
            // 
            this.colSt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSt.DataPropertyName = "St";
            this.colSt.HeaderText = "状态";
            this.colSt.MaxInputLength = 100;
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.FillWeight = 200F;
            this.colRemark.HeaderText = "备注";
            this.colRemark.MaxInputLength = 500;
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colSubCatgId
            // 
            this.colSubCatgId.DataPropertyName = "SubCatgID";
            this.colSubCatgId.HeaderText = "SubCatgId";
            this.colSubCatgId.Name = "colSubCatgId";
            this.colSubCatgId.ReadOnly = true;
            this.colSubCatgId.Visible = false;
            // 
            // colStEnum
            // 
            this.colStEnum.DataPropertyName = "ST";
            this.colStEnum.HeaderText = "StEnum";
            this.colStEnum.Name = "colStEnum";
            this.colStEnum.ReadOnly = true;
            this.colStEnum.Visible = false;
            // 
            // colShelfLife
            // 
            this.colShelfLife.DataPropertyName = "ShelfLife";
            this.colShelfLife.HeaderText = "ShelfLife";
            this.colShelfLife.Name = "colShelfLife";
            this.colShelfLife.ReadOnly = true;
            this.colShelfLife.Visible = false;
            // 
            // lblGId
            // 
            this.lblGId.AutoSize = true;
            this.lblGId.Location = new System.Drawing.Point(277, 20);
            this.lblGId.Name = "lblGId";
            this.lblGId.Size = new System.Drawing.Size(68, 15);
            this.lblGId.TabIndex = 0;
            this.lblGId.Text = "商品ID：";
            // 
            // txtGId
            // 
            this.txtGId.Location = new System.Drawing.Point(361, 15);
            this.txtGId.MaxLength = 100;
            this.txtGId.Name = "txtGId";
            this.txtGId.Size = new System.Drawing.Size(150, 25);
            this.txtGId.TabIndex = 3;
            // 
            // lblGName
            // 
            this.lblGName.AutoSize = true;
            this.lblGName.Location = new System.Drawing.Point(7, 20);
            this.lblGName.Name = "lblGName";
            this.lblGName.Size = new System.Drawing.Size(82, 15);
            this.lblGName.TabIndex = 0;
            this.lblGName.Text = "商品名称：";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(95, 15);
            this.txtGName.MaxLength = 100;
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(150, 25);
            this.txtGName.TabIndex = 1;
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(787, 20);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(52, 15);
            this.lblSt.TabIndex = 0;
            this.lblSt.Text = "状态：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "品类：";
            // 
            // cboxSt
            // 
            this.cboxSt.FormattingEnabled = true;
            this.cboxSt.Location = new System.Drawing.Point(845, 16);
            this.cboxSt.Name = "cboxSt";
            this.cboxSt.Size = new System.Drawing.Size(150, 23);
            this.cboxSt.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1047, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboxCatg
            // 
            this.cboxCatg.FormattingEnabled = true;
            this.cboxCatg.Location = new System.Drawing.Point(608, 16);
            this.cboxCatg.Name = "cboxCatg";
            this.cboxCatg.Size = new System.Drawing.Size(150, 23);
            this.cboxCatg.TabIndex = 2;
            // 
            // dgvPager
            // 
            this.dgvPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPager.Location = new System.Drawing.Point(0, 637);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1257, 39);
            this.dgvPager.TabIndex = 8;
            this.dgvPager.TotalNum = 0;
            this.dgvPager.TotalPageNum = 0;
            this.dgvPager.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvPager_pagerBtnClicked);
            // 
            // MGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 676);
            this.Controls.Add(this.dgvPager);
            this.Controls.Add(this.cboxCatg);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cboxSt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.txtGName);
            this.Controls.Add(this.lblGName);
            this.Controls.Add(this.txtGId);
            this.Controls.Add(this.lblGId);
            this.Controls.Add(this.dtgvMGoods);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MGoodsForm";
            this.ShowIcon = false;
            this.Text = "MGoodsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MGoodsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvMGoods;
        private System.Windows.Forms.Label lblGId;
        private System.Windows.Forms.TextBox txtGId;
        private System.Windows.Forms.Label lblGName;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSt;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboxCatg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCatg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLifeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCatgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStEnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLife;
        private dgv_pager.DGVPager dgvPager;
    }
}