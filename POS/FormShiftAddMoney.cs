﻿using System;
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
    public partial class FormShiftAddMoney : Form
    {
        private double _cash;
        public double cash
        {
            get
            {
                return this._cash;
            }
        }

        public FormShiftAddMoney()
        {
            this.InitializeComponent();
        }

        private void FormShiftAddMoney_Load(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.textBox1.Text) <= 0.0)
                return;
            this.saveData();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.textBox1.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
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
                this.Close();
        }

        private void saveData()
        {
            this._cash = Convert.ToDouble(this.textBox1.Text);
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(this.textBox1.Text == ""))
                return;
            this.textBox1.Text = "0.00";
            this.textBox1.SelectAll();
        }
    }
}