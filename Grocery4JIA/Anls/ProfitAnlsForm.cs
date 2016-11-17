using BLL.Com;
using BLL.Proxy;
using Model.Entity;
using Model.Util;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class ProfitAnlsForm : Form, IBaseForm
    {
        IGoodsManager goodsManager;
        IDataAnlsManager anlsManager;
        ISubCatgManager subCatgManager;
        public ProfitAnlsForm()
        {
            InitializeComponent();
            numudYear.Maximum = DateTime.Now.Year;
            numudYear.Value = DateTime.Now.Year;
            if (null == goodsManager)
                goodsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IGoodsManager>(MainForm.usr);
            if(null == anlsManager)
                anlsManager = InterfaceProxyGenerator.CreateInterfaceProxy<IDataAnlsManager>(MainForm.usr);
            if(null == subCatgManager)
                subCatgManager = InterfaceProxyGenerator.CreateInterfaceProxy<ISubCatgManager>(MainForm.usr);

            List<SubCatgVO> subCatgs = subCatgManager.LoadData(false, null);
            List<SubCatgVO> list = new List<SubCatgVO>();
            SubCatgVO subCatg = new SubCatgVO();
            subCatg.CName = "全部";
            subCatg.CId__PK = 0;
            list.Add(subCatg);
            list.AddRange(subCatgs);
            cboxCatg.DisplayMember = "CName";
            cboxCatg.ValueMember = "CID__PK";
            cboxCatg.DataSource = list;
        }

        private void SalesAnlsForm_Load(object sender, EventArgs e)
        {
            btnAnls.PerformClick();            
        }

        private void autxtGoods_loadData(object sender, EventArgs e)
        {
            string term = autxtGoods.Term;
            List<auto_text.AutoData> data = new List<auto_text.AutoData> ();
            if (term.Trim().Length > 0)
            {
                List<Goods> list = goodsManager.LoadDataByKeyWords(term.Trim(), null);
                foreach(Goods goods in list)
                {
                    auto_text.AutoData adata = new auto_text.AutoData();
                    adata.Text = goods.GName + " [" + goods.Specs + "]";
                    adata.Val = goods.GID__PK;
                    data.Add(adata);
                }
            }
            autxtGoods.Data = data;
        }

        private void btnAnls_Click(object sender, EventArgs e)
        {
            int year = (int)numudYear.Value;
            short catgId = 0;
            if (cboxCatg.SelectedIndex != -1)
                catgId = StringUtil.Obj2Short(cboxCatg.SelectedValue);
            int? gId = null;
            if (null != autxtGoods.SelectedObj)
                gId = StringUtil.Obj2Int(autxtGoods.SelectedObj);
            AnlsRsltVO rsltVO = anlsManager.ProfitStatsByMonth(year, catgId, gId);
            if (null != rsltVO)
            {
                chartYearProfit.Series[0].Points.DataBindXY(rsltVO.Xdata, rsltVO.Ydata);
                decimal total = 0;
                if (null != rsltVO.Ydata)
                {
                    foreach (decimal val in rsltVO.Ydata)
                        total += val;
                    chartYearProfit.Titles[0].Text = "总计：" + string.Format("{0:C}", total);
                }
            }
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { anlsManager, goodsManager, subCatgManager };
        }
    }
}
