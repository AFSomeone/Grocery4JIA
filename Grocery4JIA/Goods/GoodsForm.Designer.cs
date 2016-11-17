namespace UI
{
    partial class GoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.lblCatg = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.lblGName = new System.Windows.Forms.Label();
            this.txtGId = new System.Windows.Forms.TextBox();
            this.lblGNO = new System.Windows.Forms.Label();
            this.cboxCatg = new System.Windows.Forms.ComboBox();
            this.lblAbbr = new System.Windows.Forms.Label();
            this.txtAbbr = new System.Windows.Forms.TextBox();
            this.lblSpecs = new System.Windows.Forms.Label();
            this.txtSpecs = new System.Windows.Forms.TextBox();
            this.lblShelfLife = new System.Windows.Forms.Label();
            this.txtShelfLife = new System.Windows.Forms.TextBox();
            this.cboxShelfLife = new System.Windows.Forms.ComboBox();
            this.lblSt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnInvalid = new System.Windows.Forms.RadioButton();
            this.rbtnValid = new System.Windows.Forms.RadioButton();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSupplier = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCatg
            // 
            this.lblCatg.AutoSize = true;
            this.lblCatg.Location = new System.Drawing.Point(16, 149);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(76, 15);
            this.lblCatg.TabIndex = 0;
            this.lblCatg.Text = "品   类：";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(432, 22);
            this.txtGName.MaxLength = 100;
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(180, 25);
            this.txtGName.TabIndex = 2;
            // 
            // lblGName
            // 
            this.lblGName.AutoSize = true;
            this.lblGName.Location = new System.Drawing.Point(346, 27);
            this.lblGName.Name = "lblGName";
            this.lblGName.Size = new System.Drawing.Size(82, 15);
            this.lblGName.TabIndex = 0;
            this.lblGName.Text = "商品名称：";
            // 
            // txtGId
            // 
            this.txtGId.Enabled = false;
            this.txtGId.Location = new System.Drawing.Point(107, 22);
            this.txtGId.MaxLength = 100;
            this.txtGId.Name = "txtGId";
            this.txtGId.Size = new System.Drawing.Size(180, 25);
            this.txtGId.TabIndex = 1;
            // 
            // lblGNO
            // 
            this.lblGNO.AutoSize = true;
            this.lblGNO.Location = new System.Drawing.Point(16, 27);
            this.lblGNO.Name = "lblGNO";
            this.lblGNO.Size = new System.Drawing.Size(82, 15);
            this.lblGNO.TabIndex = 0;
            this.lblGNO.Text = "商品编号：";
            // 
            // cboxCatg
            // 
            this.cboxCatg.FormattingEnabled = true;
            this.cboxCatg.Location = new System.Drawing.Point(107, 145);
            this.cboxCatg.Name = "cboxCatg";
            this.cboxCatg.Size = new System.Drawing.Size(180, 23);
            this.cboxCatg.TabIndex = 6;
            // 
            // lblAbbr
            // 
            this.lblAbbr.AutoSize = true;
            this.lblAbbr.Location = new System.Drawing.Point(346, 149);
            this.lblAbbr.Name = "lblAbbr";
            this.lblAbbr.Size = new System.Drawing.Size(82, 15);
            this.lblAbbr.TabIndex = 0;
            this.lblAbbr.Text = "字母缩写：";
            // 
            // txtAbbr
            // 
            this.txtAbbr.Location = new System.Drawing.Point(432, 143);
            this.txtAbbr.MaxLength = 100;
            this.txtAbbr.Name = "txtAbbr";
            this.txtAbbr.Size = new System.Drawing.Size(180, 25);
            this.txtAbbr.TabIndex = 7;
            // 
            // lblSpecs
            // 
            this.lblSpecs.AutoSize = true;
            this.lblSpecs.Location = new System.Drawing.Point(16, 86);
            this.lblSpecs.Name = "lblSpecs";
            this.lblSpecs.Size = new System.Drawing.Size(82, 15);
            this.lblSpecs.TabIndex = 0;
            this.lblSpecs.Text = "商品规格：";
            // 
            // txtSpecs
            // 
            this.txtSpecs.Location = new System.Drawing.Point(107, 81);
            this.txtSpecs.MaxLength = 100;
            this.txtSpecs.Name = "txtSpecs";
            this.txtSpecs.Size = new System.Drawing.Size(180, 25);
            this.txtSpecs.TabIndex = 3;
            // 
            // lblShelfLife
            // 
            this.lblShelfLife.AutoSize = true;
            this.lblShelfLife.Location = new System.Drawing.Point(346, 86);
            this.lblShelfLife.Name = "lblShelfLife";
            this.lblShelfLife.Size = new System.Drawing.Size(83, 15);
            this.lblShelfLife.TabIndex = 0;
            this.lblShelfLife.Text = "保 质 期：";
            // 
            // txtShelfLife
            // 
            this.txtShelfLife.Location = new System.Drawing.Point(432, 81);
            this.txtShelfLife.Name = "txtShelfLife";
            this.txtShelfLife.Size = new System.Drawing.Size(48, 25);
            this.txtShelfLife.TabIndex = 4;
            // 
            // cboxShelfLife
            // 
            this.cboxShelfLife.FormattingEnabled = true;
            this.cboxShelfLife.Location = new System.Drawing.Point(486, 83);
            this.cboxShelfLife.Name = "cboxShelfLife";
            this.cboxShelfLife.Size = new System.Drawing.Size(126, 23);
            this.cboxShelfLife.TabIndex = 5;
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(16, 342);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(76, 15);
            this.lblSt.TabIndex = 0;
            this.lblSt.Text = "状   态：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnInvalid);
            this.panel1.Controls.Add(this.rbtnValid);
            this.panel1.Location = new System.Drawing.Point(107, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 37);
            this.panel1.TabIndex = 0;
            // 
            // rbtnInvalid
            // 
            this.rbtnInvalid.AutoSize = true;
            this.rbtnInvalid.Location = new System.Drawing.Point(92, 10);
            this.rbtnInvalid.Name = "rbtnInvalid";
            this.rbtnInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbtnInvalid.TabIndex = 11;
            this.rbtnInvalid.TabStop = true;
            this.rbtnInvalid.Text = "下架";
            this.rbtnInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnValid
            // 
            this.rbtnValid.AutoSize = true;
            this.rbtnValid.Location = new System.Drawing.Point(3, 10);
            this.rbtnValid.Name = "rbtnValid";
            this.rbtnValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnValid.TabIndex = 10;
            this.rbtnValid.TabStop = true;
            this.rbtnValid.Text = "有效";
            this.rbtnValid.UseVisualStyleBackColor = true;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(16, 210);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(76, 15);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "备   注：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(107, 205);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(505, 25);
            this.txtRemark.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(435, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(527, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "供 应 商：";
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.FormattingEnabled = true;
            this.cboxSupplier.Location = new System.Drawing.Point(105, 267);
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.Size = new System.Drawing.Size(507, 23);
            this.cboxSupplier.TabIndex = 9;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.Controls.Add(this.cboxSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.cboxShelfLife);
            this.Controls.Add(this.txtShelfLife);
            this.Controls.Add(this.lblShelfLife);
            this.Controls.Add(this.txtSpecs);
            this.Controls.Add(this.lblSpecs);
            this.Controls.Add(this.txtAbbr);
            this.Controls.Add(this.lblAbbr);
            this.Controls.Add(this.lblCatg);
            this.Controls.Add(this.txtGName);
            this.Controls.Add(this.lblGName);
            this.Controls.Add(this.txtGId);
            this.Controls.Add(this.lblGNO);
            this.Controls.Add(this.cboxCatg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatg;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.Label lblGName;
        private System.Windows.Forms.TextBox txtGId;
        private System.Windows.Forms.Label lblGNO;
        private System.Windows.Forms.ComboBox cboxCatg;
        private System.Windows.Forms.Label lblAbbr;
        private System.Windows.Forms.TextBox txtAbbr;
        private System.Windows.Forms.Label lblSpecs;
        private System.Windows.Forms.TextBox txtSpecs;
        private System.Windows.Forms.Label lblShelfLife;
        private System.Windows.Forms.TextBox txtShelfLife;
        private System.Windows.Forms.ComboBox cboxShelfLife;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnInvalid;
        private System.Windows.Forms.RadioButton rbtnValid;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSupplier;
    }
}