using Bunifu.Framework.UI; 
using word =Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.PointOfService;
using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace POS
{
    public partial class Panel_proveedores_Form : Form
    {
        private List<string> OriginalColumnHeaderIndexes;
        private bool showActionPannelForDataGridView;
        private Proveedor proveedor;
        private int EmployeeID;
        bool settingCurrentRow;
        CashDrawer m_Drawer;
        supplierProductsToolTip tip = new supplierProductsToolTip();
        private int currentSupplierButon = 0;
        

        private enum Direction
        {
            Vertical,
            Horizontal,
            Both,
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 33554432;
                return createParams;
            }
        }

        public Panel_proveedores_Form(int EmployeeID, FormWindowState windowState = FormWindowState.Normal)
        {
            this.InitializeComponent();
            this.WindowState = windowState;
            this.SuppliersPanel.Dock = DockStyle.Fill;
            this.dataGridView1.MouseDown += new MouseEventHandler(this.dataGridView1_MouseDown);
            this.proveedor = new Proveedor();
            this.showActionPannelForDataGridView = true;
            this.OriginalColumnHeaderIndexes = new List<string>();

            this.timer = new Timer();

            var employee = new Empleado(EmployeeID);
            this.EmployeeID = employee.ID;
            this.AddNewCustomerBtn.Visible = employee.isAdmin;

            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            SearchSupplierTxt.Focus();

            var comboColumn = dataGridView2.Columns["depot"] as DataGridViewComboBoxColumn;

            comboColumn.DataSource = Bodega.GetDepots();
            comboColumn.DisplayMember = "Nombre";
            comboColumn.ValueMember = "ID_Bodega";

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 15.75f, FontStyle.Bold);

            purchaseChart = new LiveCharts.WinForms.CartesianChart() { Visible = false };
            panel2.Controls.Add(purchaseChart);
            purchaseChart.Visible = true;
            purchaseChart.Dock = DockStyle.Fill;
        }

        private void Panel_proveedores_Form_Load(object sender, EventArgs e)
        {
            this.LoadingSupplierListBar.Location = new Point(this.SuppliersPanel.Width / 2 - this.LoadingSupplierListBar.Width / 2, this.SuppliersPanel.Height / 2 - this.LoadingSupplierListBar.Height / 2);
            this.loadSupplierList();

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 15.75f, FontStyle.Bold);

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

            SearchSupplierTxt.Select();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            if (this.showActionPannelForDataGridView)
            {
                this.DataGridCardControlPanel.Show();
                this.showActionPannelForDataGridView = false;
            }
            else
            {
                this.DataGridCardControlPanel.Hide();
                this.showActionPannelForDataGridView = true;
            }
        }

        private async void loadSupplierList()
        {
            this.LoadingSupplierListBar.Visible = true;
            this.LoadingSupplierListBar.Style = ProgressBarStyle.Marquee;

            this.flow1.Controls.AddRange(await Task.Run(() => this.PopulateContainer()));

            await Task.Run(() =>
            {
                foreach (var file in new DirectoryInfo(Directory.GetCurrentDirectory() + @"\Suppliers\").GetFiles("*.bmp"))
                {
                    bool delete = true;

                    foreach (DataRow supplier in proveedor.GetSupplierList().Rows)
                    {
                        if (file.Name.IndexOf(supplier[1].ToString() + supplier[0].ToString()) > -1)
                        {
                            delete = false;
                            break;
                        }
                    }
                    if (delete)
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception) { }
                    }
                }
            });

            foreach (Control control in this.flow1.Controls)
            {
                new BunifuElipse()
                {
                    ElipseRadius = 20,
                    TargetControl = control
                }.ApplyElipse();
            }
            this.flow1.AutoScroll = true;
            this.flow1.Visible = true;
            this.flow1.Dock = DockStyle.Fill;
            this.LoadingSupplierListBar.Visible = false;
            FlowContainerPanel.Visible = true;
        }

        private Control[] PopulateContainer()
        {
            DataTable supplierList = new Proveedor().GetSupplierList();
            Control[] controlArray = new Control[supplierList.Rows.Count];

            int index = 0;
            
            foreach (DataRow row in supplierList.Rows)
            {
                BunifuImageButton bunifuImageButton = new BunifuImageButton();
                bunifuImageButton.Name = row[1].ToString() + "," + row[0].ToString();
                bunifuImageButton.Click += new EventHandler(this.SupplierbuttonClick);
                bunifuImageButton.Size = new Size(500, 300);
                bunifuImageButton.Zoom = 0;

                bunifuImageButton.GotFocus += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(275,165);
                }; 

                bunifuImageButton.LostFocus += (s, e) =>
                  {
                      var button = s as BunifuImageButton;
                      button.Size = new Size(250, 150);
                  };

                bunifuImageButton.MouseEnter += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(275,165);
                };


                bunifuImageButton.MouseLeave += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(250, 150);
                };

                bunifuImageButton.Size = new Size(250, 150);
                bunifuImageButton.Margin = new Padding(this.SuppliersPanel.Width / 6 - bunifuImageButton.Width);
                bunifuGradientPanel1.Padding = new Padding(50);

                if (File.Exists(Directory.GetCurrentDirectory() + @"\Suppliers\" + row[1].ToString() + row[0].ToString() + ".bmp"))
                {
                    Image image = new Bitmap(Directory.GetCurrentDirectory() + @"\Suppliers\" + row[1].ToString() + row[0].ToString() + ".bmp");
                    bunifuImageButton.Image = image;
                }
                else
                {
                    try
                    {
                        Image image = this.createCard(row[0].ToString());
                        bunifuImageButton.Image = image;
                        image.Save(Directory.GetCurrentDirectory() + @"\Suppliers\" + row[1].ToString() + row[0].ToString() + ".bmp");
                    }
                    catch(Exception e)
                    {
                    }
                }


                this.AddSupplierToolTip.SetToolTip(bunifuImageButton, row[0].ToString());
                controlArray[index] = bunifuImageButton;
                ++index;
            }
            return controlArray;
        }

        private Control[] PopulateContainer(string search)
        {
            DataTable supplierList = Proveedor.GetSupplierList(search);
            Control[] controlArray = new Control[supplierList.Rows.Count];

            int index = 0;

            foreach (DataRow row in supplierList.Rows)
            {
                BunifuImageButton bunifuImageButton = new BunifuImageButton();
                bunifuImageButton.Name = row[1].ToString() + "," + row[0].ToString();
                bunifuImageButton.Click += new EventHandler(this.SupplierbuttonClick);
                bunifuImageButton.Size = new Size(500, 300);
                bunifuImageButton.Zoom = 0;

                bunifuImageButton.GotFocus += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(275, 165);
                };

                bunifuImageButton.LostFocus += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(250, 150);
                };

                bunifuImageButton.MouseEnter += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(275, 165);
                };


                bunifuImageButton.MouseLeave += (s, e) =>
                {
                    var button = s as BunifuImageButton;
                    button.Size = new Size(250, 150);
                };

                bunifuImageButton.Size = new Size(250, 150);
                bunifuImageButton.Margin = new Padding(this.SuppliersPanel.Width / 6 - bunifuImageButton.Width);
                bunifuGradientPanel1.Padding = new Padding(50);

                if (File.Exists(Directory.GetCurrentDirectory() + @"\Suppliers\" + row[1].ToString() + row[0].ToString() + ".bmp"))
                {
                    Image image = new Bitmap(Directory.GetCurrentDirectory() + @"\Suppliers\" + row[1].ToString() + row[0].ToString() + ".bmp");
                    bunifuImageButton.Image = image;
                }
                else
                {
                    Image image = this.createCard(row[0].ToString());
                    bunifuImageButton.Image = image;
                    image.Save(Directory.GetCurrentDirectory() + @"\Suppliers\" + row[1].ToString() + row[0].ToString() + ".bmp");
                }


                this.AddSupplierToolTip.SetToolTip(bunifuImageButton, row[0].ToString());
                controlArray[index] = bunifuImageButton;
                ++index;
            }
            return controlArray;
        }

        private Bitmap createCard(string name)
        {
            List<string> stringList = new List<string>();
            BunifuGradientPanel bunifuGradientPanel = new BunifuGradientPanel();
            bunifuGradientPanel.Size = new Size(500, 300);
            bunifuGradientPanel.Name = "card";
            Color color = this.getColor(name);
            bunifuGradientPanel.GradientBottomLeft = color;
            bunifuGradientPanel.GradientBottomRight = Color.Gray;
            bunifuGradientPanel.GradientTopLeft = color;
            bunifuGradientPanel.GradientTopRight = Color.FromArgb(60, 60, 66);
            if (name.Length > 10 && name.IndexOf(' ') > 0)
            {
                List<string> source = this.splitString(name);
                int count = source.Count;
                string Controltext1;
                string Controltext2 = Controltext1 = "";
                for (int index = 0; index < count; ++index)
                {
                    if (index < count / 2)
                        Controltext2 = Controltext2 + source.ElementAt<string>(index) + " ";
                    else
                        Controltext1 = Controltext1 + source.ElementAt<string>(index) + " ";
                }
                Label text = new Label();
                this.fillLabel(text, "CompanyNameTxt", Controltext2, Color.FromArgb(0, 0, 0), Color.Transparent, 0);
                Label label = new Label();
                this.fillLabel(label, "CompanyNameTxt2", Controltext1, Color.Black, Color.Transparent, 1);
                this.fitFont(text, label, 25, bunifuGradientPanel.Width, bunifuGradientPanel.Height);
                bunifuGradientPanel.Controls.Add((Control)text);
                bunifuGradientPanel.Controls.Add((Control)label);
                bunifuGradientPanel.Location = new Point(0, 0);
                Bitmap bitmap = new Bitmap(bunifuGradientPanel.Width, bunifuGradientPanel.Height);
                bunifuGradientPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                text.Dispose();
                bunifuGradientPanel.Dispose();
                return bitmap;
            }
            Label label1 = new Label();
            this.fillLabel(label1, "CompanyNameTxt", name, Color.Black, Color.Transparent, 0);
            this.fitFont(label1, 25, bunifuGradientPanel.Width, bunifuGradientPanel.Height);
            bunifuGradientPanel.Controls.Add((Control)label1);
            bunifuGradientPanel.Location = new Point(0, 0);
            Bitmap bitmap1 = new Bitmap(bunifuGradientPanel.Width, bunifuGradientPanel.Height);
            bunifuGradientPanel.DrawToBitmap(bitmap1, new Rectangle(0, 0, bitmap1.Width, bitmap1.Height));
            label1.Dispose();
            bunifuGradientPanel.Dispose();
            return bitmap1;
        }

        private Color getColor(string name)
        {
            string upper = name[0].ToString().ToUpper();
            if (upper[0] == 'A')
                return Color.FromArgb(86, 254, 236);
            if (upper[0] == 'B')
                return Color.FromArgb(83, 160, 254);
            if (upper[0] == 'C')
                return Color.FromArgb(142, 157, 213);
            if (upper[0] == 'D')
                return Color.FromArgb(83, 160, 254);
            if (upper[0] == 'E')
                return Color.FromArgb(255, 140, 78);
            if (upper[0] == 'G')
                return Color.FromArgb(194, 147, 225);
            if (upper[0] == 'H')
                return Color.FromArgb(248, 121, 133);
            if (upper[0] == 'I')
                return Color.FromArgb((int)byte.MaxValue, 113, 201);
            if (upper[0] == 'K')
                return Color.FromArgb((int)byte.MaxValue, 113, 137);
            if (upper[0] == 'L')
                return Color.SandyBrown;
            if (upper[0] == 'M')
                return Color.FromArgb((int)byte.MaxValue, 144, 84);
            if (upper[0] == 'N')
                return Color.FromArgb((int)byte.MaxValue, 207, 84);
            if (upper[0] == 'Ñ')
                return Color.FromArgb(238, (int)byte.MaxValue, 84);
            if (upper[0] == 'O')
                return Color.FromArgb(67, 242, 90);
            if (upper[0] == 'P')
                return Color.FromArgb(67, 242, 157);
            if (upper[0] == 'Q')
                return Color.FromArgb(89, 219, 213);
            if (upper[0] == 'R')
                return Color.FromArgb(89, 171, 219);
            if (upper[0] == 'S')
                return Color.FromArgb(89, 91, 219);
            if (upper[0] == 'T')
                return Color.FromArgb(171, 89, 219);
            if (upper[0] == 'U')
                return Color.FromArgb(219, 89, 178);
            if (upper[0] == 'V')
                return Color.FromArgb(219, 89, 89);
            if (upper[0] == 'W')
                return Color.FromArgb(219, 154, 89);
            if (upper[0] == 'X')
                return Color.FromArgb(171, 219, 89);
            if (upper[0] == 'Y')
                return Color.FromArgb(11, 210, 38);
            return upper[0] == 'Z' ? Color.FromArgb(11, 210, 171) : Color.Gray;
        }

        private void fitFont(
          Label label,
          int fontsize,
          int ContainerControlWidth,
          int ContainerControlHeight)
        {
            label.Font = new Font("Century Gothic", (float)fontsize, FontStyle.Bold);
            Graphics graphics = label.CreateGraphics();
            int width1 = (int)graphics.MeasureString(label.Text, label.Font).Width;
            int height1 = (int)graphics.MeasureString(label.Text, label.Font).Height;
            if (ContainerControlWidth > width1)
            {
                while (ContainerControlWidth - 10 > label.Width)
                {
                    label.Font = new Font("Century Gothic", (float)fontsize++, FontStyle.Bold);
                    int width2 = (int)graphics.MeasureString(label.Text, label.Font).Width;
                    int height2 = (int)graphics.MeasureString(label.Text, label.Font).Height;
                    label.Width = width2;
                    label.Height = height2;
                }
            }
            else
            {
                while (ContainerControlWidth < width1 + 10)
                {
                    label.Font = new Font("Century Gothic", (float)fontsize--, FontStyle.Bold);
                    width1 = (int)graphics.MeasureString(label.Text, label.Font).Width;
                    int height2 = (int)graphics.MeasureString(label.Text, label.Font).Height;
                    label.Width = width1;
                    label.Height = height2;
                }
            }
            label.AutoSize = true;
            label.Location = new Point(ContainerControlWidth / 2 - label.Width / 2, ContainerControlHeight / 2 - label.Height / 2);
        }

        private void fitFont(
          Label text,
          Label text2,
          int fontsize,
          int ContainerControlWidth,
          int ContainerControlHeight)
        {
            text.Font = new Font("Century Gothic", (float)fontsize, FontStyle.Bold);
            text2.Font = new Font("Century Gothic", (float)fontsize, FontStyle.Bold);
            Graphics graphics1 = text.CreateGraphics();
            int width1 = (int)graphics1.MeasureString(text.Text, text.Font).Width;
            int height1 = (int)graphics1.MeasureString(text.Text, text.Font).Height;
            Graphics graphics2 = text2.CreateGraphics();
            int width2 = (int)graphics2.MeasureString(text2.Text, text.Font).Width;
            int height2 = (int)graphics2.MeasureString(text2.Text, text.Font).Height;
            if (ContainerControlWidth > width1)
            {
                while (ContainerControlWidth - 10 > text.Width && ContainerControlWidth - 10 > text2.Width)
                {
                    text.Font = new Font("Century Gothic", (float)fontsize++, FontStyle.Bold);
                    text2.Font = new Font("Century Gothic", (float)fontsize++, FontStyle.Bold);
                    int width3 = (int)graphics1.MeasureString(text.Text, text.Font).Width;
                    int height3 = (int)graphics1.MeasureString(text.Text, text.Font).Height;
                    int width4 = (int)graphics2.MeasureString(text2.Text, text2.Font).Width;
                    int height4 = (int)graphics2.MeasureString(text2.Text, text2.Font).Height;
                    text.Width = width3;
                    text.Height = height3;
                    text2.Width = width4;
                    text2.Height = height4;
                }
            }
            else
            {
                while (ContainerControlWidth < width1 + 10)
                {
                    text.Font = new Font("Century Gothic", (float)fontsize--, FontStyle.Bold);
                    text2.Font = new Font("Century Gothic", (float)fontsize--, FontStyle.Bold);
                    width1 = (int)graphics1.MeasureString(text.Text, text.Font).Width;
                    int height3 = (int)graphics1.MeasureString(text.Text, text.Font).Height;
                    int width3 = (int)graphics2.MeasureString(text2.Text, text2.Font).Width;
                    int height4 = (int)graphics2.MeasureString(text2.Text, text2.Font).Height;
                    text.Width = width1;
                    text.Height = height3;
                    text2.Width = width3;
                    text2.Height = height4;
                }
            }
            text.AutoSize = true;
            text.Location = new Point(ContainerControlWidth / 2 - text.Width / 2, ContainerControlHeight / 2 - 5 - text.Height);
            text2.AutoSize = true;
            text2.Location = new Point(ContainerControlWidth / 2 - text2.Width / 2, ContainerControlHeight / 2 + 5);
        }

        private void fillLabel(
          Label text,
          string Controlname,
          string Controltext,
          Color fore,
          Color back,
          int index)
        {
            text.Name = Controlname + (object)index;
            text.Text = Controltext;
            text.ForeColor = fore;
            text.BackColor = back;
        }

        private List<string> splitString(string CompName)
        {
            List<string> stringList = new List<string>();
            int length = CompName.IndexOf(' ');
            while (length >= 0)
            {
                string str = CompName.Substring(0, length);
                CompName = CompName.Substring(length + 1);
                length = CompName.IndexOf(' ');
                stringList.Add(str);
            }
            stringList.Add(CompName);
            return stringList;
        }

        public void setPanelWidth(
          BunifuGradientPanel ChildPanel,
          BunifuCards PanelContainer,
          double WidthPercentage)
        {
            int num = (int)(Convert.ToDouble(PanelContainer.Width) * WidthPercentage);
            ChildPanel.Width = num;
        }

        public void Panel_Paint(object sender, PaintEventArgs e)
        {
            BunifuGradientPanel bunifuGradientPanel = sender as BunifuGradientPanel;
            e.Graphics.DrawLine(new Pen(Color.FromArgb(0, 130, 170))
            {
                Width = 3f
            }, new Point()
            {
                X = bunifuGradientPanel.Width - 3,
                Y = 0
            }, new Point()
            {
                X = bunifuGradientPanel.Width - 3,
                Y = bunifuGradientPanel.Height
            });
        }

        private List<Control> getControls(Control ParentControl)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control control in ParentControl.Controls)
                controlList.Add(control);
            return controlList;
        }

        private void centerControls(List<Control> controls, Panel_proveedores_Form.Direction direction)
        {
            if (controls.Count <= 1)
                return;
            int num1 = 0;
            int num2 = 0;
            Point point1;
            foreach (Control control in controls)
            {
                point1 = new Point(control.Location.X + control.Width / 2, control.Location.Y + control.Height / 2);
                num1 += point1.X;
                num2 += point1.Y;
            }
            Point point2 = new Point(num1 / controls.Count, num2 / controls.Count);
            point1 = new Point(controls[0].Parent.Width / 2, controls[0].Parent.Height / 2);
            int num3 = point1.X - point2.X;
            int num4 = point1.Y - point2.Y;
            foreach (Control control in controls)
            {
                switch (direction)
                {
                    case Panel_proveedores_Form.Direction.Vertical:
                        control.Location = new Point(control.Location.X, control.Location.Y + num4);
                        continue;
                    case Panel_proveedores_Form.Direction.Horizontal:
                        control.Location = new Point(control.Location.X + num3, control.Location.Y);
                        continue;
                    case Panel_proveedores_Form.Direction.Both:
                        control.Location = new Point(control.Location.X + num3, control.Location.Y + num4);
                        continue;
                    default:
                        continue;
                }
            }
        }

        private void domingoLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[0])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[0] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[0] = false;
            }
            this.UpdateVisitingDays();
        }

        private void LunesLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[1])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[1] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[1] = false;
            }
            this.UpdateVisitingDays();
        }

        private void martesLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[2])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[2] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[2] = false;
            }
            this.UpdateVisitingDays();
        }

        private void miercolesLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[3])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[3] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[3] = false;
            }
            this.UpdateVisitingDays();
        }

        private void juevesLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[4])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[4] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[4] = false;
            }
            this.UpdateVisitingDays();
        }

        private void viernesLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[5])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[5] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[5] = false;
            }
            this.UpdateVisitingDays();
        }

        private void sabadoLbl_Click(object sender, EventArgs e)
        {
            if (!new Empleado(this.EmployeeID).isAdmin)
                return;
            if (!this.proveedor.diasVisita[6])
            {
                (sender as Label).ForeColor = Color.Tomato;
                this.proveedor.diasVisita[6] = true;
            }
            else
            {
                (sender as Label).ForeColor = Color.DimGray;
                this.proveedor.diasVisita[6] = false;
            }
            this.UpdateVisitingDays();
        }

        private int GetMiddlePointXLocation(Control currentControl, Control NextControl)
        {
            int num1 = currentControl.Location.X + currentControl.Width;
            int num2 = (NextControl.Location.X - num1) / 2;
            return NextControl.Location.X - num2;
        }


        private DataTable filterReminders(DataTable reminderList, DateTime date)
        {
            string str1;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    str1 = "1000000";
                    break;
                case DayOfWeek.Monday:
                    str1 = "0100000";
                    break;
                case DayOfWeek.Tuesday:
                    str1 = "0010000";
                    break;
                case DayOfWeek.Wednesday:
                    str1 = "0001000";
                    break;
                case DayOfWeek.Thursday:
                    str1 = "0000100";
                    break;
                case DayOfWeek.Friday:
                    str1 = "0000010";
                    break;
                case DayOfWeek.Saturday:
                    str1 = "0000001";
                    break;
                default:
                    str1 = "0000000";
                    break;
            }
            for (int index1 = 0; index1 < reminderList.Rows.Count; ++index1)
            {
                DataRow row = reminderList.Rows[index1];
                string str2 = "";
                string str3 = row["Repetir en Dias"].ToString();
                for (int index2 = 0; index2 < str1.Length; ++index2)
                    str2 += Convert.ToString(Convert.ToInt32(str1[index2].ToString()) * Convert.ToInt32(str3[index2].ToString()));
                if (!Convert.ToBoolean(row["Borrable"].ToString()) && row["Repetir en Dias"].ToString() != "0000000")
                    this.updateDate(row, date);
                if (str3 == "0000000")
                {
                    if (date.Date != Convert.ToDateTime(row["Fecha de Inicio"].ToString()).Date)
                    {
                        row.Delete();
                        reminderList.AcceptChanges();
                        --index1;
                        continue;
                    }
                }
                else
                {
                    if (date.Date >= Convert.ToDateTime(row["Fecha de Inicio"].ToString()).Date && str2 != str1)
                    {
                        row.Delete();
                        reminderList.AcceptChanges();
                        --index1;
                        continue;
                    }
                    if (date.Date < Convert.ToDateTime(row["Fecha de Inicio"].ToString()).Date && str2 == str1)
                    {
                        row.Delete();
                        reminderList.AcceptChanges();
                        --index1;
                        continue;
                    }
                }
                this.updateDate(row, date);
            }
            this.reorderRemindersByDuration(reminderList);
            return reminderList;
        }

        private void reorderRemindersByDuration(DataTable reminderList)
        {
            for (int pos = 0; pos < reminderList.Rows.Count; ++pos)
            {
                DateTime dateTime1 = Convert.ToDateTime(reminderList.Rows[pos]["Fecha de Inicio"].ToString().Substring(0, 10) + " " + reminderList.Rows[pos]["Hora de Inicio"].ToString());
                TimeSpan timeSpan = Convert.ToDateTime(reminderList.Rows[pos]["Fecha de Fin"].ToString().Substring(0, 10) + " " + reminderList.Rows[pos]["Hora de Fin"].ToString()) - dateTime1;
                Dictionary<int, TimeSpan> source = new Dictionary<int, TimeSpan>();
                for (int key = 0; key < reminderList.Rows.Count; ++key)
                {
                    if (key > pos)
                    {
                        DateTime dateTime2 = Convert.ToDateTime(reminderList.Rows[key]["Fecha de Inicio"].ToString().Substring(0, 10) + " " + reminderList.Rows[key]["Hora de Inicio"].ToString());
                        DateTime dateTime3 = Convert.ToDateTime(reminderList.Rows[key]["Fecha de Fin"].ToString().Substring(0, 10) + " " + reminderList.Rows[key]["Hora de Fin"].ToString());
                        source.Add(key, dateTime3 - dateTime2);
                    }
                }
                if (source.Count > 0 && timeSpan < source.OrderBy<KeyValuePair<int, TimeSpan>, TimeSpan>((Func<KeyValuePair<int, TimeSpan>, TimeSpan>)(key => key.Value)).ElementAt<KeyValuePair<int, TimeSpan>>(source.Count - 1).Value)
                {
                    DataRow row1 = reminderList.NewRow();
                    DataRow row2 = reminderList.NewRow();
                    int key1 = source.OrderBy<KeyValuePair<int, TimeSpan>, TimeSpan>((Func<KeyValuePair<int, TimeSpan>, TimeSpan>)(key => key.Value)).ElementAt<KeyValuePair<int, TimeSpan>>(source.Count - 1).Key;
                    row1.ItemArray = reminderList.Rows[pos].ItemArray;
                    row2.ItemArray = reminderList.Rows[key1].ItemArray;
                    reminderList.Rows.Remove(reminderList.Rows[key1]);
                    reminderList.Rows.Remove(reminderList.Rows[pos]);
                    reminderList.Rows.InsertAt(row2, pos);
                    reminderList.Rows.InsertAt(row1, source.OrderBy<KeyValuePair<int, TimeSpan>, TimeSpan>((Func<KeyValuePair<int, TimeSpan>, TimeSpan>)(key => key.Value)).ElementAt<KeyValuePair<int, TimeSpan>>(0).Key);
                    reminderList.AcceptChanges();
                }
            }
        }

        private void updateDate(DataRow _event, DateTime date)
        {
            DateTime dateTime1 = Convert.ToDateTime(_event["Fecha de Inicio"].ToString());
            DateTime dateTime2 = new DateTime(date.Year, date.Month, date.Day, dateTime1.Hour, dateTime1.Minute, dateTime1.Second);
            _event["Fecha de Inicio"] = (object)dateTime2;
            if (_event["Hora de Fin"].ToString().Substring(0, 8) == "00:00:00")
                _event["Fecha de Fin"] = (object)dateTime2.AddDays(1.0);
            else
                _event["Fecha de Fin"] = (object)dateTime2;
        }

        private void displayVisitingDays()
        {
            if (this.proveedor.diasVisita[0])
                this.domingoLbl.ForeColor = Color.Tomato;
            else
                this.domingoLbl.ForeColor = Color.DimGray;
            if (this.proveedor.diasVisita[1])
                this.LunesLbl.ForeColor = Color.Tomato;
            else
                this.LunesLbl.ForeColor = Color.DimGray;
            if (this.proveedor.diasVisita[2])
                this.martesLbl.ForeColor = Color.Tomato;
            else
                this.martesLbl.ForeColor = Color.DimGray;
            if (this.proveedor.diasVisita[3])
                this.miercolesLbl.ForeColor = Color.Tomato;
            else
                this.miercolesLbl.ForeColor = Color.DimGray;
            if (this.proveedor.diasVisita[4])
                this.juevesLbl.ForeColor = Color.Tomato;
            else
                this.juevesLbl.ForeColor = Color.DimGray;
            if (this.proveedor.diasVisita[5])
                this.viernesLbl.ForeColor = Color.Tomato;
            else
                this.viernesLbl.ForeColor = Color.DimGray;
            if (this.proveedor.diasVisita[6])
                this.sabadoLbl.ForeColor = Color.Tomato;
            else
                this.sabadoLbl.ForeColor = Color.DimGray;
        }

        private void UpdateVisitingDays()
        {
            this.proveedor.UpdateVisitingDays();
        }

        private void companyNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (this.companyNameTxt.Text != "" && this.companyNameTxt.Text != this.proveedor.NombreEmpresa)
                {

                    this.proveedor.NombreEmpresa = this.companyNameTxt.Text;
                    this.proveedor.SupplierUpdateBasicInformation();
                    this.flow1.Controls.Clear();
                    flow1 = new FlowLayoutPanel();

                    this.loadSupplierList();
                    this.flow1.ControlAdded += (ControlEventHandler)((send, ee) =>
                    {
                        if (!(this.flow1.Controls[this.flow1.Controls.Count - 1] is BunifuImageButton control) || !(control.Name.Substring(0, control.Name.IndexOf(",")) == this.proveedor.ID.ToString()))
                            return;
                        this.SupplierImagePicBox.Image = control.Image;
                    });
                }
                else
                    this.companyNameTxt.Text = this.proveedor.NombreEmpresa;
            }
            if (e.KeyCode != Keys.Escape)
                return;
            this.companyNameTxt.Text = this.proveedor.NombreEmpresa;
        }

        private void companyAddressTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.companyAddressTxt.Text != this.proveedor.Direccion)
            {
                this.proveedor.Direccion = this.companyAddressTxt.Text;
                this.proveedor.SupplierUpdateBasicInformation();
            }
            if (e.KeyCode != Keys.Escape)
                return;
            this.companyAddressTxt.Text = this.proveedor.Direccion;
        }

        private void phoneNumberTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string str = this.phoneNumberTxt.Text;
                if (str.Length == 7)
                    str = str.Insert(2, "-").Insert(4, "-");
                if (str.Length == 10)
                    str = str.Insert(3, "-").Insert(7, "-");
                if (str != this.proveedor.Telefono)
                {
                    this.proveedor.Telefono = str;
                    this.proveedor.SupplierUpdateBasicInformation();
                    this.phoneNumberTxt.Text = str;
                }
            }
            if (e.KeyCode != Keys.Escape)
                return;
            this.phoneNumberTxt.Text = this.proveedor.Telefono;
        }

        private void SupplierbuttonClick(object sender, EventArgs e)
        {
            BunifuImageButton bunifuImageButton = sender as BunifuImageButton;
            this.SuppliersPanel.Hide();
            this.SupplierImagePicBox.Image = bunifuImageButton.Image;
            new BunifuElipse()
            {
                ElipseRadius = 20,
                TargetControl = ((Control)this.SupplierImagePicBox)
            }.ApplyElipse();
            this.SupplierInfromationPanel.Dock = DockStyle.Fill;
            this.proveedor.ID = int.Parse(bunifuImageButton.Name.Substring(0, bunifuImageButton.Name.IndexOf(",")));
            this.proveedor.GetSupplierData();
            this.companyNameTxt.Text = this.proveedor.NombreEmpresa;
            this.companyAddressTxt.Text = this.proveedor.Direccion;
            this.phoneNumberTxt.Text = this.proveedor.Telefono;
            this.displayVisitingDays();
            this.AdeudoLbl.Text = "$" + this.proveedor.Adeudo.ToString("n2");
            if (TextRenderer.MeasureText(this.AdeudoLbl.Text, this.AdeudoLbl.Font).Width > this.AdeudoLbl.Parent.Width - 10)
                AdeudoLbl.Font = PrinterTicket.getFont(AdeudoLbl.Text, AdeudoLbl.Parent.Width - 20,
                FontStyle.Regular, AdeudoLbl.Font.FontFamily.ToString());
            
            this.dataGridView1.DataSource = this.proveedor.GetSupplierProductList();
                       

            for (int index = 0; index < this.dataGridView1.Columns.Count; ++index)
                this.OriginalColumnHeaderIndexes.Add(this.dataGridView1.Columns[index].Name.ToString());
            this.ProductTableBtn_Click((object)this, (EventArgs)null);
            
            
            
            this.FilteringTextbox.Text = "";
            FilteringTextbox.Select();

            //------------------- this.FilterNextPurchaseTxt.Text = "";----------------------------
            this.PrepareNextPurhcase();


            comboBox1.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            

            dateTimePicker1.Value = DateTime.Today;




            
            this.setPanelWidth(this.BasicSupplierInformationPanel, this.BasicInformationCard, 0.26);
            this.setPanelWidth(this.VisitingDaysPanel, this.BasicInformationCard, 0.25);
            this.setPanelWidth(this.DebtPannel, this.BasicInformationCard, 0.24);
            this.setPanelWidth(this.SupplierImagePanel, this.BasicInformationCard, 0.25);
            this.VisitingDaysPanel.Location = new Point(this.BasicSupplierInformationPanel.Location.X + this.BasicSupplierInformationPanel.Width, this.BasicSupplierInformationPanel.Location.Y);
            this.DebtPannel.Location = new Point(this.VisitingDaysPanel.Location.X + this.VisitingDaysPanel.Width, this.VisitingDaysPanel.Location.Y);
            this.SupplierImagePanel.Location = new Point(this.DebtPannel.Location.X + this.DebtPannel.Width, this.DebtPannel.Location.Y);
            this.CompanyNameCard.Location = new Point(this.SupplierImagePanel.Width / 2 - this.CompanyNameCard.Width / 2, this.SupplierImagePanel.Height / 2 - this.CompanyNameCard.Height / 2);
            List<Control> controlList = new List<Control>();
            List<Control> controls1 = this.getControls((Control)this.BasicSupplierInformationPanel);
            this.centerControls(controls1, Direction.Vertical);
            controls1.Clear();
            List<Control> controls2 = this.getControls((Control)this.VisitingDaysPanel);
            controls2.Remove((Control)this.label2);
            this.centerControls(controls2, Panel_proveedores_Form.Direction.Horizontal);
            controls2.Clear();
            controls2.Add((Control)this.label2);
            this.centerControls(controls2, Panel_proveedores_Form.Direction.Horizontal);
            controls2.Clear();
            this.label6.Location = new Point(this.label6.Parent.Width / 2 - this.label6.Width / 2, this.label6.Parent.Height / 4 - this.label6.Height);
            this.AdeudoLbl.Location = new Point(this.AdeudoLbl.Parent.Width / 2 - this.AdeudoLbl.Width / 2, this.label6.Location.Y + this.label6.Height + 10);
            this.BasicSupplierInformationPanel.Paint += new PaintEventHandler(this.Panel_Paint);
            this.VisitingDaysPanel.Paint += new PaintEventHandler(this.Panel_Paint);
            this.DebtPannel.Paint += new PaintEventHandler(this.Panel_Paint);
            if (!new Empleado(this.EmployeeID).isAdmin)
            {
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[0].Cells[0];
                this.NextPurchaseTableBtn_Click((object)this, (EventArgs)null);
                this.setFormforNonAdminEmployee();
            }
            this.SupplierInfromationPanel.Visible = true;
            this.SuppliersPanel.Dock = DockStyle.None;
        }

        private void setFormforNonAdminEmployee()
        {
            this.companyNameTxt.Enabled = false;
            this.companyAddressTxt.Enabled = false;
            this.phoneNumberTxt.Enabled = false;
            this.ProductTableBtn.Enabled = false;
            AlarmsBtn.Enabled = false;
            this.POBtn.Visible = false;
            this.label6.Hide();
            this.AdeudoLbl.Hide();
            deleteSupplierBtn.Hide();
        }

        private void SearchProvider_TextChanged(object sender, EventArgs e)
        {
            if (SearchSupplierTxt.Text.Trim() == "")
                SearchSupplier();
        }

        private void ProductTableBtn_Click(object sender, EventArgs e)
        {
            this.ProggressActiveSeparator.Location = new Point(0, this.ProggressActiveSeparator.Location.Y);
            this.ProggressActiveSeparator.Width = this.GetMiddlePointXLocation((Control)this.ProductTableBtn, (Control)this.NextPurchaseTableBtn);
            this.ProductTableBtn.Enabled = false;
            this.NextPurchaseTableBtn.Enabled = true;
            this.AlarmsBtn.Enabled = true;
            FilteringTextbox.Select();

            foreach (Control control in this.panel.Controls)
            {
                if (control.Name == "ProductListPanel")
                {
                    control.Dock = DockStyle.Fill;
                    control.Show();
                }
                else
                {
                    control.Visible = false;
                    control.Dock = DockStyle.None;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.showProductInformation();
        }

        private void showProductInformation()
        {           
            Producto product = new Producto(dataGridView1.SelectedRows[0].Cells["Código de Barras"].Value.ToString());
            
            if (!(product.Barcode != ""))
                return;
            
            Form_Agregar formAgregar = new Form_Agregar(product);
            DarkForm darkForm = new DarkForm();
            
            darkForm.Show();
            
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                product = new Producto(product.Barcode);

                var index = findMatchingProductinNextPurchase(product.Barcode);

                if (index > -1)
                {
                    dataGridView2.Rows[index].Cells["description"].Value = product.Description;
                    dataGridView2.Rows[index].Cells["brand"].Value = product.Brand;
                }

                dataGridView1.CurrentRow.Cells["Descripción"].Value = product.Description;
                dataGridView1.CurrentRow.Cells["Marca"].Value = product.Brand;
                dataGridView1.CurrentRow.Cells["Precio de Compra"].Value =
                    (product.PurchaseCost / product.PiecesPerCase * Convert.ToDouble(dataGridView1.CurrentRow.Cells["Piezas Por Caja"].Value)).ToString("n2").Replace(",", "");


            }
            darkForm.Close();
        }

        private void AddRowBtn_Click(object sender, EventArgs e)
        {
            DarkForm darkForm = new DarkForm();

           PanelPoveedoresNuevoProducto poveedoresNuevoProducto = new PanelPoveedoresNuevoProducto(this.proveedor.ID);
            darkForm.Show();

            if (poveedoresNuevoProducto.ShowDialog() == DialogResult.OK)
            {
                this.dataGridView1.DataSource = this.proveedor.GetSupplierProductList();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Código de Barras"].Value.ToString() == poveedoresNuevoProducto.barcode)
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

                proveedor = new Proveedor(proveedor.ID);
                //this.PrepareNextPurhcase();
            }

            darkForm.Close();
        }

        private void dataGridView1_ColumnDisplayIndexChanged(
          object sender,
          DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index >= 8)
                return;
            int index = e.Column.Index;
            if (e.Column.Index != index || e.Column.DisplayIndex == index)
                return;
            MouseEventHandler mouseEventHandlertoRemove = (MouseEventHandler)null;
            this.dataGridView1.MouseUp += (MouseEventHandler)((sender1, mouseEventArgs) =>
            {
                this.dataGridView1.Columns[index].DisplayIndex = index;
                this.dataGridView1.MouseUp -= mouseEventHandlertoRemove;
            });
        }

        private void EditRowBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
                return;

            DarkForm darkForm = new DarkForm();
            Producto product = new Producto();
            product.Barcode = dataGridView1.SelectedRows[0].Cells["Código de Barras"].Value.ToString();
            product.SearchProduct();
            product.PurchaseCost = Convert.ToDouble(this.dataGridView1.SelectedRows[0].Cells["Precio de Proveedor"].Value.ToString());
            PanelPoveedoresNuevoProducto poveedoresNuevoProducto = new PanelPoveedoresNuevoProducto(this.proveedor.ID, product, Convert.ToDouble(this.dataGridView1.SelectedRows[0].Cells["Piezas por Caja"].Value));
            darkForm.Show();
            if (poveedoresNuevoProducto.ShowDialog() == DialogResult.OK)
            {
                var index = findMatchingProductinNextPurchase(dataGridView1.CurrentRow.Cells["Código de Barras"].Value.ToString());
                if (index > -1)
                {
                    DataRow dataRow = proveedor.getProductInfo(product.Barcode).Rows[0];
                    dataGridView2.Rows[index].Cells["Piecespercase"].Value = dataRow["Piezas por caja"];

                    dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells["Amount"];
                    dataGridView2.BeginEdit(true);
                    dataGridView2.EndEdit();
                }

                this.dataGridView1.DataSource = this.proveedor.GetSupplierProductList();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Código de Barras"].Value.ToString() == poveedoresNuevoProducto.barcode)
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                proveedor = new Proveedor(proveedor.ID);
                // this.PrepareNextPurhcase();

            }
            darkForm.Close();
        }

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este producto?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                var barcode = dataGridView1.CurrentRow.Cells["Código de Barras"].Value.ToString();
                var rowIndex = findMatchingProductinNextPurchase(barcode);

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                proveedor.DeleteProduct(this.proveedor.ID, barcode);

                if (rowIndex > -1)
                {
                    dataGridView2.Rows.RemoveAt(rowIndex);
                    this.grandTotalLbl.Text = "Total = $" + calculateNextPurchaseTotal().ToString("n2");
                }



                //this.dataGridView1.DataSource = this.proveedor.GetSupplierProductList();
                //this.PrepareNextPurhcase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.ToString());
            }
        }

        private int findMatchingProductinNextPurchase(string barcode)
        {
            int index = -1;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["barcode"].Value.ToString() == barcode)
                {
                    index = row.Index;
                    return index;
                }
            }

            return index;
        }

        private void PromoBtn_Click(object sender, EventArgs e)
        {
            DarkForm darkForm = new DarkForm();
            PanelProveedorPromos panelProveedorPromos = new PanelProveedorPromos(this.proveedor);
            darkForm.Show();
            int num = (int)panelProveedorPromos.ShowDialog();
            this.proveedor = new Proveedor(this.proveedor.ID);
            this.PrepareNextPurhcase();
            darkForm.Close();
        }

        private void FilteringTextbox_TextChanged(object sender, EventArgs e)
        {
            if (FilteringTextbox.Text == "")
            {
                dataGridView1.DataSource = proveedor.GetSupplierProductList();
            }
        }

        private void NextPurchaseTableBtn_Click(object sender, EventArgs e)
        {
            this.ProggressActiveSeparator.Location = new Point(this.GetMiddlePointXLocation((Control)this.ProductTableBtn, (Control)this.NextPurchaseTableBtn), this.ProggressActiveSeparator.Location.Y);
            this.ProggressActiveSeparator.Width = this.GetMiddlePointXLocation((Control)this.NextPurchaseTableBtn, (Control)this.AlarmsBtn) - this.ProggressActiveSeparator.Location.X;
            this.ProductTableBtn.Enabled = new Empleado(this.EmployeeID).isAdmin;
            this.NextPurchaseTableBtn.Enabled = false;
            this.AlarmsBtn.Enabled = true;

            foreach (Control control in this.panel.Controls)
            {
                if (control.Name == "NextPurchaseCard")
                {
                    control.Dock = DockStyle.Fill;
                    control.Show();
                }
                else
                {
                    control.Visible = false;
                    control.Dock = DockStyle.None;
                }
            }

            ProductTxt.Focus();
        }

        private void PrepareNextPurhcase()
        {
            try
            {
                double total = 0;
                dataGridView2.Rows.Clear();

                foreach (DataRow row in proveedor.SupplierGetQuantitiesAndDates().Rows)
                {
                    double amount = Convert.ToDouble(row["Cantidad"]);
                    if (amount != 0)
                    {
                        addProductToGridView(new Producto(row["id_producto"].ToString()), amount);
                        total += amount * getcost(row["id_producto"].ToString());
                    }
                }
                this.grandTotalLbl.Text = "Total = $" + total.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar la acción.\nError: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void AutoGenerateListBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in (BaseCollection)this.dataGridView2.SelectedRows)
            {
                int index = -1;
                foreach (DataGridViewRow row in this.dataGridView2.Rows)
                {
                    if (this.dataGridView1.Rows[row.Index].Cells["Código de Barras"].Value.ToString() == selectedRow.Cells["Código de Barras"].Value.ToString())
                    {
                        index = row.Index;
                        break;
                    }
                }
                if (index > -1)
                {
                    Convert.ToDouble(selectedRow.Cells["Total"].Value.ToString());
                    double num1 = 0.0;
                    if (this.dataGridView1.Rows[index].Cells[7].Style.BackColor == Color.LightGreen)
                    {
                        num1 = Math.Round((Convert.ToDouble(this.dataGridView1.Rows[selectedRow.Index].Cells["Stock Mínimo"].Value.ToString()) - Convert.ToDouble(this.dataGridView1.Rows[selectedRow.Index].Cells["Stock Actual"].Value.ToString())) / Convert.ToDouble(this.dataGridView1.Rows[selectedRow.Index].Cells["Piezas por Caja"].Value), 0);
                        if (num1 < 0.0)
                            num1 = 0.0;
                    }
                    double num2 = num1 * Convert.ToDouble(this.dataGridView1.Rows[selectedRow.Index].Cells[7].Value.ToString());
                    selectedRow.Cells["Total"].Value = (object)num2.ToString("n2");
                    selectedRow.Cells["Cantidad"].Value = (object)num1.ToString("n2");
                }
            }
        }

        private void NextPurchaseGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double num = 0.0;
            foreach (DataGridViewRow row in this.dataGridView2.Rows)
                num += Convert.ToDouble(row.Cells["Total"].Value);
            this.grandTotalLbl.Text = "Total = $" + num.ToString("n2");
        }

        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            this.dataGridView2.SelectAll();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool num1 = false;

            dataGridView2.EndEdit();

            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {

                if (Convert.ToDouble(row.Cells["amount"].Value) != 0)
                {
                    num1 = true;
                    break;
                }
            }

            if (!num1)

                MessageBox.Show("Agregue productos para generar la orden de compra");
            else
            {
                this.generataPurchaseOrder();

                if (this.FilteringTextbox.Text != "")
                    this.dataGridView1.DataSource = this.proveedor.SupplierFilterProducts(this.FilteringTextbox.Text);
                else
                    dataGridView1.DataSource = proveedor.GetSupplierProductList();
            }
        }

        private void generataPurchaseOrder()
        {
            PanelProveedor_GeneratePO newPO = new PanelProveedor_GeneratePO(this.proveedor, this.EmployeeID, Convert.ToDouble(this.grandTotalLbl.Text.Substring(this.grandTotalLbl.Text.IndexOf("$") + 1)));
            DarkForm dk = new DarkForm();
            LoadingScreen load = new LoadingScreen();
            dk.Show();
            if (newPO.ShowDialog() == DialogResult.OK)
            {
                if (newPO.PO_ID > -1)
                {
                    addItemsToPurchase(newPO.PO_ID);
                }
                else
                {
                    MessageBox.Show("No se pudo generar la Orden de Compra");
                }


                if (newPO.Payment != 0.0)
                {
                    printAndOpenCashDrawer(newPO.Payment);
                }

                load.Show();
                resetPurchase();

                this.grandTotalLbl.Text = "Total = $" + calculateNextPurchaseTotal().ToString("n2");

                this.AdeudoLbl.Text = "$" + this.proveedor.Adeudo.ToString("n2");

            }
            load.Close();
            dk.Close();
        }

        private void resetPurchase()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                proveedor.SupplierUpdateQuantities(row.Cells["barcode"].Value.ToString(), 0);
            }

            dataGridView2.Rows.Clear();
            countTotalofProducts();
        }

        private void printAndOpenCashDrawer(double payment)
        {
            FormCambio formCambio = new FormCambio(payment);
            formCambio.Show();
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
                    useNativePrinter();
                    //<<<step1>>>--End
                }
            }
            else
                useNativePrinter();
        }

        private void useNativePrinter()
        {
            try
            {

                var printDialog = new PrintDialog();               
                var printDocument = new PrintDocument() { PrintController = new StandardPrintController()};
                printDialog.PrinterSettings.PrinterName = new PrinterTicket().printerName;
                printDialog.Document = printDocument;

                printDocument.Print();
            }
            catch (InvalidPrinterException)
            {
                MessageBox.Show("Registre una impresora para poder utilizar esta opción", "No se ha registrado impresora");
            }
        }

        private void addItemsToPurchase(int poID)
        {
            foreach (DataGridViewRow row1 in this.dataGridView2.Rows)
            {
                if (Convert.ToDouble(row1.Cells["amount"].Value) != 0.0)
                {
                    Producto product = new Producto(row1.Cells["barcode"].Value.ToString());
                    DataTable productSupplierInfo = proveedor.getProductInfo(product.Barcode);

                    double UnitaryCost = Convert.ToDouble(productSupplierInfo.Rows[0]["Precio de Compra"]);
                    double PiecesPerCase = Convert.ToDouble(productSupplierInfo.Rows[0]["Piezas por Caja"]);

                    product.PurchaseCost = UnitaryCost / PiecesPerCase * product.PiecesPerCase;
                    product.UpdateProduct(product.Barcode);

                    this.proveedor.addProductToPO(poID, product, Convert.ToDouble(row1.Cells["amount"].Value.ToString()),
                        PiecesPerCase, UnitaryCost, Convert.ToDouble(row1.Cells["Total"].Value), Convert.ToInt32(row1.Cells["depot"].Value));
                }
            }
        }

        private double getPicesPerCase(string v)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (v == row.Cells["Código de Barras"].Value.ToString())
                {
                    return Convert.ToDouble(row.Cells["Piezas por Caja"].Value);
                }
            }
            return 0;
        }

        private void createPO_PDFFile(
          string supplierName,
          int PO_id,
          DateTime ArrivalDate,
          DateTime paymentDueDate,
          double total,
          System.Data.DataTable promos)
        {
            try
            {
                string str = Path.GetFullPath(Environment.CurrentDirectory) + "\\Template\\";

                word.Application instance = new word.Application();
                word.Document document1 = instance.Documents.Open(str + "Abarrotes Arvizu PO Template.dotx");
                this.changeText(instance, "DD:MM:AA", DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString());
                DateTime dateTime1 = ArrivalDate;
                string textToChange = "DD1:MM1:AA1";
                string textToReplace1 = dateTime1.Day.ToString() + "/" + dateTime1.Month.ToString() + "/" + dateTime1.Year.ToString();
                this.changeText(instance, textToChange, textToReplace1);
                DateTime dateTime2 = paymentDueDate;
                string textToReplace2 = dateTime2.Day.ToString() + "/" + dateTime2.Month.ToString() + "/" + dateTime2.Year.ToString();
                this.changeText(instance, "DD2:MM2:AA2", textToReplace2);
                this.changeText(instance, "xxx", PO_id.ToString());
                this.changeText(instance, "nombre del proveedor", supplierName);
                this.changeText(instance, "....", total.ToString("n2"));
                // ISSUE: variable of a compiler-generated type
                Microsoft.Office.Interop.Word.Table table1 = document1.Tables[1];
                for (int index = 0; index < this.dataGridView2.Rows.Count; ++index)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[index];
                    double num1 = Convert.ToDouble(row.Cells["amount"].Value.ToString());
                    int count = table1.Rows.Count;
                    object oMissing = System.Reflection.Missing.Value;

                    if (num1 > 0.0)
                    {
                        // ISSUE: variable of a compiler-generated type
                        word.Rows rows = table1.Rows;
                        // ISSUE: reference to a compiler-generated method
                        rows.Add(ref oMissing);
                        // ISSUE: reference to a compiler-generated method
                        table1.Cell(index + 2, 1).Range.Text = num1.ToString("n2");
                        // ISSUE: reference to a compiler-generated method
                        table1.Cell(index + 2, 2).Range.Text = row.Cells["barcode"].Value.ToString();
                        // ISSUE: reference to a compiler-generated method
                        table1.Cell(index + 2, 3).Range.Text = row.Cells["description"].Value.ToString();
                        double num2 = Convert.ToDouble(row.Cells["Total"].Value.ToString());
                        // ISSUE: reference to a compiler-generated method
                        table1.Cell(index + 2, 4).Range.Text = (num2 / num1).ToString("n2");
                        // ISSUE: reference to a compiler-generated method
                        table1.Cell(index + 2, 5).Range.Text = num2.ToString("n2");
                    }
                }
                // ISSUE: variable of a compiler-generated type
                Microsoft.Office.Interop.Word.Table table2 = document1.Tables[2];
                for (int index = 0; index < promos.Rows.Count; ++index)
                {
                    if (Convert.ToDateTime(promos.Rows[index]["Fecha de Fin"]).Date >= DateTime.Now.Date)
                    {
                        DataRow row = promos.Rows[index];
                        // ISSUE: variable of a compiler-generated type
                        word.Rows rows = table2.Rows;
                        object obj17 = (object)Missing.Value;
                        ref object local17 = ref obj17;
                        // ISSUE: reference to a compiler-generated method
                        rows.Add(ref local17);
                        // ISSUE: reference to a compiler-generated method
                        table2.Cell(index + 2, 1).Range.Text = row["Código de Barras"].ToString();
                        // ISSUE: reference to a compiler-generated method
                        table2.Cell(index + 2, 2).Range.Text = row["Descripción"].ToString();
                        // ISSUE: reference to a compiler-generated method
                        table2.Cell(index + 2, 3).Range.Text = row["Precio de Oferta"].ToString();
                        // ISSUE: reference to a compiler-generated method
                        table2.Cell(index + 2, 4).Range.Text = row["Cantidad Mínima de Compra"].ToString();
                        // ISSUE: reference to a compiler-generated method
                        table2.Cell(index + 2, 5).Range.Text = row["Notas"].ToString();
                        // ISSUE: reference to a compiler-generated method
                        table2.Cell(index + 2, 6).Range.Text = Convert.ToDateTime(row["Fecha de Fin"]).Date.ToShortDateString();
                    }
                }
                word.Document document2 = document1;
                string OutputFileName = str + "PO#" + PO_id + ".pdf";
                object obj18 = Missing.Value;
                ref object local18 = ref obj18;
                // ISSUE: reference to a compiler-generated method
                document2.ExportAsFixedFormat(OutputFileName, word.WdExportFormat.wdExportFormatPDF, false, word.WdExportOptimizeFor.wdExportOptimizeForPrint,
                    word.WdExportRange.wdExportAllDocument, 1, 1, word.WdExportItem.wdExportDocumentContent, false, true, word.WdExportCreateBookmarks.wdExportCreateNoBookmarks
                    , true, true, false, ref local18);

                // ISSUE: variable of a compiler-generated type
                word.Document document3 = document1;
                object obj19 = (object)false;
                ref object local19 = ref obj19;
                object obj20 = (object)Missing.Value;
                ref object local20 = ref obj20;
                object obj21 = (object)Missing.Value;
                ref object local21 = ref obj21;
                // ISSUE: reference to a compiler-generated method
                document3.Close(ref local19, ref local20, ref local21);
                // ISSUE: variable of a compiler-generated type
                word.Application application = instance;
                object obj22 = (object)Missing.Value;
                ref object local22 = ref obj22;
                object obj23 = Missing.Value;
                ref object local23 = ref obj23;
                object obj24 = Missing.Value;
                ref object local24 = ref obj24;
                // ISSUE: reference to a compiler-generated method
                application.Quit(ref local22, ref local23, ref local24);
                //Process.Start(str + "PO#" + (object)PO_id + ".pdf");

            }
            catch (COMException)
            {
                MessageBox.Show("No sé pudo completar la  acción. El archivo está siendo utilizado por otra aplicación. Ciérrelo y vuelva a intentarlo.", "Archivo en uso", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No sé pudo completar la acción.\nError: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void showNewPurchaseProgress(bool show)
        {
        }

        private void changeText(Microsoft.Office.Interop.Word.Application application, string textToChange, string textToReplace)
        {
            bool flag1 = true;
            bool flag2 = true;
            bool flag3 = false;
            bool flag4 = false;
            bool flag5 = false;
            bool flag6 = true;
            int num1 = 1;
            bool flag7 = false;
            int num2 = 1;
            // ISSUE: variable of a compiler-generated type
            word.Find find = application.Selection.Find;
            object obj1 = (object)textToChange;
            ref object local1 = ref obj1;
            object obj2 = (object)flag1;
            ref object local2 = ref obj2;
            object obj3 = (object)flag2;
            ref object local3 = ref obj3;
            object obj4 = (object)flag3;
            ref object local4 = ref obj4;
            object obj5 = (object)flag4;
            ref object local5 = ref obj5;
            object obj6 = (object)flag5;
            ref object local6 = ref obj6;
            object obj7 = (object)flag6;
            ref object local7 = ref obj7;
            object obj8 = (object)num1;
            ref object local8 = ref obj8;
            object obj9 = (object)flag7;
            ref object local9 = ref obj9;
            object obj10 = (object)textToReplace;
            ref object local10 = ref obj10;
            object obj11 = (object)num2;
            ref object local11 = ref obj11;
            object obj12 = (object)Missing.Value;
            ref object local12 = ref obj12;
            object obj13 = (object)Missing.Value;
            ref object local13 = ref obj13;
            object obj14 = (object)Missing.Value;
            ref object local14 = ref obj14;
            object obj15 = (object)Missing.Value;
            ref object local15 = ref obj15;
            // ISSUE: reference to a compiler-generated method
            find.Execute(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15);
        }

        private void NextPurchaseGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridView2.Rows.Count <= 0)
                return;
            this.dataGridView2.Columns["Código de Barras"].ReadOnly = true;
            this.dataGridView2.Columns["Descripción"].ReadOnly = true;
            this.dataGridView2.Columns["Cantidad"].ReadOnly = false;
            this.dataGridView2.Columns["Total"].ReadOnly = true;
            this.dataGridView2.Columns["Código de Barras"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView2.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView2.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView2.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView2.ScrollBars = ScrollBars.Both;
        }

        private void NextPurchaseGridView_EditingControlShowing(
          object sender,
          DataGridViewEditingControlShowingEventArgs e)
        {
            (e.Control as TextBox).KeyPress += (KeyPressEventHandler)((s, ee) =>
            {
                if (!char.IsControl(ee.KeyChar) && !char.IsDigit(ee.KeyChar) && ee.KeyChar != '.')
                    ee.Handled = true;
                if (ee.KeyChar != '.' || (s as TextBox).Text.IndexOf('.') <= -1)
                    return;
                ee.Handled = true;
            });
        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /* if (this.dataGridView1.Rows.Count <= 0)
                 return;
             for (int index1 = 0; index1 < this.dataGridView1.Rows.Count; ++index1)
             {
                 List<double> source = new List<double>();
                 for (int index2 = 7; index2 < this.dataGridView1.Columns.Count; ++index2)
                     source.Add(Convert.ToDouble(this.dataGridView1.Rows[index1].Cells[index2].Value.ToString()));
                 source.Sort();
                 source.RemoveAll((Predicate<double>)(item => item == 0.0));
                 for (int index2 = 7; index2 < this.dataGridView1.Columns.Count; ++index2)
                 {
                     if (Convert.ToDouble(this.dataGridView1.Rows[index1].Cells[index2].Value.ToString()) == source.ElementAt<double>(0) && Convert.ToDouble(this.dataGridView1.Rows[index1].Cells[index2].Value.ToString()) != 0.0)
                         this.dataGridView1.Rows[index1].Cells[index2].Style = new DataGridViewCellStyle()
                         {
                             SelectionBackColor = Color.LightGreen,
                             SelectionForeColor = Color.White,
                             BackColor = Color.LightGreen,
                             ForeColor = Color.White
                         };
                     else if (Convert.ToDouble(this.dataGridView1.Rows[index1].Cells[index2].Value.ToString()) == source.ElementAt<double>(source.Count - 1) && Convert.ToDouble(this.dataGridView1.Rows[index1].Cells[index2].Value.ToString()) != 0.0)
                         this.dataGridView1.Rows[index1].Cells[index2].Style = new DataGridViewCellStyle()
                         {
                             SelectionBackColor = Color.Tomato,
                             SelectionForeColor = Color.White,
                             BackColor = Color.Tomato,
                             ForeColor = Color.White
                         };
                     else
                         this.dataGridView1.Rows[index1].Cells[index2].Style = new DataGridViewCellStyle()
                         {
                             SelectionBackColor = Color.WhiteSmoke,
                             SelectionForeColor = Color.FromArgb(0, 130, 170),
                             BackColor = Color.WhiteSmoke,
                             ForeColor = Color.FromArgb(0, 130, 170)
                         };
                 }
             }*/
            int num = 0;
            for (int index = 0; index < this.dataGridView1.RowCount; ++index)
            {
                if (this.dataGridView1.Rows[index].Visible)
                {
                    if (num % 2 == 0)
                        this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);
                    else
                        this.dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.White;
                    ++num;
                }
            }
        }

        private void NextPurchaseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;
            double Quantity = Convert.ToDouble(this.dataGridView2.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
            double num1 = Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());//cost per case
            DataView defaultView = this.proveedor.promos.Copy().DefaultView;
            defaultView.Sort = "Cantidad Mínima de Compra asc";
            foreach (DataRow row in (InternalDataCollectionBase)defaultView.ToTable().Rows)
            {
                if (this.dataGridView2.Rows[e.RowIndex].Cells["Código de Barras"].Value.ToString() == row["Código de Barras"].ToString() && Quantity >= Convert.ToDouble(row["Cantidad Mínima de Compra"].ToString()) && DateTime.Now.Date <= Convert.ToDateTime(row["Fecha de Fin"].ToString()).Date)
                    num1 = Convert.ToDouble(row["Precio de Oferta"].ToString());
            }
            this.dataGridView2.Rows[e.RowIndex].Cells["Total"].Value = (Quantity * num1).ToString("n2");
            double num2 = 0.0;
            for (int index = 0; index < this.dataGridView2.Rows.Count; ++index)
                num2 += Convert.ToDouble(this.dataGridView2.Rows[index].Cells["Total"].Value.ToString());
            this.grandTotalLbl.Text = "Total = $" + num2.ToString("n2");
            try
            {
                this.proveedor.SupplierUpdateQuantities(this.dataGridView2.Rows[e.RowIndex].Cells["Código de Barras"].Value.ToString(), Quantity);
            }
            catch (Exception ex)
            {
                int num3 = (int)MessageBox.Show("No se pudo completar la acción.\n Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private DataTable SortPromoTableByCost(DataTable promos)
        {
            Dictionary<int, double> source = new Dictionary<int, double>();
            for (int key = 0; key < promos.Rows.Count; ++key)
                source.Add(key, Convert.ToDouble(promos.Rows[key]["Precio de Oferta"].ToString()));
            DataTable dataTable = promos.Copy();
            dataTable.Clear();
            dataTable.AcceptChanges();
            foreach (KeyValuePair<int, double> keyValuePair in (IEnumerable<KeyValuePair<int, double>>)source.OrderBy<KeyValuePair<int, double>, double>((Func<KeyValuePair<int, double>, double>)(key => key.Value)))
            {
                promos.NewRow();
                DataRow row = promos.Rows[keyValuePair.Key];
                dataTable.ImportRow(promos.Rows[keyValuePair.Key]);
            }
            dataTable.AcceptChanges();
            return dataTable;
        }

        private void AlarmsBtn_Click(object sender, EventArgs e)
        {
            this.ProggressActiveSeparator.Location = new Point(this.GetMiddlePointXLocation((Control)this.NextPurchaseTableBtn, (Control)this.AlarmsBtn), this.ProggressActiveSeparator.Location.Y);
            this.ProggressActiveSeparator.Width = this.ProgressUnactiveSeparator.Width - this.ProggressActiveSeparator.Location.X;
            this.ProductTableBtn.Enabled = new Empleado(this.EmployeeID).isAdmin;
            this.NextPurchaseTableBtn.Enabled = true;
            this.AlarmsBtn.Enabled = false;
            foreach (Control control in this.panel.Controls)
            {
                if (control.Name == "RemindersPanel")
                {
                    control.Dock = DockStyle.Fill;
                    control.Show();
                }
                else
                {
                    control.Visible = false;
                    control.Dock = DockStyle.None;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.SupplierInfromationPanel.Hide();
            this.SuppliersPanel.Dock = DockStyle.Fill;
            this.SuppliersPanel.Show();
            this.SupplierInfromationPanel.Dock = DockStyle.None;
            this.timer.Stop();
            this.timer.Dispose();
            FilteringTextbox.Text = "";
            ProductTxt.Text = "";
        }

        private void phoneNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }

     

    
        private void centerControlInTablePanel(Control l)
        {
            l.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            l.Dock = DockStyle.Fill;
            l.Dock = DockStyle.None;
            l.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            l.Anchor = AnchorStyles.None;
        }


        private void AddNewCustomerBtn_Click(object sender, EventArgs e)
        {
            PanelProveedoresNuevoProveedor proveedoresNuevoProveedor = new PanelProveedoresNuevoProveedor();
            DarkForm darkForm = new DarkForm();
            darkForm.Show();
            if (proveedoresNuevoProveedor.ShowDialog() == DialogResult.OK)
            {
                this.proveedor = new Proveedor();
                this.proveedor.NombreEmpresa = proveedoresNuevoProveedor.Name;
                this.proveedor.Adeudo = proveedoresNuevoProveedor.debt;
                try
                {
                    this.proveedor.Add();
                    this.flow1.Controls.Clear();
                    this.loadSupplierList();
                    this.flow1.ControlAdded += (ControlEventHandler)((ss, ee) =>
                    {
                        if (!(this.flow1.Controls[this.flow1.Controls.Count - 1] is BunifuImageButton control) || !(control.Name == this.proveedor.ID.ToString() + "," + this.proveedor.NombreEmpresa))
                            return;
                        this.SupplierbuttonClick((object)control, (EventArgs)null);
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo completar la acción.\n Error: " + ex.ToString());
                }
            }
            darkForm.Close();
        }

        private void POBtn_Click(object sender, EventArgs e)
        {
            new PanelProveedores_POExplorer(proveedor).Show();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MimimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            /*if (dataGridView1.DataSource != null)
            {
                int num = 0;
                foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
                {
                    if (column.Visible)
                        num += column.Width;
                }
                if (num >= this.dataGridView1.Width)
                    return;
                this.dataGridView1.Columns["Descripción"].Width += this.dataGridView1.Width - num;
            }*/
        }
        private void NextPurchaseGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Tab && !settingCurrentRow)
            {
                settingCurrentRow = true;
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["Cantidad"];
                dataGridView2.BeginEdit(true);
            }
        }
        private void Panel_proveedores_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            dataGridView1.Dispose();
            dataGridView2.Dispose();
            if (m_Drawer != null)
            {
                try
                {
                    //Cancel the device
                    m_Drawer.DeviceEnabled = false;

                    //Release the device exclusive control right.
                    m_Drawer.Release();
                    m_Drawer.Close();

                }
                catch (PosControlException)
                {
                }
            }
            //<<<step1>>>--End
        }

        private void ProductTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.ProductTxt.Text.IndexOf("*") > -1 && this.ProductTxt.Text.IndexOf("*") == this.ProductTxt.Text.Length - 1)
            {
                int selectionStart = this.ProductTxt.SelectionStart;
                this.ProductTxt.SelectionStart = this.ProductTxt.Text.IndexOf("*");
                this.ProductTxt.Find("*");
                this.ProductTxt.SelectionColor = Color.Tomato;
                this.ProductTxt.DeselectAll();
                this.ProductTxt.SelectionStart = selectionStart;
            }
            else if (this.ProductTxt.Text.IndexOf("*") > -1)
            {
                int selectionStart = this.ProductTxt.SelectionStart;
                int num = this.ProductTxt.Text.IndexOf("*") + 1;
                if (this.ProductTxt.Text.Length <= num)
                    return;
                this.ProductTxt.Find(this.ProductTxt.Text.Substring(num), num, RichTextBoxFinds.WholeWord);
                this.ProductTxt.SelectionColor = Color.LimeGreen;
                this.ProductTxt.DeselectAll();
                this.ProductTxt.SelectionStart = selectionStart;
            }
            else
            {
                int selectionStart = this.ProductTxt.SelectionStart;
                this.ProductTxt.SelectAll();
                this.ProductTxt.SelectionColor = Color.FromArgb(0, 130, 170);
                this.ProductTxt.DeselectAll();
                this.ProductTxt.SelectionStart = selectionStart;
            }
        }

        private void ProductTxt_Enter(object sender, EventArgs e)
        {
            ProductTxt.SelectAll();
        }

        private void ProductTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && this.ProductTxt != null && e.KeyCode != Keys.Return)
            {
                if (this.ProductTxt.Text.IndexOf("*") > -1)
                {
                    if (this.ProductTxt.Text.Substring(this.ProductTxt.Text.IndexOf("*") + 1) == "."
                        || ProductTxt.Text.Substring(this.ProductTxt.Text.IndexOf("*") + 1) == "-")
                    {
                        MessageBox.Show("Debe indicar la cantidad a agregar");
                        return;
                    }


                    if (this.ProductTxt.Text[this.ProductTxt.Text.Length - 1] == '*')
                        this.ProductTxt.Text = this.ProductTxt.Text.Substring(0, this.ProductTxt.Text.LastIndexOf("*") + 1) + "1";

                    string text = this.ProductTxt.Text.Substring(this.ProductTxt.Text.IndexOf("*") + 1);

                    if (text.IndexOf('.') > -1)
                    {
                        int startIndex = text.IndexOf('.');
                        text = text.Remove(startIndex, 1);
                    }


                    try { Convert.ToDouble(text); }
                    catch (FormatException)
                    {
                        MessageBox.Show("Sólo se aceptan números decimales después del \"*\"", "Formato no válido");
                        return;
                    }
                }
                e.SuppressKeyPress = true;
            }


            if (e.KeyCode == Keys.Up)
            {
                if (dataGridView2.RowCount > 0 && dataGridView2.CurrentRow.Index > 0)
                {
                    var cell = dataGridView2.CurrentCell;
                    dataGridView2.CurrentCell = dataGridView2[cell.ColumnIndex, cell.RowIndex - 1];
                    e.SuppressKeyPress = true;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (dataGridView2.RowCount > 0 && dataGridView2.CurrentRow.Index < dataGridView2.Rows.Count - 1)
                {
                    var cell = dataGridView2.CurrentCell;
                    dataGridView2.CurrentCell = dataGridView2[cell.ColumnIndex, cell.RowIndex + 1];
                    e.SuppressKeyPress = true;
                }
            }

            if (dataGridView2.RowCount > 0 && dataGridView2.CurrentCell != null && e.KeyCode == Keys.F2)
            {
                dataGridView2.Focus();
                var cell = dataGridView2.CurrentCell;
                dataGridView2.CurrentCell = dataGridView2.Rows[cell.RowIndex].Cells["amount"];
                dataGridView2.BeginEdit(true);
            }


            if (this.ProductTxt != null && e.KeyCode == Keys.Return && !e.Control)
                this.LookForProductToAdd();
            if (e.KeyCode != Keys.Escape)
                return;
            this.ProductTxt.Text = "";
        }


        private void LookForProductToAdd()
        {
            if (!(ProductTxt.Text != ""))
                return;


            int length = this.ProductTxt.Text.IndexOf("*");
            string str;
            double quantity;

            if (length > -1)
            {
                str = this.ProductTxt.Text.Substring(0, length);
                try
                {
                    quantity = Convert.ToDouble(this.ProductTxt.Text.Substring(length + 1));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Revise que la cantidad ingresada sea correcta.", "Error de Formato", MessageBoxButtons.OK);
                    int num2 = this.ProductTxt.Text.IndexOf('*');

                    if (num2 <= -1)
                        return;

                    int num3;
                    ProductTxt.Select(num3 = num2 + 1, this.ProductTxt.Text.Length - num3);
                    return;
                }
            }
            else
            {
                str = ProductTxt.Text;
                quantity = 1.0;
            }


            if (!this.isNumber(str))
            {
                str = str.Trim().ToLower();

                DataTable table = proveedor.SearchValueGetTable(str);
                if (table.Rows.Count == 0 || str == ".")
                {

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Windows_Battery_Low);
                    try
                    {
                        player.Play();
                        player.Play();
                    }
                    catch (Exception) { }
                    MessageBox.Show("No se encontró el producto");
                    this.ProductTxt.SelectAll();
                }
                else
                {
                    DarkForm darkForm = new DarkForm();
                    ChooseProductForm chooseProductForm = new ChooseProductForm(table, new Empleado(EmployeeID));
                    darkForm.Show();
                    if (chooseProductForm.ShowDialog() == DialogResult.OK)
                    {
                        this.addProductToGridView(new Producto(chooseProductForm.selectedItem[0]), quantity);
                        this.ProductTxt.Text = "";
                    }
                    darkForm.Close();
                }

            }
            else
            {
                bool found = false;
                foreach (DataRow row in proveedor.SearchValueGetTable(str).Rows)
                {
                    if (row["Código de Barras"].ToString().ToLower() == str.ToLower())
                    {
                        found = true;
                        continue;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("El producto no se encuentra registrado con el proveedor.");
                    ProductTxt.SelectAll();
                    return;
                }

                Producto p = new Producto(str);
                if (p.Barcode != "")
                {
                    this.addProductToGridView(p, quantity);
                    this.ProductTxt.Text = "";
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Windows_Battery_Low);
                    try
                    {
                        player.Play();
                        player.Play();
                    }
                    catch (Exception) { }
                    MessageBox.Show("No se encontró el producto");
                    this.ProductTxt.SelectAll();
                }
            }
        }


        private bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }

        private void addProductToGridView(Producto p, double quantity)
        {
            //lookin for an item in the datagridview to add the given product to it
            int rowIndex = -1;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                string barcode = row.Cells["barcode"].Value.ToString();

                if (barcode.IndexOf("promo(") == -1 && p.Barcode == barcode)
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            //if there is not a product like the given one in the table then add a new row
            if (rowIndex == -1)
            {
                int index = dataGridView2.Rows.Add();

                dataGridView2.Rows[index].Cells["barcode"].Value = p.Barcode;
                dataGridView2.Rows[index].Cells["description"].Value = p.Description;
                dataGridView2.Rows[index].Cells["brand"].Value = p.Brand;
                dataGridView2.Rows[index].Cells["amount"].Value = quantity.ToString();
                dataGridView2.Rows[index].Cells["Total"].Value = (getcost(p.Barcode) * quantity).ToString("n2");
                dataGridView2.Rows[index].Cells["piecesPerCase"].Value = proveedor.getProductInfo(p.Barcode).Rows[0]["Piezas Por Caja"];
                dataGridView2.Rows[index].Cells["amount"].ReadOnly = false;
                dataGridView2.Rows[index].Cells["Depot"].ReadOnly = false;
                dataGridView2.Rows[index].Cells["Depot"].Value = p.defaultDepotID;
                dataGridView2.CurrentCell = dataGridView2.Rows[dataGridView2.RowCount - 1].Cells["description"];


            }
            else //integrates the given product to an existing row
            {
                double totalAmountOfPieces = Convert.ToDouble(dataGridView2.Rows[rowIndex].Cells["amount"].Value);

                dataGridView2.Rows[rowIndex].Cells["amount"].Value = (totalAmountOfPieces + quantity).ToString("n2");
                dataGridView2.Rows[rowIndex].Cells["Total"].Value = ((totalAmountOfPieces + quantity) * getcost(p.Barcode)).ToString("n2");
                dataGridView2.CurrentCell = dataGridView2.Rows[rowIndex].Cells["description"];
            }

            countTotalofProducts();

        }

        private async void countTotalofProducts()
        {
            double total = await Task.Run(() => getnumber(dataGridView2));
            casescountLbl.Text = "Total de productos: " + total.ToString("n2");
        }
        private double getnumber(DataGridView dataGridView)
        {
            double x = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                x += Convert.ToDouble(row.Cells["amount"].Value);
                
            }
            return x;
        }

        private double getcost(string barcode)
        {
            foreach (DataRow row in proveedor.productList.Rows)
            {
                if (row[0].ToString().ToLower() == barcode)
                    return Convert.ToDouble(row[7]);
            }
            return 0;
        }

        private void ProductTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int startIndex = this.ProductTxt.Text.IndexOf('*');

            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' && startIndex > -1) &&
                (e.KeyChar != '-' && startIndex > -1) &&
                this.ProductTxt.SelectionStart > startIndex)
                e.Handled = true;

            if (startIndex <= -1)
                return;

            string str = this.ProductTxt.Text.Substring(startIndex);

            if (e.KeyChar == '-' && str.IndexOf("-") > -1)
                e.Handled = true;

            if (e.KeyChar == '.' && str.IndexOf(".") > -1)
                e.Handled = true;
        }

        private void ProductTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode != Keys.Return)
            {
                this.ProductTxt.Text += new KeysConverter().ConvertToString((object)e.KeyCode);
                this.ProductTxt.SelectionStart = this.ProductTxt.Text.Length;
            }
            if (e.KeyCode != Keys.Return)
                return;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.RowCount > 0 && e.ColumnIndex == dataGridView2.Columns["amount"].Index)
            {
                try
                {
                    double amount = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["amount"].Value);
                    dataGridView2.Rows[e.RowIndex].Cells["Total"].Value = (amount * proveedor.getcost(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString())).ToString("n2");
                }
                catch (FormatException)
                {
                    dataGridView2.Rows[e.RowIndex].Cells["amount"].Value = "0.00";
                    dataGridView2.Rows[e.RowIndex].Cells["total"].Value = "0.00";

                    double total = 0;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        total += Convert.ToDouble(row.Cells["Total"].Value);
                    }

                    this.grandTotalLbl.Text = "Total = $" + total.ToString("n2");
                }
            }
            countTotalofProducts();
            ProductTxt.Focus();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.RowCount > 0 && e.ColumnIndex == dataGridView2.Columns["amount"].Index)

                try
                {
                    proveedor.SupplierUpdateQuantities(dataGridView2.Rows[e.RowIndex].Cells["barcode"].Value.ToString(), Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["amount"].Value));
                }
                catch (FormatException)
                {
                    proveedor.SupplierUpdateQuantities(dataGridView2.Rows[e.RowIndex].Cells["barcode"].Value.ToString(), 0);

                }

            this.grandTotalLbl.Text = "Total = $" + calculateNextPurchaseTotal().ToString("n2");
        }

        private double calculateNextPurchaseTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }

            return total;
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            var currentCell = dataGridView2.CurrentCell;
            if (currentCell != null)
            {
                if (currentCell.ColumnIndex != dataGridView2.Columns["amount"].Index)
                    ProductTxt.Focus();
                else
                    dataGridView2.BeginEdit(true);
            }
        }

        private void RemindersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FilteringTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (this.FilteringTextbox.Text != "")
                        this.dataGridView1.DataSource = this.proveedor.SupplierFilterProducts(this.FilteringTextbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo completar la acción.\nError:", "Error" + ex.Message, MessageBoxButtons.OK);
                }
                if (FilteringTextbox.Text != "")
                    return;
                this.dataGridView1.DataSource = this.proveedor.GetSupplierProductList();
            }
            if (e.KeyCode == Keys.Up)
            {
                if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index > 0)
                {
                    var cell = dataGridView1.CurrentCell;
                    dataGridView1.CurrentCell = dataGridView1[cell.ColumnIndex, cell.RowIndex - 1];
                }
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
                {
                    var cell = dataGridView1.CurrentCell;
                    dataGridView1.CurrentCell = dataGridView1[cell.ColumnIndex, cell.RowIndex + 1];
                }
                e.SuppressKeyPress = true;
            }
            if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow != null && e.KeyCode == Keys.F2)
            {
                dataGridView1_CellDoubleClick(this, null);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.Left) && SupplierInfromationPanel.Visible)
                bunifuImageButton1_Click(this, null);

            if (dataGridView2.Visible && dataGridView2.RowCount > 0 && dataGridView2.CurrentRow != null)
            {
                if (keyData == (Keys.F3))
                {
                    dataGridView2.CurrentCell = dataGridView2.CurrentRow.Cells["depot"];
                    dataGridView2.BeginEdit(true);
                }

                if (keyData == (Keys.Delete | Keys.Alt))
                {
                    proveedor.SupplierUpdateQuantities(dataGridView2.CurrentRow.Cells["barcode"].Value.ToString(), 0);
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                    countTotalofProducts();
                    this.grandTotalLbl.Text = "Total = $" + calculateNextPurchaseTotal().ToString("n2");
                }
            }

            if (!dataGridView1.Visible && !dataGridView2.Visible)
            {
                if (keyData == Keys.Right)
                {
                    try
                    {
                        flow1.Controls[++currentSupplierButon].Select();

                    }
                    catch (Exception) 
                    {
                        if (flow1.Controls.Count > 0 && currentSupplierButon >= flow1.Controls.Count)
                        {
                            currentSupplierButon = 0;
                            flow1.Controls[currentSupplierButon].Select();
                        }
                    }
                }
                if (keyData == Keys.Left)
                {
                    try
                    {
                        flow1.Controls[--currentSupplierButon].Select();
                    }
                    catch (Exception)
                    {
                        if(flow1.Controls.Count>0 && currentSupplierButon<0)
                        {
                            currentSupplierButon = flow1.Controls.Count - 1;
                            flow1.Controls[currentSupplierButon].Select();
                        }
                    }
                }
                if (keyData == (Keys.Enter|Keys.Alt) && flow1.Controls.Count > 0)
                    SupplierbuttonClick(flow1.Controls[currentSupplierButon], null);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
                Proveedor.GetProductCostComparison(dataGridView1.Rows[e.RowIndex].Cells["Código de Barras"].Value.ToString()).Tables[0].Rows.Count > 1)
            {
                tip.GetToolTip(this);
                tip.Show(dataGridView1.Rows[e.RowIndex].Cells["Código de Barras"].Value.ToString(), this, new Point(this.Width + 100, 200));
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            tip.Hide(this);
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            tip.Hide(this);
        }


        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Código de Barras"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            int height = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (height < item.Height)
                    height = item.Height;
            }
            dataGridView1.RowTemplate.MinimumHeight = height;
        }

        private void proccedPurchaseBtn_Click(object sender, EventArgs e)
        {
            bool num1 = false;

            dataGridView2.EndEdit();

            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {
                if (Convert.ToDouble(row.Cells["amount"].Value) != 0)
                {
                    num1 = true;
                    break;
                }
            }

            if (!num1)
                MessageBox.Show("Agregue productos para generar la orden de compra");

            else
            {
                payPurchase();
            }
        }

        void payPurchase()
        {
            var total = Convert.ToDouble(this.grandTotalLbl.Text.Substring(this.grandTotalLbl.Text.IndexOf("$") + 1));
            PanelProveedor_GeneratePO newPO = new PanelProveedor_GeneratePO(this.proveedor, this.EmployeeID, total > 0 ? total : 0, 2);
            DarkForm dk = new DarkForm();
            dk.Show();
            if (newPO.ShowDialog() == DialogResult.OK)
            {

                OrdenCompra PO = new OrdenCompra(newPO.PO_ID) { delivered = true };

                addItemsToPurchase(PO.ID);
                if (newPO.Total != 0)
                    printAndOpenCashDrawer(PO.pay);

                PO._EmployeeWhoConfirmedThePurchaseID = EmployeeID;
                PO.updateDeliveryStatus();

                resetPurchase();

                this.grandTotalLbl.Text = "Total = $" + 0.ToString("n2");


                if (this.FilteringTextbox.Text != "")
                    this.dataGridView1.DataSource = this.proveedor.SupplierFilterProducts(this.FilteringTextbox.Text);
                else
                    dataGridView1.DataSource = proveedor.GetSupplierProductList();
            }
            dk.Close();
        }

        private void SearchSupplierTxt_Leave(object sender, EventArgs e)
        {
            //SearchSupplierTxt.Select();
        }

        private void SearchSupplierTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter && SearchSupplierTxt.Text.Trim()!="")
            {
                SearchSupplier();
            }
        }

        private void SearchSupplier()
        {
            if (this.SearchSupplierTxt.Text != "")
            {
                flow1.Controls.Clear();
                flow1.Controls.AddRange(PopulateContainer(SearchSupplierTxt.Text));
                foreach (Control control in this.flow1.Controls)
                {
                    new BunifuElipse()
                    {
                        ElipseRadius = 20,
                        TargetControl = control
                    }.ApplyElipse();
                }
            }
            else
            {
                flow1.Controls.Clear();
                loadSupplierList();
            }
            currentSupplierButon = 0;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el proveedor?. La información relacionada se perderá", "Borrar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                proveedor.Delete();
                bunifuImageButton1_Click(this, null);
                flow1.Controls.Clear();
                loadSupplierList();

            }
        }

        private void dataGridView2_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            int height = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (height < item.Height)
                    height = item.Height;
            }
            dataGridView1.RowTemplate.MinimumHeight = height;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setPurchaseStatistics();
        }

        private void setPurchaseStatistics()
        {
            setPurchaseChart();
        }

        private void setPurchaseChart()
        {
            Proveedor.PeriodOfTime period;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
                case 1:
                    period = Proveedor.PeriodOfTime.ByMonth;
                    break;
                case 2:
                    period = Proveedor.PeriodOfTime.ByYear;
                    break;

                default:
                    period = Proveedor.PeriodOfTime.ByDays;
                    break;
            }

            DataTable dt = proveedor.getPurchaseStatistics(dateTimePicker1.Value, period);
           
            this.purchaseChart.Series.Clear();
            this.purchaseChart.AxisX.Clear();
            this.purchaseChart.AxisY.Clear();
            this.purchaseChart.Zoom = ZoomingOptions.X;
            this.purchaseChart.Pan = PanningOptions.Unset;

            ChartValues<double> chartValues1 = new ChartValues<double>();
            ChartValues<double> chartValues2 = new ChartValues<double>();
            List<string> stringList = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                chartValues1.Add(Convert.ToDouble(row["Total"]));
                chartValues2.Add(Convert.ToDouble(row["Abono"]));
                stringList.Add(row["Fecha"].ToString());
            }
            LiveCharts.SeriesCollection series1 = this.purchaseChart.Series;
            LineSeries lineSeries1 = new LineSeries();
            lineSeries1.Title = "Compra";
            lineSeries1.Values = chartValues1;

            LineSeries lineSeries2 = lineSeries1;
            series1.Add(lineSeries2);
            SeriesCollection series2 = this.purchaseChart.Series;

            LineSeries lineSeries3 = new LineSeries();
            lineSeries3.Title = "Pago realizado";
            lineSeries3.Values = chartValues2;

            LineSeries lineSeries4 = lineSeries3;

            series2.Add((ISeriesView)lineSeries4);
            this.purchaseChart.AxisX.Add(new Axis()
            {
                Title = "Fecha",
                Labels = (IList<string>)stringList
            });
            this.purchaseChart.AxisY.Add(new Axis()
            {
                Title = "Cantidad",
                LabelFormatter = (Func<double, string>)(value => value.ToString("N")),
                MinValue = 0.0
            });


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setPurchaseChart();
        }
    }

    class supplierProductsToolTip : ToolTip
    {
        
        public supplierProductsToolTip()
        {
            OwnerDraw = true;

           this.Popup += new PopupEventHandler(onPupup);
            this.Draw += new DrawToolTipEventHandler(onDraw);
        }

        private void onPupup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(200, 200);
        }

        private void onDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.LightYellow, e.Bounds);

            DataSet product = Proveedor.GetProductCostComparison(e.ToolTipText);
            
            int distance = 0;

            var text = "Precio por Pieza";
            var font = PrinterTicket.getFont(text, 200);
            g.DrawString(text, font, Brushes.Black, (200 - PrinterTicket.getStringSize(text, font).Width) / 2, 0);

            distance += 40;

            foreach (DataRow row in product.Tables[0].Rows)
            {
                double cost = Convert.ToDouble(row["Precio de Compra por Pieza"]);
                int height = 0;

                if (cost == Convert.ToDouble(product.Tables[1].Rows[0]["Minimo"]) && product.Tables[0].Rows.Count > 1)
                {
                    var name = string.Format("{0}: ${1}", row["Nombre de la empresa"].ToString(), Convert.ToDouble(row["Precio de Compra por Pieza"]).ToString("n2"));
                    font = new Font("Times new roman", 12f, FontStyle.Bold);
                    if (PrinterTicket.getStringSize(name, font).Width > 200)
                        name = name.Insert(PrinterTicket.getLastLetterByMeasuring(name, font, 200), "\r\n");
                    g.DrawString(name, font, Brushes.LimeGreen, 0, distance);
                    height = PrinterTicket.getStringSize(name, font).Height;
                }
                else if (cost == Convert.ToDouble(product.Tables[1].Rows[0]["Maximo"]) && product.Tables[0].Rows.Count > 1)
                {
                    var name = string.Format("{0}: ${1}", row["Nombre de la empresa"].ToString(), Convert.ToDouble(row["Precio de Compra por Pieza"]).ToString("n2"));
                    font = new Font("Times new roman", 12f, FontStyle.Bold);
                    if (PrinterTicket.getStringSize(name, font).Width > 200)
                        name = name.Insert(PrinterTicket.getLastLetterByMeasuring(name, font, 200), "\r\n");
                    g.DrawString(name, font, Brushes.Red, 0, distance);

                    height = PrinterTicket.getStringSize(name, font).Height;
                }
                else
                {
                    continue;
                }
                font.Dispose();
                distance += 5 + height;
            }
            g.Dispose();
            product.Dispose();
        }

        
    }

}
