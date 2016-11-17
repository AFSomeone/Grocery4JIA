using BLL.Admin;
using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;
using System.Collections.Generic;

namespace UI
{
    public partial class UsrForm : Form, IBaseForm
    {
        IUsrManager manager;
        bool uptFlag = false;
        public UsrForm(Usr usr, IUsrManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            if (null == usr)
            {
                Text = "注册用户";
                rbtnValid.Enabled = false;
                rbnInvalid.Enabled = false;
            }
                
            else
            {
                Text = "修改用户";
                txtUID.Enabled = false;
                uptFlag = true;
                rbtnValid.Enabled = true;
                rbnInvalid.Enabled = true;

                txtUID.Text = usr.UId__PK;
                txtUName.Text = usr.UName;
                txtQQ.Text = usr.QQ;
                txtTel.Text = usr.Tel;
                txtRmk.Text = usr.Remark;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string uId = txtUID.Text.Trim();
            string uName = txtUName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            if (StringUtil.isEmpty(uId))
                MainForm.Warn("请输入用户ID！");
            else if (StringUtil.isEmpty(uName))
                MainForm.Warn("请输入用户姓名！");
            else if (StringUtil.isEmpty(pwd) && !uptFlag)
                MainForm.Warn("请输入密码！");
            else
            {
                string pwd2 = txtPwd2.Text.Trim();
                if (pwd != pwd2)
                {
                    MainForm.Warn("两次输入密码不一致！");
                    return;
                }
                int cnt = 0;
                if(!uptFlag)
                    cnt = manager.LoadUsrCnt(uId);
                if (cnt > 0)
                    MainForm.Warn("此ID已被注册，请重新选择！");
                else
                {
                    Usr usr = new Usr();
                    string tel = txtTel.Text.Trim();
                    string qq = txtQQ.Text.Trim();
                    usr.UName = uName;
                    usr.UId__PK = uId;
                    usr.Tel = tel;
                    usr.QQ = qq;
                    usr.Remark = txtRmk.Text.Trim();
                    if (!StringUtil.isEmpty(pwd))
                        usr.Pwd = pwd;
                    if (rbnInvalid.Checked)
                        usr.St = ST.INVALID;
                    else if (rbtnValid.Checked)
                        usr.St = ST.VALID;

                    try
                    {
                        if (uptFlag)
                            cnt = manager.Update(usr);
                        else
                            cnt = manager.AddUsr(usr);
                        if (cnt > 0)
                        {
                            MainForm.Info("保存成功！");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MainForm.Warn("保存失败！");
                        }
                    }
                    catch
                    {
                        MainForm.Error("系统异常...");
                    }
                }
            }
        }

        private void txtUID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if (keyVal >= 48 && keyVal <= 57)
                return;
            else if (keyVal >= 65 && keyVal <= 90)
                return;
            else if (keyVal >= 97 && keyVal <= 122)
                return;
            else if (keyVal == 95 || keyVal ==8 || keyVal == 13)
                return;
            else
                e.Handled = true;
        }

        private void txtUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if (keyVal == 8 || keyVal == 32|| keyVal == 13)
                return;
            Regex regex = new Regex("^([A-Za-z]|[\u4E00-\u9FA5])+$");
            if (regex.IsMatch(e.KeyChar + ""))
                return;
            else
                e.Handled = true;
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if (keyVal >= 48 && keyVal <= 57)
                return;
            else if (keyVal >= 65 && keyVal <= 90)
                return;
            else if (keyVal >= 97 && keyVal <= 122)
                return;
            else if (keyVal == 95 || keyVal == 8 || keyVal == 13)
                return;
            else
                e.Handled = true;
        }

        private void txtPwd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if (keyVal >= 48 && keyVal <= 57)
                return;
            else if (keyVal >= 65 && keyVal <= 90)
                return;
            else if (keyVal >= 97 && keyVal <= 122)
                return;
            else if (keyVal == 95 || keyVal == 8 || keyVal == 13)
                return;
            else
                e.Handled = true;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if (keyVal >= 48 && keyVal <= 57)
                return;
            else if (keyVal == 45 || keyVal == 8 || keyVal == 13)
                return;
            else
                e.Handled = true;
        }

        private void txtQQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if (keyVal >= 48 && keyVal <= 57)
                return;
            else if (keyVal == 8 || keyVal == 13)
                return;
            else
                e.Handled = true;
        }

        public List<IBaseManager> getManagers()
        {
            return null;
        }
    }
}
