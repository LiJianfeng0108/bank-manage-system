using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.money
{
    public partial class ShowCustomForm : Form
    {
        public ShowCustomForm()
        {
            InitializeComponent();
            BankDataContext c = new BankDataContext();
            var q = from t1 in c.AccountInfo
                    from t2 in c.MoneyInfo
                    where t1.帐号 == t2.帐号
                    select new
                    {
                        时间 = string.Format("{0:yyyy-MM-dd[HH:mm:ss]}", t2.发生时间),
                        帐号 = t1.帐号,
                        姓名 = t1.姓名,
                        存款类型 = t1.存款类型,
                        类别 = t2.发生类别,
                        金额 = string.Format("{0,8:f2}", t2.发生金额),
                        余额 = string.Format("{0,8:f2}", t2.余额)
                    };
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = q;
        }
    }
}

