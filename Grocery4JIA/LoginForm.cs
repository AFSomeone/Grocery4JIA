using BLL.Admin;
using Model.Entity;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        public Usr loginUsr = null;
        public LoginForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usr usr = new Usr();
                usr.UId__PK = txtLogId.Text;
                usr.Pwd = txtPwd.Text;
                UsrManager uManager = new UsrManager();
                string respTxt = string.Empty;
                loginUsr = uManager.login(usr, out respTxt);
                if (null == loginUsr)
                    MessageBox.Show(respTxt, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
