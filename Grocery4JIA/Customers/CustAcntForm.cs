using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using System.Windows.Forms;
using BLL;
using System;
using System.Collections.Generic;

namespace UI
{
    public partial class CustAcntForm : Form, IBaseForm
    {
        ICustomerManager manager;
        long? id = null;
        Customer customer;
        int uptCnt = 0;
        public CustAcntForm(ICustomerManager manager, Customer cust, CustAcnt acnt)
        {
            InitializeComponent();
            this.manager = manager;
            this.customer = cust;
            BindingSource tpBs = new BindingSource();
            tpBs.DataSource = ACNT_TYPE.ACNT_MAP;
            cboxAcntType.DataSource = tpBs;
            cboxAcntType.DisplayMember = "Value";
            cboxAcntType.ValueMember = "Key";

            BindingSource ptBs = new BindingSource();
            ptBs.DataSource = PLATFORM_NM.PLATFORM_MAP;
            cboxPlt.DataSource = ptBs;
            cboxPlt.DisplayMember = "Value";
            cboxPlt.ValueMember = "Key";

            if (null == acnt)
                Text = "【新增账户】 " + customer.CName;
            else
            {
                Text = "【修改账户】 " + customer.CName;
                txtAcntNO.Text = acnt.AcntNO;
                cboxAcntType.SelectedValue = acnt.AcntType;
                cboxPlt.SelectedValue = acnt.Platform;
                if (acnt.St == ST.INVALID)
                    rbtnInvalid.Checked = true;
                else if (acnt.St == ST.VALID)
                    rbtnValid.Checked = true;
                id = acnt.ID__PK;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (StringUtil.isEmpty(txtAcntNO.Text))
            {
                MessageBox.Show("请填写账户先！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustAcnt acnt = new CustAcnt();
            acnt.CustID = customer.CID__PK;
            acnt.AcntNO = txtAcntNO.Text;
            acnt.AcntType = StringUtil.Obj2Str(cboxAcntType.SelectedValue);
            string type = StringUtil.Obj2Str(cboxAcntType.SelectedValue);
            if (ACNT_TYPE.BANCK_NO == type)
                acnt.Platform = null;
            else if (ACNT_TYPE.THIRD_PLATFORM == type)
                acnt.Platform = StringUtil.Obj2Str(cboxPlt.SelectedValue);

            if (rbtnInvalid.Checked)
                acnt.St = ST.INVALID;
            else if (rbtnValid.Checked)
                acnt.St = ST.VALID;

            int exCnt = 0;
            try
            {
                if (null != id)
                {
                    acnt.ID__PK = id;
                    exCnt = manager.UpdateAcnt(acnt);
                }
                else
                    exCnt = manager.AddCustAcnt(acnt);
            }
            catch
            {
                exCnt = 0;
            }

            if(exCnt > 0)
            {
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uptCnt++;
            }  
            else
                MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cboxAcntType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string type = StringUtil.Obj2Str(cboxAcntType.SelectedValue);
            if (ACNT_TYPE.BANCK_NO == type)
                cboxPlt.Enabled = false;
            else if(ACNT_TYPE.THIRD_PLATFORM == type)
                cboxPlt.Enabled = true;
        }

        public List<IBaseManager> getManagers()
        {
            return null;
        }
    }
}
