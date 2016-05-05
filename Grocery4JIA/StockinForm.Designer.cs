namespace UI
{
    partial class StockinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockinForm));
            this.dtgvStockin = new System.Windows.Forms.DataGridView();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMfDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuspStockin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smuitAddGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAoumnt = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCnfrm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGoods = new System.Windows.Forms.Label();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lboxGoods = new System.Windows.Forms.ListBox();
            this.mthcdrMfDt = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStockin)).BeginInit();
            this.cmuspStockin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvStockin
            // 
            this.dtgvStockin.AllowUserToAddRows = false;
            this.dtgvStockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colShelfLife,
            this.colMfDt,
            this.colPrice,
            this.colNum});
            this.dtgvStockin.ContextMenuStrip = this.cmuspStockin;
            this.dtgvStockin.Location = new System.Drawing.Point(12, 63);
            this.dtgvStockin.Name = "dtgvStockin";
            this.dtgvStockin.RowTemplate.Height = 27;
            this.dtgvStockin.Size = new System.Drawing.Size(1226, 626);
            this.dtgvStockin.TabIndex = 2;
            this.dtgvStockin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStockin_CellClick);
            this.dtgvStockin.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStockin_CellEndEdit);
            this.dtgvStockin.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStockin_CellLeave);
            this.dtgvStockin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvStockin_MouseClick);
            // 
            // colGID
            // 
            this.colGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGID.DataPropertyName = "GID__PK";
            this.colGID.FillWeight = 80F;
            this.colGID.HeaderText = "商品ID";
            this.colGID.Name = "colGID";
            this.colGID.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.DataPropertyName = "GName";
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
            this.colPrice.HeaderText = "单价";
            this.colPrice.MaxInputLength = 100;
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.HeaderText = "数量";
            this.colNum.MaxInputLength = 100;
            this.colNum.Name = "colNum";
            this.colNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmuspStockin
            // 
            this.cmuspStockin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmuspStockin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smuitAddGoods});
            this.cmuspStockin.Name = "cmuspStockin";
            this.cmuspStockin.Size = new System.Drawing.Size(145, 30);
            // 
            // smuitAddGoods
            // 
            this.smuitAddGoods.Name = "smuitAddGoods";
            this.smuitAddGoods.Size = new System.Drawing.Size(144, 26);
            this.smuitAddGoods.Text = "添加商品";
            this.smuitAddGoods.Click += new System.EventHandler(this.smuitAddGoods_Click);
            // 
            // lblAoumnt
            // 
            this.lblAoumnt.AutoSize = true;
            this.lblAoumnt.Location = new System.Drawing.Point(12, 714);
            this.lblAoumnt.Name = "lblAoumnt";
            this.lblAoumnt.Size = new System.Drawing.Size(97, 15);
            this.lblAoumnt.TabIndex = 3;
            this.lblAoumnt.Text = "总计（元）：";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(116, 709);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 25);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "0";
            // 
            // btnCnfrm
            // 
            this.btnCnfrm.Location = new System.Drawing.Point(1038, 706);
            this.btnCnfrm.Name = "btnCnfrm";
            this.btnCnfrm.Size = new System.Drawing.Size(85, 30);
            this.btnCnfrm.TabIndex = 5;
            this.btnCnfrm.Text = "创建";
            this.btnCnfrm.UseVisualStyleBackColor = true;
            this.btnCnfrm.Click += new System.EventHandler(this.btnCnfrm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1153, 706);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Location = new System.Drawing.Point(12, 22);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(106, 15);
            this.lblGoods.TabIndex = 7;
            this.lblGoods.Text = "商品ID/名称：";
            // 
            // txtGoods
            // 
            this.txtGoods.Location = new System.Drawing.Point(124, 17);
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.Size = new System.Drawing.Size(220, 25);
            this.txtGoods.TabIndex = 8;
            this.txtGoods.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoods_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(412, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(524, 14);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 30);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lboxGoods
            // 
            this.lboxGoods.FormattingEnabled = true;
            this.lboxGoods.ItemHeight = 15;
            this.lboxGoods.Location = new System.Drawing.Point(124, 42);
            this.lboxGoods.Name = "lboxGoods";
            this.lboxGoods.Size = new System.Drawing.Size(220, 139);
            this.lboxGoods.TabIndex = 11;
            this.lboxGoods.Visible = false;
            this.lboxGoods.Click += new System.EventHandler(this.lboxGoods_Click);
            this.lboxGoods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lboxGoods_MouseMove);
            // 
            // mthcdrMfDt
            // 
            this.mthcdrMfDt.Location = new System.Drawing.Point(963, 472);
            this.mthcdrMfDt.MaxSelectionCount = 1;
            this.mthcdrMfDt.Name = "mthcdrMfDt";
            this.mthcdrMfDt.TabIndex = 12;
            this.mthcdrMfDt.Visible = false;
            this.mthcdrMfDt.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mthcdrMfDt_DateSelected);
            // 
            // StockinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 754);
            this.Controls.Add(this.mthcdrMfDt);
            this.Controls.Add(this.lboxGoods);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGoods);
            this.Controls.Add(this.lblGoods);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCnfrm);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAoumnt);
            this.Controls.Add(this.dtgvStockin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进货单";
            this.Click += new System.EventHandler(this.StockinForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStockin)).EndInit();
            this.cmuspStockin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvStockin;
        private System.Windows.Forms.Label lblAoumnt;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCnfrm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lboxGoods;
        private System.Windows.Forms.ContextMenuStrip cmuspStockin;
        private System.Windows.Forms.ToolStripMenuItem smuitAddGoods;
        private System.Windows.Forms.MonthCalendar mthcdrMfDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMfDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
    }
}