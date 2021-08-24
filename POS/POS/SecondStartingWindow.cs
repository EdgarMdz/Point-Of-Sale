using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class SecondStartingWindow : Form
    {
        public static readonly string FILE_URL_PREFIX = "file:\\";
        private Timer t = new Timer();
        public const string Path_Separator = "\\";
        public SecondStartingWindow()
        {
            this.InitializeComponent();
            this.t.Tick += new EventHandler(this.t_tick);
            this.t.Interval = 9000;
        }

        private void SecondStartingWindow_Shown(object sender, EventArgs e)
        {
            this.t.Start();

            string str1 = @"C:\Users\TIENDA\source\repos\POS\POS\Animations\";
            string str2 = "";
            switch (new Random().Next(0, 3))
            {
                case 0:
                    str2 = "gif1.gif";
                    break;
                case 1:
                    str2 = "gif2.gif";
                    break;
                case 2:
                    str2 = "gif3.gif";
                    break;
            }
            webBrowser1.Navigate(new Uri(@"file://" + str1 +"xd.html"));
            webBrowser1.DocumentText= webBrowser1.DocumentText.Replace("src =\"\"", "src = \"" + str1 + str2 + "\"");
        }

        private void t_tick(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
