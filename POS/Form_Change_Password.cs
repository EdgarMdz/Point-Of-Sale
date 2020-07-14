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
    public partial class Form_Change_Password : Form
    {
        private Empleado employee;
        public Form_Change_Password(int employeeID, bool showCloseBtn = true)
        {
            this.InitializeComponent();
            this.employee = new Empleado(employeeID);
            this.userNameLbl.Text = this.employee.userName;
            this.CloseBtn.Visible = showCloseBtn;
        }

        private void Form_Change_Password_Load(object sender, EventArgs e)
        {
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.updatePass();
        }

        private void updatePass()
        {
            if (this.newPasswod.Text == "" || this.repeatedNewPassword.Text == "")
            {
                int num1 = (int)MessageBox.Show("Llene totos los campos para continuar");
            }
            else if (this.newPasswod.Text != this.repeatedNewPassword.Text)
            {
                int num2 = (int)MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                this.employee.changePassword(this.newPasswod.Text);
                this.Close();
                int num3 = (int)MessageBox.Show("Se ha cambiado la contraseña");
            }
        }

        private void changePassword(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.updatePass();
            if (e.KeyCode != Keys.Escape)
                return;
            if ((sender as TextBox).Text != "")
            {
                (sender as TextBox).Text = "";
            }
            else
            {
                if (!this.CloseBtn.Visible)
                    return;
                this.Close();
            }
        }
    }
}
