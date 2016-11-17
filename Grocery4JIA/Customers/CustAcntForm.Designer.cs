namespace UI
{
    partial class CustAcntForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustAcntForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcntNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAcntType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxPlt = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnInvalid = new System.Windows.Forms.RadioButton();
            this.rbtnValid = new System.Windows.Forms.RadioButton();
            this.lblSt = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户：";
            // 
            // txtAcntNO
            // 
            this.txtAcntNO.Location = new System.Drawing.Point(126, 22);
            this.txtAcntNO.Name = "txtAcntNO";
            this.txtAcntNO.Size = new System.Drawing.Size(200, 25);
            this.txtAcntNO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型：";
            // 
            // cboxAcntType
            // 
            this.cboxAcntType.FormattingEnabled = true;
            this.cboxAcntType.Location = new System.Drawing.Point(126, 80);
            this.cboxAcntType.Name = "cboxAcntType";
            this.cboxAcntType.Size = new System.Drawing.Size(200, 23);
            this.cboxAcntType.TabIndex = 3;
            this.cboxAcntType.SelectedIndexChanged += new System.EventHandler(this.cboxAcntType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "平台：";
            // 
            // cboxPlt
            // 
            this.cboxPlt.Enabled = false;
            this.cboxPlt.FormattingEnabled = true;
            this.cboxPlt.Location = new System.Drawing.Point(126, 136);
            this.cboxPlt.Name = "cboxPlt";
            this.cboxPlt.Size = new System.Drawing.Size(200, 23);
            this.cboxPlt.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnInvalid);
            this.panel1.Controls.Add(this.rbtnValid);
            this.panel1.Location = new System.Drawing.Point(126, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 37);
            this.panel1.TabIndex = 6;
            // 
            // rbtnInvalid
            // 
            this.rbtnInvalid.AutoSize = true;
            this.rbtnInvalid.Location = new System.Drawing.Point(137, 10);
            this.rbtnInvalid.Name = "rbtnInvalid";
            this.rbtnInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbtnInvalid.TabIndex = 10;
            this.rbtnInvalid.Text = "废弃";
            this.rbtnInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnValid
            // 
            this.rbtnValid.AutoSize = true;
            this.rbtnValid.Checked = true;
            this.rbtnValid.Location = new System.Drawing.Point(3, 10);
            this.rbtnValid.Name = "rbtnValid";
            this.rbtnValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnValid.TabIndex = 9;
            this.rbtnValid.TabStop = true;
            this.rbtnValid.Text = "有效";
            this.rbtnValid.UseVisualStyleBackColor = true;
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(42, 203);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(52, 15);
            this.lblSt.TabIndex = 7;
            this.lblSt.Text = "状态：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustAcntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.cboxPlt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxAcntType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAcntNO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustAcntForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "账户信息";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcntNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxAcntType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxPlt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnInvalid;
        private System.Windows.Forms.RadioButton rbtnValid;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}