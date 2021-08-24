using System;
using System.Windows.Forms;

namespace POS
{
    public partial class DarkForm : Form
    {
       /* protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }*/

        public DarkForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Parent.Controls.Count < 2)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void DarkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Dispose();
        }
    }
}
