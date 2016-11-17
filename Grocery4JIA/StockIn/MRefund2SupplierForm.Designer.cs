namespace UI
{
    partial class MRefund2SupplierForm
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
            this.tabRefundOrders = new System.Windows.Forms.TabControl();
            this.tabPCreatOrder = new System.Windows.Forms.TabPage();
            this.autxtGoodsInStock = new auto_text.auto_text();
            this.btnBtchAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGoods = new System.Windows.Forms.Label();
            this.cboxNSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnAdd2List = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.dtgvRfGoods = new System.Windows.Forms.DataGridView();
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
            this.colTgtSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPQyOrders = new System.Windows.Forms.TabPage();
            this.dgvPager = new dgv_pager.DGVPager();
            this.lblQyDt = new System.Windows.Forms.Label();
            this.ckboxQyEnableEndDt = new System.Windows.Forms.CheckBox();
            this.dtpQyEndDt = new System.Windows.Forms.DateTimePicker();
            this.cboxQySupplier = new System.Windows.Forms.ComboBox();
            this.lblQSupplier = new System.Windows.Forms.Label();
            this.ckboxQyEnableStDt = new System.Windows.Forms.CheckBox();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.dtpQyStDt = new System.Windows.Forms.DateTimePicker();
            this.lblCrtTm = new System.Windows.Forms.Label();
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblOrderNO = new System.Windows.Forms.Label();
            this.dtgvRfOrders = new System.Windows.Forms.DataGridView();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQySupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRefundOrders.SuspendLayout();
            this.tabPCreatOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfGoods)).BeginInit();
            this.tabPQyOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRefundOrders
            // 
            this.tabRefundOrders.Controls.Add(this.tabPCreatOrder);
            this.tabRefundOrders.Controls.Add(this.tabPQyOrders);
            this.tabRefundOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRefundOrders.Location = new System.Drawing.Point(0, 0);
            this.tabRefundOrders.Name = "tabRefundOrders";
            this.tabRefundOrders.SelectedIndex = 0;
            this.tabRefundOrders.Size = new System.Drawing.Size(1325, 720);
            this.tabRefundOrders.TabIndex = 1;
            // 
            // tabPCreatOrder
            // 
            this.tabPCreatOrder.Controls.Add(this.autxtGoodsInStock);
            this.tabPCreatOrder.Controls.Add(this.btnBtchAdd);
            this.tabPCreatOrder.Controls.Add(this.btnDelete);
            this.tabPCreatOrder.Controls.Add(this.lblGoods);
            this.tabPCreatOrder.Controls.Add(this.cboxNSupplier);
            this.tabPCreatOrder.Controls.Add(this.lblSupplier);
            this.tabPCreatOrder.Controls.Add(this.btnAdd2List);
            this.tabPCreatOrder.Controls.Add(this.btnRefund);
            this.tabPCreatOrder.Controls.Add(this.dtgvRfGoods);
            this.tabPCreatOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPCreatOrder.Name = "tabPCreatOrder";
            this.tabPCreatOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCreatOrder.Size = new System.Drawing.Size(1317, 691);
            this.tabPCreatOrder.TabIndex = 0;
            this.tabPCreatOrder.Text = "创建退货单";
            this.tabPCreatOrder.UseVisualStyleBackColor = true;
            // 
            // autxtGoodsInStock
            // 
            this.autxtGoodsInStock.Data = null;
            this.autxtGoodsInStock.DropHeight = 139;
            this.autxtGoodsInStock.Location = new System.Drawing.Point(460, 17);
            this.autxtGoodsInStock.Name = "autxtGoodsInStock";
            this.autxtGoodsInStock.SelectedObj = null;
            this.autxtGoodsInStock.Size = new System.Drawing.Size(301, 26);
            this.autxtGoodsInStock.TabIndex = 9;
            this.autxtGoodsInStock.Term = null;
            this.autxtGoodsInStock.loadData += new auto_text.auto_text.LoadDataHandle(this.autxtGoodsInStock_loadData);
            // 
            // btnBtchAdd
            // 
            this.btnBtchAdd.Location = new System.Drawing.Point(1051, 14);
            this.btnBtchAdd.Name = "btnBtchAdd";
            this.btnBtchAdd.Size = new System.Drawing.Size(85, 30);
            this.btnBtchAdd.TabIndex = 6;
            this.btnBtchAdd.Text = "批量选择";
            this.btnBtchAdd.UseVisualStyleBackColor = true;
            this.btnBtchAdd.Click += new System.EventHandler(this.btnBtchAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(929, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Location = new System.Drawing.Point(348, 22);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(106, 15);
            this.lblGoods.TabIndex = 0;
            this.lblGoods.Text = "商品ID/名称：";
            // 
            // cboxNSupplier
            // 
            this.cboxNSupplier.FormattingEnabled = true;
            this.cboxNSupplier.Location = new System.Drawing.Point(76, 18);
            this.cboxNSupplier.Name = "cboxNSupplier";
            this.cboxNSupplier.Size = new System.Drawing.Size(250, 23);
            this.cboxNSupplier.TabIndex = 1;
            this.cboxNSupplier.SelectedIndexChanged += new System.EventHandler(this.cboxNSupplier_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(3, 22);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "供应商：";
            // 
            // btnAdd2List
            // 
            this.btnAdd2List.Location = new System.Drawing.Point(809, 14);
            this.btnAdd2List.Name = "btnAdd2List";
            this.btnAdd2List.Size = new System.Drawing.Size(85, 30);
            this.btnAdd2List.TabIndex = 4;
            this.btnAdd2List.Text = "加入订单";
            this.btnAdd2List.UseVisualStyleBackColor = true;
            this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(1171, 14);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(85, 30);
            this.btnRefund.TabIndex = 7;
            this.btnRefund.Text = "退货";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // dtgvRfGoods
            // 
            this.dtgvRfGoods.AllowUserToAddRows = false;
            this.dtgvRfGoods.AllowUserToDeleteRows = false;
            this.dtgvRfGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRfGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRfGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.colInvID,
            this.colTgtSID});
            this.dtgvRfGoods.Location = new System.Drawing.Point(0, 61);
            this.dtgvRfGoods.Name = "dtgvRfGoods";
            this.dtgvRfGoods.RowTemplate.Height = 27;
            this.dtgvRfGoods.Size = new System.Drawing.Size(1317, 634);
            this.dtgvRfGoods.TabIndex = 8;
            this.dtgvRfGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRfGoods_CellEndEdit);
            this.dtgvRfGoods.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgvRfGoods_EditingControlShowing);
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
            this.colPrice.HeaderText = "退货价/元";
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
            this.colNum.HeaderText = "退货量";
            this.colNum.Name = "colNum";
            // 
            // colInvID
            // 
            this.colInvID.HeaderText = "InvID";
            this.colInvID.Name = "colInvID";
            this.colInvID.ReadOnly = true;
            this.colInvID.Visible = false;
            // 
            // colTgtSID
            // 
            this.colTgtSID.HeaderText = "SID";
            this.colTgtSID.Name = "colTgtSID";
            this.colTgtSID.ReadOnly = true;
            this.colTgtSID.Visible = false;
            // 
            // tabPQyOrders
            // 
            this.tabPQyOrders.Controls.Add(this.dgvPager);
            this.tabPQyOrders.Controls.Add(this.lblQyDt);
            this.tabPQyOrders.Controls.Add(this.ckboxQyEnableEndDt);
            this.tabPQyOrders.Controls.Add(this.dtpQyEndDt);
            this.tabPQyOrders.Controls.Add(this.cboxQySupplier);
            this.tabPQyOrders.Controls.Add(this.lblQSupplier);
            this.tabPQyOrders.Controls.Add(this.ckboxQyEnableStDt);
            this.tabPQyOrders.Controls.Add(this.btnOrderQuery);
            this.tabPQyOrders.Controls.Add(this.dtpQyStDt);
            this.tabPQyOrders.Controls.Add(this.lblCrtTm);
            this.tabPQyOrders.Controls.Add(this.txtQyOrderNO);
            this.tabPQyOrders.Controls.Add(this.lblOrderNO);
            this.tabPQyOrders.Controls.Add(this.dtgvRfOrders);
            this.tabPQyOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPQyOrders.Name = "tabPQyOrders";
            this.tabPQyOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPQyOrders.Size = new System.Drawing.Size(1317, 691);
            this.tabPQyOrders.TabIndex = 1;
            this.tabPQyOrders.Text = "退货单查询";
            this.tabPQyOrders.UseVisualStyleBackColor = true;
            // 
            // dgvPager
            // 
            this.dgvPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPager.Location = new System.Drawing.Point(3, 652);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1311, 36);
            this.dgvPager.TabIndex = 20;
            this.dgvPager.TotalNum = 0;
            this.dgvPager.TotalPageNum = 0;
            this.dgvPager.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvPager_pagerBtnClicked);
            // 
            // lblQyDt
            // 
            this.lblQyDt.AutoSize = true;
            this.lblQyDt.Location = new System.Drawing.Point(902, 20);
            this.lblQyDt.Name = "lblQyDt";
            this.lblQyDt.Size = new System.Drawing.Size(22, 15);
            this.lblQyDt.TabIndex = 19;
            this.lblQyDt.Text = "—";
            // 
            // ckboxQyEnableEndDt
            // 
            this.ckboxQyEnableEndDt.AutoSize = true;
            this.ckboxQyEnableEndDt.Location = new System.Drawing.Point(1092, 19);
            this.ckboxQyEnableEndDt.Name = "ckboxQyEnableEndDt";
            this.ckboxQyEnableEndDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableEndDt.TabIndex = 18;
            this.ckboxQyEnableEndDt.UseVisualStyleBackColor = true;
            this.ckboxQyEnableEndDt.Click += new System.EventHandler(this.ckboxQyEnableEndDt_Click);
            // 
            // dtpQyEndDt
            // 
            this.dtpQyEndDt.CustomFormat = "yyyy-MM-dd";
            this.dtpQyEndDt.Enabled = false;
            this.dtpQyEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyEndDt.Location = new System.Drawing.Point(936, 15);
            this.dtpQyEndDt.Name = "dtpQyEndDt";
            this.dtpQyEndDt.Size = new System.Drawing.Size(150, 25);
            this.dtpQyEndDt.TabIndex = 17;
            // 
            // cboxQySupplier
            // 
            this.cboxQySupplier.FormattingEnabled = true;
            this.cboxQySupplier.Location = new System.Drawing.Point(78, 16);
            this.cboxQySupplier.Name = "cboxQySupplier";
            this.cboxQySupplier.Size = new System.Drawing.Size(250, 23);
            this.cboxQySupplier.TabIndex = 12;
            // 
            // lblQSupplier
            // 
            this.lblQSupplier.AutoSize = true;
            this.lblQSupplier.Location = new System.Drawing.Point(6, 20);
            this.lblQSupplier.Name = "lblQSupplier";
            this.lblQSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblQSupplier.TabIndex = 8;
            this.lblQSupplier.Text = "供应商：";
            // 
            // ckboxQyEnableStDt
            // 
            this.ckboxQyEnableStDt.AutoSize = true;
            this.ckboxQyEnableStDt.Location = new System.Drawing.Point(873, 19);
            this.ckboxQyEnableStDt.Name = "ckboxQyEnableStDt";
            this.ckboxQyEnableStDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableStDt.TabIndex = 15;
            this.ckboxQyEnableStDt.UseVisualStyleBackColor = true;
            this.ckboxQyEnableStDt.Click += new System.EventHandler(this.ckboxQyEnableStDt_Click);
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.Location = new System.Drawing.Point(1161, 12);
            this.btnOrderQuery.Name = "btnOrderQuery";
            this.btnOrderQuery.Size = new System.Drawing.Size(85, 30);
            this.btnOrderQuery.TabIndex = 16;
            this.btnOrderQuery.Text = "查询";
            this.btnOrderQuery.UseVisualStyleBackColor = true;
            this.btnOrderQuery.Click += new System.EventHandler(this.btnOrderQuery_Click);
            // 
            // dtpQyStDt
            // 
            this.dtpQyStDt.CustomFormat = "yyyy-MM-dd";
            this.dtpQyStDt.Enabled = false;
            this.dtpQyStDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyStDt.Location = new System.Drawing.Point(718, 15);
            this.dtpQyStDt.Name = "dtpQyStDt";
            this.dtpQyStDt.Size = new System.Drawing.Size(150, 25);
            this.dtpQyStDt.TabIndex = 14;
            // 
            // lblCrtTm
            // 
            this.lblCrtTm.AutoSize = true;
            this.lblCrtTm.Location = new System.Drawing.Point(630, 20);
            this.lblCrtTm.Name = "lblCrtTm";
            this.lblCrtTm.Size = new System.Drawing.Size(82, 15);
            this.lblCrtTm.TabIndex = 9;
            this.lblCrtTm.Text = "创建日期：";
            // 
            // txtQyOrderNO
            // 
            this.txtQyOrderNO.Location = new System.Drawing.Point(412, 15);
            this.txtQyOrderNO.Name = "txtQyOrderNO";
            this.txtQyOrderNO.Size = new System.Drawing.Size(180, 25);
            this.txtQyOrderNO.TabIndex = 13;
            // 
            // lblOrderNO
            // 
            this.lblOrderNO.AutoSize = true;
            this.lblOrderNO.Location = new System.Drawing.Point(355, 20);
            this.lblOrderNO.Name = "lblOrderNO";
            this.lblOrderNO.Size = new System.Drawing.Size(52, 15);
            this.lblOrderNO.TabIndex = 10;
            this.lblOrderNO.Text = "单号：";
            // 
            // dtgvRfOrders
            // 
            this.dtgvRfOrders.AllowUserToAddRows = false;
            this.dtgvRfOrders.AllowUserToDeleteRows = false;
            this.dtgvRfOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRfOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRfOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNO,
            this.colQySupplier,
            this.colAmount,
            this.colCrtTmst,
            this.colCrtName,
            this.colUptTmst,
            this.colUptName});
            this.dtgvRfOrders.Location = new System.Drawing.Point(2, 56);
            this.dtgvRfOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvRfOrders.Name = "dtgvRfOrders";
            this.dtgvRfOrders.ReadOnly = true;
            this.dtgvRfOrders.RowTemplate.Height = 27;
            this.dtgvRfOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRfOrders.Size = new System.Drawing.Size(1314, 592);
            this.dtgvRfOrders.TabIndex = 11;
            this.dtgvRfOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRfOrders_CellDoubleClick);
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO__PK";
            this.colOrderNO.FillWeight = 150F;
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colQySupplier
            // 
            this.colQySupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQySupplier.DataPropertyName = "CustName";
            this.colQySupplier.FillWeight = 200F;
            this.colQySupplier.HeaderText = "供应商";
            this.colQySupplier.Name = "colQySupplier";
            this.colQySupplier.ReadOnly = true;
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
            // MRefund2SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 720);
            this.Controls.Add(this.tabRefundOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MRefund2SupplierForm";
            this.Text = "MRefund2SupplierForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabRefundOrders.ResumeLayout(false);
            this.tabPCreatOrder.ResumeLayout(false);
            this.tabPCreatOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfGoods)).EndInit();
            this.tabPQyOrders.ResumeLayout(false);
            this.tabPQyOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRefundOrders;
        private System.Windows.Forms.TabPage tabPCreatOrder;
        private System.Windows.Forms.Button btnBtchAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.ComboBox cboxNSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnAdd2List;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.DataGridView dtgvRfGoods;
        private System.Windows.Forms.TabPage tabPQyOrders;
        private System.Windows.Forms.ComboBox cboxQySupplier;
        private System.Windows.Forms.Label lblQSupplier;
        private System.Windows.Forms.CheckBox ckboxQyEnableStDt;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.DateTimePicker dtpQyStDt;
        private System.Windows.Forms.Label lblCrtTm;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblOrderNO;
        private System.Windows.Forms.DataGridView dtgvRfOrders;
        private System.Windows.Forms.Label lblQyDt;
        private System.Windows.Forms.CheckBox ckboxQyEnableEndDt;
        private System.Windows.Forms.DateTimePicker dtpQyEndDt;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colTgtSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQySupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptName;
        private dgv_pager.DGVPager dgvPager;
        private auto_text.auto_text autxtGoodsInStock;
    }
}