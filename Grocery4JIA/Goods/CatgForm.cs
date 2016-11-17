using BLL.Com;
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
    /// <summary>
    /// 商品大类设置Form
    /// </summary>
    public partial class CatgForm : Form, IBaseForm
    {
        ICatgManager manager;
        public CatgForm()
        {
            InitializeComponent();
            dtgvCatg.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<ICatgManager>(usr);
        }

        private void CatgForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        { 
            try
            {
                List<Category> data = manager.LoadData(true); 
                if (null != data && data.Count > 0)
                    dtgvCatg.DataSource = data;
            }
            catch(Exception e)
            {
                string msg = e.Message;
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvCatg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dtgvCatg.Columns[e.ColumnIndex].Name == colSt.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = ST.CATG_MAP[e.Value.ToString()];
            }
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void dtgvCatg_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow curRow = dtgvCatg.CurrentRow;
            txtMdfyName.Text = StringUtil.Obj2Str(curRow.Cells[colName.Name].Value);
            string stEnum = StringUtil.Obj2Str(curRow.Cells[colStEnum.Name].Value);
            if (stEnum == ST.VALID)
                rbtnMdfyValid.Checked = true;
            else if (stEnum == ST.INVALID)
                rbtnMdfyInvalid.Checked = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = dtgvCatg.CurrentRow;
            if (null == curRow)
                return;
            string cid = StringUtil.Obj2Str(curRow.Cells[colCId.Name].Value);
            string name = StringUtil.Obj2Str(curRow.Cells[colName.Name].Value);

            string newName = txtMdfyName.Text.Trim();
            if (newName == string.Empty)
            {
                MainForm.Warn("分类名称不能为空！");
                txtMdfyName.Focus();
                return;
            }

            if (newName != name)
            {
                int cnt = manager.GenCatgCount(newName);
                if (cnt > 0)
                {
                    MainForm.Warn("分类名称已存在！");
                    txtMdfyName.Focus();
                    return;
                }
            }

            string newStEnum = ST.VALID;
            if (rbtnMdfyInvalid.Checked)
                newStEnum = ST.INVALID;

            Category catg = new Category();
            catg.CId__PK = Int16.Parse(cid);
            catg.CName = newName;
            catg.St = newStEnum;

            try
            {
                int exCnt = manager.Update(catg);
                string msg = "修改失败！";
                if (exCnt > 0)
                {
                    msg = "修改成功！";
                    BindData();
                }
                MainForm.Info(msg);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MainForm.Error(msg);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cname = txtAddName.Text.Trim();
            try
            {
                if (StringUtil.isEmpty(cname))
                {
                    MainForm.Warn("分类名称不能为空！");
                    txtAddName.Focus();
                    return;
                }
                int cnt = manager.GenCatgCount(cname);
                if (cnt > 0)
                {
                    MainForm.Warn("分类名称已存在！");
                    txtAddName.Focus();
                    return;
                }
                Category catg = new Category();
                catg.CName = cname;
                catg.St = ST.VALID;
                cnt = manager.Save(catg);

                string msg = "添加失败！";
                if (cnt > 0)
                {
                    msg = "添加成功！";
                    BindData();
                    txtAddName.Text = "";
                }
                MainForm.Info(msg);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager };
        }
    }
}
