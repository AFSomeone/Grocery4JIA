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
    public partial class AddGoods2CustForm : Form, IBaseForm
    {
        IGoodsManager goodsManager;
        ISubCatgManager subCatgManager;
        ICustomerManager custManager;
        int custId;
        PageVO page;

        Dictionary<int, SupplyInfo> supplyGoods;

        public AddGoods2CustForm(int custId, string custName)
        {
            InitializeComponent();
            dtgvGoods.AutoGenerateColumns = false;
            Usr usr = MainForm.usr;
            supplyGoods = new Dictionary<int, SupplyInfo>();
            page = new PageVO();
            page.PageSize = 100;
            page.PageNo = 1;
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(usr);
            if (null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(usr);
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            this.custId = custId;

            List<SubCatgVO> subCatgs = subCatgManager.LoadData(false, null);
            List<SubCatgVO> list = new List<SubCatgVO>();
            SubCatgVO subCatg = new SubCatgVO();
            subCatg.CName = "全部";
            subCatg.CId__PK = 0;
            list.Add(subCatg);
            list.AddRange(subCatgs);
            cboxCatg.DisplayMember = "CName";
            cboxCatg.ValueMember = "CID__PK";
            cboxCatg.DataSource = list;

            this.Text = custName;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods();
            goods.St = ST.VALID;
            if (!StringUtil.isEmpty(txtGName.Text))
                goods.GName = StringUtil.Obj2Str(txtGName.Text);
            if (!StringUtil.isEmpty(txtGID.Text))
                goods.GID__PK = StringUtil.Obj2Int(txtGID.Text.Trim());
            short cId = 0;
            if(cboxCatg.SelectedIndex != -1)
                cId = StringUtil.Obj2Short(cboxCatg.SelectedValue);
            if (0 != cId)
                goods.SubCatgID = cId;
            List<GoodsVO> list = custManager.LoadNotSupplyGoods(goods, custId, page);
            dtgvGoods.DataSource = list;

            if (supplyGoods.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvGoods.Rows)
                {
                    int gid = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                    if (supplyGoods.ContainsKey(gid))
                        row.Cells[colCkBoxs.Name].Value = "true";
                }
            }

            dgvPager.TotalNum = page.TotalNum;
            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.ShowPageInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (supplyGoods.Count > 0)
            {
                int exCnt = custManager.AddGoods(new List<SupplyInfo>(supplyGoods.Values));
                if (exCnt > 0)
                {
                    MessageBox.Show("添加成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("添加失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dtgvGoods.Columns[e.ColumnIndex].Name == colCkBoxs.Name)
                {
                    string value = StringUtil.Obj2Str(dtgvGoods.Rows[e.RowIndex].Cells[colCkBoxs.Name].Value);
                    int gid = StringUtil.Obj2Int(dtgvGoods.Rows[e.RowIndex].Cells[colGID.Name].Value);
                    if (value == "true")
                    {
                        if(supplyGoods.ContainsKey(gid))
                            supplyGoods.Remove(gid);
                        dtgvGoods.Rows[e.RowIndex].Cells[colCkBoxs.Name].Value = "false";
                    }
                    else
                    {
                        if (!supplyGoods.ContainsKey(gid))
                        {
                            SupplyInfo sinfo = new SupplyInfo();
                            sinfo.GID = gid;
                            sinfo.CustID = custId;
                            sinfo.St = ST.VALID;
                            supplyGoods.Add(gid,sinfo);
                        }
                        dtgvGoods.Rows[e.RowIndex].Cells[colCkBoxs.Name].Value = "true";
                    }
                }
            }
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            GoodsForm gForm = new GoodsForm(null, goodsManager, subCatgManager);
            DialogResult result = gForm.ShowDialog();
            if (result == DialogResult.OK)
                btnQuery.PerformClick();
        }

        private void txtGID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                e.Handled = true;
            if (keyVal >= 48 && keyVal <= 57)
            {
                TextBox gid = sender as TextBox;
                if (StringUtil.isEmpty(gid.Text))
                {
                    if (keyVal == 48)
                        e.Handled = true;
                }
            }
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { goodsManager, subCatgManager, custManager};
        }
    }
}
