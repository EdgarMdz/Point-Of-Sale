using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class supplierStatisticsForm : Form
    {
        private Proveedor proveedor;

        public supplierStatisticsForm(Proveedor supplier)
        {
            InitializeComponent();

            this.proveedor = supplier;
            comboBox1.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


            dateTimePicker1.Value = DateTime.Today;

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;


            this.dataGridView3.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;


            this.dataGridView4.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            dataGridView3.DefaultCellStyle.Font = dataGridView4.DefaultCellStyle.Font = new Font("century gothic", 10f, FontStyle.Bold);
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("century gothic", 12f, FontStyle.Bold);

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setPurchaseStatistics();
        }

        public void setPurchaseStatistics()
        {
            setBestSellers();
            setWorstSellers();
            setPurchaseChart();
        }

        private void setPurchaseChart()
        {
            Proveedor.PeriodOfTime period;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
                case 1:
                    period = Proveedor.PeriodOfTime.ByMonth;
                    break;
                case 2:
                    period = Proveedor.PeriodOfTime.ByYear;
                    break;

                default:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
            }

            DataTable dt = proveedor.getPurchaseStatistics(dateTimePicker1.Value, period);


            LineSeries purchases = new LineSeries() { Title = "Compra", PointGeometry = DefaultGeometries.Circle, PointGeometrySize = 15, Values = new ChartValues<double>() };
            LineSeries payment = new LineSeries { Title = "Pagos", PointGeometry = DefaultGeometries.Circle, PointGeometrySize = 15, Values = new ChartValues<double>() };


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];
                purchases.Values.Add(Convert.ToDouble(row["Total"]));
                payment.Values.Add(Convert.ToDouble(row["Abono"]));
            }

            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(purchases);
            cartesianChart1.Series.Add(payment);

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setPurchaseStatistics();
        }


        private void setBestSellers()
        {
            Proveedor.PeriodOfTime period;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
                case 1:
                    period = Proveedor.PeriodOfTime.ByMonth;
                    break;
                case 2:
                    period = Proveedor.PeriodOfTime.ByYear;
                    break;

                default:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
            }

            dataGridView3.DataSource = proveedor.getBestSellers(dateTimePicker1.Value, period);
        }

        private void setWorstSellers()
        {
            Proveedor.PeriodOfTime period;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
                case 1:
                    period = Proveedor.PeriodOfTime.ByMonth;
                    break;
                case 2:
                    period = Proveedor.PeriodOfTime.ByYear;
                    break;

                default:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
            }

            dataGridView4.DataSource = proveedor.getWorstSellers(dateTimePicker1.Value, period);
        }

        private void dataGridView3_DataSourceChanged(object sender, EventArgs e)
        {
            (sender as DataGridView).AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            (sender as DataGridView).Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
