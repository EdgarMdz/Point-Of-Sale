﻿using System;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Ventas));
            this.LastSaleElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LastSaleBtn = new System.Windows.Forms.Button();
            this.LookForTicketBtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.refoundBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CanceledLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductTxt = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.customerPaymentDocument = new System.Drawing.Printing.PrintDocument();
            this.saleCancelledDocument = new System.Drawing.Printing.PrintDocument();
            this.packageReturnedDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerPaymentBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ClearCustomerBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.debtLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EmployeeCanceldSaleLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelationDateLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeNameLbl = new System.Windows.Forms.Label();
            this.dateOfSaleLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnPackagesBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CancelSaleBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lessBtn = new System.Windows.Forms.Button();
            this.moreBtn = new System.Windows.Forms.Button();
            this.CobrarBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.discountList = new System.Windows.Forms.Button();
            this.newWindowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.discountBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCustomerBtn)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newWindowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // LastSaleElipse
            // 
            this.LastSaleElipse.ElipseRadius = 10;
            this.LastSaleElipse.TargetControl = this.LastSaleBtn;
            // 
            // LastSaleBtn
            // 
            this.LastSaleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastSaleBtn.AutoSize = true;
            this.LastSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.LastSaleBtn.FlatAppearance.BorderSize = 0;
            this.LastSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastSaleBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastSaleBtn.ForeColor = System.Drawing.Color.White;
            this.LastSaleBtn.Location = new System.Drawing.Point(91, 13);
            this.LastSaleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LastSaleBtn.Name = "LastSaleBtn";
            this.LastSaleBtn.Size = new System.Drawing.Size(297, 46);
            this.LastSaleBtn.TabIndex = 6;
            this.LastSaleBtn.Text = "Última Venta";
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
            this.refoundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refoundBtn.AutoSize = true;
            this.refoundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.refoundBtn.FlatAppearance.BorderSize = 0;
            this.refoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refoundBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refoundBtn.ForeColor = System.Drawing.Color.White;
            this.refoundBtn.Location = new System.Drawing.Point(91, 79);
            this.refoundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refoundBtn.Name = "refoundBtn";
            this.refoundBtn.Size = new System.Drawing.Size(297, 46);
            this.refoundBtn.TabIndex = 8;
            this.refoundBtn.Text = "Buscar Ticket";
            this.refoundBtn.UseVisualStyleBackColor = false;
            this.refoundBtn.Click += new System.EventHandler(this.refoundBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CanceledLbl);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.paymentLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 1075);
            this.panel1.TabIndex = 40;
            // 
            // CanceledLbl
            // 
            this.CanceledLbl.AutoSize = true;
            this.CanceledLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CanceledLbl.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceledLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.CanceledLbl.Location = new System.Drawing.Point(52, 558);
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
            this.description,
            this.brand,
            this.amount,
            this.UnitCost,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 100);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(889, 815);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView2_Scroll);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.barcode.HeaderText = "Código de Barras";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.barcode.Visible = false;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Descripción";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.HeaderText = "Marca";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.brand.Width = 113;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.HeaderText = "Cantidad";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 153;
            // 
            // UnitCost
            // 
            this.UnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitCost.HeaderText = "Precio Unitario";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.ReadOnly = true;
            this.UnitCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitCost.Width = 202;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 87;
            // 
            // paymentLbl
            // 
            this.paymentLbl.BackColor = System.Drawing.Color.White;
            this.paymentLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.paymentLbl.Location = new System.Drawing.Point(0, 915);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paymentLbl.Size = new System.Drawing.Size(889, 47);
            this.paymentLbl.TabIndex = 17;
            this.paymentLbl.Text = "Abono $0.00";
            this.paymentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paymentLbl.Visible = false;
            this.paymentLbl.TextChanged += new System.EventHandler(this.paymentLbl_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(0, 962);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(889, 47);
            this.label3.TabIndex = 44;
            this.label3.Text = "Importe de envases $0.00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ProductTxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(889, 100);
            this.panel4.TabIndex = 41;
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
            this.ProductTxt.Size = new System.Drawing.Size(873, 37);
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
            this.panel5.Location = new System.Drawing.Point(0, 1009);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(889, 66);
            this.panel5.TabIndex = 42;
            // 
            // totalLbl
            // 
            this.totalLbl.BackColor = System.Drawing.Color.White;
            this.totalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.totalLbl.Location = new System.Drawing.Point(246, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalLbl.Size = new System.Drawing.Size(643, 66);
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
            this.panel3.Size = new System.Drawing.Size(246, 66);
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
            this.cancelBtn.Location = new System.Drawing.Point(16, 8);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(215, 51);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Limpiar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // customerPaymentDocument
            // 
            this.customerPaymentDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.customerPaymentDocument_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerPaymentBtn);
            this.groupBox1.Controls.Add(this.ClearCustomerBtn);
            this.groupBox1.Controls.Add(this.debtLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustomerBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.groupBox1.Location = new System.Drawing.Point(47, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.SizeChanged += new System.EventHandler(this.groupBox1_SizeChanged);
            // 
            // CustomerPaymentBtn
            // 
            this.CustomerPaymentBtn.ActiveBorderThickness = 1;
            this.CustomerPaymentBtn.ActiveCornerRadius = 20;
            this.CustomerPaymentBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.CustomerPaymentBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CustomerPaymentBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
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
            this.CustomerPaymentBtn.Location = new System.Drawing.Point(44, 226);
            this.CustomerPaymentBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerPaymentBtn.Name = "CustomerPaymentBtn";
            this.CustomerPaymentBtn.Size = new System.Drawing.Size(297, 41);
            this.CustomerPaymentBtn.TabIndex = 6;
            this.CustomerPaymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerPaymentBtn.Click += new System.EventHandler(this.CustomerPaymentBtn_Click);
            // 
            // ClearCustomerBtn
            // 
            this.ClearCustomerBtn.BackColor = System.Drawing.Color.White;
            this.ClearCustomerBtn.Image = global::POS.Properties.Resources.close;
            this.ClearCustomerBtn.ImageActive = null;
            this.ClearCustomerBtn.Location = new System.Drawing.Point(364, 0);
            this.ClearCustomerBtn.Name = "ClearCustomerBtn";
            this.ClearCustomerBtn.Size = new System.Drawing.Size(20, 24);
            this.ClearCustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearCustomerBtn.TabIndex = 1;
            this.ClearCustomerBtn.TabStop = false;
            this.ClearCustomerBtn.Visible = false;
            this.ClearCustomerBtn.Zoom = 10;
            this.ClearCustomerBtn.Click += new System.EventHandler(this.ClearCustomerBtn_Click);
            this.ClearCustomerBtn.MouseLeave += new System.EventHandler(this.ClearCustomerBtn_MouseLeave);
            this.ClearCustomerBtn.MouseHover += new System.EventHandler(this.ClearCustomerBtn_MouseHover);
            // 
            // debtLbl
            // 
            this.debtLbl.AutoEllipsis = true;
            this.debtLbl.AutoSize = true;
            this.debtLbl.ForeColor = System.Drawing.Color.Tomato;
            this.debtLbl.Location = new System.Drawing.Point(203, 155);
            this.debtLbl.Name = "debtLbl";
            this.debtLbl.Size = new System.Drawing.Size(83, 32);
            this.debtLbl.TabIndex = 8;
            this.debtLbl.Text = "$0.00";
            this.debtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.debtLbl.TextChanged += new System.EventHandler(this.debtLbl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(95, 155);
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
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.refoundBtn);
            this.panel6.Controls.Add(this.EmployeeCanceldSaleLbl);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.cancelationDateLbl);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.EmployeeNameLbl);
            this.panel6.Controls.Add(this.dateOfSaleLbl);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.LastSaleBtn);
            this.panel6.Controls.Add(this.ReturnPackagesBtn);
            this.panel6.Location = new System.Drawing.Point(0, 382);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 575);
            this.panel6.TabIndex = 44;
            // 
            // EmployeeCanceldSaleLbl
            // 
            this.EmployeeCanceldSaleLbl.AutoSize = true;
            this.EmployeeCanceldSaleLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeCanceldSaleLbl.ForeColor = System.Drawing.Color.Tomato;
            this.EmployeeCanceldSaleLbl.Location = new System.Drawing.Point(42, 511);
            this.EmployeeCanceldSaleLbl.Name = "EmployeeCanceldSaleLbl";
            this.EmployeeCanceldSaleLbl.Size = new System.Drawing.Size(369, 32);
            this.EmployeeCanceldSaleLbl.TabIndex = 16;
            this.EmployeeCanceldSaleLbl.Text = "Edurdo Uriel Méndez Arvizu";
            this.EmployeeCanceldSaleLbl.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(164, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Canceló:";
            this.label8.Visible = false;
            // 
            // cancelationDateLbl
            // 
            this.cancelationDateLbl.AutoSize = true;
            this.cancelationDateLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.cancelationDateLbl.ForeColor = System.Drawing.Color.Tomato;
            this.cancelationDateLbl.Location = new System.Drawing.Point(44, 403);
            this.cancelationDateLbl.Name = "cancelationDateLbl";
            this.cancelationDateLbl.Size = new System.Drawing.Size(362, 32);
            this.cancelationDateLbl.TabIndex = 14;
            this.cancelationDateLbl.Text = "22 de Septiembre del 2015";
            this.cancelationDateLbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(69, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de Cancelación";
            this.label7.Visible = false;
            // 
            // EmployeeNameLbl
            // 
            this.EmployeeNameLbl.AutoSize = true;
            this.EmployeeNameLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.EmployeeNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.EmployeeNameLbl.Location = new System.Drawing.Point(32, 295);
            this.EmployeeNameLbl.Name = "EmployeeNameLbl";
            this.EmployeeNameLbl.Size = new System.Drawing.Size(387, 32);
            this.EmployeeNameLbl.TabIndex = 12;
            this.EmployeeNameLbl.Text = "Eduardo Uriel Mendez Arvizu";
            this.EmployeeNameLbl.Visible = false;
            // 
            // dateOfSaleLbl
            // 
            this.dateOfSaleLbl.AutoSize = true;
            this.dateOfSaleLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.dateOfSaleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.dateOfSaleLbl.Location = new System.Drawing.Point(44, 187);
            this.dateOfSaleLbl.Name = "dateOfSaleLbl";
            this.dateOfSaleLbl.Size = new System.Drawing.Size(362, 32);
            this.dateOfSaleLbl.TabIndex = 10;
            this.dateOfSaleLbl.Text = "17 de Septiembre del 2019";
            this.dateOfSaleLbl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(131, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Realizó Venta:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(115, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de venta:";
            this.label2.Visible = false;
            // 
            // ReturnPackagesBtn
            // 
            this.ReturnPackagesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnPackagesBtn.AutoSize = true;
            this.ReturnPackagesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ReturnPackagesBtn.Enabled = false;
            this.ReturnPackagesBtn.FlatAppearance.BorderSize = 0;
            this.ReturnPackagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnPackagesBtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPackagesBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnPackagesBtn.Location = new System.Drawing.Point(91, 12);
            this.ReturnPackagesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnPackagesBtn.Name = "ReturnPackagesBtn";
            this.ReturnPackagesBtn.Size = new System.Drawing.Size(297, 46);
            this.ReturnPackagesBtn.TabIndex = 17;
            this.ReturnPackagesBtn.Text = "Retornar Envases";
            this.ReturnPackagesBtn.UseVisualStyleBackColor = false;
            this.ReturnPackagesBtn.Visible = false;
            this.ReturnPackagesBtn.Click += new System.EventHandler(this.ReturnPackagesBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.groupBox3.Location = new System.Drawing.Point(47, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 76);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticket";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(150)))));
            this.checkBox1.Location = new System.Drawing.Point(117, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 40);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Imprimir";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CancelSaleBtn
            // 
            this.CancelSaleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSaleBtn.AutoSize = true;
            this.CancelSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CancelSaleBtn.FlatAppearance.BorderSize = 0;
            this.CancelSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSaleBtn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSaleBtn.ForeColor = System.Drawing.Color.White;
            this.CancelSaleBtn.Location = new System.Drawing.Point(19, 986);
            this.CancelSaleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSaleBtn.Name = "CancelSaleBtn";
            this.CancelSaleBtn.Size = new System.Drawing.Size(440, 68);
            this.CancelSaleBtn.TabIndex = 7;
            this.CancelSaleBtn.Text = "Cancelar Venta ";
            this.CancelSaleBtn.UseVisualStyleBackColor = false;
            this.CancelSaleBtn.Visible = false;
            this.CancelSaleBtn.Click += new System.EventHandler(this.CancelSaleBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lessBtn);
            this.groupBox2.Controls.Add(this.moreBtn);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.groupBox2.Location = new System.Drawing.Point(47, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // lessBtn
            // 
            this.lessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lessBtn.AutoSize = true;
            this.lessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.lessBtn.FlatAppearance.BorderSize = 0;
            this.lessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessBtn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessBtn.ForeColor = System.Drawing.Color.White;
            this.lessBtn.Location = new System.Drawing.Point(64, 39);
            this.lessBtn.Margin = new System.Windows.Forms.Padding(2);
            this.lessBtn.Name = "lessBtn";
            this.lessBtn.Size = new System.Drawing.Size(64, 68);
            this.lessBtn.TabIndex = 3;
            this.lessBtn.Text = "-";
            this.lessBtn.UseVisualStyleBackColor = false;
            this.lessBtn.Click += new System.EventHandler(this.lessBtn_Click);
            // 
            // moreBtn
            // 
            this.moreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moreBtn.AutoSize = true;
            this.moreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.moreBtn.FlatAppearance.BorderSize = 0;
            this.moreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreBtn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreBtn.ForeColor = System.Drawing.Color.White;
            this.moreBtn.Location = new System.Drawing.Point(255, 39);
            this.moreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(65, 68);
            this.moreBtn.TabIndex = 4;
            this.moreBtn.Text = "+";
            this.moreBtn.UseVisualStyleBackColor = false;
            this.moreBtn.Click += new System.EventHandler(this.moreBtn_Click);
            // 
            // CobrarBtn
            // 
            this.CobrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CobrarBtn.AutoSize = true;
            this.CobrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.CobrarBtn.FlatAppearance.BorderSize = 0;
            this.CobrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CobrarBtn.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobrarBtn.ForeColor = System.Drawing.Color.White;
            this.CobrarBtn.Location = new System.Drawing.Point(91, 962);
            this.CobrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CobrarBtn.Name = "CobrarBtn";
            this.CobrarBtn.Size = new System.Drawing.Size(297, 102);
            this.CobrarBtn.TabIndex = 0;
            this.CobrarBtn.Text = "Cobrar";
            this.CobrarBtn.UseVisualStyleBackColor = false;
            this.CobrarBtn.Click += new System.EventHandler(this.CobrarBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.discountList);
            this.panel2.Controls.Add(this.newWindowBtn);
            this.panel2.Controls.Add(this.discountBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.CobrarBtn);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.CancelSaleBtn);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(889, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 1075);
            this.panel2.TabIndex = 41;
            // 
            // discountList
            // 
            this.discountList.BackColor = System.Drawing.Color.White;
            this.discountList.FlatAppearance.BorderSize = 0;
            this.discountList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.discountList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.discountList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.discountList.Location = new System.Drawing.Point(326, 6);
            this.discountList.Name = "discountList";
            this.discountList.Size = new System.Drawing.Size(61, 30);
            this.discountList.TabIndex = 49;
            this.discountList.Text = "Ofertas";
            this.discountList.UseVisualStyleBackColor = false;
            this.discountList.Click += new System.EventHandler(this.discountList_Click);
            this.discountList.MouseLeave += new System.EventHandler(this.discountList_MouseLeave);
            this.discountList.MouseHover += new System.EventHandler(this.discountList_MouseHover);
            // 
            // newWindowBtn
            // 
            this.newWindowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newWindowBtn.BackColor = System.Drawing.Color.Transparent;
            this.newWindowBtn.Image = global::POS.Properties.Resources.new_Window;
            this.newWindowBtn.ImageActive = null;
            this.newWindowBtn.Location = new System.Drawing.Point(395, 6);
            this.newWindowBtn.Name = "newWindowBtn";
            this.newWindowBtn.Size = new System.Drawing.Size(30, 30);
            this.newWindowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newWindowBtn.TabIndex = 47;
            this.newWindowBtn.TabStop = false;
            this.newWindowBtn.Zoom = 10;
            this.newWindowBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // discountBtn
            // 
            this.discountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountBtn.BackColor = System.Drawing.Color.Transparent;
            this.discountBtn.Image = global::POS.Properties.Resources.discount;
            this.discountBtn.ImageActive = null;
            this.discountBtn.Location = new System.Drawing.Point(288, 6);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(30, 30);
            this.discountBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.discountBtn.TabIndex = 48;
            this.discountBtn.TabStop = false;
            this.discountBtn.Visible = false;
            this.discountBtn.Zoom = 10;
            this.discountBtn.Click += new System.EventHandler(this.discountBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 556);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1367, 25);
            this.bunifuGradientPanel1.TabIndex = 44;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1335, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
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
            this.MimimizeBtn.Location = new System.Drawing.Point(1306, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // Panel_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 1100);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Panel_Ventas";
            this.ShowInTaskbar = false;
            this.Text = "Venta | Point of Sale";
            this.Load += new System.EventHandler(this.Panel_Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearCustomerBtn)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newWindowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private RichTextBox ProductTxt;
        private Label paymentLbl;
        private Label label3;
        private System.Drawing.Printing.PrintDocument customerPaymentDocument;
        private System.Drawing.Printing.PrintDocument saleCancelledDocument;
        private System.Drawing.Printing.PrintDocument packageReturnedDocument;
        private Button LastSaleBtn;
        private Button refoundBtn;
        private Label totalLbl;
        private Panel panel3;
        private Button cancelBtn;
        private GroupBox groupBox1;
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
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private Button CancelSaleBtn;
        private GroupBox groupBox2;
        private Button lessBtn;
        private Button moreBtn;
        private Button CobrarBtn;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton discountBtn;
        private Bunifu.Framework.UI.BunifuImageButton newWindowBtn;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Button discountList;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn UnitCost;
        private DataGridViewTextBoxColumn Total;
        private Timer timer1;
    }
}