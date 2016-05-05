using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    /// <summary>
    /// 商品大类设置Form
    /// </summary>
    public partial class CatgForm : Form
    {
        CatgManager manager;
        public CatgForm()
        {
            InitializeComponent();
            dtgvCatg.AutoGenerateColumns = false;
            if (null == manager)
                manager = new CatgManager();
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
            catch
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string cid = StringUtil.Obj2Str(curRow.Cells[colCId.Name].Value);
            string name = StringUtil.Obj2Str(curRow.Cells[colName.Name].Value);

            string newName = txtMdfyName.Text.Trim();
            if (newName == string.Empty)
            {
                MessageBox.Show("分类名称不能为空！", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMdfyName.Focus();
                return;
            }

            if (newName != name)
            {
                int cnt = manager.GenCatgCount(newName);
                if (cnt > 0)
                {
                    MessageBox.Show("分类名称已存在！", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            int exCnt = manager.Update(catg);
            string msg = "修改失败！";
            if (exCnt > 0)
            {
                msg = "修改成功！";
                BindData();
            }
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cname = txtAddName.Text.Trim();
            if (cname == string.Empty)
            {
                MessageBox.Show("分类名称不能为空！", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddName.Focus();
                return;
            }
            int cnt = manager.GenCatgCount(cname);
            if (cnt > 0)
            {
                MessageBox.Show("分类名称已存在！", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
