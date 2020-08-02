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
    public partial class form_agregar_venta_surtido : Form
    {
        int groupID;
        Producto productToBeJoined;


        public form_agregar_venta_surtido(string barcode)
        {
            InitializeComponent();
            productToBeJoined = new Producto(barcode);
            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Height = panel1.Height + panel2.Height;
            CenterToScreen();
            panel2.Dock = DockStyle.Fill;

            if (Producto.findSellingMixedGroup(barcode) > 0)
            {
                lookForAGroup(barcode);
                showNextPanel();
            }
       
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchProduct();  
        }

        private void searchProduct()
        {
            string barcode = barcodeTxt.Text;

            if (barcode.ToLower().Trim() == productToBeJoined.Barcode)
            {
                barcodeTxt.Focus();
                barcodeTxt.SelectAll();
                return;
            }

            if (!Producto.SearchProduct(barcode))
            {
                MessageBox.Show("No se encontró el producto.");
                barcodeTxt.Focus();
                barcodeTxt.SelectAll();
                return;
            }
            if (!validateProduct(new Producto( barcodeTxt.Text)))
                return;

            lookForAGroup(barcodeTxt.Text);
            dataGridView1.Rows.Add(productToBeJoined.Barcode, string.Format("{0}, \r\t{1}", productToBeJoined.Description, productToBeJoined.Brand));
            dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.ForeColor = Color.LimeGreen;
            showNextPanel();
        }

        private void showNextPanel()
        {
            if (dataGridView1.RowCount > 0)
            {
                panel2.Hide();
                panel3.Show();
                this.Height = panel1.Height + panel3.Height;
                panel3.Dock = DockStyle.Fill;
                CenterToScreen();
            }
        }

        private void lookForAGroup(string barcode)
        {
            groupID = Producto.findSellingMixedGroup(barcode);

            //if a group was found
            if (groupID > 0)
            {
                DataTable dt = Producto.getMixedSaleGroupInfo(groupID);

                dataGridView1.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(row[0], string.Format("{0}, \r\t{1}", row[1], row[2]));
                }



                Producto product = new Producto(dt.Rows[0][0].ToString());

                costPerCaseTxt.Text = product.CostPerCase.ToString("n2");
                piecesPerCaseTxt.Text = product.PiecesPerCase.ToString("n2");


            }
            else //The given product's barcode is not registered in a group yet
            {
                Producto p = new Producto(barcode);
                if (MessageBox.Show(string.Format("El producto \"{0}, {1}\" no pertenece a ningún grupo. ¿Desea crear un grupo nuevo?", p.Description, p.Brand),
                    "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (validateProduct(p))
                    {
                        dataGridView1.Rows.Add(p.Barcode, string.Format("{0}, \r\n{1}", p.Description, p.Brand));
                        //dataGridView1.Rows.Add(productToBeJoined.Barcode, string.Format("{0}, \r\n{1}", productToBeJoined.Description, productToBeJoined.Brand));
                        //dataGridView1.Rows[1].DefaultCellStyle.ForeColor = Color.LimeGreen;
                        dataGridView1.CurrentCell = null;

                        costPerCaseTxt.Text = p.CostPerCase.ToString("n2");
                        piecesPerCaseTxt.Text = p.PiecesPerCase.ToString("n2");

                    }
                }
            }
        }

        private bool validateProduct(Producto p)
        {
            if (p.CostPerCase != productToBeJoined.CostPerCase)
            {
                string message = string.Format("Los precios por caja de los productos deben ser iguales para poder venderse como surtidos." +
                    " Corrija los precios para continuar\n\n{0},{1} = ${2}\n{3},{4} = ${5}", productToBeJoined.Description, productToBeJoined.Brand,
                    productToBeJoined.CostPerCase.ToString("n2"), p.Description, p.Brand, p.CostPerCase.ToString("n2"));

                MessageBox.Show(message, "No se pueden agrupar");
                return false;
            }

            if (p.PiecesPerCase != productToBeJoined.PiecesPerCase)
            {
                string message = string.Format("La cantidad de piezas por caja de los productos deben ser iguales para poder venderse como surtidos." +
                    " Iguale las cantidades para continuar\n\n{0},{1} = {2} piezas por caja\n{3},{4} = {5} piezas por caja", productToBeJoined.Description, productToBeJoined.Brand,
                    productToBeJoined.PiecesPerCase.ToString("n2"), p.Description, p.Brand, p.PiecesPerCase.ToString("n2"));

                MessageBox.Show(message, "No se pueden agrupar");
                return false;
            }

            return true;
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["barcode"].Value.ToString()
                == productToBeJoined.Barcode)
            
                if (MessageBox.Show("¿Desea eliminar el producto del grupo?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            if (dataGridView1.CurrentCell!=null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            formAgregar_VentaSurtido_AgregarAGrupo addNewProduct = new formAgregar_VentaSurtido_AgregarAGrupo();
            DarkForm dk = new DarkForm();

            dk.Show();

            if(addNewProduct.ShowDialog()== DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["barcode"].Value.ToString() == addNewProduct.barcode)
                    {
                        MessageBox.Show("No se puede agregar el mismo producto nuevamente");
                        dk.Close();
                        return;
                    }
                }

                Producto p = new Producto(addNewProduct.barcode);
                if(p.Barcode!="")
                {
                    dataGridView1.Rows.Add(p.Barcode, string.Format("{0}, \r\n{1}", p.Description, p.Brand));
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1];
                }
            }
            dk.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (groupID > 0)
                if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar Cambios", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            if (dataGridView1.RowCount > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("barcode");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataRow drow = dt.NewRow();
                    drow[0] = row.Cells["barcode"].Value.ToString();
                    dt.Rows.Add(drow);
                }


                if (groupID == 0) 
                    Producto.createNewGroup(dt);
                else
                    Producto.updateGroup(groupID, dt);

                MessageBox.Show("Se realizó con éxito");
                this.Close();
            }
        }

        private void barcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchProduct();
            else if (e.KeyCode == Keys.Escape && barcodeTxt.Text != "")
                barcodeTxt.Text = "";

            else if (e.KeyCode == Keys.Escape && barcodeTxt.Text == "")
                this.Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["barcode"].Value.ToString() == productToBeJoined.Barcode)
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.LimeGreen;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea eliminar el grupo?", "Borrar grupo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Producto.deleteGroup(groupID);
                MessageBox.Show("La operación se realizó con éxito");
                this.Close();
            }
        }

        private void form_agregar_venta_surtido_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 3);

            e.Graphics.DrawRectangle(p, this.ClientRectangle);
            p.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 3);

            e.Graphics.DrawLine(p, 0,0,this.Width,0);//top
            e.Graphics.DrawLine(p, 0, 0, 0, this.Height);//left
            e.Graphics.DrawLine(p, this.Width-1, 0, this.Width-1, this.Height);//right
            p.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            Pen p = new Pen(Brushes.Black, 3);

            e.Graphics.DrawLine(p, 0, 0, 0, this.Height);//left
            e.Graphics.DrawLine(p, this.Width - 1, 0, this.Width - 1, this.Height);//right

            if (!panel3.Visible)
                e.Graphics.DrawLine(p, 0, panel2.Height - 1, panel2.Width - 1, panel2.Height - 1);
            p.Dispose();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            Pen p = new Pen(Brushes.Black, 3);
            e.Graphics.DrawLine(p, 0, 0, 0, this.Height);//left
            e.Graphics.DrawLine(p, this.Width - 1, 0, this.Width - 1, this.Height);//right
            e.Graphics.DrawLine(p, 0, panel3.Height - 1, panel3.Width - 1, panel3.Height - 1);//bottom
            p.Dispose();
        }
    }
}
