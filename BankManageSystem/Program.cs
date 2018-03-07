using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BankManageSystem.common;

namespace BankManageSystem
{
    static class Program
    {
        public static string LoginID = string.Empty;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            while (LoginID.Length > 0)
            {
                Application.Run(new MainForm());
                if (LoginID.Length == 0)
                {
                    Application.Run(new LoginForm());
                }
                else
                {
                    Program.LoginID = string.Empty;
                }
            }
        }
    }
}
