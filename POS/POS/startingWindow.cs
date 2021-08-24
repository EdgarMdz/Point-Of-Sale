using System;
using System.Windows.Forms;

namespace POS
{
    public partial class startingWindow : Form
    {
        public startingWindow()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 3500;
            timer.Tick += new EventHandler(this.t_Tick);
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {            
            Form_Login formLogin = new Form_Login("Iniciar Sesión");
            SecondStartingWindow secondStartingWindow = new SecondStartingWindow();
            (sender as Timer).Stop();
            this.TopMost = false;
            if (Turno.isFirsUsageDateSet)
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    new Form1(formLogin.ID).Show();
                }
                else
                    this.Close();
            }
            else
            {
                DarkForm darkForm = new DarkForm();
                panelEmpleados_nuevoEmpleado empleadosNuevoEmpleado = new panelEmpleados_nuevoEmpleado(false);
                this.Hide();
                darkForm.Show();
                if (empleadosNuevoEmpleado.ShowDialog() == DialogResult.OK)
                {

                    resetDefaultFonts();
                    if (secondStartingWindow.ShowDialog() == DialogResult.OK)
                        new Form1(empleadosNuevoEmpleado.newEmployeeID).Show();
                }
                else
                    this.Close(); 
                darkForm.Close();
            }
        }

        private void resetDefaultFonts()
        {
            Properties.Settings.Default.PanelInicio_DGVFont = 12;
            Properties.Settings.Default.PanelVentas_DGVFont = 12;
            Properties.Settings.Default.PanelProductos_Font = 12;
            Properties.Settings.Default.PanelProveedores_DGV1Font = 12;
            Properties.Settings.Default.Save();
        }
    }
}
