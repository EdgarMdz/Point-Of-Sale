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
    public partial class FormPrestamo : Form
    {
        private double _quantity;
        public double loan
        {
            get
            {
                return this._quantity;
            }
        }

        public FormPrestamo()
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.textBox1.Text.IndexOf(".") <= -1)
                return;
            e.Handled = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.processLoan();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(this.textBox1.Text == ""))
                return;
            this.textBox1.Text = "0.00";
            this.textBox1.SelectAll();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.processLoan();
            if (e.KeyCode != Keys.Escape)
                return;
            if (this.textBox1.Text != "0.00")
                this.textBox1.Text = "0.00";
            else
                this.Close();
        }

        private void processLoan()
        {
            this._quantity = Convert.ToDouble(this.textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
