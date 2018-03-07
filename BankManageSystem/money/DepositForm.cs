using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BankManageSystem.money
{
    public partial class DepositForm : BankManageSystem.common.BasePanelForm
    {
        public DepositForm()
        {
            InitializeComponent();
        }
        //单击“存款”按钮
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Custom custom = DataOperation.GetCustom(textBoxAccount.Text.Trim());
            if (custom == null)
            {
                MessageBox.Show("帐号不存在，请重新输入！！");
                return;
            }
            custom.MoneyInfo.帐号 = textBoxAccount.Text.Trim();
            if (textBoxMoney.Text == "")
            {
                MessageBox.Show("请输入存款金额");
                return;
            }
            custom.Diposit("存款", double.Parse(textBoxMoney.Text.Trim()));
           
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            int Number;
            if (textBoxAccount.Text == "")
            {
                MessageBox.Show("请输入账号");
                return;
            }
            try
            {
                Number = Convert.ToInt32(textBoxAccount.Text);
            }
            catch (Exception)
            {
                textBoxAccount.Text = "";
                return;
            }
            if (Number > 300000)
            {
                textBoxMoney.ReadOnly = true;
                try
                {        
                    Custom custom = DataOperation.GetCustom(textBoxAccount.Text.Trim());
                    BankDataContext c = new BankDataContext();
                    var q = from t in c.MoneyInfo
                            where t.帐号 == custom.AccountInfo.帐号 && t.发生类别 == "开户"
                            select t.余额;
                    textBoxMoney.ReadOnly = true;
                    textBoxMoney.Text = q.Max().ToString();
                }
                catch (Exception) { }
            }
        }

        private void textBoxMoney_TextChanged(object sender, EventArgs e)
        {
            double money;
            try
            {
                money = double.Parse(textBoxMoney.Text);
            }
            catch (Exception)
            {
                textBoxMoney.Text = "";
            }
        }
    }
}
