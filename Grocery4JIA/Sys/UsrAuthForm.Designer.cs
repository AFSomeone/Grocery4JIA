namespace UI
{
    partial class UsrAuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrAuthForm));
            this.dtgvAuth = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboxUsr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colFuncNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFuncID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAuth
            // 
            this.dtgvAuth.AllowUserToAddRows = false;
            this.dtgvAuth.AllowUserToDeleteRows = false;
            this.dtgvAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAuth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFuncNm,
            this.colckbox,
            this.colFuncID});
            this.dtgvAuth.Location = new System.Drawing.Point(13, 50);
            this.dtgvAuth.Name = "dtgvAuth";
            this.dtgvAuth.ReadOnly = true;
            this.dtgvAuth.RowTemplate.Height = 27;
            this.dtgvAuth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAuth.Size = new System.Drawing.Size(610, 578);
            this.dtgvAuth.TabIndex = 0;
            this.dtgvAuth.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAuth_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 640);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(538, 640);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboxUsr
            // 
            this.cboxUsr.FormattingEnabled = true;
            this.cboxUsr.Location = new System.Drawing.Point(97, 12);
            this.cboxUsr.Name = "cboxUsr";
            this.cboxUsr.Size = new System.Drawing.Size(210, 23);
            this.cboxUsr.TabIndex = 3;
            this.cboxUsr.SelectedIndexChanged += new System.EventHandler(this.cboxUsr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户ID：";
            // 
            // txtUName
            // 
            this.txtUName.Enabled = false;
            this.txtUName.Location = new System.Drawing.Point(413, 11);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(210, 25);
            this.txtUName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "名称：";
            // 
            // colFuncNm
            // 
            this.colFuncNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFuncNm.FillWeight = 20F;
            this.colFuncNm.HeaderText = "系统功能";
            this.colFuncNm.Name = "colFuncNm";
            this.colFuncNm.ReadOnly = true;
            // 
            // colckbox
            // 
            this.colckbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colckbox.FillWeight = 10F;
            this.colckbox.HeaderText = "选择";
            this.colckbox.Name = "colckbox";
            this.colckbox.ReadOnly = true;
            this.colckbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colckbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFuncID
            // 
            this.colFuncID.HeaderText = "FuncID";
            this.colFuncID.Name = "colFuncID";
            this.colFuncID.ReadOnly = true;
            this.colFuncID.Visible = false;
            // 
            // UsrAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxUsr);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgvAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsrAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户权限管理";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAuth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboxUsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncNm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncID;
    }
}