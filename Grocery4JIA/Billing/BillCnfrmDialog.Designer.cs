namespace UI
{
    partial class BillCnfrmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCnfrmDialog));
            this.dtgvOrderGoods = new System.Windows.Forms.DataGridView();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCnfrm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrtTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvOrderGoods
            // 
            this.dtgvOrderGoods.AllowUserToAddRows = false;
            this.dtgvOrderGoods.AllowUserToDeleteRows = false;
            this.dtgvOrderGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvOrderGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrderGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNO,
            this.colDirectDesc,
            this.colGID,
            this.colGName,
            this.colSpesc,
            this.colNum,
            this.colPrice,
            this.colAmount,
            this.colCrtTmst});
            this.dtgvOrderGoods.Location = new System.Drawing.Point(7, 7);
            this.dtgvOrderGoods.Margin = new System.Windows.Forms.Padding(1);
            this.dtgvOrderGoods.Name = "dtgvOrderGoods";
            this.dtgvOrderGoods.ReadOnly = true;
            this.dtgvOrderGoods.RowTemplate.Height = 27;
            this.dtgvOrderGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrderGoods.Size = new System.Drawing.Size(1277, 645);
            this.dtgvOrderGoods.TabIndex = 26;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = true;
            this.lblTotalTxt.Location = new System.Drawing.Point(12, 677);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(127, 15);
            this.lblTotalTxt.TabIndex = 27;
            this.lblTotalTxt.Text = "总计应付（元）：";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(146, 677);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 15);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "0";
            // 
            // btnCnfrm
            // 
            this.btnCnfrm.Location = new System.Drawing.Point(1089, 669);
            this.btnCnfrm.Name = "btnCnfrm";
            this.btnCnfrm.Size = new System.Drawing.Size(85, 30);
            this.btnCnfrm.TabIndex = 29;
            this.btnCnfrm.Text = "确认";
            this.btnCnfrm.UseVisualStyleBackColor = true;
            this.btnCnfrm.Click += new System.EventHandler(this.btnCnfrm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1199, 669);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "放弃";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // colOrderNO
            // 
            this.colOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderNO.DataPropertyName = "OrderNO";
            this.colOrderNO.FillWeight = 120F;
            this.colOrderNO.HeaderText = "单号";
            this.colOrderNO.Name = "colOrderNO";
            this.colOrderNO.ReadOnly = true;
            // 
            // colDirectDesc
            // 
            this.colDirectDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDirectDesc.DataPropertyName = "Direct";
            this.colDirectDesc.FillWeight = 80F;
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
            this.colGName.FillWeight = 150F;
            this.colGName.HeaderText = "商品名称";
            this.colGName.Name = "colGName";
            this.colGName.ReadOnly = true;
            // 
            // colSpesc
            // 
            this.colSpesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSpesc.HeaderText = "规格";
            this.colSpesc.Name = "colSpesc";
            this.colSpesc.ReadOnly = true;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.FillWeight = 80F;
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
            // BillCnfrmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 720);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCnfrm);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTxt);
            this.Controls.Add(this.dtgvOrderGoods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillCnfrmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillCnfrmDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvOrderGoods;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCnfrm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrtTmst;
    }
}