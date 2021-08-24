using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Display_Reminder : Form
    {
        private static int windowsOpen;
        private int ID;
        public Display_Reminder(
         string CompanyName,
         string message,
         DateTime startTime,
         DateTime endTime)
        {
            this.InitializeComponent();
            this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width - 10;
            this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height - 10;
            this.ID = Display_Reminder.windowsOpen;
            ++Display_Reminder.windowsOpen;
            this.comapanyNameLbl.Text = CompanyName;
            this.messageLbl.Text = message;
            this.scheduleLbl.Text = startTime.TimeOfDay.ToString() + " - " + endTime.TimeOfDay.ToString();
            if (startTime.Hour <= DateTime.Now.Hour && startTime.Minute < DateTime.Now.Minute)
                this.lateLbl.Show();
            this.timer1.Interval = 120000;
            this.timer1.Tick += (EventHandler)((s, e) =>
            {
                this.DialogResult = DialogResult.OK;
                Display_Reminder.windowsOpen = 0;
                this.Close();
            });
        }

        private void Display_Reminder_Shown(object sender, EventArgs e)
        {
            if (this.ID > 0)
            {
                this.Close();
            }
            else
            {
                this.Opacity = 1.0;
                this.timer1.Start();
            }
        }

        private void bunifuGradientPanel1_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.4;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this.ID != 0)
                return;
            Display_Reminder.windowsOpen = 0;
            this.DialogResult = DialogResult.OK;
        }

        private void bunifuGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }
    }
}
