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
    public partial class PanelPoveedoresNuevoProducto : Form
    {

        public int SupplierID { get; set; }

        public string barcode { get; set; }

        public double price { get; set; }

        public double piecesPerCase { get; set; }

        public string brand { get; set; }

        public string description { get; set; }

        public double minStok { get; set; }

        public double Stock { get; set; }

        public bool editingMode { get; set; }

        public DataTable productsTable { get; set; }

        public PanelPoveedoresNuevoProducto()
        {
            this.InitializeComponent();
        }

        public PanelPoveedoresNuevoProducto(
          int SupplierID)
        {
            this.InitializeComponent();
            this.SupplierID = SupplierID;
            this.ShowInTaskbar = false;
            this.editingMode = false;
        }

        public PanelPoveedoresNuevoProducto(int SupplierID, Producto product, double piecesPerCase)
        {
            this.InitializeComponent();
            this.editingMode = true;
            this.SupplierID = SupplierID;
            this.barcode = product.Barcode;
            this.description = product.Description;
            this.brand = product.Brand;
            this.Stock = product.CurrentStock;
            this.minStok = product.minStock;
            this.price = product.PurchaseCost;
            this.piecesPerCase = piecesPerCase;
            this.ShowInTaskbar = false;
        }

        private void PanelPoveedoresNuevoProducto_Load(object sender, EventArgs e)
        {
            if (this.editingMode)
            {
                this.BarCodeTxt.Enabled = false;
                this.BarCodeTxt.Text = this.barcode;
                this.descriptionLbl.Text = this.description;
                this.MarcaLbl.Text = this.brand;
                this.StockLbl.Text = this.Stock.ToString("n2");
                this.MinStockLbl.Text = this.minStok.ToString("n2");
                this.precioTxt.Text = this.price.ToString("n2");
                this.piecesperCaseTxt.Text = this.piecesPerCase.ToString("n2");
                this.showNextPanel();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                showNextPanel();
            }
        }
        
        private void BarCodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.Height > 250)
                this.ResetForm();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (this.precioTxt.Text == "" || Convert.ToDouble(this.precioTxt.Text) == 0.0)
            {
                MessageBox.Show("El precio debe ser diferente de cero");
            }
            else if (!this.editingMode)
            {
                if (this.precioTxt.Text != "" && this.BarCodeTxt.Text != "")
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor.ID = this.SupplierID;
                    this.price = Convert.ToDouble(this.precioTxt.Text);
                    this.piecesPerCase = this.piecesperCaseTxt.Text != "" ? Convert.ToDouble(this.piecesperCaseTxt.Text) : 1.0;
                    string text = this.BarCodeTxt.Text;
                    try
                    {
                        proveedor.AddProduct(text, this.price, this.piecesPerCase);
                        barcode = BarCodeTxt.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {MessageBox.Show("Error:\n" + ex.ToString());
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    MessageBox.Show("LLene los campos obligatorios para poder continuar");
                }
            }
            else
            {
                if (MessageBox.Show("Desea Guardar los Cambios", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                this.price = Convert.ToDouble(this.precioTxt.Text);
                this.piecesPerCase = this.piecesperCaseTxt.Text != "" ? Convert.ToDouble(this.piecesperCaseTxt.Text) : 1.0;
                try
                {
                    new Proveedor().SupplierEditProduct(this.SupplierID, this.barcode, this.price, this.piecesPerCase);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.ToString());
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.showNextPanel();
        }

        private void showNextPanel()
        {
            if (!isNumber(BarCodeTxt.Text))
            {
                var results = Producto.SearchValueGetTable(BarCodeTxt.Text);

                if (results.Rows.Count == 1)
                {
                    if (new Proveedor(SupplierID).getProductInfo(BarCodeTxt.Text).Rows.Count == 0 || editingMode)
                    {
                        barcode = results.Rows[0]["código de barras"].ToString();
                        var p = new Producto(barcode);
                        descriptionLbl.Text = p.Description;
                        MarcaLbl.Text = p.Brand;
                        StockLbl.Text = p.CurrentStock.ToString("n2");
                        MinStockLbl.Text = p.minStock.ToString("n2");
                        this.NextButton.Hide();
                        this.Height = 540;
                        this.panel.Show();
                        this.CenterToScreen();
                        precioTxt.Select();
                    }
                    else
                        MessageBox.Show("El producto ya se encuentra registrado para este proveedor");
                }
                else if (results.Rows.Count > 1)
                {
                    ChooseProductForm form = new ChooseProductForm(results);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        barcode = form.selectedItem[0];

                        var p = new Producto(barcode);
                        descriptionLbl.Text = p.Description;
                        MarcaLbl.Text = p.Brand;
                        StockLbl.Text = p.CurrentStock.ToString("n2");
                        MinStockLbl.Text = p.minStock.ToString("n2");
                        precioTxt.Select();
                        this.NextButton.Hide();
                        this.Height = 540;
                        this.panel.Show();
                        this.CenterToScreen();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos");
                    barcode = "";
                }
            }
            else
            {
                if (Producto.SearchProduct(BarCodeTxt.Text)&&  new Proveedor(SupplierID).getProductInfo(BarCodeTxt.Text).Rows.Count == 0 || editingMode)
                {
                    barcode = BarCodeTxt.Text;
                    var p = new Producto(barcode);
                    descriptionLbl.Text = p.Description;
                    MarcaLbl.Text = p.Brand;
                    StockLbl.Text = p.CurrentStock.ToString("n2");
                    MinStockLbl.Text = p.minStock.ToString("n2");
                    this.NextButton.Hide();
                    this.Height = 540;
                    this.panel.Show();
                    this.CenterToScreen();
                    precioTxt.Select();
                }
                else
                    MessageBox.Show("El producto ya se encuentra registrado para este proveedor");
            }
        }

        bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }
     
        private void ResetForm()
        {
            if (!this.panel.Visible)
                return;
            this.panel.Visible = false;
            this.NextButton.Show();
            this.Height = 250;
            this.CenterToScreen();
        }

        private void piecesperCaseTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.piecesperCaseTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void piecesperCaseTxt_Leave(object sender, EventArgs e)
        {
            if (!(this.piecesperCaseTxt.Text == ""))
                return;
            this.piecesperCaseTxt.Text = "1.00";
        }

        private void precioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && precioTxt.Text.IndexOf(".") > -1)
                e.Handled = true;
        }
    }
}
