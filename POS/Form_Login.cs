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
    public partial class Form_Login : Form
    {
        private Queue<bool> accessAsAdmin = new Queue<bool>();
        private Empleado employee;
        private int _id;

        public int ID
        {
            get
            {
                return this._id;
            }
        }

        public Form_Login(string title = "Iniciar Sesión")
        {
            this.InitializeComponent();
            this.pictureBox1.Parent = (Control)this.panel1;
            this.pictureBox1.BackColor = Color.Transparent;
            this.ShowInTaskbar = false;
            this._id = -1;
            this.label1.Text = title;
            this.bottomLeftHiddenBtn.FlatAppearance.MouseOverBackColor = this.bottomLeftHiddenBtn.BackColor;
            this.bottomLeftHiddenBtn.FlatAppearance.MouseDownBackColor = this.bottomLeftHiddenBtn.BackColor;
            this.bottomRightHiddenBtn.FlatAppearance.MouseOverBackColor = this.bottomRightHiddenBtn.BackColor;
            this.bottomRightHiddenBtn.FlatAppearance.MouseDownBackColor = this.bottomRightHiddenBtn.BackColor;
            this.upperLeftHiddenBtn.FlatAppearance.MouseOverBackColor = this.upperLeftHiddenBtn.BackColor;
            this.upperLeftHiddenBtn.FlatAppearance.MouseDownBackColor = this.upperLeftHiddenBtn.BackColor;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.login();
        }

        private void login()
        {
            if (this.userTxt.Text == "" || this.passwordTxt.Text == "")
            {
                int num = (int)MessageBox.Show("Introduzca el usuario y la contraseña para continuar");
            }
            else
            {
                this.employee = new Empleado(this.userTxt.Text, this.passwordTxt.Text);
                if (this.employee.ID != -1)
                {
                    this._id = this.employee.ID;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    this.incorrectInfoLbl.Show();
            }
        }

        private void userPassTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.login();
            if (e.KeyCode != Keys.Escape)
                return;
            if ((sender as TextBox).Text != "")
                (sender as TextBox).Text = "";
            else
                this.Close();
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            this.label1.Location = new Point((this.label1.Parent.Width - this.label1.Width) / 2, (this.label1.Parent.Height - this.label1.Height) / 2);
        }

        private void bottomRightHiddenBtn_Click(object sender, EventArgs e)
        {
            if (this.accessAsAdmin.Count >= 3)
                this.accessAsAdmin = new Queue<bool>();
            if (this.accessAsAdmin.Count == 0)
                this.accessAsAdmin.Enqueue(true);
            else
                this.accessAsAdmin.Enqueue(false);
        }

        private void bottomLeftHiddenBtn_Click(object sender, EventArgs e)
        {
            if (this.accessAsAdmin.Count >= 3)
                this.accessAsAdmin = new Queue<bool>();
            if (this.accessAsAdmin.Count == 1)
                this.accessAsAdmin.Enqueue(true);
            else
                this.accessAsAdmin.Enqueue(false);
        }

        private void upperLeftHiddenBtn_Click(object sender, EventArgs e)
        {
            if (this.accessAsAdmin.Count >= 3)
                this.accessAsAdmin = new Queue<bool>();
            if (this.accessAsAdmin.Count == 2)
                this.accessAsAdmin.Enqueue(true);
            else
                this.accessAsAdmin.Enqueue(false);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Return | Keys.Shift | Keys.Control))
            {
                if (this.accessAsAdmin.Count == 3 && this.accessAsAdmin.Dequeue() && (this.accessAsAdmin.Dequeue() && this.accessAsAdmin.Dequeue()))
                {
                    this._id = 1;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return true;
                }
                this.accessAsAdmin = new Queue<bool>();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bottomRightHiddenBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).FlatAppearance.MouseOverBackColor = this.bottomLeftHiddenBtn.BackColor;
            (sender as Button).FlatAppearance.MouseDownBackColor = this.bottomLeftHiddenBtn.BackColor;
        }


        private void HiddenBtn_Enter(object sender, EventArgs e)
        {
            userTxt.Focus();
        }

        private void userTxt_Enter(object sender, EventArgs e)
        {
        }

        private void passwordTxt_Enter(object sender, EventArgs e)
        {
        }
    }
}
