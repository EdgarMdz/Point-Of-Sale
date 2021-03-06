using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Microsoft.PointOfService;

namespace POS
{
    public partial class Panel_productos_Faltantes_Bodega : Form
    {
        private PrinterTicket printer = new PrinterTicket();
        private Bodega depot;
        PosPrinter posPrinter;

        public Panel_productos_Faltantes_Bodega(int depotID)
        {
            this.InitializeComponent();
            this.depot = new Bodega(depotID);
            this.dataGrid1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.printer = new PrinterTicket();
            this.printDialog1.PrinterSettings.PrinterName = this.printer.printerName;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid1_DataSourceChanged(object sender, EventArgs e)
        {
            (dataGrid1.Columns["imprimir"] as DataGridViewCheckBoxColumn).TrueValue = true;
            (dataGrid1.Columns["imprimir"] as DataGridViewCheckBoxColumn).FalseValue = false;
            dataGrid1.Columns["id_producto"].Visible = false;
            foreach (DataGridViewColumn item in dataGrid1.Columns)
            {
                item.AutoSizeMode = item.Name == "Descripción" ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells;
            }

            /*DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            viewCheckBoxColumn.Name = "Print";
            viewCheckBoxColumn.HeaderText = "";
            viewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            viewCheckBoxColumn.TrueValue = (object)true;
            viewCheckBoxColumn.FalseValue = (object)false;
            this.dataGrid1.Columns.Insert(0, (DataGridViewColumn)viewCheckBoxColumn);
            this.dataGrid1.Columns[viewCheckBoxColumn.Name].Frozen = true;*/
            //this.adjustColumsSize();
           /* foreach (DataGridViewRow row in this.dataGrid1.Rows)
            {
                row.Cells[viewCheckBoxColumn.Name].Value = Convert.ToBoolean(row.Cells["Checked"].Value) ?
                   viewCheckBoxColumn.TrueValue : viewCheckBoxColumn.FalseValue;

           }*/
           /* try
            {
                dataGrid1.Columns["Cheked"].Visible = false;
            }
            catch (Exception){ dataGrid1.Columns.Remove("Checked"); }*/
        }

        private void adjustColumsSize()
        {
            int num = 0;
            for (int index = 0; index < this.dataGrid1.Columns.Count; ++index)
            {
                this.dataGrid1.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                num += this.dataGrid1.Columns[index].Width;
            }
            if (num >= this.dataGrid1.Width)
                return;
            this.dataGrid1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Panel_productos_Faltantes_Bodega_Load(object sender, EventArgs e)
        {
            this.dataGrid1.CurrentCell = (DataGridViewCell)null;
            this.dataGrid1.DataSource = (object)this.depot.MissingProducts().DefaultView;
            // setCheckAllBtn();

            try
            {
                //Create PosExplorer
                PosExplorer posExplorer = new PosExplorer();
             
                try
                {
                    posPrinter = posExplorer.CreateInstance(posExplorer.GetDevice(DeviceType.PosPrinter, "PosPrinter")) as PosPrinter;
                    posPrinter.Open();
                   
                }
                catch (Exception) { }
            }
            catch (PosControlException)
            {
                //Nothing can be used.
                MessageBox.Show("No se tuvo acceso a la impresora o al cajon");
            }
        }

        private async void setCheckAllBtn()
        {
            await Task.Run(() => checkTable(ref dataGrid1, ref bunifuCheckbox1));
        }

        private void checkTable(ref BunifuCustomDataGrid dataGrid, ref BunifuCheckbox bunifuCheckbox)
        {
            int rowCount = dataGrid.RowCount;

            if (rowCount > 1)
            {
                for (int i = 1; i < rowCount; i++)
                {
                    if (Convert.ToBoolean(dataGrid1.Rows[i - 1].Cells["Imprimir"].Value) != Convert.ToBoolean(dataGrid1.Rows[i].Cells["Imprimir"].Value))
                    {
                        bunifuCheckbox.Checked = false;
                        return;
                    }
                }
               // bunifuCheckbox.Checked = true;//Convert.ToBoolean(dataGrid1.Rows[0].Cells["Imprimir"].Value);
            }
        }

        private void dataGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1)
                return;
            if (!Convert.ToBoolean(this.dataGrid1[e.ColumnIndex, e.RowIndex].Value))
                this.dataGrid1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DimGray;
            else
                this.dataGrid1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (this.bunifuCheckbox1.Checked)
            {
                foreach (DataGridViewRow row in this.dataGrid1.Rows)
                    row.Cells["Imprimir"].Value = true;
            }
            else
            {
                foreach (DataGridViewRow row in this.dataGrid1.Rows)
                    row.Cells["imprimir"].Value = false;
            }
        }

        private void dataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGrid1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                posPrinter.Claim(1000);
                posPrinter.DeviceEnabled=true;
                posPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|4C" + "\u001b|bC" + "\u001b|cA" + "Lista de Faltantes\n");


