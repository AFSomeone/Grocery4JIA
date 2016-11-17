namespace UI
{
    partial class SoldGoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldGoodsForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtOrderNO = new System.Windows.Forms.TextBox();
            this.lbOutOrderNO = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboxResellers = new System.Windows.Forms.ComboBox();
            this.cboxCatgs = new System.Windows.Forms.ComboBox();
            this.lblCatg = new System.Windows.Forms.Label();
            this.dtgvSoldGoods = new System.Windows.Forms.DataGridView();
            this.colCkboxs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSinOrdreNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRfNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTgtSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPager = new dgv_pager.DGVPager();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSoldGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1129, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(1019, 11);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(85, 30);
            this.btnAddToList.TabIndex = 42;
            this.btnAddToList.Text = "加入订单";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(907, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 41;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtOrderNO
            // 
            this.txtOrderNO.Location = new System.Drawing.Point(686, 14);
            this.txtOrderNO.MaxLength = 100;
            this.txtOrderNO.Name = "txtOrderNO";
            this.txtOrderNO.Size = new System.Drawing.Size(180, 25);
            this.txtOrderNO.TabIndex = 39;
            // 
            // lbOutOrderNO
            // 
            this.lbOutOrderNO.AutoSize = true;
            this.lbOutOrderNO.Location = new System.Drawing.Point(598, 19);
            this.lbOutOrderNO.Name = "lbOutOrderNO";
            this.lbOutOrderNO.Size = new System.Drawing.Size(82, 15);
            this.lbOutOrderNO.TabIndex = 34;
            this.lbOutOrderNO.Text = "出货单号：";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(3, 17);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblSupplier.TabIndex = 35;
            this.lblSupplier.Text = "分销商：";
            // 
            // cboxResellers
            // 
            this.cboxResellers.FormattingEnabled = true;
            this.cboxResellers.Location = new System.Drawing.Point(76, 13);
            this.cboxResellers.Name = "cboxResellers";
            this.cboxResellers.Size = new System.Drawing.Size(250, 23);
            this.cboxResellers.TabIndex = 37;
            // 
            // cboxCatgs
            // 
            this.cboxCatgs.FormattingEnabled = true;
            this.cboxCatgs.Location = new System.Drawing.Point(417, 13);
            this.cboxCatgs.Name = "cboxCatgs";
            this.cboxCatgs.Size = new System.Drawing.Size(150, 23);
            this.cboxCatgs.TabIndex = 38;
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(359, 17);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 36;
            this.lblCatg.Text = "品类：";
            // 
            // dtgvSoldGoods
            // 
            this.dtgvSoldGoods.AllowUserToAddRows = false;
            this.dtgvSoldGoods.AllowUserToDeleteRows = false;
            this.dtgvSoldGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSoldGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSoldGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCkboxs,
            this.colSinOrdreNO,
            this.colGId,
            this.colGName,
            this.colSpecs,
            this.colPrice,
            this.colInvNum,
            this.colRfNum,
            this.colExpDt,
            this.colRemark,
            this.colInvID,
            this.colTgtSID});
            this.dtgvSoldGoods.Location = new System.Drawing.Point(9, 56);
            this.dtgvSoldGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvSoldGoods.Name = "dtgvSoldGoods";
            this.dtgvSoldGoods.ReadOnly = true;
            this.dtgvSoldGoods.RowTemplate.Height = 27;
            this.dtgvSoldGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSoldGoods.Size = new System.Drawing.Size(1390, 650);
            this.dtgvSoldGoods.TabIndex = 40;
            this.dtgvSoldGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSoldGoods_CellContentClick);
            // 
            // colCkboxs
            // 
            this.colCkboxs.FillWeight = 50F;
            this.colCkboxs.HeaderText = "";
            this.colCkboxs.Name = "colCkboxs";
            this.colCkboxs.ReadOnly = true;
            this.colCkboxs.Width = 50;
            // 
            // colSinOrdreNO
            // 
            this.colSinOrdreNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSinOrdreNO.DataPropertyName = "OrderNO";
            this.colSinOrdreNO.FillWeight = 120F;
            this.colSinOrdreNO.HeaderText = "出货单号";
            this.colSinOrdreNO.Name = "colSinOrdreNO";
            this.colSinOrdreNO.ReadOnly = true;
            // 
            // colGId
            // 
            this.colGId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGId.DataPropertyName = "GID";
            this.colGId.HeaderText = "商品编号";
            this.colGId.MaxInputLength = 100;
            this.colGId.Name = "colGId";
            this.colGId.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.DataPropertyName = "GName";
            this.colGName.FillWeight = 200F;
            this.colGName.HeaderText = "商品名称";
            this.colGName.MaxInputLength = 100;
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
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
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "单价/元";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colInvNum
            // 
            this.colInvNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvNum.DataPropertyName = "Num";
            this.colInvNum.HeaderText = "售出量";
            this.colInvNum.Name = "colInvNum";
            this.colInvNum.ReadOnly = true;
            // 
            // colRfNum
            // 
            this.colRfNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRfNum.DataPropertyName = "RfNum";
            this.colRfNum.HeaderText = "已回收";
            this.colRfNum.Name = "colRfNum";
            this.colRfNum.ReadOnly = true;
            // 
            // colExpDt
            // 
            this.colExpDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpDt.DataPropertyName = "ExpDt";
            this.colExpDt.HeaderText = "到期日";
            this.colExpDt.Name = "colExpDt";
            this.colExpDt.ReadOnly = true;
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
            // colInvID
            // 
            this.colInvID.DataPropertyName = "InvID";
            this.colInvID.HeaderText = "InvID";
            this.colInvID.Name = "colInvID";
            this.colInvID.ReadOnly = true;
            this.colInvID.Visible = false;
            // 
            // colTgtSID
            // 
            this.colTgtSID.DataPropertyName = "TgtSID";
            this.colTgtSID.HeaderText = "SID";
            this.colTgtSID.Name = "colTgtSID";
            this.colTgtSID.ReadOnly = true;
            this.colTgtSID.Visible = false;
            // 
            // dgvPager
            // 
            this.dgvPager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPager.Location = new System.Drawing.Point(6, 711);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1393, 36);
            this.dgvPager.TabIndex = 44;
            this.dgvPager.TotalNum = 0;
            this.dgvPager.TotalPageNum = 0;
            this.dgvPager.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvPager_pagerBtnClicked);
            // 
            // SoldGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 752);
            this.Controls.Add(this.dgvPager);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtOrderNO);
            this.Controls.Add(this.lbOutOrderNO);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cboxResellers);
            this.Controls.Add(this.cboxCatgs);
            this.Controls.Add(this.lblCatg);
            this.Controls.Add(this.dtgvSoldGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoldGoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoldGoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSoldGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtOrderNO;
        private System.Windows.Forms.Label lbOutOrderNO;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboxResellers;
        private System.Windows.Forms.ComboBox cboxCatgs;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.DataGridView dtgvSoldGoods;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCkboxs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinOrdreNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRfNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTgtSID;
        private dgv_pager.DGVPager dgvPager;
    }
}