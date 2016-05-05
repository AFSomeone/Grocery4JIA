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
    public partial class MSupplyInfoForm : Form
    {
        CustomerManager custManager;
        int custId = 0;
        public MSupplyInfoForm()
        {
            InitializeComponent();
            if (null == custManager)
                custManager = new CustomerManager();
            dtgvSpGoods.AutoGenerateColumns = false;

            Customer cust = new Customer();
            cust.St = ST.VALID;
            cust.Grade = GRADE.SUPPLIER;
            List<Customer> list = custManager.LoadData(cust);
            cboxSupplier.DataSource = list;
            cboxSupplier.DisplayMember = "CName";
            cboxSupplier.ValueMember = "CID__PK";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            custId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
            List<GoodsVO> list = custManager.LoadSupplyGoods(custId);
            dtgvSpGoods.Rows.Clear();
            foreach (GoodsVO vo in list)
            {
                int index = dtgvSpGoods.Rows.Add();
                InitRow(index, vo);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnQuery_Click(btnQuery, new EventArgs());
            List<int> gIds = new List<int>();
            foreach (DataGridViewRow row in dtgvSpGoods.Rows)
            {
                int gId = StringUtil.Obj2Int(row.Cells[colGID.Name].Value);
                gIds.Add(gId);
            }
            int custId = StringUtil.Obj2Int(cboxSupplier.SelectedValue);
            string custName = StringUtil.Obj2Str(cboxSupplier.Text);
            AddGoods2CustForm gForm = new AddGoods2CustForm(gIds,custId,custName);
            DialogResult result = gForm.ShowDialog();
            if(result == DialogResult.OK)
                btnQuery_Click(btnQuery, new EventArgs());
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
                    btnQuery_Click(btnQuery, new EventArgs());
                }
                else
                    MessageBox.Show("删除失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
