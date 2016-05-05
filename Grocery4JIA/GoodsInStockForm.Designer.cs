namespace UI
{
    partial class GoodsInStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsInStockForm));
            this.dtgvGoodsInStock = new System.Windows.Forms.DataGridView();
            this.colCkboxs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSinOrdreNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboxSuppliers = new System.Windows.Forms.ComboBox();
            this.cboxCatgs = new System.Windows.Forms.ComboBox();
            this.lblCatg = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtOrderNO = new System.Windows.Forms.TextBox();
            this.lblNOrderNO = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGoodsInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvGoodsInStock
            // 
            this.dtgvGoodsInStock.AllowUserToAddRows = false;
            this.dtgvGoodsInStock.AllowUserToDeleteRows = false;
            this.dtgvGoodsInStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvGoodsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGoodsInStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCkboxs,
            this.colSinOrdreNO,
            this.colGId,
            this.colGName,
            this.colSpecs,
            this.colPrice,
            this.colInvNum,
            this.colExpDt,
            this.colRemark,
            this.colInvID});
            this.dtgvGoodsInStock.Location = new System.Drawing.Point(8, 59);
            this.dtgvGoodsInStock.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvGoodsInStock.Name = "dtgvGoodsInStock";
            this.dtgvGoodsInStock.ReadOnly = true;
            this.dtgvGoodsInStock.RowTemplate.Height = 27;
            this.dtgvGoodsInStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGoodsInStock.Size = new System.Drawing.Size(1396, 698);
            this.dtgvGoodsInStock.TabIndex = 24;
            this.dtgvGoodsInStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGoodsInStock_CellContentClick);
            // 
            // colCkboxs
            // 
            this.colCkboxs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCkboxs.FillWeight = 50F;
            this.colCkboxs.HeaderText = "";
            this.colCkboxs.Name = "colCkboxs";
            this.colCkboxs.ReadOnly = true;
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
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.FillWeight = 70F;
            this.colPrice.HeaderText = "单价/元";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
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
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(2, 20);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "供应商：";
            // 
            // cboxSuppliers
            // 
            this.cboxSuppliers.FormattingEnabled = true;
            this.cboxSuppliers.Location = new System.Drawing.Point(75, 16);
            this.cboxSuppliers.Name = "cboxSuppliers";
            this.cboxSuppliers.Size = new System.Drawing.Size(180, 23);
            this.cboxSuppliers.TabIndex = 1;
            // 
            // cboxCatgs
            // 
            this.cboxCatgs.FormattingEnabled = true;
            this.cboxCatgs.Location = new System.Drawing.Point(338, 16);
            this.cboxCatgs.Name = "cboxCatgs";
            this.cboxCatgs.Size = new System.Drawing.Size(150, 23);
            this.cboxCatgs.TabIndex = 2;
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(280, 20);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 0;
            this.lblCatg.Text = "品类：";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(931, 14);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(85, 30);
            this.btnAddToList.TabIndex = 32;
            this.btnAddToList.Text = "加入订单";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(819, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 31;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtOrderNO
            // 
            this.txtOrderNO.Location = new System.Drawing.Point(607, 17);
            this.txtOrderNO.MaxLength = 100;
            this.txtOrderNO.Name = "txtOrderNO";
            this.txtOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtOrderNO.TabIndex = 3;
            // 
            // lblNOrderNO
            // 
            this.lblNOrderNO.AutoSize = true;
            this.lblNOrderNO.Location = new System.Drawing.Point(519, 22);
            this.lblNOrderNO.Name = "lblNOrderNO";
            this.lblNOrderNO.Size = new System.Drawing.Size(82, 15);
            this.lblNOrderNO.TabIndex = 0;
            this.lblNOrderNO.Text = "进货单号：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1041, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GoodsInStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 767);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtOrderNO);
            this.Controls.Add(this.lblNOrderNO);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cboxSuppliers);
            this.Controls.Add(this.cboxCatgs);
            this.Controls.Add(this.lblCatg);
            this.Controls.Add(this.dtgvGoodsInStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsInStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGoodsInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGoodsInStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCkboxs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinOrdreNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboxSuppliers;
        private System.Windows.Forms.ComboBox cboxCatgs;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtOrderNO;
        private System.Windows.Forms.Label lblNOrderNO;
        private System.Windows.Forms.Button btnClose;
    }
}