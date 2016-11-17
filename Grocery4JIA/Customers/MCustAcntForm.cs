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
    public partial class MCustAcntForm : Form, IBaseForm
    {
        List<Customer> suppliers;
        List<Customer> resellers;
        ICustomerManager manager;
        public MCustAcntForm()
        {
            InitializeComponent();
            dtgvAcnt.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);

            BindingSource bs = new BindingSource();
            bs.DataSource = GRADE.GRADE_MAP;
            cboxGrade.DataSource = bs;
            cboxGrade.DisplayMember = "Value";
            cboxGrade.ValueMember = "Key";

            cboxCust.DisplayMember = "CName";
            cboxCust.ValueMember = "CID__PK";
            string grade = StringUtil.Obj2Str(cboxGrade.SelectedValue);
            Customer cust = new Customer();
            cust.Grade = grade;
            if (grade == GRADE.SUPPLIER)
            {
                suppliers = manager.LoadData(cust,null);
                cboxCust.DataSource = suppliers;
            }

            else if (grade == GRADE.RESELLER)
            {
                resellers = manager.LoadData(cust,null);
                cboxCust.DataSource = resellers;
            }  
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int custId = 0;
            if(cboxCust.SelectedIndex != -1)
                custId = StringUtil.Obj2Int(cboxCust.SelectedValue);
            List<CustAcnt>  list = manager.LoadCustAcnt(custId, true);
            dtgvAcnt.DataSource = list;
        }

        private void cboxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grade = StringUtil.Obj2Str(cboxGrade.SelectedValue);
            Customer cust = new Customer();
            cust.Grade = grade;
            if (grade == GRADE.SUPPLIER)
            {
                if (null == suppliers)
                    suppliers = manager.LoadData(cust,null);
                cboxCust.DataSource = suppliers;
            }

            else if (grade == GRADE.RESELLER)
            {
                if(null == resellers)
                    resellers = manager.LoadData(cust,null);
                cboxCust.DataSource = resellers;
            }
        }

        private void dtgvAcnt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvAcnt.Columns[e.ColumnIndex].Name == colAcntTypeDesc.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = ACNT_TYPE.ACNT_MAP[e.Value.ToString()];
            }
            else if (dtgvAcnt.Columns[e.ColumnIndex].Name == colPlatformDesc.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = PLATFORM_NM.PLATFORM_MAP[e.Value.ToString()];
            }
            else if (dtgvAcnt.Columns[e.ColumnIndex].Name == colStDesc.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = ST.CUST_MAP[e.Value.ToString()];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboxCust.SelectedIndex == -1)
                return;
            Customer cust = cboxCust.SelectedItem as Customer;
            CustAcntForm acntForm = new CustAcntForm(manager, cust, null);
            DialogResult rslt = acntForm.ShowDialog();
            if (DialogResult.OK == rslt)
                btnQuery_Click(btnQuery, new EventArgs());
        }

        private void dtgvAcnt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvAcnt.CurrentRow;
            if (null != curRow && null != cboxCust.SelectedItem)
            {
                Customer cust = cboxCust.SelectedItem as Customer;
                CustAcnt acnt = new CustAcnt();
                acnt.AcntNO = StringUtil.Obj2Str(curRow.Cells[colAcntNO.Name].Value);
                acnt.AcntType = StringUtil.Obj2Str(curRow.Cells[colAcntType.Name].Value);
                acnt.CustID = StringUtil.Obj2Int(curRow.Cells[colCustID.Name].Value);
                acnt.ID__PK = StringUtil.Obj2Long(curRow.Cells[colID.Name].Value);
                acnt.Platform = StringUtil.Obj2Str(curRow.Cells[colPlatform.Name].Value);
                acnt.St = StringUtil.Obj2Str(curRow.Cells[colSt.Name].Value);

                CustAcntForm acntForm = new CustAcntForm(manager, cust, acnt);
                DialogResult rslt = acntForm.ShowDialog();
                if (DialogResult.OK == rslt)
                    btnQuery_Click(btnQuery, new EventArgs());
            }
        }

        private void cboxCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvAcnt.DataSource = null;
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager };
        }
    }
}
