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
    public partial class PanelProductos_NuevaBodega : Form
    {
        private bool editing;
        private Bodega depot;

        public PanelProductos_NuevaBodega()
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.editing = false;
            this.depot = (Bodega)null;
        }

        public PanelProductos_NuevaBodega(int depotID)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.editing = true;
            this.depot = new Bodega(depotID);
            this.DepotTxt.Text = this.depot.name;
        }

        private void PanelProductos_NuevaBodega_Load(object sender, EventArgs e)
        {
            if (!this.editing)
            {
                this.dataGridView1.DataSource = (object)Producto.fillTable();
            }
            else
            {
                this.dataGridView1.DataSource = (object)this.depot.ProductTable;
                this.dataGridView1.CurrentCell = this.dataGridView1.RowCount > 0 ? this.dataGridView1.Rows[0].Cells[4] : (DataGridViewCell)null;
            }
        }

        private void DepotTxt_Enter(object sender, EventArgs e)
        {
            if (this.DepotLbl.Visible)
                return;
            this.DepotLbl.Visible = true;
        }

        private void DepotTxt_Leave(object sender, EventArgs e)
        {
            this.DepotLbl.Visible = this.DepotTxt.Text != "";
        }

        private void DepotTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.DepotLbl.Visible || !(this.DepotTxt.Text != ""))
                return;
            this.DepotLbl.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0 && this.dataGridView1.CurrentCell.IsInEditMode)
                this.dataGridView1.EndEdit();
            if (!this.editing)
            {
                this.createDepot();
            }
            else
            {
                this.editDepot();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void editDepot()
        {
            foreach (DataRow row in (InternalDataCollectionBase)Bodega.GetDepots().Rows)
            {
                if (row["Nombre"].ToString().ToLower() == this.DepotTxt.Text.ToLower() && this.depot.ID != Convert.ToInt32(row["ID_Bodega"]))
                {
                    int num = (int)MessageBox.Show("Ya existe una bodega con este nombre.");
                    this.DepotTxt.Text += " Nuevo";
                    this.DepotTxt.Select();
                    return;
                }
            }
            if (this.DepotTxt.Text.ToLower() != this.depot.name.ToLower())
            {
                this.depot.name = this.DepotTxt.Text;
                this.depot.Rename();
            }
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
                this.depot.UpdateMinStockQuantity(row.Cells["Código de Barras"].Value.ToString(), Convert.ToDouble(row.Cells["minStock"].Value));
        }

        private void createDepot()
        {
            if (this.DepotTxt.Text != "")
            {
                foreach (DataRow row in (InternalDataCollectionBase)Bodega.GetDepots().Rows)
                {
                    if (row["Nombre"].ToString().ToLower() == this.DepotTxt.Text.ToLower())
                    {
                        int num = (int)MessageBox.Show("Ya existe una bodega con este nombre.");
                        this.DepotTxt.Text += " Nuevo";
                        this.DepotTxt.Select();
                        return;
                    }
                }
                Bodega bodega = new Bodega(Bodega.newDepot(this.DepotTxt.Text));
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    bodega.UpdateMinStockQuantity(row.Cells["Código de Barras"].Value.ToString(), Convert.ToDouble(row.Cells["minStock"].Value));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (this.DepotLbl.Visible)
            {
                this.errorProvider1.SetError((Control)this.DepotLbl, "Ingrese el nombre de la bodega");
            }
            else
            {
                this.DepotTxt.HintForeColor = Color.Tomato;
                this.DepotTxt.LineIdleColor = Color.Tomato;
            }
        }

        private void DepotTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!this.editing)
                    this.createDepot();
                else
                    this.editDepot();
            }
            if (e.KeyCode != Keys.Escape)
                return;
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!this.dataGridView1.Rows[e.RowIndex].Visible)
                return;
            if (e.RowIndex % 2 == 0)
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
            else
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (!this.editing)
            {
                foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
                {
                    if (column.Index < 2)
                    {
                        column.Visible = true;
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.ReadOnly = true;
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    else
                        column.Visible = false;
                }
                this.dataGridView1.Columns.Add("minStock", "Stock Mínimo");
                this.dataGridView1.Columns["minStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.dataGridView1.Columns["minStock"].ReadOnly = false;
                this.dataGridView1.Columns["minStock"].ValueType = typeof(double);
                this.dataGridView1.Columns["minStock"].SortMode = DataGridViewColumnSortMode.NotSortable;
          
                this.dataGridView1.CurrentCell = this.dataGridView1.RowCount > 0 ? this.dataGridView1.Rows[0].Cells["minStock"] : (DataGridViewCell)null;
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    row.Cells["minStock"].Value = (object)"0.00";
            }
            else
            {
                this.dataGridView1.Columns["Cantidad"].Visible = false;
                this.dataGridView1.Columns["Stock Mínimo"].Name = "minStock";
                dataGridView1.Columns["Checked"].Visible = false;
                int num = 0;
                foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    num += column.Width;
                }
                if (num < this.dataGridView1.Width)
                    this.dataGridView1.Columns["minStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            this.fitColumns();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex != this.dataGridView1.Columns["minStock"].Index)
                return;
            int num = (int)MessageBox.Show("Favor de ingresar sólo valores númericos\nPrecione \"Esc\" para cancelar.", "Formato no adecuado");
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.dataGridView1.Columns.Contains("minStock") || e.ColumnIndex != this.dataGridView1.Columns["minStock"].Index || this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != null && !(this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == ""))
                return;
            this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = (object)"0.00";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            CurrencyManager currencyManager1;
            CurrencyManager currencyManager2 = currencyManager1 = (CurrencyManager)this.BindingContext[this.dataGridView1.DataSource];
            currencyManager2.SuspendBinding();
            if (e.KeyCode == Keys.Return)
            {
                if (this.textBox1.Text == "")
                {
                    foreach (DataGridViewBand row in this.dataGridView1.Rows)
                        row.Visible = true;
                }
                else
                {
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        if (row.Cells["Código de Barras"].Value.ToString().ToLower().Contains(this.textBox1.Text.ToLower()) || row.Cells["Descripción"].Value.ToString().ToLower().Contains(this.textBox1.Text.ToLower()) || row.Cells["Marca"].Value.ToString().ToLower().Contains(this.textBox1.Text.ToLower()))
                            row.Visible = true;
                        else
                            row.Visible = false;
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                foreach (DataGridViewBand row in this.dataGridView1.Rows)
                    row.Visible = true;
            }

            fitColumns();
            currencyManager2.ResumeBinding();
        }

        private void dataGridView1_RowStateChanged(
          object sender,
          DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Visible)
                return;
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
                num = column.Visible ? num + column.Width : num;
            this.dataGridView1.Columns["Descripción"].AutoSizeMode = num < this.dataGridView1.Width ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void PanelProductos_NuevaBodega_Shown(object sender, EventArgs e)
        {
            if (!this.editing)
                return;
            this.dataGridView1.Focus();
        }

        private void fitColumns()
        {
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (column.Visible)
                    num += column.Width;
            }
            this.dataGridView1.Columns["Descripción"].AutoSizeMode = num < this.dataGridView1.Width ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
