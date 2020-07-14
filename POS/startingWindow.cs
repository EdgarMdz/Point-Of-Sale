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
                    if (secondStartingWindow.ShowDialog() != DialogResult.OK)
                        return;
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
                    if (secondStartingWindow.ShowDialog() == DialogResult.OK)
                        new Form1(empleadosNuevoEmpleado.newEmployeeID).Show();
                }
                else
                    this.Close();
                darkForm.Close();
            }
        }


    }
}
