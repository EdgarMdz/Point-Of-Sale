using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Bunifu.Framework.UI;
using System.Threading;

namespace POS
{
    public partial class Panel_Productos : Form
    {
        private int selectedrow;
        private bool editingCell;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 33554432;
                return createParams;
            }
        }

        public Panel_Productos(FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            this.dataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.showDatagridViewMenu);
            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.RowTemplate.Height = 50;
            
        }

        private void showDatagridViewMenu(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.ColumnIndex <= 2)
                return;
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Renombrar"));
            //contextMenu.MenuItems.Add(new MenuItem("Lista da Productos Faltantes"));
            contextMenu.MenuItems.Add(new MenuItem(string.Format("Borrar la bodega \"{0}\"", this.dataGridView1.Columns[e.ColumnIndex].HeaderText)));
            contextMenu.MenuItems.Add(new MenuItem("¿Mostrar la bodega en la busqueda de productos en la pestaña ventas?"));
            if (e.ColumnIndex == this.dataGridView1.Columns["1"].Index)
            {
                contextMenu.MenuItems[1].Enabled = false;
                contextMenu.MenuItems[2].Enabled = false;
            }
            contextMenu.MenuItems[2].Checked = new Bodega(Convert.ToInt32(this.dataGridView1.Columns[e.ColumnIndex].Name)).showInProductSearches;
            int num1 = 0;
            for (int index = 0; index < e.ColumnIndex; ++index)
                num1 += this.dataGridView1.Columns[index].Width;
            contextMenu.Show((Control)this.dataGridView1, new Point(num1 + e.X, e.Y));
            contextMenu.MenuItems[1].Click += (EventHandler)((s, ee) => this.deleteDepot(e.ColumnIndex));
            contextMenu.MenuItems[0].Click += (EventHandler)((s, ee) => this.editDepot(e.ColumnIndex));
            /*contextMenu.MenuItems[1].Click += (EventHandler)((s, ee) =>
            {
                DarkForm darkForm = new DarkForm();
                Panel_productos_Faltantes_Bodega productosFaltantesBodega = new Panel_productos_Faltantes_Bodega(Convert.ToInt32(this.dataGridView1.Columns[e.ColumnIndex].Name));
                darkForm.Show();
                int num2 = (int)productosFaltantesBodega.ShowDialog();
                darkForm.Close();
            });*/
            contextMenu.MenuItems[2].Click += (EventHandler)((s, ee) =>
            {
                Bodega bodega = new Bodega(Convert.ToInt32(this.dataGridView1.Columns[e.ColumnIndex].Name));
                bodega.showInProductSearches = !bodega.showInProductSearches;
            });
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.RowIndex < 0 || e.ColumnIndex <= 2)
                return;
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Modificar Stock"));
            int num1 = 0;
            int columnHeadersHeight = this.dataGridView1.ColumnHeadersHeight;
            for (int index = 0; index < e.ColumnIndex; ++index)
                num1 += this.dataGridView1.Columns[index].Width;
            for (int rowIndex = this.dataGridView1.FirstDisplayedCell.RowIndex; rowIndex < e.RowIndex; ++rowIndex)
                columnHeadersHeight += this.dataGridView1.Rows[rowIndex].Height;
            contextMenu.Show((Control)this.dataGridView1, new Point(num1 + e.X, columnHeadersHeight + e.Y));
            contextMenu.MenuItems[0].Click += (EventHandler)((s, ee) =>
            {
                this.dataGridView1.ReadOnly = false;
                this.dataGridView1.CurrentCell = this.dataGridView1[e.ColumnIndex, e.RowIndex];
                this.editingCell = false;
                Bodega depot = new Bodega(Convert.ToInt32(this.dataGridView1.CurrentCell.OwningColumn.Name));
                this.dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
                string currentValue = "";
                this.dataGridView1.CellBeginEdit += ((sss, eee) =>
                {
                    if (this.editingCell)
                        return;
                    this.editingCell = true;
                    currentValue = this.dataGridView1.CurrentCell.Value.ToString();
                    this.dataGridView1.CurrentCell.Value = new Bodega(Convert.ToInt32(this.dataGridView1.CurrentCell.OwningColumn.Name)).getProductQuantity(this.dataGridView1.Rows[eee.RowIndex].Cells["Código de Barras"].Value.ToString());
                });
                this.dataGridView1.BeginEdit(true);
                this.dataGridView1.CellEndEdit += (DataGridViewCellEventHandler)((ss, eee) =>
                {
                    if (this.dataGridView1.ReadOnly)
                        return;
                    this.dataGridView1.EditingControlShowing -= new DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
                    try
                    {
                        Producto producto1 = new Producto(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Código de Barras"].Value.ToString());
                        double newQuantity = Convert.ToDouble(this.dataGridView1.CurrentCell.Value);
                        this.dataGridView1.CurrentCell.Value = (object)string.Format("{0} {1},\n{2} {3}", (object)Math.Truncate(newQuantity / producto1.PiecesPerCase), Math.Truncate(newQuantity / producto1.PiecesPerCase) == 1.0 ? (object)"caja" : (object)"cajas", (object)(newQuantity % producto1.PiecesPerCase), newQuantity % producto1.PiecesPerCase == 1.0 ? (object)"pieza" : (object)"piezas");
                        new Bodega(Convert.ToInt32(this.dataGridView1.CurrentCell.OwningColumn.Name)).UpdateProductQuantity(newQuantity, producto1.Barcode);
                        this.editingCell = false;
                        Producto producto2 = new Producto(producto1.Barcode);
                        this.dataGridView1.CurrentCell.OwningRow.DefaultCellStyle.ForeColor = producto2.CurrentStock >= producto2.minStock ? Color.Black : Color.Tomato;
                    }
                    catch (FormatException)
                    {
                        string str = this.dataGridView1.CurrentCell.Value.ToString();
                        if (str.ToLower().IndexOf("caja") == -1 && str.ToLower().IndexOf("pieza") == -1)
                        {
                            int num2 = (int)MessageBox.Show("El formato no es válido");
                        }
                        this.dataGridView1.CurrentCell.Value = (object)currentValue;
                    }
                    catch (InvalidCastException)
                    {
                        this.dataGridView1.CurrentCell.Value = (object)currentValue;
                    }
                    this.dataGridView1.ReadOnly = true;
                });
            });
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox control = e.Control as TextBox;
            control.KeyPress += new KeyPressEventHandler(this.textbox_KeyPress);
            control.KeyDown += new KeyEventHandler(this.textbox_KeyDown);
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != System.Windows.Forms.Keys.Escape)
                return;
            Producto producto = new Producto(this.dataGridView1.CurrentCell.OwningRow.Cells["Código de Barras"].Value.ToString());
            (sender as TextBox).Text = producto.CurrentStock.ToString();
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != '-'))
                e.Handled = true;
            if ((sender as TextBox).Text.IndexOf(".") > -1 && e.KeyChar == '.')
                e.Handled = true;
            if ((sender as TextBox).Text.IndexOf("-") <= -1 || e.KeyChar != '-')
                return;
            e.Handled = true;
        }

        private void editDepot(int columnIndex)
        {
            PanelProductos_NuevaBodega productosNuevaBodega = new PanelProductos_NuevaBodega(Convert.ToInt32(this.dataGridView1.Columns[columnIndex].Name));
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (productosNuevaBodega.ShowDialog() == DialogResult.OK)
            {
                this.dataGridView1.DataSource = Bodega.getInventory(SearchTxt.Text);
                this.FitTableInformation();
                this.dataGridView1.CurrentCell = this.dataGridView1.RowCount > 0 ? this.dataGridView1.Rows[this.selectedrow].Cells[0] : (DataGridViewCell)null;
            }
            darkForm.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form_Agregar formAgregar = new Form_Agregar();
            formAgregar.Show();
        }

        private void Panel_Productos_Load(object sender, EventArgs e)
        {
            this.loadtable();
            SearchTxt.Select();
        }

        private async void loadtable()
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await Task.Run(() => Bodega.getInventory());

            if (this.dataGridView1.RowCount <= 0)
                return;
            this.dataGridView1.FirstDisplayedCell = this.dataGridView1.Rows[0].Cells[0];

            CellFormatting();

            this.Cursor = Cursors.Default;
        }
        private async void loadtable(string text)
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await Task.Run(() => Bodega.getInventory(text));


            Cursor = Cursors.Default;

            if (this.dataGridView1.RowCount <= 0)
                return;
            this.dataGridView1.FirstDisplayedCell = this.dataGridView1.Rows[0].Cells[0];

            CellFormatting();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Borrar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                new Producto(this.dataGridView1.SelectedRows[0].Cells["Código de Barras"].Value.ToString()).DeleteProduct();
                this.loadtable();
            }
            else
            {
                var tooltip = new ToolTip();
                tooltip.Show("Seleccione un producto en la lista para usar esta opción", DeleteButton);
            }
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            this.UpdateProduct();
        }

        private void UpdateProduct()
        {
            if (this.dataGridView1.RowCount <= 0)
            {
                var tooltip = new ToolTip();
                tooltip.Show("Seleccione un producto en la lista para usar esta opción", EditProduct);
                return;
            }
            Producto product = new Producto(dataGridView1.CurrentRow.Cells["Código de Barras"].Value.ToString());
            Form_Agregar formAgregar = new Form_Agregar(product);

            formAgregar.Show();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            /* CurrencyManager currencyManager2  = (CurrencyManager)this.BindingContext[this.dataGridView1.DataSource];
             currencyManager2.SuspendBinding();
             if (this.SearchTxt.Text != "")
             {
                 foreach (DataGridViewRow row in this.dataGridView1.Rows)
                 {
                     if (row.Cells["Código de Barras"].Value.ToString().ToLower().Contains(this.SearchTxt.Text.ToLower()) || row.Cells["Descripción"].Value.ToString().ToLower().Contains(this.SearchTxt.Text.ToLower()) || row.Cells["Marca"].Value.ToString().ToLower().Contains(this.SearchTxt.Text.ToLower()))
                         row.Visible = true;
                     else
                         row.Visible = false;
                 }
             }
             else
             {
                 foreach (DataGridViewBand row in this.dataGridView1.Rows)
                     row.Visible = true;
             }
             this.CellFormatting();
             currencyManager2.ResumeBinding();*/

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            this.UpdateProduct();
        }

        private void FitTableInformation()
        {
            int num = 0;
            /*foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (column.Visible)
                    num += column.Width;
            }*/
            if (num >= this.dataGridView1.Width || this.dataGridView1.Columns.Count <= 0)
                return;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_DataSourceChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                DataTable dataSource = (DataTable)this.dataGridView1.DataSource;
                this.highlightProductsBellowMinStock();

                for (int index = 3; index < this.dataGridView1.Columns.Count; ++index)
                    this.dataGridView1.Columns[index].Name = dataSource.Columns[this.dataGridView1.Columns[index].HeaderText].Caption;

               // this.dataGridView1.Sort(this.dataGridView1.Columns["Marca"], ListSortDirection.Ascending);

                if (this.dataGridView1.Columns.Count <= 4)
                    this.TransferStockBtn.Enabled = false;
                
                this.FitTableInformation();
                this.CellFormatting();
            }

            if(dataGridView1.RowCount>0)
            {
                foreach (Control item in bunifuGradientPanel1.Controls)
                {
                    if (item.Name != AddBtn.Name && item.Name != promoBtn.Name && !item.Visible)
                    {
                        item.Visible = true;
                        transition(item);

                    }
                }
            }
            else
            {
                foreach (Control item in bunifuGradientPanel1.Controls)
                {
                    if (item.Name != AddBtn.Name)
                    {
                        item.Visible = false;

                    }
                }
            }
        }

        void transition(Control control)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer() { Interval = 10 };

            int x = (control.Parent.Width - control.Width) / 2;
            int loc = 1;

            control.Location = new Point(-100, control.Location.Y);

            timer1.Tick += (ss, ee) =>
            {
                if (control.Location.X < x)
                {
                    control.Location = new Point(loc, control.Location.Y);
                    loc += 2;


                    timer1.Interval += 2;
                }
                else
                {
                    timer1.Stop();
                    timer1.Dispose();
                }
            };

            timer1.Start();

        }


        private async void highlightProductsBellowMinStock()
        {
            await Task.Run((Action)(() =>
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    try
                    {
                        if (row.Cells["Código de Barras"] != null)
                        {
                            Producto producto = new Producto(row.Cells["Código de Barras"].Value.ToString());
                            if (producto.CurrentStock < producto.minStock)
                                row.DefaultCellStyle.ForeColor = Color.Tomato;
                        }
                    }
                    catch (Exception) { }
                }
            }));
        }

        private void CellFormatting()
        {
            int num = 0;
            for (int index = 0; index < this.dataGridView1.RowCount; ++index)
            {
                if (this.dataGridView1.Rows[index].Visible)
                {
                    if (num % 2 == 0)
                        this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                    else
                        this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                    ++num;
                }
            }
        }

        private delegate void setEmployeeDelegate(int employeeID);

        public void setEmployee(int employeeID)
        {
            if(this.InvokeRequired)
            {
                var del = new setEmployeeDelegate(setEmployee);
                this.Invoke(del, new object[] { employeeID });
            }
            else
            {
                dataGridView1.CancelEdit();
                if (!new Empleado(employeeID).isAdmin)
                    this.Close();
            }
        }

        private void TransferStockBtn_Click(object sender, EventArgs e)
        {
            var barcodeCell = dataGridView1.RowCount > 0 ? dataGridView1.SelectedRows[0].Cells["Código de Barras"].Value : null;
            if (barcodeCell != null)
            {
                Producto product = new Producto(barcodeCell.ToString());
                new Panel_productos_Transferir_Inventario_entre_bodegas(product).Show();
            }
            else
            {
                var tooltip = new ToolTip();
                tooltip.Show("Seleccione un producto en la lista para usar esta opción", TransferStockBtn);
            }
        }

        private void NewDepotBtn_Click(object sender, EventArgs e)
        {
            PanelProductos_NuevaBodega productosNuevaBodega = new PanelProductos_NuevaBodega();
            productosNuevaBodega.Show();

            TransferStockBtn.Enabled = true;
        }

        private void deleteDepot(int columnIndex)
        {
            if (MessageBox.Show("¿Desea Eliminar la Bodega \"" + this.dataGridView1.Columns[columnIndex].HeaderText + "\"?. \nLos productos almacenados serán transferidos a sus respectivas bodegas por defecto.\n\nNota: En caso de que la bodega por defecto se esté eliminando, los productos se transferiran a la bodega \"" + this.dataGridView1.Columns[3].HeaderText + "\"", "Borrar Bodega", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            new Bodega(Convert.ToInt32(this.dataGridView1.Columns[columnIndex].Name)).Delete();
            this.dataGridView1.DataSource = Bodega.getInventory();
            this.FitTableInformation();
            this.dataGridView1.CurrentCell = this.dataGridView1.RowCount > 0 ? this.dataGridView1.Rows[this.selectedrow].Cells[0] : (DataGridViewCell)null;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateProduct();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            this.FitTableInformation();
        }

        private void scrapBtn_Click(object sender, EventArgs e)
        {
            PanelProducto_Scrap panelProductoScrap = new PanelProducto_Scrap();
            panelProductoScrap.Show();
        }





        private void CenterToParent(Label statisticsProductsProductLbl)
        {
            int width1 = statisticsProductsProductLbl.Parent.Width;
            int width2 = (int)statisticsProductsProductLbl.CreateGraphics().MeasureString(statisticsProductsProductLbl.Text, statisticsProductsProductLbl.Font).Width;
            statisticsProductsProductLbl.AutoSize = true;
            if (width1 > width2)
            {
                statisticsProductsProductLbl.Location = new Point((width1 - statisticsProductsProductLbl.Width) / 2, statisticsProductsProductLbl.Location.Y);
            }
            else
            {
                statisticsProductsProductLbl.AutoSize = false;
                statisticsProductsProductLbl.Width = width1;
                statisticsProductsProductLbl.AutoEllipsis = true;
                statisticsProductsProductLbl.Location = new Point(0, statisticsProductsProductLbl.Location.Y);
            }
        }


        private void Panel_Productos_Shown(object sender, EventArgs e)
        {
            SearchTxt.Select();
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(
          object sender,
          DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 3)
                return;
            this.editDepot(e.ColumnIndex);
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            this.highlightProductsBellowMinStock();
            this.CellFormatting();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mixedCaseBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                form_agregar_venta_surtido SaleAsMixed = new form_agregar_venta_surtido(dataGridView1.SelectedRows[0].Cells["Código de Barras"].Value.ToString());
                SaleAsMixed.Show();
            }
            else
            {
                var tooltip = new ToolTip();
                tooltip.Show("Seleccione un producto de la lista para usar esta opción", mixedCaseBtn);
            }
        }

        private void promoBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel_productos_productPromos promo = new panel_productos_productPromos();
                promo.Show();
            }
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SearchTxt.Text.Trim() != "")
                {
                    loadtable(SearchTxt.Text);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                SearchTxt.Text = "";
                loadtable();

            }
            if (e.KeyCode == Keys.Up && dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index > 0)
            {
                var cell = dataGridView1.CurrentCell;
                dataGridView1.CurrentCell = dataGridView1[cell.ColumnIndex, cell.RowIndex - 1];

                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down && dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
            {
                var cell = dataGridView1.CurrentCell;
                dataGridView1.CurrentCell = dataGridView1[cell.ColumnIndex, cell.RowIndex + 1];

                e.SuppressKeyPress = true;
            }
        }

        private void SearchTxt_Enter(object sender, EventArgs e)
        {
            SearchTxt.Focus();
            SearchTxt.Select(0, SearchTxt.Text.Length);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Add | Keys.Alt))
            {
                AddButton_Click(this, null);
            }

            if (keyData == (Keys.F2) && dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
            {
                UpdateProduct();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ActionBtn_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as BunifuImageButton;
            if (dataGridView1 != null && dataGridView1.RowCount > 0)
            {
                var tooltip = new ToolTip();
                tooltip.GetToolTip(btn);
                tooltip.RemoveAll();
            }
        }

        private void AddBtn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void wholesaleCostsBtn_Click(object sender, EventArgs e)
        {
            form_ProductWholeSaleCosts wholeSaleCosts = new form_ProductWholeSaleCosts(dataGridView1.SelectedRows[0].Cells["Código de Barras"].Value.ToString());
            wholeSaleCosts.ShowDialog();
        }

        private void dataGridView1_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Height += 5;
        }
    }
}
