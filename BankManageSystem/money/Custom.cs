using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.money
{
    public class Custom
    {
        /// <summary>
        /// 存款客户的帐户基本信息
        /// </summary>
        public AccountInfo AccountInfo { get; set; }
        /// <summary>
        /// 存款发生信息
        /// </summary>
        public MoneyInfo MoneyInfo { get; set; }
        /// <summary>
        /// 帐户余额
        /// </summary>
        public double AccountBalance { get; set; }
        public Custom()
        {
            AccountInfo = new AccountInfo();
            MoneyInfo = new MoneyInfo();
        }

        /// 开户
        /// </summary>
        /// <param name="accountNumber">帐号</param>
        /// <param name="money">开户金额</param>
        public virtual void Create(string accountNumber, double money)
        {
            this.AccountBalance = money;
            BankDataContext c = new BankDataContext();
            c.AccountInfo.InsertOnSubmit(AccountInfo);
            c.SubmitChanges();
            this.MoneyInfo.帐号 = accountNumber;
            InsertData("开户", money);
        }

        /// <summary>
        ///存款 
        /// </summary>
        /// <param name="genType">类型</param>
        /// <param name="money">金额</param>
        public virtual void Diposit(string genType, double money)
        {
            if (money <= 0)
            {
                throw new Exception("存款金额不能为零或负值");
            }
            else
            {
                //修改余额
                AccountBalance += money;
                InsertData(genType, money);
            }
        }

        /// <summary>
        ///检查是否允许取款，允许返回true，否则返回false
        /// </summary>
        /// <param name="money">取款金额</param>
        public bool ValidBeforeWithdraw(double money)
        {
            if (money <= 0)
            {
                MessageBox.Show("取款金额不能为零或负值");
                return false;
            }
            if (money > AccountBalance)
            {
                MessageBox.Show("取款数不能比余额大");
                return false;
            }
            return true;
        }

        /// <summary>
        ///取款 
        /// </summary>
        /// <param name="accountType">存款类别</param>
        /// <param name="money">取款金额</param>
        public virtual void Withdraw(double money)
        {
            AccountBalance -= money;
            InsertData("取款", -money);
        }

        /// <summary>
        /// 在表中添加新记录
        /// </summary>
        /// <param name="genType">发生类别</param>
        /// <param name="money">发生金额</param>
        public void InsertData(string genType, double money)
        {
            BankDataContext c = new BankDataContext();
            this.MoneyInfo.帐号 = this.AccountInfo.帐号;
            this.MoneyInfo.发生时间 = DateTime.Now;
            this.MoneyInfo.发生类别 = genType;
            this.MoneyInfo.发生金额 = money;
            this.MoneyInfo.余额 = AccountBalance;
            c.MoneyInfo.InsertOnSubmit(this.MoneyInfo);
            c.SubmitChanges();
        }
    }
}
