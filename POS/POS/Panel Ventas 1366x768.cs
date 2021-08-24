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
using System.Linq;

namespace POS
{
    public partial class Panel_Ventas_1366x768 : Form
    {
        private delegate void hideButtonDelegate(int employeeID);
        private Size customerGroupBoxMaxSize = new Size(327, 186);
        private Size customerGroupBoxMinSize = new Size(327, 89);
        private Size pictureBoxMinSize = new Size(200, 174);
        private Size pictureBoxMaxSize = new Size(253, 219);
        private const int maximumDaysForRefound = 10000;
        private const int maximumDaysForRetourningPackages = 10000;
        private bool isNewSale;
        private int EmployeeID;
        private string defaultTxt;
        private Cliente customer;
        private Venta sale;
        private PrinterTicket ticket;
        private double generalDiscount;
        private bool isDiscountbyPercentage;
        private bool editingRow;
        private static int windowCount = 0;

        CashDrawer cashDrawer = null;
        PosPrinter printer = null;
        ToolTip[] ShortcutTips = null;
        Control[] controlsShortcuts = null;

        int printedPart = 0;
        int pagecount = 0;
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
                else // cell value has the format "N pieces"
                    totalAmountOfPieces = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf(".") + 3));

                dataGridView2.Rows[rowIndex].Cells["amount"].Value = amountFormat(p, totalAmountOfPieces + quantity);
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = getCost(p, rowIndex, Convert.ToDouble(dataGridView2.Rows[rowIndex].Cells["UnitCost"].Value));
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
                if (row.Cells["barcode"].Value != null)
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
                            x += dataGridView2.RowCount > 0 ? (int)Math.Ceiling(getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), p)) :
                            0;
                        }
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

            Tuple<int, double> tuple = Producto.getCasesAndSingleProducts(p, amount);

            int cases = tuple.Item1;
            double singlePieces = tuple.Item2;

            double newDisc = 0;

            if (discount > 0)
            {
                newDisc = validateDiscount(discount, p, amount);
            }
            else
            {
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

                totalDiscount = totalDiscount > genDiscount ? totalDiscount : genDiscount;


                if (caseDiscount > 0)
                    totalDiscount = caseDiscount;
                else
                {
                    if (customerDiscount > generalDiscount)
                        totalDiscount = customerDiscount;
                    else
                        totalDiscount = genDiscount;
                }


                newDisc = validateDiscount(discount + totalDiscount, p, amount);
            }
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

        private string getCost(Producto product, int rowIndex, double retailCost = -1)
        {

            double amount = getAmountOfSinglePieces(dataGridView2.Rows[rowIndex].Cells["amount"].Value.ToString(), product);
            Tuple<int, double> tuple = Producto.getCasesAndSingleProducts(product, amount);

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

            double totalDiscount = 0;// = customerDiscount + caseDiscount + mixedCaseDiscount + genDiscount;

            if (wholesaleDiscount > 0)
            {
                totalDiscount = mixedCaseDiscount > 0 ? mixedCaseDiscount : wholesaleDiscount;
                (dataGridView2.Rows[rowIndex].Cells["WholesaleDiscountApplied"] as DataGridViewCheckBoxCell).Value = true;
            }
            else
            {
                if (caseDiscount > 0)
                    totalDiscount = caseDiscount + mixedCaseDiscount;

                else
                {
                    if (customerDiscount > 0)
                        totalDiscount = customerDiscount + mixedCaseDiscount;

                    else if (mixedCaseDiscount == 0)
                        totalDiscount = genDiscount;
                    else
                        totalDiscount = mixedCaseDiscount;
                }

                (dataGridView2.Rows[rowIndex].Cells["WholesaleDiscountApplied"] as DataGridViewCheckBoxCell).Value = false;
            }

            if (retailCost == -1)
                totalDiscount = validateDiscount(totalDiscount, product, amount);

            ///if there still a discount then show it in the table as the format -> "$100.00 \n -$15.00"
            ///otherwise show just the total
            if (totalDiscount > 0.0)
            {
                string newLine = Environment.NewLine;

                if (retailCost == -1)
                    return string.Format("{0}{1}-{2}", (product.RetailCost * amount).ToString("n2"), newLine, totalDiscount.ToString("n2"));
                else
                    return string.Format("{0}{1}-{2}", (retailCost * amount).ToString("n2"), newLine, totalDiscount.ToString("n2"));
            }
            else
            {
                if (retailCost == -1)
                    return (product.RetailCost * amount).ToString("n2");
                else
                    return (retailCost * amount).ToString("n2");
            }
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
            // Dictionary<string, Tuple<int, double, double>> values = new Dictionary<string, Tuple<int, double, double>>();

            //Dictionary<barcode,tuple<rowindex,amount,accumulated amount>
            Dictionary<int, Tuple<string, double, double>> valuesx = new Dictionary<int, Tuple<string, double, double>>();


            double discount = 0;
            double countOfTotalPices = 0;

            //sweep the listed products to find mixed cases coincidences
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                var row = /*i != rowIndex ? */dataGridView2.Rows[i]/* : dataGridView2.Rows[rowIndex]*/;
                Producto p = i != rowIndex ? new Producto(row.Cells["barcode"].Value.ToString()) :
                     product;

                var productPieces = getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), p);
                var casesNsingle = Producto.getCasesAndSingleProducts(p, productPieces);

                //if the current product has the same mixed case groud id then add it to the dictionary
                if (product.mixedCaseGroup == p.mixedCaseGroup)
                {
                    if (casesNsingle.Item2 > 0)
                        countOfTotalPices += casesNsingle.Item2;


                    //  values.Add(p.Barcode, new Tuple<int, double, double>(i, casesNsingle.Item2, countOfTotalPices));
                    valuesx.Add(i, new Tuple<string, double, double>(p.Barcode, casesNsingle.Item2, countOfTotalPices));

                }
            }

            var wholedisc = getWholeSaleDiscountPerPiece(product, countOfTotalPices);

            //When there is an applicable wholesale discount
            if (wholedisc > 0)
            {

                discount = wholedisc *
                    getAmountOfSinglePieces(dataGridView2.Rows[rowIndex].Cells["amount"].Value.ToString(), product);

                valuesx.Remove(rowIndex);

                // foreach (KeyValuePair<string, Tuple<int, double, double>> item in values)
                foreach (KeyValuePair<int, Tuple<string, double, double>> item in valuesx)
                {
                    var p = new Producto(item.Value.Item1);

                    addDiscountToRow(item.Key, wholedisc *
                        getAmountOfSinglePieces(dataGridView2.Rows[item.Key].Cells["amount"].Value.ToString(), p)); //pay attention to this
                    (dataGridView2.Rows[item.Key].Cells["WholesaleDiscountApplied"] as DataGridViewCheckBoxCell).Value = true;
                }
            }


            //Enters in this section when the given product has at least one single piece and when there are products that, when groupped altogether, conform at least one case
            else if (valuesx.ContainsKey(rowIndex) && countOfTotalPices / product.PiecesPerCase >= 1 && !Convert.ToBoolean(dataGridView2.Rows[rowIndex].Cells["WholesaleDiscountApplied"].Value))
            {
                int cases = Producto.getCasesAndSingleProducts(product, countOfTotalPices).Item1;

                double piecesWithDiscount = Math.Truncate(valuesx[rowIndex].Item3 / product.PiecesPerCase) < cases ?
                    valuesx[rowIndex].Item2 :
                    valuesx[rowIndex].Item2 - valuesx[rowIndex].Item3 % product.PiecesPerCase;

                discount = product.RetailCost * piecesWithDiscount -
                    piecesWithDiscount * product.CostPerCase / product.PiecesPerCase;

                discount = discount < 0 ? 0 : discount;

                valuesx.Remove(rowIndex);


                foreach (KeyValuePair<int, Tuple<string, double, double>> item in valuesx)
                {
                    Producto p = new Producto(item.Value.Item1);

                    piecesWithDiscount = Math.Truncate(item.Value.Item3 / product.PiecesPerCase) < cases ?
                    item.Value.Item2 :
                    item.Value.Item2 - item.Value.Item3 % product.PiecesPerCase;

                    double disc = p.RetailCost * piecesWithDiscount -
                     piecesWithDiscount * p.CostPerCase / p.PiecesPerCase;

                    addDiscountToRow(item.Key, disc);
                }
            }
            else
            {
                valuesx.Remove(rowIndex);

                foreach (KeyValuePair<int, Tuple<string, double, double>> item in valuesx)
                {
                    addDiscountToRow(item.Key, 0);
                }
            }
            return discount;
        }

        private double getWholeSaleDiscountPerPiece(Producto product, double countOfTotalPices)
        {
            return countOfTotalPices > 0 ? product.GetWholesaleDiscount(countOfTotalPices) / countOfTotalPices : 0;


        }

        private string amountFormat(Producto producto, double amount)
        {
            Tuple<int, double> tuple = Producto.getCasesAndSingleProducts(producto, amount);
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

        private async void CancelSaleBtn_Click(object sender, EventArgs e)
        {
            CancelSaleBtn.Enabled = false;
            if (this.sale != null) //&& this.sale.Date > DateTime.Now.AddDays(-2.0))
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
                try
                {
                    if (printer != null)
                        openCashDrawer();
                    else
                        printNothing();
                }
                catch (Exception)
                {
                    if (printer.State != ControlState.Closed)
                    {
                        try
                        {
                            cashDrawer.Release();
                        }
                        catch (PosControlException) { }
                    }

                    printNothing();
                }


                double MoneyToBeRefounded = 0;

                if (cancelWholeSale)
                {
                    sale.Cancel(EmployeeID);
                    double alreadyReturned = 0;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        var refound = row.Cells["refound"];
                        if (refound.ReadOnly)
                            alreadyReturned += getTotalFromRow(row.Index);
                    }

                    MoneyToBeRefounded = (double)sale.Total - alreadyReturned > (double)sale.Payment ? (double)sale.Payment : (double)sale.Total - alreadyReturned;
                }

                else
                {
                    DataTable barcodesToBeRefounded = getRefoundedProduct();
                    sale.RefoundProductsToCustomer(barcodesToBeRefounded);

                    int totalOfRefoundedProducts = 0;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        var refound = row.Cells["refound"];
                        if (Convert.ToBoolean(refound.Value))
                            totalOfRefoundedProducts++;
                    }


                    if (totalOfRefoundedProducts == sale.getSoldProducts.Rows.Count)
                        await Task.Run(() => sale.Cancel(EmployeeID));


                    MoneyToBeRefounded = calculateRefound();
                }

                setSale(sale.ID);
                FormCambio formCambio = new FormCambio(/*(double)(sale.Payment - num1)*/MoneyToBeRefounded);
                formCambio.ShowDialog();
            }
            else
            {
                MessageBox.Show(string.Format("La compra excede el lapso permitido de {0} días para realizar la devolución.\n\nFecha de la venta: {1} de {2} del {3}", (object)2, (object)this.sale.Date.Day, (object)new CultureInfo("es-MX").DateTimeFormat.GetMonthName(this.sale.Date.Month), (object)this.sale.Date.Year), "No se puede cancelar");
            }
            CancelSaleBtn.Enabled = true;
        }

        private void printNothing()
        {
            try
            {
                var document = new PrintDocument() { PrintController = new StandardPrintController() };
                printDialog1.Document = document;
                document.Print();
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("No se encontró la impreora");
            }
            catch (AccessViolationException)
            {
                var document = new PrintDocument();
                printDialog1.Document = document;
                document.Print();
            }

        }

        private double calculateRefound()
        {
            double MoneyToBeRefounded = 0;
            double alreadyReturned = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                var refound = row.Cells["refound"];
                if (refound.ReadOnly && Convert.ToBoolean(refound.Value))
                    alreadyReturned += getTotalFromRow(row.Index);

                else if (!refound.ReadOnly && Convert.ToBoolean(refound.Value))
                    MoneyToBeRefounded += getTotalFromRow(row.Index);
            }

            var alreadyRefound = (double)sale.Payment - ((double)sale.Total - alreadyReturned);
            alreadyRefound = alreadyRefound > 0 ? alreadyRefound : 0;
            MoneyToBeRefounded = (double)sale.Payment - ((double)sale.Total - alreadyReturned - MoneyToBeRefounded) - alreadyRefound;

            return MoneyToBeRefounded > 0 ? MoneyToBeRefounded : 0;
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
            if (this.label1.Width + width + 6 < this.customerGroupBox.Width)
            {
                int x = (this.customerGroupBox.Width - this.label1.Width - width - 6) / 2;
                this.label1.Location = new Point(x, this.label1.Location.Y);
                this.debtLbl.Location = new Point(x + this.label1.Width + 6, this.debtLbl.Location.Y);
            }
            else
            {
                this.debtLbl.AutoSize = false;
                this.label1.Location = new Point(0, this.label1.Location.Y);
                this.debtLbl.Location = new Point(this.label1.Width + 6, this.debtLbl.Location.Y);
                this.debtLbl.Width = this.customerGroupBox.Width - this.debtLbl.Location.X;
            }
        }

        enum centerDirection
        {
            Horizontally,
            Vertically
        }

        private void centerToParent(Control control, centerDirection direction = centerDirection.Horizontally)
        {
            var parent = control.Parent;
            if (parent != null)
            {
                if (direction == centerDirection.Horizontally)
                {
                    int width = parent.Width;
                    control.Location = new Point((width - control.Width) / 2, control.Location.Y);
                }
                else
                {
                    control.Location = new Point(control.Location.X, (parent.Height - control.Height) / 2);
                }
            }
        }

        private void ClearCustomer()
        {
            this.customer = new Cliente(0);
            this.customerGroupBox.Size = this.customerGroupBoxMinSize;
            panel10.Size = new Size(panel10.Width, customerGroupBox.Location.Y + customerGroupBox.Height + 10);
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
            this.sale = null;
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
            dataGridView2.RowTemplate.MinimumHeight = 2;
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
            // DarkForm darkForm = new DarkForm();
            FormPagar formPagar = new FormPagar("$" + Total.ToString("n2"), !this.customer.hasCredit, this.getCostOfReturnablePackages());
            //darkForm.Show();
            dataGridView2.EndEdit();


            if (formPagar.ShowDialog() == DialogResult.OK)
            {
                //if not shift is initiated and employee is not admin then start a new shift
                if (!Turno.shiftActive)
                    Turno.start(DateTime.Now, 0, EmployeeID);

                Venta venta = new Venta();
                double Payment = Convert.ToDouble(formPagar.Pay);
                List<Tuple<string, double, double, double, int>> list = new List<Tuple<string, double, double, double, int>>();
                string printingString = "";
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

                        if (printer != null)
                        {
                            if (!product.HideInTicket)
                                if (product.Brand.Trim() != "")
                                    printingString += "\u001b|N" + string.Format("{0}, {1}", product.Description, product.Brand) + "\n";
                                else
                                    printingString += "\u001b|N" + string.Format("{0}", product.Description) + "\n";
                            else
                                printingString += "\u001b|N" + string.Format("Productos Varios").Trim(',') + "\n";
                        }
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

                    if (printer != null)
                    {
                        printingString += "\u001b|N" + getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), new Producto(barcode)).ToString("n2");
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
                }

                long saleID = -1;
                try
                {
                    saleID = venta.newSale(this.EmployeeID, this.customer.ID, Total, Payment/* + formPagar.rest*/, list.ToArray(), Convert.ToDouble(formPagar.Cash));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La operación no se pudo completar.\n" + ex.Message);
                }
                if (saleID > 0)
                {
                    try
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            if (this.printCheckBox.Checked)
                            {
                                if (Convert.ToDouble(formPagar.Pay) > 0)
                                    openCashDrawer();
                                printTicket(saleID, printingString, discount);
                            }
                            else
                            {
                                if (Convert.ToDouble(formPagar.Pay) > 0)
                                    if (cashDrawer != null)
                                        openCashDrawer();
                                // else
                                //    printNothing();
                            }
                        }));
                    }
                    catch (System.Reflection.TargetInvocationException) { new Toast_Message("No se encontró impresora.").Show(); }
                }
                FormCambio formCambio = new FormCambio(Convert.ToDouble(formPagar.Cash) - Convert.ToDouble(formPagar.Pay));
                formCambio.ShowDialog();
                this.ClearSale();
                formCambio.Focus();
            }
            //darkForm.Close();
        }

        private void printTicket(long saleID, string products, double discount)
        {
            if (printer != null)
            {
                try
                {

                    printer.Claim(1000);
                    printer.DeviceEnabled = true;
                    printer.RecLetterQuality = true;


                    Venta lastSale = new Venta(saleID);

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

                    var change = lastSale.Cash - lastSale.Total;
                    change = change >= 0 ? change : 0;

                    text += "\u001b|rA" + "Cambio: $" + (change).ToString("n2") + "\n";

                    if (discount > 0)
                        text += "\u001b|rA" + "Usted Ahorró: " + discount.ToString("n2") + "\n";

                    text += "\n";

                    if (ticket.footerDisplay)
                        text += "\u001b|cA" + "\u001b|bC" + ticket.footer + "\n\n";

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


                catch (PosException e)
                {
                    MessageBox.Show(e.Message);
                    if (printer.State != ControlState.Closed)
                    {
                        try
                        {
                            printer.Release();
                        }
                        catch (PosControlException) { }
                    }

                    if (MessageBox.Show("Ocurrió un error al imprimir el Ticket.\n ¿Desea intentar imprimirlo nuevamente?", "Error de Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        prepareData(saleID);
                    }
                }
            }
            else
            {
                prepareData(saleID);
                // printDefaultPrinter(printDocument1);
            }

        }

        private async void prepareData(long saleID)
        {
            Venta lastSale = await Task.Run(() => new Venta(saleID));
            int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            string data;
            Font mainFont;
            var infoList = new List<Tuple<string, List<object>, bool>>();


            if (ticket.logoDisplay)
            {
                infoList.Add(new Tuple<string, List<object>, bool>("printImage",
                    new List<object>(new object[] { ticket.logo, width, ticket.logoHeight }),
                    true));
            }

            if (ticket.headderDisplay)
            {
                data = ticket.header;
                mainFont = ticket.headerFont;

                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                 new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
                 true));
            }
            if (ticket.addressDisplay)
            {
                data = ticket.address;
                mainFont = ticket.addressFont;
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
                    true));

            }

            if (ticket.phoneDisplay)
            {
                data = ticket.phone;
                mainFont = ticket.phoneFont;

                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }), true));
            }

            infoList.Add(new Tuple<string, List<object>, bool>("drawLine",
                new List<object>(new object[] { 10, width - 10 }),
                true));


            data = "Detalle de Venta";
            mainFont = new Font("Times new roman", 20f, FontStyle.Bold);

            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
                true));

            data = string.Format("Folio: {0}", lastSale.ID.ToString("X"));
            mainFont = width > 200 ? new Font("Times new Roman", 9.9f) : new Font("Times new Roman", 7f);

            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }), true));

            if (lastSale.CustomerID != 0)
            {
                data = "Cliente: " + new Cliente(lastSale.CustomerID).Name;
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }), true));
            }

            data = string.Format("Fecha: {0} {1}", lastSale.Date.ToShortDateString(), lastSale.Date.ToShortTimeString());
            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { data, mainFont, width, StringAlignment.Near })
                , true));

            infoList.Add(new Tuple<string, List<object>, bool>("drawLine",
                new List<object>(new object[] { 10, width - 10 }), true));

            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { "Cantidad", mainFont, width, StringAlignment.Near }),
                false));

            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { "Precio", mainFont, width, StringAlignment.Center }),
                false));

            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { "Importe", mainFont, width, StringAlignment.Far }),
                true));

            infoList.Add(new Tuple<string, List<object>, bool>("drawLine",
                new List<object>(new object[] { 10, width - 10 }),
                true));

            double num9 = 0.0;
            foreach (DataRow row in lastSale.getSoldProducts.Rows)
            {
                var barcode = row["id_producto"].ToString();
                if (barcode != "")
                {
                    data = Convert.ToBoolean(row["Ocultar en Ticket"]) ? "Artículo Varios" :
                        string.Format("{0}, {1}", row["Descripción"], row["Marca"]);


                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }),
                        true));

                    var dis = Convert.ToDouble(row["Descuento"]); //getDiscountFromRow(row.Index);


                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] { row["Cantidad"].ToString(), mainFont, width, StringAlignment.Near }),
                        false));

                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] { "$" + row["Precio"].ToString(), mainFont, width, StringAlignment.Center }),
                        false));

                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] { "$" + row["Importe"].ToString(), mainFont, width, StringAlignment.Far }),
                        true));



                    if (dis > 0)
                    {
                        data = string.Format("Descuento: -${0}", dis.ToString("n2")); //getDiscountFromRow(row.Index).ToString("n2"));
                        infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));

                        data = string.Format("Costo Final: ${0}", Convert.ToDouble(row["importe"]) - dis); //getTotalFromRow(row.Index).ToString("n2"));
                        infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));
                    }

                    num9 += dis;
                }
            }

            infoList.Add(new Tuple<string, List<object>, bool>("drawLine",
                new List<object>(new object[] { 10, width - 10 }),
                true));

            data = string.Format("Total: ${0}", lastSale.Total.ToString("n2"));//GetTotal().ToString("n2"));
            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));

            if (!lastSale.isPaid)
            {
                data = string.Format("Usted pagó: ${0}", lastSale.Payment);
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                    true));
            }

            data = string.Format("Efectivo: ${0}", lastSale.Cash);
            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }), true));

            data = string.Format("Cambio: ${0}", (lastSale.Cash - lastSale.Payment));
            infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                true));

            if (num9 > 0.0)
            {
                data = string.Format("Usted ahorró: ${0}", num9.ToString("n2"));
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                    true));
            }

            if (ticket.footerDisplay)
            {
                data = ticket.footer;
                mainFont = ticket.footerFont;
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                   new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
                   true));
            }

            Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(lastSale.ID.ToString("X8"), 50);
            infoList.Add(new Tuple<string, List<object>, bool>("printImage",
                new List<object>(new object[] { image, width, 40 }),
                true));


            var printdocument = new PrintDocument();
            printdocument.PrintController = new StandardPrintController();

            printdocument.PrintPage += (s, e) =>
            {
                printTicket(e.Graphics, infoList, e.PageSettings.PaperSize.Height);

                if (infoList.Count > 0)
                    e.HasMorePages = true;
            };
            printdocument.EndPrint += (s, e) => { image.Dispose(); mainFont.Dispose(); };


            try
            {
                printDialog1.Document = printdocument;
                printdocument.Print();

            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("No se encontró la impresora");
            }
            catch (Exception) { }
        }

        private void printTicket(Graphics graphics, List<Tuple<string, List<object>, bool>> infoList, int maxHeight)
        {
            Type thisType = typeof(printingClass);
            int location = 0;

            while (location < maxHeight - 5 && infoList.Count > 0)
            {
                var item = infoList[0];

                System.Reflection.MethodInfo theMethod = thisType.GetMethod(item.Item1);

                var parameters = new object[item.Item2.Count + 2];

                int i;

                for (i = 0; i < item.Item2.Count; i++)
                {
                    parameters[i] = item.Item2.ElementAt(i);
                }
                parameters[i++] = graphics;
                parameters[i] = location;

                if (item.Item3)
                    location += (int)theMethod.Invoke(this, parameters);

                else
                    theMethod.Invoke(this, parameters);

                infoList.RemoveAt(0);
            }
        }

        private void printTicket(long saleID)
        {
            Venta lastSale = new Venta(saleID);

            if (printer != null)
            {
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
                                    Thread.Sleep(1000);
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


                    var change = lastSale.Cash - lastSale.Total;
                    change = change >= 0 ? change : 0;

                    printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Cambio: $" + (change).ToString("n2") + "\n");

                    if (discount > 0)
                        printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Usted Ahorró: $" + discount.ToString("n2") + "\n");

                    printer.PrintNormal(PrinterStation.Receipt, "\n");

                    if (ticket.footerDisplay)
                        printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "\u001b|bC" + ticket.footer + "\n\n");

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
                }

                catch (PosException)
                {
                    if (printer != null && printer.State != ControlState.Closed)
                        try
                        {
                            printer.Release();
                        }
                        catch (PosControlException) { }

                    if (MessageBox.Show("Ocurrió un error al imprimir el Ticket.\n ¿Desea intentar imprimirlo nuevamente?", "Error de Impresión",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        prepareData(saleID);
                }
                catch (Exception) { prepareData(saleID); }
            }
            else
            {
                prepareData(sale.ID);
            }

        }

        private void openCashDrawer()
        {
            if (cashDrawer != null)
            {
                try
                {
                    //Get the exclusive control right for the opened device.
                    //Then the device is disable from other application.
                    cashDrawer.Claim(1000);
                    //Enable the device.
                    cashDrawer.DeviceEnabled = true;

                    //Open the drawer by using the "OpenDrawer" method.
                    if (!cashDrawer.DrawerOpened)
                        cashDrawer.OpenDrawer();

                    cashDrawer.DeviceEnabled = false;

                    cashDrawer.Release();

                }
                catch (PosControlException)
                {
                }
                catch (Exception)
                {
                    if (cashDrawer != null && cashDrawer.State != ControlState.Closed)
                        try
                        {
                            cashDrawer.Release();
                        }
                        catch (PosControlException) { }
                }
            }
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
            lookForCustomer();
        }

        private void lookForCustomer()
        {
            if (!this.isNewSale)
                return;
            PanelClientesListaClientesForm listaClientesForm = new PanelClientesListaClientesForm(this.EmployeeID);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (listaClientesForm.ShowDialog() == DialogResult.OK)
            {
                this.customer = new Cliente(listaClientesForm.IDCustomer);
                setCustomer();
            }

            darkForm.Close();
        }

        private void setCustomer()
        {
            this.CustomerBtn.ButtonText = this.customer.Name;
            this.ClearCustomerBtn.Visible = customer.ID != 0;
            this.debtLbl.Text = "$" + this.customer.Debt.ToString("n2");
            this.setCustomerDebtColor();
            this.customerGroupBox.Size = this.customerGroupBoxMaxSize;
            panel10.Size = new Size(panel10.Width, customerGroupBox.Location.Y + customerGroupBox.Height + 10);
            this.reassignCosts();
            this.CustomerPaymentBtn.Enabled = this.customer.Debt > 0.0;
        }

        private async void CustomerPaymentBtn_Click(object sender, EventArgs e)
        {
            FormPagar form = new FormPagar("$" + this.customer.Debt.ToString("n2"), false, 0.0);
            //DarkForm darkForm = new DarkForm();
            //   darkForm.Show();
            if (form.ShowDialog() == DialogResult.OK)
            {
                double customerPayment = Convert.ToDouble(form.Pay);
                double cash = Convert.ToDouble(form.Cash);
                if (customerPayment > 0.0)
                {
                    DataTable acountsReceivable = await Task.Run(() => customer.GetAcountsReceivable());
                    double change = cash <= customerPayment ? 0.0 : cash - customerPayment;
                    for (int index = 0; index < acountsReceivable.Rows.Count; ++index)
                    {
                        DataRow row = acountsReceivable.Rows[index];
                        if (customerPayment > 0.0)
                        {
                            double cash1 = customerPayment - Convert.ToDouble(row["Resto"]) <= 0.0 ? customerPayment : Convert.ToDouble(row["Resto"]);
                            this.customer.RegisterPayment(Convert.ToInt64(row["id_ventas"]), DateTime.Now, cash1, this.EmployeeID);
                            this.customer.Pay(cash1, Convert.ToInt64(row["id_ventas"]));
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

                        int y1 = 0;
                        Size stringSize = this.ticket.printLogo(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        stringSize = this.ticket.printHeader(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        stringSize = this.ticket.printAddress(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        stringSize = this.ticket.printPhone(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        y1 += printingClass.drawLine(10, width - 10, graphics, y1) + 5;

                        string str = "Pago de Cliente";
                        Font font = new Font("times new roman", 20f, FontStyle.Bold);//this.getFont(str1, width, FontStyle.Regular);
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Center, ee.Graphics, y1) + 1;

                        font = new Font("Times new Roman", 10f, FontStyle.Regular);

                        if (this.customer.ID != 0)
                        {
                            str = "Cliente: " + this.customer.Name;
                            y1 += printingClass.printLine(str, font, width, StringAlignment.Near, ee.Graphics, y1) + 1;
                        }

                        str = string.Format("Fecha: {0} {1}", DateTime.Now.Date.ToShortDateString(), DateTime.Now.ToShortTimeString());
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y1);


                        y1 += printingClass.drawLine(10, width - 10, graphics, y1) + 3;

                        customerPayment = Convert.ToDouble(form.Pay);
                        str = string.Format("Adeudo Previo: ${0}", (this.customer.Debt + customerPayment).ToString("n2"));
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y1) + 1;

                        str = string.Format("Monto a pagar: ${0}", customerPayment.ToString("n2"));
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y1) + 1;

                        str = string.Format("Adeudo Actualizado: ${0}", customer.Debt.ToString("n2"));
                        y1 += printingClass.printLine(str, new Font("times new roman", 10f, FontStyle.Bold), width, StringAlignment.Near, graphics, y1);

                        y1 += printingClass.drawLine(10, width - 10, graphics, y1) + 3;

                        str = string.Format("Efectivo: ${0}", cash.ToString("n2"));
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Far, graphics, y1) + 1;

                        str = string.Format("Cambio: ${0}", change.ToString("n2"));
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Far, graphics, y1) + 1;

                        if (ticket.footerDisplay)
                            printingClass.printLine(ticket.footer, ticket.footerFont, width, StringAlignment.Center, graphics, y1);
                    });

                    try
                    {
                        this.customerPaymentDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.customerPaymentDocument;
                        this.customerPaymentDocument.Print();
                    }
                    catch (InvalidPrinterException)
                    {
                        MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                    }

                    formCambio.ShowDialog();
                    this.customer.RefreshInfo();
                    this.debtLbl.Text = "$" + this.customer.Debt.ToString("n2");
                }
                else
                    MessageBox.Show("El Cliente no genera ningun adeudo");
            }
            //darkForm.Close();
        }

        private void customerPaymentDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
        }
        
        private void saleCancelledDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
        }

        private void packageReturnedDocument_PrintPage_1(object sender, PrintPageEventArgs e)
        {

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

                /* if (product.isReturnable)
                     setToolTip(e.RowIndex);
                 else
                     ReturnPackagesBtn.Enabled = false;*/
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
                double caseDiscount = amount > 1 ? product.RetailCost * amount - cases * product.CostPerCase : 0;

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
            panel6.Height = CobrarBtn.Location.Y - (customerGroupBox.Location.Y + customerGroupBox.Height);
            if (this.customerGroupBox.Size == this.customerGroupBoxMinSize)
            {
                this.CustomerPaymentBtn.Visible = false;
                this.label1.Visible = false;
                this.debtLbl.Visible = false;
                this.pictureBox1.Size = this.pictureBoxMaxSize;
                this.pictureBox1.Location = new Point((pictureBox1.Parent.Width - pictureBox1.Width) / 2, pictureBox1.Location.Y);
            }
            else if (this.customerGroupBox.Size == this.customerGroupBoxMaxSize)
            {
                this.CustomerPaymentBtn.Visible = true;
                this.label1.Visible = true;
                this.debtLbl.Visible = true;
                this.pictureBox1.Size = this.pictureBoxMinSize;
                this.pictureBox1.Location = new Point((pictureBox1.Parent.Width - pictureBox1.Width) / 2, pictureBox1.Location.Y);
            }
            this.CustomerPaymentBtn.Enabled = this.customer.Debt > 0.0;
            this.panel6.Location = new Point(this.panel6.Location.X, this.customerGroupBox.Location.Y + this.customerGroupBox.Height);
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
                MessageBox.Show("No se encontró información");
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

        public Panel_Ventas_1366x768 (int employeeID, FormWindowState windowState = FormWindowState.Normal, DataRow SellInfo = null)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            ProductTxt.Focus();
            setEmployee(employeeID);
            this.defaultTxt = "";// "Producto * Cantidad";

            this.customer = SellInfo != null ? new Cliente(Convert.ToInt32(SellInfo["id_cliente"])) : new Cliente(0);
            ClearCustomer();
            //setCustomer();

            this.isNewSale = true;
            this.ticket = new PrinterTicket();
            this.CanceledLbl.Parent = (Control)this.dataGridView2;
            this.CanceledLbl.BackColor = Color.Transparent;

            this.dataGridView2.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            var comboColumn = dataGridView2.Columns["depot"] as DataGridViewComboBoxColumn;
            var depotSource = Bodega.GetDepots();
            comboColumn.DataSource = depotSource;
            comboColumn.DisplayMember = "Nombre";
            comboColumn.ValueMember = "ID_Bodega";

            dataGridView2.Columns["depot"].Visible = depotSource.Rows.Count > 1;

            Color color = Color.FromArgb(new Random().Next());
            bunifuGradientPanel1.GradientBottomLeft = bunifuGradientPanel1.GradientTopRight = color;
            bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(color.R + 100 < 255 ? color.R + 100 : 255,
                color.G + 100 < 255 ? color.G + 100 : 255, color.B + 100 < 255 ? color.B + 100 : 255);
            bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(color.R + 100 < 255 ? color.R + 100 : 255,
                color.G + 100 < 255 ? color.G + 100 : 255, color.B + 100 < 255 ? color.B + 100 : 255);


            controlsShortcuts = new Control[] {discountBtn,discountList,newWindowBtn,lessBtn,moreBtn,printCheckBox,ClearCustomerBtn,
            CustomerBtn,LastSaleBtn,ReturnPackagesBtn,refoundBtn,printTicketBtn,CobrarBtn,CancelSaleBtn,cancelBtn};

            ShortcutTips = new ToolTip[15];
            for (int i = 0; i < ShortcutTips.Length; i++)
            {
                ShortcutTips[i] = new ToolTip();
            }


            if (SellInfo != null)
            {
                DataTable saleDetail = Venta.getInfoUnfinishedSell(Convert.ToInt32(SellInfo["id_Ventana"]), windowCount);

                foreach (DataRow row in saleDetail.Rows)
                {
                    addProductToDataGrid(new Producto(row["id_producto"].ToString()), Convert.ToDouble(row["cantidad"]), Convert.ToInt32(row["id_bodega"]));
                }
            }

        }

        public void setEmployee(int employeeID)
        {
            if (discountBtn.InvokeRequired)
            {
                var d = new hideButtonDelegate(setEmployee);
                discountBtn.Invoke(d, new object[] { employeeID });
            }
            else
            {
                this.EmployeeID = employeeID;
                this.isDiscountbyPercentage = true;
                this.discountBtn.Visible = new Empleado(employeeID).isAdmin;
                generalDiscount = 0;
                reassignCosts();
            }
        }


        private void Panel_Ventas_Load(object sender, EventArgs e)
        {
            this.ProductTxt.Text = this.defaultTxt;
            this.dataGridView2.CurrentCell = (DataGridViewCell)null;
            this.customerGroupBox.Size = this.customerGroupBoxMinSize;
            this.SuspendLayout();
            float num1 = (float)this.Width / (float)this.CanceledLbl.Width;
            float num2 = (float)this.Height / (float)this.CanceledLbl.Height;
            this.CanceledLbl.Font = new Font(this.CanceledLbl.Font.FontFamily, this.CanceledLbl.Font.Size * ((double)num1 > (double)num2 ? num2 : num1), this.CanceledLbl.Font.Style);
            this.ResumeLayout();
            this.CanceledLbl.Location = new Point(-50, (this.CanceledLbl.Parent.Height - this.CanceledLbl.Height) / 2);

            this.printDialog1 = new PrintDialog();
            this.printDialog1.PrinterSettings.PrinterName = this.ticket.printerName;

            ProductTxt.Select();

            setUpPOSDevices();
            setimage();
            ClearCustomer();
        }

        private async void setUpPOSDevices()
        {
            try
            {
                //Create PosExplorer
                PosExplorer posExplorer = new PosExplorer();
                DeviceInfo deviceInfo = null;
                try
                {
                    deviceInfo = posExplorer.GetDevice(DeviceType.CashDrawer, "CashDrawer");
                    cashDrawer = (CashDrawer)posExplorer.CreateInstance(deviceInfo);
                    await Task.Run(() => cashDrawer.Open());

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
                catch (Exception)
                {
                    try
                    {
                        printer.Release();
                    }
                    catch (PosControlException) { }
                }


            }
            catch (PosControlException)
            {
                //Nothing can be used.
                MessageBox.Show("No se tuvo acceso a la impresora o al cajon");
            }
            catch (Exception) { }
        }

        private async void setimage()
        {
            await Task.Run(() =>
            {

                PrinterTicket printerTicket = new PrinterTicket();

                if (printerTicket.logo != null)
                {
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
                }
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

            /* if (this.sale.Date.Date < DateTime.Today.Date.AddDays(-7.0))
             {
                 MessageBox.Show(string.Format("No se pueden retornar más envases. La fecha de compra excede los {0} días permitidos para la devolución.\n\nFecha de compra: {1} de {2} del {3}\n", (object)7, (object)this.sale.Date.Day, (object)new CultureInfo("es-MX").DateTimeFormat.GetMonthName(this.sale.Date.Month), (object)this.sale.Date.Year), "Lapso excedido");
             }

             else*/
            if (arePendingPackages() && !this.sale.isSaleCanceled)
            {
                //DarkForm darkForm = new DarkForm();
                PanelVentas_RetornarEnvasesForm returnForm = new PanelVentas_RetornarEnvasesForm(sale.ID, EmployeeID);
                // darkForm.Show();

                if (returnForm.ShowDialog() == DialogResult.OK)
                {
                    // this.sale.returnPackages(barcode, returnForm.AmountOfPackagesToReturn, this.EmployeeID);
                    double change = returnForm.MoneyToRefound; //(double)(this.sale.getSingleCost(barcode) * (Decimal)returnForm.AmountOfPackagesToReturn);
                    FormCambio formCambio = new FormCambio(change);
                    setSale(sale.ID);
                    ReturnPackagesBtn.Enabled = arePendingPackages();

                    if (printer != null)
                        openCashDrawer();
                    else
                        printNothing();

                    formCambio.ShowDialog();
                }
                //darkForm.Close();
            }
            else
            {
                MessageBox.Show("No se deben envases de este producto.");
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

        private void setSale(long SaleID)
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

                if (!producto.isReturnable)
                {

                    if (refounded)
                    {
                        dataGridView2.Rows[rowindex].DefaultCellStyle.ForeColor = Color.DimGray;
                        dataGridView2.Rows[rowindex].DefaultCellStyle.SelectionBackColor = Color.DimGray;
                        dataGridView2.Rows[rowindex].Cells["refound"].ReadOnly = true;
                    }
                    else
                        dataGridView2.Rows[rowindex].Cells["refound"].ReadOnly = false;
                }
                else
                {
                    //hacer que no se vea el check box cuando un producto es retornable
                    dataGridView2.Rows[rowindex].Cells["refound"].ReadOnly = true;
                }
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


            ReturnPackagesBtn.Enabled = arePendingPackages();


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

        private bool arePendingPackages()
        {
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if (sale.getAmountOfPendingPackagesToReturn(item.Cells["barcode"].Value.ToString()) > 0)
                    return true;
            }
            return false;
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
                    addProductToDataGrid(producto, -1.0, Convert.ToInt32(dataGridView2.Rows[index].Cells["depot"].Value), index);
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

        public void closeWindow()
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (this.dataGridView2.RowCount > 0 && MessageBox.Show("¿Desea cerrar la ventana?. Se perderá la infomación.", "Cerrar ventana", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                this.Close();
            });

        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData.ToString() == "Menu, Alt")
            {
                timer1.Start();
            }

            if (dataGridView2.RowCount > 1)
            {
                if (keyData == Keys.Down && !dataGridView2.IsCurrentCellInEditMode)
                {
                    try
                    {
                        dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = false;
                        dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex + 1].Cells[dataGridView2.CurrentCell.ColumnIndex];
                        dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = true;
                    }
                    catch (ArgumentOutOfRangeException) { dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Selected = true; }
                }
                else if (keyData == Keys.Up && !dataGridView2.IsCurrentCellInEditMode)
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
                if (dataGridView2.RowCount > 0 && isNewSale)
                {
                    addOneMoreProduct();
                    return true;
                }
            }

            if (keyData == (Keys.Alt | Keys.Subtract) && isNewSale)
            {
                if (dataGridView2.RowCount > 0)
                {
                    subtractOneProduct();
                    return true;
                }
            }

            if (keyData == (Keys.Alt | Keys.Delete) && isNewSale)
            {
                if (dataGridView2.RowCount > 0)
                {
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

                }

                totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
                countProducts();
            }

            if (keyData == (Keys.Alt | Keys.C) && CobrarBtn.Visible)
            {
                if (dataGridView2.RowCount > 0)
                {
                    CobrarBtn_Click(this, null);
                }
            }

            if (keyData == (Keys.Alt | Keys.C) && CancelSaleBtn.Visible && CancelSaleBtn.Enabled)
            {
                CancelSaleBtn_Click(this, null);
            }

            if (keyData == (Keys.Alt | Keys.I))
                printCheckBox.Checked = !printCheckBox.Checked;

            if (keyData == (Keys.N | Keys.Alt))
            {
                this.openNewWindow();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.O))
            {
                if (cashDrawer != null)
                    openCashDrawer();
                else
                    printNothing();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.R) && ClearCustomerBtn.Visible)
            {
                ClearCustomer();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.L))
            {
                lookForCustomer();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.Q))
            {
                if (dataGridView2.RowCount > 0 && isNewSale)
                    if (MessageBox.Show("¡Desea borrar la lista de productos?", "Borrar Lista", MessageBoxButtons.YesNo) == DialogResult.No)
                        return true;
                ClearSale();
                return true;
            }

            if (keyData == (Keys.Alt | Keys.D))
            {
                discountBtn_Click(this, null);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.F) && discountList.Visible)
            {
                discountList_Click(this, null);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.E) && ReturnPackagesBtn.Visible && ReturnPackagesBtn.Enabled)
            {
                ReturnPackagesBtn_Click(this, null);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.B))
            {
                refoundBtn_Click(this, null);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.U))
            {
                LastSaleBtn_Click(this, null);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.P) && printTicketBtn.Visible)
            {
                printTicketBtn_Click(this, null);
                return true;
            }

            if (keyData == Keys.F3 && dataGridView2.RowCount > 0 && isNewSale && dataGridView2.Columns["depot"].Visible)
            {
                dataGridView2.CurrentCell = dataGridView2.CurrentRow.Cells["depot"];
                ProductTxt.Leave -= new EventHandler(ProductTxt_Leave);
                ActiveControl = dataGridView2;
                dataGridView2.BeginEdit(true);
                return true;
            }
            if (keyData != (Keys.F4 | Keys.Alt))
                return base.ProcessCmdKey(ref msg, keyData);
            this.closeWindow();



            return true;
        }

        private void openNewWindow()
        {
            Panel_Ventas_1366x768 panel = new Panel_Ventas_1366x768(this.EmployeeID, FormWindowState.Maximized);
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



        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0 && isNewSale)
                if (MessageBox.Show("¡Desea borrar la lista de productos?", "Borrar Lista", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
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
            int x = 0;
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
                this.Invoke((MethodInvoker)delegate
                {
                    dispose.DisposeControls(this);
                    dispose.disposeArray(ShortcutTips);
                    dispose.disposeArray(controlsShortcuts);
                });
            }
            catch (Exception) { }


            if (File.Exists(this.Name + ".bmp"))
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
        {
            printTicket(sale.ID);
            dataGridView2.Focus();
        }

        private void reprintTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            printDialog1.PrinterSettings.PrinterName = this.ticket.printerName;

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


            graphics.DrawLine(Pens.White, new Point(0, y6), new Point(width, y6));

            if (e.PageSettings.PaperSize.Height < y6)
            {
                e.PageSettings.PaperSize = new PaperSize("new", e.PageSettings.PaperSize.Width, y6 + 15);
            }

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
                setSale(Convert.ToInt64(data.Tables[1].Rows[0][0]));
        }

        private void previousTicketBtn_Click(object sender, EventArgs e)
        {
            var data = sale.getNextSaleID();

            if (data.Tables[0].Rows.Count > 0)
                setSale(Convert.ToInt64(data.Tables[0].Rows[0][0]));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {

            int height = 0;
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if (height < item.Height)
                    height = item.Height;
            }
            dataGridView2.RowTemplate.MinimumHeight = height;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["depot"].Index)
            {
                ProductTxt.Leave += new EventHandler(ProductTxt_Leave);
                ProductTxt.Select();
            }
            dataGridView2.BeginInvoke((Action)(() => { try { dataGridView2.CurrentCell = dataGridView2.CurrentRow.Cells["description"]; } catch (Exception) { } }));
        }

        private void Panel_Ventas_Deactivate(object sender, EventArgs e)
        {
            ProductTxt.Leave -= new EventHandler(ProductTxt_Leave);
        }

        private void Panel_Ventas_Activated(object sender, EventArgs e)
        {
            ProductTxt.Leave += new EventHandler(ProductTxt_Leave);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["UnitCost"].Index && sale == null && new Empleado(EmployeeID).isAdmin)
            {
                panel8.Location = new Point((this.Width - panel8.Width) / 2, (this.Height - panel8.Height) / 2);
                panel7.Enabled = false;
                panel8.Show();
                alterCostTxt.Text = dataGridView2.CurrentCell.Value.ToString();
                alterCostTxt.Select();
                alterCostTxt.Focus();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Red))
            {
                e.Graphics.DrawRectangle(p, 0, 0, panel8.Width - 1, panel8.Height - 1);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            double value = -1;
            bool valid = double.TryParse(alterCostTxt.Text, out value);

            if (valid && value > 0)
            {
                dataGridView2.CurrentCell.Value = value.ToString("n2");
                addOneMoreProduct();
                subtractOneProduct();
                panel8.Hide();
                panel7.Enabled = true;
                ProductTxt.Select();
            }
            else
            {
                MessageBox.Show("El valor debe ser un número mayor a cero");
                alterCostTxt.Select();
            }

        }

        private void alterCostTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OkBtn_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Escape)
            {
                if (alterCostTxt.Text != "")
                    alterCostTxt.Text = "";
                else
                    bunifuImageButton1_Click_1(this, new EventArgs());
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            panel8.Hide();
            panel7.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["refound"].Index && e.RowIndex >= 0 && !dataGridView2[e.ColumnIndex, e.RowIndex].ReadOnly)
            {
                dataGridView2[e.ColumnIndex, e.RowIndex].Value = !Convert.ToBoolean(dataGridView2[e.ColumnIndex, e.RowIndex].Value);
            }
            else if (e.ColumnIndex == dataGridView2.Columns["depot"].Index && e.RowIndex >= 0 && sale == null)
            {
                dataGridView2.CurrentCell = dataGridView2[e.ColumnIndex, e.RowIndex];
                dataGridView2.BeginEdit(true);

            }

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex == dataGridView2.Columns["depot"].Index); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                ProductTxt.Leave -= new EventHandler(ProductTxt_Leave);
                dataGridView2.Focus();
                dataGridView2.Select();
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void Panel_Ventas_Resize(object sender, EventArgs e)
        {/*
            var resolution = Screen.PrimaryScreen.Bounds;
            if (resolution == new Rectangle(0, 0, 1366, 768))
            {
                //left side
                dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                dataGridView2.DefaultCellStyle.Font = new Font("Century Gothic", 17, FontStyle.Regular);
                dataGridView2.Columns["depot"].DefaultCellStyle.Font= new Font("Century Gothic", 17, FontStyle.Regular);
                
                ProductTxt.Font = new Font("Century Gothic", 13, FontStyle.Regular);
                ProductTxt.Height -= 5;


                float num1 = (float)this.Width / (float)this.CanceledLbl.Width;
                float num2 = (float)this.Height / (float)this.CanceledLbl.Height;
                this.CanceledLbl.Font = new Font(this.CanceledLbl.Font.FontFamily, this.CanceledLbl.Font.Size * ((double)num1 > (double)num2 ? num2 : num1), this.CanceledLbl.Font.Style);


                AmountProdctsLbl.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                AmountProdctsLbl.Height -= 9;

                cancelBtn.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                cancelBtn.Size = new Size(200, 42);

                totalLbl.Font = new Font("Century Gothic", 39, FontStyle.Bold);
                totalLbl.Height -= 9;

                panel5.Height -= 9;

                centerToParentBoth(cancelBtn);

                //right side
                lessBtn.Font = new Font("Century Gothic", 27,  FontStyle.Bold);
                lessBtn.Size = new Size(55, 55);

                moreBtn.Font = new Font("Century Gothic", 27, FontStyle.Bold);
                moreBtn.Size = new Size(55, 55);

                productGroupBox.Height -= 30;
                productGroupBox.Font = new Font("Century Gothic", 11, FontStyle.Bold);

                moreBtn.Location = new Point(moreBtn.Location.X, moreBtn.Location.Y + 20);
                lessBtn.Location = new Point(lessBtn.Location.X, lessBtn.Location.Y + 20);

                ticketGrupbox.Height -= 30;
                printCheckBox.Font = new Font("Century Gothic", 13);
                centerToParent(printCheckBox);
                printCheckBox.Location = new Point(printCheckBox.Location.X, printCheckBox.Location.Y-10);
                ticketGrupbox.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                ticketGrupbox.Location = new Point(ticketGrupbox.Location.X, productGroupBox.Location.Y + productGroupBox.Height + 10);

                customerGroupBox.Location = new Point(customerGroupBox.Location.X, ticketGrupbox.Location.Y + ticketGrupbox.Height + 10);
                customerGroupBox.Font= new Font("Century Gothic", 11, FontStyle.Bold);

                CustomerBtn.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                CustomerBtn.Height -= 30;

                label1.Font = debtLbl.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 50);
                debtLbl.Location = new Point(debtLbl.Location.X, debtLbl.Location.Y - 50);

                CustomerPaymentBtn.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                CustomerPaymentBtn.Location = new Point(CustomerPaymentBtn.Location.X, CustomerPaymentBtn.Location.Y - 55);

                customerGroupBoxMaxSize = new Size(customerGroupBoxMaxSize.Width, CustomerPaymentBtn.Location.Y + CustomerBtn.Height);

            }*/

        }

        private void centerToParentBoth(Control control)
        {
            if (control.Parent != null)
            {
                var parent = control.Parent;
                control.Location = new Point((parent.Width - control.Width) / 2, (parent.Height - control.Height) / 2);
            }
        }
    }
}
