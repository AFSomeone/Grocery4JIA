namespace UI
{
    partial class MUsrsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvUsrs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxSt = new System.Windows.Forms.ComboBox();
            this.colUId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsrs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID：";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(85, 15);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(160, 25);
            this.txtUID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(350, 15);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(160, 25);
            this.txtUName.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(771, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(884, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "注册用户";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvUsrs
            // 
            this.dtgvUsrs.AllowUserToAddRows = false;
            this.dtgvUsrs.AllowUserToDeleteRows = false;
            this.dtgvUsrs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUsrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUId,
            this.colUName,
            this.colTel,
            this.colQQ,
            this.colStDesc,
            this.colRemark,
            this.colSt});
            this.dtgvUsrs.Location = new System.Drawing.Point(1, 57);
            this.dtgvUsrs.Name = "dtgvUsrs";
            this.dtgvUsrs.ReadOnly = true;
            this.dtgvUsrs.RowTemplate.Height = 27;
            this.dtgvUsrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUsrs.Size = new System.Drawing.Size(1195, 534);
            this.dtgvUsrs.TabIndex = 6;
            this.dtgvUsrs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsrs_CellDoubleClick);
            this.dtgvUsrs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvUsrs_CellFormatting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "状态：";
            // 
            // cboxSt
            // 
            this.cboxSt.FormattingEnabled = true;
            this.cboxSt.Location = new System.Drawing.Point(621, 16);
            this.cboxSt.Name = "cboxSt";
            this.cboxSt.Size = new System.Drawing.Size(121, 23);
            this.cboxSt.TabIndex = 8;
            // 
            // colUId
            // 
            this.colUId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUId.DataPropertyName = "UID__PK";
            this.colUId.HeaderText = "用户ID";
            this.colUId.Name = "colUId";
            this.colUId.ReadOnly = true;
            // 
            // colUName
            // 
            this.colUName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUName.DataPropertyName = "UName";
            this.colUName.FillWeight = 150F;
            this.colUName.HeaderText = "姓名";
            this.colUName.Name = "colUName";
            this.colUName.ReadOnly = true;
            // 
            // colTel
            // 
            this.colTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTel.DataPropertyName = "Tel";
            this.colTel.HeaderText = "电话";
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            // 
            // colQQ
            // 
            this.colQQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQQ.DataPropertyName = "QQ";
            this.colQQ.HeaderText = "QQ";
            this.colQQ.Name = "colQQ";
            this.colQQ.ReadOnly = true;
            // 
            // colStDesc
            // 
            this.colStDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStDesc.DataPropertyName = "St";
            this.colStDesc.FillWeight = 80F;
            this.colStDesc.HeaderText = "状态";
            this.colStDesc.Name = "colStDesc";
            this.colStDesc.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.FillWeight = 150F;
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colSt
            // 
            this.colSt.HeaderText = "ST";
            this.colSt.Name = "colSt";
            this.colSt.ReadOnly = true;
            this.colSt.Visible = false;
            // 
            // MUsrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 594);
            this.Controls.Add(this.cboxSt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvUsrs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MUsrsForm";
            this.Text = "MUsrs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvUsrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSt;
    }
}