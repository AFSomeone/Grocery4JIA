using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class OrderCnfrmDialog : Form
    {
        public OrderCnfrmDialog(string text, List<OrderGoodsVO> glist)
        {
            InitializeComponent();
            Text = text;
            decimal amount = 0;
            foreach (OrderGoodsVO vo in glist)
            {
                int index = dtgvOrderGList.Rows.Add();
                InitRow(index, vo);
                amount += vo.Num * vo.Price;
            }
            lblTotalAmount.Text = amount.ToString();
        }

        private void InitRow(int index, OrderGoodsVO vo)
        {
            dtgvOrderGList.Rows[index].Cells[colGID.Name].Value = vo.GID;
            dtgvOrderGList.Rows[index].Cells[colGNane.Name].Value = vo.GName;
            dtgvOrderGList.Rows[index].Cells[colNum.Name].Value = vo.Num;
            dtgvOrderGList.Rows[index].Cells[colPrice.Name].Value = vo.Price;
            dtgvOrderGList.Rows[index].Cells[colSpecs.Name].Value = vo.Specs;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}