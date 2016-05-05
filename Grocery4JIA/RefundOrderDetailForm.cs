using BLL.Com;
using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class RefundOrderDetailForm : Form
    {
        RefundManager manager;
        public RefundOrderDetailForm(Order order, RefundManager manager)
        {
            InitializeComponent();
            dtgvRefundOrderDetail.AutoGenerateColumns = false;
            this.manager = manager;
            this.Text = "【" + order.CustName + "】 NO." + order.OrderNO;
            lblAmountValue.Text = order.Amount.ToString();
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
                List<RefundOrderDetailVO> data = manager.LoadOrderDetail(orderNO);
                if (null != data && data.Count > 0)
                {
                    dtgvRefundOrderDetail.DataSource = null;
                    dtgvRefundOrderDetail.DataSource = data;
                }
                else
                    dtgvRefundOrderDetail.DataSource = null;

            }
            catch(Exception e)
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e);
            }
        }
    }
}
