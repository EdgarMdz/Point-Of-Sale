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
    public partial class PanelProveedor_GeneratePO : Form
    {
        private Proveedor _Supplier;
        private int _EmployeeID;
        private double _Total;
        private int step;
        private int _PO_ID;
        private DateTime _ArrivalDate;
        private DateTime _PaymentDueDate;
        private double _payment;


        public double Payment
        {
            get
            {
                return this._payment;
            }
        }

        public double Total
        {
            get
            {
                return this._Total;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                return this._ArrivalDate;
            }
        }

        public DateTime PaymentDueDate
        {
            get
            {
                return this._PaymentDueDate;
            }
        }

        public int PO_ID
        {
            get
            {
                return this._PO_ID;
            }
        }

        public PanelProveedor_GeneratePO(Proveedor supplier, int employeeID, double Total)
        {
            this.InitializeComponent();
            this._Supplier = supplier;
            this._EmployeeID = employeeID;
            this._Total = Total;
            this.setForm(this.step = 0);
            this.Textbox.Hide();
            this.DatePicker.MinDate = DateTime.Today.Date;
            this._PO_ID = -1;
            this.ShowInTaskbar = false;
        }

        private void setForm(int step)
        {
            if (step == 0)
            {
                this.Label.Text = "Llegada de la Mercancía:";
                this.resizeControls((Control)this.Label, (Control)this.DatePicker);
                this.Textbox.Hide();
                this.DatePicker.Show();
                this.DatePicker.Focus();
            }
            if (step == 1)
            {
                this.Label.Text = "Fecha Límite de Pago:";
                this.resizeControls((Control)this.Label, (Control)this.DatePicker);
                this.Textbox.Hide();
                this.DatePicker.Show();
                this.DatePicker.Focus();
                this.NextBtn.Text = "Siguiente";
            }
            if (step == 2)
            {
                this.Label.Text = "Total de la Compra:";
                this.resizeControls((Control)this.Label, (Control)this.Textbox);
                this.Textbox.Show();
                this.Textbox.Text = this._Total.ToString("n2");
                this.Textbox.SelectAll();
                this.Textbox.Focus();
                this.DatePicker.Hide();
                this.NextBtn.Text = "Siguiente";
            }
            if (step == 3)
            {
                this.Label.Text = "¿Se ha dado algún abono?";
                this.resizeControls((Control)this.Label, (Control)this.Textbox);
                this.Textbox.Show();
                this.Textbox.Text = this.Payment.ToString("n2");
                this.Textbox.SelectAll();
                this.Textbox.Focus();
                this.DatePicker.Hide();
                this.NextBtn.Text = "Siguiente";
            }
            this.errorProvider.SetError((Control)this.Textbox, (string)null);
        }

        private void resizeControls(Control control1, Control control2)
        {
            if (control2.Location.X - control1.Location.X + control2.Width <= this.Width - 100)
                return;
            control2.Width = this.Width - 50 - control1.Location.X - control1.Width - 26;
            control2.Location = new Point(control1.Location.X + control1.Width + 26, control2.Location.Y);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.saveValues();
        }

        private void saveValues()
        {
            if (this.step == 0)
            {
                this._ArrivalDate = this.DatePicker.Value;
                this.setForm(++this.step);
            }
            else if (this.step == 1)
            {
                this._PaymentDueDate = this.DatePicker.Value;
                this.setForm(++this.step);
            }
            else if (this.step == 2)
            {
                if (this.Textbox.Text == "")
                    this.Textbox.Text = "0.00";
                this._Total = Convert.ToDouble(this.Textbox.Text);
                this.setForm(++this.step);
                this.NextBtn.Text = "Finalizar";
            }
            else
            {
                if (this.step != 3)
                    return;
                if (this.Textbox.Text == "")
                    this.Textbox.Text = "0.00";
                this._payment = Convert.ToDouble(this.Textbox.Text);
                if (this._Total >= this._payment)
                {
                    this._PO_ID = this._Supplier.GeneratePO(this._EmployeeID, this._ArrivalDate, this._PaymentDueDate, this._Total, this._payment);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    this.errorProvider.SetError((Control)this.Textbox, "El valor del Abono no debe superar el Total de la deuda");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.Textbox.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.setForm(--this.step);
            if (e.KeyCode != Keys.Return)
                return;
            this.saveValues();
        }

        private void DatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                    this.DatePicker.Value = this.DatePicker.Value.AddDays(1.0);
                if (e.KeyCode == Keys.Down)
                    this.DatePicker.Value = this.DatePicker.Value.AddDays(-1.0);
            }
            catch (Exception)
            {
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (this.step == 0)
                    this.Close();
                else
                    this.setForm(--this.step);
            }
            if (e.KeyCode != Keys.Return)
                return;
            this.NextBtn.Focus();
            this.saveValues();
        }

        private void PanelProveedor_GeneratePO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;
            if (this.step == 0)
                this.Close();
            else
                this.setForm(--this.step);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
