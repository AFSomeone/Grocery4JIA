namespace UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MuMain = new System.Windows.Forms.MenuStrip();
            this.muItGoodsMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muitCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSubCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.muitGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.muItStockCount = new System.Windows.Forms.ToolStripMenuItem();
            this.muitStocktaking = new System.Windows.Forms.ToolStripMenuItem();
            this.muItStockInMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muitStockin = new System.Windows.Forms.ToolStripMenuItem();
            this.muitRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.muItStockOutMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muitStockOut = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSOutRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.muItAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.muitProfitAnls = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSlesmanProfitAnls = new System.Windows.Forms.ToolStripMenuItem();
            this.multBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSupplierBill = new System.Windows.Forms.ToolStripMenuItem();
            this.muitResellerBill = new System.Windows.Forms.ToolStripMenuItem();
            this.muItCustomerMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.muitReseller = new System.Windows.Forms.ToolStripMenuItem();
            this.suitSpplyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.suitCustAcnt = new System.Windows.Forms.ToolStripMenuItem();
            this.muItSysMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muitUsrs = new System.Windows.Forms.ToolStripMenuItem();
            this.muitAuths = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muitAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRf2Supplier = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRsellerRf = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStocktaking = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStockIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStockOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSupplierBill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnResellerBill = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.MuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MuMain
            // 
            this.MuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muItGoodsMg,
            this.muItStockCount,
            this.muItStockInMg,
            this.muItStockOutMg,
            this.muItAnalysis,
            this.multBilling,
            this.muItCustomerMg,
            this.muItSysMg,
            this.aBOUTToolStripMenuItem});
            this.MuMain.Location = new System.Drawing.Point(0, 0);
            this.MuMain.Name = "MuMain";
            this.MuMain.Size = new System.Drawing.Size(1170, 28);
            this.MuMain.TabIndex = 0;
            this.MuMain.Text = "mianMenu";
            // 
            // muItGoodsMg
            // 
            this.muItGoodsMg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitCategory,
            this.muitSubCategory,
            this.muitGoods});
            this.muItGoodsMg.Name = "muItGoodsMg";
            this.muItGoodsMg.Size = new System.Drawing.Size(81, 24);
            this.muItGoodsMg.Text = "商品管理";
            // 
            // muitCategory
            // 
            this.muitCategory.Name = "muitCategory";
            this.muitCategory.Size = new System.Drawing.Size(144, 26);
            this.muitCategory.Tag = "10001";
            this.muitCategory.Text = "综合分类";
            this.muitCategory.Click += new System.EventHandler(this.muitCategory_Click);
            // 
            // muitSubCategory
            // 
            this.muitSubCategory.Name = "muitSubCategory";
            this.muitSubCategory.Size = new System.Drawing.Size(144, 26);
            this.muitSubCategory.Tag = "10002";
            this.muitSubCategory.Text = "商品分类";
            this.muitSubCategory.Click += new System.EventHandler(this.muitSubCategory_Click);
            // 
            // muitGoods
            // 
            this.muitGoods.Name = "muitGoods";
            this.muitGoods.Size = new System.Drawing.Size(144, 26);
            this.muitGoods.Tag = "10003";
            this.muitGoods.Text = "商品信息";
            this.muitGoods.Click += new System.EventHandler(this.muitGoods_Click);
            // 
            // muItStockCount
            // 
            this.muItStockCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitStocktaking});
            this.muItStockCount.Name = "muItStockCount";
            this.muItStockCount.Size = new System.Drawing.Size(81, 24);
            this.muItStockCount.Text = "库存盘点";
            // 
            // muitStocktaking
            // 
            this.muitStocktaking.Name = "muitStocktaking";
            this.muitStocktaking.Size = new System.Drawing.Size(114, 26);
            this.muitStocktaking.Tag = "20001";
            this.muitStocktaking.Text = "盘点";
            this.muitStocktaking.Click += new System.EventHandler(this.muitStocktaking_Click);
            // 
            // muItStockInMg
            // 
            this.muItStockInMg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitStockin,
            this.muitRefund});
            this.muItStockInMg.Name = "muItStockInMg";
            this.muItStockInMg.Size = new System.Drawing.Size(81, 24);
            this.muItStockInMg.Text = "进货管理";
            // 
            // muitStockin
            // 
            this.muitStockin.Name = "muitStockin";
            this.muitStockin.Size = new System.Drawing.Size(181, 26);
            this.muitStockin.Tag = "30001";
            this.muitStockin.Text = "进货";
            this.muitStockin.Click += new System.EventHandler(this.muitStockin_Click);
            // 
            // muitRefund
            // 
            this.muitRefund.Name = "muitRefund";
            this.muitRefund.Size = new System.Drawing.Size(181, 26);
            this.muitRefund.Tag = "30002";
            this.muitRefund.Text = "退货";
            this.muitRefund.Click += new System.EventHandler(this.muitRefund_Click);
            // 
            // muItStockOutMg
            // 
            this.muItStockOutMg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitStockOut,
            this.muitSOutRefund});
            this.muItStockOutMg.Name = "muItStockOutMg";
            this.muItStockOutMg.Size = new System.Drawing.Size(81, 24);
            this.muItStockOutMg.Text = "出货管理";
            // 
            // muitStockOut
            // 
            this.muitStockOut.Name = "muitStockOut";
            this.muitStockOut.Size = new System.Drawing.Size(181, 26);
            this.muitStockOut.Tag = "40001";
            this.muitStockOut.Text = "出货";
            this.muitStockOut.Click += new System.EventHandler(this.muitStockOut_Click);
            // 
            // muitSOutRefund
            // 
            this.muitSOutRefund.Name = "muitSOutRefund";
            this.muitSOutRefund.Size = new System.Drawing.Size(181, 26);
            this.muitSOutRefund.Tag = "40002";
            this.muitSOutRefund.Text = "回收";
            this.muitSOutRefund.Click += new System.EventHandler(this.muitSOutRefund_Click);
            // 
            // muItAnalysis
            // 
            this.muItAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitProfitAnls,
            this.muitSlesmanProfitAnls});
            this.muItAnalysis.Name = "muItAnalysis";
            this.muItAnalysis.Size = new System.Drawing.Size(81, 24);
            this.muItAnalysis.Text = "数据分析";
            // 
            // muitProfitAnls
            // 
            this.muitProfitAnls.Name = "muitProfitAnls";
            this.muitProfitAnls.Size = new System.Drawing.Size(204, 26);
            this.muitProfitAnls.Tag = "50001";
            this.muitProfitAnls.Text = "年利润统计";
            this.muitProfitAnls.Click += new System.EventHandler(this.muitProfitAnls_Click);
            // 
            // muitSlesmanProfitAnls
            // 
            this.muitSlesmanProfitAnls.Name = "muitSlesmanProfitAnls";
            this.muitSlesmanProfitAnls.Size = new System.Drawing.Size(204, 26);
            this.muitSlesmanProfitAnls.Tag = "50002";
            this.muitSlesmanProfitAnls.Text = "销售人员业绩统计";
            this.muitSlesmanProfitAnls.Click += new System.EventHandler(this.muitSlesmanProfitAnls_Click);
            // 
            // multBilling
            // 
            this.multBilling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitSupplierBill,
            this.muitResellerBill});
            this.multBilling.Name = "multBilling";
            this.multBilling.Size = new System.Drawing.Size(51, 24);
            this.multBilling.Text = "账务";
            // 
            // muitSupplierBill
            // 
            this.muitSupplierBill.Name = "muitSupplierBill";
            this.muitSupplierBill.Size = new System.Drawing.Size(159, 26);
            this.muitSupplierBill.Tag = "60001";
            this.muitSupplierBill.Text = "供应商账单";
            this.muitSupplierBill.Click += new System.EventHandler(this.muitSupplierBill_Click);
            // 
            // muitResellerBill
            // 
            this.muitResellerBill.Name = "muitResellerBill";
            this.muitResellerBill.Size = new System.Drawing.Size(159, 26);
            this.muitResellerBill.Tag = "60002";
            this.muitResellerBill.Text = "分销商账单";
            this.muitResellerBill.Click += new System.EventHandler(this.muitResellerBill_Click);
            // 
            // muItCustomerMg
            // 
            this.muItCustomerMg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitSupplier,
            this.muitReseller,
            this.suitSpplyInfo,
            this.suitCustAcnt});
            this.muItCustomerMg.Name = "muItCustomerMg";
            this.muItCustomerMg.Size = new System.Drawing.Size(81, 24);
            this.muItCustomerMg.Text = "客户管理";
            // 
            // muitSupplier
            // 
            this.muitSupplier.Name = "muitSupplier";
            this.muitSupplier.Size = new System.Drawing.Size(174, 26);
            this.muitSupplier.Tag = "70001";
            this.muitSupplier.Text = "供应商管理";
            this.muitSupplier.Click += new System.EventHandler(this.muitSupplier_Click);
            // 
            // muitReseller
            // 
            this.muitReseller.Name = "muitReseller";
            this.muitReseller.Size = new System.Drawing.Size(174, 26);
            this.muitReseller.Tag = "70002";
            this.muitReseller.Text = "分销商管理";
            this.muitReseller.Click += new System.EventHandler(this.muitReseller_Click);
            // 
            // suitSpplyInfo
            // 
            this.suitSpplyInfo.Name = "suitSpplyInfo";
            this.suitSpplyInfo.Size = new System.Drawing.Size(174, 26);
            this.suitSpplyInfo.Tag = "70003";
            this.suitSpplyInfo.Text = "供货信息管理";
            this.suitSpplyInfo.Click += new System.EventHandler(this.suitSpplyInfo_Click);
            // 
            // suitCustAcnt
            // 
            this.suitCustAcnt.Name = "suitCustAcnt";
            this.suitCustAcnt.Size = new System.Drawing.Size(174, 26);
            this.suitCustAcnt.Tag = "70004";
            this.suitCustAcnt.Text = "客户账户管理";
            this.suitCustAcnt.Click += new System.EventHandler(this.suitCustAcnt_Click);
            // 
            // muItSysMg
            // 
            this.muItSysMg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitUsrs,
            this.muitAuths});
            this.muItSysMg.Name = "muItSysMg";
            this.muItSysMg.Size = new System.Drawing.Size(81, 24);
            this.muItSysMg.Text = "系统管理";
            // 
            // muitUsrs
            // 
            this.muitUsrs.Name = "muitUsrs";
            this.muitUsrs.Size = new System.Drawing.Size(144, 26);
            this.muitUsrs.Tag = "80001";
            this.muitUsrs.Text = "用户管理";
            this.muitUsrs.Click += new System.EventHandler(this.muitUsrs_Click);
            // 
            // muitAuths
            // 
            this.muitAuths.Name = "muitAuths";
            this.muitAuths.Size = new System.Drawing.Size(144, 26);
            this.muitAuths.Tag = "80002";
            this.muitAuths.Text = "权限管理";
            this.muitAuths.Click += new System.EventHandler(this.muitAuths_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muitAbout});
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.aBOUTToolStripMenuItem.Text = "关于";
            // 
            // muitAbout
            // 
            this.muitAbout.Name = "muitAbout";
            this.muitAbout.Size = new System.Drawing.Size(114, 26);
            this.muitAbout.Text = "关于";
            this.muitAbout.Click += new System.EventHandler(this.muitAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRf2Supplier,
            this.toolStripSeparator3,
            this.tsbtnRsellerRf,
            this.toolStripSeparator4,
            this.tsbtnStocktaking,
            this.toolStripSeparator1,
            this.tsbtnStockIn,
            this.toolStripSeparator2,
            this.tsbtnStockOut,
            this.toolStripSeparator5,
            this.tsbtnSupplierBill,
            this.toolStripSeparator6,
            this.tsbtnResellerBill});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1170, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRf2Supplier
            // 
            this.tsbtnRf2Supplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRf2Supplier.Image = global::UI.Properties.Resources.refund;
            this.tsbtnRf2Supplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRf2Supplier.Name = "tsbtnRf2Supplier";
            this.tsbtnRf2Supplier.Size = new System.Drawing.Size(28, 28);
            this.tsbtnRf2Supplier.Text = "退回供应商";
            this.tsbtnRf2Supplier.Click += new System.EventHandler(this.tsbtnRf2Supplier_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnRsellerRf
            // 
            this.tsbtnRsellerRf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRsellerRf.Image = global::UI.Properties.Resources.recycle;
            this.tsbtnRsellerRf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRsellerRf.Name = "tsbtnRsellerRf";
            this.tsbtnRsellerRf.Size = new System.Drawing.Size(28, 28);
            this.tsbtnRsellerRf.Text = "回收";
            this.tsbtnRsellerRf.Click += new System.EventHandler(this.tsbtnRsellerRf_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnStocktaking
            // 
            this.tsbtnStocktaking.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStocktaking.Image = global::UI.Properties.Resources.stocktaking;
            this.tsbtnStocktaking.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStocktaking.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.tsbtnStocktaking.Name = "tsbtnStocktaking";
            this.tsbtnStocktaking.Size = new System.Drawing.Size(28, 28);
            this.tsbtnStocktaking.Text = "盘点";
            this.tsbtnStocktaking.Click += new System.EventHandler(this.tsbtnStocktaking_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnStockIn
            // 
            this.tsbtnStockIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStockIn.Image = global::UI.Properties.Resources.stock_in;
            this.tsbtnStockIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStockIn.Name = "tsbtnStockIn";
            this.tsbtnStockIn.Size = new System.Drawing.Size(28, 28);
            this.tsbtnStockIn.Text = "进货";
            this.tsbtnStockIn.Click += new System.EventHandler(this.tsbtnStockIn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnStockOut
            // 
            this.tsbtnStockOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStockOut.Image = global::UI.Properties.Resources.stock_out;
            this.tsbtnStockOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStockOut.Name = "tsbtnStockOut";
            this.tsbtnStockOut.Size = new System.Drawing.Size(28, 28);
            this.tsbtnStockOut.Text = "出货";
            this.tsbtnStockOut.Click += new System.EventHandler(this.tsbtnStockOut_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnSupplierBill
            // 
            this.tsbtnSupplierBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSupplierBill.Image = global::UI.Properties.Resources.pay_bill;
            this.tsbtnSupplierBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSupplierBill.Name = "tsbtnSupplierBill";
            this.tsbtnSupplierBill.Size = new System.Drawing.Size(28, 28);
            this.tsbtnSupplierBill.Text = "付款";
            this.tsbtnSupplierBill.Click += new System.EventHandler(this.tsbtnSupplierBill_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnResellerBill
            // 
            this.tsbtnResellerBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnResellerBill.Image = global::UI.Properties.Resources.rcv_bill;
            this.tsbtnResellerBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnResellerBill.Name = "tsbtnResellerBill";
            this.tsbtnResellerBill.Size = new System.Drawing.Size(28, 28);
            this.tsbtnResellerBill.Text = "收款";
            this.tsbtnResellerBill.Click += new System.EventHandler(this.tsbtnResellerBill_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 59);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1170, 574);
            this.pnlMain.TabIndex = 5;
            this.pnlMain.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlMain_ControlRemoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 633);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MuMain);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MuMain;
            this.Name = "MainForm";
            this.Text = "贾老板的杂货铺";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MuMain.ResumeLayout(false);
            this.MuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MuMain;
        private System.Windows.Forms.ToolStripMenuItem muItStockInMg;
        private System.Windows.Forms.ToolStripMenuItem muItStockOutMg;
        private System.Windows.Forms.ToolStripMenuItem muItGoodsMg;
        private System.Windows.Forms.ToolStripMenuItem muItAnalysis;
        private System.Windows.Forms.ToolStripMenuItem muItStockCount;
        private System.Windows.Forms.ToolStripMenuItem muItCustomerMg;
        private System.Windows.Forms.ToolStripMenuItem muItSysMg;
        private System.Windows.Forms.ToolStripMenuItem muitCategory;
        private System.Windows.Forms.ToolStripMenuItem muitSubCategory;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem muitGoods;
        private System.Windows.Forms.ToolStripMenuItem muitSupplier;
        private System.Windows.Forms.ToolStripMenuItem muitReseller;
        private System.Windows.Forms.ToolStripMenuItem muitStockin;
        private System.Windows.Forms.ToolStripMenuItem muitRefund;
        private System.Windows.Forms.ToolStripMenuItem suitSpplyInfo;
        private System.Windows.Forms.ToolStripMenuItem muitStockOut;
        private System.Windows.Forms.ToolStripMenuItem muitSOutRefund;
        private System.Windows.Forms.ToolStripMenuItem suitCustAcnt;
        private System.Windows.Forms.ToolStripMenuItem multBilling;
        private System.Windows.Forms.ToolStripMenuItem muitSupplierBill;
        private System.Windows.Forms.ToolStripMenuItem muitResellerBill;
        private System.Windows.Forms.ToolStripMenuItem muitUsrs;
        private System.Windows.Forms.ToolStripMenuItem muitAuths;
        private System.Windows.Forms.ToolStripMenuItem muitStocktaking;
        private System.Windows.Forms.ToolStripButton tsbtnRf2Supplier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnStockIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnStockOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnRsellerRf;
        private System.Windows.Forms.ToolStripButton tsbtnStocktaking;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnSupplierBill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtnResellerBill;
        private System.Windows.Forms.ToolStripMenuItem muitAbout;
        private System.Windows.Forms.ToolStripMenuItem muitProfitAnls;
        private System.Windows.Forms.ToolStripMenuItem muitSlesmanProfitAnls;
    }
}