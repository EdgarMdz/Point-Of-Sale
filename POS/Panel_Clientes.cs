using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace POS
{
    public partial class Panel_Clientes : Form
    {
        private Cliente cliente = new Cliente();
        private AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        private List<DataTable> selectedTables = new List<DataTable>();

        public int EmployeeID { get; set; }

        public string EmployeeType { get; set; }

        public Panel_Clientes(FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            this.AutoComplete();
            this.DetalleCompraDataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.DetalleCompraDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.printDialog1.PrinterSettings.PrinterName = new PrinterTicket().printerName;
        }

        private void AutoComplete()
        {
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = this.cliente.SearchCustomer(this.SearchTxt.Text);
            if (dataTable2.Rows.Count > 0)
            {
                foreach (DataRow row in (InternalDataCollectionBase)dataTable2.Rows)
                    this.collection.Add(row["Nombre"].ToString());
            }
            this.SearchTxt.AutoCompleteCustomSource = this.collection;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.cliente = new Cliente();
            this.cliente.Name = this.SearchTxt.Text;
            this.DetalleCompraDataGridView1.DataSource = (object)null;
            this.HideLabels();
            this.cliente.FindCustomer();
            this.FillDataList();
            this.setForm();
        }

        private void setForm()
        {
            if (this.cliente.ID <= 0)
                return;
            this.AddButton.Size = new Size(202, 37);

            this.AddButton.Location = 
                new Point(10, 
                this.SearchTxt.Location.Y / 2 - this.AddButton.Height + 25);

            this.ListaClientesBtn.Size = this.AddButton.Size;

            this.ListaClientesBtn.Location =
                new Point(AddButton.Location.X + AddButton.Width + 10,
                this.SearchTxt.Location.Y / 2 - this.ListaClientesBtn.Height + 25);
            
            this.showLabels();
            if (this.cliente.Status == "Activo")
            {
                this.InhibitBtn.BackColor = Color.FromArgb(0, 111, 173);
                this.InhibitBtn.Text = "Activo";
                this.NombreLbl.ForeColor = Color.LimeGreen;
                this.TelefonoLbl.ForeColor = Color.LimeGreen;
                this.DireccionLbl.ForeColor = Color.LimeGreen;
                this.label6.ForeColor = Color.LimeGreen;
                this.label7.ForeColor = Color.LimeGreen;
                this.SaldoLbl.ForeColor = Color.DimGray;
                this.label3.ForeColor = Color.DimGray;
                this.label2.ForeColor = Color.FromArgb(0, 111, 173);
                this.listView1.ForeColor = Color.FromArgb(0, 111, 173);
                this.PreciosBtn.BackColor = Color.FromArgb(0, 111, 173);
                this.discountLbl.ForeColor = Color.LimeGreen;
                this.discountTxt.ForeColor = Color.LimeGreen;
            }
            else
            {
                if (!(this.cliente.Status == "Inactivo"))
                    return;
                this.InhibitBtn.BackColor = Color.DimGray;
                this.InhibitBtn.Text = "Inactivo";
                this.NombreLbl.ForeColor = Color.DimGray;
                this.TelefonoLbl.ForeColor = Color.DimGray;
                this.DireccionLbl.ForeColor = Color.DimGray;
                this.label6.ForeColor = Color.DimGray;
                this.label7.ForeColor = Color.DimGray;
                this.SaldoLbl.ForeColor = Color.Red;
                this.label3.ForeColor = Color.Red;
                this.label2.ForeColor = Color.DimGray;
                this.listView1.ForeColor = Color.DimGray;
                this.PreciosBtn.BackColor = Color.DimGray;
                this.discountLbl.ForeColor = Color.DimGray;
                this.discountTxt.ForeColor = Color.DimGray;
            }
        }

        private void showLabels()
        {
            this.NombreLbl.Visible = true;
            this.DireccionLbl.Visible = true;
            this.TelefonoLbl.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.listView1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.DetalleCompraDataGridView1.Visible = true;
            this.SaldoLbl.Visible = true;
            this.PreciosBtn.Visible = true;
            this.AbonarBtn.Visible = true;
            this.printTicketBtn.Visible = true;
            this.InhibitBtn.Visible = true;
            this.PagosBtn.Visible = true;
            this.discountLbl.Visible = true;
            this.discountTxt.Visible = true;
            deleteCustomer.Show();
        }

        private void HideLabels()
        {
            this.PreciosBtn.Visible = false;
            this.AbonarBtn.Visible = false;
            this.printTicketBtn.Visible = false;
            this.PagosBtn.Visible = false;
            this.listView1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.SaldoLbl.Visible = false;
            this.NombreLbl.Visible = false;
            this.DireccionLbl.Visible = false;
            this.TelefonoLbl.Visible = false;
            this.InhibitBtn.Visible = false;
            this.label4.Visible = false;
            this.DetalleCompraDataGridView1.Visible = false;
            this.discountLbl.Visible = false;
            this.discountTxt.Visible = false;
            this.label10.Visible = false;
            this.TotalLbl.Visible = false;
            this.label5.Visible = false;
            this.AbonoLbl.Visible = false;
            this.InfoLbl.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.deleteCustomer.Visible = false;
        }

        private async void FillDataList()
        {
            this.listView1.Clear();
            if (this.cliente.ID != 0)
            {
                this.NombreLbl.Text = this.cliente.Name;
                this.DireccionLbl.Text = this.cliente.Address;
                this.TelefonoLbl.Text = this.cliente.TelephoneNumber;
                this.discountTxt.Text = this.cliente.isDiscountbyPercentage ? this.cliente.generalDiscount.ToString("n2") + "%" : this.cliente.generalDiscount.ToString("n2");
                this.fitTextboxToContent();
                List<string[]> customerPurchases = await Task.Run(()=> this.cliente.GetCustomerPurchases());
                List<string> stringList1 = new List<string>();
                this.listView1.Columns.Add("Hora", 30, HorizontalAlignment.Center);
                this.listView1.Columns.Add("Número de Ticket", 30, HorizontalAlignment.Center);
                this.listView1.Columns.Add("Total", 30, HorizontalAlignment.Center);
                this.listView1.Columns.Add("Abono", 30, HorizontalAlignment.Center);
                this.listView1.Columns.Add("Estado de Pago", -2, HorizontalAlignment.Center);
                for (int index = 0; index < customerPurchases.Count; ++index)
                {
                    List<string> stringList2 = new List<string>();
                    if (index == 0)
                    {
                        stringList1.Add(((IEnumerable<string>)customerPurchases[index]).ElementAt<string>(5).Substring(0, 10));
                        this.listView1.Groups.Add(new ListViewGroup(((IEnumerable<string>)customerPurchases[index]).ElementAt<string>(5).Substring(0, 10), HorizontalAlignment.Left));
                    }
                    if (!stringList1.Contains(((IEnumerable<string>)customerPurchases[index]).ElementAt<string>(5).Substring(0, 10)))
                    {
                        stringList1.Add(((IEnumerable<string>)customerPurchases[index]).ElementAt<string>(5).Substring(0, 10));
                        this.listView1.Groups.Add(new ListViewGroup(((IEnumerable<string>)customerPurchases[index]).ElementAt<string>(5).Substring(0, 10), HorizontalAlignment.Left));
                    }
                }
                for (int index1 = 0; index1 < customerPurchases.Count; ++index1)
                {
                    for (int index2 = 0; index2 < stringList1.Count; ++index2)
                    {
                        if (((IEnumerable<string>)customerPurchases[index1]).ElementAt<string>(5) == stringList1[index2])
                        {
                            this.listView1.Items.Add(new ListViewItem(customerPurchases[index1]));
                            this.listView1.Items[index1].Group = this.listView1.Groups[index2];
                        }
                    }
                }
                this.listViewFormat();
                this.SaldoLbl.Text = "$" + this.cliente.Debt.ToString("n2");
                if (Convert.ToDouble(this.SaldoLbl.Text.Substring(1)) > 0.0)
                {
                    this.AbonarBtn.Enabled = true;
                    this.AbonarBtn.BackColor = Color.FromArgb(0, 111, 173);
                }
                else
                {
                    this.AbonarBtn.Enabled = false;
                    this.AbonarBtn.BackColor = Color.DimGray;
                }
                this.SaldoLbl.TextAlign = ContentAlignment.MiddleRight;
                this.reorderLabels();
            }
            else
            {
                int num = (int)MessageBox.Show("No se encontró el cliente especificado");
            }
        }

        private void fitTextboxToContent()
        {
            Graphics graphics = this.NombreLbl.CreateGraphics();
            int width1 = (int)graphics.MeasureString(this.NombreLbl.Text, this.NombreLbl.Font).Width;
            int width2 = (int)graphics.MeasureString(this.DireccionLbl.Text, this.DireccionLbl.Font).Width;
            int width3 = (int)graphics.MeasureString(this.TelefonoLbl.Text, this.TelefonoLbl.Font).Width;
            while (this.NombreLbl.Width < width1 || this.DireccionLbl.Width < width2)
            {
                if (this.NombreLbl.Width < width1)
                    ++this.NombreLbl.Width;
                if (this.DireccionLbl.Width < width2)
                    ++this.DireccionLbl.Width;
                if (this.TelefonoLbl.Width < width3)
                    ++this.TelefonoLbl.Width;
            }
        }

        private void listViewFormat()
        {
            this.listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView1.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.listView1.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (ListViewItem listViewItem in this.listView1.Items)
            {
                if (listViewItem.SubItems[4].Text == "Pendiente")
                {
                    listViewItem.BackColor = Color.Orange;
                    listViewItem.ForeColor = Color.Black;
                }
            }
        }

        private string calculateDebt(List<string[]> lista)
        {
            double num1 = 0.0;
            foreach (string[] strArray in lista)
            {
                if (Convert.ToDouble(strArray[3]) < Convert.ToDouble(strArray[2]))
                {
                    double num2 = Convert.ToDouble(strArray[2]) - Convert.ToDouble(strArray[3]);
                    num1 += num2;
                }
            }
            return "$" + num1.ToString("n2");
        }

        private void SearchTxt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                this.Buscar_Click((object)this, (EventArgs)null);
            if (e.KeyCode.ToString() == "F1" && this.cliente.ID > 0)
                this.Abonar();
            if (e.Control && e.KeyCode == Keys.B && this.SearchTxt.Text != "")
            {
                e.SuppressKeyPress = true;
                this.Buscar_Click((object)this, (EventArgs)null);
            }
            if (e.Control && e.KeyCode == Keys.B && this.SearchTxt.Text == "")
                this.SearchTxt.Focus();
            if (e.Control && e.KeyCode == Keys.N)
                this.AddButton_Click((object)this, (EventArgs)null);
            if (!e.Control || e.KeyCode != Keys.L)
                return;
            this.ListaClientesBtn_Click((object)this, (EventArgs)null);
        }

        private  void fillGridView(int index)
        {
            string idHex = listView1.Items[index].SubItems[1].Text;

            Venta venta = new Venta(Convert.ToInt64(idHex, 16));
            DataTable purchase = cliente.getPurchase(idHex);

            purchase.Columns["Importe"].ReadOnly = false;

            int i = 0;
            foreach (DataRow row1 in purchase.Rows)
            {

                var row2 = venta.getSoldProducts.Rows[i++];
                if (Convert.ToDecimal(row2["Descuento"]) > 0 && row1["Código de Barras"].ToString() == row2["id_producto"].ToString())
                    row1["Importe"] = string.Format("{0}\n-{1}", row1["Importe"].ToString(), Convert.ToDecimal(row2["Descuento"]).ToString("n2"));

            }

            DetalleCompraDataGridView1.DataSource = purchase;
            DetalleCompraDataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DetalleCompraDataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DetalleCompraDataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DetalleCompraDataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DetalleCompraDataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalLbl.Text = "$" + venta.Total.ToString("n2");
            AbonoLbl.Text = "$" + (venta.Total - venta.Payment).ToString("n2");

            if (AbonoLbl.Text != "$0.00")
            {
                AbonoLbl.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
            }
            else
            {
                AbonoLbl.ForeColor = Color.LimeGreen;
                label5.ForeColor = Color.LimeGreen;
            }

            if (purchase.Rows.Count == 0)
            {
                InfoLbl.Visible = true;
                while (InfoLbl.Width < DetalleCompraDataGridView1.Width)
                    InfoLbl.Font = new Font("Century Gothic", InfoLbl.Font.Size + 1f);
                InfoLbl.Location = new Point(InfoLbl.Location.X, DetalleCompraDataGridView1.ColumnHeadersHeight + (DetalleCompraDataGridView1.Location.Y + DetalleCompraDataGridView1.Height) / 2);
            }
            else
                InfoLbl.Visible = false;
            reorderLabels();
            label5.Visible = true;
            AbonoLbl.Visible = true;
            label10.Visible = true;
            TotalLbl.Visible = true;
        }

        private void reorderLabels()
        {
            Point point = new Point();
            point.X = this.DetalleCompraDataGridView1.Location.X + this.DetalleCompraDataGridView1.Width - this.TotalLbl.Width;
            point.Y = this.TotalLbl.Location.Y;
            this.TotalLbl.Location = point;
            point.X = this.TotalLbl.Location.X - this.label10.Width - 4;
            this.label10.Location = point;
            point.X = this.DetalleCompraDataGridView1.Location.X + this.DetalleCompraDataGridView1.Width - this.AbonoLbl.Width;
            point.Y = this.AbonoLbl.Location.Y;
            this.AbonoLbl.Location = point;
            point.X = this.AbonoLbl.Location.X - this.label5.Width - 4;
            point.Y = this.AbonoLbl.Location.Y + this.AbonoLbl.Height - this.label5.Height;
            this.label5.Location = point;
            point.X = this.DetalleCompraDataGridView1.Location.X + this.DetalleCompraDataGridView1.Width - this.SaldoLbl.Width;
            point.Y = this.SaldoLbl.Location.Y;
            this.SaldoLbl.Location = point;
            point.X = this.SaldoLbl.Location.X - this.label3.Width - 4;
            point.Y = this.SaldoLbl.Location.Y + this.SaldoLbl.Height - this.label3.Height;
            this.label3.Location = point;
        }

        private void PreciosBtn_Click(object sender, EventArgs e)
        {
            DarkForm darkForm = new DarkForm();
            FormPreciosCliente formPreciosCliente = new FormPreciosCliente(this.cliente.ID);
            darkForm.Show();
            int num = (int)formPreciosCliente.ShowDialog();
            darkForm.Hide();
        }

        private void AbonarBtn_Click(object sender, EventArgs e)
        {
            this.Abonar();
        }

        private void Abonar()
        {
            FormPagar form = new FormPagar(this.SaldoLbl.Text, false, 0.0);
            //DarkForm darkForm = new DarkForm();
            //darkForm.Show();
            if (form.ShowDialog() == DialogResult.OK)
            {
                double num1 = Convert.ToDouble(form.Pay);
                double cash = Convert.ToDouble(form.Cash);
                if (num1 > 0.0)
                {
                    double change = cash <= num1 ? 0.0 : cash - num1;
                    for (int index = this.listView1.Items.Count - 1; index >= 0; --index)
                    {
                        ListViewItem listViewItem = this.listView1.Items[index];
                        if (listViewItem.SubItems[4].Text == "Pendiente" && num1 > 0.0)
                        {
                            double cash1 = num1 - Convert.ToDouble(listViewItem.SubItems[2].Text) + Convert.ToDouble(listViewItem.SubItems[3].Text) <= 0.0 ? num1 : Convert.ToDouble(listViewItem.SubItems[2].Text) - Convert.ToDouble(listViewItem.SubItems[3].Text);
                            this.cliente.RegisterPayment(Convert.ToInt64(listViewItem.SubItems[1].Text, 16), DateTime.Now, cash1, this.EmployeeID);
                            this.cliente.Pay(cash1, Convert.ToInt64(listViewItem.SubItems[1].Text, 16));
                            num1 -= cash1;
                        }
                    }
                    FormCambio formCambio = new FormCambio(change);
                    this.customerPaymentDocument = new PrintDocument();
                    customerPaymentDocument.PrintController = new StandardPrintController();

                    this.customerPaymentDocument.PrintPage += (PrintPageEventHandler)((ss, ee) =>
                    {
                        Graphics graphics = ee.Graphics;
                        var ticket = new PrinterTicket();

                        this.customerPaymentDocument.PrinterSettings.PrinterName = ticket.printerName;
                        this.customerPaymentDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 200, 200);
                        int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;

                        int y1 = 0;
                        Size stringSize = ticket.printLogo(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        stringSize = ticket.printHeader(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        stringSize = ticket.printAddress(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        stringSize = ticket.printPhone(graphics, y1);
                        y1 = stringSize.Height == 0 ? y1 : y1 + stringSize.Height + 10;

                        y1 += printingClass.drawLine(10, width - 10, graphics, y1) + 5;

                        string str = "Pago de Cliente";
                        Font font = new Font("times new roman", 17f, FontStyle.Bold);//this.getFont(str1, width, FontStyle.Regular);
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Center, ee.Graphics, y1) + 1;

                        font = width > 200 ? new Font("Times new Roman", 9.9f) : new Font("Times new Roman", 7f);

                        str = "Cliente: " + this.cliente.Name;
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, ee.Graphics, y1) + 1;


                        str = string.Format("Fecha: {0} {1}", DateTime.Now.Date.ToShortDateString(), DateTime.Now.Date.ToShortTimeString());
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y1);


                        y1 += printingClass.drawLine(10, width - 10, graphics, y1) + 3;

                        num1 = Convert.ToDouble(form.Pay);
                        str = string.Format("Adeudo Previo: ${0}", (cliente.Debt + num1).ToString("n2"));
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y1) + 1;

                        str = string.Format("Monto a pagar: ${0}", num1.ToString("n2"));
                        y1 += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y1) + 1;

                        str = string.Format("Adeudo Actualizado: ${0}", cliente.Debt.ToString("n2"));
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
                    int num12 = (int)formCambio.ShowDialog();
                    this.DetalleCompraDataGridView1.DataSource = (object)null;
                    this.label10.Visible = false;
                    this.TotalLbl.Visible = false;
                    this.label5.Visible = false;
                    this.AbonoLbl.Visible = false;
                    this.SaldoLbl.Text = "$" + this.cliente.Debt.ToString("n2");
                    this.FillDataList();
                    if (this.InfoLbl.Visible)
                        this.InfoLbl.Visible = false;
                }
                else
                {
                    MessageBox.Show("El Cliente no genera ningun adeudo");
                }
            }
           // darkForm.Close();
            this.FillDataList();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
                return;
            e.Handled = true;
        }

        private void NombreLbl_Leave(object sender, EventArgs e)
        {
            if (this.NombreLbl.Text == "")
                this.NombreLbl.Text = this.cliente.Name;
            if (!(this.NombreLbl.Text != this.cliente.Name) || !(this.NombreLbl.Text != ""))
                return;
            if (MessageBox.Show("Desea guardar los cambios efectuados", "Edición de Nombre del Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.collection.Remove(this.cliente.Name);
                this.cliente.Name = this.NombreLbl.Text;
                this.cliente.updateCustomerInfo();
                this.collection.Add(this.cliente.Name);
                this.SearchTxt.Text = this.cliente.Name;
            }
            else
                this.NombreLbl.Text = this.cliente.Name;
        }

        private void telefonoLbl_Leave(object sender, EventArgs e)
        {
            if (!(this.TelefonoLbl.Text != this.cliente.TelephoneNumber))
                return;
            if (MessageBox.Show("Desea guardar los cambios efectuados", "Edición de Número Telefónico del Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.cliente.TelephoneNumber = this.TelefonoLbl.Text;
                this.cliente.updateCustomerInfo();
            }
            else
                this.TelefonoLbl.Text = this.cliente.TelephoneNumber;
        }

        private void DireccionLbl_Leave(object sender, EventArgs e)
        {
            if (this.DireccionLbl.Text != this.cliente.Address)
            {
                if (MessageBox.Show("Desea guardar los cambios efectuados", "Edición de Dirección del Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.cliente.Address = this.DireccionLbl.Text;
                    this.cliente.updateCustomerInfo();
                }
                else
                    this.DireccionLbl.Text = this.cliente.Address;
            }
            int num = this.DireccionLbl.Text == "" ? 1 : 0;
        }

        private void InhibitBtn_Click(object sender, EventArgs e)
        {
            if (this.cliente.Status == "Activo")
            {
                this.InhibitBtn.BackColor = Color.DimGray;
                this.InhibitBtn.Text = "Inactivo";
                this.cliente.Status = "Inactivo";
                this.NombreLbl.ForeColor = Color.DimGray;
                this.TelefonoLbl.ForeColor = Color.DimGray;
                this.DireccionLbl.ForeColor = Color.DimGray;
                this.label6.ForeColor = Color.DimGray;
                this.label7.ForeColor = Color.DimGray;
                this.SaldoLbl.ForeColor = Color.Red;
                this.label3.ForeColor = Color.Red;
                this.label2.ForeColor = Color.DimGray;
                this.listView1.ForeColor = Color.DimGray;
                this.PreciosBtn.BackColor = Color.DimGray;
                this.cliente.UpdateStatus();
                this.discountTxt.ForeColor = Color.DimGray;
                this.discountLbl.ForeColor = Color.DimGray;
            }
            else
            {
                this.InhibitBtn.BackColor = Color.FromArgb(0, 111, 173);
                this.InhibitBtn.Text = "Activo";
                this.cliente.Status = "Activo";
                this.NombreLbl.ForeColor = Color.LimeGreen;
                this.TelefonoLbl.ForeColor = Color.LimeGreen;
                this.DireccionLbl.ForeColor = Color.LimeGreen;
                this.label6.ForeColor = Color.LimeGreen;
                this.label7.ForeColor = Color.LimeGreen;
                this.SaldoLbl.ForeColor = Color.DimGray;
                this.label3.ForeColor = Color.DimGray;
                this.label2.ForeColor = Color.FromArgb(0, 111, 173);
                this.listView1.ForeColor = Color.FromArgb(0, 111, 173);
                this.PreciosBtn.BackColor = Color.FromArgb(0, 111, 173);
                this.discountTxt.ForeColor = Color.LimeGreen;
                this.discountLbl.ForeColor = Color.LimeGreen;
                this.cliente.UpdateStatus();
            }
        }

        private void Panel_Clientes_Load(object sender, EventArgs e)
        {
            this.AddButton.Location =
                new Point((this.Width - this.AddButton.Width - this.ListaClientesBtn.Width) / 2,
                (this.Height - this.AddButton.Height) / 2);

            this.ListaClientesBtn.Location = 
                new Point((this.Width + this.ListaClientesBtn.Width) / 2,
                (this.Height - this.ListaClientesBtn.Height) / 2);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DarkForm darkForm = new DarkForm();
            PanelClienteNewCustomerForm clienteNewCustomerForm = new PanelClienteNewCustomerForm();
            clienteNewCustomerForm.EmployeeID = this.EmployeeID;
            darkForm.Show();
            int num1 = (int)clienteNewCustomerForm.ShowDialog();
            if (clienteNewCustomerForm.DialogResult == DialogResult.OK)
            {
                int num2 = (int)MessageBox.Show("Se ha creado un nuevo cliente");
                this.collection.Add(clienteNewCustomerForm.Name);
            }
            darkForm.Close();
        }

        private void ListaClientesBtn_Click(object sender, EventArgs e)
        {
            PanelClientesListaClientesForm listaClientesForm = new PanelClientesListaClientesForm(this.EmployeeID);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (listaClientesForm.ShowDialog() == DialogResult.OK)
            {
                this.cliente = new Cliente();
                this.cliente.Name = this.SearchTxt.Text;
                this.DetalleCompraDataGridView1.DataSource = (object)null;
                this.HideLabels();
                this.cliente.FindCustomerbyID(listaClientesForm.IDCustomer);
                this.FillDataList();
                this.setForm();
            }
            darkForm.Close();
        }

        private void TelefonoLbl_OnValueChanged(object sender, EventArgs e)
        {
            this.TelefonoLbl.LineIdleColor = Color.Transparent;
            if (!(this.TelefonoLbl.Text == ""))
                return;
            this.TelefonoLbl.LineIdleColor = Color.Gray;
        }

        private void DireccionLbl_OnValueChanged(object sender, EventArgs e)
        {
            this.DireccionLbl.LineIdleColor = Color.Transparent;
            if (!(this.DireccionLbl.Text == ""))
                return;
            this.DireccionLbl.LineIdleColor = Color.Gray;
        }

        private void NombreLbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                this.listView1.Focus();
            if (e.KeyChar != '\x001B')
                return;
            this.NombreLbl.Text = this.cliente.Name;
            this.listView1.Focus();
        }

        private void TelefonoLbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                this.listView1.Focus();
            if (e.KeyChar == '\x001B')
            {
                this.TelefonoLbl.Text = this.cliente.TelephoneNumber;
                this.listView1.Focus();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            string str = this.TelefonoLbl.Text;
            for (int length = str.LastIndexOf('-'); length > 0; length = str.LastIndexOf('-'))
                str = str.Substring(0, length) + str.Substring(length + 1);
            if (str.Length >= 10)
                e.Handled = true;
            if (str.Length < 10 || e.KeyChar != '\b')
                return;
            e.Handled = false;
        }

        private void DireccionLbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                this.listView1.Focus();
            if (e.KeyChar != '\x001B')
                return;
            this.DireccionLbl.Text = this.cliente.Address;
            this.listView1.Focus();
        }

        private void Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1" && this.cliente.ID > 0 && this.AbonarBtn.Enabled)
                this.Abonar();
            if (e.Control && e.KeyCode == Keys.B && this.SearchTxt.Text != "")
            {
                e.SuppressKeyPress = true;
                this.Buscar_Click((object)this, (EventArgs)null);
            }
            if (e.Control && e.KeyCode == Keys.B && this.SearchTxt.Text == "")
                this.SearchTxt.Focus();
            if (e.Control && e.KeyCode == Keys.N)
                this.AddButton_Click((object)this, (EventArgs)null);
            if (e.Control && e.KeyCode == Keys.L)
                this.ListaClientesBtn_Click((object)this, (EventArgs)null);
            if (!e.Control || e.KeyCode != Keys.H)
                return;
            this.PagosBtn_Click((object)this, (EventArgs)null);
        }

        private void PagosBtn_Click(object sender, EventArgs e)
        {
            DataTable purchaseRecord = this.cliente.getPurchaseRecord();
            if (purchaseRecord.Rows.Count > 0)
            {
                foreach (DataRow row in (InternalDataCollectionBase)purchaseRecord.Rows)
                    row["Hora"] = (object)row["Hora"].ToString().Substring(0, 8);
                this.InfoLbl.Visible = false;
            }
            else
            {
                this.InfoLbl.Visible = true;
                this.InfoLbl.Location = new Point(this.InfoLbl.Location.X, this.DetalleCompraDataGridView1.ColumnHeadersHeight + (this.DetalleCompraDataGridView1.Location.Y + this.DetalleCompraDataGridView1.Height) / 2);
            }
            this.DetalleCompraDataGridView1.DataSource = (object)purchaseRecord;
            this.DetalleCompraDataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.DetalleCompraDataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DetalleCompraDataGridView1.Height = listView1.Height;
            this.label5.Visible = false;
            this.label10.Visible = false;
            this.TotalLbl.Visible = false;
            this.AbonoLbl.Visible = false;

        }

        private void DetalleCompraDataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void discountTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.updateDiscount();
        }

        private void discountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != '%'))
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
            if (this.discountTxt.Text != "" && e.KeyChar == '%' && (sender as TextBox).Text.IndexOf('%') > -1)
                e.Handled = true;
            if (e.KeyChar == '%' && this.discountTxt.Text == "")
                e.Handled = true;
            if (this.discountTxt.Text.IndexOf("%") > -1 && !char.IsControl(e.KeyChar) && this.discountTxt.SelectionStart > this.discountTxt.Text.IndexOf("%"))
                e.Handled = true;
            if (e.KeyChar != '%' || this.discountTxt.SelectionStart == this.discountTxt.Text.Length)
                return;
            e.Handled = true;
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            string text = this.discountTxt.Text;
            if (text.IndexOf("%") <= -1 || this.discountTxt.Text.Length <= 1)
                return;
            this.discountTxt.Text = Convert.ToDouble(text.Substring(0, text.Length - 1)) > 100.0 ? "100%" : this.discountTxt.Text;
        }

        private void discountTxt_Leave(object sender, EventArgs e)
        {
            this.updateDiscount();
        }

        private void updateDiscount()
        {
            if (this.discountTxt.Text == "")
                this.discountTxt.Text = this.cliente.isDiscountbyPercentage ? this.cliente.generalDiscount.ToString() + "%" : this.cliente.generalDiscount.ToString();
            string text = this.discountTxt.Text;
            int num1 = text.IndexOf("%");
            bool flag = num1 > -1;
            Decimal num2 = new Decimal(0);
            Decimal num3;
            try
            {
                num3 = num1 <= -1 || this.discountTxt.Text.Length <= 1 ? Convert.ToDecimal(text) : Convert.ToDecimal(text.Substring(0, text.Length - 1));
            }
            catch (FormatException ex)
            {
                this.discountTxt.Text = string.Format("{0}{1}", (object)this.cliente.generalDiscount.ToString("n2"), this.cliente.isDiscountbyPercentage ? (object)"%" : (object)"");
                return;
            }
            if (!(num3 != this.cliente.generalDiscount) && flag == this.cliente.isDiscountbyPercentage || !(this.discountTxt.Text != ""))
                return;
            if (MessageBox.Show("Desea guardar los cambios efectuados", "Edición de Descuento del Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.cliente.generalDiscount = num3;
                this.cliente.isDiscountbyPercentage = flag;
                this.cliente.updateCustomerInfo();
            }
            else
                this.discountTxt.Text = this.cliente.isDiscountbyPercentage ? this.cliente.generalDiscount.ToString() + "%" : this.cliente.generalDiscount.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_ItemSelectionChanged(
          object sender,
          ListViewItemSelectionChangedEventArgs e)
        {
            DetalleCompraDataGridView1.Height = TotalLbl.Location.Y - DetalleCompraDataGridView1.Location.Y;
            this.fillGridView(e.ItemIndex);
            this.printTicketBtn.Text = this.listView1.SelectedItems.Count > 1 ? "Imprimir Tickets" : "Imprimir Ticket";
        }

        private void printTicketBtn_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count==0)
                return;
            try
            {
                prepareData(Convert.ToInt64(listView1.SelectedItems[0].SubItems[1].Text, 16));
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }
        }

        private async void prepareData(long saleID)
        {
            int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            string data;
            Font mainFont;
            var infoList = new List<Tuple<string, List<object>, bool>>();
            bool hasCancelledSales = false;

            PrinterTicket ticket = new PrinterTicket();
            if (listView1.SelectedItems.Count == 1)
            {
                Venta sale = await Task.Run(() => new Venta(saleID));
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
                mainFont = new Font("Times new roman", 17f, FontStyle.Bold);

                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
                    true));

                data = string.Format("Folio: {0}", sale.ID.ToString("X"));
                mainFont = width > 200 ? new Font("Times new Roman", 9.9f) : new Font("Times new Roman", 7f);

                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }), true));

                if (cliente.ID != 0)
                {
                    data = "Cliente: " + cliente.Name;
                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }), true));
                }

                data = string.Format("Fecha: {0} {1}", sale.Date.ToShortDateString(), sale.Date.ToShortTimeString());
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Near })
                    , true));

                //DataTable getSoldProducts = lastSale.getSoldProducts;
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
                foreach (DataRow row in sale.getSoldProducts.Rows)
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

                data = string.Format("Total: ${0}", sale.Total.ToString("n2"));//GetTotal().ToString("n2"));
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                                new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                                true));

                if (!sale.isPaid)
                {
                    data = string.Format("Usted pagó: ${0}", sale.Payment);
                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                        true));
                }

                data = string.Format("Efectivo: ${0}", sale.Cash);
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                    new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }), true));

                data = string.Format("Cambio: ${0}", (sale.Cash - sale.Payment));
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

                Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(sale.ID.ToString("X8"), 50);
                infoList.Add(new Tuple<string, List<object>, bool>("printImage",
                    new List<object>(new object[] { image, width, 35 }),
                    true));
            }
            else
            {
                DataTable dataTable = new DataTable();
                
                double accumulatedTotal = 0.0;

                dataTable.Columns.Add("Código de Barras");
                dataTable.Columns.Add("Descripción");
                dataTable.Columns.Add("Marca");
                dataTable.Columns.Add("Cantidad");
                dataTable.Columns.Add("Importe");
                dataTable.Columns.Add("Descuento");
                dataTable.Columns.Add("Total");
                foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
                {
                    Venta venta = await Task.Run(() => new Venta(Convert.ToInt64(selectedItem.SubItems[1].Text, 16)));

                    if (!venta.isSaleCanceled)
                    {
                        accumulatedTotal += (double)venta.Payment;
                        foreach (DataRow row in venta.getSoldProducts.Rows)
                            this.addItemToTable(row, dataTable);
                    }
                    else
                        hasCancelledSales = true;
                }

                
                mainFont = new Font("times new roman", 10f);

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
                
                data = "Resumen de Compras";
                mainFont = new Font("times new roman", 17f, FontStyle.Bold); //this.getFont(data, width, FontStyle.Bold);
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
               new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
               true));
                
                data = "Cliente: " + this.cliente.Name;
                mainFont = width > 200 ? new Font("Times new Roman", 9.9f) : new Font("Times new Roman", 7f);
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
               new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }),
               true));

                data = string.Format("Fecha: {0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
               new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }),
               true));

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

                foreach (DataRow row in dataTable.Rows)
                {
                    Producto producto = new Producto(row["Código de Barras"].ToString());
                    data = producto.HideInTicket ? "Artículo Varios" : string.Format("{0}, {1}", (object)producto.Description, (object)producto.Brand);
                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                           new List<object>(new object[] { data, mainFont, width, StringAlignment.Near }),
                           true));

                    data = row["Cantidad"].ToString();
                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] {data, mainFont, width, StringAlignment.Near }),
                        false));

                    data = string.Format("${0}", row["Importe"]);
                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                         new List<object>(new object[] { data, mainFont, width, StringAlignment.Center }),
                         false));


                    string str6 = "$" + Convert.ToDouble(row["Total"]).ToString("n2");
                    infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                        new List<object>(new object[] {data, mainFont, width, StringAlignment.Far }),
                        true));

                    var dis = Convert.ToDouble(row["Descuento"]);
                    
                    if (dis > 0)
                    {
                        data = string.Format("Descuento: -${0}", dis.ToString("n2")); //getDiscountFromRow(row.Index).ToString("n2"));
                        infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));

                        data = string.Format("Costo Final: ${0}", Convert.ToDouble(row["Total"]) - dis); //getTotalFromRow(row.Index).ToString("n2"));
                        infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));
                    }
                }
                infoList.Add(new Tuple<string, List<object>, bool>("drawLine",
                    new List<object>(new object[] { 10, width - 10 }),
                    true));

                data = string.Format("Total de las Ventas: ${0}", this.getTotal(dataTable).ToString("n2"));
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));


                data= string.Format("Pago realizado: ${0}", accumulatedTotal.ToString("n2"));

                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                               new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                               true));

                data= string.Format("Adeudo: ${0}", (this.getTotal(dataTable) - accumulatedTotal).ToString("n2"));
                infoList.Add(new Tuple<string, List<object>, bool>("printLine",
                            new List<object>(new object[] { data, mainFont, width, StringAlignment.Far }),
                            true));

            }
            var printdocument = new PrintDocument();
            printdocument.PrintController = new StandardPrintController();

            printdocument.PrintPage += (s, e) =>
            {
                printTicket(e.Graphics, infoList, e.PageSettings.PaperSize.Height);

                if (infoList.Count > 0)
                    e.HasMorePages = true;
            };
            printdocument.EndPrint += (s, e) =>
            {
                mainFont.Dispose();
                if (hasCancelledSales)
                    MessageBox.Show("Las ventas canceladas no fueron tomadas en cuenta");
            };


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

            while (location < maxHeight - 10 && infoList.Count > 0)
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

      
        private double getTotal(DataTable dt)
        {
            double num = 0.0;
            foreach (DataRow row in (InternalDataCollectionBase)dt.Rows)
                num += Convert.ToDouble(row["Total"]);
            return num;
        }

        private void addItemToTable(DataRow row, DataTable table)
        {
            bool flag = false;
            foreach (DataRow row1 in (InternalDataCollectionBase)table.Rows)
            {
                if (row["id_producto"].ToString() == row1["Código de Barras"].ToString())
                {
                    row1["Cantidad"] = (object)(Convert.ToDouble(row1["Cantidad"]) + Convert.ToDouble(row["Cantidad"])).ToString("n2");
                    row1["Importe"] = (object)(Convert.ToDouble(row1["Importe"]) + Convert.ToDouble(row["Importe"])).ToString("n2");
                    row1["Descuento"] = (object)(Convert.ToDouble(row1["Descuento"]) + Convert.ToDouble(row["Descuento"])).ToString("n2");
                    row1["Total"] = (object)(Convert.ToDouble(row1["Importe"]) - Convert.ToDouble(row1["Descuento"])).ToString("n2");
                    flag = true;
                    break;
                }
            }
            if (flag)
                return;
            DataRow row2 = table.NewRow();
            Producto producto = new Producto(row["id_producto"].ToString());
            row2["Código de Barras"] = (object)producto.Barcode;
            row2["Descripción"] = (object)producto.Description;
            row2["Marca"] = (object)producto.Brand;
            row2["Cantidad"] = row["Cantidad"];
            row2["Importe"] = row["Importe"];
            row2["Descuento"] = row["Descuento"];
            row2["Total"] = (object)(Convert.ToDouble(row["Importe"]) - Convert.ToDouble(row["Descuento"]));
            table.Rows.Add(row2);
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

        private void customerPaymentDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (!cliente.IsEmployee ())
            {
                if (cliente.Debt == 0)
                {

                    if (MessageBox.Show("¿Desea borrar la información del cliente?", "Borrar Cliente",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        cliente.Delete();
                        HideLabels();
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario liquidar el adeudo para realizar esta acción");
                }
            }
            else
            {
                MessageBox.Show("El cliente es un empleado. Para poder utilizar esta opción es necesario utilizar primero la opción \"Borrar Empleado\" en la" +
                    "ventana Empleados");
            }
        }
    }
}
