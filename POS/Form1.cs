using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        Control con;
       

        private Empleado employee;
        private ContextMenu menu;
        private bool displayingReminder;
        private ActiveWindow currentWindow;

        private enum ActiveWindow
        {
            Home, Sales, Inventory, Statistics, Customers, Suppliers, Purchases, Employees, Settings
        }

        public Form1(int EmployeeID)
        {
             InitializeComponent();
            Turno.SetFirsUsage(DateTime.Now);
            Recordatorio.resetReminders();
             WindowState = FormWindowState.Maximized;
             timer();
             HourLbl.Visible = true;
             MinutesLbl.Visible = true;
             Daylbl.Visible = true;
             DateLbl.Visible = true;
             employee = new Empleado(EmployeeID);
             displayHideTabs();
            Button control =  VentasButton;
             menu = new ContextMenu();
             menu.MenuItems.Add(new MenuItem("Abrir en nueva ventana"));
            control.ContextMenu =  menu;
            control.ContextMenu.MenuItems[0].Click += (EventHandler)((s, e) =>
            {
                if (control.Name == homeBtn.Name)
                    new Panel_Inicio(time, employee.ID, ContainerPanel.Size, FormWindowState.Maximized).Show();
                else if (control.Name == VentasButton.Name)
                {
                    Panel_Ventas panel = new Panel_Ventas(employee.ID, FormWindowState.Maximized);
                    Thread thread = new Thread(() => panel.ShowDialog());
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.IsBackground = true;
                    thread.Start();
                }
                else if (control.Name == ProductsButton.Name)
                    new Panel_Productos(FormWindowState.Maximized).Show();
                else if (control.Name == ClientesBtn.Name)
                    new Panel_Clientes(FormWindowState.Maximized).Show();
                else if (control.Name == SuppliersBtn.Name)
                    new Panel_proveedores_Form(time, employee.ID, FormWindowState.Maximized).Show();
                else if (control.Name == PurchasesBtn.Name)
                {
                    new PanelCompras(employee.ID, FormWindowState.Maximized).Show();
                }
                else
                {
                    if (!(control.Name == employeeBtn.Name))
                        return;
                    new Panel_Empleados(employee.ID, FormWindowState.Maximized).Show();
                }
            });

        }

        private void displayHideTabs()
        {
             ProductsButton.Visible =  employee.isAdmin;
             ClientesBtn.Visible =  employee.isAdmin;
             employeeBtn.Visible =  employee.isAdmin;
             settingsBtn.Visible =  employee.isAdmin;
            statisticsBtn.Visible = employee.isAdmin;
             userNameLbl.Text = string.Format("   {0}",  employee.name.IndexOf(' ') > 0 ? (object) employee.name.Substring(0,  employee.name.IndexOf(' ')) : (object) employee.name);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Minimized;
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
            if (!( VentasButton.BackColor ==  homeBtn.Parent.BackColor))
                return;
            if (con != null)
            {
                closeWindow();
            }

            if (con == null)
            {
                Panel_Ventas panelVentas = new Panel_Ventas(employee.ID, FormWindowState.Normal);
                con = (Control)panelVentas;
                panelVentas.TopLevel = false;
                ContainerPanel.Controls.Add((Control)panelVentas);
                panelVentas.Dock = DockStyle.Fill;
                panelVentas.Show();
                disableButton((Control)VentasButton);
                currentWindow = ActiveWindow.Sales;
            }
        }

        private void closeWindow()
        { 
            switch(currentWindow)
            {
                case ActiveWindow.Customers:
                    (con as Panel_Clientes).Close();
                    con = null;
                    break;
                
                case ActiveWindow.Employees:
                    (con as Panel_Empleados).Close();
                    con = null;
                    break;

                case ActiveWindow.Home:
                    (con as Panel_Inicio).Close();
                    con = null;
                    break;

                case ActiveWindow.Inventory:
                    (con as Panel_Productos).Close();
                    con = null;
                    break;

                case ActiveWindow.Purchases:
                    (con as PanelCompras).Close();
                    con = null;
                    break;

                case ActiveWindow.Sales:
                    if (con != null && VentasButton.BackColor != homeBtn.Parent.BackColor)
                    {
                        if (!(con as Panel_Ventas).canClose)
                            if (MessageBox.Show("¿Desea cambiar de pestaña?. \nPerderá la información", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                return;
                            }
                        (con as Panel_Ventas).Close();
                        con = null;
                    }
                    else
                    {

                        (con as Panel_Ventas).Close();
                        con = null;
                    }
                    break;

                case ActiveWindow.Settings:
                    (con as Panel_Configuracion).Close();
                    con = null;
                    break;

                case ActiveWindow.Statistics:
                    (con as panel_Estadisticas).Close();
                    con = null;
                    break;

                case ActiveWindow.Suppliers:
                    (con as Panel_proveedores_Form).Close();
                    con = null;
                    break;

            }
        }

        private void disableButton(Control button)
        {
            VentasButton.BackColor = TabPanel.BackColor;
            VentasButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            ProductsButton.BackColor = TabPanel.BackColor;
            ProductsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            ClientesBtn.BackColor = TabPanel.BackColor;
            ClientesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            SuppliersBtn.BackColor = TabPanel.BackColor;
            SuppliersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            PurchasesBtn.BackColor = TabPanel.BackColor;
            PurchasesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            settingsBtn.BackColor = TabPanel.BackColor;


            employeeBtn.BackColor = TabPanel.BackColor;
            employeeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            homeBtn.BackColor = TabPanel.BackColor;
            homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            statisticsBtn.BackColor = TabPanel.BackColor;
            statisticsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);


            button.BackColor = Color.FromArgb(1, 93, 141);
            if (button.Name != settingsBtn.Name)
                (button as Button).FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 93, 141);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            if (!( ProductsButton.BackColor ==  homeBtn.Parent.BackColor))
                return;
            if ( con != null)
            {
                closeWindow();
            }

            if (con == null)
            {
                Panel_Productos panelProductos = new Panel_Productos(FormWindowState.Normal);
                panelProductos.TopLevel = false;
                con = (Control)panelProductos;
                panelProductos.TopLevel = false;
                panelProductos.AutoScroll = true;
                panelProductos.Dock = DockStyle.Fill;
                panelProductos.Show();
                ContainerPanel.Controls.Add(con);
                disableButton((Control)ProductsButton);
                currentWindow = ActiveWindow.Inventory;
            }
        }


        private void timer()
        {
             time = new System.Windows.Forms.Timer();
             time.Interval = 1000;
             time.Tick += new EventHandler( t_Tick);
             time.Enabled = true;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            HourLbl.Text = now.Hour.ToString().PadLeft(2, '0');
            MinutesLbl.Text = now.Minute.ToString().PadLeft(2, '0');
            CultureInfo cultureInfo = new CultureInfo("es-MX");
            string str1 = cultureInfo.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek).ToString();
            Daylbl.Text = (char.ToUpper(str1[0]).ToString() + str1.Substring(1) + ",").Substring(0, 3);
            string str2 = cultureInfo.DateTimeFormat.GetMonthName(now.Month).Substring(0, 3);
            DateLbl.Text = str2.Substring(0, 1).ToUpper() + str2.Substring(1) + " " + now.Day.ToString();

            if (DateTime.Now.TimeOfDay == new TimeSpan(0, 0, 0))
                Recordatorio.resetReminders();

           //  setUpReminders();
        }

        private async void setUpReminders()
        {
            await Task.Run((Action)(() =>
            {
                if (displayingReminder)
                    return;

                 displayingReminder = true;
                DataTable unseenReminders = Recordatorio.getUnseenReminders();
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Windows_Notify_Calendar);

                foreach (DataRow row in unseenReminders.Rows)
                {
                    soundPlayer.Play();
                    Recordatorio recordatorio = new Recordatorio(Convert.ToInt32(row["ID_Recordatorio"]));
                    if (recordatorio.ID != null && new Display_Reminder(new Proveedor(recordatorio.ID_Supplier).NombreEmpresa, recordatorio.Message, recordatorio.StartTime, recordatorio.EndTime).ShowDialog() == DialogResult.OK)
                    {
                        recordatorio.MarkAsSeen();
                        Thread.Sleep(1000);
                    }
                }
                 displayingReminder = false;
            }));
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            if (!( ClientesBtn.BackColor ==  homeBtn.Parent.BackColor))
                return;
            
            if (con != null)
            {
                closeWindow();
            }

            if (con == null)
            {
                Panel_Clientes panelClientes = new Panel_Clientes(FormWindowState.Normal);
                panelClientes.EmployeeID = employee.ID;
                panelClientes.TopLevel = false;
                con = (Control)panelClientes;
                panelClientes.TopLevel = false;
                panelClientes.AutoScroll = true;
                SuppliersBtn.Enabled = true;
                panelClientes.Dock = DockStyle.Fill;
                panelClientes.Show();
                ContainerPanel.Controls.Add(con);
                disableButton((Control)ClientesBtn);
                currentWindow = ActiveWindow.Customers;
            }
        }
        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            if (!( SuppliersBtn.BackColor ==  homeBtn.Parent.BackColor))
                return;

            if ( con != null)
            {
                closeWindow();
            }

            if (con == null)
            {
                Panel_proveedores_Form panelProveedoresForm = new Panel_proveedores_Form(time, employee.ID, FormWindowState.Normal);
                panelProveedoresForm.TopLevel = false;
                con = (Control)panelProveedoresForm;
                panelProveedoresForm.TopLevel = false;
                panelProveedoresForm.AutoScroll = true;
                panelProveedoresForm.Dock = DockStyle.Fill;
                panelProveedoresForm.Show();
                ContainerPanel.Controls.Add(con);
                disableButton((Control)SuppliersBtn);
                currentWindow = ActiveWindow.Suppliers;
            }
        }

        private void PurchasesBtn_Click(object sender, EventArgs e)
        {
            if (!( PurchasesBtn.BackColor ==  homeBtn.Parent.BackColor))
                return;
            if ( con != null)
            {
                closeWindow();
            }

            if (con == null)
            {
                PanelCompras panelCompras = new PanelCompras(employee.ID, FormWindowState.Normal);
                panelCompras.TopLevel = false;
                con = panelCompras;
                panelCompras.TopLevel = false;
                panelCompras.AutoScroll = true;
                panelCompras.Dock = DockStyle.Fill;
                panelCompras.Show();
                ContainerPanel.Controls.Add(con);
                disableButton((Control)PurchasesBtn);
                currentWindow = ActiveWindow.Purchases;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (!( settingsBtn.BackColor ==  homeBtn.Parent.BackColor))
                return;
            
            if ( con != null)
            {
                closeWindow();
            }
            
            if (con == null)
            {
                Panel_Configuracion panelConfiguracion = new Panel_Configuracion();
                panelConfiguracion.TopLevel = false;
                con = (Control)panelConfiguracion;
                panelConfiguracion.TopLevel = false;
                panelConfiguracion.AutoScroll = true;
                panelConfiguracion.Dock = DockStyle.Fill;
                panelConfiguracion.Show();
                ContainerPanel.Controls.Add(con);
                disableButton((Control)settingsBtn);
                currentWindow = ActiveWindow.Settings;
            }
        }
        private void employeeBtn_Click(object sender, EventArgs e)
        {
            if (!( employeeBtn.BackColor ==  homeBtn.Parent.BackColor))
                return;
            if ( con != null)
            {
                closeWindow();
            }
            if (con == null)
            {
                Panel_Empleados panelEmpleados = new Panel_Empleados(employee.ID, FormWindowState.Normal);
                panelEmpleados.TopLevel = false;
                con = (Control)panelEmpleados;
                panelEmpleados.TopLevel = false;
                panelEmpleados.AutoScroll = true;
                panelEmpleados.Dock = DockStyle.Fill;
                panelEmpleados.Show();
                ContainerPanel.Controls.Add(con);
                disableButton((Control)employeeBtn);
                currentWindow = ActiveWindow.Employees;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (!( homeBtn.BackColor ==  homeBtn.Parent.BackColor))
                return;
            if (con != null)
            {
                closeWindow();
            }
            if (con == null)
            {
                Panel_Inicio panelInicio = new Panel_Inicio(time, employee.ID, ContainerPanel.Size, FormWindowState.Normal);
                panelInicio.TopLevel = false;
                con = panelInicio;
                con.Tag = (object)panelInicio;
                panelInicio.TopLevel = false;
                panelInicio.TopMost = true;
                panelInicio.AutoScroll = true;
                panelInicio.Dock = DockStyle.Fill;
                panelInicio.Show();
                ContainerPanel.Controls.Add(con);
                disableButton(homeBtn);
                currentWindow = ActiveWindow.Home;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void changeUserBtn_Click(object sender, EventArgs e)
        {
            Form_Login formLogin = new Form_Login("Iniciar Sesión");
            DarkForm darkForm = new DarkForm();
            if (MessageBox.Show(string.Format("¿Desea cambiar de usuario?.\nGuarde su información antes de continuar."), "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            darkForm.Show();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                 employee = new Empleado(formLogin.ID);
                 displayHideTabs();
                 homeBtn_Click((object)this, (EventArgs)null);
            }
            darkForm.Close();
        }


        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            if (!( statisticsBtn.BackColor ==  statisticsBtn.Parent.BackColor))
                return;

            if ( con != null)
            {
                closeWindow();
            }

            if (con == null)
            {
                panel_Estadisticas statistics = new panel_Estadisticas();
                statistics.TopLevel = false;
                con = (Control)statistics;
                con.Tag = (object)statistics;
                statistics.TopLevel = false;
                statistics.TopMost = true;
                statistics.AutoScroll = true;
                statistics.Dock = DockStyle.Fill;
                statistics.Show();
                ContainerPanel.Controls.Add(con);
                disableButton(statisticsBtn);
                currentWindow = ActiveWindow.Statistics;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            homeBtn_Click(this, null);
        }
    }
}