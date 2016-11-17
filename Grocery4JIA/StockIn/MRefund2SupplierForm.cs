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
    public partial class MRefund2SupplierForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        ISubCatgManager subCatgManager;
        IRefund2SupplierManager refundManager;
        IGoodsManager goodsManager;
        PageVO page;

        public MRefund2SupplierForm()
        {
            InitializeComponent();
            dtgvRfGoods.AutoGenerateColumns = false;
            dtgvRfOrders.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);
            if (null == refundManager)
                refundManager = InterfaceProxyGenerator.CreateInterfaceProxy<IRefund2SupplierManager>(usr);
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust, null);

            cboxNSupplier.DisplayMember = "CName";
            cboxNSupplier.ValueMember = "CID__PK";
            cboxNSupplier.DataSource = custs;

            List<Customer> custList = new List<Customer>();
            Customer tmpCust = new Customer();
            tmpCust.CID__PK = 0;
            tmpCust.CName = "--全部--";
            custList.Add(tmpCust);
            custList.AddRange(custs);
            cboxQySupplier.DisplayMember = "CName";
            cboxQySupplier.ValueMember = "CID__PK";
            cboxQySupplier.DataSource = custList;
        }

        private void InitRow(int index, StockGoodsVO goods)
        {
            dtgvRfGoods.Rows[index].Cells[colGID.Name].Value = goods.GID;
            dtgvRfGoods.Rows[index].Cells[colSpecs.Name].Value = goods.Specs;
            dtgvRfGoods.Rows[index].Cells[colInPric.Name].Value = goods.Price;
            dtgvRfGoods.Rows[index].Cells[colInvNum.Name].Value = goods.Num;
            dtgvRfGoods.Rows[index].Cells[colExpDt.Name].Value = goods.ExpDt;
            dtgvRfGoods.Rows[index].Cells[colSInOrderNO.Name].Value = goods.OrderNO;
            dtgvRfGoods.Rows[index].Cells[colInvID.Name].Value = goods.InvID;
            dtgvRfGoods.Rows[index].Cells[colSupplier.Name].Value = goods.CustName;
            dtgvRfGoods.Rows[index].Cells[colNum.Name].Value = goods.Num;
            dtgvRfGoods.Rows[index].Cells[colPrice.Name].Value = goods.Price;
            dtgvRfGoods.Rows[index].Cells[colTgtSID.Name].Value = goods.TgtSID;
            if (goods.GName.IndexOf("[") > 0)
                dtgvRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName.Substring(0, goods.GName.IndexOf("["));
            else
                dtgvRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
        }

        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            StockGoodsVO goodsInStock = autxtGoodsInStock.SelectedObj as StockGoodsVO;
            if (null == goodsInStock)
            {
                if (!StringUtil.isEmpty(autxtGoodsInStock.Term))
                    MainForm.Warn("无此商品！请重新选择！");
                return;
            }
            foreach (DataGridViewRow row in dtgvRfGoods.Rows)
            {
                long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                if (invId == goodsInStock.InvID)
                {
                    MainForm.Warn("此商品已添加，请重新选择！");
                    autxtGoodsInStock.clear();
                    return;
                }
            }
            int index = dtgvRfGoods.Rows.Add();
            InitRow(index, goodsInStock);
            autxtGoodsInStock.clear();
        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            if (cboxNSupplier.SelectedIndex == -1)
                return;
            Customer supplier = cboxNSupplier.SelectedItem as Customer;
            GoodsInStockForm goodsInFrom = new GoodsInStockForm(supplier, DIRECT.REFUND2SUPPLIER);
            DialogResult rslt = goodsInFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<long> addedGoods = GenAddedGoods();
                List<StockGoodsVO> goodsList = goodsInFrom.GoodsList;
                foreach (StockGoodsVO vo in goodsList)
                {
                    if (addedGoods.Contains(vo.InvID))
                        continue;
                    int index = dtgvRfGoods.Rows.Add();
                    InitRow(index, vo);
                }
            }
        }

        private void dtgvRfGoods_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl cellEditor = e.Control as DataGridViewTextBoxEditingControl;
            cellEditor.SelectAll();
            cellEditor.KeyPress += dtgvRfGoods_Cell_KeyPress;
        }


        private void dtgvRfGoods_Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtgvRfGoods.CurrentRow.Index < 0)
                return;
            int colIndex = dtgvRfGoods.CurrentCell.ColumnIndex;
            if (dtgvRfGoods.Columns[colIndex].Name == colNum.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                    e.Handled = true;
                if (keyVal >= 48 && keyVal <= 57)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (!StringUtil.isEmpty(srCellEditor.Text))
                    {
                        int invNum = StringUtil.Obj2Int(dtgvRfGoods.CurrentRow.Cells[colInvNum.Name].Value);
                        if (int.Parse(srCellEditor.Text + e.KeyChar) > invNum)
                            e.Handled = true;
                    }
                    else
                    {
                        if (keyVal == 48)
                            e.Handled = true;
                    }
                }
            }
            else if (dtgvRfGoods.Columns[colIndex].Name == colPrice.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13 && keyVal != 46)
                    e.Handled = true;
                if ((keyVal >= 48 && keyVal <= 57) || keyVal == 46)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (StringUtil.isEmpty(srCellEditor.Text))
                    {
                        if (keyVal == 46)
                            e.Handled = true;
                    }
                    else
                    {
                        if (keyVal != 46)
                        {
                            if (srCellEditor.Text == "0" && e.KeyChar == '0')
                                e.Handled = true;
                        }
                    }
                }
            }
        }

        private void dtgvRfGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvRfGoods.CurrentRow.Index < 0)
                return;
            if (dtgvRfGoods.Columns[e.ColumnIndex].Name == colPrice.Name)
            {
                object price = dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != price)
                {
                    if (price.ToString().EndsWith("."))
                        price = price + "0";
                    else if (price.ToString().StartsWith("."))
                        price = "0" + price;

                    try
                    {
                        price = decimal.Parse(price.ToString());
                        decimal inPrice = StringUtil.Obj2Decimal(dtgvRfGoods.CurrentRow.Cells[colInPric.Name].Value);
                        if ((decimal)price > inPrice)
                            dtgvRfGoods.CurrentRow.Cells[colPrice.Name].Style.BackColor = System.Drawing.Color.Red;
                        else
                            dtgvRfGoods.CurrentRow.Cells[colPrice.Name].Style.BackColor = System.Drawing.Color.White;
                    }
                    catch
                    {
                        price = null;
                    }
                    dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                }
            }
            else if (dtgvRfGoods.Columns[e.ColumnIndex].Name == colNum.Name)
            {
                object num = dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != num)
                {
                    try
                    {
                        num = int.Parse(num.ToString());
                    }
                    catch
                    {
                        num = null;
                    }
                    dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = num;
                }
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            RefundOrderVO refundVO = null;
            List<Refund> list = new List<Refund>();
            List<OrderGoodsVO> glist = new List<OrderGoodsVO>();
            if (cboxNSupplier.SelectedIndex == -1)
                return;
            foreach (DataGridViewRow row in dtgvRfGoods.Rows)
            {
                object numObj = row.Cells[colNum.Name].Value;
                object priceObj = row.Cells[colPrice.Name].Value;
                if (null == numObj || null == priceObj)
                    continue;
                Refund rf = new Refund();
                rf.Direct = DIRECT.REFUND2SUPPLIER;
                rf.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                rf.Num = StringUtil.Obj2Int(numObj);
                rf.Price = StringUtil.Obj2Decimal(priceObj);
                rf.TgtSID = StringUtil.Obj2Long(row.Cells[colTgtSID.Name].Value);
                if (rf.Num * rf.Price == 0)
                    continue;
                list.Add(rf);

                OrderGoodsVO vo = new OrderGoodsVO();
                vo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                vo.Num = (int)rf.Num;
                vo.Price = (int)rf.Price;
                vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                glist.Add(vo);
            }
            if (list.Count < 1)
                return;
            Customer supplier = cboxNSupplier.SelectedItem as Customer;
            OrderCnfrmDialog cnfrmDialog = new OrderCnfrmDialog("【退货单-明细】 " + supplier.CName, glist);
            DialogResult rslt = cnfrmDialog.ShowDialog();
            if (DialogResult.OK != rslt)
                return;

            refundVO = new RefundOrderVO();
            refundVO.CustID = supplier.CID__PK;
            refundVO.CustName = supplier.CName;
            refundVO.Direct = DIRECT.REFUND2SUPPLIER;
            refundVO.UptUID = MainForm.usr.UId__PK;
            refundVO.CrtUID = MainForm.usr.UId__PK;
            refundVO._RefundList = list;

            string orderNO = refundManager.Refund(refundVO);
            if (!StringUtil.isEmpty(orderNO))
            {
                MainForm.Info("商品已退回！退单号：" + orderNO);
                dtgvRfGoods.Rows.Clear();
            }
            else
                MainForm.Warn("商品退回失败！");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvRfGoods.SelectedRows)
            {
                dtgvRfGoods.Rows.Remove(row);
            }
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            DateTime? startDt = null;
            DateTime? endDt = null;
            Order order = new Order();
            order.Direct = DIRECT.REFUND2SUPPLIER;
            if (cboxQySupplier.SelectedIndex == -1)
                return;
            if (!StringUtil.isEmpty(txtQyOrderNO.Text))
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
            int custId = StringUtil.Obj2Int(cboxQySupplier.SelectedValue);
            order.CustID = custId;
            List<OrderVO> list = refundManager.LoadOrders(order, startDt, endDt, page);
            dtgvRfOrders.DataSource = list;

            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.TotalNum = page.TotalNum;
            dgvPager.ShowPageInfo();
        }

        private void dtgvRfOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvRfOrders.CurrentRow;
            if (null != curRow)
            {
                Order order = new Order();
                order.Direct = DIRECT.REFUND2SUPPLIER;
                order.Amount = StringUtil.Obj2Decimal(curRow.Cells[colAmount.Name].Value);
                order.OrderNO__PK = StringUtil.Obj2Str(curRow.Cells[colOrderNO.Name].Value);
                order.CustName = StringUtil.Obj2Str(curRow.Cells[colQySupplier.Name].Value);

                RefundOrderDetailForm detailForm = new RefundOrderDetailForm(order, refundManager);
                detailForm.ShowDialog();
            }
        }

        private void ckboxQyEnableStDt_Click(object sender, EventArgs e)
        {
            if (ckboxQyEnableStDt.Checked)
                dtpQyStDt.Enabled = true;
            else
                dtpQyStDt.Enabled = false;
        }

        private void ckboxQyEnableEndDt_Click(object sender, EventArgs e)
        {
            if (ckboxQyEnableEndDt.Checked)
                dtpQyEndDt.Enabled = true;
            else
                dtpQyEndDt.Enabled = false;
        }

        private List<long> GenAddedGoods()
        {
            List<long> addedGoods = new List<long>();
            foreach (DataGridViewRow row in dtgvRfGoods.Rows)
            {
                long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                addedGoods.Add(invId);
            }
            return addedGoods;
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnOrderQuery.PerformClick();
        }

        private void cboxNSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvRfGoods.Rows.Clear();
            autxtGoodsInStock.clear();
        }

        private void autxtGoodsInStock_loadData(object sender, EventArgs e)
        {
            string term = autxtGoodsInStock.Term;
            
            List<auto_text.AutoData> data = new List<auto_text.AutoData>();
            if (term.Trim().Length > 0)
            {
                if (cboxNSupplier.SelectedIndex == -1)
                    return;
                Customer supplier = cboxNSupplier.SelectedItem as Customer;
                List<long> addedGoods = GenAddedGoods();
                List<StockGoodsVO> list = goodsManager.LoadInStockGoodsByKeyWords(term.Trim(), supplier.CID__PK);
                foreach (StockGoodsVO vo in list)
                {
                    if (addedGoods.Contains(vo.InvID))
                        continue;
                    auto_text.AutoData adata = new auto_text.AutoData();
                    adata.Text = vo.GName + " [" + vo.Specs + "]";
                    adata.Val = vo;
                    data.Add(adata);
                }
            }
            autxtGoodsInStock.Data = data;
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { subCatgManager, refundManager, custManager, goodsManager};
        }
    }
}
