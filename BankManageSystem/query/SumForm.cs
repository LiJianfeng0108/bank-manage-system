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
    public partial class SumForm : BankManageSystem.common.BasePanelForm
    {
        public SumForm()
        {
            InitializeComponent();

                BankDataContext c = new BankDataContext();
                //在dataGridView中显示当天金额发生数据
                var q = from t1 in c.AccountInfo
                        from t2 in c.MoneyInfo
                        where t1.帐号 == t2.帐号
                        where t2.发生时间.Day == DateTime.Now.Day
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
                dataGridView1.DataSource = q;
                //计算显示当天存款总汇，取款总会，金额总汇
                var q1 = from t1 in c.AccountInfo
                         from t2 in c.MoneyInfo
                         where t1.帐号 == t2.帐号
                         where t2.发生时间.Day == DateTime.Now.Day
                         where t2.发生类别 == "存款" || t2.发生类别 == "开户"
                         select t2.发生金额;

                var q2 = from t1 in c.AccountInfo
                         from t2 in c.MoneyInfo
                         where t1.帐号 == t2.帐号
                         where t2.发生时间.Day == DateTime.Now.Day
                         where t2.发生类别 == "取款"
                         select t2.发生金额;

                if (q1.Count() == 0)
                {
                    if (q2.Count() == 0)
                    {
                        txtDespoit.Text = "0";
                        textWithdraw.Text = "0";
                        textSum.Text = "0";
                        dataGridView1.DataSource = q;
                    }
                    else
                    {
                        txtDespoit.Text = "0";
                        textWithdraw.Text = Math.Abs(q2.Sum()).ToString();
                        textSum.Text = (q1.Sum() + q2.Sum()).ToString();
                        dataGridView1.DataSource = q;
                    }

                }
                else
                {
                    if (q2.Count() == 0)
                    {
                        txtDespoit.Text = q1.Sum().ToString();
                        textWithdraw.Text = "0";
                        textSum.Text = q1.Sum().ToString();
                        dataGridView1.DataSource = q;
                    }
                    else
                    {
                        txtDespoit.Text = q1.Sum().ToString();
                        textWithdraw.Text = Math.Abs(q2.Sum()).ToString();
                        textSum.Text = (q1.Sum() + q2.Sum()).ToString();
                        dataGridView1.DataSource = q;
                    }
                }

        }
        // 查询其他日期的金额总汇
        private void btnTotal_Click(object sender, EventArgs e)
        {
            BankDataContext c = new BankDataContext();
            var q = from t1 in c.AccountInfo
                    from t2 in c.MoneyInfo
                    where t1.帐号 == t2.帐号
                    where t2.发生时间.Year == dateTimePicker1.Value.Year && t2.发生时间.Month == dateTimePicker1.Value.Month && t2.发生时间.Day == dateTimePicker1.Value.Day
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
            if (dateTimePicker1.Value.Year == DateTime.Now.Year && dateTimePicker1.Value.Month == DateTime.Now.Month && dateTimePicker1.Value.Day == DateTime.Now.Day)
            {
                labDespoit.Text = "今日取款金额";
                labWithdraw.Text = "今日取款金额";
                labSum.Text = "今日金额总汇";
            }
            else
            {
                labDespoit.Text = dateTimePicker1.Text + "存款金额：";
                labWithdraw.Text = dateTimePicker1.Text + "取款总汇";
                labSum.Text = dateTimePicker1.Text+"金额总汇";    
            }
            var q1 = from t1 in c.AccountInfo
                      from t2 in c.MoneyInfo
                      where t1.帐号 == t2.帐号
                     where t2.发生时间.Year == dateTimePicker1.Value.Year && t2.发生时间.Month == dateTimePicker1.Value.Month && t2.发生时间.Day == dateTimePicker1.Value.Day
                      where t2.发生类别 == "存款" || t2.发生类别 == "开户"
                      select t2.发生金额;
            var q2 = from t1 in c.AccountInfo
                     from t2 in c.MoneyInfo
                     where t1.帐号 == t2.帐号
                     where t2.发生时间.Year == dateTimePicker1.Value.Year && t2.发生时间.Month == dateTimePicker1.Value.Month && t2.发生时间.Day == dateTimePicker1.Value.Day
                     where t2.发生类别 == "取款"
                     select t2.发生金额;
            if (q1.Count() == 0)
            {
                if (q2.Count() == 0)
                {
                    txtDespoit.Text = "0";
                    textWithdraw.Text = "0";
                    textSum.Text = "0";
                    dataGridView1.DataSource = q;
                }
                else
                {
                    txtDespoit.Text = "0";
                    textWithdraw.Text = Math.Abs(q2.Sum()).ToString();
                    textSum.Text = (q1.Sum() + q2.Sum()).ToString();
                    dataGridView1.DataSource = q;
                }

            }
            else
            {
                if (q2.Count() == 0)
                {
                    txtDespoit.Text = q1.Sum().ToString();
                    textWithdraw.Text = "0";
                    textSum.Text = q1.Sum().ToString();
                    dataGridView1.DataSource = q;
                }
                else
                {
                    txtDespoit.Text = q1.Sum().ToString();
                    textWithdraw.Text = Math.Abs(q2.Sum()).ToString();
                    textSum.Text = (q1.Sum() + q2.Sum()).ToString();
                    dataGridView1.DataSource = q;
                }
            }
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                dateTimePicker1.Text = "";
            }
        }
 
    }
}
