namespace UI
{
    partial class PayMntForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayMntForm));
            this.tabPymnt = new System.Windows.Forms.TabControl();
            this.tabPOprt = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autxtAcntNO = new auto_text.auto_text();
            this.cboxPlatform = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalNm = new System.Windows.Forms.Label();
            this.btnCnfrm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxPayMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPymnt = new System.Windows.Forms.TextBox();
            this.lblPymnt = new System.Windows.Forms.Label();
            this.dtgvBillGoods = new System.Windows.Forms.DataGridView();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPChld = new System.Windows.Forms.TabPage();
            this.dtgvBillChld = new System.Windows.Forms.DataGridView();
            this.colChldID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcntNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOprtNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOprtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPymnt.SuspendLayout();
            this.tabPOprt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillGoods)).BeginInit();
            this.tabPChld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillChld)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPymnt
            // 
            this.tabPymnt.Controls.Add(this.tabPOprt);
            this.tabPymnt.Controls.Add(this.tabPChld);
            this.tabPymnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPymnt.Location = new System.Drawing.Point(0, 0);
            this.tabPymnt.Name = "tabPymnt";
            this.tabPymnt.SelectedIndex = 0;
            this.tabPymnt.Size = new System.Drawing.Size(1262, 717);
            this.tabPymnt.TabIndex = 0;
            this.tabPymnt.SelectedIndexChanged += new System.EventHandler(this.tabPymnt_SelectedIndexChanged);
            // 
            // tabPOprt
            // 
            this.tabPOprt.Controls.Add(this.groupBox1);
            this.tabPOprt.Controls.Add(this.dtgvBillGoods);
            this.tabPOprt.Location = new System.Drawing.Point(4, 25);
            this.tabPOprt.Name = "tabPOprt";
            this.tabPOprt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOprt.Size = new System.Drawing.Size(1254, 688);
            this.tabPOprt.TabIndex = 0;
            this.tabPOprt.Text = "付款";
            this.tabPOprt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autxtAcntNO);
            this.groupBox1.Controls.Add(this.cboxPlatform);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.lblTotalNm);
            this.groupBox1.Controls.Add(this.btnCnfrm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboxPayMode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPymnt);
            this.groupBox1.Controls.Add(this.lblPymnt);
            this.groupBox1.Location = new System.Drawing.Point(3, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 133);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支付信息";
            // 
            // autxtAcntNO
            // 
            this.autxtAcntNO.Data = null;
            this.autxtAcntNO.DropHeight = 60;
            this.autxtAcntNO.Location = new System.Drawing.Point(967, 34);
            this.autxtAcntNO.Name = "autxtAcntNO";
            this.autxtAcntNO.SelectedObj = null;
            this.autxtAcntNO.Size = new System.Drawing.Size(265, 26);
            this.autxtAcntNO.TabIndex = 44;
            this.autxtAcntNO.Term = null;
            this.autxtAcntNO.loadData += new auto_text.auto_text.LoadDataHandle(this.autxtAcntNO_loadData);
            // 
            // cboxPlatform
            // 
            this.cboxPlatform.FormattingEnabled = true;
            this.cboxPlatform.Location = new System.Drawing.Point(683, 35);
            this.cboxPlatform.Name = "cboxPlatform";
            this.cboxPlatform.Size = new System.Drawing.Size(150, 23);
            this.cboxPlatform.TabIndex = 43;
            this.cboxPlatform.SelectedIndexChanged += new System.EventHandler(this.cboxPlatform_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "支付平台：";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(89, 90);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(39, 15);
            this.lblTotalAmount.TabIndex = 41;
            this.lblTotalAmount.Text = "0.00";
            // 
            // lblTotalNm
            // 
            this.lblTotalNm.AutoSize = true;
            this.lblTotalNm.ForeColor = System.Drawing.Color.Red;
            this.lblTotalNm.Location = new System.Drawing.Point(27, 90);
            this.lblTotalNm.Name = "lblTotalNm";
            this.lblTotalNm.Size = new System.Drawing.Size(52, 15);
            this.lblTotalNm.TabIndex = 40;
            this.lblTotalNm.Text = "备注：";
            // 
            // btnCnfrm
            // 
            this.btnCnfrm.Location = new System.Drawing.Point(967, 82);
            this.btnCnfrm.Name = "btnCnfrm";
            this.btnCnfrm.Size = new System.Drawing.Size(265, 30);
            this.btnCnfrm.TabIndex = 37;
            this.btnCnfrm.Text = "支付";
            this.btnCnfrm.UseVisualStyleBackColor = true;
            this.btnCnfrm.Click += new System.EventHandler(this.btnCnfrm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "支付账户：";
            // 
            // cboxPayMode
            // 
            this.cboxPayMode.FormattingEnabled = true;
            this.cboxPayMode.Location = new System.Drawing.Point(385, 35);
            this.cboxPayMode.Name = "cboxPayMode";
            this.cboxPayMode.Size = new System.Drawing.Size(150, 23);
            this.cboxPayMode.TabIndex = 34;
            this.cboxPayMode.SelectedIndexChanged += new System.EventHandler(this.cboxPayMode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "支付方式：";
            // 
            // txtPymnt
            // 
            this.txtPymnt.Location = new System.Drawing.Point(92, 34);
            this.txtPymnt.Name = "txtPymnt";
            this.txtPymnt.Size = new System.Drawing.Size(150, 25);
            this.txtPymnt.TabIndex = 32;
            // 
            // lblPymnt
            // 
            this.lblPymnt.AutoSize = true;
            this.lblPymnt.Location = new System.Drawing.Point(27, 39);
            this.lblPymnt.Name = "lblPymnt";
            this.lblPymnt.Size = new System.Drawing.Size(52, 15);
            this.lblPymnt.TabIndex = 31;
            this.lblPymnt.Text = "付款：";
            // 
            // dtgvBillGoods
            // 
            this.dtgvBillGoods.AllowUserToAddRows = false;
            this.dtgvBillGoods.AllowUserToDeleteRows = false;
            this.dtgvBillGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNO,
            this.colDirectDesc,
            this.colGID,
            this.colGName,
            this.colSpesc,
            this.colNum,
            this.colPrice,
            this.colAmount,
            this.colCrtTmst});
            this.dtgvBillGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvBillGoods.Location = new System.Drawing.Point(3, 3);
            this.dtgvBillGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvBillGoods.Name = "dtgvBillGoods";
            this.dtgvBillGoods.ReadOnly = true;
            this.dtgvBillGoods.RowTemplate.Height = 27;
            this.dtgvBillGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBillGoods.Size = new System.Drawing.Size(1248, 533);
            this.dtgvBillGoods.TabIndex = 28;
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO";
            this.colOrderNO.FillWeight = 110F;
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colDirectDesc
            // 
            this.colDirectDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDirectDesc.DataPropertyName = "Direct";
            this.colDirectDesc.FillWeight = 70F;
            this.colDirectDesc.HeaderText = "类型";
            this.colDirectDesc.Name = "colDirectDesc";
            this.colDirectDesc.ReadOnly = true;
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
            this.colGName.FillWeight = 120F;
            this.colGName.HeaderText = "商品名称";
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colSpesc
            // 
            this.colSpesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpesc.FillWeight = 80F;
            this.colSpesc.HeaderText = "规格";
            this.colSpesc.Name = "colSpesc";
            this.colSpesc.ReadOnly = true;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.FillWeight = 70F;
            this.colNum.HeaderText = "数量";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.HeaderText = "价格/元";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // tabPChld
            // 
            this.tabPChld.Controls.Add(this.dtgvBillChld);
            this.tabPChld.Location = new System.Drawing.Point(4, 25);
            this.tabPChld.Name = "tabPChld";
            this.tabPChld.Padding = new System.Windows.Forms.Padding(3);
            this.tabPChld.Size = new System.Drawing.Size(1254, 688);
            this.tabPChld.TabIndex = 1;
            this.tabPChld.Text = "流水";
            this.tabPChld.UseVisualStyleBackColor = true;
            // 
            // dtgvBillChld
            // 
            this.dtgvBillChld.AllowUserToAddRows = false;
            this.dtgvBillChld.AllowUserToDeleteRows = false;
            this.dtgvBillChld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillChld.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChldID,
            this.colBillAmount,
            this.colPayMode,
            this.colAcntNO,
            this.colPlatform,
            this.colOprtNm,
            this.colOprtTmst});
            this.dtgvBillChld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBillChld.Location = new System.Drawing.Point(3, 3);
            this.dtgvBillChld.Name = "dtgvBillChld";
            this.dtgvBillChld.ReadOnly = true;
            this.dtgvBillChld.RowTemplate.Height = 27;
            this.dtgvBillChld.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBillChld.Size = new System.Drawing.Size(1248, 682);
            this.dtgvBillChld.TabIndex = 0;
            this.dtgvBillChld.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvBillChld_CellFormatting);
            // 
            // colChldID
            // 
            this.colChldID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChldID.DataPropertyName = "ID__PK";
            this.colChldID.HeaderText = "流水ID";
            this.colChldID.Name = "colChldID";
            this.colChldID.ReadOnly = true;
            // 
            // colBillAmount
            // 
            this.colBillAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBillAmount.DataPropertyName = "Amount";
            this.colBillAmount.HeaderText = "金额/元";
            this.colBillAmount.Name = "colBillAmount";
            this.colBillAmount.ReadOnly = true;
            // 
            // colPayMode
            // 
            this.colPayMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPayMode.DataPropertyName = "PayMode";
            this.colPayMode.HeaderText = "支付方式";
            this.colPayMode.Name = "colPayMode";
            this.colPayMode.ReadOnly = true;
            // 
            // colAcntNO
            // 
            this.colAcntNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAcntNO.DataPropertyName = "AcntNO";
            this.colAcntNO.HeaderText = "支付账户";
            this.colAcntNO.Name = "colAcntNO";
            this.colAcntNO.ReadOnly = true;
            // 
            // colPlatform
            // 
            this.colPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPlatform.DataPropertyName = "Platform";
            this.colPlatform.HeaderText = "支付平台";
            this.colPlatform.Name = "colPlatform";
            this.colPlatform.ReadOnly = true;
            // 
            // colOprtNm
            // 
            this.colOprtNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOprtNm.DataPropertyName = "OprtUsrName";
            this.colOprtNm.HeaderText = "操作人";
            this.colOprtNm.Name = "colOprtNm";
            this.colOprtNm.ReadOnly = true;
            // 
            // colOprtTmst
            // 
            this.colOprtTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOprtTmst.DataPropertyName = "OprtTmst";
            this.colOprtTmst.HeaderText = "操作时间";
            this.colOprtTmst.Name = "colOprtTmst";
            this.colOprtTmst.ReadOnly = true;
            // 
            // PayMntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 717);
            this.Controls.Add(this.tabPymnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayMntForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayMntForm";
            this.tabPymnt.ResumeLayout(false);
            this.tabPOprt.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillGoods)).EndInit();
            this.tabPChld.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillChld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPymnt;
        private System.Windows.Forms.TabPage tabPOprt;
        private System.Windows.Forms.DataGridView dtgvBillGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
        private System.Windows.Forms.TabPage tabPChld;
        private System.Windows.Forms.DataGridView dtgvBillChld;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalNm;
        private System.Windows.Forms.Button btnCnfrm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxPayMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPymnt;
        private System.Windows.Forms.Label lblPymnt;
        private System.Windows.Forms.ComboBox cboxPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChldID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcntNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOprtNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOprtTmst;
        private auto_text.auto_text autxtAcntNO;
    }
}