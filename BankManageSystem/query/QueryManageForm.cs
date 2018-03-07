using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.query
{
    public partial class QueryManageForm : BankManageSystem.common.BaseForm
    {
        public QueryManageForm()
        {
            InitializeComponent();
        }
        private void ShowFormInRightPanel(Form form)
        {

            form.TopLevel = false;
            this.rightPanel.Controls.Clear();
            this.rightPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            SumForm sumForm = new SumForm();
            ShowFormInRightPanel(sumForm);
        }

        private void buttonDepositQuery_Click(object sender, EventArgs e)
        {
            DespoitQueryForm queryForm = new DespoitQueryForm();
            ShowFormInRightPanel(queryForm);
        }
    }
}
