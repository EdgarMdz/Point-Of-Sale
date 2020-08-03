using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;
using Microsoft.PointOfService;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace POS
{
    public partial class Panel_Ventas : Form
    {
        private Size customerGroupBoxMaxSize = new Size(384, 280);
        private Size customerGroupBoxMinSize = new Size(384, 134);
        private Size pictureBoxMinSize = new Size(242, 213);
        private Size pictureBoxMaxSize = new Size(388, 359);
        private const int maximumDaysForRefound = 2;
        private const int maximumDaysForRetourningPackages = 7;
        private bool isNewSale;
        private int EmployeeID;
        private string defaultTxt;
        private Cliente customer;
        private Venta sale;
        private PrinterTicket ticket;
        private double generalDiscount;
        private bool isDiscountbyPercentage;
        private bool editingRow;
        private static int count = 0;
        CashDrawer cashDrawer = null;
        PosPrinter printer = null;


        public bool canClose
        {
            get
            {
                if (dataGridView2 != null && dataGridView2.RowCount == 0)
                    return true;
                else
                    return false;
            }
        }

        private void addOneMoreProduct()
        {
            if (this.dataGridView2.CurrentRow == null)
                return;

            int index = dataGridView2.CurrentRow.Index;
            var barcode = dataGridView2.SelectedRows[0].Cells["barcode"].Value.ToString();

            if (barcode != null && barcode.IndexOf("promo(") == -1 && barcode != "")
                addProductToDataGrid(new Producto(dataGridView2.SelectedRows[0].Cells["barcode"].Value.ToString()), 1.0, Convert.ToInt32(dataGridView2.Rows[index].Cells["depot"].Value));
            else
            {
                selectPromo(index);

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (index > row.Index)
                        index = row.Index;
                }

                addPromoToGridView(getPromoIDFromRow(dataGridView2.Rows[index].Index), 1);
            }
            dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells["description"];
        }

        private void addProductToDataGrid(Producto p, double quantity, int depotIndex = 1, int rowIndex = -1)
        {
            //lookin for an item in the datagridview to add the given product to it
            if (autoGrouping.Checked || quantity < 0 && rowIndex < 0)
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    string barcode = row.Cells["barcode"].Value.ToString();


                    if (barcode.IndexOf("promo(") == -1 && p.Barcode == barcode && Convert.ToInt32(row.Cells["depot"].Value) == depotIndex)
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

            //if there is not a product like the given one in the table then add a new row
            if (rowIndex == -1)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                int index = dataGridView2.Rows.Add();

                

                dataGridView2.Rows[index].Cells["barcode"].Value = p.Barcode;
                dataGridView2.Rows[index].Cells["description"].Value = p.Description;
                dataGridView2.Rows[index].Cells["brand"].Value = p.Brand;
                dataGridView2.Rows[index].Cells["amount"].Value = amountFormat(p, quantity);
                dataGridView2.Rows[index].Cells["UnitCost"].Value = p.RetailCost.ToString("n2");
                dataGridView2.Rows[index].Cells["Total"].Value = getCost(p, index);
                dataGridView2.Rows[index].Cells["Depot"].ReadOnly = false;
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells["description"];
            }
            else //integrates the given product to an existing row
            {
                string cellValue = dataGridView2.Rows[rowIndex].Cells["amount"].Value.ToString();
                double totalAmountOfPieces;
                if (cellValue.IndexOf(",") > -1)// if cellvalue has the format "X cases, N pieces" then...
                {
                    double cases = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf("c")));
                    cellValue = cellValue.Substring(cellValue.IndexOf(",") + 1);
                    double singlePieces = Convert.ToDouble(cellValue.Substring(0, !p.displayAsKilogram ? cellValue.IndexOf(nameof(p)) : cellValue.ToLower().IndexOf("kg")));
                    totalAmountOfPieces = cases * p.PiecesPerCase + singlePieces;
                }
                else// cell value has the format "N pieces"
                    totalAmountOfPieces = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf(".") + 3));

                dataGridView2.Rows[rowIndex].Cells["amount"].Value = amountFormat(p, totalAmountOfPieces + quantity);
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = getCost(p, rowIndex);
                dataGridView2.CurrentCell = dataGridView2.Rows[rowIndex].Cells["description"];
            }
            totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
            pictureBox1.Image = p.image;
            countProducts();

        }

        private async void countProducts()
        {
            int products = await Task.Run(() => getnumber(dataGridView2));
            AmountProdctsLbl.Text = "Productos: " + products.ToString();
            AmountProdctsLbl.Visible = products > 0;
        }

        private int getnumber(DataGridView dataGridView)
        {
            int x = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var barcode = row.Cells["barcode"].Value.ToString();
                if (barcode.IndexOf("promo(") > -1)
                    continue;
                else
                {
                    Producto p = new Producto(barcode);
                    if (p.displayAsKilogram)
                        x++;
                    else
                    {
                        x += dataGridView2.RowCount > 0 ? (int)getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), p) :
                        0;
                    }
                }
            }
            return x;
        }

        private void addPromoToGridView(int id, double quantity, int rowIndex = -1)
        {
            //lookin for an item in the datagridview to add the given product to it

            if (autoGrouping.Checked)
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    string barcode = row.Cells["barcode"].Value.ToString();

                    if (barcode.IndexOf("promo(") > -1 && getPromoIDFromRow(row.Index) == id)
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

            //if there is not a product like the given one in the table then add a new row
            if (rowIndex == -1)
            {
                DataSet promoDetails = Producto.getPromo(id);

                int index = dataGridView2.Rows.Add();
                double unitCost = Convert.ToDouble(promoDetails.Tables[0].Rows[0]["cost"]);
                double discount = Convert.ToDouble(promoDetails.Tables[0].Rows[0]["discount"]);

                dataGridView2.Rows[index].Cells["barcode"].Value = string.Format("promo({0})", id);
                dataGridView2.Rows[index].Cells["description"].Value = "Promoción";
                dataGridView2.Rows[index].Cells["brand"].Value = "";
                dataGridView2.Rows[index].Cells["amount"].Value = quantity.ToString("n2");
                dataGridView2.Rows[index].Cells["UnitCost"].Value = (unitCost + discount).ToString("n2");
                dataGridView2.Rows[index].Cells["Total"].Value = string.Format("{0}\r\n-{1}",
                    ((unitCost + discount) * quantity).ToString("n2"), (discount * quantity).ToString("n2"));
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells["description"];
                dataGridView2.Rows[index].Cells["Depot"] = new DataGridViewTextBoxCell();

                addPromoChildsToGridView(promoDetails.Tables[1]);
            }
            else
            {
                DataSet promoDetails = Producto.getPromo(id);

                double unitCost = Convert.ToDouble(promoDetails.Tables[0].Rows[0]["cost"]);
                double discount = Convert.ToDouble(promoDetails.Tables[0].Rows[0]["discount"]);

                double amount = Convert.ToDouble(dataGridView2.Rows[rowIndex].Cells["amount"].Value);

                dataGridView2.Rows[rowIndex].Cells["amount"].Value = (amount + quantity).ToString("n2");


                double total = (unitCost + discount) * (quantity + amount);
                discount = discount * (quantity + amount);//promo discount
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = string.Format("{0}\r\n-{1}",
                    (total).ToString("n2"), (discount).ToString("n2"));
            }

            ProductTxt.Text = "";
            totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
            countProducts();
        }

        private void addPromoChildsToGridView(DataTable PromoChilds)
        {
            foreach (DataRow row in PromoChilds.Rows)
            {
                int childIndex = dataGridView2.Rows.Add();
                Producto p = new Producto(row["id_producto"].ToString());
                double childAmount = Convert.ToDouble(row["amount"]);

                dataGridView2.Rows[childIndex].Cells["barcode"].Value = "";
                dataGridView2.Rows[childIndex].Cells["description"].Value = "\t" + p.Description;
                dataGridView2.Rows[childIndex].Cells["brand"].Value = p.Brand;
                dataGridView2.Rows[childIndex].Cells["amount"].Value = childAmount == 1 ? "1.00 piezas" :
                    childAmount.ToString("n2") + " piezas";
                dataGridView2.Rows[childIndex].Cells["UnitCost"].Value = p.RetailCost.ToString("n2");
                dataGridView2.Rows[childIndex].Cells["Total"].Value = (p.RetailCost * childAmount).ToString("n2");
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells["description"];

                dataGridView2.Rows[childIndex].DefaultCellStyle.Font = new Font("century gothic", 15);
                dataGridView2.Rows[childIndex].DefaultCellStyle.ForeColor = Color.Black;
                dataGridView2.Rows[childIndex].Cells["Depot"].Value = 1;
                dataGridView2.Rows[childIndex].Cells["Depot"].ReadOnly = false;
            }
        }

        private int getPromoIDFromRow(int rowindex)
        {
            string str = dataGridView2.Rows[rowindex].Cells["barcode"].Value.ToString().Trim().ToLower();

            if (str.IndexOf("promo(") > -1)
            {
                int beginIndex = str.IndexOf("promo(") + 6;
                int strLength = str.IndexOf(")") - beginIndex;

                return Convert.ToInt32(str.Substring(beginIndex, strLength));
            }

            return -1;
        }


        private void addDiscountToRow(int rowIndex, double discount)
        {
            Producto p = new Producto(dataGridView2.Rows[rowIndex].Cells["barcode"].Value.ToString());
            double amount = getAmountOfSinglePieces(dataGridView2.Rows[rowIndex].Cells["amount"].Value.ToString(), p);



            Tuple<int, double> tuple = getCasesAndSingleProducts(p, amount);

            int cases = tuple.Item1;
            double singlePieces = tuple.Item2;

            double cost = p.CostPerCase * cases + p.RetailCost * singlePieces;

            //getting general discount
            double genDiscount;

            double customerCost = customer.getCost(p.Barcode, amount);

            genDiscount = (cost) / 100 * generalDiscount;

            //getting discount for customer
            double customerDiscount = (p.RetailCost - customerCost) * amount;
            if (customerDiscount < 0)
                customerDiscount = 0;

            //getting discount for cases
            double caseDiscount = 0;
            if (cases > 0)
            {
                caseDiscount = p.RetailCost * p.PiecesPerCase * cases - p.CostPerCase * cases;

                caseDiscount = caseDiscount < 0 ? 0 : caseDiscount;
            }

            double totalDiscount = customerDiscount > caseDiscount ? customerDiscount : caseDiscount;

            totalDiscount = totalDiscount > genDiscount ? totalDiscount : generalDiscount;


            if (caseDiscount > 0)
                totalDiscount = caseDiscount;
            else
            {
                if (customerDiscount > generalDiscount)
                    totalDiscount = customerDiscount;
                else
                    totalDiscount = generalDiscount;
            }


            double newDisc = validateDiscount(discount + totalDiscount, p, amount);
            ///if there still a discount then show it in the table as the format -> "$100.00 \n -$15.00"
            ///otherwise show just the total
            if (newDisc > 0.0)
            {
                string newLine = Environment.NewLine;
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = string.Format("{0}{1}-{2}", (p.RetailCost * amount).ToString("n2"), newLine, newDisc.ToString("n2"));
            }
            else
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = (p.RetailCost * amount).ToString("n2");
        }

        private string getCost(Producto product, int rowIndex)
        {

            string result = "";

            double amount = getAmountOfSinglePieces(dataGridView2.Rows[rowIndex].Cells["amount"].Value.ToString(), product);
            Tuple<int, double> tuple = getCasesAndSingleProducts(product, amount);

            int cases = tuple.Item1;
            double singlePieces = tuple.Item2;

            double cost = product.CostPerCase * cases + product.RetailCost * singlePieces;

            //getting general discount
            double genDiscount;

            double customerCost = customer.getCost(product.Barcode, amount);

            genDiscount = (cost) / 100 * generalDiscount;

            //getting discount for customer
            double customerDiscount = (product.RetailCost - customerCost) * amount;
            if (customerDiscount < 0)
                customerDiscount = 0;

            //getting discount for cases
            double caseDiscount = 0;
            if (cases > 0)
            {
                caseDiscount = product.RetailCost * product.PiecesPerCase * cases - product.CostPerCase * cases;

                caseDiscount = caseDiscount < 0 ? 0 : caseDiscount;
            }

            //Wholesale Discount
            double wholesaleDiscount = product.GetWholesaleDiscount(amount);


            //getting discount for mixed case
            double mixedCaseDiscount = 0;

            if (product.mixedCaseGroup > 0)
            {
                mixedCaseDiscount = getDiscountForMixedCase(rowIndex, product);
            }

            double totalDiscount;// = customerDiscount + caseDiscount + mixedCaseDiscount + genDiscount;

            if(wholesaleDiscount>0)
            {
                totalDiscount = mixedCaseDiscount > 0 ? mixedCaseDiscount : wholesaleDiscount;
                (dataGridView2.Rows[rowIndex].Cells["WholesaleDiscountApplied"] as DataGridViewCheckBoxCell).Value = true;
            }
            else
            {
                if (caseDiscount > 0)
                    totalDiscount = caseDiscount;

                else
                {
                    if (customerDiscount > 0)
                        totalDiscount = customerDiscount;
                    else
                        totalDiscount = genDiscount;
                }

                totalDiscount += mixedCaseDiscount;
                (dataGridView2.Rows[rowIndex].Cells["WholesaleDiscountApplied"] as DataGridViewCheckBoxCell).Value = false;
            }


            totalDiscount = validateDiscount(totalDiscount, product, amount);

            ///if there still a discount then show it in the table as the format -> "$100.00 \n -$15.00"
            ///otherwise show just the total
            if (totalDiscount > 0.0)
            {
                string newLine = Environment.NewLine;
                result = string.Format("{0}{1}-{2}", (product.RetailCost * amount).ToString("n2"), newLine, totalDiscount.ToString("n2"));
            }
            else
                result = (product.RetailCost * amount).ToString("n2");

            return result;
        }


        private double validateDiscount(double discount, Producto product, double amount)
        {
            //check if the discount is greater than the purchase cost, if so then the discount equals to the purchase cost.
            if (product.RetailCost * amount - discount < product.PurchaseCost / product.PiecesPerCase * amount)
                discount = product.RetailCost * amount - product.PurchaseCost / product.PiecesPerCase * amount;

            return discount;
        }

        double getDiscountForMixedCase(int rowIndex, Producto product)
        {
            //list to store values
            //Dictionary<barcode,tuple<rowindex,amount,accumulated amount>
            Dictionary<string, Tuple<int, double, double>> values = new Dictionary<string, Tuple<int, double, double>>();

            double discount = 0;
            double countOfPieces = 0;
            double countOfTotalPices = 0;

            //sweep the listed products to find mixed cases coincidences
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                var row = /*i != rowIndex ? */dataGridView2.Rows[i]/* : dataGridView2.Rows[rowIndex]*/;
                Producto p = i != rowIndex ? new Producto(row.Cells["barcode"].Value.ToString()) :
                     product;

                //if the current product has the same mixed case groud id then add it to the dictionary
                if (product.mixedCaseGroup == p.mixedCaseGroup)
                {
                    countOfTotalPices += getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), p);
                    double singlePieces = getCasesAndSingleProducts(p,
                      countOfTotalPices).Item2;//amount of single pieces

                    countOfPieces += singlePieces;
                    values.Add(p.Barcode, new Tuple<int, double, double>(i, singlePieces, countOfPieces));

                }
            }
            var wholedisc = product.GetWholesaleDiscount(countOfTotalPices) / countOfTotalPices;
            
            //When there is an applicable wholesale discount
            if (wholedisc > 0)
            {
                discount = wholedisc *
                    getAmountOfSinglePieces(dataGridView2.Rows[values[product.Barcode].Item1].Cells["amount"].Value.ToString(), product);

                values.Remove(product.Barcode);

                foreach (KeyValuePair<string, Tuple<int, double, double>> item in values)
                {
                    var p = new Producto(item.Key);
                    addDiscountToRow(item.Value.Item1, wholedisc * 
                        getAmountOfSinglePieces(dataGridView2.Rows[values[p.Barcode].Item1].Cells["amount"].Value.ToString(), p));
                    (dataGridView2.Rows[item.Value.Item1].Cells["WholesaleDiscountApplied"] as DataGridViewCheckBoxCell).Value = true;
                }
            }


            //Enters in this seccion when there are products that, when groupped altogether, conform at least one case
            else if (countOfPieces / product.PiecesPerCase >= 1 && !Convert.ToBoolean(dataGridView2.Rows[rowIndex].Cells["WholesaleDiscountApplied"].Value))
            {
                int cases = getCasesAndSingleProducts(product, countOfPieces).Item1;


                double piecesWithDiscount = Math.Truncate(values[product.Barcode].Item3 / product.PiecesPerCase) < cases ?
                    values[product.Barcode].Item2 :
                    values[product.Barcode].Item2 - values[product.Barcode].Item3 % product.PiecesPerCase;

                discount = product.RetailCost * piecesWithDiscount -
                    piecesWithDiscount * product.CostPerCase / product.PiecesPerCase;

                discount = discount < 0 ? 0 : discount;

                values.Remove(product.Barcode);


                foreach (KeyValuePair<string, Tuple<int, double, double>> item in values)
                {
                    Producto p = new Producto(item.Key);

                    piecesWithDiscount = Math.Truncate(item.Value.Item3 / product.PiecesPerCase) < cases ?
                    item.Value.Item2 :
                    item.Value.Item2 - item.Value.Item3 % product.PiecesPerCase;

                    double disc = p.RetailCost * piecesWithDiscount -
                     piecesWithDiscount * p.CostPerCase / p.PiecesPerCase;

                    addDiscountToRow(item.Value.Item1, disc);
                }
            }
            else
            {
                values.Remove(product.Barcode);

                foreach (KeyValuePair<string, Tuple<int, double, double>> item in values)
                {
                    Producto p = new Producto(item.Key);
                    addDiscountToRow(item.Value.Item1, 0);
                }
            }
            return discount;
        }

        private Tuple<int, double> getCasesAndSingleProducts(Producto producto, double amount)
        {
            int cases = producto.PiecesPerCase > 1.0 ? (int)Math.Truncate(amount / producto.PiecesPerCase) : 0;
            double singlePieces = producto.PiecesPerCase > 1.0 ? amount % producto.PiecesPerCase : amount;

            return new Tuple<int, double>(cases, singlePieces);
        }

        private string amountFormat(Producto producto, double amount)
        {
            Tuple<int, double> tuple = getCasesAndSingleProducts(producto, amount);
            int cases = tuple.Item1;
            double singlePieces = tuple.Item2;

            string units = producto.displayAsKilogram ? "Kg" : "piezas";
            string unit = producto.displayAsKilogram ? "Kg" : "pieza";

            string result = "";

            if (cases > 0 && producto.PiecesPerCase > 1.0)
            {
                if (cases != 1)
                    result = singlePieces == 1.0 ?
                        string.Format("{0} cajas,\n {1} {2}", cases, singlePieces, unit) :
                        string.Format("{0} cajas,\n {1} {2}", cases, singlePieces, units);

                else if (cases == 1)
                    result = singlePieces == 1.0 ?
                        string.Format("{0} caja,\n {1} {2}", cases, singlePieces, unit) :
                        string.Format("{0} caja,\n {1} {2}", cases, singlePieces, units);
            }

            else
                result = singlePieces == 1.0 ?
                    string.Format("{0} {1}", amount, unit) :
                    string.Format("{0} {1}", amount, units);


            return result;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.Rows.Count <= 0 && this.sale == null)
                return;
            if (this.sale == null)
            {
                if (MessageBox.Show("¿Desea Cancelar la Venta?.\r\nSe perderá la información.", "Cancelar Venta", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.ClearSale();
            }
            else
                this.ClearSale();
        }

        private void CancelSaleBtn_Click(object sender, EventArgs e)
        {
            if (this.sale != null && this.sale.Date > DateTime.Now.AddDays(-2.0))
            {
                DialogResult userSelection = new DialogResult();
                bool cancelWholeSale = false;
               
                if (checkForRefoundProducts())
                    userSelection = MessageBox.Show("¿Desea realizar la devolución de los productos seleccionados?", 
                        "Devolver Productos Seleccionados", MessageBoxButtons.YesNo);


                if (userSelection != DialogResult.Yes)
                {

                    if (MessageBox.Show("¿Desea cancelar la venta?\n\nEn caso de haber adeudo en envases, " +
                       "una vez cancelada no se podrán retornar más envases.", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

                    else
                        cancelWholeSale = true;
                }
                openCashDrawer();

                double MoneyToBeRefounded = 0;

                if (cancelWholeSale)
                {
                    sale.Cancel(EmployeeID);      
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        var refound = row.Cells["refound"];
                        if (!refound.ReadOnly)
                            MoneyToBeRefounded += getTotalFromRow(row.Index);
                    }
                }

                else
                {
                    DataTable barcodesToBeRefounded = getRefoundedProduct();
                    sale.RefoundProductsToCustomer(barcodesToBeRefounded);


                    int totalOfRefoundedProducts = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        var refound = row.Cells["refound"];
                        if (!refound.ReadOnly && Convert.ToBoolean(refound.Value))
                            MoneyToBeRefounded += getTotalFromRow(row.Index);


                        if (Convert.ToBoolean(refound.Value))
                            totalOfRefoundedProducts++;
                    }

                    if (totalOfRefoundedProducts == sale.getSoldProducts.Rows.Count)
                        sale.Cancel(EmployeeID);

                }

                setSale(sale.ID);
                FormCambio formCambio = new FormCambio(/*(double)(sale.Payment - num1)*/MoneyToBeRefounded);
                DarkForm darkForm = new DarkForm();
                darkForm.Show();
                formCambio.ShowDialog();
                darkForm.Close();
               /* this.CanceledLbl.Show();
                this.CancelSaleBtn.Enabled = false;
                this.CanceledLbl.Show();*/
            }
            else
            {
                MessageBox.Show(string.Format("La compra excede el lapso permitido de {0} días para realizar la devolución.\n\nFecha de la venta: {1} de {2} del {3}", (object)2, (object)this.sale.Date.Day, (object)new CultureInfo("es-MX").DateTimeFormat.GetMonthName(this.sale.Date.Month), (object)this.sale.Date.Year), "No se puede cancelar");
            }
        }

        private DataTable getRefoundedProduct()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("barcode");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                var refound = row.Cells["refound"];
                DataRow dataRow = dt.NewRow();

                if (!refound.ReadOnly && Convert.ToBoolean(refound.Value))
                {
                    dataRow["barcode"] = row.Cells["barcode"].Value.ToString();
                    dt.Rows.Add(dataRow);
                    dt.AcceptChanges();
                }

            }

            return dt;
        }

        private bool checkForRefoundProducts()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.Cells["refound"].ReadOnly && Convert.ToBoolean(row.Cells["refound"].Value))
                    return true;
            }

            return false;
        }

        private void centerCustomerDebtLabels()
        {
            this.debtLbl.AutoSize = true;
            int width = (int)this.debtLbl.CreateGraphics().MeasureString(this.debtLbl.Text, this.debtLbl.Font).Width;
            if (this.label1.Width + width + 6 < this.groupBox1.Width)
            {
                int x = (this.groupBox1.Width - this.label1.Width - width - 6) / 2;
                this.label1.Location = new Point(x, this.label1.Location.Y);
                this.debtLbl.Location = new Point(x + this.label1.Width + 6, this.debtLbl.Location.Y);
            }
            else
            {
                this.debtLbl.AutoSize = false;
                this.label1.Location = new Point(0, this.label1.Location.Y);
                this.debtLbl.Location = new Point(this.label1.Width + 6, this.debtLbl.Location.Y);
                this.debtLbl.Width = this.groupBox1.Width - this.debtLbl.Location.X;
            }
        }

        private void centerToParent(Control control)
        {
            int width = control.Parent.Width;
            control.Location = new Point((width - control.Width) / 2, control.Location.Y);
        }

        private void ClearCustomer()
        {
            this.customer = new Cliente(0);
            this.groupBox1.Size = this.customerGroupBoxMinSize;
            this.reassignCosts();
            this.CustomerBtn.ButtonText = this.customer.Name;
            this.ClearCustomerBtn.Hide();
        }

        private void ClearCustomerBtn_Click(object sender, EventArgs e)
        {
            this.ClearCustomer();
        }

        private void ClearCustomerBtn_MouseHover(object sender, EventArgs e)
        {
            this.ClearCustomerBtn.BackColor = Color.LightSalmon;
        }

        private void ClearCustomerBtn_MouseLeave(object sender, EventArgs e)
        {
            this.ClearCustomerBtn.BackColor = Color.Transparent;
        }

        private void ClearSale()
        {
            this.dataGridView2.Rows.Clear();
            this.totalLbl.Text = "Total   $0.00";
            this.ClearCustomer();
            this.isNewSale = true;
            this.ProductTxt.Enabled = true;
            this.CanceledLbl.Visible = false;
            this.CancelSaleBtn.Hide();
            this.CobrarBtn.Show();
            this.sale = (Venta)null;
            this.label2.Hide();
            this.dateOfSaleLbl.Hide();
            this.EmployeeNameLbl.Hide();
            this.label4.Hide();
            this.dateOfSaleLbl.Hide();
            this.label7.Hide();
            this.cancelationDateLbl.Hide();
            this.label8.Hide();
            this.EmployeeCanceldSaleLbl.Hide();
            this.AmountProdctsLbl.Hide();
            this.pictureBox1.BringToFront();
            this.pictureBox1.Image = (Image)null;
            this.ReturnPackagesBtn.Hide();
            pictureBox1.Show();
            this.printTicketBtn.Hide();
            this.LastSaleBtn.Show();
            this.generalDiscount = 0.0;
            this.isDiscountbyPercentage = false;
            ProductTxt.Text = "";// "Producto * Cantidad";
            ProductTxt.Focus();
            AmountProdctsLbl.Visible = false;
            dataGridView2.Columns["refound"].Visible = false;
            dataGridView2.Columns["depot"].Visible = true;
            previousTicketBtn.Hide();
            nextTicketBtn.Hide();
        }

        private int getDepotIDFromRow(int rowindex)
        {
            try
            {
                var column = dataGridView2.Columns["depot"] as DataGridViewComboBoxColumn;
                foreach (DataRow row in (column.DataSource as DataTable).Rows)
                {
                    if (row["Nombre"].ToString() == dataGridView2.Rows[rowindex].Cells["depot"].EditedFormattedValue.ToString())
                        return Convert.ToInt32(row["ID_Bodega"]);
                }
            }
            catch (FormatException) { }

            return -1;
        }

        private void CobrarBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.Rows.Count <= 0 || !this.isNewSale)
                return;

            double Total = Convert.ToDouble(this.totalLbl.Text.Substring(this.totalLbl.Text.IndexOf("$") + 1));
            DarkForm darkForm = new DarkForm();
            FormPagar formPagar = new FormPagar("$" + Total.ToString("n2"), !this.customer.hasCredit, this.getCostOfReturnablePackages());
            darkForm.Show();
            

            if (formPagar.ShowDialog() == DialogResult.OK)
            {
                Venta venta = new Venta();
                double Payment = Convert.ToDouble(formPagar.Pay);
                List<Tuple<string, double, double, double, int>> list = new List<Tuple<string, double, double, double, int>>();
                string printingString="";
                double discount = 0;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var barcode = row.Cells["barcode"].Value.ToString().ToLower();

                    if (barcode != "" && barcode.IndexOf("promo(") == -1)
                    {
                        Producto product = new Producto(barcode);
                        double amountOfSinglePieces = this.getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), product);
                        double discountFromRow = this.getDiscountFromRow(row.Index);
                        list.Add(new Tuple<string, double, double, double, int>
                            (product.Barcode, product.RetailCost, amountOfSinglePieces, discountFromRow, getDepotIDFromRow(row.Index)));
                        if (!product.HideInTicket)
                            if (product.Brand.Trim() != "")
                                printingString += "\u001b|N" + string.Format("{0}, {1}", product.Description, product.Brand) + "\n";
                            else
                                printingString += "\u001b|N" + string.Format("{0}", product.Description) + "\n";
                        else
                            printingString += "\u001b|N" + string.Format("Productos Varios").Trim(',') + "\n";
                    }
                    else if (barcode.IndexOf("promo(") > -1)
                    {
                        DataSet dataSet = Producto.getPromo(getPromoIDFromRow(row.Index));

                        var amount = Convert.ToDouble(row.Cells["amount"].Value);
                        double promoDiscount = Convert.ToDouble(dataSet.Tables[0].Rows[0]["discount"]);
                        double discountForeachProduct =
                            promoDiscount / Convert.ToDouble(dataSet.Tables[0].Rows[0]["totalAmountOfProducts"]);
                        int child = 1;

                        string description = "Promoción: ";

                        foreach (DataRow promoChild in dataSet.Tables[1].Rows)
                        {
                            string childBarcode = promoChild["id_producto"].ToString();
                            double childAmount = Convert.ToDouble(promoChild["amount"]);
                            double childCost = Convert.ToDouble(dataGridView2.Rows[row.Index + child].Cells["UnitCost"].Value);


                            list.Add(new Tuple<string, double, double, double, int>
                                (childBarcode, childCost, childAmount * amount, discountForeachProduct * childAmount * amount, getDepotIDFromRow(row.Index + child)));

                            description += Convert.ToDouble(promoChild["amount"]).ToString() + " " + promoChild["producto"].ToString().
                                      Substring(0, promoChild["producto"].ToString().LastIndexOf(",")) + ", ";
                            child++;
                        }

                        printingString += "\u001b|N" + description.Substring(0, description.Length - 2) + "\n";
                    }
                    else
                        continue;
                    
                    printingString += "\u001b|N" + row.Cells["amount"].Value.ToString();
                    printingString += "\u001b|cA" + "$" + row.Cells["UnitCost"].Value;
                    printingString += "\u001b|rA" + "$" + getTotalFromRowWithoutDiscount(row.Index).ToString("n2") + "\n";


                    var productDiscount = getDiscountFromRow(row.Index);

                    if (productDiscount > 0)
                    {
                        printingString += "\u001b|rA" + "Descuento: -$" + getDiscountFromRow(row.Index).ToString("n2") + "\n";
                        printingString += "\u001b|rA" + "Costo Final: $" + getTotalFromRow(row.Index).ToString("n2") + "\u001b|N\n";
                    }
                    discount += productDiscount;
                }

                FormCambio formCambio = new FormCambio(Convert.ToDouble(formPagar.Cash) - Convert.ToDouble(formPagar.Pay));
                formCambio.Show();

                var saleID = venta.newSale(this.EmployeeID, this.customer.ID, Total, Payment + formPagar.rest, list.ToArray(), Convert.ToDouble(formPagar.Cash));

                if (this.checkBox1.Checked)
                {
                    openCashDrawer();
                    printTicket(saleID, printingString, discount);
                }
                else
                {
                    openCashDrawer();
                }
                
                this.ClearSale();
                formCambio.Focus();
                darkForm.Close();
            }
            else
            {
                darkForm.Close();
            }

        }

        private void printTicket(int saleID,string products, double discount)
        {
            Venta lastSale = new Venta(saleID);
            try
            {
                if (printer != null)
                {
                    //string logopath = Directory.GetCurrentDirectory() + "\\new logo.bmp";
                    //printer.Open();
                    printer.Claim(1000);
                    printer.DeviceEnabled = true;
                    printer.RecLetterQuality = true;


                    string text = "";
                    if (ticket.logoDisplay)
                        text += "\u001b|1B";//printing logo

                    if (ticket.headderDisplay)
                        text += "\u001b|cA" + "\u001b| 3C" + "\u001b|bC" + ticket.header + "\n";

                    if (ticket.addressDisplay)
                        text += "\u001b|cA" + "\u001b|1C" + ticket.address + "\n";

                    if (ticket.phoneDisplay)
                        text += "\u001b|cA" + "\u001b|1C" + ticket.phone + "\n";

                    string divisionLine = "_".PadLeft(printer.RecLineChars - 2, '_');

                    text += "\u001b|cA" + divisionLine + "\n";

                    text += "\u001b|cA" + "\u001b|4C" + "Detalle de Venta" + "\u001b|1C\n";

                    text += "\u001b|N" + "\nFolio:" + saleID.ToString("X") + "\n";

                    if (lastSale.CustomerID != 0)
                        text += "Cliente: " + new Cliente(lastSale.CustomerID).Name + "\n";

                    text += "Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n";

                    text += "\u001b|cA" + divisionLine + "\n";
                    text += "\u001b|N" + "Cantidad";
                    text += "\u001b|cA" + "Precio";
                    text += "\u001b|rA" + "Importe";
                    text += "\u001b|cA" + divisionLine + "\n" + "\u001b|N";


                    text += products;

                    text += "\u001b|cA" + divisionLine + "\n";
                    text += "\u001b|rA" + "Total: $" + lastSale.Total.ToString("n2") + "\n";

                    if (!lastSale.isPaid)
                        text += "\u001b|rA" + "Usted pagó: $" + lastSale.Payment.ToString("n2") + "\n";

                    text += "\u001b|rA" + "Efectivo: $" + lastSale.Cash.ToString("n2") + "\n";
                    text += "\u001b|rA" + "Cambio: $" + (lastSale.Cash - lastSale.Total).ToString("n2") + "\n";

                    if (discount > 0)
                        text += "\u001b|rA" + "Usted Ahorró: " + discount.ToString("n2") + "\n";

                    text += "\n";

                    if (ticket.footerDisplay)
                        text += "\u001b|cA" + "\u001b|bC" + ticket.footer + "\n";

                    printer.PrintNormal(PrinterStation.Receipt, text);

                    //<<<step4>>>--Start
                    if (printer.CapRecBarCode == true)
                    {
                        //Barcode printing
                        printer.PrintBarCode(PrinterStation.Receipt, lastSale.ID.ToString("X8"),
                            BarCodeSymbology.Code128, 80,
                            printer.RecLineWidth, PosPrinter.PrinterBarCodeCenter,
                            BarCodeTextPosition.None);
                    }

                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|fP");

                    printer.DeviceEnabled = false;
                    printer.Release();
                    //printer.Close();
                }
            }

            catch (PosException e)
            {
                MessageBox.Show(e.Message);
                if (printer.State != ControlState.Closed)
                {
                    printer.Release();
                    // printer.Close();
                }
            }
        }

        private void printTicket(int saleID)
        {
            Venta lastSale = new Venta(saleID);
            try
            {
                string logopath = Directory.GetCurrentDirectory() + "\\new logo.bmp";
                //printer.Open();
                printer.Claim(1000);
                printer.DeviceEnabled = true;
                printer.RecLetterQuality = true;

                if (printer.CapRecBitmap)
                {

                    for (int iRetryCount = 0; iRetryCount < 5; iRetryCount++)
                    {
                        try
                        {
                            //Register a bitmap
                            printer.SetBitmap(1, PrinterStation.Receipt,
                                logopath, printer.RecLineWidth * ticket.logoHeight / 114,
                                PosPrinter.PrinterBitmapCenter);
                            break;
                        }
                        catch (PosControlException pce)
                        {
                            if (pce.ErrorCode == ErrorCode.Failure && pce.ErrorCodeExtended == 0 && pce.Message == "It is not initialized.")
                            {
                                System.Threading.Thread.Sleep(1000);
                            }
                            else
                            {
                                MessageBox.Show(pce.Message + " " + pce.HelpLink);
                            }
                        }
                    }

                }


                if (ticket.logoDisplay)
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|1B");//printing logo

                if (ticket.headderDisplay)
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "\u001b| 3C" + "\u001b|bC" + ticket.header + "\n");

                if (ticket.addressDisplay)
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "\u001b|1C" + ticket.address + "\n");

                if (ticket.phoneDisplay)
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "\u001b|1C" + ticket.phone + "\n");

                string divisionLine = "_".PadLeft(printer.RecLineChars - 2, '_');

                printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + divisionLine + "\n");

                printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "\u001b|4C" + "Detalle de Venta" + "\u001b|1C\n");

                printer.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "\nFolio:" + saleID.ToString("X") + "\n");

                if (lastSale.CustomerID != 0)
                    printer.PrintNormal(PrinterStation.Receipt, "Cliente: " + new Cliente(lastSale.CustomerID).Name + "\n");

                printer.PrintNormal(PrinterStation.Receipt, "Fecha: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");

                printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + divisionLine + "\n");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|N" + "Cantidad");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Precio");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Importe" + "\n");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + divisionLine + "\n" + "\u001b|N");

                double discount = 0.0;
                Console.WriteLine("before adding productds");
                 foreach (DataGridViewRow row in dataGridView2.Rows)
                 {
                     var barcode = row.Cells["barcode"].Value.ToString();
                     if (barcode != "")
                     {
                         string product = "";
                         if (barcode.IndexOf("promo(") == -1)
                         {
                             product = new Producto(barcode).HideInTicket ? "Artículo Varios" : string.Format("{0}, {1}", row.Cells["description"].Value, row.Cells["brand"].Value);

                         }
                         else if (barcode.IndexOf("promo(") > -1)
                         {
                             DataSet table = Producto.getPromo(getPromoIDFromRow(row.Index));

                             string description = string.Format("Promoción: ");

                             foreach (DataRow childRow in table.Tables[1].Rows)
                             {
                                 description += Convert.ToDouble(childRow["amount"]).ToString() + " " + childRow["producto"].ToString().
                                     Substring(0, childRow["producto"].ToString().LastIndexOf(",")) + ", ";
                             }

                             product = description.Substring(0, description.Length - 2);
                         }



                         printer.PrintNormal(PrinterStation.Receipt, product + "\n");

                         var productDiscount = getDiscountFromRow(row.Index);

                         Console.WriteLine("Adding Product");

                         printer.PrintNormal(PrinterStation.Receipt, row.Cells["amount"].Value.ToString());
                         printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "$" + row.Cells["UnitCost"].Value);
                         printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "$" + getTotalFromRowWithoutDiscount(row.Index).ToString("n2") + "\n");

                        if (productDiscount > 0)
                        {
                            printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Descuento: -$" + getDiscountFromRow(row.Index).ToString("n2") + "\n");
                            printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Costo Final: $" + getTotalFromRow(row.Index).ToString("n2") + "\u001b|N\n");
                        }
                         Console.WriteLine("Product added");

                         discount += productDiscount;
                     }
                 }

                Console.WriteLine("Products added");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + divisionLine + "\n");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Total: $" + lastSale.Total.ToString("n2") + "\n");

                if (!lastSale.isPaid)
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Usted pagó: $" + lastSale.Payment.ToString("n2"));

                printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Efectivo: $" + lastSale.Cash.ToString("n2") + "\n");
                printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Cambio: $" + (lastSale.Cash - lastSale.Total).ToString("n2") + "\n");

                if (discount > 0)   
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Usted Ahorró: $" + discount.ToString("n2") + "\n");

                printer.PrintNormal(PrinterStation.Receipt, "\n");

                if (ticket.footerDisplay)
                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "\u001b|bC" + ticket.footer + "\n");

                //<<<step4>>>--Start
                if (printer.CapRecBarCode == true)
                {
                    //Barcode printing
                    printer.PrintBarCode(PrinterStation.Receipt, lastSale.ID.ToString("X8"),
                        BarCodeSymbology.Code128, 80,
                        printer.RecLineWidth, PosPrinter.PrinterBarCodeCenter,
                        BarCodeTextPosition.None);
                }

                printer.PrintNormal(PrinterStation.Receipt, "\u001b|fP");

                printer.DeviceEnabled = false;
                printer.Release();
                //printer.Close();
            }

            catch (PosException e)
            {
                MessageBox.Show(e.Message);
                if (printer.State != ControlState.Closed)
                {
                    printer.Release();
                    //printer.Close();
                }
            }
        }

        private void openCashDrawer()
        {
            string message = "";
            try
            {
                if (cashDrawer != null)
                {
                    //Open the device
                    //Use a Logical Device Name which has been set on the SetupPOS.
                    //cashDrawer.Open();
                    message = "opened";

                    //Get the exclusive control right for the opened device.
                    //Then the device is disable from other application.
                    cashDrawer.Claim(1000);
                    message = "claimed";
                    //Enable the device.
                    cashDrawer.DeviceEnabled = true;
                    message = "enabled";
                    //Open the drawer by using the "OpenDrawer" method.
                    if (!cashDrawer.DrawerOpened)
                        cashDrawer.OpenDrawer();
                    message = "cash drawer opened";

                    //When the drawer is not closed in ten seconds after opening, beep until it is closed.
                    //If  that method is executed, the value is not returned until the drawer is closed.
                    // m_Drawer.WaitForDrawerClose(10000, 2000, 100, 1000);

                    cashDrawer.DeviceEnabled = false;
                    message = "disabled";
                    cashDrawer.Release();
                    message = "released";
                    // cashDrawer.Close();
                    message = "closed";
                }
            }
            catch (PosControlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.HelpLink + " " + ex.HResult + "\n stage: " + message);
            }
            catch (Exception) { }
        }

        private double getCostOfReturnablePackages()
        {
            double num = 0.0;
            foreach (DataGridViewRow row in (IEnumerable)this.dataGridView2.Rows)
            {
                if (new Producto(row.Cells["barcode"].Value.ToString()).isReturnable)
                    num += this.getTotalFromRow(row.Index);
            }
            return num;
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            if (!this.isNewSale)
                return;
            PanelClientesListaClientesForm listaClientesForm = new PanelClientesListaClientesForm(this.EmployeeID);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (listaClientesForm.ShowDialog() == DialogResult.OK)
            {
                this.customer = new Cliente(listaClientesForm.IDCustomer);
                this.CustomerBtn.ButtonText = this.customer.Name;
                this.ClearCustomerBtn.Show();
                this.debtLbl.Text = "$" + this.customer.Debt.ToString("n2");
                this.setCustomerDebtColor();
                this.groupBox1.Size = this.customerGroupBoxMaxSize;
                this.reassignCosts();
                this.CustomerPaymentBtn.Enabled = this.customer.Debt > 0.0;
            }
            darkForm.Close();
        }

        private void CustomerPaymentBtn_Click(object sender, EventArgs e)
        {
            FormPagar form = new FormPagar("$" + this.customer.Debt.ToString("n2"), false, 0.0);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (form.ShowDialog() == DialogResult.OK)
            {
                double customerPayment = Convert.ToDouble(form.Pay);
                double cash = Convert.ToDouble(form.Cash);
                if (customerPayment > 0.0)
                {
                    DataTable acountsReceivable = this.customer.GetAcountsReceivable();
                    double change = cash <= customerPayment ? 0.0 : cash - customerPayment;
                    for (int index = 0; index < acountsReceivable.Rows.Count; ++index)
                    {
                        DataRow row = acountsReceivable.Rows[index];
                        if (customerPayment > 0.0)
                        {
                            double cash1 = customerPayment - Convert.ToDouble(row["Resto"]) <= 0.0 ? customerPayment : Convert.ToDouble(row["Resto"]);
                            this.customer.RegisterPayment(Convert.ToInt32(row["id_ventas"]), DateTime.Now, cash1, this.EmployeeID);
                            this.customer.Pay(cash1, Convert.ToInt32(row["id_ventas"]));
                            customerPayment -= cash1;
                        }
                    }
                    FormCambio formCambio = new FormCambio(change);
                    this.customerPaymentDocument = new PrintDocument();
                    customerPaymentDocument.PrintController = new StandardPrintController();

                    this.customerPaymentDocument.PrintPage += (PrintPageEventHandler)((ss, ee) =>
                    {
                        Graphics graphics = ee.Graphics;
                        this.customerPaymentDocument.PrinterSettings.PrinterName = this.ticket.printerName;
                        this.customerPaymentDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 200, 200);
                        int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
                        int y1 = 10;
                        Size size1 = this.ticket.printLogo(graphics, y1);
                        int y2 = size1.Height == 0 ? y1 : y1 + size1.Height + 10;
                        Size size2 = this.ticket.printHeader(graphics, y2);
                        int y3 = size2.Height == 0 ? y2 : y2 + size2.Height + 10;
                        Size size3 = this.ticket.printAddress(graphics, y3);
                        int y4 = size3.Height == 0 ? y3 : y3 + size3.Height + 10;
                        Size size4 = this.ticket.printPhone(graphics, y4);
                        int num1 = size4.Height == 0 ? y4 : y4 + size4.Height + 10;
                        graphics.DrawLine(Pens.Black, 10, num1, width - 10, num1);
                        int num2 = num1 + 5;
                        string str1 = "Pago de Cliente";
                        Font font1 = this.getFont(str1, width, FontStyle.Regular);
                        Size stringSize1 = this.getStringSize(str1, font1);
                        graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)num2);
                        int num3 = num2 + (15 + stringSize1.Height);
                        if (this.customer.ID != 0)
                        {
                            Font font2 = new Font("Times new Roman", 8f, FontStyle.Bold);
                            Size stringSize2 = this.getStringSize("Cliente: " + this.customer.Name, font2);
                            graphics.DrawString("Cliente: " + this.customer.Name, font2, Brushes.Black, 0.0f, (float)num3);
                            num3 += stringSize2.Height + 10;
                        }
                        string str2 = string.Format("Fecha: {0}\t{1}", (object)DateTime.Now.Date.ToShortDateString(), (object)DateTime.Now.Date.ToShortTimeString());
                        Font font3 = new Font("Times new Roman", 8f, FontStyle.Bold);
                        Size stringSize3 = this.getStringSize(str2, font3);
                        int num4;
                        if (stringSize3.Width + 10 < width)
                        {
                            graphics.DrawString(str2, font3, Brushes.Black, 0.0f, (float)num3);
                            num4 = num3 + (stringSize3.Height + 5);
                        }
                        else
                        {
                            this.Font = this.getFont(str2, width - 10, FontStyle.Bold);
                            Size stringSize2 = this.getStringSize(str2, font3);
                            graphics.DrawString(str2, font3, Brushes.Black, 10f, (float)num3);
                            num4 = num3 + (stringSize2.Height + 5);
                        }
                        customerPayment = Convert.ToDouble(form.Pay);
                        string str3 = string.Format("Adeudo Previo: ${0}", (object)(this.customer.Debt + customerPayment).ToString("n2"));
                        Font font4 = this.getFont(str3, width * 5 / 8, FontStyle.Regular);
                        Size stringSize4 = this.getStringSize(str3, font4);
                        graphics.DrawString(str3, font4, Brushes.Black, 0.0f, (float)num4);
                        int num5 = num4 + (stringSize4.Height + 3);
                        string str4 = string.Format("Monto a pagar: ${0}", (object)customerPayment.ToString("n2"));
                        Size stringSize5 = this.getStringSize(str4, font4);
                        graphics.DrawString(str4, font4, Brushes.Black, 0.0f, (float)num5);
                        int num6 = num5 + (stringSize5.Height + 3);
                        string str5 = string.Format("Adeudo Actualizado: ${0}", (object)this.customer.Debt.ToString("n2"));
                        Font font5 = this.getFont(str5, width * 3 / 4, FontStyle.Bold);
                        Size stringSize6 = this.getStringSize(str3, font5);
                        graphics.DrawString(str5, font5, Brushes.Black, 0.0f, (float)num6);
                        int num7 = num6 + (stringSize6.Height + 8);
                        string str6 = string.Format("Efectivo: ${0}", (object)cash.ToString("n2"));
                        Size stringSize7 = this.getStringSize(str6, font4);
                        graphics.DrawString(str6, font4, Brushes.Black, (float)(width - stringSize7.Width), (float)num7);
                        int num8 = num7 + (stringSize7.Height + 3);
                        string str7 = string.Format("Cambio: ${0}", (object)change.ToString("n2"));
                        Size stringSize8 = this.getStringSize(str7, font4);
                        graphics.DrawString(str7, font4, Brushes.Black, (float)(width - stringSize8.Width), (float)num8);
                        int y5 = num8 + (8 + stringSize8.Height);
                        Size size5 = this.ticket.printFooter(graphics, y5);
                        int num9 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
                    });
                    try
                    {
                        this.customerPaymentDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.customerPaymentDocument;
                        this.customerPaymentDocument.Print();
                    }
                    catch (InvalidPrinterException ex)
                    {
                        int num = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                    }
                    int num10 = (int)formCambio.ShowDialog();
                    this.customer.RefreshInfo();
                    this.debtLbl.Text = "$" + this.customer.Debt.ToString("n2");
                }
                else
                {
                    int num11 = (int)MessageBox.Show("El Cliente no genera ningun adeudo");
                }
            }
            darkForm.Close();
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Visible)
                {
                    if (row.Cells["barcode"].Value != null && row.Cells["barcode"].Value.ToString() != "")
                    {
                        if (i % 2 == 0)
                            row.DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                        else
                            row.DefaultCellStyle.BackColor = Color.White;

                        i++;
                    }
                    else
                        row.DefaultCellStyle.BackColor = dataGridView2.Rows[row.Index - 1 > 0 ? row.Index - 1 : 0].DefaultCellStyle.BackColor;
                }
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.RowCount > 0 && e.ColumnIndex == dataGridView2.Columns["amount"].Index)
            {
                Bodega bodega = new Bodega(Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["depot"].Value));
                string barcode = dataGridView2.Rows[e.RowIndex].Cells["barcode"].Value.ToString();
                var stock = bodega.getProductQuantity(barcode);
                var min = bodega.getMinStockForProduct(barcode);

                if (stock - getAmountOfSinglePieces(dataGridView2.Rows[e.RowIndex].Cells["amount"].Value.ToString(), new Producto(barcode)) <= min)
                {
                    toolTip1.SetToolTip((Control)dataGridView2, "Stock bajo");
                    
                }
            }
        }

        double discountForProductsWithSameMainProduct(Producto producto, int rowIndex)
        {
            double discount = 0;
            double amount = 0;
            Queue<int> matchingMainProductRowIndexes = new Queue<int>();
            double piecesWithDiscount = 0;
            Dictionary<int, double[]> keyValues = new Dictionary<int, double[]>();

            int groupID1 = Producto.findSellingMixedGroup(producto.Barcode);

            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                Producto p = new Producto(r.Cells["barcode"].Value.ToString());

                int groupID2 = Producto.findSellingMixedGroup(p.Barcode);

                //if  (p.mainProductBarcode != null && p.mainProductBarcode == producto.mainProductBarcode)
                if (groupID1 == groupID2 && groupID1 > 0)
                {
                    double wholeAmount = getAmountOfSinglePieces(r.Cells["amount"].Value.ToString(), p);

                    //removing the cases from the whole amount of pieces si if the amount is 1 case 2 pieces we get just 2 pieces
                    amount += wholeAmount % p.PiecesPerCase;

                    if (r.Index != rowIndex)
                        matchingMainProductRowIndexes.Enqueue(r.Index);
                    else
                        piecesWithDiscount = wholeAmount % p.PiecesPerCase;

                    keyValues.Add(r.Index, new double[] { wholeAmount, amount });
                }
            }

            //if the whole single amount makes a case o more then add the discount
            if (amount / producto.PiecesPerCase >= 1)
            {
                int cases = (int)Math.Truncate(amount / producto.PiecesPerCase);

                piecesWithDiscount = keyValues[rowIndex][1] > cases * producto.PiecesPerCase ?
                    keyValues[rowIndex][0] - keyValues[rowIndex][1] % producto.PiecesPerCase :
                    keyValues[rowIndex][0];

                discount += producto.RetailCost * piecesWithDiscount - producto.CostPerCase / producto.PiecesPerCase * piecesWithDiscount;

                foreach (int rowindex in matchingMainProductRowIndexes)
                {
                    dataGridView2.CurrentCell = dataGridView2.Rows[rowindex].Cells["amount"];
                    if (!editingRow)
                    {
                        editingRow = true;
                        addOneMoreProduct();
                        subtractOneProduct();
                        editingRow = false;
                    }
                }

                dataGridView2.CurrentCell = dataGridView2.Rows[rowIndex].Cells["amount"];
            }

            else
            {
                foreach (int rowindex in matchingMainProductRowIndexes)
                {
                    dataGridView2.CurrentCell = dataGridView2.Rows[rowindex].Cells["amount"];
                    if (!editingRow && getDiscountFromRow(rowindex) != 0)
                    {
                        editingRow = true;
                        addOneMoreProduct();
                        subtractOneProduct();
                        editingRow = false;
                    }
                }
            }

            return discount;
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.isNewSale)
                return;
            if (e.KeyCode == Keys.Delete && this.dataGridView2.CurrentRow != null)
            {
                this.dataGridView2.Rows.Remove(this.dataGridView2.CurrentRow);
                this.totalLbl.Text = string.Format("Total   ${0}", (object)this.GetTotal().ToString("n2"));
            }
            if (e.KeyCode == Keys.Add && this.dataGridView2.CurrentRow != null)
                this.addOneMoreProduct();
            if (e.KeyCode != Keys.Subtract || this.dataGridView2.CurrentRow == null)
                return;
            this.subtractOneProduct();
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].Cells["depot"].Value = 1;
            if (this.dataGridView2.RowCount - 1 == this.dataGridView2.FirstDisplayedScrollingRowIndex + this.dataGridView2.DisplayedRowCount(true) - 1)
                return;
            this.dataGridView2.FirstDisplayedScrollingRowIndex = this.dataGridView2.RowCount - 1;

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView2.Rows[e.RowIndex].Cells["barcode"].Value == null)
                return;


            string barcode = this.dataGridView2.Rows[e.RowIndex].Cells["barcode"].Value.ToString();


            if (barcode.ToString() == null || barcode.ToString() == "" || barcode.ToString().ToLower().IndexOf("promo(") > -1)
            {
                selectPromo(e.RowIndex);
                pictureBox1.Image = null;
            }
            else
            {
                Producto product = new Producto(barcode);

                pictureBox1.Image = product.image;//this.ShowImage(barcode);

                if (product.isReturnable)
                    setToolTip(e.RowIndex);
                else
                    ReturnPackagesBtn.Enabled = false;

            }
        }

        private void selectPromo(int rowindex)
        {
            //looking for the begining of the promo
            for (int i = rowindex; i >= 0; i--)
            {
                var code = dataGridView2.Rows[i].Cells["barcode"].Value.ToString();

                dataGridView2.Rows[i].Selected = true;

                if (code != null && code.IndexOf("promo(") > -1)
                {

                    break;
                }
            }

            for (int i = rowindex + 1; i < dataGridView2.RowCount; i++)
            {
                var code = dataGridView2.Rows[i].Cells["barcode"].Value.ToString();

                if (code != null && code != "")
                {
                    break;
                }
                else
                {
                    dataGridView2.Rows[i].Selected = true;
                }
            }
        }

        private void setCurrentCell(DataGridView dataGridView, int rowindex)
        {
            dataGridView.CurrentCell = dataGridView.Rows[rowindex].Cells[1];
        }

        private void debtLbl_TextChanged(object sender, EventArgs e)
        {
            this.setCustomerDebtColor();
            this.centerCustomerDebtLabels();
        }

        private double getAmountOfSinglePieces(string cellValue, Producto product)
        {
            string lower = cellValue.ToLower();
            double num1 = lower.IndexOf(",") > -1 ? Convert.ToDouble(lower.Substring(0, lower.IndexOf("c"))) : 0.0;
            string str = lower.Substring(lower.IndexOf(",") + 1);

            double num2 = 0;
            try
            {
                num2 = Convert.ToDouble(lower);
            }
            catch (FormatException)
            {
                if (!product.displayAsKilogram)
                {
                    num2 = Convert.ToDouble(str.Substring(0, str.IndexOf("p")));
                }
                else
                {
                    bool hasCases = false;
                    if (cellValue.IndexOf("caja") > -1)
                    {
                        num2 = product.PiecesPerCase * Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf("caja")));
                        hasCases = true;
                    }
                    num2 = hasCases ? num2 + Convert.ToDouble(cellValue.Substring(cellValue.IndexOf("\n"), cellValue.ToLower().IndexOf("kg") - cellValue.IndexOf("\n"))) :
                        Convert.ToDouble(cellValue.ToLower().Substring(0, cellValue.ToLower().IndexOf("kg")));
                    return num2;
                }
            }

            return num1 * product.PiecesPerCase + num2;
        }

        private void GetCustomerCostFormat(int rowIndex)
        {
            string cellValue = this.dataGridView2.Rows[rowIndex].Cells["amount"].Value.ToString();
            Producto product = new Producto(this.dataGridView2.Rows[rowIndex].Cells["barcode"].Value.ToString());

            //if the cell value has the format-> "X cajas, N pieces"
            if (cellValue.IndexOf(",") > -1)
            {
                int cases = Convert.ToInt32(cellValue.Substring(0, cellValue.IndexOf("c")));

                cellValue = cellValue.Substring(cellValue.IndexOf(",") + 1);

                //converting the whole amount to pieces
                double amount = !product.displayAsKilogram ? Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf("p"))) + (double)cases * product.PiecesPerCase :
                    Convert.ToDouble(cellValue.Remove(cellValue.IndexOf("Kg"), 2)) + (double)cases * product.PiecesPerCase;

                //customer discount
                double discount = amount * product.RetailCost - this.customer.getCost(product.Barcode, amount) * amount;

                //cost for each case and adding the cost of every piece that does not make an entire case
                double caseDiscount = product.RetailCost * amount - cases * product.CostPerCase;//+ (cases * product.PiecesPerCase) * product.RetailCost;

                //getting general discount
                double genDisc = getTotalFromRowWithoutDiscount(rowIndex) / 100.0 * this.generalDiscount;

                //selecting the best discount for the customer
                double finalDisc = discount > caseDiscount ? discount : caseDiscount;

                finalDisc = finalDisc > genDisc ? finalDisc : genDisc;


                //if the final cost minus the discount is less than the purchase cost then adjust the discount for the user income become zero
                if (getTotalFromRowWithoutDiscount(rowIndex) - finalDisc < product.PurchaseCost / product.PiecesPerCase * amount)
                    finalDisc = amount * product.RetailCost - product.PurchaseCost / product.PiecesPerCase * amount;

                if (finalDisc > 0.0 && !this.customer.DontApplyAnyDiscount)
                {
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = ((amount * product.RetailCost).ToString("n2") + "\r\n-" + finalDisc.ToString("n2"));
                }
                else//if theres no discount
                {
                    double num4 = amount * product.RetailCost;
                    double num5 = amount - (double)cases * product.PiecesPerCase;
                    double num6 = num4 - (num5 * product.RetailCost + (double)cases * product.CostPerCase);
                    if (num6 > product.PurchaseCost)
                        num6 = caseDiscount - product.PurchaseCost;
                    if (this.customer.DontApplyAnyDiscount)
                        num6 = 0.0;
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = num6 > 0.0 ? string.Format("{0}\r\n-{1}", num4.ToString("n2"), num6.ToString("n2")) :
                        string.Format("{0}", num4.ToString("n2"));
                }
            }
            else
            {
                double amount = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf(".") + 3));
                double customerDisc = amount * product.RetailCost - this.customer.getCost(product.Barcode, amount) * amount;
                double generalDisc = amount * product.RetailCost / 100.0 * this.generalDiscount;

                double finalDisc = customerDisc > generalDisc ? customerDisc : generalDisc;

                if (product.RetailCost * amount - finalDisc < product.PurchaseCost / product.PiecesPerCase * amount)
                    finalDisc = amount * product.RetailCost - product.PurchaseCost / product.PiecesPerCase * amount;

                if (finalDisc > 0.0 && !this.customer.DontApplyAnyDiscount)
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = (object)((amount * product.RetailCost).ToString("n2") + "\r\n-" + finalDisc.ToString("n2"));

                else
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = (object)(amount * this.customer.getCost(product.Barcode, amount)).ToString("n2");
            }
        }

        private double getDiscountFromRow(int rowindex)
        {
            if (this.dataGridView2.Rows.Count <= rowindex)
                return 0.0;
            string str = this.dataGridView2.Rows[rowindex].Cells["Total"].Value.ToString();
            return str.IndexOf("\r\n") > -1 ? Convert.ToDouble(str.Substring(str.LastIndexOf("-") + 1)) : 0.0;
        }

        private double GetTotal()
        {
            double num = 0.0;
            foreach (DataGridViewRow row in (IEnumerable)this.dataGridView2.Rows)
            {
                if (row.Cells["Total"].Value != null && row.Cells["barcode"].Value.ToString() != "")
                    num += this.getTotalFromRow(row.Index);
            }
            return num;
        }

        private double getTotalFromRow(int rowIndex)
        {
            if (this.dataGridView2.Rows.Count <= rowIndex && dataGridView2.Rows[rowIndex].Cells["barcode"].Value.ToString() == "")
                return 0.0;

            string str = this.dataGridView2.Rows[rowIndex].Cells["Total"].Value.ToString();

            return str.IndexOf("\r\n") > -1 ? Convert.ToDouble(str.Substring(0, str.IndexOf("\r\n"))) - this.getDiscountFromRow(rowIndex) : Convert.ToDouble(this.dataGridView2.Rows[rowIndex].Cells["Total"].Value);
        }

        private void groupBox1_SizeChanged(object sender, EventArgs e)
        {
            panel6.Height = CobrarBtn.Location.Y - (groupBox1.Location.Y + groupBox1.Height);
            if (this.groupBox1.Size == this.customerGroupBoxMinSize)
            {
                this.CustomerPaymentBtn.Visible = false;
                this.label1.Visible = false;
                this.debtLbl.Visible = false;
                this.pictureBox1.Size = this.pictureBoxMaxSize;
                var top = (refoundBtn.Location.Y + refoundBtn.Height);
                this.pictureBox1.Location = new Point(this.groupBox1.Location.X, top + (panel6.Height - top) / 2 - pictureBox1.Height / 2);
            }
            else if (this.groupBox1.Size == this.customerGroupBoxMaxSize)
            {
                this.CustomerPaymentBtn.Visible = true;
                this.label1.Visible = true;
                this.debtLbl.Visible = true;
                this.pictureBox1.Size = this.pictureBoxMinSize;
                var top = (refoundBtn.Location.Y + refoundBtn.Height);
                this.pictureBox1.Location = new Point((panel6.Width - pictureBox1.Width) / 2, top + (panel6.Height - top) / 2 - pictureBox1.Height / 2);
            }
            this.CustomerPaymentBtn.Enabled = this.customer.Debt > 0.0;
            this.panel6.Location = new Point(this.panel6.Location.X, this.groupBox1.Location.Y + this.groupBox1.Height);
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

        private void lessBtn_Click(object sender, EventArgs e)
        {
            if (!this.isNewSale)
                return;
            this.subtractOneProduct();

            totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
            countProducts();
        }

        private void LastSaleBtn_Click(object sender, EventArgs e)
        {
            Venta lastSale = Venta.getLastSale();
            if (lastSale != null)
            {
                if (this.dataGridView2.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea mostrar la última venta realizada?. Se perderá la información actual.", "Última venta", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    this.setSale(lastSale.ID);
                }
                else
                {
                    if (this.dataGridView2.Rows.Count != 0)
                        return;
                    this.setSale(lastSale.ID);
                }
            }
            else
            {
                int num = (int)MessageBox.Show("No se encontró información");
            }
        }

        private void LookForProductToAdd()
        {
            if (!(ProductTxt.Text != ""))
                return;


            int length = this.ProductTxt.Text.IndexOf("*");
            string str;
            double quantity;

            if (length > -1)
            {
                str = this.ProductTxt.Text.Trim().Substring(0, length);
                try
                {
                    quantity = Convert.ToDouble(this.ProductTxt.Text.Substring(length + 1));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Revise que la cantidad ingresada sea correcta.", "Error de Formato", MessageBoxButtons.OK);
                    int num2 = this.ProductTxt.Text.IndexOf('*');

                    if (num2 <= -1)
                        return;

                    int num3;
                    ProductTxt.Select(num3 = num2 + 1, this.ProductTxt.Text.Length - num3);
                    return;
                }
            }
            else
            {
                str = ProductTxt.Text.Trim();
                quantity = 1.0;
            }


            if (!this.isNumber(str))
            {
                str = str.Trim().ToLower();

                if (str.IndexOf("promo(") == 0 && (str.IndexOf(")") > str.IndexOf("promo(")))
                {
                    try
                    {
                        int beginIndex = str.IndexOf("promo(") + 6;
                        int strLength = str.IndexOf(")") - beginIndex;

                        int id = Convert.ToInt32(str.Substring(beginIndex, strLength));

                        if (Producto.promoExist(id))
                        {
                            addPromoToGridView(id, quantity);
                        }
                        else
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Windows_Battery_Low);
                            try
                            {
                                player.Play();
                                player.Play();
                            }
                            catch (Exception) { }
                            MessageBox.Show("No se encontró la promoción indicada.");
                            ProductTxt.Select(beginIndex, strLength);
                        }
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Formato incorrecto.");
                        ProductTxt.SelectAll();
                    }
                }
                else
                {
                    DataTable table = Producto.SearchValueGetTable(str);
                    if (table.Rows.Count == 0 || str == ".")
                    {

                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Windows_Battery_Low);
                        try
                        {
                            player.Play();
                            player.Play();
                        }
                        catch (Exception) { }
                        MessageBox.Show("No se encontró el producto");
                        this.ProductTxt.SelectAll();
                    }
                    else
                    {
                        DarkForm darkForm = new DarkForm();
                        ChooseProductForm chooseProductForm = new ChooseProductForm(table, new Empleado(EmployeeID));
                        darkForm.Show();
                        if (chooseProductForm.ShowDialog() == DialogResult.OK)
                        {
                            this.addProductToDataGrid(new Producto(chooseProductForm.selectedItem[0]), quantity);
                            this.ProductTxt.Text = "";
                        }
                        darkForm.Close();
                    }
                }
            }
            else
            {
                Producto p = new Producto(str);
                if (p.Barcode != "")
                {
                    this.addProductToDataGrid(p, quantity);
                    this.ProductTxt.Text = "";
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Windows_Battery_Low);
                    try
                    {
                        player.Play();
                        player.Play();
                    }
                    catch (Exception) { }
                    MessageBox.Show("No se encontró el producto");
                    this.ProductTxt.SelectAll();
                }
            }
        }

        private void moreBtn_Click(object sender, EventArgs e)
        {
            if (!this.isNewSale)
                return;
            this.addOneMoreProduct();
            countProducts();
        }

        public Panel_Ventas(int employeeID, FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            ProductTxt.Focus();
            this.EmployeeID = employeeID;
            this.defaultTxt = "";// "Producto * Cantidad";
            this.customer = new Cliente(0);
            this.isNewSale = true;
            this.ticket = new PrinterTicket();
            this.CanceledLbl.Parent = (Control)this.dataGridView2;
            this.CanceledLbl.BackColor = Color.Transparent;
            this.dataGridView2.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.discountBtn.Visible = new Empleado(employeeID).isAdmin;
            this.generalDiscount = 0.0;
            this.isDiscountbyPercentage = false;

            var comboColumn = dataGridView2.Columns["depot"] as DataGridViewComboBoxColumn;
            comboColumn.DataSource = Bodega.GetDepots();
            comboColumn.DisplayMember = "Nombre";
            comboColumn.ValueMember = "ID_Bodega";

            Color color = Color.FromArgb(new Random().Next());
            bunifuGradientPanel1.GradientBottomLeft = bunifuGradientPanel1.GradientTopRight = color;
            bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(color.R + 100 < 255 ? color.R + 100 : 255,
                color.G + 100 < 255 ? color.G + 100 : 255, color.B + 100 < 255 ? color.B + 100 : 255);
            bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(color.R + 100 < 255 ? color.R + 100 : 255,
                color.G + 100 < 255 ? color.G + 100 : 255, color.B + 100 < 255 ? color.B + 100 : 255);

            printDocument1.PrintController = new StandardPrintController();
            this.Name = "window " + count.ToString();
        }

        private void Panel_Ventas_Load(object sender, EventArgs e)
        {
            this.ProductTxt.Text = this.defaultTxt;
            this.dataGridView2.CurrentCell = (DataGridViewCell)null;
            this.groupBox1.Size = this.customerGroupBoxMinSize;
            this.SuspendLayout();
            float num1 = (float)this.Width / (float)this.CanceledLbl.Width;
            float num2 = (float)this.Height / (float)this.CanceledLbl.Height;
            this.CanceledLbl.Font = new Font(this.CanceledLbl.Font.FontFamily, this.CanceledLbl.Font.Size * ((double)num1 > (double)num2 ? num2 : num1), this.CanceledLbl.Font.Style);
            this.ResumeLayout();
            this.CanceledLbl.Location = new Point(-50, (this.CanceledLbl.Parent.Height - this.CanceledLbl.Height) / 2);
            this.printDialog1 = new PrintDialog();
            this.printDialog1.PrinterSettings.PrinterName = this.ticket.printerName;

            ProductTxt.Focus();

            try
            {
                //Create PosExplorer
                PosExplorer posExplorer = new PosExplorer();
                DeviceInfo deviceInfo = null;
                try
                {
                    deviceInfo = posExplorer.GetDevice(DeviceType.CashDrawer, "CashDrawer");
                    cashDrawer = (CashDrawer)posExplorer.CreateInstance(deviceInfo);
                    cashDrawer.Open();

                }
                catch (Exception) {                   /*Nothing can be used.  */       }

                try
                {
                    printer = posExplorer.CreateInstance(posExplorer.GetDevice(DeviceType.PosPrinter, "PosPrinter")) as PosPrinter;
                    printer.Open();

                    string logopath = Directory.GetCurrentDirectory() + "\\new logo.bmp";
                    
                    printer.Claim(1000);
                    printer.DeviceEnabled = true;
                    printer.RecLetterQuality = true;

                    if (printer.CapRecBitmap)
                    {

                        for (int iRetryCount = 0; iRetryCount < 5; iRetryCount++)
                        {
                            try
                            {
                                //Register a bitmap
                                printer.SetBitmap(1, PrinterStation.Receipt,
                                    logopath, printer.RecLineWidth * ticket.logoHeight / 114,
                                    PosPrinter.PrinterBitmapCenter);
                                break;
                            }
                            catch (PosControlException pce)
                            {
                                if (pce.ErrorCode == ErrorCode.Failure && pce.ErrorCodeExtended == 0 && pce.Message == "It is not initialized.")
                                {
                                    System.Threading.Thread.Sleep(1000);
                                }
                                else
                                {
                                    MessageBox.Show(pce.Message + " " + pce.HelpLink);
                                }
                            }
                        }

                    }

                    printer.DeviceEnabled = false;
                    printer.Release();
                }
                catch (Exception) { }


            }
            catch (PosControlException)
            {
                //Nothing can be used.
                MessageBox.Show("No se tuvo acceso a la impresora o al cajon");
            }

            setimage();

        }

        private async void setimage()
        {
            await Task.Run(() => {

                PrinterTicket printerTicket = new PrinterTicket();
                Bitmap bmp = (Bitmap)printerTicket.logo;


                Rectangle newRec = new Rectangle(0, 0, 300, 114);
                Bitmap resize = new Bitmap(300, 114);

                resize.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
                using (var g = Graphics.FromImage(resize))
                {
                    g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    using (var wrap = new ImageAttributes())
                    {
                        wrap.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                        g.DrawImage(bmp, newRec, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, wrap);
                    }
                }

                resize.Save("new logo.bmp");
            });
        }

        private void paymentLbl_TextChanged(object sender, EventArgs e)
        {
            if (this.sale == null)
                return;
            this.AmountProdctsLbl.ForeColor = this.sale.isPaid ? Color.Blue : Color.Tomato;
        }

        private void ProductTxt_Enter(object sender, EventArgs e)
        {
            if (this.ProductTxt.Find(this.defaultTxt) <= -1)
                return;
            this.ProductTxt.Text = "";
        }

        private void ProductTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.ProductTxt != null && e.KeyCode != Keys.Return)
            {
                if (this.ProductTxt.Text.IndexOf("*") > -1)
                {
                    if (this.ProductTxt.Text.Substring(this.ProductTxt.Text.IndexOf("*") + 1) == ".")
                    {
                        MessageBox.Show("Debe indicar la cantidad a agregar");
                        return;
                    }
                    if (this.ProductTxt.Text[this.ProductTxt.Text.Length - 1] == '*')
                        this.ProductTxt.Text = this.ProductTxt.Text.Substring(0, this.ProductTxt.Text.LastIndexOf("*") + 1) + "1";
                    string text = this.ProductTxt.Text.Substring(this.ProductTxt.Text.IndexOf("*") + 1);
                    if (text.IndexOf('.') > -1)
                    {
                        int startIndex = text.IndexOf('.');
                        text = text.Remove(startIndex, 1);
                    }
                    if (!this.isNumber(text))
                    {
                        MessageBox.Show("Sólo se aceptan números decimales después del \"*\"", "Formato no válido");
                        return;
                    }
                }
                e.SuppressKeyPress = true;
            }
            if (this.ProductTxt != null && e.KeyCode == Keys.Return && !e.Control)
                this.LookForProductToAdd();
            if (e.KeyCode != Keys.Escape)
                return;
            this.ProductTxt.Text = "";
        }

        private void ProductTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int startIndex = this.ProductTxt.Text.IndexOf('*');
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && startIndex > -1) && this.ProductTxt.SelectionStart > startIndex)
                e.Handled = true;
            if (startIndex <= -1)
                return;
            string str = this.ProductTxt.Text.Substring(startIndex);
            if (e.KeyChar != '.' || str.IndexOf(".") <= -1)
                return;
            e.Handled = true;
        }

        private void ProductTxt_Leave(object sender, EventArgs e)
        {
            ProductTxt.Focus();
            if (!(this.ProductTxt.Text == ""))
                return;
            this.ProductTxt.Text = this.defaultTxt;
        }

        private void ProductTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.ProductTxt.Text.IndexOf("*") > -1 && this.ProductTxt.Text.IndexOf("*") == this.ProductTxt.Text.Length - 1)
            {
                int selectionStart = this.ProductTxt.SelectionStart;
                this.ProductTxt.SelectionStart = this.ProductTxt.Text.IndexOf("*");
                this.ProductTxt.Find("*");
                this.ProductTxt.SelectionColor = Color.Tomato;
                this.ProductTxt.DeselectAll();
                this.ProductTxt.SelectionStart = selectionStart;
            }
            else if (this.ProductTxt.Text.IndexOf("*") > -1)
            {
                int selectionStart = this.ProductTxt.SelectionStart;
                int num = this.ProductTxt.Text.IndexOf("*") + 1;
                if (this.ProductTxt.Text.Length <= num)
                    return;
                this.ProductTxt.Find(this.ProductTxt.Text.Substring(num), num, RichTextBoxFinds.WholeWord);
                this.ProductTxt.SelectionColor = Color.LimeGreen;
                this.ProductTxt.DeselectAll();
                this.ProductTxt.SelectionStart = selectionStart;
            }
            else
            {
                int selectionStart = this.ProductTxt.SelectionStart;
                this.ProductTxt.SelectAll();
                this.ProductTxt.SelectionColor = Color.FromArgb(0, 130, 170);
                this.ProductTxt.DeselectAll();
                this.ProductTxt.SelectionStart = selectionStart;
            }
        }

        private void reassignCosts()
        {
            int rowindex = dataGridView2.CurrentCell != null ? dataGridView2.CurrentCell.RowIndex : -1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["barcode"].Value != null && row.Cells["barcode"].Value.ToString() != "" &&
                    row.Cells["barcode"].Value.ToString().ToLower().IndexOf("promo(") == -1)
                {
                    dataGridView2.CurrentCell = row.Cells["amount"];
                    Producto p = new Producto(row.Cells["barcode"].Value.ToString());
                    
                    row.Cells["total"].Value = getCost(p, row.Index);
                }

            }
            dataGridView2.CurrentCell = rowindex != -1 ? dataGridView2.Rows[rowindex].Cells["amount"] : null;

            totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));

        }

        private void refoundBtn_Click(object sender, EventArgs e)
        {
            DarkForm darkForm = new DarkForm();
            panelVentas_getTicketForm ventasGetTicketForm = new panelVentas_getTicketForm();
            darkForm.Show();
            if (ventasGetTicketForm.ShowDialog() == DialogResult.OK)
                this.setSale(ventasGetTicketForm.ticketNumber);
            darkForm.Close();
        }

        private void ReturnPackagesBtn_Click(object sender, EventArgs e)
        {
            string barcode = this.dataGridView2.SelectedRows[0].Cells["barcode"].Value.ToString();
            int pendingPackages = this.sale.getAmountOfPendingPackagesToReturn(barcode);
            if (this.sale.Date.Date < DateTime.Today.Date.AddDays(-7.0))
            {
                MessageBox.Show(string.Format("No se pueden retornar más envases. La fecha de compra excede los {0} días permitidos para la devolución.\n\nFecha de compra: {1} de {2} del {3}\n", (object)7, (object)this.sale.Date.Day, (object)new CultureInfo("es-MX").DateTimeFormat.GetMonthName(this.sale.Date.Month), (object)this.sale.Date.Year), "Lapso excedido");
            }
            else if (pendingPackages > 0 && !this.sale.isSaleCanceled)
            {
                DarkForm darkForm = new DarkForm();
                PanelVentas_RetornarEnvasesForm returnForm = new PanelVentas_RetornarEnvasesForm(pendingPackages);
                darkForm.Show();
                if (returnForm.ShowDialog() == DialogResult.OK)
                {
                    this.sale.returnPackages(barcode, returnForm.AmountOfPackagesToReturn, this.EmployeeID);
                    double change = (double)(this.sale.getSingleCost(barcode) * (Decimal)returnForm.AmountOfPackagesToReturn);
                    FormCambio formCambio = new FormCambio(change);
                    /*this.packageReturnedDocument = new PrintDocument();
                    packageReturnedDocument.PrintController = new StandardPrintController();
                    this.packageReturnedDocument.PrintPage += (PrintPageEventHandler)((s, ee) =>
                    {
                        Graphics graphics = ee.Graphics;
                        this.packageReturnedDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
                        int y1 = 10;
                        Size size1 = this.ticket.printLogo(graphics, y1);
                        int y2 = size1.Height == 0 ? y1 : y1 + size1.Height + 10;
                        Size size2 = this.ticket.printHeader(graphics, y2);
                        int y3 = size2.Height == 0 ? y2 : y2 + size2.Height + 10;
                        Size size3 = this.ticket.printAddress(graphics, y3);
                        int y4 = size3.Height == 0 ? y3 : y3 + size3.Height + 10;
                        Size size4 = this.ticket.printPhone(graphics, y4);
                        int num2 = size4.Height == 0 ? y4 : y4 + size4.Height + 10;
                        graphics.DrawLine(Pens.Black, 10, num2, width - 10, num2);
                        int num3 = num2 + 5;
                        string str1 = "Retorno de Envases";
                        Font font1 = this.getFont(str1, width, FontStyle.Bold);
                        Size stringSize1 = this.getStringSize(str1, font1);
                        graphics.DrawString(str1, font1, Brushes.Black, 0.0f, (float)num3);
                        int num4 = num3 + (stringSize1.Height + 5);
                        Font font2 = new Font("times new roman", 10f, FontStyle.Regular);
                        string str2 = string.Format("Folio: {0}", (object)this.sale.ID.ToString("X"));
                        Font font3 = font2;
                        Size stringSize2 = this.getStringSize(str2, font3);
                        if (stringSize2.Width > width)
                        {
                            font3 = this.getFont(str2, width, FontStyle.Regular);
                            stringSize2 = this.getStringSize(str2, font3);
                        }
                        graphics.DrawString(str2, font3, Brushes.Black, 0.0f, (float)num4);
                        int num5 = num4 + (stringSize2.Height + 3);
                        string str3 = string.Format("Fecha: {0} {1}", (object)DateTime.Now.ToShortDateString(), (object)DateTime.Now.ToShortTimeString());
                        Font font4 = font2;
                        Size stringSize3 = this.getStringSize(str3, font4);
                        if (stringSize3.Width > width)
                        {
                            font4 = this.getFont(str3, width, FontStyle.Regular);
                            stringSize3 = this.getStringSize(str3, font4);
                        }
                        graphics.DrawString(str3, font4, Brushes.Black, 0.0f, (float)num5);
                        int num6 = num5 + (stringSize3.Height + 3);
                        if (this.sale.CustomerID != 0)
                        {
                            string str4 = string.Format("Cliente: {0}", (object)new Cliente(this.sale.CustomerID).Name);
                            Font font5 = font2;
                            Size stringSize4 = this.getStringSize(str4, font5);
                            if (stringSize4.Width > width - 10)
                            {
                                this.getFont(str4, width - 10, FontStyle.Bold);
                                stringSize4 = this.getStringSize(str4, font5);
                            }
                            graphics.DrawString(str4, font5, Brushes.Black, 0.0f, (float)num6);
                            num6 += stringSize4.Height + 3;
                        }
                        graphics.DrawLine(Pens.Black, 10, num6, width - 10, num6);
                        int num7 = num6 + 10;
                        Producto producto = new Producto(barcode);
                        string str5 = string.Format("{0}, {1}", (object)producto.Description, (object)producto.Brand);
                        Font font6 = new Font("times new roman", 12f);
                        Size stringSize5 = this.getStringSize(str5, font6);
                        if (stringSize5.Width > width)
                        {
                            int letterByMeasuring = this.getLastLetterByMeasuring(str5, font6, width);
                            str5 = str5.Insert(letterByMeasuring, str5[letterByMeasuring] == ' ' ? "\n" : "-\n");
                            stringSize5 = this.getStringSize(str5, font6);
                        }
                        graphics.DrawString(str5, font6, Brushes.Black, 0.0f, (float)num7);
                        int num8 = num7 + (stringSize5.Height + 10);
                        string str6 = string.Format("Envases retornados: {0}", (object)returnForm.AmountOfPackagesToReturn);
                        Font font7 = this.getFont(str6, width * 5 / 8, FontStyle.Regular);
                        Size stringSize6 = this.getStringSize(str6, font7);
                        graphics.DrawString(str6, font7, Brushes.Black, 0.0f, (float)num8);
                        int num9 = num8 + (stringSize6.Height + 2);
                        string str7 = string.Format("Envases pendientes: {0}", (object)(pendingPackages - returnForm.AmountOfPackagesToReturn));
                        Font font8 = new Font(font7.Name, font7.Size, FontStyle.Bold);
                        Size stringSize7 = this.getStringSize(str7, font8);
                        if (stringSize7.Width > width - 10)
                        {
                            font8 = this.getFont(str7, width - 10, FontStyle.Bold);
                            stringSize7 = this.getStringSize(str7, font8);
                        }
                        graphics.DrawString(str7, font8, Brushes.Black, 0.0f, (float)num9);
                        int num10 = num9 + (stringSize7.Height + 9);
                        string str8 = string.Format("Cambio: ${0}", (object)change.ToString("n2"));
                        Font font9 = new Font("times new roman", 10f, FontStyle.Regular);
                        Size stringSize8 = this.getStringSize(str8, font9);
                        graphics.DrawString(str8, font9, Brushes.Black, (float)(width - stringSize8.Width), (float)num10);
                        int y5 = num10 + (stringSize8.Height + 10);
                        Size size5 = this.ticket.printFooter(graphics, y5);
                        int y6 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
                        Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(this.sale.ID.ToString("X8"), 50);
                        graphics.DrawImage(image, 10, y6, width - 10, 20);
                    });
                    try
                    {
                        this.packageReturnedDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.packageReturnedDocument;
                        this.packageReturnedDocument.Print();
                    }
                    catch (InvalidPrinterException ex)
                    {
                        int num2 = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                    }
                    */
                    openCashDrawer();

                    formCambio.ShowDialog();
                    this.setToolTip(this.dataGridView2.CurrentRow.Index);
                }
                darkForm.Close();
            }
            else
            {
                int num12 = (int)MessageBox.Show("No se deben envases de este producto.");
            }
        }

        private void packageReturnedDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
        }

        private void setCustomerDebtColor()
        {
            if (this.customer.Debt == 0.0)
            {
                this.debtLbl.ForeColor = Color.LimeGreen;
                this.label1.ForeColor = Color.LimeGreen;
            }
            else
            {
                this.debtLbl.ForeColor = Color.Tomato;
                this.label1.ForeColor = Color.Tomato;
            }
        }

        private void setSale(int SaleID)
        {
            ClearSale();
            sale = new Venta(SaleID);
            Cliente cliente = new Cliente(sale.CustomerID);
            pictureBox1.SendToBack();
            pictureBox1.Hide();
            foreach (DataRow row in sale.getSoldProducts.Rows)
            {
                Producto producto = new Producto(row["id_producto"].ToString());
                bool refounded = Convert.ToBoolean(row["Devolución"]);
                int rowindex = dataGridView2.Rows.Add(producto.Barcode, refounded, producto.Description, producto.Brand, row["Cantidad"].ToString(), row["Precio"].ToString(), Convert.ToDouble(row["Descuento"]) != 0.0 ? (row["Importe"].ToString() + "\r\n -" + row["Descuento"].ToString()) : row["Importe"].ToString());

                if (refounded)
                {
                    dataGridView2.Rows[rowindex].DefaultCellStyle.ForeColor = Color.DimGray;
                    dataGridView2.Rows[rowindex].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                    dataGridView2.Rows[rowindex].Cells["refound"].ReadOnly = true;
                }
                else
                    dataGridView2.Rows[rowindex].Cells["refound"].ReadOnly = false;
            }


         

            dataGridView2.Columns["refound"].Visible = true;
            dataGridView2.Columns["depot"].Visible = false;
            CustomerBtn.ButtonText = cliente.Name;
            totalLbl.Text = string.Format("Total   ${0}", sale.Total);
            AmountProdctsLbl.Text = string.Format("Abono   ${0}", sale.Payment);
            ProductTxt.Enabled = false;
            isNewSale = false;
            CanceledLbl.Visible = sale.isSaleCanceled;
            CobrarBtn.Visible = false;
            CancelSaleBtn.Visible = true;
            CancelSaleBtn.Enabled = !sale.isSaleCanceled;
            CultureInfo cultureInfo = new CultureInfo("es-MX");
            dateOfSaleLbl.Text = string.Format("{0} de {1} del {2}", sale.Date.Day, cultureInfo.DateTimeFormat.GetMonthName(sale.Date.Month), sale.Date.Year);
            EmployeeNameLbl.Text = new Empleado(sale.EmployeeID).name;
            centerToParent(EmployeeNameLbl);
            EmployeeNameLbl.Visible = true;
            cancelationDateLbl.Text = string.Format("{0} de {1} del {2}", sale.cancellationDate.Day, cultureInfo.DateTimeFormat.GetMonthName(sale.cancellationDate.Month), sale.cancellationDate.Year);
            EmployeeCanceldSaleLbl.Text = new Empleado(sale.EmployeeWhoCanceledTheSale).name;
            label2.Show();
            dateOfSaleLbl.Show();
            centerToParent(dateOfSaleLbl);
            label4.Show();
            dateOfSaleLbl.Show();
            centerToParent(dateOfSaleLbl);
            label7.Visible = sale.isSaleCanceled;
            cancelationDateLbl.Visible = sale.isSaleCanceled;
            centerToParent(cancelationDateLbl);
            label8.Visible = sale.isSaleCanceled;
            EmployeeCanceldSaleLbl.Visible = sale.isSaleCanceled;
            centerToParent(EmployeeCanceldSaleLbl);
            AmountProdctsLbl.Show();
            ReturnPackagesBtn.Show();
            LastSaleBtn.Hide();
            printTicketBtn.Show();
            nextTicketBtn.Visible = true;
            previousTicketBtn.Visible = true;


            //***************************
            var data = sale.getNextSaleID();

            if (data.Tables[1].Rows.Count == 0)
                nextTicketBtn.Hide();
            else
                nextTicketBtn.Show();


            if (data.Tables[0].Rows.Count == 0)
                previousTicketBtn.Hide();
            else
                previousTicketBtn.Show();
        }

        private void setToolTip(int RowIndex)
        {
            if (sale == null)
                return;
            int packagesToReturn = this.sale.getAmountOfPendingPackagesToReturn(this.dataGridView2.Rows[RowIndex].Cells["barcode"].Value.ToString());
            string str = packagesToReturn == 1 ? string.Format("Pendientes {0} envase por retornar", (object)packagesToReturn) : string.Format("Pendientes {0} envases por retornar", (object)packagesToReturn);
            this.ReturnPackagesBtn.Enabled = true;
            this.dataGridView2.Rows[RowIndex].Cells["description"].ToolTipText = str;
            this.dataGridView2.Rows[RowIndex].Cells["brand"].ToolTipText = str;
            this.dataGridView2.Rows[RowIndex].Cells["amount"].ToolTipText = str;
            this.dataGridView2.Rows[RowIndex].Cells["UnitCost"].ToolTipText = str;
            this.dataGridView2.Rows[RowIndex].Cells["Total"].ToolTipText = str;
        }

        private void ShowImage(string barcode)
        {
            Bitmap bmp = (Bitmap)new Producto(barcode).image;
            this.pictureBox1.Image = bmp;
        }


        private void subtractOneProduct()
        {
            if (dataGridView2.CurrentRow == null)
                return;

            int index = dataGridView2.SelectedRows[0].Index;

            var barcode = dataGridView2.CurrentRow.Cells["barcode"].Value.ToString();

            if (barcode != null && barcode != "" && barcode.IndexOf("promo(") == -1)
            {
                Producto producto = new Producto(barcode);

                if (getAmountOfSinglePieces(this.dataGridView2.Rows[index].Cells["amount"].Value.ToString(), producto) - 1 <= 0.0)
                {
                    this.dataGridView2.Rows.Remove(this.dataGridView2.Rows[index]);

                    totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
                    countProducts();
                    return;
                }

                else
                {
                    addProductToDataGrid(producto, -1.0, Convert.ToInt32(dataGridView2.Rows[index].Cells["depot"].Value),index);
                    dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells["description"];
                }
            }
            else
            {
                selectPromo(index);

                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (index > row.Index)
                        index = row.Index;
                }

                addPromoToGridView(getPromoIDFromRow(index), -1, index);


                if (dataGridView2.RowCount > 0 && Convert.ToDouble(dataGridView2.Rows[index].Cells["amount"].Value) <= 0)
                    for (int i = dataGridView2.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                    }
            }
        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            printDialog1.PrinterSettings.PrinterName = this.ticket.printerName;
            printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
            int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            int location = 10;

            Size size1 = ticket.printLogo(graphics, location);
            location = size1.Height == 0 ? location : location + size1.Height + 10;
            Size size2 = ticket.printHeader(graphics, location);
            location = size2.Height == 0 ? location : location + size2.Height + 10;
            Size size3 = ticket.printAddress(graphics, location);
            location = size3.Height == 0 ? location : location + size3.Height + 10;
            Size size4 = ticket.printPhone(graphics, location);
            location = size4.Height == 0 ? location : location + size4.Height + 10;
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 5;

            Venta lastSale = Venta.getLastSale();

            string str1 = "Detalle de Venta";
            Font font1 = PrinterTicket.getFont(str1, width - 10, FontStyle.Regular);
            Size stringSize1 = PrinterTicket.getStringSize(str1, font1);
            graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)location);
            location = location + (15 + stringSize1.Height);

            string str2 = string.Format("Folio: {0}", (object)lastSale.ID.ToString("X"));
            Font font2 = new Font("Times new Roman", 8f);
            Size stringSize2 = PrinterTicket.getStringSize(str2, font2);

            if (stringSize2.Width + 10 < width)
            {
                graphics.DrawString(str2, font2, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }
            else
            {
                font2 = PrinterTicket.getFont(str2, width - 10, FontStyle.Bold);
                stringSize2 = PrinterTicket.getStringSize(str2, font2);
                graphics.DrawString(str2, font2, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }

            if (customer.ID != 0)
            {
                Size stringSize3 = PrinterTicket.getStringSize("Cliente: " + customer.Name, font2);
                graphics.DrawString("Cliente: " + customer.Name, font2, Brushes.Black, 10f, (float)location);
                location += stringSize3.Height + 10;
            }

            string str3 = string.Format("Fecha: {0}\t{1}", lastSale.Date.ToShortDateString(), lastSale.Date.ToShortTimeString());
            Font font3 = new Font("Times new Roman", 8f);

            if (PrinterTicket.getStringSize(str3, font3).Width + 10 < width)
            {
                graphics.DrawString(str3, font3, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }
            else
            {
                font2 = PrinterTicket.getFont(lastSale.ID.ToString(), width - 10, FontStyle.Bold);
                stringSize2 = PrinterTicket.getStringSize(lastSale.ID.ToString(), font2);
                graphics.DrawString(lastSale.ID.ToString(), font2, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }

            DataTable getSoldProducts = lastSale.getSoldProducts;
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 1;

            string text = "Cantidad\tPrecio\tImporte";
            Font font4 = font2;
            Size stringSize4 = PrinterTicket.getStringSize(text, font4);

            graphics.DrawString("Cantidad", font4, Brushes.Black, 10f, (float)location);
            graphics.DrawString("Precio", font4, Brushes.Black, ((width - PrinterTicket.getStringSize("Precio", font4).Width) / 2), location);
            graphics.DrawString("Importe", font4, Brushes.Black, (width - PrinterTicket.getStringSize("Importe", font4).Width), location);

            location = location + (stringSize4.Height + 1);
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 2;

            double num9 = 0.0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                var barcode = row.Cells["barcode"].Value.ToString();
                if (barcode != "")
                {
                    string str4 = "";
                    if (barcode.IndexOf("promo(") == -1)
                    {
                        str4 = new Producto(barcode).HideInTicket ? "Artículo Varios" : string.Format("{0}, {1}", row.Cells["description"].Value, row.Cells["brand"].Value);

                    }
                    else if (barcode.IndexOf("promo(") > -1)
                    {
                        DataSet table = Producto.getPromo(getPromoIDFromRow(row.Index));

                        string description = string.Format("Promoción: ");

                        foreach (DataRow childRow in table.Tables[1].Rows)
                        {
                            description += Convert.ToDouble(childRow["amount"]).ToString() + " " + childRow["producto"].ToString().
                                Substring(0, childRow["producto"].ToString().LastIndexOf(",")) + ", ";
                        }

                        str4 = description.Substring(0, description.Length - 2);
                    }

                    Font font5 = new Font(font4, FontStyle.Regular);
                    Size stringSize3 = PrinterTicket.getStringSize(str4, font5);
                    if (stringSize3.Width > width)
                    {
                        int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(str4, font5, width);
                        str4 = str4.Insert(letterByMeasuring, str4[letterByMeasuring] == ' ' ? "\n" : "-\n");
                        stringSize3 = PrinterTicket.getStringSize(str4, font5);
                    }
                    graphics.DrawString(str4, font5, Brushes.Black, 10f, location);
                    location += stringSize3.Height + 2;
                    getDiscountFromRow(row.Index);
                    string.Format("{0}\t{1}\t{2}", row.Cells["amount"].Value, row.Cells["UnitCost"].Value, getTotalFromRowWithoutDiscount(row.Index).ToString("n2"));
                    Font font6 = font5;
                    Size stringSize5 = PrinterTicket.getStringSize("$" + row.Cells["Total"].Value.ToString(), font6);
                    graphics.DrawString(row.Cells["amount"].Value.ToString(), font6, Brushes.Black, 10f, (float)location);
                    graphics.DrawString("$" + row.Cells["UnitCost"].Value.ToString(), font6, Brushes.Black, (float)((width - PrinterTicket.getStringSize(row.Cells["UnitCost"].Value.ToString(), font6).Width) / 2), (float)location);
                    graphics.DrawString("$" + row.Cells["Total"].Value.ToString(), font6, Brushes.Black, (float)(width - PrinterTicket.getStringSize(row.Cells["Total"].Value.ToString(), font6).Width), (float)location);
                    num9 += getDiscountFromRow(row.Index);
                    location += stringSize5.Height + 5;
                }
            }
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            int num10 = location + 3;
            string str5 = string.Format("Total: ${0}", GetTotal().ToString("n2"));
            Font font7 = font2;
            Size stringSize6 = PrinterTicket.getStringSize(str5, font4);
            graphics.DrawString(str5, font7, Brushes.Black, (width - stringSize6.Width), num10);
            int num11 = num10 + (stringSize6.Height + 3);
            if (!lastSale.isPaid)
            {
                string str4 = string.Format("Usted pagó: ${0}", lastSale.Payment);
                Size stringSize3 = PrinterTicket.getStringSize(str4, font7);
                graphics.DrawString(str4, font7, Brushes.Black, (width - stringSize3.Width), num11);
                num11 += stringSize3.Height + 3;
            }
            string str6 = string.Format("Efectivo: ${0}", lastSale.Cash);
            Size stringSize7 = PrinterTicket.getStringSize(str6, font7);
            graphics.DrawString(str6, font7, Brushes.Black, (width - stringSize7.Width), num11);
            int num12 = num11 + (stringSize7.Height + 3);
            string str7 = string.Format("Cambio: ${0}", (lastSale.Cash - lastSale.Payment));
            Size stringSize8 = PrinterTicket.getStringSize(str7, font7);
            graphics.DrawString(str7, font7, Brushes.Black, (width - stringSize8.Width), num12);
            int y5 = num12 + (3 + stringSize8.Height);
            if (num9 > 0.0)
            {
                string str4 = string.Format("Usted ahorró: ${0}", num9.ToString("n2"));
                PrinterTicket.getFont(str4, width / 2 - 10, FontStyle.Bold);
                Size stringSize3 = PrinterTicket.getStringSize(str4, font7);
                graphics.DrawString(str4, font7, Brushes.Black, (width - stringSize3.Width), y5);
                y5 += stringSize3.Height + 20;
            }
            Size size5 = ticket.printFooter(graphics, y5);
            int y6 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
            Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(lastSale.ID.ToString("X8"), 50);
            graphics.DrawImage(image, (width - ((int)(width * 0.75))) / 2, y6, (int)(width * 0.75), 40);

            y6 += 30 + 30;
            graphics.DrawLine(Pens.White, new Point(0, y6), new Point(width, y6));


        }

        private void customerPaymentDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
        }

        private double getTotalFromRowWithoutDiscount(int rowIndex)
        {
            if (this.dataGridView2.Rows.Count <= rowIndex)
                return 0.0;
            string str = this.dataGridView2.Rows[rowIndex].Cells["Total"].Value.ToString();
            return Convert.ToDouble(str.Substring(0, str.IndexOf(".") + 3));
        }

        private Font getFont(string text, int width, FontStyle style = FontStyle.Bold)
        {
            int num1 = 25;
            Font font1 = new Font("Times new roman", (float)num1, style);
            Size stringSize = this.getStringSize(text, font1);
            if (stringSize.Width > width)
            {
                int num2 = 0;
                Font font2;
                for (; stringSize.Width > width; stringSize = this.getStringSize(text, font2))
                {
                    num2 += 2;
                    font2 = new Font("Times new roman", (float)(num1 - num2), style);
                }
                font1 = new Font("Times new roman", (float)(num1 - num2), style);
            }
            else if (stringSize.Width < width)
            {
                int num2 = 0;
                Font font2;
                for (; stringSize.Width < width; stringSize = this.getStringSize(text, font2))
                {
                    num2 += 2;
                    font2 = new Font("Times new roman", (float)(num1 + num2), style);
                }
                font1 = new Font("Times new roman", (float)(num1 + num2), style);
            }
            return font1;
        }

        private Size getStringSize(string text, Font font)
        {
            return TextRenderer.MeasureText(text, font);
        }

        private int getLastLetterByMeasuring(string text, Font font, int paperWidth)
        {
            int num = -1;
            for (int index = 0; index < text.Length; ++index)
            {
                if (this.getStringSize(text.Substring(0, index + 1), font).Width >= paperWidth)
                {
                    num = index - 1 < 0 ? 0 : index - 1;
                    break;
                }
            }
            return num;
        }

        private void ProductTxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void ProductTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode != Keys.Return)
            {
                this.ProductTxt.Text += new KeysConverter().ConvertToString((object)e.KeyCode);
                this.ProductTxt.SelectionStart = this.ProductTxt.Text.Length;
            }
            if (e.KeyCode != Keys.Return)
                return;
            int num = e.Control ? 1 : 0;
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            if (!this.CanceledLbl.Visible)
                return;
            this.CanceledLbl.Visible = false;
            this.CanceledLbl.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.closeWindow();
        }

        private void closeWindow()
        {
            if (this.dataGridView2.RowCount > 0 && MessageBox.Show("¿Desea cerrar la ventana?. Se perderá la infomación.", "Cerrar ventana", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            this.Close();
        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (dataGridView2.RowCount > 1)
            {
                if (keyData == Keys.Down)
                {
                    try
                    {
                        dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = false;
                        dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex + 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
                        dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = true;
                    }
                    catch (ArgumentOutOfRangeException) { dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = true; }
                }
                else if (keyData == Keys.Up)
                {
                    try
                    {
                        dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = false;
                        dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex - 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
                        dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = true;
                    }
                    catch (ArgumentOutOfRangeException) { dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = true; }
                }
            }
            if (keyData == (Keys.Alt | Keys.Add))
            {
                if (dataGridView2.RowCount > 0)
                {
                    addOneMoreProduct();
                    return true;
                }
            }

            if (keyData == (Keys.Alt | Keys.Subtract))
            {
                if (dataGridView2.RowCount > 0)
                {
                    subtractOneProduct();
                    return true;
                }
            }

            if (keyData == (Keys.Alt | Keys.Delete))
            {
                if (dataGridView2.RowCount > 0)
                {
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

                }

                totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
                countProducts();
            }

            if (keyData == (Keys.Alt | Keys.C))
            {
                if (dataGridView2.RowCount > 0)
                {
                    CobrarBtn_Click(this, null);
                }
            }

            if (keyData == (Keys.Alt | Keys.I))
                checkBox1.Checked = !checkBox1.Checked;

            if (keyData == (Keys.N | Keys.Alt))
            {
                this.openNewWindow();
                return true;
            }
            if(keyData == (Keys.Alt|Keys.O))
            {
                openCashDrawer();
                return true;
            }

            if (keyData != (Keys.F4 | Keys.Alt))
                return base.ProcessCmdKey(ref msg, keyData);
            this.closeWindow();
            return true;
        }

        private void openNewWindow()
        {
            Panel_Ventas panel = new Panel_Ventas(this.EmployeeID, FormWindowState.Maximized);
            Thread thread = new Thread(() => panel.ShowDialog());
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.openNewWindow();
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
            PanelVentas_SaleDiscount ventasSaleDiscount = new PanelVentas_SaleDiscount(this.generalDiscount, this.isDiscountbyPercentage);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (ventasSaleDiscount.ShowDialog() == DialogResult.OK)
            {
                this.generalDiscount = ventasSaleDiscount.discount;
                this.isDiscountbyPercentage = ventasSaleDiscount.isPercentage;
                this.reassignCosts();
            }
            darkForm.Close();
        }

        private void packageReturnedDocument_PrintPage_1(object sender, PrintPageEventArgs e)
        {
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            ClearSale();
        }

        private void discountList_MouseHover(object sender, EventArgs e)
        {
            var font = discountList.Font;
            discountList.Font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
        }

        private void discountList_MouseLeave(object sender, EventArgs e)
        {
            var font = discountList.Font;
            discountList.Font = new Font(font.FontFamily, font.Size, FontStyle.Regular);
        }

        private void discountList_Click(object sender, EventArgs e)
        {
            DarkForm dk = new DarkForm();
            panel_ventas_select_promo promo = new panel_ventas_select_promo();

            dk.Show();
            if (promo.ShowDialog() == DialogResult.OK)
            {
                ProductTxt.Text = string.Format("Promo({0}) * 1", promo.choosenPromo);
                ProductTxt.Focus();
            }

            dk.Close();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (cashDrawer != null)
            {
                try
                {
                    //Cancel the device
                    cashDrawer.DeviceEnabled = false;

                    //Release the device exclusive control right.
                    cashDrawer.Release();
                    //Finish using the device.
                    cashDrawer.Close();

                }
                catch (PosControlException)
                {
                }
            }
            if (printer != null)
            {
                try
                {
                    //Cancel the device
                    printer.DeviceEnabled = false;

                    //Release the device exclusive control right.
                    printer.Release();
                    //Finish using the device.
                    printer.Close();

                }
                catch (PosControlException)
                {
                }
            }
            try
            {
                dataGridView2.Columns.Remove(dataGridView2.Columns["Depot"]);
                dataGridView2.Dispose();
                pictureBox1.Dispose();
            }
            catch (Exception) { }
           

            if(File.Exists(this.Name+".bmp"))
            {
                File.Delete(this.Name + ".bmp");
            }
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView2.RowCount == 0)
            {
                pictureBox1.Image = null;
            }
        }

        private void printTicketBtn_Click(object sender, EventArgs e)
        {/*
            try
            {
                this.reprintTicket.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                this.printDialog1.Document = this.reprintTicket;
                this.reprintTicket.Print();
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }

            reprintTicket = new PrintDocument();
            reprintTicket.PrintController = new StandardPrintController();
            reprintTicket.PrintPage += new PrintPageEventHandler(reprintTicket_PrintPage);*/
            printTicket(sale.ID);
        }

        private void reprintTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            printDialog1.PrinterSettings.PrinterName = this.ticket.printerName;
            printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
            int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            int location = 10;

            Size size1 = ticket.printLogo(graphics, location);
            location = size1.Height == 0 ? location : location + size1.Height + 10;
            Size size2 = ticket.printHeader(graphics, location);
            location = size2.Height == 0 ? location : location + size2.Height + 10;
            Size size3 = ticket.printAddress(graphics, location);
            location = size3.Height == 0 ? location : location + size3.Height + 10;
            Size size4 = ticket.printPhone(graphics, location);
            location = size4.Height == 0 ? location : location + size4.Height + 10;
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 5;

            Venta lastSale = sale;

            string str1 = "Detalle de Venta";
            Font font1 = PrinterTicket.getFont(str1, width - 10, FontStyle.Regular);
            Size stringSize1 = PrinterTicket.getStringSize(str1, font1);
            graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)location);
            location = location + (15 + stringSize1.Height);

            string str2 = string.Format("Folio: {0}", (object)lastSale.ID.ToString("X"));
            Font font2 = new Font("Times new Roman", 8f);
            Size stringSize2 = PrinterTicket.getStringSize(str2, font2);

            if (stringSize2.Width + 10 < width)
            {
                graphics.DrawString(str2, font2, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }
            else
            {
                font2 = PrinterTicket.getFont(str2, width - 10, FontStyle.Bold);
                stringSize2 = PrinterTicket.getStringSize(str2, font2);
                graphics.DrawString(str2, font2, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }

            if (customer.ID != 0)
            {
                Size stringSize3 = PrinterTicket.getStringSize("Cliente: " + customer.Name, font2);
                graphics.DrawString("Cliente: " + customer.Name, font2, Brushes.Black, 10f, (float)location);
                location += stringSize3.Height + 10;
            }

            string str3 = string.Format("Fecha: {0}\t{1}", lastSale.Date.ToShortDateString(), lastSale.Date.ToShortTimeString());
            Font font3 = new Font("Times new Roman", 8f);

            if (PrinterTicket.getStringSize(str3, font3).Width + 10 < width)
            {
                graphics.DrawString(str3, font3, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }
            else
            {
                font2 = PrinterTicket.getFont(lastSale.ID.ToString(), width - 10, FontStyle.Bold);
                stringSize2 = PrinterTicket.getStringSize(lastSale.ID.ToString(), font2);
                graphics.DrawString(lastSale.ID.ToString(), font2, Brushes.Black, 10f, (float)location);
                location = location + (stringSize2.Height + 1);
            }

            DataTable getSoldProducts = lastSale.getSoldProducts;
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 1;

            string text = "Cantidad\tPrecio\tImporte";
            Font font4 = font2;
            Size stringSize4 = PrinterTicket.getStringSize(text, font4);

            graphics.DrawString("Cantidad", font4, Brushes.Black, 10f, (float)location);
            graphics.DrawString("Precio", font4, Brushes.Black, ((width - PrinterTicket.getStringSize("Precio", font4).Width) / 2), location);
            graphics.DrawString("Importe", font4, Brushes.Black, (width - PrinterTicket.getStringSize("Importe", font4).Width), location);

            location = location + (stringSize4.Height + 1);
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 2;

            double num9 = 0.0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                var barcode = row.Cells["barcode"].Value.ToString();
                if (barcode != "")
                {
                    string str4 = "";
                    if (barcode.IndexOf("promo(") == -1)
                    {
                        str4 = new Producto(barcode).HideInTicket ? "Artículo Varios" : string.Format("{0}, {1}", row.Cells["description"].Value, row.Cells["brand"].Value);

                    }
                    else if (barcode.IndexOf("promo(") > -1)
                    {
                        DataSet table = Producto.getPromo(getPromoIDFromRow(row.Index));

                        string description = string.Format("Promoción: ");

                        foreach (DataRow childRow in table.Tables[1].Rows)
                        {
                            description += Convert.ToDouble(childRow["amount"]).ToString() + " " + childRow["producto"].ToString().
                                Substring(0, childRow["producto"].ToString().LastIndexOf(",")) + ", ";
                        }

                        str4 = description.Substring(0, description.Length - 2);
                    }

                    Font font5 = new Font(font4, FontStyle.Regular);
                    Size stringSize3 = PrinterTicket.getStringSize(str4, font5);
                    if (stringSize3.Width > width)
                    {
                        int letterByMeasuring = PrinterTicket.getLastLetterByMeasuring(str4, font5, width);
                        str4 = str4.Insert(letterByMeasuring, str4[letterByMeasuring] == ' ' ? "\n" : "-\n");
                        stringSize3 = PrinterTicket.getStringSize(str4, font5);
                    }
                    graphics.DrawString(str4, font5, Brushes.Black, 10f, location);
                    location += stringSize3.Height + 2;
                    getDiscountFromRow(row.Index);
                    string.Format("{0}\t{1}\t{2}", row.Cells["amount"].Value, row.Cells["UnitCost"].Value, getTotalFromRowWithoutDiscount(row.Index).ToString("n2"));
                    Font font6 = font5;
                    Size stringSize5 = PrinterTicket.getStringSize("$" + row.Cells["Total"].Value.ToString(), font6);
                    graphics.DrawString(row.Cells["amount"].Value.ToString(), font6, Brushes.Black, 10f, (float)location);
                    graphics.DrawString("$" + row.Cells["UnitCost"].Value.ToString(), font6, Brushes.Black, (float)((width - PrinterTicket.getStringSize(row.Cells["UnitCost"].Value.ToString(), font6).Width) / 2), (float)location);
                    graphics.DrawString("$" + row.Cells["Total"].Value.ToString(), font6, Brushes.Black, (float)(width - PrinterTicket.getStringSize(row.Cells["Total"].Value.ToString(), font6).Width), (float)location);
                    num9 += getDiscountFromRow(row.Index);
                    location += stringSize5.Height + 5;
                }
            }
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            int num10 = location + 3;
            string str5 = string.Format("Total: ${0}", GetTotal().ToString("n2"));
            Font font7 = font2;
            Size stringSize6 = PrinterTicket.getStringSize(str5, font4);
            graphics.DrawString(str5, font7, Brushes.Black, (width - stringSize6.Width), num10);
            int num11 = num10 + (stringSize6.Height + 3);
            if (!lastSale.isPaid)
            {
                string str4 = string.Format("Usted pagó: ${0}", lastSale.Payment);
                Size stringSize3 = PrinterTicket.getStringSize(str4, font7);
                graphics.DrawString(str4, font7, Brushes.Black, (width - stringSize3.Width), num11);
                num11 += stringSize3.Height + 3;
            }
            string str6 = string.Format("Efectivo: ${0}", lastSale.Cash);
            Size stringSize7 = PrinterTicket.getStringSize(str6, font7);
            graphics.DrawString(str6, font7, Brushes.Black, (width - stringSize7.Width), num11);
            int num12 = num11 + (stringSize7.Height + 3);
            string str7 = string.Format("Cambio: ${0}", (lastSale.Cash - lastSale.Payment));
            Size stringSize8 = PrinterTicket.getStringSize(str7, font7);
            graphics.DrawString(str7, font7, Brushes.Black, (width - stringSize8.Width), num12);
            int y5 = num12 + (3 + stringSize8.Height);
            if (num9 > 0.0)
            {
                string str4 = string.Format("Usted ahorró: ${0}", num9.ToString("n2"));
                PrinterTicket.getFont(str4, width / 2 - 10, FontStyle.Bold);
                Size stringSize3 = PrinterTicket.getStringSize(str4, font7);
                graphics.DrawString(str4, font7, Brushes.Black, (width - stringSize3.Width), y5);
                y5 += stringSize3.Height + 20;
            }
            Size size5 = ticket.printFooter(graphics, y5);
            int y6 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
            Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(lastSale.ID.ToString("X8"), 50);
            graphics.DrawImage(image, (width - ((int)(width * 0.75))) / 2, y6, (int)(width * 0.75), 40);

            y6 += 30 + 30;
            graphics.DrawLine(Pens.White, new Point(0, y6), new Point(width, y6));

        }

        private void EmployeeNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void saleCancelledDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void previousTicketBtn_MouseHover(object sender, EventArgs e)
        {
            var font = previousTicketBtn.Font;
            previousTicketBtn.Font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
        }

        private void previousTicketBtn_MouseLeave(object sender, EventArgs e)
        {
            var font = previousTicketBtn.Font;
            previousTicketBtn.Font = new Font(font.FontFamily, font.Size, FontStyle.Regular);
        }

        private void nextTicketBtn_MouseHover(object sender, EventArgs e)
        {
            var font = nextTicketBtn.Font;
            nextTicketBtn.Font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
        }

        private void nextTicketBtn_MouseLeave(object sender, EventArgs e)
        {
            var font = nextTicketBtn.Font;
            nextTicketBtn.Font = new Font(font.FontFamily, font.Size, FontStyle.Regular);
        }

        private void nextTicketBtn_Click(object sender, EventArgs e)
        {
            var data = sale.getNextSaleID();

            if (data.Tables[1].Rows.Count > 0)
                setSale(Convert.ToInt32(data.Tables[1].Rows[0][0]));
        }

        private void previousTicketBtn_Click(object sender, EventArgs e)
        {
            var data = sale.getNextSaleID();

            if (data.Tables[0].Rows.Count > 0)
                setSale(Convert.ToInt32(data.Tables[0].Rows[0][0]));
        }
    }
}