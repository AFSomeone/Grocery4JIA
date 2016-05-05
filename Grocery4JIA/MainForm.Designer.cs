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
            this.muItStockInMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muitStockin = new System.Windows.Forms.ToolStripMenuItem();
            this.muitRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.muItStockOutMg = new System.Windows.Forms.ToolStripMenuItem();
            this.muItAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.muItCustomerMg = new System.Windows.Forms.ToolStripMenuItem();
            this.suitSpplyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.muitReseller = new System.Windows.Forms.ToolStripMenuItem();
            this.muItSysMg = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stBottomBar = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.muitStockOut = new System.Windows.Forms.ToolStripMenuItem();
            this.muitSOutRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.MuMain.SuspendLayout();
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
            this.muitCategory.Text = "综合分类";
            this.muitCategory.Click += new System.EventHandler(this.muitCategory_Click);
            // 
            // muitSubCategory
            // 
            this.muitSubCategory.Name = "muitSubCategory";
            this.muitSubCategory.Size = new System.Drawing.Size(144, 26);
            this.muitSubCategory.Text = "商品分类";
            this.muitSubCategory.Click += new System.EventHandler(this.muitSubCategory_Click);
            // 
            // muitGoods
            // 
            this.muitGoods.Name = "muitGoods";
            this.muitGoods.Size = new System.Drawing.Size(144, 26);
            this.muitGoods.Text = "商品信息";
            this.muitGoods.Click += new System.EventHandler(this.muitGoods_Click);
            // 
            // muItStockCount
            // 
            this.muItStockCount.Name = "muItStockCount";
            this.muItStockCount.Size = new System.Drawing.Size(81, 24);
            this.muItStockCount.Text = "库存盘点";
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
            this.muitStockin.Text = "进货";
            this.muitStockin.Click += new System.EventHandler(this.muitStockin_Click);
            // 
            // muitRefund
            // 
            this.muitRefund.Name = "muitRefund";
            this.muitRefund.Size = new System.Drawing.Size(181, 26);
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
            // muItAnalysis
            // 
            this.muItAnalysis.Name = "muItAnalysis";
            this.muItAnalysis.Size = new System.Drawing.Size(81, 24);
            this.muItAnalysis.Text = "数据分析";
            // 
            // muItCustomerMg
            // 
            this.muItCustomerMg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suitSpplyInfo,
            this.muitSupplier,
            this.muitReseller});
            this.muItCustomerMg.Name = "muItCustomerMg";
            this.muItCustomerMg.Size = new System.Drawing.Size(81, 24);
            this.muItCustomerMg.Text = "客户管理";
            // 
            // suitSpplyInfo
            // 
            this.suitSpplyInfo.Name = "suitSpplyInfo";
            this.suitSpplyInfo.Size = new System.Drawing.Size(181, 26);
            this.suitSpplyInfo.Text = "供货信息管理";
            this.suitSpplyInfo.Click += new System.EventHandler(this.suitSpplyInfo_Click);
            // 
            // muitSupplier
            // 
            this.muitSupplier.Name = "muitSupplier";
            this.muitSupplier.Size = new System.Drawing.Size(181, 26);
            this.muitSupplier.Text = "供应商管理";
            this.muitSupplier.Click += new System.EventHandler(this.muitSupplier_Click);
            // 
            // muitReseller
            // 
            this.muitReseller.Name = "muitReseller";
            this.muitReseller.Size = new System.Drawing.Size(181, 26);
            this.muitReseller.Text = "分销商管理";
            this.muitReseller.Click += new System.EventHandler(this.muitReseller_Click);
            // 
            // muItSysMg
            // 
            this.muItSysMg.Name = "muItSysMg";
            this.muItSysMg.Size = new System.Drawing.Size(81, 24);
            this.muItSysMg.Text = "系统管理";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.aBOUTToolStripMenuItem.Text = "关于";
            // 
            // stBottomBar
            // 
            this.stBottomBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stBottomBar.Location = new System.Drawing.Point(0, 611);
            this.stBottomBar.Name = "stBottomBar";
            this.stBottomBar.Size = new System.Drawing.Size(1170, 22);
            this.stBottomBar.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1170, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 53);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1170, 558);
            this.pnlMain.TabIndex = 5;
            // 
            // muitStockOut
            // 
            this.muitStockOut.Name = "muitStockOut";
            this.muitStockOut.Size = new System.Drawing.Size(181, 26);
            this.muitStockOut.Text = "出货";
            this.muitStockOut.Click += new System.EventHandler(this.muitStockOut_Click);
            // 
            // muitSOutRefund
            // 
            this.muitSOutRefund.Name = "muitSOutRefund";
            this.muitSOutRefund.Size = new System.Drawing.Size(181, 26);
            this.muitSOutRefund.Text = "回收";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 633);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stBottomBar);
            this.Controls.Add(this.MuMain);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MuMain;
            this.Name = "MainForm";
            this.Text = "贾老板的杂货铺";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MuMain.ResumeLayout(false);
            this.MuMain.PerformLayout();
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
        private System.Windows.Forms.StatusStrip stBottomBar;
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
    }
}