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

namespace POS
{
    public partial class Panel_Inicio : Form
    {
        private Timer time;
        private int employeeID;
        private DateTime date;
        private CashDrawer m_Drawer;

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
            this.populateAgenda(DateTime.Now);
            this.Size = size;
           // this.AgendaEventsPanel.Parent =this.agendaBackgrountPictureBox;
            //this.AgendaHeaderPanel.Parent = this.agendaBackgrountPictureBox;
          //  this.AgendaEventsPanel.BackColor = Color.FromArgb(155, Color.White);
            //this.flowLayoutPanel1.BackColor = Color.FromArgb(180, 0, 130, 170);
            this.flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            this.flowLayoutPanel1.AutoScroll = false;
            this.flowLayoutPanel1.VerticalScroll.Visible = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.time = timer;
            this.time.Interval = 1000;
            this.time.Tick += new EventHandler(this.highlightEvents);
            this.time.Enabled = true;
            this.endShiftBtn.Visible = Turno.shiftActive;
            this.startShiftBtn.Visible = !Turno.shiftActive;
            this.employeeID = empID;
            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.date = DateTime.Now;
            this.DateLbl.Text = this.date.ToShortDateString();
            this.printDialog1.PrinterSettings.PrinterName = new PrinterTicket().printerName;
        }
        ~Panel_Inicio()
        {
            this.time.Stop();
            this.time.Dispose();
        }

