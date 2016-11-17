using BLL.Com;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class MStockInForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        IGoodsManager goodsManager;
        IStockInManager stockinManager;
        PageVO page;

        public MStockInForm()
        {
            InitializeComponent();
            dtgvStockin.AutoGenerateColumns = false;
            dtgvOrders.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == stockinManager)
                stockinManager = InterfaceProxyGenerator.CreateInterfaceProxy<IStockInManager>(usr);
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust,null);
            cboxNSupplier.DisplayMember = "CName";
            cboxNSupplier.ValueMember = "CID__PK";
            cboxNSupplier.DataSource = custs;

            List<Customer> qyCustList = new List<Customer>();
            cust.CID__PK = 0;
            cust.CName = "--全部--";
            qyCustList.Add(cust);
            qyCustList.AddRange(custs);
            cboxQyCust.DisplayMember = "CName";
            cboxQyCust.ValueMember = "CID__PK";
            cboxQyCust.DataSource = qyCustList;
        }

        private void InitRow(int index, Goods goods)
        {
            dtgvStockin.Rows[index].Cells[colGID.Name].Value = goods.GID__PK;
            dtgvStockin.Rows[index].Cells[colShelfLife.Name].Value = goods.ShelfLife;
            dtgvStockin.Rows[index].Cells[colSpecs.Name].Value = goods.Specs;
            if (goods.GName.IndexOf("[") > 0)
                dtgvStockin.Rows[index].Cells[colGName.Name].Value = goods.GName.Substring(0, goods.GName.IndexOf("["));
            else
                dtgvStockin.Rows[index].Cells[colGName.Name].Value = goods.GName;
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            DateTime? startDt = null;
            DateTime? endDt = null;
            order.Direct = DIRECT.STOCK_IN;
            if (cboxQyCust.SelectedIndex == -1)
                return;
            if (!StringUtil.isEmpty(txtQyOrderNO.Text.Trim()))
                order.OrderNO__PK = txtQyOrderNO.Text.Trim();
            if (ckboxQyEnableStDt.Checked)
            {
                string dtStr = dtpQyStDt.Value.ToString("yyyyMMdd");
                startDt = DateTime.ParseExact(dtStr, "yyyyMMdd",null);
            }
            if (ckboxEnableEndDt.Checked)
            {
                string dtStr = dtpQyEndDt.Value.ToString("yyyyMMdd");
                endDt = DateTime.ParseExact(dtStr, "yyyyMMdd", null);
            }
            int custId = StringUtil.Obj2Int(cboxQyCust.SelectedValue);
            if(custId !=0)
                order.CustID = custId;
            List<OrderVO> list = stockinManager.LoadOrders(order, startDt, endDt, page);
            dtgvOrders.DataSource = list;

            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.TotalNum = page.TotalNum;
            dgvPager.ShowPageInfo();
        }

        private void ckboxEnableDt_Click(object sender, EventArgs e)
        {
            if (ckboxQyEnableStDt.Checked)
                dtpQyStDt.Enabled = true;
            else
                dtpQyStDt.Enabled = false;
        }

        private void ckboxEnableEndDt_Click(object sender, EventArgs e)
        {
            if (ckboxEnableEndDt.Checked)
                dtpQyEndDt.Enabled = true;
            else
                dtpQyEndDt.Enabled = false;
        }

        private void dtgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvOrders.CurrentRow;
            if (null != curRow)
            {
                Order order = new Order();
                order.Amount = StringUtil.Obj2Decimal(curRow.Cells[colAmount.Name].Value);
                order.OrderNO__PK = StringUtil.Obj2Str(curRow.Cells[colOrderNO.Name].Value);
                order.CustName = StringUtil.Obj2Str(curRow.Cells[colCustName.Name].Value);

                StockInOrderDetailForm detailForm = new StockInOrderDetailForm(order, stockinManager);
                detailForm.ShowDialog();
            }
        }

        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            Goods goods = autxtNSupplyGoods.SelectedObj as Goods;
            if (null == goods)
            {
                if (!StringUtil.isEmpty(autxtNSupplyGoods.Term))
                {
                    DialogResult rslt = MessageBox.Show("无此商品！是否新增？", "操作结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rslt == DialogResult.OK)
                    {
                        Usr usr = MainForm.usr;
                        GoodsForm gForm = new GoodsForm(null, goodsManager, InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr));
                        gForm.ShowDialog();
                    }
                }
                return;
            }
            foreach (DataGridViewRow row in dtgvStockin.Rows)
            {
                long gId = StringUtil.Obj2Long(row.Cells[colGID.Name].Value);
                if (gId == goods.GID__PK)
                {
                    MainForm.Warn("此商品已添加，请重新选择！");
                    autxtNSupplyGoods.clear();
                    return;
                }
            }
            int index = dtgvStockin.Rows.Add();
            InitRow(index, goods);
            autxtNSupplyGoods.clear();
        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            if (cboxNSupplier.SelectedIndex == -1)
                return;
            Customer supplier = cboxNSupplier.SelectedItem as Customer;
            SupplyGoodsForm goodsFrom = new SupplyGoodsForm(supplier);
            DialogResult rslt = goodsFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<int> addedGoods = GenAddedGoods();
                List<Goods> goodsList = goodsFrom.GoodsList;
                foreach (Goods gd in goodsList)
                {
                    if (addedGoods.Contains((int)gd.GID__PK))
                        continue;
                    int index = dtgvStockin.Rows.Add();
                    InitRow(index, gd);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StockInOrderVO orderVO = null;
            List<StockIn> list = new List<StockIn>();
            List<OrderGoodsVO> glist = new List<OrderGoodsVO>();
            if (cboxNSupplier.SelectedIndex == -1)
                return;
            foreach (DataGridViewRow row in dtgvStockin.Rows)
            {
                object numObj = row.Cells[colNum.Name].Value;
                object priceObj = row.Cells[colPrice.Name].Value;
                if (null == numObj || null == priceObj)
                    continue;

                StockIn sin = new StockIn();
                sin.Num = StringUtil.Obj2Int(row.Cells[colNum.Name].Value);
                sin.Price = StringUtil.Obj2Decimal(row.Cells[colPrice.Name].Value);
                sin.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                if (sin.Num * sin.Price == 0)
                    continue;
                if (!StringUtil.isEmpty(row.Cells[colMfDt.Name].Value + ""))
                {
                    DateTime? expDt = null;
                    DateTime mfDt = DateTime.ParseExact(StringUtil.Obj2Str(row.Cells[colMfDt.Name].Value), "yyyy/MM/dd", null);
                    string shelfLifeStr = StringUtil.Obj2Str(row.Cells[colShelfLife.Name].Value);
                    string num = shelfLifeStr.Substring(0, shelfLifeStr.Length - 1);
                    string term = shelfLifeStr.Substring(shelfLifeStr.Length - 1);
                    if (term == TERM.DAY)
                        expDt = mfDt.AddDays(int.Parse(num));
                    else if (term == TERM.MONTH)
                        expDt = mfDt.AddMonths(int.Parse(num));
                    else if (term == TERM.YEAR)
                        expDt = mfDt.AddYears(int.Parse(num));
                    sin.ExpDt = expDt;
                    sin.MfDt = mfDt;
                }
                list.Add(sin);

                OrderGoodsVO vo = new OrderGoodsVO();
                vo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                vo.Num = (int)sin.Num;
                vo.Price = (decimal)sin.Price;
                vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                glist.Add(vo);
            }
            if (list.Count < 1)
                return;
            Customer supplier = cboxNSupplier.SelectedItem as Customer;
            OrderCnfrmDialog cnfrmDialog = new OrderCnfrmDialog("【进货单-明细】 " + supplier.CName, glist);
            DialogResult rslt = cnfrmDialog.ShowDialog();
            if (DialogResult.OK != rslt)
                return;

            orderVO = new StockInOrderVO();
            orderVO.CustID = supplier.CID__PK;
            orderVO.CustName = supplier.CName;
            orderVO.Direct = DIRECT.STOCK_IN;
            orderVO.UptUID = MainForm.usr.UId__PK;
            orderVO.CrtUID = MainForm.usr.UId__PK;
            orderVO._StockinList = list;

            string orderNO = stockinManager.Stockin(orderVO);
            if (!StringUtil.isEmpty(orderNO))
            {
                MessageBox.Show("进货单创建成功！ 单号：" + orderNO, "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvStockin.Rows.Clear();
            }
            else
                MessageBox.Show("进货单创建失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvStockin.SelectedRows)
            {
                dtgvStockin.Rows.Remove(row);
            }
        }

        private void dtgvStockin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            if (mthcdrMfDt.Visible)
                return;
            if (dtgvStockin.Columns[e.ColumnIndex].Name == colMfDt.Name)
            {
                Rectangle rec = dtgvStockin.GetCellDisplayRectangle(dtgvStockin.CurrentCell.ColumnIndex, dtgvStockin.CurrentCell.RowIndex, false);
                int x = dtgvStockin.Location.X + rec.X;
                int y = dtgvStockin.Location.Y + rec.Height + rec.Y;
                mthcdrMfDt.Location = new Point(x, y);
                mthcdrMfDt.Visible = true;
            }
        }

        private void dtgvStockin_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (mthcdrMfDt.Focused)
                return;
            if (mthcdrMfDt.Visible)
                mthcdrMfDt.Visible = false;
        }

        private void mthcdrMfDt_DateSelected(object sender, DateRangeEventArgs e)
        {
            string dtStr = mthcdrMfDt.SelectionStart.ToString("yyyy/MM/dd");
            dtgvStockin.CurrentCell.Value = dtStr;
            mthcdrMfDt.Visible = false;
        }

        private void dtgvStockin_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgvStockin.ColumnHeadersVisible == true && e.Y <= dtgvStockin.ColumnHeadersHeight)
            {
                if (mthcdrMfDt.Visible)
                    mthcdrMfDt.Visible = false;
                return;
            }
            int index = dtgvStockin.FirstDisplayedScrollingRowIndex;
            int displayedCount = dtgvStockin.DisplayedRowCount(true);
            for (int i = 1; i <= displayedCount;)
            {
                if (dtgvStockin.Rows[index].Visible == true)
                {
                    Rectangle rect = dtgvStockin.GetRowDisplayRectangle(index, true);
                    if (rect.Top <= e.Y && e.Y < rect.Bottom)
                        return;
                    i++;
                }
                index++;
            }
            if (mthcdrMfDt.Visible)
                mthcdrMfDt.Visible = false;
        }

        private void tabSinOrders_Click(object sender, EventArgs e)
        {
            if (mthcdrMfDt.Visible)
                mthcdrMfDt.Visible = false;
        }

        private void tabpgStockin_Click(object sender, EventArgs e)
        {
            if (mthcdrMfDt.Visible)
                mthcdrMfDt.Visible = false;
        }

        private void dtgvStockin_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl cellEditor = e.Control as DataGridViewTextBoxEditingControl;
            cellEditor.SelectAll();
            cellEditor.KeyPress += dtgvStockin_Cell_KeyPress;
        }

        private void dtgvStockin_Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtgvStockin.CurrentRow.Index < 0)
                return;
            int colIndex = dtgvStockin.CurrentCell.ColumnIndex;
            if (dtgvStockin.Columns[colIndex].Name == colNum.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                    e.Handled = true;
                if (keyVal >= 48 && keyVal <= 57)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (StringUtil.isEmpty(srCellEditor.Text))
                    {
                        if (keyVal == 48)
                            e.Handled = true;
                    }
                }
            }
            else if (dtgvStockin.Columns[colIndex].Name == colPrice.Name)
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
                        else
                        {
                            if (srCellEditor.Text.Contains(e.KeyChar.ToString()))
                                e.Handled = true;
                        }
                    }
                }
            }
        }

        private void dtgvStockin_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvStockin.CurrentRow.Index < 0)
                return;
            if (dtgvStockin.Columns[e.ColumnIndex].Name == colPrice.Name)
            {
                object price = dtgvStockin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != price)
                {
                    if (price.ToString().EndsWith("."))
                        price = price + "0";
                        
                    else if (price.ToString().StartsWith("."))
                        price = "0" + price;
                    
                    try
                    {
                        price = decimal.Parse(price.ToString());
                    }
                    catch
                    {
                        price = null;
                    }
                    dtgvStockin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                }
            }
            else if (dtgvStockin.Columns[e.ColumnIndex].Name == colNum.Name)
            {
                object num = dtgvStockin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
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
                    dtgvStockin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = num;
                }
            }
        }

        private List<int> GenAddedGoods()
        {
            List<int> addedGoods = new List<int>();
            foreach (DataGridViewRow row in dtgvStockin.Rows)
            {
                int gid = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                addedGoods.Add(gid);
            }
            return addedGoods;
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnOrderQuery.PerformClick();
        }

        private void autxtNSupplyGoods_loadData(object sender, EventArgs e)
        {
            string term = autxtNSupplyGoods.Term;

            List<auto_text.AutoData> data = new List<auto_text.AutoData>();
            if (term.Trim().Length > 0)
            {
                if (cboxNSupplier.SelectedIndex == -1)
                    return;
                Customer supplier = cboxNSupplier.SelectedItem as Customer;
                List<int> addedGoods = GenAddedGoods();
                List<Goods> list = goodsManager.LoadDataByKeyWords(term.Trim(), supplier.CID__PK);
                foreach (Goods goods in list)
                {
                    if (addedGoods.Contains((int)goods.GID__PK))
                        continue;
                    auto_text.AutoData adata = new auto_text.AutoData();
                    adata.Text = goods.GName + " [" + goods.Specs + "]";
                    adata.Val = goods;
                    data.Add(adata);
                }
            }
            autxtNSupplyGoods.Data = data;
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { custManager, goodsManager, stockinManager };
        }
    }
}
