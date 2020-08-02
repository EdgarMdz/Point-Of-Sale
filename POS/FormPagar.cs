using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FormPagar : Form
    {
        private double minimumPaymentNeeded;
        private bool payingPO;

        public string Total { get; set; }

        public string Cash { get; set; }

        public string Pay { get; set; }

        private bool sellingMode { get; set; }

        public double rest { get { return _rest; } }

        private double _rest;

        public FormPagar(string total, bool sellingMode, double minimumPaymentRequired = 0.0)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.payingPO = false;
            this.minimumPaymentNeeded = minimumPaymentRequired;
            this.sellingMode = sellingMode;
            this.Total = "$" + CalculateToal(Convert.ToDouble(total.Substring(1)));
        }

        private string CalculateToal(double total)
        {
            var totalNoDecimals = Math.Ceiling(total) - 1;
            var TotalRest = total - totalNoDecimals;
            double res = 0;
            

            if (TotalRest < 0.4)
                res = totalNoDecimals;
            else if (TotalRest >= 0.4 && TotalRest < 0.89)
                res = (totalNoDecimals + 0.5);
            else
                res=(totalNoDecimals + 1);

            this._rest = total - res; 

            return res.ToString("n2");

        }

        public FormPagar(double total, bool payingPO)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.Total = "$" + total.ToString("n2");
            this.payingPO = payingPO;
            this.CashTxt.Text = total.ToString("n2");
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (this.sellingMode)
            {
                if (this.CashTxt.Text == "" || Convert.ToDouble(this.CashTxt.Text) < Convert.ToDouble(this.Total.Substring(1)) || Convert.ToDouble(this.Total.Substring(1)) == 0.0)
                    shake(CashTxt);
                else
                    this.Makecharge();
            }
            else if (this.CashTxt.Text != "" && this.paymentTxt.Text != "")
            {
                if (Convert.ToDouble(this.paymentTxt.Text) > Convert.ToDouble(this.CashTxt.Text))
                    this.shake(this.CashTxt);
                else if (Convert.ToDouble(this.paymentTxt.Text) < this.minimumPaymentNeeded)
                {
                    this.shake(this.paymentTxt);
                    MessageBox.Show(string.Format("La cantidad mínima a cobrar son ${0}", (object)this.minimumPaymentNeeded));
                    this.paymentTxt.Text = this.minimumPaymentNeeded.ToString("n2");
                }
                else
                    this.Makecharge();
            }
            else
            {
                if (this.paymentTxt.Text == "" || Convert.ToDouble(this.paymentTxt.Text) < this.minimumPaymentNeeded)
                {
                    this.shake(this.paymentTxt);
                    int num = (int)MessageBox.Show(string.Format("La cantidad mínima a cobrar son ${0}", (object)this.minimumPaymentNeeded));
                    this.paymentTxt.Text = this.minimumPaymentNeeded.ToString("n2");
                }
                else
                    this.showNextTextbox();
                if (!this.CashTxt.Visible)
                    return;
                this.shake(this.CashTxt);
            }
        }

        private void shake(BunifuMaterialTextbox text)
        {
            if (!this.payingPO)
            {
                for (int index = 0; index < 4; ++index)
                {
                    text.Visible = false;
                    Thread.Sleep(50);
                    text.Visible = true;
                }
                text.Focus();
                text.LineIdleColor = Color.Red;
                text.LineFocusedColor = Color.Red;
            }
            else
            {
                this.OKBtn.Focus();
                this.paymentTxt.Focus();
            }
        }

        private void Makecharge()
        {
            if (this.sellingMode)
            {
                this.DialogResult = DialogResult.OK;
                this.Cash = this.CashTxt.Text;
                this.Pay = this.Total.Substring(1);
                this.Close();
            }
            else if (Convert.ToDouble(this.CashTxt.Text) < Convert.ToDouble(this.paymentTxt.Text))
                this.shake(this.CashTxt);
            else if (Convert.ToDouble(this.paymentTxt.Text) < this.minimumPaymentNeeded)
            {
                this.shake(this.paymentTxt);
                this.paymentTxt.Text = this.minimumPaymentNeeded.ToString("n2");
            }
            else
            {
                this.Cash = this.CashTxt.Text;
                this.Pay = this.paymentTxt.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormPagar_Load(object sender, EventArgs e)
        {
            this.TotalLbl.Text = this.Total.ToString();
            this.CashTxt.ForeColor = Color.FromArgb(0, 111, 173);
            if (this.sellingMode)
            {
                this.paymentLbl.Visible = false;
                this.paymentTxt.Visible = false;
                this.CashLbl.Location = this.paymentLbl.Location;
                this.CashTxt.Location = this.paymentTxt.Location;
                this.CashLbl.Visible = true;
                this.CashTxt.Visible = true;
                this.paymentTxt.Text = "0";
            }
            this.FormPagar_Paint((object)this, new PaintEventArgs(this.CreateGraphics(), new Rectangle(this.Location, this.Size)));
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.closeForm();
        }

        private void closeForm()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && this.CashTxt.Text != "")
            {
                if (Convert.ToDouble(this.paymentTxt.Text) > Convert.ToDouble(this.CashTxt.Text) || this.sellingMode && Convert.ToDouble(this.CashTxt.Text) < Convert.ToDouble(this.Total.Substring(1)) || Convert.ToDouble(this.paymentTxt.Text) < this.minimumPaymentNeeded)
                {
                    this.CashTxt.LineIdleColor = Color.Red;
                    this.shake(this.CashTxt);
                }
                else
                    this.Makecharge();
            }
            if (e.KeyChar == '\x001B')
                this.closeForm();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.CashTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void FormPagar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 111, 173))
            {
                Width = 5f
            }, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.showNextTextbox();
        }

        private void showNextTextbox()
        {
            this.Size = new Size(811, 322);
            OKBtn.Location = new Point(132, 265);
            CancelBtn.Location = new Point(477, 265);
            CashLbl.Show();
            CashTxt.Show();
            Refresh();
            CashTxt.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (!(this.paymentTxt.Text != "") || Convert.ToDouble(this.paymentTxt.Text) <= Convert.ToDouble(this.Total.Substring(1)))
                return;
            this.paymentTxt.Text = this.Total.Substring(1);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.paymentTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void CancelBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode != Keys.Return)
                return;
            this.OKBtn_Click((object)this, (EventArgs)null);
        }

    }
}
