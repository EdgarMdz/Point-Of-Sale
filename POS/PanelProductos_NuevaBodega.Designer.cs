using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProductos_NuevaBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProductos_NuevaBodega));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepotLbl = new System.Windows.Forms.Label();
            this.DepotTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.okBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DepotLbl);
            this.panel1.Controls.Add(this.DepotTxt);
            this.panel1.Location = new System.Drawing.Point(99, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 63);
            this.panel1.TabIndex = 0;
            // 
            // DepotLbl
            // 
            this.DepotLbl.AutoSize = true;
            this.DepotLbl.BackColor = System.Drawing.Color.Transparent;
            this.DepotLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepotLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.DepotLbl.Location = new System.Drawing.Point(2, 1);
            this.DepotLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepotLbl.Name = "DepotLbl";
            this.DepotLbl.Size = new System.Drawing.Size(128, 15);
            this.DepotLbl.TabIndex = 36;
            this.DepotLbl.Text = "Nombre de la Bodega:";
            this.DepotLbl.Visible = false;
            // 
            // DepotTxt
            // 
            this.DepotTxt.AutoSize = true;
            this.DepotTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepotTxt.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.DepotTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DepotTxt.HintForeColor = System.Drawing.Color.Empty;
            this.DepotTxt.HintText = "Nombre de la Bodega";
            this.DepotTxt.isPassword = false;
            this.DepotTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DepotTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.DepotTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.DepotTxt.LineThickness = 1;
            this.DepotTxt.Location = new System.Drawing.Point(0, 19);
            this.DepotTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DepotTxt.Name = "DepotTxt";
            this.DepotTxt.Size = new System.Drawing.Size(752, 44);
            this.DepotTxt.TabIndex = 0;
            this.DepotTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepotTxt.OnValueChanged += new System.EventHandler(this.DepotTxt_OnValueChanged);
            this.DepotTxt.Enter += new System.EventHandler(this.DepotTxt_Enter);
            this.DepotTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepotTxt_KeyDown);
            this.DepotTxt.Leave += new System.EventHandler(this.DepotTxt_Leave);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(912, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 40;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 45);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.okBtn);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 154);
            this.panel4.TabIndex = 46;
            // 
            // okBtn
            // 
            this.okBtn.ActiveBorderThickness = 1;
            this.okBtn.ActiveCornerRadius = 20;
            this.okBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.okBtn.ActiveForecolor = System.Drawing.Color.White;
            this.okBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.okBtn.BackColor = System.Drawing.Color.White;
            this.okBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okBtn.BackgroundImage")));
            this.okBtn.ButtonText = "Aceptar";
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.okBtn.IdleBorderThickness = 1;
            this.okBtn.IdleCornerRadius = 20;
            this.okBtn.IdleFillColor = System.Drawing.Color.White;
            this.okBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.okBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.okBtn.Location = new System.Drawing.Point(385, 111);
            this.okBtn.Margin = new System.Windows.Forms.Padding(5);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(181, 41);
            this.okBtn.TabIndex = 1;
            this.okBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelProductos_NuevaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 205);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelProductos_NuevaBodega";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Bodega | Point of Sale";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProductos_NuevaBodega_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DepotLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DepotTxt;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Panel panel3;
        private Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 okBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}