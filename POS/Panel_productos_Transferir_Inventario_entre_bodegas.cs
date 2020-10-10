using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace POS
{
    public partial class Panel_productos_Transferir_Inventario_entre_bodegas : Form
    {
        private Producto product;
        private Bodega receiverDepot;
        private Bodega donatingDepot;
        private double transferCount;
        private bool altered;
        private List<int> ReceiverDepotIDs;
        private List<int> DonatingComboDepotsIds;


        public Panel_productos_Transferir_Inventario_entre_bodegas(Producto product)
        {
            this.InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            
            this.transferCount = 0;
            
            this.altered = false;
            
            this.product = product;
            
            this.ReceiverDepotIDs = new List<int>();
            this.DonatingComboDepotsIds = new List<int>();
           
            foreach (DataRow row in Bodega.GetDepots().Rows)
            {
                this.receiverCombo.Items.Add(row["Nombre"]);
                this.ReceiverDepotIDs.Add(Convert.ToInt32(row["ID_Bodega"]));
            }
            
            this.receiverCombo.SelectedItem = new Bodega(product.defaultDepotID).name;
            this.receiverDepot = new Bodega(product.defaultDepotID);

            this.setReceiverDepotCard();
            ProductTxt.Select();
        }



        private void setReceiverDepotCard()
        {
            this.BarcodeLbl.Text = this.product.Barcode;
            this.descriptionLbl.Text = this.product.Description;
            this.brandLbl.Text = this.product.Brand;
            costLbl.Text = "$" + product.RetailCost.ToString("n2");
            piecesPerCaseLbl.Text = product.PiecesPerCase.ToString() + " piezas por caja";

            if (this.product.Image != null)
            {
                Image image = Image.FromStream((Stream)new MemoryStream(this.product.Image, 0, this.product.Image.Length));
                this.productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.productPicture.Image = image;
                this.productPicture.BorderStyle = BorderStyle.None;
                this.label4.Visible = false;
                panel4.BackColor = Color.Transparent;
            }
            else
            {
                this.label4.Visible = true;
                this.productPicture.Image = (Image)null;
                this.productPicture.BorderStyle = BorderStyle.FixedSingle;
                panel4.BackColor = Color.FromArgb(196, 196, 196);
            }

            var stock = Producto.getCasesAndSingleProducts(product, receiverDepot.getProductQuantity(product.Barcode));

            this.quantityLbl.Text = stock.Item1.ToString() +" Cajas";
            quantityPcsLbl.Text= stock.Item2.ToString() + " Piezas";

            this.addedPiecesLbl.Visible = false;
            addedPiecesLbl.Text = " 0 piezas";
        }

        private void ProductTxt_Enter(object sender, EventArgs e)
        {
            if (this.ProductLbl.Visible)
                return;
            this.ProductLbl.Visible = true;
        }

        private void ProductTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.ProductLbl.Visible || !(this.ProductTxt.Text != ""))
                return;
            this.ProductLbl.Visible = true;
        }

        private void ProductTxt_Leave(object sender, EventArgs e)
        {
            this.ProductLbl.Visible = this.ProductTxt.Text != "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = this.altered ? DialogResult.OK : DialogResult.Cancel;
            this.Close();
        }

        private void ProductTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || !(this.ProductTxt.Text != ""))
                return;
            if (!this.isNumber(this.ProductTxt.Text))
            {
                DataTable table = Producto.SearchValueGetTable(this.ProductTxt.Text);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el producto", "Sin coincidencias", MessageBoxButtons.OK);
                }
                else if (table.Rows.Count == 1)
                {
                    this.product = new Producto(table.Rows[0]["Código de Barras"].ToString());
                    this.setReceiverDepotCard();
                    if (this.donatingDepot == null || this.receiverDepot == null)
                        return;
                    this.transferCount = 0;
                    this.setDonatingDepotCard();
                    textBox1.Select();
                }
                else
                {
                    DarkForm darkForm = new DarkForm();
                    ChooseProductForm chooseProductForm = new ChooseProductForm(table);
                    darkForm.Show();
                    if (chooseProductForm.ShowDialog() == DialogResult.OK)
                    {
                        this.product = new Producto(chooseProductForm.selectedItem[0]);
                        this.setReceiverDepotCard();
                        if (this.donatingDepot != null && this.receiverDepot != null)
                        {
                            this.transferCount = 0;
                            this.setDonatingDepotCard();
                        }
                        textBox1.Select();
                    }
                    darkForm.Close();
                }
            }
            else
            {
                Producto producto = new Producto(this.ProductTxt.Text);
                if (producto.Description == null)
                {
                    MessageBox.Show("No se encontró el producto", "Sin coincidencias", MessageBoxButtons.OK);
                }
                else
                {
                    this.product = producto;
                    this.setReceiverDepotCard();
                    if (this.donatingDepot == null || this.receiverDepot == null)
                        return;
                    this.transferCount = 0;
                    this.setDonatingDepotCard();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.receiverDepot != null && this.donatingDepot != null)
            {
                this.transferCount = 0;
                textBox1.Text = "0.00";
                this.setDonatingDepotCard();
            }

            this.receiverDepot = new Bodega(this.ReceiverDepotIDs[this.receiverCombo.SelectedIndex]);
            this.setReceiverDepotCard();

            var currentDonatingID = donatingDepot != null ? donatingDepot.ID : 0;

            this.DonatingCombo.Items.Clear();
            this.DonatingComboDepotsIds = new List<int>();
            
            for (int index = 0; index < this.receiverCombo.Items.Count; ++index)
            {
                if (index != this.receiverCombo.SelectedIndex)
                {
                    this.DonatingCombo.Items.Add((object)this.receiverCombo.Items[index].ToString());
                    this.DonatingComboDepotsIds.Add(this.ReceiverDepotIDs[index]);
                }
            }

            currentDonatingID = DonatingComboDepotsIds.IndexOf(currentDonatingID);
            this.DonatingCombo.SelectedIndex = currentDonatingID > -1 ? currentDonatingID : 0;
        }


        private void ToCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.donatingDepot = new Bodega(this.DonatingComboDepotsIds[this.DonatingCombo.SelectedIndex]);

            if (this.donatingDepot == null || this.receiverDepot == null)
                return;

            transferCount = 0;
            textBox1.Text = "0.00";
            addedPiecesLbl.Hide();
            setDonatingDepotCard();
        }



        public void countChanged()
        {
            this.addedPiecesLbl.Text = "+ " + this.transferCount.ToString() + " piezas";
            double num = this.donatingDepot.getProductQuantity(this.product.Barcode) - (double)this.transferCount;


            this.addedPiecesLbl.Visible = true;
        }

        private void setDonatingDepotCard()
        {
            var productQuantity = getCasesAndSingleProducts(product.PiecesPerCase, donatingDepot.getProductQuantity(product.Barcode));
            boxQuantLbl.Text = productQuantity.Item1 != 1 ? productQuantity.Item1.ToString() + " Cajas" : productQuantity.Item1.ToString() + " Caja";
            pieceQuantLbl.Text = productQuantity.Item2 != 1 ? productQuantity.Item2.ToString() + " Piezas" : productQuantity.Item2.ToString() + " Piezas";
            label7.Text = "0 piezas";
            label7.Visible = false;
        }
        public static Tuple<int, double> getCasesAndSingleProducts(double piecesPerCase, double amount)
        {
            int cases = piecesPerCase > 1.0 ? (int)Math.Truncate(amount / piecesPerCase) : 0;
            double singlePieces = piecesPerCase > 1.0 ? amount % piecesPerCase : amount;

            return new Tuple<int, double>(cases, singlePieces);
        }

        private void switchDepotsBtn_Click(object sender, EventArgs e)
        {
            string str = this.receiverCombo.SelectedItem.ToString();
            this.receiverCombo.SelectedItem = this.DonatingCombo.SelectedItem;
            this.DonatingCombo.SelectedItem = str;
        }



        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (transferCount > 0)
            {
                this.receiverDepot.UpdateProductQuantity(this.receiverDepot.getProductQuantity(this.product.Barcode) + this.transferCount, this.product.Barcode);
                this.donatingDepot.UpdateProductQuantity(this.donatingDepot.getProductQuantity(this.product.Barcode) - this.transferCount, this.product.Barcode);
                this.setReceiverDepotCard();
                this.setDonatingDepotCard();
                MessageBox.Show("Operación exitosa");
                this.altered = true;
                transferCount = 0;
                textBox1.Text = "";
            }
        }


        private void ProductTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


        private void Panel_productos_Transferir_Inventario_entre_bodegas_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 3);

            e.Graphics.DrawRectangle(p, this.ClientRectangle);
            p.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                transferCount = Convert.ToDouble(textBox1.Text);

                this.addedPiecesLbl.Text = "+ " + this.transferCount.ToString() + " piezas";
                label7.Text = "- " + transferCount.ToString() + " piezas";


                this.addedPiecesLbl.Visible = true;
                label7.Visible = true;

            }
            catch (FormatException)
            {
                transferCount = 0;
                addedPiecesLbl.Visible = false;
                label7.Visible = false;
            }


            changeReveivedDepotStock();
            changeDonatingDepotStock();
        }

        private void changeDonatingDepotStock()
        {
            var stock = getCasesAndSingleProducts(product.PiecesPerCase, donatingDepot.getProductQuantity(product.Barcode)- transferCount);
            //var transfer = getCasesAndSingleProducts(product.PiecesPerCase, );

            var cases = stock.Item1;// - transfer.Item1;
            var pieces = stock.Item2;// - transfer.Item2;
            
            boxQuantLbl.Text = cases == 1 || cases == -1 ? cases.ToString() + " Caja" : cases.ToString() + " Cajas";
            pieceQuantLbl.Text = pieces == 1 || pieces == -1 ? pieces.ToString() + " Pieza" : pieces.ToString() + " Piezas";
        }

        private void changeReveivedDepotStock()
        {
            var stock = getCasesAndSingleProducts(product.PiecesPerCase, receiverDepot.getProductQuantity(product.Barcode)+transferCount);
            // var transfer = getCasesAndSingleProducts(product.PiecesPerCase, transferCount);

            var cases = stock.Item1;// + transfer.Item1;
            var pieces = stock.Item2;// + transfer.Item2;

            quantityLbl.Text = cases == 1 || cases == -1 ? cases.ToString() + " Caja" : cases.ToString() + " Cajas";
            quantityPcsLbl.Text = pieces == 1 || pieces == -1 ? pieces.ToString() + " Pieza" : pieces.ToString() + " Piezas";
        }


        private void Panel_productos_Transferir_Inventario_entre_bodegas_Paint_1(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black) { Width=2};

            e.Graphics.DrawRectangle(pen, 1, 1, this.Width - 2, this.Height - 1);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
