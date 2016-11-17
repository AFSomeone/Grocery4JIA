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
    public partial class MResellerRefundForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        IGoodsManager goodsManager;
        IResellerRefundManager refundManager;
        PageVO page;
        public MResellerRefundForm()
        {
            InitializeComponent();
            dtgvResellerRfGoods.AutoGenerateColumns = false;
            dtgvResellerRfOrders.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);
            if (null == refundManager)
                refundManager = InterfaceProxyGenerator.CreateInterfaceProxy<IResellerRefundManager>(usr);
            Customer cust = new Customer();
            cust.Grade = GRADE.RESELLER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust, null);

            cboxNReseller.DisplayMember = "CName";
            cboxNReseller.ValueMember = "CID__PK";
            cboxNReseller.DataSource = custs;

            List<Customer> custList = new List<Customer>();
            Customer tmpCust = new Customer();
            tmpCust.CID__PK = 0;
            tmpCust.CName = "--全部--";
            custList.Add(tmpCust);
            custList.AddRange(custs);
            cboxQyReseller.DisplayMember = "CName";
            cboxQyReseller.ValueMember = "CID__PK";
            cboxQyReseller.DataSource = custList;

        }

        private void InitRow(int index, StockGoodsVO goods)
        {
            dtgvResellerRfGoods.Rows[index].Cells[colGID.Name].Value = goods.GID;
            dtgvResellerRfGoods.Rows[index].Cells[colSpecs.Name].Value = goods.Specs;
            dtgvResellerRfGoods.Rows[index].Cells[colSalePrice.Name].Value = goods.Price;
            dtgvResellerRfGoods.Rows[index].Cells[colSoldNum.Name].Value = goods.Num;
            dtgvResellerRfGoods.Rows[index].Cells[colExpDt.Name].Value = goods.ExpDt;
            dtgvResellerRfGoods.Rows[index].Cells[colSOutOrderNO.Name].Value = goods.OrderNO;
            dtgvResellerRfGoods.Rows[index].Cells[colInvID.Name].Value = goods.InvID;
            dtgvResellerRfGoods.Rows[index].Cells[colReseller.Name].Value = goods.CustName;
            dtgvResellerRfGoods.Rows[index].Cells[colNum.Name].Value = goods.Num-goods.RfNum;
            dtgvResellerRfGoods.Rows[index].Cells[colRfNum.Name].Value = goods.RfNum;
            dtgvResellerRfGoods.Rows[index].Cells[colPrice.Name].Value = goods.Price;
            dtgvResellerRfGoods.Rows[index].Cells[colTgtSID.Name].Value = goods.TgtSID;
            if (goods.GName.IndexOf("[") > 0)
                dtgvResellerRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName.Substring(0, goods.GName.IndexOf("["));
            else
                dtgvResellerRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
            
        }

        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            StockGoodsVO soldGoods = autxtSodGoods.SelectedObj as StockGoodsVO;
            if (null == soldGoods)
            {
                if (!StringUtil.isEmpty(autxtSodGoods.Term))
                    MainForm.Warn("无此商品！请重新选择！");
                return;
            }
            foreach (DataGridViewRow row in dtgvResellerRfGoods.Rows)
            {
                object gId = row.Cells[colGID.Name].Value;
                string ordrNO = StringUtil.Obj2Str(row.Cells[colSOutOrderNO.Name].Value);
                if (gId+""+ordrNO == soldGoods.GID+""+soldGoods.OrderNO)
                {
                    MainForm.Warn("此商品已添加，请重新选择！");
                    autxtSodGoods.clear();
                    return;
                }
            }
            int index = dtgvResellerRfGoods.Rows.Add();
            InitRow(index, soldGoods);
            autxtSodGoods.clear();
        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            if (cboxNReseller.SelectedIndex == -1)
                return;
            Customer reseller = cboxNReseller.SelectedItem as Customer;
            SoldGoodsForm goodsInFrom = new SoldGoodsForm(reseller);
            DialogResult rslt = goodsInFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<string> addedGoods = GenAddedGoods();
                List<StockGoodsVO> goodsList = goodsInFrom.GoodsList;
                foreach (StockGoodsVO vo in goodsList)
                {
                    if (addedGoods.Contains(vo.GID+""+vo.OrderNO))
                        continue;
                    int index = dtgvResellerRfGoods.Rows.Add();
                    InitRow(index, vo);
                }
            }
        }

        private void dtgvResellerRfGoods_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl cellEditor = e.Control as DataGridViewTextBoxEditingControl;
            cellEditor.SelectAll();
            cellEditor.KeyPress += dtgvResellerRfGoods_Cell_KeyPress;
        }


        private void dtgvResellerRfGoods_Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtgvResellerRfGoods.CurrentRow.Index < 0)
                return;
            int colIndex = dtgvResellerRfGoods.CurrentCell.ColumnIndex;
            if (dtgvResellerRfGoods.Columns[colIndex].Name == colNum.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                    e.Handled = true;
                if (keyVal >= 48 && keyVal <= 57)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (!StringUtil.isEmpty(srCellEditor.Text))
                    {
                        int soldNum = StringUtil.Obj2Int(dtgvResellerRfGoods.CurrentRow.Cells[colSoldNum.Name].Value);
                        if (int.Parse(srCellEditor.Text + e.KeyChar) > soldNum)
                            e.Handled = true;
                    }
                    else
                    {
                        if (keyVal == 48)
                            e.Handled = true;
                    }
                }
            }
            else if (dtgvResellerRfGoods.Columns[colIndex].Name == colPrice.Name)
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

        private void dtgvResellerRfGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvResellerRfGoods.CurrentRow.Index < 0)
                return;
            if (dtgvResellerRfGoods.Columns[e.ColumnIndex].Name == colPrice.Name)
            {
                object price = dtgvResellerRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != price)
                {
                    if (price.ToString().EndsWith("."))
                        price = price + "0";
                    else if (price.ToString().StartsWith("."))
                        price = "0" + price;

                    try
                    {
                        price = decimal.Parse(price.ToString());
                        decimal salePrice = StringUtil.Obj2Decimal(dtgvResellerRfGoods.CurrentRow.Cells[colSalePrice.Name].Value);
                        if ((decimal)price > salePrice)
                            dtgvResellerRfGoods.CurrentRow.Cells[colPrice.Name].Style.BackColor = System.Drawing.Color.Red;
                        else
                            dtgvResellerRfGoods.CurrentRow.Cells[colPrice.Name].Style.BackColor = System.Drawing.Color.White;
                    }
                    catch
                    {
                        price = null;
                    }
                    dtgvResellerRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                }
            }
            else if (dtgvResellerRfGoods.Columns[e.ColumnIndex].Name == colNum.Name)
            {
                object num = dtgvResellerRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != num)
                {
                    try
                    {
                        num = int.Parse(num.ToString());
                        int soldNum = StringUtil.Obj2Int(dtgvResellerRfGoods.CurrentRow.Cells[colSoldNum.Name].Value);
                        int rfNum = StringUtil.Obj2Int(dtgvResellerRfGoods.CurrentRow.Cells[colRfNum.Name].Value);

                        if ((int)num > (soldNum-rfNum))
                            num = null;
                    }
                    catch
                    {
                        num = null;
                    }
                    dtgvResellerRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = num;
                }
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            RefundOrderVO refundVO = null;
            List<Refund> list = new List<Refund>();
            List<OrderGoodsVO> glist = new List<OrderGoodsVO>();
            if (cboxNReseller.SelectedIndex == -1)
                return;
            foreach (DataGridViewRow row in dtgvResellerRfGoods.Rows)
            {
                object numObj = row.Cells[colNum.Name].Value;
                object priceObj = row.Cells[colPrice.Name].Value;
                if (null == numObj || null == priceObj)
                    continue;
                Refund rf = new Refund();
                rf.Direct = DIRECT.RESELLER_REFUND;
                rf.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                rf.TgtSID = StringUtil.Obj2Long(row.Cells[colTgtSID.Name].Value);
                rf.Num = StringUtil.Obj2Int(numObj);
                rf.Price = StringUtil.Obj2Decimal(priceObj);
                if (rf.Num * rf.Price == 0)
                    continue;
                list.Add(rf);

                OrderGoodsVO vo = new OrderGoodsVO();
                vo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                vo.Num = (int)rf.Num;
                vo.Price = (decimal)rf.Price;
                vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                glist.Add(vo);
            }
            if (list.Count < 1)
                return;
            Customer reseller = cboxNReseller.SelectedItem as Customer;
            OrderCnfrmDialog cnfrmDialog = new OrderCnfrmDialog("【回收单-明细】 " + reseller.CName, glist);
            DialogResult rslt = cnfrmDialog.ShowDialog();
            if (DialogResult.OK != rslt)
                return;

            refundVO = new RefundOrderVO();
            refundVO.CustID = reseller.CID__PK;
            refundVO.CustName = reseller.CName;
            refundVO.Direct = DIRECT.RESELLER_REFUND;
            refundVO.UptUID = MainForm.usr.UId__PK;
            refundVO.CrtUID = MainForm.usr.UId__PK;
            refundVO._RefundList = list;

            string orderNO = refundManager.Refund(refundVO);
            if (!StringUtil.isEmpty(orderNO))
            {
                MessageBox.Show("商品已回收！回收单号：" + orderNO, "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvResellerRfGoods.Rows.Clear();
            }
            else
                MessageBox.Show("商品回收失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvResellerRfGoods.SelectedRows)
            {
                dtgvResellerRfGoods.Rows.Remove(row);
            }
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            DateTime? startDt = null;
            DateTime? endDt = null;
            Order order = new Order();
            order.Direct = DIRECT.RESELLER_REFUND;
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
            int custId = 0;
            if(cboxQyReseller.SelectedIndex !=-1)
                custId = StringUtil.Obj2Int(cboxQyReseller.SelectedValue);
            order.CustID = custId;
            List<OrderVO> list = refundManager.LoadOrders(order, startDt, endDt, page);
            dtgvResellerRfOrders.DataSource = list;

            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.TotalNum = page.TotalNum;
            dgvPager.ShowPageInfo();
        }

        private void dtgvResellerRfOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvResellerRfOrders.CurrentRow;
            if (null != curRow)
            {
                Order order = new Order();
                order.Direct = DIRECT.RESELLER_REFUND;
                order.Amount = StringUtil.Obj2Decimal(curRow.Cells[colAmount.Name].Value);
                order.OrderNO__PK = StringUtil.Obj2Str(curRow.Cells[colOrderNO.Name].Value);
                order.CustName = StringUtil.Obj2Str(curRow.Cells[colQyReseller.Name].Value);

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

        /// <summary>
        /// 已添加的商品
        /// </summary>
        /// <returns>gId+orderNO</returns>
        private List<string> GenAddedGoods()
        {
            List<string> addedGoods = new List<string>();
            foreach (DataGridViewRow row in dtgvResellerRfGoods.Rows)
            {
                object gId = row.Cells[colGID.Name].Value;
                string ordrNO = StringUtil.Obj2Str(row.Cells[colSOutOrderNO.Name].Value);
                addedGoods.Add(gId + "" + ordrNO);
            }
            return addedGoods;
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnOrderQuery.PerformClick();
        }

        private void autxtSodGoods_loadData(object sender, EventArgs e)
        {
            string term = autxtSodGoods.Term;

            List<auto_text.AutoData> data = new List<auto_text.AutoData>();
            if (term.Trim().Length > 0)
            {
                if (cboxNReseller.SelectedIndex == -1)
                    return;
                List<string> addedGoods = GenAddedGoods();
                Customer reseller = cboxNReseller.SelectedItem as Customer;
                List<StockGoodsVO> list = goodsManager.LoadSoldGoodsByKeyWords(term.Trim(), reseller.CID__PK);
                foreach (StockGoodsVO vo in list)
                {
                    if (addedGoods.Contains(vo.GID + "" + vo.OrderNO))
                        continue;
                    auto_text.AutoData adata = new auto_text.AutoData();
                    adata.Text = vo.GName + " [" + vo.Specs + " " + vo.OrderNO.Replace(ORDERNO_PREF.STOCK_OUT, "") + "]";
                    adata.Val = vo;
                    data.Add(adata);
                }
            }
            autxtSodGoods.Data = data;
        }

        private void cboxNReseller_SelectedIndexChanged(object sender, EventArgs e)
        {
            autxtSodGoods.clear();
            dtgvResellerRfGoods.Rows.Clear();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { custManager, refundManager ,goodsManager};
        }
    }
}