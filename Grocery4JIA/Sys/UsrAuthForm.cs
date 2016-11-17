using BLL.Admin;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class UsrAuthForm : Form, IBaseForm
    {
        IUsrAuthManager manager;
        IUsrManager usrManager;
        NameValueCollection section;
        public UsrAuthForm()
        {
            InitializeComponent();
            dtgvAuth.AutoGenerateColumns = false;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IUsrAuthManager>(MainForm.usr);
            if(null == usrManager)
                usrManager = InterfaceProxyGenerator.CreateInterfaceProxy<IUsrManager>(MainForm.usr);

            section = (NameValueCollection)ConfigurationManager.GetSection("FunctionGroup/Func");
            List<Usr> usrs = usrManager.LoadUsrs();
            cboxUsr.DataSource = usrs;
            cboxUsr.DisplayMember = "UId__PK";
            cboxUsr.ValueMember = "UId__PK";
            BindData();
        }

        private void BindData()
        {
            dtgvAuth.Rows.Clear();
            if (cboxUsr.SelectedIndex == -1)
                return;
            string uId = cboxUsr.SelectedValue.ToString();
            List<UsrAuth> authList = manager.LoadUsrAuth(uId);
            Dictionary<string, UsrAuth> map = new Dictionary<string, UsrAuth>();
            foreach (UsrAuth auth in authList)
            {
                if(!StringUtil.isEmpty(auth.FuncID__PK))
                    map.Add(auth.FuncID__PK, auth);
            }
            foreach (string key in section.Keys)
            {
                string desc = section[key];
                int index = dtgvAuth.Rows.Add();
                dtgvAuth.Rows[index].Cells[colFuncID.Name].Value = key;
                dtgvAuth.Rows[index].Cells[colFuncNm.Name].Value = desc;
                if (map.ContainsKey(key))
                {
                    UsrAuth auth = map[key];
                    dtgvAuth.Rows[index].Cells[colckbox.Name].Value = "true";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboxUsr.SelectedIndex == -1)
                return;
            string uId = StringUtil.Obj2Str(cboxUsr.SelectedValue);
            List<UsrAuth> list = new List<UsrAuth>();
            foreach (DataGridViewRow row in dtgvAuth.Rows)
            {
                UsrAuth auth = new UsrAuth();
                string value = StringUtil.Obj2Str(row.Cells[colckbox.Name].Value);
                if (value == "true")
                    auth.St = ST.VALID;
                else
                    auth.St = ST.INVALID;
                
                auth.FuncID__PK = StringUtil.Obj2Str(row.Cells[colFuncID.Name].Value);
                auth.UID__PK = uId;
                list.Add(auth);
            }
            try
            {
                int cnt = 0;
                if (list.Count > 0)
                    cnt = manager.SetAuth(list);
                if(cnt >0)
                    MainForm.Info("设置成功！");
                else
                    MainForm.Warn("设置失败！") ;
            }
            catch(Exception e1)
            {
                MainForm.Error(e1.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboxUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindData();
            Usr usr = cboxUsr.SelectedItem as Usr;
            txtUName.Text = usr.UName;
        }

        private void dtgvAuth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvAuth.Columns[e.ColumnIndex].Name == colckbox.Name)
                {
                    string value = StringUtil.Obj2Str(dtgvAuth.Rows[e.RowIndex].Cells[colckbox.Name].Value);
                    if (value == "true")
                        dtgvAuth.Rows[e.RowIndex].Cells[colckbox.Name].Value = "false";
                    else
                        dtgvAuth.Rows[e.RowIndex].Cells[colckbox.Name].Value = "true";
                }
            }
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager, usrManager };
        }
    }
}
