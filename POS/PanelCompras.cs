﻿using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.PointOfService;


namespace POS
{
    public partial class PanelCompras : Form
    {
        private Proveedor supplier;
        private OrdenCompra PO;
        private int POemployeeID;
        private int CurrentEmployeeID;
        private Empleado currentEmployee;
        private Queue<bool> request;
        private CurrencyManager cm;
        CashDrawer m_Drawer;
        private bool inASearch;
        Control currentControl ;

        public PanelCompras(int employeeid, FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            this.POsContainerPanel.Dock = DockStyle.Fill;
            this.PODescriptionPanel.Visible = false;
            Queue<bool> boolQueue = new Queue<bool>();
            this.CurrentEmployeeID = employeeid;
            if (new Empleado(this.CurrentEmployeeID).isAdmin)
                return;
            this.deleteBtn.Visible = false;
            this.PayBtn.Visible = false;
            this.TotalLbl.Enabled = false;

            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NormalizeBtn_Click(object sender, EventArgs e)
        {
        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void PanelCompras_Load(object sender, EventArgs e)
        {
            this.loadPurchases();
            //<<<step1>>>--Start
            //Use a Logical Device Name which has been set on the SetupPOS.
            string strLogicalName = "CashDrawer";

            try
            {
                //Create PosExplorer
                PosExplorer posExplorer = new PosExplorer();

                DeviceInfo deviceInfo = null;

                try
                {
                    deviceInfo = posExplorer.GetDevice(DeviceType.CashDrawer, strLogicalName);
                    m_Drawer = (CashDrawer)posExplorer.CreateInstance(deviceInfo);
                }
                catch (Exception)
                {
                    //Nothing can be used.
                    return;
                }


            }
            catch (PosControlException)
            {
                //Nothing can be used.
                //Nothing can be used.
            }
            //<<<step1>>>--End
        }

        private void loadPurchases()
        {
            inASearch = false;
            DataTable allPo = OrdenCompra.getAllPO(DateTime.Now.Date);
            this.request = new Queue<bool>();
            this.PopulateLayout(allPo);
        }
        
        private bool toggleFlag = false;
        private bool ToggleFlag
        {
            get
            {
                bool aux = toggleFlag;
                toggleFlag = !aux;
                return aux;
            }
        }
        private async void PopulateLayout(DataTable purchases)
        {
            bool myFlag = ToggleFlag;

            flowLayoutPanel1.Controls.Clear();

            bool previousDays = false;
            bool currentDay = false;

            try
            {
                foreach (DataRow row in purchases.Rows)
                {
                    if (myFlag == toggleFlag)
                        throw new IndexOutOfRangeException();

                    var card = await Task.Run(() => this.createCard(row));

                    try
                    {
                        flowLayoutPanel1.Controls.Add(card);
                    }
                    catch (Exception) { return; }
                    DateTime dateTime = Convert.ToDateTime(card.Name.Substring(0, card.Name.IndexOf(',')));
                    if (dateTime.Date == DateTime.Now.Date)
                        currentDay = true;
                    if (dateTime.Date != DateTime.Now.Date && !previousDays && currentDay)
                    {
                        this.flowLayoutPanel1.SetFlowBreak(card, true);
                        previousDays = true;
                    }
                }
            }
            catch (IndexOutOfRangeException) { flowLayoutPanel1.Controls.Clear(); }
        }

        private BunifuCards createCard(DataRow row1)
        {

            BunifuCards bunifuCards = new BunifuCards();
            bunifuCards.Size = new Size(420, 380);
            bunifuCards.BackColor = Color.White;
            bunifuCards.BorderRadius = 35;
            bunifuCards.Margin = new Padding(20, 0, 20, 20);
            this.toolTip1.SetToolTip((Control)bunifuCards, "Orden #" + row1["ID_PO"].ToString());
            if (!Convert.ToBoolean(row1["Estado de Pago"]) && !Convert.ToBoolean(row1["Mercancia Recibida"]) && DateTime.Today.Date <= Convert.ToDateTime(row1["Fecha de Llegada"]).Date)
                bunifuCards.color = Color.FromArgb(0, 130, 170);
            else if (!Convert.ToBoolean(row1["Estado de Pago"]) && !Convert.ToBoolean(row1["Mercancia Recibida"]))
                bunifuCards.color = Color.Orange;
            else if (!Convert.ToBoolean(row1["Estado de Pago"]) && Convert.ToBoolean(row1["Mercancia Recibida"]))
                bunifuCards.color = Color.Red;
            else if (Convert.ToBoolean(row1["Estado de Pago"]) && Convert.ToBoolean(row1["Mercancia Recibida"]))
                bunifuCards.color = Color.LimeGreen;
            Label label1 = new Label();
            label1.Font = new Font("Century Gothic", 22f, FontStyle.Bold);
            label1.Text = row1["Nombre de la Empresa"].ToString();
            label1.BackColor = Color.Transparent;
            label1.AutoSize = true;
            this.toolTip1.SetToolTip((Control)label1, "Orden #" + row1["ID_PO"].ToString());
            BunifuGradientPanel bunifuGradientPanel = new BunifuGradientPanel();
            bunifuGradientPanel.Dock = DockStyle.Top;
            bunifuGradientPanel.Controls.Add((Control)label1);
            bunifuGradientPanel.Height = 50;
            bunifuGradientPanel.Width = bunifuCards.Width;
            this.toolTip1.SetToolTip((Control)bunifuGradientPanel, "Orden #" + row1["ID_PO"].ToString());
            bunifuGradientPanel.GradientBottomLeft = Color.White;
            bunifuGradientPanel.GradientBottomRight = Color.White;
            bunifuGradientPanel.GradientTopLeft = Color.White;
            bunifuGradientPanel.GradientTopRight = Color.White;
            label1.Location = new Point((label1.Parent.Width - label1.Width) / 2, (label1.Parent.Height - label1.Height) / 2);
            bunifuCards.Controls.Add((Control)bunifuGradientPanel);
            DataGridView dataGridView = new DataGridView();
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ReadOnly = true;
            dataGridView.Location = new Point(0, bunifuGradientPanel.Height);
            dataGridView.Width = bunifuCards.Width;
            dataGridView.Height = 217;
            bunifuCards.Controls.Add((Control)dataGridView);
            dataGridView.Columns.Add("Descripción", "Descripción");
            dataGridView.Columns.Add("Cantidad", "Cantidad");
            dataGridView.Columns.Add("Precio Unitario", "Precio Unitario");
            dataGridView.Columns.Add("Total", "Total");
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 130, 170);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 12f);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dataGridView.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataTable poDetails = OrdenCompra.GetPODetails(Convert.ToInt32(row1["ID_PO"]));
            for (int index = 0; index < poDetails.Rows.Count; ++index)
            {
                dataGridView.Rows.Add();
                DataRow row2 = poDetails.Rows[index];
                dataGridView[0, index].Value = row2["Descripción"];
                dataGridView[1, index].Value = row2["Cantidad"];
                dataGridView[2, index].Value = row2["Precio por Caja"];
                dataGridView[3, index].Value = row2["Total"];
            }
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 130, 170);
            label2.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
            DateTime dateTime = Convert.ToDateTime(row1["Fecha de Llegada"]);
            if (dateTime.Date > DateTime.Now.Date && !Convert.ToBoolean(row1["Mercancia Recibida"]))
            {
                string monthName = new CultureInfo("es-MX").DateTimeFormat.GetMonthName(dateTime.Month);
                string str = monthName[0].ToString().ToUpper() + monthName.Substring(1);
                label2.Text = "Fecha de Llegada: " + dateTime.Day.ToString() + " de " + str;
            }
            else if (dateTime.Date == DateTime.Now.Date && !Convert.ToBoolean(row1["Mercancia Recibida"]))
            {
                string monthName = new CultureInfo("es-MX").DateTimeFormat.GetMonthName(dateTime.Month);
                string str = monthName[0].ToString().ToUpper() + monthName.Substring(1);
                label2.Text = "Fecha de Llegada: \nHoy";
                label2.TextAlign = ContentAlignment.MiddleCenter;
            }
            else if (dateTime.Date == DateTime.Now.Date && Convert.ToBoolean(row1["Mercancia Recibida"]))
            {
                label2.Text = "Recibido";
                label2.TextAlign = ContentAlignment.MiddleCenter;
            }
            else if (dateTime < DateTime.Now.Date && !Convert.ToBoolean(row1["Mercancia Recibida"]))
            {
                label2.Text = "No se recibió el pedido";
                label2.ForeColor = Color.Orange;
            }
            else if (!Convert.ToBoolean(row1["Estado de Pago"]))
            {
                label2.Text = "Pago Pendiente";
                label2.ForeColor = Color.Red;
            }
            else if (Convert.ToBoolean(row1["Mercancia Recibida"]))
            {
                label2.Text = "Completado";
                label2.ForeColor = Color.Green;
            }
            bunifuCards.Controls.Add((Control)label2);
            label2.Location = new Point((bunifuCards.Width - label2.Width) / 2, dataGridView.Location.Y + dataGridView.Height + 20);
            BunifuThinButton2 bunifuThinButton2 = new BunifuThinButton2();
            bunifuThinButton2.Size = new Size(180, 40);
            bunifuThinButton2.ForeColor = Color.FromArgb(0, 130, 170);
            bunifuThinButton2.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
            bunifuThinButton2.ActiveFillColor = Color.FromArgb(0, 110, 150);
            bunifuThinButton2.ActiveForecolor = Color.White;
            bunifuThinButton2.ActiveLineColor = Color.FromArgb(0, 110, 150);
            bunifuThinButton2.IdleFillColor = Color.White;
            bunifuThinButton2.IdleForecolor = Color.FromArgb(0, 110, 150);
            bunifuThinButton2.IdleLineColor = Color.FromArgb(0, 110, 150);
            bunifuCards.Controls.Add((Control)bunifuThinButton2);
            int num1 = label2.Location.Y + label2.Height;
            int num2 = bunifuCards.Height - num1;
            bunifuThinButton2.Location = new Point((bunifuCards.Width - bunifuThinButton2.Width) / 2, (num2 - bunifuThinButton2.Height) / 2 + num1);
            bunifuThinButton2.ButtonText = "Abrir";
            bunifuThinButton2.Click += new EventHandler(this.OpenPO);
            bunifuThinButton2.Name = row1["ID_PO"].ToString();
            bunifuCards.Name = dateTime.Date.ToShortDateString() + "," + row1["Nombre de la Empresa"];
            
