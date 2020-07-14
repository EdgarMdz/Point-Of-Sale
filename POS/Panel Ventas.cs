using Bunifu.Framework.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

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
        private bool editingCell;
        private bool isNewSale;
        private int EmployeeID;
        private string defaultTxt;
        private Cliente customer;
        private Venta sale;
        private PrinterTicket ticket;
        private double generalDiscount;
        private bool isDiscountbyPercentage;
        private bool editingRow;

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
                addProductToDataGrid(new Producto(dataGridView2.SelectedRows[0].Cells["barcode"].Value.ToString()), 1.0);
            else
            {
                selectPromo(index);
                addPromoToGridView(getPromoIDFromRow(dataGridView2.SelectedRows[0].Index), 1);
            }
            dataGridView2.CurrentCell = this.dataGridView2[1, index];
        }

        private void addProductToDataGrid(Producto p, double quantity)
        {
            //lookin for an item in the datagridview to add the given product to it
            int rowIndex = -1;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                string barcode = row.Cells["barcode"].Value.ToString();

                if (barcode.IndexOf("promo(") == -1 && p.Barcode == barcode)
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
                    double singlePieces = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf(nameof(p))));
                    totalAmountOfPieces = cases * p.PiecesPerCase + singlePieces;
                }
                else// cell value has the format "N pieces"
                    totalAmountOfPieces = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf(".") + 3));

                dataGridView2.Rows[rowIndex].Cells["amount"].Value = amountFormat(p, totalAmountOfPieces + quantity);
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = getCost(p,rowIndex);// (quantity * p.RetailCost + Convert.ToDouble(getTotalFromRow(rowIndex).ToString("n2")));
                dataGridView2.CurrentCell = dataGridView2.Rows[rowIndex].Cells["description"];
            }
            totalLbl.Text = string.Format("Total   ${0}", GetTotal().ToString("n2"));
            pictureBox1.Image = p.image;//ShowImage(p.Barcode);
        }



        private void addPromoToGridView(int id, double quantity)
        {
            //lookin for an item in the datagridview to add the given product to it
            int rowIndex = -1;

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
                dataGridView2.Rows[index].Cells["UnitCost"].Value = (unitCost+discount).ToString("n2");
                dataGridView2.Rows[index].Cells["Total"].Value = string.Format("{0}\r\n-{1}", 
                    ((unitCost + discount) * quantity).ToString("n2"), (discount * quantity).ToString("n2"));
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells["description"];

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
                discount= discount * (quantity + amount);//promo discount
                dataGridView2.Rows[rowIndex].Cells["Total"].Value= string.Format("{0}\r\n-{1}",
                    (total).ToString("n2"), (discount).ToString("n2"));
            }

            ProductTxt.Text = "";
            totalLbl.Text= string.Format("Total   ${0}", GetTotal().ToString("n2")); 
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
            }
        }

        private  int getPromoIDFromRow(int rowindex)
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


            double totalDiscount = customerDiscount + caseDiscount + genDiscount;

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
            double customerDiscount = (product.RetailCost - customerCost) *amount;
            if (customerDiscount < 0)
                customerDiscount = 0;

            //getting discount for cases
            double caseDiscount = 0;
            if (cases > 0)
            {
                caseDiscount = product.RetailCost * product.PiecesPerCase * cases - product.CostPerCase * cases;

                caseDiscount = caseDiscount < 0 ? 0 : caseDiscount;
            }


            //getting discount for mixed case
            double mixedCaseDiscount = 0;

            if (product.mixedCaseGroup > 0)
            {
                mixedCaseDiscount = getDiscountForMixedCase(rowIndex, product);
            }

            double totalDiscount = customerDiscount + caseDiscount + mixedCaseDiscount + genDiscount;

            //validating that if appling totaldiscount we still have a revenue
            totalDiscount = validateDiscount(totalDiscount, product,amount);

            ///if there still a discount then show it in the table as the format -> "$100.00 \n -$15.00"
            ///otherwise show just the total
            if (totalDiscount > 0.0)
            {
                string newLine = Environment.NewLine;
                result = string.Format("{0}{1}-{2}", (product.RetailCost*amount).ToString("n2"), newLine, totalDiscount.ToString("n2"));
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
            //Dictionary<barcode,tuple<rowindex,amount,acumulated amount>
            Dictionary<string, Tuple<int, double, double>> values = new Dictionary<string, Tuple<int, double, double>>();

            double discount = 0;
            double countOfPieces = 0;


            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                var row = i != rowIndex ? dataGridView2.Rows[i] : dataGridView2.Rows[rowIndex];
                Producto p = i != rowIndex ? new Producto(row.Cells["barcode"].Value.ToString()) :
                     product;

                if (product.mixedCaseGroup == p.mixedCaseGroup)
                {
                    double singlePieces = getCasesAndSingleProducts(p,
                        getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), p)).Item2;

                    countOfPieces += singlePieces;
                    values.Add(p.Barcode, new Tuple<int, double, double>(i, singlePieces, countOfPieces));
                }
            }

            if (countOfPieces / product.PiecesPerCase >= 1)
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

        private Tuple<int,double> getCasesAndSingleProducts(Producto   producto, double amount)
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
                if (MessageBox.Show("¿Desea cancelar la venta?\n\nEn caso de haber adeudo en envases, una vez cancelada no se podrán retornar más envases.", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                try
                {
                    saleCancelledDocument.PrintController = new StandardPrintController();
                    this.saleCancelledDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                    this.printDialog1.Document = this.saleCancelledDocument;
                    this.saleCancelledDocument.Print();
                }
                catch (InvalidPrinterException)
                {
                    int num = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                }
                this.sale.Cancel(this.EmployeeID);
                Decimal num1 = new Decimal(0);
                foreach (DataRow row in (InternalDataCollectionBase)this.sale.getSoldProducts.Rows)
                {
                    string barcode = row["id_producto"].ToString();
                    num1 += (Decimal)this.sale.getAmountOfPackagesReturned(barcode) * this.sale.getSingleCost(barcode);
                }
                FormCambio formCambio = new FormCambio((double)(this.sale.Payment - num1));
                DarkForm darkForm = new DarkForm();
                darkForm.Show();
                int num2 = (int)formCambio.ShowDialog();
                darkForm.Close();
                this.CanceledLbl.Show();
                this.CancelSaleBtn.Enabled = false;
                this.CanceledLbl.Show();
            }
            else
            {
                int num3 = (int)MessageBox.Show(string.Format("La compra excede el lapso permitido de {0} días para realizar la devolución.\n\nFecha de la venta: {1} de {2} del {3}", (object)2, (object)this.sale.Date.Day, (object)new CultureInfo("es-MX").DateTimeFormat.GetMonthName(this.sale.Date.Month), (object)this.sale.Date.Year), "No se puede cancelar");
            }
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
            this.paymentLbl.Hide();
            this.pictureBox1.BringToFront();
            this.pictureBox1.Image = (Image)null;
            this.ReturnPackagesBtn.Hide();
            this.LastSaleBtn.Show();
            this.generalDiscount = 0.0;
            this.isDiscountbyPercentage = false;
            ProductTxt.Text = "";// "Producto * Cantidad";
            ProductTxt.Focus();
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
                List<Tuple<string, double, double, double>> list = new List<Tuple<string, double, double, double>>();

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var barcode = row.Cells["barcode"].Value.ToString().ToLower();

                    if (barcode != "" && barcode.IndexOf("promo(") == -1)
                    {
                        Producto product = new Producto(barcode);
                        double amountOfSinglePieces = this.getAmountOfSinglePieces(row.Cells["amount"].Value.ToString(), product);
                        double discountFromRow = this.getDiscountFromRow(row.Index);
                        list.Add(new Tuple<string, double, double, double>
                            (product.Barcode,product.RetailCost, amountOfSinglePieces, discountFromRow));
                        
                    }
                    else if(barcode.IndexOf("promo(") > -1)
                    {
                        DataSet dataSet = Producto.getPromo(getPromoIDFromRow(row.Index));

                        var amount = Convert.ToDouble(row.Cells["amount"].Value);
                        double promoDiscount = Convert.ToDouble(dataSet.Tables[0].Rows[0]["discount"]);
                        double discountForeachProduct =
                            promoDiscount / Convert.ToDouble(dataSet.Tables[0].Rows[0]["totalAmountOfProducts"]);
                        int child = 1;

                        foreach (DataRow promoChild in dataSet.Tables[1].Rows)
                        {
                            string childBarcode = promoChild["id_producto"].ToString();
                            double childAmount = Convert.ToDouble(promoChild["amount"]);
                            double childCost = Convert.ToDouble(dataGridView2.Rows[row.Index+child].Cells["UnitCost"].Value);
                            child++;

                            list.Add(new Tuple<string, double, double, double>
                                (childBarcode, childCost, childAmount * amount, discountForeachProduct * childAmount * amount));
                            
                        }
                    }
                }
                venta.newSale(this.EmployeeID, this.customer.ID, Total, Payment, list.ToArray(), Convert.ToDouble(formPagar.Cash));
                FormCambio formCambio = new FormCambio(Convert.ToDouble(formPagar.Cash) - Convert.ToDouble(formPagar.Pay));
                formCambio.Show();
                if (this.checkBox1.Checked)
                {
                    try
                    {
                        this.printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.printDocument1;
                        this.printDocument1.Print();
                    }
                    catch (InvalidPrinterException)
                    {
                        MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                    }
                    this.printDocument1 = new PrintDocument();
                    printDocument1.PrintController = new StandardPrintController();
                    this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
                }
                this.ClearSale();
                formCambio.Focus();
            }
            darkForm.Close();
            if (this.Parent != null)
                return;
            this.Close();
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
                    if (row.Cells["barcode"].Value != null && row.Cells["barcode"].Value.ToString()!="")
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
                    if (!editingRow && getDiscountFromRow(rowindex) !=0)
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

            for (int i =rowindex; i >= 0; i--)
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
                num2 = !product.displayAsKilogram ? Convert.ToDouble(str.Substring(0, str.IndexOf("p"))) : Convert.ToDouble(cellValue.Remove(cellValue.IndexOf("Kg"), 2));
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
                double amount = !product.displayAsKilogram ? Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf("p"))) + (double)cases * product.PiecesPerCase : Convert.ToDouble(cellValue.Remove(cellValue.IndexOf("Kg"), 2)) + (double)cases * product.PiecesPerCase;
                
                //customer discount
                double discount = amount * product.RetailCost - this.customer.getCost(product.Barcode, amount) * amount;




                //cost for each case and adding the cost of every piece that does not make an entire case
                double num2 =  cases * product.CostPerCase + (cases * product.PiecesPerCase - amount) * product.RetailCost;

                //adding the general discount
                double num3 = discount + num2 / 100.0 * this.generalDiscount;

                //if the final cost minus the discount is less than the purchase cost then adjust the discount for the user income become zero
                if (num2  - num3 < product.PurchaseCost / product.PiecesPerCase * amount)
                    num3 = amount * this.customer.getCost(product.Barcode, amount) - product.PurchaseCost / product.PiecesPerCase * amount;
                
                if (num3 > 0.0 && !this.customer.DontApplyAnyDiscount)
                {
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = ((amount * product.RetailCost).ToString("n2") + "\r\n-" + num3.ToString("n2"));
                }
                else
                {
                    double num4 = amount * product.RetailCost;
                    double num5 = amount - (double)cases * product.PiecesPerCase;
                    double num6 = num4 - (num5 * product.RetailCost + (double)cases * product.CostPerCase);
                    if (num6 > product.PurchaseCost)
                        num6 = num2 - product.PurchaseCost;
                    if (this.customer.DontApplyAnyDiscount)
                        num6 = 0.0;
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = num6 > 0.0 ? (object)string.Format("{0}\r\n-{1}", (object)num4.ToString("n2"), (object)num6.ToString("n2")) : (object)string.Format("{0}", (object)num4.ToString("n2"));
                }
            }
            else
            {
                double amount = Convert.ToDouble(cellValue.Substring(0, cellValue.IndexOf(".") + 3));
                double num = amount * product.RetailCost - this.customer.getCost(product.Barcode, amount) * amount + amount * product.RetailCost / 100.0 * this.generalDiscount;
                if (product.RetailCost * amount - num < product.PurchaseCost / product.PiecesPerCase * amount)
                    num = amount * product.RetailCost - product.PurchaseCost / product.PiecesPerCase * amount;
                if (num > 0.0 && !this.customer.DontApplyAnyDiscount)
                    this.dataGridView2.Rows[rowIndex].Cells["Total"].Value = (object)((amount * product.RetailCost).ToString("n2") + "\r\n-" + num.ToString("n2"));
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
                if (row.Cells["Total"].Value != null && row.Cells["barcode"].Value.ToString()!="")
                    num += this.getTotalFromRow(row.Index);
            }
            return num;
        }

        private double getTotalFromRow(int rowIndex)
        {
            if (this.dataGridView2.Rows.Count <= rowIndex &&dataGridView2.Rows[rowIndex].Cells["barcode"].Value.ToString()=="")
                return 0.0;

            string str = this.dataGridView2.Rows[rowIndex].Cells["Total"].Value.ToString();
            
            return str.IndexOf("\r\n") > -1 ? Convert.ToDouble(str.Substring(0, str.IndexOf("\r\n"))) - this.getDiscountFromRow(rowIndex) : Convert.ToDouble(this.dataGridView2.Rows[rowIndex].Cells["Total"].Value);
        }

        private void groupBox1_SizeChanged(object sender, EventArgs e)
        {
            if (this.groupBox1.Size == this.customerGroupBoxMinSize)
            {
                this.CustomerPaymentBtn.Visible = false;
                this.label1.Visible = false;
                this.debtLbl.Visible = false;
                this.pictureBox1.Size = this.pictureBoxMaxSize;
                this.pictureBox1.Location = new Point(this.groupBox1.Location.X, (this.CobrarBtn.Location.Y - this.groupBox1.Location.Y + this.groupBox1.Width) / 2);
            }
            else if (this.groupBox1.Size == this.customerGroupBoxMaxSize)
            {
                this.CustomerPaymentBtn.Visible = true;
                this.label1.Visible = true;
                this.debtLbl.Visible = true;
                this.pictureBox1.Size = this.pictureBoxMinSize;
                this.pictureBox1.Location = new Point((this.pictureBox1.Parent.Width - this.pictureBox1.Width) / 2, this.CobrarBtn.Location.Y - (this.refoundBtn.Parent.Location.Y + this.refoundBtn.Location.Y + this.refoundBtn.Height) / 2);
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
                str = this.ProductTxt.Text.Substring(0, length);
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
                str = ProductTxt.Text;
                quantity = 1.0;
            }


            if (!this.isNumber(str))
            {
                str = str.Trim().ToLower();

                if (str.IndexOf("promo(") == 0 && (str.IndexOf(")") > str.IndexOf("promo(")) )
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
                        MessageBox.Show("No se encontró el producto");
                        this.ProductTxt.SelectAll();
                    }
                    else
                    {
                        DarkForm darkForm = new DarkForm();
                        ChooseProductForm chooseProductForm = new ChooseProductForm(table);
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
            
                    printDocument1.PrintController = new StandardPrintController();
            
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
        }

        private void paymentLbl_TextChanged(object sender, EventArgs e)
        {
            if (this.sale == null)
                return;
            this.paymentLbl.ForeColor = this.sale.isPaid ? Color.Blue : Color.Tomato;
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
                        int num = (int)MessageBox.Show("Debe indicar la cantidad a agregar");
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
                    this.GetCustomerCostFormat(row.Index);
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
                int num1 = (int)MessageBox.Show(string.Format("No se pueden retornar más envases. La fecha de compra excede los {0} días permitidos para la devolución.\n\nFecha de compra: {1} de {2} del {3}\n", (object)7, (object)this.sale.Date.Day, (object)new CultureInfo("es-MX").DateTimeFormat.GetMonthName(this.sale.Date.Month), (object)this.sale.Date.Year), "Lapso excedido");
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
                    this.packageReturnedDocument = new PrintDocument();
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
                    int num11 = (int)formCambio.ShowDialog();
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
            foreach (DataRow row in (InternalDataCollectionBase)sale.getSoldProducts.Rows)
            {
                Producto producto = new Producto(row["id_producto"].ToString());
                dataGridView2.Rows.Add(producto.Barcode, producto.Description, producto.Brand, row["Cantidad"].ToString(), row["Precio"].ToString(), Convert.ToDouble(row["Descuento"]) != 0.0 ? (row["Importe"].ToString() + "\r\n -" + row["Descuento"].ToString()) : row["Importe"].ToString());
            }
            CustomerBtn.ButtonText = cliente.Name;
            totalLbl.Text = string.Format("Total   ${0}", sale.Total);
            paymentLbl.Text = string.Format("Abono   ${0}", sale.Payment);
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
            paymentLbl.Show();
            ReturnPackagesBtn.Show();
            LastSaleBtn.Hide();
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
                    return;
                }

                else
                {
                    addProductToDataGrid(producto, -1.0);
                    dataGridView2.CurrentCell = dataGridView2[1, index];
                }
            }
            else
            {
                selectPromo(index);
                addPromoToGridView(getPromoIDFromRow(dataGridView2.SelectedRows[0].Index), -1);

                
                if (Convert.ToDouble(dataGridView2.SelectedRows[0].Cells["amount"].Value)<=0)
                    for(int i=dataGridView2.SelectedRows.Count-1;i>=0;i--)
                    {
                        foreach (DataGridViewRow item in dataGridView2.SelectedRows)
                        {
                            dataGridView2.Rows.Remove(item);
                        }
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

            Size size1 =  ticket.printLogo(graphics, location);
            location = size1.Height == 0 ? location : location + size1.Height + 10;
            Size size2 =  ticket.printHeader(graphics, location);
            location = size2.Height == 0 ? location : location + size2.Height + 10;
            Size size3 =  ticket.printAddress(graphics, location);
            location = size3.Height == 0 ? location : location + size3.Height + 10;
            Size size4 =  ticket.printPhone(graphics, location);
            location = size4.Height == 0 ? location : location + size4.Height + 10;
            graphics.DrawLine(Pens.Black, 10, location, width - 10, location);
            location = location + 5;
            
            Venta lastSale = Venta.getLastSale();
            
            string str1 = "Detalle de Venta";
            Font font1 = PrinterTicket.getFont(str1, width-10, FontStyle.Regular);
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
                    else if ( barcode.IndexOf("promo(") > -1)
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
            graphics.DrawImage(image, (width-((int)(width * 0.75)))/2, y6,(int) (width *0.75), 40);

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
            
            if (keyData == (Keys.N | Keys.Shift | Keys.Control))
            {
                this.openNewWindow();
                return true;
            }
            if (keyData != (Keys.F4 | Keys.Alt))
                return base.ProcessCmdKey(ref msg, keyData);
            this.closeWindow();
            return true;
        }

        private void openNewWindow()
        {
            new Panel_Ventas(this.EmployeeID, FormWindowState.Maximized).Show();
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
            var font =discountList.Font;
            discountList.Font = new Font(font.FontFamily, font.Size,  FontStyle.Bold);
        }

        private void discountList_MouseLeave(object sender, EventArgs e)
        {
            var font = discountList.Font;
            discountList.Font = new Font(font.FontFamily, font.Size,  FontStyle.Regular);
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
    }
}
