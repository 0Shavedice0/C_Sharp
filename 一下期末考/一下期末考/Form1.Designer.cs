namespace 一下期末考
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.產生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.產生ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarToolStripMenuItem,
            this.qRCODEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.產生ToolStripMenuItem,
            this.移除ToolStripMenuItem});
            this.progressBarToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.progressBarToolStripMenuItem.Text = "ProgressBar";
            // 
            // 產生ToolStripMenuItem
            // 
            this.產生ToolStripMenuItem.Name = "產生ToolStripMenuItem";
            this.產生ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.產生ToolStripMenuItem.Text = "產生";
            this.產生ToolStripMenuItem.Click += new System.EventHandler(this.產生ToolStripMenuItem_Click);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.移除ToolStripMenuItem.Text = "移除";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.移除ToolStripMenuItem_Click);
            // 
            // qRCODEToolStripMenuItem
            // 
            this.qRCODEToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.qRCODEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.產生ToolStripMenuItem1,
            this.移除ToolStripMenuItem1});
            this.qRCODEToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.qRCODEToolStripMenuItem.Name = "qRCODEToolStripMenuItem";
            this.qRCODEToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.qRCODEToolStripMenuItem.Text = "QRCODE";
            // 
            // 產生ToolStripMenuItem1
            // 
            this.產生ToolStripMenuItem1.Name = "產生ToolStripMenuItem1";
            this.產生ToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.產生ToolStripMenuItem1.Text = "產生";
            this.產生ToolStripMenuItem1.Click += new System.EventHandler(this.產生ToolStripMenuItem1_Click);
            // 
            // 移除ToolStripMenuItem1
            // 
            this.移除ToolStripMenuItem1.Name = "移除ToolStripMenuItem1";
            this.移除ToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.移除ToolStripMenuItem1.Text = "移除";
            this.移除ToolStripMenuItem1.Click += new System.EventHandler(this.移除ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 產生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRCODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 產生ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem1;
    }
}

