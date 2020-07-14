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
    public partial class FormAgregarPrecioCliente : Form
    {
        private Size maximized = new Size(580, 546);
        private Size minSize = new Size(596, 150);
        private DataTable dt = new DataTable();
        private bool flagProduct;
        private bool updateMode;
        private int discountID;

        public int CustomerID { get; set; }

        public FormAgregarPrecioCliente(int customerID)
        {
            this.InitializeComponent();
            this.autofill();
            this.updateMode = false;
            this.ShowInTaskbar = false;
            this.CustomerID = customerID;
        }

        public FormAgregarPrecioCliente(
          int customerID,
          string barcode,
          double minimumAmount,
          string discount,
          bool sellbyCase,
          int discountID)
        {
            this.InitializeComponent();
            this.discountID = discountID;
            this.CustomerID = customerID;
            this.BarcodeTxt.Text = barcode;
            this.updateMode = true;
            this.autofill();
            this.DisplayInfo();
            this.CantMinTxt.Text = minimumAmount.ToString("n2");
            this.DescuentoTxt.Text = discount;
            this.SaleByCaseRadio.Checked = sellbyCase;
            this.autofill();
            this.ShowInTaskbar = false;
            this.BarcodeTxt.Enabled = false;
        }

        private void autofill()
        {
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            this.dt = new Producto().SearchProductByCoincidence(this.BarcodeTxt.Text);
            if (this.dt.Rows.Count > 0)
            {
                foreach (DataRow row in (InternalDataCollectionBase)this.dt.Rows)
                {
                    stringCollection.Add(row["Descripción"].ToString());
                    stringCollection.Add(row["Código de Barras"].ToString());
                    //stringCollection.Add(row["Precio Menudeo"].ToString());
                }
            }
            this.BarcodeTxt.AutoCompleteCustomSource = stringCollection;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(this.BarcodeTxt.Text == ""))
                return;
            this.AutoSizeForm("min");
            this.DisplayInfo();
        }

        private void ProductTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.DisplayInfo();
        }

        private void DisplayInfo()
        {
            foreach (DataRow row in (InternalDataCollectionBase)this.dt.Rows)
            {
                string lower1 = row[0].ToString().ToLower();
                string lower2 = row[1].ToString().ToLower();
                string str = row[2].ToString();
                if (this.BarcodeTxt.Text.ToLower() == lower1 || this.BarcodeTxt.Text.ToLower() == lower2)
                {
                    this.ProductLbl.Text = row[0].ToString() + ", " + row[1].ToString();
                    this.BarcodeTxt.Text = row["Código de Barras"].ToString();
                    this.ProductLbl.Location = new Point()
                    {
                        X = this.Size.Width / 2 - this.ProductLbl.Width / 2,
                        Y = this.ProductLbl.Location.Y
                    };
                    this.ProductLbl.Visible = true;
                    this.PrecioLbl.Text = "$" + str + " -";
                    this.PrecioLbl.Visible = true;
                    this.PrecioFinalLbl.Visible = true;
                    this.PrecioFinalLbl.Text = "= $" + str;
                    this.NextStepBtn_Click((object)this, (EventArgs)null);
                    break;
                }
                if (this.BarcodeTxt.Text == "")
                {
                    this.ProductLbl.Text = "";
                    this.PrecioLbl.Text = "";
                    this.PrecioFinalLbl.Text = "";
                    this.DescuentoTxt.Text = "";
                    this.CantMinTxt.Text = "";
                    this.AutoSizeForm("min");
                    this.NextStepBtn.Visible = true;
                    this.label1.Visible = false;
                    this.DescuentoTxt.Visible = false;
                    this.PrecioFinalLbl.Visible = false;
                    this.label3.Visible = false;
                    this.CantMinTxt.Visible = false;
                    this.OKBtn.Visible = false;
                }
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            string barcode = this.ProductLbl.Text.Substring(0, this.ProductLbl.Text.IndexOf(","));
            bool flag1 = this.SaleByCaseRadio.Checked;
            double num1 = Convert.ToDouble(this.CantMinTxt.Text);
            double num2 = this.DescuentoTxt.Text.IndexOf("%") > -1 ? Convert.ToDouble(this.DescuentoTxt.Text.Substring(0, this.DescuentoTxt.Text.IndexOf('%'))) : Convert.ToDouble(this.DescuentoTxt.Text);
            bool isPercentage = this.DescuentoTxt.Text.IndexOf("%") > -1;
            if (!this.updateMode)
            {
                Cliente cliente = new Cliente(this.CustomerID);
                DataRow discount = cliente.findDiscount(barcode, num1);
                if (discount == null)
                {
                    cliente.newPrice(barcode, num2, isPercentage, num1, flag1);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    cliente.UpdatePrice(Convert.ToInt32(discount["id_descuento"]), num2, isPercentage, num1, flag1);
                    int num3 = (int)MessageBox.Show("Se ha actulizado la información");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Cliente cliente = new Cliente(this.CustomerID);
                DataTable allDiscount = cliente.findAllDiscount(barcode, num1);
                bool flag2 = false;
                foreach (DataRow row in (InternalDataCollectionBase)allDiscount.Rows)
                {
                    if (Convert.ToInt32(row["id_descuento"]) != this.discountID)
                    {
                        flag2 = true;
                        break;
                    }
                }
                if (!flag2)
                {
                    cliente.UpdatePrice(this.discountID, num2, isPercentage, num1, flag1);
                    int num3 = (int)MessageBox.Show("Se ha actulizado la información");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    int num4 = (int)MessageBox.Show("Ya existe un descuento aplicable para la cantidad indicada.");
                }
            }
        }

        private void ProductTxt_Leave(object sender, EventArgs e)
        {
            this.DisplayInfo();
        }

        private void DescuentoTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.PrecioFinalLbl.Text != "") || !this.flagProduct)
                return;
            double num1 = Convert.ToDouble(this.PrecioLbl.Text.Substring(1, this.PrecioLbl.Text.Length - 2));
            this.DescuentoTxt.Text.IndexOf('%');
            if (this.DescuentoTxt.Text.IndexOf('%') == -1 && this.DescuentoTxt.Text != "")
            {
                double num2 = Convert.ToDouble(this.DescuentoTxt.Text);
                double num3 = num1 - num2;
                PrecioFinalLbl.Text = "= $" + num3.ToString("n2");
               
            }
            else if (this.DescuentoTxt.Text.IndexOf('%') > -1 && this.DescuentoTxt.Text != "")
            {
                int num2 = (int)this.DescuentoTxt.Text.Last<char>();
                
                double num3 = 0;

                try {num3  = Convert.ToDouble(this.DescuentoTxt.Text.Substring(0, this.DescuentoTxt.Text.Length - 1)); }
                catch(FormatException)
                {
                    DescuentoTxt.Text = "0%";
                    DescuentoTxt.SelectAll();
                    num3 = Convert.ToDouble(this.DescuentoTxt.Text.Substring(0, this.DescuentoTxt.Text.Length - 1));
                }
                double num4 = num1 / 100.0 * num3;
                this.PrecioFinalLbl.Text = "= $" + (num1 - num4).ToString("n2");
            }
            else
            {
                if (!(this.DescuentoTxt.Text == ""))
                    return;
                this.PrecioFinalLbl.Text = "= $" + num1.ToString("n2");
            }

        }

        private void FormAgregarPrecioCliente_Load(object sender, EventArgs e)
        {
            if (!this.updateMode)
            {
                this.Width = 27 + this.barcodeLbl.Width + (this.BarcodeTxt.Location.X - this.barcodeLbl.Location.X - this.barcodeLbl.Width) + this.BarcodeTxt.Width + this.closeBtn.Width + 27;
                this.Height = 15 + this.BarcodeTxt.Height + 10 + this.NextStepBtn.Height + this.closeBtn.Height + 15;
                this.closeBtn.Location = this.RelocateComponent(this.Width - this.closeBtn.Width - 10, 10);
                this.barcodeLbl.Location = this.RelocateComponent(27, 10 + this.closeBtn.Height + 5);
                this.BarcodeTxt.Location = this.RelocateComponent(this.barcodeLbl.Location.X + this.barcodeLbl.Width + 30, 10 + this.closeBtn.Height + 5);
                this.NextStepBtn.Location = this.RelocateComponent(this.Width / 2 - this.NextStepBtn.Width / 2, this.Height - 15 - this.NextStepBtn.Height);
            }
            else
                this.NextStepBtn_Click((object)this, (EventArgs)null);
        }

        private void AutoSizeForm(string command)
        {
            if (command == "min")
                this.Size = this.minSize;
            if (!(command == "max"))
                return;
            this.Size = this.maximized;
        }

        private Point RelocateComponent(int x, int y)
        {
            return new Point() { X = x, Y = y };
        }

        private void DescuentoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != '%'))
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
            if (this.DescuentoTxt.Text != "" && e.KeyChar == '%' && (sender as TextBox).Text.IndexOf('%') > -1)
                e.Handled = true;
            if (e.KeyChar == '%' && this.DescuentoTxt.Text == "")
                e.Handled = true;
            if (this.DescuentoTxt.Text.IndexOf("%") > -1 && !char.IsControl(e.KeyChar) && this.DescuentoTxt.SelectionStart > this.DescuentoTxt.Text.IndexOf("%"))
                e.Handled = true;
            if (e.KeyChar != '%' || this.DescuentoTxt.SelectionStart == this.DescuentoTxt.Text.Length)
                return;
            e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarPrecioCliente_Paint(object sender, PaintEventArgs e)
        {
        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if (!this.ProductLbl.Visible && !this.updateMode)
                return;
            this.AutoSizeForm("max");
            this.closeBtn.Location = this.RelocateComponent(this.Width - this.closeBtn.Width - 10, 10);
            this.ProductLbl.Location = this.RelocateComponent((this.Width - this.ProductLbl.Width) / 2, this.DescuentoTxt.Location.Y - this.BarcodeTxt.Location.Y - this.BarcodeTxt.Height);
            this.label1.Location = this.RelocateComponent(this.Width / 2 - (this.label1.Width + 5 + this.PrecioFinalLbl.Width + 5 + this.DescuentoTxt.Width + 5 + this.PrecioFinalLbl.Width) / 2, this.label1.Location.Y);
            this.PrecioFinalLbl.Location = this.RelocateComponent(this.label1.Location.X + this.label1.Width + 5, this.PrecioFinalLbl.Location.Y);
            this.DescuentoTxt.Location = this.RelocateComponent(this.PrecioLbl.Location.X + this.PrecioLbl.Width + 5, this.DescuentoTxt.Location.Y);
            this.PrecioFinalLbl.Location = this.RelocateComponent(this.DescuentoTxt.Location.X + this.DescuentoTxt.Width + 5, this.PrecioFinalLbl.Location.Y);
            this.NextStepBtn.Visible = false;
            this.label1.Visible = true;
            this.DescuentoTxt.Visible = true;
            this.PrecioFinalLbl.Visible = true;
            this.label3.Visible = true;
            this.CantMinTxt.Visible = true;
            this.OKBtn.Visible = true;
        }

        private void ProductLbl_TextChanged(object sender, EventArgs e)
        {
            if (this.ProductLbl.Text.IndexOf(',') > 0)
            {
                string str = this.ProductLbl.Text.Substring(0, this.ProductLbl.Text.IndexOf(','));
                string lower1 = this.ProductLbl.Text.Substring(this.ProductLbl.Text.IndexOf(',') + 2).ToLower();
                string lower2 = this.BarcodeTxt.Text.ToLower();
                if (this.BarcodeTxt.Text == str || lower2 == lower1)
                {
                    this.flagProduct = true;
                    this.DescuentoTxt.Text = "0";
                    this.CantMinTxt.Text = "1";
                    this.SaleByPieceRadio.Checked = true;
                }
                else
                    this.flagProduct = false;
            }
            else
                this.flagProduct = false;
        }

        private void FormAgregarPrecioCliente_SizeChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void SaleByPieceRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.piecesCasesLbl.Text = "piezas";
        }

        private void SaleByCaseRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.piecesCasesLbl.Text = "cajas";
        }

        private void DescuentoTxt_Enter(object sender, EventArgs e)
        {
            this.DescuentoTxt.SelectAll();
        }

        private void CantMinTxt_Enter(object sender, EventArgs e)
        {
            this.CantMinTxt.SelectAll();
        }

        private void DescuentoTxt_Click(object sender, EventArgs e)
        {
            this.DescuentoTxt.SelectAll();
        }

        private void CantMinTxt_Click(object sender, EventArgs e)
        {
            this.CantMinTxt.SelectAll();
        }

        private void FormAgregarPrecioCliente_SizeChanged_1(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
