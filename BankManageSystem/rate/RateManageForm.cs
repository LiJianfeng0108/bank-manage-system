using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankManageSystem.rate
{
    public partial class RateManageForm : BankManageSystem.common.BaseForm
    {
        public RateManageForm()
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
        private void btnFlexible_Click(object sender, EventArgs e)
        {
            FlexibleForm Flexiblef = new FlexibleForm();
            ShowFormInRightPanel(Flexiblef);
        }

        private void btnFixed_Click(object sender, EventArgs e)
        {
            FixedForm Fixedf = new FixedForm();
            ShowFormInRightPanel(Fixedf);
        }

        private void btnLCZQ_Click(object sender, EventArgs e)
        {
            FDBIForm fd = new FDBIForm();
            ShowFormInRightPanel(fd);
        }
    }
}
