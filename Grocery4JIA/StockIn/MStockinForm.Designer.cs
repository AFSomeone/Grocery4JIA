namespace UI
{
    partial class MStockInForm
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
            this.tabpgStockinOrder = new System.Windows.Forms.TabPage();
            this.dgvPager = new dgv_pager.DGVPager();
            this.lblQyDt = new System.Windows.Forms.Label();
            this.ckboxEnableEndDt = new System.Windows.Forms.CheckBox();
            this.dtpQyEndDt = new System.Windows.Forms.DateTimePicker();
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblQyOrderNO = new System.Windows.Forms.Label();
            this.ckboxQyEnableStDt = new System.Windows.Forms.CheckBox();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.cboxQyCust = new System.Windows.Forms.ComboBox();
            this.lblQyCust = new System.Windows.Forms.Label();
            this.dtpQyStDt = new System.Windows.Forms.DateTimePicker();
            this.lblQyCrtTm = new System.Windows.Forms.Label();
            this.dtgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabpgStockin = new System.Windows.Forms.TabPage();
            this.autxtNSupplyGoods = new auto_text.auto_text();
            this.mthcdrMfDt = new System.Windows.Forms.MonthCalendar();
            this.btnBtchAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGoods = new System.Windows.Forms.Label();
            this.btnAdd2List = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cboxNSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.dtgvStockin = new System.Windows.Forms.DataGridView();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMfDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSinOrders = new System.Windows.Forms.TabControl();
            this.tabpgStockinOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).BeginInit();
            this.tabpgStockin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStockin)).BeginInit();
            this.tabSinOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpgStockinOrder
            // 
            this.tabpgStockinOrder.Controls.Add(this.dgvPager);
            this.tabpgStockinOrder.Controls.Add(this.lblQyDt);
            this.tabpgStockinOrder.Controls.Add(this.ckboxEnableEndDt);
            this.tabpgStockinOrder.Controls.Add(this.dtpQyEndDt);
            this.tabpgStockinOrder.Controls.Add(this.txtQyOrderNO);
            this.tabpgStockinOrder.Controls.Add(this.lblQyOrderNO);
            this.tabpgStockinOrder.Controls.Add(this.ckboxQyEnableStDt);
            this.tabpgStockinOrder.Controls.Add(this.btnOrderQuery);
            this.tabpgStockinOrder.Controls.Add(this.cboxQyCust);
            this.tabpgStockinOrder.Controls.Add(this.lblQyCust);
            this.tabpgStockinOrder.Controls.Add(this.dtpQyStDt);
            this.tabpgStockinOrder.Controls.Add(this.lblQyCrtTm);
            this.tabpgStockinOrder.Controls.Add(this.dtgvOrders);
            this.tabpgStockinOrder.Location = new System.Drawing.Point(4, 25);
            this.tabpgStockinOrder.Name = "tabpgStockinOrder";
            this.tabpgStockinOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgStockinOrder.Size = new System.Drawing.Size(1412, 706);
            this.tabpgStockinOrder.TabIndex = 1;
            this.tabpgStockinOrder.Text = "进货单查询";
            this.tabpgStockinOrder.UseVisualStyleBackColor = true;
            // 
            // dgvPager
            // 
            this.dgvPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPager.Location = new System.Drawing.Point(3, 667);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1406, 36);
            this.dgvPager.TabIndex = 10;
            this.dgvPager.TotalNum = 0;
            this.dgvPager.TotalPageNum = 0;
            this.dgvPager.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvPager_pagerBtnClicked);
            // 
            // lblQyDt
            // 
            this.lblQyDt.AutoSize = true;
            this.lblQyDt.Location = new System.Drawing.Point(893, 24);
            this.lblQyDt.Name = "lblQyDt";
            this.lblQyDt.Size = new System.Drawing.Size(22, 15);
            this.lblQyDt.TabIndex = 9;
            this.lblQyDt.Text = "—";
            // 
            // ckboxEnableEndDt
            // 
            this.ckboxEnableEndDt.AutoSize = true;
            this.ckboxEnableEndDt.Location = new System.Drawing.Point(1084, 22);
            this.ckboxEnableEndDt.Name = "ckboxEnableEndDt";
            this.ckboxEnableEndDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxEnableEndDt.TabIndex = 8;
            this.ckboxEnableEndDt.UseVisualStyleBackColor = true;
            this.ckboxEnableEndDt.Click += new System.EventHandler(this.ckboxEnableEndDt_Click);
            // 
            // dtpQyEndDt
            // 
            this.dtpQyEndDt.CustomFormat = "yyyy-MM-dd";
            this.dtpQyEndDt.Enabled = false;
            this.dtpQyEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyEndDt.Location = new System.Drawing.Point(928, 18);
            this.dtpQyEndDt.Name = "dtpQyEndDt";
            this.dtpQyEndDt.Size = new System.Drawing.Size(150, 25);
            this.dtpQyEndDt.TabIndex = 7;
            // 
            // txtQyOrderNO
            // 
            this.txtQyOrderNO.Location = new System.Drawing.Point(414, 18);
            this.txtQyOrderNO.Name = "txtQyOrderNO";
            this.txtQyOrderNO.Size = new System.Drawing.Size(180, 25);
            this.txtQyOrderNO.TabIndex = 2;
            // 
            // lblQyOrderNO
            // 
            this.lblQyOrderNO.AutoSize = true;
            this.lblQyOrderNO.Location = new System.Drawing.Point(356, 23);
            this.lblQyOrderNO.Name = "lblQyOrderNO";
            this.lblQyOrderNO.Size = new System.Drawing.Size(52, 15);
            this.lblQyOrderNO.TabIndex = 0;
            this.lblQyOrderNO.Text = "单号：";
            // 
            // ckboxQyEnableStDt
            // 
            this.ckboxQyEnableStDt.AutoSize = true;
            this.ckboxQyEnableStDt.Location = new System.Drawing.Point(865, 22);
            this.ckboxQyEnableStDt.Name = "ckboxQyEnableStDt";
            this.ckboxQyEnableStDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableStDt.TabIndex = 4;
            this.ckboxQyEnableStDt.UseVisualStyleBackColor = true;
            this.ckboxQyEnableStDt.Click += new System.EventHandler(this.ckboxEnableDt_Click);
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.Location = new System.Drawing.Point(1154, 15);
            this.btnOrderQuery.Name = "btnOrderQuery";
            this.btnOrderQuery.Size = new System.Drawing.Size(85, 30);
            this.btnOrderQuery.TabIndex = 6;
            this.btnOrderQuery.Text = "查询";
            this.btnOrderQuery.UseVisualStyleBackColor = true;
            this.btnOrderQuery.Click += new System.EventHandler(this.btnOrderQuery_Click);
            // 
            // cboxQyCust
            // 
            this.cboxQyCust.FormattingEnabled = true;
            this.cboxQyCust.Location = new System.Drawing.Point(79, 18);
            this.cboxQyCust.Name = "cboxQyCust";
            this.cboxQyCust.Size = new System.Drawing.Size(250, 23);
            this.cboxQyCust.TabIndex = 5;
            // 
            // lblQyCust
            // 
            this.lblQyCust.AutoSize = true;
            this.lblQyCust.Location = new System.Drawing.Point(6, 22);
            this.lblQyCust.Name = "lblQyCust";
            this.lblQyCust.Size = new System.Drawing.Size(67, 15);
            this.lblQyCust.TabIndex = 0;
            this.lblQyCust.Text = "供应商：";
            // 
            // dtpQyStDt
            // 
            this.dtpQyStDt.CustomFormat = "yyyy-MM-dd";
            this.dtpQyStDt.Enabled = false;
            this.dtpQyStDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyStDt.Location = new System.Drawing.Point(709, 18);
            this.dtpQyStDt.Name = "dtpQyStDt";
            this.dtpQyStDt.Size = new System.Drawing.Size(150, 25);
            this.dtpQyStDt.TabIndex = 3;
            // 
            // lblQyCrtTm
            // 
            this.lblQyCrtTm.AutoSize = true;
            this.lblQyCrtTm.Location = new System.Drawing.Point(621, 23);
            this.lblQyCrtTm.Name = "lblQyCrtTm";
            this.lblQyCrtTm.Size = new System.Drawing.Size(82, 15);
            this.lblQyCrtTm.TabIndex = 0;
            this.lblQyCrtTm.Text = "创建日期：";
            // 
            // dtgvOrders
            // 
            this.dtgvOrders.AllowUserToAddRows = false;
            this.dtgvOrders.AllowUserToDeleteRows = false;
            this.dtgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNO,
            this.colCustName,
            this.colAmount,
            this.colCrtTmst,
            this.colCrtUName,
            this.colUptTmst,
            this.colUptUName,
            this.colCustID,
            this.colCrtUID,
            this.colUptUID,
            this.colDirect});
            this.dtgvOrders.Location = new System.Drawing.Point(0, 60);
            this.dtgvOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvOrders.Name = "dtgvOrders";
            this.dtgvOrders.ReadOnly = true;
            this.dtgvOrders.RowTemplate.Height = 27;
            this.dtgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrders.Size = new System.Drawing.Size(1412, 602);
            this.dtgvOrders.TabIndex = 0;
            this.dtgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrders_CellDoubleClick);
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO__PK";
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colCustName
            // 
            this.colCustName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustName.DataPropertyName = "CustName";
            this.colCustName.FillWeight = 200F;
            this.colCustName.HeaderText = "供应商";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总计（元）";
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
            // colCrtUName
            // 
            this.colCrtUName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCrtUName.DataPropertyName = "CrtUName";
            this.colCrtUName.HeaderText = "创建人";
            this.colCrtUName.Name = "colCrtUName";
            this.colCrtUName.ReadOnly = true;
            // 
            // colUptTmst
            // 
            this.colUptTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUptTmst.DataPropertyName = "UptTmst";
            this.colUptTmst.HeaderText = "更新时间";
            this.colUptTmst.Name = "colUptTmst";
            this.colUptTmst.ReadOnly = true;
            // 
            // colUptUName
            // 
            this.colUptUName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUptUName.DataPropertyName = "UptUName";
            this.colUptUName.HeaderText = "更新人";
            this.colUptUName.Name = "colUptUName";
            this.colUptUName.ReadOnly = true;
            // 
            // colCustID
            // 
            this.colCustID.DataPropertyName = "CustID";
            this.colCustID.HeaderText = "CustID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            this.colCustID.Visible = false;
            // 
            // colCrtUID
            // 
            this.colCrtUID.DataPropertyName = "CrtUID";
            this.colCrtUID.HeaderText = "CrtUID";
            this.colCrtUID.Name = "colCrtUID";
            this.colCrtUID.ReadOnly = true;
            this.colCrtUID.Visible = false;
            // 
            // colUptUID
            // 
            this.colUptUID.DataPropertyName = "UptUID";
            this.colUptUID.HeaderText = "UptUID";
            this.colUptUID.Name = "colUptUID";
            this.colUptUID.ReadOnly = true;
            this.colUptUID.Visible = false;
            // 
            // colDirect
            // 
            this.colDirect.DataPropertyName = "Direct";
            this.colDirect.HeaderText = "Direct";
            this.colDirect.Name = "colDirect";
            this.colDirect.ReadOnly = true;
            this.colDirect.Visible = false;
            // 
            // tabpgStockin
            // 
            this.tabpgStockin.Controls.Add(this.autxtNSupplyGoods);
            this.tabpgStockin.Controls.Add(this.mthcdrMfDt);
            this.tabpgStockin.Controls.Add(this.btnBtchAdd);
            this.tabpgStockin.Controls.Add(this.btnDelete);
            this.tabpgStockin.Controls.Add(this.lblGoods);
            this.tabpgStockin.Controls.Add(this.btnAdd2List);
            this.tabpgStockin.Controls.Add(this.btnCreate);
            this.tabpgStockin.Controls.Add(this.cboxNSupplier);
            this.tabpgStockin.Controls.Add(this.lblSupplier);
            this.tabpgStockin.Controls.Add(this.dtgvStockin);
            this.tabpgStockin.Location = new System.Drawing.Point(4, 25);
            this.tabpgStockin.Name = "tabpgStockin";
            this.tabpgStockin.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgStockin.Size = new System.Drawing.Size(1412, 706);
            this.tabpgStockin.TabIndex = 0;
            this.tabpgStockin.Text = "创建进货单";
            this.tabpgStockin.UseVisualStyleBackColor = true;
            this.tabpgStockin.Click += new System.EventHandler(this.tabpgStockin_Click);
            // 
            // autxtNSupplyGoods
            // 
            this.autxtNSupplyGoods.Data = null;
            this.autxtNSupplyGoods.DropHeight = 139;
            this.autxtNSupplyGoods.Location = new System.Drawing.Point(472, 18);
            this.autxtNSupplyGoods.Name = "autxtNSupplyGoods";
            this.autxtNSupplyGoods.SelectedObj = null;
            this.autxtNSupplyGoods.Size = new System.Drawing.Size(300, 26);
            this.autxtNSupplyGoods.TabIndex = 24;
            this.autxtNSupplyGoods.Term = null;
            this.autxtNSupplyGoods.loadData += new auto_text.auto_text.LoadDataHandle(this.autxtNSupplyGoods_loadData);
            // 
            // mthcdrMfDt
            // 
            this.mthcdrMfDt.Location = new System.Drawing.Point(1136, 487);
            this.mthcdrMfDt.MaxSelectionCount = 1;
            this.mthcdrMfDt.Name = "mthcdrMfDt";
            this.mthcdrMfDt.TabIndex = 23;
            this.mthcdrMfDt.Visible = false;
            this.mthcdrMfDt.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mthcdrMfDt_DateSelected);
            // 
            // btnBtchAdd
            // 
            this.btnBtchAdd.Location = new System.Drawing.Point(1058, 15);
            this.btnBtchAdd.Name = "btnBtchAdd";
            this.btnBtchAdd.Size = new System.Drawing.Size(85, 30);
            this.btnBtchAdd.TabIndex = 20;
            this.btnBtchAdd.Text = "批量添加";
            this.btnBtchAdd.UseVisualStyleBackColor = true;
            this.btnBtchAdd.Click += new System.EventHandler(this.btnBtchAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(936, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Location = new System.Drawing.Point(360, 23);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(106, 15);
            this.lblGoods.TabIndex = 15;
            this.lblGoods.Text = "商品ID/名称：";
            // 
            // btnAdd2List
            // 
            this.btnAdd2List.Location = new System.Drawing.Point(816, 15);
            this.btnAdd2List.Name = "btnAdd2List";
            this.btnAdd2List.Size = new System.Drawing.Size(85, 30);
            this.btnAdd2List.TabIndex = 18;
            this.btnAdd2List.Text = "加入订单";
            this.btnAdd2List.UseVisualStyleBackColor = true;
            this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1178, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 30);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "进货";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cboxNSupplier
            // 
            this.cboxNSupplier.FormattingEnabled = true;
            this.cboxNSupplier.ItemHeight = 15;
            this.cboxNSupplier.Location = new System.Drawing.Point(81, 19);
            this.cboxNSupplier.Name = "cboxNSupplier";
            this.cboxNSupplier.Size = new System.Drawing.Size(250, 23);
            this.cboxNSupplier.TabIndex = 1;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(8, 23);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "供应商：";
            // 
            // dtgvStockin
            // 
            this.dtgvStockin.AllowUserToAddRows = false;
            this.dtgvStockin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvStockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colShelfLife,
            this.colMfDt,
            this.colPrice,
            this.colNum});
            this.dtgvStockin.Location = new System.Drawing.Point(0, 61);
            this.dtgvStockin.Name = "dtgvStockin";
            this.dtgvStockin.RowTemplate.Height = 27;
            this.dtgvStockin.Size = new System.Drawing.Size(1412, 643);
            this.dtgvStockin.TabIndex = 22;
            this.dtgvStockin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStockin_CellClick);
            this.dtgvStockin.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStockin_CellEndEdit);
            this.dtgvStockin.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStockin_CellLeave);
            this.dtgvStockin.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgvStockin_EditingControlShowing);
            this.dtgvStockin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvStockin_MouseClick);
            // 
            // colGID
            // 
            this.colGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGID.DataPropertyName = "GID__PK";
            this.colGID.HeaderText = "商品ID";
            this.colGID.Name = "colGID";
            this.colGID.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.DataPropertyName = "GName";
            this.colGName.FillWeight = 200F;
            this.colGName.HeaderText = "商品名称";
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colSpecs
            // 
            this.colSpecs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpecs.DataPropertyName = "Specs";
            this.colSpecs.HeaderText = "规格";
            this.colSpecs.Name = "colSpecs";
            this.colSpecs.ReadOnly = true;
            // 
            // colShelfLife
            // 
            this.colShelfLife.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShelfLife.DataPropertyName = "ShelfLife";
            this.colShelfLife.HeaderText = "保质期";
            this.colShelfLife.Name = "colShelfLife";
            this.colShelfLife.ReadOnly = true;
            // 
            // colMfDt
            // 
            this.colMfDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMfDt.HeaderText = "生产日期";
            this.colMfDt.MaxInputLength = 100;
            this.colMfDt.Name = "colMfDt";
            this.colMfDt.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.FillWeight = 80F;
            this.colPrice.HeaderText = "单价";
            this.colPrice.MaxInputLength = 100;
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.FillWeight = 80F;
            this.colNum.HeaderText = "数量";
            this.colNum.MaxInputLength = 100;
            this.colNum.Name = "colNum";
            this.colNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabSinOrders
            // 
            this.tabSinOrders.Controls.Add(this.tabpgStockin);
            this.tabSinOrders.Controls.Add(this.tabpgStockinOrder);
            this.tabSinOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSinOrders.Location = new System.Drawing.Point(0, 0);
            this.tabSinOrders.Name = "tabSinOrders";
            this.tabSinOrders.SelectedIndex = 0;
            this.tabSinOrders.Size = new System.Drawing.Size(1420, 735);
            this.tabSinOrders.TabIndex = 7;
            this.tabSinOrders.Click += new System.EventHandler(this.tabSinOrders_Click);
            // 
            // MStockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 735);
            this.Controls.Add(this.tabSinOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MStockInForm";
            this.Text = "MStockinForm";
            this.tabpgStockinOrder.ResumeLayout(false);
            this.tabpgStockinOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).EndInit();
            this.tabpgStockin.ResumeLayout(false);
            this.tabpgStockin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStockin)).EndInit();
            this.tabSinOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpgStockinOrder;
        private System.Windows.Forms.TabPage tabpgStockin;
        private System.Windows.Forms.TabControl tabSinOrders;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.ComboBox cboxQyCust;
        private System.Windows.Forms.Label lblQyCust;
        private System.Windows.Forms.DateTimePicker dtpQyStDt;
        private System.Windows.Forms.Label lblQyCrtTm;
        private System.Windows.Forms.DataGridView dtgvOrders;
        private System.Windows.Forms.CheckBox ckboxQyEnableStDt;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblQyOrderNO;
        private System.Windows.Forms.ComboBox cboxNSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnBtchAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.Button btnAdd2List;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.MonthCalendar mthcdrMfDt;
        private System.Windows.Forms.DataGridView dtgvStockin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMfDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.CheckBox ckboxEnableEndDt;
        private System.Windows.Forms.DateTimePicker dtpQyEndDt;
        private System.Windows.Forms.Label lblQyDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirect;
        private dgv_pager.DGVPager dgvPager;
        private auto_text.auto_text autxtNSupplyGoods;
    }
}