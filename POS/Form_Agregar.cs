using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form_Agregar : Form
    {
        private bool editingMode;
        private string barcode;
        private int[] depotID;
        private CancellationTokenSource cancellationTokenSource;

        public Form_Agregar()
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.getDepots();
            panel5.Hide();
        }

        public Form_Agregar(Producto product)
        {
            this.InitializeComponent();
            this.getDepots();
            this.SetInfoForEditing(product);
            this.stockTxt.Enabled = false;
            this.barcodeTxt.Enabled = false;
            this.ShowInTaskbar = false;
            wholesaleCostsBtn.Show();
            pictureBox1.Controls.Add(panel5);
            panel5.BringToFront();
            panel5.Location = new Point((pictureBox1.Width - panel5.Width) / 2, (pictureBox1.Height - panel5.Height) / 2);

            removeImageBtn.Parent = pictureBox1;
            removeImageBtn.Location = new Point(3, 3);


            var table = product.checkForStoredPurchaseCosts();
            if (table.Rows.Count > 0)
            {
                purchaseCostLbl.Font = new Font(purchaseCostLbl.Font.FontFamily, purchaseCostLbl.Font.Size, FontStyle.Underline | FontStyle.Bold);
                purchaseCostLbl.Cursor = Cursors.Hand;

                purchaseCostLbl.Click += (s, e) =>
                  {
                      Panel_Productos_precios_de_compra form = new Panel_Productos_precios_de_compra(table);
                      form.FormClosing += (ss, ee) =>
                      {
                          if (form.rows != table.Rows.Count)
                          {
                              table = product.checkForStoredPurchaseCosts();
                              PurchaseCostTxt.Text = new Producto(product.Barcode).PurchaseCost.ToString("n2");
                          }

                      };

                      form.ShowDialog();
                  };

                
            }
            alterProductsList.Visible = product.getDerivedProductsList().Rows.Count > 0;
        }

        private void getDepots()
        {
            DataTable depots = Bodega.GetDepots();
            this.depotID = new int[depots.Rows.Count];
            for (int index = 0; index < depots.Rows.Count; ++index)
            {
                DataRow row = depots.Rows[index];
                this.comboBox1.Items.Add(row["Nombre"]);
                this.depotID[index] = Convert.ToInt32(row["ID_Bodega"]);
            }
            this.comboBox1.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.pictureBox1.Image = (Image)new Bitmap(openFileDialog.FileName);
            this.pictureBox1.BorderStyle = BorderStyle.None;
            removeImageBtn.Show();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (this.LinkProductCheckBox.Checked && this.linkedProductBarcodeTxt.Text == "" || this.LinkProductCheckBox.Checked && this.barcodeTxt.Text == this.linkedProductBarcodeTxt.Text)
            {
                this.linkedProductBarcodeTxt.LineIdleColor = Color.Red;
                this.linkedProductBarcodeTxt.HintForeColor = Color.Tomato;
            }
            else if (LinkProductCheckBox.Checked && !Producto.SearchProduct(this.linkedProductBarcodeTxt.Text))
            {
                MessageBox.Show("No se encontró el producto producto principal.\nRevise que el código de barras sea correcto");
            }
            else if (!checkFieldData())
            {
                MessageBox.Show("Revise los costos sean coherentes.\n " +
                    "•El precio de compra no debe ser mayor al precio por caja\n" +
                    "•El precio de caja no debe ser mayor al precio de menudeo multiplicado por las piezas por caja.", "Incongruencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                this.AddEditProduct();
        }

        private bool checkFieldData()
        {
            bool result1 = false;
            bool result2 = false;
            try
            {                
                var retail = Convert.ToDouble(retailCostTxt.Text);

                var purchase = purchaseCostLbl.Text == "" ? 0 : Convert.ToDouble(PurchaseCostTxt.Text);
                var pieces = Convert.ToDouble(piecesByCaseTxt.Text);
                var caseCost = costbyCaseTxt.Text == "" ? retail * pieces : Convert.ToDouble(costbyCaseTxt.Text);

                if (purchase <= caseCost)
                {
                    if (caseCost <= pieces * retail)
                    {
                        costbyCaseTxt.ForeColor = Color.FromArgb(0, 130, 170);
                        result1 = true;
                    }
                    else
                        costbyCaseTxt.ForeColor = Color.Tomato;
                }
                else
                    costbyCaseTxt.ForeColor = Color.Tomato;

                if(retail< purchase/pieces)
                {
                    retailCostTxt.ForeColor = Color.Tomato;
                }
                else
                {
                    result2 = true;
                    retailCostTxt.ForeColor = Color.FromArgb(0, 130, 170);
                }
            }
            catch(FormatException){}
            return result1 && result2;

        }

        private void AddEditProduct()
        {
            Producto producto = new Producto();
            if (!this.editingMode)
            {
                if (this.DescriptionTxt.Text != "" && this.barcodeTxt.Text != "" && this.retailCostTxt.Text != "")
                {
                    var canproceed = this.GetInfo(producto);
                    if (!canproceed)
                        return;
                    if (!producto.SearchProduct())
                    {
                        producto.addProduct();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                       MessageBox.Show("Ya existe un producto registrado con el mismo Código de Barras");
                        this.barcodeTxt.Focus();
                        this.barcodeTxt.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Llene los campos Descripción, Precio Minoreo y Código de Barras");
                }
            }
            else if (this.DescriptionTxt.Text != "" && this.barcodeTxt.Text != "" && this.retailCostTxt.Text != "")
            {
                bool canProceed = GetInfo(producto);//setting information
                if (!canProceed)
                    return;

                if (!Producto.SearchProduct(producto.Barcode) || producto.Barcode == this.barcode)
                {
                    ///
                    int groupID = Producto.findSellingMixedGroup(producto.Barcode);
                    if (groupID > 0)
                    {
                        DataTable dt = Producto.getMixedSaleGroupInfo(groupID);
                        Producto partnerProduct = new Producto();
                        int productRowNumber=0;//used to remove the product from the group if the user decides to do it

                        //finding a different product that belong to the same group to campare
                        for(int i=0;i<dt.Rows.Count;i++)
                        {
                            DataRow row = dt.Rows[i];

                            if (row["id_producto"].ToString() != producto.Barcode)
                            {
                                partnerProduct = new Producto(row["id_producto"].ToString());
                                productRowNumber = i;
                                break;
                            }
                        }

                        if (partnerProduct.Barcode != "")
                        {
                            if (partnerProduct.PiecesPerCase!= producto.PiecesPerCase
                                || partnerProduct.CostPerCase != producto.CostPerCase)
                            {
                                string message = "El producto que desea editar se encuentra registrado" +
                                    "junto a otros productos para vender por caja surtida. ¿Desea actualizar el precio por caja y/o " +
                                    "las piezas por caja del resto de los productos?";

                                if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.No)
                                {
                                    if (MessageBox.Show("¿Desea borrar este producto del grupo de venta de caja surtida al que pertenece para poder continuar?"
                                        , "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        //delete product from group and update
                                        dt.Rows.RemoveAt(productRowNumber);
                                        dt.Columns.Remove("Descripción");
                                        dt.Columns.Remove("Marca");
                                        dt.AcceptChanges();
                                        Producto.updateGroup(groupID, dt);
                                    
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    //update the pieces per case and cost of each product from the mixed case group 
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        if (row["id_producto"].ToString() == producto.Barcode)
                                            continue;

                                        Producto p = new Producto(row["id_producto"].ToString());
                                        p.CostPerCase = producto.CostPerCase;
                                        p.PiecesPerCase = producto.PiecesPerCase;

                                        p.UpdateProduct(p.Barcode);
                                    }
                                }
                            }
                        }
                    }


                    producto.UpdateProduct(this.barcode);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    int num2 = (int)MessageBox.Show("Ya existe otro producto con el mismo codigo de barras. Elimine este producto primero para poder continuar");
                }
            }
            else
            {
                int num3 = (int)MessageBox.Show("Llene los campos Descripción, Precio Minoreo y Código de Barras");
            }
        }

        bool GetInfo(Producto producto)
        {
            producto.Description = this.DescriptionTxt.Text;
            producto.Barcode = this.barcodeTxt.Text;
            
            if (this.BrandTxt.Text != "")
                producto.Brand = this.BrandTxt.Text;
            
            if (this.retailCostTxt.Text != "")
                producto.RetailCost = Convert.ToDouble(this.retailCostTxt.Text);
            
            if (this.piecesByCaseTxt.Text != "")
                producto.PiecesPerCase = Convert.ToDouble(this.piecesByCaseTxt.Text);

            if (this.costbyCaseTxt.Text != "")
                producto.CostPerCase = LinkProductCheckBox.Checked || producto.PiecesPerCase == 1 ?
                    producto.RetailCost :
                    Convert.ToDouble(this.costbyCaseTxt.Text);

            if (this.stockTxt.Text != "")
                producto.CurrentStock = Convert.ToDouble(this.stockTxt.Text);
          
            if (this.minimumStockTxt.Text != "")
                producto.minStock = Convert.ToDouble(this.minimumStockTxt.Text);
            
            if (this.PurchaseCostTxt.Text != "")
                producto.PurchaseCost = Convert.ToDouble(this.PurchaseCostTxt.Text);
            producto.mainProductBarcode = this.LinkProductCheckBox.Checked ? this.linkedProductBarcodeTxt.Text : "";

            try
            {
                if (LinkProductCheckBox.Checked)
                    producto.PiecesToMakeOneMainProduct = Convert.ToDouble(bunifuMaterialTextbox1.Text);
                else
                    producto.PiecesToMakeOneMainProduct = 1;
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Se encontró un error en la información introducida.");
                bunifuMaterialTextbox1.ForeColor = Color.Tomato;
                return false;
            }

            producto.isReturnable = this.checkBox1.Checked;
            producto.displayAsKilogram = this.displayAsKilogramCheckBox.Checked;
            producto.HideInTicket = this.hideInTicketCheckBox.Checked;

            if (this.pictureBox1.Image != null)
            {
                try
                {
                    MemoryStream memoryStream = new MemoryStream();
                    this.pictureBox1.Image.Save((Stream)memoryStream, this.pictureBox1.Image.RawFormat);
                    producto.Image = memoryStream.GetBuffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            producto.defaultDepotID = this.depotID[this.comboBox1.SelectedIndex];
            return true;
        }


        private void CodigoBarrasTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;*/
        }

        private void PrecioMinoreoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.retailCostTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void PrecioCajaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.costbyCaseTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void PiezasCajaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.piecesByCaseTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void StockTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.stockTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void MinimimStockTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (this.minimumStockTxt.Text.IndexOf('.') <= -1 || e.KeyChar != '.')
                return;
            e.Handled = true;
        }

        private void PurchaseCostTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (this.PurchaseCostTxt.Text.IndexOf(".") <= -1 || e.KeyChar != '.')
                return;
            e.Handled = true;
        }

        private void SetInfoForEditing(Producto p)
        {
            this.DescriptionTxt.Text = p.Description;
            this.BrandTxt.Text = p.Brand;
            this.barcode = this.barcodeTxt.Text = p.Barcode;
            this.retailCostTxt.Text = p.RetailCost.ToString("n2");
            this.costbyCaseTxt.Text = p.CostPerCase.ToString("n2");
            this.piecesByCaseTxt.Text = p.PiecesPerCase.ToString("n2");
            this.stockTxt.Text = p.CurrentStock.ToString("n3");
            this.minimumStockTxt.Text = p.minStock.ToString("n3");
            this.PurchaseCostTxt.Text = p.PurchaseCost.ToString("n2");
            this.linkedProductBarcodeTxt.Text = p.mainProductBarcode;
            this.LinkProductCheckBox.Checked = !(p.mainProductBarcode == "");
            bunifuMaterialTextbox1.Enabled = !(p.mainProductBarcode == "");
            this.bunifuMaterialTextbox1.Text = p.PiecesToMakeOneMainProduct.ToString("n6");

            this.checkBox1.Checked = p.isReturnable;
            this.displayAsKilogramCheckBox.Checked = p.displayAsKilogram;
            this.hideInTicketCheckBox.Checked = p.HideInTicket;
            for (int index = 0; index < this.depotID.Length; ++index)
            {
                if (this.depotID[index] == p.defaultDepotID)
                {
                    this.comboBox1.SelectedIndex = index;
                    break;
                }
            }
            if (p.Image != null)
            {
                Image image = Image.FromStream((Stream)new MemoryStream(p.Image, 0, p.Image.Length));
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox1.Image = image;
                this.pictureBox1.BorderStyle = BorderStyle.None;
                removeImageBtn.Show();
            }
            else
                removeImageBtn.Hide();
            this.editingMode = true;
        }

        private void DescripcionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode != Keys.Return || !((sender as Control).Name != "barcodeTxt"))
                return;
            this.AddEditProduct();
        }

        private void StockTxt_TextChanged(object sender, EventArgs e)
        {
            this.refreshStockPerCase();
            if (this.stockLbl.Visible || !(this.stockTxt.Text != ""))
                return;
            this.stockLbl.Visible = true;
        }

        private void refreshStockPerCase()
        {
            if (this.stockTxt.Text != "")
            {
                try
                {
                    this.textBox1.Text = (Convert.ToDecimal(this.stockTxt.Text) / Convert.ToDecimal(this.piecesByCaseTxt.Text)).ToString("n2");
                }
                catch (Exception)
                {
                    this.textBox1.Text = "";
                }
            }
            else
            {
                this.stockTxt.Text = "0.00";
                this.stockTxt.Select();
            }
        }

        private void MinimimStockTxt_TextChanged(object sender, EventArgs e)
        {
            this.refreshMinStockPerCase();
            if (this.minimumStockLbl.Visible || !(this.minimumStockTxt.Text != ""))
                return;
            this.minimumStockLbl.Visible = true;
        }

        private void refreshMinStockPerCase()
        {
            if (!(this.minimumStockTxt.Text != ""))
                return;
            try
            {
                this.textBox2.Text = (Convert.ToDecimal(this.minimumStockTxt.Text) / Convert.ToDecimal(this.piecesByCaseTxt.Text)).ToString("n2");
            }
            catch (Exception)
            {
                this.textBox2.Text = "";
            }
        }

        private void DescripcionTxt_Enter(object sender, EventArgs e)
        {
            if (this.DescriptionLbl.Visible)
                return;
            this.DescriptionLbl.Visible = true;
        }

        private void BrandTxt_Enter(object sender, EventArgs e)
        {
            if (this.brandLbl.Visible)
                return;
            this.brandLbl.Visible = true;
        }

        private void barcodeTxt_Enter(object sender, EventArgs e)
        {
            if (this.BarcodeLbl.Visible)
                return;
            this.BarcodeLbl.Visible = true;
        }

        private void retailCostTxt_Enter(object sender, EventArgs e)
        {
            if (this.retailCostLbl.Visible)
                return;
            this.retailCostLbl.Visible = true;
        }

        private void costbyCaseTxt_Enter(object sender, EventArgs e)
        {
            if (this.costbyCaseLbl.Visible)
                return;
            this.costbyCaseLbl.Visible = true;
        }

        private void piecesByCaseTxt_Enter(object sender, EventArgs e)
        {
            if (this.piecesByCaseLbl.Visible)
                return;
            this.piecesByCaseLbl.Visible = true;
        }

        private void PurchaseCostTxt_Enter(object sender, EventArgs e)
        {
            if (this.purchaseCostLbl.Visible)
                return;
            this.purchaseCostLbl.Visible = true;
        }

        private void stockTxt_Enter(object sender, EventArgs e)
        {
            if (this.stockLbl.Visible)
                return;
            this.stockLbl.Visible = true;

            stockTxt.Select();
        }

        private void minimumStockTxt_Enter(object sender, EventArgs e)
        {
            if (this.minimumStockLbl.Visible)
                return;
            this.minimumStockLbl.Visible = true;
        }

        private void DescripcionTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.DescriptionLbl.Visible || !(this.DescriptionTxt.Text != ""))
                return;
            this.DescriptionLbl.Visible = true;
        }

        private void BrandTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.brandLbl.Visible || !(this.BrandTxt.Text != ""))
                return;
            this.brandLbl.Visible = true;
        }

        private void barcodeTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.BarcodeLbl.Visible || !(this.barcodeTxt.Text != ""))
                return;
            this.BarcodeLbl.Visible = true;
        }

        private void retailCostTxt_OnValueChanged(object sender, EventArgs e)
        {
            double ppc = -1;
            double.TryParse(piecesByCaseTxt.Text, out ppc);
            if(LinkProductCheckBox.Checked ||ppc == 1)
            {
                costbyCaseTxt.Text = retailCostTxt.Text;
            }

            if (this.retailCostLbl.Visible || !(this.retailCostTxt.Text != ""))
                return;
            this.retailCostLbl.Visible = true;
        }

        private void costbyCaseTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.costbyCaseLbl.Visible || !(this.costbyCaseTxt.Text != ""))
                return;
            this.costbyCaseLbl.Visible = true;
        }

        private void piecesByCaseTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var product = new Producto(linkedProductBarcodeTxt.Text);
                if (product.Barcode != "")
                {
                    try
                    {
                        var pieces = Convert.ToDouble(piecesByCaseTxt.Text);
                        var value = product.PurchaseCost / product.PiecesPerCase * pieces / Convert.ToDouble(bunifuMaterialTextbox1.Text);
                        PurchaseCostTxt.Text = (value).ToString("n2");
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            if (this.piecesByCaseLbl.Visible || !(this.piecesByCaseTxt.Text != ""))
                return;
            this.piecesByCaseLbl.Visible = true;
        }

        private void PurchaseCostTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.purchaseCostLbl.Visible || !(this.PurchaseCostTxt.Text != ""))
                return;
            this.purchaseCostLbl.Visible = true;
        }

        private void DescripcionTxt_Leave(object sender, EventArgs e)
        {
            this.DescriptionLbl.Visible = this.DescriptionTxt.Text != "";
        }

        private void BrandTxt_Leave(object sender, EventArgs e)
        {
            this.brandLbl.Visible = this.BrandTxt.Text != "";
        }

        private void barcodeTxt_Leave(object sender, EventArgs e)
        {
            this.BarcodeLbl.Visible = this.barcodeTxt.Text != "";
        }

        private void retailCostTxt_Leave(object sender, EventArgs e)
        {
            this.retailCostLbl.Visible = this.retailCostTxt.Text != "";
        }

        private void costbyCaseTxt_Leave(object sender, EventArgs e)
        {
            this.costbyCaseLbl.Visible = this.costbyCaseTxt.Text != "";
        }

        private void piecesByCaseTxt_Leave(object sender, EventArgs e)
        {
            this.piecesByCaseLbl.Visible = this.piecesByCaseTxt.Text != "";

            if (piecesByCaseTxt.Text.Trim() == "")
                piecesByCaseTxt.Text = "1.00";

            if (Convert.ToDouble(this.piecesByCaseTxt.Text) == 0.0)
                this.piecesByCaseTxt.Text = "1.00";

            /*if (LinkProductCheckBox.Checked)
            {
                Producto p = new Producto(linkedProductBarcodeTxt.Text);
                if (p.Barcode != "")
                {
                    PurchaseCostTxt.Text = (p.PurchaseCost / p.PiecesPerCase).ToString("n2");
                }
            }*/

            this.refreshStockPerCase();
            this.refreshMinStockPerCase();
        }

        private void PurchaseCostTxt_Leave(object sender, EventArgs e)
        {
            this.purchaseCostLbl.Visible = this.PurchaseCostTxt.Text != "";
        }

        private void stockTxt_Leave(object sender, EventArgs e)
        {
            this.stockLbl.Visible = this.stockTxt.Text != "";
        }

        private void minimumStockTxt_Leave(object sender, EventArgs e)
        {
            this.minimumStockLbl.Visible = this.minimumStockTxt.Text != "";
        }

        private void LinkProductCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.LinkProductCheckBox.Checked)
            {
                if(linkedProductBarcodeTxt.Text!= "" && (Producto.SearchProduct(linkedProductBarcodeTxt.Text) && bunifuMaterialTextbox1.Text!=""))
                {
                    try
                    {
                        var product = new Producto(linkedProductBarcodeTxt.Text);
                        var pieces = Convert.ToDouble(piecesByCaseTxt.Text);
                        var value = product.PurchaseCost / product.PiecesPerCase / Convert.ToDouble(bunifuMaterialTextbox1.Text) * pieces;
                        PurchaseCostTxt.Text = (value).ToString("n2");
                        bunifuMaterialTextbox1.LineIdleColor = Color.Gray;
                    }
                    catch (FormatException) { }
                }


                this.linkedProductBarcodeTxt.Enabled = true;
                this.LinkedProductBarcodeLbl.Enabled = true;
                this.PurchaseCostTxt.Enabled = false;
                //this.costbyCaseTxt.Enabled = false;
                this.minimumStockTxt.Enabled = false;
                bunifuMaterialTextbox1.Enabled = false;
                this.stockTxt.Enabled = false;
                stockTxt.Text = "0.00";
                piecesByCaseTxt.Enabled = false;
                piecesByCaseTxt.Text = "1.00";
                costbyCaseTxt.Enabled = false;
                costbyCaseTxt.Text = retailCostTxt.Text;
            }
            else
            {
                this.linkedProductBarcodeTxt.Enabled = false;
                this.LinkedProductBarcodeLbl.Enabled = false;
                this.PurchaseCostTxt.Enabled = true;
               // this.costbyCaseTxt.Enabled = true;
                this.minimumStockTxt.Enabled = true; 
                this.stockTxt.Enabled = false;
                bunifuMaterialTextbox1.Enabled = false;

                var product = new Producto(barcodeTxt.Text);

                piecesByCaseTxt.Enabled = true;
                piecesByCaseTxt.Text = editingMode ?product.PiecesPerCase.ToString("n2") : "1.00";

                costbyCaseTxt.Enabled = true;
                costbyCaseTxt.Text = editingMode ? product.CostPerCase.ToString("n2") : ((Convert.ToDouble(piecesByCaseTxt.Text)
                    * Convert.ToDouble(retailCostTxt.Text))).ToString("n2"); 
            }
        }

        private void linkedProductBarcodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;*/
        }

        private void displayAsKilogramCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.displayAsKilogramCheckBox.Checked)
            {
                this.piecesByCaseLbl.Text = "Kilos por Caja";
                this.label9.Text = "Kg.";
                this.label11.Text = "Kg.";
            }
            else
            {
                this.piecesByCaseLbl.Text = "Piezas por Caja";
                this.label9.Text = "pzas";
                this.label11.Text = "pzas";
            }
        }

        private void Form_Agregar_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            pictureBox1.Dispose();
            DialogResult = DialogResult.Cancel;
        }

        private void linkedProductBarcodeTxt_Leave(object sender, EventArgs e)
        {
            checkForMainProduct();
        }

        private void checkForMainProduct()
        {
            if (linkedProductBarcodeTxt.Text.Trim() != "")
            {
                Producto p = getmainproduct(linkedProductBarcodeTxt.Text.Trim());
                if(p!= null && p.Barcode == barcodeTxt.Text)
                {
                    new Toast_Message("El producto principal y el producto actual no deben tener el mismo código de barras").Show();
                    linkedProductBarcodeTxt.ForeColor = Color.Tomato;
                    return;
                }
                else if (p != null)
                {
                    linkedProductBarcodeTxt.Text = p.Barcode;
                   // costbyCaseTxt.Text = p.RetailCost.ToString("n2");
                    linkedProductBarcodeTxt.ForeColor = Color.LimeGreen;
                    //PurchaseCostTxt.Text = (p.PurchaseCost / p.PiecesPerCase).ToString("n2");
                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox1.Select();
                    bunifuMaterialTextbox1.Focus();
                }
                else
                {
                    costbyCaseTxt.Text = "0.00";
                    PurchaseCostTxt.Text = "0.00";
                    linkedProductBarcodeTxt.ForeColor = Color.Tomato;
                }
            }
            else
                LinkProductCheckBox.Checked = false;
        }

        private Producto getmainproduct(string barcode)
        {
            if (!Producto.SearchProduct(barcode))
                return null;
            else
            {
                var p = new Producto(barcode);
                while (p.mainProductBarcode != "")
                {
                    p = new Producto(p.mainProductBarcode);
                }

                if (p.Barcode != barcode)
                    new Toast_Message("Se reedirigió al producto principal").Show();
                
                return p;
            }
        }

        private void Form_Agregar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, e.ClipRectangle);
        }

        private void wholesaleCostsBtn_Click(object sender, EventArgs e)
        {
            form_ProductWholeSaleCosts wholeSaleCosts = new form_ProductWholeSaleCosts(barcode);
            wholeSaleCosts.ShowDialog();
            this.Show();

            
        }

        private void Form_Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.Dispose();
            timer1.Stop();
            timer1.Dispose();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            removeImageBtn.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            var pictureLocation = this.PointToScreen(pictureBox1.Location);
            var pictureSize = this.PointToScreen(new Point(pictureBox1.Width, pictureBox1.Height));
            var mouselocation = Cursor.Position;

            //if (pictureLocation.X < mouselocation.X && pictureLocation.X + pictureSize.X < mouselocation.X && pictureLocation.Y < mouselocation.Y && pictureLocation.Y + pictureSize.Y < mouselocation.Y)

            if (mouselocation.X > pictureLocation.X && mouselocation.X < pictureLocation.X + pictureBox1.Width && mouselocation.Y > pictureLocation.Y && mouselocation.Y < pictureLocation.Y + pictureBox1.Height)
                return;
            else
                bunifuFlatButton1.Visible = false;
        }

        private void bunifuFlatButton1_MouseHover(object sender, EventArgs e)
        {
            bunifuFlatButton1.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (editingMode && pictureBox1.Image != null)
            {
                bunifuFlatButton1.Visible = true;
            }
            else
            {
                bunifuFlatButton1.Visible = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var explorer = new SaveFileDialog();

            if(explorer.ShowDialog()== DialogResult.OK)
            {

                pictureBox1.Image.Save(explorer.FileName+".png");
            }
        }

        private void Form_Agregar_Deactivate(object sender, EventArgs e)
        {
            bunifuFlatButton1.Visible = false;
        }

        private void alterProductsList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_productos_AlternProductsList form = new panel_productos_AlternProductsList(new Producto(barcodeTxt.Text));
            form.Show();
        }

        private void linkedProductBarcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
                checkForMainProduct();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            try {
                if (LinkProductCheckBox.Checked)
                {
                    var product = new Producto(linkedProductBarcodeTxt.Text);
                    var pieces = Convert.ToDouble(piecesByCaseTxt.Text);
                    var value = product.PurchaseCost / product.PiecesPerCase / Convert.ToDouble(bunifuMaterialTextbox1.Text)*pieces;
                    PurchaseCostTxt.Text = (value).ToString("n2");
                    bunifuMaterialTextbox1.LineIdleColor = Color.Gray;

                    timer1.Stop();
                    timer1.Start();
                }
            }
            catch (Exception) {
                bunifuMaterialTextbox1.LineIdleColor = Color.Tomato;
                bunifuMaterialTextbox1.LineFocusedColor = Color.Tomato;
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.bunifuMaterialTextbox1.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            helpPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double subproduct = 1;
            double mainproduct = 1;
            double pieces = 1;

            double.TryParse(subProductTxt.Text, out subproduct);
            double.TryParse(mainProductTxt.Text, out mainproduct);
            double.TryParse(piecesByCaseTxt.Text, out pieces);

            bunifuMaterialTextbox1.Text = (subproduct / mainproduct*pieces).ToString("n6");
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            setHelpingValues();
            helpPanel.Show();
        }

        private async void setHelpingValues()
        {
            double x;
            double.TryParse(bunifuMaterialTextbox1.Text, out x);
            double xCopy;

            x /= Convert.ToDouble(piecesByCaseTxt.Text);

            xCopy = x;

            x = 10000 * x - x;

            x = 1 - (x - Math.Truncate(x)) < 0.0009 ? Math.Ceiling(x) : x;

/*            if (cancellationTokenSource != null)
                cancellationTokenSource.Cancel();

            cancellationTokenSource = new CancellationTokenSource();
            var cancel = cancellationTokenSource.Token;
*/

            if (x - Math.Truncate(x) > 0)
            {
                var num = xCopy;
                var div = 1.0;

                while (num - Math.Truncate(num) != 0)
                {
                    num *= 10;
                    div *= 10;
                }
               /* try
                {*/
                    var minDiv = await Task.Run(() => getMinCommonDivisor(Convert.ToUInt64(num), Convert.ToUInt64(div)/*, cancel*/));
                    subProductTxt.Text = (num / minDiv).ToString("n2");
                    mainProductTxt.Text = (div / minDiv).ToString("n2");
                /*}
                catch (OperationCanceledException) { }
                finally { cancellationTokenSource = null; }
                */
            }
            else
            {
               /* try
                {*/
                    var mindiv = await Task.Run(() => getMinCommonDivisor((ulong)x, 9999/*, cancel*/));
                    subProductTxt.Text = (x / mindiv).ToString("n2");
                    mainProductTxt.Text = (9999 / mindiv).ToString("n2");
                /*}
                catch (OperationCanceledException) { }
                finally { cancellationTokenSource = null; }*/
            }
        }

        private ulong getMinCommonDivisor(ulong num, ulong div/*, CancellationToken token*/)
        {
            ulong top = num > div ? num : div;

            while (top>=1)
            {
                /*if (token.IsCancellationRequested)
                    throw new OperationCanceledException();
                */
                if (num % top == 0 && div % top == 0)
                    return top;
                else
                    top--;
            }

            return 1;
        }

        private void subProductTxt_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || (sender as TextBox).Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (ActiveControl != null && (ActiveControl != helpPanel && ActiveControl.Parent!= helpPanel) )
                helpPanel.Hide();
        }

        private void helpPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (helpPanel.Visible)
            {
                var x = groupBox1.Location.X + label2.Location.X + label2.Width - helpPanel.Width;
                var y = groupBox1.Location.Y + label2.Location.Y - helpPanel.Height;
                helpPanel.Location = new Point(x, y);
            }
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && bunifuMaterialTextbox1.Enabled)
                helpPanel.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setHelpingValues();
            timer1.Stop();
        }

        private void Form_Agregar_Resize(object sender, EventArgs e)
        {
            if(Screen.PrimaryScreen.Bounds== new Rectangle(0,0,1366,768))
            {
                this.Height = 700;
            }
        }

        private void removeImageBtn_MouseEnter(object sender, EventArgs e)
        {
            removeImageBtn.BackColor = Color.FromArgb(245, 245, 245);
            pictureBox1.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void removeImageBtn_MouseLeave(object sender, EventArgs e)
        {
            removeImageBtn.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }

        private void Form_Agregar_Shown(object sender, EventArgs e)
        {
            if(this.Height>Screen.PrimaryScreen.Bounds.Height)
            {
                this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * .9);
                this.Width = this.MaximumSize.Width;
                this.CenterToScreen();
            }
            else{

                this.Height = this.MaximumSize.Height;
                this.CenterToScreen();
            }
        }
    }
}
