using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerForm : Form
    {
        CustomerManager manager;
        int? cId = null;
        public CustomerForm(Customer cst, string gradeEnum, CustomerManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            if (null != cst)
            {
                this.Text = "修改客户信息";
                cId = cst.CID__PK;

                txtCName.Text = cst.CName;
                txtAddress.Text = cst.Address;
                txtEmail.Text = cst.Email;
                txtFax.Text = cst.Fax;
                txtTel.Text = cst.Tel;
                txtPhone.Text = cst.Phone;
                txtRemark.Text = cst.Remark;
                txtLinkMan.Text = cst.LinkMan;
                if (ST.INVALID == cst.St)
                    rbtnInvalid.Checked = true;
                else if (ST.VALID == cst.St)
                    rbtnValid.Checked = true;
            }
            else
            {
                this.Text = "添加客户";
                rbtnInvalid.Enabled = false;
                rbtnValid.Enabled = false;
                rbtnValid.Checked = true;
            }

            BindingSource stBs = new BindingSource();
            stBs.DataSource = GRADE.GRADE_MAP;
            cboxGrade.DisplayMember = "Value";
            cboxGrade.ValueMember = "Key";
            cboxGrade.DataSource = stBs;
            cboxGrade.SelectedValue = gradeEnum;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Customer cust = new Customer();
            int exCnt = 0;
            cust.CName = txtCName.Text.Trim();
            cust.Address = txtAddress.Text.Trim();
            cust.Email = txtEmail.Text.Trim();
            cust.Fax = txtFax.Text.Trim();
            cust.Grade = StringUtil.Obj2Str(cboxGrade.SelectedValue);
            cust.LinkMan = txtLinkMan.Text.Trim();
            cust.Phone = txtPhone.Text.Trim();
            cust.Remark = txtRemark.Text.Trim();
            cust.Tel = txtTel.Text.Trim();
            if (rbtnInvalid.Checked)
                cust.St = ST.INVALID;
            else if (rbtnValid.Checked)
                cust.St = ST.VALID;
            if (null == cId)
            {
                exCnt = manager.Save(cust);
            }
            else
            {
                cust.CID__PK = (int)cId;
                exCnt = manager.Update(cust);
            }

            if (exCnt > 0)
            {
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
            else
                MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnColse_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
