using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

       private void restoreApplicationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Show();
           this.WindowState = FormWindowState.Normal;
           notifyIcon1.Visible = false;
       }

       private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void btn_testbubble_Click(object sender, EventArgs e)
       {
           DisplayWorkingHours();
       }
       
        private void DisplayWorkingHours()
        {
            DateTime thisDay = DateTime.Today;
            String dayName = thisDay.DayOfWeek.ToString();

            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipText = "Are you blind? The day is: " + dayName;
            this.notifyIcon1.BalloonTipTitle = dayName;
            this.notifyIcon1.ShowBalloonTip(30000);

            if (dayName == "Sunday")
            {

            }
            else if (dayName == "Monday")
            {
            }
        }
    }
}
