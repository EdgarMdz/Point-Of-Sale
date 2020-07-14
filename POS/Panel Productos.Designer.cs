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
            this.promoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mixedCaseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.TransferStockBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.scrapBtn = new System.Windows.Forms.Button();
            this.NewDepotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            this.ProductListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixedCaseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferStockBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
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
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
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
            this.panel4.Size = new System.Drawing.Size(1557, 713);
            this.panel4.TabIndex = 13;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ProductListPanel);
            this.ProductPanel.Controls.Add(this.bunifuGradientPanel5);
            this.ProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(1557, 713);
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
            this.ProductListPanel.Location = new System.Drawing.Point(0, 63);
            this.ProductListPanel.Name = "ProductListPanel";
            this.ProductListPanel.Quality = 10;
            this.ProductListPanel.Size = new System.Drawing.Size(1557, 650);
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
            this.dataGridView1.Size = new System.Drawing.Size(1479, 583);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick_1);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.promoBtn);
            this.bunifuGradientPanel1.Controls.Add(this.mixedCaseBtn);
            this.bunifuGradientPanel1.Controls.Add(this.TransferStockBtn);
            this.bunifuGradientPanel1.Controls.Add(this.EditProduct);
            this.bunifuGradientPanel1.Controls.Add(this.DeleteButton);
            this.bunifuGradientPanel1.Controls.Add(this.AddBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 65);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(76, 583);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // promoBtn
            // 
            this.promoBtn.BackColor = System.Drawing.Color.Transparent;
            this.promoBtn.Image = global::POS.Properties.Resources.discount;
            this.promoBtn.ImageActive = null;
            this.promoBtn.Location = new System.Drawing.Point(11, 514);
            this.promoBtn.Name = "promoBtn";
            this.promoBtn.Size = new System.Drawing.Size(50, 50);
            this.promoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.promoBtn.TabIndex = 5;
            this.promoBtn.TabStop = false;
            this.promoBtn.Zoom = 10;
            this.promoBtn.Click += new System.EventHandler(this.promoBtn_Click);
            // 
            // mixedCaseBtn
            // 
            this.mixedCaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.mixedCaseBtn.Image = ((System.Drawing.Image)(resources.GetObject("mixedCaseBtn.Image")));
            this.mixedCaseBtn.ImageActive = null;
            this.mixedCaseBtn.Location = new System.Drawing.Point(12, 415);
            this.mixedCaseBtn.Name = "mixedCaseBtn";
            this.mixedCaseBtn.Size = new System.Drawing.Size(50, 50);
            this.mixedCaseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixedCaseBtn.TabIndex = 4;
            this.mixedCaseBtn.TabStop = false;
            this.mixedCaseBtn.Zoom = 10;
            this.mixedCaseBtn.Click += new System.EventHandler(this.mixedCaseBtn_Click);
            // 
            // TransferStockBtn
            // 
            this.TransferStockBtn.BackColor = System.Drawing.Color.Transparent;
            this.TransferStockBtn.Image = global::POS.Properties.Resources._switch;
            this.TransferStockBtn.ImageActive = null;
            this.TransferStockBtn.Location = new System.Drawing.Point(13, 217);
            this.TransferStockBtn.Name = "TransferStockBtn";
            this.TransferStockBtn.Size = new System.Drawing.Size(50, 50);
            this.TransferStockBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TransferStockBtn.TabIndex = 3;
            this.TransferStockBtn.TabStop = false;
            this.TransferStockBtn.Zoom = 10;
            this.TransferStockBtn.Click += new System.EventHandler(this.TransferStockBtn_Click);
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.Color.Transparent;
            this.EditProduct.Image = global::POS.Properties.Resources.edit;
            this.EditProduct.ImageActive = null;
            this.EditProduct.Location = new System.Drawing.Point(13, 118);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(50, 50);
            this.EditProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditProduct.TabIndex = 2;
            this.EditProduct.TabStop = false;
            this.EditProduct.Zoom = 10;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Image = global::POS.Properties.Resources.delete;
            this.DeleteButton.ImageActive = null;
            this.DeleteButton.Location = new System.Drawing.Point(13, 316);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Zoom = 10;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Image = global::POS.Properties.Resources.plus;
            this.AddBtn.ImageActive = null;
            this.AddBtn.Location = new System.Drawing.Point(13, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 50);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBtn.TabIndex = 0;
            this.AddBtn.TabStop = false;
            this.AddBtn.Zoom = 10;
            this.AddBtn.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(407, 15);
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
            this.SearchTxt.Location = new System.Drawing.Point(533, 12);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(417, 40);
            this.SearchTxt.TabIndex = 4;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            this.SearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown);
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.Controls.Add(this.scrapBtn);
            this.bunifuGradientPanel5.Controls.Add(this.NewDepotBtn);
            this.bunifuGradientPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(1557, 63);
            this.bunifuGradientPanel5.TabIndex = 9;
            // 
            // scrapBtn
            // 
            this.scrapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.scrapBtn.FlatAppearance.BorderSize = 0;
            this.scrapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrapBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapBtn.ForeColor = System.Drawing.Color.White;
            this.scrapBtn.Location = new System.Drawing.Point(33, 5);
            this.scrapBtn.Name = "scrapBtn";
            this.scrapBtn.Size = new System.Drawing.Size(193, 52);
            this.scrapBtn.TabIndex = 2;
            this.scrapBtn.Text = "Scrap";
            this.scrapBtn.UseVisualStyleBackColor = false;
            this.scrapBtn.Click += new System.EventHandler(this.scrapBtn_Click);
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
            this.NewDepotBtn.Location = new System.Drawing.Point(1334, 11);
            this.NewDepotBtn.Margin = new System.Windows.Forms.Padding(5);
            this.NewDepotBtn.Name = "NewDepotBtn";
            this.NewDepotBtn.Size = new System.Drawing.Size(181, 41);
            this.NewDepotBtn.TabIndex = 0;
            this.NewDepotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewDepotBtn.Click += new System.EventHandler(this.NewDepotBtn_Click);
            // 
            // Panel_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1557, 738);
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
            ((System.ComponentModel.ISupportInitialize)(this.promoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixedCaseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferStockBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.bunifuGradientPanel5.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuImageButton DeleteButton;
        private Bunifu.Framework.UI.BunifuImageButton AddBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Label label1;
        private TextBox SearchTxt;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Button scrapBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 NewDepotBtn;
    }
}