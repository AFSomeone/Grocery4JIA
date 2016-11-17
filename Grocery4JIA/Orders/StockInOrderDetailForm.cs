using BLL.Com;
using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class StockInOrderDetailForm : Form, IBaseForm
    {
        IStockInManager manager;
        public StockInOrderDetailForm(Order order, IStockInManager manager)
        {
            InitializeComponent();
            dtgvStockinOrderDetail.AutoGenerateColumns = false;
            this.Text = "【"+order.CustName+"】 NO."+ order.OrderNO__PK;
            lblAmountValue.Text = order.Amount.ToString();
            this.manager = manager;
            BindData(order.OrderNO__PK);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindData(string orderNO)
        {
            try
            {
                List<StockInOrderDetailVO> data = manager.LoadOrderDetail(orderNO, null);
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

        public List<IBaseManager> getManagers()
        {
            return null;
        }
    }
}
