using BLL.Com;
using BLL.Proxy;
using Model.Const;
using Model.Entity;
using Model.VO;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using System;

namespace UI
{
    public partial class InvOprtChldDialog : Form, IBaseForm
    {
        IInventoryManager manager;
        public InvOprtChldDialog(long invId, string supplier, Goods goods)
        {
            InitializeComponent();
            dtgvChld.AutoGenerateColumns = false;
            if (null == manager)
                manager = InterfaceProxyGenerator.CreateInterfaceProxy<IInventoryManager>(MainForm.usr);
            Text = "库存变更流水【"+goods.GName+" "+goods.Specs+" @"+supplier+"】";
            List<InvOprtChldVO> list = manager.LoadOprtChld(invId);
            dtgvChld.DataSource = list;
        }

        private void dtgvChld_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvChld.Columns[e.ColumnIndex].Name == colOprt.Name)
            {
                if (null == e.Value || e.Value.ToString() == string.Empty)
                    return;
                e.Value = DIRECT.DIRECT_MAP[e.Value.ToString()];
            }
        }

        private void btnClsoe_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public List<IBaseManager> getManagers()
        {
            return new List<IBaseManager>() { manager };
        }
    }
}
