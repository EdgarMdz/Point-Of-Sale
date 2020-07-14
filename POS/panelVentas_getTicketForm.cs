using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class panelVentas_getTicketForm : Form
    {
        private int _ticketNumber;

        public int ticketNumber
        {
            get
            {
                return this._ticketNumber;
            }
        }

        public panelVentas_getTicketForm()
        {
            this.InitializeComponent();
            this._ticketNumber = -1;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            this.validateTicket();
        }

        private void validateTicket()
        {
            int int32 = Convert.ToInt32(this.textBox1.Text, 16);
            if (Venta.doesSaleExist(int32))
            {
                this._ticketNumber = int32;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                int num = (int)MessageBox.Show("No se encontró la venta en la base de datos. Revise que el valor sea correcto");
                this.textBox1.Focus();
                this.textBox1.SelectAll();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char upper = char.ToUpper(e.KeyChar);
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (upper == 'A' || upper == 'B') || (upper == 'C' || upper == 'D' || (upper == 'E' || upper == 'F')))
                return;
            SystemSounds.Hand.Play();
            e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.validateTicket();
            if (e.KeyCode != Keys.Escape)
                return;
            this.Close();
        }
    }
}
