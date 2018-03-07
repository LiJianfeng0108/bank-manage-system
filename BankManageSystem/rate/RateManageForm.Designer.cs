namespace BankManageSystem.rate
{
    partial class RateManageForm
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
            this.btnFixed = new System.Windows.Forms.Button();
            this.btnLCZQ = new System.Windows.Forms.Button();
            this.btnFlexible = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnLCZQ);
            this.leftPanel.Controls.Add(this.btnFixed);
            this.leftPanel.Controls.Add(this.btnFlexible);
            // 
            // btnFixed
            // 
            this.btnFixed.Image = global::BankManageSystem.Properties.Resources.btnRate;
            this.btnFixed.Location = new System.Drawing.Point(22, 160);
            this.btnFixed.Name = "btnFixed";
            this.btnFixed.Size = new System.Drawing.Size(72, 74);
            this.btnFixed.TabIndex = 8;
            this.btnFixed.Text = "定期";
            this.btnFixed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFixed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFixed.UseVisualStyleBackColor = true;
            this.btnFixed.Click += new System.EventHandler(this.btnFixed_Click);
            // 
            // btnLCZQ
            // 
            this.btnLCZQ.Image = global::BankManageSystem.Properties.Resources.btnRate;
            this.btnLCZQ.Location = new System.Drawing.Point(23, 261);
            this.btnLCZQ.Name = "btnLCZQ";
            this.btnLCZQ.Size = new System.Drawing.Size(72, 74);
            this.btnLCZQ.TabIndex = 9;
            this.btnLCZQ.Text = "零存整取";
            this.btnLCZQ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLCZQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLCZQ.UseVisualStyleBackColor = true;
            this.btnLCZQ.Click += new System.EventHandler(this.btnLCZQ_Click);
            // 
            // btnFlexible
            // 
            this.btnFlexible.Image = global::BankManageSystem.Properties.Resources.btnRate;
            this.btnFlexible.Location = new System.Drawing.Point(23, 54);
            this.btnFlexible.Name = "btnFlexible";
            this.btnFlexible.Size = new System.Drawing.Size(72, 74);
            this.btnFlexible.TabIndex = 7;
            this.btnFlexible.Text = "活期";
            this.btnFlexible.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFlexible.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFlexible.UseVisualStyleBackColor = true;
            this.btnFlexible.Click += new System.EventHandler(this.btnFlexible_Click);
            // 
            // RateManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Name = "RateManageForm";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFlexible;
        private System.Windows.Forms.Button btnFixed;
        private System.Windows.Forms.Button btnLCZQ;
    }
}
