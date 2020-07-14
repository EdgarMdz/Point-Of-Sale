using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelPoveedoresNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPoveedoresNuevoProducto));
            this.bunifuCustomLabel1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel8 = new System.Windows.Forms.Label();
            this.MinStockLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel7 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new System.Windows.Forms.Label();
            this.MarcaLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel5 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel4 = new System.Windows.Forms.Label();
            this.StockLbl = new System.Windows.Forms.Label();
            this.BarCodeTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.piecesperCaseTxt = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(133, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(291, 38);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Agregar Producto";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(3, 57);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(240, 30);
            this.bunifuCustomLabel8.TabIndex = 23;
            this.bunifuCustomLabel8.Text = "Precio de Compra:";
            // 
            // MinStockLbl
            // 
            this.MinStockLbl.AutoSize = true;
            this.MinStockLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinStockLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.MinStockLbl.Location = new System.Drawing.Point(190, 228);
            this.MinStockLbl.Name = "MinStockLbl";
            this.MinStockLbl.Size = new System.Drawing.Size(128, 30);
            this.MinStockLbl.TabIndex = 22;
            this.MinStockLbl.Text = "Stock Min";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 107);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(226, 30);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Código de Barras:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(3, 228);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(181, 30);
            this.bunifuCustomLabel7.TabIndex = 21;
            this.bunifuCustomLabel7.Text = "Stock Mínimo:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 169);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(128, 30);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Producto:";
            // 
            // MarcaLbl
            // 
            this.MarcaLbl.AutoSize = true;
            this.MarcaLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.MarcaLbl.Location = new System.Drawing.Point(118, 9);
            this.MarcaLbl.Name = "MarcaLbl";
            this.MarcaLbl.Size = new System.Drawing.Size(91, 30);
            this.MarcaLbl.TabIndex = 18;
            this.MarcaLbl.Text = "Marca";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 112);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(202, 30);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Piezas por Caja:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 167);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(169, 30);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Stock Actual:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(98, 30);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Marca:";
            // 
            // StockLbl
            // 
            this.StockLbl.AutoSize = true;
            this.StockLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.StockLbl.Location = new System.Drawing.Point(190, 167);
            this.StockLbl.Name = "StockLbl";
            this.StockLbl.Size = new System.Drawing.Size(77, 30);
            this.StockLbl.TabIndex = 20;
            this.StockLbl.Text = "Stock";
            // 
            // BarCodeTxt
            // 
            this.BarCodeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BarCodeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BarCodeTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.BarCodeTxt.Location = new System.Drawing.Point(244, 104);
            this.BarCodeTxt.Name = "BarCodeTxt";
            this.BarCodeTxt.Size = new System.Drawing.Size(301, 37);
            this.BarCodeTxt.TabIndex = 3;
            this.BarCodeTxt.TextChanged += new System.EventHandler(this.BarCodeTxt_TextChanged);
            this.BarCodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.BarCodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarCodeTxt_KeyPress);
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DescriptionTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DescriptionTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.DescriptionTxt.Location = new System.Drawing.Point(146, 166);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(399, 37);
            this.DescriptionTxt.TabIndex = 4;
            this.DescriptionTxt.TextChanged += new System.EventHandler(this.DescriptionTxt_TextChanged);
            this.DescriptionTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescriptionTxt_KeyDown);
            // 
            // precioTxt
            // 
            this.precioTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.precioTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.precioTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.precioTxt.Location = new System.Drawing.Point(240, 50);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(292, 37);
            this.precioTxt.TabIndex = 24;
            // 
            // piecesperCaseTxt
            // 
            this.piecesperCaseTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.piecesperCaseTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.piecesperCaseTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piecesperCaseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.piecesperCaseTxt.Location = new System.Drawing.Point(231, 105);
            this.piecesperCaseTxt.Name = "piecesperCaseTxt";
            this.piecesperCaseTxt.Size = new System.Drawing.Size(292, 37);
            this.piecesperCaseTxt.TabIndex = 27;
            this.piecesperCaseTxt.Text = "1.00";
            this.piecesperCaseTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piecesperCaseTxt_KeyPress);
            this.piecesperCaseTxt.Leave += new System.EventHandler(this.piecesperCaseTxt_Leave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.AcceptBtn);
            this.panel.Controls.Add(this.piecesperCaseTxt);
            this.panel.Controls.Add(this.bunifuCustomLabel5);
            this.panel.Controls.Add(this.precioTxt);
            this.panel.Controls.Add(this.bunifuCustomLabel8);
            this.panel.Controls.Add(this.bunifuCustomLabel4);
            this.panel.Controls.Add(this.MarcaLbl);
            this.panel.Controls.Add(this.MinStockLbl);
            this.panel.Controls.Add(this.bunifuCustomLabel6);
            this.panel.Controls.Add(this.bunifuCustomLabel7);
            this.panel.Controls.Add(this.StockLbl);
            this.panel.Location = new System.Drawing.Point(12, 220);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(552, 376);
            this.panel.TabIndex = 18;
            this.panel.Visible = false;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.AcceptBtn.FlatAppearance.BorderSize = 0;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AcceptBtn.ForeColor = System.Drawing.Color.White;
            this.AcceptBtn.Location = new System.Drawing.Point(157, 272);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(242, 61);
            this.AcceptBtn.TabIndex = 28;
            this.AcceptBtn.Text = "Aceptar";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(169, 229);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(242, 61);
            this.NextButton.TabIndex = 19;
            this.NextButton.Text = "Siguiente";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(551, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 20;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PanelPoveedoresNuevoProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 297);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.BarCodeTxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelPoveedoresNuevoProducto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.PanelPoveedoresNuevoProducto_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bunifuCustomLabel1;
        private System.Windows.Forms.Label bunifuCustomLabel8;
        private System.Windows.Forms.Label MinStockLbl;
        private System.Windows.Forms.Label bunifuCustomLabel2;
        private System.Windows.Forms.Label bunifuCustomLabel7;
        private System.Windows.Forms.Label bunifuCustomLabel3;
        private System.Windows.Forms.Label MarcaLbl;
        private System.Windows.Forms.Label bunifuCustomLabel5;
        private System.Windows.Forms.Label bunifuCustomLabel6;
        private System.Windows.Forms.Label bunifuCustomLabel4;
        private System.Windows.Forms.Label StockLbl;
        private System.Windows.Forms.TextBox BarCodeTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.TextBox piecesperCaseTxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button AcceptBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}