        private void highlightEvents(object sender, EventArgs e)
        {
            if (!(this.date.Date == DateTime.Now.Date))
                return;
            foreach (Control control in (ArrangedElementCollection)this.flowLayoutPanel1.Controls)
            {
                Recordatorio recordatorio = new Recordatorio(Convert.ToInt32(control.Name));
                TimeSpan timeSpan1 = recordatorio.StartTime - recordatorio.StartTime.Date;
                TimeSpan timeSpan2 = recordatorio.EndTime - recordatorio.EndTime.Date;
                TimeSpan timeSpan3 = DateTime.Now - DateTime.Now.Date;
                control.BackColor = !(timeSpan1 <= timeSpan3) || !(timeSpan2 >= timeSpan3) ? Color.FromArgb(50, 64, 64, 64) : Color.FromArgb(90, Color.AliceBlue);
            }
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

        private async void populateAgenda(DateTime time)
        {
            if (this.isPopulating)
                return;
            else
            {
                int height = 0;
                this.isPopulating = true;
                this.agendaContainerPanel.Visible = false;
                this.flowLayoutPanel1.Controls.Clear();
                int[] reminderList = Recordatorio.getReminderIDsForDate(time); 
                List<Panel> panelList = new List<Panel>();
                foreach (int num in reminderList)
                {
                    int id = num;

                    //PARECE SER QUE SE DIVIDIO EN DOS EL TASK. JUNTARLO SI LLEGA A FALLAR
                    Func<Panel> function = (Func<Panel>)(() => this.createEventsForAgenda(id));
                    Panel p = await Task.Run<Panel>(function);
                    
                    this.flowLayoutPanel1.Controls.Add(p);
                    p.Width = p.Parent.Width;
                    height += p.Height;
                }
                //Esto quien sabe que pex
                //bool flag;
                //int num1 = flag ? 1 : 0;
                this.agendaContainerPanel.Visible = true;
                this.isPopulating = false;

                flowLayoutPanel1.VerticalScroll.Visible = reminderList.Length > 0 && height > flowLayoutPanel1.Height;

            }
        }

        private Panel createEventsForAgenda(int id)
        {
            Recordatorio reminder = new Recordatorio(id);
            Panel containerPanel = new Panel();
            containerPanel.Name = reminder.ID.ToString();
            containerPanel.BackColor = Color.Transparent;
            containerPanel.Size = new Size(this.AgendaEventsPanel.Width, this.agendaContainerPanel.Height / 5);
            Panel panel1 = new Panel();
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Left;
            panel1.Size = new Size(this.agendaContainerPanel.Width / 4, this.agendaContainerPanel.Height / 4);
            BunifuSeparator bunifuSeparator = new BunifuSeparator();
            bunifuSeparator.LineThickness = 3;
            bunifuSeparator.Height = 3;
            bunifuSeparator.LineColor = Color.Yellow;
            Label label1 = new Label();
            label1.ForeColor = Color.White;
            label1.Font = new Font("century gothic", 20f, FontStyle.Bold);
            label1.AutoSize = false;
            string str1 = string.Format("{0}:{1} {2}", (object)reminder.StartTime.Hour.ToString("D2"), (object)reminder.StartTime.Minute.ToString("D2"), reminder.StartTime.TimeOfDay > new TimeSpan(12, 0, 0) ? (object)"P.M." : (object)"A.M.");
            string str2 = string.Format("{0}:{1} {2}", (object)reminder.EndTime.Hour.ToString("D2"), (object)reminder.EndTime.Minute.ToString("D2"), reminder.EndTime.TimeOfDay > new TimeSpan(12, 0, 0) ? (object)"P.M." : (object)"A.M.");
            label1.Text = string.Format("{0}\n-\n{1}", (object)str1, (object)str2);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            panel1.Controls.Add((Control)label1);
            panel1.Controls.Add((Control)bunifuSeparator);
            label1.Dock = DockStyle.Fill;
            bunifuSeparator.Width = TextRenderer.MeasureText(label1.Text, label1.Font).Width;
            Size stringSize = PrinterTicket.getStringSize(label1.Text, label1.Font);
            bunifuSeparator.Location = new Point((bunifuSeparator.Parent.Width - bunifuSeparator.Width) / 2, label1.Height / 2 + stringSize.Height / 2 - 3);
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
            label2.Text = new Proveedor(reminder.ID_Supplier).NombreEmpresa;
            Label label3 = new Label();
            label3.Dock = DockStyle.Fill;
            label3.BackColor = Color.FromArgb(0, Color.White);
            label3.ForeColor = Color.White;
            label3.Font = new Font("century gothic", 12f, FontStyle.Bold);
            label3.TextAlign = ContentAlignment.TopLeft;
            label3.AutoSize = false;
            label3.Text = reminder.Message;
            panel2.Controls.Add((Control)label2);
            panel2.Controls.Add((Control)label3);
            label3.BringToFront();
            containerPanel.Controls.Add((Control)panel1);
            containerPanel.Controls.Add((Control)panel2);
            panel2.BringToFront();
            label1.DoubleClick += (EventHandler)((s, e) =>
            {
                DarkForm darkForm = new DarkForm();
                PanelProveedoresNuevoRecordatorio nuevoRecordatorio = new PanelProveedoresNuevoRecordatorio(containerPanel.BackColor, reminder.Erasable, new Empleado(this.employeeID).isAdmin, true);
                nuevoRecordatorio.time = reminder.StartTime.Hour;
                DateTime startTime = reminder.StartTime;
                nuevoRecordatorio.HalfHour = startTime.Minute > 0;
                nuevoRecordatorio.SupplierID = reminder.ID_Supplier;
                nuevoRecordatorio.reminderID = reminder.ID;
                nuevoRecordatorio.date = reminder.StartTime.Date;
                nuevoRecordatorio.headerTitle = "Modificar Recordatorio";
                nuevoRecordatorio.eventName = reminder.Message;
                nuevoRecordatorio.endtime = reminder.EndTime.Hour;
                nuevoRecordatorio.endDate = reminder.EndTime;
                DateTime endTime = reminder.EndTime;
                nuevoRecordatorio.EndTimeHalfHour = endTime.Minute > 0;
                nuevoRecordatorio.repetingDays = reminder.RepeatingDays;
                darkForm.Show();
                if (nuevoRecordatorio.ShowDialog() == DialogResult.OK)
                    this.populateAgenda(DateTime.Now);
                darkForm.Close();
            });
            label2.DoubleClick += (EventHandler)((s, e) =>
            {
                DarkForm darkForm = new DarkForm();
                PanelProveedoresNuevoRecordatorio nuevoRecordatorio = new PanelProveedoresNuevoRecordatorio(containerPanel.BackColor, reminder.Erasable, new Empleado(this.employeeID).isAdmin, true);
                nuevoRecordatorio.time = reminder.StartTime.Hour;
                DateTime startTime = reminder.StartTime;
                nuevoRecordatorio.HalfHour = startTime.Minute > 0;
                nuevoRecordatorio.SupplierID = reminder.ID_Supplier;
                nuevoRecordatorio.reminderID = reminder.ID;
                nuevoRecordatorio.date = reminder.StartTime.Date;
                nuevoRecordatorio.headerTitle = "Modificar Recordatorio";
                nuevoRecordatorio.eventName = reminder.Message;
                nuevoRecordatorio.endtime = reminder.EndTime.Hour;
                nuevoRecordatorio.endDate = reminder.EndTime;
                DateTime endTime = reminder.EndTime;
                nuevoRecordatorio.EndTimeHalfHour = endTime.Minute > 0;
                nuevoRecordatorio.repetingDays = reminder.RepeatingDays;
                darkForm.Show();
                if (nuevoRecordatorio.ShowDialog() == DialogResult.OK)
                    this.populateAgenda(DateTime.Now);
                darkForm.Close();
            });
            label3.DoubleClick += (EventHandler)((s, e) =>
            {
                DarkForm darkForm = new DarkForm();
                PanelProveedoresNuevoRecordatorio nuevoRecordatorio = new PanelProveedoresNuevoRecordatorio(containerPanel.BackColor, reminder.Erasable, new Empleado(this.employeeID).isAdmin, true);
                nuevoRecordatorio.time = reminder.StartTime.Hour;
                DateTime startTime = reminder.StartTime;
                nuevoRecordatorio.HalfHour = startTime.Minute > 0;
                nuevoRecordatorio.SupplierID = reminder.ID_Supplier;
                nuevoRecordatorio.reminderID = reminder.ID;
                nuevoRecordatorio.date = reminder.StartTime.Date;
                nuevoRecordatorio.headerTitle = "Modificar Recordatorio";
                nuevoRecordatorio.eventName = reminder.Message;
                nuevoRecordatorio.endtime = reminder.EndTime.Hour;
                nuevoRecordatorio.endDate = reminder.EndTime;
                DateTime endTime = reminder.EndTime;
                nuevoRecordatorio.EndTimeHalfHour = endTime.Minute > 0;
                nuevoRecordatorio.repetingDays = reminder.RepeatingDays;
                darkForm.Show();
                if (nuevoRecordatorio.ShowDialog() == DialogResult.OK)
                    this.populateAgenda(DateTime.Now);
                darkForm.Close();
            });
            return containerPanel;
        }

        private void AgendaEventsPanel_Resize(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Height = this.AgendaEventsPanel.Height;
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
                this.setGroupBoxInfo();
            }
            darkForm.Close();
        }

