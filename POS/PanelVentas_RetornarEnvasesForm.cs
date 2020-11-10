using POS.dataBaseDataSetTableAdapters;
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
    public partial class PanelVentas_RetornarEnvasesForm : Form
    {
        Venta sale;
        int employeeID;
        double refoundMoney;

        public double MoneyToRefound { get { return refoundMoney; } }

        public PanelVentas_RetornarEnvasesForm(long saleID, int employeeID)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;


            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("century gothic", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("century gothic", 16, FontStyle.Bold);

            refoundMoney = 0;

            sale = new Venta(saleID);
            this.employeeID = employeeID;

            dataGridView1.Select();

            FillTable(saleID);

        }
        
        private void FillTable(long saleID) => dataGridView1.DataSource = Venta.getReturnableProducts(saleID);

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void accept()
        {
            dataGridView1.EndEdit();
            double count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var amount = Convert.ToInt32(row.Cells["toBeReturned"].Value);
                sale.returnPackages(row.Cells["Código de Barras"].Value.ToString(), amount, employeeID);
                refoundMoney += amount * Convert.ToDouble(row.Cells["costo"].Value);
                count += amount;
            }

            if (count > 0)
                this.DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.accept();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["costo"].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "toBeReturned",
                HeaderText = "Envases a Retornar",
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    ForeColor = Color.LimeGreen,
                    Font = new Font("Century Gothic", 15f, FontStyle.Bold)
                },
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });


            CellFormatting();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                if (e.ColumnIndex == dataGridView1.Columns["toBeReturned"].Index && e.RowIndex >= 0)
                    dataGridView1.Cursor = Cursors.IBeam;
                else
                    dataGridView1.Cursor = Cursors.Arrow;
            }
        }

        private void CellFormatting()
        {
            int num = 0;
            for (int index = 0; index < this.dataGridView1.RowCount; ++index)
            {
                if (this.dataGridView1.Rows[index].Visible)
                {
                    if (num % 2 == 0)
                        this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                    else
                        this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                    ++num;
                }
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.Columns["toBeReturned"] != null && dataGridView1.RowCount > 0)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["toBeReturned"].Index && dataGridView1.CurrentCell.RowIndex >= 0)
                    dataGridView1.ReadOnly = false;
                else
                    dataGridView1.ReadOnly = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var amount = Math.Floor(Math.Abs(Convert.ToDouble(dataGridView1[e.ColumnIndex, e.RowIndex].Value)));
                var max = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Envases pendientes"].Value);

                amount = amount <= max ? amount : max;

                dataGridView1[e.ColumnIndex, e.RowIndex].Value = amount;

            }
            catch (FormatException) { dataGridView1[e.ColumnIndex, e.RowIndex].Value = "0"; }
            toolTip1.Hide(this);
        }

        private void PanelVentas_RetornarEnvasesForm_Load(object sender, EventArgs e)
        {
            this.Focus();
            try {
                dataGridView1.Columns["tobereturned"].HeaderCell.Style.BackColor = Color.FromArgb(0, 172, 224);
                dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(230,230,230);
                dataGridView1.Columns["tobereturned"].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns["tobereturned"].DefaultCellStyle.ForeColor = Color.FromArgb(0, 172, 224); 

                dataGridView1.BeginInvoke(new Action(() =>
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["tobeReturned"];
                    dataGridView1.BeginEdit(false);
                }));
                /*dataGridView1.Select();
                dataGridView1.Focus();*/
            }
            catch (Exception){ }
         }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var cellRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            toolTip1.Show("Ingrese la cantidad de envases que se van a retornar",
                          this, dataGridView1.Location.X + cellRect.X + cellRect.Width,
                          dataGridView1.Location.Y + cellRect.Y - 15,
                          5000);
            dataGridView1.ShowCellToolTips = true;
        }
    }
}