namespace BankManageSystem.query
{
    partial class QueryManageForm
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
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonDepositQuery = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.buttonDepositQuery);
            this.leftPanel.Controls.Add(this.buttonSum);
            // 
            // buttonSum
            // 
            this.buttonSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSum.Image = global::BankManageSystem.Properties.Resources.btnSum;
            this.buttonSum.Location = new System.Drawing.Point(26, 70);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(73, 79);
            this.buttonSum.TabIndex = 8;
            this.buttonSum.Text = "当日汇总";
            this.buttonSum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonDepositQuery
            // 
            this.buttonDepositQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDepositQuery.Image = global::BankManageSystem.Properties.Resources.btnSum;
            this.buttonDepositQuery.Location = new System.Drawing.Point(26, 229);
            this.buttonDepositQuery.Name = "buttonDepositQuery";
            this.buttonDepositQuery.Size = new System.Drawing.Size(73, 79);
            this.buttonDepositQuery.TabIndex = 9;
            this.buttonDepositQuery.Text = "存款查询";
            this.buttonDepositQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDepositQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDepositQuery.UseVisualStyleBackColor = true;
            this.buttonDepositQuery.Click += new System.EventHandler(this.buttonDepositQuery_Click);
            // 
            // QueryManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Name = "QueryManageForm";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonDepositQuery;
    }
}
