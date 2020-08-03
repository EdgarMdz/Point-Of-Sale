using POS.dataBaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class form_ProductWholeSaleCosts : Form
    {
        string barcode;

        public form_ProductWholeSaleCosts(string barcode)
        {
            InitializeComponent();
            this.barcode = barcode;
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        => this.Close();
        


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form_new_wholesale_cost cost = new Form_new_wholesale_cost(barcode);
            
            if (cost.ShowDialog() == DialogResult.OK)
            {
                FillTable();
            }

        }

        private void FillTable()
        {
            var product = new Producto(barcode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = product.GetWholesaleCosts();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["id_producto"].Visible = false;
            dataGridView1.Columns["id_cost"].Visible = false;
            dataGridView1.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Cantidad"].ValueType = typeof(double);
            dataGridView1.Columns["Descuento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "edit",
                HeaderText = "Editar",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                Image = Properties.Resources.edit_green,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "delete",
                HeaderText = "Borrar",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                Image = Properties.Resources.close_Red,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            dataGridView1.CurrentCell = null;
        }

        private void form_ProductWholeSaleCosts_Load(object sender, EventArgs e)
        => FillTable();
        

        private void editCost(int rowIndex)
        {
            var cellText = dataGridView1.Rows[rowIndex].Cells["descuento"].Value.ToString();
            double discount = cellText.IndexOf("%") > -1 ? Convert.ToDouble(cellText.Substring(0, cellText.Length - 1)) : Convert.ToDouble(cellText);
            bool isbypercenage = cellText.IndexOf("%") > -1;

            Form_new_wholesale_cost cost = new Form_new_wholesale_cost(barcode, Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells["cantidad"].Value),
                discount, isbypercenage, Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_cost"].Value));

            this.Hide();
            if(cost.ShowDialog() == DialogResult.OK)
            {
                FillTable();
            }
            this.Show();
        }
    
        private void deleteCost(int rowIndex)
        {
            if (MessageBox.Show("¿Desea eliminar el valor seleccionado?", "Borrar precio de Mayoreo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var p = new Producto(barcode);
                p.deleteWholeSaleCost(Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_cost"].Value));

                FillTable();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex>-1)
                editCost(e.RowIndex);

            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex > -1)
                deleteCost(e.RowIndex);

            dataGridView1.CurrentCell = null;
        }

        private void form_ProductWholeSaleCosts_Paint(object sender, PaintEventArgs e)
            => e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 130, 170)), e.ClipRectangle);

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var g = e.Graphics;
            Pen pen = new Pen(Color.DimGray) { Width = 2 };

            g.DrawLine(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.X + e.CellBounds.Width, e.CellBounds.Y);//upper line
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);

                else
                    row.DefaultCellStyle.BackColor = Color.White;

                i++;
            }
            
        }
    }
}
