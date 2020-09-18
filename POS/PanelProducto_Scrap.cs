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
    public partial class PanelProducto_Scrap : Form
    {
        private Size minimized = new Size(615, 143);
        private Size maximized = new Size(615, 757);
        private int employeeID = 1;
        private Producto product;
        private Bodega depot;
        private Dictionary<string, int> depotList;
        private double scrapCount;
        private bool scrapRegistered;

        public PanelProducto_Scrap()
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.product = (Producto)null;
            this.depot = (Bodega)null;
            this.Size = this.minimized;
            this.scrapCount = 0.0;
            this.depotList = new Dictionary<string, int>();
            foreach (DataRow row in (InternalDataCollectionBase)Bodega.GetDepots().Rows)
            {
                this.comboBox1.Items.Add((object)row["Nombre"].ToString());
                this.depotList.Add(row["Nombre"].ToString(), Convert.ToInt32(row["ID_Bodega"]));
            }
            textBox1.SelectAll();
            
            this.comboBox1.SelectedIndex = 0;
            this.depot = new Bodega(1);
            this.Refresh();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (!this.scrapRegistered)
                return;
            this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.product == null || this.depot == null)
                return;
            this.scrapCount = 0.0;
            this.scrapLbl.Visible = false;
            this.depot = new Bodega(this.depotList[this.comboBox1.SelectedItem.ToString()]);
            this.setProduct();
        }

        private void displayScrap()
        {
            this.scrapLbl.Text = "-" + this.scrapCount.ToString("n2") + " piezas";
            this.stockLbl.Text = (this.depot.getProductQuantity(this.product.Barcode) - this.scrapCount).ToString("n2");
        }

     

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.searchProduct();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (this.scrapCount == 0.0)
                return;
            this.depot.RegisterScrap(this.product.Barcode, this.scrapCount, this.employeeID);
            
            MessageBox.Show("Se ha dado de baja el material");

            textBox1.Text = "0.00";
            this.scrapRegistered = true;
            this.scrapCount = 0.0;
            this.scrapLbl.Hide();
            this.depot = new Bodega(this.depot.ID);
            this.setProduct();
            
        }

        private void PanelProducto_Scrap_Resize(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.searchProduct();
        }

        private void searchProduct()
        {
            if (!(this.SearchTxt.Text != ""))
                return;
            if (!this.isNumber(this.SearchTxt.Text))
            {
                DataTable table = Producto.SearchValueGetTable(this.SearchTxt.Text);
                if (table.Rows.Count == 0)
                {
                    int num = (int)MessageBox.Show("No se encontraron coincidencias");
                    this.SearchTxt.Select();
                }
                else if (table.Rows.Count == 1)
                {
                    this.product = new Producto(table.Rows[0]["Código de Barras"].ToString());
                    this.setProduct();
                }
                else
                {
                    ChooseProductForm chooseProductForm = new ChooseProductForm(table);
                    if (chooseProductForm.ShowDialog() != DialogResult.OK)
                        return;
                    this.product = new Producto(chooseProductForm.selectedItem[0]);
                    this.setProduct();
                }
            }
            else
            {
                Producto producto = new Producto(this.SearchTxt.Text);
                if (producto.Description == null)
                {
                    int num = (int)MessageBox.Show("No se encontraron coincidencias");
                    this.SearchTxt.Select();
                }
                else
                {
                    this.product = producto;
                    this.setProduct();
                }
            }
        }

        private bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.SearchTxt.Text != "")
                this.searchProduct();
            else if (e.KeyCode == Keys.Escape && this.SearchTxt.Text != "")
            {
                this.SearchTxt.Text = "";
            }
            else
            {
                if (e.KeyCode != Keys.Escape || !(this.SearchTxt.Text == ""))
                    return;
                this.Close();
            }
        }

        private void setProduct()
        {
            this.SearchTxt.Text = "";
            this.productLbl.Text = this.product.Description;
            this.barcodeLbl.Text = this.product.Barcode;
            this.brandLbl.Text = this.product.Brand;
            if (this.product.image != null)
            {
                this.pictureBox1.BorderStyle = BorderStyle.None;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.Image = this.product.image;
                this.NoPictureLbl.Hide();
            }
            else
            {
                this.NoPictureLbl.Show();
                this.pictureBox1.Image = (Image)null;
                this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            this.NextBtn.Hide();
            this.searchBtn.Show();
            this.bunifuCards1.Show();
            this.Size = this.maximized;

            Refresh();
            double productQuantity = this.depot.getProductQuantity(this.product.Barcode);
            this.stockLbl.Text = productQuantity.ToString("n2");

            textBox1.Text = "0.00";
        }

        
        private void PanelProducto_Scrap_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Tomato) { Width = 2 };

            e.Graphics.DrawRectangle(pen, 1, 1, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                scrapCount = Convert.ToDouble(textBox1.Text);
                displayScrap();
                scrapLbl.Visible = true;
                
            }
            catch(Exception)
            {
                scrapCount = 0;
                displayScrap();
                scrapLbl.Hide();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
