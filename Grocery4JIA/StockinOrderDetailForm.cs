using BLL.Com;
using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class StockinOrderDetailForm : Form
    {
        StockInManager manager;
        public StockinOrderDetailForm(Order order, StockInManager manager)
        {
            InitializeComponent();
            dtgvStockinOrderDetail.AutoGenerateColumns = false;
            this.Text = "【"+order.CustName+"】 NO."+ order.OrderNO;
            lblAmountValue.Text = order.Amount.ToString();
            this.manager = manager;
            BindData(order.OrderNO);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindData(string orderNO)
        {
            try
            {
                List<StockInOrderDetailVO> data = manager.LoadOrderDetail(orderNO);
                if (null != data && data.Count > 0)
                {
                    dtgvStockinOrderDetail.DataSource = null;
                    dtgvStockinOrderDetail.DataSource = data;
                }
                else
                    dtgvStockinOrderDetail.DataSource = null;
                
            }
            catch
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
