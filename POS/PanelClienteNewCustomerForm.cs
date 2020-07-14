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
    public partial class PanelClienteNewCustomerForm : Form
    {

        public int EmployeeID { get; set; }

        public new string Name { get; set; }

        public PanelClienteNewCustomerForm()
        {
            this.InitializeComponent();
        }

        private void PanelClienteNewCustomerForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(0, 111, 173));
            e.Graphics.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1)));
        }

        private void PanelClienteNewCustomerForm_Load(object sender, EventArgs e)
        {
            this.PanelClienteNewCustomerForm_Paint((object)this, new PaintEventArgs(this.CreateGraphics(), new Rectangle(this.Location, this.Size)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            DataTable dataTable1 = new DataTable();
            if (this.PhoneTxt.Text.Length == 10)
            {
                this.PhoneTxt.Text = this.PhoneTxt.Text.Insert(3, "-");
                this.PhoneTxt.Text = this.PhoneTxt.Text.Insert(7, "-");
            }
            if (this.PhoneTxt.Text.Length == 7)
            {
                this.PhoneTxt.Text = this.PhoneTxt.Text.Insert(2, "-");
                this.PhoneTxt.Text = this.PhoneTxt.Text.Insert(4, "-");
            }
            cliente.TelephoneNumber = this.PhoneTxt.Text;
            cliente.Address = this.AddressTxt.Text;
            if (this.NameTxt.Text != "")
            {
                cliente.Name = this.NameTxt.Text;
                DataTable dataTable2 = cliente.SearchCustomer(this.NameTxt.Text);
                double debt = 0.0;
                if (this.DebtTxt.Text != "")
                    debt = Convert.ToDouble(this.DebtTxt.Text);
                if (dataTable2.Rows.Count > 0)
                {
                    if (MessageBox.Show("Ya existe un cliente con este Nombre, ¿Desea continuar?", "Coincidencia de clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cliente.NewCustomer(debt, this.EmployeeID);
                        this.Name = this.NameTxt.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    cliente.NewCustomer(debt, this.EmployeeID);
                    this.Name = this.NameTxt.Text;
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
            else
                this.NameError.SetError((Control)this.label1, "Ingrese Nombre");
        }

        private void OkBtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode != Keys.Return || !(this.NameTxt.Text != ""))
                return;
            this.OkBtn_Click((object)this, (EventArgs)null);
        }

        private void DebtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.DebtTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
