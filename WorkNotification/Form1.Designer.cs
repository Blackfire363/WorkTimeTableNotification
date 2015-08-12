namespace WorkNotification
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotificationTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_testbubble = new System.Windows.Forms.Button();
            this.contextMenuNotificationTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuNotificationTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Work Notifications";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuNotificationTray
            // 
            this.contextMenuNotificationTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreApplicationToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.contextMenuNotificationTray.Name = "contextMenuNotificationTray";
            this.contextMenuNotificationTray.Size = new System.Drawing.Size(178, 48);
            // 
            // restoreApplicationToolStripMenuItem
            // 
            this.restoreApplicationToolStripMenuItem.Name = "restoreApplicationToolStripMenuItem";
            this.restoreApplicationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.restoreApplicationToolStripMenuItem.Text = "Restore Application";
            this.restoreApplicationToolStripMenuItem.Click += new System.EventHandler(this.restoreApplicationToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert the days you are working this week";
            // 
            // btn_testbubble
            // 
            this.btn_testbubble.Location = new System.Drawing.Point(13, 30);
            this.btn_testbubble.Name = "btn_testbubble";
            this.btn_testbubble.Size = new System.Drawing.Size(75, 23);
            this.btn_testbubble.TabIndex = 2;
            this.btn_testbubble.Text = "Bubble Text";
            this.btn_testbubble.UseVisualStyleBackColor = true;
            this.btn_testbubble.Click += new System.EventHandler(this.btn_testbubble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_testbubble);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Working Timetable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuNotificationTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotificationTray;
        private System.Windows.Forms.ToolStripMenuItem restoreApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_testbubble;
    }
}

