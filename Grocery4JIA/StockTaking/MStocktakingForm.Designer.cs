namespace UI
{
    partial class MStocktakingForm
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtOrderNO = new System.Windows.Forms.TextBox();
            this.lblNOrderNO = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboxSuppliers = new System.Windows.Forms.ComboBox();
            this.cboxCatgs = new System.Windows.Forms.ComboBox();
            this.lblCatg = new System.Windows.Forms.Label();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvGoods = new System.Windows.Forms.DataGridView();
            this.colSinOrdreNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChld = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPager = new dgv_pager.DGVPager();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGoods)).BeginInit();
            this.cmsDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1107, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 40;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtOrderNO
            // 
            this.txtOrderNO.Location = new System.Drawing.Point(914, 14);
            this.txtOrderNO.MaxLength = 100;
            this.txtOrderNO.Name = "txtOrderNO";
            this.txtOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtOrderNO.TabIndex = 39;
            // 
            // lblNOrderNO
            // 
            this.lblNOrderNO.AutoSize = true;
            this.lblNOrderNO.Location = new System.Drawing.Point(826, 19);
            this.lblNOrderNO.Name = "lblNOrderNO";
            this.lblNOrderNO.Size = new System.Drawing.Size(82, 15);
            this.lblNOrderNO.TabIndex = 34;
            this.lblNOrderNO.Text = "进货单号：";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(4, 19);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblSupplier.TabIndex = 35;
            this.lblSupplier.Text = "供应商：";
            // 
            // cboxSuppliers
            // 
            this.cboxSuppliers.FormattingEnabled = true;
            this.cboxSuppliers.Location = new System.Drawing.Point(77, 15);
            this.cboxSuppliers.Name = "cboxSuppliers";
            this.cboxSuppliers.Size = new System.Drawing.Size(180, 23);
            this.cboxSuppliers.TabIndex = 37;
            // 
            // cboxCatgs
            // 
            this.cboxCatgs.FormattingEnabled = true;
            this.cboxCatgs.Location = new System.Drawing.Point(340, 15);
            this.cboxCatgs.Name = "cboxCatgs";
            this.cboxCatgs.Size = new System.Drawing.Size(150, 23);
            this.cboxCatgs.TabIndex = 38;
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(282, 19);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 36;
            this.lblCatg.Text = "品类：";
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(629, 14);
            this.txtGID.MaxLength = 100;
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(170, 25);
            this.txtGID.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "商品名称/ID：";
            // 
            // dtgvGoods
            // 
            this.dtgvGoods.AllowUserToAddRows = false;
            this.dtgvGoods.AllowUserToDeleteRows = false;
            this.dtgvGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSinOrdreNO,
            this.colGId,
            this.colGName,
            this.colSpecs,
            this.colInvNum,
            this.colCustName,
            this.colExpDt,
            this.colRemark,
            this.colInvID});
            this.dtgvGoods.ContextMenuStrip = this.cmsDetail;
            this.dtgvGoods.Location = new System.Drawing.Point(2, 56);
            this.dtgvGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvGoods.Name = "dtgvGoods";
            this.dtgvGoods.ReadOnly = true;
            this.dtgvGoods.RowTemplate.Height = 27;
            this.dtgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGoods.Size = new System.Drawing.Size(1273, 634);
            this.dtgvGoods.TabIndex = 43;
            this.dtgvGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGoods_CellDoubleClick);
            // 
            // colSinOrdreNO
            // 
            this.colSinOrdreNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSinOrdreNO.DataPropertyName = "OrderNO";
            this.colSinOrdreNO.HeaderText = "进货单号";
            this.colSinOrdreNO.Name = "colSinOrdreNO";
            this.colSinOrdreNO.ReadOnly = true;
            // 
            // colGId
            // 
            this.colGId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGId.DataPropertyName = "GID";
            this.colGId.FillWeight = 78.25026F;
            this.colGId.HeaderText = "商品编号";
            this.colGId.MaxInputLength = 100;
            this.colGId.Name = "colGId";
            this.colGId.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.DataPropertyName = "GName";
            this.colGName.FillWeight = 78.25026F;
            this.colGName.HeaderText = "商品名称";
            this.colGName.MaxInputLength = 100;
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colSpecs
            // 
            this.colSpecs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpecs.DataPropertyName = "Specs";
            this.colSpecs.FillWeight = 78.25026F;
            this.colSpecs.HeaderText = "规格";
            this.colSpecs.MaxInputLength = 100;
            this.colSpecs.Name = "colSpecs";
            this.colSpecs.ReadOnly = true;
            // 
            // colInvNum
            // 
            this.colInvNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvNum.DataPropertyName = "Num";
            this.colInvNum.FillWeight = 70F;
            this.colInvNum.HeaderText = "库存量";
            this.colInvNum.Name = "colInvNum";
            this.colInvNum.ReadOnly = true;
            // 
            // colCustName
            // 
            this.colCustName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustName.DataPropertyName = "CustName";
            this.colCustName.FillWeight = 150F;
            this.colCustName.HeaderText = "供应商";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
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
            this.colRemark.FillWeight = 150F;
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
            // cmsDetail
            // 
            this.cmsDetail.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiChld});
            this.cmsDetail.Name = "cmsDetail";
            this.cmsDetail.Size = new System.Drawing.Size(145, 56);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(144, 26);
            this.tsmiEdit.Text = "修改库存";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiChld
            // 
            this.tsmiChld.Name = "tsmiChld";
            this.tsmiChld.Size = new System.Drawing.Size(144, 26);
            this.tsmiChld.Text = "变更流水";
            this.tsmiChld.Click += new System.EventHandler(this.tsmiChld_Click);
            // 
            // dgvPager
            // 
            this.dgvPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPager.Location = new System.Drawing.Point(0, 693);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1280, 43);
            this.dgvPager.TabIndex = 44;
            this.dgvPager.TotalNum = 0;
            this.dgvPager.TotalPageNum = 0;
            this.dgvPager.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvPager_pagerBtnClicked);
            // 
            // MStocktakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 736);
            this.Controls.Add(this.dgvPager);
            this.Controls.Add(this.dtgvGoods);
            this.Controls.Add(this.txtGID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtOrderNO);
            this.Controls.Add(this.lblNOrderNO);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cboxSuppliers);
            this.Controls.Add(this.cboxCatgs);
            this.Controls.Add(this.lblCatg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MStocktakingForm";
            this.Text = "MStocktakingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGoods)).EndInit();
            this.cmsDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtOrderNO;
        private System.Windows.Forms.Label lblNOrderNO;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboxSuppliers;
        private System.Windows.Forms.ComboBox cboxCatgs;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinOrdreNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
        private dgv_pager.DGVPager dgvPager;
        private System.Windows.Forms.ContextMenuStrip cmsDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiChld;
    }
}