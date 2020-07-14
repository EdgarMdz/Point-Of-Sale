using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProveedoresNuevoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProveedoresNuevoProveedor));
            this.MessageLbl = new System.Windows.Forms.Label();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.MessageLbl.Location = new System.Drawing.Point(62, 77);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(528, 38);
            this.MessageLbl.TabIndex = 0;
            this.MessageLbl.Text = "¿Tiene algún adeudo pendiente?";
            // 
            // InputTxt
            // 
            this.InputTxt.ForeColor = System.Drawing.Color.Black;
            this.InputTxt.Location = new System.Drawing.Point(157, 143);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(385, 47);
            this.InputTxt.TabIndex = 1;
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            this.InputTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTxt_KeyPress);
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Location = new System.Drawing.Point(257, 217);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(184, 58);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "Siguiente";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(669, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelProveedoresNuevoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 298);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.MessageLbl);
            this.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "PanelProveedoresNuevoProveedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Proveedor | Point of Sale";
            this.Load += new System.EventHandler(this.PanelProveedoresNuevoProveedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button OkBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}