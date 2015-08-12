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

        //Setting up all of the values from the last user session on the computer, it will also display what hours you will work tomorrow.
        private void Form1_Load(object sender, EventArgs e)
        {
            txtbox_mondayHours.Text = Properties.Settings.Default.MondayWorkingHours;
            txtbox_tuesdayHours.Text = Properties.Settings.Default.TuesdayWorkingHours;
            txtbox_wednesdayHours.Text = Properties.Settings.Default.WednesdayWorkingHours;
            txtbox_thursdayHours.Text = Properties.Settings.Default.ThursdayWorkingHours;
            txtbox_fridayHours.Text = Properties.Settings.Default.FridayWorkingHours;
            txtbox_saturdayHours.Text = Properties.Settings.Default.SaturdayWorkingHours;
            txtbox_sundayHours.Text = Properties.Settings.Default.SundayWorkingHours;

            SaveWorkHours();
            DisplayWorkingHours();
        }
        
        //When you minimze the program it will hide the window.
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

       private void checkHoursToolStripMenuItem_Click(object sender, EventArgs e)
       {
           DisplayWorkingHours();
       }

       // Setting all of the different buttons up to call the right methods.
       private void btn_seehours_Click(object sender, EventArgs e)
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

       // This will save all of the different hours that you will be working and will change it if the value has not been inputted.
       private void SaveWorkHours()
       {
           Properties.Settings.Default.MondayWorkingHours = txtbox_mondayHours.Text;
           Properties.Settings.Default.TuesdayWorkingHours = txtbox_tuesdayHours.Text;
           Properties.Settings.Default.WednesdayWorkingHours = txtbox_wednesdayHours.Text;
           Properties.Settings.Default.ThursdayWorkingHours = txtbox_thursdayHours.Text;
           Properties.Settings.Default.FridayWorkingHours = txtbox_fridayHours.Text;
           Properties.Settings.Default.SaturdayWorkingHours = txtbox_saturdayHours.Text;
           Properties.Settings.Default.SundayWorkingHours = txtbox_sundayHours.Text;

           if (Properties.Settings.Default.MondayWorkingHours == "") { Properties.Settings.Default.MondayWorkingHours = "None. You are not working on Monday"; }
           if (Properties.Settings.Default.TuesdayWorkingHours == "") { Properties.Settings.Default.TuesdayWorkingHours = "None. You are not working on Tuesday"; }
           if (Properties.Settings.Default.WednesdayWorkingHours == "") { Properties.Settings.Default.WednesdayWorkingHours = "None. You are not working on Wednesday"; }
           if (Properties.Settings.Default.ThursdayWorkingHours == "") { Properties.Settings.Default.ThursdayWorkingHours = "None. You are not working on Thursday"; }
           if (Properties.Settings.Default.FridayWorkingHours == "") { Properties.Settings.Default.FridayWorkingHours = "None. You are not working on Friday"; }
           if (Properties.Settings.Default.SaturdayWorkingHours == "") { Properties.Settings.Default.SaturdayWorkingHours = "None. You are not working on Saturday"; }
           if (Properties.Settings.Default.SundayWorkingHours == "") { Properties.Settings.Default.SundayWorkingHours = "None. You are not working on Sunday"; }

           Properties.Settings.Default.Save();
       }

       // This is the main method which will show what hours you will be working on the next day with a notification bubble.
       private void DisplayWorkingHours()
       {
           DateTime thisDay = DateTime.Today;
           String dayName = thisDay.DayOfWeek.ToString();

           if (dayName == "Sunday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Monday are: " + Properties.Settings.Default.MondayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Monday";
           }
           else if (dayName == "Monday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Tuesday are: " + Properties.Settings.Default.TuesdayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Tuesday";
           }
           else if (dayName == "Tuesday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Wednesday are: " + Properties.Settings.Default.WednesdayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Wednesday";
           }
           else if (dayName == "Wednesday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Thursday are: " + Properties.Settings.Default.ThursdayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Thursday";
           }
           else if (dayName == "Thursday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Friday are: " + Properties.Settings.Default.FridayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Friday";
           }
           else if (dayName == "Friday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Saturday are: " + Properties.Settings.Default.SaturdayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Saturday";
           }
           else if (dayName == "Saturday")
           {
               this.notifyIcon1.BalloonTipText = "The hours you will be working on Sunday are: " + Properties.Settings.Default.SundayWorkingHours;
               this.notifyIcon1.BalloonTipTitle = "Sunday";
           }
           
           this.notifyIcon1.ShowBalloonTip(100000);
        }

       // This will double check all of the hours have been saved by the application.
       private void Form1_FormClosed(object sender, FormClosedEventArgs e)
       {
           SaveWorkHours();
       }

       // This will reset all of the differnet textbox and save them to override past values.
       private void btn_reset_Click(object sender, EventArgs e)
       {
           txtbox_mondayHours.Text = "";
           txtbox_tuesdayHours.Text = "";
           txtbox_wednesdayHours.Text = "";
           txtbox_thursdayHours.Text = "";
           txtbox_fridayHours.Text = "";
           txtbox_saturdayHours.Text = "";
           txtbox_sundayHours.Text = "";

           SaveWorkHours();
       }
       
    }
}
