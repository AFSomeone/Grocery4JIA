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
    public partial class SinRefundForm : Form
    {
        RefundManager manager;
        string orderNO;
        Customer supplier;
        public SinRefundForm(List<InStockGoodsVO> list, Customer supplier)
        {
            InitializeComponent();
            dtgvRfGoods.AutoGenerateColumns = false;
            decimal total = 0;
            foreach (InStockGoodsVO goods in list)
            {
                int index = dtgvRfGoods.Rows.Add();
                InitRow(index, goods);
                total += goods.Price * goods.Num;
            }
            txtAmount.Text = total.ToString();
            if (null == manager)
                manager = new RefundManager();
            this.supplier = supplier;
            Text = supplier.CName;
        }

        private void InitRow(int index, InStockGoodsVO goods)
        {
            dtgvRfGoods.Rows[index].Cells[colSInOrderNO.Name].Value = goods.OrderNO;
            dtgvRfGoods.Rows[index].Cells[colGID.Name].Value = goods.GID;
            dtgvRfGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
            dtgvRfGoods.Rows[index].Cells[colSpecs.Name].Value = goods.Specs;
            dtgvRfGoods.Rows[index].Cells[colPrice.Name].Value = goods.Price;
            dtgvRfGoods.Rows[index].Cells[colInPric.Name].Value = goods.Price;
            dtgvRfGoods.Rows[index].Cells[colInvNum.Name].Value = goods.Num;
            dtgvRfGoods.Rows[index].Cells[colRfNum.Name].Value = goods.Num;
            dtgvRfGoods.Rows[index].Cells[colInvID.Name].Value = goods.InvID;
        }

        private void dtgvRfGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            object rfNumObj = null, rfPrice = null;
            if (dtgvRfGoods.Columns[e.ColumnIndex].Name == colPrice.Name)
            {
                rfPrice = dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (null != rfPrice)
                {
                    if (rfPrice.ToString().EndsWith("."))
                    {
                        rfPrice = rfPrice + "0";
                        dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = rfPrice;
                    }
                    if (rfPrice.ToString().StartsWith("."))
                    {
                        rfPrice = "0" + rfPrice;
                        dtgvRfGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = rfPrice;
                    }
                }
            }

            foreach (DataGridViewRow row in dtgvRfGoods.Rows)
            {
                rfNumObj = row.Cells[colRfNum.Name].Value;
                rfPrice = row.Cells[colPrice.Name].Value;

                if (null != rfNumObj && null != rfPrice)
                {
                    decimal price = StringUtil.Obj2Decimal(rfPrice);
                    total += StringUtil.Obj2Int(rfNumObj) * price;
                }
            }
            txtAmount.Text = total.ToString();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            RefundOrderVO refundVO = null;
            foreach (DataGridViewRow row in dtgvRfGoods.Rows)
            {
                Refund rf = new Refund();
                rf.Direct = DIRECT.REFUND2SUPPLIER;
                rf.InvID = StringUtil.Obj2Long(row.Cells[colInvID.Name].Value);
                rf.Num = StringUtil.Obj2Int(row.Cells[colRfNum.Name].Value);
                rf.Price = StringUtil.Obj2Decimal(row.Cells[colPrice.Name].Value);
                rf.St = ST.VALID;
               
                if (null == refundVO)
                {
                    refundVO = new RefundOrderVO();
                    refundVO.CustID = supplier.CID__PK;
                    refundVO.CustName = supplier.CName;
                    refundVO.Direct = DIRECT.REFUND2SUPPLIER;
                    refundVO.UptUID = MainForm.usr.UId__PK;
                    refundVO.CrtUID = MainForm.usr.UId__PK;
                    List<Refund> list = new List<Refund>();
                    list.Add(rf);
                    refundVO._RefundList = list;
                }
                else
                    refundVO._RefundList.Add(rf);
            }
            if (null != refundVO)
            {
                orderNO = manager.Refund(refundVO);
                if (!StringUtil.isEmpty(orderNO))
                {
                    MessageBox.Show("商品已退回！退单号：" + OrderNO, "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("商品退回失败！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgvRfGoods_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl cellEditor = e.Control as DataGridViewTextBoxEditingControl;
            cellEditor.SelectAll();
            cellEditor.KeyPress += Cell_KeyPress;
        }

        private void Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dtgvRfGoods.CurrentRow.Index < 0)
                return;
            int colIndex = dtgvRfGoods.CurrentCell.ColumnIndex;
            if (dtgvRfGoods.Columns[colIndex].Name == colRfNum.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                    e.Handled = true;
                if (keyVal >= 48 && keyVal <= 57)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (!StringUtil.isEmpty(srCellEditor.Text))
                    {
                        int invNum = StringUtil.Obj2Int(dtgvRfGoods.CurrentRow.Cells[colInvNum.Name].Value);
                        if (int.Parse(srCellEditor.Text + e.KeyChar) > invNum)
                            e.Handled = true;
                    }
                    else
                    {
                        if (keyVal == 48)
                            e.Handled = true;
                    }
                }
            }
            else if (dtgvRfGoods.Columns[colIndex].Name == colPrice.Name)
            {
                int keyVal = Convert.ToInt32(e.KeyChar);
                if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13 && keyVal != 46)
                    e.Handled = true;
                if ((keyVal >= 48 && keyVal <= 57) || keyVal == 46)
                {
                    DataGridViewTextBoxEditingControl srCellEditor = sender as DataGridViewTextBoxEditingControl;
                    if (!StringUtil.isEmpty(srCellEditor.Text))
                    {
                        if (keyVal != 46)
                        {
                            decimal price = StringUtil.Obj2Decimal(dtgvRfGoods.CurrentRow.Cells[colInPric.Name].Value);
                            if (StringUtil.Obj2Decimal(srCellEditor.Text + e.KeyChar) > price)
                                e.Handled = true;
                        }
                    }
                    else
                    {
                        if (keyVal == 46)
                            e.Handled = true;
                    }
                }
            }
        }

        public string OrderNO
        {
            get
            {
                return orderNO;
            }
        }
    }
}
