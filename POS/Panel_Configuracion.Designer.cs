using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Configuracion));
            this.headderLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.footerLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.printerPanel = new System.Windows.Forms.Panel();
            this.selectPrinterBtn = new System.Windows.Forms.Button();
            this.printerNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.ticketLayout = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.ticketPanelLeft = new System.Windows.Forms.Panel();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.logoSectionPanel = new System.Windows.Forms.Panel();
            this.LogoCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.searchLogoBtn = new System.Windows.Forms.Button();
            this.LogopathLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.headderTxt = new System.Windows.Forms.TextBox();
            this.headderFontTxt = new System.Windows.Forms.TextBox();
            this.headerFontBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.footerCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.footerTxt = new System.Windows.Forms.TextBox();
            this.footerFontTxt = new System.Windows.Forms.TextBox();
            this.footerFontBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ticketPanelRight = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.printBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.phoneCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.phoneFontTxt = new System.Windows.Forms.TextBox();
            this.phoneFontBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressFontTxt = new System.Windows.Forms.TextBox();
            this.addresFontBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ticketPanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SetPrinterBtnElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printerPanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.NormalizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.printerPanel.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.ticketLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.ticketPanelLeft.SuspendLayout();
            this.logoSectionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ticketPanelRight.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headderLbl
            // 
            this.headderLbl.AutoSize = true;
            this.headderLbl.Location = new System.Drawing.Point(95, 10);
            this.headderLbl.Name = "headderLbl";
            this.headderLbl.Size = new System.Drawing.Size(290, 32);
            this.headderLbl.TabIndex = 0;
            this.headderLbl.Text = "Nombre del Negocio";
            this.headderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headderLbl.FontChanged += new System.EventHandler(this.headderLbl_FontChanged_1);
            this.headderLbl.SizeChanged += new System.EventHandler(this.headderLbl_SizeChanged);
            this.headderLbl.TextChanged += new System.EventHandler(this.headderLbl_TextChanged);
            this.headderLbl.VisibleChanged += new System.EventHandler(this.headderLbl_VisibleChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(171, 66);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(139, 32);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Dirección";
            this.addressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addressLbl.FontChanged += new System.EventHandler(this.headderLbl_FontChanged_1);
            this.addressLbl.LocationChanged += new System.EventHandler(this.addressLbl_LocationChanged);
            this.addressLbl.SizeChanged += new System.EventHandler(this.addressLbl_SizeChanged);
            this.addressLbl.TextChanged += new System.EventHandler(this.addressLbl_TextChanged);
            // 
            // footerLbl
            // 
            this.footerLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.footerLbl.AutoSize = true;
            this.footerLbl.Location = new System.Drawing.Point(75, 639);
            this.footerLbl.Name = "footerLbl";
            this.footerLbl.Size = new System.Drawing.Size(330, 32);
            this.footerLbl.TabIndex = 3;
            this.footerLbl.Text = "pie de página del ticket";
            this.footerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.footerLbl.FontChanged += new System.EventHandler(this.headderLbl_FontChanged_1);
            this.footerLbl.SizeChanged += new System.EventHandler(this.footerLbl_SizeChanged);
            this.footerLbl.TextChanged += new System.EventHandler(this.footerLbl_TextChanged);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(178, 126);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(124, 32);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = "Teléfono";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phoneLbl.FontChanged += new System.EventHandler(this.headderLbl_FontChanged_1);
            this.phoneLbl.SizeChanged += new System.EventHandler(this.phoneLbl_SizeChanged);
            this.phoneLbl.TextChanged += new System.EventHandler(this.phoneLbl_TextChanged);
            // 
            // printerPanel
            // 
            this.printerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.printerPanel.Controls.Add(this.selectPrinterBtn);
            this.printerPanel.Controls.Add(this.printerNameLbl);
            this.printerPanel.Controls.Add(this.label1);
            this.printerPanel.Location = new System.Drawing.Point(10, 70);
            this.printerPanel.Name = "printerPanel";
            this.printerPanel.Size = new System.Drawing.Size(1538, 130);
            this.printerPanel.TabIndex = 48;
            this.printerPanel.SizeChanged += new System.EventHandler(this.printerPanel_SizeChanged);
            // 
            // selectPrinterBtn
            // 
            this.selectPrinterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.selectPrinterBtn.FlatAppearance.BorderSize = 0;
            this.selectPrinterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPrinterBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.selectPrinterBtn.ForeColor = System.Drawing.Color.White;
            this.selectPrinterBtn.Location = new System.Drawing.Point(604, 79);
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
            this.printerNameLbl.Size = new System.Drawing.Size(1184, 33);
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
            this.ticketPanel.Controls.Add(this.ticketPanelLeft);
            this.ticketPanel.Controls.Add(this.ticketPanelRight);
            this.ticketPanel.Enabled = false;
            this.ticketPanel.Location = new System.Drawing.Point(10, 206);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(1538, 854);
            this.ticketPanel.TabIndex = 49;
            this.ticketPanel.Visible = false;
            // 
            // ticketLayout
            // 
            this.ticketLayout.BackColor = System.Drawing.Color.White;
            this.ticketLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketLayout.Controls.Add(this.splitContainer1);
            this.ticketLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketLayout.Location = new System.Drawing.Point(528, 0);
            this.ticketLayout.Name = "ticketLayout";
            this.ticketLayout.Size = new System.Drawing.Size(483, 854);
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
            this.splitContainer1.Panel2.Controls.Add(this.addressLbl);
            this.splitContainer1.Panel2.Controls.Add(this.headderLbl);
            this.splitContainer1.Panel2.Controls.Add(this.phoneLbl);
            this.splitContainer1.Panel2.Controls.Add(this.footerLbl);
            this.splitContainer1.Size = new System.Drawing.Size(481, 852);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 29;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(481, 160);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Visible = false;
            // 
            // ticketPanelLeft
            // 
            this.ticketPanelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.ticketPanelLeft.Controls.Add(this.bunifuCheckbox2);
            this.ticketPanelLeft.Controls.Add(this.logoSectionPanel);
            this.ticketPanelLeft.Controls.Add(this.panel1);
            this.ticketPanelLeft.Controls.Add(this.panel2);
            this.ticketPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ticketPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.ticketPanelLeft.Name = "ticketPanelLeft";
            this.ticketPanelLeft.Size = new System.Drawing.Size(528, 854);
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
            this.logoSectionPanel.Controls.Add(this.LogoCheckbox);
            this.logoSectionPanel.Controls.Add(this.searchLogoBtn);
            this.logoSectionPanel.Controls.Add(this.LogopathLbl);
            this.logoSectionPanel.Controls.Add(this.label2);
            this.logoSectionPanel.Location = new System.Drawing.Point(71, 12);
            this.logoSectionPanel.Name = "logoSectionPanel";
            this.logoSectionPanel.Size = new System.Drawing.Size(387, 180);
            this.logoSectionPanel.TabIndex = 72;
            // 
            // LogoCheckbox
            // 
            this.LogoCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.LogoCheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.LogoCheckbox.Checked = true;
            this.LogoCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.LogoCheckbox.ForeColor = System.Drawing.Color.White;
            this.LogoCheckbox.Location = new System.Drawing.Point(298, 27);
            this.LogoCheckbox.Margin = new System.Windows.Forms.Padding(184, 129, 184, 129);
            this.LogoCheckbox.Name = "LogoCheckbox";
            this.LogoCheckbox.Size = new System.Drawing.Size(20, 20);
            this.LogoCheckbox.TabIndex = 71;
            this.LogoCheckbox.OnChange += new System.EventHandler(this.LogoCheckbox_OnChange);
            // 
            // searchLogoBtn
            // 
            this.searchLogoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.searchLogoBtn.FlatAppearance.BorderSize = 0;
            this.searchLogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchLogoBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.searchLogoBtn.ForeColor = System.Drawing.Color.White;
            this.searchLogoBtn.Location = new System.Drawing.Point(87, 120);
            this.searchLogoBtn.Name = "searchLogoBtn";
            this.searchLogoBtn.Size = new System.Drawing.Size(212, 41);
            this.searchLogoBtn.TabIndex = 48;
            this.searchLogoBtn.Text = "Buscar";
            this.searchLogoBtn.UseVisualStyleBackColor = false;
            this.searchLogoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogopathLbl
            // 
            this.LogopathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogopathLbl.AutoEllipsis = true;
            this.LogopathLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.LogopathLbl.Location = new System.Drawing.Point(0, 70);
            this.LogopathLbl.Name = "LogopathLbl";
            this.LogopathLbl.Size = new System.Drawing.Size(387, 33);
            this.LogopathLbl.TabIndex = 47;
            this.LogopathLbl.Text = "...";
            this.LogopathLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logotipo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headerCheckBox);
            this.panel1.Controls.Add(this.headderTxt);
            this.panel1.Controls.Add(this.headderFontTxt);
            this.panel1.Controls.Add(this.headerFontBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(71, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 165);
            this.panel1.TabIndex = 73;
            // 
            // headerCheckBox
            // 
            this.headerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.headerCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.headerCheckBox.Checked = true;
            this.headerCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.headerCheckBox.ForeColor = System.Drawing.Color.White;
            this.headerCheckBox.Location = new System.Drawing.Point(298, 13);
            this.headerCheckBox.Margin = new System.Windows.Forms.Padding(65, 51, 65, 51);
            this.headerCheckBox.Name = "headerCheckBox";
            this.headerCheckBox.Size = new System.Drawing.Size(20, 20);
            this.headerCheckBox.TabIndex = 70;
            this.headerCheckBox.OnChange += new System.EventHandler(this.headerCheckBox_OnChange);
            // 
            // headderTxt
            // 
            this.headderTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.headderTxt.Location = new System.Drawing.Point(2, 46);
            this.headderTxt.MaxLength = 2147483647;
            this.headderTxt.Multiline = true;
            this.headderTxt.Name = "headderTxt";
            this.headderTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.headderTxt.Size = new System.Drawing.Size(382, 75);
            this.headderTxt.TabIndex = 52;
            this.headderTxt.TextChanged += new System.EventHandler(this.headderTxt_TextChanged);
            this.headderTxt.Leave += new System.EventHandler(this.headderTxt_Leave);
            // 
            // headderFontTxt
            // 
            this.headderFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.headderFontTxt.Location = new System.Drawing.Point(0, 132);
            this.headderFontTxt.Name = "headderFontTxt";
            this.headderFontTxt.Size = new System.Drawing.Size(349, 31);
            this.headderFontTxt.TabIndex = 53;
            this.headderFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.headderFontTxt_KeyDown);
            this.headderFontTxt.Leave += new System.EventHandler(this.headderFontTxt_Leave);
            // 
            // headerFontBtn
            // 
            this.headerFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.headerFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.headerFontBtn.ForeColor = System.Drawing.Color.Black;
            this.headerFontBtn.Location = new System.Drawing.Point(349, 132);
            this.headerFontBtn.Name = "headerFontBtn";
            this.headerFontBtn.Size = new System.Drawing.Size(38, 31);
            this.headerFontBtn.TabIndex = 54;
            this.headerFontBtn.Text = "...";
            this.headerFontBtn.UseVisualStyleBackColor = false;
            this.headerFontBtn.Click += new System.EventHandler(this.headerFontBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 49;
            this.label4.Text = "Encabezado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.footerCheckBox);
            this.panel2.Controls.Add(this.footerTxt);
            this.panel2.Controls.Add(this.footerFontTxt);
            this.panel2.Controls.Add(this.footerFontBtn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(71, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 166);
            this.panel2.TabIndex = 74;
            // 
            // footerCheckBox
            // 
            this.footerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.footerCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.footerCheckBox.Checked = true;
            this.footerCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.footerCheckBox.ForeColor = System.Drawing.Color.White;
            this.footerCheckBox.Location = new System.Drawing.Point(298, 14);
            this.footerCheckBox.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.footerCheckBox.Name = "footerCheckBox";
            this.footerCheckBox.Size = new System.Drawing.Size(20, 20);
            this.footerCheckBox.TabIndex = 69;
            this.footerCheckBox.OnChange += new System.EventHandler(this.bunifuCheckbox3_OnChange);
            // 
            // footerTxt
            // 
            this.footerTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.footerTxt.Location = new System.Drawing.Point(2, 47);
            this.footerTxt.MaxLength = 2147483647;
            this.footerTxt.Multiline = true;
            this.footerTxt.Name = "footerTxt";
            this.footerTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.footerTxt.Size = new System.Drawing.Size(382, 75);
            this.footerTxt.TabIndex = 65;
            this.footerTxt.TextChanged += new System.EventHandler(this.footerTxt_TextChanged);
            // 
            // footerFontTxt
            // 
            this.footerFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.footerFontTxt.Location = new System.Drawing.Point(0, 133);
            this.footerFontTxt.Name = "footerFontTxt";
            this.footerFontTxt.Size = new System.Drawing.Size(349, 31);
            this.footerFontTxt.TabIndex = 66;
            this.footerFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.footerFontTxt_KeyDown);
            this.footerFontTxt.Leave += new System.EventHandler(this.footerFontTxt_Leave);
            // 
            // footerFontBtn
            // 
            this.footerFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.footerFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footerFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.footerFontBtn.ForeColor = System.Drawing.Color.Black;
            this.footerFontBtn.Location = new System.Drawing.Point(349, 132);
            this.footerFontBtn.Name = "footerFontBtn";
            this.footerFontBtn.Size = new System.Drawing.Size(38, 31);
            this.footerFontBtn.TabIndex = 68;
            this.footerFontBtn.Text = "...";
            this.footerFontBtn.UseVisualStyleBackColor = false;
            this.footerFontBtn.Click += new System.EventHandler(this.footerFontBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 32);
            this.label9.TabIndex = 64;
            this.label9.Text = "Pie de Página";
            // 
            // ticketPanelRight
            // 
            this.ticketPanelRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ticketPanelRight.Controls.Add(this.panel5);
            this.ticketPanelRight.Controls.Add(this.panel4);
            this.ticketPanelRight.Controls.Add(this.panel3);
            this.ticketPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.ticketPanelRight.Location = new System.Drawing.Point(1011, 0);
            this.ticketPanelRight.Name = "ticketPanelRight";
            this.ticketPanelRight.Size = new System.Drawing.Size(527, 854);
            this.ticketPanelRight.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.printBtn);
            this.panel5.Controls.Add(this.saveSettingsBtn);
            this.panel5.Location = new System.Drawing.Point(72, 663);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 156);
            this.panel5.TabIndex = 67;
            // 
            // printBtn
            // 
            this.printBtn.ActiveBorderThickness = 1;
            this.printBtn.ActiveCornerRadius = 20;
            this.printBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.printBtn.ActiveForecolor = System.Drawing.Color.White;
            this.printBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
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
            this.printBtn.Location = new System.Drawing.Point(102, 14);
            this.printBtn.Margin = new System.Windows.Forms.Padding(5);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(181, 41);
            this.printBtn.TabIndex = 64;
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveSettingsBtn.FlatAppearance.BorderSize = 0;
            this.saveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.saveSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.saveSettingsBtn.Location = new System.Drawing.Point(86, 63);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(212, 80);
            this.saveSettingsBtn.TabIndex = 65;
            this.saveSettingsBtn.Text = "Guardar Configuración";
            this.saveSettingsBtn.UseVisualStyleBackColor = false;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.phoneCheckBox);
            this.panel4.Controls.Add(this.phoneTxt);
            this.panel4.Controls.Add(this.phoneFontTxt);
            this.panel4.Controls.Add(this.phoneFontBtn);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(70, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 174);
            this.panel4.TabIndex = 66;
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.phoneCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.phoneCheckBox.Checked = true;
            this.phoneCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.phoneCheckBox.ForeColor = System.Drawing.Color.White;
            this.phoneCheckBox.Location = new System.Drawing.Point(264, 16);
            this.phoneCheckBox.Margin = new System.Windows.Forms.Padding(8);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(20, 20);
            this.phoneCheckBox.TabIndex = 63;
            this.phoneCheckBox.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneTxt.Location = new System.Drawing.Point(2, 51);
            this.phoneTxt.MaxLength = 50;
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.phoneTxt.Size = new System.Drawing.Size(382, 75);
            this.phoneTxt.TabIndex = 60;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // phoneFontTxt
            // 
            this.phoneFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.phoneFontTxt.Location = new System.Drawing.Point(0, 137);
            this.phoneFontTxt.Name = "phoneFontTxt";
            this.phoneFontTxt.Size = new System.Drawing.Size(349, 31);
            this.phoneFontTxt.TabIndex = 61;
            this.phoneFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneFontTxt_KeyDown);
            this.phoneFontTxt.Leave += new System.EventHandler(this.phoneFontTxt_Leave);
            // 
            // phoneFontBtn
            // 
            this.phoneFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.phoneFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.phoneFontBtn.ForeColor = System.Drawing.Color.Black;
            this.phoneFontBtn.Location = new System.Drawing.Point(349, 137);
            this.phoneFontBtn.Name = "phoneFontBtn";
            this.phoneFontBtn.Size = new System.Drawing.Size(38, 31);
            this.phoneFontBtn.TabIndex = 62;
            this.phoneFontBtn.Text = "...";
            this.phoneFontBtn.UseVisualStyleBackColor = false;
            this.phoneFontBtn.Click += new System.EventHandler(this.phoneFontBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 32);
            this.label8.TabIndex = 59;
            this.label8.Text = "Teléfono";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addressTxt);
            this.panel3.Controls.Add(this.addressFontTxt);
            this.panel3.Controls.Add(this.addresFontBtn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(70, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 192);
            this.panel3.TabIndex = 65;
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.addressTxt.Location = new System.Drawing.Point(2, 60);
            this.addressTxt.MaxLength = 2147483647;
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressTxt.Size = new System.Drawing.Size(382, 75);
            this.addressTxt.TabIndex = 56;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // addressFontTxt
            // 
            this.addressFontTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.addressFontTxt.Location = new System.Drawing.Point(0, 146);
            this.addressFontTxt.Name = "addressFontTxt";
            this.addressFontTxt.Size = new System.Drawing.Size(349, 31);
            this.addressFontTxt.TabIndex = 57;
            this.addressFontTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressFontTxt_KeyDown);
            this.addressFontTxt.Leave += new System.EventHandler(this.addressFontTxt_Leave);
            // 
            // addresFontBtn
            // 
            this.addresFontBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addresFontBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addresFontBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.addresFontBtn.ForeColor = System.Drawing.Color.Black;
            this.addresFontBtn.Location = new System.Drawing.Point(349, 146);
            this.addresFontBtn.Name = "addresFontBtn";
            this.addresFontBtn.Size = new System.Drawing.Size(38, 31);
            this.addresFontBtn.TabIndex = 58;
            this.addresFontBtn.Text = "...";
            this.addresFontBtn.UseVisualStyleBackColor = false;
            this.addresFontBtn.Click += new System.EventHandler(this.addresFontBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 32);
            this.label6.TabIndex = 55;
            this.label6.Text = "Dirección";
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
            this.closeBtn.Location = new System.Drawing.Point(1526, 2);
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
            this.MaximizeBtn.Location = new System.Drawing.Point(1500, 2);
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
            this.NormalizeBtn.Location = new System.Drawing.Point(1500, 2);
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
            this.MimimizeBtn.Location = new System.Drawing.Point(1474, 2);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1558, 25);
            this.bunifuGradientPanel1.TabIndex = 45;
            // 
            // Panel_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 1061);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.printerPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Panel_Configuracion";
            this.ShowInTaskbar = false;
            this.Text = "Configuración de Equipo | Point of Sale";
            this.Load += new System.EventHandler(this.Panel_Configuracion_Load);
            this.Shown += new System.EventHandler(this.Panel_Configuracion_Shown);
            this.SizeChanged += new System.EventHandler(this.Panel_Configuracion_SizeChanged);
            this.printerPanel.ResumeLayout(false);
            this.printerPanel.PerformLayout();
            this.ticketPanel.ResumeLayout(false);
            this.ticketLayout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ticketPanelLeft.ResumeLayout(false);
            this.logoSectionPanel.ResumeLayout(false);
            this.logoSectionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ticketPanelRight.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headderLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label footerLbl;
        private System.Windows.Forms.Label phoneLbl;
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
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCheckbox headerCheckBox;
        private System.Windows.Forms.TextBox headderTxt;
        private System.Windows.Forms.TextBox headderFontTxt;
        private System.Windows.Forms.Button headerFontBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCheckbox footerCheckBox;
        private System.Windows.Forms.TextBox footerTxt;
        private System.Windows.Forms.TextBox footerFontTxt;
        private System.Windows.Forms.Button footerFontBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel ticketPanelRight;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuThinButton2 printBtn;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCheckbox phoneCheckBox;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox phoneFontTxt;
        private System.Windows.Forms.Button phoneFontBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox addressFontTxt;
        private System.Windows.Forms.Button addresFontBtn;
        private System.Windows.Forms.Label label6;
    }
}