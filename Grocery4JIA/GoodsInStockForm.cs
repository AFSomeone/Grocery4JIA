using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class GoodsInStockForm : Form
    {
        CustomerManager custManager;
        SubCatgManager subCatgManager;
        InventoryManager manager;
        List<InStockGoodsVO> goodsList;
        Customer customer;

        public GoodsInStockForm(Customer customer, string title)
        {
            InitializeComponent();
            dtgvGoodsInStock.AutoGenerateColumns = false;
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == subCatgManager)
                subCatgManager = new SubCatgManager();
            if (null == manager)
                manager = new InventoryManager();
            this.customer = customer;
            this.Text = "【" + title + "】" + " "+ customer.CName;

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust);

            List<Customer> custList = new List<Customer>();
            Customer tmpCust = new Customer();
            tmpCust.CID__PK = 0;
            tmpCust.CName = "---选择---";
            custList.Add(tmpCust);
            custList.AddRange(custs);
            cboxSuppliers.DisplayMember = "CName";
            cboxSuppliers.ValueMember = "CID__PK";
            cboxSuppliers.DataSource = custList;

            List<SubCatgVO> scatgs = subCatgManager.LoadData(false);
            List<SubCatgVO> catgList = new List<SubCatgVO>();
            SubCatgVO catgVO = new SubCatgVO();
            catgVO.CName = "全部";
            catgVO.CId__PK = 0;
            catgList.Add(catgVO);
            catgList.AddRange(scatgs);

            cboxCatgs.DisplayMember = "CName";
            cboxCatgs.ValueMember = "CId__PK";
            cboxCatgs.DataSource = catgList;
        }

        private void dtgvGoodsInStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvGoodsInStock.Columns[e.ColumnIndex].Name == colCkboxs.Name)
                {
                    string value = StringUtil.Obj2Str(dtgvGoodsInStock.Rows[e.RowIndex].Cells[colCkboxs.Name].Value);
                    if (value == "true")
                        dtgvGoodsInStock.Rows[e.RowIndex].Cells[colCkboxs.Name].Value = "false";
                    else
                        dtgvGoodsInStock.Rows[e.RowIndex].Cells[colCkboxs.Name].Value = "true";
                }
            }
        }

        private void btnAddToList_Click(object sender, System.EventArgs e)
        {
            goodsList = new List<InStockGoodsVO>();
            foreach (DataGridViewRow row in dtgvGoodsInStock.Rows)
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
                    vo.CustID = customer.CID__PK;
                    vo.CustName = customer.CName;
                    goodsList.Add(vo);
                }
            }

            if (goodsList.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("请选择商品先！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            Order order = new Order();
            order.OrderNO = txtOrderNO.Text.Trim();
            order.CustID = StringUtil.Obj2Int(cboxSuppliers.SelectedValue);
            int catgId = StringUtil.Obj2Int(cboxCatgs.SelectedValue);

            List<InStockGoodsVO> list = manager.LoadGoodsInStock(order, catgId);
            dtgvGoodsInStock.DataSource = list;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public List<InStockGoodsVO> GoodsList
        {
            get
            {
                return goodsList;
            }
        }
    }
}