                string divisionLine = "_".PadLeft(posPrinter.RecLineChars - 2, '_');
                posPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + divisionLine + "\n");
                posPrinter.PrintNormal(PrinterStation.Receipt, "Stock Actual\tCantidad Faltante\tProducto\n");
                posPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + divisionLine + "\n");

                foreach (DataGridViewRow row in dataGrid1.Rows)
                {
                    if(Convert.ToBoolean(row.Cells["imprimir"].Value))
                    {
                        posPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|N" + row.Cells["Stock actual"].Value.ToString() + "\t" + row.Cells["Faltante"].Value.ToString()
                            + "\t" + row.Cells["descripción"].Value.ToString()+", "+ row.Cells["marca"].Value.ToString()+"\n");
                    }
                }

                posPrinter.PrintNormal(PrinterStation.Receipt, "\u001b|fP");

                posPrinter.DeviceEnabled = false;
                posPrinter.Release();
            }
            catch
            {

            }
            
            
            /*
            try
            {
                PrintDocument printDocument = new PrintDocument() { PrintController = new StandardPrintController() };
                
                printDocument.PrinterSettings.PrinterName = this.printer.printerName;
                this.printDialog1.Document = printDocument;
                printDocument.PrintPage += new PrintPageEventHandler(this.prepareTicket);
                printDocument.Print();
            }
            catch (InvalidPrinterException)
            {
                int num = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }*/
        }

        private void prepareTicket(object sender, PrintPageEventArgs e)
        {
            /*int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
            int num1 = 0;
            Graphics graphics = e.Graphics;
            string str1 = string.Format("Faltantes {0}", (object)this.depot.name);
            Font font1 = this.fitFont(str1, width, FontStyle.Bold);
            Size stringSize1 = this.getStringSize(str1, font1);
            graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)num1);
            int num2 = num1 + (stringSize1.Height + 5);
            string str2 = "Cantidad";
            Font font2 = new Font("Times new roman", 12f);
            Size stringSize2 = this.getStringSize(str2, font2);
            graphics.DrawLine(Pens.Black, 10, num2, this.Width - 10, num2);
            int num3 = num2 + 2;
            graphics.DrawString("Producto", font2, Brushes.Black, 0.0f, (float)num3);
            graphics.DrawString(str2, font2, Brushes.Black, (float)(width - stringSize2.Width), (float)num3);
            int num4 = num3 + (stringSize2.Height + 2);
            graphics.DrawLine(Pens.Black, 10, num4, this.Width - 10, num4);
            int num5 = num4 + 2; 
           /* DataTable checkboxes = new DataTable();

            checkboxes.Columns.Add("barcode");
            checkboxes.Columns.Add("isChecked");



            foreach (DataGridViewRow row in this.dataGrid1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Print"].Value))
                {
                    Producto producto = new Producto(row.Cells["Código de Barras"].Value.ToString());
                    Font font3 = font2;
                    string str3 = string.Format("{0}\n{1}", (object)producto.Description, (object)producto.Brand);
                    string str4 = row.Cells["Cantidad Faltante"].Value.ToString();
                    Size stringSize3 = this.getStringSize(str3, font3);
                    Size stringSize4 = this.getStringSize(str4, font3);
                    if (stringSize3.Width > width / 2)
                    {
                        font3 = this.fitFont(str3, width * 3 / 4 - 5, FontStyle.Regular);
                        stringSize3 = this.getStringSize(str3, font3);
                        stringSize4 = this.getStringSize(str4, font3);
                    }
                    graphics.DrawString(str3, font3, Brushes.Black, 0.0f, (float)num5);
                    graphics.DrawString(str4, font3, Brushes.Black, (float)(width - stringSize4.Width), (float)num5);
                    if (row.Index % 2 == 0)
                    {
                        SolidBrush solidBrush = new SolidBrush(Color.FromArgb(242, 242, 242));
                        graphics.FillRectangle((Brush)solidBrush, 0, num5, 0, num5 + stringSize3.Height);
                    }
                    graphics.DrawLine(Pens.Black, 10, num5, this.Width - 10, num5);
                    num5 += 3 + stringSize3.Height;
                }

                DataRow r = checkboxes.NewRow();
                r[0] = row.Cells[1].Value.ToString();
                r[1] = Convert.ToBoolean(row.Cells["Print"].Value);

                checkboxes.Rows.Add(r);
            }


            Bodega.updateProductCheckStatus(depot.ID, checkboxes);*/
        }

        private Font fitFont(string text, int width, FontStyle style = FontStyle.Regular)
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

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            var cell = dataGrid1.CurrentCell;
        }

        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGrid1.Columns["Imprimir"].Index)
            {
                var cell= (dataGrid1[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell);

                cell.Value = Convert.ToBoolean(dataGrid1[e.ColumnIndex, e.RowIndex].Value) == true ? cell.FalseValue : cell.TrueValue;
                Bodega.updateProductCheckStatus(depot.ID, dataGrid1.Rows[e.RowIndex].Cells["id_producto"].Value.ToString());
                dataGrid1.EndEdit();
            }    
        }

        private void Panel_productos_Faltantes_Bodega_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (posPrinter != null)
            {
                try
                {
                    //Cancel the device
                    posPrinter.DeviceEnabled = false;

                    //Release the device exclusive control right.
                    posPrinter.Release();
                    //Finish using the device.
                    posPrinter.Close();

                }
                catch (PosControlException)
                {
                    //Finish using the device.
                    posPrinter.Close();
                }
            }

            dataGrid1.Dispose();
        }
    }
}
