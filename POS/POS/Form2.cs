using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class panel_productos_productPromos : Form
    {
        int currentPromoID = -1;

        public panel_productos_productPromos()
        {
            InitializeComponent();
            populateTable();
            resizeForm();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_productos_productPromos_Shown(object sender, EventArgs e)
        {
            resizeForm();
        }

        /* private void resizeForm()
         {
             Control[] list = new Control[] { bunifuGradientPanel1, dataGridView1, panel4 };

             int w = 0;

             foreach (Control control in list)
             {
                 if (control.Visible)
                     w += control.Width;
             }

             Width = w;
             centerToParent(TitleLabel);
         }
         */

        void centerToParent(Control control)
        {
            var parent = control.Parent;

            control.Location = new Point((parent.Width - control.Width) / 2, control.Location.Y);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel2.Show();
            panel6.Hide();
            showTableLayout();
        }

        private void showTableLayout()
        {

            panel4.Show();
            dataGridView1.Hide();
            bunifuGradientPanel1.Hide();

            resizeForm();
            panel4.Dock = DockStyle.Fill;



            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;
            newRow();
        }

        private void newRow()
        {
            tableLayoutPanel1.RowCount += 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0.2f));
            int rowIndex = tableLayoutPanel1.RowCount - 1;

            tableLayoutPanel1.Controls.Add(new TextBox
            {
                ForeColor = Color.FromArgb(0, 130, 170),
                Anchor = AnchorStyles.None,
                Size = new Size(286, 41),
                TextAlign = HorizontalAlignment.Center,
                Name = "productTxt_" + rowIndex
            }, 1, rowIndex);

            tableLayoutPanel1.Controls.Add(new TextBox()
            {
                ForeColor = Color.FromArgb(0, 130, 170),
                Anchor = AnchorStyles.None,
                Size = new Size(161, 41),
                TextAlign = HorizontalAlignment.Center,
                Name = "amountTxt_" + rowIndex
            }, 2, rowIndex);

            var productTxt = tableLayoutPanel1.GetControlFromPosition(1, rowIndex) as TextBox;
            var amountTxt = tableLayoutPanel1.GetControlFromPosition(2, rowIndex) as TextBox;

            productTxt.KeyDown += (s, e) =>
            {
                var sender = (s as TextBox);
                var name = sender.Name;
                int rowindex = Convert.ToInt32(name.Substring(name.IndexOf("_") + 1));
                var amountControl = tableLayoutPanel1.GetControlFromPosition(2, rowindex) as TextBox;

                if (sender.Text.Trim() != "" && amountControl.Text == "" && e.KeyCode == Keys.Enter)
                    amountControl.Focus();

                else if (sender.Text.Trim() == "" && amountControl.Text != "" && e.KeyCode == Keys.Enter)
                    sender.Focus();

                else if (sender.Text.Trim() != "" && amountControl.Text != "" && e.KeyCode == Keys.Enter)
                    addProductToRow(tableLayoutPanel1.GetControlFromPosition(0, rowindex), null);

            };

            amountTxt.KeyDown += (s, e) =>
            {
                var sender = (s as TextBox);
                var name = sender.Name;
                int rowindex = Convert.ToInt32(name.Substring(name.IndexOf("_") + 1));
                var productControl = tableLayoutPanel1.GetControlFromPosition(1, rowindex) as TextBox;

                if (sender.Text != "" && productControl.Text.Trim() == "" && e.KeyCode == Keys.Enter)
                    productControl.Focus();

                else if (sender.Text == "" && productControl.Text.Trim() != "" && e.KeyCode == Keys.Enter)
                    sender.Focus();

                else if (sender.Text != "" && productControl.Text.Trim() != "" && e.KeyCode == Keys.Enter)
                    addProductToRow(tableLayoutPanel1.GetControlFromPosition(0, rowindex), null);

            };
            amountTxt.KeyPress += new KeyPressEventHandler(OnlyNumbers);

            tableLayoutPanel1.Controls.Add(new Bunifu.Framework.UI.BunifuImageButton()
            {
                BackColor = Color.Transparent,
                Image = Properties.Resources.checkmark,
                ImageActive = Properties.Resources.checkmark_green,
                Size = new Size(25, 25),
                Anchor = AnchorStyles.None,
                Name = "addProduct_" + rowIndex.ToString()
            }, 0, rowIndex); ;

            tableLayoutPanel1.GetControlFromPosition(0, rowIndex).Click += new EventHandler(addProductToRow);
        }

        private void addProductToRow(object sender, EventArgs e)
        {
            var control = sender as Control;
            int rowIndex = Convert.ToInt32(control.Name.Substring(control.Name.IndexOf("_") + 1));
            var productText = (tableLayoutPanel1.GetControlFromPosition(1, rowIndex) as TextBox);
            var barcode = tableLayoutPanel1.GetControlFromPosition(1, rowIndex).Text.Trim();
            var amount = tableLayoutPanel1.GetControlFromPosition(2, rowIndex).Text.Trim();

            if (barcode == "" || amount == "")
                return;
            if (checkForDuplicates(barcode))
            {
                MessageBox.Show("Ya se encuentra este producto en la lista.");
                return;
            }

            Producto p = isNumber(barcode) && Producto.SearchProduct(barcode) ? new Producto(barcode) : null;

            if (p == null)
            {
                DataTable dt = Producto.SearchValueGetTable(barcode);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el producto");
                    productText.Focus();
                    productText.SelectAll();
                    return;
                }
                else if (dt.Rows.Count == 1)
                {
                    p = new Producto(dt.Rows[0]["Código de Barras"].ToString());
                }
                else
                {
                    ChooseProductForm choose = new ChooseProductForm(dt);
                    DarkForm dk = new DarkForm();

                    dk.Show();
                    if (choose.ShowDialog() == DialogResult.OK)
                        p = new Producto(choose.selectedItem[0]);
                    else
                        return;
                }

            }

            productText.Name = p.Barcode + "_" + rowIndex.ToString();
            productText.Dock = DockStyle.Fill;

            var amountTxt = tableLayoutPanel1.GetControlFromPosition(2, rowIndex) as TextBox;

            try { double d = Convert.ToDouble(amount); }
            catch (FormatException)
            {
                MessageBox.Show("La Cantidad no tiene el formato adecuado");
                amountTxt.Focus();
                amountTxt.SelectAll();
                return;
            }

            amountTxt.Enabled = false;
            amountTxt.Dock = DockStyle.Fill;

            productText.Enabled = false;
            productText.Text = string.Format("{0}, {1}", p.Description, p.Brand);

            tableLayoutPanel1.Controls.RemoveByKey("addProduct_" + rowIndex.ToString());

            tableLayoutPanel1.Controls.Add(new Bunifu.Framework.UI.BunifuImageButton()
            {
                BackColor = Color.Transparent,
                Image = Properties.Resources.close,
                Size = new Size(25, 25),
                Anchor = AnchorStyles.None,
                Name = "removeProductBtn_" + rowIndex.ToString()
            }, 0, rowIndex); ;

            var removeBtn = tableLayoutPanel1.GetControlFromPosition(0, rowIndex) as Bunifu.Framework.UI.BunifuImageButton;
            removeBtn.Click += new EventHandler(removeBtn_click);
            newRow();
        }

        private Control[] newRow(string barcode, string productDescription, string amount, int rowIndex)
        {

            Control[] c = new Control[] {
            new Label
            {
                ForeColor = Color.FromArgb(0, 130, 170),
                Anchor = AnchorStyles.None,
                Size = new Size(286, 41),
                TextAlign = ContentAlignment.MiddleCenter,
                Name = barcode + "_" + rowIndex,
                Text = productDescription,
                Dock= DockStyle.Fill
            },

            new Label()
            {
                ForeColor = Color.FromArgb(0, 130, 170),
                Anchor = AnchorStyles.None,
                Size = new Size(161, 41),
                TextAlign =  ContentAlignment.MiddleCenter,
                Name = "amountTxt_" + rowIndex,
                Text = amount,
                Dock = DockStyle.Fill
            },

            new Bunifu.Framework.UI.BunifuImageButton()
            {
                BackColor = Color.Transparent,
                Image = Properties.Resources.close,
                Size = new Size(25, 25),
                Anchor = AnchorStyles.None,
                Name = "removeProductBtn_" + rowIndex.ToString()
            }};


            c[2].Click += new EventHandler(removeBtn_click);

            return c;
        }

        private bool checkForDuplicates(string barcode)
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                var control = tableLayoutPanel1.GetControlFromPosition(1, i);

                if (control != null && control.Name.Substring(0, control.Name.IndexOf("_")) == barcode)
                    return true;
            }

            return false;
        }

        private void removeBtn_click(object sender, EventArgs e)
        {
            var button = (sender as Bunifu.Framework.UI.BunifuImageButton);
            int rowindex = Convert.ToInt32(button.Name.Substring(button.Name.IndexOf("_") + 1));

            for (int i = 0; i < 3; i++)
            {
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(i, rowindex));
            }

            for (int i = rowindex + 1; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var control = tableLayoutPanel1.GetControlFromPosition(j, i);

                    control.Name = control.Name.Substring(0, control.Name.IndexOf("_") + 1) + (i - 1).ToString();

                    tableLayoutPanel1.Controls.Add(control, j, i - 1);
                }
            }

            tableLayoutPanel1.RowCount -= 1;
        }


        bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }



        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if ((sender as TextBox).Text.IndexOf(".") > -1 && e.KeyChar == '.')
                e.Handled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowCount == 1)
                return;
            DarkForm dk = new DarkForm();
            panel_productos_productPromos_cost costForm = new panel_productos_productPromos_cost();
            dk.Show();
            if (costForm.ShowDialog() == DialogResult.OK)
            {
                Producto.newPromo(getListOfProducts(), costForm.cost);
                populateTable();
                showGridHideTable();
            }

            dk.Close();

        }

        private void populateTable()
        {
            dataGridView1.DataSource = Producto.getListOfPromos();
        }

        private DataTable getListOfProducts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("barcode");
            dt.Columns.Add("spare");//in sql stored procedure this is a field for retail cost
            dt.Columns.Add("amount");
            dt.Columns.Add("spare1");
            dt.Columns.Add("No.");
            dt.Columns.Add("DepotID");

            for (int i = 0; i < tableLayoutPanel1.RowCount - 1; i++)
            {
                DataRow row = dt.NewRow();
                var product = tableLayoutPanel1.GetControlFromPosition(1, i);
                var amount = tableLayoutPanel1.GetControlFromPosition(2, i);

                row["barcode"] = product.Name.Substring(0, product.Name.IndexOf("_"));
                row["amount"] = amount.Text;
                row["spare"] = row["spare1"] = 0;
                row["No."] = i;
                row["DepotID"] = 1;
                dt.Rows.Add(row);
            }

            return dt;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowCount > 1 && MessageBox.Show("¿Desea salir sin guardar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                showGridHideTable();
            }
        }

        void showGridHideTable()
        {
            panel4.Hide();
            dataGridView1.Show();
            bunifuGradientPanel1.Show();
            panel4.Dock = DockStyle.None;

            resizeForm();
            dataGridView1.BringToFront();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            DeleteBtn.Visible = dataGridView1.RowCount > 0;

            dataGridView1.Columns["promoID"].Visible = false;

            int width = 0;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (column.Visible) width += column.Width;
            }

            if (dataGridView1.Width != width)
                dataGridView1.Columns["Costo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridView1.RowCount > 0)
                dataGridView1.Focus();
        }



        void resizeForm()
        {
            int width = 0;
            Control[] list = new Control[] { bunifuGradientPanel1, dataGridView1, panel4 };

            foreach (Control c in list)
            {
                if (c.Visible)
                    width += c.Width;
            }

            this.Width = width;
            centerToParent(TitleLabel);
            CenterToScreen();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.RowCount > 0 && e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                var cell = dataGridView1.CurrentCell;
                dataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(cell.ColumnIndex, cell.RowIndex));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            int promoID = Convert.ToInt32(row.Cells["promoID"].Value);
            if (promoID != currentPromoID)
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.RowCount = 0;

                DataTable table = Producto.getPromo(promoID).Tables[1];
                int i = 0;

                foreach (DataRow drow in table.Rows)
                {
                    Control[] controls = newRow(drow["id_producto"].ToString(),
                        drow["producto"].ToString(), drow["amount"].ToString(), i);

                    tableLayoutPanel1.RowCount++;
                    tableLayoutPanel1.Controls.Add(controls[2], 0, i);
                    tableLayoutPanel1.Controls.Add(controls[0], 1, i);
                    tableLayoutPanel1.Controls.Add(controls[1], 2, i);

                    i++;

                }

                newRow();
                panel2.Hide();
                panel6.Show();
                panel4.Show();
                panel4.Location = new Point(dataGridView1.Location.X + dataGridView1.Width, 0);

                resizeForm();
                currentPromoID = promoID;
            }
        }


        private void updatePromoBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar los datos?", "Actualizar Promoción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DarkForm dk = new DarkForm();
                panel_productos_productPromos_cost costForm = new panel_productos_productPromos_cost(
                    Convert.ToDouble(dataGridView1.CurrentRow.Cells["costo"].Value));
                dk.Show();
                if (costForm.ShowDialog() == DialogResult.OK)
                {
                    Producto.updatePromo(currentPromoID, getListOfProducts(), costForm.cost);
                    populateTable();
                    showGridHideTable();

                    MessageBox.Show("Se acutalizó la información");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index > -1
                && MessageBox.Show("Desea borrar la promoción", "Borrar pormoción", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Producto.deletePromo(currentPromoID);
                populateTable();
                showGridHideTable();
            }
        }
    }
}
