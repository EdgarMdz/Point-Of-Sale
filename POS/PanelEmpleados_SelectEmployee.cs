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
    public partial class PanelEmpleados_SelectEmployee : Form
    {
        private int _employeeID;
        public int employeeID
        {
            get
            {
                return this._employeeID;
            }
        }

        public PanelEmpleados_SelectEmployee(DataTable employeeList)
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.dataGridView1.DataSource = (object)employeeList;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.chooseEmployee();
        }

        private void chooseEmployee()
        {
            this._employeeID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["id_Empleado"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PanelEmpleados_SelectEmployee_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["Puesto"].Width = (int)((double)this.dataGridView1.Width * 0.25);
            this.dataGridView1.Columns["Nombre"].Width = (int)((double)this.dataGridView1.Width * 0.75) - 1;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!this.dataGridView1.Rows[e.RowIndex].Visible)
                return;
            if (e.RowIndex % 2 != 0)
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
            else
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["id_Empleado"].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.chooseEmployee();
        }

    }
}
