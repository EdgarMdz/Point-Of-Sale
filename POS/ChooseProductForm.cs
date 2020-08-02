using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace POS
{
    public partial class ChooseProductForm : Form
    {
        public string[] selectedItem = new string[5];
        CustomTooltip tip;

        public DataTable products { set; get; }

        Empleado emp;
        public ChooseProductForm()
        {
            this.InitializeComponent();
            tip = new CustomTooltip();
        }

        public ChooseProductForm(DataTable products, Empleado empleado)
        {
            this.InitializeComponent();
            tip = new CustomTooltip();
            this.products = products;
            emp = empleado;
        }

        public ChooseProductForm(DataTable products)
        {
            this.InitializeComponent();
            this.products = products;
            tip = new CustomTooltip();
        }

        private void ChooseProductForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = products.Rows.Count < 60 ? products : products.Rows.Cast<DataRow>().Take(60).CopyToDataTable();


            this.dataGridView1.Columns["Stock"].Visible = false;
            this.dataGridView1.Columns["Stock Mínimo"].Visible = false;
            this.dataGridView1.Columns["Código de Barras"].Visible = true;

            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[1, 0];
                tip.GetToolTip(this);
                tip.Show(dataGridView1.Rows[0].Cells["Código de Barras"].Value.ToString(), this, new Point(this.Width, -tip.Height / 2));
            }
            this.resizeGridView();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.openProduct();
        }

        private void openProduct()
        {
            if (this.dataGridView1.CurrentCell == null)
                return;
            int index = this.dataGridView1.CurrentCell.OwningRow.Index;
            this.selectedItem[0] = this.dataGridView1.Rows[index].Cells["Código de Barras"].Value.ToString();
            this.selectedItem[1] = this.dataGridView1.Rows[index].Cells["Descripción"].Value.ToString();
            this.selectedItem[2] = this.dataGridView1.Rows[index].Cells["Marca"].Value.ToString();
            this.selectedItem[3] = this.dataGridView1.Rows[index].Cells["Stock Mínimo"].Value.ToString();
            this.selectedItem[4] = this.dataGridView1.Rows[index].Cells["Stock"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.openProduct();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in (IEnumerable)this.dataGridView1.Rows)
            {
                if (row.Visible)
                {
                    if (row.Index % 2 == 0)
                        row.DefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["Precio Menudeo"].HeaderText = "Precio";
            this.dataGridView1.Columns["Código de Barras"].DisplayIndex = 0;
            this.dataGridView1.Columns["Precio de Compra por Pieza"].Visible = emp != null && emp.isAdmin;

            this.resizeGridView();

            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Select();
            }
        }

        private void resizeGridView()
        {
            int num = 0;
            foreach (DataGridViewColumn column in (BaseCollection)this.dataGridView1.Columns)
            {
                if (column.Visible)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    num += column.Width;
                }
            }
            if (num >= this.dataGridView1.Width)
                return;
            this.dataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            this.resizeGridView();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            this.openProduct();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (keyData != Keys.Return)
                return base.ProcessCmdKey(ref msg, keyData);
            this.openProduct();
            return true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tip.GetToolTip(this);
            tip.Show(dataGridView1.Rows[e.RowIndex].Cells["Código de Barras"].Value.ToString(), this, new Point(this.Width, -tip.Height / 2));

        }


        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (tip != null)
                tip.Hide(this);
        }

        private void ChooseProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tip.Dispose();
            dataGridView1.Dispose();
        }
    }

    class CustomTooltip : ToolTip
    {
        const int side = 200;
        public int Height { get { return side; } }
        public int Width { get { return side; } }

        public CustomTooltip()
        {
            OwnerDraw = true;

            this.Popup += new PopupEventHandler(onPupup);
            this.Draw += new DrawToolTipEventHandler(onDraw);
        }

        private void onDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = new Producto(e.ToolTipText).image;

            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));

            //g.FillRectangle(brush, e.Bounds);
            if (image != null)
            {
                if (image.Height > image.Width)
                {
                    int imHeight = side;
                    int imWidth = image.Width * side / image.Height;

                    g.DrawImage(image, new Rectangle(0, 0, imWidth, imHeight));
                }
                else
                {
                    int imHeight = image.Height * side / image.Width;
                    int imWidth = side;

                    g.DrawImage(image, new Rectangle(0, (side - imHeight) / 2, imWidth, imHeight));
                }
            }
            brush.Dispose();
        }

        private void onPupup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(side, side);
        }
    }
}
