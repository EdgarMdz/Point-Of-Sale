using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zen.Barcode;
using System.Threading;
using System.Data;
using System.Threading.Tasks;
using System.IO;

namespace POS
{
    public partial class panel_Productos_Importar_desde_excel : Form
    {
        CancellationTokenSource cancellationSource = null; 

        private delegate void formatCellDelegate(DataGridViewCellEventArgs args);

        public panel_Productos_Importar_desde_excel()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
            setDataGridviewColumns();
            hideProgressPanel();
        }

        void hideProgressPanel()
        {
            panel3.Hide();
            openFileBtn.Enabled = true;
            copyTemplateBtn.Enabled = true;
            ImportBtn.Enabled = true;
            closeBtn.Enabled = true;
        }

        void showProgressPanel()
        {
            progressBar1.Value = 0;
            progressLbl.Text = "0%";
            panel3.Show();
            openFileBtn.Enabled = false;
            copyTemplateBtn.Enabled = false;
            ImportBtn.Enabled = false;
            closeBtn.Enabled = false;
        }
        private async void loadtable(string filePath)
        {
            cancellationSource = new CancellationTokenSource();
            var token = cancellationSource.Token;

            showProgressPanel();

            dataGridView1.CellValidating -= dataGridView1_CellValidating;
            this.Cursor = Cursors.WaitCursor;
            dataGridView1.Rows.Clear();

            Excel.Application exApp = new Excel.Application();
            exApp.ScreenUpdating = true;
            //exApp.Visible = true;
            exApp.Interactive = true;
            exApp.IgnoreRemoteRequests = false;

            Workbook workbook = await Task.Run(() => exApp.Workbooks.Open(filePath));
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Cells.FormatConditions.Delete();


            Range range = worksheet.UsedRange;

            try
            {
                List<DataGridViewRow> rowList = new List<DataGridViewRow>();

                if (workbook != null)
                {
                    try
                    {
                        await Task.Run(() =>
                        {
                            for (int i = 2; i <= range.Rows.Count; i++)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView1);
                                int count = 0;

                                for (int j = 1; j <= 11; j++)
                                {
                                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                                    {
                                        if (j < 10)
                                        {
                                            var cell = range.Cells[i, j].Value2;
                                            row.Cells[j - 1].Value = cell != null ? cell.ToString() : "";
                                        }
                                        else
                                        {
                                            var cell = range.Cells[i, j].Value2.ToString().ToLower();
                                            if (cell == "sí" || cell =="si")
                                                (row.Cells[j - 1] as DataGridViewComboBoxCell).Value = (row.Cells[j - 1] as DataGridViewComboBoxCell).Items[0];
                                            else
                                            {
                                                (row.Cells[j - 1] as DataGridViewComboBoxCell).Value = (row.Cells[j - 1] as DataGridViewComboBoxCell).Items[1];
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (j < 10)
                                        {
                                            row.Cells[j - 1].Value = "";
                                            
                                        }
                                        else
                                        {
                                            (row.Cells[j - 1] as DataGridViewComboBoxCell).Value = (row.Cells[j - 1] as DataGridViewComboBoxCell).Items[1];

                                        }
                                        count++;
                                    }

                                    if (token.IsCancellationRequested)
                                        throw new OperationCanceledException();

                                }
                                if (count < dataGridView1.Columns.Count)
                                    rowList.Add(row);


                                var percentage = (i / (range.Rows.Count - 2.0)) * 100.0;
                                progressBar1.Value =  Convert.ToInt32(percentage)<100? Convert.ToInt32(percentage) : 99;
                                progressLbl.Text = percentage < 100 ? percentage.ToString("n2") + "%" : "99.99";
                            }

                        });
                    }
                    catch (OperationCanceledException)
                    {
                        rowList.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo");
                }

                if (rowList.Count > 0)
                {
                    if (dataGridView1 != null && dataGridView1.Columns.Count > 0)
                        dataGridView1.Rows.AddRange(rowList.ToArray());
                    formatCells();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos en el archivo");
                }
            }

            catch (COMException)
            {
                MessageBox.Show("El archivo se ha cerrado");
            }
            finally
            {
                workbook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                exApp.Quit();


                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(exApp);
            }
            this.Cursor = Cursors.Default;
            hideProgressPanel();

        }

        private async void formatCells()
        {
            cancellationSource = new CancellationTokenSource();
            var token = cancellationSource.Token;
            try
            {
                await Task.Run(() =>
                {
                    beginFormatting(token);
                });


            }
            catch (OperationCanceledException)
            {
            }
            catch(ObjectDisposedException)
            {
            
            }
            finally
            {
                cancellationSource.Dispose();
            }
            if (dataGridView1 != null)
                dataGridView1.CellValidating += dataGridView1_CellValidating;
        }

        private void beginFormatting(CancellationToken token)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    formatCell(new DataGridViewCellEventArgs(column.Index, row.Index));

                    if(token.IsCancellationRequested)
                    {
                        throw new OperationCanceledException();
                    }
                }
            }
        }

        private void setDataGridviewColumns()
        {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "barcode", HeaderText = "Código de Barras" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "description", HeaderText = "Descripción" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "brand", HeaderText = "Marca" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "retailCost", HeaderText = "Precio de Menudeo" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "costPerCase", HeaderText = "Precio por Caja" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "piecesPerCase", HeaderText = "Piezas por Caja" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "purchaseCost", HeaderText = "Precio de Compra" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Stock", HeaderText = "Stock Actual" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "minStock", HeaderText = "Stock Mínimo" });
            
            dataGridView1.Columns.Add(new DataGridViewComboBoxColumn() { Name = "IsPackage", HeaderText = "¿Es Envase?" });
            (dataGridView1.Columns["ispackage"] as DataGridViewComboBoxColumn).Items.AddRange(new string[] { "Sí", "No" });
            

            dataGridView1.Columns.Add(new DataGridViewComboBoxColumn() { Name = "Kg", HeaderText = "¿Se vende a granel?" });
            (dataGridView1.Columns["kg"] as DataGridViewComboBoxColumn).Items.AddRange(new string[] { "Sí", "No" });
            

            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["barcode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void panel_Productos_Importar_desde_excel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancellationSource != null)
                cancellationSource.Cancel();
        }

        private void closeBtn_Click_1(object sender, System.EventArgs e)
        {
            if (cancellationSource != null)
                try { cancellationSource.Cancel(); }
                catch (Exception) { }
            this.Close();
        }

        private void panel_Productos_Importar_desde_excel_Load(object sender, System.EventArgs e)
        {
            closeBtn.Location = new System.Drawing.Point(panel1.Width - closeBtn.Width - 3, closeBtn.Location.Y);
        }

        private void panel_Productos_Importar_desde_excel_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(0, 130, 170)))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            formatCell(e);
        }

        private void formatCell(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.InvokeRequired)
            {
                var del = new formatCellDelegate(formatCell);

                dataGridView1.Invoke(del, new object[] { e });
            }
            else
            {

                if (e.ColumnIndex == dataGridView1.Columns["barcode"].Index)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["barcode"].Value != null && Producto.SearchProduct(dataGridView1.Rows[e.RowIndex].Cells["barcode"].Value.ToString())
                        && dataGridView1.Rows[e.RowIndex].Cells["barcode"].Style.ForeColor != Color.Tomato)
                        dataGridView1.Rows[e.RowIndex].Cells["barcode"].Style.ForeColor = Color.Tomato;
                    else
                        if (dataGridView1.Rows[e.RowIndex].Cells["barcode"].Style.ForeColor != Color.Black)
                        dataGridView1.Rows[e.RowIndex].Cells["barcode"].Style.ForeColor = Color.Black;
                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["description"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["description"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString().Trim() == "")
                        && dataGridView1.Rows[e.RowIndex].Cells["description"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["description"].Value = "Sin Descripción";
                        dataGridView1.Rows[e.RowIndex].Cells["description"].Style.ForeColor = Color.Tomato;
                    }
                    else
                        if (dataGridView1.Rows[e.RowIndex].Cells["description"].Style.ForeColor != Color.Black)
                        dataGridView1.Rows[e.RowIndex].Cells["description"].Style.ForeColor = Color.Black;

                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["retailcost"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Value.ToString().Trim() == "") &&
                        dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Value = 1.00;
                        dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Style.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        try
                        {
                            var number = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Value);
                            if (number <= 0)
                                throw new FormatException("El valor debe ser mayor a cero");

                            if (dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Style.ForeColor != Color.Black)
                                dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Style.ForeColor = Color.Black;
                        }
                        catch (FormatException)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Style.ForeColor != Color.Tomato)
                                dataGridView1.Rows[e.RowIndex].Cells["retailcost"].Style.ForeColor = Color.Tomato;
                        }
                    }

                    return;
                }


                if (e.ColumnIndex == dataGridView1.Columns["costpercase"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Value.ToString().Trim() == "")
                        && dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Value = 0;
                        dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Style.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        try
                        {
                            var number = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Value);
                            if (number <= 0)
                                throw new FormatException("El valor debe ser mayor a cero");

                            if (dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Style.ForeColor != Color.Black)
                                dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Style.ForeColor = Color.Black;
                        }
                        catch (FormatException)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Style.ForeColor != Color.Tomato)
                                dataGridView1.Rows[e.RowIndex].Cells["costPerCase"].Style.ForeColor = Color.Tomato;
                        }
                    }
                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["piecespercase"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Value.ToString().Trim() == "")
                        && dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Value = 1.00;
                        dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Style.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        try
                        {
                            var number = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Value);

                            if (number < 1)
                                throw new FormatException("El valor debe ser positivo");

                            if (dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Style.ForeColor != Color.Black)
                                dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Style.ForeColor = Color.Black;
                        }
                        catch (FormatException)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Style.ForeColor != Color.Tomato)
                                dataGridView1.Rows[e.RowIndex].Cells["piecespercase"].Style.ForeColor = Color.Tomato;
                        }

                    }

                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["purchaseCost"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Value.ToString().Trim() == "")
                        && dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Value = 0.00;
                        dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Style.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        try
                        {
                            var number = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Value);

                            if (number < 0)
                                throw new FormatException("El valor debe ser positivo");

                            if (dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Style.ForeColor != Color.Black)
                                dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Style.ForeColor = Color.Black;
                        }
                        catch (FormatException)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Style.ForeColor != Color.Tomato)
                                dataGridView1.Rows[e.RowIndex].Cells["purchasecost"].Style.ForeColor = Color.Tomato;
                        }

                    }

                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["stock"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["stock"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["stock"].Value.ToString().Trim() == "")
                        && dataGridView1.Rows[e.RowIndex].Cells["stock"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["stock"].Value = 0.00;
                        dataGridView1.Rows[e.RowIndex].Cells["stock"].Style.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        try
                        {
                            var number = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["stock"].Value);

                            if (number < 0)
                                throw new FormatException("El valor debe ser positivo");

                            if (dataGridView1.Rows[e.RowIndex].Cells["stock"].Style.ForeColor != Color.Black)
                                dataGridView1.Rows[e.RowIndex].Cells["stock"].Style.ForeColor = Color.Black;
                        }
                        catch (FormatException)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["stock"].Style.ForeColor != Color.Tomato)
                                dataGridView1.Rows[e.RowIndex].Cells["stock"].Style.ForeColor = Color.Tomato;
                        }

                    }

                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["minstock"].Index)
                {
                    if ((dataGridView1.Rows[e.RowIndex].Cells["minstock"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["minstock"].Value.ToString().Trim() == "")
                        && dataGridView1.Rows[e.RowIndex].Cells["minstock"].Style.ForeColor != Color.Tomato)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["minstock"].Value = 0.00;
                        dataGridView1.Rows[e.RowIndex].Cells["minstock"].Style.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        try
                        {
                            var number = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["minstock"].Value);

                            if (number < 0)
                                throw new FormatException("El valor debe ser positivo");

                            if (dataGridView1.Rows[e.RowIndex].Cells["minstock"].Style.ForeColor != Color.Black)
                                dataGridView1.Rows[e.RowIndex].Cells["minstock"].Style.ForeColor = Color.Black;
                        }
                        catch (FormatException)
                        {
                            if (dataGridView1.Rows[e.RowIndex].Cells["minstock"].Style.ForeColor != Color.Tomato)
                                dataGridView1.Rows[e.RowIndex].Cells["minstock"].Style.ForeColor = Color.Tomato;
                        }
                    }
                }
            }
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Hoja de Cálculo (*.xlsx) | *.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (cancellationSource != null)
                {
                    try { cancellationSource.Cancel(); }
                    catch (ObjectDisposedException) { }
                }
                loadtable(dialog.FileName);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        { 
            if(dataGridView1.RowCount==0)
                            return;
            
            int count = 0;
            dataGridView1.EndEdit();
            for (int j = 0;j<dataGridView1.Rows.Count;j++)
            {
                int i = -1;
                var row = dataGridView1.Rows[j];


                try
                {
                    if (Producto.SearchProduct(row.Cells["barcode"].Value.ToString()))
                        throw new Exception("the given barcode is alredy registered in the database");

                    Producto p = new Producto();
                    p.Barcode = row.Cells["barcode"].Value.ToString();
                    i++;

                    p.Description = row.Cells["description"].Value.ToString();
                    i++;

                    p.Brand = row.Cells["Brand"].Value.ToString();
                    i++;

                    p.RetailCost = Convert.ToDouble(row.Cells["retailcost"].Value);
                    i++;

                    p.CostPerCase = Convert.ToDouble(row.Cells["costpercase"].Value);
                    i++;

                    p.PiecesPerCase = Convert.ToDouble(row.Cells["piecesPerCase"].Value);
                    i++;

                    p.PurchaseCost = Convert.ToDouble(row.Cells["purchasecost"].Value);
                    i++;

                    p.CurrentStock = Convert.ToDouble(row.Cells["stock"].Value);
                    i++;

                    p.minStock = Convert.ToDouble(row.Cells["minStock"].Value);
                    i++;


                    p.defaultDepotID = 1;
                    p.isReturnable = (row.Cells["ispackage"] as DataGridViewComboBoxCell).Value.ToString() == "No" ? false : true;
                    p.displayAsKilogram = (row.Cells["kg"] as DataGridViewComboBoxCell).Value.ToString() == "No" ? false : true;
                    p.HideInTicket = false;

                    p.addProduct();

                    dataGridView1.Rows.Remove(row);
                    j--;
                    count++;
                }
                catch (Exception)
                {
                    switch (i)
                    {
                        case -1:
                            row.Cells["barcode"].Style.ForeColor = Color.Tomato;
                            break;
                        case 0:
                            row.Cells["description"].Style.ForeColor = Color.Tomato;
                            break;
                        case 1:
                            row.Cells["brand"].Style.ForeColor = Color.Tomato;
                            break;
                        case 2:
                            row.Cells["retailcost"].Style.ForeColor = Color.Tomato;
                            break;
                        case 3:
                            row.Cells["costPerCase"].Style.ForeColor = Color.Tomato;
                            break;
                        case 4:
                            row.Cells["piecespercase"].Style.ForeColor = Color.Tomato;
                            break;
                        case 5:
                            row.Cells["purchaseCost"].Style.ForeColor = Color.Tomato;
                            break;
                        case 6:
                            row.Cells["stock"].Style.ForeColor = Color.Tomato;
                            break;
                        case 7:
                            row.Cells["minstock"].Style.ForeColor = Color.Tomato;
                            break;
                        case 8:
                            row.Cells["barcode"].Style.ForeColor = Color.Tomato;
                            row.Cells["barcode"].ErrorText = "Ya existe un producto registrado con este Código de Barras.";
                            break;
                    }
                }

            }

            if (dataGridView1.Rows.Count > 0)
                MessageBox.Show(string.Format("Se agregaron {0} productos.\n Los productos que se muestran en la tabla no pudieron ser agragados", count));
            else
                MessageBox.Show(string.Format("Se agregaron {0} productos", count));
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var value = e.FormattedValue.ToString().Trim();
            if (e.ColumnIndex == dataGridView1.Columns["barcode"].Index)
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("Ingrese un código de barras");
                    e.Cancel = true;
                }
                else if (Producto.SearchProduct(value))
                {
                    MessageBox.Show("El código de barras ingresado ya se encuentra registrado en el inventario. Ingrese uno diferente");
                    e.Cancel = true;
                }
                return;
            }

            if (e.ColumnIndex == dataGridView1.Columns["description"].Index)
            {
                if (value == "")
                {
                   MessageBox.Show( "Debe ingresar la descripción del producto");
                    e.Cancel = true;
                }
                return;
            }

            if (e.ColumnIndex == dataGridView1.Columns["retailcost"].Index || e.ColumnIndex==  dataGridView1.Columns["costpercase"].Index)
            {
                double number;
                if (!double.TryParse(value, out number) || number <= 0)
                {
                   MessageBox.Show( "Debe ingresar un valor numérico mayor a cero");
                    e.Cancel = true;
                }

            }

            if (e.ColumnIndex == dataGridView1.Columns["purchasecost"].Index)
            {
                double number;
                if (!double.TryParse(value, out number) || number < 0)
                {
                   MessageBox.Show( "Debe ingresar un valor numérico positivo");
                    e.Cancel = true;
                }

            }

            if (e.ColumnIndex == dataGridView1.Columns["piecespercase"].Index)
            {
                double number;
                if (!double.TryParse(value, out number) || number < 1)
                {
                   MessageBox.Show( "Debe ingresar un valor numérico mayor a uno");
                    e.Cancel = true;
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["stock"].Index || e.ColumnIndex== dataGridView1.Columns["minstock"].Index)
            {
                double number;
                if (!double.TryParse(value, out number) )
                {
                   MessageBox.Show( "Debe ingresar un valor numérico");
                    e.Cancel = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog() { FileName = "Importar Productos", DefaultExt= ".xlsx", OverwritePrompt=true };
            
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dialog.FileName, Properties.Resources.Importar_Productos);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cancellationSource != null)
                try { cancellationSource.Cancel(); }
                catch (Exception) { }
            panel3.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p=new Pen(Color.LimeGreen))
            {
                e.Graphics.DrawRectangle(p, 0, 0, panel3.Width - 1, panel3.Height - 1);
            }
        }
    }
}
