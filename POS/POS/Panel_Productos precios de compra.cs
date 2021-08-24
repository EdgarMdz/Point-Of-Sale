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
    public partial class Panel_Productos_precios_de_compra : Form
    {
        Producto product;
        private int _rows;
        
        public int rows { get { return _rows; } }
        

        public Panel_Productos_precios_de_compra(DataTable purchaseRecordTable)
        {
            InitializeComponent();


            dataGridView1.DefaultCellStyle.Font = new Font("century gothic", 12f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("century gothic", 14f, FontStyle.Bold);
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "purchaseCost",
                HeaderText="Precio de compra por pieza",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            }) ;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "remainingPieces",
                HeaderText = "Piezas Restantes por Vender Para Aplicar el Precio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "date",
                HeaderText = "Fecha de Creación",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
            });

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "apply",
                HeaderText = "Aplicar Cambios",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                Image = new Bitmap(Properties.Resources.checkmark_nobg, 20, 20),
                ImageLayout = DataGridViewImageCellLayout.Normal,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "delete",
                HeaderText = "Borrar",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                Image = new Bitmap(Properties.Resources.close_Red, 20, 20),
                ImageLayout = DataGridViewImageCellLayout.Normal,
                SortMode = DataGridViewColumnSortMode.NotSortable,
            });


            foreach (DataRow row in purchaseRecordTable.Rows)
            {
                if (product == null)
                    product = new Producto(row["Código de Barras"].ToString());

                int index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells["purchaseCost"].Value = row["Precio de Compra por pieza"];
                dataGridView1.Rows[index].Cells["remainingPieces"].Value = row["Piezas Restantes por Vender"];
                dataGridView1.Rows[index].Cells["date"].Value = row["Fecha"];    
            
            }
            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            _rows = dataGridView1.RowCount;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["apply"].Index && e.RowIndex>-1)
            {
                product.PurchaseCost = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["purchaseCost"].Value) * product.PiecesPerCase;
                product.UpdateProduct(product.Barcode);

                product.DeletePurchaseCostRecordValue(Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["date"].Value),
                   Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["remainingPieces"].Value),
                   Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["purchaseCost"].Value));

                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                MessageBox.Show("Se aplicó el precio de compra");
            }

            if(e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex>-1)
            {
                product.DeletePurchaseCostRecordValue(Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["date"].Value),
                    Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["remainingPieces"].Value),
                    Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["purchaseCost"].Value));

                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
            }

            _rows = dataGridView1.Rows.Count;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 226, 243);
                }

                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 226, 243);
                }
                i++;
            }
        }

        private void Panel_Productos_precios_de_compra_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(64,64,64)) { Width=2})
            {
                e.Graphics.DrawRectangle(p, 1, 1, this.Width - 2, this.Height - 2);
            }
        }
    }
}
