using BLL.Com;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class MStocktakingForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        ISubCatgManager subCatgManager;
        IInventoryManager manager;
        PageVO page;

        public MStocktakingForm()
        {
            InitializeComponent();
            dtgvGoods.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;

            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IInventoryManager>(usr);

            Customer cust = new Customer();
            cust.Grade = GRADE.SUPPLIER;
            cust.St = ST.VALID;
            List<Customer> custs = custManager.LoadData(cust, null);

            List<Customer> custList = new List<Customer>();
            Customer tmpCust = new Customer();
            tmpCust.CID__PK = 0;
            tmpCust.CName = "---选择---";
            custList.Add(tmpCust);
            custList.AddRange(custs);

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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderNO__PK = txtOrderNO.Text.Trim();
            order.CustID = StringUtil.Obj2Int(cboxSuppliers.SelectedValue);
            int catgId = StringUtil.Obj2Int(cboxCatgs.SelectedValue);
            string gNmId = txtGID.Text.Trim();

            List<StockGoodsVO> list = manager.LoadGoodsInStock(order, catgId, gNmId, 0, page);
            dtgvGoods.DataSource = list;

            dgvPager.TotalNum = page.TotalNum;
            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.ShowPageInfo();
        }

        private void dtgvGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (null != dtgvGoods.CurrentRow)
            {
                UpdateInv();
            }
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnQuery.PerformClick();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (null != dtgvGoods.CurrentRow)
            {
                UpdateInv();
            }
        }

        private void tsmiChld_Click(object sender, EventArgs e)
        {
            if (null != dtgvGoods.CurrentRow)
            {
                DataGridViewRow row = dtgvGoods.CurrentRow;
                Goods goods = new Goods();
                long invID = StringUtil.Obj2Long(row.Cells["colInvID"].Value);
                goods.GID__PK = StringUtil.Obj2Int(row.Cells["colGId"].Value);
                goods.GName = StringUtil.Obj2Str(row.Cells["colGName"].Value);
                goods.Specs = StringUtil.Obj2Str(row.Cells["colSpecs"].Value);
                string custName = StringUtil.Obj2Str(row.Cells["colCustName"].Value);
                InvOprtChldDialog chldDialog = new InvOprtChldDialog(invID, custName, goods);
                chldDialog.ShowDialog();
            }
        }

        private void UpdateInv()
        {
            DataGridViewRow row = dtgvGoods.CurrentRow;
            StockGoodsVO vo = new StockGoodsVO();
            vo.CustName = StringUtil.Obj2Str(row.Cells["colCustName"].Value);
            vo.OrderNO = StringUtil.Obj2Str(row.Cells["colSinOrdreNO"].Value);
            vo.GID = StringUtil.Obj2Int(row.Cells["colGId"].Value);
            vo.GName = StringUtil.Obj2Str(row.Cells["colGName"].Value);
            vo.Specs = StringUtil.Obj2Str(row.Cells["colSpecs"].Value);
            vo.Num = StringUtil.Obj2Int(row.Cells["colInvNum"].Value);
            vo.InvID = StringUtil.Obj2Long(row.Cells["colInvID"].Value);
            InvGoodsDialog dialog = new InvGoodsDialog(manager, vo);
            DialogResult rslt = dialog.ShowDialog();
            if (DialogResult.OK == rslt)
                btnQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { custManager, manager, subCatgManager };
        }
    }
}
