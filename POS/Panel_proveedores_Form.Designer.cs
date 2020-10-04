using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_proveedores_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_proveedores_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddSupplierToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grandTotalLbl = new System.Windows.Forms.Label();
            this.ProductTableBtn = new System.Windows.Forms.Button();
            this.AlarmsBtn = new System.Windows.Forms.Button();
            this.RecomendValueBtn = new System.Windows.Forms.Button();
            this.AddNewCustomerBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.NextMonthButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.PreviousMonthButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.FilteringTextbox = new System.Windows.Forms.TextBox();
            this.PromoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.AgendaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NextDayButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TodayBtn = new System.Windows.Forms.Button();
            this.PreviousDayButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddNewReminderBtn = new System.Windows.Forms.Button();
            this.companyAddressTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.companyNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneNumberTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel9 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadingSupplierListBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.AdeudoLbl = new System.Windows.Forms.Label();
            this.LunesLbl = new System.Windows.Forms.Label();
            this.viernesLbl = new System.Windows.Forms.Label();
            this.sabadoLbl = new System.Windows.Forms.Label();
            this.juevesLbl = new System.Windows.Forms.Label();
            this.miercolesLbl = new System.Windows.Forms.Label();
            this.martesLbl = new System.Windows.Forms.Label();
            this.domingoLbl = new System.Windows.Forms.Label();
            this.SearchSupplierTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CalendarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Btn56 = new System.Windows.Forms.Button();
            this.Btn54 = new System.Windows.Forms.Button();
            this.Btn44 = new System.Windows.Forms.Button();
            this.Btn55 = new System.Windows.Forms.Button();
            this.Btn53 = new System.Windows.Forms.Button();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Btn52 = new System.Windows.Forms.Button();
            this.Btn43 = new System.Windows.Forms.Button();
            this.Btn51 = new System.Windows.Forms.Button();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Btn50 = new System.Windows.Forms.Button();
            this.Btn42 = new System.Windows.Forms.Button();
            this.Btn46 = new System.Windows.Forms.Button();
            this.Btn45 = new System.Windows.Forms.Button();
            this.Btn41 = new System.Windows.Forms.Button();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Btn40 = new System.Windows.Forms.Button();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl0 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Btn00 = new System.Windows.Forms.Button();
            this.Btn16 = new System.Windows.Forms.Button();
            this.Btn36 = new System.Windows.Forms.Button();
            this.Btn35 = new System.Windows.Forms.Button();
            this.Btn01 = new System.Windows.Forms.Button();
            this.Btn34 = new System.Windows.Forms.Button();
            this.Btn15 = new System.Windows.Forms.Button();
            this.Btn33 = new System.Windows.Forms.Button();
            this.Btn02 = new System.Windows.Forms.Button();
            this.Btn32 = new System.Windows.Forms.Button();
            this.Btn14 = new System.Windows.Forms.Button();
            this.Btn03 = new System.Windows.Forms.Button();
            this.Btn30 = new System.Windows.Forms.Button();
            this.Btn13 = new System.Windows.Forms.Button();
            this.Btn26 = new System.Windows.Forms.Button();
            this.Btn04 = new System.Windows.Forms.Button();
            this.Btn25 = new System.Windows.Forms.Button();
            this.Btn12 = new System.Windows.Forms.Button();
            this.Btn24 = new System.Windows.Forms.Button();
            this.Btn06 = new System.Windows.Forms.Button();
            this.Btn23 = new System.Windows.Forms.Button();
            this.Btn11 = new System.Windows.Forms.Button();
            this.Btn22 = new System.Windows.Forms.Button();
            this.Btn05 = new System.Windows.Forms.Button();
            this.Btn21 = new System.Windows.Forms.Button();
            this.Btn10 = new System.Windows.Forms.Button();
            this.Btn20 = new System.Windows.Forms.Button();
            this.Btn31 = new System.Windows.Forms.Button();
            this.ProggressActiveSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.ProgressUnactiveSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.NextPurchaseTableBtn = new System.Windows.Forms.Button();
            this.POBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NextPurchaseCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.casescountLbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piecesPerCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ProductTxt = new System.Windows.Forms.RichTextBox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.proccedPurchaseBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BasicInformationCard = new Bunifu.Framework.UI.BunifuCards();
            this.VisitingDaysPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DebtPannel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SupplierImagePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.CompanyNameCard = new Bunifu.Framework.UI.BunifuCards();
            this.SupplierImagePicBox = new System.Windows.Forms.PictureBox();
            this.BasicSupplierInformationPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.RemindersPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AgendaContainerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel7 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.DayNumberLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel8 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.YearLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DataGridCardControlPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ProductListPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ControlsContainerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SupplierInfromationPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.FlowContainerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SearchingPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuppliersPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ProgressAtiveBarElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProgressUnactiveBarElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ProductTableButtonElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NextPurchaseButtonElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AlarmsButtonElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SelectAllBtnElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.WindowSizeControlPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewCustomerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextMonthButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousMonthButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextDayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousDayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.NextPurchaseCard.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.bunifuGradientPanel5.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.BasicInformationCard.SuspendLayout();
            this.VisitingDaysPanel.SuspendLayout();
            this.DebtPannel.SuspendLayout();
            this.SupplierImagePanel.SuspendLayout();
            this.CompanyNameCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierImagePicBox)).BeginInit();
            this.BasicSupplierInformationPanel.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.RemindersPanel.SuspendLayout();
            this.AgendaContainerPanel.SuspendLayout();
            this.bunifuGradientPanel7.SuspendLayout();
            this.bunifuGradientPanel8.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.DataGridCardControlPanel.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.ProductListPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.ControlsContainerPanel.SuspendLayout();
            this.SupplierInfromationPanel.SuspendLayout();
            this.FlowContainerPanel.SuspendLayout();
            this.SearchingPanel.SuspendLayout();
            this.SuppliersPanel.SuspendLayout();
            this.WindowSizeControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // grandTotalLbl
            // 
            this.grandTotalLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grandTotalLbl.AutoEllipsis = true;
            this.grandTotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.grandTotalLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.grandTotalLbl.Location = new System.Drawing.Point(782, 10);
            this.grandTotalLbl.Name = "grandTotalLbl";
            this.grandTotalLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grandTotalLbl.Size = new System.Drawing.Size(756, 39);
            this.grandTotalLbl.TabIndex = 0;
            this.grandTotalLbl.Text = "Total = $0.00";
            this.grandTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSupplierToolTip.SetToolTip(this.grandTotalLbl, "Costo de la compra");
            // 
            // ProductTableBtn
            // 
            this.ProductTableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.ProductTableBtn.FlatAppearance.BorderSize = 0;
            this.ProductTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductTableBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTableBtn.ForeColor = System.Drawing.Color.White;
            this.ProductTableBtn.Location = new System.Drawing.Point(25, 3);
            this.ProductTableBtn.Name = "ProductTableBtn";
            this.ProductTableBtn.Size = new System.Drawing.Size(130, 61);
            this.ProductTableBtn.TabIndex = 15;
            this.ProductTableBtn.Text = "Productos";
            this.AddSupplierToolTip.SetToolTip(this.ProductTableBtn, "Lista de Productos");
            this.ProductTableBtn.UseVisualStyleBackColor = false;
            this.ProductTableBtn.Click += new System.EventHandler(this.ProductTableBtn_Click);
            // 
            // AlarmsBtn
            // 
            this.AlarmsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.AlarmsBtn.FlatAppearance.BorderSize = 0;
            this.AlarmsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlarmsBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmsBtn.ForeColor = System.Drawing.Color.White;
            this.AlarmsBtn.Location = new System.Drawing.Point(401, 3);
            this.AlarmsBtn.Name = "AlarmsBtn";
            this.AlarmsBtn.Size = new System.Drawing.Size(130, 61);
            this.AlarmsBtn.TabIndex = 17;
            this.AlarmsBtn.Text = "Recordatorios";
            this.AddSupplierToolTip.SetToolTip(this.AlarmsBtn, "Recordatorios");
            this.AlarmsBtn.UseVisualStyleBackColor = false;
            this.AlarmsBtn.Click += new System.EventHandler(this.AlarmsBtn_Click);
            // 
            // RecomendValueBtn
            // 
            this.RecomendValueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.RecomendValueBtn.FlatAppearance.BorderSize = 0;
            this.RecomendValueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecomendValueBtn.ForeColor = System.Drawing.Color.White;
            this.RecomendValueBtn.Location = new System.Drawing.Point(550, 10);
            this.RecomendValueBtn.Name = "RecomendValueBtn";
            this.RecomendValueBtn.Size = new System.Drawing.Size(292, 45);
            this.RecomendValueBtn.TabIndex = 1;
            this.RecomendValueBtn.Text = "Recomendar Valor";
            this.AddSupplierToolTip.SetToolTip(this.RecomendValueBtn, "Recomendar valor para la siguiente compra del producto seleccionado en la tabla");
            this.RecomendValueBtn.UseVisualStyleBackColor = false;
            this.RecomendValueBtn.Visible = false;
            this.RecomendValueBtn.Click += new System.EventHandler(this.AutoGenerateListBtn_Click);
            // 
            // AddNewCustomerBtn
            // 
            this.AddNewCustomerBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddNewCustomerBtn.Image = global::POS.Properties.Resources.plus;
            this.AddNewCustomerBtn.ImageActive = null;
            this.AddNewCustomerBtn.Location = new System.Drawing.Point(1576, 17);
            this.AddNewCustomerBtn.Name = "AddNewCustomerBtn";
            this.AddNewCustomerBtn.Size = new System.Drawing.Size(71, 69);
            this.AddNewCustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddNewCustomerBtn.TabIndex = 2;
            this.AddNewCustomerBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.AddNewCustomerBtn, "Agregar Proveedor\r\n");
            this.AddNewCustomerBtn.Zoom = 10;
            this.AddNewCustomerBtn.Click += new System.EventHandler(this.AddNewCustomerBtn_Click);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.BackColor = System.Drawing.Color.Transparent;
            this.NextMonthButton.Image = global::POS.Properties.Resources.Down_arrow;
            this.NextMonthButton.ImageActive = null;
            this.NextMonthButton.Location = new System.Drawing.Point(256, 4);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(29, 25);
            this.NextMonthButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextMonthButton.TabIndex = 10;
            this.NextMonthButton.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.NextMonthButton, "Avanzar un mes");
            this.NextMonthButton.Zoom = 10;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousMonthButton.Image = global::POS.Properties.Resources.Up_Arrow;
            this.PreviousMonthButton.ImageActive = null;
            this.PreviousMonthButton.Location = new System.Drawing.Point(226, 4);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(29, 25);
            this.PreviousMonthButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviousMonthButton.TabIndex = 9;
            this.PreviousMonthButton.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.PreviousMonthButton, "Retroceder un mes");
            this.PreviousMonthButton.Zoom = 10;
            this.PreviousMonthButton.Click += new System.EventHandler(this.PreviousMonthButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.Back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(20, 196);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(64, 69);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.bunifuImageButton1, "Atrás");
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FilteringTextbox
            // 
            this.FilteringTextbox.Location = new System.Drawing.Point(464, 6);
            this.FilteringTextbox.Name = "FilteringTextbox";
            this.FilteringTextbox.Size = new System.Drawing.Size(667, 41);
            this.FilteringTextbox.TabIndex = 0;
            this.AddSupplierToolTip.SetToolTip(this.FilteringTextbox, "Buscar un producto");
            this.FilteringTextbox.TextChanged += new System.EventHandler(this.FilteringTextbox_TextChanged);
            this.FilteringTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilteringTextbox_KeyDown);
            // 
            // PromoBtn
            // 
            this.PromoBtn.BackColor = System.Drawing.Color.Transparent;
            this.PromoBtn.Image = ((System.Drawing.Image)(resources.GetObject("PromoBtn.Image")));
            this.PromoBtn.ImageActive = null;
            this.PromoBtn.Location = new System.Drawing.Point(25, 607);
            this.PromoBtn.Name = "PromoBtn";
            this.PromoBtn.Size = new System.Drawing.Size(50, 50);
            this.PromoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PromoBtn.TabIndex = 4;
            this.PromoBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.PromoBtn, "Promociones");
            this.PromoBtn.Visible = false;
            this.PromoBtn.Zoom = 10;
            this.PromoBtn.Click += new System.EventHandler(this.PromoBtn_Click);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddRowBtn.Image = global::POS.Properties.Resources.plus;
            this.AddRowBtn.ImageActive = null;
            this.AddRowBtn.Location = new System.Drawing.Point(27, 118);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(50, 50);
            this.AddRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddRowBtn.TabIndex = 1;
            this.AddRowBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.AddRowBtn, "Agregar un producto");
            this.AddRowBtn.Zoom = 10;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // EditRowBtn
            // 
            this.EditRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditRowBtn.Image = global::POS.Properties.Resources.edit;
            this.EditRowBtn.ImageActive = null;
            this.EditRowBtn.Location = new System.Drawing.Point(25, 320);
            this.EditRowBtn.Name = "EditRowBtn";
            this.EditRowBtn.Size = new System.Drawing.Size(50, 50);
            this.EditRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditRowBtn.TabIndex = 2;
            this.EditRowBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.EditRowBtn, "Editar el producto seleccionado");
            this.EditRowBtn.Zoom = 10;
            this.EditRowBtn.Click += new System.EventHandler(this.EditRowBtn_Click);
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRowBtn.Image = global::POS.Properties.Resources.delete;
            this.DeleteRowBtn.ImageActive = null;
            this.DeleteRowBtn.Location = new System.Drawing.Point(25, 522);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(50, 50);
            this.DeleteRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteRowBtn.TabIndex = 3;
            this.DeleteRowBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.DeleteRowBtn, "Eliminar el producto seleccionado");
            this.DeleteRowBtn.Zoom = 10;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // AgendaPanel
            // 
            this.AgendaPanel.AutoScroll = true;
            this.AgendaPanel.ColumnCount = 2;
            this.AgendaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.AgendaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.73684F));
            this.AgendaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgendaPanel.Location = new System.Drawing.Point(0, 123);
            this.AgendaPanel.Margin = new System.Windows.Forms.Padding(1);
            this.AgendaPanel.Name = "AgendaPanel";
            this.AgendaPanel.RowCount = 24;
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.AgendaPanel.Size = new System.Drawing.Size(992, 120);
            this.AgendaPanel.TabIndex = 2;
            this.AddSupplierToolTip.SetToolTip(this.AgendaPanel, "Agregar nuevo recordatorio");
            this.AgendaPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            // 
            // NextDayButton
            // 
            this.NextDayButton.BackColor = System.Drawing.Color.Transparent;
            this.NextDayButton.Image = global::POS.Properties.Resources.right_arrow;
            this.NextDayButton.ImageActive = null;
            this.NextDayButton.Location = new System.Drawing.Point(208, 17);
            this.NextDayButton.Name = "NextDayButton";
            this.NextDayButton.Size = new System.Drawing.Size(35, 35);
            this.NextDayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextDayButton.TabIndex = 2;
            this.NextDayButton.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.NextDayButton, "Avanzar un día");
            this.NextDayButton.Zoom = 10;
            this.NextDayButton.Click += new System.EventHandler(this.NextDayButton_Click);
            // 
            // TodayBtn
            // 
            this.TodayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayBtn.BackColor = System.Drawing.Color.DimGray;
            this.TodayBtn.Enabled = false;
            this.TodayBtn.FlatAppearance.BorderSize = 0;
            this.TodayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayBtn.ForeColor = System.Drawing.Color.White;
            this.TodayBtn.Location = new System.Drawing.Point(404, 15);
            this.TodayBtn.Name = "TodayBtn";
            this.TodayBtn.Size = new System.Drawing.Size(75, 37);
            this.TodayBtn.TabIndex = 8;
            this.TodayBtn.Text = "Hoy";
            this.AddSupplierToolTip.SetToolTip(this.TodayBtn, "Ir a la fecha de hoy");
            this.TodayBtn.UseVisualStyleBackColor = false;
            this.TodayBtn.Click += new System.EventHandler(this.TodayBtn_Click);
            // 
            // PreviousDayButton
            // 
            this.PreviousDayButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousDayButton.Image = global::POS.Properties.Resources.left_arrow;
            this.PreviousDayButton.ImageActive = null;
            this.PreviousDayButton.Location = new System.Drawing.Point(3, 17);
            this.PreviousDayButton.Name = "PreviousDayButton";
            this.PreviousDayButton.Size = new System.Drawing.Size(35, 35);
            this.PreviousDayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviousDayButton.TabIndex = 1;
            this.PreviousDayButton.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.PreviousDayButton, "Retroceder un día");
            this.PreviousDayButton.Zoom = 10;
            this.PreviousDayButton.Click += new System.EventHandler(this.PreviousDayButton_Click);
            // 
            // AddNewReminderBtn
            // 
            this.AddNewReminderBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddNewReminderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.AddNewReminderBtn.FlatAppearance.BorderSize = 0;
            this.AddNewReminderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewReminderBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewReminderBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewReminderBtn.Location = new System.Drawing.Point(153, 16);
            this.AddNewReminderBtn.Name = "AddNewReminderBtn";
            this.AddNewReminderBtn.Size = new System.Drawing.Size(255, 37);
            this.AddNewReminderBtn.TabIndex = 9;
            this.AddNewReminderBtn.Text = "Nuevo Recordatorio";
            this.AddSupplierToolTip.SetToolTip(this.AddNewReminderBtn, "Agregar Nuevo Recordatorio");
            this.AddNewReminderBtn.UseVisualStyleBackColor = false;
            this.AddNewReminderBtn.Click += new System.EventHandler(this.AddNewReminderBtn_Click);
            // 
            // companyAddressTxt
            // 
            this.companyAddressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyAddressTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.companyAddressTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.companyAddressTxt.HintForeColor = System.Drawing.Color.Gray;
            this.companyAddressTxt.HintText = "Dirección";
            this.companyAddressTxt.isPassword = false;
            this.companyAddressTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.companyAddressTxt.LineIdleColor = System.Drawing.Color.Empty;
            this.companyAddressTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.companyAddressTxt.LineThickness = 4;
            this.companyAddressTxt.Location = new System.Drawing.Point(20, 67);
            this.companyAddressTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.companyAddressTxt.Name = "companyAddressTxt";
            this.companyAddressTxt.Size = new System.Drawing.Size(333, 47);
            this.companyAddressTxt.TabIndex = 32;
            this.companyAddressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSupplierToolTip.SetToolTip(this.companyAddressTxt, "Dirección");
            this.companyAddressTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.companyAddressTxt_KeyDown);
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyNameTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.companyNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.companyNameTxt.HintForeColor = System.Drawing.Color.Gray;
            this.companyNameTxt.HintText = "Nombre de la Empresa";
            this.companyNameTxt.isPassword = false;
            this.companyNameTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.companyNameTxt.LineIdleColor = System.Drawing.Color.Empty;
            this.companyNameTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.companyNameTxt.LineThickness = 4;
            this.companyNameTxt.Location = new System.Drawing.Point(20, 12);
            this.companyNameTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(333, 47);
            this.companyNameTxt.TabIndex = 31;
            this.companyNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSupplierToolTip.SetToolTip(this.companyNameTxt, "Nombre de la Empresa");
            this.companyNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.companyNameTxt_KeyDown);
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.phoneNumberTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.phoneNumberTxt.HintForeColor = System.Drawing.Color.Gray;
            this.phoneNumberTxt.HintText = "Teléfono";
            this.phoneNumberTxt.isPassword = false;
            this.phoneNumberTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.phoneNumberTxt.LineIdleColor = System.Drawing.Color.Empty;
            this.phoneNumberTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phoneNumberTxt.LineThickness = 4;
            this.phoneNumberTxt.Location = new System.Drawing.Point(20, 122);
            this.phoneNumberTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(333, 47);
            this.phoneNumberTxt.TabIndex = 33;
            this.phoneNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSupplierToolTip.SetToolTip(this.phoneNumberTxt, "Número de Teléfono");
            this.phoneNumberTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneNumberTxt_KeyDown);
            this.phoneNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTxt_KeyPress);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = global::POS.Properties.Resources.delete;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1583, 199);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(64, 69);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 20;
            this.bunifuImageButton3.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.bunifuImageButton3, "Eliminar Proveedor");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel9);
            this.panel1.Location = new System.Drawing.Point(25, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel9
            // 
            this.bunifuGradientPanel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel9.BackgroundImage")));
            this.bunifuGradientPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel9.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel9.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel9.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel9.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel9.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.bunifuGradientPanel9.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel9.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel9.Name = "bunifuGradientPanel9";
            this.bunifuGradientPanel9.Quality = 10;
            this.bunifuGradientPanel9.Size = new System.Drawing.Size(200, 25);
            this.bunifuGradientPanel9.TabIndex = 45;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(168, 2);
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
            this.MimimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MimimizeBtn.Image")));
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(139, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // flow1
            // 
            this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow1.Location = new System.Drawing.Point(0, 0);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(184, 71);
            this.flow1.TabIndex = 1;
            // 
            // LoadingSupplierListBar
            // 
            this.LoadingSupplierListBar.Location = new System.Drawing.Point(87, 305);
            this.LoadingSupplierListBar.Name = "LoadingSupplierListBar";
            this.LoadingSupplierListBar.Size = new System.Drawing.Size(815, 32);
            this.LoadingSupplierListBar.TabIndex = 0;
            this.LoadingSupplierListBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(123, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Días de Visita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label6.Location = new System.Drawing.Point(217, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Adeudo";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.ForeColor = System.Drawing.Color.White;
            this.MonthLabel.Location = new System.Drawing.Point(3, 4);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(159, 23);
            this.MonthLabel.TabIndex = 8;
            this.MonthLabel.Text = "Febrero de 2009";
            // 
            // Lbl5
            // 
            this.Lbl5.BackColor = System.Drawing.Color.Transparent;
            this.Lbl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.ForeColor = System.Drawing.Color.White;
            this.Lbl5.Location = new System.Drawing.Point(208, 0);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(35, 41);
            this.Lbl5.TabIndex = 47;
            this.Lbl5.Text = "vi";
            this.Lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdeudoLbl
            // 
            this.AdeudoLbl.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdeudoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.AdeudoLbl.Location = new System.Drawing.Point(14, 53);
            this.AdeudoLbl.Name = "AdeudoLbl";
            this.AdeudoLbl.Size = new System.Drawing.Size(506, 115);
            this.AdeudoLbl.TabIndex = 30;
            this.AdeudoLbl.Text = "$0.00";
            this.AdeudoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LunesLbl
            // 
            this.LunesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LunesLbl.AutoSize = true;
            this.LunesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.LunesLbl.Location = new System.Drawing.Point(103, 99);
            this.LunesLbl.Name = "LunesLbl";
            this.LunesLbl.Size = new System.Drawing.Size(32, 39);
            this.LunesLbl.TabIndex = 22;
            this.LunesLbl.Text = "L";
            this.LunesLbl.Click += new System.EventHandler(this.LunesLbl_Click);
            // 
            // viernesLbl
            // 
            this.viernesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viernesLbl.AutoSize = true;
            this.viernesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viernesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.viernesLbl.Location = new System.Drawing.Point(320, 99);
            this.viernesLbl.Name = "viernesLbl";
            this.viernesLbl.Size = new System.Drawing.Size(40, 39);
            this.viernesLbl.TabIndex = 23;
            this.viernesLbl.Text = "V";
            this.viernesLbl.Click += new System.EventHandler(this.viernesLbl_Click);
            // 
            // sabadoLbl
            // 
            this.sabadoLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sabadoLbl.AutoSize = true;
            this.sabadoLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabadoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.sabadoLbl.Location = new System.Drawing.Point(368, 99);
            this.sabadoLbl.Name = "sabadoLbl";
            this.sabadoLbl.Size = new System.Drawing.Size(33, 39);
            this.sabadoLbl.TabIndex = 24;
            this.sabadoLbl.Text = "S";
            this.sabadoLbl.Click += new System.EventHandler(this.sabadoLbl_Click);
            // 
            // juevesLbl
            // 
            this.juevesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.juevesLbl.AutoSize = true;
            this.juevesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juevesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.juevesLbl.Location = new System.Drawing.Point(280, 99);
            this.juevesLbl.Name = "juevesLbl";
            this.juevesLbl.Size = new System.Drawing.Size(32, 39);
            this.juevesLbl.TabIndex = 25;
            this.juevesLbl.Text = "J";
            this.juevesLbl.Click += new System.EventHandler(this.juevesLbl_Click);
            // 
            // miercolesLbl
            // 
            this.miercolesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.miercolesLbl.AutoSize = true;
            this.miercolesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miercolesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.miercolesLbl.Location = new System.Drawing.Point(219, 99);
            this.miercolesLbl.Name = "miercolesLbl";
            this.miercolesLbl.Size = new System.Drawing.Size(53, 39);
            this.miercolesLbl.TabIndex = 26;
            this.miercolesLbl.Text = "Mi";
            this.miercolesLbl.Click += new System.EventHandler(this.miercolesLbl_Click);
            // 
            // martesLbl
            // 
            this.martesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.martesLbl.AutoSize = true;
            this.martesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.martesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.martesLbl.Location = new System.Drawing.Point(143, 99);
            this.martesLbl.Name = "martesLbl";
            this.martesLbl.Size = new System.Drawing.Size(68, 39);
            this.martesLbl.TabIndex = 27;
            this.martesLbl.Text = "Ma";
            this.martesLbl.Click += new System.EventHandler(this.martesLbl_Click);
            // 
            // domingoLbl
            // 
            this.domingoLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.domingoLbl.AutoSize = true;
            this.domingoLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domingoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.domingoLbl.Location = new System.Drawing.Point(54, 99);
            this.domingoLbl.Name = "domingoLbl";
            this.domingoLbl.Size = new System.Drawing.Size(41, 39);
            this.domingoLbl.TabIndex = 28;
            this.domingoLbl.Text = "D";
            this.domingoLbl.Click += new System.EventHandler(this.domingoLbl_Click);
            // 
            // SearchSupplierTxt
            // 
            this.SearchSupplierTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchSupplierTxt.Location = new System.Drawing.Point(132, 30);
            this.SearchSupplierTxt.Name = "SearchSupplierTxt";
            this.SearchSupplierTxt.Size = new System.Drawing.Size(430, 41);
            this.SearchSupplierTxt.TabIndex = 0;
            this.SearchSupplierTxt.TextChanged += new System.EventHandler(this.SearchProvider_TextChanged);
            this.SearchSupplierTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSupplierTxt_KeyDown);
            this.SearchSupplierTxt.Leave += new System.EventHandler(this.SearchSupplierTxt_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.CalendarPanel);
            this.panel2.Controls.Add(this.MonthLabel);
            this.panel2.Controls.Add(this.NextMonthButton);
            this.panel2.Controls.Add(this.PreviousMonthButton);
            this.panel2.Location = new System.Drawing.Point(25, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 326);
            this.panel2.TabIndex = 6;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.BackColor = System.Drawing.Color.Transparent;
            this.CalendarPanel.ColumnCount = 7;
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendarPanel.Controls.Add(this.Btn56, 6, 6);
            this.CalendarPanel.Controls.Add(this.Btn54, 4, 6);
            this.CalendarPanel.Controls.Add(this.Btn44, 4, 5);
            this.CalendarPanel.Controls.Add(this.Btn55, 5, 6);
            this.CalendarPanel.Controls.Add(this.Btn53, 3, 6);
            this.CalendarPanel.Controls.Add(this.Lbl6, 6, 0);
            this.CalendarPanel.Controls.Add(this.Btn52, 2, 6);
            this.CalendarPanel.Controls.Add(this.Btn43, 3, 5);
            this.CalendarPanel.Controls.Add(this.Btn51, 1, 6);
            this.CalendarPanel.Controls.Add(this.Lbl4, 4, 0);
            this.CalendarPanel.Controls.Add(this.Btn50, 0, 6);
            this.CalendarPanel.Controls.Add(this.Btn42, 2, 5);
            this.CalendarPanel.Controls.Add(this.Btn46, 6, 5);
            this.CalendarPanel.Controls.Add(this.Lbl5, 5, 0);
            this.CalendarPanel.Controls.Add(this.Btn45, 5, 5);
            this.CalendarPanel.Controls.Add(this.Btn41, 1, 5);
            this.CalendarPanel.Controls.Add(this.Lbl3, 3, 0);
            this.CalendarPanel.Controls.Add(this.Btn40, 0, 5);
            this.CalendarPanel.Controls.Add(this.Lbl2, 2, 0);
            this.CalendarPanel.Controls.Add(this.Lbl0, 0, 0);
            this.CalendarPanel.Controls.Add(this.Lbl1, 1, 0);
            this.CalendarPanel.Controls.Add(this.Btn00, 0, 1);
            this.CalendarPanel.Controls.Add(this.Btn16, 6, 2);
            this.CalendarPanel.Controls.Add(this.Btn36, 6, 4);
            this.CalendarPanel.Controls.Add(this.Btn35, 5, 4);
            this.CalendarPanel.Controls.Add(this.Btn01, 1, 1);
            this.CalendarPanel.Controls.Add(this.Btn34, 4, 4);
            this.CalendarPanel.Controls.Add(this.Btn15, 5, 2);
            this.CalendarPanel.Controls.Add(this.Btn33, 3, 4);
            this.CalendarPanel.Controls.Add(this.Btn02, 2, 1);
            this.CalendarPanel.Controls.Add(this.Btn32, 2, 4);
            this.CalendarPanel.Controls.Add(this.Btn14, 4, 2);
            this.CalendarPanel.Controls.Add(this.Btn03, 3, 1);
            this.CalendarPanel.Controls.Add(this.Btn30, 0, 4);
            this.CalendarPanel.Controls.Add(this.Btn13, 3, 2);
            this.CalendarPanel.Controls.Add(this.Btn26, 6, 3);
            this.CalendarPanel.Controls.Add(this.Btn04, 4, 1);
            this.CalendarPanel.Controls.Add(this.Btn25, 5, 3);
            this.CalendarPanel.Controls.Add(this.Btn12, 2, 2);
            this.CalendarPanel.Controls.Add(this.Btn24, 4, 3);
            this.CalendarPanel.Controls.Add(this.Btn06, 6, 1);
            this.CalendarPanel.Controls.Add(this.Btn23, 3, 3);
            this.CalendarPanel.Controls.Add(this.Btn11, 1, 2);
            this.CalendarPanel.Controls.Add(this.Btn22, 2, 3);
            this.CalendarPanel.Controls.Add(this.Btn05, 5, 1);
            this.CalendarPanel.Controls.Add(this.Btn21, 1, 3);
            this.CalendarPanel.Controls.Add(this.Btn10, 0, 2);
            this.CalendarPanel.Controls.Add(this.Btn20, 0, 3);
            this.CalendarPanel.Controls.Add(this.Btn31, 1, 4);
            this.CalendarPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.CalendarPanel.Location = new System.Drawing.Point(1, 35);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.RowCount = 7;
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarPanel.Size = new System.Drawing.Size(290, 290);
            this.CalendarPanel.TabIndex = 7;
            // 
            // Btn56
            // 
            this.Btn56.BackColor = System.Drawing.Color.Transparent;
            this.Btn56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn56.FlatAppearance.BorderSize = 0;
            this.Btn56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn56.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn56.ForeColor = System.Drawing.Color.White;
            this.Btn56.Location = new System.Drawing.Point(249, 249);
            this.Btn56.Name = "Btn56";
            this.Btn56.Size = new System.Drawing.Size(38, 38);
            this.Btn56.TabIndex = 133;
            this.Btn56.Text = "0";
            this.Btn56.UseVisualStyleBackColor = false;
            this.Btn56.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn54
            // 
            this.Btn54.BackColor = System.Drawing.Color.Transparent;
            this.Btn54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn54.FlatAppearance.BorderSize = 0;
            this.Btn54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn54.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn54.ForeColor = System.Drawing.Color.Silver;
            this.Btn54.Location = new System.Drawing.Point(167, 249);
            this.Btn54.Name = "Btn54";
            this.Btn54.Size = new System.Drawing.Size(35, 38);
            this.Btn54.TabIndex = 141;
            this.Btn54.Text = "8";
            this.Btn54.UseVisualStyleBackColor = false;
            this.Btn54.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn44
            // 
            this.Btn44.BackColor = System.Drawing.Color.Transparent;
            this.Btn44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn44.FlatAppearance.BorderSize = 0;
            this.Btn44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn44.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn44.ForeColor = System.Drawing.Color.Silver;
            this.Btn44.Location = new System.Drawing.Point(167, 208);
            this.Btn44.Name = "Btn44";
            this.Btn44.Size = new System.Drawing.Size(35, 35);
            this.Btn44.TabIndex = 146;
            this.Btn44.Text = "1";
            this.Btn44.UseVisualStyleBackColor = false;
            this.Btn44.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn55
            // 
            this.Btn55.BackColor = System.Drawing.Color.Transparent;
            this.Btn55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn55.FlatAppearance.BorderSize = 0;
            this.Btn55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn55.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn55.ForeColor = System.Drawing.Color.Silver;
            this.Btn55.Location = new System.Drawing.Point(208, 249);
            this.Btn55.Name = "Btn55";
            this.Btn55.Size = new System.Drawing.Size(35, 38);
            this.Btn55.TabIndex = 134;
            this.Btn55.Text = "9";
            this.Btn55.UseVisualStyleBackColor = false;
            this.Btn55.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn53
            // 
            this.Btn53.BackColor = System.Drawing.Color.Transparent;
            this.Btn53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn53.FlatAppearance.BorderSize = 0;
            this.Btn53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn53.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn53.ForeColor = System.Drawing.Color.Silver;
            this.Btn53.Location = new System.Drawing.Point(126, 249);
            this.Btn53.Name = "Btn53";
            this.Btn53.Size = new System.Drawing.Size(35, 38);
            this.Btn53.TabIndex = 140;
            this.Btn53.Text = "7";
            this.Btn53.UseVisualStyleBackColor = false;
            this.Btn53.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Lbl6
            // 
            this.Lbl6.BackColor = System.Drawing.Color.Transparent;
            this.Lbl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.ForeColor = System.Drawing.Color.White;
            this.Lbl6.Location = new System.Drawing.Point(249, 0);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(38, 41);
            this.Lbl6.TabIndex = 129;
            this.Lbl6.Text = "sa";
            this.Lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn52
            // 
            this.Btn52.BackColor = System.Drawing.Color.Transparent;
            this.Btn52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn52.FlatAppearance.BorderSize = 0;
            this.Btn52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn52.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn52.ForeColor = System.Drawing.Color.Silver;
            this.Btn52.Location = new System.Drawing.Point(85, 249);
            this.Btn52.Name = "Btn52";
            this.Btn52.Size = new System.Drawing.Size(35, 38);
            this.Btn52.TabIndex = 139;
            this.Btn52.Text = "6";
            this.Btn52.UseVisualStyleBackColor = false;
            this.Btn52.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn43
            // 
            this.Btn43.BackColor = System.Drawing.Color.Transparent;
            this.Btn43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn43.FlatAppearance.BorderSize = 0;
            this.Btn43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn43.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn43.ForeColor = System.Drawing.Color.White;
            this.Btn43.Location = new System.Drawing.Point(126, 208);
            this.Btn43.Name = "Btn43";
            this.Btn43.Size = new System.Drawing.Size(35, 35);
            this.Btn43.TabIndex = 145;
            this.Btn43.Text = "31";
            this.Btn43.UseVisualStyleBackColor = false;
            this.Btn43.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn51
            // 
            this.Btn51.BackColor = System.Drawing.Color.Transparent;
            this.Btn51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn51.FlatAppearance.BorderSize = 0;
            this.Btn51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn51.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn51.ForeColor = System.Drawing.Color.Silver;
            this.Btn51.Location = new System.Drawing.Point(44, 249);
            this.Btn51.Name = "Btn51";
            this.Btn51.Size = new System.Drawing.Size(35, 38);
            this.Btn51.TabIndex = 138;
            this.Btn51.Text = "5";
            this.Btn51.UseVisualStyleBackColor = false;
            this.Btn51.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Lbl4
            // 
            this.Lbl4.BackColor = System.Drawing.Color.Transparent;
            this.Lbl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.ForeColor = System.Drawing.Color.White;
            this.Lbl4.Location = new System.Drawing.Point(167, 0);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(35, 41);
            this.Lbl4.TabIndex = 132;
            this.Lbl4.Text = "ju";
            this.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn50
            // 
            this.Btn50.BackColor = System.Drawing.Color.Transparent;
            this.Btn50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn50.FlatAppearance.BorderSize = 0;
            this.Btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn50.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn50.ForeColor = System.Drawing.Color.Silver;
            this.Btn50.Location = new System.Drawing.Point(3, 249);
            this.Btn50.Name = "Btn50";
            this.Btn50.Size = new System.Drawing.Size(35, 38);
            this.Btn50.TabIndex = 137;
            this.Btn50.Text = "4";
            this.Btn50.UseVisualStyleBackColor = false;
            this.Btn50.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn42
            // 
            this.Btn42.BackColor = System.Drawing.Color.Transparent;
            this.Btn42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn42.FlatAppearance.BorderSize = 0;
            this.Btn42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn42.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn42.ForeColor = System.Drawing.Color.White;
            this.Btn42.Location = new System.Drawing.Point(85, 208);
            this.Btn42.Name = "Btn42";
            this.Btn42.Size = new System.Drawing.Size(35, 35);
            this.Btn42.TabIndex = 144;
            this.Btn42.Text = "30";
            this.Btn42.UseVisualStyleBackColor = false;
            this.Btn42.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn46
            // 
            this.Btn46.BackColor = System.Drawing.Color.Transparent;
            this.Btn46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn46.FlatAppearance.BorderSize = 0;
            this.Btn46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn46.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn46.ForeColor = System.Drawing.Color.Silver;
            this.Btn46.Location = new System.Drawing.Point(249, 208);
            this.Btn46.Name = "Btn46";
            this.Btn46.Size = new System.Drawing.Size(38, 35);
            this.Btn46.TabIndex = 136;
            this.Btn46.Text = "3";
            this.Btn46.UseVisualStyleBackColor = false;
            this.Btn46.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn45
            // 
            this.Btn45.BackColor = System.Drawing.Color.Transparent;
            this.Btn45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn45.FlatAppearance.BorderSize = 0;
            this.Btn45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn45.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn45.ForeColor = System.Drawing.Color.Silver;
            this.Btn45.Location = new System.Drawing.Point(208, 208);
            this.Btn45.Name = "Btn45";
            this.Btn45.Size = new System.Drawing.Size(35, 35);
            this.Btn45.TabIndex = 135;
            this.Btn45.Text = "2";
            this.Btn45.UseVisualStyleBackColor = false;
            this.Btn45.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn41
            // 
            this.Btn41.BackColor = System.Drawing.Color.Transparent;
            this.Btn41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn41.FlatAppearance.BorderSize = 0;
            this.Btn41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn41.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn41.ForeColor = System.Drawing.Color.White;
            this.Btn41.Location = new System.Drawing.Point(44, 208);
            this.Btn41.Name = "Btn41";
            this.Btn41.Size = new System.Drawing.Size(35, 35);
            this.Btn41.TabIndex = 143;
            this.Btn41.Text = "29";
            this.Btn41.UseVisualStyleBackColor = false;
            this.Btn41.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.ForeColor = System.Drawing.Color.White;
            this.Lbl3.Location = new System.Drawing.Point(126, 0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(35, 41);
            this.Lbl3.TabIndex = 131;
            this.Lbl3.Text = "mi";
            this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn40
            // 
            this.Btn40.BackColor = System.Drawing.Color.Transparent;
            this.Btn40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn40.FlatAppearance.BorderSize = 0;
            this.Btn40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn40.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn40.ForeColor = System.Drawing.Color.White;
            this.Btn40.Location = new System.Drawing.Point(3, 208);
            this.Btn40.Name = "Btn40";
            this.Btn40.Size = new System.Drawing.Size(35, 35);
            this.Btn40.TabIndex = 142;
            this.Btn40.Text = "28";
            this.Btn40.UseVisualStyleBackColor = false;
            this.Btn40.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.ForeColor = System.Drawing.Color.White;
            this.Lbl2.Location = new System.Drawing.Point(85, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(35, 41);
            this.Lbl2.TabIndex = 130;
            this.Lbl2.Text = "ma";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl0
            // 
            this.Lbl0.BackColor = System.Drawing.Color.Transparent;
            this.Lbl0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl0.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl0.ForeColor = System.Drawing.Color.White;
            this.Lbl0.Location = new System.Drawing.Point(3, 0);
            this.Lbl0.Name = "Lbl0";
            this.Lbl0.Size = new System.Drawing.Size(35, 41);
            this.Lbl0.TabIndex = 75;
            this.Lbl0.Text = "do";
            this.Lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl1
            // 
            this.Lbl1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.ForeColor = System.Drawing.Color.White;
            this.Lbl1.Location = new System.Drawing.Point(44, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(35, 41);
            this.Lbl1.TabIndex = 128;
            this.Lbl1.Text = "lu";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn00
            // 
            this.Btn00.BackColor = System.Drawing.Color.Transparent;
            this.Btn00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn00.FlatAppearance.BorderSize = 0;
            this.Btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn00.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn00.ForeColor = System.Drawing.Color.Silver;
            this.Btn00.Location = new System.Drawing.Point(3, 44);
            this.Btn00.Name = "Btn00";
            this.Btn00.Size = new System.Drawing.Size(35, 35);
            this.Btn00.TabIndex = 100;
            this.Btn00.Text = "1";
            this.Btn00.UseVisualStyleBackColor = false;
            this.Btn00.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn16
            // 
            this.Btn16.BackColor = System.Drawing.Color.Transparent;
            this.Btn16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn16.FlatAppearance.BorderSize = 0;
            this.Btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn16.ForeColor = System.Drawing.Color.White;
            this.Btn16.Location = new System.Drawing.Point(249, 85);
            this.Btn16.Name = "Btn16";
            this.Btn16.Size = new System.Drawing.Size(38, 35);
            this.Btn16.TabIndex = 113;
            this.Btn16.Text = "13";
            this.Btn16.UseVisualStyleBackColor = false;
            this.Btn16.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn36
            // 
            this.Btn36.BackColor = System.Drawing.Color.Transparent;
            this.Btn36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn36.FlatAppearance.BorderSize = 0;
            this.Btn36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn36.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn36.ForeColor = System.Drawing.Color.White;
            this.Btn36.Location = new System.Drawing.Point(249, 167);
            this.Btn36.Name = "Btn36";
            this.Btn36.Size = new System.Drawing.Size(38, 35);
            this.Btn36.TabIndex = 28;
            this.Btn36.Text = "27";
            this.Btn36.UseVisualStyleBackColor = false;
            this.Btn36.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn35
            // 
            this.Btn35.BackColor = System.Drawing.Color.Transparent;
            this.Btn35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn35.FlatAppearance.BorderSize = 0;
            this.Btn35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn35.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn35.ForeColor = System.Drawing.Color.White;
            this.Btn35.Location = new System.Drawing.Point(208, 167);
            this.Btn35.Name = "Btn35";
            this.Btn35.Size = new System.Drawing.Size(35, 35);
            this.Btn35.TabIndex = 126;
            this.Btn35.Text = "26";
            this.Btn35.UseVisualStyleBackColor = false;
            this.Btn35.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn01
            // 
            this.Btn01.BackColor = System.Drawing.Color.Transparent;
            this.Btn01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn01.FlatAppearance.BorderSize = 0;
            this.Btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn01.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn01.ForeColor = System.Drawing.Color.White;
            this.Btn01.Location = new System.Drawing.Point(44, 44);
            this.Btn01.Name = "Btn01";
            this.Btn01.Size = new System.Drawing.Size(35, 35);
            this.Btn01.TabIndex = 101;
            this.Btn01.Text = "1";
            this.Btn01.UseVisualStyleBackColor = false;
            this.Btn01.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn34
            // 
            this.Btn34.BackColor = System.Drawing.Color.Transparent;
            this.Btn34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn34.FlatAppearance.BorderSize = 0;
            this.Btn34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn34.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn34.ForeColor = System.Drawing.Color.White;
            this.Btn34.Location = new System.Drawing.Point(167, 167);
            this.Btn34.Name = "Btn34";
            this.Btn34.Size = new System.Drawing.Size(35, 35);
            this.Btn34.TabIndex = 125;
            this.Btn34.Text = "25";
            this.Btn34.UseVisualStyleBackColor = false;
            this.Btn34.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn15
            // 
            this.Btn15.BackColor = System.Drawing.Color.Transparent;
            this.Btn15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn15.FlatAppearance.BorderSize = 0;
            this.Btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn15.ForeColor = System.Drawing.Color.White;
            this.Btn15.Location = new System.Drawing.Point(208, 85);
            this.Btn15.Name = "Btn15";
            this.Btn15.Size = new System.Drawing.Size(35, 35);
            this.Btn15.TabIndex = 112;
            this.Btn15.Text = "12";
            this.Btn15.UseVisualStyleBackColor = false;
            this.Btn15.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn33
            // 
            this.Btn33.BackColor = System.Drawing.Color.Transparent;
            this.Btn33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn33.FlatAppearance.BorderSize = 0;
            this.Btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn33.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn33.ForeColor = System.Drawing.Color.White;
            this.Btn33.Location = new System.Drawing.Point(126, 167);
            this.Btn33.Name = "Btn33";
            this.Btn33.Size = new System.Drawing.Size(35, 35);
            this.Btn33.TabIndex = 124;
            this.Btn33.Text = "24";
            this.Btn33.UseVisualStyleBackColor = false;
            this.Btn33.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn02
            // 
            this.Btn02.BackColor = System.Drawing.Color.Transparent;
            this.Btn02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn02.FlatAppearance.BorderSize = 0;
            this.Btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn02.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn02.ForeColor = System.Drawing.Color.White;
            this.Btn02.Location = new System.Drawing.Point(85, 44);
            this.Btn02.Name = "Btn02";
            this.Btn02.Size = new System.Drawing.Size(35, 35);
            this.Btn02.TabIndex = 102;
            this.Btn02.Text = "2";
            this.Btn02.UseVisualStyleBackColor = false;
            this.Btn02.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn32
            // 
            this.Btn32.BackColor = System.Drawing.Color.Transparent;
            this.Btn32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn32.FlatAppearance.BorderSize = 0;
            this.Btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn32.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn32.ForeColor = System.Drawing.Color.White;
            this.Btn32.Location = new System.Drawing.Point(85, 167);
            this.Btn32.Name = "Btn32";
            this.Btn32.Size = new System.Drawing.Size(35, 35);
            this.Btn32.TabIndex = 123;
            this.Btn32.Text = "23";
            this.Btn32.UseVisualStyleBackColor = false;
            this.Btn32.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn14
            // 
            this.Btn14.BackColor = System.Drawing.Color.Transparent;
            this.Btn14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn14.FlatAppearance.BorderSize = 0;
            this.Btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn14.ForeColor = System.Drawing.Color.White;
            this.Btn14.Location = new System.Drawing.Point(167, 85);
            this.Btn14.Name = "Btn14";
            this.Btn14.Size = new System.Drawing.Size(35, 35);
            this.Btn14.TabIndex = 111;
            this.Btn14.Text = "11";
            this.Btn14.UseVisualStyleBackColor = false;
            this.Btn14.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn03
            // 
            this.Btn03.BackColor = System.Drawing.Color.Transparent;
            this.Btn03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn03.FlatAppearance.BorderSize = 0;
            this.Btn03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn03.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn03.ForeColor = System.Drawing.Color.White;
            this.Btn03.Location = new System.Drawing.Point(126, 44);
            this.Btn03.Name = "Btn03";
            this.Btn03.Size = new System.Drawing.Size(35, 35);
            this.Btn03.TabIndex = 103;
            this.Btn03.Text = "3";
            this.Btn03.UseVisualStyleBackColor = false;
            this.Btn03.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn30
            // 
            this.Btn30.BackColor = System.Drawing.Color.Transparent;
            this.Btn30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn30.FlatAppearance.BorderSize = 0;
            this.Btn30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn30.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn30.ForeColor = System.Drawing.Color.White;
            this.Btn30.Location = new System.Drawing.Point(3, 167);
            this.Btn30.Name = "Btn30";
            this.Btn30.Size = new System.Drawing.Size(35, 35);
            this.Btn30.TabIndex = 121;
            this.Btn30.Text = "21";
            this.Btn30.UseVisualStyleBackColor = false;
            this.Btn30.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn13
            // 
            this.Btn13.BackColor = System.Drawing.Color.Transparent;
            this.Btn13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn13.FlatAppearance.BorderSize = 0;
            this.Btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn13.ForeColor = System.Drawing.Color.White;
            this.Btn13.Location = new System.Drawing.Point(126, 85);
            this.Btn13.Name = "Btn13";
            this.Btn13.Size = new System.Drawing.Size(35, 35);
            this.Btn13.TabIndex = 110;
            this.Btn13.Text = "10";
            this.Btn13.UseVisualStyleBackColor = false;
            this.Btn13.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn26
            // 
            this.Btn26.BackColor = System.Drawing.Color.Transparent;
            this.Btn26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn26.FlatAppearance.BorderSize = 0;
            this.Btn26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn26.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn26.ForeColor = System.Drawing.Color.White;
            this.Btn26.Location = new System.Drawing.Point(249, 126);
            this.Btn26.Name = "Btn26";
            this.Btn26.Size = new System.Drawing.Size(38, 35);
            this.Btn26.TabIndex = 120;
            this.Btn26.Text = "20";
            this.Btn26.UseVisualStyleBackColor = false;
            this.Btn26.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn04
            // 
            this.Btn04.BackColor = System.Drawing.Color.Transparent;
            this.Btn04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn04.FlatAppearance.BorderSize = 0;
            this.Btn04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn04.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn04.ForeColor = System.Drawing.Color.White;
            this.Btn04.Location = new System.Drawing.Point(167, 44);
            this.Btn04.Name = "Btn04";
            this.Btn04.Size = new System.Drawing.Size(35, 35);
            this.Btn04.TabIndex = 104;
            this.Btn04.Text = "4";
            this.Btn04.UseVisualStyleBackColor = false;
            this.Btn04.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn25
            // 
            this.Btn25.BackColor = System.Drawing.Color.Transparent;
            this.Btn25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn25.FlatAppearance.BorderSize = 0;
            this.Btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn25.ForeColor = System.Drawing.Color.White;
            this.Btn25.Location = new System.Drawing.Point(208, 126);
            this.Btn25.Name = "Btn25";
            this.Btn25.Size = new System.Drawing.Size(35, 35);
            this.Btn25.TabIndex = 119;
            this.Btn25.Text = "19";
            this.Btn25.UseVisualStyleBackColor = false;
            this.Btn25.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn12
            // 
            this.Btn12.BackColor = System.Drawing.Color.Transparent;
            this.Btn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn12.FlatAppearance.BorderSize = 0;
            this.Btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn12.ForeColor = System.Drawing.Color.White;
            this.Btn12.Location = new System.Drawing.Point(85, 85);
            this.Btn12.Name = "Btn12";
            this.Btn12.Size = new System.Drawing.Size(35, 35);
            this.Btn12.TabIndex = 109;
            this.Btn12.Text = "9";
            this.Btn12.UseVisualStyleBackColor = false;
            this.Btn12.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn24
            // 
            this.Btn24.BackColor = System.Drawing.Color.Transparent;
            this.Btn24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn24.FlatAppearance.BorderSize = 0;
            this.Btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn24.ForeColor = System.Drawing.Color.White;
            this.Btn24.Location = new System.Drawing.Point(167, 126);
            this.Btn24.Name = "Btn24";
            this.Btn24.Size = new System.Drawing.Size(35, 35);
            this.Btn24.TabIndex = 118;
            this.Btn24.Text = "18";
            this.Btn24.UseVisualStyleBackColor = false;
            this.Btn24.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn06
            // 
            this.Btn06.BackColor = System.Drawing.Color.Transparent;
            this.Btn06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn06.FlatAppearance.BorderSize = 0;
            this.Btn06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn06.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn06.ForeColor = System.Drawing.Color.White;
            this.Btn06.Location = new System.Drawing.Point(249, 44);
            this.Btn06.Name = "Btn06";
            this.Btn06.Size = new System.Drawing.Size(38, 35);
            this.Btn06.TabIndex = 106;
            this.Btn06.Text = "6";
            this.Btn06.UseVisualStyleBackColor = false;
            this.Btn06.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn23
            // 
            this.Btn23.BackColor = System.Drawing.Color.Transparent;
            this.Btn23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn23.FlatAppearance.BorderSize = 0;
            this.Btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn23.ForeColor = System.Drawing.Color.White;
            this.Btn23.Location = new System.Drawing.Point(126, 126);
            this.Btn23.Name = "Btn23";
            this.Btn23.Size = new System.Drawing.Size(35, 35);
            this.Btn23.TabIndex = 117;
            this.Btn23.Text = "17";
            this.Btn23.UseVisualStyleBackColor = false;
            this.Btn23.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn11
            // 
            this.Btn11.BackColor = System.Drawing.Color.Transparent;
            this.Btn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn11.FlatAppearance.BorderSize = 0;
            this.Btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn11.ForeColor = System.Drawing.Color.White;
            this.Btn11.Location = new System.Drawing.Point(44, 85);
            this.Btn11.Name = "Btn11";
            this.Btn11.Size = new System.Drawing.Size(35, 35);
            this.Btn11.TabIndex = 108;
            this.Btn11.Text = "8";
            this.Btn11.UseVisualStyleBackColor = false;
            this.Btn11.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn22
            // 
            this.Btn22.BackColor = System.Drawing.Color.Transparent;
            this.Btn22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn22.FlatAppearance.BorderSize = 0;
            this.Btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn22.ForeColor = System.Drawing.Color.White;
            this.Btn22.Location = new System.Drawing.Point(85, 126);
            this.Btn22.Name = "Btn22";
            this.Btn22.Size = new System.Drawing.Size(35, 35);
            this.Btn22.TabIndex = 116;
            this.Btn22.Text = "16";
            this.Btn22.UseVisualStyleBackColor = false;
            this.Btn22.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn05
            // 
            this.Btn05.BackColor = System.Drawing.Color.Transparent;
            this.Btn05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn05.FlatAppearance.BorderSize = 0;
            this.Btn05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn05.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn05.ForeColor = System.Drawing.Color.White;
            this.Btn05.Location = new System.Drawing.Point(208, 44);
            this.Btn05.Name = "Btn05";
            this.Btn05.Size = new System.Drawing.Size(35, 35);
            this.Btn05.TabIndex = 105;
            this.Btn05.Text = "5";
            this.Btn05.UseVisualStyleBackColor = false;
            this.Btn05.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn21
            // 
            this.Btn21.BackColor = System.Drawing.Color.Transparent;
            this.Btn21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn21.FlatAppearance.BorderSize = 0;
            this.Btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn21.ForeColor = System.Drawing.Color.White;
            this.Btn21.Location = new System.Drawing.Point(44, 126);
            this.Btn21.Name = "Btn21";
            this.Btn21.Size = new System.Drawing.Size(35, 35);
            this.Btn21.TabIndex = 115;
            this.Btn21.Text = "15";
            this.Btn21.UseVisualStyleBackColor = false;
            this.Btn21.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn10
            // 
            this.Btn10.BackColor = System.Drawing.Color.Transparent;
            this.Btn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn10.FlatAppearance.BorderSize = 0;
            this.Btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn10.ForeColor = System.Drawing.Color.White;
            this.Btn10.Location = new System.Drawing.Point(3, 85);
            this.Btn10.Name = "Btn10";
            this.Btn10.Size = new System.Drawing.Size(35, 35);
            this.Btn10.TabIndex = 107;
            this.Btn10.Text = "7";
            this.Btn10.UseVisualStyleBackColor = false;
            this.Btn10.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn20
            // 
            this.Btn20.BackColor = System.Drawing.Color.Transparent;
            this.Btn20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn20.FlatAppearance.BorderSize = 0;
            this.Btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn20.ForeColor = System.Drawing.Color.White;
            this.Btn20.Location = new System.Drawing.Point(3, 126);
            this.Btn20.Name = "Btn20";
            this.Btn20.Size = new System.Drawing.Size(35, 35);
            this.Btn20.TabIndex = 114;
            this.Btn20.Text = "14";
            this.Btn20.UseVisualStyleBackColor = false;
            this.Btn20.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // Btn31
            // 
            this.Btn31.BackColor = System.Drawing.Color.Transparent;
            this.Btn31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn31.FlatAppearance.BorderSize = 0;
            this.Btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn31.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn31.ForeColor = System.Drawing.Color.White;
            this.Btn31.Location = new System.Drawing.Point(44, 167);
            this.Btn31.Name = "Btn31";
            this.Btn31.Size = new System.Drawing.Size(35, 35);
            this.Btn31.TabIndex = 133;
            this.Btn31.Text = "22";
            this.Btn31.UseVisualStyleBackColor = false;
            this.Btn31.Click += new System.EventHandler(this.DayButtons_Click);
            // 
            // ProggressActiveSeparator
            // 
            this.ProggressActiveSeparator.BackColor = System.Drawing.Color.Transparent;
            this.ProggressActiveSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.ProggressActiveSeparator.LineThickness = 65535;
            this.ProggressActiveSeparator.Location = new System.Drawing.Point(-2, 30);
            this.ProggressActiveSeparator.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.ProggressActiveSeparator.Name = "ProggressActiveSeparator";
            this.ProggressActiveSeparator.Size = new System.Drawing.Size(567, 15);
            this.ProggressActiveSeparator.TabIndex = 11;
            this.ProggressActiveSeparator.Transparency = 255;
            this.ProggressActiveSeparator.Vertical = false;
            // 
            // ProgressUnactiveSeparator
            // 
            this.ProgressUnactiveSeparator.BackColor = System.Drawing.Color.Transparent;
            this.ProgressUnactiveSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProgressUnactiveSeparator.LineThickness = 65535;
            this.ProgressUnactiveSeparator.Location = new System.Drawing.Point(-2, 30);
            this.ProgressUnactiveSeparator.Margin = new System.Windows.Forms.Padding(65, 51, 65, 51);
            this.ProgressUnactiveSeparator.Name = "ProgressUnactiveSeparator";
            this.ProgressUnactiveSeparator.Size = new System.Drawing.Size(567, 15);
            this.ProgressUnactiveSeparator.TabIndex = 14;
            this.ProgressUnactiveSeparator.Transparency = 255;
            this.ProgressUnactiveSeparator.Vertical = false;
            // 
            // NextPurchaseTableBtn
            // 
            this.NextPurchaseTableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.NextPurchaseTableBtn.FlatAppearance.BorderSize = 0;
            this.NextPurchaseTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPurchaseTableBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPurchaseTableBtn.ForeColor = System.Drawing.Color.White;
            this.NextPurchaseTableBtn.Location = new System.Drawing.Point(213, 3);
            this.NextPurchaseTableBtn.Name = "NextPurchaseTableBtn";
            this.NextPurchaseTableBtn.Size = new System.Drawing.Size(130, 61);
            this.NextPurchaseTableBtn.TabIndex = 16;
            this.NextPurchaseTableBtn.Text = "Siguiente Compra";
            this.NextPurchaseTableBtn.UseVisualStyleBackColor = false;
            this.NextPurchaseTableBtn.Click += new System.EventHandler(this.NextPurchaseTableBtn_Click);
            // 
            // POBtn
            // 
            this.POBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.POBtn.FlatAppearance.BorderSize = 0;
            this.POBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POBtn.ForeColor = System.Drawing.Color.White;
            this.POBtn.Location = new System.Drawing.Point(1433, 199);
            this.POBtn.Name = "POBtn";
            this.POBtn.Size = new System.Drawing.Size(212, 81);
            this.POBtn.TabIndex = 19;
            this.POBtn.Text = "Ordenes de Compra";
            this.POBtn.UseVisualStyleBackColor = false;
            this.POBtn.Visible = false;
            this.POBtn.Click += new System.EventHandler(this.POBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(346, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnDisplayIndexChanged);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowHeightChanged);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // NextPurchaseCard
            // 
            this.NextPurchaseCard.BackColor = System.Drawing.Color.White;
            this.NextPurchaseCard.BorderRadius = 15;
            this.NextPurchaseCard.BottomSahddow = true;
            this.NextPurchaseCard.color = System.Drawing.Color.White;
            this.NextPurchaseCard.Controls.Add(this.bunifuGradientPanel4);
            this.NextPurchaseCard.Controls.Add(this.bunifuGradientPanel5);
            this.NextPurchaseCard.Controls.Add(this.bunifuGradientPanel3);
            this.NextPurchaseCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextPurchaseCard.LeftSahddow = false;
            this.NextPurchaseCard.Location = new System.Drawing.Point(0, 0);
            this.NextPurchaseCard.Name = "NextPurchaseCard";
            this.NextPurchaseCard.RightSahddow = true;
            this.NextPurchaseCard.ShadowDepth = 20;
            this.NextPurchaseCard.Size = new System.Drawing.Size(1569, 691);
            this.NextPurchaseCard.TabIndex = 48;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.dataGridView2);
            this.bunifuGradientPanel4.Controls.Add(this.casescountLbl);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel4.ForeColor = System.Drawing.Color.LimeGreen;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(0, 53);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(1569, 575);
            this.bunifuGradientPanel4.TabIndex = 3;
            // 
            // casescountLbl
            // 
            this.casescountLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.casescountLbl.Location = new System.Drawing.Point(0, 532);
            this.casescountLbl.Name = "casescountLbl";
            this.casescountLbl.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.casescountLbl.Size = new System.Drawing.Size(1569, 43);
            this.casescountLbl.TabIndex = 4;
            this.casescountLbl.Text = "Total de productos: 0.00";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.description,
            this.brand,
            this.piecesPerCase,
            this.amount,
            this.depot,
            this.Total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1569, 532);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_RowHeightChanged);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.barcode.HeaderText = "Código de Barras";
            this.barcode.Name = "barcode";
            this.barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.barcode.Visible = false;
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
            this.brand.Width = 107;
            // 
            // piecesPerCase
            // 
            this.piecesPerCase.HeaderText = "Piezas por Caja";
            this.piecesPerCase.Name = "piecesPerCase";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.HeaderText = "Cantidad de Cajas";
            this.amount.Name = "amount";
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 176;
            // 
            // depot
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depot.DefaultCellStyle = dataGridViewCellStyle6;
            this.depot.HeaderText = "Bodega Destino";
            this.depot.Name = "depot";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 81;
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.Controls.Add(this.ProductTxt);
            this.bunifuGradientPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(1569, 53);
            this.bunifuGradientPanel5.TabIndex = 50;
            // 
            // ProductTxt
            // 
            this.ProductTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ProductTxt.Location = new System.Drawing.Point(4, 8);
            this.ProductTxt.Multiline = false;
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(1561, 37);
            this.ProductTxt.TabIndex = 2;
            this.ProductTxt.Text = "";
            this.ProductTxt.TextChanged += new System.EventHandler(this.ProductTxt_TextChanged);
            this.ProductTxt.Enter += new System.EventHandler(this.ProductTxt_Enter);
            this.ProductTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyDown);
            this.ProductTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductTxt_KeyPress);
            this.ProductTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyUp);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.proccedPurchaseBtn);
            this.bunifuGradientPanel3.Controls.Add(this.grandTotalLbl);
            this.bunifuGradientPanel3.Controls.Add(this.SaveBtn);
            this.bunifuGradientPanel3.Controls.Add(this.RecomendValueBtn);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 628);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1569, 63);
            this.bunifuGradientPanel3.TabIndex = 2;
            // 
            // proccedPurchaseBtn
            // 
            this.proccedPurchaseBtn.ActiveBorderThickness = 1;
            this.proccedPurchaseBtn.ActiveCornerRadius = 20;
            this.proccedPurchaseBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proccedPurchaseBtn.ActiveForecolor = System.Drawing.Color.White;
            this.proccedPurchaseBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proccedPurchaseBtn.BackColor = System.Drawing.Color.White;
            this.proccedPurchaseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proccedPurchaseBtn.BackgroundImage")));
            this.proccedPurchaseBtn.ButtonText = "Realizar Compra";
            this.proccedPurchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proccedPurchaseBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proccedPurchaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proccedPurchaseBtn.IdleBorderThickness = 1;
            this.proccedPurchaseBtn.IdleCornerRadius = 20;
            this.proccedPurchaseBtn.IdleFillColor = System.Drawing.Color.White;
            this.proccedPurchaseBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proccedPurchaseBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proccedPurchaseBtn.Location = new System.Drawing.Point(7, 11);
            this.proccedPurchaseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.proccedPurchaseBtn.Name = "proccedPurchaseBtn";
            this.proccedPurchaseBtn.Size = new System.Drawing.Size(181, 41);
            this.proccedPurchaseBtn.TabIndex = 4;
            this.proccedPurchaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.proccedPurchaseBtn.Click += new System.EventHandler(this.proccedPurchaseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Guardar Orden de Compra";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 20;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.White;
            this.SaveBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.SaveBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.SaveBtn.Location = new System.Drawing.Point(217, 11);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(265, 41);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BasicInformationCard
            // 
            this.BasicInformationCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasicInformationCard.BackColor = System.Drawing.Color.White;
            this.BasicInformationCard.BorderRadius = 15;
            this.BasicInformationCard.BottomSahddow = true;
            this.BasicInformationCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(203)))));
            this.BasicInformationCard.Controls.Add(this.VisitingDaysPanel);
            this.BasicInformationCard.Controls.Add(this.DebtPannel);
            this.BasicInformationCard.Controls.Add(this.bunifuSeparator2);
            this.BasicInformationCard.Controls.Add(this.SupplierImagePanel);
            this.BasicInformationCard.Controls.Add(this.BasicSupplierInformationPanel);
            this.BasicInformationCard.LeftSahddow = true;
            this.BasicInformationCard.Location = new System.Drawing.Point(0, 0);
            this.BasicInformationCard.Name = "BasicInformationCard";
            this.BasicInformationCard.RightSahddow = true;
            this.BasicInformationCard.ShadowDepth = 60;
            this.BasicInformationCard.Size = new System.Drawing.Size(1724, 187);
            this.BasicInformationCard.TabIndex = 8;
            // 
            // VisitingDaysPanel
            // 
            this.VisitingDaysPanel.BackColor = System.Drawing.Color.Transparent;
            this.VisitingDaysPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VisitingDaysPanel.BackgroundImage")));
            this.VisitingDaysPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisitingDaysPanel.Controls.Add(this.label2);
            this.VisitingDaysPanel.Controls.Add(this.sabadoLbl);
            this.VisitingDaysPanel.Controls.Add(this.LunesLbl);
            this.VisitingDaysPanel.Controls.Add(this.domingoLbl);
            this.VisitingDaysPanel.Controls.Add(this.viernesLbl);
            this.VisitingDaysPanel.Controls.Add(this.martesLbl);
            this.VisitingDaysPanel.Controls.Add(this.juevesLbl);
            this.VisitingDaysPanel.Controls.Add(this.miercolesLbl);
            this.VisitingDaysPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.VisitingDaysPanel.GradientBottomRight = System.Drawing.Color.White;
            this.VisitingDaysPanel.GradientTopLeft = System.Drawing.Color.White;
            this.VisitingDaysPanel.GradientTopRight = System.Drawing.Color.White;
            this.VisitingDaysPanel.Location = new System.Drawing.Point(491, 6);
            this.VisitingDaysPanel.Name = "VisitingDaysPanel";
            this.VisitingDaysPanel.Quality = 10;
            this.VisitingDaysPanel.Size = new System.Drawing.Size(414, 181);
            this.VisitingDaysPanel.TabIndex = 35;
            // 
            // DebtPannel
            // 
            this.DebtPannel.BackColor = System.Drawing.Color.Transparent;
            this.DebtPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DebtPannel.BackgroundImage")));
            this.DebtPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DebtPannel.Controls.Add(this.label6);
            this.DebtPannel.Controls.Add(this.AdeudoLbl);
            this.DebtPannel.GradientBottomLeft = System.Drawing.Color.White;
            this.DebtPannel.GradientBottomRight = System.Drawing.Color.White;
            this.DebtPannel.GradientTopLeft = System.Drawing.Color.White;
            this.DebtPannel.GradientTopRight = System.Drawing.Color.White;
            this.DebtPannel.Location = new System.Drawing.Point(903, 4);
            this.DebtPannel.Name = "DebtPannel";
            this.DebtPannel.Quality = 10;
            this.DebtPannel.Size = new System.Drawing.Size(535, 183);
            this.DebtPannel.TabIndex = 36;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(203)))));
            this.bunifuSeparator2.LineThickness = 65535;
            this.bunifuSeparator2.Location = new System.Drawing.Point(7151, 33);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(193, 1140);
            this.bunifuSeparator2.TabIndex = 15;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // SupplierImagePanel
            // 
            this.SupplierImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.SupplierImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SupplierImagePanel.BackgroundImage")));
            this.SupplierImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupplierImagePanel.Controls.Add(this.CompanyNameCard);
            this.SupplierImagePanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SupplierImagePanel.GradientBottomRight = System.Drawing.Color.White;
            this.SupplierImagePanel.GradientTopLeft = System.Drawing.Color.White;
            this.SupplierImagePanel.GradientTopRight = System.Drawing.Color.White;
            this.SupplierImagePanel.Location = new System.Drawing.Point(1444, 4);
            this.SupplierImagePanel.Name = "SupplierImagePanel";
            this.SupplierImagePanel.Quality = 10;
            this.SupplierImagePanel.Size = new System.Drawing.Size(389, 181);
            this.SupplierImagePanel.TabIndex = 38;
            // 
            // CompanyNameCard
            // 
            this.CompanyNameCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyNameCard.BackColor = System.Drawing.Color.Transparent;
            this.CompanyNameCard.BorderRadius = 15;
            this.CompanyNameCard.BottomSahddow = true;
            this.CompanyNameCard.color = System.Drawing.Color.Transparent;
            this.CompanyNameCard.Controls.Add(this.SupplierImagePicBox);
            this.CompanyNameCard.LeftSahddow = false;
            this.CompanyNameCard.Location = new System.Drawing.Point(63, 15);
            this.CompanyNameCard.Name = "CompanyNameCard";
            this.CompanyNameCard.RightSahddow = true;
            this.CompanyNameCard.ShadowDepth = 80;
            this.CompanyNameCard.Size = new System.Drawing.Size(250, 150);
            this.CompanyNameCard.TabIndex = 10;
            // 
            // SupplierImagePicBox
            // 
            this.SupplierImagePicBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SupplierImagePicBox.Location = new System.Drawing.Point(0, 0);
            this.SupplierImagePicBox.Name = "SupplierImagePicBox";
            this.SupplierImagePicBox.Size = new System.Drawing.Size(250, 150);
            this.SupplierImagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SupplierImagePicBox.TabIndex = 0;
            this.SupplierImagePicBox.TabStop = false;
            // 
            // BasicSupplierInformationPanel
            // 
            this.BasicSupplierInformationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BasicSupplierInformationPanel.BackgroundImage")));
            this.BasicSupplierInformationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BasicSupplierInformationPanel.Controls.Add(this.companyAddressTxt);
            this.BasicSupplierInformationPanel.Controls.Add(this.companyNameTxt);
            this.BasicSupplierInformationPanel.Controls.Add(this.phoneNumberTxt);
            this.BasicSupplierInformationPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.BasicSupplierInformationPanel.GradientBottomRight = System.Drawing.Color.White;
            this.BasicSupplierInformationPanel.GradientTopLeft = System.Drawing.Color.White;
            this.BasicSupplierInformationPanel.GradientTopRight = System.Drawing.Color.White;
            this.BasicSupplierInformationPanel.Location = new System.Drawing.Point(0, 6);
            this.BasicSupplierInformationPanel.Name = "BasicSupplierInformationPanel";
            this.BasicSupplierInformationPanel.Quality = 10;
            this.BasicSupplierInformationPanel.Size = new System.Drawing.Size(492, 181);
            this.BasicSupplierInformationPanel.TabIndex = 34;
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.panel2);
            this.bunifuGradientPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(341, 243);
            this.bunifuGradientPanel6.TabIndex = 0;
            // 
            // RemindersPanel
            // 
            this.RemindersPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemindersPanel.BackgroundImage")));
            this.RemindersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemindersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemindersPanel.Controls.Add(this.AgendaContainerPanel);
            this.RemindersPanel.Controls.Add(this.bunifuGradientPanel6);
            this.RemindersPanel.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.RemindersPanel.GradientBottomRight = System.Drawing.Color.White;
            this.RemindersPanel.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.RemindersPanel.GradientTopRight = System.Drawing.Color.White;
            this.RemindersPanel.Location = new System.Drawing.Point(0, 388);
            this.RemindersPanel.Name = "RemindersPanel";
            this.RemindersPanel.Quality = 10;
            this.RemindersPanel.Size = new System.Drawing.Size(1335, 245);
            this.RemindersPanel.TabIndex = 50;
            // 
            // AgendaContainerPanel
            // 
            this.AgendaContainerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgendaContainerPanel.BackgroundImage")));
            this.AgendaContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgendaContainerPanel.Controls.Add(this.AgendaPanel);
            this.AgendaContainerPanel.Controls.Add(this.bunifuGradientPanel7);
            this.AgendaContainerPanel.Controls.Add(this.bunifuGradientPanel8);
            this.AgendaContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgendaContainerPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.AgendaContainerPanel.GradientBottomRight = System.Drawing.Color.White;
            this.AgendaContainerPanel.GradientTopLeft = System.Drawing.Color.White;
            this.AgendaContainerPanel.GradientTopRight = System.Drawing.Color.White;
            this.AgendaContainerPanel.Location = new System.Drawing.Point(341, 0);
            this.AgendaContainerPanel.Name = "AgendaContainerPanel";
            this.AgendaContainerPanel.Quality = 10;
            this.AgendaContainerPanel.Size = new System.Drawing.Size(992, 243);
            this.AgendaContainerPanel.TabIndex = 1;
            // 
            // bunifuGradientPanel7
            // 
            this.bunifuGradientPanel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel7.BackgroundImage")));
            this.bunifuGradientPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel7.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel7.Controls.Add(this.NextDayButton);
            this.bunifuGradientPanel7.Controls.Add(this.TodayBtn);
            this.bunifuGradientPanel7.Controls.Add(this.PreviousDayButton);
            this.bunifuGradientPanel7.Controls.Add(this.AddNewReminderBtn);
            this.bunifuGradientPanel7.Controls.Add(this.DayNumberLabel);
            this.bunifuGradientPanel7.Controls.Add(this.DayLabel);
            this.bunifuGradientPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel7.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel7.Location = new System.Drawing.Point(0, 53);
            this.bunifuGradientPanel7.Name = "bunifuGradientPanel7";
            this.bunifuGradientPanel7.Quality = 10;
            this.bunifuGradientPanel7.Size = new System.Drawing.Size(992, 70);
            this.bunifuGradientPanel7.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 63);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1008, 5);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // DayNumberLabel
            // 
            this.DayNumberLabel.AutoSize = true;
            this.DayNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayNumberLabel.Location = new System.Drawing.Point(103, 36);
            this.DayNumberLabel.Name = "DayNumberLabel";
            this.DayNumberLabel.Size = new System.Drawing.Size(27, 19);
            this.DayNumberLabel.TabIndex = 6;
            this.DayNumberLabel.Text = "55";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(78, 15);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(81, 19);
            this.DayLabel.TabIndex = 5;
            this.DayLabel.Text = "Domingo";
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanel8
            // 
            this.bunifuGradientPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel8.BackgroundImage")));
            this.bunifuGradientPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel8.Controls.Add(this.YearLabel);
            this.bunifuGradientPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel8.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel8.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel8.Name = "bunifuGradientPanel8";
            this.bunifuGradientPanel8.Quality = 10;
            this.bunifuGradientPanel8.Size = new System.Drawing.Size(992, 53);
            this.bunifuGradientPanel8.TabIndex = 0;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.BackColor = System.Drawing.Color.Transparent;
            this.YearLabel.ForeColor = System.Drawing.Color.Black;
            this.YearLabel.Location = new System.Drawing.Point(5, 10);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(74, 32);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "April";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(103, 53);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(346, 230);
            this.bunifuGradientPanel2.TabIndex = 50;
            // 
            // DataGridCardControlPanel
            // 
            this.DataGridCardControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataGridCardControlPanel.BackgroundImage")));
            this.DataGridCardControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataGridCardControlPanel.Controls.Add(this.PromoBtn);
            this.DataGridCardControlPanel.Controls.Add(this.AddRowBtn);
            this.DataGridCardControlPanel.Controls.Add(this.EditRowBtn);
            this.DataGridCardControlPanel.Controls.Add(this.DeleteRowBtn);
            this.DataGridCardControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridCardControlPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.DataGridCardControlPanel.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.DataGridCardControlPanel.GradientTopLeft = System.Drawing.Color.White;
            this.DataGridCardControlPanel.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.DataGridCardControlPanel.Location = new System.Drawing.Point(0, 0);
            this.DataGridCardControlPanel.Name = "DataGridCardControlPanel";
            this.DataGridCardControlPanel.Quality = 10;
            this.DataGridCardControlPanel.Size = new System.Drawing.Size(103, 283);
            this.DataGridCardControlPanel.TabIndex = 48;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.FilteringTextbox);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(103, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(346, 53);
            this.bunifuGradientPanel1.TabIndex = 49;
            // 
            // ProductListPanel
            // 
            this.ProductListPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductListPanel.BackgroundImage")));
            this.ProductListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductListPanel.Controls.Add(this.bunifuGradientPanel2);
            this.ProductListPanel.Controls.Add(this.bunifuGradientPanel1);
            this.ProductListPanel.Controls.Add(this.DataGridCardControlPanel);
            this.ProductListPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.ProductListPanel.GradientBottomRight = System.Drawing.Color.White;
            this.ProductListPanel.GradientTopLeft = System.Drawing.Color.White;
            this.ProductListPanel.GradientTopRight = System.Drawing.Color.White;
            this.ProductListPanel.Location = new System.Drawing.Point(0, 408);
            this.ProductListPanel.Name = "ProductListPanel";
            this.ProductListPanel.Quality = 10;
            this.ProductListPanel.Size = new System.Drawing.Size(449, 283);
            this.ProductListPanel.TabIndex = 49;
            this.ProductListPanel.Visible = false;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.NextPurchaseCard);
            this.panel.Controls.Add(this.ProductListPanel);
            this.panel.Controls.Add(this.RemindersPanel);
            this.panel.GradientBottomLeft = System.Drawing.Color.White;
            this.panel.GradientBottomRight = System.Drawing.Color.White;
            this.panel.GradientTopLeft = System.Drawing.Color.White;
            this.panel.GradientTopRight = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(78, 310);
            this.panel.Name = "panel";
            this.panel.Quality = 10;
            this.panel.Size = new System.Drawing.Size(1569, 691);
            this.panel.TabIndex = 17;
            // 
            // ControlsContainerPanel
            // 
            this.ControlsContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsContainerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlsContainerPanel.BackgroundImage")));
            this.ControlsContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlsContainerPanel.Controls.Add(this.ProductTableBtn);
            this.ControlsContainerPanel.Controls.Add(this.NextPurchaseTableBtn);
            this.ControlsContainerPanel.Controls.Add(this.AlarmsBtn);
            this.ControlsContainerPanel.Controls.Add(this.ProggressActiveSeparator);
            this.ControlsContainerPanel.Controls.Add(this.ProgressUnactiveSeparator);
            this.ControlsContainerPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.ControlsContainerPanel.GradientBottomRight = System.Drawing.Color.White;
            this.ControlsContainerPanel.GradientTopLeft = System.Drawing.Color.White;
            this.ControlsContainerPanel.GradientTopRight = System.Drawing.Color.White;
            this.ControlsContainerPanel.Location = new System.Drawing.Point(579, 199);
            this.ControlsContainerPanel.Name = "ControlsContainerPanel";
            this.ControlsContainerPanel.Quality = 10;
            this.ControlsContainerPanel.Size = new System.Drawing.Size(567, 67);
            this.ControlsContainerPanel.TabIndex = 16;
            // 
            // SupplierInfromationPanel
            // 
            this.SupplierInfromationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SupplierInfromationPanel.BackgroundImage")));
            this.SupplierInfromationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupplierInfromationPanel.Controls.Add(this.bunifuImageButton3);
            this.SupplierInfromationPanel.Controls.Add(this.BasicInformationCard);
            this.SupplierInfromationPanel.Controls.Add(this.POBtn);
            this.SupplierInfromationPanel.Controls.Add(this.bunifuImageButton1);
            this.SupplierInfromationPanel.Controls.Add(this.panel);
            this.SupplierInfromationPanel.Controls.Add(this.ControlsContainerPanel);
            this.SupplierInfromationPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SupplierInfromationPanel.GradientBottomRight = System.Drawing.Color.White;
            this.SupplierInfromationPanel.GradientTopLeft = System.Drawing.Color.White;
            this.SupplierInfromationPanel.GradientTopRight = System.Drawing.Color.White;
            this.SupplierInfromationPanel.Location = new System.Drawing.Point(0, 25);
            this.SupplierInfromationPanel.Name = "SupplierInfromationPanel";
            this.SupplierInfromationPanel.Quality = 10;
            this.SupplierInfromationPanel.Size = new System.Drawing.Size(1724, 1036);
            this.SupplierInfromationPanel.TabIndex = 2;
            this.SupplierInfromationPanel.Visible = false;
            // 
            // FlowContainerPanel
            // 
            this.FlowContainerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlowContainerPanel.BackgroundImage")));
            this.FlowContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlowContainerPanel.Controls.Add(this.flow1);
            this.FlowContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowContainerPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.FlowContainerPanel.GradientBottomRight = System.Drawing.Color.White;
            this.FlowContainerPanel.GradientTopLeft = System.Drawing.Color.White;
            this.FlowContainerPanel.GradientTopRight = System.Drawing.Color.White;
            this.FlowContainerPanel.Location = new System.Drawing.Point(0, 100);
            this.FlowContainerPanel.Name = "FlowContainerPanel";
            this.FlowContainerPanel.Quality = 10;
            this.FlowContainerPanel.Size = new System.Drawing.Size(184, 71);
            this.FlowContainerPanel.TabIndex = 2;
            this.FlowContainerPanel.Visible = false;
            // 
            // SearchingPanel
            // 
            this.SearchingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchingPanel.BackgroundImage")));
            this.SearchingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchingPanel.Controls.Add(this.label1);
            this.SearchingPanel.Controls.Add(this.SearchSupplierTxt);
            this.SearchingPanel.Controls.Add(this.AddNewCustomerBtn);
            this.SearchingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchingPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SearchingPanel.GradientBottomRight = System.Drawing.Color.White;
            this.SearchingPanel.GradientTopLeft = System.Drawing.Color.White;
            this.SearchingPanel.GradientTopRight = System.Drawing.Color.White;
            this.SearchingPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchingPanel.Name = "SearchingPanel";
            this.SearchingPanel.Quality = 10;
            this.SearchingPanel.Size = new System.Drawing.Size(184, 100);
            this.SearchingPanel.TabIndex = 1;
            // 
            // SuppliersPanel
            // 
            this.SuppliersPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SuppliersPanel.BackgroundImage")));
            this.SuppliersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SuppliersPanel.Controls.Add(this.FlowContainerPanel);
            this.SuppliersPanel.Controls.Add(this.SearchingPanel);
            this.SuppliersPanel.Controls.Add(this.LoadingSupplierListBar);
            this.SuppliersPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SuppliersPanel.GradientBottomRight = System.Drawing.Color.White;
            this.SuppliersPanel.GradientTopLeft = System.Drawing.Color.White;
            this.SuppliersPanel.GradientTopRight = System.Drawing.Color.White;
            this.SuppliersPanel.Location = new System.Drawing.Point(882, 438);
            this.SuppliersPanel.Name = "SuppliersPanel";
            this.SuppliersPanel.Quality = 10;
            this.SuppliersPanel.Size = new System.Drawing.Size(184, 171);
            this.SuppliersPanel.TabIndex = 1;
            // 
            // ProgressAtiveBarElipse
            // 
            this.ProgressAtiveBarElipse.ElipseRadius = 20;
            this.ProgressAtiveBarElipse.TargetControl = this.ProggressActiveSeparator;
            // 
            // ProgressUnactiveBarElipse
            // 
            this.ProgressUnactiveBarElipse.ElipseRadius = 20;
            this.ProgressUnactiveBarElipse.TargetControl = this.ProgressUnactiveSeparator;
            // 
            // ProductTableButtonElipse
            // 
            this.ProductTableButtonElipse.ElipseRadius = 15;
            this.ProductTableButtonElipse.TargetControl = this.ProductTableBtn;
            // 
            // NextPurchaseButtonElipse
            // 
            this.NextPurchaseButtonElipse.ElipseRadius = 15;
            this.NextPurchaseButtonElipse.TargetControl = this.NextPurchaseTableBtn;
            // 
            // AlarmsButtonElipse
            // 
            this.AlarmsButtonElipse.ElipseRadius = 15;
            this.AlarmsButtonElipse.TargetControl = this.AlarmsBtn;
            // 
            // SelectAllBtnElipse
            // 
            this.SelectAllBtnElipse.ElipseRadius = 35;
            this.SelectAllBtnElipse.TargetControl = this;
            // 
            // WindowSizeControlPanel
            // 
            this.WindowSizeControlPanel.BackColor = System.Drawing.Color.White;
            this.WindowSizeControlPanel.Controls.Add(this.minimizeBtn);
            this.WindowSizeControlPanel.Controls.Add(this.bunifuImageButton2);
            this.WindowSizeControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowSizeControlPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowSizeControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WindowSizeControlPanel.Name = "WindowSizeControlPanel";
            this.WindowSizeControlPanel.Size = new System.Drawing.Size(1724, 25);
            this.WindowSizeControlPanel.TabIndex = 21;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(1668, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(19, 20);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBtn.TabIndex = 14;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1693, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 13;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // Panel_proveedores_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1724, 1061);
            this.Controls.Add(this.SupplierInfromationPanel);
            this.Controls.Add(this.SuppliersPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WindowSizeControlPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Panel_proveedores_Form";
            this.ShowInTaskbar = false;
            this.Text = "Proveedores | Point of Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_proveedores_Form_FormClosing);
            this.Load += new System.EventHandler(this.Panel_proveedores_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddNewCustomerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextMonthButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousMonthButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextDayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousDayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CalendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.NextPurchaseCard.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.BasicInformationCard.ResumeLayout(false);
            this.VisitingDaysPanel.ResumeLayout(false);
            this.VisitingDaysPanel.PerformLayout();
            this.DebtPannel.ResumeLayout(false);
            this.DebtPannel.PerformLayout();
            this.SupplierImagePanel.ResumeLayout(false);
            this.CompanyNameCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierImagePicBox)).EndInit();
            this.BasicSupplierInformationPanel.ResumeLayout(false);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.RemindersPanel.ResumeLayout(false);
            this.AgendaContainerPanel.ResumeLayout(false);
            this.bunifuGradientPanel7.ResumeLayout(false);
            this.bunifuGradientPanel7.PerformLayout();
            this.bunifuGradientPanel8.ResumeLayout(false);
            this.bunifuGradientPanel8.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.DataGridCardControlPanel.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ProductListPanel.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ControlsContainerPanel.ResumeLayout(false);
            this.SupplierInfromationPanel.ResumeLayout(false);
            this.FlowContainerPanel.ResumeLayout(false);
            this.SearchingPanel.ResumeLayout(false);
            this.SearchingPanel.PerformLayout();
            this.SuppliersPanel.ResumeLayout(false);
            this.WindowSizeControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flow1;
        private Bunifu.Framework.UI.BunifuGradientPanel SuppliersPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel SearchingPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel FlowContainerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel SupplierInfromationPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel ControlsContainerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel panel;
        private Bunifu.Framework.UI.BunifuGradientPanel ProductListPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel DataGridCardControlPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel RemindersPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private System.Windows.Forms.ProgressBar LoadingSupplierListBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label grandTotalLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label AdeudoLbl;
        private System.Windows.Forms.Label LunesLbl;
        private System.Windows.Forms.Label viernesLbl;
        private System.Windows.Forms.Label sabadoLbl;
        private System.Windows.Forms.Label juevesLbl;
        private System.Windows.Forms.Label miercolesLbl;
        private System.Windows.Forms.Label martesLbl;
        private System.Windows.Forms.Label domingoLbl;
        private System.Windows.Forms.TextBox SearchSupplierTxt;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator ProggressActiveSeparator;
        private Bunifu.Framework.UI.BunifuSeparator ProgressUnactiveSeparator;
        private System.Windows.Forms.Button ProductTableBtn;
        private System.Windows.Forms.Button NextPurchaseTableBtn;
        private System.Windows.Forms.Button AlarmsBtn;
        private System.Windows.Forms.Button RecomendValueBtn;
        private System.Windows.Forms.Button POBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCards NextPurchaseCard;
        private Bunifu.Framework.UI.BunifuCards BasicInformationCard;
        private Bunifu.Framework.UI.BunifuImageButton PreviousMonthButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton AddNewCustomerBtn;
        private Bunifu.Framework.UI.BunifuImageButton NextMonthButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel9;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private System.Windows.Forms.TableLayoutPanel CalendarPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuGradientPanel AgendaContainerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton NextDayButton;
        private System.Windows.Forms.Button TodayBtn;
        private Bunifu.Framework.UI.BunifuImageButton PreviousDayButton;
        private System.Windows.Forms.Button AddNewReminderBtn;
        private System.Windows.Forms.Label DayNumberLabel;
        private System.Windows.Forms.Label DayLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel8;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TableLayoutPanel AgendaPanel;
        private Bunifu.Framework.UI.BunifuImageButton PromoBtn;
        private Bunifu.Framework.UI.BunifuImageButton AddRowBtn;
        private Bunifu.Framework.UI.BunifuImageButton EditRowBtn;
        private Bunifu.Framework.UI.BunifuImageButton DeleteRowBtn;
        private System.Windows.Forms.TextBox FilteringTextbox;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel VisitingDaysPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel DebtPannel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuGradientPanel SupplierImagePanel;
        private Bunifu.Framework.UI.BunifuCards CompanyNameCard;
        private System.Windows.Forms.PictureBox SupplierImagePicBox;
        private Bunifu.Framework.UI.BunifuGradientPanel BasicSupplierInformationPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyAddressTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyNameTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumberTxt;
        private System.Windows.Forms.ToolTip AddSupplierToolTip;
        private Label Lbl0;
        private Label Lbl1;
        private Button Btn35;
        private Button Btn34;
        private Button Btn33;
        private Button Btn32;
        private Button Btn30;
        private Button Btn26;
        private Button Btn25;
        private Button Btn24;
        private Button Btn23;
        private Button Btn22;
        private Button Btn21;
        private Button Btn20;
        private Button Btn16;
        private Button Btn15;
        private Button Btn14;
        private Button Btn13;
        private Button Btn12;
        private Button Btn11;
        private Button Btn10;
        private Button Btn06;
        private Button Btn05;
        private Button Btn00;
        private Button Btn04;
        private Button Btn01;
        private Button Btn03;
        private Button Btn02;
        private Button Btn36;
        private Label Lbl4;
        private Label Lbl3;
        private Label Lbl2;
        private Label Lbl6;
        private Button Btn56;
        private Button Btn55;
        private Button Btn54;
        private Button Btn44;
        private Button Btn53;
        private Button Btn52;
        private Button Btn43;
        private Button Btn51;
        private Button Btn50;
        private Button Btn42;
        private Button Btn46;
        private Button Btn45;
        private Button Btn41;
        private Button Btn40;
        private Button Btn31;
        private Bunifu.Framework.UI.BunifuElipse ProgressAtiveBarElipse;
        private Bunifu.Framework.UI.BunifuElipse ProgressUnactiveBarElipse;
        private Bunifu.Framework.UI.BunifuElipse ProductTableButtonElipse;
        private Bunifu.Framework.UI.BunifuElipse NextPurchaseButtonElipse;
        private Bunifu.Framework.UI.BunifuElipse AlarmsButtonElipse;
        private Bunifu.Framework.UI.BunifuElipse SelectAllBtnElipse;
        private Timer timer;
        private Panel WindowSizeControlPanel;
        private Bunifu.Framework.UI.BunifuImageButton minimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private DataGridView dataGridView2;
        private RichTextBox ProductTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 proccedPurchaseBtn;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn piecesPerCase;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewComboBoxColumn depot;
        private DataGridViewTextBoxColumn Total;
        private Label casescountLbl;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}