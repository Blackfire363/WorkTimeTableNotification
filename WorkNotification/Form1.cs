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

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

       private void restoreApplicationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Show();
           this.WindowState = FormWindowState.Normal;
       }

       private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

    }
}
