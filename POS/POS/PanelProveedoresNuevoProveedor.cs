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
    public partial class PanelProveedoresNuevoProveedor : Form
    {
        private bool firstStage;


        public new string Name { get; set; }

        public double debt { get; set; }

        public PanelProveedoresNuevoProveedor()
        {
            this.InitializeComponent();
            this.firstStage = true;
            this.ShowInTaskbar = false;
        }

        private void PanelProveedoresNuevoProveedor_Load(object sender, EventArgs e)
        {
            this.MessageLbl.Text = "Nombre de la compañía:";
            this.CenterMessageLabel();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.GotoNextStage();
        }

        private void GotoNextStage()
        {
            if (this.firstStage)
            {
                this.Name = this.InputTxt.Text;
                this.MessageLbl.Text = "¿Tiene algún adeudo con el proveedor?";
                this.CenterMessageLabel();
                this.InputTxt.Text = "0.00";
                this.InputTxt.SelectionStart = 0;
                this.InputTxt.SelectionLength = this.InputTxt.Text.Length;
                this.InputTxt.Focus();
                this.OkBtn.Text = "Finalizar";
                this.firstStage = false;
            }
            else
            {
                this.debt = Convert.ToDouble(this.InputTxt.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void CenterMessageLabel()
        {
            this.MessageLbl.Location = new Point((this.Width - this.MessageLbl.Width) / 2, this.MessageLbl.Location.Y);
        }

        private void InputTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.firstStage)
                return;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar != '.' || this.InputTxt.Text.IndexOf('.') <= -1)
                return;
            e.Handled = true;
        }

        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode != Keys.Return)
                return;
            this.GotoNextStage();
        }

    }
}
