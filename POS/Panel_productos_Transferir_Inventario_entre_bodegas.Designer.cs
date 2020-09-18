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
            this.label7 = new System.Windows.Forms.Label();
            this.pieceQuantLbl = new System.Windows.Forms.Label();
            this.boxQuantLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiverDepotCard = new Bunifu.Framework.UI.BunifuCards();
            this.quantityPcsLbl = new System.Windows.Forms.Label();
            this.addedPiecesLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.brandLbl = new System.Windows.Forms.Label();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.receiverCombo = new System.Windows.Forms.ComboBox();
            this.DonatingCombo = new System.Windows.Forms.ComboBox();
            this.switchDepotsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.costLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DonatingDepotCard.SuspendLayout();
            this.ReceiverDepotCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDepotsBtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DonatingDepotCard
            // 
            this.DonatingDepotCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.DonatingDepotCard.BorderRadius = 15;
            this.DonatingDepotCard.BottomSahddow = false;
            this.DonatingDepotCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.DonatingDepotCard.Controls.Add(this.label7);
            this.DonatingDepotCard.Controls.Add(this.pieceQuantLbl);
            this.DonatingDepotCard.Controls.Add(this.boxQuantLbl);
            this.DonatingDepotCard.Controls.Add(this.label2);
            this.DonatingDepotCard.LeftSahddow = false;
            this.DonatingDepotCard.Location = new System.Drawing.Point(782, 494);
            this.DonatingDepotCard.Name = "DonatingDepotCard";
            this.DonatingDepotCard.RightSahddow = false;
            this.DonatingDepotCard.ShadowDepth = 50;
            this.DonatingDepotCard.Size = new System.Drawing.Size(605, 205);
            this.DonatingDepotCard.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(409, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "-50";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // pieceQuantLbl
            // 
            this.pieceQuantLbl.AutoEllipsis = true;
            this.pieceQuantLbl.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.pieceQuantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pieceQuantLbl.Location = new System.Drawing.Point(95, 140);
            this.pieceQuantLbl.Name = "pieceQuantLbl";
            this.pieceQuantLbl.Size = new System.Drawing.Size(415, 47);
            this.pieceQuantLbl.TabIndex = 14;
            this.pieceQuantLbl.Text = "40 piezas";
            this.pieceQuantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxQuantLbl
            // 
            this.boxQuantLbl.AutoEllipsis = true;
            this.boxQuantLbl.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.boxQuantLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(238, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock";
            // 
            // ReceiverDepotCard
            // 
            this.ReceiverDepotCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ReceiverDepotCard.BorderRadius = 15;
            this.ReceiverDepotCard.BottomSahddow = false;
            this.ReceiverDepotCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ReceiverDepotCard.Controls.Add(this.quantityPcsLbl);
            this.ReceiverDepotCard.Controls.Add(this.addedPiecesLbl);
            this.ReceiverDepotCard.Controls.Add(this.label1);
            this.ReceiverDepotCard.Controls.Add(this.quantityLbl);
            this.ReceiverDepotCard.LeftSahddow = false;
            this.ReceiverDepotCard.Location = new System.Drawing.Point(53, 494);
            this.ReceiverDepotCard.Name = "ReceiverDepotCard";
            this.ReceiverDepotCard.RightSahddow = false;
            this.ReceiverDepotCard.ShadowDepth = 50;
            this.ReceiverDepotCard.Size = new System.Drawing.Size(575, 205);
            this.ReceiverDepotCard.TabIndex = 0;
            // 
            // quantityPcsLbl
            // 
            this.quantityPcsLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityPcsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.quantityPcsLbl.Location = new System.Drawing.Point(113, 138);
            this.quantityPcsLbl.Name = "quantityPcsLbl";
            this.quantityPcsLbl.Size = new System.Drawing.Size(349, 49);
            this.quantityPcsLbl.TabIndex = 40;
            this.quantityPcsLbl.Text = "Cantidad";
            this.quantityPcsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addedPiecesLbl
            // 
            this.addedPiecesLbl.AutoEllipsis = true;
            this.addedPiecesLbl.BackColor = System.Drawing.Color.Transparent;
            this.addedPiecesLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedPiecesLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.addedPiecesLbl.Location = new System.Drawing.Point(369, 64);
            this.addedPiecesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addedPiecesLbl.Name = "addedPiecesLbl";
            this.addedPiecesLbl.Size = new System.Drawing.Size(194, 21);
            this.addedPiecesLbl.TabIndex = 39;
            this.addedPiecesLbl.Text = "+50";
            this.addedPiecesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addedPiecesLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLbl
            // 
            this.quantityLbl.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.quantityLbl.Location = new System.Drawing.Point(113, 75);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(349, 49);
            this.quantityLbl.TabIndex = 5;
            this.quantityLbl.Text = "Cantidad";
            this.quantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 74);
            this.label4.TabIndex = 40;
            this.label4.Text = "Sin\r\nImagen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.Color.Transparent;
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPicture.Location = new System.Drawing.Point(0, 0);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(173, 183);
            this.productPicture.TabIndex = 6;
            this.productPicture.TabStop = false;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoEllipsis = true;
            this.descriptionLbl.Location = new System.Drawing.Point(3, 21);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(341, 30);
            this.descriptionLbl.TabIndex = 2;
            this.descriptionLbl.Text = "Nombre del Producto";
            // 
            // brandLbl
            // 
            this.brandLbl.AutoEllipsis = true;
            this.brandLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.Location = new System.Drawing.Point(3, 64);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(341, 30);
            this.brandLbl.TabIndex = 4;
            this.brandLbl.Text = "Marca";
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoEllipsis = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.Location = new System.Drawing.Point(3, 107);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(341, 30);
            this.BarcodeLbl.TabIndex = 3;
            this.BarcodeLbl.Text = "Código de Barras";
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 30);
            this.panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1396, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ProductLbl);
            this.panel2.Controls.Add(this.ProductTxt);
            this.panel2.Location = new System.Drawing.Point(311, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 60);
            this.panel2.TabIndex = 0;
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
            this.ProductTxt.Size = new System.Drawing.Size(818, 44);
            this.ProductTxt.TabIndex = 0;
            this.ProductTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductTxt.OnValueChanged += new System.EventHandler(this.ProductTxt_OnValueChanged);
            this.ProductTxt.Enter += new System.EventHandler(this.ProductTxt_Enter);
            this.ProductTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyDown);
            this.ProductTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductTxt_KeyPress);
            this.ProductTxt.Leave += new System.EventHandler(this.ProductTxt_Leave);
            // 
            // receiverCombo
            // 
            this.receiverCombo.BackColor = System.Drawing.SystemColors.Control;
            this.receiverCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receiverCombo.FormattingEnabled = true;
            this.receiverCombo.Location = new System.Drawing.Point(54, 442);
            this.receiverCombo.Name = "receiverCombo";
            this.receiverCombo.Size = new System.Drawing.Size(575, 36);
            this.receiverCombo.TabIndex = 1;
            this.receiverCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DonatingCombo
            // 
            this.DonatingCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DonatingCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DonatingCombo.FormattingEnabled = true;
            this.DonatingCombo.Location = new System.Drawing.Point(782, 442);
            this.DonatingCombo.Name = "DonatingCombo";
            this.DonatingCombo.Size = new System.Drawing.Size(605, 36);
            this.DonatingCombo.TabIndex = 2;
            this.DonatingCombo.SelectedIndexChanged += new System.EventHandler(this.ToCombo_SelectedIndexChanged);
            // 
            // switchDepotsBtn
            // 
            this.switchDepotsBtn.BackColor = System.Drawing.Color.Transparent;
            this.switchDepotsBtn.Image = global::POS.Properties.Resources._switch;
            this.switchDepotsBtn.ImageActive = null;
            this.switchDepotsBtn.Location = new System.Drawing.Point(679, 433);
            this.switchDepotsBtn.Name = "switchDepotsBtn";
            this.switchDepotsBtn.Size = new System.Drawing.Size(53, 53);
            this.switchDepotsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.switchDepotsBtn.TabIndex = 43;
            this.switchDepotsBtn.TabStop = false;
            this.switchDepotsBtn.Zoom = 10;
            this.switchDepotsBtn.Click += new System.EventHandler(this.switchDepotsBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.costLbl);
            this.panel3.Controls.Add(this.BarcodeLbl);
            this.panel3.Controls.Add(this.descriptionLbl);
            this.panel3.Controls.Add(this.brandLbl);
            this.panel3.Location = new System.Drawing.Point(337, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 201);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.productPicture);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(584, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 183);
            this.panel4.TabIndex = 42;
            // 
            // costLbl
            // 
            this.costLbl.AutoEllipsis = true;
            this.costLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLbl.Location = new System.Drawing.Point(3, 150);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(341, 30);
            this.costLbl.TabIndex = 41;
            this.costLbl.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(959, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 30);
            this.label5.TabIndex = 47;
            this.label5.Text = "Bodega de Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(254, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 30);
            this.label6.TabIndex = 48;
            this.label6.Text = "Bodega Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(602, 765);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 33);
            this.label8.TabIndex = 49;
            this.label8.Text = "Piezas a Transferir";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(620, 813);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 41);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Transferir";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(557, 890);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(326, 41);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // Panel_productos_Transferir_Inventario_entre_bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 970);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.switchDepotsBtn);
            this.Controls.Add(this.DonatingCombo);
            this.Controls.Add(this.receiverCombo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReceiverDepotCard);
            this.Controls.Add(this.DonatingDepotCard);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Panel_productos_Transferir_Inventario_entre_bodegas";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir Productos entre Bodegas | Point of Sale";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_productos_Transferir_Inventario_entre_bodegas_Paint_1);
            this.DonatingDepotCard.ResumeLayout(false);
            this.DonatingDepotCard.PerformLayout();
            this.ReceiverDepotCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchDepotsBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards DonatingDepotCard;
        private Bunifu.Framework.UI.BunifuCards ReceiverDepotCard;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private Bunifu.Framework.UI.BunifuImageButton switchDepotsBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Panel panel3;
        private Label costLbl;
        private Label label7;
        private Label quantityPcsLbl;
        private TextBox textBox1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}