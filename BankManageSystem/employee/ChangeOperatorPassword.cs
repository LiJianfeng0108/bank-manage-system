using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BankManageSystem.employee
{
    public partial class ChangeOperatorPassword : BankManageSystem.common.BasePanelForm
    {
        string id = Program.LoginID;
        public ChangeOperatorPassword()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string oldPass,newPass,confirmPass;

            if (textBoxOldPassword.Text == "")
            {
                MessageBox.Show("请输入原密码");
                return;
            }
            else 
            {
                oldPass = textBoxOldPassword.Text;
            }

            if (textBoxNewPassword.Text == "")
            {
                MessageBox.Show("请输入新密码");
                return;
            }
            else
            {
                newPass = textBoxNewPassword.Text;
            }

            if (textBoxPasswordConfirm.Text == "")
            {
                MessageBox.Show("请再次输入新密码");
                return;
            }
            else
            {
                confirmPass = textBoxPasswordConfirm.Text;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("输入的两次新密码不一致");
                return;
            }
            else if(ValidatingTest(newPass)==false)
            {
                MessageBox.Show("新密码输入包含非法符号");
            }
            else
            {
                BankDataContext bd = new BankDataContext();
                var q = from t in bd.LoginInfo
                        where t.编号 == id 
                        select t.密码;
                string getPass = q.Single().ToString();

                if (getPass != oldPass)
                {
                    MessageBox.Show("原密码错误");
                    return;
                }
                else
                {
                    var q2 = from t in bd.LoginInfo
                            where t.编号 == id
                             select t;
                    q2.Single().密码 = newPass.Trim();//取消两边空格
                    bd.SubmitChanges();
                    MessageBox.Show("密码修改成功");

                    //textbox置空
                    textBoxNewPassword.Text = "";
                    textBoxOldPassword.Text = "";
                    textBoxPasswordConfirm.Text = "";
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

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeOperatorPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
