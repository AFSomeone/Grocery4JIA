using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class PayMntForm : Form, IBaseForm
    {
        ISupplierBillingManager supplierManager;
        IResellerBillingManager resellerManager;
        string grade;
        int custId;
        BillGoodsVO billGoods = null ;

        public PayMntForm(string billNO, Customer cust, object manager)
        {
            InitializeComponent();
            dtgvBillGoods.AutoGenerateColumns = false;
            dtgvBillChld.AutoGenerateColumns = false;
            if (cust.Grade == GRADE.SUPPLIER)
            {
                supplierManager = (ISupplierBillingManager)manager;
                grade = GRADE.SUPPLIER;
                lblPymnt.Text = "付款：";
                btnCnfrm.Text = "付款";
            }

            else if (cust.Grade == GRADE.RESELLER)
            {
                resellerManager = (IResellerBillingManager)manager;
                grade = GRADE.RESELLER;
                lblPymnt.Text = "收款：";
                btnCnfrm.Text = "收款";
            }
            else
                return;
            this.custId = (int)cust.CID__PK;

            BindingSource modeBs = new BindingSource();
            modeBs.DataSource = PAY_MODE.MODE_MAP;
            cboxPayMode.DataSource = modeBs;
            cboxPayMode.DisplayMember = "Value";
            cboxPayMode.ValueMember = "Key";

            BindingSource patfBs = new BindingSource();
            patfBs.DataSource = PLATFORM_NM.PLATFORM_MAP;
            cboxPlatform.DataSource = patfBs;
            cboxPlatform.DisplayMember = "Value";
            cboxPlatform.ValueMember = "Key";
            cboxPlatform.Enabled = false;

            autxtAcntNO.Enabled = false;
            InitPymntTable(billNO, custId);
            InitChldTable(billNO);
        }

        private void InitPymntTable(string billNO, int custId)
        {
            if (grade == GRADE.SUPPLIER)
                billGoods = supplierManager.LoadBillGoods(billNO, custId, null);
            else if (grade == GRADE.RESELLER)
                billGoods = resellerManager.LoadBillGoods(billNO, custId, null);

            setAmntInfo();
            if (null != billGoods)
            {
                Text = "【" + billGoods.CustName + "】 账单NO. " + billGoods.BillNO__PK;
                List<OrderGoodsVO> list = billGoods._OrderGoods;
                foreach (OrderGoodsVO goods in list)
                {
                    int index = dtgvBillGoods.Rows.Add();
                    dtgvBillGoods.Rows[index].Cells[colOrderNO.Name].Value = goods.OrderNO;
                    dtgvBillGoods.Rows[index].Cells[colDirectDesc.Name].Value = DIRECT.DIRECT_MAP[goods.Direct];
                    dtgvBillGoods.Rows[index].Cells[colGID.Name].Value = goods.GID;
                    dtgvBillGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
                    dtgvBillGoods.Rows[index].Cells[colSpesc.Name].Value = goods.Specs;
                    dtgvBillGoods.Rows[index].Cells[colNum.Name].Value = goods.Num;
                    dtgvBillGoods.Rows[index].Cells[colPrice.Name].Value = goods.Price;
                    dtgvBillGoods.Rows[index].Cells[colCrtTmst.Name].Value = goods.Tmst;
                    dtgvBillGoods.Rows[index].Cells[colAmount.Name].Value = goods.Num * goods.Price;
                }
            }
        }

        private void InitChldTable(string billNO)
        {
            List<BillingChldVO> chldVOs = null;
            if (grade == GRADE.SUPPLIER)
                chldVOs = supplierManager.LoadBillingChld(billNO,null);
            else if (grade == GRADE.RESELLER)
                chldVOs = resellerManager.LoadBillingChld(billNO,null);
            dtgvBillChld.DataSource = chldVOs;

            decimal factAmount = 0;
            foreach (DataGridViewRow row in dtgvBillChld.Rows)
            {
                decimal amount = StringUtil.Obj2Decimal(row.Cells["colBillAmount"].Value);
                factAmount += amount;
            }
            if (null != billGoods)
                billGoods.FactAmount = factAmount;
        }

        private void btnCnfrm_Click(object sender, System.EventArgs e)
        {
            decimal? amount = null;
            try
            {
                amount = decimal.Parse(txtPymnt.Text.Trim());
            }
            catch
            {
                txtPymnt.Text = string.Empty;
                return;
            }
            if (billGoods.Amount - billGoods.FactAmount < amount)
            {
                MainForm.Warn("入账金额超出！");
                return;
            }
            int cnt = 0;
            BillingChld chld = new BillingChld();
            chld.BillNO = billGoods.BillNO__PK;
            chld.PayMode = StringUtil.Obj2Str(cboxPayMode.SelectedValue);
            chld.Amount = amount;
            chld.OprtUsrId = MainForm.usr.UId__PK;

            CustAcnt custAcnt = new CustAcnt();
            if (PAY_MODE.CASH == chld.PayMode)
                custAcnt = null;
            else
            {
                if (null != autxtAcntNO.SelectedObj)
                    custAcnt = autxtAcntNO.SelectedObj as CustAcnt;
                else
                {
                    if (!StringUtil.isEmpty(autxtAcntNO.Term))
                    {
                        custAcnt.AcntNO = autxtAcntNO.Term.Trim();
                        custAcnt.CustID = custId;
                        custAcnt.St = ST.VALID;
                        if (PAY_MODE.BANK_TRANSFER == chld.PayMode)
                        {
                            custAcnt.AcntType = ACNT_TYPE.BANCK_NO;
                            custAcnt.Platform = null;
                        }
                        else if (PAY_MODE.THIRD_PLATFORM == chld.PayMode)
                        {
                            custAcnt.AcntType = ACNT_TYPE.THIRD_PLATFORM;
                            custAcnt.Platform = StringUtil.Obj2Str(cboxPlatform.SelectedValue);
                        }
                    }
                    else
                        custAcnt = null;
                }
            }
            if (grade == GRADE.SUPPLIER)
                cnt = supplierManager.Pay(chld, custAcnt);
            else if (grade == GRADE.RESELLER)
                cnt = resellerManager.Rcv(chld, custAcnt);

            if (cnt < 1)
            {
                MainForm.Warn("操作失败！");
            }
            else
            {
                tabPymnt.SelectedTab = tabPChld;
                InitChldTable(billGoods.BillNO__PK);
                txtPymnt.Text = string.Empty;
                cboxPayMode.SelectedIndex = 0;
                cboxPlatform.SelectedIndex = 0;
                autxtAcntNO.clear();
            }
        }

        private void cboxPayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = StringUtil.Obj2Str(cboxPayMode.SelectedValue);
            if (PAY_MODE.CASH == value)
            {
                autxtAcntNO.Enabled = false;
                cboxPlatform.Enabled = false;
            }
            else if (PAY_MODE.BANK_TRANSFER == value)
            {
                autxtAcntNO.Enabled = true;
                cboxPlatform.Enabled = false;
            }      
            else if (PAY_MODE.THIRD_PLATFORM == value)
            {
                autxtAcntNO.Enabled = true;
                cboxPlatform.Enabled = true;
            }
            autxtAcntNO.clear();
        }

        private void dtgvBillChld_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvBillChld.Columns[e.ColumnIndex].Name == colPayMode.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = PAY_MODE.MODE_MAP[e.Value.ToString()];
            }
            else if (dtgvBillChld.Columns[e.ColumnIndex].Name == colPlatform.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    e.Value = "——";
                else
                    e.Value = PLATFORM_NM.PLATFORM_MAP[e.Value.ToString()];
            }
            else if (dtgvBillChld.Columns[e.ColumnIndex].Name == colAcntNO.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    e.Value = "——";
            }
        }

        private void cboxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            autxtAcntNO.clear();
        }

        private void setAmntInfo()
        {
            string factAmountStr = "";
            if (grade == GRADE.SUPPLIER)
            {
                factAmountStr = "已付：";
                tabPOprt.Text = "付款";
            }
            else if (grade == GRADE.RESELLER)
            {
                factAmountStr = "已收：";
                tabPOprt.Text = "收款";
            }

            if (null != billGoods)
            {
                lblTotalAmount.Text = "总计：" + billGoods.Amount + "，" + factAmountStr + billGoods.FactAmount;
            }
        }

        private void tabPymnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPymnt.SelectedTab.Name == tabPOprt.Name)
                setAmntInfo();
        }

        public List<IBaseManager> getManagers()
        {
            return null;
        }

        private void autxtAcntNO_loadData(object sender, EventArgs e)
        {
            string term = autxtAcntNO.Term;

            List<auto_text.AutoData> data = new List<auto_text.AutoData>();
            if (term.Trim().Length > 0)
            {
                string type = StringUtil.Obj2Str(cboxPayMode.SelectedValue);
                string platfrom = StringUtil.Obj2Str(cboxPlatform.SelectedValue);
                List<CustAcnt> list = new List<CustAcnt>();
                if (grade == GRADE.SUPPLIER)
                    list = supplierManager.LoadCustAcntByKeywords(custId, type, platfrom, term.Trim());
                else if (grade == GRADE.RESELLER)
                    list = resellerManager.LoadCustAcntByKeywords(custId, type, platfrom, term.Trim());

                foreach (CustAcnt acnt in list)
                {
                    auto_text.AutoData adata = new auto_text.AutoData();
                    adata.Text = acnt.AcntNO;
                    adata.Val = acnt;
                    data.Add(adata);
                }
            }
            autxtAcntNO.Data = data;
        }
    }
}
