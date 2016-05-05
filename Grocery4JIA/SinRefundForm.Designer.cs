namespace UI
{
    partial class SinRefundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinRefundForm));
            this.dtgvRfGoods = new System.Windows.Forms.DataGridView();
            this.colSInOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInPric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRfNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRfGoods
            // 
            this.dtgvRfGoods.AllowUserToAddRows = false;
            this.dtgvRfGoods.AllowUserToDeleteRows = false;
            this.dtgvRfGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRfGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSInOrderNO,
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colInPric,
            this.colPrice,
            this.colInvNum,
            this.colRfNum,
            this.colInvID});
            this.dtgvRfGoods.Location = new System.Drawing.Point(5, 5);
            this.dtgvRfGoods.Name = "dtgvRfGoods";
            this.dtgvRfGoods.RowTemplate.Height = 27;
            this.dtgvRfGoods.Size = new System.Drawing.Size(1170, 588);
            this.dtgvRfGoods.TabIndex = 0;
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
            // colInPric
            // 
            this.colInPric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInPric.HeaderText = "进货价/元";
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
            // colRfNum
            // 
            this.colRfNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRfNum.FillWeight = 80F;
            this.colRfNum.HeaderText = "退货量";
            this.colRfNum.Name = "colRfNum";
            // 
            // colInvID
            // 
            this.colInvID.HeaderText = "InvID";
            this.colInvID.Name = "colInvID";
            this.colInvID.ReadOnly = true;
            this.colInvID.Visible = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 617);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 15);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "总计（元）：";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(115, 612);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 25);
            this.txtAmount.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(979, 609);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "创建";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1090, 609);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // SinRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 649);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dtgvRfGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SinRefundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退货单";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRfGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRfGoods;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSInOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInPric;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRfNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
    }
}