            return bunifuCards;
        }

        private BunifuCards[] createCard(DataTable POs)
        {
            List<BunifuCards> bunifuCardsList = new List<BunifuCards>();
            foreach (DataRow row1 in POs.Rows)
            {
                BunifuCards bunifuCards = new BunifuCards();
                bunifuCards.Size = new Size(420, 380);
                bunifuCards.BackColor = Color.White;
                bunifuCards.BorderRadius = 35;
                bunifuCards.Margin = new Padding(20, 0, 20, 20);
                this.toolTip1.SetToolTip((Control)bunifuCards, "Orden #" + row1["ID_PO"].ToString());
                if (!Convert.ToBoolean(row1["Estado de Pago"]) && !Convert.ToBoolean(row1["Mercancia Recibida"]) && DateTime.Today.Date <= Convert.ToDateTime(row1["Fecha de Llegada"]).Date)
                    bunifuCards.color = Color.FromArgb(0, 130, 170);
                else if (!Convert.ToBoolean(row1["Estado de Pago"]) && !Convert.ToBoolean(row1["Mercancia Recibida"]))
                    bunifuCards.color = Color.Orange;
                else if (!Convert.ToBoolean(row1["Estado de Pago"]) && Convert.ToBoolean(row1["Mercancia Recibida"]))
                    bunifuCards.color = Color.Red;
                else if (Convert.ToBoolean(row1["Estado de Pago"]) && Convert.ToBoolean(row1["Mercancia Recibida"]))
                    bunifuCards.color = Color.LimeGreen;
                Label label1 = new Label();
                label1.Font = new Font("Century Gothic", 22f, FontStyle.Bold);
                label1.Text = row1["Nombre de la Empresa"].ToString();
                label1.BackColor = Color.Transparent;
                label1.AutoSize = true;
                this.toolTip1.SetToolTip((Control)label1, "Orden #" + row1["ID_PO"].ToString());
                BunifuGradientPanel bunifuGradientPanel = new BunifuGradientPanel();
                bunifuGradientPanel.Dock = DockStyle.Top;
                bunifuGradientPanel.Controls.Add((Control)label1);
                bunifuGradientPanel.Height = 50;
                bunifuGradientPanel.Width = bunifuCards.Width;
                this.toolTip1.SetToolTip((Control)bunifuGradientPanel, "Orden #" + row1["ID_PO"].ToString());
                bunifuGradientPanel.GradientBottomLeft = Color.White;
                bunifuGradientPanel.GradientBottomRight = Color.White;
                bunifuGradientPanel.GradientTopLeft = Color.White;
                bunifuGradientPanel.GradientTopRight = Color.White;
                label1.Location = new Point((label1.Parent.Width - label1.Width) / 2, (label1.Parent.Height - label1.Height) / 2);
                bunifuCards.Controls.Add((Control)bunifuGradientPanel);
                DataGridView dataGridView = new DataGridView();
                dataGridView.BackgroundColor = Color.White;
                dataGridView.BorderStyle = BorderStyle.None;
                dataGridView.ScrollBars = ScrollBars.Both;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ReadOnly = true;
                dataGridView.Location = new Point(0, bunifuGradientPanel.Height);
                dataGridView.Width = bunifuCards.Width;
                dataGridView.Height = 217;
                bunifuCards.Controls.Add((Control)dataGridView);
                dataGridView.Columns.Add("Descripción", "Descripción");
                dataGridView.Columns.Add("Cantidad", "Cantidad");
                dataGridView.Columns.Add("Precio Unitario", "Precio Unitario");
                dataGridView.Columns.Add("Total", "Total");
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 130, 170);
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
                dataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 12f);
                dataGridView.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (DataGridViewColumn column in dataGridView.Columns)
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataTable poDetails = OrdenCompra.GetPODetails(Convert.ToInt32(row1["ID_PO"]));
                for (int index = 0; index < poDetails.Rows.Count; ++index)
                {
                    dataGridView.Rows.Add();
                    DataRow row2 = poDetails.Rows[index];
                    dataGridView[0, index].Value = row2["Descripción"];
                    dataGridView[1, index].Value = row2["Cantidad"];
                    dataGridView[2, index].Value = row2["Precio por Caja"];
                    dataGridView[3, index].Value = row2["Total"];
                }
                dataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.ForeColor = Color.FromArgb(0, 130, 170);
                label2.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
                DateTime dateTime = Convert.ToDateTime(row1["Fecha de Llegada"]);
                if (dateTime.Date > DateTime.Now.Date && !Convert.ToBoolean(row1["Mercancia Recibida"]))
                {
                    string monthName = new CultureInfo("es-MX").DateTimeFormat.GetMonthName(dateTime.Month);
                    string str = monthName[0].ToString().ToUpper() + monthName.Substring(1);
                    label2.Text = "Fecha de Llegada: " + dateTime.Day.ToString() + " de " + str;
                }
                else if (dateTime.Date == DateTime.Now.Date && !Convert.ToBoolean(row1["Mercancia Recibida"]))
                {
                    string monthName = new CultureInfo("es-MX").DateTimeFormat.GetMonthName(dateTime.Month);
                    string str = monthName[0].ToString().ToUpper() + monthName.Substring(1);
                    label2.Text = "Fecha de Llegada: \nHoy";
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                }
                else if (dateTime.Date == DateTime.Now.Date && Convert.ToBoolean(row1["Mercancia Recibida"]))
                {
                    label2.Text = "Recibido";
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                }
                else if (dateTime < DateTime.Now.Date && !Convert.ToBoolean(row1["Mercancia Recibida"]))
                {
                    label2.Text = "No se recibió el pedido";
                    label2.ForeColor = Color.Orange;
                }
                else if (!Convert.ToBoolean(row1["Estado de Pago"]))
                {
                    label2.Text = "Pago Pendiente";
                    label2.ForeColor = Color.Red;
                }
                else if (Convert.ToBoolean(row1["Mercancia Recibida"]))
                {
                    label2.Text = "Completado";
                    label2.ForeColor = Color.Green;
                }
                bunifuCards.Controls.Add((Control)label2);
                label2.Location = new Point((bunifuCards.Width - label2.Width) / 2, dataGridView.Location.Y + dataGridView.Height + 20);
                BunifuThinButton2 bunifuThinButton2 = new BunifuThinButton2();
                bunifuThinButton2.Size = new Size(180, 40);
                bunifuThinButton2.ForeColor = Color.FromArgb(0, 130, 170);
                bunifuThinButton2.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
                bunifuThinButton2.ActiveFillColor = Color.FromArgb(0, 110, 150);
                bunifuThinButton2.ActiveForecolor = Color.White;
                bunifuThinButton2.ActiveLineColor = Color.FromArgb(0, 110, 150);
                bunifuThinButton2.IdleFillColor = Color.White;
                bunifuThinButton2.IdleForecolor = Color.FromArgb(0, 110, 150);
                bunifuThinButton2.IdleLineColor = Color.FromArgb(0, 110, 150);
                bunifuCards.Controls.Add((Control)bunifuThinButton2);
                int num1 = label2.Location.Y + label2.Height;
                int num2 = bunifuCards.Height - num1;
                bunifuThinButton2.Location = new Point((bunifuCards.Width - bunifuThinButton2.Width) / 2, (num2 - bunifuThinButton2.Height) / 2 + num1);
                bunifuThinButton2.ButtonText = "Abrir";
                bunifuThinButton2.Click += new EventHandler(this.OpenPO);
                bunifuThinButton2.Name = row1["ID_PO"].ToString();
                bunifuCards.Name = dateTime.Date.ToShortDateString() + "," + row1["Nombre de la Empresa"];
                bunifuCardsList.Add(bunifuCards);
            }
            return bunifuCardsList.ToArray();
        }

        private void BrowserTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(this.BrowserTxt.Text == ""))
                return;
            this.PopulateLayout(OrdenCompra.getAllPO(DateTime.Now.Date));
            inASearch = false;
        }

        private void BrowserTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.BrowserTxt.Text != "" && e.KeyCode == Keys.Return)
            {
                searchPO();
            }
            if (e.KeyCode != Keys.Escape)
                return;
            this.BrowserTxt.Text = "";
        }

        private void OpenPO(object sender, EventArgs e)
        {
            this.PO = new OrdenCompra(Convert.ToInt32((sender as BunifuThinButton2).Name));
            this.POIDlbl.Text = this.PO.ID.ToString();
            this.SupplierLbl.Text = this.PO.SupplierName;
            this.employeeName.Text = this.PO.EmployeeName;
            this.arrivalDateLbl.Text = this.PO.arrivalDate.Date.ToShortDateString();
            this.purchaseDateLbl.Text = this.PO.purchaseDate.ToShortDateString();
            this.paymentDateLbl.Text = this.PO.paymentDate.ToShortDateString();
            this.TotalLbl.Text = this.PO.total.ToString("n2");

            var data=this.PO._products.Copy();
            data.Columns["cantidad"].ReadOnly = false;

            this.dataGridView1.DataSource = data;
            
            this.updateValues();
            this.supplier = new Proveedor(this.PO.SupplierID);
            this.POemployeeID = this.PO.EmployeeID;
            this.POsContainerPanel.Dock = DockStyle.None;
            this.POsContainerPanel.Visible = false;
            this.PODescriptionPanel.Visible = true;
            this.PODescriptionPanel.Dock = DockStyle.Fill;

            dataGridView1.Focus();
            this.dataGridView1.CurrentCell = dataGridView1.RowCount > 0 ? dataGridView1.Rows[0].Cells["cantidad"] : null;

            if (dataGridView1.CurrentCell != null)
                dataGridView1.BeginEdit(true);
            currentControl = (sender as Control).Parent;
        }

        private void updateValues()
        {
            this.purchaseStatusLbl.Text = this.PO.paid ? "Pagado" : "Pago Pendiente";
            this.paymantLbl.Text = this.PO.pay.ToString("n2");
            this.debtLbl.Text = (this.PO.total - this.PO.pay).ToString("n2");
            this.DeliveryStatus.Text = this.PO.delivered ? "Pedido Recibido" : "Entrega Pendiente";
            if (!this.PO.paid)
            {
                this.purchaseStatusLbl.ForeColor = Color.Tomato;
                this.debtLbl.ForeColor = Color.Tomato;
                if (this.PO.paymentDate.Date <= DateTime.Now.Date && !this.PO.paid)
                    this.paymentDateLbl.ForeColor = Color.Tomato;
                this.PayBtn.Enabled = true;
            }
            else
            {
                this.purchaseStatusLbl.ForeColor = Color.LimeGreen;
                this.debtLbl.ForeColor = Color.LimeGreen;
                this.PayBtn.Enabled = false;
            }
            if (this.PO.delivered)
            {
                this.DeliveryStatus.ForeColor = Color.LimeGreen;
                this.dataGridView1.ReadOnly = true;
            }
            else
            {
                this.DeliveryStatus.ForeColor = Color.Tomato;
                this.dataGridView1.ReadOnly = false;
            }
            if (this.PO.delivered && this.PO.paid)
                this.bunifuSeparator1.LineColor = Color.LimeGreen;
            if (this.PO.delivered && !this.PO.paid && DateTime.Now.Date >= this.PO.arrivalDate.Date)
                this.bunifuSeparator1.LineColor = Color.Tomato;
            if (this.PO.delivered && !this.PO.paid && DateTime.Now.Date < this.PO.arrivalDate.Date)
                this.bunifuSeparator1.LineColor = Color.Orange;
            if (!this.PO.delivered && this.PO.paid)
                this.bunifuSeparator1.LineColor = Color.Orange;
            if (!this.PO.delivered && !this.PO.paid && DateTime.Now.Date > this.PO.arrivalDate.Date)
                this.bunifuSeparator1.LineColor = Color.Orange;
            if (!this.PO.delivered && !this.PO.paid && DateTime.Now.Date <= this.PO.arrivalDate.Date)
                this.bunifuSeparator1.LineColor = Color.FromArgb(0, 150, 190);
            if (this.PO.delivered)
            {
                this.ConfirmBtn.Enabled = false;
                this.label12.Show();
                this.EmployeeWhoConfirmedLbl.Text = new Empleado(this.PO._EmployeeWhoConfirmedThePurchaseID).name;
                this.EmployeeWhoConfirmedLbl.Show();
            }
            else
            {
                this.ConfirmBtn.Enabled = true;
                this.EmployeeWhoConfirmedLbl.Hide();
                this.label12.Hide();
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.cm = (CurrencyManager)this.BindingContext[this.dataGridView1.DataSource];

            int num = 0;
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                num = column.Width;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            //if (num < this.dataGridView1.Width)
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (!this.PO.delivered)
                return;


            foreach (DataGridViewBand row in this.dataGridView1.Rows)
                this.paintRow(row.Index);

            this.dataGridView1.CurrentCell = null;

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cantidad"].Index)
            {
                var cellRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                toolTip1.Show("Ingrese la cantidad de cajas que se recibieron de este producto.", this, dataGridView1.Location.X + cellRect.X +cellRect.Width/2- 10,
                              dataGridView1.Location.Y + cellRect.Y - 5,
                              5000);
                dataGridView1.ShowCellToolTips = true;
                return;

            }
            e.Cancel = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.cm.SuspendBinding();
            this.dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = (object)(Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value) * Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["Precio por Caja"].Value));
            this.paintRow(e.RowIndex);
            this.cm.ResumeBinding();

            try { dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex + 1]; }
            catch { dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, 0]; }

            toolTip1.Hide(this);
        }

        private void calculateTotalAndDebt()
        {
            double num = 0.0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
                num += (double)Convert.ToInt32(row.Cells["Total"].Value);
            this.TotalLbl.Text = num.ToString("n2");
            this.debtLbl.Text = (num - Convert.ToDouble(this.paymantLbl.Text)).ToString("n2");
            this.PO.total = num;
        }

        private void paintRow(int RowIndex)
        {
            this.getCorrespondingIndex(RowIndex);
            try
            {
                if (Convert.ToDouble(this.PO._products.Rows[RowIndex]["Cantidad"]) > Convert.ToDouble(this.dataGridView1[3, RowIndex].Value))
                    this.dataGridView1.Rows[RowIndex].DefaultCellStyle.ForeColor = Color.Tomato;
                else
                    this.dataGridView1.Rows[RowIndex].DefaultCellStyle.ForeColor = Color.LimeGreen;
            }
            catch (Exception) { }
        }

        private int getCorrespondingIndex(int RowIndex)
        {
            for (int index = 0; index < this.PO._products.Rows.Count; ++index)
            {
                if (this.PO._products.Rows[index]["Código de Barras"].ToString() == this.dataGridView1.Rows[RowIndex].Cells["Código de Barras"].Value.ToString())
                    return index;
            }
            return -1;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.dataGridView1.Focused && keyData == Keys.Return && this.dataGridView1.SelectedCells.Count > 0 && !PO.delivered)
            {
                this.cm.SuspendBinding();
                foreach (DataGridViewCell selectedCell in (BaseCollection)this.dataGridView1.SelectedCells)
                {
                    int correspondingIndex = this.getCorrespondingIndex(selectedCell.RowIndex);
                    this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Cantidad"].Value = this.PO._products.Rows[correspondingIndex]["Cantidad"];
                    this.paintRow(selectedCell.RowIndex);
                    this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Total"].Value = (object)(Convert.ToInt32(this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Cantidad"].Value) * Convert.ToInt32(this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Precio por Caja"].Value));
                    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex];
                }
            }
            if (this.dataGridView1.Focused && keyData == Keys.Escape && this.dataGridView1.SelectedCells.Count > 0 && !PO.delivered)
            {
                this.cm.SuspendBinding();
                foreach (DataGridViewCell selectedCell in (BaseCollection)this.dataGridView1.SelectedCells)
                {
                    this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Cantidad"].Value = (object)0.0;
                    this.paintRow(selectedCell.RowIndex);
                    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[selectedCell.RowIndex].Cells[selectedCell.ColumnIndex];
                    this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Total"].Value = (object)(Convert.ToInt32(this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Cantidad"].Value) * Convert.ToInt32(this.dataGridView1.Rows[selectedCell.RowIndex].Cells["Precio por Caja"].Value));
                }
                // this.cm.ResumeBinding();
            }

            if (keyData == (Keys.Alt | Keys.Left) && PODescriptionPanel.Visible)
            {
                goBack();
            }

            if (keyData == (Keys.Alt | Keys.C) && PODescriptionPanel.Visible && ConfirmBtn.Enabled)
            {
                ConfirmBtn_Click(this, null);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView1_EditingControlShowing(
          object sender,
          DataGridViewEditingControlShowingEventArgs e)
        {
            (e.Control as TextBox).KeyPress += (KeyPressEventHandler)((s, ee) =>
            {
                if (!char.IsControl(ee.KeyChar) && !char.IsDigit(ee.KeyChar) && ee.KeyChar != '.')
                    ee.Handled = true;
                if (ee.KeyChar != '.' || (s as TextBox).Text.IndexOf('.') <= -1)
                    return;
                ee.Handled = true;
            });
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.ScrollControlIntoView(currentControl);
            }
            catch (Exception) { }

            this.goBack();
            }

        private void goBack()
        {
            this.PODescriptionPanel.Visible = false;
            this.PODescriptionPanel.Dock = DockStyle.None;
            this.POsContainerPanel.Dock = DockStyle.Fill;
            this.POsContainerPanel.Visible = true;
            this.paymentDateLbl.ForeColor = Color.FromArgb(0, 130, 170);
            currentControl = null;
        }

        private void pdfFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Users\TIENDA\source\repos\POS\POS\Template\" + "PO#" + (object)this.PO.ID + ".pdf");
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró el archivo");
            }
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (this.PO.delivered)
            {
                FormPagar formPagar = new FormPagar(this.PO.total - this.PO.pay, true);
                DarkForm darkForm = new DarkForm();
                darkForm.Show();
                if (formPagar.ShowDialog() == DialogResult.OK)
                {
                    this.PO.MakePayment(Convert.ToDouble(formPagar.Pay), this.CurrentEmployeeID);
                    this.updateValues();

                    if (m_Drawer != null)
                    {
                        try
                        {

                            //Open the device
                            //Use a Logical Device Name which has been set on the SetupPOS.
                            m_Drawer.Open();

                            //Get the exclusive control right for the opened device.
                            //Then the device is disable from other application.
                            m_Drawer.Claim(1000);

                            //Enable the device.
                            m_Drawer.DeviceEnabled = true;

                            //Open the drawer by using the "OpenDrawer" method.
                            m_Drawer.OpenDrawer();


                            m_Drawer.DeviceEnabled = false;
                            m_Drawer.Release();

                            m_Drawer.Close();
                        }
                        catch (PosControlException)
                        { useNativePrinter(); }
                    }
                    else
                        useNativePrinter();
                    

                    //<<<step1>>>--End
                    MessageBox.Show("Se realizó abono con exito");
                    if (this.PO.paid)
                    {
                        if (inASearch)
                            searchPO();
                        else
                            this.loadPurchases();
                    }
                }
                darkForm.Close();
            }
            else
                MessageBox.Show("Primero debe confirmar el pedido para realizar un abono", "No se puede realizar un abono", MessageBoxButtons.OK);
        }

        private void useNativePrinter()
        {
            try
            {

                var printDialog = new PrintDialog();
                var printDocument = new PrintDocument() { PrintController = new StandardPrintController() };
                printDialog.PrinterSettings.PrinterName = new PrinterTicket().printerName;
                printDialog.Document = printDocument;

                printDocument.Print();
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cancelar la orden de compra?.\n Los productos comprados serán descontados de su respectiva bodega por defecto.", "Cancelar Compra", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.PO.delete();

                if (inASearch)
                    searchPO();
                else
                    this.loadPurchases();
                
                this.goBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:\n" + ex.Message, "Error");
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            this.dataGridView1.CurrentCell = (DataGridViewCell)null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.cm.SuspendBinding();
            if (this.textBox1.Text != "")
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (row.Cells["Código de Barras"].Value.ToString().ToLower().Contains(this.textBox1.Text.ToLower()) || row.Cells["Descripción"].Value.ToString().ToLower().Contains(this.textBox1.Text.ToLower()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
            else
            {
                foreach (DataGridViewBand row in this.dataGridView1.Rows)
                    row.Visible = true;
            }
            this.cm.ResumeBinding();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.DefaultCellStyle.ForeColor.ToKnownColor() == Color.FromArgb(0, 0, 0, 0).ToKnownColor())
                {
                    MessageBox.Show("Aún quedan artículos sin revisar");
                    dataGridView1.CurrentCell = row.Cells["Cantidad"];
                    dataGridView1.BeginEdit(true);
                    return;
                }
            }
            Form_Login formLogin = new Form_Login(string.Format("Verificación De\nUsuario"));
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (row.DefaultCellStyle.ForeColor == Color.LimeGreen || row.DefaultCellStyle.ForeColor == Color.Tomato)
                    {
                        int correspondingIndex = this.getCorrespondingIndex(row.Index);
                        if (correspondingIndex > -1 && row.Cells["Cantidad"].Value != this.PO._products.Rows[correspondingIndex]["Cantidad"])
                        {
                            Producto producto = new Producto(row.Cells["Código de Barras"].Value.ToString());

                            double num = (Convert.ToDouble(row.Cells["Cantidad"].Value) - Convert.ToDouble(this.PO._products.Rows[correspondingIndex]["Cantidad"])) * Convert.ToDouble(row.Cells["Piezas por Caja"].Value);

                            if (num != 0.0)
                            {
                                Bodega depot = new Bodega(producto.defaultDepotID);
                                depot.UpdateProductQuantity(depot.getProductQuantity(producto.Barcode) + num, producto.Barcode);
                                this.PO.UpdateProductQunantity(producto.Barcode, Convert.ToDouble(row.Cells["Cantidad"].Value));
                            }
                        }
                    }
                }

                this.PO.delivered = true;
                this.PO._EmployeeWhoConfirmedThePurchaseID = formLogin.ID;
                this.PO.updateDeliveryStatus();
                this.updateValues();
                this.PO = new OrdenCompra(this.PO.ID);

                if (inASearch)
                    searchPO();
                else
                    this.loadPurchases();
            }
            darkForm.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;
            this.textBox1.Text = "";
        }

        private void EmployeeWhoConfirmedLbl_TextChanged(object sender, EventArgs e)
        {
            this.EmployeeWhoConfirmedLbl.Location = new Point((this.EmployeeWhoConfirmedLbl.Parent.Width - this.EmployeeWhoConfirmedLbl.Width) / 2, this.EmployeeWhoConfirmedLbl.Location.Y);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchPO();
        }

        private void searchPO()
        {
            if (!(this.BrowserTxt.Text != ""))
                return;
            this.PopulateLayout(OrdenCompra.SearchByCoincidence(this.BrowserTxt.Text));
            inASearch = true;
        }

        private void TotalLbl_TextChanged(object sender, EventArgs e)
        {
            if (!(this.TotalLbl.Text == ""))
                return;
            this.TotalLbl.Text = string.Format("{0}", (object)this.PO.total.ToString("n2"));
            this.TotalLbl.SelectAll();
        }

        private void TotalLbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (this.TotalLbl.Text.IndexOf(".") <= -1 || e.KeyChar != '.')
                return;
            e.Handled = true;
        }

        private void TotalLbl_Leave(object sender, EventArgs e)
        {
            this.updateTotal();
        }

        private void updateTotal()
        {
            double newTotal = Convert.ToDouble(this.TotalLbl.Text);
            if (newTotal == this.PO.total || MessageBox.Show("¿Desea modificar el total de la compra?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.PO.updateTotal(newTotal);
            this.updateValues();
            int num = (int)MessageBox.Show("Se actualizó correctamente");
        }

        private void TotalLbl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.updateTotal();
            }
            else
            {
                if (e.KeyCode != Keys.Escape || Convert.ToDouble(this.TotalLbl.Text) == this.PO.total)
                    return;
                this.TotalLbl.Text = this.PO.total.ToString("n2");
            }
        }

        private void PanelCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            //<<<step1>>>--Start
            if (m_Drawer != null)
            {
                try
                {
                    //Cancel the device
                    m_Drawer.DeviceEnabled = false;

                    //Release the device exclusive control right.
                    m_Drawer.Release();
                    //Finish using the device.
                    m_Drawer.Close();
                }
                catch (PosControlException)
                {
                }
            }
            this.Dispose();
            //<<<step1>>>--End
        }


        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                try
                {

                    if (e.ColumnIndex == dataGridView1.Columns["cantidad"].Index && !PO.delivered)
                        dataGridView1.Cursor = Cursors.IBeam;
                    else
                        dataGridView1.Cursor = Cursors.Arrow;
                }
                catch (Exception) { }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cantidad"].Index)
            {
                dataGridView1.BeginEdit(true);
            }
        }

        private void PanelCompras_Resize(object sender, EventArgs e)
        {
            var res = Screen.PrimaryScreen.Bounds;
            foreach (Control control in headerPanel.Controls)
            {
                control.Width = (headerPanel.Width / 3);
            }

            if(res!= new Rectangle(0,0,1920,1080))
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
                dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 12);
            }
            else
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 24);
                dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 16);
            }
        }

        private void headerPanel_Resize(object sender, EventArgs e)
        {
            leftPanel.Width = middlePanel.Width = rightPanel.Width = headerPanel.Width / 3;
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.Dispose();
        }
    }
}
