using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace BankManageSystem.rate
{
    public partial class FDBIForm : BankManageSystem.common.BasePanelForm
    {
        BankDataContext c;
        string connString = Properties.Settings.Default.BankConnectionString;
        public FDBIForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                float newRate = float.Parse(txtNewRate.Text);
                string type = cmbDBIType.Text;
                string sql = string.Format("update RateInfo set 利率='{0}' where 类别='{1}'", newRate, type);
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                    conn.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("请输入调整后利率");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDBIType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewRate.Clear();
            c = new BankDataContext();
            var q = (from t in c.RateInfo
                     where t.类别 == cmbDBIType.Text
                     select t.利率).Single();
            txtOldRate.Text = q.ToString();
        }

        private void FDBIForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from RateInfo where 类别 like '零存整取%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        cmbDBIType.Items.Add(string.Format("{0}", r[0]));
                    }
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "修改失败");
                }
            }
        }
    }
}

