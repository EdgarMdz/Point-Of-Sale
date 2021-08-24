using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace POS
{
    public partial class Form_new_wholesale_cost : Form
    {

        double amount;
        double cost;
        Producto product;
        readonly int costID;
        bool editingCost;

        public Form_new_wholesale_cost(string barcode)
        {
            InitializeComponent();
            amount = 0;
            cost = 0;
            product = new Producto(barcode);
            editingCost = false;
        }

        public Form_new_wholesale_cost(string barcode, double amount, double cost, bool isByPercentage, int costID)
        {
            InitializeComponent();
            textBox1.Text = "1";
            this.amount = amount;
            this.cost = cost;
            this.costID = costID;
            editingCost = true;

            product = new Producto(barcode);

            nextBtn_Click(this, null);
            backBtn.Hide();

            checkBox1.Checked = isByPercentage;
            textBox1.Text = cost.ToString("n2");
            textBox1.SelectAll();
            textBox1.Focus();
            
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (textBox1.Text.IndexOf('.') > -1 && e.KeyChar == '.')
                e.Handled = true;

            if(checkBox1.Visible && e.KeyChar == '%')
                checkBox1.Checked = !checkBox1.Checked;

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //checking if there´s a record that matches with the input
            try { amount = Convert.ToDouble(textBox1.Text); }
            catch (FormatException) { MessageBox.Show("El valor ingresado no es válido.", "Formato Incorrecto", MessageBoxButtons.OK); return; }

            if ((!product.checkForWholeSaleExistingAmount(amount) && amount > 0) || costID>0)
            {
                textBox1.Text = "";
                textBox1.Focus();
                label2.Text = "Descuento";
                backBtn.Show();
                okBtn.Show();
                nextBtn.Hide();
                checkBox1.Show();
            }
            else
            {
                MessageBox.Show("Ya existe un costo asignado a la cantidad ingresada. Ingrese un valor diferente para continuar");
                textBox1.SelectAll();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = amount.ToString("n2");
            textBox1.Focus();
            textBox1.SelectAll();
            label2.Text = "Cantidad Mínima de Compra";
            backBtn.Hide();
            nextBtn.Show();
            okBtn.Hide();
            checkBox1.Hide();
            checkBox1.Checked = false;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //checking if there´s a record that matches with the input
            try { cost = Convert.ToDouble(textBox1.Text); }
            catch (FormatException) { MessageBox.Show("El valor ingresado no es válido.", "Formato Incorrecto", MessageBoxButtons.OK); return; }

           if(!editingCost)
                product.addNewWholeSaleCost(amount, cost, checkBox1.Checked);
            else
                product.UpdateWholeSaleCost(costID, cost, checkBox1.Checked);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter) && nextBtn.Visible && textBox1.Text.Trim() != "")
                nextBtn_Click(this, null);


            else if (keyData == (Keys.Escape) && backBtn.Visible)
                backBtn_Click(this, null);


            else if (keyData == Keys.Escape && nextBtn.Visible)
                this.Close();

            else if (keyData == Keys.Enter && !nextBtn.Visible && textBox1.Text.Trim() != "")
                okBtn_Click(this, null);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                try
                {
                    var value = Convert.ToDouble(textBox1.Text);

                    if (value > 100)
                    {
                        textBox1.Text = "100";
                    }
                }
                catch (FormatException)
                {
                    textBox1.Text = "0";
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    var value = Convert.ToDouble(textBox1.Text);

                    if (value > 100)
                    {
                        textBox1.Text = "100";
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.SelectionLength = 0;
                    }
                }
                catch (FormatException)
                {
                }
            }
        }

        private void Form_new_wholesale_cost_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(0,100,140)) { Width = 3 };

            e.Graphics.DrawLine(p, 0, 2, this.Width, 2);//upper border
            e.Graphics.DrawLine(p, 0, this.Height - 2, this.Width, this.Height - 2);//bottom border
            e.Graphics.DrawLine(p, 2, 0, 2, this.Height);//left border
            e.Graphics.DrawLine(p, this.Width - 2, 0, this.Width - 2, this.Height);//right border

            p.Dispose();
        }
    }
}