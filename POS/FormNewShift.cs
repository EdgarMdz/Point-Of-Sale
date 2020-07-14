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
    public partial class FormNewShift : Form
    {
        private Decimal _cash;
        private bool startShiftRequired;

        public Decimal Cash
        {
            get
            {
                return this._cash;
            }
        }

        public FormNewShift(bool closeBtnVisible = true)
        {
            this.InitializeComponent();
            this.textBox1.SelectAll();
            this.bunifuImageButton1.Visible = closeBtnVisible;
            this.startShiftRequired = closeBtnVisible;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.textBox1.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saveData();
        }

        private void saveData()
        {
            this._cash = Convert.ToDecimal(this.textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(this.textBox1.Text == ""))
                return;
            this.textBox1.Text = "0.00";
            this.textBox1.SelectAll();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.saveData();
            if (e.KeyCode != Keys.Escape)
                return;
            if (this.textBox1.Text != "0.00")
            {
                this.textBox1.Text = "0.00";
                this.textBox1.SelectAll();
            }
            else
            {
                if (!(this.textBox1.Text != "0.00") || this.startShiftRequired)
                    return;
                this.Close();
            }
        }

    }
}
