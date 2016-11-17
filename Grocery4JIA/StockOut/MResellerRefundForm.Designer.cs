namespace UI
{
    partial class MResellerRefundForm
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
            this.tabResellerRfOrders = new System.Windows.Forms.TabControl();
            this.tabPCreatResellerRfOrder = new System.Windows.Forms.TabPage();
            this.autxtSodGoods = new auto_text.auto_text();
            this.btnBtchAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGoods = new System.Windows.Forms.Label();
            this.cboxNReseller = new System.Windows.Forms.ComboBox();
            this.lblReseller = new System.Windows.Forms.Label();
            this.btnAdd2List = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.dtgvResellerRfGoods = new System.Windows.Forms.DataGridView();
            this.colSOutOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReseller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoldNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRfNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTgtSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPQyResellerRfOrders = new System.Windows.Forms.TabPage();
            this.dgvPager = new dgv_pager.DGVPager();
            this.lblQyDt = new System.Windows.Forms.Label();
            this.ckboxQyEnableEndDt = new System.Windows.Forms.CheckBox();
            this.dtpQyEndDt = new System.Windows.Forms.DateTimePicker();
            this.cboxQyReseller = new System.Windows.Forms.ComboBox();
            this.lblQyReseller = new System.Windows.Forms.Label();
            this.ckboxQyEnableStDt = new System.Windows.Forms.CheckBox();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.dtpQyStDt = new System.Windows.Forms.DateTimePicker();
            this.lblCrtTm = new System.Windows.Forms.Label();
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblOrderNO = new System.Windows.Forms.Label();
            this.dtgvResellerRfOrders = new System.Windows.Forms.DataGridView();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQyReseller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabResellerRfOrders.SuspendLayout();
            this.tabPCreatResellerRfOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResellerRfGoods)).BeginInit();
            this.tabPQyResellerRfOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResellerRfOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabResellerRfOrders
            // 
            this.tabResellerRfOrders.Controls.Add(this.tabPCreatResellerRfOrder);
            this.tabResellerRfOrders.Controls.Add(this.tabPQyResellerRfOrders);
            this.tabResellerRfOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResellerRfOrders.Location = new System.Drawing.Point(0, 0);
            this.tabResellerRfOrders.Name = "tabResellerRfOrders";
            this.tabResellerRfOrders.SelectedIndex = 0;
            this.tabResellerRfOrders.Size = new System.Drawing.Size(1343, 711);
            this.tabResellerRfOrders.TabIndex = 2;
            // 
            // tabPCreatResellerRfOrder
            // 
            this.tabPCreatResellerRfOrder.Controls.Add(this.autxtSodGoods);
            this.tabPCreatResellerRfOrder.Controls.Add(this.btnBtchAdd);
            this.tabPCreatResellerRfOrder.Controls.Add(this.btnDelete);
            this.tabPCreatResellerRfOrder.Controls.Add(this.lblGoods);
            this.tabPCreatResellerRfOrder.Controls.Add(this.cboxNReseller);
            this.tabPCreatResellerRfOrder.Controls.Add(this.lblReseller);
            this.tabPCreatResellerRfOrder.Controls.Add(this.btnAdd2List);
            this.tabPCreatResellerRfOrder.Controls.Add(this.btnRefund);
            this.tabPCreatResellerRfOrder.Controls.Add(this.dtgvResellerRfGoods);
            this.tabPCreatResellerRfOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPCreatResellerRfOrder.Name = "tabPCreatResellerRfOrder";
            this.tabPCreatResellerRfOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCreatResellerRfOrder.Size = new System.Drawing.Size(1335, 682);
            this.tabPCreatResellerRfOrder.TabIndex = 0;
            this.tabPCreatResellerRfOrder.Text = "创建回收单";
            this.tabPCreatResellerRfOrder.UseVisualStyleBackColor = true;
            // 
            // autxtSodGoods
            // 
            this.autxtSodGoods.Data = null;
            this.autxtSodGoods.DropHeight = 139;
            this.autxtSodGoods.Location = new System.Drawing.Point(460, 17);
            this.autxtSodGoods.Name = "autxtSodGoods";
            this.autxtSodGoods.SelectedObj = null;
            this.autxtSodGoods.Size = new System.Drawing.Size(300, 26);
            this.autxtSodGoods.TabIndex = 9;
            this.autxtSodGoods.Term = null;
            this.autxtSodGoods.loadData += new auto_text.auto_text.LoadDataHandle(this.autxtSodGoods_loadData);
            // 
            // btnBtchAdd
            // 
            this.btnBtchAdd.Location = new System.Drawing.Point(1083, 14);
            this.btnBtchAdd.Name = "btnBtchAdd";
            this.btnBtchAdd.Size = new System.Drawing.Size(85, 30);
            this.btnBtchAdd.TabIndex = 6;
            this.btnBtchAdd.Text = "批量选择";
            this.btnBtchAdd.UseVisualStyleBackColor = true;
            this.btnBtchAdd.Click += new System.EventHandler(this.btnBtchAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(961, 14);
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
            // cboxNReseller
            // 
            this.cboxNReseller.FormattingEnabled = true;
            this.cboxNReseller.Location = new System.Drawing.Point(76, 18);
            this.cboxNReseller.Name = "cboxNReseller";
            this.cboxNReseller.Size = new System.Drawing.Size(250, 23);
            this.cboxNReseller.TabIndex = 1;
            this.cboxNReseller.SelectedIndexChanged += new System.EventHandler(this.cboxNReseller_SelectedIndexChanged);
            // 
            // lblReseller
            // 
            this.lblReseller.AutoSize = true;
            this.lblReseller.Location = new System.Drawing.Point(3, 22);
            this.lblReseller.Name = "lblReseller";
            this.lblReseller.Size = new System.Drawing.Size(67, 15);
            this.lblReseller.TabIndex = 0;
            this.lblReseller.Text = "分销商：";
            // 
            // btnAdd2List
            // 
            this.btnAdd2List.Location = new System.Drawing.Point(841, 14);
            this.btnAdd2List.Name = "btnAdd2List";
            this.btnAdd2List.Size = new System.Drawing.Size(85, 30);
            this.btnAdd2List.TabIndex = 4;
            this.btnAdd2List.Text = "加入订单";
            this.btnAdd2List.UseVisualStyleBackColor = true;
            this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(1203, 14);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(85, 30);
            this.btnRefund.TabIndex = 7;
            this.btnRefund.Text = "回收";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // dtgvResellerRfGoods
            // 
            this.dtgvResellerRfGoods.AllowUserToAddRows = false;
            this.dtgvResellerRfGoods.AllowUserToDeleteRows = false;
            this.dtgvResellerRfGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvResellerRfGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResellerRfGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSOutOrderNO,
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colReseller,
            this.colExpDt,
            this.colSalePrice,
            this.colSoldNum,
            this.colRfNum,
            this.colPrice,
            this.colNum,
            this.colInvID,
            this.colTgtSID});
            this.dtgvResellerRfGoods.Location = new System.Drawing.Point(0, 61);
            this.dtgvResellerRfGoods.Name = "dtgvResellerRfGoods";
            this.dtgvResellerRfGoods.RowTemplate.Height = 27;
            this.dtgvResellerRfGoods.Size = new System.Drawing.Size(1335, 625);
            this.dtgvResellerRfGoods.TabIndex = 8;
            this.dtgvResellerRfGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvResellerRfGoods_CellEndEdit);
            this.dtgvResellerRfGoods.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgvResellerRfGoods_EditingControlShowing);
            // 
            // colSOutOrderNO
            // 
            this.colSOutOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSOutOrderNO.HeaderText = "出货单号";
            this.colSOutOrderNO.Name = "colSOutOrderNO";
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
            // colReseller
            // 
            this.colReseller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReseller.HeaderText = "分销商";
            this.colReseller.Name = "colReseller";
            this.colReseller.ReadOnly = true;
            // 
            // colExpDt
            // 
            this.colExpDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpDt.HeaderText = "到期日";
            this.colExpDt.Name = "colExpDt";
            this.colExpDt.ReadOnly = true;
            // 
            // colSalePrice
            // 
            this.colSalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSalePrice.HeaderText = "售价/元";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            // 
            // colSoldNum
            // 
            this.colSoldNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoldNum.FillWeight = 80F;
            this.colSoldNum.HeaderText = "出货量";
            this.colSoldNum.Name = "colSoldNum";
            this.colSoldNum.ReadOnly = true;
            // 
            // colRfNum
            // 
            this.colRfNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRfNum.FillWeight = 80F;
            this.colRfNum.HeaderText = "已回收";
            this.colRfNum.Name = "colRfNum";
            this.colRfNum.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.HeaderText = "回收价/元";
            this.colPrice.Name = "colPrice";
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.FillWeight = 80F;
            this.colNum.HeaderText = "回收量";
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
            this.colTgtSID.DataPropertyName = "TgtSID";
            this.colTgtSID.HeaderText = "SID";
            this.colTgtSID.Name = "colTgtSID";
            this.colTgtSID.ReadOnly = true;
            this.colTgtSID.Visible = false;
            // 
            // tabPQyResellerRfOrders
            // 
            this.tabPQyResellerRfOrders.Controls.Add(this.dgvPager);
            this.tabPQyResellerRfOrders.Controls.Add(this.lblQyDt);
            this.tabPQyResellerRfOrders.Controls.Add(this.ckboxQyEnableEndDt);
            this.tabPQyResellerRfOrders.Controls.Add(this.dtpQyEndDt);
            this.tabPQyResellerRfOrders.Controls.Add(this.cboxQyReseller);
            this.tabPQyResellerRfOrders.Controls.Add(this.lblQyReseller);
            this.tabPQyResellerRfOrders.Controls.Add(this.ckboxQyEnableStDt);
            this.tabPQyResellerRfOrders.Controls.Add(this.btnOrderQuery);
            this.tabPQyResellerRfOrders.Controls.Add(this.dtpQyStDt);
            this.tabPQyResellerRfOrders.Controls.Add(this.lblCrtTm);
            this.tabPQyResellerRfOrders.Controls.Add(this.txtQyOrderNO);
            this.tabPQyResellerRfOrders.Controls.Add(this.lblOrderNO);
            this.tabPQyResellerRfOrders.Controls.Add(this.dtgvResellerRfOrders);
            this.tabPQyResellerRfOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPQyResellerRfOrders.Name = "tabPQyResellerRfOrders";
            this.tabPQyResellerRfOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPQyResellerRfOrders.Size = new System.Drawing.Size(1335, 682);
            this.tabPQyResellerRfOrders.TabIndex = 1;
            this.tabPQyResellerRfOrders.Text = "回收单查询";
            this.tabPQyResellerRfOrders.UseVisualStyleBackColor = true;
            // 
            // dgvPager
            // 
            this.dgvPager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPager.Location = new System.Drawing.Point(3, 643);
            this.dgvPager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPager.Name = "dgvPager";
            this.dgvPager.Size = new System.Drawing.Size(1329, 36);
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
            // cboxQyReseller
            // 
            this.cboxQyReseller.FormattingEnabled = true;
            this.cboxQyReseller.Location = new System.Drawing.Point(78, 16);
            this.cboxQyReseller.Name = "cboxQyReseller";
            this.cboxQyReseller.Size = new System.Drawing.Size(250, 23);
            this.cboxQyReseller.TabIndex = 12;
            // 
            // lblQyReseller
            // 
            this.lblQyReseller.AutoSize = true;
            this.lblQyReseller.Location = new System.Drawing.Point(6, 20);
            this.lblQyReseller.Name = "lblQyReseller";
            this.lblQyReseller.Size = new System.Drawing.Size(67, 15);
            this.lblQyReseller.TabIndex = 8;
            this.lblQyReseller.Text = "分销商：";
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
            this.btnOrderQuery.Location = new System.Drawing.Point(1164, 12);
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
            // dtgvResellerRfOrders
            // 
            this.dtgvResellerRfOrders.AllowUserToAddRows = false;
            this.dtgvResellerRfOrders.AllowUserToDeleteRows = false;
            this.dtgvResellerRfOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvResellerRfOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResellerRfOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNO,
            this.colQyReseller,
            this.colAmount,
            this.colCrtTmst,
            this.colCrtName,
            this.colUptTmst,
            this.colUptName});
            this.dtgvResellerRfOrders.Location = new System.Drawing.Point(2, 56);
            this.dtgvResellerRfOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvResellerRfOrders.Name = "dtgvResellerRfOrders";
            this.dtgvResellerRfOrders.ReadOnly = true;
            this.dtgvResellerRfOrders.RowTemplate.Height = 27;
            this.dtgvResellerRfOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvResellerRfOrders.Size = new System.Drawing.Size(1332, 585);
            this.dtgvResellerRfOrders.TabIndex = 11;
            this.dtgvResellerRfOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvResellerRfOrders_CellDoubleClick);
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
            // colQyReseller
            // 
            this.colQyReseller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQyReseller.DataPropertyName = "CustName";
            this.colQyReseller.FillWeight = 200F;
            this.colQyReseller.HeaderText = "分销商";
            this.colQyReseller.Name = "colQyReseller";
            this.colQyReseller.ReadOnly = true;
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
            // MResellerRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 711);
            this.Controls.Add(this.tabResellerRfOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MResellerRefundForm";
            this.Text = "MResellerRefundForm";
            this.tabResellerRfOrders.ResumeLayout(false);
            this.tabPCreatResellerRfOrder.ResumeLayout(false);
            this.tabPCreatResellerRfOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResellerRfGoods)).EndInit();
            this.tabPQyResellerRfOrders.ResumeLayout(false);
            this.tabPQyResellerRfOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResellerRfOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabResellerRfOrders;
        private System.Windows.Forms.TabPage tabPCreatResellerRfOrder;
        private System.Windows.Forms.Button btnBtchAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.ComboBox cboxNReseller;
        private System.Windows.Forms.Label lblReseller;
        private System.Windows.Forms.Button btnAdd2List;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.DataGridView dtgvResellerRfGoods;
        private System.Windows.Forms.TabPage tabPQyResellerRfOrders;
        private System.Windows.Forms.Label lblQyDt;
        private System.Windows.Forms.CheckBox ckboxQyEnableEndDt;
        private System.Windows.Forms.DateTimePicker dtpQyEndDt;
        private System.Windows.Forms.ComboBox cboxQyReseller;
        private System.Windows.Forms.Label lblQyReseller;
        private System.Windows.Forms.CheckBox ckboxQyEnableStDt;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.DateTimePicker dtpQyStDt;
        private System.Windows.Forms.Label lblCrtTm;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblOrderNO;
        private System.Windows.Forms.DataGridView dtgvResellerRfOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOutOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReseller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoldNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRfNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTgtSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQyReseller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptName;
        private dgv_pager.DGVPager dgvPager;
        private auto_text.auto_text autxtSodGoods;
    }
}