using BLL.Admin;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class MUsrsForm : Form, IBaseForm
    {
        IUsrManager manager;
        public MUsrsForm()
        {
            InitializeComponent();
            dtgvUsrs.AutoGenerateColumns = false;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IUsrManager>(MainForm.usr);

            Dictionary<string, string> stMap = new Dictionary<string, string>();
            stMap.Add("","--不限--");
            foreach (string key in ST.USR_MAP.Keys)
                stMap.Add(key, ST.USR_MAP[key]);
            BindingSource stBs = new BindingSource();
            stBs.DataSource = stMap;
            cboxSt.DisplayMember = "Value";
            cboxSt.ValueMember = "Key";
            cboxSt.DataSource = stBs;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Usr usr = new Usr();
            usr.UId__PK = txtUID.Text.Trim();
            usr.UName = txtUName.Text.Trim();
            usr.St = StringUtil.Obj2Str(cboxSt.SelectedValue);
            List<Usr> list = manager.LoadUsrs(usr);
            dtgvUsrs.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UsrForm usrForm = new UsrForm(null, manager);
            DialogResult rslt = usrForm.ShowDialog();
            if (rslt == DialogResult.OK)
                btnQuery_Click(btnQuery , new EventArgs());
        }

        private void dtgvUsrs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usr usr = new Usr();
            usr.UId__PK = StringUtil.Obj2Str(dtgvUsrs.CurrentRow.Cells[colUId.Name].Value);
            usr.UName = StringUtil.Obj2Str(dtgvUsrs.CurrentRow.Cells[colUName.Name].Value);
            usr.QQ = StringUtil.Obj2Str(dtgvUsrs.CurrentRow.Cells[colQQ.Name].Value);
            usr.Tel = StringUtil.Obj2Str(dtgvUsrs.CurrentRow.Cells[colTel.Name].Value);
            usr.St = StringUtil.Obj2Str(dtgvUsrs.CurrentRow.Cells[colSt.Name].Value);
            usr.Remark = StringUtil.Obj2Str(dtgvUsrs.CurrentRow.Cells[colRemark.Name].Value);

            UsrForm usrForm = new UsrForm(usr, manager);
            DialogResult rslt = usrForm.ShowDialog();
            if (rslt == DialogResult.OK)
                btnQuery_Click(btnQuery, new EventArgs());
        }

        private void dtgvUsrs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvUsrs.Columns[e.ColumnIndex].Name == colStDesc.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = ST.USR_MAP[e.Value.ToString()];
            }
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager };
        }
    }
}