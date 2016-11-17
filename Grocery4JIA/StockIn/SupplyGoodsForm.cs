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
    public partial class SupplyGoodsForm : Form, IBaseForm
    {
        IGoodsManager goodsManager;
        ICustomerManager custManager;
        ISubCatgManager catgManager;
        Dictionary<int, Goods> goodsMap;
        PageVO page;

        public SupplyGoodsForm(Customer supplier)
        {
            InitializeComponent();
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;
            page.PageSize = 100;
            goodsMap = new Dictionary<int, Goods>();
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            if (null == catgManager)
                catgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);

            List<SubCatgVO> subCatgs = catgManager.LoadData(false,null);
            List<SubCatgVO> list = new List<SubCatgVO>();
            SubCatgVO subCatg = new SubCatgVO();
            subCatg.CName = "全部";
            subCatg.CId__PK = 0;
            list.Add(subCatg);
            list.AddRange(subCatgs);
            cboxCatg.DisplayMember = "CName";
            cboxCatg.ValueMember = "CID__PK";
            cboxCatg.DataSource = list;

            List<Customer> custs = new List<Customer>();
            custs.Add(supplier);
            cboxSupplier.DisplayMember = "CName";
            cboxSupplier.ValueMember = "CID__PK";
            cboxSupplier.DataSource = custs;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Goods goods = new Goods();
                goods.St = ST.VALID;
                short subCatgID = StringUtil.Obj2Short(cboxCatg.SelectedValue);
                int supplierId = 0;
                if(cboxSupplier.SelectedIndex !=-1)
                    supplierId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
                goods.SubCatgID = subCatgID;
                List<GoodsVO> data = goodsManager.LoadData(goods, page, supplierId);
                if (null != data && data.Count > 0)
                {
                    dtgvMGoods.DataSource = null;
                    dtgvMGoods.DataSource = data;
                }
                else
                    dtgvMGoods.DataSource = null;

                if (goodsMap.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgvMGoods.Rows)
                    {
                        int gid = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                        if (goodsMap.ContainsKey(gid))
                            row.Cells[colCkboxs.Name].Value = "true";
                    }
                }  
            }
            catch
            {
                MainForm.Error("系统异常！");
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (goodsMap.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MainForm.Warn("请选择商品先！");
        }

        private void dtgvMGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvMGoods.Columns[e.ColumnIndex].Name == colCkboxs.Name)
                {
                    DataGridViewRow row = dtgvMGoods.Rows[e.RowIndex];
                    string value = StringUtil.Obj2Str(row.Cells[colCkboxs.Name].Value);
                    int gid = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                    if (value == "true")
                    {
                        if (goodsMap.ContainsKey(gid))
                            goodsMap.Remove(gid);
                        row.Cells[colCkboxs.Name].Value = "false";
                    }
                    else
                    {
                        Goods goods = new Goods();
                        goods.GID__PK = StringUtil.Obj2Int(row.Cells[colGId.Name].Value);
                        goods.GName = StringUtil.Obj2Str(row.Cells[colGName.Name].Value);
                        goods.Specs = StringUtil.Obj2Str(row.Cells[colSpecs.Name].Value);
                        goods.Abbr = StringUtil.Obj2Str(row.Cells[colAbbr.Name].Value);
                        goods.ShelfLife = StringUtil.Obj2Str(row.Cells[colShelfLife.Name].Value);
                        goods.SubCatgID = StringUtil.Obj2Short(row.Cells[colSubCatgId.Name].Value);
                        goods.Remark = StringUtil.Obj2Str(row.Cells[colRemark.Name].Value);
                        goodsMap.Add(gid, goods);

                        row.Cells[colCkboxs.Name].Value = "true";
                    }                        
                }
            }
        }

        public List<Goods> GoodsList
        {
            get
            {
                return new List<Goods> (goodsMap.Values);
            }
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { catgManager, custManager, goodsManager };
        }
    }
}
