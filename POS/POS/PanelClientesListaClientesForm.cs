using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class PanelClientesListaClientesForm : Form
    {
        private Cliente cliente = new Cliente();

        public int IDCustomer { get; set; }

        public PanelClientesListaClientesForm(int employeeID)
        {
            this.InitializeComponent();
            if (new Empleado(employeeID).isAdmin)
                return;
            this.DeshabilitarBtn.Visible = false;
            this.AbrirBtn.Location = new Point((this.AbrirBtn.Parent.Width - this.AbrirBtn.Width) / 2, this.AbrirBtn.Location.Y);
        }

        private void PanelClientesListaClientesForm_Load(object sender, EventArgs e)
        {
            this.panel1_Paint((object)this, new PaintEventArgs(this.CreateGraphics(), new Rectangle(this.Location, this.Size)));
            this.panel2_Paint((object)this, new PaintEventArgs(this.CreateGraphics(), new Rectangle(this.Location, new Size()
            {
                Width = this.Width,
                Height = this.Height - 2
            })));
            this.FillDataGridView();    
            this.Refresh();
            BuscarClientetxt.Select();
        }

        private void FillDataGridView()
        {
            DataTable customerList = this.cliente.GetCustomerList();
            customerList.Columns["Id_Cliente"].ColumnName = "Número de Cliente";
            this.dataGridView1.DataSource = customerList;

            if (customerList.Rows.Count > 0)
                dataGridView1.CurrentCell = dataGridView1[dataGridView1.Columns["Nombre"].Index, 0];
        }

        private async void BuscarClientetxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dataTable2 = BuscarClientetxt.Text == "" ? this.cliente.GetCustomerList() :
                    await Task.Run(() => this.cliente.SearchCustomer(this.BuscarClientetxt.Text));

                dataTable2.Columns["Id_Cliente"].ColumnName = "Número de Cliente";

                this.dataGridView1.DataSource = (object)dataTable2;
            }
            catch (Exception) { }
        }

        private void AbrirBtn_Click(object sender, EventArgs e)
        {
            this.openCustomer();
        }

        private void openCustomer()
        {
            if (dataGridView1.CurrentRow != null)
            {
                this.IDCustomer = int.Parse(this.dataGridView1.SelectedRows[0].Cells["Número de Cliente"].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DeshabilitarBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                this.cliente.Name = this.dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                this.cliente.ID = int.Parse(this.dataGridView1.SelectedRows[0].Cells["Número de cliente"].Value.ToString());
                string str = this.dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();
                int index = this.dataGridView1.SelectedRows[0].Index;
                this.cliente.Status = !(str == "Inactivo") ? "Inactivo" : "Activo";
                this.cliente.UpdateStatus();
                this.FillDataGridView();
                this.dataGridView1.Rows[index].Selected = true;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(0, 111, 173));
            Graphics graphics = e.Graphics;
            pen.Width = 2f;
            graphics.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1)));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(0, 111, 173));
            Graphics graphics = e.Graphics;
            pen.Width = 2f;
            graphics.DrawRectangle(pen, new Rectangle(new Point(0, -2), new Size(this.panel2.Width - 1, this.panel2.Height)));
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            this.panel2.Height = 0;
            this.panel2.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.openCustomer();
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            try
            {
                num = this.dataGridView1.SelectedRows[0].Index;
            }
            catch (Exception)
            {
                num = -1;
            }
            if (num >= 0)
            {
                this.panel2.Height = 112;
                panel2.Show();
                if (this.dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString() == "Activo")
                    this.DeshabilitarBtn.Text = "Deshabilitar";
                if (this.dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString() == "Inactivo")
                    this.DeshabilitarBtn.Text = "Habilitar";
                this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.SelectedRows[0].Index;
            }
            else
            {
                this.panel2.Height = 0;
                this.panel2.Visible = false;
            }
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in (IEnumerable)this.dataGridView1.Rows)
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

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["Número de Cliente"].Visible = false;
            this.resizeGridView();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource == null)
                return;
            this.resizeGridView();
        }

        private void resizeGridView()
        {
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
            {
                if (column.Visible)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    num += column.Width;
                }
            }
            if (num >= this.dataGridView1.Width)
                return;
            this.dataGridView1.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarClientetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index + 1 < dataGridView1.RowCount) 
            {
                dataGridView1.CurrentCell = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentRow.Index + 1];
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Up && dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index -1  >=0)
            {
                dataGridView1.CurrentCell = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentRow.Index - 1];
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter && dataGridView1.RowCount > 0 && dataGridView1.CurrentRow!=null)
            {
                openCustomer();
            }
        }
    }
}
