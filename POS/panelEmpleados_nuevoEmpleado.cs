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
    public partial class panelEmpleados_nuevoEmpleado : Form
    {
        private int _id;
        public int newEmployeeID { get { return this._id; } }

        public panelEmpleados_nuevoEmpleado(bool enableCombobox = true)
        {
            InitializeComponent(); 
            this.ShowInTaskbar = false;
            this.comboBox1.Enabled = enableCombobox;
            if (!enableCombobox)
                this.comboBox1.SelectedIndex = 1;
            else
                this.comboBox1.SelectedIndex = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.nameTxt.Text != "" && this.userNameTxt.Text != "")
            {
                bool flag1 = Empleado.nameExist(this.nameTxt.Text);
                bool flag2 = Empleado.userNameExist(this.userNameTxt.Text);
                if (!flag1 && !flag2)
                {
                    this._id = Empleado.newEmployee(this.nameTxt.Text, this.userNameTxt.Text, this.comboBox1.SelectedIndex == 1);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                    int num = (int)new Form_Change_Password(this._id, false).ShowDialog();
                }
                else if (flag1)
                {
                    int num = (int)MessageBox.Show("Ya existe un usuario con este Nombre. Cambie el nombre para continuar");
                    this.nameTxt.SelectAll();
                    this.nameTxt.Focus();
                }
                else
                {
                    if (!flag2)
                        return;
                    int num = (int)MessageBox.Show("Ya existe un empleado con el mismo nombre de usuario. Cambie el nombre de usuario para poder continuar");
                    this.userNameTxt.SelectAll();
                    this.userNameTxt.Focus();
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Llene todos los campos para continuar");
            }
        }
    }
}
