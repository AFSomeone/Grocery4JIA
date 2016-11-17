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
    public partial class MSupplyInfoForm : Form, IBaseForm
    {
        ICustomerManager custManager;
        int custId = 0;
        PageVO page;
        public MSupplyInfoForm()
        {
            InitializeComponent();
            Usr usr = MainForm.usr;
            page = new PageVO();
            page.PageNo = 1;
            if (null == custManager)
                custManager = InterfaceProxyGenerator.CreateInterfaceProxy<ICustomerManager>(usr);
            dtgvSpGoods.AutoGenerateColumns = false;

            Customer cust = new Customer();
            cust.St = ST.VALID;
            cust.Grade = GRADE.SUPPLIER;
            List<Customer> list = custManager.LoadData(cust, null);
            cboxSupplier.DataSource = list;
            cboxSupplier.DisplayMember = "CName";
            cboxSupplier.ValueMember = "CID__PK";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cboxSupplier.SelectedIndex == -1)
                return;
            custId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
            List<GoodsVO> list = custManager.LoadSupplyGoods(custId, page);
            dtgvSpGoods.Rows.Clear();
            foreach (GoodsVO vo in list)
            {
                int index = dtgvSpGoods.Rows.Add();
                InitRow(index, vo);
            }

            dgvPager.TotalNum = page.TotalNum;
            dgvPager.TotalPageNum = page.TotalPage;
            dgvPager.ShowPageInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboxSupplier.SelectedIndex == -1)
                return;
            int custId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
            string custName = StringUtil.Obj2Str(cboxSupplier.Text);
            AddGoods2CustForm gForm = new AddGoods2CustForm(custId,custName);
            DialogResult result = gForm.ShowDialog();
            if (result == DialogResult.OK)
                btnQuery.PerformClick();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSpGoods.SelectedRows)
            {
                int gId = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                int exCnt = custManager.DeleteSupplyGoods(custId,gId);
                if(exCnt>0)
                {
                    dtgvSpGoods.Rows.Remove(row);
                    btnQuery.PerformClick();
                }
                else
                    MainForm.Warn("删除失败！");
            }
        }

        private void InitRow(int index, GoodsVO vo)
        {
            dtgvSpGoods.Rows[index].Cells[colGID.Name].Value = vo.GID__PK;
            dtgvSpGoods.Rows[index].Cells[colGName.Name].Value = vo.GName;
            dtgvSpGoods.Rows[index].Cells[colShelfLife.Name].Value = vo.ShelfLife;
            dtgvSpGoods.Rows[index].Cells[colSpecs.Name].Value = vo.Specs;
            dtgvSpGoods.Rows[index].Cells[colCatg.Name].Value = vo.CatgName;
            dtgvSpGoods.Rows[index].Cells[colRemark.Name].Value = vo.Remark;
        }

        private void dgvPager_pagerBtnClicked(object sender, EventArgs e)
        {
            page.PageNo = dgvPager.PageNO;
            btnQuery.PerformClick();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { custManager };
        }
    }
}
