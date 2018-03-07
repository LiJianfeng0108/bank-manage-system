using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient; 

namespace BankManageSystem.rate
{
    public partial class FixedForm : BankManageSystem.common.BasePanelForm
    {
        BankDataContext c;
        string connString = Properties.Settings.Default.BankConnectionString;
        public FixedForm()
        {
            InitializeComponent();
        }

        private void txtFixedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewRate.Clear();
            c = new BankDataContext();
            try
            {
                var q = (from t in c.RateInfo
                         where t.类别 == cmbFixedType.Text
                         select t.利率).Single();
                txtOldRate.Text = q.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FixedForm_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("select * from RateInfo where 类别 like '定期%'",conn);
                try
                {
                    conn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        cmbFixedType.Items.Add(string.Format("{0}", r[0]));
                    }
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "读取失败");
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    float newRate = float.Parse(txtNewRate.Text);
                    string type = cmbFixedType.Text;
                    string sql = string.Format("update RateInfo set 利率={0} where 类别='{1}'", newRate, type);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                        {
                            MessageBox.Show("修改成功");
                        }
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入调整后利率");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
