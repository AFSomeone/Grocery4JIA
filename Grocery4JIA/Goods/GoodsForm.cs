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
    public partial class GoodsForm : Form, IBaseForm
    {
        IGoodsManager manager;
        ISubCatgManager subCatgManager;
        ICustomerManager custManager;
        bool chngFlag = false;

        public GoodsForm(Goods mGoods, IGoodsManager goodsManager, ISubCatgManager subCatgManager)
        {
            InitializeComponent();
            this.manager = goodsManager;
            this.subCatgManager = subCatgManager;
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(MainForm.usr);

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

                List <SubCatgVO> list = this.subCatgManager.LoadData(false,null);
                cboxCatg.DataSource = list;
                cboxCatg.DisplayMember = "CName";
                cboxCatg.ValueMember = "CId__PK";


                Customer cust = new Customer();
                cust.Grade = GRADE.SUPPLIER;
                cust.St = ST.VALID;
                List<Customer> custs = custManager.LoadData(cust, null);

                List<Customer> ds = new List<Customer>();
                cust.CID__PK = 0;
                cust.CName = "--选择--";
                ds.Add(cust);
                ds.AddRange(custs);

                cboxSupplier.DisplayMember = "CName";
                cboxSupplier.ValueMember = "CID__PK";
                cboxSupplier.DataSource = ds;

                cboxSupplier.Enabled = true;
            }
            else
            {
                this.Text = "修改商品";
                List<SubCatgVO> list = this.subCatgManager.LoadData(true,null);
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

                cboxSupplier.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (cboxCatg.SelectedIndex == -1)
                return;
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

            if (!StringUtil.isEmpty(gId))
            {
                goods.GID__PK = int.Parse(gId);
                exCnt = manager.Update(goods);
            }
            else
            {
                int supplierId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
                if (supplierId != 0)
                    exCnt = manager.Save(goods, supplierId);
                else
                    exCnt = manager.Save(goods, null);
            }

            if (exCnt > 0)
            {
                chngFlag = true;
                MainForm.Info("保存成功！");
                if (!StringUtil.isEmpty(gId))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    txtGName.Text = string.Empty;
                    txtAbbr.Text = string.Empty;
                    txtRemark.Text = string.Empty;
                    txtSpecs.Text = string.Empty;
                    txtShelfLife.Text = string.Empty;
                }
            }
            else
                MainForm.Warn("保存失败！");
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            if(chngFlag == true)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { custManager };
        }
    }
}
