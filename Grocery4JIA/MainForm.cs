using Model.Const;
using Model.Entity;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        MCustomersForm mCustomersFrom;
        MGoodsForm mGoodsFrom;
        MStockinForm mStockinFrom;
        //MSinRefundForm mSinRefundFrom;
        MSupplyInfoForm mSupplyInfoForm;
        MStockOutForm mStockoutForm;
        MRefund2SupplierForm mRefund2SupplierForm;
        public static Usr usr;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            DialogResult result = loginForm.ShowDialog();
            Usr loginUsr = loginForm.loginUsr;
            if (result == DialogResult.Cancel || null == loginUsr)
            {
                this.Close();
                Application.Exit();
                return;
            }  
            if (result == DialogResult.OK)
                loginForm.Close();
            this.Show();
            MainForm.usr = loginUsr;
        }

        private void InitMGoods()
        {
            pnlMain.Controls.Clear();
            if (null != mGoodsFrom)
            {
                mGoodsFrom.Close();
                mGoodsFrom = null;
            }
            if (null == mGoodsFrom)
                mGoodsFrom = new MGoodsForm();
            mGoodsFrom.TopLevel = false;
            pnlMain.Controls.Add(mGoodsFrom);
            mGoodsFrom.Width = pnlMain.Width;
            mGoodsFrom.Height = pnlMain.Height;
            mGoodsFrom.Show();
        }

        private void InitMCustomers(string grade)
        {
            pnlMain.Controls.Clear();
            if (null != mCustomersFrom)
            {
                mCustomersFrom.Close();
                mCustomersFrom = null;
            }
            if (null == mCustomersFrom)
                mCustomersFrom = new MCustomersForm(grade);
            mCustomersFrom.TopLevel = false;
            pnlMain.Controls.Add(mCustomersFrom);
            mCustomersFrom.Width = pnlMain.Width;
            mCustomersFrom.Height = pnlMain.Height;
            mCustomersFrom.Show();
        }

        private void InitMStockin()
        {
            pnlMain.Controls.Clear();
            if (null != mStockinFrom)
            {
                mStockinFrom.Close();
                mStockinFrom = null;
            }
            if (null == mStockinFrom)
                mStockinFrom = new MStockinForm();
            mStockinFrom.TopLevel = false;
            pnlMain.Controls.Add(mStockinFrom);
            mStockinFrom.Width = pnlMain.Width;
            mStockinFrom.Height = pnlMain.Height;
            mStockinFrom.Show();
        }

        /*
        private void initSinRefund()
        {
            pnlMain.Controls.Clear();
            if (null != mSinRefundFrom)
            {
                mSinRefundFrom.Close();
                mSinRefundFrom = null;
            }
            if (null == mSinRefundFrom)
                mSinRefundFrom = new MSinRefundForm();
            mSinRefundFrom.TopLevel = false;
            pnlMain.Controls.Add(mSinRefundFrom);
            mSinRefundFrom.Width = pnlMain.Width;
            mSinRefundFrom.Height = pnlMain.Height;
            mSinRefundFrom.Show();
        }
        */

        private void InitRefnd2Supplier()
        {
            pnlMain.Controls.Clear();
            if (null != mRefund2SupplierForm)
            {
                mRefund2SupplierForm.Close();
                mRefund2SupplierForm = null;
            }
            if (null == mRefund2SupplierForm)
                mRefund2SupplierForm = new MRefund2SupplierForm();
            mRefund2SupplierForm.TopLevel = false;
            pnlMain.Controls.Add(mRefund2SupplierForm);
            mRefund2SupplierForm.Width = pnlMain.Width;
            mRefund2SupplierForm.Height = pnlMain.Height;
            mRefund2SupplierForm.Show();
        }

        private void InitSupplyInfoForm()
        {
            pnlMain.Controls.Clear();
            if (null != mSupplyInfoForm)
            {
                mSupplyInfoForm.Close();
                mSupplyInfoForm = null;
            }
            if (null == mSupplyInfoForm)
                mSupplyInfoForm = new MSupplyInfoForm();
            mSupplyInfoForm.TopLevel = false;
            pnlMain.Controls.Add(mSupplyInfoForm);
            mSupplyInfoForm.Width = pnlMain.Width;
            mSupplyInfoForm.Height = pnlMain.Height;
            mSupplyInfoForm.Show();
        }

        private void InitMStockoutForm()
        {
            pnlMain.Controls.Clear();
            if (null != mStockoutForm)
            {
                mStockoutForm.Close();
                mStockoutForm = null;
            }
            if (null == mStockoutForm)
                mStockoutForm = new MStockOutForm();
            mStockoutForm.TopLevel = false;
            pnlMain.Controls.Add(mStockoutForm);
            mStockoutForm.Width = pnlMain.Width;
            mStockoutForm.Height = pnlMain.Height;
            mStockoutForm.Show();
        }

        private void muitCategory_Click(object sender, EventArgs e)
        {
            CatgForm catgForm = new CatgForm();
            catgForm.ShowDialog();
        }

        private void muitSubCategory_Click(object sender, EventArgs e)
        {
            SubCatgForm subCatgForm = new SubCatgForm();
            subCatgForm.ShowDialog();
        }

        private void muitSupplier_Click(object sender, EventArgs e)
        {
            InitMCustomers(GRADE.SUPPLIER);
        }

        private void muitReseller_Click(object sender, EventArgs e)
        {
            InitMCustomers(GRADE.RESELLER);
        }

        private void muitGoods_Click(object sender, EventArgs e)
        {
            InitMGoods();
        }

        private void muitStockin_Click(object sender, EventArgs e)
        {
            InitMStockin();
        }

        private void muitRefund_Click(object sender, EventArgs e)
        {
            InitRefnd2Supplier();
        }

        private void suitSpplyInfo_Click(object sender, EventArgs e)
        {
            InitSupplyInfoForm();
        }

        private void muitStockOut_Click(object sender, EventArgs e)
        {
            InitMStockoutForm();
        }
    }
}
