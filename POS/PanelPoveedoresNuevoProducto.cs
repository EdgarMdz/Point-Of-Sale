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

        public AutoCompleteStringCollection descriptionCollection { get; set; }

        public AutoCompleteStringCollection barcodeCollection { get; set; }

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
          int SupplierID,
          DataTable products,
          AutoCompleteStringCollection barCodeCollection,
          AutoCompleteStringCollection DescriptionCollection)
        {
            this.InitializeComponent();
            this.SupplierID = SupplierID;
            this.productsTable = products;
            this.barcodeCollection = barCodeCollection;
            this.descriptionCollection = DescriptionCollection;
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
            if (!this.editingMode)
            {
                this.DescriptionTxt.AutoCompleteCustomSource = this.descriptionCollection;
                this.BarCodeTxt.AutoCompleteCustomSource = this.barcodeCollection;
            }
            else
            {
                this.BarCodeTxt.Enabled = false;
                this.DescriptionTxt.Enabled = false;
                this.BarCodeTxt.Text = this.barcode;
                this.DescriptionTxt.Text = this.description;
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
            if (e.KeyCode != Keys.Return || !this.barcodeCollection.Contains(this.BarCodeTxt.Text))
                return;
            Producto producto = new Producto();
            producto.Barcode = this.BarCodeTxt.Text;
            producto.SearchProduct();
            this.DescriptionTxt.Text = producto.Description;
            this.MarcaLbl.Text = producto.Brand;
            this.precioTxt.Text = "0.00";
            this.MinStockLbl.Text = producto.minStock.ToString("n2") + " piezas";
            this.StockLbl.Text = producto.CurrentStock.ToString("n2") + " piezas";
            this.showNextPanel();
        }

        private void BarCodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void DescriptionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            DataTable table = Producto.SearchValueGetTable(this.DescriptionTxt.Text);
            foreach (DataRow row in (InternalDataCollectionBase)table.Rows)
            {
                if (!this.barcodeCollection.Contains(row["Código de Barras"].ToString()))
                    row.Delete();
            }
            table.AcceptChanges();
            if (table.Rows.Count > 1)
            {
                ChooseProductForm chooseProductForm = new ChooseProductForm();
                chooseProductForm.products = table;
                if (chooseProductForm.ShowDialog() == DialogResult.OK)
                {
                    string[] strArray = new string[5];
                    string[] selectedItem = chooseProductForm.selectedItem;
                    this.BarCodeTxt.Text = selectedItem[0];
                    this.DescriptionTxt.Text = selectedItem[1];
                    this.MarcaLbl.Text = selectedItem[2];
                    this.precioTxt.Text = "0.00";
                    this.MinStockLbl.Text = selectedItem[3] + " piezas";
                    this.StockLbl.Text = selectedItem[4] + " piezas";
                    this.showNextPanel();
                }
            }
            if (table.Rows.Count != 1)
                return;
            this.BarCodeTxt.Text = table.Rows[0]["Código de Barras"].ToString();
            this.DescriptionTxt.Text = table.Rows[0]["Descripción"].ToString();
            this.MarcaLbl.Text = table.Rows[0]["Marca"].ToString();
            this.precioTxt.Text = "0.00";
            this.MinStockLbl.Text = Convert.ToDouble(table.Rows[0]["Stock Mínimo"].ToString()).ToString("n2") + " piezas";
            this.StockLbl.Text = Convert.ToDouble(table.Rows[0]["Stock"].ToString()).ToString("n2") + " piezas";
            this.showNextPanel();
        }

        private void BarCodeTxt_TextChanged(object sender, EventArgs e)
        {
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
                    {
                        int num2 = (int)MessageBox.Show("Error:\n" + ex.ToString());
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    int num3 = (int)MessageBox.Show("LLene los campos obligatorios para poder continuar");
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
                    int num2 = (int)MessageBox.Show("Error:\n" + ex.ToString());
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
            if (!this.editingMode && (!this.barcodeCollection.Contains(this.BarCodeTxt.Text) || !this.descriptionCollection.Contains(this.DescriptionTxt.Text)))
                //||                !this.editingMode && this.barcodeCollection.IndexOf(this.BarCodeTxt.Text) != this.descriptionCollection.IndexOf(this.DescriptionTxt.Text))
                return;
            this.NextButton.Hide();
            this.Height = 566;
            this.panel.Show();
            this.CenterToScreen();
        }

        private void DescriptionTxt_TextChanged(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void ResetForm()
        {
            if (!this.panel.Visible)
                return;
            this.panel.Visible = false;
            this.NextButton.Show();
            this.Height = 297;
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
    }
}
