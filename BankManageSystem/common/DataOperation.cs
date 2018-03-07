using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using BankManageSystem;
using BankManageSystem.money;

namespace BankManageSystem
{
    public class DataOperation
    {
        public static readonly string[] AccountType = { "活期存款", "定期存款", "零存整取" };
        /// <summary>
        /// 获取操作员照片
        /// </summary>
        /// <param name="id">操作员编号</param>
        /// <returns></returns>
        public static Bitmap GetOperatePicture(string id)
        {
            try
            {
                BankDataContext c = new BankDataContext();
                var q = (from t in c.EmployeeInfo
                         where t.编号 == id
                         select t).Single();
                if (q.照片 != null)
                {
                    System.IO.MemoryStream memStream = new System.IO.MemoryStream(q.照片.ToArray());
                    return new Bitmap(memStream);
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取操作员姓名
        /// </summary>
        /// <param name="id">操作员编号</param>
        /// <returns></returns>
        public static string GetOperateName(string id)
        {
            BankDataContext c = new BankDataContext();
            var q = (from t in c.EmployeeInfo
                     where t.编号 == id
                     select t).Single();
            return q.姓名;
        }

        /// <summary>
        /// 根据存款类型创建存款用户
        /// </summary>
        /// <param name="accountType">存款类型</param>
        /// <returns></returns>
        public static Custom CreateCustom(string accountType)
        {
            Custom custom = null;
            switch (accountType)
            {
                case "活期存款":
                    custom = new CustomChecking();
                    break;
                case "定期存款":
                    custom = new CustomFixed();
                    break;
                case "零存整取":
                    custom = new CustomSporadic();
                    break;
            }
            custom.AccountInfo.存款类型 = accountType;
            return custom;
        }

        /// <summary>
        /// 获取存款用户信息,并初始化余额
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static Custom GetCustom(string accountNumber)
        {
            Custom custom = null;
            BankDataContext c = new BankDataContext();
            try
            {
                var q = (from t in c.AccountInfo
                         where t.帐号 == accountNumber
                         select t).Single();
                custom = CreateCustom(q.存款类型);
                custom.AccountInfo.帐号 = accountNumber;
                custom.AccountInfo.姓名 = q.姓名;
                custom.AccountInfo.密码 = q.密码;
                custom.AccountInfo.身份证号 = q.身份证号;
            }
            catch
            {
                return null;
            }
            var q1 = (from t in c.MoneyInfo
                      where t.帐号 == accountNumber
                      select t).Sum(x => x.发生金额);
            custom.AccountBalance = q1;
            return custom;
        }

        /// <summary>
        /// 获取指定类别的利率
        /// </summary>
        /// <param name="rateType">利率类别</param>
        /// <returns>对应类别的利率值</returns>
        public static double GetRate(RateType rateType)
        {
            BankDataContext c = new BankDataContext();
            var q = (from t in c.RateInfo
                     where t.类别 == rateType.ToString()
                     select t.利率).Single();
            return q;
        }
    }
}
