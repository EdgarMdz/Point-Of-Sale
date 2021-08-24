using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class panel_productos_AlternProductsList : Form
    {
        public panel_productos_AlternProductsList(Producto producto)
        {
            InitializeComponent();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "barcode",
                HeaderText = "Código de Barras",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "description",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Brand",
                HeaderText = "Marca",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "retailCost",
                HeaderText = "Precio de Menudeo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "caseCost",
                HeaderText = "Precio por Caja",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "piecesPerCase",
                HeaderText = "Piezas por Caja",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            var buttonColumn = new DataGridViewButtonColumn();

            buttonColumn.Name = "button";
            buttonColumn.HeaderText = "";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.Text = "Abrir";
            buttonColumn.FlatStyle = FlatStyle.Flat;
            buttonColumn.CellTemplate.Style.BackColor = Color.FromArgb(0, 130, 170);
            buttonColumn.CellTemplate.Style.ForeColor = Color.White;
            buttonColumn.CellTemplate.Style.Font = new System.Drawing.Font("Century Gothic", 10f, FontStyle.Bold);            
            dataGridView1.Columns.Add(buttonColumn);

            foreach (DataRow row in producto.getDerivedProductsList().Rows)
            {
                int index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells["barcode"].Value = row["Código de Barras"];
                dataGridView1.Rows[index].Cells["description"].Value = row["Descripción"];
                dataGridView1.Rows[index].Cells["brand"].Value = row["Marca"];
                dataGridView1.Rows[index].Cells["retailCost"].Value = row["Precio Menudeo"];
                dataGridView1.Rows[index].Cells["casecost"].Value = row["Precio por Caja"];
                dataGridView1.Rows[index].Cells["piecespercase"].Value = row["Piezas por Caja"];

            }

            label1.Text += string.Format(" {0}, {1}", producto.Description, producto.Brand);

            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

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

        private void panel_productos_AlternProductsList_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(64, 64, 64)) { Width = 2 })
            {
                e.Graphics.DrawRectangle(p, 1, 1, this.Width - 2, this.Height - 2);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1 && e.ColumnIndex== dataGridView1.Columns["button"].Index)
            {
                OpenProduct(e.RowIndex);
            }
        }

        private void OpenProduct(int rowindex)
        {
            var barcode =  dataGridView1.Rows[rowindex].Cells["barcode"].Value.ToString();

            if (Producto.SearchProduct(barcode))
            {

                Form_Agregar form = new Form_Agregar(new Producto(barcode));
                form.Show();
            }

            else
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[rowindex]);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["button"].Index)
            {
                OpenProduct(e.RowIndex);
            }
        }
    }
}   