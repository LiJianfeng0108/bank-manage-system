using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BankManageSystem.rate
{
    public partial class FlexibleForm : BankManageSystem.common.BasePanelForm
    {
        BankDataContext c;
        public FlexibleForm()
        {
            InitializeComponent();
            c = new BankDataContext();
            var q = (from t in c.RateInfo
                     where t.类别 == "活期"
                     select t).Single();
            txtOldRate.Text = q.利率.ToString("f4");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                float rate = float.Parse(txtNewRate.Text.ToString());
                c = new BankDataContext();
                var q = (from t in c.RateInfo
                         where t.类别 == "活期"
                         select t).Single();
                q.利率 = rate;
                c.SubmitChanges();
                MessageBox.Show("修改成功");
            }
            catch (Exception)
            {
                MessageBox.Show("请输入调整后利率");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