        private void endShiftBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea hacer el corte de caja?", "Corte de caja", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
          
            DataTable dt = Turno.endShift(this.employeeID);
            
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
                int y = 10;
                if (printerTicket.logoDisplay && printerTicket.logo != null)
                {
                    Bitmap bitmap = printerTicket.logo != null ? new Bitmap(printerTicket.logo, width, printerTicket.logoHeight) : (Bitmap)null;
                    bitmap.SetResolution((float)width, (float)printerTicket.logoHeight);
                    graphics.DrawImage((Image)bitmap, 0, y, width, printerTicket.logoHeight);
                    y += printerTicket.logoHeight + 10;
                }
                if (printerTicket.headderDisplay)
                {
                    Size stringSize = PrinterTicket.getStringSize(printerTicket.header, printerTicket.headerFont);
                    graphics.DrawString(printerTicket.header, printerTicket.headerFont, Brushes.Black, (float)((width - stringSize.Width) / 2), (float)y);
                    y += stringSize.Height + 10;
                }
                string str1 = "Corte de Caja";
                Font font1 = PrinterTicket.getFont(str1, width, FontStyle.Regular);
                Size stringSize1 = PrinterTicket.getStringSize(str1, font1);
                graphics.DrawString(str1, font1, Brushes.Black, (float)((width - stringSize1.Width) / 2), (float)y);
                int num1 = y + (15 + stringSize1.Height);
                string str2 = "Comenzó el turno: " + new Empleado(Convert.ToInt32(row["Empleado que Inició"])).name;
                Font font2 = new Font("Times new roman", 6f, FontStyle.Bold);
                Size stringSize2 = PrinterTicket.getStringSize(str2, font2);
                graphics.DrawString(str2, font2, Brushes.Black, 0.0f, (float)num1);
                int num2 = num1 + (stringSize2.Height + 1);
                string str3 = "Realizó corte de caja: " + new Empleado(this.employeeID).name;
                Size stringSize3 = PrinterTicket.getStringSize(str3, font2);
                graphics.DrawString(str3, font2, Brushes.Black, 0.0f, (float)num2);
                int num3 = num2 + (stringSize3.Height + 5);
                Font font3 = new Font("Times new roman", 8f);
                for (int index = 0; index < 8; ++index)
                {
                    string str4 = Convert.ToDouble(row[index]) > 0.0 ? string.Format("{0}: \n${1}", (object)dt.Columns[index].ColumnName, (object)Convert.ToDouble(row[index]).ToString("n2")) : string.Format("{0}: \n-${1}", (object)dt.Columns[index].ColumnName, (object)Math.Abs(Convert.ToDouble(row[index])).ToString("n2"));
                    Size stringSize4 = PrinterTicket.getStringSize(str4, font3);
                    graphics.DrawString(str4, font3, Brushes.Black, 0.0f, (float)num3);
                    num3 += stringSize4.Height + 2;
                }
            };
            this.endShiftBtn.Hide();
            this.button2.Show();
            DarkForm darkForm = new DarkForm();
            panelInicio_finDeTurno inicioFinDeTurno = new panelInicio_finDeTurno(Convert.ToDouble(dt.Rows[0]["Efectivo en Caja"]));
            darkForm.Show();
            try
            {
                this.printDocument1.PrinterSettings.PrinterName = this.printDialog1.PrinterSettings.PrinterName;
                this.printDialog1.Document = this.printDocument1;
                this.printDocument1.Print();
            }
            catch (InvalidPrinterException)
            {
                int num = (int)MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }
            int num4 = (int)inicioFinDeTurno.ShowDialog();
            darkForm.Close();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.resizeColumns();
            dataGridView1.Sort(dataGridView1.Columns["Fecha"], ListSortDirection.Ascending);
        }

        private void resizeColumns()
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;
            this.dataGridView1.Columns["Nombre"].Width = (int)((double)this.dataGridView1.Width * 0.3);
            this.dataGridView1.Columns["Añadió"].Width = (int)((double)this.dataGridView1.Width * 0.3);
            this.dataGridView1.Columns["Fecha"].Width = (int)((double)this.dataGridView1.Width * 0.4);
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

                        useDefaultPrinter();
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

                    Turno.AddCashToDrawer(empleado.ID, formShiftAddMoney.cash);
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

   

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddDays(-1.0);
            this.DateLbl.Text = this.date.ToShortDateString();
            this.populateAgenda(this.date);
        }

        private void goFurtherBtn_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddDays(1.0);
            this.DateLbl.Text = this.date.ToShortDateString();
            this.populateAgenda(this.date);

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
        }
    }
}
