namespace BankManageSystem.other
{
    partial class OtherManageForm
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
            this.buttonCustomPassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.buttonCustomPassword);
            // 
            // buttonCustomPassword
            // 
            this.buttonCustomPassword.Image = global::BankManageSystem.Properties.Resources.btnPassword;
            this.buttonCustomPassword.Location = new System.Drawing.Point(11, 226);
            this.buttonCustomPassword.Name = "buttonCustomPassword";
            this.buttonCustomPassword.Size = new System.Drawing.Size(89, 77);
            this.buttonCustomPassword.TabIndex = 11;
            this.buttonCustomPassword.Text = "更改客户密码";
            this.buttonCustomPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCustomPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCustomPassword.UseVisualStyleBackColor = true;
            this.buttonCustomPassword.Click += new System.EventHandler(this.buttonCustomPassword_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BankManageSystem.Properties.Resources.btnPassword;
            this.button1.Location = new System.Drawing.Point(11, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "客户密码找回";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OtherManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Name = "OtherManageForm";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomPassword;
        private System.Windows.Forms.Button button1;
    }
}
