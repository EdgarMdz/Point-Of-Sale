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

namespace POS
{
    public partial class Panel_productos_Transferir_Inventario_entre_bodegas : Form
    {
        private Producto product;
        private Bodega receiverDepot;
        private Bodega donatingDepot;
        private int transferCount;
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
            foreach (DataRow row in (InternalDataCollectionBase)Bodega.GetDepots().Rows)
            {
                this.receiverCombo.Items.Add(row["Nombre"]);
                this.ReceiverDepotIDs.Add(Convert.ToInt32(row["ID_Bodega"]));
            }
            this.receiverCombo.SelectedItem = (object)new Bodega(product.defaultDepotID).name;
            this.receiverDepot = new Bodega(product.defaultDepotID);
            this.setReceiverDepotCard();
        }

        private void setReceiverDepotCard()
        {
            this.piecesPerCaseTxt.Text = this.product.PiecesPerCase.ToString("n2");
            this.BarcodeLbl.Text = this.product.Barcode;
            this.descriptionLbl.Text = this.product.Description;
            this.brandLbl.Text = this.product.Brand;
            if (this.product.Image != null)
            {
                Image image = Image.FromStream((Stream)new MemoryStream(this.product.Image, 0, this.product.Image.Length));
                this.productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.productPicture.Image = image;
                this.productPicture.BorderStyle = BorderStyle.None;
                this.label4.Visible = false;
            }
            else
            {
                this.label4.Visible = true;
                this.productPicture.Image = (Image)null;
                this.productPicture.BorderStyle = BorderStyle.FixedSingle;
            }
            this.quantityLbl.Text = this.receiverDepot.getProductQuantity(this.product.Barcode).ToString();
            this.addedPiecesLbl.Visible = false;
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
                    int num = (int)MessageBox.Show("No se encontró el producto", "Sin coincidencias", MessageBoxButtons.OK);
                }
                else if (table.Rows.Count == 1)
                {
                    this.product = new Producto(table.Rows[0]["Código de Barras"].ToString());
                    this.setReceiverDepotCard();
                    if (this.donatingDepot == null || this.receiverDepot == null)
                        return;
                    this.transferCount = 0;
                    this.setDonatingDepotCard();
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
                    }
                    darkForm.Close();
                }
            }
            else
            {
                Producto producto = new Producto(this.ProductTxt.Text);
                if (producto.Description == null)
                {
                    int num = (int)MessageBox.Show("No se encontró el producto", "Sin coincidencias", MessageBoxButtons.OK);
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
                this.setDonatingDepotCard();
            }
            this.receiverDepot = new Bodega(this.ReceiverDepotIDs[this.receiverCombo.SelectedIndex]);
            this.setReceiverDepotCard();
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
            this.DonatingCombo.SelectedIndex = 0;
        }

        private void LongLessBtn_Click(object sender, EventArgs e)
        {
            int num1 = (int)Convert.ToDouble(this.piecesPerCaseTxt.Text);
            int num2 = this.transferCount - num1 < 0 ? this.transferCount : num1;
            if (num2 <= 0)
                return;
            this.transferCount -= num2;
            this.countChanged();
        }

        private void LongMoreBtn_Click(object sender, EventArgs e)
        {
            if (this.transferCount >= this.trackBar1.Maximum)
                return;
            double num = Convert.ToDouble(this.piecesPerCaseTxt.Text);
            this.transferCount += (int)num + this.transferCount > this.trackBar1.Maximum ? this.trackBar1.Maximum - this.transferCount : (int)num;
            this.countChanged();
        }

        private void ToCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.donatingDepot = new Bodega(this.DonatingComboDepotsIds[this.DonatingCombo.SelectedIndex]);
            if (this.donatingDepot == null || this.receiverDepot == null)
                return;
            this.transferCount = 0;
            this.setDonatingDepotCard();
        }

        private void MoreBtn_Click(object sender, EventArgs e)
        {
            if (this.transferCount + 1 > this.trackBar1.Maximum)
                return;
            ++this.transferCount;
            this.countChanged();
        }

        private void LessBtn_Click(object sender, EventArgs e)
        {
            if (this.transferCount - 1 < 0)
                return;
            --this.transferCount;
            this.countChanged();
        }

        public void countChanged()
        {
            this.addedPiecesLbl.Text = "+ " + this.transferCount.ToString() + " piezas";
            double num = this.donatingDepot.getProductQuantity(this.product.Barcode) - (double)this.transferCount;
            this.boxQuantLbl.Text = Math.Truncate(num / Convert.ToDouble(this.piecesPerCaseTxt.Text)).ToString() + " cajas";
            this.pieceQuantLbl.Text = (num % Convert.ToDouble(this.piecesPerCaseTxt.Text)).ToString() + " piezas";
            this.trackBar1.Value = this.transferCount;
            this.addedPiecesLbl.Visible = true;
        }

        private void setDonatingDepotCard()
        {
            double productQuantity = this.donatingDepot.getProductQuantity(this.product.Barcode);
            this.boxQuantLbl.Text = Convert.ToDouble(this.piecesPerCaseTxt.Text) == 0.0 ? "0 cajas" : Math.Truncate(productQuantity / Convert.ToDouble(this.piecesPerCaseTxt.Text)).ToString() + " cajas";
            this.pieceQuantLbl.Text = Convert.ToDouble(this.piecesPerCaseTxt.Text) == 0.0 ? "0 piezas" : (productQuantity % Convert.ToDouble(this.piecesPerCaseTxt.Text)).ToString() + " piezas";
            this.trackBar1.Maximum = productQuantity < 0.0 ? 0 : (int)productQuantity;
            this.trackBar1.Value = 0;
            this.trackBar1.LargeChange = this.trackBar1.Maximum / 4 == 0 ? 1 : this.trackBar1.Maximum / 4;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.trackbarMoved();
        }

        private void trackbarMoved()
        {
            this.transferCount = this.trackBar1.Value;
            this.countChanged();
        }

        private void switchDepotsBtn_Click(object sender, EventArgs e)
        {
            this.transferCount = 0;
            string str = this.receiverCombo.SelectedItem.ToString();
            this.receiverCombo.SelectedItem = this.DonatingCombo.SelectedItem;
            this.DonatingCombo.SelectedItem = (object)str;
        }

        private void piecesPerCaseTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.piecesPerCaseTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            this.receiverDepot.UpdateProductQuantity(this.receiverDepot.getProductQuantity(this.product.Barcode) + (double)this.transferCount, this.product.Barcode);
            this.donatingDepot.UpdateProductQuantity(this.donatingDepot.getProductQuantity(this.product.Barcode) - (double)this.transferCount, this.product.Barcode);
            this.setReceiverDepotCard();
            this.setDonatingDepotCard();
            int num = (int)MessageBox.Show("Operación exitosa");
            this.altered = true;
        }

        private void piecesPerCaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.piecesPerCaseTxt.Text != "" && this.donatingDepot != null)
            {
                if (this.receiverDepot != null)
                {
                    try
                    {
                        Convert.ToInt32(Convert.ToDouble(this.piecesPerCaseTxt.Text));
                        this.trackbarMoved();
                    }
                    catch (OverflowException ex)
                    {
                        int num = (int)MessageBox.Show("El número máximo aceptable es " + int.MaxValue.ToString() + ".", "Número demaciado grande");
                        this.piecesPerCaseTxt.Text = this.product.PiecesPerCase.ToString("n2");
                        this.piecesPerCaseTxt.SelectAll();
                    }
                    catch (FormatException)
                    {
                        int num = (int)MessageBox.Show("Sólo se permiten valores numéricos", "Formato no Válido");
                        this.piecesPerCaseTxt.Text = this.product.PiecesPerCase.ToString("n2");
                        this.piecesPerCaseTxt.SelectAll();
                    }
                }
            }
            if (!(this.piecesPerCaseTxt.Text == ""))
                return;
            this.piecesPerCaseTxt.Text = this.product.PiecesPerCase.ToString("n2");
            this.piecesPerCaseTxt.SelectAll();
        }

        private void ProductTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void DonatingDepotCard_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Panel_productos_Transferir_Inventario_entre_bodegas_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 3);

            e.Graphics.DrawRectangle(p, this.ClientRectangle);
            p.Dispose();
        }
    }
}
