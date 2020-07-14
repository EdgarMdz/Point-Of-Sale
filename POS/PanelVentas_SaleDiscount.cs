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
    public partial class PanelVentas_SaleDiscount : Form
    {
        private double _discount;
        private bool _isPercentage;

        public double discount
        {
            get
            {
                return this._discount;
            }
        }

        public bool isPercentage
        {
            get
            {
                return this._isPercentage;
            }
        }

        public PanelVentas_SaleDiscount(double currentDiscount, bool isByPercentage)
        {
            this.InitializeComponent();
            this._discount = currentDiscount;
            this._isPercentage = isByPercentage;
            this.discountTxt.Text = string.Format("{0}", (object)this._discount.ToString("n2"));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || (sender as TextBox).Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.saveDiscont();
        }

        private void saveDiscont()
        {
            string text = this.discountTxt.Text;
            int num1 = text.IndexOf("%");
            double num2;
            try
            {
                num2 = num1 <= -1 || this.discountTxt.Text.Length <= 1 ? Convert.ToDouble(text) : Convert.ToDouble(text.Substring(0, text.Length - 1));
            }
            catch (FormatException)
            {
                this.discountTxt.Text = "0.00";
                return;
            }
            this._discount = Math.Round(num2, 2);
            this._isPercentage = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.discountTxt.Text == ""))
                return;
            this.discountTxt.Text = "0.00";
            this.discountTxt.SelectAll();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void discountTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.saveDiscont();
            if (e.KeyCode != Keys.Escape)
                return;
            if (this.discountTxt.Text == this._discount.ToString("n2") || this.discountTxt.Text == "0.00")
            {
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.discountTxt.Text = "0.00";
                this.discountTxt.SelectAll();
            }
        }

    }
}
