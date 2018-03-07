using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.other
{
    public partial class OtherManageForm : BankManageSystem.common.BaseForm
    {
        public OtherManageForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindCustomPasssWord fp = new FindCustomPasssWord();
            ShowFormInRightPanel(fp);
        }

        private void buttonCustomPassword_Click(object sender, EventArgs e)
        {
            ChangeCustomPassword cc = new ChangeCustomPassword();
            ShowFormInRightPanel(cc);
        }

        //在右边panel显示界面
        private void ShowFormInRightPanel(Form form)
        {
            form.TopLevel = false;//子窗口取消顶级窗口属性，子窗口就能镶嵌在父窗口中
            this.rightPanel.Controls.Clear();
            this.rightPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();

        }
    }
}
