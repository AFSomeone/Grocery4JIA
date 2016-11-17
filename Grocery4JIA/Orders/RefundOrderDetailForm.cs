using BLL.Com;
using Model.Const;
using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class RefundOrderDetailForm : Form, IBaseForm
    {
        IResellerRefundManager resellerManager;
        IRefund2SupplierManager supplierManager;
        public RefundOrderDetailForm(Order order, object manager)
        {
            InitializeComponent();
            dtgvRefundOrderDetail.AutoGenerateColumns = false;
            if (DIRECT.RESELLER_REFUND == order.Direct)
            {
                colTgtOrderNO.HeaderText = "出货单号";
                colPrice.HeaderText = "回收价/元";
                colNum.HeaderText = "回收量";
                resellerManager = (IResellerRefundManager)manager;
            }
            else if (DIRECT.REFUND2SUPPLIER == order.Direct)
            {
                colTgtOrderNO.HeaderText = "进货单号";
                colPrice.HeaderText = "退货价/元";
                colNum.HeaderText = "退货量";
                supplierManager = (IRefund2SupplierManager)manager;
            }
            else
                return;
            this.Text = "【" + order.CustName + "】 NO." + order.OrderNO__PK;
            lblAmountValue.Text = order.Amount.ToString();
            BindData(order.OrderNO__PK, order.Direct);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindData(string orderNO, string direct)
        {
            try
            {
                List<RefundOrderDetailVO> data = null;
                if (direct == DIRECT.REFUND2SUPPLIER)
                    data = supplierManager.LoadOrderDetail(orderNO, null);
                else if (direct == DIRECT.RESELLER_REFUND)
                    data = resellerManager.LoadOrderDetail(orderNO, null);
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

        public List<IBaseManager> getManagers()
        {
            return null;
        }
    }
}
