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
    public partial class MSinRefundForm : Form
    {
        CustomerManager custManager;
        SubCatgManager subCatgManager;
        RefundManager manager;

        public MSinRefundForm()
        {
            InitializeComponent();
            dtgvMRfGoods.AutoGenerateColumns = false;
            dtgvRfOrders.AutoGenerateColumns = false;
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == subCatgManager)
                subCatgManager = new SubCatgManager();
            if (null == manager)
                manager = new RefundManager();

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust);

            cboxNSppliers.DisplayMember = "CName";
            cboxNSppliers.ValueMember = "CID__PK";
            cboxNSppliers.DataSource = custs;

            List<Customer> custList = new List<Customer>();
            Customer tmpCust = new Customer();
            tmpCust.CID__PK = 0;
            tmpCust.CName = "---选择---";
            custList.Add(tmpCust);
            custList.AddRange(custs);
            cboxQySupplier.DisplayMember = "CName";
            cboxQySupplier.ValueMember = "CID__PK";
            cboxQySupplier.DataSource = custList;

            List<SubCatgVO> scatgs = subCatgManager.LoadData(false);
            List<SubCatgVO> catgList = new List<SubCatgVO>();
            SubCatgVO catgVO = new SubCatgVO();
            catgVO.CName = "全部";
            catgVO.CId__PK = 0;
            catgList.Add(catgVO);
            catgList.AddRange(scatgs);

            cboxNCatg.DisplayMember = "CName";
            cboxNCatg.ValueMember = "CId__PK";
            cboxNCatg.DataSource = catgList;
        }

        private void dtgvMRfGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvMRfGoods.Columns[e.ColumnIndex].Name == colCkboxs.Name)
                {
                    string value = StringUtil.Obj2Str(dtgvMRfGoods.Rows[e.RowIndex].Cells[colCkboxs.Name].Value);
                    if (value == "true")
                        dtgvMRfGoods.Rows[e.RowIndex].Cells[colCkboxs.Name].Value = "false";
                    else
                        dtgvMRfGoods.Rows[e.RowIndex].Cells[colCkboxs.Name].Value = "true";
                }
            }
        }

        private void btnRefund_Click(object sender, System.EventArgs e)
        {
            List<InStockGoodsVO> list = new List<InStockGoodsVO>();
            Customer supplier = cboxNSppliers.SelectedItem as Customer;
            foreach (DataGridViewRow row in dtgvMRfGoods.Rows)
            {
                string value = StringUtil.Obj2Str(row.Cells[colCkboxs.Name].Value);
                if (value == "true")
                {
                    InStockGoodsVO vo = new InStockGoodsVO();
                    vo.GID = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                    vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                    vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                    vo.Price = StringUtil.Obj2Decimal(row.Cells[colPrice.Name].Value);
                    vo.Num = StringUtil.Obj2Int(row.Cells[colInvNum.Name].Value);
                    vo.OrderNO = StringUtil.Obj2Str(row.Cells[colSinOrdreNO.Name].Value);
                    vo.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                    vo.CustID = supplier.CID__PK;
                    vo.CustName = supplier.CName;

                    list.Add(vo);
                }
            }

            if (list.Count > 0)
            {
                SinRefundForm srfForm = new SinRefundForm(list, supplier);
                DialogResult rslt = srfForm.ShowDialog();
                if (rslt == DialogResult.OK)
                {
                    txtQyOrderNO.Text = srfForm.OrderNO;
                    btnOrderQuery_Click(btnOrderQuery, new EventArgs());
                }
            }
        }

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            BindMRfGoodsData();
        }

        private void BindMRfGoodsData()
        {
            Order order = new Order();
            order.OrderNO = txtNOrderNO.Text.Trim();
            order.CustID = StringUtil.Obj2Int(cboxNSppliers.SelectedValue);
            int catgId = StringUtil.Obj2Int(cboxNCatg.SelectedValue);

            List<InStockGoodsVO> list = manager.LoadGoodsInStock(order, catgId);
            dtgvMRfGoods.DataSource = list;
        }

        private void btnOrderQuery_Click(object sender, System.EventArgs e)
        {
            Order order = new Order();
            order.Direct = DIRECT.REFUND2SUPPLIER;
            if (!StringUtil.isEmpty(txtQyOrderNO.Text.Trim()))
                order.OrderNO = txtQyOrderNO.Text.Trim();
            if (ckboxEnableDt.Checked)
            {
                string crtDtStr = dtpQyCrtTm.Value.ToString("yyyyMMdd");
                order.CrtTmst = DateTime.ParseExact(crtDtStr, "yyyyMMdd", null);
            }
            int custId = StringUtil.Obj2Int(cboxQySupplier.SelectedValue);
            if (custId != 0)
                order.CustID = custId;
            List<RefundOrderVO> list = manager.LoadOrders(order);
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
                order.CustName = StringUtil.Obj2Str(curRow.Cells[colSupplier.Name].Value);

                RefundOrderDetailForm detailForm = new RefundOrderDetailForm(order, manager);
                detailForm.ShowDialog();
            }
        }
    }
}
