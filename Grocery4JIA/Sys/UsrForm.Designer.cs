namespace UI
{
    partial class UsrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbnInvalid = new System.Windows.Forms.RadioButton();
            this.rbtnValid = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gboxRequired = new System.Windows.Forms.GroupBox();
            this.gboxUnneeded = new System.Windows.Forms.GroupBox();
            this.gboxRequired.SuspendLayout();
            this.gboxUnneeded.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户 ID：";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(114, 32);
            this.txtUID.MaxLength = 18;
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(200, 25);
            this.txtUID.TabIndex = 1;
            this.txtUID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户姓名：";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(114, 81);
            this.txtUName.MaxLength = 30;
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(200, 25);
            this.txtUName.TabIndex = 3;
            this.txtUName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "电   话：";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(114, 32);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(180, 25);
            this.txtTel.TabIndex = 5;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "QQ：";
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(373, 32);
            this.txtQQ.MaxLength = 18;
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(180, 25);
            this.txtQQ.TabIndex = 7;
            this.txtQQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQQ_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "密   码：";
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Location = new System.Drawing.Point(114, 132);
            this.txtPwd.MaxLength = 18;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '#';
            this.txtPwd.Size = new System.Drawing.Size(200, 25);
            this.txtPwd.TabIndex = 9;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "确认密码：";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(114, 178);
            this.txtPwd2.MaxLength = 18;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '#';
            this.txtPwd2.Size = new System.Drawing.Size(200, 25);
            this.txtPwd2.TabIndex = 11;
            this.txtPwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd2_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(325, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "字母/数字/下划线，最大长度18";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(325, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "真实姓名，最大长度30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(325, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "字母/数字/下划线，最大长度18";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "备   注：";
            // 
            // txtRmk
            // 
            this.txtRmk.Location = new System.Drawing.Point(114, 94);
            this.txtRmk.MaxLength = 250;
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(439, 25);
            this.txtRmk.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "状   态：";
            // 
            // rbnInvalid
            // 
            this.rbnInvalid.AutoSize = true;
            this.rbnInvalid.Location = new System.Drawing.Point(236, 149);
            this.rbnInvalid.Name = "rbnInvalid";
            this.rbnInvalid.Size = new System.Drawing.Size(58, 19);
            this.rbnInvalid.TabIndex = 1;
            this.rbnInvalid.Text = "禁用";
            this.rbnInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnValid
            // 
            this.rbtnValid.AutoSize = true;
            this.rbtnValid.Checked = true;
            this.rbtnValid.Location = new System.Drawing.Point(114, 149);
            this.rbtnValid.Name = "rbtnValid";
            this.rbtnValid.Size = new System.Drawing.Size(58, 19);
            this.rbtnValid.TabIndex = 0;
            this.rbtnValid.TabStop = true;
            this.rbtnValid.Text = "有效";
            this.rbtnValid.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(515, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gboxRequired
            // 
            this.gboxRequired.Controls.Add(this.txtUID);
            this.gboxRequired.Controls.Add(this.label1);
            this.gboxRequired.Controls.Add(this.label7);
            this.gboxRequired.Controls.Add(this.txtUName);
            this.gboxRequired.Controls.Add(this.label2);
            this.gboxRequired.Controls.Add(this.label9);
            this.gboxRequired.Controls.Add(this.label8);
            this.gboxRequired.Controls.Add(this.txtPwd);
            this.gboxRequired.Controls.Add(this.label5);
            this.gboxRequired.Controls.Add(this.txtPwd2);
            this.gboxRequired.Controls.Add(this.label6);
            this.gboxRequired.ForeColor = System.Drawing.Color.Red;
            this.gboxRequired.Location = new System.Drawing.Point(16, 12);
            this.gboxRequired.Name = "gboxRequired";
            this.gboxRequired.Size = new System.Drawing.Size(584, 225);
            this.gboxRequired.TabIndex = 21;
            this.gboxRequired.TabStop = false;
            this.gboxRequired.Text = "必填 *";
            // 
            // gboxUnneeded
            // 
            this.gboxUnneeded.Controls.Add(this.rbnInvalid);
            this.gboxUnneeded.Controls.Add(this.txtTel);
            this.gboxUnneeded.Controls.Add(this.rbtnValid);
            this.gboxUnneeded.Controls.Add(this.label3);
            this.gboxUnneeded.Controls.Add(this.txtQQ);
            this.gboxUnneeded.Controls.Add(this.label4);
            this.gboxUnneeded.Controls.Add(this.label11);
            this.gboxUnneeded.Controls.Add(this.txtRmk);
            this.gboxUnneeded.Controls.Add(this.label10);
            this.gboxUnneeded.Location = new System.Drawing.Point(16, 258);
            this.gboxUnneeded.Name = "gboxUnneeded";
            this.gboxUnneeded.Size = new System.Drawing.Size(584, 193);
            this.gboxUnneeded.TabIndex = 22;
            this.gboxUnneeded.TabStop = false;
            this.gboxUnneeded.Text = "选填";
            // 
            // UsrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 518);
            this.Controls.Add(this.gboxUnneeded);
            this.Controls.Add(this.gboxRequired);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册用户";
            this.gboxRequired.ResumeLayout(false);
            this.gboxRequired.PerformLayout();
            this.gboxUnneeded.ResumeLayout(false);
            this.gboxUnneeded.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbnInvalid;
        private System.Windows.Forms.RadioButton rbtnValid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gboxRequired;
        private System.Windows.Forms.GroupBox gboxUnneeded;
    }
}