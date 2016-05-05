namespace UI
{
    partial class MSinRefundForm
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
            this.tabRefund = new System.Windows.Forms.TabControl();
            this.tabpgRefund = new System.Windows.Forms.TabPage();
            this.cboxNSppliers = new System.Windows.Forms.ComboBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.cboxNCatg = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblCatg = new System.Windows.Forms.Label();
            this.lblSpplier = new System.Windows.Forms.Label();
            this.txtNOrderNO = new System.Windows.Forms.TextBox();
            this.lblNOrderNO = new System.Windows.Forms.Label();
            this.dtgvMRfGoods = new System.Windows.Forms.DataGridView();
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
            this.tabpgRefundOrders = new System.Windows.Forms.TabPage();
            this.cboxQySupplier = new System.Windows.Forms.ComboBox();
            this.lblQSupplier = new System.Windows.Forms.Label();
            this.ckboxEnableDt = new System.Windows.Forms.CheckBox();
            this.btnOrderQuery = new System.Windows.Forms.Button();
            this.dtpQyCrtTm = new System.Windows.Forms.DateTimePicker();
            this.lblCrtTm = new System.Windows.Forms.Label();
            this.txtQyOrderNO = new System.Windows.Forms.TextBox();
            this.lblOrderNO = new System.Windows.Forms.Label();
            this.dtgvRfOrders = new System.Windows.Forms.DataGridView();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRefund.SuspendLayout();
            this.tabpgRefund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMRfGoods)).BeginInit();
            this.tabpgRefundOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRefund
            // 
            this.tabRefund.Controls.Add(this.tabpgRefund);
            this.tabRefund.Controls.Add(this.tabpgRefundOrders);
            this.tabRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRefund.Location = new System.Drawing.Point(0, 0);
            this.tabRefund.Name = "tabRefund";
            this.tabRefund.SelectedIndex = 0;
            this.tabRefund.Size = new System.Drawing.Size(1500, 657);
            this.tabRefund.TabIndex = 8;
            // 
            // tabpgRefund
            // 
            this.tabpgRefund.Controls.Add(this.cboxNSppliers);
            this.tabpgRefund.Controls.Add(this.btnRefund);
            this.tabpgRefund.Controls.Add(this.cboxNCatg);
            this.tabpgRefund.Controls.Add(this.btnQuery);
            this.tabpgRefund.Controls.Add(this.lblCatg);
            this.tabpgRefund.Controls.Add(this.lblSpplier);
            this.tabpgRefund.Controls.Add(this.txtNOrderNO);
            this.tabpgRefund.Controls.Add(this.lblNOrderNO);
            this.tabpgRefund.Controls.Add(this.dtgvMRfGoods);
            this.tabpgRefund.Location = new System.Drawing.Point(4, 25);
            this.tabpgRefund.Name = "tabpgRefund";
            this.tabpgRefund.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgRefund.Size = new System.Drawing.Size(1492, 628);
            this.tabpgRefund.TabIndex = 0;
            this.tabpgRefund.Text = "新建退货单";
            this.tabpgRefund.UseVisualStyleBackColor = true;
            // 
            // cboxNSppliers
            // 
            this.cboxNSppliers.FormattingEnabled = true;
            this.cboxNSppliers.Location = new System.Drawing.Point(81, 21);
            this.cboxNSppliers.Name = "cboxNSppliers";
            this.cboxNSppliers.Size = new System.Drawing.Size(180, 23);
            this.cboxNSppliers.TabIndex = 1;
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(957, 17);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(85, 30);
            this.btnRefund.TabIndex = 5;
            this.btnRefund.Text = "退货单";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // cboxNCatg
            // 
            this.cboxNCatg.FormattingEnabled = true;
            this.cboxNCatg.Location = new System.Drawing.Point(351, 21);
            this.cboxNCatg.Name = "cboxNCatg";
            this.cboxNCatg.Size = new System.Drawing.Size(150, 23);
            this.cboxNCatg.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(845, 17);
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
            this.lblCatg.Location = new System.Drawing.Point(293, 25);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 0;
            this.lblCatg.Text = "品类：";
            // 
            // lblSpplier
            // 
            this.lblSpplier.AutoSize = true;
            this.lblSpplier.Location = new System.Drawing.Point(8, 25);
            this.lblSpplier.Name = "lblSpplier";
            this.lblSpplier.Size = new System.Drawing.Size(67, 15);
            this.lblSpplier.TabIndex = 0;
            this.lblSpplier.Text = "供应商：";
            // 
            // txtNOrderNO
            // 
            this.txtNOrderNO.Location = new System.Drawing.Point(633, 20);
            this.txtNOrderNO.MaxLength = 100;
            this.txtNOrderNO.Name = "txtNOrderNO";
            this.txtNOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtNOrderNO.TabIndex = 3;
            // 
            // lblNOrderNO
            // 
            this.lblNOrderNO.AutoSize = true;
            this.lblNOrderNO.Location = new System.Drawing.Point(546, 25);
            this.lblNOrderNO.Name = "lblNOrderNO";
            this.lblNOrderNO.Size = new System.Drawing.Size(82, 15);
            this.lblNOrderNO.TabIndex = 0;
            this.lblNOrderNO.Text = "进货单号：";
            // 
            // dtgvMRfGoods
            // 
            this.dtgvMRfGoods.AllowUserToAddRows = false;
            this.dtgvMRfGoods.AllowUserToDeleteRows = false;
            this.dtgvMRfGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMRfGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMRfGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgvMRfGoods.Location = new System.Drawing.Point(0, 60);
            this.dtgvMRfGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvMRfGoods.Name = "dtgvMRfGoods";
            this.dtgvMRfGoods.ReadOnly = true;
            this.dtgvMRfGoods.RowTemplate.Height = 27;
            this.dtgvMRfGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMRfGoods.Size = new System.Drawing.Size(1491, 568);
            this.dtgvMRfGoods.TabIndex = 14;
            this.dtgvMRfGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMRfGoods_CellContentClick);
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
            // tabpgRefundOrders
            // 
            this.tabpgRefundOrders.Controls.Add(this.cboxQySupplier);
            this.tabpgRefundOrders.Controls.Add(this.lblQSupplier);
            this.tabpgRefundOrders.Controls.Add(this.ckboxEnableDt);
            this.tabpgRefundOrders.Controls.Add(this.btnOrderQuery);
            this.tabpgRefundOrders.Controls.Add(this.dtpQyCrtTm);
            this.tabpgRefundOrders.Controls.Add(this.lblCrtTm);
            this.tabpgRefundOrders.Controls.Add(this.txtQyOrderNO);
            this.tabpgRefundOrders.Controls.Add(this.lblOrderNO);
            this.tabpgRefundOrders.Controls.Add(this.dtgvRfOrders);
            this.tabpgRefundOrders.Location = new System.Drawing.Point(4, 25);
            this.tabpgRefundOrders.Name = "tabpgRefundOrders";
            this.tabpgRefundOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgRefundOrders.Size = new System.Drawing.Size(1492, 628);
            this.tabpgRefundOrders.TabIndex = 1;
            this.tabpgRefundOrders.Text = "退货单查询";
            this.tabpgRefundOrders.UseVisualStyleBackColor = true;
            // 
            // cboxQySupplier
            // 
            this.cboxQySupplier.FormattingEnabled = true;
            this.cboxQySupplier.Location = new System.Drawing.Point(96, 19);
            this.cboxQySupplier.Name = "cboxQySupplier";
            this.cboxQySupplier.Size = new System.Drawing.Size(170, 23);
            this.cboxQySupplier.TabIndex = 1;
            // 
            // lblQSupplier
            // 
            this.lblQSupplier.AutoSize = true;
            this.lblQSupplier.Location = new System.Drawing.Point(8, 23);
            this.lblQSupplier.Name = "lblQSupplier";
            this.lblQSupplier.Size = new System.Drawing.Size(67, 15);
            this.lblQSupplier.TabIndex = 0;
            this.lblQSupplier.Text = "供应商：";
            // 
            // ckboxEnableDt
            // 
            this.ckboxEnableDt.AutoSize = true;
            this.ckboxEnableDt.Location = new System.Drawing.Point(832, 22);
            this.ckboxEnableDt.Name = "ckboxEnableDt";
            this.ckboxEnableDt.Size = new System.Drawing.Size(18, 17);
            this.ckboxEnableDt.TabIndex = 4;
            this.ckboxEnableDt.UseVisualStyleBackColor = true;
            // 
            // btnOrderQuery
            // 
            this.btnOrderQuery.Location = new System.Drawing.Point(920, 17);
            this.btnOrderQuery.Name = "btnOrderQuery";
            this.btnOrderQuery.Size = new System.Drawing.Size(85, 30);
            this.btnOrderQuery.TabIndex = 7;
            this.btnOrderQuery.Text = "查询";
            this.btnOrderQuery.UseVisualStyleBackColor = true;
            this.btnOrderQuery.Click += new System.EventHandler(this.btnOrderQuery_Click);
            // 
            // dtpQyCrtTm
            // 
            this.dtpQyCrtTm.CustomFormat = "yyyy-MM-dd";
            this.dtpQyCrtTm.Enabled = false;
            this.dtpQyCrtTm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQyCrtTm.Location = new System.Drawing.Point(677, 18);
            this.dtpQyCrtTm.Name = "dtpQyCrtTm";
            this.dtpQyCrtTm.Size = new System.Drawing.Size(150, 25);
            this.dtpQyCrtTm.TabIndex = 3;
            // 
            // lblCrtTm
            // 
            this.lblCrtTm.AutoSize = true;
            this.lblCrtTm.Location = new System.Drawing.Point(589, 23);
            this.lblCrtTm.Name = "lblCrtTm";
            this.lblCrtTm.Size = new System.Drawing.Size(82, 15);
            this.lblCrtTm.TabIndex = 0;
            this.lblCrtTm.Text = "创建日期：";
            // 
            // txtQyOrderNO
            // 
            this.txtQyOrderNO.Location = new System.Drawing.Point(382, 18);
            this.txtQyOrderNO.Name = "txtQyOrderNO";
            this.txtQyOrderNO.Size = new System.Drawing.Size(170, 25);
            this.txtQyOrderNO.TabIndex = 2;
            // 
            // lblOrderNO
            // 
            this.lblOrderNO.AutoSize = true;
            this.lblOrderNO.Location = new System.Drawing.Point(309, 23);
            this.lblOrderNO.Name = "lblOrderNO";
            this.lblOrderNO.Size = new System.Drawing.Size(52, 15);
            this.lblOrderNO.TabIndex = 0;
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
            this.colSupplier,
            this.colAmount,
            this.colCrtTmst,
            this.colCrtName,
            this.colUptTmst,
            this.colUptName});
            this.dtgvRfOrders.Location = new System.Drawing.Point(0, 60);
            this.dtgvRfOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvRfOrders.Name = "dtgvRfOrders";
            this.dtgvRfOrders.ReadOnly = true;
            this.dtgvRfOrders.RowTemplate.Height = 27;
            this.dtgvRfOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRfOrders.Size = new System.Drawing.Size(1492, 570);
            this.dtgvRfOrders.TabIndex = 0;
            this.dtgvRfOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRfOrders_CellDoubleClick);
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO";
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplier.DataPropertyName = "CustName";
            this.colSupplier.HeaderText = "供应商";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
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
            // MSinRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 657);
            this.Controls.Add(this.tabRefund);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MSinRefundForm";
            this.Text = "MRefundForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabRefund.ResumeLayout(false);
            this.tabpgRefund.ResumeLayout(false);
            this.tabpgRefund.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMRfGoods)).EndInit();
            this.tabpgRefundOrders.ResumeLayout(false);
            this.tabpgRefundOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRefund;
        private System.Windows.Forms.TabPage tabpgRefund;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.ComboBox cboxNCatg;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.Label lblSpplier;
        private System.Windows.Forms.TextBox txtNOrderNO;
        private System.Windows.Forms.Label lblNOrderNO;
        private System.Windows.Forms.DataGridView dtgvMRfGoods;
        private System.Windows.Forms.TabPage tabpgRefundOrders;
        private System.Windows.Forms.CheckBox ckboxEnableDt;
        private System.Windows.Forms.Button btnOrderQuery;
        private System.Windows.Forms.DateTimePicker dtpQyCrtTm;
        private System.Windows.Forms.Label lblCrtTm;
        private System.Windows.Forms.TextBox txtQyOrderNO;
        private System.Windows.Forms.Label lblOrderNO;
        private System.Windows.Forms.DataGridView dtgvRfOrders;
        private System.Windows.Forms.ComboBox cboxNSppliers;
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
        private System.Windows.Forms.ComboBox cboxQySupplier;
        private System.Windows.Forms.Label lblQSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptTmst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUptName;
    }
}