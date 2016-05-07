
using BLL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class StockOutOrderDetailForm : Form
    {
        StockOutManager manager;
        public StockOutOrderDetailForm(Order order, StockOutManager manager)
        {
            InitializeComponent();
            dtgvSOutOrderDetail.AutoGenerateColumns = false;
            this.Text = "【" + order.CustName + "】 NO." + order.OrderNO;
            lblAmountValue.Text = order.Amount.ToString();
            this.manager = manager;
            BindData(order.OrderNO);
        }

        private void BindData(string orderNO)
        {
            try
            {
                List<StockOutOrderDetailVO> data = manager.LoadOrderDetail(orderNO);
                if (null != data && data.Count > 0)
                {
                    dtgvSOutOrderDetail.DataSource = null;
                    dtgvSOutOrderDetail.DataSource = data;
                }
                else
                    dtgvSOutOrderDetail.DataSource = null;

            }
            catch
            {
                MessageBox.Show("系统异常！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
