namespace BankManageSystem.query
{
    partial class SumForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labDespoit = new System.Windows.Forms.Label();
            this.txtDespoit = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.labWithdraw = new System.Windows.Forms.Label();
            this.labSum = new System.Windows.Forms.Label();
            this.textWithdraw = new System.Windows.Forms.TextBox();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(140, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 33);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "每日汇总";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(449, 208);
            this.dataGridView1.TabIndex = 17;
            // 
            // labDespoit
            // 
            this.labDespoit.AutoSize = true;
            this.labDespoit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDespoit.Location = new System.Drawing.Point(12, 268);
            this.labDespoit.Name = "labDespoit";
            this.labDespoit.Size = new System.Drawing.Size(89, 12);
            this.labDespoit.TabIndex = 18;
            this.labDespoit.Text = "今日存款金额：";
            // 
            // txtDespoit
            // 
            this.txtDespoit.Location = new System.Drawing.Point(237, 259);
            this.txtDespoit.Name = "txtDespoit";
            this.txtDespoit.ReadOnly = true;
            this.txtDespoit.Size = new System.Drawing.Size(137, 21);
            this.txtDespoit.TabIndex = 20;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(331, 337);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 21;
            this.btnTotal.Text = "查询";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // labWithdraw
            // 
            this.labWithdraw.AutoSize = true;
            this.labWithdraw.Location = new System.Drawing.Point(12, 293);
            this.labWithdraw.Name = "labWithdraw";
            this.labWithdraw.Size = new System.Drawing.Size(89, 12);
            this.labWithdraw.TabIndex = 22;
            this.labWithdraw.Text = "今日取款金额：";
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Location = new System.Drawing.Point(12, 318);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(89, 12);
            this.labSum.TabIndex = 23;
            this.labSum.Text = "今日金额总汇：";
            // 
            // textWithdraw
            // 
            this.textWithdraw.Location = new System.Drawing.Point(237, 283);
            this.textWithdraw.Name = "textWithdraw";
            this.textWithdraw.ReadOnly = true;
            this.textWithdraw.Size = new System.Drawing.Size(137, 21);
            this.textWithdraw.TabIndex = 24;
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(237, 308);
            this.textSum.Name = "textSum";
            this.textSum.ReadOnly = true;
            this.textSum.Size = new System.Drawing.Size(137, 21);
            this.textSum.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "查找日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 341);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(454, 378);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.textWithdraw);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.labWithdraw);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtDespoit);
            this.Controls.Add(this.labDespoit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTitle);
            this.Name = "SumForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labDespoit;
        private System.Windows.Forms.TextBox txtDespoit;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label labWithdraw;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.TextBox textWithdraw;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
