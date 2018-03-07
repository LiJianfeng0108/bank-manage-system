using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.employee
{
    public partial class EmployeeManageForm : BankManageSystem.common.BaseForm
    {
        public EmployeeManageForm()
        {
            InitializeComponent();
        }

        //打开职员信息界面
        private void buttonEmployeeInfo_Click(object sender, EventArgs e)
        {
            BasicInfoForm fm = new BasicInfoForm();
            fm.ShowDialog();
        }

        //打开工资管理界面
        private void buttonPay_Click(object sender, EventArgs e)
        {
            PayForm pf = new PayForm();
            //pf.ShowDialog();
            ShowFormInRightPanel(pf);
            
        }

        //在右边panel显示界面
        private void ShowFormInRightPanel(Form form)
        {
            try
            {
                form.TopLevel = false;//子窗口取消顶级窗口属性，子窗口就能镶嵌在父窗口中
                this.rightPanel.Controls.Clear();
                this.rightPanel.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("不能修改自己工资");
            }

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeOperatorPassword cp = new ChangeOperatorPassword();
            ShowFormInRightPanel(cp);
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
