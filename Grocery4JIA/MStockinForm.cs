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
        GoodsManager goodsManager;
        SubCatgManager subCatgManager;
        CustomerManager custManager;
        StockinManager manager;

        public MStockinForm()
        {
            InitializeComponent();
            dtgvMGoods.AutoGenerateColumns = false;
            dtgvOrders.AutoGenerateColumns = false;
            if (null == goodsManager)
                goodsManager = new GoodsManager();
            if (null == subCatgManager)
                subCatgManager = new SubCatgManager();
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == manager)
                manager = new StockinManager();

            List<SubCatgVO> subCatgs = subCatgManager.LoadData(false);
            List<SubCatgVO> list = new List<SubCatgVO>();
            SubCatgVO subCatg = new SubCatgVO();
            subCatg.CName = "全部";
            subCatg.CId__PK = 0;
            list.Add(subCatg);
            list.AddRange(subCatgs);
            cboxCatg.DisplayMember = "CName";
            cboxCatg.ValueMember = "CID__PK";
            cboxCatg.DataSource = list;

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust);
            List<Customer> qyCustList = new List<Customer>();
            cust.CID__PK = 0;
            cust.CName = "---选择---";
            qyCustList.Add(cust);
            qyCustList.AddRange(custs);
            cboxQyCust.DisplayMember = "CName";
            cboxQyCust.ValueMember = "CID__PK";
            cboxQyCust.DataSource = qyCustList;

            cboxSupplier.DataSource = custs;
            cboxSupplier.DisplayMember = "CName";
            cboxSupplier.ValueMember = "CID__PK";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            try
            {
                Goods goods = new Goods();
                goods.GName = txtGName.Text.Trim();
                goods.St = ST.VALID;
                short subCatgID = StringUtil.Obj2Short(cboxCatg.SelectedValue);
                int supplierId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
                goods.SubCatgID = subCatgID;
                List<GoodsVO> data = goodsManager.LoadData(goods, supplierId);
                if (null != data && data.Count > 0)
                {
                    dtgvMGoods.DataSource = null;
                    dtgvMGoods.DataSource = data;
                }
                else
                    dtgvMGoods.DataSource = null;
            }
            catch
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvMGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvMGoods.Columns[e.ColumnIndex].Name == colCkboxs.Name)
                {
                    string value = StringUtil.Obj2Str(dtgvMGoods.Rows[e.RowIndex].Cells[colCkboxs.Name].Value);
                    if (value == "true")
                        dtgvMGoods.Rows[e.RowIndex].Cells[colCkboxs.Name].Value = "false";
                    else
                        dtgvMGoods.Rows[e.RowIndex].Cells[colCkboxs.Name].Value = "true";
                }
            }
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            List<Goods> glist = new List<Goods>();
            foreach (DataGridViewRow row in dtgvMGoods.Rows)
            {
                string value = StringUtil.Obj2Str(row.Cells[colCkboxs.Name].Value);
                if (value == "true")
                {
                    Goods goods = new Goods();
                    goods.GID__PK = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                    goods.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                    goods.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                    goods.Abbr = StringUtil.Obj2Str(row.Cells[colAbbr.Name].Value);
                    goods.ShelfLife = StringUtil.Obj2Str(row.Cells[colShelfLife.Name].Value);
                    goods.SubCatgID = StringUtil.Obj2Short(row.Cells[colSubCatgId.Name].Value);
                    goods.Remark = StringUtil.Obj2Str(row.Cells[colRemark.Name].Value);
                    glist.Add(goods);
                }
            }
            Customer supplier = cboxSupplier.SelectedItem as Customer;
            StockinForm sinForm = new StockinForm(glist, supplier);
            DialogResult result = sinForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                tabSinOrders.SelectedTab = tabpgStockinOrder;
                txtQyOrderNO.Text = sinForm.OrderNO;
                btnOrderQuery_Click(btnOrderQuery, new EventArgs());
            }
        }

        private void btnOrderQuery_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Direct = DIRECT.STOCK_IN;
            if (!StringUtil.isEmpty(txtQyOrderNO.Text.Trim()))
                order.OrderNO = txtQyOrderNO.Text.Trim();
            if (ckboxQyEnableDt.Checked)
            {
                string crtDtStr = dtpQyCrtTm.Value.ToString("yyyyMMdd");
                order.CrtTmst = DateTime.ParseExact(crtDtStr,"yyyyMMdd",null);
            }
            int custId = StringUtil.Obj2Int(cboxQyCust.SelectedValue);
            if(custId !=0)
                order.CustID = custId;
            List<StockinOrderVO> list = manager.LoadOrders(order);
            dtgvOrders.DataSource = list;
        }

        private void ckboxEnableDt_Click(object sender, EventArgs e)
        {
            if (ckboxQyEnableDt.Checked)
                dtpQyCrtTm.Enabled = true;
            else
                dtpQyCrtTm.Enabled = false;
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

                StockinOrderDetailForm detailForm = new StockinOrderDetailForm(order, manager);
                detailForm.ShowDialog();
            }
        }

        private void cboxSupplier_DrawItem(object sender, DrawItemEventArgs e)
        {
            //MainForm.ComboBox_DrawItem(sender, e);
            if (e.Index < 0)
            {
                return;
            }
            ComboBox cbox = sender as ComboBox;
            Customer item = cbox.Items[e.Index] as Customer;
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(item.CName, e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y + 3);

        }
    }
}
