using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Microsoft.PointOfService;
using POS.dataBaseDataSetTableAdapters;

namespace POS
{
    public partial class Panel_Inicio : Form
    {
        private int employeeID;
        private DateTime date;
        private CashDrawer m_Drawer;

        public int EmployeeID
        {
            set
            {
                if (!new Empleado(value).isAdmin)
                    flowLayoutPanel1.Controls.Clear();
                else
                    if (flowLayoutPanel1.Controls.Count == 0)
                {
                    populateNotificationPanel();
                }
                employeeID = value;
            }
        }

        private bool isPopulating { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 33554432;
                return createParams;
            }
        }

        public Panel_Inicio(Timer timer, int empID, Size size, FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;

            if (new Empleado(empID).isAdmin)
                this.populateNotificationPanel();

            this.Size = size;
            this.flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            this.flowLayoutPanel1.AutoScroll = true;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            this.endShiftBtn.Visible = Turno.shiftActive;
            this.startShiftBtn.Visible = !Turno.shiftActive;
            this.employeeID = empID;
            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.date = DateTime.Now;

            this.printDialog1.PrinterSettings.PrinterName = new PrinterTicket().printerName;
        }



        private void Panel_Inicio_Load(object sender, EventArgs e)
        {

            if (Turno.shiftActive)
                this.setGroupBoxInfo();


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

        private void Panel_Inicio_SizeChanged(object sender, EventArgs e)
        {
            this.resizeColumns();
        }

        private void setGroupBoxInfo()
        {
            this.groupBox1.Visible = Turno.shiftActive;
            this.groupBox1.Text = "Inicio de Turno: " + Turno.startingDate.ToString();
            this.dataGridView1.DataSource = (object)Turno.MoneyAddedToDrawer();
        }

        private async void populateNotificationPanel()
        {
            if (this.isPopulating)
                return;
            else
            {
                int height = 0;
                this.isPopulating = true;
                this.NotificationContainerPanel.Visible = false;
                this.flowLayoutPanel1.Controls.Clear();

                DataTable products = Producto.getWrongProducts();

                foreach (DataRow row in products.Rows)
                {
                    //PARECE SER QUE SE DIVIDIO EN DOS EL TASK. JUNTARLO SI LLEGA A FALLAR
                    Func<Panel> function = (Func<Panel>)(() => this.createEventsForAgenda(row));
                    Panel p = await Task.Run<Panel>(function);

                    this.flowLayoutPanel1.Controls.Add(p);
                    p.Width = p.Parent.Width;
                    height += p.Height;
                }
                this.NotificationContainerPanel.Visible = true;
                this.isPopulating = false;

                //flowLayoutPanel1.VerticalScroll.Visible = reminderList.Length > 0 && height > flowLayoutPanel1.Height;

            }
        }

        private Panel createEventsForAgenda(DataRow row)
        {

            Panel containerPanel = new Panel();
            containerPanel.Name = row["Código de Barras"].ToString();
            containerPanel.BackColor = Color.Transparent;
            containerPanel.Size = new Size(this.NotificationPanel.Width, this.NotificationContainerPanel.Height / 5);
            Panel panel1 = new Panel();
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Left;
            panel1.Size = new Size(this.NotificationContainerPanel.Width / 4, this.NotificationContainerPanel.Height / 4);
            panel1.Padding = new Padding(5);

            BunifuSeparator bunifuSeparator = new BunifuSeparator();
            bunifuSeparator.LineThickness = 3;
            bunifuSeparator.Height = 3;
            bunifuSeparator.LineColor = Color.Yellow;

            var p = new Producto(row["Código de Barras"].ToString());
            panel1.Controls.Add(new PictureBox()
            {
                Image = p.image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = p.image != null ? Color.White : Color.Transparent
            });

            bunifuSeparator.BringToFront();
            Panel panel2 = new Panel();

            panel2.BackColor = Color.Transparent;
            panel2.Dock = DockStyle.Fill;


            Label label2 = new Label();
            label2.Dock = DockStyle.Top;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Yellow;
            label2.Font = new Font("century gothic", 20f, FontStyle.Bold);
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.AutoSize = false;
            label2.Size = new Size(100, panel2.Height / 2);
            label2.Text = row["Descripción"].ToString();

            Label label3 = new Label();
            label3.Dock = DockStyle.Fill;
            label3.BackColor = Color.FromArgb(0, Color.White);
            label3.ForeColor = Color.White;
            label3.Font = new Font("century gothic", 20f, FontStyle.Bold);
            label3.TextAlign = ContentAlignment.TopLeft;
            label3.AutoSize = false;
            label3.Text = row["Marca"].ToString();
            panel2.Controls.Add((Control)label2);
            panel2.Controls.Add((Control)label3);
            label3.BringToFront();


            containerPanel.Controls.Add((Control)panel1);
            containerPanel.Controls.Add((Control)panel2);


            panel2.BringToFront();



            containerPanel.Controls.Add(bunifuSeparator);
            bunifuSeparator.Dock = DockStyle.Bottom;


            label2.DoubleClick += (s, e) =>
            openProduct((s as Label).Parent.Parent.Name);

            label3.DoubleClick += (s, e) =>
            openProduct((s as Label).Parent.Parent.Name);

            containerPanel.DoubleClick += (s, e) =>
            openProduct((s as Panel).Parent.Name);

            panel1.Controls[0].DoubleClick += (s, e) =>
             openProduct((s as PictureBox).Parent.Parent.Name);


            label2.MouseEnter += (s, e) =>
         mouseEnter((s as Label).Parent.Parent);

            label3.MouseEnter += (s, e) =>
            mouseEnter((s as Label).Parent.Parent);

            containerPanel.MouseEnter += (s, e) =>
            mouseEnter((s as Panel).Parent);

            panel1.Controls[0].MouseEnter += (s, e) =>
             mouseEnter((s as PictureBox).Parent.Parent);


            label2.MouseLeave += (s, e) =>
     mouseLeave((s as Label).Parent.Parent);

            label3.MouseLeave += (s, e) =>
            mouseLeave((s as Label).Parent.Parent);

            containerPanel.MouseLeave += (s, e) =>
            mouseLeave((s as Panel).Parent);

            panel1.Controls[0].MouseLeave += (s, e) =>
             mouseLeave((s as PictureBox).Parent.Parent);

            return containerPanel;
        }

        private void mouseLeave(Control control)
        {
            control.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void mouseEnter(Control control)
        {
            control.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void openProduct(string barcode)
        {
            Form_Agregar form = new Form_Agregar(new Producto(barcode));
            if (form.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control.Name == barcode)
                    {
                        flowLayoutPanel1.Controls.Remove(control);
                        break;
                    }
                }
            }
        }

        private void AgendaEventsPanel_Resize(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Height = this.NotificationPanel.Height;
        }

        private void startShiftBtn_Click(object sender, EventArgs e)
        {
            this.startNewShift();
        }

        private void startNewShift()
        {
            FormNewShift formNewShift = new FormNewShift(new Empleado(this.employeeID).isAdmin);
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (formNewShift.ShowDialog() == DialogResult.OK)
            {
                Turno.start(DateTime.Now, formNewShift.Cash, this.employeeID);
                this.startShiftBtn.Hide();
                this.button2.Hide();
                this.endShiftBtn.Show();
                endShiftBtn.Enabled = true;
                this.setGroupBoxInfo();
            }
            darkForm.Close();
        }

        private async void endShiftBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea hacer el corte de caja?", "Corte de caja", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            endShiftBtn.Enabled = false;
            button1.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            DataTable dt = await Task.Run(() => Turno.endShift(this.employeeID));

            this.printDocument1 = new PrintDocument();
            printDocument1.PrintController = new StandardPrintController();

            this.printDocument1.PrintPage += (ss, ee) =>
            {
                DataRow row = dt.Rows[0];
                PrinterTicket printerTicket = new PrinterTicket();

                this.printDocument1.PrinterSettings.PrinterName = printerTicket.printerName;

                Graphics graphics = ee.Graphics;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                int width = (int)this.printDialog1.PrinterSettings.DefaultPageSettings.PrintableArea.Width; //this.printDocument1.DefaultPageSettings.PaperSize.Width;
                int y = 0;
                if (printerTicket.logoDisplay && printerTicket.logo != null)
                {
                    Bitmap bitmap = printerTicket.logo != null ? new Bitmap(printerTicket.logo, width, printerTicket.logoHeight) : (Bitmap)null;
                    bitmap.SetResolution((float)width, (float)printerTicket.logoHeight);
                    graphics.DrawImage((Image)bitmap, 0, y, width, printerTicket.logoHeight);
                    y += printerTicket.logoHeight + 10;
                }
                if (printerTicket.headderDisplay)
                {
                    y += printingClass.printLine(printerTicket.header, printerTicket.headerFont,
                        width, StringAlignment.Center, graphics, y) + 1;
                }
                string str = "Corte de Caja";
                Font font = new Font("times new roman", 18f, FontStyle.Bold);
                y += printingClass.printLine(str, font, width, StringAlignment.Center, graphics, y) + 1;

                var startingTime = Turno.startingDate;
                str = string.Format("Periodo del Turno: {0} {1} - {2} {3}", startingTime.Date.ToShortDateString(), startingTime.ToShortTimeString(),
                    DateTime.Now.Date.ToShortDateString(), DateTime.Now.ToShortTimeString());

                font = width > 200 ? new Font("Times new Roman", 9.9f, FontStyle.Bold) : new Font("Times new Roman", 7f, FontStyle.Bold);
                y += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y) + 3;

                str = "Comenzó el turno: " + new Empleado(Convert.ToInt32(row["Empleado que Inició"])).name;
                y += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y) + 1;

