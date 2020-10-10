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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.ProductListPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
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
            this.NewDepotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.scrapBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.ProductListPanel.SuspendLayout();
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
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowHeightChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
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
            this.bunifuGradientPanel4.Controls.Add(this.NewDepotBtn);
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
            this.NewDepotBtn.Location = new System.Drawing.Point(1326, 12);
            this.NewDepotBtn.Margin = new System.Windows.Forms.Padding(5);
            this.NewDepotBtn.Name = "NewDepotBtn";
            this.NewDepotBtn.Size = new System.Drawing.Size(181, 40);
            this.NewDepotBtn.TabIndex = 110;
            this.NewDepotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewDepotBtn.Click += new System.EventHandler(this.NewDepotBtn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ProductPanel.ResumeLayout(false);
            this.ProductListPanel.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
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
    }
}