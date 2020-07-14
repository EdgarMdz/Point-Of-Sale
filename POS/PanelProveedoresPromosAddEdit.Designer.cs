using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProveedoresPromosAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProveedoresPromosAddEdit));
            this.TitleLbl = new System.Windows.Forms.Label();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinQuantLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.BarCodeTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.NotesTxt = new System.Windows.Forms.TextBox();
            this.MinQuantTxt = new System.Windows.Forms.TextBox();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.NextStepPanel = new System.Windows.Forms.Panel();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.NextBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OKBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NextStepPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(233, 30);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(63, 32);
            this.TitleLbl.TabIndex = 19;
            this.TitleLbl.Text = "Title";
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Location = new System.Drawing.Point(12, 99);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(195, 25);
            this.BarcodeLbl.TabIndex = 20;
            this.BarcodeLbl.Text = "Código de Barras:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(12, 154);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(138, 25);
            this.DescriptionLbl.TabIndex = 21;
            this.DescriptionLbl.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Notas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Fecha de Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vigencia";
            // 
            // MinQuantLbl
            // 
            this.MinQuantLbl.AutoSize = true;
            this.MinQuantLbl.Location = new System.Drawing.Point(3, 57);
            this.MinQuantLbl.Name = "MinQuantLbl";
            this.MinQuantLbl.Size = new System.Drawing.Size(319, 25);
            this.MinQuantLbl.TabIndex = 35;
            this.MinQuantLbl.Text = "Cantidad Mínima de Compra:";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(3, 6);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(87, 25);
            this.CostLbl.TabIndex = 44;
            this.CostLbl.Text = "Precio: ";
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(3, 186);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(175, 25);
            this.StartDateLbl.TabIndex = 38;
            this.StartDateLbl.Text = "Fecha de Inicio:";
            // 
            // BarCodeTxt
            // 
            this.BarCodeTxt.Location = new System.Drawing.Point(226, 96);
            this.BarCodeTxt.Name = "BarCodeTxt";
            this.BarCodeTxt.Size = new System.Drawing.Size(300, 33);
            this.BarCodeTxt.TabIndex = 28;
            this.BarCodeTxt.TextChanged += new System.EventHandler(this.descriptionTxt_TextChanged);
            this.BarCodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarCodeTxt_KeyDown);
            this.BarCodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarCodeTxt_KeyPress);
            this.BarCodeTxt.Leave += new System.EventHandler(this.BarCodeTxt_Leave);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(164, 151);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(362, 33);
            this.descriptionTxt.TabIndex = 29;
            this.descriptionTxt.TextChanged += new System.EventHandler(this.descriptionTxt_TextChanged);
            this.descriptionTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descriptionTxt_KeyDown);
            this.descriptionTxt.Leave += new System.EventHandler(this.descriptionTxt_Leave);
            // 
            // NotesTxt
            // 
            this.NotesTxt.Location = new System.Drawing.Point(91, 333);
            this.NotesTxt.Name = "NotesTxt";
            this.NotesTxt.Size = new System.Drawing.Size(419, 33);
            this.NotesTxt.TabIndex = 43;
            // 
            // MinQuantTxt
            // 
            this.MinQuantTxt.Location = new System.Drawing.Point(353, 54);
            this.MinQuantTxt.Name = "MinQuantTxt";
            this.MinQuantTxt.Size = new System.Drawing.Size(157, 33);
            this.MinQuantTxt.TabIndex = 40;
            this.MinQuantTxt.Text = "0.00";
            this.MinQuantTxt.TextChanged += new System.EventHandler(this.MinQuantTxt_TextChanged);
            this.MinQuantTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTxt_MinQuantTxt_KeyPress);
            // 
            // CostTxt
            // 
            this.CostTxt.Location = new System.Drawing.Point(101, 3);
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.Size = new System.Drawing.Size(242, 33);
            this.CostTxt.TabIndex = 45;
            this.CostTxt.Text = "0.00";
            this.CostTxt.TextChanged += new System.EventHandler(this.CostTxt_TextChanged);
            this.CostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTxt_MinQuantTxt_KeyPress);
            // 
            // NextStepPanel
            // 
            this.NextStepPanel.Controls.Add(this.EndDatePicker);
            this.NextStepPanel.Controls.Add(this.StartDateLbl);
            this.NextStepPanel.Controls.Add(this.StartDatePicker);
            this.NextStepPanel.Controls.Add(this.label1);
            this.NextStepPanel.Controls.Add(this.label5);
            this.NextStepPanel.Controls.Add(this.label3);
            this.NextStepPanel.Controls.Add(this.MinQuantLbl);
            this.NextStepPanel.Controls.Add(this.CostTxt);
            this.NextStepPanel.Controls.Add(this.CostLbl);
            this.NextStepPanel.Controls.Add(this.MinQuantTxt);
            this.NextStepPanel.Controls.Add(this.NotesTxt);
            this.NextStepPanel.Location = new System.Drawing.Point(16, 209);
            this.NextStepPanel.Name = "NextStepPanel";
            this.NextStepPanel.Size = new System.Drawing.Size(522, 381);
            this.NextStepPanel.TabIndex = 37;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(168, 240);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(342, 33);
            this.EndDatePicker.TabIndex = 41;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(197, 180);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(313, 33);
            this.StartDatePicker.TabIndex = 36;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(506, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.ActiveBorderThickness = 1;
            this.NextBtn.ActiveCornerRadius = 20;
            this.NextBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.NextBtn.ActiveForecolor = System.Drawing.Color.White;
            this.NextBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.NextBtn.BackColor = System.Drawing.Color.White;
            this.NextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextBtn.BackgroundImage")));
            this.NextBtn.ButtonText = "Siguiente";
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.NextBtn.IdleBorderThickness = 1;
            this.NextBtn.IdleCornerRadius = 20;
            this.NextBtn.IdleFillColor = System.Drawing.Color.White;
            this.NextBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.NextBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.NextBtn.Location = new System.Drawing.Point(178, 192);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(5);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(181, 41);
            this.NextBtn.TabIndex = 35;
            this.NextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.ActiveBorderThickness = 1;
            this.OKBtn.ActiveCornerRadius = 20;
            this.OKBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.OKBtn.ActiveForecolor = System.Drawing.Color.White;
            this.OKBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.OKBtn.BackColor = System.Drawing.Color.White;
            this.OKBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OKBtn.BackgroundImage")));
            this.OKBtn.ButtonText = "Aceptar";
            this.OKBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.OKBtn.IdleBorderThickness = 1;
            this.OKBtn.IdleCornerRadius = 20;
            this.OKBtn.IdleFillColor = System.Drawing.Color.White;
            this.OKBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.OKBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.OKBtn.Location = new System.Drawing.Point(178, 598);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(5);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(181, 41);
            this.OKBtn.TabIndex = 36;
            this.OKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // PanelProveedoresPromosAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 649);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.NextStepPanel);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.BarCodeTxt);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.BarcodeLbl);
            this.Controls.Add(this.TitleLbl);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PanelProveedoresPromosAddEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ofertas | Point of Sale";
            this.NextStepPanel.ResumeLayout(false);
            this.NextStepPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinQuantLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.TextBox BarCodeTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox NotesTxt;
        private System.Windows.Forms.TextBox MinQuantTxt;
        private System.Windows.Forms.TextBox CostTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 OKBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 NextBtn;
        private System.Windows.Forms.Panel NextStepPanel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}