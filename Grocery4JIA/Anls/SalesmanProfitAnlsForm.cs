using BLL.Com;
using BLL.Proxy;
using Model.VO;
using System;
using System.Windows.Forms;
using BLL;
using System.Collections.Generic;

namespace UI
{
    public partial class SalesmanProfitAnlsForm : Form, IBaseForm
    {
        private IDataAnlsManager anlsManager;
        public SalesmanProfitAnlsForm()
        {
            InitializeComponent();
            if (null == anlsManager)
                anlsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IDataAnlsManager>(MainForm.usr);
            DateTime beginDt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpBeginDt.Value = beginDt;
        }

        private void SalesmanProfitAnlsForm_Load(object sender, EventArgs e)
        {
            btnAnls.PerformClick();         
        }

        private void btnAnls_Click(object sender, EventArgs e)
        {
            AnlsRsltVO rsltVO = anlsManager.ProfitStatsByUsr(dtpBeginDt.Value, dtpEndDt.Value);
            if (null != rsltVO)
            {
                chartUsrProfit.Series[0].Points.DataBindXY(rsltVO.Xdata, rsltVO.Ydata);
            }
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { anlsManager };
        }
    }
}