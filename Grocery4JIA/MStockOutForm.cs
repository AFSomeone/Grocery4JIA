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
    public partial class MStockOutForm : Form
    {
        CustomerManager custManager;
        GoodsManager goodsManager;
        InStockGoodsVO goodsInStock;
        StockOutManager stockOutmanager;

        public MStockOutForm()
        {
            InitializeComponent();
            dtgvSOutGoods.AutoGenerateColumns = false;
            dtgvMOutOrders.AutoGenerateColumns = false;

            if (null == custManager)
                custManager = new CustomerManager();
            if (null == goodsManager)
                goodsManager = new GoodsManager();
            if (null == stockOutmanager)
                stockOutmanager = new StockOutManager();

            Customer cust = new Customer();
            cust.Grade = GRADE.RESELLER;
            cust.St = ST.VALID;
            List<Customer> resellers = custManager.LoadData(cust);

            cboxNResellers.DisplayMember = "CName";
            cboxNResellers.ValueMember = "CID__PK";
            cboxNResellers.DataSource = resellers;

            List<Customer> qyResellers = new List<Customer>();
            Customer reseller = new Customer();
            reseller.CID__PK = 0;
            reseller.CName = "---选择---";
            qyResellers.AddRange(resellers);

            cboxQyReseller.DisplayMember = "CName";
            cboxQyReseller.ValueMember = "CID__PK";
            cboxQyReseller.DataSource = qyResellers;
        }

        private void InitRow(int index, InStockGoodsVO goods)
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
                if (!StringUtil.isEmpty(term) && term.Trim().Length>1)
                {
                    Goods tgoods = new Goods();
                    tgoods.St = ST.VALID;
                    List<InStockGoodsVO> list = goodsManager.LoadInStockGoodsByKeyWords(term.Trim());
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StockOutOrderVO orderVO = null;
            List<StockOut> soutList = new List<StockOut>();
            List<OrderGoodsVO> glist = new List<OrderGoodsVO>();
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
                vo.Num = sout.Num;
                vo.Price = sout.Price;
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

            string orderNO = stockOutmanager.StockOut(orderVO);
            if (!StringUtil.isEmpty(orderNO))
            {
                MessageBox.Show("出货单创建成功！ 单号："+orderNO, "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("出货单创建失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            foreach (DataGridViewRow row in dtgvSOutGoods.Rows)
            {
                long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                if (invId == goodsInStock.InvID)
                {
                    MessageBox.Show("此商品已添加，请重新选择！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGoodsInStock.Text = "";
                    return;
                }
            }
            int index = dtgvSOutGoods.Rows.Add();
            InitRow(index, goodsInStock);
            txtGoodsInStock.Text = "";
            goodsInStock = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBtchAdd_Click(object sender, EventArgs e)
        {
            Customer reseller = cboxNResellers.SelectedItem as Customer;
            GoodsInStockForm goodsInFrom = new GoodsInStockForm(reseller, "出货单");
            DialogResult rslt = goodsInFrom.ShowDialog();
            if (rslt == DialogResult.OK)
            {
                List<long> addedGoods = new List<long>();
                foreach (DataGridViewRow row in dtgvSOutGoods.Rows)
                {
                    long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                    addedGoods.Add(invId);
                }
                List<InStockGoodsVO> goodsList = goodsInFrom.GoodsList;
                foreach (InStockGoodsVO vo in goodsList)
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
    }
}
