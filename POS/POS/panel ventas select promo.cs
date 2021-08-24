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
    public partial class panel_ventas_select_promo : Form
    {
        int currentPromoID = -1;

        public int choosenPromo { get { return currentPromoID; } }
        public panel_ventas_select_promo()
        {
            InitializeComponent();

            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        
            dataGridView1.DataSource = Producto.getListOfPromos();

            if (dataGridView1.RowCount > 0)
                displayPromoDetals(0);
        }

        private void displayPromoDetals(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];
            int promoID = Convert.ToInt32(row.Cells["promoID"].Value);

            if (promoID != currentPromoID)
            {
                //removing controls except headers and styles
                for (int j = tableLayoutPanel1.Controls.Count; j > 2; j--)
                {
                    tableLayoutPanel1.Controls.RemoveAt(j - 1);
                }

                tableLayoutPanel1.RowCount = 1;

                DataTable table = Producto.getPromo(promoID).Tables[1];
                int i = 1;

                foreach (DataRow drow in table.Rows)
                {
                    tableLayoutPanel1.RowCount++;
                    Control[] controls = newRow(drow["producto"].ToString(), drow["amount"].ToString(),drow["id_producto"].ToString());

                    tableLayoutPanel1.Controls.Add(controls[0], 0, i);
                    tableLayoutPanel1.Controls.Add(controls[1], 1, i);
                    i++;
                }
                currentPromoID = promoID;
            }
        }

        private Control[] newRow(string productName, string amount, string barcode)
        {
            return new Control[2]{
                new Label(){
                Text=productName,
                Dock= DockStyle.Fill,
                AutoSize=false,
                ForeColor=Color.Black,
                TextAlign= ContentAlignment.MiddleCenter,
                Padding=new Padding(0,0,0,0),
                Margin=new Padding(0,0,0,0),
                Name = "product_"+barcode
                },
                new Label(){
                Text=amount,
                Dock= DockStyle.Fill,
                AutoSize=false,
                ForeColor=Color.Black,
                TextAlign= ContentAlignment.MiddleCenter,
                Padding=new Padding(0,0,0,0),
                Margin=new Padding(0,0,0,0),
                Name= "amount"+barcode
                }
            };

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["promoID"].Visible = false;

            int width = 0;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                if (column.Visible) width += column.Width;
            }

            if (dataGridView1.Width != width)
                dataGridView1.Columns["Costo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridView1.RowCount > 0)
                dataGridView1.Focus();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                displayPromoDetals(e.RowIndex);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            filterPromos();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            cm.SuspendBinding();
            if (searchTxt.Text=="")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }

                displayPromoDetals(0);
            }
            cm.ResumeBinding();
        }

        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                searchTxt.Text = "";

            if (e.KeyCode == Keys.Enter)
                filterPromos();
        }

        private void filterPromos()
        {
            CurrencyManager cm =(CurrencyManager) this.BindingContext[dataGridView1.DataSource];
            cm.SuspendBinding();

            if (searchTxt.Text.Trim() != "")
            {
                int[] IDs = Producto.findPromo(searchTxt.Text);
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int promoid = Convert.ToInt32(row.Cells["promoID"].Value);

                    foreach (int id in IDs)
                    {
                        if(promoid== id)
                        {
                            row.Visible = true;

                            break;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }

                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Visible)
                    {
                        displayPromoDetals(row1.Index);
                        break;
                    }

                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
                displayPromoDetals(0);
            }

            cm.ResumeBinding();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
