using BLL.Com;
using BLL.Proxy;
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
    public partial class MResellerBillingForm : Form, IBaseForm
    {
        IResellerBillingManager billingManager;
        ICustomerManager custManager;
        IStockOutManager stockoutManager;
        IResellerRefundManager refundManager;
        PageVO orderPage;
        PageVO billPage;
        Dictionary<string, decimal> selectedOrdrs;

        public MResellerBillingForm()
        {
            InitializeComponent();
            dtgvBilling.AutoGenerateColumns = false;
            dtgvOrders.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            orderPage = new PageVO();
            billPage = new PageVO();
            orderPage.PageNo = 1;
            billPage.PageNo = 1;
            selectedOrdrs = new Dictionary<string, decimal>();

            if (null == billingManager)
                billingManager = InterfaceProxyGenerator.CreateInterfaceProxy<IResellerBillingManager>(usr);
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);

            Customer cust = new Customer();
            cust.Grade = GRADE.RESELLER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust,null);
            cboxQrdResellers.DisplayMember = "CName";
            cboxQrdResellers.ValueMember = "CID__PK";
            cboxQrdResellers.DataSource = custs;

            cboxBillResellers.DisplayMember = "CName";
            cboxBillResellers.ValueMember = "CID__PK";
            cboxBillResellers.DataSource = custs;

            BindingSource directBs = new BindingSource();
            directBs.DataSource = new Dictionary<string, string> { { string.Empty, "全部" }, { DIRECT.STOCK_OUT, "出货单" }, { DIRECT.RESELLER_REFUND, "回收单" } };
            cboxDirect.DataSource = directBs;
            cboxDirect.DisplayMember = "Value";
            cboxDirect.ValueMember = "Key";

            BindingSource stBs = new BindingSource();
            Dictionary<string, string> stDict = new Dictionary<string, string> { { string.Empty, "全部" } };
            foreach (string key in HANDLE_FLAG.HANDLE_MAP.Keys)
                stDict.Add(key, HANDLE_FLAG.HANDLE_MAP[key]);
            stBs.DataSource = stDict;
            cboxEntry.DataSource = stBs;
            cboxEntry.DisplayMember = "Value";
            cboxEntry.ValueMember = "Key";

            BindingSource settleBs = new BindingSource();
            settleBs.DataSource = new Dictionary<string, string> { { string.Empty, "全部" }, { "false", "未结清" }, { "true", "已结清" } };
            cboxBillSt.DataSource = settleBs;
            cboxBillSt.DisplayMember = "Value";
            cboxBillSt.ValueMember = "Key";
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            dtgvOrders.Rows.Clear();
            Order order = new Order();
            DateTime? startDt = null;
            DateTime? endDt = null;
            if (!StringUtil.isEmpty(txtQyOrderNO.Text.Trim()))
                order.OrderNO__PK = txtQyOrderNO.Text.Trim();
            if (ckboxQyEnableStDt.Checked)
            {
                string dtStr = dtpQyStDt.Value.ToString("yyyyMMdd");
                startDt = DateTime.ParseExact(dtStr, "yyyyMMdd", null);
            }
            if (ckboxQyEnableEndDt.Checked)
            {
                string dtStr = dtpQyEndDt.Value.ToString("yyyyMMdd");
                endDt = DateTime.ParseExact(dtStr, "yyyyMMdd", null);
            }
            int custId = 0;
            if (cboxQrdResellers.SelectedIndex !=-1)
                custId = StringUtil.Obj2Int(cboxQrdResellers.SelectedValue);
            order.CustID = custId;
            string handleFlag = StringUtil.Obj2Str(cboxEntry.SelectedValue);
            order.Handled = handleFlag;
            string direct = StringUtil.Obj2Str(cboxDirect.SelectedValue);
            order.Direct = direct;
            List<OrderVO> list = billingManager.LoadOrders(order, startDt, endDt, orderPage);
            foreach (OrderVO vo in list)
            {
                int index = dtgvOrders.Rows.Add();
                InitRow(index, vo);
            }
            dgvpgOrder.TotalPageNum = orderPage.TotalPage;
            dgvpgOrder.TotalNum = orderPage.TotalNum;
            dgvpgOrder.ShowPageInfo();
        }

        private void InitRow(int index, OrderVO vo)
        {
            bool handled = vo.Handled == HANDLE_FLAG.HANDLED ? true : false;
            if (handled)
            {
                dtgvOrders.Rows[index].Cells[colCkboxs.Name].ReadOnly = true;
                dtgvOrders.Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                if (selectedOrdrs.ContainsKey(vo.OrderNO__PK))
                    dtgvOrders.Rows[index].Cells[colCkboxs.Name].Value = "true";
            }
            dtgvOrders.Rows[index].Cells[colHandled.Name].Value = vo.Handled;
            dtgvOrders.Rows[index].Cells[colAmount.Name].Value = vo.Amount;
            dtgvOrders.Rows[index].Cells[colBillNO.Name].Value = StringUtil.isEmpty(vo.BillNO) ? "——" : vo.BillNO;
            dtgvOrders.Rows[index].Cells[colCrtTmst.Name].Value = vo.CrtTmst;
            dtgvOrders.Rows[index].Cells[colCrtUID.Name].Value = vo.CrtUID;
            dtgvOrders.Rows[index].Cells[colCrtUName.Name].Value = vo.CrtUName;
            dtgvOrders.Rows[index].Cells[colCustID.Name].Value = vo.CustID;
            dtgvOrders.Rows[index].Cells[colDirectDesc.Name].Value = DIRECT.DIRECT_MAP[vo.Direct];
            dtgvOrders.Rows[index].Cells[colDirect.Name].Value = vo.Direct;
            dtgvOrders.Rows[index].Cells[colOrderNO.Name].Value = vo.OrderNO__PK;
        }

        private void dtgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvOrders.Columns[e.ColumnIndex].Name == colCkboxs.Name)
                {
                    DataGridViewRow row = dtgvOrders.Rows[e.RowIndex];
                    string value = StringUtil.Obj2Str(row.Cells[colCkboxs.Name].Value);
                    bool handled = HANDLE_FLAG.HANDLED == StringUtil.Obj2Str(row.Cells[colHandled.Name].Value) ? true : false;
                    string orderNo = StringUtil.Obj2Str(row.Cells[colOrderNO.Name].Value);
                    if (handled)
                    {
                        if (selectedOrdrs.ContainsKey(orderNo))
                            selectedOrdrs.Remove(orderNo);
                        row.Cells[colCkboxs.Name].Value = "false";
                        return;
                    }
                    if (value == "true")
                    {
                        if (selectedOrdrs.ContainsKey(orderNo))
                            selectedOrdrs.Remove(orderNo);
                        row.Cells[colCkboxs.Name].Value = "false";
                    }
                    else
                    {
                        if (!selectedOrdrs.ContainsKey(orderNo))
                        {
                            decimal amount = StringUtil.Obj2Decimal(row.Cells[colAmount.Name].Value);
                            string direct = StringUtil.Obj2Str(row.Cells[colDirect.Name].Value);
                            if (DIRECT.RESELLER_REFUND == direct)
                                amount *= -1;
                            selectedOrdrs.Add(orderNo, amount);
                        }
                        row.Cells[colCkboxs.Name].Value = "true";
                    }     
                }
            }
        }

        private void btnBillQuery_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            DateTime? startDt = null;
            DateTime? endDt = null;
            if (!StringUtil.isEmpty(txtBillNO.Text.Trim()))
                bill.BillNO__PK = txtBillNO.Text.Trim();
            if (ckboxBillEnableStDt.Checked)
            {
                string dtStr = dtpBillStDt.Value.ToString("yyyyMMdd");
                startDt = DateTime.ParseExact(dtStr, "yyyyMMdd", null);
            }
            if (ckboxBillEnableEndDt.Checked)
            {
                string dtStr = dtpBillEndDt.Value.ToString("yyyyMMdd");
                endDt = DateTime.ParseExact(dtStr, "yyyyMMdd", null);
            }
            int custId = 0;
            if(cboxBillResellers.SelectedIndex !=-1)
                custId = StringUtil.Obj2Int(cboxBillResellers.SelectedValue);
            bill.CustID = custId;
            string settleFlag = StringUtil.Obj2Str(cboxBillSt.SelectedValue);
            bool? settled;
            if (settleFlag == "true")
                settled = true;
            else if (settleFlag == "false")
                settled = false;
            else
                settled = null;
            List<BilliingVO> list = billingManager.LoadBills(bill, settled, startDt, endDt, billPage);
            dtgvBilling.DataSource = list;

            dgvpgBill.TotalPageNum = billPage.TotalPage;
            dgvpgBill.TotalNum = billPage.TotalNum;
            dgvpgBill.ShowPageInfo();
        }

        private void btnGathering_Click(object sender, EventArgs e)
        {
            if (null == dtgvBilling.CurrentRow)
                return;
            if (cboxBillResellers.SelectedIndex == -1)
                return;
            string billNO = StringUtil.Obj2Str(dtgvBilling.CurrentRow.Cells[colPayBillNO.Name].Value);
            Customer reseller = cboxBillResellers.SelectedItem as Customer;
            PayMntForm pymntForm = new PayMntForm(billNO, reseller, billingManager);
            DialogResult rslt = pymntForm.ShowDialog();
            if (rslt == DialogResult.Cancel)
                btnBillQuery.PerformClick();
        }

        private void ckboxBillEnableStDt_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxBillEnableStDt.Checked)
                dtpBillStDt.Enabled = true;
            else
                dtpBillStDt.Enabled = false;
        }

        private void ckboxBillEnableEndDt_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxBillEnableEndDt.Checked)
                dtpBillEndDt.Enabled = true;
            else
                dtpBillEndDt.Enabled = false;
        }

        private void ckboxQyEnableStDt_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxQyEnableStDt.Checked)
                dtpQyStDt.Enabled = true;
            else
                dtpQyStDt.Enabled = false;
        }

        private void ckboxQyEnableEndDt_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxQyEnableEndDt.Checked)
                dtpQyEndDt.Enabled = true;
            else
                dtpQyEndDt.Enabled = false;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>(selectedOrdrs.Keys);
            decimal total = 0;
            foreach (decimal amount in selectedOrdrs.Values)
            {
                total += amount;
            }
            if (list.Count > 0)
            {
                if (cboxQrdResellers.SelectedIndex == -1)
                    return;
                Customer reseller = cboxQrdResellers.SelectedItem as Customer;
                BilliingVO vo = new BilliingVO();
                vo._OrderNOList = list;
                vo.Amount = total;
                vo.CrtUsrId = MainForm.usr.UId__PK;
                vo.CustID = (int)reseller.CID__PK;
                vo.CustName = reseller.CName;
                vo.Direct = PYMNT_DIRECT.RECEIVE;

                BillCnfrmDialog cnfrmDiaglog = new BillCnfrmDialog(vo, billingManager);
                DialogResult rslt = cnfrmDiaglog.ShowDialog();
                if (rslt == DialogResult.OK)
                {
                    string billNO = billingManager.Entry(vo);
                    if (!StringUtil.isEmpty(billNO))
                    {
                        MainForm.Info("所选订单已入账！ 账单号：" + billNO);
                        dtgvOrders.Rows.Clear();
                    }
                    else
                        MainForm.Warn("入账失败！");
                }
            }
        }

        private void dgvpgBill_pagerBtnClicked(object sender, EventArgs e)
        {
            billPage.PageNo = dgvpgBill.PageNO;
            btnBillQuery.PerformClick();
        }

        private void dgvpgOrder_pagerBtnClicked(object sender, EventArgs e)
        {
            orderPage.PageNo = dgvpgOrder.PageNO;
            btnOrderQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { billingManager , custManager, stockoutManager, refundManager };
        }

        private void dtgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (null == dtgvOrders.CurrentRow)
                return;
            if (cboxBillResellers.SelectedIndex == -1)
                return;
            Customer reseller = cboxBillResellers.SelectedItem as Customer;
            Order order = new Order();
            order.CustName = reseller.CName;
            order.CustID = reseller.CID__PK;

            order.OrderNO__PK = StringUtil.Obj2Str(dtgvOrders.CurrentRow.Cells["colOrderNO"].Value);
            order.Amount = StringUtil.Obj2Decimal(dtgvOrders.CurrentRow.Cells["colAmount"].Value);
            order.Direct = StringUtil.Obj2Str(dtgvOrders.CurrentRow.Cells["colDirect"].Value);

            if (DIRECT.STOCK_OUT == order.Direct)
            {
                if (null == stockoutManager)
                    stockoutManager = InterfaceProxyGenerator.CreateInterfaceProxy<IStockOutManager>(MainForm.usr);
                StockOutOrderDetailForm detailForm = new StockOutOrderDetailForm(order, stockoutManager);
                detailForm.ShowDialog();
            }
            else if (DIRECT.RESELLER_REFUND == order.Direct)
            {
                if (null == refundManager)
                    refundManager = InterfaceProxyGenerator.CreateInterfaceProxy<IResellerRefundManager>(MainForm.usr);
                RefundOrderDetailForm detailForm = new RefundOrderDetailForm(order, refundManager);
                detailForm.ShowDialog();
            }
        }

        private void dtgvBilling_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGathering.PerformClick();
        }
    }
}
