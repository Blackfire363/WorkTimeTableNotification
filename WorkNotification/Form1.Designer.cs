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
            this.btn_testbubble = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_mondayHours = new System.Windows.Forms.TextBox();
            this.txtbox_tuesdayHours = new System.Windows.Forms.TextBox();
            this.txtbox_wednesdayHours = new System.Windows.Forms.TextBox();
            this.txtbox_thursdayHours = new System.Windows.Forms.TextBox();
            this.txtbox_fridayHours = new System.Windows.Forms.TextBox();
            this.txtbox_saturdayHours = new System.Windows.Forms.TextBox();
            this.txtbox_sundayHours = new System.Windows.Forms.TextBox();
            this.btn_savehours = new System.Windows.Forms.Button();
            this.btn_hidescreen = new System.Windows.Forms.Button();
            this.txtbox_information = new System.Windows.Forms.RichTextBox();
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
            // btn_testbubble
            // 
            this.btn_testbubble.Location = new System.Drawing.Point(345, 26);
            this.btn_testbubble.Name = "btn_testbubble";
            this.btn_testbubble.Size = new System.Drawing.Size(75, 23);
            this.btn_testbubble.TabIndex = 2;
            this.btn_testbubble.Text = "Bubble Text";
            this.btn_testbubble.UseVisualStyleBackColor = true;
            this.btn_testbubble.Click += new System.EventHandler(this.btn_testbubble_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type what hours you will be working on each day, if you are not working on a spec" +
    "ific day, leave the box blank, then click save hours and hide";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saturday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sunday";
            // 
            // txtbox_mondayHours
            // 
            this.txtbox_mondayHours.Location = new System.Drawing.Point(77, 28);
            this.txtbox_mondayHours.Name = "txtbox_mondayHours";
            this.txtbox_mondayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_mondayHours.TabIndex = 11;
            // 
            // txtbox_tuesdayHours
            // 
            this.txtbox_tuesdayHours.Location = new System.Drawing.Point(77, 54);
            this.txtbox_tuesdayHours.Name = "txtbox_tuesdayHours";
            this.txtbox_tuesdayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_tuesdayHours.TabIndex = 12;
            // 
            // txtbox_wednesdayHours
            // 
            this.txtbox_wednesdayHours.Location = new System.Drawing.Point(77, 80);
            this.txtbox_wednesdayHours.Name = "txtbox_wednesdayHours";
            this.txtbox_wednesdayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_wednesdayHours.TabIndex = 13;
            // 
            // txtbox_thursdayHours
            // 
            this.txtbox_thursdayHours.Location = new System.Drawing.Point(77, 106);
            this.txtbox_thursdayHours.Name = "txtbox_thursdayHours";
            this.txtbox_thursdayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_thursdayHours.TabIndex = 14;
            // 
            // txtbox_fridayHours
            // 
            this.txtbox_fridayHours.Location = new System.Drawing.Point(77, 132);
            this.txtbox_fridayHours.Name = "txtbox_fridayHours";
            this.txtbox_fridayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_fridayHours.TabIndex = 15;
            // 
            // txtbox_saturdayHours
            // 
            this.txtbox_saturdayHours.Location = new System.Drawing.Point(77, 158);
            this.txtbox_saturdayHours.Name = "txtbox_saturdayHours";
            this.txtbox_saturdayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_saturdayHours.TabIndex = 16;
            // 
            // txtbox_sundayHours
            // 
            this.txtbox_sundayHours.Location = new System.Drawing.Point(77, 184);
            this.txtbox_sundayHours.Name = "txtbox_sundayHours";
            this.txtbox_sundayHours.Size = new System.Drawing.Size(100, 20);
            this.txtbox_sundayHours.TabIndex = 17;
            // 
            // btn_savehours
            // 
            this.btn_savehours.Location = new System.Drawing.Point(183, 26);
            this.btn_savehours.Name = "btn_savehours";
            this.btn_savehours.Size = new System.Drawing.Size(75, 23);
            this.btn_savehours.TabIndex = 18;
            this.btn_savehours.Text = "Save Hours";
            this.btn_savehours.UseVisualStyleBackColor = true;
            this.btn_savehours.Click += new System.EventHandler(this.btn_savehours_Click);
            // 
            // btn_hidescreen
            // 
            this.btn_hidescreen.Location = new System.Drawing.Point(264, 26);
            this.btn_hidescreen.Name = "btn_hidescreen";
            this.btn_hidescreen.Size = new System.Drawing.Size(75, 23);
            this.btn_hidescreen.TabIndex = 19;
            this.btn_hidescreen.Text = "Hide";
            this.btn_hidescreen.UseVisualStyleBackColor = true;
            this.btn_hidescreen.Click += new System.EventHandler(this.btn_hidescreen_Click);
            // 
            // txtbox_information
            // 
            this.txtbox_information.Location = new System.Drawing.Point(184, 54);
            this.txtbox_information.Name = "txtbox_information";
            this.txtbox_information.ReadOnly = true;
            this.txtbox_information.Size = new System.Drawing.Size(236, 150);
            this.txtbox_information.TabIndex = 20;
            this.txtbox_information.Text = resources.GetString("txtbox_information.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 217);
            this.Controls.Add(this.txtbox_information);
            this.Controls.Add(this.btn_hidescreen);
            this.Controls.Add(this.btn_savehours);
            this.Controls.Add(this.txtbox_sundayHours);
            this.Controls.Add(this.txtbox_saturdayHours);
            this.Controls.Add(this.txtbox_fridayHours);
            this.Controls.Add(this.txtbox_thursdayHours);
            this.Controls.Add(this.txtbox_wednesdayHours);
            this.Controls.Add(this.txtbox_tuesdayHours);
            this.Controls.Add(this.txtbox_mondayHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_testbubble);
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
        private System.Windows.Forms.Button btn_testbubble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_mondayHours;
        private System.Windows.Forms.TextBox txtbox_tuesdayHours;
        private System.Windows.Forms.TextBox txtbox_wednesdayHours;
        private System.Windows.Forms.TextBox txtbox_thursdayHours;
        private System.Windows.Forms.TextBox txtbox_fridayHours;
        private System.Windows.Forms.TextBox txtbox_saturdayHours;
        private System.Windows.Forms.TextBox txtbox_sundayHours;
        private System.Windows.Forms.Button btn_savehours;
        private System.Windows.Forms.Button btn_hidescreen;
        private System.Windows.Forms.RichTextBox txtbox_information;
    }
}

