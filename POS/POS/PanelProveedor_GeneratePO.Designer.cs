using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProveedor_GeneratePO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProveedor_GeneratePO));
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.NextBtn = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(29, 94);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(276, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "Llegada de la Mercancía:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Orden de Compra";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(342, 87);
            this.DatePicker.MinDate = new System.DateTime(2019, 8, 26, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(328, 33);
            this.DatePicker.TabIndex = 1;
            this.DatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatePicker_KeyDown);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.Location = new System.Drawing.Point(240, 151);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(218, 33);
            this.NextBtn.TabIndex = 3;
            this.NextBtn.Text = "Siguiente";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Textbox
            // 
            this.errorProvider.SetError(this.Textbox, "El valor ingresado supera el Total de la compra.");
            this.Textbox.Location = new System.Drawing.Point(342, 87);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(328, 33);
            this.Textbox.TabIndex = 4;
            this.Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_KeyDown);
            this.Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(670, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PanelProveedor_GeneratePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 206);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PanelProveedor_GeneratePO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Orden de Compra | Point of Sale";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelProveedor_GeneratePO_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.TextBox Textbox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}