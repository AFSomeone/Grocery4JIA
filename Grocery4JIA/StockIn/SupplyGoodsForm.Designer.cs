namespace UI
{
    partial class SupplyGoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyGoodsForm));
            this.cboxSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboxCatg = new System.Windows.Forms.ComboBox();
            this.lblCatg = new System.Windows.Forms.Label();
            this.dtgvMGoods = new System.Windows.Forms.DataGridView();
            this.colCkboxs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLifeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCatg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubCatgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvPager = new dgv_pager.DGVPager();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxSupplier.FormattingEnabled = true;
            this.cboxSupplier.ItemHeight = 16;
            this.cboxSupplier.Location = new System.Drawing.Point(82, 16);
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.Size = new System.Drawing.Size(250, 22);
            this.cboxSupplier.TabIndex = 18;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(10, 20);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblSupplier.TabIndex = 15;
            this.lblSupplier.Text = "供应商：";
            // 
            // cboxCatg
            // 
            this.cboxCatg.FormattingEnabled = true;
            this.cboxCatg.Location = new System.Drawing.Point(424, 16);
            this.cboxCatg.Name = "cboxCatg";
            this.cboxCatg.Size = new System.Drawing.Size(170, 23);
            this.cboxCatg.TabIndex = 19;
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(366, 20);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 16;
            this.lblCatg.Text = "品类：";
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
            this.colCkboxs,
            this.colGId,
            this.colGName,
            this.colSpecs,
            this.colShelfLifeDesc,
            this.colSubCatg,
            this.colRemark,
            this.colSubCatgId,
            this.colShelfLife,
            this.colSt,
            this.colAbbr});
            this.dtgvMGoods.Location = new System.Drawing.Point(9, 55);
            this.dtgvMGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvMGoods.Name = "dtgvMGoods";
            this.dtgvMGoods.ReadOnly = true;
            this.dtgvMGoods.RowTemplate.Height = 27;
            this.dtgvMGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMGoods.Size = new System.Drawing.Size(1274, 568);
            this.dtgvMGoods.TabIndex = 21;
            this.dtgvMGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMGoods_CellContentClick);
            // 
            // colCkboxs
            // 
            this.colCkboxs.FillWeight = 50F;
            this.colCkboxs.HeaderText = "";
            this.colCkboxs.Name = "colCkboxs";
            this.colCkboxs.ReadOnly = true;
            this.colCkboxs.Width = 60;
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
            this.colGName.FillWeight = 300F;
            this.colGName.HeaderText = "商品名称";
            this.colGName.MaxInputLength = 100;
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colSpecs
            // 
            this.colSpecs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpecs.DataPropertyName = "Specs";
            this.colSpecs.FillWeight = 120F;
            this.colSpecs.HeaderText = "规格";
            this.colSpecs.MaxInputLength = 100;
            this.colSpecs.Name = "colSpecs";
            this.colSpecs.ReadOnly = true;
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
            // colSubCatg
            // 
            this.colSubCatg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubCatg.DataPropertyName = "CatgName";
            this.colSubCatg.FillWeight = 120F;
            this.colSubCatg.HeaderText = "品类";
            this.colSubCatg.MaxInputLength = 100;
            this.colSubCatg.Name = "colSubCatg";
            this.colSubCatg.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
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
            // colShelfLife
            // 
            this.colShelfLife.DataPropertyName = "ShelfLife";
            this.colShelfLife.HeaderText = "ShelfLife";
            this.colShelfLife.Name = "colShelfLife";
            this.colShelfLife.ReadOnly = true;
            this.colShelfLife.Visible = false;
            // 
            // colSt
            // 
            this.colSt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSt.DataPropertyName = "ST";
            this.colSt.HeaderText = "StEnum";
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            this.colSt.Visible = false;
            // 
            // colAbbr
            // 
            this.colAbbr.DataPropertyName = "Abbr";
            this.colAbbr.HeaderText = "Abbr";
            this.colAbbr.Name = "colAbbr";
            this.colAbbr.ReadOnly = true;
            this.colAbbr.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(897, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(780, 12);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(85, 30);
            this.btnAddToList.TabIndex = 35;
            this.btnAddToList.Text = "加入订单";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(657, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 34;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvPager
            // 
            this.dgvPager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPager.Location = new System.Drawing.Point(9, 626);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1274, 36);
            this.dgvPager.TabIndex = 37;
            this.dgvPager.TotalNum = 0;
            this.dgvPager.TotalPageNum = 0;
            this.dgvPager.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvPager_pagerBtnClicked);
            // 
            // SupplyGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 667);
            this.Controls.Add(this.dgvPager);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cboxSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cboxCatg);
            this.Controls.Add(this.lblCatg);
            this.Controls.Add(this.dtgvMGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplyGoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboxCatg;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.DataGridView dtgvMGoods;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCkboxs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLifeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCatg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubCatgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbbr;
        private dgv_pager.DGVPager dgvPager;
    }
}