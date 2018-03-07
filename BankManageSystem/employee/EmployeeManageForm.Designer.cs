namespace BankManageSystem.employee
{
    partial class EmployeeManageForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEmployeeInfo = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.buttonPay);
            this.leftPanel.Controls.Add(this.buttonEmployeeInfo);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // rightPanel
            // 
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // buttonPay
            // 
            this.buttonPay.Image = global::BankManageSystem.Properties.Resources.btnEmployee;
            this.buttonPay.Location = new System.Drawing.Point(24, 167);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(80, 68);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "工资调整";
            this.buttonPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BankManageSystem.Properties.Resources.btnEmployee;
            this.button1.Location = new System.Drawing.Point(24, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "更改密码";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEmployeeInfo
            // 
            this.buttonEmployeeInfo.Image = global::BankManageSystem.Properties.Resources.btnEmployee;
            this.buttonEmployeeInfo.Location = new System.Drawing.Point(24, 58);
            this.buttonEmployeeInfo.Name = "buttonEmployeeInfo";
            this.buttonEmployeeInfo.Size = new System.Drawing.Size(80, 68);
            this.buttonEmployeeInfo.TabIndex = 7;
            this.buttonEmployeeInfo.Text = "职员信息";
            this.buttonEmployeeInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmployeeInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEmployeeInfo.UseVisualStyleBackColor = true;
            this.buttonEmployeeInfo.Click += new System.EventHandler(this.buttonEmployeeInfo_Click);
            // 
            // EmployeeManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Name = "EmployeeManageForm";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmployeeInfo;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button button1;
    }
}
