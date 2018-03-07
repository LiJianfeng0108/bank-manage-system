using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.money
{
    public partial class WithdrawForm : BankManageSystem.common.BasePanelForm
    {
        int n = 0;
        public WithdrawForm()
        {

            InitializeComponent();
        }
        //单击“取款”按钮
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Custom custom = DataOperation.GetCustom(textBoxAccount.Text.Trim());
            if (custom == null)
            {
                MessageBox.Show("账号不存在，请重新输入！");
                return;
            }
            if (custom.AccountInfo.密码 != textBoxPassword.Text)
            {
                MessageBox.Show("密码不正确");
                n++;
                if (n >= 3)
                {
                    MessageBox.Show("密码错误超过三次，禁止操作！！");
                    this.Close();
                }
            }
            else
            {
                n = 0;
                if (textBoxMoney.Text == "")
                {
                    MessageBox.Show("请输入取款金额");
                    return;
                }
                custom.Withdraw(double.Parse(textBoxMoney.Text));
                this.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            int Number;
            try
            {
                Number = Convert.ToInt32(textBoxAccount.Text);
            }
            catch (Exception)
            {
                textBoxAccount.Text = "";
                return;
            }
            if (Number <= 200000)
            {
                label3.Show();
                textBoxMoney.Show();
            }
            else
            {
                Custom custom = DataOperation.GetCustom(textBoxAccount.Text.Trim());
                label3.Hide();
                textBoxMoney.Hide();
                try
                {
                    textBoxMoney.Text = custom.AccountBalance.ToString();          
                }
                catch (Exception) { };
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
