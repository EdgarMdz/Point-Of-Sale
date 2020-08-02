using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.PointOfService;

namespace POS
{
    public partial class Panel_Empleados : Form
    {
        private bool[] paymentDays = new bool[7];
        private Empleado employee;
        private int User_employeeID;
        private CashDrawer m_Drawer;
        private bool changingEmployee { get; set; }

        public Panel_Empleados(int employeeID, FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            this.dateofBirth.MaxDate = DateTime.Today;
            this.dateofBirth.MinDate = new DateTime();
            this.hirementDate.MaxDate = DateTime.Today;
            this.hirementDate.MinDate = new DateTime();
            this.User_employeeID = employeeID;
            this.printDialog1.PrinterSettings.PrinterName = new PrinterTicket().printerName;
            printDocument1.PrintController = new StandardPrintController();

        }

        private void searchEmployeeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.searchEmployee();
        }

        private void searchEmployee()
        {
            if (!(this.searchEmployeeTxt.Text != ""))
                return;
            DataTable employeeList = Empleado.searchEmployee(this.searchEmployeeTxt.Text);
            PanelEmpleados_SelectEmployee empleadosSelectEmployee = new PanelEmpleados_SelectEmployee(employeeList);
            DarkForm darkForm = new DarkForm();
            if (employeeList.Rows.Count == 0)
            {
                int num = (int)MessageBox.Show("No se encontraron empleados");
            }
            else if (employeeList.Rows.Count == 1)
            {
                this.employee = new Empleado(Convert.ToInt32(employeeList.Rows[0]["id_Empleado"]));
                this.setEmployeeInfo();
            }
            else
            {
                darkForm.Show();
                if (empleadosSelectEmployee.ShowDialog() == DialogResult.OK)
                {
                    this.employee = new Empleado(empleadosSelectEmployee.employeeID);
                    this.setEmployeeInfo();
                }
                darkForm.Close();
            }
        }

        private void setEmployeeInfo()
        {
            this.changingEmployee = true;
            this.nameTxt.Text = this.employee.name;
            this.addressTxt.Text = this.employee.address;
            this.phoneTxt.Text = this.employee.phoneNumber;
            this.dateofBirth.Value = this.employee.dateOfBirth < this.dateofBirth.MinDate ? this.dateofBirth.MinDate : this.employee.dateOfBirth;
            this.hirementDate.Value = this.employee.hirementDate < this.hirementDate.MinDate ? this.hirementDate.MinDate : this.employee.hirementDate;
            this.salaryTxt.Text = this.employee.salary.ToString("n2");
            this.discountTxt.Text = this.employee.isDiscountAppliedAsPercentage ? this.employee.discount.ToString("n2") + "%" : this.employee.discount.ToString("n2");
            this.comboBox1.SelectedIndex = this.employee.isAdmin ? 1 : 0;
            this.paymentDays = this.employee.daysOfPayment;
            this.mondayLbl.ForeColor = this.paymentDays[0] ? Color.Tomato : Color.DimGray;
            this.tuestayLbl.ForeColor = this.paymentDays[1] ? Color.Tomato : Color.DimGray;
            this.wednesdayLbl.ForeColor = this.paymentDays[2] ? Color.Tomato : Color.DimGray;
            this.thursdayLbl.ForeColor = this.paymentDays[3] ? Color.Tomato : Color.DimGray;
            this.fridayLbl.ForeColor = this.paymentDays[4] ? Color.Tomato : Color.DimGray;
            this.saturdayLbl.ForeColor = this.paymentDays[5] ? Color.Tomato : Color.DimGray;
            this.sundayLbl.ForeColor = this.paymentDays[6] ? Color.Tomato : Color.DimGray;
            this.debtLbl.Text = "$" + new Cliente(this.employee.CustomerID).Debt.ToString("n2");
            this.searchEmployeeTxt.Text = "";
            this.EmployeePanel.Visible = true;
            this.changingEmployee = false;
        }

