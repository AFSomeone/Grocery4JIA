namespace UI
{
    partial class MStockinForm
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
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblQyOrderNO = new System.Windows.Forms.Label();
            this.ckboxQyEnableDt = new System.Windows.Forms.CheckBox();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.cboxQyCust = new System.Windows.Forms.ComboBox();
            this.lblQyCust = new System.Windows.Forms.Label();
            this.dtpQyCrtTm = new System.Windows.Forms.DateTimePicker();
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
            this.cboxSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnStockin = new System.Windows.Forms.Button();
            this.cboxCatg = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblCatg = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.lblGName = new System.Windows.Forms.Label();
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
            this.tabSinOrders = new System.Windows.Forms.TabControl();
            this.tabpgStockinOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).BeginInit();
            this.tabpgStockin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMGoods)).BeginInit();
            this.tabSinOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpgStockinOrder
            // 
            this.tabpgStockinOrder.Controls.Add(this.txtQyOrderNO);
            this.tabpgStockinOrder.Controls.Add(this.lblQyOrderNO);
            this.tabpgStockinOrder.Controls.Add(this.ckboxQyEnableDt);
            this.tabpgStockinOrder.Controls.Add(this.btnOrderQuery);
            this.tabpgStockinOrder.Controls.Add(this.cboxQyCust);
            this.tabpgStockinOrder.Controls.Add(this.lblQyCust);
            this.tabpgStockinOrder.Controls.Add(this.dtpQyCrtTm);
            this.tabpgStockinOrder.Controls.Add(this.lblQyCrtTm);
            this.tabpgStockinOrder.Controls.Add(this.dtgvOrders);
            this.tabpgStockinOrder.Location = new System.Drawing.Point(4, 25);
            this.tabpgStockinOrder.Name = "tabpgStockinOrder";
            this.tabpgStockinOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgStockinOrder.Size = new System.Drawing.Size(1266, 658);
            this.tabpgStockinOrder.TabIndex = 1;
            this.tabpgStockinOrder.Text = "进货单查询";
            this.tabpgStockinOrder.UseVisualStyleBackColor = true;
            // 
            // txtQyOrderNO
            // 
            this.txtQyOrderNO.Location = new System.Drawing.Point(352, 18);
            this.txtQyOrderNO.Name = "txtQyOrderNO";
            this.txtQyOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtQyOrderNO.TabIndex = 2;
            // 
            // lblQyOrderNO
            // 
            this.lblQyOrderNO.AutoSize = true;
            this.lblQyOrderNO.Location = new System.Drawing.Point(294, 23);
            this.lblQyOrderNO.Name = "lblQyOrderNO";
            this.lblQyOrderNO.Size = new System.Drawing.Size(52, 15);
            this.lblQyOrderNO.TabIndex = 0;
            this.lblQyOrderNO.Text = "单号：";
            // 
            // ckboxQyEnableDt
            // 
            this.ckboxQyEnableDt.AutoSize = true;
            this.ckboxQyEnableDt.Location = new System.Drawing.Point(802, 22);
            this.ckboxQyEnableDt.Name = "ckboxQyEnableDt";
            this.ckboxQyEnableDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxQyEnableDt.TabIndex = 4;
            this.ckboxQyEnableDt.UseVisualStyleBackColor = true;
            this.ckboxQyEnableDt.Click += new System.EventHandler(this.ckboxEnableDt_Click);
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.Location = new System.Drawing.Point(877, 15);
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
            this.cboxQyCust.Size = new System.Drawing.Size(180, 23);
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
            // dtpQyCrtTm
            // 
            this.dtpQyCrtTm.CustomFormat = "yyyy-MM-dd";
            this.dtpQyCrtTm.Enabled = false;
            this.dtpQyCrtTm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyCrtTm.Location = new System.Drawing.Point(646, 18);
            this.dtpQyCrtTm.Name = "dtpQyCrtTm";
            this.dtpQyCrtTm.Size = new System.Drawing.Size(150, 25);
            this.dtpQyCrtTm.TabIndex = 3;
            // 
            // lblQyCrtTm
            // 
            this.lblQyCrtTm.AutoSize = true;
            this.lblQyCrtTm.Location = new System.Drawing.Point(558, 23);
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
            this.dtgvOrders.Size = new System.Drawing.Size(1266, 600);
            this.dtgvOrders.TabIndex = 0;
            this.dtgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrders_CellDoubleClick);
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO";
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
            this.tabpgStockin.Controls.Add(this.cboxSupplier);
            this.tabpgStockin.Controls.Add(this.lblSupplier);
            this.tabpgStockin.Controls.Add(this.btnStockin);
            this.tabpgStockin.Controls.Add(this.cboxCatg);
            this.tabpgStockin.Controls.Add(this.btnQuery);
            this.tabpgStockin.Controls.Add(this.lblCatg);
            this.tabpgStockin.Controls.Add(this.txtGName);
            this.tabpgStockin.Controls.Add(this.lblGName);
            this.tabpgStockin.Controls.Add(this.dtgvMGoods);
            this.tabpgStockin.Location = new System.Drawing.Point(4, 25);
            this.tabpgStockin.Name = "tabpgStockin";
            this.tabpgStockin.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgStockin.Size = new System.Drawing.Size(1266, 658);
            this.tabpgStockin.TabIndex = 0;
            this.tabpgStockin.Text = "创建进货单";
            this.tabpgStockin.UseVisualStyleBackColor = true;
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxSupplier.FormattingEnabled = true;
            this.cboxSupplier.ItemHeight = 16;
            this.cboxSupplier.Location = new System.Drawing.Point(81, 19);
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.Size = new System.Drawing.Size(180, 22);
            this.cboxSupplier.TabIndex = 1;
            this.cboxSupplier.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboxSupplier_DrawItem);
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
            // btnStockin
            // 
            this.btnStockin.Location = new System.Drawing.Point(968, 16);
            this.btnStockin.Name = "btnStockin";
            this.btnStockin.Size = new System.Drawing.Size(85, 30);
            this.btnStockin.TabIndex = 5;
            this.btnStockin.Text = "进货单";
            this.btnStockin.UseVisualStyleBackColor = true;
            this.btnStockin.Click += new System.EventHandler(this.btnStockin_Click);
            // 
            // cboxCatg
            // 
            this.cboxCatg.FormattingEnabled = true;
            this.cboxCatg.Location = new System.Drawing.Point(363, 19);
            this.cboxCatg.Name = "cboxCatg";
            this.cboxCatg.Size = new System.Drawing.Size(150, 23);
            this.cboxCatg.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(856, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(305, 23);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 0;
            this.lblCatg.Text = "品类：";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(644, 18);
            this.txtGName.MaxLength = 100;
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(150, 25);
            this.txtGName.TabIndex = 3;
            // 
            // lblGName
            // 
            this.lblGName.AutoSize = true;
            this.lblGName.Location = new System.Drawing.Point(556, 23);
            this.lblGName.Name = "lblGName";
            this.lblGName.Size = new System.Drawing.Size(82, 15);
            this.lblGName.TabIndex = 0;
            this.lblGName.Text = "商品名称：";
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
            this.dtgvMGoods.Location = new System.Drawing.Point(0, 60);
            this.dtgvMGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvMGoods.Name = "dtgvMGoods";
            this.dtgvMGoods.ReadOnly = true;
            this.dtgvMGoods.RowTemplate.Height = 27;
            this.dtgvMGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMGoods.Size = new System.Drawing.Size(1262, 598);
            this.dtgvMGoods.TabIndex = 14;
            this.dtgvMGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMGoods_CellContentClick);
            // 
            // colCkboxs
            // 
            this.colCkboxs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCkboxs.FillWeight = 50F;
            this.colCkboxs.HeaderText = "";
            this.colCkboxs.Name = "colCkboxs";
            this.colCkboxs.ReadOnly = true;
            // 
            // colGId
            // 
            this.colGId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGId.DataPropertyName = "GID__PK";
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
            // colShelfLifeDesc
            // 
            this.colShelfLifeDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShelfLifeDesc.DataPropertyName = "ShelfLife";
            this.colShelfLifeDesc.FillWeight = 78.25026F;
            this.colShelfLifeDesc.HeaderText = "保质期";
            this.colShelfLifeDesc.MaxInputLength = 100;
            this.colShelfLifeDesc.Name = "colShelfLifeDesc";
            this.colShelfLifeDesc.ReadOnly = true;
            // 
            // colSubCatg
            // 
            this.colSubCatg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubCatg.DataPropertyName = "CatgName";
            this.colSubCatg.FillWeight = 78.25026F;
            this.colSubCatg.HeaderText = "品类";
            this.colSubCatg.MaxInputLength = 100;
            this.colSubCatg.Name = "colSubCatg";
            this.colSubCatg.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.FillWeight = 156.5005F;
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
            // tabSinOrders
            // 
            this.tabSinOrders.Controls.Add(this.tabpgStockin);
            this.tabSinOrders.Controls.Add(this.tabpgStockinOrder);
            this.tabSinOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSinOrders.Location = new System.Drawing.Point(0, 0);
            this.tabSinOrders.Name = "tabSinOrders";
            this.tabSinOrders.SelectedIndex = 0;
            this.tabSinOrders.Size = new System.Drawing.Size(1274, 687);
            this.tabSinOrders.TabIndex = 7;
            // 
            // MStockinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 687);
            this.Controls.Add(this.tabSinOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MStockinForm";
            this.Text = "MStockinForm";
            this.tabpgStockinOrder.ResumeLayout(false);
            this.tabpgStockinOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).EndInit();
            this.tabpgStockin.ResumeLayout(false);
            this.tabpgStockin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMGoods)).EndInit();
            this.tabSinOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpgStockinOrder;
        private System.Windows.Forms.TabPage tabpgStockin;
        private System.Windows.Forms.Button btnStockin;
        private System.Windows.Forms.ComboBox cboxCatg;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.Label lblGName;
        private System.Windows.Forms.DataGridView dtgvMGoods;
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
        private System.Windows.Forms.TabControl tabSinOrders;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.ComboBox cboxQyCust;
        private System.Windows.Forms.Label lblQyCust;
        private System.Windows.Forms.DateTimePicker dtpQyCrtTm;
        private System.Windows.Forms.Label lblQyCrtTm;
        private System.Windows.Forms.DataGridView dtgvOrders;
        private System.Windows.Forms.CheckBox ckboxQyEnableDt;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblQyOrderNO;
        private System.Windows.Forms.ComboBox cboxSupplier;
        private System.Windows.Forms.Label lblSupplier;
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
    }
}