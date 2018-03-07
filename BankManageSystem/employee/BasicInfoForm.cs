using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;



namespace BankManageSystem.employee
{
    public partial class BasicInfoForm : Form
    {
        string id = Program.LoginID;
        Regex regChina = new Regex("^[\u4e00-\u9fa5]+$");//汉字正则表达式
        static int new1=0;
        //string path = @"e:\"+new1.ToString()+".jpg";//图片保存地址
        int count = 0;//点击保存按钮，0为修改，1为新建
        //picbox,图片和数据库
        
        byte[] by;
        


        public BasicInfoForm()
        {
            InitializeComponent();
            this.StartPosition = StartPosition = FormStartPosition.CenterScreen;

            BankDataContext bd = new BankDataContext();
            
            
        }

        private void BasicInfoForm_Load(object sender, EventArgs e)
        {
            count = 0;


            

            //datagridview信息
            BindingSource bds1 = new BindingSource();
            BankDataContext c = new BankDataContext();
            if(id=="00001")
            {
                label1.Hide();
                newToolStripButton.Visible = true;
                剪切UToolStripButton.Visible = true;
                dataGridView1.Show();
                
                var q1 = from t in c.EmployeeInfo
                         
                         select new
                         {
                             编号 = t.编号,
                             姓名 = t.姓名,
                             性别 = t.性别,
                             参加工作日期 = t.参加工作日期,
                             电话 = t.联系电话,
                             身份证号 = t.身份证号,
                             //工资 = t.工资,
                             //照片 = t.照片
                         };
                
                //datagridview显示数据
                bds1.DataSource = q1;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = bds1;

                //navigator绑定
                bindingNavigator1.BindingSource = bds1;

                //textbox显示数据

                Display();

                //照片导入
                if (this.pictureBox1.Image != null)
                {
                    this.pictureBox1.Image.Dispose();
                }
                this.pictureBox1.Image = DataOperation.GetOperatePicture(textBoxID.Text);
            }
            else
            {
                this.Refresh();
                dataGridView1.Hide();
                newToolStripButton.Visible = false;
                剪切UToolStripButton.Visible = false;
                label1.Show();
                
                
                var q2 = from t in c.EmployeeInfo
                         where t.编号==id
                         select t;
                bindingNavigator1.BindingSource = bds1;
                bds1.DataSource = q2;
               
                //textbox显示数据

                textBoxID.Text = q2.Single().编号;
                textBoxName.Text = q2.Single().姓名;
                if (q2.Single().性别 == '女') { radioButton1.Checked = true;
                radioButton2.Checked = false;
                }
                else { radioButton1.Checked = false ;
                radioButton2.Checked = true;
                }
                dateTimePicker.Text = q2.Single().参加工作日期.ToString();
                textBoxPID.Text = q2.Single().身份证号;
                //textBoxSalary.Text = q2.Single().工资.ToString();
                textBoxPhoneNumber.Text = q2.Single().联系电话;

                //照片导入
                if (this.pictureBox1.Image != null)
                {
                    this.pictureBox1.Image.Dispose();
                }
                this.pictureBox1.Image = DataOperation.GetOperatePicture(textBoxID.Text);

            }

        }
        //信息显示到上面的textbox。。。
        private void Display()
        {
            try
            {
                textBoxID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["编号"].Value.ToString();
                textBoxName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["姓名"].Value.ToString();
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["性别"].Value.ToString() == "女")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }

                dateTimePicker.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["参加工作日期"].Value.ToString();

