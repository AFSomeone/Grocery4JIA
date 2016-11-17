using BLL.Com;
using BLL.Proxy;
using Model.Entity;
using Model.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class OrderPrinterForm : Form, IBaseForm
    {
        IStockOutManager manager;
        string orderNo;
        public OrderPrinterForm(string orderNo)
        {
            InitializeComponent();
            Usr usr = MainForm.usr;
            this.orderNo = orderNo;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IStockOutManager>(usr);
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager };
        }

        private void OrderPrinterForm_Load(object sender, EventArgs e)
        {

            List<StockOutOrderDetailVO> list = manager.LoadOrderDetail(orderNo, null);
            this.StockOutOrderDetailVOBindingSource.DataSource = list;
            this.reportViewer1.RefreshReport(); 
        }
    }
}
