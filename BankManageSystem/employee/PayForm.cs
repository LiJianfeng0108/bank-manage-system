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
    public partial class PayForm : BankManageSystem.common.BasePanelForm
    {
        string id = Program.LoginID;
        public PayForm()
        {
            InitializeComponent();
        }

        BankDataContext bd = new BankDataContext();

        private void PayForm_Load(object sender, EventArgs e)
        {
            
            //combobox绑定编号
            
            if (id == "00001")//00001作为业务员的管理员能修改出自己以外所有工资，其他编号的业务员不能修改
            {

                var q = from t in bd.EmployeeInfo
                        where t.编号!="00001"
                        select t.编号;
                string[] idRange = q.ToArray();
                this.comboBox1.Items.AddRange(idRange);
                this.comboBox1.SelectedIndex = 0;
            }
            else 
            {
                this.Close();
                
                
            }
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //改变combobox的item时获取相应工资
            string id2 = this.comboBox1.SelectedItem.ToString();
            var q = from t in bd.EmployeeInfo
                    where t.编号 == id2
                    select t;
            if (q.Count() > 0)
            {
                textBoxName.Text = q.Single().姓名;
                //textBoxOld.Text = q.Single().工资.ToString();

                textBoxOld.Text = string.Format("{0:f0}", q.Single().工资);//控制小数位数
            }
            else
            {
                textBoxName.Text = "";
                textBoxOld.Text = "";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //提交
            if (textBoxNew.Text == "")
            {
                MessageBox.Show("新工资不能为空");
                return;
            }
            else
            {
                try
                {
                    //获取新数据提交
                    string id3 = this.comboBox1.SelectedItem.ToString();
                    string salary = textBoxNew.Text;
                    var q = from t in bd.EmployeeInfo
                            where t.编号 == id3
                            select t;
                    q.Single().工资 = Convert.ToDecimal(salary);//双精度转化为十进制
                    bd.SubmitChanges();

                    MessageBox.Show("提交成功！");
                    //刷新工资
                    this.textBoxOld.Text = this.textBoxNew.Text.Trim();//   去掉两边空格
                    this.textBoxNew.Text = "";
                }
                catch (Exception err)
                {
                   
                    MessageBox.Show("新工资输入不合法!", err.Message);
                }
            }
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            //关闭工资修改窗口
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        




    }
}
