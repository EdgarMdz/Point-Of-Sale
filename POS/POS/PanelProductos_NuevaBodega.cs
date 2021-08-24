using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class PanelProductos_NuevaBodega : Form
    {
        private bool editing;
        private Bodega depot;

        public PanelProductos_NuevaBodega()
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.editing = false;
            this.depot = null;
        }

        public PanelProductos_NuevaBodega(int depotID)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.editing = true;
            this.depot = new Bodega(depotID);
            this.DepotTxt.Text = this.depot.name;
        }

        private void PanelProductos_NuevaBodega_Load(object sender, EventArgs e)
        {
        }

        private void DepotTxt_Enter(object sender, EventArgs e)
        {
            if (this.DepotLbl.Visible)
                return;
            this.DepotLbl.Visible = true;
        }

        private void DepotTxt_Leave(object sender, EventArgs e)
        {
            this.DepotLbl.Visible = this.DepotTxt.Text != "";
        }

        private void DepotTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (this.DepotLbl.Visible || !(this.DepotTxt.Text != ""))
                return;
            this.DepotLbl.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!this.editing)
            {
                this.createDepot();
            }
            else
            {
                this.editDepot();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void editDepot()
        {
            foreach (DataRow row in (InternalDataCollectionBase)Bodega.GetDepots().Rows)
            {
                if (row["Nombre"].ToString().ToLower() == this.DepotTxt.Text.ToLower() && this.depot.ID != Convert.ToInt32(row["ID_Bodega"]))
                {
                    MessageBox.Show("Ya existe una bodega con este nombre.");
                    this.DepotTxt.Text += " Nuevo";
                    this.DepotTxt.Select();
                    return;
                }
            }
            if (this.DepotTxt.Text.ToLower() != this.depot.name.ToLower())
            {
                this.depot.name = this.DepotTxt.Text;
                this.depot.Rename();
            }
        }

        private void createDepot()
        {
            if (this.DepotTxt.Text != "")
            {
                foreach (DataRow row in Bodega.GetDepots().Rows)
                {
                    if (row["Nombre"].ToString().ToLower() == this.DepotTxt.Text.ToLower())
                    {
                        MessageBox.Show("Ya existe una bodega con este nombre.");
                        this.DepotTxt.Text += " Nuevo";
                        this.DepotTxt.Select();
                        return;
                    }
                }

                Bodega bodega = new Bodega(Bodega.newDepot(this.DepotTxt.Text));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (this.DepotLbl.Visible)
            {
                this.errorProvider1.SetError(DepotLbl, "Ingrese el nombre de la bodega");
            }
            else
            {
                this.DepotTxt.HintForeColor = Color.Tomato;
                this.DepotTxt.LineIdleColor = Color.Tomato;
            }
        }

        private void DepotTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!this.editing)
                    this.createDepot();
                else
                    this.editDepot();
            }
            if (e.KeyCode != Keys.Escape)
                return;
            this.Close();
        }

        private void PanelProductos_NuevaBodega_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(81, 173, 207)),
                e.ClipRectangle);
        }
    }
}
