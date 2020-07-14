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
    public partial class PanelProveedorPromos : Form
    {
        private Proveedor proveedor { get; set; }

        public PanelProveedorPromos()
        {
            this.InitializeComponent();
        }

        public PanelProveedorPromos(Proveedor proveedor)
        {
            this.InitializeComponent();
            this.proveedor = proveedor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelProveedorPromos_Load_1(object sender, EventArgs e)
        {
            this.loadPromos();
        }

        private void loadPromos()
        {
            this.PromoGridView.DataSource = (object)this.proveedor.GetSales();
            this.PromoGridView.Columns["ID"].Visible = false;
            for (int index = 0; index < this.PromoGridView.Rows.Count; ++index)
            {
                if (Convert.ToDateTime(this.PromoGridView.Rows[index].Cells["Fecha de Fin"].Value.ToString()) < DateTime.Now.Date)
                {
                    this.PromoGridView.Rows[index].DefaultCellStyle.ForeColor = Color.DimGray;
                    this.PromoGridView.Rows[index].DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
                    this.PromoGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.Gray;
                }
            }
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            AutoCompleteStringCollection barcodes = new AutoCompleteStringCollection();
            AutoCompleteStringCollection descriptions = new AutoCompleteStringCollection();
            foreach (DataRow row in (InternalDataCollectionBase)Producto.fillTable().Rows)
            {
                barcodes.Add(row["Código de Barras"].ToString());
                descriptions.Add(row["Descripción"].ToString().ToLower());
            }
            PanelProveedoresPromosAddEdit proveedoresPromosAddEdit = new PanelProveedoresPromosAddEdit(this.proveedor, barcodes, descriptions);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (proveedoresPromosAddEdit.ShowDialog() == DialogResult.OK)
                this.loadPromos();
            darkForm.Close();
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar la oferta?", "Borrar Oferta", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Oferta oferta = new Oferta(Convert.ToInt32(this.PromoGridView.SelectedRows[0].Cells["ID"].Value));
            if (oferta.ID <= 0)
                return;
            oferta.Delete();
            this.loadPromos();
        }

        private void EditRowBtn_Click(object sender, EventArgs e)
        {
            this.EditPromo();
        }

        private void PromoGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditPromo();
        }

        private void EditPromo()
        {
            DarkForm darkForm = new DarkForm();
            PanelProveedoresPromosAddEdit proveedoresPromosAddEdit = new PanelProveedoresPromosAddEdit(this.proveedor, new Oferta(int.Parse(this.PromoGridView.SelectedRows[0].Cells[0].Value.ToString())));
            darkForm.Show();
            if (proveedoresPromosAddEdit.ShowDialog() == DialogResult.OK)
                this.loadPromos();
            darkForm.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
