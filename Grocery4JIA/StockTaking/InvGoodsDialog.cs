using BLL.Com;
using Model.Util;
using Model.VO;
using System;
using System.Windows.Forms;
using BLL;
using System.Collections.Generic;

namespace UI
{
    public partial class InvGoodsDialog : Form, IBaseForm
    {
        IInventoryManager manager;
        long invId = 0;
        int befNum = 0;
        public InvGoodsDialog(IInventoryManager manager, StockGoodsVO gvo)
        {
            InitializeComponent();
            this.manager = manager;
            txtGID.Text = gvo.GID+"";
            txtGName.Text = gvo.GName;
            txtSpecs.Text = gvo.Specs;
            txtOrderNo.Text = gvo.OrderNO;
            txtSupplier.Text = gvo.CustName;
            txtInvNum.Text = gvo.Num+"";
            invId = gvo.InvID;
            befNum = gvo.Num;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int? num = null;
            try
            {
                num = StringUtil.Obj2Int(txtInvNum.Text.Trim());
            }
            catch
            {
                MainForm.Warn("请输入正确的数字！");
                return;
            }
            if (num == befNum)
                return;
            try
            {
                int cnt = manager.UpdateInvNum(invId, befNum, (int)num, MainForm.usr);
                if (cnt > 0)
                    MainForm.Info("保存成功！");
                else
                    MainForm.Warn("保存失败！");
            }
            catch (Exception e1)
            {
                MainForm.Error(e1);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtInvNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyVal = Convert.ToInt32(e.KeyChar);
            if ((keyVal < 48 || keyVal > 57) && keyVal != 8 && keyVal != 13)
                e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<IBaseManager> getManagers()
        {
            return null;
        }
    }
}
