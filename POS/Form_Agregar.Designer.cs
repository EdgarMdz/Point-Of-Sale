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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.LinkProductCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.displayAsKilogramCheckBox = new System.Windows.Forms.CheckBox();
            this.hideInTicketCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label9.Location = new System.Drawing.Point(216, 573);
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
            this.label11.Location = new System.Drawing.Point(216, 634);
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
            this.label13.Location = new System.Drawing.Point(534, 573);
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
            this.label14.Location = new System.Drawing.Point(287, 573);
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
            this.label15.Location = new System.Drawing.Point(287, 634);
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
            this.label16.Location = new System.Drawing.Point(534, 634);
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
            this.LoadImageBtn.Location = new System.Drawing.Point(672, 314);
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
            this.AcceptButton.Location = new System.Drawing.Point(372, 718);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(158, 53);
            this.AcceptButton.TabIndex = 13;
            this.AcceptButton.Text = "Aceptar";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
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
            this.panel2.Location = new System.Drawing.Point(31, 120);
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
            this.panel3.Location = new System.Drawing.Point(31, 187);
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
            this.panel4.Location = new System.Drawing.Point(31, 254);
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
            this.linkedProductPanel.Location = new System.Drawing.Point(0, 77);
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
            this.linkedProductBarcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.linkedProductBarcodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linkedProductBarcodeTxt_KeyPress);
            this.linkedProductBarcodeTxt.Leave += new System.EventHandler(this.linkedProductBarcodeTxt_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.costbyCaseLbl);
            this.panel6.Controls.Add(this.costbyCaseTxt);
            this.panel6.Location = new System.Drawing.Point(31, 388);
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
            this.panel7.Location = new System.Drawing.Point(31, 455);
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
            this.panel8.Location = new System.Drawing.Point(36, 321);
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
            this.panel9.Location = new System.Drawing.Point(31, 551);
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
            this.panel10.Location = new System.Drawing.Point(31, 612);
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
            this.panel11.Location = new System.Drawing.Point(615, 360);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(252, 55);
            this.panel11.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LinkProductCheckBox);
            this.groupBox1.Controls.Add(this.linkedProductPanel);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(620, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 140);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta Suelto";
            // 
            // LinkProductCheckBox
            // 
            this.LinkProductCheckBox.AutoSize = true;
            this.LinkProductCheckBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkProductCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.LinkProductCheckBox.Location = new System.Drawing.Point(0, 42);
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
            this.checkBox1.Location = new System.Drawing.Point(615, 422);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 29);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Es Retornable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // displayAsKilogramCheckBox
            // 
            this.displayAsKilogramCheckBox.AutoSize = true;
            this.displayAsKilogramCheckBox.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.displayAsKilogramCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.displayAsKilogramCheckBox.Location = new System.Drawing.Point(615, 455);
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
            this.hideInTicketCheckBox.Location = new System.Drawing.Point(615, 488);
            this.hideInTicketCheckBox.Name = "hideInTicketCheckBox";
            this.hideInTicketCheckBox.Size = new System.Drawing.Size(240, 29);
            this.hideInTicketCheckBox.TabIndex = 50;
            this.hideInTicketCheckBox.Text = "Ocultar en el Ticket";
            this.hideInTicketCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(333, 572);
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
            this.textBox2.Location = new System.Drawing.Point(333, 633);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(197, 34);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(856, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 51;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(615, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            // 
            // Form_Agregar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 795);
            this.Controls.Add(this.bunifuImageButton1);
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
            this.Load += new System.EventHandler(this.Form_Agregar_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
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
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}