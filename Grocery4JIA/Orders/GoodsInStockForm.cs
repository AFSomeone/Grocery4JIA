using BLL.Com;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using System;

namespace UI
{
    public partial class GoodsInStockForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        ISubCatgManager subCatgManager;
        IInventoryManager manager;
        Customer customer;

        Dictionary<long, StockGoodsVO> goodsMap;
        PageVO page;

        public GoodsInStockForm(Customer customer, string direct)
        {
            InitializeComponent();
            dtgvGoodsInStock.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            goodsMap = new Dictionary<long, StockGoodsVO>();
            page = new PageVO();
            page.PageSize = 100;
            page.PageNo = 1;

            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IInventoryManager>(usr);
            this.customer = customer;
            string title = string.Empty;
            if (DIRECT.REFUND2SUPPLIER == direct)
                title = "退货单";
            else if (DIRECT.STOCK_OUT == direct)
                title = "出货单";
            else
                return;
            this.Text = "【" + title + "】" + " "+ customer.CName;

            List<Customer> custList = new List<Customer>();
            if (DIRECT.REFUND2SUPPLIER == direct)
            {
                custList.Add(customer);
            }
            else if (DIRECT.STOCK_OUT == direct)
            {
                Customer cust = new Customer();
                cust.Grade = GRADE.SUPPLIER;
                cust.St = ST.VALID;
                List<Customer> custs = custManager.LoadData(cust, null);

                Customer tmpCust = new Customer();
                tmpCust.CID__PK = 0;
                tmpCust.CName = "---选择---";
                custList.Add(tmpCust);
                custList.AddRange(custs);
            }
            
            cboxSuppliers.DisplayMember = "CName";
            cboxSuppliers.ValueMember = "CID__PK";
            cboxSuppliers.DataSource = custList;

            List<SubCatgVO> scatgs = subCatgManager.LoadData(false, null);
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
                    DataGridViewRow row = dtgvGoodsInStock.Rows[e.RowIndex];
                    string value = StringUtil.Obj2Str(row.Cells[colCkboxs.Name].Value);
                    long invId = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                    if (value == "true")
                    {
                        if(goodsMap.ContainsKey(invId))
                            goodsMap.Remove(invId);
                        row.Cells[colCkboxs.Name].Value = "false";                        
                    }
                    else
                    {                        
                        if (!goodsMap.ContainsKey(invId))
                        {
                            StockGoodsVO vo = new StockGoodsVO();
                            vo.GID = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                            vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                            vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                            vo.Price = StringUtil.Obj2Decimal(row.Cells[colPrice.Name].Value);
                            vo.Num = StringUtil.Obj2Int(row.Cells[colInvNum.Name].Value);
                            vo.OrderNO = StringUtil.Obj2Str(row.Cells[colSinOrdreNO.Name].Value);
                            vo.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                            vo.CustID = StringUtil.Obj2Int(row.Cells[colCustID.Name].Value);
                            vo.CustName = StringUtil.Obj2Str(row.Cells[colCustName.Name].Value);
                            vo.TgtSID = StringUtil.Obj2Long(row.Cells[colTgtSID.Name].Value);
                            vo.ExpDt = (DateTime)row.Cells[colExpDt.Name].Value;
                            goodsMap.Add(invId, vo);
                        }
                        row.Cells[colCkboxs.Name].Value = "true";
                    }
                }
            }
        }

        private void btnAddToList_Click(object sender, System.EventArgs e)
        {
            if (goodsMap.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MainForm.Info("请选择商品先！");
        }

        private void btnQuery_Click(object sender, System.EventArgs e)
        {
            Order order = new Order();
            order.OrderNO__PK = txtOrderNO.Text.Trim();
            if(cboxSuppliers.SelectedIndex !=-1)
                order.CustID = StringUtil.Obj2Int(cboxSuppliers.SelectedValue);
            int catgId = StringUtil.Obj2Int(cboxCatgs.SelectedValue);

            List<StockGoodsVO> list = manager.LoadGoodsInStock(order, catgId, 1, page);
            dtgvGoodsInStock.DataSource = list;

            if (goodsMap.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvGoodsInStock.Rows)
                {
                    int invId = StringUtil.Obj2Int(row.Cells[colInvID.Name].Value);
                    if (goodsMap.ContainsKey(invId))
                        row.Cells[colCkboxs.Name].Value = "true";
                }
            }
            
            dgvPager.TotalNum = page.TotalNum;
            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.ShowPageInfo();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public List<StockGoodsVO> GoodsList
        {
            get
            {
                return new List<StockGoodsVO>(goodsMap.Values);
            }
        }

        private void dgvPager_pagerBtnClicked(object sender, System.EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { custManager, subCatgManager, manager };
        }
    }
}
