namespace UI
{
    partial class RefundOrderDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundOrderDetailForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dtgvRefundOrderDetail = new System.Windows.Forms.DataGridView();
            this.colTgtOrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRefundOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1123, 605);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.Location = new System.Drawing.Point(115, 613);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(15, 15);
            this.lblAmountValue.TabIndex = 11;
            this.lblAmountValue.Text = "0";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 613);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 15);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "总计（元）：";
            // 
            // dtgvRefundOrderDetail
            // 
            this.dtgvRefundOrderDetail.AllowUserToAddRows = false;
            this.dtgvRefundOrderDetail.AllowUserToDeleteRows = false;
            this.dtgvRefundOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRefundOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTgtOrderNO,
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colPrice,
            this.colNum,
            this.colInvID});
            this.dtgvRefundOrderDetail.Location = new System.Drawing.Point(6, 2);
            this.dtgvRefundOrderDetail.Name = "dtgvRefundOrderDetail";
            this.dtgvRefundOrderDetail.ReadOnly = true;
            this.dtgvRefundOrderDetail.RowTemplate.Height = 27;
            this.dtgvRefundOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRefundOrderDetail.Size = new System.Drawing.Size(1202, 587);
            this.dtgvRefundOrderDetail.TabIndex = 9;
            // 
            // colTgtOrderNO
            // 
            this.colTgtOrderNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTgtOrderNO.DataPropertyName = "TgtOrderNO";
            this.colTgtOrderNO.HeaderText = "单号";
            this.colTgtOrderNO.Name = "colTgtOrderNO";
            this.colTgtOrderNO.ReadOnly = true;
            // 
            // colGID
            // 
            this.colGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGID.DataPropertyName = "GID";
            this.colGID.FillWeight = 80F;
            this.colGID.HeaderText = "商品ID";
            this.colGID.Name = "colGID";
            this.colGID.ReadOnly = true;
            // 
            // colGName
            // 
            this.colGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGName.DataPropertyName = "GName";
            this.colGName.FillWeight = 200F;
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
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "价/元";
            this.colPrice.MaxInputLength = 100;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.DataPropertyName = "Num";
            this.colNum.HeaderText = "数量";
            this.colNum.MaxInputLength = 100;
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            this.colNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colInvID
            // 
            this.colInvID.DataPropertyName = "InvID";
            this.colInvID.HeaderText = "InvID";
            this.colInvID.Name = "colInvID";
            this.colInvID.ReadOnly = true;
            this.colInvID.Visible = false;
            // 
            // RefundOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 648);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAmountValue);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dtgvRefundOrderDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefundOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRefundOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DataGridView dtgvRefundOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTgtOrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
    }
}