using System;
using System.Windows.Forms;

namespace POS
{
    public partial class Toast_Message : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public Toast_Message(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void Toast_Message_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1)
            {
                timer1.Interval = 2500;
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void Toast_Message_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            timer1.Dispose();
        }
    }
}
