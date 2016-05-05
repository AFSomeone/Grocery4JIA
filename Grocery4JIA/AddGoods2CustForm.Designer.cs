namespace UI
{
    partial class AddGoods2CustForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoods2CustForm));
            this.dtgvGoods = new System.Windows.Forms.DataGridView();
            this.colCkBoxs = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGName = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.lblCatg = new System.Windows.Forms.Label();
            this.cboxCatg = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvGoods
            // 
            this.dtgvGoods.AllowUserToAddRows = false;
            this.dtgvGoods.AllowUserToDeleteRows = false;
            this.dtgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCkBoxs,
            this.colGID,
            this.colGName,
            this.colSpecs,
            this.colCatg,
            this.colShelfLife,
            this.colRemark});
            this.dtgvGoods.Location = new System.Drawing.Point(7, 52);
            this.dtgvGoods.Name = "dtgvGoods";
            this.dtgvGoods.ReadOnly = true;
            this.dtgvGoods.RowTemplate.Height = 27;
            this.dtgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGoods.Size = new System.Drawing.Size(1001, 543);
            this.dtgvGoods.TabIndex = 0;
            this.dtgvGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGoods_CellContentClick);
            // 
            // colCkBoxs
            // 
            this.colCkBoxs.FillWeight = 60F;
            this.colCkBoxs.Frozen = true;
            this.colCkBoxs.HeaderText = "";
            this.colCkBoxs.Name = "colCkBoxs";
            this.colCkBoxs.ReadOnly = true;
            this.colCkBoxs.Width = 60;
            // 
            // colGID
            // 
            this.colGID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGID.DataPropertyName = "GID__PK";
            this.colGID.HeaderText = "商品ID";
            this.colGID.Name = "colGID";
            this.colGID.ReadOnly = true;
            this.colGID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // colCatg
            // 
            this.colCatg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCatg.DataPropertyName = "CatgName";
            this.colCatg.HeaderText = "品类";
            this.colCatg.Name = "colCatg";
            this.colCatg.ReadOnly = true;
            // 
            // colShelfLife
            // 
            this.colShelfLife.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShelfLife.DataPropertyName = "ShelfLife";
            this.colShelfLife.HeaderText = "保质期";
            this.colShelfLife.Name = "colShelfLife";
            this.colShelfLife.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // lblGName
            // 
            this.lblGName.AutoSize = true;
            this.lblGName.Location = new System.Drawing.Point(4, 19);
            this.lblGName.Name = "lblGName";
            this.lblGName.Size = new System.Drawing.Size(82, 15);
            this.lblGName.TabIndex = 0;
            this.lblGName.Text = "商品名称：";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(99, 14);
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(150, 25);
            this.txtGName.TabIndex = 1;
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(511, 19);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(52, 15);
            this.lblCatg.TabIndex = 0;
            this.lblCatg.Text = "品类：";
            // 
            // cboxCatg
            // 
            this.cboxCatg.FormattingEnabled = true;
            this.cboxCatg.Location = new System.Drawing.Point(569, 15);
            this.cboxCatg.Name = "cboxCatg";
            this.cboxCatg.Size = new System.Drawing.Size(150, 23);
            this.cboxCatg.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(765, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 30);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(801, 610);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(923, 610);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Location = new System.Drawing.Point(874, 11);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(85, 30);
            this.btnAddGoods.TabIndex = 5;
            this.btnAddGoods.Text = "新增商品";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "商品ID：";
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(339, 14);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(150, 25);
            this.txtGID.TabIndex = 2;
            this.txtGID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGID_KeyPress);
            // 
            // AddGoods2CustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 652);
            this.Controls.Add(this.txtGID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.cboxCatg);
            this.Controls.Add(this.lblCatg);
            this.Controls.Add(this.txtGName);
            this.Controls.Add(this.lblGName);
            this.Controls.Add(this.dtgvGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGoods2CustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGoods;
        private System.Windows.Forms.Label lblGName;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.ComboBox cboxCatg;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCkBoxs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGID;
    }
}