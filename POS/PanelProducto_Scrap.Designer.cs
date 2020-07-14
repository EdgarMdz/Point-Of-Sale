using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProducto_Scrap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProducto_Scrap));
            this.label1 = new System.Windows.Forms.Label();
            this.stockLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NoPictureLbl = new System.Windows.Forms.Label();
            this.scrapLbl = new System.Windows.Forms.Label();
            this.SearchTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlusOnePieceBtn = new System.Windows.Forms.Button();
            this.PlusOneTenthPieceBtn = new System.Windows.Forms.Button();
            this.MinusOneTenthPieceBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MinusOnePieceBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brandLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.searchBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.OkBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // stockLbl
            // 
            this.stockLbl.AutoEllipsis = true;
            this.stockLbl.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(29, 147);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(546, 98);
            this.stockLbl.TabIndex = 14;
            this.stockLbl.Text = "Stock";
            this.stockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock";
            // 
            // NoPictureLbl
            // 
            this.NoPictureLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoPictureLbl.Location = new System.Drawing.Point(427, 70);
            this.NoPictureLbl.Name = "NoPictureLbl";
            this.NoPictureLbl.Size = new System.Drawing.Size(100, 60);
            this.NoPictureLbl.TabIndex = 9;
            this.NoPictureLbl.Text = "Sin Imagen";
            this.NoPictureLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrapLbl
            // 
            this.scrapLbl.AutoEllipsis = true;
            this.scrapLbl.ForeColor = System.Drawing.Color.Tomato;
            this.scrapLbl.Location = new System.Drawing.Point(100, 123);
            this.scrapLbl.Name = "scrapLbl";
            this.scrapLbl.Size = new System.Drawing.Size(475, 24);
            this.scrapLbl.TabIndex = 15;
            this.scrapLbl.Text = "-15000 piezas";
            this.scrapLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scrapLbl.Visible = false;
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.White;
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTxt.HintForeColor = System.Drawing.Color.Empty;
            this.SearchTxt.HintText = "Buscar producto por nombre o codigo de barras";
            this.SearchTxt.isPassword = false;
            this.SearchTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.SearchTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.SearchTxt.LineThickness = 1;
            this.SearchTxt.Location = new System.Drawing.Point(105, 41);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(456, 32);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(5, 100);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(605, 593);
            this.bunifuCards1.TabIndex = 2;
            this.bunifuCards1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PlusOnePieceBtn);
            this.panel2.Controls.Add(this.PlusOneTenthPieceBtn);
            this.panel2.Controls.Add(this.MinusOneTenthPieceBtn);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.scrapLbl);
            this.panel2.Controls.Add(this.stockLbl);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MinusOnePieceBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 393);
            this.panel2.TabIndex = 15;
            // 
            // PlusOnePieceBtn
            // 
            this.PlusOnePieceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.PlusOnePieceBtn.FlatAppearance.BorderSize = 0;
            this.PlusOnePieceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusOnePieceBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusOnePieceBtn.ForeColor = System.Drawing.Color.White;
            this.PlusOnePieceBtn.Location = new System.Drawing.Point(535, 308);
            this.PlusOnePieceBtn.Name = "PlusOnePieceBtn";
            this.PlusOnePieceBtn.Size = new System.Drawing.Size(58, 58);
            this.PlusOnePieceBtn.TabIndex = 11;
            this.PlusOnePieceBtn.Text = "++";
            this.PlusOnePieceBtn.UseVisualStyleBackColor = false;
            this.PlusOnePieceBtn.Click += new System.EventHandler(this.PlusOnePieceBtn_Click);
            // 
            // PlusOneTenthPieceBtn
            // 
            this.PlusOneTenthPieceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.PlusOneTenthPieceBtn.FlatAppearance.BorderSize = 0;
            this.PlusOneTenthPieceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusOneTenthPieceBtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusOneTenthPieceBtn.ForeColor = System.Drawing.Color.White;
            this.PlusOneTenthPieceBtn.Location = new System.Drawing.Point(460, 308);
            this.PlusOneTenthPieceBtn.Name = "PlusOneTenthPieceBtn";
            this.PlusOneTenthPieceBtn.Size = new System.Drawing.Size(58, 58);
            this.PlusOneTenthPieceBtn.TabIndex = 10;
            this.PlusOneTenthPieceBtn.Text = "+";
            this.PlusOneTenthPieceBtn.UseVisualStyleBackColor = false;
            this.PlusOneTenthPieceBtn.Click += new System.EventHandler(this.PlusOneTenthPieceBtn_Click);
            // 
            // MinusOneTenthPieceBtn
            // 
            this.MinusOneTenthPieceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.MinusOneTenthPieceBtn.FlatAppearance.BorderSize = 0;
            this.MinusOneTenthPieceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusOneTenthPieceBtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusOneTenthPieceBtn.ForeColor = System.Drawing.Color.White;
            this.MinusOneTenthPieceBtn.Location = new System.Drawing.Point(86, 311);
            this.MinusOneTenthPieceBtn.Name = "MinusOneTenthPieceBtn";
            this.MinusOneTenthPieceBtn.Size = new System.Drawing.Size(58, 58);
            this.MinusOneTenthPieceBtn.TabIndex = 12;
            this.MinusOneTenthPieceBtn.Text = "-";
            this.MinusOneTenthPieceBtn.UseVisualStyleBackColor = false;
            this.MinusOneTenthPieceBtn.Click += new System.EventHandler(this.MinusOneTenthPieceBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(155, 324);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(294, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MinusOnePieceBtn
            // 
            this.MinusOnePieceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.MinusOnePieceBtn.FlatAppearance.BorderSize = 0;
            this.MinusOnePieceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusOnePieceBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusOnePieceBtn.ForeColor = System.Drawing.Color.White;
            this.MinusOnePieceBtn.Location = new System.Drawing.Point(11, 310);
            this.MinusOnePieceBtn.Name = "MinusOnePieceBtn";
            this.MinusOnePieceBtn.Size = new System.Drawing.Size(58, 58);
            this.MinusOnePieceBtn.TabIndex = 13;
            this.MinusOnePieceBtn.Text = "- -";
            this.MinusOnePieceBtn.UseVisualStyleBackColor = false;
            this.MinusOnePieceBtn.Click += new System.EventHandler(this.MinusOnePieceBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.brandLbl);
            this.panel1.Controls.Add(this.productLbl);
            this.panel1.Controls.Add(this.barcodeLbl);
            this.panel1.Controls.Add(this.NoPictureLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 200);
            this.panel1.TabIndex = 14;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoEllipsis = true;
            this.brandLbl.Location = new System.Drawing.Point(24, 142);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(314, 24);
            this.brandLbl.TabIndex = 5;
            this.brandLbl.Text = "Marca";
            this.brandLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productLbl
            // 
            this.productLbl.AutoEllipsis = true;
            this.productLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLbl.Location = new System.Drawing.Point(24, 77);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(313, 46);
            this.productLbl.TabIndex = 3;
            this.productLbl.Text = "Producto";
            this.productLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoEllipsis = true;
            this.barcodeLbl.Location = new System.Drawing.Point(23, 34);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(314, 24);
            this.barcodeLbl.TabIndex = 4;
            this.barcodeLbl.Text = "Código de Barras";
            this.barcodeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 184);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.Location = new System.Drawing.Point(226, 89);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(162, 43);
            this.NextBtn.TabIndex = 15;
            this.NextBtn.Text = "Aceptar";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.Image = global::POS.Properties.Resources.search;
            this.searchBtn.ImageActive = null;
            this.searchBtn.Location = new System.Drawing.Point(568, 38);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 37);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBtn.TabIndex = 10;
            this.searchBtn.TabStop = false;
            this.searchBtn.Visible = false;
            this.searchBtn.Zoom = 10;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.ActiveBorderThickness = 1;
            this.OkBtn.ActiveCornerRadius = 20;
            this.OkBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.OkBtn.ActiveForecolor = System.Drawing.Color.White;
            this.OkBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.OkBtn.BackColor = System.Drawing.Color.White;
            this.OkBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkBtn.BackgroundImage")));
            this.OkBtn.ButtonText = "Aceptar";
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.OkBtn.IdleBorderThickness = 1;
            this.OkBtn.IdleCornerRadius = 20;
            this.OkBtn.IdleFillColor = System.Drawing.Color.White;
            this.OkBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.OkBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.OkBtn.Location = new System.Drawing.Point(217, 704);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(5);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(181, 41);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(586, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PanelProducto_Scrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 755);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PanelProducto_Scrap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrap | Point of Sale";
            this.Resize += new System.EventHandler(this.PanelProducto_Scrap_Resize);
            this.bunifuCards1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NoPictureLbl;
        private System.Windows.Forms.Label scrapLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchTxt;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button MinusOnePieceBtn;
        private System.Windows.Forms.Button NextBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 OkBtn;
        private Bunifu.Framework.UI.BunifuImageButton searchBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PlusOnePieceBtn;
        private System.Windows.Forms.Button PlusOneTenthPieceBtn;
        private System.Windows.Forms.Button MinusOneTenthPieceBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}