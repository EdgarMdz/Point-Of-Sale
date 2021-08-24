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
    public partial class panel_productos_productPromos_cost : Form
    {
        double _cost;
        public double cost { get { return _cost; } }

        public panel_productos_productPromos_cost()
        {
            InitializeComponent();
        }

        public panel_productos_productPromos_cost(double cost)
        {
            InitializeComponent();

            costTxt.Text = cost.ToString("n2");
            costTxt.Focus();
            costTxt.SelectAll();
        }

        private void costTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && costTxt.Text.IndexOf('.') > -1)
                e.Handled = true;

        }

        private void costTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && costTxt.Text != "")
                save();

            else if (e.KeyCode == Keys.Escape && costTxt.Text != "")
            {
                costTxt.Text = "";
                costTxt.Focus();
            }
            else if (e.KeyCode == Keys.Escape && costTxt.Text == "")
                this.Close();

        }

        private void save()
        {
            try
            {
                _cost = Convert.ToDouble(costTxt.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Debe ingresar un número válido", "Error de Formato");
                costTxt.Focus();
                costTxt.SelectAll();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
