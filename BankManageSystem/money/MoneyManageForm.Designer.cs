namespace BankManageSystem.money
{
    partial class MoneyManageForm
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
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithDraw = new System.Windows.Forms.Button();
            this.buttonNewAccount = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.buttonWithDraw);
            this.leftPanel.Controls.Add(this.buttonDeposit);
            this.leftPanel.Controls.Add(this.buttonNewAccount);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Image = global::BankManageSystem.Properties.Resources.btnDesposit;
            this.buttonDeposit.Location = new System.Drawing.Point(11, 149);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(83, 77);
            this.buttonDeposit.TabIndex = 5;
            this.buttonDeposit.Text = "存款";
            this.buttonDeposit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithDraw
            // 
            this.buttonWithDraw.Image = global::BankManageSystem.Properties.Resources.btnDesposit;
            this.buttonWithDraw.Location = new System.Drawing.Point(11, 265);
            this.buttonWithDraw.Name = "buttonWithDraw";
            this.buttonWithDraw.Size = new System.Drawing.Size(83, 77);
            this.buttonWithDraw.TabIndex = 6;
            this.buttonWithDraw.Text = "取款";
            this.buttonWithDraw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWithDraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWithDraw.UseVisualStyleBackColor = true;
            this.buttonWithDraw.Click += new System.EventHandler(this.buttonWithDraw_Click);
            // 
            // buttonNewAccount
            // 
            this.buttonNewAccount.Image = global::BankManageSystem.Properties.Resources.btnDesposit;
            this.buttonNewAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewAccount.Location = new System.Drawing.Point(11, 39);
            this.buttonNewAccount.Name = "buttonNewAccount";
            this.buttonNewAccount.Size = new System.Drawing.Size(83, 77);
            this.buttonNewAccount.TabIndex = 4;
            this.buttonNewAccount.Text = "开户";
            this.buttonNewAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewAccount.UseVisualStyleBackColor = true;
            this.buttonNewAccount.Click += new System.EventHandler(this.buttonNewAccount_Click);
            // 
            // MoneyManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Name = "MoneyManageForm";
            this.Text = "MoneyManageForm";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWithDraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonNewAccount;
    }
}
