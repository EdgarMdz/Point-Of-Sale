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
    public partial class formAgregar_VentaSurtido_AgregarAGrupo : Form
    {
        public string barcode { get { return _barcode; } }
        string _barcode;
        public formAgregar_VentaSurtido_AgregarAGrupo()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Producto.findSellingMixedGroup(textBox1.Text) > 0)
            {
                MessageBox.Show("El producto que busca ya se encuentra registrado en otro grupo. Sólo se permite" +
                  "que los productos pertenezcan a un único grupo");
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            saveBarcode();
        }

        private void saveBarcode()
        {
            Producto p = new Producto(textBox1.Text);
            if (p.Barcode != "")
            {
                _barcode = p.Barcode;
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se encontró un producto registrado para el código de barras ingresado.", "Sin coincidencias");
                textBox1.SelectAll();
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
                saveBarcode();

            else if (e.KeyCode == Keys.Escape && textBox1.Text != "")
                textBox1.Text = "";

            else if (e.KeyCode == Keys.Escape && textBox1.Text == "")
                this.Close();
        }
    }
}
