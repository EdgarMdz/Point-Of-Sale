using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_Configuracion_Impresora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Configuracion_Impresora));
            this.printerPanel = new System.Windows.Forms.Panel();
            this.selectPrinterBtn = new System.Windows.Forms.Button();
            this.printerNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.ticketLayout = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.ticketPanelRight = new System.Windows.Forms.Panel();
            this.savePanel = new System.Windows.Forms.Panel();
            this.printBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.phonePanel = new System.Windows.Forms.Panel();
            this.phoneCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.phoneFontTxt = new System.Windows.Forms.TextBox();
            this.phoneFontBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressFontTxt = new System.Windows.Forms.TextBox();
            this.addresFontBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ticketPanelLeft = new System.Windows.Forms.Panel();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.logoSectionPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logoHeight = new System.Windows.Forms.NumericUpDown();
            this.LogoCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.searchLogoBtn = new System.Windows.Forms.Button();
            this.LogopathLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.headderTxt = new System.Windows.Forms.TextBox();
            this.headderFontTxt = new System.Windows.Forms.TextBox();
            this.headerFontBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.footerCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.footerTxt = new System.Windows.Forms.TextBox();
            this.footerFontTxt = new System.Windows.Forms.TextBox();
            this.footerFontBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ticketPanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SetPrinterBtnElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printerPanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.NormalizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printerPanel.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.ticketLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.ticketPanelRight.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.phonePanel.SuspendLayout();
            this.addressPanel.SuspendLayout();
            this.ticketPanelLeft.SuspendLayout();
            this.logoSectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoHeight)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printerPanel
            // 
            this.printerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.printerPanel.Controls.Add(this.selectPrinterBtn);
            this.printerPanel.Controls.Add(this.printerNameLbl);
            this.printerPanel.Controls.Add(this.label1);
            this.printerPanel.Location = new System.Drawing.Point(10, 49);
            this.printerPanel.Name = "printerPanel";
            this.printerPanel.Size = new System.Drawing.Size(1144, 130);
            this.printerPanel.TabIndex = 48;
            this.printerPanel.SizeChanged += new System.EventHandler(this.printerPanel_SizeChanged);
            // 
            // selectPrinterBtn
            // 
            this.selectPrinterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectPrinterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.selectPrinterBtn.FlatAppearance.BorderSize = 0;
            this.selectPrinterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPrinterBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.selectPrinterBtn.ForeColor = System.Drawing.Color.White;
            this.selectPrinterBtn.Location = new System.Drawing.Point(407, 79);
            this.selectPrinterBtn.Name = "selectPrinterBtn";
            this.selectPrinterBtn.Size = new System.Drawing.Size(330, 41);
            this.selectPrinterBtn.TabIndex = 47;
            this.selectPrinterBtn.Text = "Seleccionar Impresora";
            this.selectPrinterBtn.UseVisualStyleBackColor = false;
            this.selectPrinterBtn.Click += new System.EventHandler(this.selectPrinterBtn_Click);
            // 
            // printerNameLbl
            // 
            this.printerNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printerNameLbl.AutoEllipsis = true;
            this.printerNameLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.printerNameLbl.Location = new System.Drawing.Point(330, 26);
            this.printerNameLbl.Name = "printerNameLbl";
            this.printerNameLbl.Size = new System.Drawing.Size(790, 33);
            this.printerNameLbl.TabIndex = 46;
            this.printerNameLbl.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impresora de tickets:";
            // 
            // ticketPanel
            // 
            this.ticketPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ticketPanel.Controls.Add(this.ticketLayout);
            this.ticketPanel.Controls.Add(this.ticketPanelRight);
            this.ticketPanel.Controls.Add(this.ticketPanelLeft);
            this.ticketPanel.Enabled = false;
            this.ticketPanel.Location = new System.Drawing.Point(10, 206);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1144, 537);
            this.ticketPanel.TabIndex = 49;
            this.ticketPanel.Visible = false;
            // 
            // ticketLayout
            // 
            this.ticketLayout.BackColor = System.Drawing.Color.White;
            this.ticketLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketLayout.Controls.Add(this.splitContainer1);
            this.ticketLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketLayout.Location = new System.Drawing.Point(342, 0);
            this.ticketLayout.MinimumSize = new System.Drawing.Size(228, 422);
            this.ticketLayout.Name = "ticketLayout";
            this.ticketLayout.Size = new System.Drawing.Size(466, 537);
            this.ticketLayout.TabIndex = 0;
            this.ticketLayout.SizeChanged += new System.EventHandler(this.ticketLayout_SizeChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.logoPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.printPreviewControl1);
            this.splitContainer1.Size = new System.Drawing.Size(464, 535);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 29;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(464, 25);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Visible = false;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.BackColor = System.Drawing.Color.White;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(464, 506);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.UseAntiAlias = true;
            this.printPreviewControl1.Zoom = 1D;
            // 
            // ticketPanelRight
            // 
            this.ticketPanelRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ticketPanelRight.Controls.Add(this.savePanel);
            this.ticketPanelRight.Controls.Add(this.phonePanel);
            this.ticketPanelRight.Controls.Add(this.addressPanel);
            this.ticketPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.ticketPanelRight.Location = new System.Drawing.Point(808, 0);
            this.ticketPanelRight.Name = "ticketPanelRight";
            this.ticketPanelRight.Size = new System.Drawing.Size(336, 537);
            this.ticketPanelRight.TabIndex = 56;
            // 
            // savePanel
            // 
            this.savePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePanel.Controls.Add(this.printBtn);
            this.savePanel.Controls.Add(this.saveSettingsBtn);
            this.savePanel.Location = new System.Drawing.Point(30, 370);
            this.savePanel.Margin = new System.Windows.Forms.Padding(5);
            this.savePanel.MinimumSize = new System.Drawing.Size(282, 138);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(282, 138);
            this.savePanel.TabIndex = 67;
            // 
            // printBtn
            // 
            this.printBtn.ActiveBorderThickness = 1;
            this.printBtn.ActiveCornerRadius = 20;
            this.printBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.printBtn.ActiveForecolor = System.Drawing.Color.White;
            this.printBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.printBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.printBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printBtn.BackgroundImage")));
            this.printBtn.ButtonText = "Imprimir";
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.printBtn.IdleBorderThickness = 1;
            this.printBtn.IdleCornerRadius = 20;
            this.printBtn.IdleFillColor = System.Drawing.Color.White;
            this.printBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.printBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.printBtn.Location = new System.Drawing.Point(51, 5);
            this.printBtn.Margin = new System.Windows.Forms.Padding(5);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(181, 41);
            this.printBtn.TabIndex = 64;
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveSettingsBtn.FlatAppearance.BorderSize = 0;
            this.saveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.saveSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.saveSettingsBtn.Location = new System.Drawing.Point(35, 54);
            this.saveSettingsBtn.MaximumSize = new System.Drawing.Size(216, 81);
            this.saveSettingsBtn.MinimumSize = new System.Drawing.Size(187, 66);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(212, 80);
            this.saveSettingsBtn.TabIndex = 65;
            this.saveSettingsBtn.Text = "Guardar Configuración";
            this.saveSettingsBtn.UseVisualStyleBackColor = false;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // phonePanel
            // 
            this.phonePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phonePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phonePanel.Controls.Add(this.phoneCheckBox);
            this.phonePanel.Controls.Add(this.phoneTxt);
            this.phonePanel.Controls.Add(this.phoneFontTxt);
            this.phonePanel.Controls.Add(this.phoneFontBtn);
            this.phonePanel.Controls.Add(this.label8);
            this.phonePanel.Location = new System.Drawing.Point(25, 192);
            this.phonePanel.MaximumSize = new System.Drawing.Size(374, 209);
            this.phonePanel.MinimumSize = new System.Drawing.Size(283, 159);
            this.phonePanel.Name = "phonePanel";
            this.phonePanel.Size = new System.Drawing.Size(283, 159);
            this.phonePanel.TabIndex = 66;
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.phoneCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.phoneCheckBox.Checked = true;
            this.phoneCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.phoneCheckBox.ForeColor = System.Drawing.Color.White;
            this.phoneCheckBox.Location = new System.Drawing.Point(200, 15);
            this.phoneCheckBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(20, 20);
            this.phoneCheckBox.TabIndex = 63;
            this.phoneCheckBox.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneTxt.Location = new System.Drawing.Point(2, 42);
            this.phoneTxt.MaxLength = 50;
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.phoneTxt.Size = new System.Drawing.Size(279, 75);
            this.phoneTxt.TabIndex = 60;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // phoneFontTxt
            // 
            this.phoneFontTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneFontTxt.Location = new System.Drawing.Point(0, 120);
            this.phoneFontTxt.Name = "phoneFontTxt";
            this.phoneFontTxt.Size = new System.Drawing.Size(235, 31);
            this.phoneFontTxt.TabIndex = 61;
            this.phoneFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneFontTxt_KeyDown);
            this.phoneFontTxt.Leave += new System.EventHandler(this.phoneFontTxt_Leave);
            // 
            // phoneFontBtn
            // 
            this.phoneFontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.phoneFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.phoneFontBtn.ForeColor = System.Drawing.Color.Black;
            this.phoneFontBtn.Location = new System.Drawing.Point(241, 120);
            this.phoneFontBtn.Name = "phoneFontBtn";
            this.phoneFontBtn.Size = new System.Drawing.Size(38, 31);
            this.phoneFontBtn.TabIndex = 62;
            this.phoneFontBtn.Text = "...";
            this.phoneFontBtn.UseVisualStyleBackColor = false;
            this.phoneFontBtn.Click += new System.EventHandler(this.phoneFontBtn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 32);
            this.label8.TabIndex = 59;
            this.label8.Text = "Teléfono";
            // 
            // addressPanel
            // 
            this.addressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressPanel.Controls.Add(this.addressTxt);
            this.addressPanel.Controls.Add(this.addressFontTxt);
            this.addressPanel.Controls.Add(this.addresFontBtn);
            this.addressPanel.Controls.Add(this.label6);
            this.addressPanel.Location = new System.Drawing.Point(25, 14);
            this.addressPanel.MaximumSize = new System.Drawing.Size(374, 209);
            this.addressPanel.MinimumSize = new System.Drawing.Size(283, 159);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(283, 159);
            this.addressPanel.TabIndex = 65;
            // 
            // addressTxt
            // 
            this.addressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.addressTxt.Location = new System.Drawing.Point(2, 42);
            this.addressTxt.MaxLength = 2147483647;
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressTxt.Size = new System.Drawing.Size(279, 75);
            this.addressTxt.TabIndex = 56;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // addressFontTxt
            // 
            this.addressFontTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.addressFontTxt.Location = new System.Drawing.Point(0, 124);
            this.addressFontTxt.Name = "addressFontTxt";
            this.addressFontTxt.Size = new System.Drawing.Size(235, 31);
            this.addressFontTxt.TabIndex = 57;
            this.addressFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressFontTxt_KeyDown);
            this.addressFontTxt.Leave += new System.EventHandler(this.addressFontTxt_Leave);
            // 
            // addresFontBtn
            // 
            this.addresFontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addresFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addresFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addresFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.addresFontBtn.ForeColor = System.Drawing.Color.Black;
            this.addresFontBtn.Location = new System.Drawing.Point(241, 123);
            this.addresFontBtn.Name = "addresFontBtn";
            this.addresFontBtn.Size = new System.Drawing.Size(38, 31);
            this.addresFontBtn.TabIndex = 58;
            this.addresFontBtn.Text = "...";
            this.addresFontBtn.UseVisualStyleBackColor = false;
            this.addresFontBtn.Click += new System.EventHandler(this.addresFontBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 32);
            this.label6.TabIndex = 55;
            this.label6.Text = "Dirección";
            // 
            // ticketPanelLeft
            // 
            this.ticketPanelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.ticketPanelLeft.Controls.Add(this.bunifuCheckbox2);
            this.ticketPanelLeft.Controls.Add(this.logoSectionPanel);
            this.ticketPanelLeft.Controls.Add(this.headerPanel);
            this.ticketPanelLeft.Controls.Add(this.footerPanel);
            this.ticketPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ticketPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.ticketPanelLeft.Name = "ticketPanelLeft";
            this.ticketPanelLeft.Size = new System.Drawing.Size(342, 537);
            this.ticketPanelLeft.TabIndex = 55;
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(928, 1376);
            this.bunifuCheckbox2.Margin = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 67;
            // 
            // logoSectionPanel
            // 
            this.logoSectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoSectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoSectionPanel.Controls.Add(this.label3);
            this.logoSectionPanel.Controls.Add(this.logoHeight);
            this.logoSectionPanel.Controls.Add(this.LogoCheckbox);
            this.logoSectionPanel.Controls.Add(this.searchLogoBtn);
            this.logoSectionPanel.Controls.Add(this.LogopathLbl);
            this.logoSectionPanel.Controls.Add(this.label2);
            this.logoSectionPanel.Location = new System.Drawing.Point(30, 14);
            this.logoSectionPanel.MaximumSize = new System.Drawing.Size(387, 180);
            this.logoSectionPanel.MinimumSize = new System.Drawing.Size(283, 159);
            this.logoSectionPanel.Name = "logoSectionPanel";
            this.logoSectionPanel.Size = new System.Drawing.Size(283, 180);
            this.logoSectionPanel.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 75;
            this.label3.Text = "Altura";
            // 
            // logoHeight
            // 
            this.logoHeight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logoHeight.Location = new System.Drawing.Point(142, 83);
            this.logoHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.logoHeight.Name = "logoHeight";
            this.logoHeight.Size = new System.Drawing.Size(120, 41);
            this.logoHeight.TabIndex = 72;
            this.logoHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoHeight.ThousandsSeparator = true;
            this.logoHeight.ValueChanged += new System.EventHandler(this.logoHeight_ValueChanged);
            this.logoHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logoHeight_KeyPress);
            // 
            // LogoCheckbox
            // 
            this.LogoCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.LogoCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.LogoCheckbox.Checked = true;
            this.LogoCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.LogoCheckbox.ForeColor = System.Drawing.Color.White;
            this.LogoCheckbox.Location = new System.Drawing.Point(251, 12);
            this.LogoCheckbox.Margin = new System.Windows.Forms.Padding(184, 128, 184, 128);
            this.LogoCheckbox.Name = "LogoCheckbox";
            this.LogoCheckbox.Size = new System.Drawing.Size(20, 20);
            this.LogoCheckbox.TabIndex = 71;
            this.LogoCheckbox.OnChange += new System.EventHandler(this.LogoCheckbox_OnChange);
            // 
            // searchLogoBtn
            // 
            this.searchLogoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchLogoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.searchLogoBtn.FlatAppearance.BorderSize = 0;
            this.searchLogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchLogoBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.searchLogoBtn.ForeColor = System.Drawing.Color.White;
            this.searchLogoBtn.Location = new System.Drawing.Point(34, 128);
            this.searchLogoBtn.Name = "searchLogoBtn";
            this.searchLogoBtn.Size = new System.Drawing.Size(212, 41);
            this.searchLogoBtn.TabIndex = 48;
            this.searchLogoBtn.Text = "Buscar";
            this.searchLogoBtn.UseVisualStyleBackColor = false;
            this.searchLogoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogopathLbl
            // 
            this.LogopathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogopathLbl.AutoEllipsis = true;
            this.LogopathLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.LogopathLbl.Location = new System.Drawing.Point(0, 43);
            this.LogopathLbl.Name = "LogopathLbl";
            this.LogopathLbl.Size = new System.Drawing.Size(280, 33);
            this.LogopathLbl.TabIndex = 47;
            this.LogopathLbl.Text = "...";
            this.LogopathLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logotipo";
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.headerCheckBox);
            this.headerPanel.Controls.Add(this.headderTxt);
            this.headerPanel.Controls.Add(this.headderFontTxt);
            this.headerPanel.Controls.Add(this.headerFontBtn);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Location = new System.Drawing.Point(30, 203);
            this.headerPanel.MaximumSize = new System.Drawing.Size(374, 209);
            this.headerPanel.MinimumSize = new System.Drawing.Size(283, 159);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(283, 159);
            this.headerPanel.TabIndex = 73;
            // 
            // headerCheckBox
            // 
            this.headerCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.headerCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.headerCheckBox.Checked = true;
            this.headerCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.headerCheckBox.ForeColor = System.Drawing.Color.White;
            this.headerCheckBox.Location = new System.Drawing.Point(234, 7);
            this.headerCheckBox.Margin = new System.Windows.Forms.Padding(64, 52, 64, 52);
            this.headerCheckBox.Name = "headerCheckBox";
            this.headerCheckBox.Size = new System.Drawing.Size(20, 20);
            this.headerCheckBox.TabIndex = 70;
            this.headerCheckBox.OnChange += new System.EventHandler(this.headerCheckBox_OnChange);
            // 
            // headderTxt
            // 
            this.headderTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.headderTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.headderTxt.Location = new System.Drawing.Point(2, 42);
            this.headderTxt.MaxLength = 2147483647;
            this.headderTxt.Multiline = true;
            this.headderTxt.Name = "headderTxt";
            this.headderTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.headderTxt.Size = new System.Drawing.Size(279, 75);
            this.headderTxt.TabIndex = 52;
            this.headderTxt.TextChanged += new System.EventHandler(this.headderTxt_TextChanged);
            this.headderTxt.Leave += new System.EventHandler(this.headderTxt_Leave);
            // 
            // headderFontTxt
            // 
            this.headderFontTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headderFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.headderFontTxt.Location = new System.Drawing.Point(0, 124);
            this.headderFontTxt.Name = "headderFontTxt";
            this.headderFontTxt.Size = new System.Drawing.Size(241, 31);
            this.headderFontTxt.TabIndex = 53;
            this.headderFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.headderFontTxt_KeyDown);
            this.headderFontTxt.Leave += new System.EventHandler(this.headderFontTxt_Leave);
            // 
            // headerFontBtn
            // 
            this.headerFontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.headerFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.headerFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.headerFontBtn.ForeColor = System.Drawing.Color.Black;
            this.headerFontBtn.Location = new System.Drawing.Point(243, 125);
            this.headerFontBtn.Name = "headerFontBtn";
            this.headerFontBtn.Size = new System.Drawing.Size(38, 31);
            this.headerFontBtn.TabIndex = 54;
            this.headerFontBtn.Text = "...";
            this.headerFontBtn.UseVisualStyleBackColor = false;
            this.headerFontBtn.Click += new System.EventHandler(this.headerFontBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Encabezado";
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footerPanel.Controls.Add(this.footerCheckBox);
            this.footerPanel.Controls.Add(this.footerTxt);
            this.footerPanel.Controls.Add(this.footerFontTxt);
            this.footerPanel.Controls.Add(this.footerFontBtn);
            this.footerPanel.Controls.Add(this.label9);
            this.footerPanel.Location = new System.Drawing.Point(30, 371);
            this.footerPanel.MaximumSize = new System.Drawing.Size(374, 209);
            this.footerPanel.MinimumSize = new System.Drawing.Size(283, 159);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(283, 159);
            this.footerPanel.TabIndex = 74;
            // 
            // footerCheckBox
            // 
            this.footerCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.footerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.footerCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.footerCheckBox.Checked = true;
            this.footerCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.footerCheckBox.ForeColor = System.Drawing.Color.White;
            this.footerCheckBox.Location = new System.Drawing.Point(239, 10);
            this.footerCheckBox.Margin = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.footerCheckBox.Name = "footerCheckBox";
            this.footerCheckBox.Size = new System.Drawing.Size(20, 20);
            this.footerCheckBox.TabIndex = 69;
            this.footerCheckBox.OnChange += new System.EventHandler(this.bunifuCheckbox3_OnChange);
            // 
            // footerTxt
            // 
            this.footerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.footerTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.footerTxt.Location = new System.Drawing.Point(2, 42);
            this.footerTxt.MaxLength = 2147483647;
            this.footerTxt.Multiline = true;
            this.footerTxt.Name = "footerTxt";
            this.footerTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.footerTxt.Size = new System.Drawing.Size(279, 75);
            this.footerTxt.TabIndex = 65;
            this.footerTxt.TextChanged += new System.EventHandler(this.footerTxt_TextChanged);
            // 
            // footerFontTxt
            // 
            this.footerFontTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.footerFontTxt.Location = new System.Drawing.Point(0, 124);
            this.footerFontTxt.Name = "footerFontTxt";
            this.footerFontTxt.Size = new System.Drawing.Size(241, 31);
            this.footerFontTxt.TabIndex = 66;
            this.footerFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.footerFontTxt_KeyDown);
            this.footerFontTxt.Leave += new System.EventHandler(this.footerFontTxt_Leave);
            // 
            // footerFontBtn
            // 
            this.footerFontBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.footerFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.footerFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footerFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.footerFontBtn.ForeColor = System.Drawing.Color.Black;
            this.footerFontBtn.Location = new System.Drawing.Point(242, 124);
            this.footerFontBtn.Name = "footerFontBtn";
            this.footerFontBtn.Size = new System.Drawing.Size(38, 31);
            this.footerFontBtn.TabIndex = 68;
            this.footerFontBtn.Text = "...";
            this.footerFontBtn.UseVisualStyleBackColor = false;
            this.footerFontBtn.Click += new System.EventHandler(this.footerFontBtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 32);
            this.label9.TabIndex = 64;
            this.label9.Text = "Pie de Página";
            // 
            // ticketPanelElipse
            // 
            this.ticketPanelElipse.ElipseRadius = 30;
            this.ticketPanelElipse.TargetControl = this.ticketPanel;
            // 
            // SetPrinterBtnElipse
            // 
            this.SetPrinterBtnElipse.ElipseRadius = 15;
            this.SetPrinterBtnElipse.TargetControl = this.selectPrinterBtn;
            // 
            // printerPanelElipse
            // 
            this.printerPanelElipse.ElipseRadius = 30;
            this.printerPanelElipse.TargetControl = this.printerPanel;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1132, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeBtn.Image = global::POS.Properties.Resources.Maximize;
            this.MaximizeBtn.ImageActive = null;
            this.MaximizeBtn.Location = new System.Drawing.Point(1106, 2);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MaximizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizeBtn.TabIndex = 2;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.Zoom = 10;
            // 
            // NormalizeBtn
            // 
            this.NormalizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.NormalizeBtn.Image = global::POS.Properties.Resources.normalizar;
            this.NormalizeBtn.ImageActive = null;
            this.NormalizeBtn.Location = new System.Drawing.Point(1106, 2);
            this.NormalizeBtn.Name = "NormalizeBtn";
            this.NormalizeBtn.Size = new System.Drawing.Size(20, 20);
            this.NormalizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NormalizeBtn.TabIndex = 3;
            this.NormalizeBtn.TabStop = false;
            this.NormalizeBtn.Zoom = 10;
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1080, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.NormalizeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.MaximizeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1164, 25);
            this.bunifuGradientPanel1.TabIndex = 45;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_Configuracion_Impresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 749);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.printerPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Panel_Configuracion_Impresora";
            this.ShowInTaskbar = false;
            this.Text = "Configuración de Equipo | Point of Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_Configuracion_Impresora_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Configuracion_Load);
            this.Shown += new System.EventHandler(this.Panel_Configuracion_Shown);
            this.SizeChanged += new System.EventHandler(this.Panel_Configuracion_SizeChanged);
            this.printerPanel.ResumeLayout(false);
            this.printerPanel.PerformLayout();
            this.ticketPanel.ResumeLayout(false);
            this.ticketLayout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ticketPanelRight.ResumeLayout(false);
            this.savePanel.ResumeLayout(false);
            this.phonePanel.ResumeLayout(false);
            this.phonePanel.PerformLayout();
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.ticketPanelLeft.ResumeLayout(false);
            this.logoSectionPanel.ResumeLayout(false);
            this.logoSectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoHeight)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton NormalizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Panel printerPanel;
        private System.Windows.Forms.Panel ticketPanel;
        private Bunifu.Framework.UI.BunifuElipse ticketPanelElipse;
        private Bunifu.Framework.UI.BunifuElipse SetPrinterBtnElipse;
        private Bunifu.Framework.UI.BunifuElipse printerPanelElipse;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button selectPrinterBtn;
        private System.Windows.Forms.Label printerNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ticketLayout;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel ticketPanelLeft;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private System.Windows.Forms.Panel logoSectionPanel;
        private Bunifu.Framework.UI.BunifuCheckbox LogoCheckbox;
        private System.Windows.Forms.Button searchLogoBtn;
        private System.Windows.Forms.Label LogopathLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.Framework.UI.BunifuCheckbox headerCheckBox;
        private System.Windows.Forms.TextBox headderTxt;
        private System.Windows.Forms.TextBox headderFontTxt;
        private System.Windows.Forms.Button headerFontBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel footerPanel;
        private Bunifu.Framework.UI.BunifuCheckbox footerCheckBox;
        private System.Windows.Forms.TextBox footerTxt;
        private System.Windows.Forms.TextBox footerFontTxt;
        private System.Windows.Forms.Button footerFontBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel ticketPanelRight;
        private System.Windows.Forms.Panel savePanel;
        private Bunifu.Framework.UI.BunifuThinButton2 printBtn;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Panel phonePanel;
        private Bunifu.Framework.UI.BunifuCheckbox phoneCheckBox;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox phoneFontTxt;
        private System.Windows.Forms.Button phoneFontBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox addressFontTxt;
        private System.Windows.Forms.Button addresFontBtn;
        private System.Windows.Forms.Label label6;
        private PrintPreviewControl printPreviewControl1;
        private Timer timer1;
        private Label label3;
        private NumericUpDown logoHeight;
    }
}