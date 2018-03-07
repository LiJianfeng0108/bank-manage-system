namespace BankManageSystem.common
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.存款取款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇总查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.利率设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.groupBoxOperator = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.存款取款ToolStripMenuItem,
            this.汇总查询ToolStripMenuItem,
            this.职员管理ToolStripMenuItem,
            this.其他功能ToolStripMenuItem,
            this.利率设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(400, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(824, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 存款取款ToolStripMenuItem
            // 
            this.存款取款ToolStripMenuItem.Name = "存款取款ToolStripMenuItem";
            this.存款取款ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.存款取款ToolStripMenuItem.Text = "存款取款";
            // 
            // 汇总查询ToolStripMenuItem
            // 
            this.汇总查询ToolStripMenuItem.Name = "汇总查询ToolStripMenuItem";
            this.汇总查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.汇总查询ToolStripMenuItem.Text = "汇总查询";
            // 
            // 职员管理ToolStripMenuItem
            // 
            this.职员管理ToolStripMenuItem.Name = "职员管理ToolStripMenuItem";
            this.职员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.职员管理ToolStripMenuItem.Text = "职员管理";
            // 
            // 其他功能ToolStripMenuItem
            // 
            this.其他功能ToolStripMenuItem.Name = "其他功能ToolStripMenuItem";
            this.其他功能ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.其他功能ToolStripMenuItem.Text = "其他功能";
            // 
            // 利率设置ToolStripMenuItem
            // 
            this.利率设置ToolStripMenuItem.Name = "利率设置ToolStripMenuItem";
            this.利率设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.利率设置ToolStripMenuItem.Text = "利率设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelDateTime);
            this.panel2.Controls.Add(this.groupBoxOperator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 406);
            this.panel2.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(87, 257);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "注销";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "更换图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDateTime.ForeColor = System.Drawing.Color.Red;
            this.labelDateTime.Location = new System.Drawing.Point(12, 293);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(145, 23);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxOperator
            // 
            this.groupBoxOperator.Controls.Add(this.pictureBox1);
            this.groupBoxOperator.Location = new System.Drawing.Point(3, 62);
            this.groupBoxOperator.Name = "groupBoxOperator";
            this.groupBoxOperator.Size = new System.Drawing.Size(160, 178);
            this.groupBoxOperator.TabIndex = 4;
            this.groupBoxOperator.TabStop = false;
            this.groupBoxOperator.Text = "操作员：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 17);
            this.tabControl1.Location = new System.Drawing.Point(169, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 406);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "银行业务管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 存款取款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇总查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 利率设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.GroupBox groupBoxOperator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExit;

    }
}