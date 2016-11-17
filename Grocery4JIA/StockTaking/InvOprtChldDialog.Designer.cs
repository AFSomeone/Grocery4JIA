namespace UI
{
    partial class InvOprtChldDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvOprtChldDialog));
            this.dtgvChld = new System.Windows.Forms.DataGridView();
            this.btnClsoe = new System.Windows.Forms.Button();
            this.colChldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBefNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOprt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOprtUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTmst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChld)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChld
            // 
            this.dtgvChld.AllowUserToAddRows = false;
            this.dtgvChld.AllowUserToDeleteRows = false;
            this.dtgvChld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChld.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChldId,
            this.colBefNum,
            this.colNum,
            this.colOprt,
            this.colOprtUName,
            this.colTmst});
            this.dtgvChld.Location = new System.Drawing.Point(7, 9);
            this.dtgvChld.Name = "dtgvChld";
            this.dtgvChld.ReadOnly = true;
            this.dtgvChld.RowTemplate.Height = 27;
            this.dtgvChld.Size = new System.Drawing.Size(1065, 646);
            this.dtgvChld.TabIndex = 0;
            this.dtgvChld.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvChld_CellFormatting);
            // 
            // btnClsoe
            // 
            this.btnClsoe.Location = new System.Drawing.Point(987, 661);
            this.btnClsoe.Name = "btnClsoe";
            this.btnClsoe.Size = new System.Drawing.Size(85, 30);
            this.btnClsoe.TabIndex = 1;
            this.btnClsoe.Text = "关闭";
            this.btnClsoe.UseVisualStyleBackColor = true;
            this.btnClsoe.Click += new System.EventHandler(this.btnClsoe_Click);
            // 
            // colChldId
            // 
            this.colChldId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colChldId.DataPropertyName = "ChldID__PK";
            this.colChldId.FillWeight = 0.85F;
            this.colChldId.HeaderText = "流水号";
            this.colChldId.Name = "colChldId";
            this.colChldId.ReadOnly = true;
            // 
            // colBefNum
            // 
            this.colBefNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBefNum.DataPropertyName = "BefNum";
            this.colBefNum.FillWeight = 1F;
            this.colBefNum.HeaderText = "操作前数量";
            this.colBefNum.Name = "colBefNum";
            this.colBefNum.ReadOnly = true;
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.DataPropertyName = "Num";
            this.colNum.FillWeight = 1F;
            this.colNum.HeaderText = "操作数量";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colOprt
            // 
            this.colOprt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOprt.DataPropertyName = "OprtDirect";
            this.colOprt.FillWeight = 1F;
            this.colOprt.HeaderText = "操作";
            this.colOprt.Name = "colOprt";
            this.colOprt.ReadOnly = true;
            // 
            // colOprtUName
            // 
            this.colOprtUName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOprtUName.DataPropertyName = "UName";
            this.colOprtUName.FillWeight = 1F;
            this.colOprtUName.HeaderText = "操作人";
            this.colOprtUName.Name = "colOprtUName";
            this.colOprtUName.ReadOnly = true;
            // 
            // colTmst
            // 
            this.colTmst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTmst.DataPropertyName = "OprtTmst";
            this.colTmst.FillWeight = 1F;
            this.colTmst.HeaderText = "操作时间";
            this.colTmst.Name = "colTmst";
            this.colTmst.ReadOnly = true;
            // 
            // InvOprtChldDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 701);
            this.Controls.Add(this.btnClsoe);
            this.Controls.Add(this.dtgvChld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvOprtChldDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存变更流水";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChld;
        private System.Windows.Forms.Button btnClsoe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBefNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOprt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOprtUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTmst;
    }
}