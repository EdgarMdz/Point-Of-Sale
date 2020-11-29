using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WindowSizeControlPanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.VentasButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.SuppliersBtn = new System.Windows.Forms.Button();
            this.PurchasesBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.changeUserBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            this.MinutesLbl = new System.Windows.Forms.Label();
            this.Daylbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.HourLbl = new System.Windows.Forms.Label();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.WindowSizeControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.TabPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeUserBtn)).BeginInit();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowSizeControlPanel
            // 
            this.WindowSizeControlPanel.BackColor = System.Drawing.Color.White;
            this.WindowSizeControlPanel.Controls.Add(this.bunifuImageButton2);
            this.WindowSizeControlPanel.Controls.Add(this.bunifuImageButton1);
            this.WindowSizeControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowSizeControlPanel.Location = new System.Drawing.Point(202, 0);
            this.WindowSizeControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WindowSizeControlPanel.Name = "WindowSizeControlPanel";
            this.WindowSizeControlPanel.Size = new System.Drawing.Size(795, 25);
            this.WindowSizeControlPanel.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(772, 2);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.minimize;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(744, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TabPanel
            // 
            this.TabPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.TabPanel.Controls.Add(this.flowLayoutPanel1);
            this.TabPanel.Controls.Add(this.settingsPanel);
            this.TabPanel.Controls.Add(this.datePanel);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TabPanel.Location = new System.Drawing.Point(0, 0);
            this.TabPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(202, 700);
            this.TabPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.homeBtn);
            this.flowLayoutPanel1.Controls.Add(this.VentasButton);
            this.flowLayoutPanel1.Controls.Add(this.ProductsButton);
            this.flowLayoutPanel1.Controls.Add(this.statisticsBtn);
            this.flowLayoutPanel1.Controls.Add(this.ClientesBtn);
            this.flowLayoutPanel1.Controls.Add(this.SuppliersBtn);
            this.flowLayoutPanel1.Controls.Add(this.PurchasesBtn);
            this.flowLayoutPanel1.Controls.Add(this.employeeBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 471);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // homeBtn
            // 
            this.homeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeBtn.Location = new System.Drawing.Point(2, 2);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(204, 54);
            this.homeBtn.TabIndex = 13;
            this.homeBtn.Text = "Inicio";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // VentasButton
            // 
            this.VentasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.VentasButton.FlatAppearance.BorderSize = 0;
            this.VentasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentasButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VentasButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VentasButton.Location = new System.Drawing.Point(2, 60);
            this.VentasButton.Margin = new System.Windows.Forms.Padding(2);
            this.VentasButton.Name = "VentasButton";
            this.VentasButton.Size = new System.Drawing.Size(202, 54);
            this.VentasButton.TabIndex = 2;
            this.VentasButton.Text = "Ventas";
            this.VentasButton.UseVisualStyleBackColor = false;
            this.VentasButton.Click += new System.EventHandler(this.VentasButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsButton.Location = new System.Drawing.Point(2, 118);
            this.ProductsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(202, 54);
            this.ProductsButton.TabIndex = 3;
            this.ProductsButton.Text = "Inventario";
            this.ProductsButton.UseVisualStyleBackColor = false;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.statisticsBtn.FlatAppearance.BorderSize = 0;
            this.statisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statisticsBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statisticsBtn.Location = new System.Drawing.Point(2, 176);
            this.statisticsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(202, 54);
            this.statisticsBtn.TabIndex = 14;
            this.statisticsBtn.Text = "Estadísticas";
            this.statisticsBtn.UseVisualStyleBackColor = false;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.ClientesBtn.FlatAppearance.BorderSize = 0;
            this.ClientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientesBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientesBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientesBtn.Location = new System.Drawing.Point(2, 234);
            this.ClientesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(202, 54);
            this.ClientesBtn.TabIndex = 8;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.UseVisualStyleBackColor = false;
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            // 
            // SuppliersBtn
            // 
            this.SuppliersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.SuppliersBtn.FlatAppearance.BorderSize = 0;
            this.SuppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppliersBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SuppliersBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SuppliersBtn.Location = new System.Drawing.Point(2, 292);
            this.SuppliersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SuppliersBtn.Name = "SuppliersBtn";
            this.SuppliersBtn.Size = new System.Drawing.Size(202, 54);
            this.SuppliersBtn.TabIndex = 9;
            this.SuppliersBtn.Text = "Proveedores";
            this.SuppliersBtn.UseVisualStyleBackColor = false;
            this.SuppliersBtn.Click += new System.EventHandler(this.SuppliersBtn_Click);
            // 
            // PurchasesBtn
            // 
            this.PurchasesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.PurchasesBtn.FlatAppearance.BorderSize = 0;
            this.PurchasesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchasesBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PurchasesBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PurchasesBtn.Location = new System.Drawing.Point(2, 350);
            this.PurchasesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PurchasesBtn.Name = "PurchasesBtn";
            this.PurchasesBtn.Size = new System.Drawing.Size(202, 54);
            this.PurchasesBtn.TabIndex = 10;
            this.PurchasesBtn.Text = "Compras";
            this.PurchasesBtn.UseVisualStyleBackColor = false;
            this.PurchasesBtn.Click += new System.EventHandler(this.PurchasesBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.employeeBtn.FlatAppearance.BorderSize = 0;
            this.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.employeeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeeBtn.Location = new System.Drawing.Point(2, 408);
            this.employeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(202, 54);
            this.employeeBtn.TabIndex = 12;
            this.employeeBtn.Text = "Empleados";
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.settingsBtn);
            this.settingsPanel.Controls.Add(this.changeUserBtn);
            this.settingsPanel.Controls.Add(this.userNameLbl);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsPanel.Location = new System.Drawing.Point(0, 600);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(202, 100);
            this.settingsPanel.TabIndex = 16;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.Image = global::POS.Properties.Resources.GearWhite;
            this.settingsBtn.ImageActive = null;
            this.settingsBtn.Location = new System.Drawing.Point(124, 8);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(60, 60);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsBtn.TabIndex = 11;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Zoom = 10;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // changeUserBtn
            // 
            this.changeUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeUserBtn.Image = global::POS.Properties.Resources.changeUserBtn;
            this.changeUserBtn.ImageActive = null;
            this.changeUserBtn.Location = new System.Drawing.Point(14, 11);
            this.changeUserBtn.Name = "changeUserBtn";
            this.changeUserBtn.Size = new System.Drawing.Size(51, 54);
            this.changeUserBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changeUserBtn.TabIndex = 15;
            this.changeUserBtn.TabStop = false;
            this.changeUserBtn.Zoom = 10;
            this.changeUserBtn.Click += new System.EventHandler(this.changeUserBtn_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.White;
            this.userNameLbl.Location = new System.Drawing.Point(0, 68);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(202, 32);
            this.userNameLbl.TabIndex = 16;
            this.userNameLbl.Text = "   Edgar";
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.MinutesLbl);
            this.datePanel.Controls.Add(this.Daylbl);
            this.datePanel.Controls.Add(this.DateLbl);
            this.datePanel.Controls.Add(this.HourLbl);
            this.datePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datePanel.Location = new System.Drawing.Point(0, 0);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(202, 129);
            this.datePanel.TabIndex = 17;
            // 
            // MinutesLbl
            // 
            this.MinutesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinutesLbl.AutoSize = true;
            this.MinutesLbl.BackColor = System.Drawing.Color.Transparent;
            this.MinutesLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesLbl.ForeColor = System.Drawing.Color.White;
            this.MinutesLbl.Location = new System.Drawing.Point(122, 17);
            this.MinutesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinutesLbl.Name = "MinutesLbl";
            this.MinutesLbl.Size = new System.Drawing.Size(64, 47);
            this.MinutesLbl.TabIndex = 5;
            this.MinutesLbl.Text = "22";
            this.MinutesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinutesLbl.Visible = false;
            // 
            // Daylbl
            // 
            this.Daylbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Daylbl.AutoSize = true;
            this.Daylbl.BackColor = System.Drawing.Color.Transparent;
            this.Daylbl.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daylbl.ForeColor = System.Drawing.Color.White;
            this.Daylbl.Location = new System.Drawing.Point(128, 65);
            this.Daylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Daylbl.Name = "Daylbl";
            this.Daylbl.Size = new System.Drawing.Size(48, 19);
            this.Daylbl.TabIndex = 6;
            this.Daylbl.Text = "Dom";
            this.Daylbl.Visible = false;
            // 
            // DateLbl
            // 
            this.DateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(128, 91);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(68, 19);
            this.DateLbl.TabIndex = 7;
            this.DateLbl.Text = "Nov 22";
            this.DateLbl.Visible = false;
            // 
            // HourLbl
            // 
            this.HourLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HourLbl.AutoSize = true;
            this.HourLbl.BackColor = System.Drawing.Color.Transparent;
            this.HourLbl.Font = new System.Drawing.Font("Century Gothic", 84.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLbl.ForeColor = System.Drawing.Color.White;
            this.HourLbl.Location = new System.Drawing.Point(-25, -3);
            this.HourLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HourLbl.Name = "HourLbl";
            this.HourLbl.Size = new System.Drawing.Size(183, 135);
            this.HourLbl.TabIndex = 4;
            this.HourLbl.Text = "22";
            this.HourLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HourLbl.Visible = false;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.AutoSize = true;
            this.ContainerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContainerPanel.BackColor = System.Drawing.Color.White;
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(202, 0);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(795, 700);
            this.ContainerPanel.TabIndex = 2;
            this.ContainerPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ContainerPanel_ControlAdded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(997, 700);
            this.Controls.Add(this.WindowSizeControlPanel);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.TabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.WindowSizeControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.TabPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeUserBtn)).EndInit();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WindowSizeControlPanel;
        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.Panel ContainerPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button VentasButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button SuppliersBtn;
        private System.Windows.Forms.Button PurchasesBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Panel settingsPanel;
        private Bunifu.Framework.UI.BunifuImageButton settingsBtn;
        private Bunifu.Framework.UI.BunifuImageButton changeUserBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label Daylbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label MinutesLbl;
        private System.Windows.Forms.Label HourLbl;
        private System.Windows.Forms.Timer time;
        private Button statisticsBtn;
        private Panel datePanel;
    }
}