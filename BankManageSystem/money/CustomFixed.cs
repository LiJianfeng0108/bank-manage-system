using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankManageSystem.money;
using BankManageSystem;
using System.Windows.Forms;

namespace BankManageSystem
{
    public class CustomFixed : Custom
    {
        /// 开户
        /// </summary>
        /// <param name="accountNumber">帐号</param>
        /// <param name="money">开户金额</param>
        public override void Create(string accountNumber, double money)
        {
            if (money < 100)
            {
                MessageBox.Show("定期存款100元起存。");
                return;
            }
            base.Create(accountNumber, money);
        }

        /// <summary>
        ///存款 
        /// </summary>
        public override void Diposit(string genType, double money)
        {
            if (money < 100)
            {
                MessageBox.Show("定期存款100元起存。");
                return;
            }
            
            BankDataContext c = new BankDataContext();
            var q = from t in c.MoneyInfo
                    where t.帐号 == this.AccountInfo.帐号 && t.发生类别 == "存款"
                    select t.发生时间;

            //计算日期差
            //TimeSpan ts;
            int tsy=0;
            int tsm=0;
            try
            {
                try
                {
                    DateTime time1 = q.Max().Date;
                    DateTime time2 = DateTime.Now;

                    tsy = time2.Year - time1.Year;
                    tsm = time2.Month - time1.Month;
                    
                    //ts = time2.Subtract(time1);
                }
                catch (Exception)
                {
                    q = from t in c.MoneyInfo
                        where t.帐号 == this.AccountInfo.帐号 && t.发生类别 == "开户"
                        select t.发生时间;
                    DateTime time1 = q.Max().Date;
                    DateTime time2 = DateTime.Now;

                    tsy = time2.Year - time1.Year;
                    tsm = time2.Month - time1.Month;
                    //ts = time2.Subtract(time1);
                }
            }
            catch (Exception)
            {
                //ts = new TimeSpan(0,0,0,0,0);
            }

            //结算利息
            if(tsy!=0||tsm!=0)// (ts.TotalDays >=1)
            {

                if (tsy <= 0||(tsy == 1 && tsm<0))//(ts.TotalDays <= 365)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期提前支取) * this.AccountBalance);
                }
                else if ((tsy > 1 && tsy < 3) || (tsy == 1 && tsm >= 0) || (tsy == 3 && tsm < 0))//(ts.TotalDays <= 365 * 2)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期1年) * this.AccountBalance);
                }
                else if ((tsy > 3 && tsy < 5) || (tsy == 3 && tsm >= 0) || (tsy == 5 && tsm < 0))//(ts.TotalDays <= 365 * 4)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期3年) * this.AccountBalance);
                }
                else if (tsy == 5 && tsm == 0)//(ts.TotalDays <= 365 * 6)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期5年) * this.AccountBalance);
                }
                else
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期5年) * this.AccountBalance 
                        + (1 + DataOperation.GetRate(RateType.定期5年)) * this.AccountBalance * DataOperation.GetRate(RateType.定期超期部分));
                }
            }
            //存款
            base.Diposit("存款", money);            
        }

        /// <summary>
        ///取款 
        /// </summary>
        /// <param name="money">取款金额</param>
        public override void Withdraw(double money)
        {
            BankDataContext c = new BankDataContext();
            var q = from t in c.MoneyInfo
                    where t.帐号 == this.AccountInfo.帐号 && t.发生类别 == "存款"
                    select t.发生时间;

            //计算日期差
            //TimeSpan ts;
            int tsy = 0;
            int tsm = 0;
            try
            {
                try
                {
                    DateTime time1 = q.Max().Date;
                    DateTime time2 = DateTime.Now;

                    tsy = time2.Year - time1.Year;
                    tsm = time2.Month - time1.Month;

                    //ts = time2.Subtract(time1);
                }
                catch (Exception)
                {
                    q = from t in c.MoneyInfo
                        where t.帐号 == this.AccountInfo.帐号 && t.发生类别 == "开户"
                        select t.发生时间;
                    DateTime time1 = q.Max().Date;
                    DateTime time2 = DateTime.Now;

                    tsy = time2.Year - time1.Year;
                    tsm = time2.Month - time1.Month;
                    //ts = time2.Subtract(time1);
                }
            }
            catch (Exception)
            {
                //ts = new TimeSpan(0, 0, 0, 0, 0);
            }

            //结算利息
            if (tsy != 0 || tsm != 0)// (ts.TotalDays >=1)
            {

                if (tsy <= 0 || (tsy ==1 && tsm <0))//(ts.TotalDays <= 365)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期提前支取) * this.AccountBalance);
                }
                else if ((tsy > 1 && tsy < 3) || (tsy == 1 && tsm >= 0) || (tsy == 3 && tsm < 0))//(ts.TotalDays <= 365 * 2)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期1年) * this.AccountBalance);
                }
                else if ((tsy > 3 && tsy < 5) || (tsy == 3 && tsm >= 0) || (tsy == 5 && tsm < 0))//(ts.TotalDays <= 365 * 4)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期3年) * this.AccountBalance);
                }
                else if (tsy == 5 && tsm == 0)//(ts.TotalDays <= 365 * 6)
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期5年) * this.AccountBalance);
                }
                else
                {
                    base.Diposit("结算利息", DataOperation.GetRate(RateType.定期5年) * this.AccountBalance
                        + (1 + DataOperation.GetRate(RateType.定期5年)) * this.AccountBalance * DataOperation.GetRate(RateType.定期超期部分));
                }
            }
            //取款
            base.Withdraw(this.AccountBalance);
        }
    }
}
