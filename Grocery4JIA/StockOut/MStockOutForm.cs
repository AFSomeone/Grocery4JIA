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
    public partial class MStockOutForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        IGoodsManager goodsManager;
        IStockOutManager stockOutManager;
        PageVO page;
        public MStockOutForm()
        {
            InitializeComponent();
            dtgvSOutGoods.AutoGenerateColumns = false;
            dtgvMOutOrders.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);
            if (null == stockOutManager)
                stockOutManager = InterfaceProxyGenerator.CreateInterfaceProxy<IStockOutManager>(usr);

            Customer cust = new Customer();
            cust.Grade = GRADE.RESELLER;
            cust.St = ST.VALID;
            List<Customer> resellers = custManager.LoadData(cust,null);

            cboxNResellers.DisplayMember = "CName";
            cboxNResellers.ValueMember = "CID__PK";
            cboxNResellers.DataSource = resellers;

            List<Customer> qyResellers = new List<Customer>();
            Customer reseller = new Customer();
            reseller.CID__PK = 0;
            reseller.CName = "--全部--";
            qyResellers.Add(reseller);
            qyResellers.AddRange(resellers);

            cboxQyReseller.DisplayMember = "CName";
            cboxQyReseller.ValueMember = "CID__PK";
            cboxQyReseller.DataSource = qyResellers;
        }

        private void InitRow(int index, StockGoodsVO goods)
        {
            dtgvSOutGoods.Rows[index].Cells[colGID.Name].Value = goods.GID;
            dtgvSOutGoods.Rows[index].Cells[colSpecs.Name].Value = goods.Specs;
            dtgvSOutGoods.Rows[index].Cells[colInPric.Name].Value = goods.Price;
            dtgvSOutGoods.Rows[index].Cells[colInvNum.Name].Value = goods.Num;
            dtgvSOutGoods.Rows[index].Cells[colExpDt.Name].Value = goods.ExpDt;
            dtgvSOutGoods.Rows[index].Cells[colSInOrderNO.Name].Value = goods.OrderNO;
            dtgvSOutGoods.Rows[index].Cells[colInvID.Name].Value = goods.InvID;
            dtgvSOutGoods.Rows[index].Cells[colSupplier.Name].Value = goods.CustName;
            if (goods.GName.IndexOf("[") > 0)
                dtgvSOutGoods.Rows[index].Cells[colGName.Name].Value = goods.GName.Substring(0, goods.GName.IndexOf("["));
            else
                dtgvSOutGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StockOutOrderVO orderVO = null;
            List<StockOut> soutList = new List<StockOut>();
            List<OrderGoodsVO> glist = new List<OrderGoodsVO>();
            if (cboxNResellers.SelectedIndex == -1)
                return;
            foreach (DataGridViewRow row in dtgvSOutGoods.Rows)
            {
                object numObj = row.Cells[colNum.Name].Value;
                object priceObj = row.Cells[colPrice.Name].Value;
                if (null == numObj || null == priceObj)
                    continue;
                StockOut sout = new StockOut();
                sout.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                sout.Num = StringUtil.Obj2Int(numObj);
                sout.Price = StringUtil.Obj2Decimal(priceObj);
                if (sout.Num * sout.Price == 0)
                    continue;
                soutList.Add(sout);

                OrderGoodsVO vo = new OrderGoodsVO();
                vo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                vo.Num = (int)sout.Num;
                vo.Price = (decimal)sout.Price;
                vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                glist.Add(vo);
            }
            if (soutList.Count < 1)
                return;
            Customer reseller = cboxNResellers.SelectedItem as Customer;
            OrderCnfrmDialog cnfrmDialog = new OrderCnfrmDialog("【出货单-明细】 "+reseller.CName, glist);
            DialogResult rslt = cnfrmDialog.ShowDialog();
            if (DialogResult.OK != rslt)
                return;

            orderVO = new StockOutOrderVO();
            orderVO.Direct = DIRECT.STOCK_OUT;
            orderVO._StockOutList = soutList;
            orderVO.CustID = reseller.CID__PK;
            orderVO.CustName = reseller.CName;
            Usr lgnUsr = MainForm.usr;
            orderVO.CrtUID = lgnUsr.UId__PK;
            orderVO.UptUID = lgnUsr.UId__PK;

            string orderNO = stockOutManager.StockOut(orderVO);
            if (!StringUtil.isEmpty(orderNO))
            {
                MainForm.Info("出货单创建成功！ 单号："+orderNO);
                dtgvSOutGoods.Rows.Clear();
            }
            else
                MainForm.Warn("出货单创建失败！");
        }

        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            if (null == autxtGoodsInStock.SelectedObj)
            {
                if (!StringUtil.isEmpty(autxtGoodsInStock.Term))
                    MainForm.Warn("无此商品！请重新选择！");
                autxtGoodsInStock.clear();
                return;
            }

            StockGoodsVO goodsInStock = autxtGoodsInStock.SelectedObj as StockGoodsVO;
            foreach (DataGridViewRow row in dtgvSOutGoods.Rows)
            {
                long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                if (invId == goodsInStock.InvID)
                {
                    MainForm.Warn("此商品已添加，请重新选择！");
                    autxtGoodsInStock.clear();
                    return;
                }
            }
            int index = dtgvSOutGoods.Rows.Add();
            InitRow(index, goodsInStock);
            autxtGoodsInStock.clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSOutGoods.SelectedRows)
            {
                dtgvSOutGoods.Rows.Remove(row);
            }
        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            if (cboxNResellers.SelectedIndex == -1)
                return;
            Customer reseller = cboxNResellers.SelectedItem as Customer;
            GoodsInStockForm goodsInFrom = new GoodsInStockForm(reseller, DIRECT.STOCK_OUT);
            DialogResult rslt = goodsInFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<long> addedGoods = GenAddedGoods();
                List<StockGoodsVO> goodsList = goodsInFrom.GoodsList;
                foreach (StockGoodsVO vo in goodsList)
                {
                    if (addedGoods.Contains(vo.InvID))
                        continue;
                    int index = dtgvSOutGoods.Rows.Add();
                    InitRow(index, vo);
                }
            }
        }

        private void dtgvSOutGoods_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl cellEditor = e.Control as DataGridViewTextBoxEditingControl;
            cellEditor.SelectAll();
            cellEditor.KeyPress += dtgvSOutGoods_Cell_KeyPress;
        }


        private void dtgvSOutGoods_Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtgvSOutGoods.CurrentRow.Index < 0)
                return;
            int colIndex = dtgvSOutGoods.CurrentCell.ColumnIndex;
            if (dtgvSOutGoods.Columns[colIndex].Name == colNum.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                    e.Handled = true;
                if (keyVal >= 48 && keyVal <= 57)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (!StringUtil.isEmpty(srCellEditor.Text))
                    {
                        int invNum = StringUtil.Obj2Int(dtgvSOutGoods.CurrentRow.Cells[colInvNum.Name].Value);
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
            else if (dtgvSOutGoods.Columns[colIndex].Name == colPrice.Name)
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

        private void dtgvSOutGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSOutGoods.CurrentRow.Index < 0)
                return;
            if (dtgvSOutGoods.Columns[e.ColumnIndex].Name == colPrice.Name)
            {
                object price = dtgvSOutGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != price)
                {
                    if (price.ToString().EndsWith("."))
                    {
                        price = price + "0";
                        dtgvSOutGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                    }
                    if (price.ToString().StartsWith("."))
                    {
                        price = "0" + price;
                        dtgvSOutGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                    }
                }
            }
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            DateTime? startDt = null;
            DateTime? endDt = null;
            Order order = new Order();
            order.Direct = DIRECT.STOCK_OUT;
            if (cboxQyReseller.SelectedIndex == -1)
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
            int custId = StringUtil.Obj2Int(cboxQyReseller.SelectedValue);
            if (custId != 0)
                order.CustID = custId;
            List<OrderVO> list = stockOutManager.LoadOrders(order, startDt, endDt, page);
            dtgvMOutOrders.DataSource = list;

            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.TotalNum = page.TotalNum;
            dgvPager.ShowPageInfo();
        }

        private void ckboxQyEnableStDt_Click(object sender, EventArgs e)
        {
            if (ckboxQyEnableStDt.Checked)
                dtpQyStDt.Enabled = true;
            else
                dtpQyStDt.Enabled = false;
        }

        private void ckboxEnableEndDt_Click(object sender, EventArgs e)
        {
            if (ckboxQyEnableEndDt.Checked)
                dtpQyEndDt.Enabled = true;
            else
                dtpQyEndDt.Enabled = false;
        }

        private void dtgvMOutOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvMOutOrders.CurrentRow;
            if (null != curRow)
            {
                Order order = new Order();
                order.Amount = StringUtil.Obj2Decimal(curRow.Cells[colAmount.Name].Value);
                order.OrderNO__PK = StringUtil.Obj2Str(curRow.Cells[colOrderNO.Name].Value);
                order.CustName = StringUtil.Obj2Str(curRow.Cells[colReseller.Name].Value);

                StockOutOrderDetailForm detailForm = new StockOutOrderDetailForm(order, stockOutManager);
                detailForm.ShowDialog();
            }
        }

        private List<long> GenAddedGoods()
        {
            List<long> addedGoods = new List<long>();
            foreach (DataGridViewRow row in dtgvSOutGoods.Rows)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (null == dtgvMOutOrders.CurrentRow)
                return;
            string orderNo = StringUtil.Obj2Str(dtgvMOutOrders.CurrentRow.Cells["colOrderNO"].Value);
            OrderPrinterForm pform = new OrderPrinterForm(orderNo);
            pform.ShowDialog();
        }

        private void autxtGoodsInStock_loadData(object sender, EventArgs e)
        {
            string term = autxtGoodsInStock.Term;

            List<auto_text.AutoData> data = new List<auto_text.AutoData>();
            if (term.Trim().Length > 0)
            {
                List<long> addedGoods = GenAddedGoods();
                List<StockGoodsVO> list = goodsManager.LoadInStockGoodsByKeyWords(term.Trim());

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
            return new List<IBaseManager>() { custManager, goodsManager, stockOutManager };
        }
    }
}
