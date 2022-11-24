namespace ISpan
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
            this.店家資訊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資料更改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帳號管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.店家資訊ToolStripMenuItem,
            this.資料更改ToolStripMenuItem,
            this.帳號管理ToolStripMenuItem,
            this.登出ToolStripMenuItem1,
            this.登出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 店家資訊ToolStripMenuItem
            // 
            this.店家資訊ToolStripMenuItem.Name = "店家資訊ToolStripMenuItem";
            this.店家資訊ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.店家資訊ToolStripMenuItem.Text = "店家資訊";
            this.店家資訊ToolStripMenuItem.Click += new System.EventHandler(this.店家資訊ToolStripMenuItem_Click);
            // 
            // 資料更改ToolStripMenuItem
            // 
            this.資料更改ToolStripMenuItem.Name = "資料更改ToolStripMenuItem";
            this.資料更改ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.資料更改ToolStripMenuItem.Text = "資料更改";
            this.資料更改ToolStripMenuItem.Click += new System.EventHandler(this.資料更改ToolStripMenuItem_Click);
            // 
            // 帳號管理ToolStripMenuItem
            // 
            this.帳號管理ToolStripMenuItem.Name = "帳號管理ToolStripMenuItem";
            this.帳號管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.帳號管理ToolStripMenuItem.Text = "帳號管理";
            this.帳號管理ToolStripMenuItem.Click += new System.EventHandler(this.帳號管理ToolStripMenuItem_Click);
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.登出ToolStripMenuItem.Text = "結束";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click1);
            // 
            // 登出ToolStripMenuItem1
            // 
            this.登出ToolStripMenuItem1.Name = "登出ToolStripMenuItem1";
            this.登出ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.登出ToolStripMenuItem1.Text = "登出";
            this.登出ToolStripMenuItem1.Click += new System.EventHandler(this.登出ToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帳號管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 店家資訊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資料更改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem1;
    }
}