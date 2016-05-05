using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.Util;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class GoodsForm : Form
    {
        GoodsManager manager;
        SubCatgManager subCatgManager;
        bool chngFlag = false;

        public GoodsForm(Goods mGoods, GoodsManager goodsManager, SubCatgManager subCatgManager)
        {
            InitializeComponent();
            this.manager = goodsManager;
            this.subCatgManager = subCatgManager;

            BindingSource bs = new BindingSource();
            bs.DataSource = TERM.TERM_MAP;
            cboxShelfLife.DataSource = bs;
            cboxShelfLife.DisplayMember = "Value";
            cboxShelfLife.ValueMember = "Key";

            if (null == mGoods)
            {
                this.Text = "添加商品";
                rbtnInvalid.Enabled = false;
                rbtnValid.Enabled = false;
                rbtnValid.Checked = true;

                List <SubCatgVO> list = this.subCatgManager.LoadData(false);
                cboxCatg.DataSource = list;
                cboxCatg.DisplayMember = "CName";
                cboxCatg.ValueMember = "CId__PK";
            }
            else
            {
                this.Text = "修改商品";
                List<SubCatgVO> list = this.subCatgManager.LoadData(true);
                cboxCatg.DataSource = list;
                cboxCatg.DisplayMember = "CName";
                cboxCatg.ValueMember = "CId__PK";

                string shelfLifeStr = mGoods.ShelfLife;
                string num = shelfLifeStr.Substring(0, shelfLifeStr.Length-1);
                string term = shelfLifeStr.Substring(shelfLifeStr.Length - 1);
                txtGId.Text = mGoods.GID__PK.ToString();
                txtGName.Text = mGoods.GName;
                txtAbbr.Text = mGoods.Abbr;
                txtRemark.Text = mGoods.Remark;
                txtShelfLife.Text = num;
                cboxShelfLife.SelectedValue = term;
                txtSpecs.Text = mGoods.Specs;
                cboxCatg.SelectedValue = mGoods.SubCatgID;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            chngFlag = false;
            Goods goods = new Goods();
            int exCnt = 0;
            goods.GName = txtGName.Text.Trim();
            goods.Abbr = txtAbbr.Text.Trim();
            goods.Remark = txtRemark.Text.Trim();
            goods.Specs = txtSpecs.Text.Trim();
            goods.SubCatgID = StringUtil.Obj2Short(cboxCatg.SelectedValue);
            goods.ShelfLife = txtShelfLife.Text.Trim()+cboxShelfLife.SelectedValue.ToString();
            string gId = txtGId.Text.Trim();
            if (rbtnInvalid.Checked)
                goods.St = ST.INVALID;
            if (rbtnValid.Checked)
                goods.St = ST.VALID;

            if (string.Empty != gId)
            {
                goods.GID__PK = int.Parse(gId);
                exCnt = manager.Update(goods);
            }
            else
            {
                exCnt = manager.Save(goods);
            }

            if (exCnt > 0)
            {
                chngFlag = true;
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (string.Empty != gId)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            if(chngFlag == true)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddCatg_Click(object sender, System.EventArgs e)
        {
            SubCatgForm scatgForm = new SubCatgForm();
            DialogResult result = scatgForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<SubCatgVO> list = this.subCatgManager.LoadData(false);
                cboxCatg.DataSource = list;
                cboxCatg.DisplayMember = "CName";
                cboxCatg.ValueMember = "CId__PK";
            }
        }
    }
}
