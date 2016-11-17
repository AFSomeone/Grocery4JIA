using BLL.Com;
using Model.Const;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using System;

namespace UI
{
    public partial class BillCnfrmDialog : Form, IBaseForm
    {
        ISupplierBillingManager supplierManager;
        IResellerBillingManager resellerManager;
        public BillCnfrmDialog(BilliingVO bill, object manager)
        {
            InitializeComponent();
            dtgvOrderGoods.AutoGenerateColumns = false;
            Text = "【账单】 " + bill.CustName;
            if (bill.Direct == PYMNT_DIRECT.PAY)
            {
                lblTotalTxt.Text = "总计应付（元）：";
                this.supplierManager = (ISupplierBillingManager)manager;
            }   
            else if (bill.Direct == PYMNT_DIRECT.RECEIVE)
            {
                lblTotalTxt.Text = "总计应收（元）：";
                this.resellerManager = (IResellerBillingManager)manager;
            }
                
            else
                return;
            lblTotal.Text = bill.Amount+"";
            Init(bill);
        }

        private void Init(BilliingVO bill)
        {
            List<OrderGoodsVO> list = null;
            if (bill.Direct == PYMNT_DIRECT.PAY)
                list = supplierManager.LoadOrderGoods((int)bill.CustID, bill._OrderNOList, null);
            else if (bill.Direct == PYMNT_DIRECT.RECEIVE)
                list = resellerManager.LoadOrderGoods((int)bill.CustID, bill._OrderNOList, null);

            foreach (OrderGoodsVO goods in list)
            {
                int index = dtgvOrderGoods.Rows.Add();
                dtgvOrderGoods.Rows[index].Cells[colOrderNO.Name].Value = goods.OrderNO;
                dtgvOrderGoods.Rows[index].Cells[colDirectDesc.Name].Value = DIRECT.DIRECT_MAP[goods.Direct];
                dtgvOrderGoods.Rows[index].Cells[colGID.Name].Value = goods.GID;
                dtgvOrderGoods.Rows[index].Cells[colGName.Name].Value = goods.GName;
                dtgvOrderGoods.Rows[index].Cells[colSpesc.Name].Value = goods.Specs;
                dtgvOrderGoods.Rows[index].Cells[colNum.Name].Value = goods.Num;
                dtgvOrderGoods.Rows[index].Cells[colPrice.Name].Value = goods.Price;
                dtgvOrderGoods.Rows[index].Cells[colCrtTmst.Name].Value = goods.Tmst;
                dtgvOrderGoods.Rows[index].Cells[colAmount.Name].Value = goods.Num * goods.Price;
            }
        }

        private void btnCnfrm_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<IBaseManager> getManagers()
        {
            throw null;
        }
    }
}
