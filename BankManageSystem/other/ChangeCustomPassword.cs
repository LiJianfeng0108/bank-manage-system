using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BankManageSystem.other
{
    public partial class ChangeCustomPassword : BankManageSystem.common.BasePanelForm
    {
        public ChangeCustomPassword()
        {
            InitializeComponent();
        }

        private void ChangeCustomPassword_Load(object sender, EventArgs e)
        {
            try
            {
                BankDataContext bd = new BankDataContext();
                var q = from t in bd.AccountInfo
                        select t.帐号;
                string[] range = q.ToArray();
                this.comboBox1.Items.AddRange(range);
                this.comboBox1.SelectedIndex = 0;
            }
            catch(Exception)
            {
                MessageBox.Show("没有帐号");
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string oldPass, newPass, confirmPass;

            if (txtOldpwd.Text == "")
            {
                MessageBox.Show("请输入原密码");
                return;
            }
            else
            {
                oldPass = txtOldpwd.Text;
            }

            if (txtNewpwd.Text == "")
            {
                MessageBox.Show("请输入新密码");
                return;
            }
            else
            {
                newPass = txtNewpwd.Text;
            }

            if (txtNewConfirm.Text == "")
            {
                MessageBox.Show("请再次输入新密码");
                return;
            }
            else
            {
                confirmPass = txtNewConfirm.Text;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("输入的两次新密码不一致");
                return;
            }
            else if (ValidatingTest(newPass) == false)
            {
                MessageBox.Show("新密码输入包含非法符号");
            }
            else
            {
                
                string id = this.comboBox1.SelectedItem.ToString();
                BankDataContext bd = new BankDataContext();
                var q = from t in bd.AccountInfo
                        where t.帐号 == id
                        select t.密码;
                string getPass = q.Single().ToString();

                if (getPass != oldPass)
                {
                    MessageBox.Show("原密码错误");
                    return;
                }
                else
                {
                    var q2 = from t in bd.AccountInfo
                             where t.帐号 == id
                             select t;
                    q2.Single().密码 = newPass.Trim();//取消两边空格
                    bd.SubmitChanges();
                    MessageBox.Show("密码修改成功");

                    //textbox置空
                    txtOldpwd.Text = "";
                    txtNewpwd.Text = "";
                    txtNewConfirm.Text = "";
                }
            }

        }
        //密码验证
        private bool ValidatingTest(string t)
        {


            for (int i = 0; i < t.Length; i++)
            {
                if (Char.IsLetterOrDigit(t[i]) == false)
                {

                    return false;
                }
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
