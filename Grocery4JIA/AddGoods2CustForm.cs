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
    public partial class AddGoods2CustForm : Form
    {
        GoodsManager goodsManager;
        SubCatgManager subCatgManager;
        CustomerManager custManager;
        int custId;
        List<int> gIds;
        public AddGoods2CustForm(List<int> gIds, int custId, string custName)
        {
            InitializeComponent();
            dtgvGoods.AutoGenerateColumns = false;
            if (null == goodsManager)
                goodsManager = new GoodsManager();
            if (null == subCatgManager)
                subCatgManager = new SubCatgManager();
            if (null == custManager)
                custManager = new CustomerManager();
            this.custId = custId;
            this.gIds = gIds;

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
            short cId = StringUtil.Obj2Short(cboxCatg.SelectedValue);
            if (0 != cId)
                goods.SubCatgID = cId;
            List<GoodsVO> list = goodsManager.LoadData(goods);
            List<GoodsVO> data = new List<GoodsVO>();
            if (null != list && list.Count > 0)
            {
                foreach (GoodsVO vo in list)
                {
                    if (gIds.Contains(vo.GID__PK))
                        continue;
                    data.Add(vo);
                }
            }
            dtgvGoods.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<SupplyInfo> list = new List<SupplyInfo>();
            foreach (DataGridViewRow row in dtgvGoods.Rows)
            {
                string value = StringUtil.Obj2Str(row.Cells[colCkBoxs.Name].Value);
                if (value == "true")
                {
                    SupplyInfo sinfo = new SupplyInfo();
                    sinfo.GID = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                    sinfo.CustID = custId;
                    sinfo.St = ST.VALID;
                    list.Add(sinfo);
                }
            }

            if (list.Count > 0)
            {
                int exCnt = custManager.AddGoods(list);
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
                    if (value == "true")
                        dtgvGoods.Rows[e.RowIndex].Cells[colCkBoxs.Name].Value = "false";
                    else
                        dtgvGoods.Rows[e.RowIndex].Cells[colCkBoxs.Name].Value = "true";
                }
            }
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            GoodsForm gForm = new GoodsForm(null, goodsManager, subCatgManager);
            DialogResult result = gForm.ShowDialog();
            if (result == DialogResult.OK)
                btnQuery_Click(btnQuery, new EventArgs());
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
    }
}
