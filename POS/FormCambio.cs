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
    public partial class FormCambio : Form
    {
        private double change { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 33554432;
                return createParams;
            }
        }

        public FormCambio(double change)
        {
            this.InitializeComponent();
            this.change = change;
        }

        private void FormCambio_Load(object sender, EventArgs e)
        {
            this.CambioLbl.Text = "$" + this.change.ToString("n2");
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void FormCambio_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LimeGreen);
            Graphics graphics = e.Graphics;
            pen.Width = 5f;
            graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }
    }
}
