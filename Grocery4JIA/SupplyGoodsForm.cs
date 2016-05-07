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
    public partial class SupplyGoodsForm : Form
    {
        GoodsManager goodsManager;
        CustomerManager custManager;
        SubCatgManager catgManager;
        List<Goods> goodsList;

        public SupplyGoodsForm(Customer supplier)
        {
            InitializeComponent();
            if (null == goodsManager)
                goodsManager = new GoodsManager();
            if (null == custManager)
                custManager = new CustomerManager();
            if (null == catgManager)
                catgManager = new SubCatgManager();

            List<SubCatgVO> subCatgs = catgManager.LoadData(false);
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

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            goodsList = new List<Goods>();
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
                    goodsList.Add(goods);
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

        public List<Goods> GoodsList
        {
            get
            {
                return goodsList;
            }
        }
    }
}
