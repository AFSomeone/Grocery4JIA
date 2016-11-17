using BLL.Admin;
using BLL.Proxy;
using Model.Entity;
using Model.Util;
using System;
using System.Windows.Forms;
using BLL;
using System.Collections.Generic;

namespace UI
{
    public partial class LoginForm : Form, IBaseForm
    {
        public Usr loginUsr = null;
        IUsrManager manager;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usr usr = new Usr();
                usr.UId__PK = txtLogId.Text;
                usr.Pwd = txtPwd.Text;
                if (StringUtil.isEmpty(usr.UId__PK) || StringUtil.isEmpty(usr.Pwd))
                {
                    MessageBox.Show("请输入登录名 / 密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IUsrManager>(null);
                string respTxt = string.Empty;
                loginUsr = manager.Login(usr);
                if (null != loginUsr)
                    this.DialogResult = DialogResult.OK;
            }
            catch (Exception e1)
            {
                string msg = e1.Message;
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager };
        }
    }
}
