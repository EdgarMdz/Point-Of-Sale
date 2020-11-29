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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AddSupplierToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grandTotalLbl = new System.Windows.Forms.Label();
            this.ProductTableBtn = new System.Windows.Forms.Button();
            this.AlarmsBtn = new System.Windows.Forms.Button();
            this.RecomendValueBtn = new System.Windows.Forms.Button();
            this.AddNewCustomerBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.FilteringTextbox = new System.Windows.Forms.TextBox();
            this.PromoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.companyAddressTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.companyNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneNumberTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.flow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadingSupplierListBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdeudoLbl = new System.Windows.Forms.Label();
            this.LunesLbl = new System.Windows.Forms.Label();
            this.viernesLbl = new System.Windows.Forms.Label();
            this.sabadoLbl = new System.Windows.Forms.Label();
            this.juevesLbl = new System.Windows.Forms.Label();
            this.miercolesLbl = new System.Windows.Forms.Label();
            this.martesLbl = new System.Windows.Forms.Label();
            this.domingoLbl = new System.Windows.Forms.Label();
            this.SearchSupplierTxt = new System.Windows.Forms.TextBox();
            this.ProggressActiveSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.ProgressUnactiveSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.NextPurchaseTableBtn = new System.Windows.Forms.Button();
            this.POBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NextPurchaseCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piecesPerCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depot = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casescountLbl = new System.Windows.Forms.Label();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ProductTxt = new System.Windows.Forms.RichTextBox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.saveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.proceedPurchaseBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SupplierImagePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SupplierImagePicBox = new System.Windows.Forms.PictureBox();
            this.RemindersPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DataGridCardControlPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ProductListPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ControlsContainerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SupplierInfromationPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BasicInformationCard = new System.Windows.Forms.Panel();
            this.DebtPannel = new System.Windows.Forms.Panel();
            this.VisitingDaysPanel = new System.Windows.Forms.Panel();
            this.BasicSupplierInformationPanel = new System.Windows.Forms.Panel();
            this.deleteSupplierBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.NextPurchaseCard.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.bunifuGradientPanel5.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SupplierImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierImagePicBox)).BeginInit();
            this.RemindersPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.DataGridCardControlPanel.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.ProductListPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.ControlsContainerPanel.SuspendLayout();
            this.SupplierInfromationPanel.SuspendLayout();
            this.BasicInformationCard.SuspendLayout();
            this.DebtPannel.SuspendLayout();
            this.VisitingDaysPanel.SuspendLayout();
            this.BasicSupplierInformationPanel.SuspendLayout();
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
            this.grandTotalLbl.Location = new System.Drawing.Point(308, 3);
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
            this.ProductTableBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.ProductTableBtn.FlatAppearance.BorderSize = 0;
            this.ProductTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductTableBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTableBtn.ForeColor = System.Drawing.Color.White;
            this.ProductTableBtn.Location = new System.Drawing.Point(88, 3);
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
            this.AlarmsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlarmsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.AlarmsBtn.FlatAppearance.BorderSize = 0;
            this.AlarmsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlarmsBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmsBtn.ForeColor = System.Drawing.Color.White;
            this.AlarmsBtn.Location = new System.Drawing.Point(464, 3);
            this.AlarmsBtn.Name = "AlarmsBtn";
            this.AlarmsBtn.Size = new System.Drawing.Size(130, 61);
            this.AlarmsBtn.TabIndex = 17;
            this.AlarmsBtn.Text = "Estadísticas";
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
            this.AddNewCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewCustomerBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddNewCustomerBtn.Image = global::POS.Properties.Resources.plus;
            this.AddNewCustomerBtn.ImageActive = null;
            this.AddNewCustomerBtn.Location = new System.Drawing.Point(480, 16);
            this.AddNewCustomerBtn.Name = "AddNewCustomerBtn";
            this.AddNewCustomerBtn.Size = new System.Drawing.Size(71, 69);
            this.AddNewCustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddNewCustomerBtn.TabIndex = 2;
            this.AddNewCustomerBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.AddNewCustomerBtn, "Agregar Proveedor\r\n");
            this.AddNewCustomerBtn.Zoom = 10;
            this.AddNewCustomerBtn.Click += new System.EventHandler(this.AddNewCustomerBtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.Back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(35, 199);
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
            this.FilteringTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilteringTextbox.Location = new System.Drawing.Point(51, 6);
            this.FilteringTextbox.Name = "FilteringTextbox";
            this.FilteringTextbox.Size = new System.Drawing.Size(407, 41);
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
            this.AddRowBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddRowBtn.Image = global::POS.Properties.Resources.plus;
            this.AddRowBtn.ImageActive = null;
            this.AddRowBtn.Location = new System.Drawing.Point(15, 29);
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
            this.EditRowBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditRowBtn.Image = global::POS.Properties.Resources.edit;
            this.EditRowBtn.ImageActive = null;
            this.EditRowBtn.Location = new System.Drawing.Point(15, 46);
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
            this.DeleteRowBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRowBtn.Image = global::POS.Properties.Resources.delete;
            this.DeleteRowBtn.ImageActive = null;
            this.DeleteRowBtn.Location = new System.Drawing.Point(15, 63);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(50, 50);
            this.DeleteRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteRowBtn.TabIndex = 3;
            this.DeleteRowBtn.TabStop = false;
            this.AddSupplierToolTip.SetToolTip(this.DeleteRowBtn, "Eliminar el producto seleccionado");
            this.DeleteRowBtn.Zoom = 10;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // companyAddressTxt
            // 
            this.companyAddressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.companyAddressTxt.Location = new System.Drawing.Point(19, 64);
            this.companyAddressTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.companyAddressTxt.Name = "companyAddressTxt";
            this.companyAddressTxt.Size = new System.Drawing.Size(248, 47);
            this.companyAddressTxt.TabIndex = 32;
            this.companyAddressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSupplierToolTip.SetToolTip(this.companyAddressTxt, "Dirección");
            this.companyAddressTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.companyAddressTxt_KeyDown);
            // 
            // companyNameTxt
            // 
            this.companyNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.companyNameTxt.Location = new System.Drawing.Point(19, 13);
            this.companyNameTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.companyNameTxt.Name = "companyNameTxt";
            this.companyNameTxt.Size = new System.Drawing.Size(248, 47);
            this.companyNameTxt.TabIndex = 31;
            this.companyNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSupplierToolTip.SetToolTip(this.companyNameTxt, "Nombre de la Empresa");
            this.companyNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.companyNameTxt_KeyDown);
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.phoneNumberTxt.Location = new System.Drawing.Point(19, 114);
            this.phoneNumberTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(248, 47);
            this.phoneNumberTxt.TabIndex = 33;
            this.phoneNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSupplierToolTip.SetToolTip(this.phoneNumberTxt, "Número de Teléfono");
            this.phoneNumberTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneNumberTxt_KeyDown);
            this.phoneNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTxt_KeyPress);
            // 
            // flow1
            // 
            this.flow1.BackColor = System.Drawing.Color.White;
            this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow1.Location = new System.Drawing.Point(0, 0);
            this.flow1.Name = "flow1";
            this.flow1.Size = new System.Drawing.Size(628, 300);
            this.flow1.TabIndex = 1;
            // 
            // LoadingSupplierListBar
            // 
            this.LoadingSupplierListBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingSupplierListBar.Location = new System.Drawing.Point(175, 143);
            this.LoadingSupplierListBar.Name = "LoadingSupplierListBar";
            this.LoadingSupplierListBar.Size = new System.Drawing.Size(279, 32);
            this.LoadingSupplierListBar.TabIndex = 0;
            this.LoadingSupplierListBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(82, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Días de Visita";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar: ";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "Adeudo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdeudoLbl
            // 
            this.AdeudoLbl.BackColor = System.Drawing.Color.White;
            this.AdeudoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdeudoLbl.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdeudoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.AdeudoLbl.Location = new System.Drawing.Point(10, 48);
            this.AdeudoLbl.Name = "AdeudoLbl";
            this.AdeudoLbl.Size = new System.Drawing.Size(317, 116);
            this.AdeudoLbl.TabIndex = 30;
            this.AdeudoLbl.Text = "$0.00";
            this.AdeudoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LunesLbl
            // 
            this.LunesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LunesLbl.AutoSize = true;
            this.LunesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.LunesLbl.Location = new System.Drawing.Point(54, 92);
            this.LunesLbl.Name = "LunesLbl";
            this.LunesLbl.Size = new System.Drawing.Size(32, 39);
            this.LunesLbl.TabIndex = 22;
            this.LunesLbl.Text = "L";
            this.LunesLbl.Click += new System.EventHandler(this.LunesLbl_Click);
            // 
            // viernesLbl
            // 
            this.viernesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viernesLbl.AutoSize = true;
            this.viernesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viernesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.viernesLbl.Location = new System.Drawing.Point(239, 92);
            this.viernesLbl.Name = "viernesLbl";
            this.viernesLbl.Size = new System.Drawing.Size(40, 39);
            this.viernesLbl.TabIndex = 23;
            this.viernesLbl.Text = "V";
            this.viernesLbl.Click += new System.EventHandler(this.viernesLbl_Click);
            // 
            // sabadoLbl
            // 
            this.sabadoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sabadoLbl.AutoSize = true;
            this.sabadoLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabadoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.sabadoLbl.Location = new System.Drawing.Point(279, 92);
            this.sabadoLbl.Name = "sabadoLbl";
            this.sabadoLbl.Size = new System.Drawing.Size(33, 39);
            this.sabadoLbl.TabIndex = 24;
            this.sabadoLbl.Text = "S";
            this.sabadoLbl.Click += new System.EventHandler(this.sabadoLbl_Click);
            // 
            // juevesLbl
            // 
            this.juevesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.juevesLbl.AutoSize = true;
            this.juevesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juevesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.juevesLbl.Location = new System.Drawing.Point(207, 92);
            this.juevesLbl.Name = "juevesLbl";
            this.juevesLbl.Size = new System.Drawing.Size(32, 39);
            this.juevesLbl.TabIndex = 25;
            this.juevesLbl.Text = "J";
            this.juevesLbl.Click += new System.EventHandler(this.juevesLbl_Click);
            // 
            // miercolesLbl
            // 
            this.miercolesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.miercolesLbl.AutoSize = true;
            this.miercolesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miercolesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.miercolesLbl.Location = new System.Drawing.Point(154, 92);
            this.miercolesLbl.Name = "miercolesLbl";
            this.miercolesLbl.Size = new System.Drawing.Size(53, 39);
            this.miercolesLbl.TabIndex = 26;
            this.miercolesLbl.Text = "Mi";
            this.miercolesLbl.Click += new System.EventHandler(this.miercolesLbl_Click);
            // 
            // martesLbl
            // 
            this.martesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.martesLbl.AutoSize = true;
            this.martesLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.martesLbl.ForeColor = System.Drawing.Color.DimGray;
            this.martesLbl.Location = new System.Drawing.Point(86, 92);
            this.martesLbl.Name = "martesLbl";
            this.martesLbl.Size = new System.Drawing.Size(68, 39);
            this.martesLbl.TabIndex = 27;
            this.martesLbl.Text = "Ma";
            this.martesLbl.Click += new System.EventHandler(this.martesLbl_Click);
            // 
            // domingoLbl
            // 
            this.domingoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.domingoLbl.AutoSize = true;
            this.domingoLbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domingoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.domingoLbl.Location = new System.Drawing.Point(13, 92);
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
            // ProggressActiveSeparator
            // 
            this.ProggressActiveSeparator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProggressActiveSeparator.BackColor = System.Drawing.Color.Transparent;
            this.ProggressActiveSeparator.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProggressActiveSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.ProggressActiveSeparator.LineThickness = 51199;
            this.ProggressActiveSeparator.Location = new System.Drawing.Point(60, 26);
            this.ProggressActiveSeparator.Margin = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.ProggressActiveSeparator.Name = "ProggressActiveSeparator";
            this.ProggressActiveSeparator.Size = new System.Drawing.Size(189, 16);
            this.ProggressActiveSeparator.TabIndex = 11;
            this.ProggressActiveSeparator.Transparency = 255;
            this.ProggressActiveSeparator.Vertical = false;
            // 
            // ProgressUnactiveSeparator
            // 
            this.ProgressUnactiveSeparator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgressUnactiveSeparator.BackColor = System.Drawing.Color.Transparent;
            this.ProgressUnactiveSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProgressUnactiveSeparator.LineThickness = 65535;
            this.ProgressUnactiveSeparator.Location = new System.Drawing.Point(63, 27);
            this.ProgressUnactiveSeparator.Margin = new System.Windows.Forms.Padding(64, 52, 64, 52);
            this.ProgressUnactiveSeparator.Name = "ProgressUnactiveSeparator";
            this.ProgressUnactiveSeparator.Size = new System.Drawing.Size(568, 15);
            this.ProgressUnactiveSeparator.TabIndex = 14;
            this.ProgressUnactiveSeparator.Transparency = 255;
            this.ProgressUnactiveSeparator.Vertical = false;
            // 
            // NextPurchaseTableBtn
            // 
            this.NextPurchaseTableBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextPurchaseTableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.NextPurchaseTableBtn.FlatAppearance.BorderSize = 0;
            this.NextPurchaseTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPurchaseTableBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPurchaseTableBtn.ForeColor = System.Drawing.Color.White;
            this.NextPurchaseTableBtn.Location = new System.Drawing.Point(276, 3);
            this.NextPurchaseTableBtn.Name = "NextPurchaseTableBtn";
            this.NextPurchaseTableBtn.Size = new System.Drawing.Size(130, 61);
            this.NextPurchaseTableBtn.TabIndex = 16;
            this.NextPurchaseTableBtn.Text = "Siguiente Compra";
            this.NextPurchaseTableBtn.UseVisualStyleBackColor = false;
            this.NextPurchaseTableBtn.Click += new System.EventHandler(this.NextPurchaseTableBtn_Click);
            // 
            // POBtn
            // 
            this.POBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.POBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.POBtn.FlatAppearance.BorderSize = 0;
            this.POBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POBtn.ForeColor = System.Drawing.Color.White;
            this.POBtn.Location = new System.Drawing.Point(925, 190);
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
            this.dataGridView1.Size = new System.Drawing.Size(380, 110);
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
            this.NextPurchaseCard.Size = new System.Drawing.Size(1095, 379);
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
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(1095, 282);
            this.bunifuGradientPanel4.TabIndex = 3;
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
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
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
            this.dataGridView2.Size = new System.Drawing.Size(1095, 245);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView2_CurrentCellDirtyStateChanged);
            this.dataGridView2.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_RowHeightChanged);
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
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
            // casescountLbl
            // 
            this.casescountLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.casescountLbl.Location = new System.Drawing.Point(0, 245);
            this.casescountLbl.Name = "casescountLbl";
            this.casescountLbl.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.casescountLbl.Size = new System.Drawing.Size(1095, 37);
            this.casescountLbl.TabIndex = 4;
            this.casescountLbl.Text = "Total de productos: 0.00";
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
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(1095, 53);
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
            this.ProductTxt.Size = new System.Drawing.Size(1087, 37);
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
            this.bunifuGradientPanel3.Controls.Add(this.saveBtn);
            this.bunifuGradientPanel3.Controls.Add(this.proceedPurchaseBtn);
            this.bunifuGradientPanel3.Controls.Add(this.grandTotalLbl);
            this.bunifuGradientPanel3.Controls.Add(this.RecomendValueBtn);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 335);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1095, 44);
            this.bunifuGradientPanel3.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.ActiveBorderThickness = 1;
            this.saveBtn.ActiveCornerRadius = 20;
            this.saveBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.saveBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.ButtonText = "Guardar Compra";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveBtn.IdleBorderThickness = 1;
            this.saveBtn.IdleCornerRadius = 20;
            this.saveBtn.IdleFillColor = System.Drawing.Color.White;
            this.saveBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.saveBtn.Location = new System.Drawing.Point(268, 2);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(181, 41);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // proceedPurchaseBtn
            // 
            this.proceedPurchaseBtn.ActiveBorderThickness = 1;
            this.proceedPurchaseBtn.ActiveCornerRadius = 20;
            this.proceedPurchaseBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proceedPurchaseBtn.ActiveForecolor = System.Drawing.Color.White;
            this.proceedPurchaseBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proceedPurchaseBtn.BackColor = System.Drawing.Color.White;
            this.proceedPurchaseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proceedPurchaseBtn.BackgroundImage")));
            this.proceedPurchaseBtn.ButtonText = "Realizar Compra";
            this.proceedPurchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedPurchaseBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedPurchaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proceedPurchaseBtn.IdleBorderThickness = 1;
            this.proceedPurchaseBtn.IdleCornerRadius = 20;
            this.proceedPurchaseBtn.IdleFillColor = System.Drawing.Color.White;
            this.proceedPurchaseBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proceedPurchaseBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.proceedPurchaseBtn.Location = new System.Drawing.Point(27, 2);
            this.proceedPurchaseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.proceedPurchaseBtn.Name = "proceedPurchaseBtn";
            this.proceedPurchaseBtn.Size = new System.Drawing.Size(181, 41);
            this.proceedPurchaseBtn.TabIndex = 9;
            this.proceedPurchaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.proceedPurchaseBtn.Click += new System.EventHandler(this.proccedPurchaseBtn_Click);
            // 
            // SupplierImagePanel
            // 
            this.SupplierImagePanel.BackColor = System.Drawing.Color.White;
            this.SupplierImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SupplierImagePanel.BackgroundImage")));
            this.SupplierImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupplierImagePanel.Controls.Add(this.SupplierImagePicBox);
            this.SupplierImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierImagePanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SupplierImagePanel.GradientBottomRight = System.Drawing.Color.White;
            this.SupplierImagePanel.GradientTopLeft = System.Drawing.Color.White;
            this.SupplierImagePanel.GradientTopRight = System.Drawing.Color.White;
            this.SupplierImagePanel.Location = new System.Drawing.Point(948, 0);
            this.SupplierImagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SupplierImagePanel.MinimumSize = new System.Drawing.Size(100, 174);
            this.SupplierImagePanel.Name = "SupplierImagePanel";
            this.SupplierImagePanel.Quality = 10;
            this.SupplierImagePanel.Size = new System.Drawing.Size(216, 174);
            this.SupplierImagePanel.TabIndex = 38;
            this.SupplierImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DebtPannel_Paint);
            // 
            // SupplierImagePicBox
            // 
            this.SupplierImagePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierImagePicBox.Location = new System.Drawing.Point(21, 35);
            this.SupplierImagePicBox.MaximumSize = new System.Drawing.Size(250, 150);
            this.SupplierImagePicBox.MinimumSize = new System.Drawing.Size(10, 30);
            this.SupplierImagePicBox.Name = "SupplierImagePicBox";
            this.SupplierImagePicBox.Size = new System.Drawing.Size(174, 104);
            this.SupplierImagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SupplierImagePicBox.TabIndex = 0;
            this.SupplierImagePicBox.TabStop = false;
            this.SupplierImagePicBox.Resize += new System.EventHandler(this.SupplierImagePicBox_Resize);
            // 
            // RemindersPanel
            // 
            this.RemindersPanel.AutoScroll = true;
            this.RemindersPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemindersPanel.BackgroundImage")));
            this.RemindersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemindersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemindersPanel.Controls.Add(this.panel3);
            this.RemindersPanel.Controls.Add(this.panel4);
            this.RemindersPanel.Controls.Add(this.panel1);
            this.RemindersPanel.Controls.Add(this.panel2);
            this.RemindersPanel.Controls.Add(this.label7);
            this.RemindersPanel.Controls.Add(this.dateTimePicker1);
            this.RemindersPanel.Controls.Add(this.comboBox1);
            this.RemindersPanel.Controls.Add(this.label5);
            this.RemindersPanel.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.RemindersPanel.GradientBottomRight = System.Drawing.Color.White;
            this.RemindersPanel.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.RemindersPanel.GradientTopRight = System.Drawing.Color.White;
            this.RemindersPanel.Location = new System.Drawing.Point(0, 174);
            this.RemindersPanel.Name = "RemindersPanel";
            this.RemindersPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.RemindersPanel.Quality = 10;
            this.RemindersPanel.Size = new System.Drawing.Size(842, 205);
            this.RemindersPanel.TabIndex = 50;
            this.RemindersPanel.SizeChanged += new System.EventHandler(this.RemindersPanel_SizeChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.dataGridView4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(583, 403);
            this.panel3.MinimumSize = new System.Drawing.Size(486, 288);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(486, 288);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(486, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.EnableHeadersVisualStyles = false;
            this.dataGridView4.GridColor = System.Drawing.Color.White;
            this.dataGridView4.Location = new System.Drawing.Point(0, 42);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(486, 246);
            this.dataGridView4.TabIndex = 5;
            this.dataGridView4.DataSourceChanged += new System.EventHandler(this.dataGridView3_DataSourceChanged);
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Menos Vendidos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(7, 729);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel4.Size = new System.Drawing.Size(809, 282);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(362, 112);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(338, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // chart2
            // 
            chartArea1.AxisX.Title = "Fecha";
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(0, 83);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(809, 199);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(0, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(809, 32);
            this.label11.TabIndex = 17;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(809, 41);
            this.panel5.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(209, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(132, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Buscar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(7, 403);
            this.panel1.MinimumSize = new System.Drawing.Size(486, 288);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(486, 288);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.GridColor = System.Drawing.Color.White;
            this.dataGridView3.Location = new System.Drawing.Point(0, 42);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(486, 246);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.DataSourceChanged += new System.EventHandler(this.dataGridView3_DataSourceChanged);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(486, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mejores Vendidos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 102);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(809, 275);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(362, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "Fecha";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 37);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(809, 238);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(809, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Compras";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mostrar por";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 10);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(419, 33);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Día",
            "Mes",
            "Año"});
            this.comboBox1.Location = new System.Drawing.Point(292, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(419, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de Compra";
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(78, 53);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(380, 110);
            this.bunifuGradientPanel2.TabIndex = 50;
            // 
            // DataGridCardControlPanel
            // 
            this.DataGridCardControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataGridCardControlPanel.BackgroundImage")));
            this.DataGridCardControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataGridCardControlPanel.Controls.Add(this.AddRowBtn);
            this.DataGridCardControlPanel.Controls.Add(this.EditRowBtn);
            this.DataGridCardControlPanel.Controls.Add(this.DeleteRowBtn);
            this.DataGridCardControlPanel.Controls.Add(this.PromoBtn);
            this.DataGridCardControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridCardControlPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.DataGridCardControlPanel.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.DataGridCardControlPanel.GradientTopLeft = System.Drawing.Color.White;
            this.DataGridCardControlPanel.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.DataGridCardControlPanel.Location = new System.Drawing.Point(0, 0);
            this.DataGridCardControlPanel.Name = "DataGridCardControlPanel";
            this.DataGridCardControlPanel.Quality = 10;
            this.DataGridCardControlPanel.Size = new System.Drawing.Size(78, 163);
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(78, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(380, 53);
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
            this.ProductListPanel.Location = new System.Drawing.Point(0, 216);
            this.ProductListPanel.Name = "ProductListPanel";
            this.ProductListPanel.Quality = 10;
            this.ProductListPanel.Size = new System.Drawing.Size(458, 163);
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
            this.panel.Location = new System.Drawing.Point(35, 310);
            this.panel.Name = "panel";
            this.panel.Quality = 10;
            this.panel.Size = new System.Drawing.Size(1095, 379);
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
            this.ControlsContainerPanel.Location = new System.Drawing.Point(285, 199);
            this.ControlsContainerPanel.Name = "ControlsContainerPanel";
            this.ControlsContainerPanel.Quality = 10;
            this.ControlsContainerPanel.Size = new System.Drawing.Size(690, 67);
            this.ControlsContainerPanel.TabIndex = 16;
            // 
            // SupplierInfromationPanel
            // 
            this.SupplierInfromationPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SupplierInfromationPanel.BackgroundImage")));
            this.SupplierInfromationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupplierInfromationPanel.Controls.Add(this.BasicInformationCard);
            this.SupplierInfromationPanel.Controls.Add(this.deleteSupplierBtn);
            this.SupplierInfromationPanel.Controls.Add(this.POBtn);
            this.SupplierInfromationPanel.Controls.Add(this.bunifuImageButton1);
            this.SupplierInfromationPanel.Controls.Add(this.panel);
            this.SupplierInfromationPanel.Controls.Add(this.ControlsContainerPanel);
            this.SupplierInfromationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierInfromationPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SupplierInfromationPanel.GradientBottomRight = System.Drawing.Color.White;
            this.SupplierInfromationPanel.GradientTopLeft = System.Drawing.Color.White;
            this.SupplierInfromationPanel.GradientTopRight = System.Drawing.Color.White;
            this.SupplierInfromationPanel.Location = new System.Drawing.Point(0, 25);
            this.SupplierInfromationPanel.Name = "SupplierInfromationPanel";
            this.SupplierInfromationPanel.Quality = 10;
            this.SupplierInfromationPanel.Size = new System.Drawing.Size(1164, 724);
            this.SupplierInfromationPanel.TabIndex = 2;
            this.SupplierInfromationPanel.Visible = false;
            this.SupplierInfromationPanel.Resize += new System.EventHandler(this.SupplierInfromationPanel_Resize);
            // 
            // BasicInformationCard
            // 
            this.BasicInformationCard.AutoScroll = true;
            this.BasicInformationCard.Controls.Add(this.SupplierImagePanel);
            this.BasicInformationCard.Controls.Add(this.DebtPannel);
            this.BasicInformationCard.Controls.Add(this.VisitingDaysPanel);
            this.BasicInformationCard.Controls.Add(this.BasicSupplierInformationPanel);
            this.BasicInformationCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BasicInformationCard.Location = new System.Drawing.Point(0, 0);
            this.BasicInformationCard.Name = "BasicInformationCard";
            this.BasicInformationCard.Size = new System.Drawing.Size(1164, 174);
            this.BasicInformationCard.TabIndex = 39;
            // 
            // DebtPannel
            // 
            this.DebtPannel.Controls.Add(this.AdeudoLbl);
            this.DebtPannel.Controls.Add(this.label6);
            this.DebtPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DebtPannel.Location = new System.Drawing.Point(611, 0);
            this.DebtPannel.MinimumSize = new System.Drawing.Size(337, 174);
            this.DebtPannel.Name = "DebtPannel";
            this.DebtPannel.Padding = new System.Windows.Forms.Padding(10);
            this.DebtPannel.Size = new System.Drawing.Size(337, 174);
            this.DebtPannel.TabIndex = 2;
            this.DebtPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.DebtPannel_Paint);
            // 
            // VisitingDaysPanel
            // 
            this.VisitingDaysPanel.Controls.Add(this.label2);
            this.VisitingDaysPanel.Controls.Add(this.sabadoLbl);
            this.VisitingDaysPanel.Controls.Add(this.miercolesLbl);
            this.VisitingDaysPanel.Controls.Add(this.LunesLbl);
            this.VisitingDaysPanel.Controls.Add(this.juevesLbl);
            this.VisitingDaysPanel.Controls.Add(this.domingoLbl);
            this.VisitingDaysPanel.Controls.Add(this.martesLbl);
            this.VisitingDaysPanel.Controls.Add(this.viernesLbl);
            this.VisitingDaysPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VisitingDaysPanel.Location = new System.Drawing.Point(286, 0);
            this.VisitingDaysPanel.MinimumSize = new System.Drawing.Size(325, 174);
            this.VisitingDaysPanel.Name = "VisitingDaysPanel";
            this.VisitingDaysPanel.Size = new System.Drawing.Size(325, 174);
            this.VisitingDaysPanel.TabIndex = 1;
            this.VisitingDaysPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DebtPannel_Paint);
            // 
            // BasicSupplierInformationPanel
            // 
            this.BasicSupplierInformationPanel.Controls.Add(this.companyAddressTxt);
            this.BasicSupplierInformationPanel.Controls.Add(this.companyNameTxt);
            this.BasicSupplierInformationPanel.Controls.Add(this.phoneNumberTxt);
            this.BasicSupplierInformationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BasicSupplierInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.BasicSupplierInformationPanel.MinimumSize = new System.Drawing.Size(286, 174);
            this.BasicSupplierInformationPanel.Name = "BasicSupplierInformationPanel";
            this.BasicSupplierInformationPanel.Size = new System.Drawing.Size(286, 174);
            this.BasicSupplierInformationPanel.TabIndex = 0;
            this.BasicSupplierInformationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DebtPannel_Paint);
            // 
            // deleteSupplierBtn
            // 
            this.deleteSupplierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.deleteSupplierBtn.FlatAppearance.BorderSize = 0;
            this.deleteSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSupplierBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSupplierBtn.ForeColor = System.Drawing.Color.White;
            this.deleteSupplierBtn.Location = new System.Drawing.Point(966, 202);
            this.deleteSupplierBtn.Name = "deleteSupplierBtn";
            this.deleteSupplierBtn.Size = new System.Drawing.Size(130, 61);
            this.deleteSupplierBtn.TabIndex = 21;
            this.deleteSupplierBtn.Text = "Borrar Proveedor";
            this.deleteSupplierBtn.UseVisualStyleBackColor = false;
            this.deleteSupplierBtn.Click += new System.EventHandler(this.bunifuImageButton3_Click);
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
            this.FlowContainerPanel.Size = new System.Drawing.Size(628, 300);
            this.FlowContainerPanel.TabIndex = 2;
            this.FlowContainerPanel.Visible = false;
            // 
            // SearchingPanel
            // 
            this.SearchingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchingPanel.BackgroundImage")));
            this.SearchingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchingPanel.Controls.Add(this.AddNewCustomerBtn);
            this.SearchingPanel.Controls.Add(this.label1);
            this.SearchingPanel.Controls.Add(this.SearchSupplierTxt);
            this.SearchingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchingPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SearchingPanel.GradientBottomRight = System.Drawing.Color.White;
            this.SearchingPanel.GradientTopLeft = System.Drawing.Color.White;
            this.SearchingPanel.GradientTopRight = System.Drawing.Color.White;
            this.SearchingPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchingPanel.Name = "SearchingPanel";
            this.SearchingPanel.Quality = 10;
            this.SearchingPanel.Size = new System.Drawing.Size(628, 100);
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
            this.SuppliersPanel.Location = new System.Drawing.Point(0, 349);
            this.SuppliersPanel.Name = "SuppliersPanel";
            this.SuppliersPanel.Quality = 10;
            this.SuppliersPanel.Size = new System.Drawing.Size(628, 400);
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
            this.WindowSizeControlPanel.Size = new System.Drawing.Size(1164, 25);
            this.WindowSizeControlPanel.TabIndex = 21;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageActive = null;
            this.minimizeBtn.Location = new System.Drawing.Point(1108, 2);
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
            this.bunifuImageButton2.Location = new System.Drawing.Point(1133, 2);
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
            this.ClientSize = new System.Drawing.Size(1164, 749);
            this.Controls.Add(this.SupplierInfromationPanel);
            this.Controls.Add(this.SuppliersPanel);
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
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_proveedores_Form_MouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.AddNewCustomerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.NextPurchaseCard.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.SupplierImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierImagePicBox)).EndInit();
            this.RemindersPanel.ResumeLayout(false);
            this.RemindersPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.DataGridCardControlPanel.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ProductListPanel.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ControlsContainerPanel.ResumeLayout(false);
            this.SupplierInfromationPanel.ResumeLayout(false);
            this.BasicInformationCard.ResumeLayout(false);
            this.DebtPannel.ResumeLayout(false);
            this.VisitingDaysPanel.ResumeLayout(false);
            this.VisitingDaysPanel.PerformLayout();
            this.BasicSupplierInformationPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ProgressBar LoadingSupplierListBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label grandTotalLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AdeudoLbl;
        private System.Windows.Forms.Label LunesLbl;
        private System.Windows.Forms.Label viernesLbl;
        private System.Windows.Forms.Label sabadoLbl;
        private System.Windows.Forms.Label juevesLbl;
        private System.Windows.Forms.Label miercolesLbl;
        private System.Windows.Forms.Label martesLbl;
        private System.Windows.Forms.Label domingoLbl;
        private System.Windows.Forms.TextBox SearchSupplierTxt;
        private Bunifu.Framework.UI.BunifuSeparator ProggressActiveSeparator;
        private Bunifu.Framework.UI.BunifuSeparator ProgressUnactiveSeparator;
        private System.Windows.Forms.Button ProductTableBtn;
        private System.Windows.Forms.Button NextPurchaseTableBtn;
        private System.Windows.Forms.Button AlarmsBtn;
        private System.Windows.Forms.Button RecomendValueBtn;
        private System.Windows.Forms.Button POBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCards NextPurchaseCard;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton AddNewCustomerBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton PromoBtn;
        private Bunifu.Framework.UI.BunifuImageButton AddRowBtn;
        private Bunifu.Framework.UI.BunifuImageButton EditRowBtn;
        private Bunifu.Framework.UI.BunifuImageButton DeleteRowBtn;
        private System.Windows.Forms.TextBox FilteringTextbox;
        private Bunifu.Framework.UI.BunifuGradientPanel SupplierImagePanel;
        private System.Windows.Forms.PictureBox SupplierImagePicBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyAddressTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyNameTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumberTxt;
        private System.Windows.Forms.ToolTip AddSupplierToolTip;
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
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn piecesPerCase;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewComboBoxColumn depot;
        private DataGridViewTextBoxColumn Total;
        private Label casescountLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 proceedPurchaseBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 saveBtn;
        private Button deleteSupplierBtn;
        private Panel panel1;
        private DataGridView dataGridView3;
        private Label label8;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label4;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label5;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label11;
        private Panel panel5;
        private TextBox textBox1;
        private Label label10;
        private Panel panel3;
        private DataGridView dataGridView4;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel BasicInformationCard;
        private Panel DebtPannel;
        private Panel VisitingDaysPanel;
        private Panel BasicSupplierInformationPanel;
    }
}