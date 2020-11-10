using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Form_Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.PhotoBtnElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brandLbl = new System.Windows.Forms.Label();
            this.BrandTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.barcodeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.retailCostLbl = new System.Windows.Forms.Label();
            this.retailCostTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.linkedProductPanel = new System.Windows.Forms.Panel();
            this.LinkedProductBarcodeLbl = new System.Windows.Forms.Label();
            this.linkedProductBarcodeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.costbyCaseLbl = new System.Windows.Forms.Label();
            this.costbyCaseTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.piecesByCaseLbl = new System.Windows.Forms.Label();
            this.piecesByCaseTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.purchaseCostLbl = new System.Windows.Forms.Label();
            this.PurchaseCostTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.stockLbl = new System.Windows.Forms.Label();
            this.stockTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.minimumStockLbl = new System.Windows.Forms.Label();
            this.minimumStockTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LinkProductCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.displayAsKilogramCheckBox = new System.Windows.Forms.CheckBox();
            this.hideInTicketCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.wholesaleCostsBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.removeImageBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.alterProductsList = new System.Windows.Forms.LinkLabel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainProductTxt = new System.Windows.Forms.TextBox();
            this.subProductTxt = new System.Windows.Forms.TextBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.linkedProductPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeImageBtn)).BeginInit();
            this.panel5.SuspendLayout();
            this.helpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label9.Location = new System.Drawing.Point(213, 675);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "pzas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(2, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Bodega por Default:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label11.Location = new System.Drawing.Point(216, 761);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 27);
            this.label11.TabIndex = 26;
            this.label11.Text = "pzas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label13.Location = new System.Drawing.Point(531, 677);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 27);
            this.label13.TabIndex = 28;
            this.label13.Text = "cajas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label14.Location = new System.Drawing.Point(284, 677);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 27);
            this.label14.TabIndex = 30;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label15.Location = new System.Drawing.Point(283, 761);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 27);
            this.label15.TabIndex = 33;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label16.Location = new System.Drawing.Point(530, 761);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 27);
            this.label16.TabIndex = 31;
            this.label16.Text = "cajas";
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.LoadImageBtn.FlatAppearance.BorderSize = 0;
            this.LoadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImageBtn.ForeColor = System.Drawing.Color.White;
            this.LoadImageBtn.Location = new System.Drawing.Point(671, 281);
            this.LoadImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(138, 35);
            this.LoadImageBtn.TabIndex = 12;
            this.LoadImageBtn.Text = "Buscar Foto";
            this.LoadImageBtn.UseVisualStyleBackColor = false;
            this.LoadImageBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(364, 834);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(158, 53);
            this.AcceptButton.TabIndex = 13;
            this.AcceptButton.Text = "Aceptar";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // PhotoBtnElipse
            // 
            this.PhotoBtnElipse.ElipseRadius = 35;
            this.PhotoBtnElipse.TargetControl = this.LoadImageBtn;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DescriptionTxt);
            this.panel1.Controls.Add(this.DescriptionLbl);
            this.panel1.Location = new System.Drawing.Point(31, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 55);
            this.panel1.TabIndex = 0;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.AutoSize = true;
            this.DescriptionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.DescriptionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DescriptionTxt.HintForeColor = System.Drawing.Color.Empty;
            this.DescriptionTxt.HintText = "Descripción del Producto";
            this.DescriptionTxt.isPassword = false;
            this.DescriptionTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DescriptionTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.DescriptionTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DescriptionTxt.LineThickness = 1;
            this.DescriptionTxt.Location = new System.Drawing.Point(0, 11);
            this.DescriptionTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(559, 44);
            this.DescriptionTxt.TabIndex = 0;
            this.DescriptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DescriptionTxt.OnValueChanged += new System.EventHandler(this.DescripcionTxt_OnValueChanged);
            this.DescriptionTxt.Enter += new System.EventHandler(this.DescripcionTxt_Enter);
            this.DescriptionTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.DescriptionTxt.Leave += new System.EventHandler(this.DescripcionTxt_Leave);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.DescriptionLbl.Location = new System.Drawing.Point(2, -2);
            this.DescriptionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(75, 15);
            this.DescriptionLbl.TabIndex = 36;
            this.DescriptionLbl.Text = "Descripción:";
            this.DescriptionLbl.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.brandLbl);
            this.panel2.Controls.Add(this.BrandTxt);
            this.panel2.Location = new System.Drawing.Point(31, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 55);
            this.panel2.TabIndex = 1;
            // 
            // brandLbl
            // 
            this.brandLbl.BackColor = System.Drawing.Color.Transparent;
            this.brandLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.brandLbl.Location = new System.Drawing.Point(2, -2);
            this.brandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(54, 16);
            this.brandLbl.TabIndex = 36;
            this.brandLbl.Text = "Marca:";
            this.brandLbl.Visible = false;
            // 
            // BrandTxt
            // 
            this.BrandTxt.AutoSize = true;
            this.BrandTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BrandTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.BrandTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.BrandTxt.HintForeColor = System.Drawing.Color.Empty;
            this.BrandTxt.HintText = "Marca";
            this.BrandTxt.isPassword = false;
            this.BrandTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.BrandTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.BrandTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.BrandTxt.LineThickness = 1;
            this.BrandTxt.Location = new System.Drawing.Point(0, 11);
            this.BrandTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BrandTxt.Name = "BrandTxt";
            this.BrandTxt.Size = new System.Drawing.Size(559, 44);
            this.BrandTxt.TabIndex = 1;
            this.BrandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BrandTxt.OnValueChanged += new System.EventHandler(this.BrandTxt_OnValueChanged);
            this.BrandTxt.Enter += new System.EventHandler(this.BrandTxt_Enter);
            this.BrandTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.BrandTxt.Leave += new System.EventHandler(this.BrandTxt_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BarcodeLbl);
            this.panel3.Controls.Add(this.barcodeTxt);
            this.panel3.Location = new System.Drawing.Point(31, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 55);
            this.panel3.TabIndex = 2;
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.BackColor = System.Drawing.Color.Transparent;
            this.BarcodeLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.BarcodeLbl.Location = new System.Drawing.Point(2, -2);
            this.BarcodeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(103, 15);
            this.BarcodeLbl.TabIndex = 36;
            this.BarcodeLbl.Text = "Código de Barras:";
            this.BarcodeLbl.Visible = false;
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.AutoSize = true;
            this.barcodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcodeTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.barcodeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.barcodeTxt.HintForeColor = System.Drawing.Color.Empty;
            this.barcodeTxt.HintText = "Código de Baras";
            this.barcodeTxt.isPassword = false;
            this.barcodeTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.barcodeTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.barcodeTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.barcodeTxt.LineThickness = 1;
            this.barcodeTxt.Location = new System.Drawing.Point(0, 11);
            this.barcodeTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(559, 44);
            this.barcodeTxt.TabIndex = 2;
            this.barcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.barcodeTxt.OnValueChanged += new System.EventHandler(this.barcodeTxt_OnValueChanged);
            this.barcodeTxt.Enter += new System.EventHandler(this.barcodeTxt_Enter);
            this.barcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.barcodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoBarrasTxt_KeyPress);
            this.barcodeTxt.Leave += new System.EventHandler(this.barcodeTxt_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.retailCostLbl);
            this.panel4.Controls.Add(this.retailCostTxt);
            this.panel4.Location = new System.Drawing.Point(31, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 55);
            this.panel4.TabIndex = 3;
            // 
            // retailCostLbl
            // 
            this.retailCostLbl.AutoSize = true;
            this.retailCostLbl.BackColor = System.Drawing.Color.Transparent;
            this.retailCostLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailCostLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.retailCostLbl.Location = new System.Drawing.Point(2, -2);
            this.retailCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retailCostLbl.Name = "retailCostLbl";
            this.retailCostLbl.Size = new System.Drawing.Size(117, 15);
            this.retailCostLbl.TabIndex = 36;
            this.retailCostLbl.Text = "Precio de Menudeo:";
            // 
            // retailCostTxt
            // 
            this.retailCostTxt.AutoSize = true;
            this.retailCostTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.retailCostTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.retailCostTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.retailCostTxt.HintForeColor = System.Drawing.Color.Empty;
            this.retailCostTxt.HintText = "Precio de Menudeo";
            this.retailCostTxt.isPassword = false;
            this.retailCostTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.retailCostTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.retailCostTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.retailCostTxt.LineThickness = 1;
            this.retailCostTxt.Location = new System.Drawing.Point(0, 11);
            this.retailCostTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.retailCostTxt.Name = "retailCostTxt";
            this.retailCostTxt.Size = new System.Drawing.Size(559, 44);
            this.retailCostTxt.TabIndex = 3;
            this.retailCostTxt.Text = "0";
            this.retailCostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.retailCostTxt.OnValueChanged += new System.EventHandler(this.retailCostTxt_OnValueChanged);
            this.retailCostTxt.Enter += new System.EventHandler(this.retailCostTxt_Enter);
            this.retailCostTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.retailCostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioMinoreoTxt_KeyPress);
            this.retailCostTxt.Leave += new System.EventHandler(this.retailCostTxt_Leave);
            // 
            // linkedProductPanel
            // 
            this.linkedProductPanel.Controls.Add(this.LinkedProductBarcodeLbl);
            this.linkedProductPanel.Controls.Add(this.linkedProductBarcodeTxt);
            this.linkedProductPanel.Location = new System.Drawing.Point(0, 68);
            this.linkedProductPanel.Name = "linkedProductPanel";
            this.linkedProductPanel.Size = new System.Drawing.Size(258, 55);
            this.linkedProductPanel.TabIndex = 47;
            // 
            // LinkedProductBarcodeLbl
            // 
            this.LinkedProductBarcodeLbl.BackColor = System.Drawing.Color.Transparent;
            this.LinkedProductBarcodeLbl.Enabled = false;
            this.LinkedProductBarcodeLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedProductBarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.LinkedProductBarcodeLbl.Location = new System.Drawing.Point(2, -2);
            this.LinkedProductBarcodeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkedProductBarcodeLbl.Name = "LinkedProductBarcodeLbl";
            this.LinkedProductBarcodeLbl.Size = new System.Drawing.Size(242, 16);
            this.LinkedProductBarcodeLbl.TabIndex = 36;
            this.LinkedProductBarcodeLbl.Text = "Código de Barras Producto Principal:";
            this.LinkedProductBarcodeLbl.Visible = false;
            // 
            // linkedProductBarcodeTxt
            // 
            this.linkedProductBarcodeTxt.AutoSize = true;
            this.linkedProductBarcodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.linkedProductBarcodeTxt.Enabled = false;
            this.linkedProductBarcodeTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.linkedProductBarcodeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.linkedProductBarcodeTxt.HintForeColor = System.Drawing.Color.Empty;
            this.linkedProductBarcodeTxt.HintText = "Código de Baras";
            this.linkedProductBarcodeTxt.isPassword = false;
            this.linkedProductBarcodeTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.linkedProductBarcodeTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.linkedProductBarcodeTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.linkedProductBarcodeTxt.LineThickness = 1;
            this.linkedProductBarcodeTxt.Location = new System.Drawing.Point(12, 11);
            this.linkedProductBarcodeTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.linkedProductBarcodeTxt.Name = "linkedProductBarcodeTxt";
            this.linkedProductBarcodeTxt.Size = new System.Drawing.Size(234, 44);
            this.linkedProductBarcodeTxt.TabIndex = 2;
            this.linkedProductBarcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.linkedProductBarcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.linkedProductBarcodeTxt_KeyDown);
            this.linkedProductBarcodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linkedProductBarcodeTxt_KeyPress);
            this.linkedProductBarcodeTxt.Leave += new System.EventHandler(this.linkedProductBarcodeTxt_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.costbyCaseLbl);
            this.panel6.Controls.Add(this.costbyCaseTxt);
            this.panel6.Location = new System.Drawing.Point(31, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(559, 55);
            this.panel6.TabIndex = 7;
            // 
            // costbyCaseLbl
            // 
            this.costbyCaseLbl.AutoSize = true;
            this.costbyCaseLbl.BackColor = System.Drawing.Color.Transparent;
            this.costbyCaseLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costbyCaseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.costbyCaseLbl.Location = new System.Drawing.Point(2, -2);
            this.costbyCaseLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costbyCaseLbl.Name = "costbyCaseLbl";
            this.costbyCaseLbl.Size = new System.Drawing.Size(94, 15);
            this.costbyCaseLbl.TabIndex = 36;
            this.costbyCaseLbl.Text = "Precio por Caja:";
            // 
            // costbyCaseTxt
            // 
            this.costbyCaseTxt.AutoSize = true;
            this.costbyCaseTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.costbyCaseTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.costbyCaseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.costbyCaseTxt.HintForeColor = System.Drawing.Color.Empty;
            this.costbyCaseTxt.HintText = "Precio Por Caja";
            this.costbyCaseTxt.isPassword = false;
            this.costbyCaseTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.costbyCaseTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.costbyCaseTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.costbyCaseTxt.LineThickness = 1;
            this.costbyCaseTxt.Location = new System.Drawing.Point(0, 11);
            this.costbyCaseTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.costbyCaseTxt.Name = "costbyCaseTxt";
            this.costbyCaseTxt.Size = new System.Drawing.Size(559, 44);
            this.costbyCaseTxt.TabIndex = 7;
            this.costbyCaseTxt.Text = "0.00";
            this.costbyCaseTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costbyCaseTxt.OnValueChanged += new System.EventHandler(this.costbyCaseTxt_OnValueChanged);
            this.costbyCaseTxt.Enter += new System.EventHandler(this.costbyCaseTxt_Enter);
            this.costbyCaseTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.costbyCaseTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioCajaTxt_KeyPress);
            this.costbyCaseTxt.Leave += new System.EventHandler(this.costbyCaseTxt_Leave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.piecesByCaseLbl);
            this.panel7.Controls.Add(this.piecesByCaseTxt);
            this.panel7.Location = new System.Drawing.Point(31, 569);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(559, 55);
            this.panel7.TabIndex = 8;
            // 
            // piecesByCaseLbl
            // 
            this.piecesByCaseLbl.AutoSize = true;
            this.piecesByCaseLbl.BackColor = System.Drawing.Color.Transparent;
            this.piecesByCaseLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piecesByCaseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.piecesByCaseLbl.Location = new System.Drawing.Point(2, -2);
            this.piecesByCaseLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.piecesByCaseLbl.Name = "piecesByCaseLbl";
            this.piecesByCaseLbl.Size = new System.Drawing.Size(93, 15);
            this.piecesByCaseLbl.TabIndex = 36;
            this.piecesByCaseLbl.Text = "Piezas por Caja:";
            // 
            // piecesByCaseTxt
            // 
            this.piecesByCaseTxt.AutoSize = true;
            this.piecesByCaseTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.piecesByCaseTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.piecesByCaseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.piecesByCaseTxt.HintForeColor = System.Drawing.Color.Empty;
            this.piecesByCaseTxt.HintText = "Piezas por Caja";
            this.piecesByCaseTxt.isPassword = false;
            this.piecesByCaseTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.piecesByCaseTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.piecesByCaseTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.piecesByCaseTxt.LineThickness = 1;
            this.piecesByCaseTxt.Location = new System.Drawing.Point(0, 11);
            this.piecesByCaseTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.piecesByCaseTxt.Name = "piecesByCaseTxt";
            this.piecesByCaseTxt.Size = new System.Drawing.Size(559, 44);
            this.piecesByCaseTxt.TabIndex = 8;
            this.piecesByCaseTxt.Text = "1";
            this.piecesByCaseTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.piecesByCaseTxt.OnValueChanged += new System.EventHandler(this.piecesByCaseTxt_OnValueChanged);
            this.piecesByCaseTxt.Enter += new System.EventHandler(this.piecesByCaseTxt_Enter);
            this.piecesByCaseTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.piecesByCaseTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PiezasCajaTxt_KeyPress);
            this.piecesByCaseTxt.Leave += new System.EventHandler(this.piecesByCaseTxt_Leave);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.purchaseCostLbl);
            this.panel8.Controls.Add(this.PurchaseCostTxt);
            this.panel8.Location = new System.Drawing.Point(36, 397);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(559, 55);
            this.panel8.TabIndex = 6;
            // 
            // purchaseCostLbl
            // 
            this.purchaseCostLbl.AutoSize = true;
            this.purchaseCostLbl.BackColor = System.Drawing.Color.Transparent;
            this.purchaseCostLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseCostLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.purchaseCostLbl.Location = new System.Drawing.Point(2, -2);
            this.purchaseCostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purchaseCostLbl.Name = "purchaseCostLbl";
            this.purchaseCostLbl.Size = new System.Drawing.Size(202, 15);
            this.purchaseCostLbl.TabIndex = 36;
            this.purchaseCostLbl.Text = "Último Precio de Compra (por Caja): ";
            // 
            // PurchaseCostTxt
            // 
            this.PurchaseCostTxt.AutoSize = true;
            this.PurchaseCostTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PurchaseCostTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.PurchaseCostTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.PurchaseCostTxt.HintForeColor = System.Drawing.Color.Empty;
            this.PurchaseCostTxt.HintText = "Último Precio de Compra";
            this.PurchaseCostTxt.isPassword = false;
            this.PurchaseCostTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.PurchaseCostTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.PurchaseCostTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.PurchaseCostTxt.LineThickness = 1;
            this.PurchaseCostTxt.Location = new System.Drawing.Point(0, 11);
            this.PurchaseCostTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PurchaseCostTxt.Name = "PurchaseCostTxt";
            this.PurchaseCostTxt.Size = new System.Drawing.Size(559, 44);
            this.PurchaseCostTxt.TabIndex = 6;
            this.PurchaseCostTxt.Text = "0.00";
            this.PurchaseCostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PurchaseCostTxt.OnValueChanged += new System.EventHandler(this.PurchaseCostTxt_OnValueChanged);
            this.PurchaseCostTxt.Enter += new System.EventHandler(this.PurchaseCostTxt_Enter);
            this.PurchaseCostTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.PurchaseCostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseCostTxt_KeyPress);
            this.PurchaseCostTxt.Leave += new System.EventHandler(this.PurchaseCostTxt_Leave);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.stockLbl);
            this.panel9.Controls.Add(this.stockTxt);
            this.panel9.Location = new System.Drawing.Point(31, 655);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(177, 55);
            this.panel9.TabIndex = 9;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.BackColor = System.Drawing.Color.Transparent;
            this.stockLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.stockLbl.Location = new System.Drawing.Point(2, -2);
            this.stockLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(39, 15);
            this.stockLbl.TabIndex = 36;
            this.stockLbl.Text = "Stock:";
            // 
            // stockTxt
            // 
            this.stockTxt.AutoSize = true;
            this.stockTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.stockTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.stockTxt.HintForeColor = System.Drawing.Color.Empty;
            this.stockTxt.HintText = "Stock";
            this.stockTxt.isPassword = false;
            this.stockTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.stockTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.stockTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.stockTxt.LineThickness = 1;
            this.stockTxt.Location = new System.Drawing.Point(0, 11);
            this.stockTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(177, 44);
            this.stockTxt.TabIndex = 9;
            this.stockTxt.Text = "0";
            this.stockTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stockTxt.OnValueChanged += new System.EventHandler(this.StockTxt_TextChanged);
            this.stockTxt.Enter += new System.EventHandler(this.stockTxt_Enter);
            this.stockTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.stockTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockTxt_KeyPress);
            this.stockTxt.Leave += new System.EventHandler(this.stockTxt_Leave);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.minimumStockLbl);
            this.panel10.Controls.Add(this.minimumStockTxt);
            this.panel10.Location = new System.Drawing.Point(31, 741);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(177, 55);
            this.panel10.TabIndex = 10;
            // 
            // minimumStockLbl
            // 
            this.minimumStockLbl.AutoSize = true;
            this.minimumStockLbl.BackColor = System.Drawing.Color.Transparent;
            this.minimumStockLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumStockLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.minimumStockLbl.Location = new System.Drawing.Point(2, -2);
            this.minimumStockLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minimumStockLbl.Name = "minimumStockLbl";
            this.minimumStockLbl.Size = new System.Drawing.Size(81, 15);
            this.minimumStockLbl.TabIndex = 36;
            this.minimumStockLbl.Text = "Stock Mínimo:";
            // 
            // minimumStockTxt
            // 
            this.minimumStockTxt.AutoSize = true;
            this.minimumStockTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minimumStockTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.minimumStockTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.minimumStockTxt.HintForeColor = System.Drawing.Color.Empty;
            this.minimumStockTxt.HintText = "Stock Mínimo:";
            this.minimumStockTxt.isPassword = false;
            this.minimumStockTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.minimumStockTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.minimumStockTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.minimumStockTxt.LineThickness = 1;
            this.minimumStockTxt.Location = new System.Drawing.Point(0, 11);
            this.minimumStockTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minimumStockTxt.Name = "minimumStockTxt";
            this.minimumStockTxt.Size = new System.Drawing.Size(177, 44);
            this.minimumStockTxt.TabIndex = 10;
            this.minimumStockTxt.Text = "0";
            this.minimumStockTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.minimumStockTxt.OnValueChanged += new System.EventHandler(this.MinimimStockTxt_TextChanged);
            this.minimumStockTxt.Enter += new System.EventHandler(this.minimumStockTxt_Enter);
            this.minimumStockTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTxt_KeyDown);
            this.minimumStockTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinimimStockTxt_KeyPress);
            this.minimumStockTxt.Leave += new System.EventHandler(this.minimumStockTxt_Leave);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.comboBox1);
            this.panel11.Location = new System.Drawing.Point(615, 341);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(252, 55);
            this.panel11.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.groupBox1.Controls.Add(this.LinkProductCheckBox);
            this.groupBox1.Controls.Add(this.linkedProductPanel);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(615, 509);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 229);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio Alterno";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 40);
            this.label2.TabIndex = 50;
            this.label2.Text = "¿Cuántas piezas conforman una pieza del proucto principal?";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoSize = true;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Piezas";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuMaterialTextbox1.LineThickness = 1;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(23, 178);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(212, 44);
            this.bunifuMaterialTextbox1.TabIndex = 49;
            this.bunifuMaterialTextbox1.Text = "1.00";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.bunifuMaterialTextbox1.Click += new System.EventHandler(this.bunifuMaterialTextbox1_Click);
            this.bunifuMaterialTextbox1.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            this.bunifuMaterialTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMaterialTextbox1_KeyPress);
            this.bunifuMaterialTextbox1.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // LinkProductCheckBox
            // 
            this.LinkProductCheckBox.AutoSize = true;
            this.LinkProductCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkProductCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.LinkProductCheckBox.Location = new System.Drawing.Point(0, 33);
            this.LinkProductCheckBox.Name = "LinkProductCheckBox";
            this.LinkProductCheckBox.Size = new System.Drawing.Size(258, 26);
            this.LinkProductCheckBox.TabIndex = 46;
            this.LinkProductCheckBox.Text = "Relacionar con Producto";
            this.LinkProductCheckBox.UseVisualStyleBackColor = true;
            this.LinkProductCheckBox.CheckedChanged += new System.EventHandler(this.LinkProductCheckBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.checkBox1.Location = new System.Drawing.Point(615, 408);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 29);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Es Envase";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // displayAsKilogramCheckBox
            // 
            this.displayAsKilogramCheckBox.AutoSize = true;
            this.displayAsKilogramCheckBox.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.displayAsKilogramCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.displayAsKilogramCheckBox.Location = new System.Drawing.Point(615, 441);
            this.displayAsKilogramCheckBox.Name = "displayAsKilogramCheckBox";
            this.displayAsKilogramCheckBox.Size = new System.Drawing.Size(224, 29);
            this.displayAsKilogramCheckBox.TabIndex = 49;
            this.displayAsKilogramCheckBox.Text = "Mostrar como Kg.";
            this.displayAsKilogramCheckBox.UseVisualStyleBackColor = true;
            this.displayAsKilogramCheckBox.CheckedChanged += new System.EventHandler(this.displayAsKilogramCheckBox_CheckedChanged);
            // 
            // hideInTicketCheckBox
            // 
            this.hideInTicketCheckBox.AutoSize = true;
            this.hideInTicketCheckBox.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.hideInTicketCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.hideInTicketCheckBox.Location = new System.Drawing.Point(615, 474);
            this.hideInTicketCheckBox.Name = "hideInTicketCheckBox";
            this.hideInTicketCheckBox.Size = new System.Drawing.Size(240, 29);
            this.hideInTicketCheckBox.TabIndex = 50;
            this.hideInTicketCheckBox.Text = "Ocultar en el Ticket";
            this.hideInTicketCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(330, 675);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(197, 34);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(329, 759);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(197, 34);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(855, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(19, 20);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 51;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(615, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // wholesaleCostsBtn
            // 
            this.wholesaleCostsBtn.ActiveBorderThickness = 1;
            this.wholesaleCostsBtn.ActiveCornerRadius = 20;
            this.wholesaleCostsBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.wholesaleCostsBtn.ActiveForecolor = System.Drawing.Color.White;
            this.wholesaleCostsBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.wholesaleCostsBtn.BackColor = System.Drawing.Color.White;
            this.wholesaleCostsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wholesaleCostsBtn.BackgroundImage")));
            this.wholesaleCostsBtn.ButtonText = "Precios de Mayoreo";
            this.wholesaleCostsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wholesaleCostsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholesaleCostsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.wholesaleCostsBtn.IdleBorderThickness = 1;
            this.wholesaleCostsBtn.IdleCornerRadius = 20;
            this.wholesaleCostsBtn.IdleFillColor = System.Drawing.Color.White;
            this.wholesaleCostsBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.wholesaleCostsBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(170)))));
            this.wholesaleCostsBtn.Location = new System.Drawing.Point(650, 792);
            this.wholesaleCostsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.wholesaleCostsBtn.Name = "wholesaleCostsBtn";
            this.wholesaleCostsBtn.Size = new System.Drawing.Size(181, 41);
            this.wholesaleCostsBtn.TabIndex = 52;
            this.wholesaleCostsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wholesaleCostsBtn.Visible = false;
            this.wholesaleCostsBtn.Click += new System.EventHandler(this.wholesaleCostsBtn_Click);
            // 
            // removeImageBtn
            // 
            this.removeImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeImageBtn.Image")));
            this.removeImageBtn.ImageActive = null;
            this.removeImageBtn.Location = new System.Drawing.Point(615, 53);
            this.removeImageBtn.Name = "removeImageBtn";
            this.removeImageBtn.Size = new System.Drawing.Size(19, 20);
            this.removeImageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeImageBtn.TabIndex = 53;
            this.removeImageBtn.TabStop = false;
            this.removeImageBtn.Visible = false;
            this.removeImageBtn.Zoom = 10;
            this.removeImageBtn.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Descargar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 2);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(125, 41);
            this.bunifuFlatButton1.TabIndex = 54;
            this.bunifuFlatButton1.Text = "Descargar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            this.bunifuFlatButton1.MouseHover += new System.EventHandler(this.bunifuFlatButton1_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.bunifuFlatButton1);
            this.panel5.Location = new System.Drawing.Point(672, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 45);
            this.panel5.TabIndex = 55;
            // 
            // alterProductsList
            // 
            this.alterProductsList.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.alterProductsList.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.alterProductsList.Location = new System.Drawing.Point(657, 748);
            this.alterProductsList.Name = "alterProductsList";
            this.alterProductsList.Size = new System.Drawing.Size(174, 39);
            this.alterProductsList.TabIndex = 48;
            this.alterProductsList.TabStop = true;
            this.alterProductsList.Text = "Lista de Productos Derivados";
            this.alterProductsList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alterProductsList.Visible = false;
            this.alterProductsList.VisitedLinkColor = System.Drawing.Color.Blue;
            this.alterProductsList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.alterProductsList_LinkClicked);
            // 
            // helpPanel
            // 
            this.helpPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.helpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpPanel.Controls.Add(this.bunifuImageButton1);
            this.helpPanel.Controls.Add(this.button1);
            this.helpPanel.Controls.Add(this.label6);
            this.helpPanel.Controls.Add(this.label5);
            this.helpPanel.Controls.Add(this.label4);
            this.helpPanel.Controls.Add(this.label3);
            this.helpPanel.Controls.Add(this.mainProductTxt);
            this.helpPanel.Controls.Add(this.subProductTxt);
            this.helpPanel.Location = new System.Drawing.Point(615, 787);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(342, 100);
            this.helpPanel.TabIndex = 56;
            this.helpPanel.Visible = false;
            this.helpPanel.VisibleChanged += new System.EventHandler(this.helpPanel_VisibleChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(325, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(15, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 54;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(120, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 21);
            this.button1.TabIndex = 35;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Producto Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(179, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Producto Principal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(273, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "piezas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(123, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "piezas      =";
            // 
            // mainProductTxt
            // 
            this.mainProductTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainProductTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductTxt.Location = new System.Drawing.Point(202, 40);
            this.mainProductTxt.Name = "mainProductTxt";
            this.mainProductTxt.Size = new System.Drawing.Size(60, 21);
            this.mainProductTxt.TabIndex = 1;
            this.mainProductTxt.Text = "1.00";
            this.mainProductTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainProductTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subProductTxt_KeyPress);
            this.mainProductTxt.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // subProductTxt
            // 
            this.subProductTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subProductTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subProductTxt.Location = new System.Drawing.Point(54, 40);
            this.subProductTxt.Name = "subProductTxt";
            this.subProductTxt.Size = new System.Drawing.Size(60, 21);
            this.subProductTxt.TabIndex = 0;
            this.subProductTxt.Text = "1.00";
            this.subProductTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subProductTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subProductTxt_KeyPress);
            this.subProductTxt.Leave += new System.EventHandler(this.bunifuMaterialTextbox1_Leave);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = false;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.helpPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form_Agregar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 900);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.removeImageBtn);
            this.Controls.Add(this.alterProductsList);
            this.Controls.Add(this.wholesaleCostsBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hideInTicketCheckBox);
            this.Controls.Add(this.displayAsKilogramCheckBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.LoadImageBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Agregar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto | Point of Sale";
            this.Deactivate += new System.EventHandler(this.Form_Agregar_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Agregar_FormClosing);
            this.Load += new System.EventHandler(this.Form_Agregar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Agregar_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.linkedProductPanel.ResumeLayout(false);
            this.linkedProductPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeImageBtn)).EndInit();
            this.panel5.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            this.helpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button LoadImageBtn;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox hideInTicketCheckBox;
        private System.Windows.Forms.CheckBox displayAsKilogramCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LinkProductCheckBox;
        private System.Windows.Forms.Panel linkedProductPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox linkedProductBarcodeTxt;
        private System.Windows.Forms.Label LinkedProductBarcodeLbl;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox minimumStockTxt;
        private System.Windows.Forms.Label minimumStockLbl;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stockTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PurchaseCostTxt;
        private System.Windows.Forms.Label purchaseCostLbl;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox piecesByCaseTxt;
        private System.Windows.Forms.Label piecesByCaseLbl;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox costbyCaseTxt;
        private System.Windows.Forms.Label costbyCaseLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label retailCostLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox retailCostTxt;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox barcodeTxt;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BrandTxt;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescriptionTxt;
        private System.Windows.Forms.Label DescriptionLbl;
        private Bunifu.Framework.UI.BunifuElipse PhotoBtnElipse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 wholesaleCostsBtn;
        private Bunifu.Framework.UI.BunifuImageButton removeImageBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Panel panel5;
        private LinkLabel alterProductsList;
        private Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Panel helpPanel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox mainProductTxt;
        private TextBox subProductTxt;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Button button1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}