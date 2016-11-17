using BLL.Com;
using BLL.Proxy;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class SoldGoodsForm : Form, IBaseForm
    {
        ISubCatgManager subCatgManager;
        IInventoryManager manager;
        Customer customer;
        Dictionary<long, StockGoodsVO> goodsMap;
        PageVO page;

        public SoldGoodsForm(Customer customer)
        {
            InitializeComponent();
            dtgvSoldGoods.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            goodsMap = new Dictionary<long, StockGoodsVO>();
            page = new PageVO();
            page.PageSize = 100;
            page.PageNo = 1;

            if (null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IInventoryManager>(usr);
            this.customer = customer;
            this.Text = "【回收单】 "+customer.CName;

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

            List<Customer> custs = new List<Customer>();
            custs.Add(customer);
            cboxResellers.DataSource = custs;
            cboxResellers.DisplayMember = "CName";
            cboxResellers.ValueMember = "CID__PK";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cboxResellers.SelectedIndex == -1)
                return;
            Order order = new Order();
            order.OrderNO__PK = txtOrderNO.Text.Trim();
            order.CustID = StringUtil.Obj2Int(cboxResellers.SelectedValue);
            int catgId = StringUtil.Obj2Int(cboxCatgs.SelectedValue);

            List<StockGoodsVO> list = manager.LoadSoldGoods(order, catgId, page);
            dtgvSoldGoods.DataSource = list;

            if (goodsMap.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvSoldGoods.Rows)
                {
                    long invID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                    if (goodsMap.ContainsKey(invID))
                    {
                        row.Cells[colCkboxs.Name].Value = "true";
                    }
                }
            }

            dgvPager.TotalNum = page.TotalNum;
            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.ShowPageInfo();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (GoodsList.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MainForm.Info("请选择商品先！");
        }

        private void dtgvSoldGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvSoldGoods.Columns[e.ColumnIndex].Name == colCkboxs.Name)
                {
                    DataGridViewRow row = dtgvSoldGoods.Rows[e.RowIndex];
                    string value = StringUtil.Obj2Str(row.Cells[colCkboxs.Name].Value);
                    long invID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                    if (value == "true")
                    {
                        if (goodsMap.ContainsKey(invID))
                            goodsMap.Remove(invID);
                        row.Cells[colCkboxs.Name].Value = "false";
                    }
                    else
                    {
                        if (!goodsMap.ContainsKey(invID))
                        {
                            StockGoodsVO vo = new StockGoodsVO();
                            vo.GID = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                            vo.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                            vo.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                            vo.Price = StringUtil.Obj2Decimal(row.Cells[colPrice.Name].Value);
                            vo.Num = StringUtil.Obj2Int(row.Cells[colInvNum.Name].Value);
                            vo.OrderNO = StringUtil.Obj2Str(row.Cells[colSinOrdreNO.Name].Value);
                            vo.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                            vo.Remark = StringUtil.Obj2Str(row.Cells[colRemark.Name].Value);
                            vo.TgtSID = StringUtil.Obj2Long(row.Cells[colTgtSID.Name].Value);
                            object expDt = row.Cells[colExpDt.Name].Value;
                            if (null != expDt)
                                vo.ExpDt = (DateTime)expDt;
                            vo.RfNum = StringUtil.Obj2Int(row.Cells[colRfNum.Name].Value);
                            vo.CustID = (int)customer.CID__PK;
                            vo.CustName = customer.CName;
                            goodsMap.Add(invID, vo);
                        }
                        row.Cells[colCkboxs.Name].Value = "true";
                    }   
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<StockGoodsVO> GoodsList
        {
            get
            {
                return new List<StockGoodsVO> (goodsMap.Values);
            }
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { subCatgManager, manager };
        }
    }
}
