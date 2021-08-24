using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class FormAgregarPrecioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarPrecioCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.PrecioFinalLbl = new System.Windows.Forms.Label();
            this.PrecioLbl = new System.Windows.Forms.Label();
            this.piecesCasesLbl = new System.Windows.Forms.Label();
            this.CantMinTxt = new System.Windows.Forms.TextBox();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.DescuentoTxt = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.NextStepBtn = new System.Windows.Forms.Button();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaleByPieceRadio = new System.Windows.Forms.RadioButton();
            this.SaleByCaseRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(54, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio:";
            this.label1.Visible = false;
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.BackColor = System.Drawing.Color.White;
            this.barcodeLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.barcodeLbl.Location = new System.Drawing.Point(29, 53);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(224, 28);
            this.barcodeLbl.TabIndex = 2;
            this.barcodeLbl.Text = "Código de Barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(10, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad Mínima:";
            this.label3.Visible = false;
            // 
            // ProductLbl
            // 
            this.ProductLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductLbl.AutoEllipsis = true;
            this.ProductLbl.BackColor = System.Drawing.Color.White;
            this.ProductLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLbl.ForeColor = System.Drawing.Color.Lime;
            this.ProductLbl.Location = new System.Drawing.Point(-2, 116);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(579, 53);
            this.ProductLbl.TabIndex = 9;
            this.ProductLbl.Text = "Producto";
            this.ProductLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductLbl.Visible = false;
            this.ProductLbl.TextChanged += new System.EventHandler(this.ProductLbl_TextChanged);
            // 
            // PrecioFinalLbl
            // 
            this.PrecioFinalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecioFinalLbl.AutoSize = true;
            this.PrecioFinalLbl.BackColor = System.Drawing.Color.White;
            this.PrecioFinalLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioFinalLbl.ForeColor = System.Drawing.Color.Gray;
            this.PrecioFinalLbl.Location = new System.Drawing.Point(426, 199);
            this.PrecioFinalLbl.Name = "PrecioFinalLbl";
            this.PrecioFinalLbl.Size = new System.Drawing.Size(92, 28);
            this.PrecioFinalLbl.TabIndex = 11;
            this.PrecioFinalLbl.Text = "= $0.00";
            this.PrecioFinalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrecioFinalLbl.Visible = false;
            // 
            // PrecioLbl
            // 
            this.PrecioLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecioLbl.AutoSize = true;
            this.PrecioLbl.BackColor = System.Drawing.Color.White;
            this.PrecioLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLbl.ForeColor = System.Drawing.Color.Gray;
            this.PrecioLbl.Location = new System.Drawing.Point(162, 199);
            this.PrecioLbl.Name = "PrecioLbl";
            this.PrecioLbl.Size = new System.Drawing.Size(88, 28);
            this.PrecioLbl.TabIndex = 10;
            this.PrecioLbl.Text = "$0.00 -";
            this.PrecioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrecioLbl.Visible = false;
            // 
            // piecesCasesLbl
            // 
            this.piecesCasesLbl.AutoSize = true;
            this.piecesCasesLbl.BackColor = System.Drawing.Color.White;
            this.piecesCasesLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piecesCasesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.piecesCasesLbl.Location = new System.Drawing.Point(405, 415);
            this.piecesCasesLbl.Name = "piecesCasesLbl";
            this.piecesCasesLbl.Size = new System.Drawing.Size(162, 28);
            this.piecesCasesLbl.TabIndex = 35;
            this.piecesCasesLbl.Text = "piezas/cajas";
            // 
            // CantMinTxt
            // 
            this.CantMinTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantMinTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.CantMinTxt.Location = new System.Drawing.Point(262, 411);
            this.CantMinTxt.Name = "CantMinTxt";
            this.CantMinTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CantMinTxt.Size = new System.Drawing.Size(137, 38);
            this.CantMinTxt.TabIndex = 5;
            this.CantMinTxt.Text = "1";
            this.CantMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CantMinTxt.Visible = false;
            this.CantMinTxt.Click += new System.EventHandler(this.CantMinTxt_Click);
            this.CantMinTxt.Enter += new System.EventHandler(this.CantMinTxt_Enter);
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BarcodeTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BarcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.BarcodeTxt.Location = new System.Drawing.Point(278, 53);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(273, 38);
            this.BarcodeTxt.TabIndex = 3;
            this.BarcodeTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.BarcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductTxt_KeyDown);
            this.BarcodeTxt.Leave += new System.EventHandler(this.ProductTxt_Leave);
            // 
            // DescuentoTxt
            // 
            this.DescuentoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.DescuentoTxt.Location = new System.Drawing.Point(262, 195);
            this.DescuentoTxt.Name = "DescuentoTxt";
            this.DescuentoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescuentoTxt.Size = new System.Drawing.Size(158, 38);
            this.DescuentoTxt.TabIndex = 1;
            this.DescuentoTxt.Text = "0";
            this.DescuentoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DescuentoTxt.Visible = false;
            this.DescuentoTxt.Click += new System.EventHandler(this.DescuentoTxt_Click);
            this.DescuentoTxt.TextChanged += new System.EventHandler(this.DescuentoTxt_TextChanged);
            this.DescuentoTxt.Enter += new System.EventHandler(this.DescuentoTxt_Enter);
            this.DescuentoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTxt_KeyPress);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.OKBtn.FlatAppearance.BorderSize = 0;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.White;
            this.OKBtn.Location = new System.Drawing.Point(220, 472);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(135, 52);
            this.OKBtn.TabIndex = 6;
            this.OKBtn.Text = "Aceptar";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Visible = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // NextStepBtn
            // 
            this.NextStepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.NextStepBtn.FlatAppearance.BorderSize = 0;
            this.NextStepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextStepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextStepBtn.ForeColor = System.Drawing.Color.White;
            this.NextStepBtn.Location = new System.Drawing.Point(223, 116);
            this.NextStepBtn.Name = "NextStepBtn";
            this.NextStepBtn.Size = new System.Drawing.Size(135, 52);
            this.NextStepBtn.TabIndex = 33;
            this.NextStepBtn.Text = "Siguiente";
            this.NextStepBtn.UseVisualStyleBackColor = false;
            this.NextStepBtn.Click += new System.EventHandler(this.NextStepBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(548, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 34;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 15;
            this.FormElipse.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaleByPieceRadio);
            this.groupBox1.Controls.Add(this.SaleByCaseRadio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 100);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta por:";
            // 
            // SaleByPieceRadio
            // 
            this.SaleByPieceRadio.AutoSize = true;
            this.SaleByPieceRadio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleByPieceRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.SaleByPieceRadio.Location = new System.Drawing.Point(130, 38);
            this.SaleByPieceRadio.Name = "SaleByPieceRadio";
            this.SaleByPieceRadio.Size = new System.Drawing.Size(93, 29);
            this.SaleByPieceRadio.TabIndex = 36;
            this.SaleByPieceRadio.TabStop = true;
            this.SaleByPieceRadio.Text = "Piezas";
            this.SaleByPieceRadio.UseVisualStyleBackColor = true;
            this.SaleByPieceRadio.CheckedChanged += new System.EventHandler(this.SaleByPieceRadio_CheckedChanged);
            // 
            // SaleByCaseRadio
            // 
            this.SaleByCaseRadio.AutoSize = true;
            this.SaleByCaseRadio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleByCaseRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.SaleByCaseRadio.Location = new System.Drawing.Point(337, 38);
            this.SaleByCaseRadio.Name = "SaleByCaseRadio";
            this.SaleByCaseRadio.Size = new System.Drawing.Size(88, 29);
            this.SaleByCaseRadio.TabIndex = 37;
            this.SaleByCaseRadio.TabStop = true;
            this.SaleByCaseRadio.Text = "Cajas";
            this.SaleByCaseRadio.UseVisualStyleBackColor = true;
            this.SaleByCaseRadio.CheckedChanged += new System.EventHandler(this.SaleByCaseRadio_CheckedChanged);
            // 
            // FormAgregarPrecioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.NextStepBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.DescuentoTxt);
            this.Controls.Add(this.BarcodeTxt);
            this.Controls.Add(this.CantMinTxt);
            this.Controls.Add(this.piecesCasesLbl);
            this.Controls.Add(this.PrecioFinalLbl);
            this.Controls.Add(this.PrecioLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductLbl);
            this.Controls.Add(this.barcodeLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarPrecioCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Descuento al Cliente | Point of Sale";
            this.Load += new System.EventHandler(this.FormAgregarPrecioCliente_Load);
            this.SizeChanged += new System.EventHandler(this.FormAgregarPrecioCliente_SizeChanged_1);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductLbl;
        private System.Windows.Forms.Label PrecioFinalLbl;
        private System.Windows.Forms.Label PrecioLbl;
        private System.Windows.Forms.Label piecesCasesLbl;
        private System.Windows.Forms.TextBox CantMinTxt;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.TextBox DescuentoTxt;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button NextStepBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SaleByPieceRadio;
        private System.Windows.Forms.RadioButton SaleByCaseRadio;
    }
}