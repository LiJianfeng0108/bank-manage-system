using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BankManageSystem
{
    public partial class LoginForm : Form
    {
        int n = 0;
        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.Text = "123";
        }

        public void InsertPictureToBank(Stream pictureStream, string id)
        {
            int len = (int)pictureStream.Length;
            byte[] bt = new byte[len];
            pictureStream.Read(bt, 0, len);
            BankDataContext c = new BankDataContext();
            var q = (from t in c.EmployeeInfo
                     where t.编号 == id
                     select t).Single();
            q.照片 = new System.Data.Linq.Binary(bt);
            c.SubmitChanges();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //要求实现读取数据库表检查帐号、密码是否正确
            //如果正确，此窗体消失，显示主窗体
            try
            {
                string id = comboBoxNumber.SelectedValue.ToString();
                BankDataContext c = new BankDataContext();
                var q = from t in c.LoginInfo
                        where t.编号 == id && t.密码 == textBoxPassword.Text
                        select t;
                if (q.Count() == 1)
                {
                    Program.LoginID = id;
                    this.Close();
                    n = 0;
                }
                else
                {
                    MessageBox.Show("密码不正确!");
                    //textBoxPassword.Text = "";
                    n++;
                }
                if (n >= 3)
                {
                    MessageBox.Show("密码错误三次，禁止登录！！");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Program.LoginID = string.Empty;
            this.Close();
        }

        private void comboBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPicture();
        }
        private void ShowPicture()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            pictureBox1.Image = DataOperation.GetOperatePicture(comboBoxNumber.SelectedValue.ToString());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bankDataSet.EmployeeInfo”中。您可以根据需要移动或删除它。
            this.employeeInfoTableAdapter.Fill(this.bankDataSet.EmployeeInfo);
            try
            {
                BankDataContext c = new BankDataContext();
                var q = from t in c.LoginInfo
                        select t.编号;
                comboBoxNumber.DataSource = q;
                comboBoxNumber.SelectedIndex = 0;
                ShowPicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
