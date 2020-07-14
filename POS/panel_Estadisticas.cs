using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS
{
    public partial class panel_Estadisticas : Form
    {
        private Producto product;
        public panel_Estadisticas()
        {
            InitializeComponent();

            this.periodTimeCombo.SelectedIndex = 1; 
            this.datePicker.MaxDate = DateTime.Today.Date;
            this.datePicker.Value = DateTime.Today.Date;


            ScrapCard();
            bestSellCard();
            profitInvestmentCard();
            
        } 
        
        private void periodTimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ScrapCard();
            this.bestSellCard();
            this.profitInvestmentCard();
            if (this.product == null)
                return;
            this.ProductStatistics();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ScrapCard();
            this.bestSellCard();
            this.profitInvestmentCard();
            if (this.product == null)
                return;
            this.ProductStatistics();
        }

        private void ScrapCard()
        {
            DataTable scrap = Producto.getScrap(this.datePicker.Value, this.periodTimeCombo.SelectedIndex);
            if (scrap != null && scrap.Rows.Count > 0)
            {
                this.scrapNoInfoLbl.Visible = false;
                this.splitContainer1.Enabled = true;
                this.bunifuCards1.color = Color.Tomato;
                this.scrapChart.Palette = ChartColorPalette.Pastel;
                this.scrapChart.Series.Clear();
                this.scrapChart.Legends.Clear();
                this.scrapChart.Legends.Add("Shit");
                this.scrapChart.Legends[0].LegendStyle = LegendStyle.Table;
                this.scrapChart.Legends[0].Docking = Docking.Top;
                this.scrapChart.Legends[0].Alignment = StringAlignment.Center;
                this.scrapChart.Legends[0].Title = "Top 10 Productos más Desechados";
                this.scrapChart.Legends[0].BorderColor = Color.Black;
                string name = "Scrap";
                this.scrapChart.Series.Add(name);
                this.scrapChart.Series[name].ChartType = SeriesChartType.Pie;
                int index1;
                for (index1 = 0; index1 < 10 && index1 < scrap.Rows.Count; ++index1)
                {
                    DataRow row = scrap.Rows[index1];
                    this.scrapChart.Series[name].Points.AddXY((double)index1, Convert.ToDouble(row["Costo"]));
                    this.scrapChart.Series[name].Points[index1].LegendText = string.Format("{0} {1}", (object)row["Descripción"].ToString(), (object)row["Marca"].ToString());
                    this.scrapChart.Series[name].Points[index1].Label = string.Format("{0} piezas (${1} pesos)", row["Cantidad"], row["Costo"]);
                }
                if (index1 < scrap.Rows.Count)
                {
                    double num = 0.0;
                    for (int index2 = index1; index2 < scrap.Rows.Count; ++index2)
                    {
                        DataRow row = scrap.Rows[index2];
                        num += Convert.ToDouble(row["Costo"]);
                    }
                    this.scrapChart.Series[name].Points.AddXY((object)"Otros", (object)num);
                }
                this.scrapGridView.DataSource = (object)scrap;
            }
            else
            {
                this.scrapNoInfoLbl.Visible = true;
                this.splitContainer1.Enabled = false;
                this.bunifuCards1.color = Color.DimGray;
                this.scrapChart.Palette = ChartColorPalette.Grayscale;
                this.scrapGridView.BackgroundColor = Color.DimGray;
                this.scrapGridView.DefaultCellStyle.ForeColor = Color.DimGray;
                this.scrapGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            }
        }

        private void scrapGridView_DataSourceChanged(object sender, EventArgs e)
        {
            this.scrapGridView.Columns["Código de Barras"].Visible = false;
            this.resizeScrapDataGrid();
            foreach (DataGridViewColumn column in (BaseCollection)this.scrapGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.scrapGridView.BackgroundColor = Color.White;
            this.scrapGridView.DefaultCellStyle.ForeColor = Color.FromArgb(0, 130, 170);
            this.scrapGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 130, 170);
            this.scrapGridView.RowHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
            this.scrapGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
            this.scrapGridView.DefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
        }

        private void scrapGridView_SizeChanged(object sender, EventArgs e)
        {
            this.resizeScrapDataGrid();
        }

        private void resizeScrapDataGrid()
        {
            if (this.scrapGridView.Rows.Count <= 0)
                return;
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.scrapGridView.Columns)
            {
                if (column.Visible)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    num += column.Width;
                }
            }
            if (num >= this.scrapGridView.Width)
                return;
            this.scrapGridView.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void scrapGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.scrapGridView.Rows.Count <= 0)
                return;
            for (int index = 0; index < this.scrapGridView.Rows.Count; ++index)
            {
                if (index % 2 == 0)
                    this.scrapGridView.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                else
                    this.scrapGridView.Rows[index].DefaultCellStyle.BackColor = Color.White;
                this.scrapGridView.Rows[index].DefaultCellStyle.SelectionBackColor = Color.Transparent;
                this.scrapGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 130, 170);
                this.scrapGridView.ClearSelection();
            }
        }

        private void bestSellCard()
        {
            DataTable bestSellProducts = Producto.getBestSellProducts(this.datePicker.Value, this.periodTimeCombo.SelectedIndex);
            if (bestSellProducts != null && bestSellProducts.Rows.Count > 0)
            {
                this.bestSellersCard.color = Color.LimeGreen;
                this.bestSellerNoInfoLbl.Hide();
                this.bestSellChart.Palette = ChartColorPalette.SeaGreen;
                this.splitContainer2.Enabled = true;
                this.bestSellChart.Series.Clear();
                this.bestSellChart.Legends.Clear();
                this.bestSellChart.Legends.Add("Shit");
                this.bestSellChart.Legends[0].LegendStyle = LegendStyle.Table;
                this.bestSellChart.Legends[0].Docking = Docking.Top;
                this.bestSellChart.Legends[0].Alignment = StringAlignment.Center;
                this.bestSellChart.Legends[0].Title = "Top 10 Producto más Vendidos";
                this.bestSellChart.Legends[0].BorderColor = Color.Black;
                string name = "Best sellers";
                this.bestSellChart.Series.Add(name);
                this.bestSellChart.Series[name].ChartType = SeriesChartType.Pie;
                this.bestSellChart.Series[name].Font = new Font("Century Gothic", 8f);
                for (int index = 0; index < 10 && index < bestSellProducts.Rows.Count; ++index)
                {
                    DataRow row = bestSellProducts.Rows[index];
                    this.bestSellChart.Series[name].Points.AddXY((double)index, Convert.ToDouble(row["Cantidad"]));
                    this.bestSellChart.Series[name].Points[index].LegendText = string.Format("{0} {1}", (object)row["Descripción"].ToString(), (object)row["Marca"].ToString());
                    this.bestSellChart.Series[name].Points[index].Label = string.Format("{0} piezas", row["Cantidad"]);
                }
                this.bestSellGridView.DataSource = (object)bestSellProducts;
            }
            else
            {
                this.bestSellerNoInfoLbl.Visible = true;
                this.splitContainer2.Enabled = false;
                this.bestSellersCard.color = Color.DimGray;
                this.bestSellChart.Palette = ChartColorPalette.Grayscale;
                this.bestSellGridView.BackgroundColor = Color.DimGray;
                this.bestSellGridView.DefaultCellStyle.ForeColor = Color.DimGray;
                this.bestSellGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
                this.bestSellGridView.Enabled = false;
            }
        }

        private void bestSellGridView_DataSourceChanged(object sender, EventArgs e)
        {
            this.bestSellGridView.Enabled = true;
            foreach (DataGridViewColumn column in (BaseCollection)this.bestSellGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.bestSellGridView.Columns["id_producto"].Visible = false;
            this.bestSellGridView.BackgroundColor = Color.White;
            this.bestSellGridView.DefaultCellStyle.ForeColor = Color.FromArgb(0, 130, 170);
            this.bestSellGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 130, 170);
            this.bestSellGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
            this.bestSellGridView.RowHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
            this.bestSellGridView.DefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
            this.resizeBestSellDataGrid();

            if (this.bestSellGridView.Rows.Count > 0 && product==null)
            {
                this.product = new Producto(this.bestSellGridView.Rows[0].Cells["id_producto"].Value.ToString());
                this.ProductStatistics();
            }
        }

        private void bestSellGridView_CellFormatting(
          object sender,
          DataGridViewCellFormattingEventArgs e)
        {
            if (this.bestSellGridView.Rows.Count <= 0)
                return;
            for (int index = 0; index < this.bestSellGridView.Rows.Count; ++index)
            {
                if (index % 2 == 0)
                    this.bestSellGridView.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                else
                    this.bestSellGridView.Rows[index].DefaultCellStyle.BackColor = Color.White;
                this.bestSellGridView.Rows[index].DefaultCellStyle.SelectionBackColor = Color.Transparent;
                this.bestSellGridView.Rows[index].DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 130, 170);
                this.bestSellGridView.ClearSelection();
            }
        }

        private void bestSellGridView_SizeChanged(object sender, EventArgs e)
        {
            this.resizeBestSellDataGrid();
        }

        private void resizeBestSellDataGrid()
        {
            if (this.bestSellGridView.Rows.Count <= 0)
                return;
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.bestSellGridView.Columns)
            {
                if (column.Visible)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    num += column.Width;
                }
            }
            if (num >= this.bestSellGridView.Width)
                return;
            this.bestSellGridView.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void profitInvestmentCard()
        {
            DataTable investProfitData = Venta.getSalesInvestProfitData(this.periodTimeCombo.SelectedIndex, this.datePicker.Value);
            this.investmentProfitChart.Series.Clear();
            this.investmentProfitChart.AxisX.Clear();
            this.investmentProfitChart.AxisY.Clear();
            this.investmentProfitChart.Zoom = ZoomingOptions.X;
            this.investmentProfitChart.Pan = PanningOptions.Unset;
            ChartValues<double> chartValues1 = new ChartValues<double>();
            ChartValues<double> chartValues2 = new ChartValues<double>();
            ChartValues<double> chartValues3 = new ChartValues<double>();
            ChartValues<double> chartValues4 = new ChartValues<double>();
            ChartValues<double> chartValues5 = new ChartValues<double>();
            ChartValues<double> chartValues6 = new ChartValues<double>();
            List<string> stringList = new List<string>();
            foreach (DataRow row in (InternalDataCollectionBase)investProfitData.Rows)
            {
                chartValues1.Add(Convert.ToDouble(row["Ventas"]));
                chartValues2.Add(Convert.ToDouble(row["Adeudo de Clientes"]));
                chartValues3.Add(Convert.ToDouble(row["Perdida por Scrap"]));
                chartValues4.Add(Convert.ToDouble(row["Inversion"]));
                chartValues5.Add(Convert.ToDouble(row["Ganancia"]));
                chartValues6.Add(Convert.ToDouble(row["Pago de Empleados"]));
                stringList.Add(row["Fecha"].ToString());
            }
            LiveCharts.SeriesCollection series1 = this.investmentProfitChart.Series;
            ColumnSeries columnSeries1 = new ColumnSeries();
            columnSeries1.Title = "Venta";
            columnSeries1.Values = (IChartValues)chartValues1;
            ColumnSeries columnSeries2 = columnSeries1;
            series1.Add((ISeriesView)columnSeries2);
            LiveCharts.SeriesCollection series2 = this.investmentProfitChart.Series;
            ColumnSeries columnSeries3 = new ColumnSeries();
            columnSeries3.Title = "Adeudo de Clientes";
            columnSeries3.Values = (IChartValues)chartValues2;
            ColumnSeries columnSeries4 = columnSeries3;
            series2.Add((ISeriesView)columnSeries4);
            LiveCharts.SeriesCollection series3 = this.investmentProfitChart.Series;
            ColumnSeries columnSeries5 = new ColumnSeries();
            columnSeries5.Title = "Perdida por Scrap";
            columnSeries5.Values = (IChartValues)chartValues3;
            ColumnSeries columnSeries6 = columnSeries5;
            series3.Add((ISeriesView)columnSeries6);
            LiveCharts.SeriesCollection series4 = this.investmentProfitChart.Series;
            ColumnSeries columnSeries7 = new ColumnSeries();
            columnSeries7.Title = "Pago de Empleados";
            columnSeries7.Values = (IChartValues)chartValues6;
            ColumnSeries columnSeries8 = columnSeries7;
            series4.Add((ISeriesView)columnSeries8);
            LiveCharts.SeriesCollection series5 = this.investmentProfitChart.Series;
            ColumnSeries columnSeries9 = new ColumnSeries();
            columnSeries9.Title = "Inversión";
            columnSeries9.Values = (IChartValues)chartValues4;
            ColumnSeries columnSeries10 = columnSeries9;
            series5.Add((ISeriesView)columnSeries10);
            LiveCharts.SeriesCollection series6 = this.investmentProfitChart.Series;
            ColumnSeries columnSeries11 = new ColumnSeries();
            columnSeries11.Title = "Ganancia";
            columnSeries11.Values = (IChartValues)chartValues5;
            ColumnSeries columnSeries12 = columnSeries11;
            series6.Add((ISeriesView)columnSeries12);
            this.investmentProfitChart.AxisX.Add(new LiveCharts.Wpf.Axis()
            {
                Title = "Fecha",
                Labels = (IList<string>)stringList
            });
            this.investmentProfitChart.AxisY.Add(new LiveCharts.Wpf.Axis()
            {
                Title = "Pesos",
                LabelFormatter = (Func<double, string>)(value => value.ToString("N"))
            });
        }

        private void ProductStatistics()
        {
            DataTable dataTable = Producto.ProductStatistics(this.product.Barcode, this.periodTimeCombo.SelectedIndex, this.datePicker.Value);
            this.statisticsProductsProductLbl.Text = string.Format("{0} {1}", (object)this.product.Description, (object)this.product.Brand);
            this.productStatisticsChart.Series.Clear();
            this.productStatisticsChart.AxisX.Clear();
            this.productStatisticsChart.AxisY.Clear();
            this.productStatisticsChart.Zoom = ZoomingOptions.X;
            this.productStatisticsChart.Pan = PanningOptions.Unset;
            ChartValues<double> chartValues1 = new ChartValues<double>();
            ChartValues<double> chartValues2 = new ChartValues<double>();
            List<string> stringList = new List<string>();
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                chartValues1.Add(Convert.ToDouble(row["Venta"]));
                chartValues2.Add(Convert.ToDouble(row["Compra"]));
                stringList.Add(row["Fecha"].ToString());
            }
            LiveCharts.SeriesCollection series1 = this.productStatisticsChart.Series;
            LineSeries lineSeries1 = new LineSeries();
            lineSeries1.Title = "Venta";
            lineSeries1.Values = (IChartValues)chartValues1;
            LineSeries lineSeries2 = lineSeries1;
            series1.Add((ISeriesView)lineSeries2);
            LiveCharts.SeriesCollection series2 = this.productStatisticsChart.Series;
            LineSeries lineSeries3 = new LineSeries();
            lineSeries3.Title = "Compra";
            lineSeries3.Values = (IChartValues)chartValues2;
            LineSeries lineSeries4 = lineSeries3;
            series2.Add((ISeriesView)lineSeries4);
            this.productStatisticsChart.AxisX.Add(new LiveCharts.Wpf.Axis()
            {
                Title = "Fecha",
                Labels = (IList<string>)stringList
            });
            this.productStatisticsChart.AxisY.Add(new LiveCharts.Wpf.Axis()
            {
                Title = "Piezas",
                LabelFormatter = (Func<double, string>)(value => value.ToString("N")),
                MinValue = 0.0
            });
        }

        private void StatisticsProductTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != System.Windows.Forms.Keys.Return || !(this.StatisticsProductTxt.Text != ""))
                return;
            DataTable table = Producto.SearchValueGetTable(this.StatisticsProductTxt.Text);
            if (table.Rows.Count == 1)
            {
                this.product = new Producto(table.Rows[0]["Código de Barras"].ToString());
                this.ProductStatistics();
                this.StatisticsProductTxt.Text = "";
            }
            else if (table.Rows.Count > 1)
            {
                DarkForm darkForm = new DarkForm();
                ChooseProductForm chooseProductForm = new ChooseProductForm(table);
                darkForm.Show();
                if (chooseProductForm.ShowDialog() == DialogResult.OK)
                {
                    this.product = new Producto(chooseProductForm.selectedItem[0]);
                    this.ProductStatistics();
                    this.StatisticsProductTxt.Text = "";
                }
                darkForm.Close();
            }
            else
            {
                int num = (int)MessageBox.Show("No se encontró el producto.");
                this.StatisticsProductTxt.SelectAll();
            }
        }

        private void StatisticsPanel_Resize(object sender, EventArgs e)
        {
            int height = this.bestSellersCard.Height;
            this.investmentProfitStatisticsCard.Height = height / 2;
            this.investmentProfitStatisticsCard.Width = this.StatisticsPanel.Width - this.investmentProfitStatisticsCard.Location.X - 10;
            this.ProductStatisticsCard.Location = new Point(this.ProductStatisticsCard.Location.X, this.investmentProfitStatisticsCard.Location.Y + this.investmentProfitStatisticsCard.Height + 10);
            this.ProductStatisticsCard.Height = height / 2;
            this.ProductStatisticsCard.Width = this.StatisticsPanel.Width - this.ProductStatisticsCard.Location.X - 10;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            int x1 = this.StatisticsProductTxt.Location.X;
            int width = this.StatisticsProductTxt.Width;
            int x2 = this.label3.Location.X;
            this.StatisticsProductTxt.Location = new Point(this.StatisticsProductTxt.Location.X, (this.panel1.Height - this.StatisticsProductTxt.Height) / 2);
            this.label3.Location = new Point(this.label3.Location.X, (this.panel1.Height - this.label3.Height) / 2);
        }

      

        private void statisticsProductsProductLbl_TextChanged(object sender, EventArgs e)
        {
            this.CenterToParent(this.statisticsProductsProductLbl);
        }

        private void ProductStatisticsCard_Resize(object sender, EventArgs e)
        {
            this.CenterToParent(this.statisticsProductsProductLbl);
        }

        private void CenterToParent(Label statisticsProductsProductLbl)
        {
            int width1 = statisticsProductsProductLbl.Parent.Width;
            int width2 = (int)statisticsProductsProductLbl.CreateGraphics().MeasureString(statisticsProductsProductLbl.Text, statisticsProductsProductLbl.Font).Width;
            statisticsProductsProductLbl.AutoSize = true;
            if (width1 > width2)
            {
                statisticsProductsProductLbl.Location = new Point((width1 - statisticsProductsProductLbl.Width) / 2, statisticsProductsProductLbl.Location.Y);
            }
            else
            {
                statisticsProductsProductLbl.AutoSize = false;
                statisticsProductsProductLbl.Width = width1;
                statisticsProductsProductLbl.AutoEllipsis = true;
                statisticsProductsProductLbl.Location = new Point(0, statisticsProductsProductLbl.Location.Y);
            }
        }

        private void investmentProfitStatisticsCard_SizeChanged(object sender, EventArgs e)
        {
            this.CenterToParent(this.InvestmentProfitLbl);
        }

    }
}
