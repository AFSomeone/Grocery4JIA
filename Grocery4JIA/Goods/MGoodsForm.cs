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
    public partial class MGoodsForm : Form, IBaseForm
    {
        IGoodsManager manager;
        ISubCatgManager subCatgManager;
        PageVO page;
        public MGoodsForm()
        {
            InitializeComponent();
            page = new PageVO();
            page.PageNo = 1;
            dtgvMGoods.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);
            if (null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);

            BindingSource stBs = new BindingSource();
            Dictionary<string,string> goodsMap = new Dictionary<string, string>();
            goodsMap.Add("","全部");
            goodsMap.Add(ST.VALID,ST.GOODS_MAP[ST.VALID]);
            goodsMap.Add(ST.INVALID, ST.GOODS_MAP[ST.INVALID]);
            stBs.DataSource = goodsMap;
            cboxSt.DisplayMember = "Value";
            cboxSt.ValueMember = "Key";
            cboxSt.DataSource = stBs;

            List<SubCatgVO> subCatgs = subCatgManager.LoadData(false,null);
            List<SubCatgVO> list = new List<SubCatgVO>();
            SubCatgVO subCatg = new SubCatgVO();
            subCatg.CName = "全部";
            subCatg.CId__PK = 0;
            list.Add(subCatg);
            list.AddRange(subCatgs);
            cboxCatg.DisplayMember = "CName";
            cboxCatg.ValueMember = "CID__PK";
            cboxCatg.DataSource = list;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            try
            {
                if (cboxCatg.SelectedIndex == -1)
                    return;
                Goods goods = new Goods();
                goods.GName = txtGName.Text.Trim();
                goods.St = cboxSt.SelectedValue.ToString();
                short subCatgID = StringUtil.Obj2Short(cboxCatg.SelectedValue);
                goods.SubCatgID = subCatgID;
                if (string.Empty != txtGId.Text.Trim())
                {
                    goods.GID__PK = int.Parse(txtGId.Text.Trim());
                }
                List<GoodsVO> data = manager.LoadData(goods, page);
                if (null != data && data.Count > 0)
                {
                    dtgvMGoods.DataSource = null;
                    dtgvMGoods.DataSource = data;
                }
                else
                    dtgvMGoods.DataSource = null;
                dgvPager.TotalPageNum = page.TotalPage;
                dgvPager.TotalNum = page.TotalNum;
                dgvPager.ShowPageInfo();
            }
            catch
            {
                MainForm.Error("系统异常！");
            }
        }

        private void dtgvMGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvMGoods.Columns[e.ColumnIndex].Name == colSt.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = ST.GOODS_MAP[e.Value.ToString()];
            }
            if (dtgvMGoods.Columns[e.ColumnIndex].Name == colShelfLifeDesc.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;

                string num = e.Value.ToString().Substring(0, e.Value.ToString().Length - 1);
                string term = e.Value.ToString().Substring(e.Value.ToString().Length - 1);
                term = TERM.TERM_MAP[term];
                e.Value = num +" "+ term;
            }
        }

        private void dtgvMGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow curRow = dtgvMGoods.CurrentRow;
            if(null != curRow)
            {
                Goods goods = new Goods();
                goods.GID__PK = StringUtil.Obj2Int(curRow.Cells[colGId.Name].Value);
                goods.GName = StringUtil.Obj2Str(curRow.Cells[colGName.Name].Value);
                goods.Specs = StringUtil.Obj2Str(curRow.Cells[colSpecs.Name].Value);
                goods.Abbr = StringUtil.Obj2Str(curRow.Cells[colAbbr.Name].Value);
                goods.ShelfLife = StringUtil.Obj2Str(curRow.Cells[colShelfLife.Name].Value);
                goods.SubCatgID = StringUtil.Obj2Short(curRow.Cells[colSubCatgId.Name].Value);
                goods.Remark = StringUtil.Obj2Str(curRow.Cells[colRemark.Name].Value);
                goods.St = StringUtil.Obj2Str(curRow.Cells[colStEnum.Name].Value);

                GoodsForm gForm = new GoodsForm(goods, manager, subCatgManager);
                DialogResult result = gForm.ShowDialog();
                if (result == DialogResult.OK)
                    BindData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoodsForm gForm = new GoodsForm(null, manager, subCatgManager);
            DialogResult result = gForm.ShowDialog();
            if (result == DialogResult.OK)
                BindData();
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            BindData();
        }

        private void MGoodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(null != manager)
                manager.close();
            if (null != subCatgManager)
                subCatgManager.close();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager, subCatgManager };
        }
    }
}
