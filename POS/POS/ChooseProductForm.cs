using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.70);
            CenterToScreen();
            setColumnsInTable();
            addProductsToTable();


            this.dataGridView1.Columns["Stock"].Visible = false;
            this.dataGridView1.Columns["Stock Mínimo"].Visible = false;
            this.dataGridView1.Columns["Código de Barras"].Visible = true;


            this.resizeGridView();
            dataGridView1.Select();

            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[1, 0];
                tip.GetToolTip(this);
                int reference = (Screen.PrimaryScreen.Bounds.Height - this.Height)/2;

                tip.Show(dataGridView1.Rows[0].Cells["Código de Barras"].Value.ToString(), this, new Point(this.Width, reference-tip.Height / 2 < 0 ? 0 : -tip.Height / 2));
            }
        }
    

        private void setColumnsInTable()
        {
            dataGridView1.Columns.Clear();
            foreach (DataColumn column in products.Columns)
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = column.ColumnName });
        }

        private void addProductsToTable()
        { 
            while(dataGridView1.RowCount+1<=products.Rows.Count)
            {
                var index = dataGridView1.Rows.Add();

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    dataGridView1[column.Index, index].Value = products.Rows[index][column.Index];
                }
            }
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
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(217, 226, 243);

                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

                i++;
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["Precio Menudeo"].HeaderText = "Precio";
            this.dataGridView1.Columns["Código de Barras"].DisplayIndex = 0;
            this.dataGridView1.Columns["Precio de Compra por Pieza"].Visible = emp != null && emp.isAdmin;

            this.dataGridView1.Columns["Código de Barras"].Frozen = true;
            this.dataGridView1.Columns["Descripción"].Frozen = true;
            this.dataGridView1.Columns["Marca"].Frozen = true;

            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            resizeGridView();


            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Select();
            }
        }

        private void resizeGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if(dataGridView1.Columns["descripción"].Width<=200)
                    dataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
            var barcode = dataGridView1.Rows[e.RowIndex].Cells["Código de Barras"].Value;
            if (dataGridView1.RowCount > 0 && barcode!=null)
            {
                tip.GetToolTip(this);
                int reference = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                tip.Show(barcode.ToString(), this, new Point(this.Width,reference -tip.Height / 2 < 0 ? 0 : -tip.Height / 2));
            }
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

        private void panel2_Resize(object sender, EventArgs e)
        {
            var resolution = Screen.PrimaryScreen.Bounds;

            if (resolution == new Rectangle(0, 0, 1366, 768))
            {
                this.Size = new Size(1024, 384);
                label1.Font = new Font("Century Gothic", 26);
                centerToParent(label1);
                bunifuImageButton1.Location = new Point(panel2.Width - 10 - bunifuImageButton1.Width, 10);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                button1.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                button1.Size = new Size(169, 41);
                panel3.Width = this.Width;
                centerToParent(button1);
            }

            tip.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.15) - 10;
        }

        private void centerToParent(Control control)
        {
            var parent = control.Parent;
            if(parent!=null)
            {
                control.Location = new Point((parent.Width - control.Width) / 2, (parent.Height - control.Height) / 2);
            }
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
    }

    class CustomTooltip : ToolTip
    {
        int side = 200;
        public int Height { get { return side; } set { side = value; } }
        public int Width { get { return side; } set { side = value; } }

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

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255,255,255)))
            {
                g.FillRectangle(brush, 0, 0, side, side);
            }

            //g.FillRectangle(brush, e.Bounds);
            if (image != null)
            {
                if (image.Height > image.Width)
                {
                    int imHeight = side;
                    int imWidth = image.Width * side / image.Height;

                    g.DrawImage(image, new Rectangle((side-imWidth)/2, 0, imWidth, imHeight));
                }
                else
                {
                    int imHeight = image.Height * side / image.Width;
                    int imWidth = side;

                    g.DrawImage(image, new Rectangle(0, (side - imHeight) / 2, imWidth, imHeight));
                }
            }

        }

        private void onPupup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(side, side);
        }
    }
}