        private void dayLabel_click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = label.ForeColor == Color.DimGray ? Color.Tomato : Color.DimGray;
            if (label.Name == this.mondayLbl.Name)
            {
                this.paymentDays[0] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[0] = false;
                this.mondayLbl.ForeColor = Color.DimGray;
            }
            if (label.Name == this.tuestayLbl.Name)
            {
                this.paymentDays[1] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[1] = false;
                this.tuestayLbl.ForeColor = Color.DimGray;
            }
            if (label.Name == this.wednesdayLbl.Name)
            {
                this.paymentDays[2] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[2] = false;
                this.wednesdayLbl.ForeColor = Color.DimGray;
            }
            if (label.Name == this.thursdayLbl.Name)
            {
                this.paymentDays[3] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[3] = false;
                this.thursdayLbl.ForeColor = Color.DimGray;
            }
            if (label.Name == this.fridayLbl.Name)
            {
                this.paymentDays[4] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[4] = false;
                this.fridayLbl.ForeColor = Color.DimGray;
            }
            if (label.Name == this.saturdayLbl.Name)
            {
                this.paymentDays[5] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[5] = false;
                this.saturdayLbl.ForeColor = Color.DimGray;
            }
            if (label.Name == this.sundayLbl.Name)
            {
                this.paymentDays[6] = !(label.ForeColor == Color.DimGray);
            }
            else
            {
                this.paymentDays[6] = false;
                this.sundayLbl.ForeColor = Color.DimGray;
            }
            this.employee.updatePaymentDay(this.paymentDays);
        }

        private void discountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != '%'))
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
            if (this.discountTxt.Text != "" && e.KeyChar == '%' && (sender as TextBox).Text.IndexOf('%') > -1)
                e.Handled = true;
            if (e.KeyChar == '%' && this.discountTxt.Text == "")
                e.Handled = true;
            if (this.discountTxt.Text.IndexOf("%") > -1 && !char.IsControl(e.KeyChar) && this.discountTxt.SelectionStart > this.discountTxt.Text.IndexOf("%"))
                e.Handled = true;
            if (e.KeyChar != '%' || this.discountTxt.SelectionStart == this.discountTxt.Text.Length)
                return;
            e.Handled = true;
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            string text = this.discountTxt.Text;
            if (text.IndexOf("%") <= -1 || this.discountTxt.Text.Length <= 1)
                return;
            this.discountTxt.Text = Convert.ToDouble(text.Substring(0, text.Length - 1)) > 100.0 ? "100%" : this.discountTxt.Text;
        }

        private void discountTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.updateDiscount();
        }

        private void updateDiscount()
        {
            string text = this.discountTxt.Text;
            bool isPercentage = text.IndexOf("%") > -1;
            double discount = isPercentage ? Convert.ToDouble(text.Substring(0, text.Length - 1)) : Convert.ToDouble(text);
            if (this.employee.isDiscountAppliedAsPercentage == isPercentage && this.employee.discount == discount)
                return;
            this.employee.UpdateDiscount(discount, isPercentage);
            int num = (int)MessageBox.Show("Se actualizó el descuento");
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            this.newEmployeeBtn.Location = new Point(this.panel1.Width - this.newEmployeeBtn.Width - 50, this.newEmployeeBtn.Location.Y);
            this.employeeListBtn.Location = new Point(this.newEmployeeBtn.Location.X - this.employeeListBtn.Width - 25, this.employeeListBtn.Location.Y);
        }

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.updateName();
            if (e.KeyCode != Keys.Escape)
                return;
            this.nameTxt.Text = this.employee.name;
        }

        private void updateName()
        {
            if (!(this.nameTxt.Text != "") || !(this.nameTxt.Text.ToLower() != this.employee.name.ToLower()))
                return;
            this.employee.UpdateName(this.nameTxt.Text);
            int num = (int)MessageBox.Show("Se ha actualizado el nombre");
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (this.nameTxt.Text == "")
                this.nameTxt.Text = this.employee.name;
            else
                this.updateName();
        }

        private void addressTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.updateAddress();
            if (e.KeyCode != Keys.Escape)
                return;
            this.addressTxt.Text = this.employee.address;
        }

        private void addressTxt_Leave(object sender, EventArgs e)
        {
            this.updateAddress();
        }

        private void updateAddress()
        {
            if (!(this.addressTxt.Text.ToLower() != this.employee.address.ToLower()))
                return;
            this.employee.UpdateAddress(this.addressTxt.Text);
            int num = (int)MessageBox.Show("Se ha actualizado la dirección");
        }

        private void phoneTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.UpdatePhone();
            if (e.KeyCode != Keys.Escape)
                return;
            this.phoneTxt.Text = this.employee.phoneNumber;
        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            this.UpdatePhone();
        }

        private void UpdatePhone()
        {
            if (!(this.phoneTxt.Text.ToLower() != this.employee.phoneNumber.ToLower()))
                return;
            this.employee.UpdatePhone(this.phoneTxt.Text);
            int num = (int)MessageBox.Show("Se ha actualizado el número de teléfono");
        }

        private void dateofBirth_ValueChanged(object sender, EventArgs e)
        {
            if (this.employee == null || !(this.dateofBirth.Value.Date != this.employee.dateOfBirth.Date))
                return;
            this.employee.UpdateDateOfBirth(this.dateofBirth.Value);
        }

        private void hirementDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.employee == null || !(this.hirementDate.Value.Date != this.employee.hirementDate))
                return;
            this.employee.UpdateHirementDate(this.hirementDate.Value);
        }

        private void salaryTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                this.UpdateSalary();
            if (e.KeyCode != Keys.Escape)
                return;
            this.salaryTxt.Text = this.employee.salary.ToString("n2");
        }

        private void UpdateSalary()
        {
            double newSalary = Convert.ToDouble(this.salaryTxt.Text);
            Form_Login formLogin = new Form_Login(string.Format("Verificación De\nUsuario"));
            DarkForm darkForm = new DarkForm();
            if (this.employee.salary == newSalary)
                return;
            darkForm.Show();
            int num1 = (int)formLogin.ShowDialog();
            Empleado empleado = new Empleado(formLogin.ID);
            if (formLogin.DialogResult == DialogResult.OK && empleado.isAdmin)
            {
                this.employee.updateSalary(newSalary);
                int num2 = (int)MessageBox.Show("Se ha actualizado el número el salario");
                this.salaryTxt.Text = newSalary.ToString("n2");
            }
            else if (formLogin.DialogResult == DialogResult.OK && !empleado.isAdmin && formLogin.ID > -1)
            {
                int num2 = (int)MessageBox.Show("No tiene los permisos necesarios para realizar esta acción");
                this.salaryTxt.Text = this.employee.salary.ToString("n2");
            }
            else
                this.salaryTxt.Text = this.employee.salary.ToString("n2");
            darkForm.Close();
        }

        private void salaryTxt_Leave(object sender, EventArgs e)
        {
            this.UpdateSalary();
        }

        private void salaryTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (!(this.salaryTxt.Text == ""))
                return;
            this.salaryTxt.Text = "0.00";
        }

        private void salaryTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (this.salaryTxt.Text.IndexOf('.') <= -1 || e.KeyChar != '.')
                return;
            e.Handled = true;
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            FormCambio formCambio = new FormCambio(this.employee.salary);
            DarkForm darkForm = new DarkForm();
            Form_Login formLogin = new Form_Login(string.Format("Verificación De\nUsuario"));
            darkForm.Show();
            int num1 = (int)formLogin.ShowDialog();
            Empleado empleado = new Empleado(formLogin.ID);
            if (formLogin.DialogResult == DialogResult.OK)
            {
                if (empleado.isAdmin)
                {
                    /*try
                    {
                        this.printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.printDocument1;
                        this.printDocument1.Print();
                    }
                    catch (InvalidPrinterException)
                    {
                        int num2 = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                    }*/

                    openDrawer();
                    this.employee.paySalary();
                    formCambio.ShowDialog();
                    goto label_7;
                }
            }
            if (formLogin.DialogResult == DialogResult.OK && !empleado.isAdmin)
            {
                MessageBox.Show("No dispone de los permisos necesarios para realizar el pago");
            }
        label_7:
            darkForm.Close();
        }

        private void openDrawer()
        {
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
                catch (Exception)
                {
                }
            }
        }

        private void paymentDebtBtn_Click(object sender, EventArgs e)
        {
            Cliente customer = new Cliente(this.employee.CustomerID);
            if (customer.Debt <= 0.0)
                return;
            FormPagar form = new FormPagar("$" + customer.Debt.ToString("n2"), false, 0.0);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (form.ShowDialog() == DialogResult.OK)
            {
                double customerPayment = Convert.ToDouble(form.Pay);
                double cash = Convert.ToDouble(form.Cash);
                if (customerPayment > 0.0)
                {
                    DataTable acountsReceivable = customer.GetAcountsReceivable();
                    double change = cash <= customerPayment ? 0.0 : cash - customerPayment;
                    for (int index = 0; index < acountsReceivable.Rows.Count; ++index)
                    {
                        DataRow row = acountsReceivable.Rows[index];
                        if (customerPayment > 0.0)
                        {
                            double cash1 = customerPayment - Convert.ToDouble(row["Resto"]) <= 0.0 ? customerPayment : Convert.ToDouble(row["Resto"]);
                            customer.RegisterPayment(Convert.ToInt32(row["id_ventas"]), DateTime.Now, cash1, this.User_employeeID);
                            customer.Pay(cash1, Convert.ToInt32(row["id_ventas"]));
                            customerPayment -= cash1;
                        }
                    }
                    FormCambio formCambio = new FormCambio(change);
                    this.customerPaymentDocument = new PrintDocument();
                    customerPaymentDocument.PrintController = new StandardPrintController();

                    this.customerPaymentDocument.PrintPage += (PrintPageEventHandler)((ss, ee) =>
                    {
                        PrinterTicket printerTicket = new PrinterTicket();
                        Graphics graphics = ee.Graphics;
                        this.customerPaymentDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 200, 200);
                        int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width;
                        int y1 = 10;
                        Size size1 = printerTicket.printLogo(graphics, y1);
                        int y2 = size1.Height == 0 ? y1 : y1 + size1.Height + 10;
                        Size size2 = printerTicket.printHeader(graphics, y2);
                        int y3 = size2.Height == 0 ? y2 : y2 + size2.Height + 10;
                        Size size3 = printerTicket.printAddress(graphics, y3);
                        int y4 = size3.Height == 0 ? y3 : y3 + size3.Height + 10;
                        Size size4 = printerTicket.printPhone(graphics, y4);
                        int num1 = size4.Height == 0 ? y4 : y4 + size4.Height + 10;
                        graphics.DrawLine(Pens.Black, 10, num1, width - 10, num1);
                        int num2 = num1 + 5;
                        string str1 = "Pago de Cliente";
                        Font font1 = this.getFont(str1, width, FontStyle.Regular);
                        Size stringSize1 = this.getStringSize(str1, font1);
                        graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)num2);
                        int num3 = num2 + (15 + stringSize1.Height);
                        if (customer.ID != 0)
                        {
                            Font font2 = new Font("Times new Roman", 8f, FontStyle.Bold);
                            Size stringSize2 = this.getStringSize("Cliente: " + customer.Name, font2);
                            graphics.DrawString("Cliente: " + customer.Name, font2, Brushes.Black, 0.0f, (float)num3);
                            num3 += stringSize2.Height + 10;
                        }
                        string str2 = string.Format("Fecha: {0}\t{1}", (object)DateTime.Now.Date.ToShortDateString(), (object)DateTime.Now.Date.ToShortTimeString());
                        Font font3 = new Font("Times new Roman", 8f, FontStyle.Bold);
                        Size stringSize3 = this.getStringSize(str2, font3);
                        int num4;
                        if (stringSize3.Width + 10 < width)
                        {
                            graphics.DrawString(str2, font3, Brushes.Black, 0.0f, (float)num3);
                            num4 = num3 + (stringSize3.Height + 5);
                        }
                        else
                        {
                            this.Font = this.getFont(str2, width - 10, FontStyle.Bold);
                            Size stringSize2 = this.getStringSize(str2, font3);
                            graphics.DrawString(str2, font3, Brushes.Black, 10f, (float)num3);
                            num4 = num3 + (stringSize2.Height + 5);
                        }
                        customerPayment = Convert.ToDouble(form.Pay);
                        string str3 = string.Format("Adeudo Previo: ${0}", (object)(customer.Debt + customerPayment).ToString("n2"));
                        Font font4 = this.getFont(str3, width * 5 / 8, FontStyle.Regular);
                        Size stringSize4 = this.getStringSize(str3, font4);
                        graphics.DrawString(str3, font4, Brushes.Black, 0.0f, (float)num4);
                        int num5 = num4 + (stringSize4.Height + 3);
                        string str4 = string.Format("Monto a pagar: ${0}", (object)customerPayment.ToString("n2"));
                        Size stringSize5 = this.getStringSize(str4, font4);
                        graphics.DrawString(str4, font4, Brushes.Black, 0.0f, (float)num5);
                        int num6 = num5 + (stringSize5.Height + 3);
                        string str5 = string.Format("Adeudo Actualizado: ${0}", (object)customer.Debt.ToString("n2"));
                        Font font5 = this.getFont(str5, width * 3 / 4, FontStyle.Bold);
                        Size stringSize6 = this.getStringSize(str3, font5);
                        graphics.DrawString(str5, font5, Brushes.Black, 0.0f, (float)num6);
                        int num7 = num6 + (stringSize6.Height + 8);
                        string str6 = string.Format("Efectivo: ${0}", (object)cash.ToString("n2"));
                        Size stringSize7 = this.getStringSize(str6, font4);
                        graphics.DrawString(str6, font4, Brushes.Black, (float)(width - stringSize7.Width), (float)num7);
                        int num8 = num7 + (stringSize7.Height + 3);
                        string str7 = string.Format("Cambio: ${0}", (object)change.ToString("n2"));
                        Size stringSize8 = this.getStringSize(str7, font4);
                        graphics.DrawString(str7, font4, Brushes.Black, (float)(width - stringSize8.Width), (float)num8);
                        int y5 = num8 + (8 + stringSize8.Height);
                        Size size5 = printerTicket.printFooter(graphics, y5);
                        int num9 = size5.Height == 0 ? y5 : y5 + size5.Height + 10;
                    });
                    try
                    {
                        this.customerPaymentDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                        this.printDialog1.Document = this.customerPaymentDocument;
                        this.customerPaymentDocument.Print();
                    }
                    catch (InvalidPrinterException ex)
                    {
                        int num = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                    }
                    int num10 = (int)formCambio.ShowDialog();
                    customer.RefreshInfo();
                    this.debtLbl.Text = "$" + customer.Debt.ToString("n2");
                }
                else
                {
                    int num11 = (int)MessageBox.Show("El Cliente no genera ningun adeudo");
                }
            }
            darkForm.Close();
        }

        private Font getFont(string text, int width, FontStyle style = FontStyle.Bold)
        {
            int num1 = 25;
            Font font1 = new Font("Times new roman", (float)num1, style);
            Size stringSize = this.getStringSize(text, font1);
            if (stringSize.Width > width)
            {
                int num2 = 0;
                Font font2;
                for (; stringSize.Width > width; stringSize = this.getStringSize(text, font2))
                {
                    num2 += 2;
                    font2 = new Font("Times new roman", (float)(num1 - num2), style);
                }
                font1 = new Font("Times new roman", (float)(num1 - num2), style);
            }
            else if (stringSize.Width < width)
            {
                int num2 = 0;
                Font font2;
                for (; stringSize.Width < width; stringSize = this.getStringSize(text, font2))
                {
                    num2 += 2;
                    font2 = new Font("Times new roman", (float)(num1 + num2), style);
                }
                font1 = new Font("Times new roman", (float)(num1 + num2), style);
            }
            return font1;
        }

        private Size getStringSize(string text, Font font)
        {
            return TextRenderer.MeasureText(text, font);
        }

        private void loanBtn_Click(object sender, EventArgs e)
        {
            FormPrestamo formPrestamo = new FormPrestamo();
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (formPrestamo.ShowDialog() == DialogResult.OK && formPrestamo.loan > 0.0)
            {
                double loan = formPrestamo.loan;
                Cliente cliente = new Cliente(this.employee.CustomerID);
                Venta venta = new Venta();
                double Payment = 0.0;
                double num1 = loan;
                venta.newSale(this.User_employeeID, cliente.ID, loan, Payment, null, num1);
                FormCambio formCambio = new FormCambio(num1);
                /*try
                {
                    this.printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                    this.printDialog1.Document = this.printDocument1;
                    this.printDocument1.Print();
                }
                catch (InvalidPrinterException ex)
                {
                    int num2 = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
                }*/
                openDrawer();
                formCambio.ShowDialog();
                this.debtLbl.Text = "$" + (cliente.Debt + loan).ToString("n2");
            }
            darkForm.Close();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            Form_Change_Password formChangePassword = new Form_Change_Password(this.employee.ID, true);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            int num = (int)formChangePassword.ShowDialog();
            darkForm.Hide();
        }

        private void debtLbl_TextChanged(object sender, EventArgs e)
        {
            if (this.debtLbl.Text == "$0.00")
                this.bunifuCards1.color = Color.LimeGreen;
            else
                this.bunifuCards1.color = Color.Tomato;
        }

        private void newEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.User_employeeID).isAdmin)
                return;
            panelEmpleados_nuevoEmpleado empleadosNuevoEmpleado = new panelEmpleados_nuevoEmpleado(true);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (empleadosNuevoEmpleado.ShowDialog() == DialogResult.OK)
            {
                this.employee = new Empleado(empleadosNuevoEmpleado.newEmployeeID);
                this.setEmployeeInfo();
            }
            darkForm.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.employee == null || this.changingEmployee)
                return;
            this.UpdatePosition();
        }

        private void UpdatePosition()
        {
            Form_Login formLogin = new Form_Login(string.Format("Verificación De\nUsuario"));
            DarkForm darkForm = new DarkForm();
            if (this.employee.ID != 1)
            {
                darkForm.Show();
                int num1 = (int)formLogin.ShowDialog();
                Empleado empleado = new Empleado(formLogin.ID);
                if (formLogin.DialogResult == DialogResult.OK && empleado.isAdmin)
                {
                    this.employee.UpdatePosition(this.comboBox1.SelectedIndex == 1);
                    int num2 = (int)MessageBox.Show("Se ha actualizado el puesto del empleado");
                }
                else if (formLogin.DialogResult == DialogResult.OK && !empleado.isAdmin && formLogin.ID > -1)
                {
                    int num2 = (int)MessageBox.Show("No tiene los permisos necesarios para realizar esta acción");
                    this.changingEmployee = true;
                    this.comboBox1.SelectedIndex = this.employee.isAdmin ? 1 : 0;
                    this.changingEmployee = false;
                }
                else
                {
                    this.changingEmployee = true;
                    this.comboBox1.SelectedIndex = this.employee.isAdmin ? 1 : 0;
                    this.changingEmployee = false;
                }
                darkForm.Close();
            }
            else
            {
                int num = (int)MessageBox.Show("No puede dejar de ser administrador");
            }
        }

        private void employeeList_Click(object sender, EventArgs e)
        {
            DataTable listOfEmployees = Empleado.getListOfEmployees();
            PanelEmpleados_SelectEmployee empleadosSelectEmployee = new PanelEmpleados_SelectEmployee(listOfEmployees);
            DarkForm darkForm = new DarkForm();
            if (listOfEmployees.Rows.Count == 0)
            {
                int num = (int)MessageBox.Show("No se encontraron empleados");
            }
            else if (listOfEmployees.Rows.Count == 1)
            {
                this.employee = new Empleado(Convert.ToInt32(listOfEmployees.Rows[0]["id_Empleado"]));
                this.setEmployeeInfo();
            }
            else
            {
                darkForm.Show();
                if (empleadosSelectEmployee.ShowDialog() == DialogResult.OK)
                {
                    this.employee = new Empleado(empleadosSelectEmployee.employeeID);
                    this.setEmployeeInfo();
                }
                darkForm.Close();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.searchEmployee();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_Empleados_Load(object sender, EventArgs e)
        {
            //<<< step1 >>> --Start
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

        private void Panel_Empleados_FormClosing(object sender, FormClosingEventArgs e)
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
            //<<<step1>>>--End
        }
    }
}
