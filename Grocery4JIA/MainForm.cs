using BLL;
using BLL.Admin;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        MCustomersForm mCustomersFrom;
        MGoodsForm mGoodsFrom;
        MStockInForm mStockinFrom;
        MSupplyInfoForm mSupplyInfoForm;
        MStockOutForm mStockoutForm;
        MRefund2SupplierForm mRefund2SupplierForm;
        MResellerRefundForm mResellerRefundForm;
        MCustAcntForm mCustAcntFrom;
        MSupplierBillingForm mSupplierBillingForm;
        MResellerBillingForm mResellerBillngForm;
        MUsrsForm mUsrsFrom;
        MStocktakingForm mStocktakingForm;

        IUsrAuthManager authManager;
        public static Usr usr;

        public MainForm()
        {
            InitializeComponent();
            if (null == authManager)
                authManager = InterfaceProxyGenerator.CreateInterfaceProxy<IUsrAuthManager>(null);
        }

        public static void Info(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(string msg)
        {
            MessageBox.Show(msg, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg)
        {
            MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Error(Exception e)
        {
            MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
            Usr loginUsr = loginForm.loginUsr;
            if (result == DialogResult.Cancel || null == loginUsr)
            {
                Close();
                Application.Exit();
                return;
            }
            if (result == DialogResult.OK)
            {
                loginForm.Close();
            }
            usr = loginUsr;
            Show();
            InitMenus();
        }

        private void InitMenus()
        {
            List<UsrAuth> authList = authManager.LoadUsrAuth(usr.UId__PK);
            List<string> funcIds = new List<string>();
            foreach (UsrAuth auth in authList)
            {
                funcIds.Add(auth.FuncID__PK);
            }
            foreach (ToolStripMenuItem item in MuMain.Items)
            {
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    if (null == subItem.Tag)
                        continue;
                    string fId = StringUtil.Obj2Str(subItem.Tag);
                    if (funcIds.Contains(fId))
                        subItem.Enabled = true;
                    else
                        subItem.Enabled = false;
                } 
            }
            authManager.close();
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
                mStockinFrom = new MStockInForm();
            mStockinFrom.TopLevel = false;
            pnlMain.Controls.Add(mStockinFrom);
            mStockinFrom.Width = pnlMain.Width;
            mStockinFrom.Height = pnlMain.Height;
            mStockinFrom.Show();
        }

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

        private void InitMResellerRefundForm()
        {
            pnlMain.Controls.Clear();
            if (null != mResellerRefundForm)
            {
                mResellerRefundForm.Close();
                mResellerRefundForm = null;
            }
            if (null == mResellerRefundForm)
                mResellerRefundForm = new MResellerRefundForm();
            mResellerRefundForm.TopLevel = false;
            pnlMain.Controls.Add(mResellerRefundForm);
            mResellerRefundForm.Width = pnlMain.Width;
            mResellerRefundForm.Height = pnlMain.Height;
            mResellerRefundForm.Show();
        }

        private void InitMCustAcntFrom()
        {
            pnlMain.Controls.Clear();
            if (null != mCustAcntFrom)
            {
                mCustAcntFrom.Close();
                mCustAcntFrom = null;
            }
            if (null == mCustAcntFrom)
                mCustAcntFrom = new MCustAcntForm();
            mCustAcntFrom.TopLevel = false;
            pnlMain.Controls.Add(mCustAcntFrom);
            mCustAcntFrom.Width = pnlMain.Width;
            mCustAcntFrom.Height = pnlMain.Height;
            mCustAcntFrom.Show();
        }

        private void InitMSupplierBillingForm()
        {
            pnlMain.Controls.Clear();
            if (null != mSupplierBillingForm)
            {
                mSupplierBillingForm.Close();
                mSupplierBillingForm = null;
            }
            if (null == mSupplierBillingForm)
                mSupplierBillingForm = new MSupplierBillingForm();
            mSupplierBillingForm.TopLevel = false;
            pnlMain.Controls.Add(mSupplierBillingForm);
            mSupplierBillingForm.Width = pnlMain.Width;
            mSupplierBillingForm.Height = pnlMain.Height;
            mSupplierBillingForm.Show();
        }

        private void InitMResellerBillingForm()
        {
            pnlMain.Controls.Clear();
            if (null != mResellerBillngForm)
            {
                mResellerBillngForm.Close();
                mResellerBillngForm = null;
            }
            if (null == mResellerBillngForm)
                mResellerBillngForm = new MResellerBillingForm();
            mResellerBillngForm.TopLevel = false;
            pnlMain.Controls.Add(mResellerBillngForm);
            mResellerBillngForm.Width = pnlMain.Width;
            mResellerBillngForm.Height = pnlMain.Height;
            mResellerBillngForm.Show();
        }
        
        private void InitMUsrsForm()
        {
            pnlMain.Controls.Clear();
            if (null != mUsrsFrom)
            {
                mUsrsFrom.Close();
                mUsrsFrom = null;
            }
            if (null == mUsrsFrom)
                mUsrsFrom = new MUsrsForm();
            mUsrsFrom.TopLevel = false;
            pnlMain.Controls.Add(mUsrsFrom);
            mUsrsFrom.Width = pnlMain.Width;
            mUsrsFrom.Height = pnlMain.Height;
            mUsrsFrom.Show();
        }

        private void InitMStocktakingForm()
        {
            pnlMain.Controls.Clear();
            if (null != mStocktakingForm)
            {
                mStocktakingForm.Close();
                mStocktakingForm = null;
            }
            if (null == mStocktakingForm)
                mStocktakingForm = new MStocktakingForm();
            mStocktakingForm.TopLevel = false;
            pnlMain.Controls.Add(mStocktakingForm);
            mStocktakingForm.Width = pnlMain.Width;
            mStocktakingForm.Height = pnlMain.Height;
            mStocktakingForm.Show();
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

        private void muitSOutRefund_Click(object sender, EventArgs e)
        {
            InitMResellerRefundForm();
        }

        private void suitCustAcnt_Click(object sender, EventArgs e)
        {
            InitMCustAcntFrom();
        }

        private void muitSupplierBill_Click(object sender, EventArgs e)
        {
            InitMSupplierBillingForm();
        }

        private void muitResellerBill_Click(object sender, EventArgs e)
        {
            InitMResellerBillingForm();
        }

        private void muitUsrs_Click(object sender, EventArgs e)
        {
            InitMUsrsForm();
        }

        private void muitStocktaking_Click(object sender, EventArgs e)
        {
            InitMStocktakingForm();
        }

        private void tsbtnStocktaking_Click(object sender, EventArgs e)
        {
            muitStocktaking.PerformClick();
        }

        private void tsbtnRf2Supplier_Click(object sender, EventArgs e)
        {
            muitRefund.PerformClick();
        }

        private void tsbtnStockIn_Click(object sender, EventArgs e)
        {
            muitStockin.PerformClick();
        }

        private void tsbtnStockOut_Click(object sender, EventArgs e)
        {
            muitStockOut.PerformClick();
        }

        private void tsbtnRsellerRf_Click(object sender, EventArgs e)
        {
            muitSOutRefund.PerformClick();
        }

        private void tsbtnSupplierBill_Click(object sender, EventArgs e)
        {
            muitSupplierBill.PerformClick();
        }

        private void tsbtnResellerBill_Click(object sender, EventArgs e)
        {
            muitResellerBill.PerformClick();
        }


        private void muitCategory_Click(object sender, EventArgs e)
        {
            CatgForm catgForm = new CatgForm();
            catgForm.ShowDialog();
            catgForm.FormClosed += Form_Close;
        }

        private void muitSubCategory_Click(object sender, EventArgs e)
        {
            SubCatgForm subCatgForm = new SubCatgForm();
            subCatgForm.ShowDialog();
            subCatgForm.FormClosed += Form_Close;
        }

        private void muitAuths_Click(object sender, EventArgs e)
        {
            UsrAuthForm authForm = new UsrAuthForm();
            authForm.ShowDialog();
            authForm.FormClosed += Form_Close;
        }

        private void muitAbout_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDiaglog = new AboutDialog();
            aboutDiaglog.ShowDialog();
            aboutDiaglog.FormClosed += Form_Close; 
        }

        private void muitSlesmanProfitAnls_Click(object sender, EventArgs e)
        {
            SalesmanProfitAnlsForm anlsForm = new SalesmanProfitAnlsForm();
            anlsForm.ShowDialog();
            anlsForm.FormClosed += Form_Close;
        }

        private void muitProfitAnls_Click(object sender, EventArgs e)
        {
            ProfitAnlsForm anlsForm = new ProfitAnlsForm();
            anlsForm.ShowDialog();
            anlsForm.FormClosed += Form_Close;
        }

        private void pnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is IBaseForm)
            {
                DisposeBaseForm(e.Control as IBaseForm);
            }
        }

        private void DisposeBaseForm(IBaseForm form)
        {
            if (null == form)
                return;
            List<IBaseManager> mgrs = form.getManagers();
            if (null != mgrs)
            {
                foreach (IBaseManager mgr in mgrs)
                {
                    if (null != mgr)
                        mgr.close();
                }

            }
        }

        private void Form_Close(object sender, EventArgs e)
        {
            if (sender is IBaseForm)
            {
                DisposeBaseForm(sender as IBaseForm);
            }
        }
    }
}
