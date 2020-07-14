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
    public partial class PanelVentas_RetornarEnvasesForm : Form
    {
        private int _amount;
        private int maxPermited;


        public int AmountOfPackagesToReturn
        {
            get
            {
                return this._amount;
            }
        }

        public PanelVentas_RetornarEnvasesForm(int maxPermited)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.maxPermited = maxPermited;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.accept();
            if (e.KeyCode != Keys.Escape)
                return;
            if (this.textBox1.Text == "")
                this.Close();
            else
                this.textBox1.Text = "";
        }

        private void accept()
        {
            if (this.textBox1.Text != "" && Convert.ToInt32(this.textBox1.Text) <= this.maxPermited)
            {
                this._amount = Convert.ToInt32(this.textBox1.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.textBox1.Text = this.maxPermited.ToString();
                this.textBox1.ForeColor = Color.Tomato;
                this.textBox1.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.accept();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
