using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class MStockinForm : Form
    {
        CustomerManager custManager;
        GoodsManager goodsManager;
        StockInManager stockinManager;
        Goods goods;
        public MStockinForm()
        {
            InitializeComponent();
            dtgvStockin.AutoGenerateColumns = false;
            dtgvOrders.AutoGenerateColumns = false;
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == stockinManager)
                stockinManager = new StockInManager();
            if (null == goodsManager)
                goodsManager = new GoodsManager();

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust);
            cboxNSupplier.DisplayMember = "CName";
            cboxNSupplier.ValueMember = "CID__PK";
            cboxNSupplier.DataSource = custs;

            List<Customer> qyCustList = new List<Customer>();
            cust.CID__PK = 0;
            cust.CName = "---选择---";
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
            if (!StringUtil.isEmpty(txtQyOrderNO.Text.Trim()))
                order.OrderNO = txtQyOrderNO.Text.Trim();
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
            List<OrderVO> list = stockinManager.LoadOrders(order, startDt, endDt);
            dtgvOrders.DataSource = list;
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
                order.OrderNO = StringUtil.Obj2Str(curRow.Cells[colOrderNO.Name].Value);
                order.CustName = StringUtil.Obj2Str(curRow.Cells[colCustName.Name].Value);

                StockinOrderDetailForm detailForm = new StockinOrderDetailForm(order, stockinManager);
                detailForm.ShowDialog();
            }
        }

        private void txtNSupplyGoods_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                if (lboxGoods.SelectedIndex > 0)
                    lboxGoods.SelectedIndex--;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                if (lboxGoods.SelectedIndex < lboxGoods.Items.Count - 1)
                    lboxGoods.SelectedIndex++;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                goods = lboxGoods.SelectedItem as Goods;
                txtNSupplyGoods.Text = goods.GName;
                lboxGoods.Visible = false;
            }
            else
            {
                string term = txtNSupplyGoods.Text;
                Customer supplier = cboxNSupplier.SelectedItem as Customer;
                if (!StringUtil.isEmpty(term) && term.Trim().Length > 1)
                {
                    Goods tgoods = new Goods();
                    tgoods.St = ST.VALID;
                    List<Goods> list = goodsManager.LoadDataByKeyWords(term.Trim(), supplier.CID__PK);
                    for (int i = 0; i < list.Count; i++)
                    {
                        Goods good = list[i];
                        good.GName = good.GName + " [" + good.Specs + "]";
                        list[i] = good;
                    }
                    if (list.Count > 0)
                    {
                        lboxGoods.DataSource = list;
                        lboxGoods.DisplayMember = "GName";
                        lboxGoods.ValueMember = "GID__PK";
                        lboxGoods.Visible = true;
                    }
                    else
                        lboxGoods.Visible = false;
                }
                else
                {
                    lboxGoods.Visible = false;
                    goods = null;
                }
            }
            txtNSupplyGoods.Select(txtNSupplyGoods.Text.Length, 1);
        }

        private void lboxGoods_Click(object sender, EventArgs e)
        {
            goods = lboxGoods.SelectedItem as Goods;
            txtNSupplyGoods.Text = goods.GName;
            lboxGoods.Visible = false;
            //光标定位到最后
            txtNSupplyGoods.Select(txtNSupplyGoods.Text.Length, 1);
        }

        private void lboxGoods_MouseMove(object sender, MouseEventArgs e)
        {
            lboxGoods.SelectedIndex = lboxGoods.IndexFromPoint(e.Location);
        }

        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            if (null == goods)
            {
                if (!StringUtil.isEmpty(txtNSupplyGoods.Text))
                {
                    DialogResult rslt = MessageBox.Show("无此商品！是否新增？", "操作结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rslt == DialogResult.OK)
                    {
                        GoodsForm gForm = new GoodsForm(null, goodsManager, new SubCatgManager());
                        gForm.ShowDialog();
                    }
                }
                txtNSupplyGoods.Text = "";
                return;
            }
            foreach (DataGridViewRow row in dtgvStockin.Rows)
            {
                long gId = StringUtil.Obj2Long(row.Cells[colGID.Name].Value);
                if (gId == goods.GID__PK)
                {
                    MessageBox.Show("此商品已添加，请重新选择！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNSupplyGoods.Text = "";
                    return;
                }
            }
            int index = dtgvStockin.Rows.Add();
            InitRow(index, goods);
            txtNSupplyGoods.Text = "";
            goods = null;
        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            Customer supplier = cboxNSupplier.SelectedItem as Customer;
            SupplyGoodsForm goodsFrom = new SupplyGoodsForm(supplier);
            DialogResult rslt = goodsFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<int> addedGoods = new List<int>();
                foreach (DataGridViewRow row in dtgvStockin.Rows)
                {
                    int gid = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                    addedGoods.Add(gid);
                }
                List<Goods> goodsList = goodsFrom.GoodsList;
                foreach (Goods gd in goodsList)
                {
                    if (addedGoods.Contains(gd.GID__PK))
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
                sin.St = ST.VALID;
                if (sin.Num * sin.Price == 0)
                    continue;
                if (!StringUtil.isEmpty(row.Cells[colMfDt.Name].Value + ""))
                {
                    DateTime? expDt = null;
                    sin.MfDt = DateTime.ParseExact(StringUtil.Obj2Str(row.Cells[colMfDt.Name].Value), "yyyy/MM/dd", null);
                    string shelfLifeStr = StringUtil.Obj2Str(row.Cells[colShelfLife.Name].Value);
                    string num = shelfLifeStr.Substring(0, shelfLifeStr.Length - 1);
                    string term = shelfLifeStr.Substring(shelfLifeStr.Length - 1);
                    if (term == TERM.DAY)
                        expDt = sin.MfDt.AddDays(int.Parse(num));
                    else if (term == TERM.MONTH)
                        expDt = sin.MfDt.AddMonths(int.Parse(num));
                    else if (term == TERM.YEAR)
                        expDt = sin.MfDt.AddYears(int.Parse(num));
                    if (null != expDt)
                        sin.ExpDt = (DateTime)expDt;
                }
                list.Add(sin);

                OrderGoodsVO vo = new OrderGoodsVO();
                vo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                vo.Num = sin.Num;
                vo.Price = sin.Price;
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
    }
}
