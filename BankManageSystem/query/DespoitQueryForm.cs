using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BankManageSystem.query
{
    public partial class DespoitQueryForm : BankManageSystem.common.BasePanelForm
    {
        public DespoitQueryForm()
        {

            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            label3.Hide();
            BankDataContext c = new BankDataContext();
            var q = from t1 in c.AccountInfo
                    from t2 in c.MoneyInfo
                    where t1.帐号 == t2.帐号
                    where t2.发生类别 == "存款" || t2.发生类别 == "开户"
                    where t1.身份证号 == txtID.Text
                    select new
                    {
                        身份证号 = t1.身份证号,
                        姓名 = t1.姓名,
                        帐号 = t1.帐号,
                        存款类型 = t2.发生类别,
                        余额 = string.Format("{0,8:f2}", t2.余额),
                    };
            dataGridView1.DataSource = q;
        }

    }
}
