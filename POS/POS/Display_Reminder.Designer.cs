using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Display_Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_Reminder));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.scheduleLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.lateLbl = new System.Windows.Forms.Label();
            this.comapanyNameLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.scheduleLbl);
            this.bunifuGradientPanel1.Controls.Add(this.messageLbl);
            this.bunifuGradientPanel1.Controls.Add(this.lateLbl);
            this.bunifuGradientPanel1.Controls.Add(this.comapanyNameLbl);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(418, 190);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.MouseEnter += new System.EventHandler(this.bunifuGradientPanel1_MouseEnter);
            this.bunifuGradientPanel1.MouseLeave += new System.EventHandler(this.bunifuGradientPanel1_MouseLeave);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(391, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(15, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.bunifuImageButton1.MouseEnter += new System.EventHandler(this.bunifuGradientPanel1_MouseEnter);
            // 
            // scheduleLbl
            // 
            this.scheduleLbl.AutoSize = true;
            this.scheduleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.scheduleLbl.Location = new System.Drawing.Point(54, 101);
            this.scheduleLbl.Name = "scheduleLbl";
            this.scheduleLbl.Size = new System.Drawing.Size(304, 32);
            this.scheduleLbl.TabIndex = 3;
            this.scheduleLbl.Text = "12:15 P.M. - 15:00 P.M.";
            this.scheduleLbl.MouseEnter += new System.EventHandler(this.bunifuGradientPanel1_MouseEnter);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoEllipsis = true;
            this.messageLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.Color.White;
            this.messageLbl.Location = new System.Drawing.Point(56, 48);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(339, 53);
            this.messageLbl.TabIndex = 2;
            this.messageLbl.Text = "Visita";
            this.messageLbl.MouseEnter += new System.EventHandler(this.bunifuGradientPanel1_MouseEnter);
            // 
            // lateLbl
            // 
            this.lateLbl.AutoSize = true;
            this.lateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateLbl.ForeColor = System.Drawing.Color.Tomato;
            this.lateLbl.Location = new System.Drawing.Point(56, 144);
            this.lateLbl.Name = "lateLbl";
            this.lateLbl.Size = new System.Drawing.Size(105, 22);
            this.lateLbl.TabIndex = 4;
            this.lateLbl.Text = "Retrasado";
            this.lateLbl.Visible = false;
            this.lateLbl.MouseEnter += new System.EventHandler(this.bunifuGradientPanel1_MouseEnter);
            // 
            // comapanyNameLbl
            // 
            this.comapanyNameLbl.AutoSize = true;
            this.comapanyNameLbl.ForeColor = System.Drawing.Color.White;
            this.comapanyNameLbl.Location = new System.Drawing.Point(54, 12);
            this.comapanyNameLbl.Name = "comapanyNameLbl";
            this.comapanyNameLbl.Size = new System.Drawing.Size(69, 32);
            this.comapanyNameLbl.TabIndex = 1;
            this.comapanyNameLbl.Text = "Lala";
            this.comapanyNameLbl.MouseEnter += new System.EventHandler(this.bunifuGradientPanel1_MouseEnter);
            // 
            // Display_Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 190);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Display_Reminder";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recordatorio | Point of Sale";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Display_Reminder_Shown);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label comapanyNameLbl;
        private System.Windows.Forms.Label lateLbl;
        private System.Windows.Forms.Label scheduleLbl;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}