                str = "Realizó corte de caja: " + new Empleado(this.employeeID).name;
                y += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y) + 15;


                for (int index = 0; index < 9; ++index)
                {
                    font = width > 200 ? new Font("Times new Roman", 9.9f) : new Font("Times new Roman", 7f);
                    str = dt.Columns[index].ColumnName;
                    y += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y) + 1;

                    font = width > 200 ? new Font("Times new Roman", 9.9f, FontStyle.Bold) : new Font("Times new Roman", 7f, FontStyle.Bold);
                    str = row[index].ToString();
                    str = index > 0 ? str.Substring(1) : str;
                    str = Convert.ToDouble(str) > 0.0 ? string.Format("{0}", row[index]) :
                    string.Format("{0}", row[index]);
                    y += printingClass.printLine(str, font, width, StringAlignment.Near, graphics, y) + 5;

                }
            };

            this.endShiftBtn.Hide();
            this.button2.Show();
            DarkForm darkForm = new DarkForm();
            panelInicio_finDeTurno inicioFinDeTurno = new panelInicio_finDeTurno(Convert.ToDouble(dt.Rows[0]["Efectivo a Entregar"].ToString().Substring(1)));
            darkForm.Show();
            try
            {
                this.printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                this.printDialog1.Document = this.printDocument1;
                this.printDocument1.Print();
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }
            inicioFinDeTurno.ShowDialog();

            darkForm.Close();

            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            setDatagridviewFontSize();
            resizeColumns();
        }

        private void setDatagridviewFontSize()
        {
            var prop = Properties.Settings.Default;
            dataGridView1.DefaultCellStyle.Font = new Font("century gothic", prop.PanelInicio_DGVFont - 2, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("century gothic", prop.PanelInicio_DGVFont, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("century gothic", prop.PanelInicio_DGVFont - 2, FontStyle.Bold);
        }

        private void resizeColumns()
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["motivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Turno.shiftActive)
                return;
            DarkForm darkForm = new DarkForm();
            Form_Login formLogin = new Form_Login(string.Format("Verificación De\nUsuario"));
            FormShiftAddMoney formShiftAddMoney = new FormShiftAddMoney();

            darkForm.Show();
            formLogin.ShowDialog();

            Empleado empleado = new Empleado(formLogin.ID);


            if (formLogin.DialogResult == DialogResult.OK && empleado.isAdmin)
            {
                if (formShiftAddMoney.ShowDialog() == DialogResult.OK)
                {
                    //<<< step1 >>> --Start
                    //When outputting to a printer,a mouse cursor becomes like a hourglass.


                    try
                    {
                        if (m_Drawer != null)
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
                        else
                        {
                            useDefaultPrinter();
                        }
                    }
                    catch (Exception)
                    {
                        if (m_Drawer != null)
                        {
                            m_Drawer.Release();
                            m_Drawer.Close();
                        }
                        useDefaultPrinter();
                    }
                    //<<<step1>>>--End

                    Turno.AddCashToDrawer(empleado.ID, formShiftAddMoney.cash, formShiftAddMoney.reason);
                    MessageBox.Show("Se realizó correctamente");
                    this.setGroupBoxInfo();
                }
            }
            else if (formLogin.DialogResult == DialogResult.OK && !empleado.isAdmin && formLogin.ID > -1)
            {
                MessageBox.Show("No tiene los permisos necesarios para realizar esta acción");
            }
            darkForm.Close();
        }

        private void useDefaultPrinter()
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintController = new StandardPrintController();
                printDocument.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                this.printDialog1.Document = printDocument;
                printDocument.Print();
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Registre una impresora para poder abrir el cajón automaticamente", "No se ha registrado impresora");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Inicio_FormClosing(object sender, FormClosingEventArgs e)
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

            dispose.DisposeControls(this);
        }

        private void Panel_Inicio_Resize(object sender, EventArgs e)
        {
            /*var resolution = Screen.PrimaryScreen.Bounds;
            if (resolution == new Rectangle(0, 0, 1366, 768))
            {*/
            NotificationContainerPanel.Width = (this.Width - 50) / 2;
            NotificationContainerPanel.Height = this.Height - NotificationContainerPanel.Location.Y - 20;
            NotificationContainerPanel.Location = new Point((this.Width / 2 - NotificationContainerPanel.Width) / 2,
                    NotificationContainerPanel.Location.Y);

            shiftPanel.Width = (this.Width - 50) / 2;
            shiftPanel.Height = this.Height - shiftPanel.Location.Y - 20;
            shiftPanel.Location = new Point(this.Width / 2 + (this.Width / 2 - shiftPanel.Width) / 2, shiftPanel.Location.Y);
            /* 
         }*/
        }

        private void Panel_Inicio_MouseWheel(object sender, MouseEventArgs e)
        {
            if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftCtrl))
            {
                var prop = Properties.Settings.Default;

                float value = prop.PanelInicio_DGVFont + e.Delta / 50;

                setNewFontValue(value);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Add) || keyData == (Keys.Control | Keys.Oemplus))
            {
                float value = Properties.Settings.Default.PanelInicio_DGVFont + 1;
                setNewFontValue(value);
            }
            if (keyData == (Keys.Control | Keys.OemMinus) || keyData == (Keys.Control | Keys.Subtract))
            {
                setNewFontValue(Properties.Settings.Default.PanelInicio_DGVFont - 1);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void setNewFontValue(float fontSize)
        {
            if (fontSize > 8.5 && fontSize < 30)
            {
                Properties.Settings.Default.PanelInicio_DGVFont = fontSize;
                Properties.Settings.Default.Save();

                setDatagridviewFontSize();
            }
        }
    }
}
