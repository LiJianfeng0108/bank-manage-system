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
    public partial class NewAccountForm : BankManageSystem.common.BasePanelForm
    {
        public NewAccountForm()
        {
            InitializeComponent();
            string[] items = Enum.GetNames(typeof(MoneyAccountType));
            comboBoxAccountType.Items.AddRange(items);
            //只允许从选项中选择
            comboBoxAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountType.SelectedIndex = 0;
        }
        //单击“开户”按钮
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Custom custom = DataOperation.CreateCustom(comboBoxAccountType.SelectedItem.ToString());
                custom.AccountInfo.帐号 = textBoxAccount.Text.Trim();
                custom.AccountInfo.身份证号 = textBoxIdCard.Text.Trim();
                custom.AccountInfo.姓名 = textBoxName.Text.Trim();
                custom.AccountInfo.密码 = textBoxPassword.Text.Trim();
                custom.AccountInfo.存款类型 = comboBoxAccountType.Text;
                custom.Create(textBoxAccount.Text.Trim(), double.Parse(textBoxMoney.Text.Trim()));
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("开户失败，请正确填写信息");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBoxAccountType.SelectedItem.ToString();
            BankDataContext c = new BankDataContext();
            var q = from t in c.AccountInfo
                    where t.存款类型 == s
                    select t;
            if (q.Count() > 0)
            {
                textBoxAccount.Text = string.Format("{0}", int.Parse(q.Max(x => x.帐号)) + 1);
            }
            else
            {
                textBoxAccount.Text = string.Format("{0}00001", comboBoxAccountType.SelectedIndex + 1);
            }
        }
    }
}
