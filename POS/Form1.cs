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
        Control _control;
        private Control con
        {
            get { return _control; }


            set
            {
                if (_control != null && VentasButton.BackColor != this.homeBtn.Parent.BackColor)
                {
                    if (!(_control as Panel_Ventas).canClose)
                        if (MessageBox.Show("¿Desea cambiar de pestaña?. \nPerderá la información", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }

                    _control = value;
                }
                else
                {

                    _control = value;
                }
            }
        }

            string xd { get; set; }
        private Empleado employee;
        private ContextMenu menu;
        private bool displayingReminder;

        public Form1(int EmployeeID)
        {
            this.InitializeComponent();
            Turno.SetFirsUsage(DateTime.Now);
            Recordatorio.resetReminders();
            this.WindowState = FormWindowState.Maximized;
            this.timer();
            this.HourLbl.Visible = true;
            this.MinutesLbl.Visible = true;
            this.Daylbl.Visible = true;
            this.DateLbl.Visible = true;
            this.employee = new Empleado(EmployeeID);
            this.displayHideTabs();
            Button control = this.VentasButton;
            this.menu = new ContextMenu();
            this.menu.MenuItems.Add(new MenuItem("Abrir en nueva ventana"));
            control.ContextMenu = this.menu;
            control.ContextMenu.MenuItems[0].Click += (EventHandler)((s, e) =>
            {
                if (control.Name == this.homeBtn.Name)
                    new Panel_Inicio(this.time, this.employee.ID, this.ContainerPanel.Size, FormWindowState.Maximized).Show();
                else if (control.Name == this.VentasButton.Name)
                    new Panel_Ventas(this.employee.ID, FormWindowState.Maximized).Show();
                else if (control.Name == this.ProductsButton.Name)
                    new Panel_Productos(FormWindowState.Maximized).Show();
                else if (control.Name == this.ClientesBtn.Name)
                    new Panel_Clientes(FormWindowState.Maximized).Show();
                else if (control.Name == this.SuppliersBtn.Name)
                    new Panel_proveedores_Form(this.time, this.employee.ID, FormWindowState.Maximized).Show();
                else if (control.Name == this.PurchasesBtn.Name)
                {
                    new PanelCompras(this.employee.ID, FormWindowState.Maximized).Show();
                }
                else
                {
                    if (!(control.Name == this.employeeBtn.Name))
                        return;
                    new Panel_Empleados(this.employee.ID, FormWindowState.Maximized).Show();
                }
            });

        }

        private void displayHideTabs()
        {
            this.ProductsButton.Visible = this.employee.isAdmin;
            this.ClientesBtn.Visible = this.employee.isAdmin;
            this.employeeBtn.Visible = this.employee.isAdmin;
            this.settingsBtn.Visible = this.employee.isAdmin;
            statisticsBtn.Visible = employee.isAdmin;
            this.userNameLbl.Text = string.Format("   {0}", this.employee.name.IndexOf(' ') > 0 ? (object)this.employee.name.Substring(0, this.employee.name.IndexOf(' ')) : (object)this.employee.name);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
            if (!(this.VentasButton.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                this.con = null;
            }
            if (con == null)
            {
                Panel_Ventas panelVentas = new Panel_Ventas(this.employee.ID, FormWindowState.Normal);
                this.con = (Control)panelVentas;
                panelVentas.TopLevel = false;
                this.ContainerPanel.Controls.Add((Control)panelVentas);
                panelVentas.Dock = DockStyle.Fill;
                panelVentas.Show();
                this.disableButton((Control)this.VentasButton);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }

        private void disableButton(Control button)
        {
            this.VentasButton.BackColor = this.TabPanel.BackColor;
            VentasButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.ProductsButton.BackColor = this.TabPanel.BackColor;
            ProductsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.ClientesBtn.BackColor = this.TabPanel.BackColor;
            ClientesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.SuppliersBtn.BackColor = this.TabPanel.BackColor;
            SuppliersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.PurchasesBtn.BackColor = this.TabPanel.BackColor;
            PurchasesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.settingsBtn.BackColor = this.TabPanel.BackColor;


            this.employeeBtn.BackColor = this.TabPanel.BackColor;
            employeeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.homeBtn.BackColor = this.TabPanel.BackColor;
            homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);

            this.statisticsBtn.BackColor = this.TabPanel.BackColor;
            statisticsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 133, 207);


            button.BackColor = Color.FromArgb(1, 93, 141);
            if (button.Name != settingsBtn.Name)
                (button as Button).FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 93, 141);
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            if (!(this.ProductsButton.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                this.con = null;
            }

            if (con == null)
            {
                Panel_Productos panelProductos = new Panel_Productos(FormWindowState.Normal);
                panelProductos.TopLevel = false;
                this.con = (Control)panelProductos;
                panelProductos.TopLevel = false;
                panelProductos.AutoScroll = true;
                panelProductos.Dock = DockStyle.Fill;
                panelProductos.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton((Control)this.ProductsButton);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }


        private void timer()
        {
            this.time = new System.Windows.Forms.Timer();
            this.time.Interval = 1000;
            this.time.Tick += new EventHandler(this.t_Tick);
            this.time.Enabled = true;
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
            
            this.setUpReminders();
        }

        private async void setUpReminders()
        {
            await Task.Run((Action)(() =>
            {
                if (displayingReminder)
                    return;
                
                this.displayingReminder = true;
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
                this.displayingReminder = false;
            }));
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            if (!(this.ClientesBtn.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                con = null;
            }
            if (con == null)
            {
                Panel_Clientes panelClientes = new Panel_Clientes(FormWindowState.Normal);
                panelClientes.EmployeeID = this.employee.ID;
                panelClientes.TopLevel = false;
                this.con = (Control)panelClientes;
                panelClientes.TopLevel = false;
                panelClientes.AutoScroll = true;
                this.SuppliersBtn.Enabled = true;
                panelClientes.Dock = DockStyle.Fill;
                panelClientes.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton((Control)this.ClientesBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }
        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            if (!(this.SuppliersBtn.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                con = null;
            }
            if (con == null)
            {
                Panel_proveedores_Form panelProveedoresForm = new Panel_proveedores_Form(this.time, this.employee.ID, FormWindowState.Normal);
                panelProveedoresForm.TopLevel = false;
                this.con = (Control)panelProveedoresForm;
                panelProveedoresForm.TopLevel = false;
                panelProveedoresForm.AutoScroll = true;
                panelProveedoresForm.Dock = DockStyle.Fill;
                panelProveedoresForm.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton((Control)this.SuppliersBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }

        private void PurchasesBtn_Click(object sender, EventArgs e)
        {
            if (!(this.PurchasesBtn.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                con = null;
            }
            if (con == null)
            {
                PanelCompras panelCompras = new PanelCompras(this.employee.ID, FormWindowState.Normal);
                panelCompras.TopLevel = false;
                this.con = panelCompras;
                panelCompras.TopLevel = false;
                panelCompras.AutoScroll = true;
                panelCompras.Dock = DockStyle.Fill;
                panelCompras.Show();
                this.ContainerPanel.Controls.Add(con);
                this.disableButton((Control)this.PurchasesBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (!(this.settingsBtn.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                con = null;
            }
            if (con == null)
            {
                Panel_Configuracion panelConfiguracion = new Panel_Configuracion();
                panelConfiguracion.TopLevel = false;
                this.con = (Control)panelConfiguracion;
                panelConfiguracion.TopLevel = false;
                panelConfiguracion.AutoScroll = true;
                panelConfiguracion.Dock = DockStyle.Fill;
                panelConfiguracion.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton((Control)this.settingsBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }
        private void employeeBtn_Click(object sender, EventArgs e)
        {
            if (!(this.employeeBtn.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                this.con = null;
            }
            if (con == null)
            {
                Panel_Empleados panelEmpleados = new Panel_Empleados(this.employee.ID, FormWindowState.Normal);
                panelEmpleados.TopLevel = false;
                this.con = (Control)panelEmpleados;
                panelEmpleados.TopLevel = false;
                panelEmpleados.AutoScroll = true;
                panelEmpleados.Dock = DockStyle.Fill;
                panelEmpleados.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton((Control)this.employeeBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (!(this.homeBtn.BackColor == this.homeBtn.Parent.BackColor))
                return;
            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                this.con=null;
            }

            if (con == null)
            {
                Panel_Inicio panelInicio = new Panel_Inicio(this.time, this.employee.ID, this.ContainerPanel.Size, FormWindowState.Normal);
                panelInicio.TopLevel = false;
                this.con = (Control)panelInicio;
                this.con.Tag = (object)panelInicio;
                panelInicio.TopLevel = false;
                panelInicio.TopMost = true;
                panelInicio.AutoScroll = true;
                panelInicio.Dock = DockStyle.Fill;
                panelInicio.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton((Control)this.homeBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
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
                this.employee = new Empleado(formLogin.ID);
                this.displayHideTabs();
                this.homeBtn_Click((object)this, (EventArgs)null);
            }
            darkForm.Close();
        }

       
        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            if (!(this.statisticsBtn.BackColor == this.statisticsBtn.Parent.BackColor))
                return;

            if (this.con != null)
            {
                this.ContainerPanel.Controls.Clear();
                this.con = null;
            }
            if (con == null)
            {
                panel_Estadisticas statistics = new panel_Estadisticas();
                statistics.TopLevel = false;
                this.con = (Control)statistics;
                this.con.Tag = (object)statistics;
                statistics.TopLevel = false;
                statistics.TopMost = true;
                statistics.AutoScroll = true;
                statistics.Dock = DockStyle.Fill;
                statistics.Show();
                this.ContainerPanel.Controls.Add(this.con);
                this.disableButton(statisticsBtn);
            }
            else
            {
                ContainerPanel.Controls.Add(con);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            homeBtn_Click(this, null);
        }
    }
}
