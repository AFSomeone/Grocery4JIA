using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class MCustomersForm : Form
    {
        CustomerManager manager;
        string grade;
        public MCustomersForm(string gradeEnum)
        {
            InitializeComponent();
            dtgvCustomers.AutoGenerateColumns = false;
            grade = gradeEnum;
            if (null == manager)
                manager = new CustomerManager();

            BindingSource stBs = new BindingSource();
            Dictionary<string, string> custMap = new Dictionary<string, string>();
            custMap.Add("", "全部");
            custMap.Add(ST.VALID, ST.CUST_MAP[ST.VALID]);
            custMap.Add(ST.INVALID, ST.CUST_MAP[ST.INVALID]);
            stBs.DataSource = custMap;
            cboxSt.DisplayMember = "Value";
            cboxSt.ValueMember = "Key";
            cboxSt.DataSource = stBs;

            if (GRADE.SUPPLIER == grade)
                this.lblCName.Text = "供应商名称：";
            else if (GRADE.RESELLER == grade)
                this.lblCName.Text = "分销商名称：";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerForm csForm = new CustomerForm(null, grade, manager);
            DialogResult result = csForm.ShowDialog();
            if (result == DialogResult.OK)
                BindData();
        }

        private void BindData()
        {
            try
            {
                Customer cust = new Customer();
                cust.CName = txtCName.Text.Trim();
                cust.LinkMan = txtLinkMan.Text.Trim();
                cust.St = StringUtil.Obj2Str(cboxSt.SelectedValue);
                cust.Grade = grade;
                List<Customer> list = manager.LoadData(cust);
                if (null != list && list.Count > 0)
                {
                    dtgvCustomers.DataSource = null;
                    dtgvCustomers.DataSource = list;
                }
                else
                    dtgvCustomers.DataSource = null;
            }
            catch
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvCustomers.Columns[e.ColumnIndex].Name == colSt.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = ST.CUST_MAP[e.Value.ToString()];
            }

            if (dtgvCustomers.Columns[e.ColumnIndex].Name == colGrade.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = GRADE.GRADE_MAP[e.Value.ToString()];
            }
        }

        private void dtgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvCustomers.CurrentRow;
            if (null != curRow)
            {
                Customer cust = new Customer();
                cust.CID__PK = StringUtil.Obj2Int(curRow.Cells[colCID.Name].Value);
                cust.CName = StringUtil.Obj2Str(curRow.Cells[colCName.Name].Value);
                cust.Address = StringUtil.Obj2Str(curRow.Cells[colAddress.Name].Value);
                cust.Email = StringUtil.Obj2Str(curRow.Cells[colEmail.Name].Value);
                cust.Fax = StringUtil.Obj2Str(curRow.Cells[colFax.Name].Value);
                cust.Grade = StringUtil.Obj2Str(curRow.Cells[colGradeEnum.Name].Value);
                cust.LinkMan = StringUtil.Obj2Str(curRow.Cells[colLinkMan.Name].Value);
                cust.Tel = StringUtil.Obj2Str(curRow.Cells[colTel.Name].Value);
                cust.Phone = StringUtil.Obj2Str(curRow.Cells[colPhone.Name].Value);
                cust.Remark = StringUtil.Obj2Str(curRow.Cells[colRemark.Name].Value);
                cust.St = StringUtil.Obj2Str(curRow.Cells[colStEnum.Name].Value);

                CustomerForm csForm = new CustomerForm(cust, grade, manager);
                DialogResult result = csForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    BindData();
                }
            }
        }
    }
}
