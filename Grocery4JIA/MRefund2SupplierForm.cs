using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class MRefund2SupplierForm : Form
    {
        CustomerManager custManager;
        SubCatgManager subCatgManager;
        RefundManager refundManager;
        GoodsManager goodsManager;
        InStockGoodsVO goodsInStock;

        public MRefund2SupplierForm()
        {
            InitializeComponent();
            dtgvRfGoods.AutoGenerateColumns = false;
            dtgvRfOrders.AutoGenerateColumns = false;
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == subCatgManager)
                subCatgManager = new SubCatgManager();
            if (null == refundManager)
                refundManager = new RefundManager();
            if (null == goodsManager)
                goodsManager = new GoodsManager();

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust);

            cboxNSupplier.DisplayMember = "CName";
            cboxNSupplier.ValueMember = "CID__PK";
            cboxNSupplier.DataSource = custs;

            List<Customer> custList = new List<Customer>();
            Customer tmpCust = new Customer();
            tmpCust.CID__PK = 0;
            tmpCust.CName = "---选择---";
            custList.Add(tmpCust);
            custList.AddRange(custs);
            cboxQySupplier.DisplayMember = "CName";
            cboxQySupplier.ValueMember = "CID__PK";
            cboxQySupplier.DataSource = custList;
        }

        private void InitRow(int index, InStockGoodsVO goods)
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
            if (goods.GName.IndexOf("[") > 0)
                dtgvRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName.Substring(0, goods.GName.IndexOf("["));
            else
                dtgvRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
        }

        private void txtGoodsInStock_KeyUp(object sender, KeyEventArgs e)
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
                goodsInStock = lboxGoods.SelectedItem as InStockGoodsVO;
                txtGoodsInStock.Text = goodsInStock.GName;
                lboxGoods.Visible = false;
            }
            else
            {
                string term = txtGoodsInStock.Text;
                if (!StringUtil.isEmpty(term) && term.Trim().Length > 1)
                {
                    Goods tgoods = new Goods();
                    tgoods.St = ST.VALID;
                    Customer supplier = cboxNSupplier.SelectedItem as Customer;
                    List<InStockGoodsVO> list = goodsManager.LoadInStockGoodsByKeyWords(term.Trim(), supplier.CID__PK);
                    for (int i = 0; i < list.Count; i++)
                    {
                        InStockGoodsVO vo = list[i];
                        vo.GName = vo.GName + " [" + vo.Specs + "]";
                        list[i] = vo;
                    }
                    if (list.Count > 0)
                    {
                        lboxGoods.DataSource = list;
                        lboxGoods.DisplayMember = "GName";
                        lboxGoods.ValueMember = "GID";
                        lboxGoods.Visible = true;
                    }
                    else
                        lboxGoods.Visible = false;
                }
                else
                {
                    lboxGoods.Visible = false;
                    goodsInStock = null;
                }
            }
            txtGoodsInStock.Select(txtGoodsInStock.Text.Length, 1);
        }

        private void lboxGoods_Click(object sender, EventArgs e)
        {
            goodsInStock = lboxGoods.SelectedItem as InStockGoodsVO;
            txtGoodsInStock.Text = goodsInStock.GName;
            lboxGoods.Visible = false;
            //光标定位到最后
            txtGoodsInStock.Select(txtGoodsInStock.Text.Length, 1);
        }

        private void lboxGoods_MouseMove(object sender, MouseEventArgs e)
        {
            lboxGoods.SelectedIndex = lboxGoods.IndexFromPoint(e.Location);
        }

        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            if (null == goodsInStock)
            {
                if (!StringUtil.isEmpty(txtGoodsInStock.Text))
                {
                    DialogResult rslt = MessageBox.Show("无此商品！是否新增？", "操作结果", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rslt == DialogResult.OK)
                    {
                        GoodsForm gForm = new GoodsForm(null, goodsManager, new SubCatgManager());
                        gForm.ShowDialog();
                    }
                }
                txtGoodsInStock.Text = "";
                return;
            }
            foreach (DataGridViewRow row in dtgvRfGoods.Rows)
            {
                long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                if (invId == goodsInStock.InvID)
                {
                    MessageBox.Show("此商品已添加，请重新选择！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGoodsInStock.Text = "";
                    return;
                }
            }
            int index = dtgvRfGoods.Rows.Add();
            InitRow(index, goodsInStock);
            txtGoodsInStock.Text = "";
            goodsInStock = null;
        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            Customer supplier = cboxNSupplier.SelectedItem as Customer;
            GoodsInStockForm goodsInFrom = new GoodsInStockForm(supplier, DIRECT.REFUND2SUPPLIER);
            DialogResult rslt = goodsInFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<long> addedGoods = new List<long>();
                foreach (DataGridViewRow row in dtgvRfGoods.Rows)
                {
                    long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                    addedGoods.Add(invId);
                }
                List<InStockGoodsVO> goodsList = goodsInFrom.GoodsList;
                foreach (InStockGoodsVO vo in goodsList)
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
                    {
                        price = price + "0";
                        dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                    }
                    if (price.ToString().StartsWith("."))
                    {
                        price = "0" + price;
                        dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = price;
                    }
                }
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            RefundOrderVO refundVO = null;
            List<Refund> list = new List<Refund>();
            List<OrderGoodsVO> glist = new List<OrderGoodsVO>();
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
                if (rf.Num * rf.Price == 0)
                    continue;
                list.Add(rf);

                OrderGoodsVO vo = new OrderGoodsVO();
                vo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                vo.Num = rf.Num;
                vo.Price = rf.Price;
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
                MessageBox.Show("商品已退回！退单号：" + orderNO, "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("商品退回失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!StringUtil.isEmpty(txtQyOrderNO.Text))
                order.OrderNO = txtQyOrderNO.Text.Trim();
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
            if (custId != 0)
                order.CustID = custId;
            List<OrderVO> list = refundManager.LoadOrders(order, startDt, endDt);
            dtgvRfOrders.DataSource = list;
        }

        private void dtgvRfOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvRfOrders.CurrentRow;
            if (null != curRow)
            {
                Order order = new Order();
                order.Amount = StringUtil.Obj2Decimal(curRow.Cells[colAmount.Name].Value);
                order.OrderNO = StringUtil.Obj2Str(curRow.Cells[colOrderNO.Name].Value);
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
    }
}
