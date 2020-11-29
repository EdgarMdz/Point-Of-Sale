using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Ventas));
            this.LastSaleElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LastSaleBtn = new System.Windows.Forms.Button();
            this.LookForTicketBtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.refoundBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CanceledLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refound = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WholesaleDiscountApplied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AmountProdctsLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nextTicketBtn = new System.Windows.Forms.Button();
            this.previousTicketBtn = new System.Windows.Forms.Button();
            this.ProductTxt = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.customerPaymentDocument = new System.Drawing.Printing.PrintDocument();
            this.saleCancelledDocument = new System.Drawing.Printing.PrintDocument();
            this.packageReturnedDocument = new System.Drawing.Printing.PrintDocument();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearCustomerBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.debtLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CustomerPaymentBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.printTicketBtn = new System.Windows.Forms.Button();
            this.EmployeeCanceldSaleLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelationDateLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeNameLbl = new System.Windows.Forms.Label();
            this.dateOfSaleLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReturnPackagesBtn = new System.Windows.Forms.Button();
            this.ticketGrupbox = new System.Windows.Forms.GroupBox();
            this.printCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelSaleBtn = new System.Windows.Forms.Button();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.lessBtn = new System.Windows.Forms.Button();
            this.moreBtn = new System.Windows.Forms.Button();
            this.CobrarBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.newWindowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.autoGrouping = new System.Windows.Forms.CheckBox();
            this.discountList = new System.Windows.Forms.Button();
            this.discountBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reprintElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OkBtn = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.alterCostTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCustomerBtn)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ticketGrupbox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newWindowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBtn)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // LastSaleElipse
            // 
            this.LastSaleElipse.ElipseRadius = 10;
            this.LastSaleElipse.TargetControl = this.LastSaleBtn;
            // 
            // LastSaleBtn
            // 
            this.LastSaleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastSaleBtn.AutoSize = true;
            this.LastSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.LastSaleBtn.FlatAppearance.BorderSize = 0;
            this.LastSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastSaleBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastSaleBtn.ForeColor = System.Drawing.Color.White;
            this.LastSaleBtn.Location = new System.Drawing.Point(61, 12);
            this.LastSaleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LastSaleBtn.Name = "LastSaleBtn";
            this.LastSaleBtn.Size = new System.Drawing.Size(297, 46);
            this.LastSaleBtn.TabIndex = 6;
            this.LastSaleBtn.Text = "Última Venta";
            this.toolTip1.SetToolTip(this.LastSaleBtn, "Mostrar Última Venta\r\nAlt + U");
            this.LastSaleBtn.UseVisualStyleBackColor = false;
            this.LastSaleBtn.Click += new System.EventHandler(this.LastSaleBtn_Click);
            // 
            // LookForTicketBtn
            // 
            this.LookForTicketBtn.ElipseRadius = 10;
            this.LookForTicketBtn.TargetControl = this.refoundBtn;
            // 
            // refoundBtn
            // 
            this.refoundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refoundBtn.AutoSize = true;
            this.refoundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.refoundBtn.FlatAppearance.BorderSize = 0;
            this.refoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refoundBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refoundBtn.ForeColor = System.Drawing.Color.White;
            this.refoundBtn.Location = new System.Drawing.Point(61, 80);
            this.refoundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refoundBtn.Name = "refoundBtn";
            this.refoundBtn.Size = new System.Drawing.Size(297, 46);
            this.refoundBtn.TabIndex = 8;
            this.refoundBtn.Text = "Buscar Ticket";
            this.toolTip1.SetToolTip(this.refoundBtn, "Buscar Ticket\r\nAlt + B");
            this.refoundBtn.UseVisualStyleBackColor = false;
            this.refoundBtn.Click += new System.EventHandler(this.refoundBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CanceledLbl);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.AmountProdctsLbl);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 1050);
            this.panel1.TabIndex = 40;
            // 
            // CanceledLbl
            // 
            this.CanceledLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CanceledLbl.AutoSize = true;
            this.CanceledLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CanceledLbl.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceledLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.CanceledLbl.Location = new System.Drawing.Point(158, 469);
            this.CanceledLbl.Name = "CanceledLbl";
            this.CanceledLbl.Size = new System.Drawing.Size(577, 112);
            this.CanceledLbl.TabIndex = 43;
            this.CanceledLbl.Text = "Cancelada";
            this.CanceledLbl.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.refound,
            this.description,
            this.brand,
            this.amount,
            this.UnitCost,
            this.Total,
            this.depot,
            this.WholesaleDiscountApplied});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 100);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(905, 839);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView2_CurrentCellDirtyStateChanged);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            this.dataGridView2.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_RowHeightChanged);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
            this.dataGridView2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView2_Scroll);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barcode.DefaultCellStyle = dataGridViewCellStyle2;
            this.barcode.HeaderText = "Código de Barras";
            this.barcode.Name = "barcode";
            this.barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.barcode.Visible = false;
            // 
            // refound
            // 
            this.refound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.refound.HeaderText = "Devolución";
            this.refound.Name = "refound";
            this.refound.Visible = false;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.HeaderText = "Marca";
            this.brand.Name = "brand";
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.brand.Width = 113;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.HeaderText = "Cantidad";
            this.amount.Name = "amount";
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 153;
            // 
            // UnitCost
            // 
            this.UnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitCost.HeaderText = "Precio Unitario";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitCost.Width = 202;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 87;
            // 
            // depot
            // 
            this.depot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depot.DefaultCellStyle = dataGridViewCellStyle3;
            this.depot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depot.HeaderText = "Bodega";
            this.depot.Name = "depot";
            this.depot.ReadOnly = true;
            this.depot.Width = 133;
            // 
            // WholesaleDiscountApplied
            // 
            this.WholesaleDiscountApplied.FalseValue = "false";
            this.WholesaleDiscountApplied.HeaderText = "Precio por Mayoreo Aplicado";
            this.WholesaleDiscountApplied.IndeterminateValue = "false";
            this.WholesaleDiscountApplied.Name = "WholesaleDiscountApplied";
            this.WholesaleDiscountApplied.TrueValue = "true";
            this.WholesaleDiscountApplied.Visible = false;
            // 
            // AmountProdctsLbl
            // 
            this.AmountProdctsLbl.BackColor = System.Drawing.Color.White;
            this.AmountProdctsLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AmountProdctsLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountProdctsLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AmountProdctsLbl.Location = new System.Drawing.Point(0, 939);
            this.AmountProdctsLbl.Name = "AmountProdctsLbl";
            this.AmountProdctsLbl.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.AmountProdctsLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountProdctsLbl.Size = new System.Drawing.Size(905, 38);
            this.AmountProdctsLbl.TabIndex = 17;
            this.AmountProdctsLbl.Text = "Productos: 0";
            this.AmountProdctsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AmountProdctsLbl.Visible = false;
            this.AmountProdctsLbl.TextChanged += new System.EventHandler(this.paymentLbl_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.nextTicketBtn);
            this.panel4.Controls.Add(this.previousTicketBtn);
            this.panel4.Controls.Add(this.ProductTxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 100);
            this.panel4.TabIndex = 41;
            // 
            // nextTicketBtn
            // 
            this.nextTicketBtn.BackColor = System.Drawing.Color.White;
            this.nextTicketBtn.FlatAppearance.BorderSize = 0;
            this.nextTicketBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.nextTicketBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nextTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTicketBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextTicketBtn.ForeColor = System.Drawing.Color.Teal;
            this.nextTicketBtn.Location = new System.Drawing.Point(126, 3);
            this.nextTicketBtn.Name = "nextTicketBtn";
            this.nextTicketBtn.Size = new System.Drawing.Size(120, 30);
            this.nextTicketBtn.TabIndex = 51;
            this.nextTicketBtn.Text = "Ticket Siguiente ->";
            this.nextTicketBtn.UseVisualStyleBackColor = false;
            this.nextTicketBtn.Visible = false;
            this.nextTicketBtn.Click += new System.EventHandler(this.nextTicketBtn_Click);
            this.nextTicketBtn.MouseLeave += new System.EventHandler(this.nextTicketBtn_MouseLeave);
            this.nextTicketBtn.MouseHover += new System.EventHandler(this.nextTicketBtn_MouseHover);
            // 
            // previousTicketBtn
            // 
            this.previousTicketBtn.BackColor = System.Drawing.Color.White;
            this.previousTicketBtn.FlatAppearance.BorderSize = 0;
            this.previousTicketBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.previousTicketBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.previousTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousTicketBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousTicketBtn.ForeColor = System.Drawing.Color.Teal;
            this.previousTicketBtn.Location = new System.Drawing.Point(10, 3);
            this.previousTicketBtn.Name = "previousTicketBtn";
            this.previousTicketBtn.Size = new System.Drawing.Size(110, 30);
            this.previousTicketBtn.TabIndex = 50;
            this.previousTicketBtn.Text = "<- Ticket Anterior";
            this.previousTicketBtn.UseVisualStyleBackColor = false;
            this.previousTicketBtn.Visible = false;
            this.previousTicketBtn.Click += new System.EventHandler(this.previousTicketBtn_Click);
            this.previousTicketBtn.MouseLeave += new System.EventHandler(this.previousTicketBtn_MouseLeave);
            this.previousTicketBtn.MouseHover += new System.EventHandler(this.previousTicketBtn_MouseHover);
            // 
            // ProductTxt
            // 
            this.ProductTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ProductTxt.Location = new System.Drawing.Point(10, 35);
            this.ProductTxt.Multiline = false;
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(890, 37);
            this.ProductTxt.TabIndex = 1;
            this.ProductTxt.Text = "";
            this.ProductTxt.TextChanged += new System.EventHandler(this.ProductTxt_TextChanged);
            this.ProductTxt.Enter += new System.EventHandler(this.ProductTxt_Enter);
            this.ProductTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyDown);
            this.ProductTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductTxt_KeyPress);
            this.ProductTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyUp);
            this.ProductTxt.Leave += new System.EventHandler(this.ProductTxt_Leave);
            this.ProductTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ProductTxt_PreviewKeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.totalLbl);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 977);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 73);
            this.panel5.TabIndex = 42;
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.White;
            this.totalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLbl.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.totalLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalLbl.Location = new System.Drawing.Point(246, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalLbl.Size = new System.Drawing.Size(659, 73);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Total   $0.00";
            this.totalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 73);
            this.panel3.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(16, 18);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(215, 48);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.cancelBtn, "Limpiar Lista de Productos\r\nAlt + Q");
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // customerPaymentDocument
            // 
            this.customerPaymentDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.customerPaymentDocument_PrintPage);
            // 
            // saleCancelledDocument
            // 
            this.saleCancelledDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.saleCancelledDocument_PrintPage);
            // 
            // packageReturnedDocument
            // 
            this.packageReturnedDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.packageReturnedDocument_PrintPage_1);
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerGroupBox.Controls.Add(this.ClearCustomerBtn);
            this.customerGroupBox.Controls.Add(this.debtLbl);
            this.customerGroupBox.Controls.Add(this.label1);
            this.customerGroupBox.Controls.Add(this.CustomerBtn);
            this.customerGroupBox.Controls.Add(this.CustomerPaymentBtn);
            this.customerGroupBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.customerGroupBox.Location = new System.Drawing.Point(17, 268);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.customerGroupBox.Size = new System.Drawing.Size(384, 262);
            this.customerGroupBox.TabIndex = 3;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Cliente";
            this.customerGroupBox.SizeChanged += new System.EventHandler(this.groupBox1_SizeChanged);
            // 
            // ClearCustomerBtn
            // 
            this.ClearCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCustomerBtn.BackColor = System.Drawing.Color.White;
            this.ClearCustomerBtn.Image = global::POS.Properties.Resources.close;
            this.ClearCustomerBtn.ImageActive = null;
            this.ClearCustomerBtn.Location = new System.Drawing.Point(364, 0);
            this.ClearCustomerBtn.MinimumSize = new System.Drawing.Size(20, 24);
            this.ClearCustomerBtn.Name = "ClearCustomerBtn";
            this.ClearCustomerBtn.Size = new System.Drawing.Size(20, 24);
            this.ClearCustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearCustomerBtn.TabIndex = 20;
            this.ClearCustomerBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.ClearCustomerBtn, "Remover Cliente\r\nAlt + R");
            this.ClearCustomerBtn.Visible = false;
            this.ClearCustomerBtn.Zoom = 10;
            this.ClearCustomerBtn.Click += new System.EventHandler(this.ClearCustomerBtn_Click);
            this.ClearCustomerBtn.MouseLeave += new System.EventHandler(this.ClearCustomerBtn_MouseLeave);
            this.ClearCustomerBtn.MouseHover += new System.EventHandler(this.ClearCustomerBtn_MouseHover);
            // 
            // debtLbl
            // 
            this.debtLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.debtLbl.AutoEllipsis = true;
            this.debtLbl.AutoSize = true;
            this.debtLbl.ForeColor = System.Drawing.Color.Tomato;
            this.debtLbl.Location = new System.Drawing.Point(210, 157);
            this.debtLbl.Name = "debtLbl";
            this.debtLbl.Size = new System.Drawing.Size(83, 32);
            this.debtLbl.TabIndex = 8;
            this.debtLbl.Text = "$0.00";
            this.debtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.debtLbl.TextChanged += new System.EventHandler(this.debtLbl_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(102, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Saldo:";
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.ActiveBorderThickness = 1;
            this.CustomerBtn.ActiveCornerRadius = 20;
            this.CustomerBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CustomerBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CustomerBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerBtn.BackColor = System.Drawing.Color.White;
            this.CustomerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.BackgroundImage")));
            this.CustomerBtn.ButtonText = "General";
            this.CustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.CustomerBtn.IdleBorderThickness = 1;
            this.CustomerBtn.IdleCornerRadius = 20;
            this.CustomerBtn.IdleFillColor = System.Drawing.Color.White;
            this.CustomerBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CustomerBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CustomerBtn.Location = new System.Drawing.Point(0, 36);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(384, 92);
            this.CustomerBtn.TabIndex = 0;
            this.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.CustomerBtn, "Seleccionar Cliente\r\nAlt + L");
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // CustomerPaymentBtn
            // 
            this.CustomerPaymentBtn.ActiveBorderThickness = 1;
            this.CustomerPaymentBtn.ActiveCornerRadius = 20;
            this.CustomerPaymentBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.CustomerPaymentBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CustomerPaymentBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.CustomerPaymentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerPaymentBtn.BackColor = System.Drawing.Color.White;
            this.CustomerPaymentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerPaymentBtn.BackgroundImage")));
            this.CustomerPaymentBtn.ButtonText = "Abonar";
            this.CustomerPaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerPaymentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPaymentBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.CustomerPaymentBtn.IdleBorderThickness = 1;
            this.CustomerPaymentBtn.IdleCornerRadius = 20;
            this.CustomerPaymentBtn.IdleFillColor = System.Drawing.Color.White;
            this.CustomerPaymentBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.CustomerPaymentBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.CustomerPaymentBtn.Location = new System.Drawing.Point(44, 221);
            this.CustomerPaymentBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerPaymentBtn.Name = "CustomerPaymentBtn";
            this.CustomerPaymentBtn.Size = new System.Drawing.Size(297, 41);
            this.CustomerPaymentBtn.TabIndex = 6;
            this.CustomerPaymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerPaymentBtn.Click += new System.EventHandler(this.CustomerPaymentBtn_Click);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.refoundBtn);
            this.panel6.Controls.Add(this.printTicketBtn);
            this.panel6.Controls.Add(this.EmployeeCanceldSaleLbl);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.cancelationDateLbl);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.EmployeeNameLbl);
            this.panel6.Controls.Add(this.dateOfSaleLbl);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.LastSaleBtn);
            this.panel6.Controls.Add(this.ReturnPackagesBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 547);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(419, 383);
            this.panel6.TabIndex = 44;
            this.panel6.SizeChanged += new System.EventHandler(this.panel6_SizeChanged);
            // 
            // printTicketBtn
            // 
            this.printTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printTicketBtn.AutoSize = true;
            this.printTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.printTicketBtn.FlatAppearance.BorderSize = 0;
            this.printTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printTicketBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTicketBtn.ForeColor = System.Drawing.Color.White;
            this.printTicketBtn.Location = new System.Drawing.Point(61, 145);
            this.printTicketBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printTicketBtn.Name = "printTicketBtn";
            this.printTicketBtn.Size = new System.Drawing.Size(297, 46);
            this.printTicketBtn.TabIndex = 18;
            this.printTicketBtn.Text = "Reimpirmir Ticket";
            this.toolTip1.SetToolTip(this.printTicketBtn, "Reimprimir Ticket\r\nAlt + P");
            this.printTicketBtn.UseVisualStyleBackColor = false;
            this.printTicketBtn.Visible = false;
            this.printTicketBtn.Click += new System.EventHandler(this.printTicketBtn_Click);
            // 
            // EmployeeCanceldSaleLbl
            // 
            this.EmployeeCanceldSaleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeCanceldSaleLbl.AutoSize = true;
            this.EmployeeCanceldSaleLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeCanceldSaleLbl.ForeColor = System.Drawing.Color.Tomato;
            this.EmployeeCanceldSaleLbl.Location = new System.Drawing.Point(-3, 484);
            this.EmployeeCanceldSaleLbl.Name = "EmployeeCanceldSaleLbl";
            this.EmployeeCanceldSaleLbl.Size = new System.Drawing.Size(369, 32);
            this.EmployeeCanceldSaleLbl.TabIndex = 16;
            this.EmployeeCanceldSaleLbl.Text = "Edurdo Uriel Méndez Arvizu";
            this.EmployeeCanceldSaleLbl.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(114, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Canceló:";
            this.label8.Visible = false;
            // 
            // cancelationDateLbl
            // 
            this.cancelationDateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelationDateLbl.AutoSize = true;
            this.cancelationDateLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.cancelationDateLbl.ForeColor = System.Drawing.Color.Tomato;
            this.cancelationDateLbl.Location = new System.Drawing.Point(0, 398);
            this.cancelationDateLbl.Name = "cancelationDateLbl";
            this.cancelationDateLbl.Size = new System.Drawing.Size(362, 32);
            this.cancelationDateLbl.TabIndex = 14;
            this.cancelationDateLbl.Text = "22 de Septiembre del 2015";
            this.cancelationDateLbl.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(23, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de Cancelación";
            this.label7.Visible = false;
            // 
            // EmployeeNameLbl
            // 
            this.EmployeeNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeNameLbl.AutoSize = true;
            this.EmployeeNameLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.EmployeeNameLbl.Location = new System.Drawing.Point(-12, 314);
            this.EmployeeNameLbl.Name = "EmployeeNameLbl";
            this.EmployeeNameLbl.Size = new System.Drawing.Size(387, 32);
            this.EmployeeNameLbl.TabIndex = 12;
            this.EmployeeNameLbl.Text = "Eduardo Uriel Méndez Arvizu";
            this.EmployeeNameLbl.Visible = false;
            // 
            // dateOfSaleLbl
            // 
            this.dateOfSaleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOfSaleLbl.AutoSize = true;
            this.dateOfSaleLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.dateOfSaleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.dateOfSaleLbl.Location = new System.Drawing.Point(0, 229);
            this.dateOfSaleLbl.Name = "dateOfSaleLbl";
            this.dateOfSaleLbl.Size = new System.Drawing.Size(362, 32);
            this.dateOfSaleLbl.TabIndex = 10;
            this.dateOfSaleLbl.Text = "17 de Septiembre del 2019";
            this.dateOfSaleLbl.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(81, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Realizó Venta:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(67, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de venta:";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(19, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReturnPackagesBtn
            // 
            this.ReturnPackagesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnPackagesBtn.AutoSize = true;
            this.ReturnPackagesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ReturnPackagesBtn.Enabled = false;
            this.ReturnPackagesBtn.FlatAppearance.BorderSize = 0;
            this.ReturnPackagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnPackagesBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPackagesBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnPackagesBtn.Location = new System.Drawing.Point(61, 12);
            this.ReturnPackagesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnPackagesBtn.Name = "ReturnPackagesBtn";
            this.ReturnPackagesBtn.Size = new System.Drawing.Size(297, 46);
            this.ReturnPackagesBtn.TabIndex = 17;
            this.ReturnPackagesBtn.Text = "Retornar Envases";
            this.toolTip1.SetToolTip(this.ReturnPackagesBtn, "Retornar Envases\r\nAlt + E");
            this.ReturnPackagesBtn.UseVisualStyleBackColor = false;
            this.ReturnPackagesBtn.Visible = false;
            this.ReturnPackagesBtn.Click += new System.EventHandler(this.ReturnPackagesBtn_Click);
            // 
            // ticketGrupbox
            // 
            this.ticketGrupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketGrupbox.Controls.Add(this.printCheckBox);
            this.ticketGrupbox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.ticketGrupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ticketGrupbox.Location = new System.Drawing.Point(17, 186);
            this.ticketGrupbox.Name = "ticketGrupbox";
            this.ticketGrupbox.Size = new System.Drawing.Size(384, 76);
            this.ticketGrupbox.TabIndex = 5;
            this.ticketGrupbox.TabStop = false;
            this.ticketGrupbox.Text = "Ticket";
            // 
            // printCheckBox
            // 
            this.printCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printCheckBox.AutoSize = true;
            this.printCheckBox.Checked = true;
            this.printCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printCheckBox.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.printCheckBox.Location = new System.Drawing.Point(117, 28);
            this.printCheckBox.Name = "printCheckBox";
            this.printCheckBox.Size = new System.Drawing.Size(150, 40);
            this.printCheckBox.TabIndex = 0;
            this.printCheckBox.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.printCheckBox, "Imprimir Ticket\r\nAlt + I");
            this.printCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelSaleBtn
            // 
            this.CancelSaleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSaleBtn.AutoSize = true;
            this.CancelSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CancelSaleBtn.FlatAppearance.BorderSize = 0;
            this.CancelSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSaleBtn.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.CancelSaleBtn.ForeColor = System.Drawing.Color.White;
            this.CancelSaleBtn.Location = new System.Drawing.Point(15, 26);
            this.CancelSaleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSaleBtn.Name = "CancelSaleBtn";
            this.CancelSaleBtn.Size = new System.Drawing.Size(388, 68);
            this.CancelSaleBtn.TabIndex = 7;
            this.CancelSaleBtn.Text = "Cancelar Venta ";
            this.toolTip1.SetToolTip(this.CancelSaleBtn, "Cancelar Compra\r\nAlt + C");
            this.CancelSaleBtn.UseVisualStyleBackColor = false;
            this.CancelSaleBtn.Visible = false;
            this.CancelSaleBtn.Click += new System.EventHandler(this.CancelSaleBtn_Click);
            // 
            // productGroupBox
            // 
            this.productGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGroupBox.Controls.Add(this.lessBtn);
            this.productGroupBox.Controls.Add(this.moreBtn);
            this.productGroupBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.productGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.productGroupBox.Location = new System.Drawing.Point(17, 51);
            this.productGroupBox.MinimumSize = new System.Drawing.Size(0, 100);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.productGroupBox.Size = new System.Drawing.Size(384, 129);
            this.productGroupBox.TabIndex = 4;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Producto";
            // 
            // lessBtn
            // 
            this.lessBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessBtn.AutoSize = true;
            this.lessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.lessBtn.FlatAppearance.BorderSize = 0;
            this.lessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessBtn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessBtn.ForeColor = System.Drawing.Color.White;
            this.lessBtn.Location = new System.Drawing.Point(64, 43);
            this.lessBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lessBtn.Name = "lessBtn";
            this.lessBtn.Size = new System.Drawing.Size(63, 66);
            this.lessBtn.TabIndex = 3;
            this.lessBtn.Text = "-";
            this.toolTip1.SetToolTip(this.lessBtn, "Quitar una pieza\r\nAlt + \"-\"");
            this.lessBtn.UseVisualStyleBackColor = false;
            this.lessBtn.Click += new System.EventHandler(this.lessBtn_Click);
            // 
            // moreBtn
            // 
            this.moreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moreBtn.AutoSize = true;
            this.moreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.moreBtn.FlatAppearance.BorderSize = 0;
            this.moreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreBtn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreBtn.ForeColor = System.Drawing.Color.White;
            this.moreBtn.Location = new System.Drawing.Point(255, 43);
            this.moreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(63, 66);
            this.moreBtn.TabIndex = 4;
            this.moreBtn.Text = "+";
            this.toolTip1.SetToolTip(this.moreBtn, "Agregar una pieza\r\nAlt + \"+\"");
            this.moreBtn.UseVisualStyleBackColor = false;
            this.moreBtn.Click += new System.EventHandler(this.moreBtn_Click);
            // 
            // CobrarBtn
            // 
            this.CobrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CobrarBtn.AutoSize = true;
            this.CobrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CobrarBtn.FlatAppearance.BorderSize = 0;
            this.CobrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CobrarBtn.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobrarBtn.ForeColor = System.Drawing.Color.White;
            this.CobrarBtn.Location = new System.Drawing.Point(61, 9);
            this.CobrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CobrarBtn.Name = "CobrarBtn";
            this.CobrarBtn.Size = new System.Drawing.Size(297, 102);
            this.CobrarBtn.TabIndex = 0;
            this.CobrarBtn.Text = "Cobrar";
            this.toolTip1.SetToolTip(this.CobrarBtn, "Realizar Cobro\r\nAlt + C");
            this.CobrarBtn.UseVisualStyleBackColor = false;
            this.CobrarBtn.Click += new System.EventHandler(this.CobrarBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(905, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 1050);
            this.panel2.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.CobrarBtn);
            this.panel9.Controls.Add(this.CancelSaleBtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 930);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(419, 120);
            this.panel9.TabIndex = 51;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.customerGroupBox);
            this.panel10.Controls.Add(this.newWindowBtn);
            this.panel10.Controls.Add(this.productGroupBox);
            this.panel10.Controls.Add(this.autoGrouping);
            this.panel10.Controls.Add(this.discountList);
            this.panel10.Controls.Add(this.ticketGrupbox);
            this.panel10.Controls.Add(this.discountBtn);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(419, 547);
            this.panel10.TabIndex = 52;
            // 
            // newWindowBtn
            // 
            this.newWindowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newWindowBtn.BackColor = System.Drawing.Color.Transparent;
            this.newWindowBtn.Image = global::POS.Properties.Resources.new_Window;
            this.newWindowBtn.ImageActive = null;
            this.newWindowBtn.Location = new System.Drawing.Point(352, 17);
            this.newWindowBtn.MinimumSize = new System.Drawing.Size(30, 30);
            this.newWindowBtn.Name = "newWindowBtn";
            this.newWindowBtn.Size = new System.Drawing.Size(30, 30);
            this.newWindowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newWindowBtn.TabIndex = 47;
            this.newWindowBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.newWindowBtn, "Nueva Ventana\r\nAlt + N");
            this.newWindowBtn.Zoom = 10;
            this.newWindowBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // autoGrouping
            // 
            this.autoGrouping.AutoSize = true;
            this.autoGrouping.Checked = true;
            this.autoGrouping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoGrouping.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.autoGrouping.Location = new System.Drawing.Point(50, 23);
            this.autoGrouping.Name = "autoGrouping";
            this.autoGrouping.Size = new System.Drawing.Size(172, 20);
            this.autoGrouping.TabIndex = 50;
            this.autoGrouping.Text = "Agrupar Automáticamente";
            this.autoGrouping.UseVisualStyleBackColor = true;
            this.autoGrouping.Visible = false;
            // 
            // discountList
            // 
            this.discountList.BackColor = System.Drawing.Color.White;
            this.discountList.FlatAppearance.BorderSize = 0;
            this.discountList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.discountList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.discountList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountList.Location = new System.Drawing.Point(221, 17);
            this.discountList.Name = "discountList";
            this.discountList.Size = new System.Drawing.Size(61, 30);
            this.discountList.TabIndex = 49;
            this.discountList.Text = "Ofertas";
            this.toolTip1.SetToolTip(this.discountList, "Ofertas\r\nAlt + F");
            this.discountList.UseVisualStyleBackColor = false;
            this.discountList.Visible = false;
            this.discountList.Click += new System.EventHandler(this.discountList_Click);
            this.discountList.MouseLeave += new System.EventHandler(this.discountList_MouseLeave);
            this.discountList.MouseHover += new System.EventHandler(this.discountList_MouseHover);
            // 
            // discountBtn
            // 
            this.discountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountBtn.BackColor = System.Drawing.Color.Transparent;
            this.discountBtn.Image = global::POS.Properties.Resources.discount;
            this.discountBtn.ImageActive = null;
            this.discountBtn.Location = new System.Drawing.Point(309, 17);
            this.discountBtn.MinimumSize = new System.Drawing.Size(30, 30);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(30, 30);
            this.discountBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.discountBtn.TabIndex = 48;
            this.discountBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.discountBtn, "Añadir Descuento\r\nAlt + D");
            this.discountBtn.Visible = false;
            this.discountBtn.Zoom = 10;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1324, 25);
            this.bunifuGradientPanel1.TabIndex = 44;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1303, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 19;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1274, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.refoundBtn;
            // 
            // reprintElipse
            // 
            this.reprintElipse.ElipseRadius = 10;
            this.reprintElipse.TargetControl = this.printTicketBtn;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1324, 1050);
            this.panel7.TabIndex = 46;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.AutoSize = true;
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Location = new System.Drawing.Point(184, 200);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(297, 46);
            this.OkBtn.TabIndex = 9;
            this.OkBtn.Text = "&Aceptar";
            this.toolTip1.SetToolTip(this.OkBtn, "Buscar Ticket\r\nAlt + B");
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(629, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.Controls.Add(this.bunifuImageButton1);
            this.panel8.Controls.Add(this.OkBtn);
            this.panel8.Controls.Add(this.alterCostTxt);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(330, 400);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(664, 274);
            this.panel8.TabIndex = 53;
            this.panel8.Visible = false;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // alterCostTxt
            // 
            this.alterCostTxt.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.alterCostTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.alterCostTxt.Location = new System.Drawing.Point(147, 115);
            this.alterCostTxt.Name = "alterCostTxt";
            this.alterCostTxt.Size = new System.Drawing.Size(370, 41);
            this.alterCostTxt.TabIndex = 19;
            this.alterCostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alterCostTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alterCostTxt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.label3.Location = new System.Drawing.Point(125, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese el Precio del Producto:";
            // 
            // Panel_Ventas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 1075);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Panel_Ventas";
            this.Text = "Venta | Point of Sale";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Activated += new System.EventHandler(this.Panel_Ventas_Activated);
            this.Deactivate += new System.EventHandler(this.Panel_Ventas_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_Ventas_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Ventas_Load);
            this.Resize += new System.EventHandler(this.Panel_Ventas_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCustomerBtn)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ticketGrupbox.ResumeLayout(false);
            this.ticketGrupbox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newWindowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBtn)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private Bunifu.Framework.UI.BunifuElipse LastSaleElipse;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.Framework.UI.BunifuCustomLabel CanceledLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse LookForTicketBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private RichTextBox ProductTxt;
        private Label AmountProdctsLbl;
        private System.Drawing.Printing.PrintDocument customerPaymentDocument;
        private System.Drawing.Printing.PrintDocument saleCancelledDocument;
        private System.Drawing.Printing.PrintDocument packageReturnedDocument;
        private Button LastSaleBtn;
        private Button refoundBtn;
        private Label totalLbl;
        private Panel panel3;
        private Button cancelBtn;
        private GroupBox customerGroupBox;
        private Bunifu.Framework.UI.BunifuThinButton2 CustomerPaymentBtn;
        private Bunifu.Framework.UI.BunifuImageButton ClearCustomerBtn;
        private Label debtLbl;
        private Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 CustomerBtn;
        private Panel panel6;
        private Label EmployeeCanceldSaleLbl;
        private Label label8;
        private Label cancelationDateLbl;
        private Label label7;
        private Label EmployeeNameLbl;
        private Label dateOfSaleLbl;
        private Label label4;
        private Label label2;
        private Button ReturnPackagesBtn;
        private GroupBox ticketGrupbox;
        private CheckBox printCheckBox;
        private Button CancelSaleBtn;
        private GroupBox productGroupBox;
        private Button lessBtn;
        private Button moreBtn;
        private Button CobrarBtn;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton discountBtn;
        private Bunifu.Framework.UI.BunifuImageButton newWindowBtn;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Button discountList;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button printTicketBtn;
        private Bunifu.Framework.UI.BunifuElipse reprintElipse;
        private Panel panel7;
        private CheckBox autoGrouping;
        private ToolTip toolTip1;
        private Button nextTicketBtn;
        private Button previousTicketBtn;
        private Timer timer1;
        private Panel panel8;
        private TextBox alterCostTxt;
        private Label label3;
        private Button OkBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Panel panel9;
        private Panel panel10;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewCheckBoxColumn refound;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn UnitCost;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewComboBoxColumn depot;
        private DataGridViewCheckBoxColumn WholesaleDiscountApplied;
    }
}