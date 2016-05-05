namespace UI
{
    partial class MStockOutForm
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
            this.tabSOutOrders = new System.Windows.Forms.TabControl();
            this.tabPCreatOrder = new System.Windows.Forms.TabPage();
            this.btnBtchAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lboxGoods = new System.Windows.Forms.ListBox();
            this.txtGoodsInStock = new System.Windows.Forms.TextBox();
            this.lblGoods = new System.Windows.Forms.Label();
            this.cboxNResellers = new System.Windows.Forms.ComboBox();
            this.lblReseller = new System.Windows.Forms.Label();
            this.btnAdd2List = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtgvSOutGoods = new System.Windows.Forms.DataGridView();
            this.colSInOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInPric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPSOutOrders = new System.Windows.Forms.TabPage();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblQyOrderNO = new System.Windows.Forms.Label();
            this.ckboxQyEnableDt = new System.Windows.Forms.CheckBox();
            this.dtpQyCrtTm = new System.Windows.Forms.DateTimePicker();
            this.lblQyCrtTm = new System.Windows.Forms.Label();
            this.cboxQyReseller = new System.Windows.Forms.ComboBox();
            this.lblQyReseller = new System.Windows.Forms.Label();
            this.dtgvMOutOrders = new System.Windows.Forms.DataGridView();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReseller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSOutOrders.SuspendLayout();
            this.tabPCreatOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSOutGoods)).BeginInit();
            this.tabPSOutOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMOutOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSOutOrders
            // 
            this.tabSOutOrders.Controls.Add(this.tabPCreatOrder);
            this.tabSOutOrders.Controls.Add(this.tabPSOutOrders);
            this.tabSOutOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSOutOrders.Location = new System.Drawing.Point(0, 0);
            this.tabSOutOrders.Name = "tabSOutOrders";
            this.tabSOutOrders.SelectedIndex = 0;
            this.tabSOutOrders.Size = new System.Drawing.Size(1447, 722);
            this.tabSOutOrders.TabIndex = 0;
            // 
            // tabPCreatOrder
            // 
            this.tabPCreatOrder.Controls.Add(this.btnBtchAdd);
            this.tabPCreatOrder.Controls.Add(this.btnDelete);
            this.tabPCreatOrder.Controls.Add(this.lboxGoods);
            this.tabPCreatOrder.Controls.Add(this.txtGoodsInStock);
            this.tabPCreatOrder.Controls.Add(this.lblGoods);
            this.tabPCreatOrder.Controls.Add(this.cboxNResellers);
            this.tabPCreatOrder.Controls.Add(this.lblReseller);
            this.tabPCreatOrder.Controls.Add(this.btnAdd2List);
            this.tabPCreatOrder.Controls.Add(this.btnCreate);
            this.tabPCreatOrder.Controls.Add(this.dtgvSOutGoods);
            this.tabPCreatOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPCreatOrder.Name = "tabPCreatOrder";
            this.tabPCreatOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCreatOrder.Size = new System.Drawing.Size(1439, 693);
            this.tabPCreatOrder.TabIndex = 0;
            this.tabPCreatOrder.Text = "创建出货单";
            this.tabPCreatOrder.UseVisualStyleBackColor = true;
            // 
            // btnBtchAdd
            // 
            this.btnBtchAdd.Location = new System.Drawing.Point(997, 14);
            this.btnBtchAdd.Name = "btnBtchAdd";
            this.btnBtchAdd.Size = new System.Drawing.Size(85, 30);
            this.btnBtchAdd.TabIndex = 6;
            this.btnBtchAdd.Text = "批量选择";
            this.btnBtchAdd.UseVisualStyleBackColor = true;
            this.btnBtchAdd.Click += new System.EventHandler(this.btnBtchAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(875, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lboxGoods
            // 
            this.lboxGoods.FormattingEnabled = true;
            this.lboxGoods.ItemHeight = 15;
            this.lboxGoods.Location = new System.Drawing.Point(406, 44);
            this.lboxGoods.Name = "lboxGoods";
            this.lboxGoods.Size = new System.Drawing.Size(300, 139);
            this.lboxGoods.TabIndex = 3;
            this.lboxGoods.Visible = false;
            this.lboxGoods.Click += new System.EventHandler(this.lboxGoods_Click);
            this.lboxGoods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lboxGoods_MouseMove);
            // 
            // txtGoodsInStock
            // 
            this.txtGoodsInStock.Location = new System.Drawing.Point(406, 19);
            this.txtGoodsInStock.Name = "txtGoodsInStock";
            this.txtGoodsInStock.Size = new System.Drawing.Size(300, 25);
            this.txtGoodsInStock.TabIndex = 2;
            this.txtGoodsInStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoodsInStock_KeyUp);
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Location = new System.Drawing.Point(294, 23);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(106, 15);
            this.lblGoods.TabIndex = 0;
            this.lblGoods.Text = "商品ID/名称：";
            // 
            // cboxNResellers
            // 
            this.cboxNResellers.FormattingEnabled = true;
            this.cboxNResellers.Location = new System.Drawing.Point(76, 19);
            this.cboxNResellers.Name = "cboxNResellers";
            this.cboxNResellers.Size = new System.Drawing.Size(180, 23);
            this.cboxNResellers.TabIndex = 1;
            // 
            // lblReseller
            // 
            this.lblReseller.AutoSize = true;
            this.lblReseller.Location = new System.Drawing.Point(3, 23);
            this.lblReseller.Name = "lblReseller";
            this.lblReseller.Size = new System.Drawing.Size(67, 15);
            this.lblReseller.TabIndex = 0;
            this.lblReseller.Text = "零售商：";
            // 
            // btnAdd2List
            // 
            this.btnAdd2List.Location = new System.Drawing.Point(755, 14);
            this.btnAdd2List.Name = "btnAdd2List";
            this.btnAdd2List.Size = new System.Drawing.Size(85, 30);
            this.btnAdd2List.TabIndex = 4;
            this.btnAdd2List.Text = "加入订单";
            this.btnAdd2List.UseVisualStyleBackColor = true;
            this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1117, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 30);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "创建订单";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dtgvSOutGoods
            // 
            this.dtgvSOutGoods.AllowUserToAddRows = false;
            this.dtgvSOutGoods.AllowUserToDeleteRows = false;
            this.dtgvSOutGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSOutGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSOutGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSInOrderNO,
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colSupplier,
            this.colExpDt,
            this.colInPric,
            this.colPrice,
            this.colInvNum,
            this.colNum,
            this.colInvID});
            this.dtgvSOutGoods.Location = new System.Drawing.Point(0, 61);
            this.dtgvSOutGoods.Name = "dtgvSOutGoods";
            this.dtgvSOutGoods.RowTemplate.Height = 27;
            this.dtgvSOutGoods.Size = new System.Drawing.Size(1439, 629);
            this.dtgvSOutGoods.TabIndex = 8;
            this.dtgvSOutGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSOutGoods_CellEndEdit);
            this.dtgvSOutGoods.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgvSOutGoods_EditingControlShowing);
            // 
            // colSInOrderNO
            // 
            this.colSInOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSInOrderNO.HeaderText = "进货单号";
            this.colSInOrderNO.Name = "colSInOrderNO";
            // 
            // colGID
            // 
            this.colGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGID.FillWeight = 80F;
            this.colGID.HeaderText = "商品ID";
            this.colGID.Name = "colGID";
            this.colGID.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.HeaderText = "商品名称";
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colSpecs
            // 
            this.colSpecs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpecs.HeaderText = "规格";
            this.colSpecs.Name = "colSpecs";
            this.colSpecs.ReadOnly = true;
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplier.HeaderText = "供应商";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            // 
            // colExpDt
            // 
            this.colExpDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpDt.HeaderText = "到期日";
            this.colExpDt.Name = "colExpDt";
            this.colExpDt.ReadOnly = true;
            // 
            // colInPric
            // 
            this.colInPric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInPric.HeaderText = "进价/元";
            this.colInPric.Name = "colInPric";
            this.colInPric.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.HeaderText = "售价/元";
            this.colPrice.Name = "colPrice";
            // 
            // colInvNum
            // 
            this.colInvNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInvNum.FillWeight = 80F;
            this.colInvNum.HeaderText = "库存量";
            this.colInvNum.Name = "colInvNum";
            this.colInvNum.ReadOnly = true;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.FillWeight = 80F;
            this.colNum.HeaderText = "出货量";
            this.colNum.Name = "colNum";
            // 
            // colInvID
            // 
            this.colInvID.HeaderText = "InvID";
            this.colInvID.Name = "colInvID";
            this.colInvID.ReadOnly = true;
            this.colInvID.Visible = false;
            // 
            // tabPSOutOrders
            // 
            this.tabPSOutOrders.Controls.Add(this.btnOrderQuery);
            this.tabPSOutOrders.Controls.Add(this.txtQyOrderNO);
            this.tabPSOutOrders.Controls.Add(this.lblQyOrderNO);
            this.tabPSOutOrders.Controls.Add(this.ckboxQyEnableDt);
            this.tabPSOutOrders.Controls.Add(this.dtpQyCrtTm);
            this.tabPSOutOrders.Controls.Add(this.lblQyCrtTm);
            this.tabPSOutOrders.Controls.Add(this.cboxQyReseller);
            this.tabPSOutOrders.Controls.Add(this.lblQyReseller);
            this.tabPSOutOrders.Controls.Add(this.dtgvMOutOrders);
            this.tabPSOutOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPSOutOrders.Name = "tabPSOutOrders";
            this.tabPSOutOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSOutOrders.Size = new System.Drawing.Size(1439, 693);
            this.tabPSOutOrders.TabIndex = 1;
            this.tabPSOutOrders.Text = "出货单查询";
            this.tabPSOutOrders.UseVisualStyleBackColor = true;
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.Location = new System.Drawing.Point(900, 15);
            this.btnOrderQuery.Name = "btnOrderQuery";
            this.btnOrderQuery.Size = new System.Drawing.Size(85, 30);
            this.btnOrderQuery.TabIndex = 13;
            this.btnOrderQuery.Text = "查询";
            this.btnOrderQuery.UseVisualStyleBackColor = true;
            // 
            // txtQyOrderNO
            // 
            this.txtQyOrderNO.Location = new System.Drawing.Point(355, 18);
            this.txtQyOrderNO.Name = "txtQyOrderNO";
            this.txtQyOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtQyOrderNO.TabIndex = 10;
            // 
            // lblQyOrderNO
            // 
            this.lblQyOrderNO.AutoSize = true;
            this.lblQyOrderNO.Location = new System.Drawing.Point(297, 23);
            this.lblQyOrderNO.Name = "lblQyOrderNO";
            this.lblQyOrderNO.Size = new System.Drawing.Size(52, 15);
            this.lblQyOrderNO.TabIndex = 8;
            this.lblQyOrderNO.Text = "单号：";
            // 
            // ckboxQyEnableDt
            // 
            this.ckboxQyEnableDt.AutoSize = true;
            this.ckboxQyEnableDt.Location = new System.Drawing.Point(815, 22);
            this.ckboxQyEnableDt.Name = "ckboxQyEnableDt";
            this.ckboxQyEnableDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableDt.TabIndex = 12;
            this.ckboxQyEnableDt.UseVisualStyleBackColor = true;
            // 
            // dtpQyCrtTm
            // 
            this.dtpQyCrtTm.CustomFormat = "yyyy-MM-dd";
            this.dtpQyCrtTm.Enabled = false;
            this.dtpQyCrtTm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyCrtTm.Location = new System.Drawing.Point(659, 18);
            this.dtpQyCrtTm.Name = "dtpQyCrtTm";
            this.dtpQyCrtTm.Size = new System.Drawing.Size(150, 25);
            this.dtpQyCrtTm.TabIndex = 11;
            // 
            // lblQyCrtTm
            // 
            this.lblQyCrtTm.AutoSize = true;
            this.lblQyCrtTm.Location = new System.Drawing.Point(571, 23);
            this.lblQyCrtTm.Name = "lblQyCrtTm";
            this.lblQyCrtTm.Size = new System.Drawing.Size(82, 15);
            this.lblQyCrtTm.TabIndex = 9;
            this.lblQyCrtTm.Text = "创建日期：";
            // 
            // cboxQyReseller
            // 
            this.cboxQyReseller.FormattingEnabled = true;
            this.cboxQyReseller.Location = new System.Drawing.Point(77, 19);
            this.cboxQyReseller.Name = "cboxQyReseller";
            this.cboxQyReseller.Size = new System.Drawing.Size(180, 23);
            this.cboxQyReseller.TabIndex = 7;
            // 
            // lblQyReseller
            // 
            this.lblQyReseller.AutoSize = true;
            this.lblQyReseller.Location = new System.Drawing.Point(4, 23);
            this.lblQyReseller.Name = "lblQyReseller";
            this.lblQyReseller.Size = new System.Drawing.Size(67, 15);
            this.lblQyReseller.TabIndex = 6;
            this.lblQyReseller.Text = "零售商：";
            // 
            // dtgvMOutOrders
            // 
            this.dtgvMOutOrders.AllowUserToAddRows = false;
            this.dtgvMOutOrders.AllowUserToDeleteRows = false;
            this.dtgvMOutOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMOutOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMOutOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNO,
            this.colReseller,
            this.colAmount,
            this.colCrtTmst,
            this.colCrtName,
            this.colUptTmst,
            this.colUptName});
            this.dtgvMOutOrders.Location = new System.Drawing.Point(0, 61);
            this.dtgvMOutOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvMOutOrders.Name = "dtgvMOutOrders";
            this.dtgvMOutOrders.ReadOnly = true;
            this.dtgvMOutOrders.RowTemplate.Height = 27;
            this.dtgvMOutOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMOutOrders.Size = new System.Drawing.Size(1439, 631);
            this.dtgvMOutOrders.TabIndex = 1;
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO";
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colReseller
            // 
            this.colReseller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReseller.DataPropertyName = "CustName";
            this.colReseller.HeaderText = "零售商";
            this.colReseller.Name = "colReseller";
            this.colReseller.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总计/元";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colCrtTmst
            // 
            this.colCrtTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCrtTmst.DataPropertyName = "CrtTmst";
            this.colCrtTmst.HeaderText = "创建时间";
            this.colCrtTmst.Name = "colCrtTmst";
            this.colCrtTmst.ReadOnly = true;
            // 
            // colCrtName
            // 
            this.colCrtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCrtName.DataPropertyName = "CrtUName";
            this.colCrtName.HeaderText = "创建人";
            this.colCrtName.Name = "colCrtName";
            this.colCrtName.ReadOnly = true;
            // 
            // colUptTmst
            // 
            this.colUptTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUptTmst.DataPropertyName = "UptTmst";
            this.colUptTmst.HeaderText = "更新时间";
            this.colUptTmst.Name = "colUptTmst";
            this.colUptTmst.ReadOnly = true;
            // 
            // colUptName
            // 
            this.colUptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUptName.DataPropertyName = "UptUName";
            this.colUptName.HeaderText = "更新人";
            this.colUptName.Name = "colUptName";
            this.colUptName.ReadOnly = true;
            // 
            // MStockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 722);
            this.Controls.Add(this.tabSOutOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MStockOutForm";
            this.Text = "MStockOutForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabSOutOrders.ResumeLayout(false);
            this.tabPCreatOrder.ResumeLayout(false);
            this.tabPCreatOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSOutGoods)).EndInit();
            this.tabPSOutOrders.ResumeLayout(false);
            this.tabPSOutOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMOutOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSOutOrders;
        private System.Windows.Forms.TabPage tabPCreatOrder;
        private System.Windows.Forms.TabPage tabPSOutOrders;
        private System.Windows.Forms.Button btnAdd2List;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dtgvMOutOrders;
        private System.Windows.Forms.ComboBox cboxQyReseller;
        private System.Windows.Forms.Label lblQyReseller;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblQyOrderNO;
        private System.Windows.Forms.CheckBox ckboxQyEnableDt;
        private System.Windows.Forms.DateTimePicker dtpQyCrtTm;
        private System.Windows.Forms.Label lblQyCrtTm;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReseller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptName;
        private System.Windows.Forms.ComboBox cboxNResellers;
        private System.Windows.Forms.Label lblReseller;
        private System.Windows.Forms.ListBox lboxGoods;
        private System.Windows.Forms.TextBox txtGoodsInStock;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgvSOutGoods;
        private System.Windows.Forms.Button btnBtchAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSInOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInPric;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
    }
}