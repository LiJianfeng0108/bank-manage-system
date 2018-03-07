using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.money
{
    public partial class MoneyManageForm : BankManageSystem.common.BaseForm
    {
        public MoneyManageForm()
        {
            InitializeComponent();
            ShowBankData();
        }

        /// <summary>
        /// 在右侧面板中显示存取款信息
        /// </summary>
        private void ShowBankData()
        {
            ShowCustomForm customForm = new ShowCustomForm();
            customForm.TopLevel = false;
            this.rightPanel.Controls.Clear();
            this.rightPanel.Controls.Add(customForm);
            customForm.Dock = DockStyle.Fill;
            customForm.Show();
        }

        /// <summary>
        /// 在右侧面板中显示指定的窗体
        /// </summary>
        /// <param name="form">窗体</param>
        private void ShowFormInRightPanel(Form form)
        {
            form.TopLevel = false;
            this.rightPanel.Controls.Clear();
            this.rightPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowBankData();
        }
        //开户
        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            NewAccountForm form = new NewAccountForm();
            ShowFormInRightPanel(form);
        }
        //存款
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm();
            ShowFormInRightPanel(form);
        }
        //取款
        private void buttonWithDraw_Click(object sender, EventArgs e)
        {
            WithdrawForm form = new WithdrawForm();
            ShowFormInRightPanel(form);
        }
    }
}
