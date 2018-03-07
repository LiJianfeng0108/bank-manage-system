using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankManageSystem.money;
using BankManageSystem.query;
using BankManageSystem.employee;
using BankManageSystem.other;
using BankManageSystem.rate;
using BankManageSystem.help;

namespace BankManageSystem.common
{
    public partial class MainForm : Form
    {
        LoginForm lf = new LoginForm();
        public MainForm()
        {
            InitializeComponent();
            string id = Program.LoginID;
            pictureBox1.Image = DataOperation.GetOperatePicture(id);
            groupBoxOperator.Text = string.Format("操作员：[{0}]{1}",
                id, DataOperation.GetOperateName(id));
            labelDateTime.Text = DateTime.Now.ToString();
            MoneyManageForm form = new MoneyManageForm();
            ShowForm("存款取款", form);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string s = e.ClickedItem.Text;
            switch (s)
            {
                case "存款取款":
                    ShowForm(s, new MoneyManageForm());
                    break;
                case "汇总查询":
                    ShowForm(s, new QueryManageForm());
                    break;
                case "职员管理":
                    ShowForm(s, new EmployeeManageForm());
                    break;
                case "其他功能":
                    ShowForm(s, new OtherManageForm());
                    break;
                case "利率设置":
                    ShowForm(s, new RateManageForm());
                    break;
                case "帮助":
                    AboutForm af = new AboutForm();
                    af.ShowDialog();
                    break;
            }
        }

        private void ShowForm(string title, Form form)
        {
            tabControl1.TabPages[0].Controls.Clear();
            tabControl1.TabPages[0].Text = title;
            form.TopLevel = false;
            tabControl1.TabPages[0].Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        //更换操作员图片
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK){
                lf.InsertPictureToBank(ofd.OpenFile(), Program.LoginID);
            }
            pictureBox1.Image = DataOperation.GetOperatePicture(Program.LoginID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.LoginID = string.Empty;
            this.Close();
            //LoginForm lf = new LoginForm();
            //lf.ShowDialog();
           //Application.Run(new LoginForm());
        }       
    }
}
