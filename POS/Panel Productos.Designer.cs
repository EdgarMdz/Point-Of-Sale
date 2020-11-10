using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS
{
    partial class Panel_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.ProductListPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AddBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TransferStockBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mixedCaseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.promoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.wholesaleCostsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.moreOptionsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.NewDepotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.burgerBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.scrapBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel4.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.ProductListPanel.SuspendLayout();
            this.helpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferStockBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixedCaseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleCostsBtn)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.moreOptionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1505, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 6;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel3.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1557, 25);
            this.bunifuGradientPanel3.TabIndex = 8;
            this.bunifuGradientPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel3_Paint);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1534, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 5;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ProductPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1557, 794);
            this.panel4.TabIndex = 13;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ProductListPanel);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(1557, 794);
            this.ProductPanel.TabIndex = 10;
            // 
            // ProductListPanel
            // 
            this.ProductListPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductListPanel.BackgroundImage")));
            this.ProductListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductListPanel.Controls.Add(this.helpPanel);
            this.ProductListPanel.Controls.Add(this.dataGridView1);
            this.ProductListPanel.Controls.Add(this.bunifuGradientPanel1);
            this.ProductListPanel.Controls.Add(this.bunifuGradientPanel4);
            this.ProductListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductListPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.ProductListPanel.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.ProductListPanel.GradientTopLeft = System.Drawing.Color.White;
            this.ProductListPanel.GradientTopRight = System.Drawing.Color.White;
            this.ProductListPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductListPanel.Name = "ProductListPanel";
            this.ProductListPanel.Quality = 10;
            this.ProductListPanel.Size = new System.Drawing.Size(1557, 794);
            this.ProductListPanel.TabIndex = 7;
            // 
            // helpPanel
            // 
            this.helpPanel.Controls.Add(this.dataGridView2);
            this.helpPanel.Controls.Add(this.panel2);
            this.helpPanel.Location = new System.Drawing.Point(892, 183);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(338, 258);
            this.helpPanel.TabIndex = 14;
            this.helpPanel.Visible = false;
            this.helpPanel.VisibleChanged += new System.EventHandler(this.helpPanel_VisibleChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.description,
            this.pieces});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(338, 214);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellMouseEnter);
            this.dataGridView2.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValidated);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.Leave += new System.EventHandler(this.dataGridView2_Leave);
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcode.HeaderText = "Código de Barras";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 93;
            // 
            // pieces
            // 
            this.pieces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pieces.HeaderText = "Piezas en Stock";
            this.pieces.Name = "pieces";
            this.pieces.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pieces.Width = 71;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 44);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(117, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(76, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1479, 727);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowHeightChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.AddBtn);
            this.bunifuGradientPanel1.Controls.Add(this.EditProduct);
            this.bunifuGradientPanel1.Controls.Add(this.DeleteButton);
            this.bunifuGradientPanel1.Controls.Add(this.TransferStockBtn);
            this.bunifuGradientPanel1.Controls.Add(this.mixedCaseBtn);
            this.bunifuGradientPanel1.Controls.Add(this.promoBtn);
            this.bunifuGradientPanel1.Controls.Add(this.wholesaleCostsBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 65);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(76, 727);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Image = global::POS.Properties.Resources.plus;
            this.AddBtn.ImageActive = null;
            this.AddBtn.Location = new System.Drawing.Point(13, 16);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 50);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBtn.TabIndex = 100;
            this.AddBtn.TabStop = false;
            this.AddBtn.Zoom = 10;
            this.AddBtn.Click += new System.EventHandler(this.AddButton_Click);
            this.AddBtn.MouseHover += new System.EventHandler(this.AddBtn_MouseHover);
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.Color.Transparent;
            this.EditProduct.Image = global::POS.Properties.Resources.edit;
            this.EditProduct.ImageActive = null;
            this.EditProduct.Location = new System.Drawing.Point(13, 132);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(50, 50);
            this.EditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditProduct.TabIndex = 2;
            this.EditProduct.TabStop = false;
            this.EditProduct.Visible = false;
            this.EditProduct.Zoom = 10;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            this.EditProduct.MouseHover += new System.EventHandler(this.ActionBtn_MouseHover);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Image = global::POS.Properties.Resources.delete;
            this.DeleteButton.ImageActive = null;
            this.DeleteButton.Location = new System.Drawing.Point(13, 364);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Zoom = 10;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseHover += new System.EventHandler(this.ActionBtn_MouseHover);
            // 
            // TransferStockBtn
            // 
            this.TransferStockBtn.BackColor = System.Drawing.Color.Transparent;
            this.TransferStockBtn.Image = global::POS.Properties.Resources._switch;
            this.TransferStockBtn.ImageActive = null;
            this.TransferStockBtn.Location = new System.Drawing.Point(13, 248);
            this.TransferStockBtn.Name = "TransferStockBtn";
            this.TransferStockBtn.Size = new System.Drawing.Size(50, 50);
            this.TransferStockBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TransferStockBtn.TabIndex = 3;
            this.TransferStockBtn.TabStop = false;
            this.TransferStockBtn.Visible = false;
            this.TransferStockBtn.Zoom = 10;
            this.TransferStockBtn.Click += new System.EventHandler(this.TransferStockBtn_Click);
            this.TransferStockBtn.MouseHover += new System.EventHandler(this.ActionBtn_MouseHover);
            // 
            // mixedCaseBtn
            // 
            this.mixedCaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.mixedCaseBtn.Image = ((System.Drawing.Image)(resources.GetObject("mixedCaseBtn.Image")));
            this.mixedCaseBtn.ImageActive = null;
            this.mixedCaseBtn.Location = new System.Drawing.Point(12, 480);
            this.mixedCaseBtn.Name = "mixedCaseBtn";
            this.mixedCaseBtn.Size = new System.Drawing.Size(50, 50);
            this.mixedCaseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixedCaseBtn.TabIndex = 4;
            this.mixedCaseBtn.TabStop = false;
            this.mixedCaseBtn.Visible = false;
            this.mixedCaseBtn.Zoom = 10;
            this.mixedCaseBtn.Click += new System.EventHandler(this.mixedCaseBtn_Click);
            this.mixedCaseBtn.MouseHover += new System.EventHandler(this.ActionBtn_MouseHover);
            // 
            // promoBtn
            // 
            this.promoBtn.BackColor = System.Drawing.Color.Transparent;
            this.promoBtn.Image = global::POS.Properties.Resources.discount;
            this.promoBtn.ImageActive = null;
            this.promoBtn.Location = new System.Drawing.Point(11, 501);
            this.promoBtn.Name = "promoBtn";
            this.promoBtn.Size = new System.Drawing.Size(50, 50);
            this.promoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.promoBtn.TabIndex = 5;
            this.promoBtn.TabStop = false;
            this.promoBtn.Visible = false;
            this.promoBtn.Zoom = 10;
            this.promoBtn.Click += new System.EventHandler(this.promoBtn_Click);
            // 
            // wholesaleCostsBtn
            // 
            this.wholesaleCostsBtn.BackColor = System.Drawing.Color.Transparent;
            this.wholesaleCostsBtn.Image = global::POS.Properties.Resources.wholesale1;
            this.wholesaleCostsBtn.ImageActive = null;
            this.wholesaleCostsBtn.Location = new System.Drawing.Point(11, 596);
            this.wholesaleCostsBtn.Name = "wholesaleCostsBtn";
            this.wholesaleCostsBtn.Size = new System.Drawing.Size(50, 50);
            this.wholesaleCostsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wholesaleCostsBtn.TabIndex = 101;
            this.wholesaleCostsBtn.TabStop = false;
            this.wholesaleCostsBtn.Visible = false;
            this.wholesaleCostsBtn.Zoom = 10;
            this.wholesaleCostsBtn.Click += new System.EventHandler(this.wholesaleCostsBtn_Click);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.moreOptionsPanel);
            this.bunifuGradientPanel4.Controls.Add(this.burgerBtn);
            this.bunifuGradientPanel4.Controls.Add(this.scrapBtn);
            this.bunifuGradientPanel4.Controls.Add(this.label1);
            this.bunifuGradientPanel4.Controls.Add(this.SearchTxt);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(1555, 65);
            this.bunifuGradientPanel4.TabIndex = 8;
            // 
            // moreOptionsPanel
            // 
            this.moreOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moreOptionsPanel.Controls.Add(this.panel1);
            this.moreOptionsPanel.Location = new System.Drawing.Point(1223, 8);
            this.moreOptionsPanel.Name = "moreOptionsPanel";
            this.moreOptionsPanel.Size = new System.Drawing.Size(274, 51);
            this.moreOptionsPanel.TabIndex = 112;
            this.moreOptionsPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.NewDepotBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 51);
            this.panel1.TabIndex = 113;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(225, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 46);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 112;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton2, "Importar Productos desde Excel");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // NewDepotBtn
            // 
            this.NewDepotBtn.ActiveBorderThickness = 1;
            this.NewDepotBtn.ActiveCornerRadius = 20;
            this.NewDepotBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NewDepotBtn.ActiveForecolor = System.Drawing.Color.White;
            this.NewDepotBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NewDepotBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewDepotBtn.BackColor = System.Drawing.Color.White;
            this.NewDepotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewDepotBtn.BackgroundImage")));
            this.NewDepotBtn.ButtonText = "Nueva Bodega";
            this.NewDepotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewDepotBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDepotBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.NewDepotBtn.IdleBorderThickness = 1;
            this.NewDepotBtn.IdleCornerRadius = 20;
            this.NewDepotBtn.IdleFillColor = System.Drawing.Color.White;
            this.NewDepotBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NewDepotBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NewDepotBtn.Location = new System.Drawing.Point(10, 5);
            this.NewDepotBtn.Margin = new System.Windows.Forms.Padding(5);
            this.NewDepotBtn.Name = "NewDepotBtn";
            this.NewDepotBtn.Size = new System.Drawing.Size(181, 40);
            this.NewDepotBtn.TabIndex = 110;
            this.NewDepotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.NewDepotBtn, "Crear nueva bodega");
            this.NewDepotBtn.Click += new System.EventHandler(this.NewDepotBtn_Click);
            // 
            // burgerBtn
            // 
            this.burgerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.burgerBtn.BackColor = System.Drawing.Color.Transparent;
            this.burgerBtn.Image = global::POS.Properties.Resources.Hamburger_icon_svg;
            this.burgerBtn.ImageActive = null;
            this.burgerBtn.Location = new System.Drawing.Point(1504, 17);
            this.burgerBtn.Name = "burgerBtn";
            this.burgerBtn.Size = new System.Drawing.Size(30, 30);
            this.burgerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.burgerBtn.TabIndex = 111;
            this.burgerBtn.TabStop = false;
            this.burgerBtn.Zoom = 10;
            this.burgerBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // scrapBtn
            // 
            this.scrapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.scrapBtn.FlatAppearance.BorderSize = 0;
            this.scrapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrapBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapBtn.ForeColor = System.Drawing.Color.White;
            this.scrapBtn.Location = new System.Drawing.Point(30, 12);
            this.scrapBtn.Name = "scrapBtn";
            this.scrapBtn.Size = new System.Drawing.Size(171, 40);
            this.scrapBtn.TabIndex = 2;
            this.scrapBtn.Text = "Scrap";
            this.scrapBtn.UseVisualStyleBackColor = false;
            this.scrapBtn.Click += new System.EventHandler(this.scrapBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(515, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.SearchTxt.Location = new System.Drawing.Point(622, 12);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(417, 40);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            this.SearchTxt.Enter += new System.EventHandler(this.SearchTxt_Enter);
            this.SearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown);
            // 
            // Panel_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1557, 819);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Panel_Productos";
            this.ShowInTaskbar = false;
            this.Text = "Inventario | Point of Sale";
            this.Load += new System.EventHandler(this.Panel_Productos_Load);
            this.Shown += new System.EventHandler(this.Panel_Productos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductListPanel.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferStockBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixedCaseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleCostsBtn)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.moreOptionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private System.Windows.Forms.Panel panel4;
        private Panel ProductPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel ProductListPanel;
        private DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton promoBtn;
        private Bunifu.Framework.UI.BunifuImageButton mixedCaseBtn;
        private Bunifu.Framework.UI.BunifuImageButton TransferStockBtn;
        private Bunifu.Framework.UI.BunifuImageButton EditProduct;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Label label1;
        private TextBox SearchTxt;
        private Button scrapBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 NewDepotBtn;
        private Bunifu.Framework.UI.BunifuImageButton DeleteButton;
        private Bunifu.Framework.UI.BunifuImageButton AddBtn;
        private Bunifu.Framework.UI.BunifuImageButton wholesaleCostsBtn;
        private Panel moreOptionsPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton burgerBtn;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Panel helpPanel;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn pieces;
        private Panel panel2;
        private Button button1;
    }
}