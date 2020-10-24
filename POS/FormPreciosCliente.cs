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
    public partial class FormPreciosCliente : Form
    {
        private Cliente cliente = new Cliente();


        public int CustomerID { get; set; }

        public FormPreciosCliente(int customerID)
        {
            this.InitializeComponent();
            this.CustomerID = customerID;
        }

        private void FormPreciosCliente_Load(object sender, EventArgs e)
        {
            this.cliente = new Cliente(this.CustomerID);
            this.FormPreciosCliente_Paint((object)this, new PaintEventArgs(this.CreateGraphics(), new Rectangle(this.Location, this.Size)));
            this.fillGridView();
            this.dontApplyDiscountsCheckBox.Checked = this.cliente.DontApplyAnyDiscount;
        }

        private void fillGridView()
        {
            this.DataGridView1.DataSource = (object)this.cliente.getPriceList(this.CustomerID);
            this.DataGridView1.Columns["id_descuento"].Visible = false;
            this.DataGridView1.Columns["Cantidad minima"].Visible = false;
            this.adjustTableColumnsSize();
        }

        private void adjustTableColumnsSize()
        {
            if (this.DataGridView1.DataSource == null)
                return;
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.DataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (column.Visible)
                    num += column.Width;
            }
            if (num >= this.DataGridView1.Width)
                return;
            this.DataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void NuevoBtn_Click_1(object sender, EventArgs e)
        {
            FormAgregarPrecioCliente agregarPrecioCliente = new FormAgregarPrecioCliente(this.CustomerID);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            switch (agregarPrecioCliente.ShowDialog())
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    this.fillGridView();
                    break;
            }
            darkForm.Close();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este precio de la lista?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.cliente.deletePrice(Convert.ToInt32(DataGridView1.CurrentRow.Cells["id_descuento"].Value));
            this.fillGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPreciosCliente_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1)));
        }

        private void DataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            cliente.RefreshInfo();
            if (this.DataGridView1.Rows.Count == 0)
                this.Borrar.Enabled = false;
            else
                this.Borrar.Enabled = true;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in this.DataGridView1.Rows)
            {
                if (row.Visible)
                {
                    if (row.Index % 2 == 0)
                        row.DefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow discount1 = this.cliente.findDiscount(Convert.ToInt32(this.DataGridView1.CurrentRow.Cells["id_descuento"].Value));
            DarkForm darkForm = new DarkForm();
            string discount2 = Convert.ToBoolean(discount1["Porcentage"]) ? Convert.ToDouble(discount1["Descuento"]).ToString("n2") + "%" : Convert.ToDouble(discount1["Descuento"]).ToString("n2");
            FormAgregarPrecioCliente agregarPrecioCliente = new FormAgregarPrecioCliente(this.CustomerID, discount1["id_producto"].ToString(), Convert.ToDouble(discount1["Cantidad minima"]), discount2, Convert.ToBoolean(discount1["Venta por Caja"]), Convert.ToInt32(discount1["id_descuento"]));
            darkForm.Show();
            if (agregarPrecioCliente.ShowDialog() == DialogResult.OK)
                this.fillGridView();
            darkForm.Close();
        }

        private void DataGridView1_SizeChanged(object sender, EventArgs e)
        {
            this.adjustTableColumnsSize();
        }

        private void dontApplyDiscountsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dontApplyDiscountsCheckBox.Checked)
            {
                this.DataGridView1.Enabled = false;
                this.NuevoBtn.Enabled = false;
                this.Borrar.Enabled = false;
                this.cliente.DontApplyAnyDiscount = true;
                this.DataGridView1.CurrentCell = (DataGridViewCell)null;
                this.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
                this.DataGridView1.DefaultCellStyle.ForeColor = Color.DarkGray;
                this.cliente.updateCustomerInfo();
            }
            else
            {
                this.DataGridView1.Enabled = true;
                this.NuevoBtn.Enabled = true;
                this.Borrar.Enabled = true;
                this.cliente.DontApplyAnyDiscount = false;
                this.DataGridView1.CurrentCell = this.DataGridView1.RowCount > 0 ? this.DataGridView1[1, 0] : (DataGridViewCell)null;
                this.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 130, 170);
                this.DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(0, 130, 170);
                this.cliente.updateCustomerInfo();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
