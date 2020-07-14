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
    public partial class PanelProveedoresPromosAddEdit : Form
    {
        private Proveedor proveedor;
        private Oferta promo;
        private bool editMode;



        public PanelProveedoresPromosAddEdit(
          Proveedor supplier,
          AutoCompleteStringCollection barcodes,
          AutoCompleteStringCollection descriptions)
        {
            this.InitializeComponent();
            this.TitleLbl.Text = "Nueva Promoción";
            this.centerTitle();
            this.proveedor = supplier;
            this.BarCodeTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.BarCodeTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.BarCodeTxt.AutoCompleteCustomSource = barcodes;
            this.descriptionTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.descriptionTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.descriptionTxt.AutoCompleteCustomSource = descriptions;
            this.Height = this.NextBtn.Location.Y + this.NextBtn.Height + 10;
            this.editMode = false;
            this.NextStepPanel.Visible = false;
            this.OKBtn.Hide();
            this.ShowInTaskbar = false;
        }

        public PanelProveedoresPromosAddEdit(Proveedor supplier, Oferta promo)
        {
            this.InitializeComponent();
            this.editMode = true;
            this.BarCodeTxt.Text = promo.Barcode;
            this.BarCodeTxt.Enabled = false;
            this.descriptionTxt.Text = promo.ProductDescription;
            this.descriptionTxt.Enabled = false;
            this.CostTxt.Text = promo.cost.ToString("n2");
            this.MinQuantTxt.Text = promo.MinimumQuantityToBuy.ToString("n2");
            this.StartDatePicker.Value = promo.StartingPomoDate.Date;
            this.EndDatePicker.Value = promo.EndingPromoDate.Date;
            this.NotesTxt.Text = promo.notes;
            this.TitleLbl.Text = "Editar Oferta";
            this.centerTitle();
            this.NextBtn.Hide();
            this.proveedor = supplier;
            this.promo = promo;
        }

        private void centerTitle()
        {
            this.TitleLbl.Left = (this.Width - this.TitleLbl.Width) / 2;
        }

        private void BarCodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void CostTxt_MinQuantTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (textBox.Text.IndexOf('.') <= -1 || e.KeyChar != '.')
                return;
            e.Handled = true;
        }

        private void BarCodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || this.BarCodeTxt.AutoCompleteCustomSource.IndexOf(this.BarCodeTxt.Text) <= -1)
                return;
            this.descriptionTxt.Text = this.descriptionTxt.AutoCompleteCustomSource[this.BarCodeTxt.AutoCompleteCustomSource.IndexOf(this.BarCodeTxt.Text)];
            this.showNextStep();
        }

        private void BarCodeTxt_Leave(object sender, EventArgs e)
        {
            if (this.BarCodeTxt.AutoCompleteCustomSource.IndexOf(this.BarCodeTxt.Text) <= -1)
                return;
            this.descriptionTxt.Text = this.descriptionTxt.AutoCompleteCustomSource[this.BarCodeTxt.AutoCompleteCustomSource.IndexOf(this.BarCodeTxt.Text)];
            this.showNextStep();
        }

        private void descriptionTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return || this.descriptionTxt.AutoCompleteCustomSource.IndexOf(this.descriptionTxt.Text.ToLower()) <= -1)
                return;
            this.BarCodeTxt.Text = this.BarCodeTxt.AutoCompleteCustomSource[this.descriptionTxt.AutoCompleteCustomSource.IndexOf(this.descriptionTxt.Text)];
            this.showNextStep();
        }

        private void descriptionTxt_Leave(object sender, EventArgs e)
        {
            if (this.descriptionTxt.AutoCompleteCustomSource.IndexOf(this.descriptionTxt.Text.ToLower()) <= -1)
                return;
            this.BarCodeTxt.Text = this.BarCodeTxt.AutoCompleteCustomSource[this.descriptionTxt.AutoCompleteCustomSource.IndexOf(this.descriptionTxt.Text)];
            this.showNextStep();
        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.editMode || this.BarCodeTxt.AutoCompleteCustomSource.IndexOf(this.BarCodeTxt.Text) == this.descriptionTxt.AutoCompleteCustomSource.IndexOf(this.descriptionTxt.Text.ToLower()))
                return;
            this.Height = this.NextBtn.Location.Y + this.NextBtn.Height + 10;
            this.NextStepPanel.Visible = false;
            this.OKBtn.Hide();
            this.NextBtn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.showNextStep();
        }

        private void showNextStep()
        {
            if (this.BarCodeTxt.AutoCompleteCustomSource.IndexOf(this.BarCodeTxt.Text) != this.descriptionTxt.AutoCompleteCustomSource.IndexOf(this.descriptionTxt.Text.ToLower()))
                return;
            this.NextStepPanel.Show();
            this.NextBtn.Hide();
            this.CostTxt.Text = new Producto(this.BarCodeTxt.Text).PurchaseCost.ToString("n2");
            this.CostTxt.Focus();
            this.StartDatePicker.Value = DateTime.Now;
            this.EndDatePicker.Value = DateTime.Now.AddDays(1.0);
            this.Height = 650;
            this.OKBtn.Show();
            this.CenterToScreen();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!this.editMode)
            {
                if (!(this.StartDatePicker.Value.Date <= this.EndDatePicker.Value.Date))
                    return;
                this.promo = new Oferta(this.BarCodeTxt.Text);
                this.promo.cost = Convert.ToDouble(this.CostTxt.Text);
                this.promo.MinimumQuantityToBuy = Convert.ToDouble(this.MinQuantTxt.Text);
                this.promo.StartingPomoDate = this.StartDatePicker.Value.Date;
                this.promo.EndingPromoDate = this.EndDatePicker.Value.Date;
                this.promo.notes = this.NotesTxt.Text;
                try
                {
                    if (!this.promo.CorroborateExistenceOfSimilarPromo(this.proveedor.ID))
                    {
                        this.promo.Add(this.proveedor.ID);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        int num = (int)MessageBox.Show("Ya existe una oferta registrada para la cantidad ingresada ($" + this.MinQuantTxt.Text + ").", "Coincidencia de Ofertas", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("No se pudo completar la accion\nError:" + ex.Message, "Ocurrió un Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                this.promo.cost = Convert.ToDouble(this.CostTxt.Text);
                this.promo.MinimumQuantityToBuy = Convert.ToDouble(this.MinQuantTxt.Text);
                this.promo.StartingPomoDate = this.StartDatePicker.Value;
                this.promo.EndingPromoDate = this.EndDatePicker.Value;
                this.promo.notes = this.NotesTxt.Text;
                if (!this.promo.CorroborateExistenceOfSimilarPromo(this.proveedor.ID))
                {
                    this.promo.Update();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    int num = (int)MessageBox.Show("Ya existe una oferta registrada para la cantidad ingresada ($" + this.MinQuantTxt.Text + ").", "Coincidencia de Ofertas", MessageBoxButtons.OK);
                }
            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            this.EndDatePicker.MinDate = this.StartDatePicker.Value.AddDays(1.0);
        }

        private void CostTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.CostTxt.Text == ""))
                return;
            this.CostTxt.Text = "0.00";
        }

        private void MinQuantTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.MinQuantLbl.Text == ""))
                return;
            this.MinQuantLbl.Text = "0.00";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
