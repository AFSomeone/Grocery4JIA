namespace UI
{
    partial class MSupplierBillingForm
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
            this.tabStockInBill = new System.Windows.Forms.TabControl();
            this.tabPOrders = new System.Windows.Forms.TabPage();
            this.dgvpgOrder = new dgv_pager.DGVPager();
            this.cboxEntry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxDirect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntry = new System.Windows.Forms.Button();
            this.lblQyDt = new System.Windows.Forms.Label();
            this.ckboxQyEnableEndDt = new System.Windows.Forms.CheckBox();
            this.dtpQyEndDt = new System.Windows.Forms.DateTimePicker();
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblQyOrderNO = new System.Windows.Forms.Label();
            this.ckboxQyEnableStDt = new System.Windows.Forms.CheckBox();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.cboxQrdSupplier = new System.Windows.Forms.ComboBox();
            this.lblQyCust = new System.Windows.Forms.Label();
            this.dtpQyStDt = new System.Windows.Forms.DateTimePicker();
            this.lblQyCrtTm = new System.Windows.Forms.Label();
            this.dtgvOrders = new System.Windows.Forms.DataGridView();
            this.colCkboxs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPBills = new System.Windows.Forms.TabPage();
            this.dgvpgBill = new dgv_pager.DGVPager();
            this.cboxBillSt = new System.Windows.Forms.ComboBox();
            this.lblBillSt = new System.Windows.Forms.Label();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ckboxBillEnableEndDt = new System.Windows.Forms.CheckBox();
            this.dtpBillEndDt = new System.Windows.Forms.DateTimePicker();
            this.txtBillNO = new System.Windows.Forms.TextBox();
            this.lblBillNO = new System.Windows.Forms.Label();
            this.ckboxBillEnableStDt = new System.Windows.Forms.CheckBox();
            this.btnBillQuery = new System.Windows.Forms.Button();
            this.cboxBillSuppliers = new System.Windows.Forms.ComboBox();
            this.lblBillSuppliers = new System.Windows.Forms.Label();
            this.dtpBillStDt = new System.Windows.Forms.DateTimePicker();
            this.lblBillDt = new System.Windows.Forms.Label();
            this.dtgvBilling = new System.Windows.Forms.DataGridView();
            this.colPayBillNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillCrtUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStockInBill.SuspendLayout();
            this.tabPOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).BeginInit();
            this.tabPBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStockInBill
            // 
            this.tabStockInBill.Controls.Add(this.tabPOrders);
            this.tabStockInBill.Controls.Add(this.tabPBills);
            this.tabStockInBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStockInBill.Location = new System.Drawing.Point(0, 0);
            this.tabStockInBill.Name = "tabStockInBill";
            this.tabStockInBill.SelectedIndex = 0;
            this.tabStockInBill.Size = new System.Drawing.Size(1687, 693);
            this.tabStockInBill.TabIndex = 0;
            // 
            // tabPOrders
            // 
            this.tabPOrders.Controls.Add(this.dgvpgOrder);
            this.tabPOrders.Controls.Add(this.cboxEntry);
            this.tabPOrders.Controls.Add(this.label2);
            this.tabPOrders.Controls.Add(this.cboxDirect);
            this.tabPOrders.Controls.Add(this.label1);
            this.tabPOrders.Controls.Add(this.btnEntry);
            this.tabPOrders.Controls.Add(this.lblQyDt);
            this.tabPOrders.Controls.Add(this.ckboxQyEnableEndDt);
            this.tabPOrders.Controls.Add(this.dtpQyEndDt);
            this.tabPOrders.Controls.Add(this.txtQyOrderNO);
            this.tabPOrders.Controls.Add(this.lblQyOrderNO);
            this.tabPOrders.Controls.Add(this.ckboxQyEnableStDt);
            this.tabPOrders.Controls.Add(this.btnOrderQuery);
            this.tabPOrders.Controls.Add(this.cboxQrdSupplier);
            this.tabPOrders.Controls.Add(this.lblQyCust);
            this.tabPOrders.Controls.Add(this.dtpQyStDt);
            this.tabPOrders.Controls.Add(this.lblQyCrtTm);
            this.tabPOrders.Controls.Add(this.dtgvOrders);
            this.tabPOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPOrders.Name = "tabPOrders";
            this.tabPOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOrders.Size = new System.Drawing.Size(1679, 664);
            this.tabPOrders.TabIndex = 0;
            this.tabPOrders.Text = "供应商订单";
            this.tabPOrders.UseVisualStyleBackColor = true;
            // 
            // dgvpgOrder
            // 
            this.dgvpgOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpgOrder.Location = new System.Drawing.Point(3, 625);
            this.dgvpgOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvpgOrder.Name = "dgvpgOrder";
            this.dgvpgOrder.Size = new System.Drawing.Size(1673, 36);
            this.dgvpgOrder.TabIndex = 39;
            this.dgvpgOrder.TotalNum = 0;
            this.dgvpgOrder.TotalPageNum = 0;
            this.dgvpgOrder.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvpgOrder_pagerBtnClicked);
            // 
            // cboxEntry
            // 
            this.cboxEntry.FormattingEnabled = true;
            this.cboxEntry.Location = new System.Drawing.Point(837, 20);
            this.cboxEntry.Name = "cboxEntry";
            this.cboxEntry.Size = new System.Drawing.Size(100, 23);
            this.cboxEntry.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "状态：";
            // 
            // cboxDirect
            // 
            this.cboxDirect.FormattingEnabled = true;
            this.cboxDirect.Location = new System.Drawing.Point(664, 20);
            this.cboxDirect.Name = "cboxDirect";
            this.cboxDirect.Size = new System.Drawing.Size(100, 23);
            this.cboxDirect.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "订单类别：";
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(1569, 15);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(85, 30);
            this.btnEntry.TabIndex = 34;
            this.btnEntry.Text = "入帐";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // lblQyDt
            // 
            this.lblQyDt.AutoSize = true;
            this.lblQyDt.Location = new System.Drawing.Point(1218, 24);
            this.lblQyDt.Name = "lblQyDt";
            this.lblQyDt.Size = new System.Drawing.Size(22, 15);
            this.lblQyDt.TabIndex = 33;
            this.lblQyDt.Text = "—";
            // 
            // ckboxQyEnableEndDt
            // 
            this.ckboxQyEnableEndDt.AutoSize = true;
            this.ckboxQyEnableEndDt.Location = new System.Drawing.Point(1403, 23);
            this.ckboxQyEnableEndDt.Name = "ckboxQyEnableEndDt";
            this.ckboxQyEnableEndDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableEndDt.TabIndex = 32;
            this.ckboxQyEnableEndDt.UseVisualStyleBackColor = true;
            this.ckboxQyEnableEndDt.Click += new System.EventHandler(this.ckboxEnableEndDt_Click);
            // 
            // dtpQyEndDt
            // 
            this.dtpQyEndDt.CustomFormat = "yyyy-MM-dd";
            this.dtpQyEndDt.Enabled = false;
            this.dtpQyEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyEndDt.Location = new System.Drawing.Point(1247, 19);
            this.dtpQyEndDt.Name = "dtpQyEndDt";
            this.dtpQyEndDt.Size = new System.Drawing.Size(150, 25);
            this.dtpQyEndDt.TabIndex = 31;
            // 
            // txtQyOrderNO
            // 
            this.txtQyOrderNO.Location = new System.Drawing.Point(398, 19);
            this.txtQyOrderNO.Name = "txtQyOrderNO";
            this.txtQyOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtQyOrderNO.TabIndex = 26;
            // 
            // lblQyOrderNO
            // 
            this.lblQyOrderNO.AutoSize = true;
            this.lblQyOrderNO.Location = new System.Drawing.Point(340, 24);
            this.lblQyOrderNO.Name = "lblQyOrderNO";
            this.lblQyOrderNO.Size = new System.Drawing.Size(52, 15);
            this.lblQyOrderNO.TabIndex = 22;
            this.lblQyOrderNO.Text = "单号：";
            // 
            // ckboxQyEnableStDt
            // 
            this.ckboxQyEnableStDt.AutoSize = true;
            this.ckboxQyEnableStDt.Location = new System.Drawing.Point(1198, 23);
            this.ckboxQyEnableStDt.Name = "ckboxQyEnableStDt";
            this.ckboxQyEnableStDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableStDt.TabIndex = 28;
            this.ckboxQyEnableStDt.UseVisualStyleBackColor = true;
            this.ckboxQyEnableStDt.Click += new System.EventHandler(this.ckboxQyEnableStDt_Click);
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.Location = new System.Drawing.Point(1456, 16);
            this.btnOrderQuery.Name = "btnOrderQuery";
            this.btnOrderQuery.Size = new System.Drawing.Size(85, 30);
            this.btnOrderQuery.TabIndex = 30;
            this.btnOrderQuery.Text = "查询";
            this.btnOrderQuery.UseVisualStyleBackColor = true;
            this.btnOrderQuery.Click += new System.EventHandler(this.btnOrderQuery_Click);
            // 
            // cboxQrdSupplier
            // 
            this.cboxQrdSupplier.FormattingEnabled = true;
            this.cboxQrdSupplier.Location = new System.Drawing.Point(80, 20);
            this.cboxQrdSupplier.Name = "cboxQrdSupplier";
            this.cboxQrdSupplier.Size = new System.Drawing.Size(250, 23);
            this.cboxQrdSupplier.TabIndex = 29;
            // 
            // lblQyCust
            // 
            this.lblQyCust.AutoSize = true;
            this.lblQyCust.Location = new System.Drawing.Point(7, 24);
            this.lblQyCust.Name = "lblQyCust";
            this.lblQyCust.Size = new System.Drawing.Size(67, 15);
            this.lblQyCust.TabIndex = 23;
            this.lblQyCust.Text = "供应商：";
            // 
            // dtpQyStDt
            // 
            this.dtpQyStDt.CustomFormat = "yyyy-MM-dd";
            this.dtpQyStDt.Enabled = false;
            this.dtpQyStDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyStDt.Location = new System.Drawing.Point(1042, 19);
            this.dtpQyStDt.Name = "dtpQyStDt";
            this.dtpQyStDt.Size = new System.Drawing.Size(150, 25);
            this.dtpQyStDt.TabIndex = 27;
            // 
            // lblQyCrtTm
            // 
            this.lblQyCrtTm.AutoSize = true;
            this.lblQyCrtTm.Location = new System.Drawing.Point(954, 24);
            this.lblQyCrtTm.Name = "lblQyCrtTm";
            this.lblQyCrtTm.Size = new System.Drawing.Size(82, 15);
            this.lblQyCrtTm.TabIndex = 24;
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
            this.colCkboxs,
            this.colOrderNO,
            this.colDirectDesc,
            this.colAmount,
            this.colBillNO,
            this.colCrtUName,
            this.colCrtTmst,
            this.colCustID,
            this.colCrtUID,
            this.colHandled,
            this.colDirect});
            this.dtgvOrders.Location = new System.Drawing.Point(1, 59);
            this.dtgvOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvOrders.Name = "dtgvOrders";
            this.dtgvOrders.ReadOnly = true;
            this.dtgvOrders.RowTemplate.Height = 27;
            this.dtgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrders.Size = new System.Drawing.Size(1677, 560);
            this.dtgvOrders.TabIndex = 25;
            this.dtgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrders_CellContentClick);
            this.dtgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrders_CellDoubleClick);
            // 
            // colCkboxs
            // 
            this.colCkboxs.FillWeight = 50F;
            this.colCkboxs.HeaderText = "";
            this.colCkboxs.Name = "colCkboxs";
            this.colCkboxs.ReadOnly = true;
            this.colCkboxs.Width = 50;
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO";
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colDirectDesc
            // 
            this.colDirectDesc.DataPropertyName = "Direct";
            this.colDirectDesc.HeaderText = "类型";
            this.colDirectDesc.Name = "colDirectDesc";
            this.colDirectDesc.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总计（元）";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colBillNO
            // 
            this.colBillNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBillNO.HeaderText = "账单号";
            this.colBillNO.Name = "colBillNO";
            this.colBillNO.ReadOnly = true;
            // 
            // colCrtUName
            // 
            this.colCrtUName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCrtUName.DataPropertyName = "CrtUName";
            this.colCrtUName.HeaderText = "创建人";
            this.colCrtUName.Name = "colCrtUName";
            this.colCrtUName.ReadOnly = true;
            // 
            // colCrtTmst
            // 
            this.colCrtTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCrtTmst.DataPropertyName = "CrtTmst";
            this.colCrtTmst.HeaderText = "创建时间";
            this.colCrtTmst.Name = "colCrtTmst";
            this.colCrtTmst.ReadOnly = true;
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
            // colHandled
            // 
            this.colHandled.HeaderText = "Handled";
            this.colHandled.Name = "colHandled";
            this.colHandled.ReadOnly = true;
            this.colHandled.Visible = false;
            // 
            // colDirect
            // 
            this.colDirect.HeaderText = "Direct";
            this.colDirect.Name = "colDirect";
            this.colDirect.ReadOnly = true;
            this.colDirect.Visible = false;
            // 
            // tabPBills
            // 
            this.tabPBills.Controls.Add(this.dgvpgBill);
            this.tabPBills.Controls.Add(this.cboxBillSt);
            this.tabPBills.Controls.Add(this.lblBillSt);
            this.tabPBills.Controls.Add(this.btnPayBill);
            this.tabPBills.Controls.Add(this.label5);
            this.tabPBills.Controls.Add(this.ckboxBillEnableEndDt);
            this.tabPBills.Controls.Add(this.dtpBillEndDt);
            this.tabPBills.Controls.Add(this.txtBillNO);
            this.tabPBills.Controls.Add(this.lblBillNO);
            this.tabPBills.Controls.Add(this.ckboxBillEnableStDt);
            this.tabPBills.Controls.Add(this.btnBillQuery);
            this.tabPBills.Controls.Add(this.cboxBillSuppliers);
            this.tabPBills.Controls.Add(this.lblBillSuppliers);
            this.tabPBills.Controls.Add(this.dtpBillStDt);
            this.tabPBills.Controls.Add(this.lblBillDt);
            this.tabPBills.Controls.Add(this.dtgvBilling);
            this.tabPBills.Location = new System.Drawing.Point(4, 25);
            this.tabPBills.Name = "tabPBills";
            this.tabPBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPBills.Size = new System.Drawing.Size(1679, 664);
            this.tabPBills.TabIndex = 1;
            this.tabPBills.Text = "付款单";
            this.tabPBills.UseVisualStyleBackColor = true;
            // 
            // dgvpgBill
            // 
            this.dgvpgBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpgBill.Location = new System.Drawing.Point(3, 625);
            this.dgvpgBill.Margin = new System.Windows.Forms.Padding(2);
            this.dgvpgBill.Name = "dgvpgBill";
            this.dgvpgBill.Size = new System.Drawing.Size(1673, 36);
            this.dgvpgBill.TabIndex = 56;
            this.dgvpgBill.TotalNum = 0;
            this.dgvpgBill.TotalPageNum = 0;
            this.dgvpgBill.pagerBtnClicked += new dgv_pager.DGVPager.PagerBtnClickHandle(this.dgvpgBill_pagerBtnClicked);
            // 
            // cboxBillSt
            // 
            this.cboxBillSt.FormattingEnabled = true;
            this.cboxBillSt.Location = new System.Drawing.Point(651, 20);
            this.cboxBillSt.Name = "cboxBillSt";
            this.cboxBillSt.Size = new System.Drawing.Size(100, 23);
            this.cboxBillSt.TabIndex = 55;
            // 
            // lblBillSt
            // 
            this.lblBillSt.AutoSize = true;
            this.lblBillSt.Location = new System.Drawing.Point(593, 24);
            this.lblBillSt.Name = "lblBillSt";
            this.lblBillSt.Size = new System.Drawing.Size(52, 15);
            this.lblBillSt.TabIndex = 54;
            this.lblBillSt.Text = "状态：";
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(1375, 15);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(85, 30);
            this.btnPayBill.TabIndex = 51;
            this.btnPayBill.Text = "付款信息";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1031, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "—";
            // 
            // ckboxBillEnableEndDt
            // 
            this.ckboxBillEnableEndDt.AutoSize = true;
            this.ckboxBillEnableEndDt.Location = new System.Drawing.Point(1216, 23);
            this.ckboxBillEnableEndDt.Name = "ckboxBillEnableEndDt";
            this.ckboxBillEnableEndDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxBillEnableEndDt.TabIndex = 49;
            this.ckboxBillEnableEndDt.UseVisualStyleBackColor = true;
            this.ckboxBillEnableEndDt.CheckedChanged += new System.EventHandler(this.ckboxBillEnableEndDt_CheckedChanged);
            // 
            // dtpBillEndDt
            // 
            this.dtpBillEndDt.CustomFormat = "yyyy-MM-dd";
            this.dtpBillEndDt.Enabled = false;
            this.dtpBillEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillEndDt.Location = new System.Drawing.Point(1060, 19);
            this.dtpBillEndDt.Name = "dtpBillEndDt";
            this.dtpBillEndDt.Size = new System.Drawing.Size(150, 25);
            this.dtpBillEndDt.TabIndex = 48;
            // 
            // txtBillNO
            // 
            this.txtBillNO.Location = new System.Drawing.Point(411, 19);
            this.txtBillNO.Name = "txtBillNO";
            this.txtBillNO.Size = new System.Drawing.Size(170, 25);
            this.txtBillNO.TabIndex = 43;
            // 
            // lblBillNO
            // 
            this.lblBillNO.AutoSize = true;
            this.lblBillNO.Location = new System.Drawing.Point(340, 24);
            this.lblBillNO.Name = "lblBillNO";
            this.lblBillNO.Size = new System.Drawing.Size(67, 15);
            this.lblBillNO.TabIndex = 39;
            this.lblBillNO.Text = "账单号：";
            // 
            // ckboxBillEnableStDt
            // 
            this.ckboxBillEnableStDt.AutoSize = true;
            this.ckboxBillEnableStDt.Location = new System.Drawing.Point(1011, 23);
            this.ckboxBillEnableStDt.Name = "ckboxBillEnableStDt";
            this.ckboxBillEnableStDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxBillEnableStDt.TabIndex = 45;
            this.ckboxBillEnableStDt.UseVisualStyleBackColor = true;
            this.ckboxBillEnableStDt.CheckedChanged += new System.EventHandler(this.ckboxBillEnableStDt_CheckedChanged);
            // 
            // btnBillQuery
            // 
            this.btnBillQuery.Location = new System.Drawing.Point(1262, 16);
            this.btnBillQuery.Name = "btnBillQuery";
            this.btnBillQuery.Size = new System.Drawing.Size(85, 30);
            this.btnBillQuery.TabIndex = 47;
            this.btnBillQuery.Text = "查询";
            this.btnBillQuery.UseVisualStyleBackColor = true;
            this.btnBillQuery.Click += new System.EventHandler(this.btnBillQuery_Click);
            // 
            // cboxBillSuppliers
            // 
            this.cboxBillSuppliers.FormattingEnabled = true;
            this.cboxBillSuppliers.Location = new System.Drawing.Point(80, 20);
            this.cboxBillSuppliers.Name = "cboxBillSuppliers";
            this.cboxBillSuppliers.Size = new System.Drawing.Size(250, 23);
            this.cboxBillSuppliers.TabIndex = 46;
            // 
            // lblBillSuppliers
            // 
            this.lblBillSuppliers.AutoSize = true;
            this.lblBillSuppliers.Location = new System.Drawing.Point(7, 24);
            this.lblBillSuppliers.Name = "lblBillSuppliers";
            this.lblBillSuppliers.Size = new System.Drawing.Size(67, 15);
            this.lblBillSuppliers.TabIndex = 40;
            this.lblBillSuppliers.Text = "供应商：";
            // 
            // dtpBillStDt
            // 
            this.dtpBillStDt.CustomFormat = "yyyy-MM-dd";
            this.dtpBillStDt.Enabled = false;
            this.dtpBillStDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillStDt.Location = new System.Drawing.Point(855, 19);
            this.dtpBillStDt.Name = "dtpBillStDt";
            this.dtpBillStDt.Size = new System.Drawing.Size(150, 25);
            this.dtpBillStDt.TabIndex = 44;
            // 
            // lblBillDt
            // 
            this.lblBillDt.AutoSize = true;
            this.lblBillDt.Location = new System.Drawing.Point(767, 24);
            this.lblBillDt.Name = "lblBillDt";
            this.lblBillDt.Size = new System.Drawing.Size(82, 15);
            this.lblBillDt.TabIndex = 41;
            this.lblBillDt.Text = "创建日期：";
            // 
            // dtgvBilling
            // 
            this.dtgvBilling.AllowUserToAddRows = false;
            this.dtgvBilling.AllowUserToDeleteRows = false;
            this.dtgvBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPayBillNO,
            this.colPayAmount,
            this.colFactAmount,
            this.colBillCrtUName,
            this.colBillCrtTmst});
            this.dtgvBilling.Location = new System.Drawing.Point(1, 59);
            this.dtgvBilling.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvBilling.Name = "dtgvBilling";
            this.dtgvBilling.ReadOnly = true;
            this.dtgvBilling.RowTemplate.Height = 27;
            this.dtgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBilling.Size = new System.Drawing.Size(1677, 560);
            this.dtgvBilling.TabIndex = 42;
            this.dtgvBilling.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBilling_CellDoubleClick);
            // 
            // colPayBillNO
            // 
            this.colPayBillNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPayBillNO.DataPropertyName = "BillNO__PK";
            this.colPayBillNO.HeaderText = "账单号";
            this.colPayBillNO.Name = "colPayBillNO";
            this.colPayBillNO.ReadOnly = true;
            // 
            // colPayAmount
            // 
            this.colPayAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPayAmount.DataPropertyName = "Amount";
            this.colPayAmount.HeaderText = "应付金额/元";
            this.colPayAmount.Name = "colPayAmount";
            this.colPayAmount.ReadOnly = true;
            // 
            // colFactAmount
            // 
            this.colFactAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFactAmount.DataPropertyName = "FactAmount";
            this.colFactAmount.HeaderText = "已付金额/元";
            this.colFactAmount.Name = "colFactAmount";
            this.colFactAmount.ReadOnly = true;
            // 
            // colBillCrtUName
            // 
            this.colBillCrtUName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBillCrtUName.DataPropertyName = "CrtUsrName";
            this.colBillCrtUName.HeaderText = "创建人";
            this.colBillCrtUName.Name = "colBillCrtUName";
            this.colBillCrtUName.ReadOnly = true;
            // 
            // colBillCrtTmst
            // 
            this.colBillCrtTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBillCrtTmst.DataPropertyName = "CrtTmst";
            this.colBillCrtTmst.HeaderText = "创建时间";
            this.colBillCrtTmst.Name = "colBillCrtTmst";
            this.colBillCrtTmst.ReadOnly = true;
            // 
            // MSupplierBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 693);
            this.Controls.Add(this.tabStockInBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MSupplierBillingForm";
            this.Text = "MStockInBillingForm";
            this.tabStockInBill.ResumeLayout(false);
            this.tabPOrders.ResumeLayout(false);
            this.tabPOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).EndInit();
            this.tabPBills.ResumeLayout(false);
            this.tabPBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStockInBill;
        private System.Windows.Forms.TabPage tabPOrders;
        private System.Windows.Forms.Label lblQyDt;
        private System.Windows.Forms.CheckBox ckboxQyEnableEndDt;
        private System.Windows.Forms.DateTimePicker dtpQyEndDt;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblQyOrderNO;
        private System.Windows.Forms.CheckBox ckboxQyEnableStDt;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.ComboBox cboxQrdSupplier;
        private System.Windows.Forms.Label lblQyCust;
        private System.Windows.Forms.DateTimePicker dtpQyStDt;
        private System.Windows.Forms.Label lblQyCrtTm;
        private System.Windows.Forms.DataGridView dtgvOrders;
        private System.Windows.Forms.TabPage tabPBills;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.ComboBox cboxEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxDirect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCkboxs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirect;
        private System.Windows.Forms.ComboBox cboxBillSt;
        private System.Windows.Forms.Label lblBillSt;
        private System.Windows.Forms.Button btnPayBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckboxBillEnableEndDt;
        private System.Windows.Forms.DateTimePicker dtpBillEndDt;
        private System.Windows.Forms.TextBox txtBillNO;
        private System.Windows.Forms.Label lblBillNO;
        private System.Windows.Forms.CheckBox ckboxBillEnableStDt;
        private System.Windows.Forms.Button btnBillQuery;
        private System.Windows.Forms.ComboBox cboxBillSuppliers;
        private System.Windows.Forms.Label lblBillSuppliers;
        private System.Windows.Forms.DateTimePicker dtpBillStDt;
        private System.Windows.Forms.Label lblBillDt;
        private System.Windows.Forms.DataGridView dtgvBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayBillNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillCrtUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillCrtTmst;
        private dgv_pager.DGVPager dgvpgOrder;
        private dgv_pager.DGVPager dgvpgBill;
    }
}