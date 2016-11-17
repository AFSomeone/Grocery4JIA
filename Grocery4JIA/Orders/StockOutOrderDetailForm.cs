
using BLL.Com;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using System;

namespace UI
{
    public partial class StockOutOrderDetailForm : Form, IBaseForm
    {
        IStockOutManager manager;
        public StockOutOrderDetailForm(Order order, IStockOutManager manager)
        {
            InitializeComponent();
            dtgvSOutOrderDetail.AutoGenerateColumns = false;
            this.Text = "【" + order.CustName + "】 NO." + order.OrderNO__PK;
            lblAmountValue.Text = order.Amount.ToString();
            this.manager = manager;
            BindData(order.OrderNO__PK);
        }

        private void BindData(string orderNO)
        {
            try
            {
                List<StockOutOrderDetailVO> data = manager.LoadOrderDetail(orderNO,null);
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

        public List<IBaseManager> getManagers()
        {
            return null;
        }
    }
}
