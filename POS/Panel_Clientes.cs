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
            DataTable dataTable = new DataTable();
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
            this.AddButton.Location = new Point(this.AddButton.Location.X, this.SearchTxt.Location.Y / 2 - this.AddButton.Height + 25);
            this.ListaClientesBtn.Size = this.AddButton.Size;
            this.ListaClientesBtn.Location = new Point(this.ListaClientesBtn.Location.X, this.SearchTxt.Location.Y / 2 - this.ListaClientesBtn.Height + 25);
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
        }

        private void FillDataList()
        {
            this.listView1.Clear();
            if (this.cliente.ID != 0)
            {
                this.NombreLbl.Text = this.cliente.Name;
                this.DireccionLbl.Text = this.cliente.Address;
                this.TelefonoLbl.Text = this.cliente.TelephoneNumber;
                this.discountTxt.Text = this.cliente.isDiscountbyPercentage ? this.cliente.generalDiscount.ToString("n2") + "%" : this.cliente.generalDiscount.ToString("n2");
                this.fitTextboxToContent();
                List<string[]> customerPurchases = this.cliente.GetCustomerPurchases();
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

        private void listView1_Click(object sender, EventArgs e)
        {
        }

        private void fillGridView(int index)
        {
            DataTable dataTable = new DataTable();
            string idHex = listView1.Items[index].SubItems[1].Text;

            Venta venta = new Venta(Convert.ToInt32(idHex, 16));
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
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
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
                            this.cliente.RegisterPayment(Convert.ToInt32(listViewItem.SubItems[1].Text, 16), DateTime.Now, cash1, this.EmployeeID);
                            this.cliente.Pay(cash1, Convert.ToInt32(listViewItem.SubItems[1].Text, 16));
                            num1 -= cash1;
                        }
                    }
                    FormCambio formCambio = new FormCambio(change);
                    this.customerPaymentDocument = new PrintDocument();
                    customerPaymentDocument.PrintController = new StandardPrintController();

                    this.customerPaymentDocument.PrintPage += (PrintPageEventHandler)((ss, ee) =>
                    {
                        PrinterTicket printerTicket = new PrinterTicket();
                        Graphics graphics = ee.Graphics;
                        this.customerPaymentDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 200, 200);
                        int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
                        int y1 = 10;
                        Size size1 = printerTicket.printLogo(graphics, y1);
                        int y2 = size1.Height == 0 ? y1 : y1 + size1.Height + 10;
                        Size size2 = printerTicket.printHeader(graphics, y2);
                        int y3 = size2.Height == 0 ? y2 : y2 + size2.Height + 10;
                        Size size3 = printerTicket.printAddress(graphics, y3);
                        int y4 = size3.Height == 0 ? y3 : y3 + size3.Height + 10;
                        Size size4 = printerTicket.printPhone(graphics, y4);
                        int num666 = size4.Height == 0 ? y4 : y4 + size4.Height + 10;
                        graphics.DrawLine(Pens.Black, 10, num666, width - 10, num666);
                        int num2 = num666 + 5;
                        string str1 = "Pago de Cliente";
                        Font font1 = this.getFont(str1, width, FontStyle.Regular);
                        Size stringSize1 = this.getStringSize(str1, font1);
                        graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)num2);
                        int num3 = num2 + (15 + stringSize1.Height);
                        if (this.cliente.ID != 0)
                        {
                            Font font2 = new Font("Times new Roman", 8f, FontStyle.Bold);
                            Size stringSize2 = this.getStringSize("Cliente: " + this.cliente.Name, font2);
                            graphics.DrawString("Cliente: " + this.cliente.Name, font2, Brushes.Black, 0.0f, (float)num3);
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
                        double num5 = Convert.ToDouble(form.Pay);
                        string str3 = string.Format("Adeudo Previo: ${0}", (object)(this.cliente.Debt + num5).ToString("n2"));
                        Font font4 = this.getFont(str3, width * 5 / 8, FontStyle.Regular);
                        Size stringSize4 = this.getStringSize(str3, font4);
                        graphics.DrawString(str3, font4, Brushes.Black, 0.0f, (float)num4);
                        int num6 = num4 + (stringSize4.Height + 3);
                        string str4 = string.Format("Monto a pagar: ${0}", (object)num5.ToString("n2"));
                        Size stringSize5 = this.getStringSize(str4, font4);
                        graphics.DrawString(str4, font4, Brushes.Black, 0.0f, (float)num6);
                        int num7 = num6 + (stringSize5.Height + 3);
                        string str5 = string.Format("Adeudo Actualizado: ${0}", (object)this.cliente.Debt.ToString("n2"));
                        Font font5 = this.getFont(str5, width * 3 / 4, FontStyle.Bold);
                        Size stringSize6 = this.getStringSize(str3, font5);
                        graphics.DrawString(str5, font5, Brushes.Black, 0.0f, (float)num7);
                        int num8 = num7 + (stringSize6.Height + 8);
                        string str6 = string.Format("Efectivo: ${0}", (object)cash.ToString("n2"));
                        Size stringSize7 = this.getStringSize(str6, font4);
                        graphics.DrawString(str6, font4, Brushes.Black, (float)(width - stringSize7.Width), (float)num8);
                        int num9 = num8 + (stringSize7.Height + 3);
                        string str7 = string.Format("Cambio: ${0}", (object)change.ToString("n2"));
                        Size stringSize8 = this.getStringSize(str7, font4);
                        graphics.DrawString(str7, font4, Brushes.Black, (float)(width - stringSize8.Width), (float)num9);
                        int y5 = num9 + (8 + stringSize8.Height);
                        Size size5 = printerTicket.printFooter(graphics, y5);
                        int num10 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
                    });
                    try
                    {
                        this.customerPaymentDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.customerPaymentDocument;
                        this.customerPaymentDocument.Print();
                    }
                    catch (InvalidPrinterException)
                    {
                        int num2 = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
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
                    int num13 = (int)MessageBox.Show("El Cliente no genera ningun adeudo");
                }
            }
            darkForm.Close();
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
            this.AddButton.Location = new Point((this.Width - this.AddButton.Width - this.ListaClientesBtn.Width) / 2, (this.Height - this.AddButton.Height) / 2);
            this.ListaClientesBtn.Location = new Point((this.Width + this.ListaClientesBtn.Width) / 2, (this.Height - this.ListaClientesBtn.Height) / 2);
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
                DataTable dataTable = new DataTable();
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
            this.fillGridView(e.ItemIndex);
            this.printTicketBtn.Text = this.listView1.SelectedItems.Count > 1 ? "Imprimir Tickets" : "Imprimir Ticket";
        }

        private void printTicketBtn_Click(object sender, EventArgs e)
        {
            if (this.DetalleCompraDataGridView1.DataSource == null)
                return;
            try
            {
                this.printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                this.printDialog1.Document = this.printDocument1;
                this.printDocument1.Print();
            }
            catch (InvalidPrinterException ex)
            {
                int num = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }
            this.printDocument1 = new PrintDocument();
            printDocument1.PrintController = new StandardPrintController();
            this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                PrinterTicket printerTicket = new PrinterTicket();
                int num1 = 0;
                foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
                {
                    Venta venta = new Venta(Convert.ToInt32(selectedItem.SubItems[1].Text, 16));
                    Cliente cliente = new Cliente(venta.CustomerID);
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Código de Barras");
                    dataTable.Columns.Add("Descripción");
                    dataTable.Columns.Add("Marca");
                    dataTable.Columns.Add("Cantidad");
                    dataTable.Columns.Add("Precio");
                    dataTable.Columns.Add("Total");
                    foreach (DataRow row1 in (InternalDataCollectionBase)venta.getSoldProducts.Rows)
                    {
                        DataRow row2 = dataTable.NewRow();
                        Producto producto = new Producto(row1["id_producto"].ToString());
                        row2["Código de Barras"] = (object)producto.Barcode;
                        row2["Descripción"] = (object)producto.Description;
                        row2["Marca"] = (object)producto.Brand;
                        row2["Cantidad"] = (object)Convert.ToDouble(row1["Cantidad"]).ToString("n2");
                        row2["Precio"] = (object)Convert.ToDouble(row1["Precio"]).ToString("n2");
                        row2["Total"] = Convert.ToDouble(row1["Descuento"]) > 0.0 ? (object)string.Format("{0}\n-{1}", (object)Convert.ToDouble(row1["Importe"]).ToString("n2"), (object)Convert.ToDouble(row1["Descuento"]).ToString("n2")) : (object)string.Format("{0}", (object)Convert.ToDouble(row1["Importe"]).ToString("n2"));
                        dataTable.Rows.Add(row2);
                    }
                    Graphics graphics1 = e.Graphics;
                    this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 200, 200);
                    int width1 = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
                    int y1 = num1 + 10;
                    Size size1 = printerTicket.printLogo(graphics1, y1);
                    int y2 = size1.Height == 0 ? y1 : y1 + size1.Height + 10;
                    Size size2 = printerTicket.printHeader(graphics1, y2);
                    int y3 = size2.Height == 0 ? y2 : y2 + size2.Height + 10;
                    Size size3 = printerTicket.printAddress(graphics1, y3);
                    int y4 = size3.Height == 0 ? y3 : y3 + size3.Height + 10;
                    Size size4 = printerTicket.printPhone(graphics1, y4);
                    int num2 = size4.Height == 0 ? y4 : y4 + size4.Height + 10;
                    graphics1.DrawLine(Pens.Black, 10, num2, width1 - 10, num2);
                    int num3 = num2 + 5;
                    string str1 = "Detalle de Venta";
                    Font font1 = this.getFont(str1, width1, FontStyle.Regular);
                    Size stringSize1 = this.getStringSize(str1, font1);
                    graphics1.DrawString(str1, font1, Brushes.Black, (float)((width1 - stringSize1.Width) / 2), (float)num3);
                    int num4 = num3 + (15 + stringSize1.Height);
                    string str2 = string.Format("Folio: {0}", (object)venta.ID.ToString("X"));
                    Font font2 = new Font("Times new Roman", 8f);
                    Size stringSize2 = this.getStringSize(str2, font2);
                    int num5;
                    if (stringSize2.Width + 10 < width1)
                    {
                        graphics1.DrawString(str2, font2, Brushes.Black, 10f, (float)num4);
                        num5 = num4 + (stringSize2.Height + 1);
                    }
                    else
                    {
                        font2 = this.getFont(str2, width1 - 10, FontStyle.Bold);
                        stringSize2 = this.getStringSize(str2, font2);
                        graphics1.DrawString(str2, font2, Brushes.Black, 10f, (float)num4);
                        num5 = num4 + (stringSize2.Height + 1);
                    }
                    if (cliente.ID != 0)
                    {
                        Size stringSize3 = this.getStringSize("Cliente: " + cliente.Name, font2);
                        graphics1.DrawString("Cliente: " + cliente.Name, font2, Brushes.Black, 10f, (float)num5);
                        num5 += stringSize3.Height + 10;
                    }
                    string str3 = string.Format("Fecha: {0}\t{1}", (object)venta.Date.ToShortDateString(), (object)venta.Date.ToShortTimeString());
                    Font font3 = new Font("Times new Roman", 8f);
                    int num6;
                    if (this.getStringSize(str3, font3).Width + 10 < width1)
                    {
                        graphics1.DrawString(str3, font3, Brushes.Black, 10f, (float)num5);
                        num6 = num5 + (stringSize2.Height + 1);
                    }
                    else
                    {
                        font2 = this.getFont(venta.ID.ToString(), width1 - 10, FontStyle.Bold);
                        stringSize2 = this.getStringSize(venta.ID.ToString(), font2);
                        graphics1.DrawString(venta.ID.ToString(), font2, Brushes.Black, 10f, (float)num5);
                        num6 = num5 + (stringSize2.Height + 1);
                    }
                    DataTable getSoldProducts = venta.getSoldProducts;
                    graphics1.DrawLine(Pens.Black, 10, num6, width1 - 10, num6);
                    int num7 = num6 + 1;
                    string text = "Cantidad\tPrecio\tImporte";
                    Font font4 = font2;
                    Size stringSize4 = this.getStringSize(text, font4);
                    graphics1.DrawString("Cantidad", font4, Brushes.Black, 10f, (float)num7);
                    graphics1.DrawString("Precio", font4, Brushes.Black, (float)((width1 - this.getStringSize("Precio", font4).Width) / 2), (float)num7);
                    graphics1.DrawString("Importe", font4, Brushes.Black, (float)(width1 - this.getStringSize("Importe", font4).Width), (float)num7);
                    int num8 = num7 + (stringSize4.Height + 1);
                    graphics1.DrawLine(Pens.Black, 10, num8, width1 - 10, num8);
                    int num9 = num8 + 2;
                    double num10 = 0.0;
                    foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
                    {
                        string str4 = new Producto(row["Código de Barras"].ToString()).HideInTicket ? "Artículo Varios" : string.Format("{0} {1}", row["Descripción"], row["Marca"]);
                        Font font5 = new Font(font4, FontStyle.Regular);
                        Size stringSize3 = this.getStringSize(str4, font5);
                        if (stringSize3.Width > width1)
                        {
                            int letterByMeasuring = this.getLastLetterByMeasuring(str4, font5, width1);
                            str4 = str4.Insert(letterByMeasuring, str4[letterByMeasuring] == ' ' ? "\n" : "-\n");
                            stringSize3 = this.getStringSize(str4, font5);
                        }
                        graphics1.DrawString(str4, font5, Brushes.Black, 10f, (float)num9);
                        num9 += stringSize3.Height + 2;
                        double num11 = row["Total"].ToString().IndexOf("-") > -1 ? Convert.ToDouble(row["Total"].ToString().Substring(row["Total"].ToString().IndexOf("-") + 1)) : 0.0;
                        string.Format("{0}\t{1}\t{2}", row["Cantidad"], row["Precio"], row["Total"].ToString().IndexOf("-") == -1 ? (object)Convert.ToDouble(row["Total"]).ToString("n2") : (object)row["Total"].ToString().Substring(0, row["Total"].ToString().IndexOf("-")));
                        Font font6 = font5;
                        Size stringSize5 = this.getStringSize("$" + row["Total"].ToString(), font6);
                        graphics1.DrawString(row["Cantidad"].ToString(), font6, Brushes.Black, 10f, (float)num9);
                        Graphics graphics2 = graphics1;
                        string s1 = "$" + row["Precio"].ToString();
                        Font font7 = font6;
                        Brush black1 = Brushes.Black;
                        int num12 = width1;
                        Size stringSize6 = this.getStringSize(row["Precio"].ToString(), font6);
                        int width2 = stringSize6.Width;
                        double num13 = (double)((num12 - width2) / 2);
                        double num14 = (double)num9;
                        graphics2.DrawString(s1, font7, black1, (float)num13, (float)num14);
                        Graphics graphics3 = graphics1;
                        string s2 = "$" + row["Total"].ToString();
                        Font font8 = font6;
                        Brush black2 = Brushes.Black;
                        int num15 = width1;
                        stringSize6 = this.getStringSize(row["Total"].ToString(), font6);
                        int width3 = stringSize6.Width;
                        double num16 = (double)(num15 - width3);
                        double num17 = (double)num9;
                        graphics3.DrawString(s2, font8, black2, (float)num16, (float)num17);
                        num10 += num11;
                        num9 += stringSize5.Height + 5;
                    }
                    graphics1.DrawLine(Pens.Black, 10, num9, width1 - 10, num9);
                    int num18 = num9 + 3;
                    string str5 = string.Format("Total: ${0}", (object)venta.Total.ToString("n2"));
                    Font font9 = font2;
                    Size stringSize7 = this.getStringSize(str5, font4);
                    graphics1.DrawString(str5, font9, Brushes.Black, (float)(width1 - stringSize7.Width), (float)num18);
                    int y5 = num18 + (stringSize7.Height + 3);
                    if (!venta.isPaid)
                    {
                        string str4 = string.Format("Usted pagó: ${0}", (object)venta.Payment);
                        Size stringSize3 = this.getStringSize(str4, font9);
                        graphics1.DrawString(str4, font9, Brushes.Black, (float)(width1 - stringSize3.Width), (float)y5);
                        y5 += stringSize3.Height + 3;
                    }
                    if (num10 > 0.0)
                    {
                        string str4 = string.Format("Usted ahorró: ${0}", (object)num10.ToString("n2"));
                        this.getFont(str4, width1 / 2 - 10, FontStyle.Bold);
                        Size stringSize3 = this.getStringSize(str4, font9);
                        graphics1.DrawString(str4, font9, Brushes.Black, (float)(width1 - stringSize3.Width), (float)y5);
                        y5 += stringSize3.Height + 20;
                    }
                    if (venta.isSaleCanceled)
                    {
                        string str4 = "Cancelada";
                        Font font5 = this.getFont(str4, width1, FontStyle.Bold);
                        this.getStringSize(str4, font5);
                        GraphicsState gstate = graphics1.Save();
                        graphics1.ResetTransform();
                        graphics1.RotateTransform(315f);
                        graphics1.TranslateTransform(0.0f, (float)y5, MatrixOrder.Append);
                        graphics1.DrawString(str4, font5, (Brush)new SolidBrush(Color.FromArgb(50, 0, 0, 0)), 0.0f, 0.0f);
                        graphics1.Restore(gstate);
                    }
                    Size size5 = printerTicket.printFooter(graphics1, y5);
                    int y6 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
                    Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(venta.ID.ToString("X8"), 50);
                    graphics1.DrawImage(image, 10, y6, width1 - 10, 20);
                    num1 = y6 + (image.Height + 10);
                }
            }
            else
            {
                if (this.listView1.SelectedItems.Count <= 1)
                    return;
                DataTable dataTable = new DataTable();
                bool hasCancelledSales = false;
                double num1 = 0.0;
                dataTable.Columns.Add("Código de Barras");
                dataTable.Columns.Add("Descripción");
                dataTable.Columns.Add("Marca");
                dataTable.Columns.Add("Cantidad");
                dataTable.Columns.Add("Importe");
                dataTable.Columns.Add("Descuento");
                dataTable.Columns.Add("Total");
                foreach (ListViewItem selectedItem in this.listView1.SelectedItems)
                {
                    Venta venta = new Venta(Convert.ToInt32(selectedItem.SubItems[1].Text, 16));
                    if (!venta.isSaleCanceled)
                    {
                        num1 += (double)venta.Payment;
                        foreach (DataRow row in (InternalDataCollectionBase)venta.getSoldProducts.Rows)
                            this.addItemToTable(row, dataTable);
                    }
                    else
                        hasCancelledSales = true;
                }
                Graphics graphics = e.Graphics;
                PrinterTicket printerTicket = new PrinterTicket();
                Font font1 = new Font("times new roman", 8f);
                int y1 = 0;
                int width = (int)this.printDocument1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
                Size size1 = printerTicket.printLogo(graphics, y1);
                int y2 = size1.Height == 0 ? y1 : y1 + size1.Height + 10;
                Size size2 = printerTicket.printHeader(graphics, y2);
                int y3 = size2.Height == 0 ? y2 : y2 + size2.Height + 10;
                Size size3 = printerTicket.printAddress(graphics, y3);
                int y4 = size3.Height == 0 ? y3 : y3 + size3.Height + 10;
                Size size4 = printerTicket.printPhone(graphics, y4);
                int num2 = size4.Height == 0 ? y4 : y4 + size4.Height + 10;
                graphics.DrawLine(Pens.Black, 10, num2, width - 10, num2);
                int num3 = num2 + 5;
                string str1 = "Resumen de Compras";
                Font font2 = this.getFont(str1, width, FontStyle.Bold);
                Size stringSize1 = this.getStringSize(str1, font2);
                graphics.DrawString(str1, font2, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)num3);
                int num4 = num3 + (stringSize1.Height + 3);
                string str2 = "Cliente: " + this.cliente.Name;
                Font font3 = font1;
                Size stringSize2 = this.getStringSize(str2, font3);
                if (stringSize2.Width > width)
                {
                    int letterByMeasuring = this.getLastLetterByMeasuring(str2, font3, width);
                    str2 = str2.Insert(letterByMeasuring, str2[letterByMeasuring] == ' ' ? "\n" : "-\n");
                    stringSize2 = this.getStringSize(str2, font3);
                }
                graphics.DrawString(str2, font3, Brushes.Black, 0.0f, (float)num4);
                int num5 = num4 + (stringSize2.Height + 3);
                string str3 = string.Format("Fecha: {0}\t{1}", (object)DateTime.Now.ToShortDateString(), (object)DateTime.Now.ToShortTimeString());
                Font font4 = new Font("Times new Roman", 8f);
                Size stringSize3 = this.getStringSize(str3, font4);
                int num6;
                if (stringSize3.Width + 10 < width)
                {
                    graphics.DrawString(str3, font4, Brushes.Black, 10f, (float)num5);
                    num6 = num5 + (stringSize3.Height + 1);
                }
                else
                {
                    graphics.DrawString(str3, font4, Brushes.Black, 10f, (float)num5);
                    num6 = num5 + (stringSize3.Height + 1);
                }
                graphics.DrawLine(Pens.Black, 0, num6, width - 10, num6);
                int num7 = num6 + 1;
                Size stringSize4 = this.getStringSize("Cantidad\tImporte\tTotal", font1);
                graphics.DrawString("Cantidad", font1, Brushes.Black, 0.0f, (float)num7);
                graphics.DrawString("Importe", font1, Brushes.Black, (float)((width - this.getStringSize("Importe", font1).Width) / 2), (float)num7);
                graphics.DrawString("Total", font1, Brushes.Black, (float)(width - this.getStringSize("Total", font1).Width), (float)num7);
                int num8 = num7 + (stringSize4.Height + 1);
                graphics.DrawLine(Pens.Black, 10, num8, width - 10, num8);
                int num9 = num8 + 2;
                foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
                {
                    Producto producto = new Producto(row["Código de Barras"].ToString());
                    string str4 = producto.HideInTicket ? "Artículo Varios" : string.Format("{0}, {1}", (object)producto.Description, (object)producto.Brand);
                    Size stringSize5 = this.getStringSize(str4, font1);
                    if (stringSize5.Width > width)
                    {
                        int letterByMeasuring = this.getLastLetterByMeasuring(str4, font1, width);
                        str4 = str4.Insert(letterByMeasuring, str4[letterByMeasuring] == ' ' ? "\n" : "-\n");
                        stringSize5 = this.getStringSize(str4, font1);
                    }
                    graphics.DrawString(str4, font1, Brushes.Black, 0.0f, (float)num9);
                    num9 += stringSize5.Height + 2;
                    string s = row["Cantidad"].ToString();
                    graphics.DrawString(s, font1, Brushes.Black, 0.0f, (float)num9);
                    string str5 = Convert.ToDouble(row["Descuento"]) > 0.0 ? string.Format(" ${0}\n-${1}", row["Importe"], row["Descuento"]) : string.Format("${0}", row["Importe"]);
                    Size stringSize6 = this.getStringSize(str5, font1);
                    graphics.DrawString(str5, font1, Brushes.Black, (float)((width - stringSize6.Width) / 2), (float)num9);
                    string str6 = "$" + Convert.ToDouble(row["Total"]).ToString("n2");
                    Size stringSize7 = this.getStringSize(str6, font1);
                    graphics.DrawString(str6, font1, Brushes.Black, (float)(width - stringSize7.Width), (float)num9);
                    num9 += stringSize6.Height + 3;
                }
                graphics.DrawLine(Pens.Black, 10, num9, width - 10, num9);
                int num10 = num9 + 3;
                string str7 = string.Format("Total de las Ventas: ${0}", (object)this.getTotal(dataTable).ToString("n2"));
                Size stringSize8 = this.getStringSize(str7, font1);
                graphics.DrawString(str7, font1, Brushes.Black, (float)(width - stringSize8.Width), (float)num10);
                int num11 = num10 + (stringSize8.Height + 3);
                string str8 = string.Format("Pago realizado: ${0}", (object)num1.ToString("n2"));
                Size stringSize9 = this.getStringSize(str8, font1);
                graphics.DrawString(str8, font1, Brushes.Black, (float)(width - stringSize9.Width), (float)num11);
                int num12 = num11 + (stringSize9.Height + 3);
                string str9 = string.Format("Adeudo: ${0}", (object)(this.getTotal(dataTable) - num1).ToString("n2"));
                Size stringSize10 = this.getStringSize(str9, font1);
                graphics.DrawString(str9, font1, Brushes.Black, (float)(width - stringSize10.Width), (float)num12);
                this.printDocument1.EndPrint += (PrintEventHandler)((ss, ee) =>
                {
                    if (!hasCancelledSales)
                        return;
                    int num = (int)MessageBox.Show("Las ventas canceladas no fueron tomadas en cuenta");
                });
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

       
    }
}
