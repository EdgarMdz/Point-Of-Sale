using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_productos_Transferir_Inventario_entre_bodegas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_productos_Transferir_Inventario_entre_bodegas));
            this.DonatingDepotCard = new Bunifu.Framework.UI.BunifuCards();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LessBtn = new System.Windows.Forms.Button();
            this.pieceQuantLbl = new System.Windows.Forms.Label();
            this.MoreBtn = new System.Windows.Forms.Button();
            this.boxQuantLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LongMoreBtn = new System.Windows.Forms.Button();
            this.LongLessBtn = new System.Windows.Forms.Button();
            this.ReceiverDepotCard = new Bunifu.Framework.UI.BunifuCards();
            this.addedPiecesLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.brandLbl = new System.Windows.Forms.Label();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.receiverCombo = new System.Windows.Forms.ComboBox();
            this.DonatingCombo = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.AcceptBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.switchDepotsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.piecesPerCaseTxt = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DonatingDepotCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.ReceiverDepotCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDepotsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DonatingDepotCard
            // 
            this.DonatingDepotCard.BackColor = System.Drawing.Color.White;
            this.DonatingDepotCard.BorderRadius = 15;
            this.DonatingDepotCard.BottomSahddow = true;
            this.DonatingDepotCard.color = System.Drawing.Color.LightSkyBlue;
            this.DonatingDepotCard.Controls.Add(this.trackBar1);
            this.DonatingDepotCard.Controls.Add(this.LessBtn);
            this.DonatingDepotCard.Controls.Add(this.pieceQuantLbl);
            this.DonatingDepotCard.Controls.Add(this.MoreBtn);
            this.DonatingDepotCard.Controls.Add(this.boxQuantLbl);
            this.DonatingDepotCard.Controls.Add(this.label2);
            this.DonatingDepotCard.Controls.Add(this.LongMoreBtn);
            this.DonatingDepotCard.Controls.Add(this.LongLessBtn);
            this.DonatingDepotCard.LeftSahddow = false;
            this.DonatingDepotCard.Location = new System.Drawing.Point(749, 194);
            this.DonatingDepotCard.Name = "DonatingDepotCard";
            this.DonatingDepotCard.RightSahddow = true;
            this.DonatingDepotCard.ShadowDepth = 50;
            this.DonatingDepotCard.Size = new System.Drawing.Size(605, 283);
            this.DonatingDepotCard.TabIndex = 40;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(145, 222);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(314, 23);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // LessBtn
            // 
            this.LessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.LessBtn.FlatAppearance.BorderSize = 0;
            this.LessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LessBtn.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessBtn.ForeColor = System.Drawing.Color.White;
            this.LessBtn.Location = new System.Drawing.Point(82, 205);
            this.LessBtn.Name = "LessBtn";
            this.LessBtn.Size = new System.Drawing.Size(57, 57);
            this.LessBtn.TabIndex = 13;
            this.LessBtn.Text = "-";
            this.LessBtn.UseVisualStyleBackColor = false;
            this.LessBtn.Click += new System.EventHandler(this.LessBtn_Click);
            // 
            // pieceQuantLbl
            // 
            this.pieceQuantLbl.AutoEllipsis = true;
            this.pieceQuantLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceQuantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.pieceQuantLbl.Location = new System.Drawing.Point(95, 140);
            this.pieceQuantLbl.Name = "pieceQuantLbl";
            this.pieceQuantLbl.Size = new System.Drawing.Size(415, 47);
            this.pieceQuantLbl.TabIndex = 14;
            this.pieceQuantLbl.Text = "40 piezas";
            this.pieceQuantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoreBtn
            // 
            this.MoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.MoreBtn.FlatAppearance.BorderSize = 0;
            this.MoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreBtn.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreBtn.ForeColor = System.Drawing.Color.White;
            this.MoreBtn.Location = new System.Drawing.Point(465, 201);
            this.MoreBtn.Name = "MoreBtn";
            this.MoreBtn.Size = new System.Drawing.Size(57, 57);
            this.MoreBtn.TabIndex = 12;
            this.MoreBtn.Text = "+";
            this.MoreBtn.UseVisualStyleBackColor = false;
            this.MoreBtn.Click += new System.EventHandler(this.MoreBtn_Click);
            // 
            // boxQuantLbl
            // 
            this.boxQuantLbl.AutoEllipsis = true;
            this.boxQuantLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxQuantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.boxQuantLbl.Location = new System.Drawing.Point(95, 75);
            this.boxQuantLbl.Name = "boxQuantLbl";
            this.boxQuantLbl.Size = new System.Drawing.Size(415, 47);
            this.boxQuantLbl.TabIndex = 6;
            this.boxQuantLbl.Text = "40 cajas";
            this.boxQuantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // LongMoreBtn
            // 
            this.LongMoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.LongMoreBtn.FlatAppearance.BorderSize = 0;
            this.LongMoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongMoreBtn.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongMoreBtn.ForeColor = System.Drawing.Color.White;
            this.LongMoreBtn.Location = new System.Drawing.Point(528, 201);
            this.LongMoreBtn.Name = "LongMoreBtn";
            this.LongMoreBtn.Size = new System.Drawing.Size(57, 57);
            this.LongMoreBtn.TabIndex = 7;
            this.LongMoreBtn.Text = "++";
            this.LongMoreBtn.UseVisualStyleBackColor = false;
            this.LongMoreBtn.Click += new System.EventHandler(this.LongMoreBtn_Click);
            // 
            // LongLessBtn
            // 
            this.LongLessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.LongLessBtn.FlatAppearance.BorderSize = 0;
            this.LongLessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LongLessBtn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.LongLessBtn.ForeColor = System.Drawing.Color.White;
            this.LongLessBtn.Location = new System.Drawing.Point(19, 205);
            this.LongLessBtn.Name = "LongLessBtn";
            this.LongLessBtn.Size = new System.Drawing.Size(57, 57);
            this.LongLessBtn.TabIndex = 11;
            this.LongLessBtn.Text = "- -";
            this.LongLessBtn.UseVisualStyleBackColor = false;
            this.LongLessBtn.Click += new System.EventHandler(this.LongLessBtn_Click);
            // 
            // ReceiverDepotCard
            // 
            this.ReceiverDepotCard.BackColor = System.Drawing.Color.White;
            this.ReceiverDepotCard.BorderRadius = 15;
            this.ReceiverDepotCard.BottomSahddow = true;
            this.ReceiverDepotCard.color = System.Drawing.Color.LightSkyBlue;
            this.ReceiverDepotCard.Controls.Add(this.addedPiecesLbl);
            this.ReceiverDepotCard.Controls.Add(this.label4);
            this.ReceiverDepotCard.Controls.Add(this.label1);
            this.ReceiverDepotCard.Controls.Add(this.descriptionLbl);
            this.ReceiverDepotCard.Controls.Add(this.quantityLbl);
            this.ReceiverDepotCard.Controls.Add(this.brandLbl);
            this.ReceiverDepotCard.Controls.Add(this.BarcodeLbl);
            this.ReceiverDepotCard.Controls.Add(this.productPicture);
            this.ReceiverDepotCard.LeftSahddow = true;
            this.ReceiverDepotCard.Location = new System.Drawing.Point(56, 194);
            this.ReceiverDepotCard.Name = "ReceiverDepotCard";
            this.ReceiverDepotCard.RightSahddow = false;
            this.ReceiverDepotCard.ShadowDepth = 50;
            this.ReceiverDepotCard.Size = new System.Drawing.Size(605, 283);
            this.ReceiverDepotCard.TabIndex = 0;
            // 
            // addedPiecesLbl
            // 
            this.addedPiecesLbl.AutoEllipsis = true;
            this.addedPiecesLbl.BackColor = System.Drawing.Color.Transparent;
            this.addedPiecesLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedPiecesLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.addedPiecesLbl.Location = new System.Drawing.Point(158, 182);
            this.addedPiecesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addedPiecesLbl.Name = "addedPiecesLbl";
            this.addedPiecesLbl.Size = new System.Drawing.Size(194, 21);
            this.addedPiecesLbl.TabIndex = 39;
            this.addedPiecesLbl.Text = "+50";
            this.addedPiecesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addedPiecesLbl.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(407, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 74);
            this.label4.TabIndex = 40;
            this.label4.Text = "Sin Imagen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoEllipsis = true;
            this.descriptionLbl.Location = new System.Drawing.Point(11, 74);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(341, 30);
            this.descriptionLbl.TabIndex = 2;
            this.descriptionLbl.Text = "Nombre del Producto";
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(5, 203);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(349, 49);
            this.quantityLbl.TabIndex = 5;
            this.quantityLbl.Text = "Cantidad";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoEllipsis = true;
            this.brandLbl.Location = new System.Drawing.Point(11, 118);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(341, 30);
            this.brandLbl.TabIndex = 4;
            this.brandLbl.Text = "Marca";
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoEllipsis = true;
            this.BarcodeLbl.Location = new System.Drawing.Point(11, 30);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(341, 30);
            this.BarcodeLbl.TabIndex = 3;
            this.BarcodeLbl.Text = "Código de Barras";
            // 
            // productPicture
            // 
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPicture.Location = new System.Drawing.Point(358, 30);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(235, 222);
            this.productPicture.TabIndex = 6;
            this.productPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(1013, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Piezas por caja:";
            // 
            // ProductLbl
            // 
            this.ProductLbl.AutoSize = true;
            this.ProductLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProductLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.ProductLbl.Location = new System.Drawing.Point(2, 0);
            this.ProductLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(47, 15);
            this.ProductLbl.TabIndex = 36;
            this.ProductLbl.Text = "Buscar:";
            this.ProductLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 37);
            this.panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1379, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductLbl);
            this.panel2.Controls.Add(this.ProductTxt);
            this.panel2.Location = new System.Drawing.Point(426, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 60);
            this.panel2.TabIndex = 38;
            // 
            // ProductTxt
            // 
            this.ProductTxt.AutoSize = true;
            this.ProductTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.ProductTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ProductTxt.HintForeColor = System.Drawing.Color.Empty;
            this.ProductTxt.HintText = "Buscar productó o código de barras";
            this.ProductTxt.isPassword = false;
            this.ProductTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ProductTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.ProductTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ProductTxt.LineThickness = 1;
            this.ProductTxt.Location = new System.Drawing.Point(0, 16);
            this.ProductTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(559, 44);
            this.ProductTxt.TabIndex = 0;
            this.ProductTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductTxt.OnValueChanged += new System.EventHandler(this.ProductTxt_OnValueChanged);
            this.ProductTxt.Enter += new System.EventHandler(this.ProductTxt_Enter);
            this.ProductTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyDown);
            this.ProductTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductTxt_KeyPress);
            this.ProductTxt.Leave += new System.EventHandler(this.ProductTxt_Leave);
            // 
            // receiverCombo
            // 
            this.receiverCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receiverCombo.FormattingEnabled = true;
            this.receiverCombo.Location = new System.Drawing.Point(56, 124);
            this.receiverCombo.Name = "receiverCombo";
            this.receiverCombo.Size = new System.Drawing.Size(605, 36);
            this.receiverCombo.TabIndex = 39;
            this.receiverCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DonatingCombo
            // 
            this.DonatingCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonatingCombo.FormattingEnabled = true;
            this.DonatingCombo.Location = new System.Drawing.Point(749, 124);
            this.DonatingCombo.Name = "DonatingCombo";
            this.DonatingCombo.Size = new System.Drawing.Size(605, 36);
            this.DonatingCombo.TabIndex = 41;
            this.DonatingCombo.SelectedIndexChanged += new System.EventHandler(this.ToCombo_SelectedIndexChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(703, 195);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(5, 282);
            this.bunifuSeparator1.TabIndex = 42;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.ActiveBorderThickness = 1;
            this.AcceptBtn.ActiveCornerRadius = 20;
            this.AcceptBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.AcceptBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AcceptBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.AcceptBtn.BackColor = System.Drawing.Color.White;
            this.AcceptBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AcceptBtn.BackgroundImage")));
            this.AcceptBtn.ButtonText = "Aceptar";
            this.AcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AcceptBtn.IdleBorderThickness = 1;
            this.AcceptBtn.IdleCornerRadius = 20;
            this.AcceptBtn.IdleFillColor = System.Drawing.Color.White;
            this.AcceptBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.AcceptBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.AcceptBtn.Location = new System.Drawing.Point(615, 504);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(181, 41);
            this.AcceptBtn.TabIndex = 44;
            this.AcceptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // switchDepotsBtn
            // 
            this.switchDepotsBtn.BackColor = System.Drawing.Color.Transparent;
            this.switchDepotsBtn.Image = global::POS.Properties.Resources._switch;
            this.switchDepotsBtn.ImageActive = null;
            this.switchDepotsBtn.Location = new System.Drawing.Point(679, 118);
            this.switchDepotsBtn.Name = "switchDepotsBtn";
            this.switchDepotsBtn.Size = new System.Drawing.Size(53, 53);
            this.switchDepotsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.switchDepotsBtn.TabIndex = 43;
            this.switchDepotsBtn.TabStop = false;
            this.switchDepotsBtn.Zoom = 10;
            this.switchDepotsBtn.Click += new System.EventHandler(this.switchDepotsBtn_Click);
            // 
            // piecesPerCaseTxt
            // 
            this.piecesPerCaseTxt.Location = new System.Drawing.Point(1234, 68);
            this.piecesPerCaseTxt.Name = "piecesPerCaseTxt";
            this.piecesPerCaseTxt.Size = new System.Drawing.Size(120, 37);
            this.piecesPerCaseTxt.TabIndex = 45;
            this.piecesPerCaseTxt.TextChanged += new System.EventHandler(this.piecesPerCaseTxt_TextChanged);
            this.piecesPerCaseTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piecesPerCaseTxt_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Panel_productos_Transferir_Inventario_entre_bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1411, 557);
            this.Controls.Add(this.piecesPerCaseTxt);
            this.Controls.Add(this.switchDepotsBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.DonatingCombo);
            this.Controls.Add(this.receiverCombo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReceiverDepotCard);
            this.Controls.Add(this.DonatingDepotCard);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Panel_productos_Transferir_Inventario_entre_bodegas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir Productos entre Bodegas | Point of Sale";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_productos_Transferir_Inventario_entre_bodegas_Paint);
            this.DonatingDepotCard.ResumeLayout(false);
            this.DonatingDepotCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ReceiverDepotCard.ResumeLayout(false);
            this.ReceiverDepotCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDepotsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards DonatingDepotCard;
        private Bunifu.Framework.UI.BunifuCards ReceiverDepotCard;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label ProductLbl;
        private System.Windows.Forms.Label boxQuantLbl;
        private System.Windows.Forms.Label pieceQuantLbl;
        private System.Windows.Forms.Label addedPiecesLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductTxt;
        private System.Windows.Forms.ComboBox receiverCombo;
        private System.Windows.Forms.ComboBox DonatingCombo;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button LongMoreBtn;
        private System.Windows.Forms.Button LongLessBtn;
        private System.Windows.Forms.Button MoreBtn;
        private System.Windows.Forms.Button LessBtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 AcceptBtn;
        private Bunifu.Framework.UI.BunifuImageButton switchDepotsBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.TextBox piecesPerCaseTxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}