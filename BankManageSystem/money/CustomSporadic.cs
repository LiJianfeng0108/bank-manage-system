using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankManageSystem.money;
using BankManageSystem;
using System.Windows.Forms;

namespace BankManageSystem
{
    public class CustomSporadic : Custom
    {
        /// 开户
        /// </summary>
        /// <param name="accountNumber">帐号</param>
        /// <param name="money">开户金额</param>
        public override void Create(string accountNumber, double money)
        {
            if (money < 5)
            {
                MessageBox.Show("零存整取5元起存。");
                return;
            }
            base.Create(accountNumber, money);
        }

        /// <summary>
        ///存款 
        /// </summary>
        public override void Diposit(string genType, double money)
        {
            BankDataContext c = new BankDataContext();
            var q = from t in c.MoneyInfo
                    where t.帐号 == this.AccountInfo.帐号
                    select t.发生时间;

            //计算日期差
            
            TimeSpan ts1;

            ts1 = DateTime.Now.Subtract(q.Max().Date);
            if (ts1.TotalDays >= 62)
            {
                MessageBox.Show("该账户没能按规定存款，已失效，请及时取出存款！");
                return;
            }
                      
            int time1 = q.Max().Date.Month;
            int time2 = DateTime.Now.Month;
            int ts = time2 - time1;

            if (ts == 0)
            {
                MessageBox.Show("该账户本月已存过款！");
                return;
            }
            else if(ts!=1&&ts!=-11)
            {
                MessageBox.Show("该账户没能按规定存款，已失效，请及时取出存款！");
                return;
            }

            base.Diposit("存款", money);
        }

        /// <summary>
        ///取款 
        /// </summary>
        /// <param name="money">取款金额</param>
        public override void Withdraw(double money)
        {

            //结算利息
            
            BankDataContext c = new BankDataContext();
            var q = from t in c.MoneyInfo
                    where t.帐号 == this.AccountInfo.帐号
                    select t;
            int count = q.Count();

            if (count < 12)
            {
                base.Diposit("结算利息", DataOperation.GetRate(RateType.零存整取违规) * this.AccountBalance);
            }
            else
            {
                int t1 = DateTime.Now.Year - q.Min().发生时间.Date.Year;
                int t2 = DateTime.Now.Month - q.Min().发生时间.Date.Month;
                int t3 = t1 * 12 + t2 * -1;

                if (count >= t3&&count>=12)
                {
                    if (count < 36)
                    {
                        base.Diposit("结算利息", DataOperation.GetRate(RateType.零存整取1年) * (this.AccountBalance / count) * 12
                            + (this.AccountBalance + DataOperation.GetRate(RateType.零存整取1年) * (this.AccountBalance / count) * 12 * DataOperation.GetRate(RateType.零存整取超期部分)));
                    }
                    else if (count < 60)
                    {
                        base.Diposit("结算利息", DataOperation.GetRate(RateType.零存整取3年) * (this.AccountBalance / count) * 36
                            + (this.AccountBalance + DataOperation.GetRate(RateType.零存整取3年) * (this.AccountBalance / count) * 36 * DataOperation.GetRate(RateType.零存整取超期部分)));
                    }
                    else
                    {
                        base.Diposit("结算利息", DataOperation.GetRate(RateType.零存整取5年) * (this.AccountBalance/count)*60
                            +(this.AccountBalance+DataOperation.GetRate(RateType.零存整取5年) * (this.AccountBalance/count)*60*DataOperation .GetRate(RateType.零存整取超期部分)));
                    }
                }
                else
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.零存整取违规) * this.AccountBalance);
                }
            }
            if (!ValidBeforeWithdraw(money)) return;
            //取款
            base.Withdraw(this.AccountBalance);
        }
    }
}