                textBoxPID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["身份证号"].Value.ToString();
                //textBoxSalary.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["工资"].Value.ToString();
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["电话"].Value != null)
                {
                    textBoxPhoneNumber.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["电话"].Value.ToString();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("排序完成");
            }
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            count = 0;
            Display();
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
            }
            this.pictureBox1.Image = DataOperation.GetOperatePicture(textBoxID.Text);
            
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            
            //获取业务员信息并验证
            string id1 = textBoxID.Text;
            string name;
            if ((textBoxName.Text == "") 
                || textBoxName.Text.Length > 4 
                || textBoxName.Text.Length <2 
                || (regChina.IsMatch(textBoxName.Text) == false))
            {
                MessageBox.Show("姓名长度为2-4，且只能为汉字");
                return;
            }
            else
            {
                name = textBoxName.Text;
            }

            char sex;
            if (radioButton1.Checked == true)
            { sex = '女'; }
            else
            {
                sex = '男';
            }


            System.DateTime date = dateTimePicker.Value;

            string pid;
            if (textBoxPID.Text.Trim() == "" || ValidatingTest2(textBoxPID.Text.Trim()) == false)
            {
                MessageBox.Show("请输入正确格式的身份证号");
                return;
            }
            else
            {
                pid = textBoxPID.Text.Trim();
            }

            //string salary = textBoxSalary.Text;

            string phoneNum;
            if (ValidatingTest2(textBoxPhoneNumber.Text) == false)
            {
                MessageBox.Show("请输入正确格式的电话");
                return;
            }
            else
            {
                phoneNum = textBoxPhoneNumber.Text;
            }


            BankDataContext bd = new BankDataContext();
            //修改或保存新信息        
            //int max = bd.EmployeeInfo.Count()+1;
            //int tb = int.Parse(textBoxID.Text);
            if (count==0)//修改
            {

                if (this.pictureBox1.Image == null)
                {
                    MessageBox.Show("没有照片");
                    return;
                }
                //pic获取到数组
                getPic();



                
                var q = from t in bd.EmployeeInfo
                        where t.编号 == id1
                        select t;
                q.Single().姓名 = name;
                q.Single().性别 = sex;
                q.Single().参加工作日期 = date;
                q.Single().身份证号 = pid;
                //q.Single().工资 = Convert.ToDecimal(salary);
                q.Single().联系电话 = phoneNum; 
                q.Single().照片 = new System.Data.Linq.Binary(by);

                bd.SubmitChanges();

                MessageBox.Show("保存成功！");
            }
            else//添加新操作员信息
            {
                if (this.pictureBox1.Image == null)
                {
                    MessageBox.Show("没有照片");
                    return;
                }
                //pic获取到数组
                getPic();
                
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.BankConnectionString);
                SqlDataAdapter adapter = new SqlDataAdapter("select * from EmployeeInfo", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                row[0] = id1;
                row[1] = name;
                row[2] = sex;
                row[3] = date;
                row[4] = phoneNum;
                row[5] = pid;
                row[6] = by;
                

                table.Rows.Add(row);
                adapter.Update(table);
                //添加登陆界面信息，默认密码：身份证
                BankDataContext b = new BankDataContext();
                LoginInfo ta = new LoginInfo();
                ta.编号 = id1;
                ta.密码 = pid;
                
                b.LoginInfo.InsertOnSubmit(ta);
                b.SubmitChanges();

                MessageBox.Show("新建成功，初始密码为身份证号");

            }

            count = 0;

            

            //更新到datagridview
            if (id == "00001")
            {
                var q1 = from t in bd.EmployeeInfo

                         select new
                         {
                             编号 = t.编号,
                             姓名 = t.姓名,
                             性别 = t.性别,
                             参加工作日期 = t.参加工作日期,
                             电话 = t.联系电话,
                             身份证号 = t.身份证号,
                             //工资 = t.工资,
                             //照片 = t.照片
                         };

                //datagridview显示数据
                BindingSource bs = new BindingSource();
                bs.DataSource = q1;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = bs;
                bindingNavigator1.BindingSource = bs;


            }
                      
            
        }
        //获取pic 到数组
        private void getPic()
        {
            Bitmap image = (Bitmap)pictureBox1.Image;
            MemoryStream stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            by = new byte[stream.Length];


            stream.Position = 0;
            stream.Read(by, 0, Convert.ToInt32(stream.Length));



            stream.Close();
        }
        

        //信息验证:不是数字返回false
        private bool ValidatingTest2(string t)
        {


            for (int i = 0; i < t.Length; i++)
            {
                if (Char.IsDigit(t[i]) == false)
                {

                    return false;
                }
            }
            return true;
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //count = 0;
            //string id1 = textBoxID.Text;
            //BankDataContext bd = new BankDataContext();
            //var q1 = from t in bd.EmployeeInfo
            //        where t.编号 == id1
            //        select t;
            //if (q1.Count() > 0)
            //{
            //    var q11 = q1.First();
            //    bd.EmployeeInfo.DeleteOnSubmit(q11);
            //    bd.SubmitChanges();
            //}
            //MessageBox.Show("删除成功");

        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            //string filename = null;
            //FileStream file = null;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //filename = ofd.FileName;
                //image = new Bitmap(filename);

                this.pictureBox1.Image = Image.FromFile(ofd.FileName);

                //file = new FileStream(filename, FileMode.Open, FileAccess.Read);
                //reader = new BinaryReader(file);
                //by = reader.ReadBytes((int)file.Length);
                //reader.Close();
                //file.Close();
                MessageBox.Show("导入成功");
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            count = 1;

            this.pictureBox1.Image = null;
            textBoxID.Text = "";
            textBoxName.Text = "";
            radioButton1.Checked = true;
            dateTimePicker.Value = DateTime.Now;
            textBoxPhoneNumber.Text = "";
            textBoxPID.Text = "";


            BankDataContext d = new BankDataContext();
            var q = from t in d.EmployeeInfo
                    select t.编号;
            int max = int.Parse(q.Max())+1;
            string ii="0000";
            if (max >= 10) { ii = "000"; }
            if (max >= 100) { ii = "00"; }
            string i = ii + max.ToString();
            textBoxID.Text = i;
            
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            
            
            //this.pictureBox1.Image = null;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("无图片可导出");
                return;
            }
            else 
            {
                new1++;
                string path = @"e:\" + new1.ToString() + ".jpg";//图片保存地址
                pictureBox1.Image.Save(path);
                MessageBox.Show("已保存至" + path);
            }

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void 剪切UToolStripButton_Click(object sender, EventArgs e)
        {
            count = 0;
            string id1 = textBoxID.Text;
            if (id1 == "00001")
            {
                MessageBox.Show("管理员不能删除");
                return;
            }
            BankDataContext bd = new BankDataContext();
            var q1 = from t in bd.EmployeeInfo
                     where t.编号 == id1
                     select t;
            if (q1.Count() > 0)
            {
                var q11 = q1.First();
                bd.EmployeeInfo.DeleteOnSubmit(q11);
                bd.SubmitChanges();
            }

            var qq2 = from t2 in bd.LoginInfo
                       where t2.编号 == id1
                       select t2;
            if(qq2.Count()>0)
            {
                var qqq = qq2.First();
                bd.LoginInfo.DeleteOnSubmit(qqq);
                bd.SubmitChanges();
            }


            MessageBox.Show("删除成功");


            BankDataContext c = new BankDataContext();
            var qq = from t in c.EmployeeInfo

                     select new
                     {
                         编号 = t.编号,
                         姓名 = t.姓名,
                         性别 = t.性别,
                         参加工作日期 = t.参加工作日期,
                         电话 = t.联系电话,
                         身份证号 = t.身份证号,
                         //工资 = t.工资,
                         //照片 = t.照片
                     };

            
            
            //datagridview显示数据
            BindingSource bds1 = new BindingSource();
            bds1.DataSource = qq;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = bds1;

            
            bindingNavigator1.BindingSource = bds1;
            
        }

        
    }
}
