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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

       // Working with the notification icons context menu.
       private void restoreApplicationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Show();
           this.WindowState = FormWindowState.Normal;
       }

       private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }
       
       // Setting all of the different buttons up to call the right methods.
       private void btn_testbubble_Click(object sender, EventArgs e)
       {
           DisplayWorkingHours();
       }

       private void btn_savehours_Click(object sender, EventArgs e)
       {
           SaveWorkHours();
       }

       private void btn_hidescreen_Click(object sender, EventArgs e)
       {
           this.WindowState = FormWindowState.Minimized;
       }

       // Working with all of the different methods.
       private void SaveWorkHours()
       {

       }

       private void DisplayWorkingHours()
       {
           DateTime thisDay = DateTime.Today;
           String dayName = thisDay.DayOfWeek.ToString();

           if (dayName == "Sunday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Monday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Monday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
           else if (dayName == "Monday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Tuesday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Tuesday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
           else if (dayName == "Tuesday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Wednesday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Wednesday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
           else if (dayName == "Wednesday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Thursday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Thursday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
           else if (dayName == "Thursday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Friday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Friday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
           else if (dayName == "Friday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Saturday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Saturday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
           else if (dayName == "Saturday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Sunday are: " + dayName;
               this.notifyIcon1.BalloonTipTitle = "Sunday";
               this.notifyIcon1.ShowBalloonTip(100000);
           }
         
        }
    }
}
