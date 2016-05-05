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
    public partial class StockinForm : Form
    {
        CustomerManager custManager;
        GoodsManager goodsManager;
        StockinManager manager;
        Customer supplier;
        Goods goods;
        string orderNO;

        public StockinForm(List<Goods> glist, Customer supplier)
        {
            InitializeComponent();
            dtgvStockin.AutoGenerateColumns = false;
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == goodsManager)
                goodsManager = new GoodsManager();
            if (null == manager)
                manager = new StockinManager();
            this.supplier = supplier;

            foreach (Goods tgoods in glist)
            {
                int index = dtgvStockin.Rows.Add();
                InitRow(index, tgoods);
            }
            Text = supplier.CName;
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

        private void txtGoods_KeyUp(object sender, KeyEventArgs e)
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
                txtGoods.Text = goods.GName;
                lboxGoods.Visible = false;
            }
            else
            {
                if (!StringUtil.isEmpty(txtGoods.Text))
                {
                    Goods tgoods = new Goods();
                    tgoods.St = ST.VALID;
                    List<Goods> list = goodsManager.LoadDataByKeyWords(txtGoods.Text.Trim(), supplier.CID__PK);
                    for (int i = 0; i < list.Count;i++)
                    {
                        Goods good = list[i];
                        good.GName = good.GName + " [" + good.Specs+"]";
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
            txtGoods.Select(txtGoods.Text.Length, 1);
        }

        private void lboxGoods_Click(object sender, EventArgs e)
        {
            goods = lboxGoods.SelectedItem as Goods;
            txtGoods.Text = goods.GName;
            lboxGoods.Visible = false;
            //光标定位到最后
            txtGoods.Select(txtGoods.Text.Length, 1);
        }

        private void lboxGoods_MouseMove(object sender, MouseEventArgs e)
        {
            lboxGoods.SelectedIndex = lboxGoods.IndexFromPoint(e.Location);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (null == goods)
            {
                if (!StringUtil.isEmpty(txtGoods.Text))
                {
                    MessageBox.Show("无此商品！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    smuitAddGoods_Click(smuitAddGoods ,new EventArgs());
                }
                txtGoods.Text = "";
                return;
            }
            foreach (DataGridViewRow row in dtgvStockin.Rows)
            {
                int gid = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                if (gid == goods.GID__PK)
                {
                    MessageBox.Show("此商品已添加，请重新选择！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGoods.Text = "";
                    return;
                }
            }
            int index = dtgvStockin.Rows.Add();
            InitRow(index, goods);
            txtGoods.Text = "";
            goods = null;
        }

        private void dtgvStockin_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvStockin.Columns[e.ColumnIndex].Name == colPrice.Name || dtgvStockin.Columns[e.ColumnIndex].Name == colNum.Name)
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dtgvStockin.Rows)
                {
                    object numObj = row.Cells[colNum.Name].Value;
                    object priceObj = row.Cells[colPrice.Name].Value;

                    if (null != numObj && null != priceObj)
                        total += StringUtil.Obj2Int(numObj) * StringUtil.Obj2Decimal(priceObj);
                }
                txtAmount.Text = total+"";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvStockin.SelectedRows)
            {
                dtgvStockin.Rows.Remove(row);
            }
        }

        private void btnCnfrm_Click(object sender, EventArgs e)
        {
            StockinOrderVO orderVO = null;
            foreach (DataGridViewRow row in dtgvStockin.Rows)
            {
                StockIn sin = new StockIn();
                sin.Num = StringUtil.Obj2Int(row.Cells[colNum.Name].Value);
                sin.Price = StringUtil.Obj2Decimal(row.Cells[colPrice.Name].Value);
                sin.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                sin.St = ST.VALID;
                if (!StringUtil.isEmpty(row.Cells[colMfDt.Name].Value + ""))
                {
                    DateTime? expDt = null;
                    sin.MfDt = DateTime.ParseExact(StringUtil.Obj2Str(row.Cells[colMfDt.Name].Value), "yyyy/MM/dd", null);
                    string shelfLifeStr = StringUtil.Obj2Str(row.Cells[colShelfLife.Name]);
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
                if(null == orderVO)
                {
                    orderVO = new StockinOrderVO();
                    orderVO.CustID = supplier.CID__PK;
                    orderVO.CustName = supplier.CName;
                    orderVO.Direct = DIRECT.STOCK_IN;
                    orderVO.UptUID = MainForm.usr.UId__PK;
                    orderVO.CrtUID = MainForm.usr.UId__PK;
                    List<StockIn> list = new List<StockIn>();
                    list.Add(sin);
                    orderVO._StockinList = list;
                }
                else
                    orderVO._StockinList.Add(sin);
            }
            if (null != orderVO)
            {
                orderNO = manager.Stockin(orderVO);
                if (!StringUtil.isEmpty(orderNO))
                {
                    MessageBox.Show("商品已入库！单号：" + OrderNO, "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("商品入库失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void smuitAddGoods_Click(object sender, EventArgs e)
        {
            GoodsForm gForm = new GoodsForm(null, goodsManager, new SubCatgManager());
            gForm.ShowDialog();
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

        private void StockinForm_Click(object sender, EventArgs e)
        {
            if (mthcdrMfDt.Visible)
                mthcdrMfDt.Visible = false;
        }

        public string OrderNO
        {
            get
            {
                return orderNO;
            }
        }
    }
}
