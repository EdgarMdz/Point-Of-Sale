using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.okBtn = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.incorrectInfoLbl = new System.Windows.Forms.Label();
            this.upperLeftHiddenBtn = new System.Windows.Forms.Button();
            this.bottomRightHiddenBtn = new System.Windows.Forms.Button();
            this.bottomLeftHiddenBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.panel4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.userTxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(48, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(390, 52);
            this.panel4.TabIndex = 0;
            // 
            // userTxt
            // 
            this.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(5, 9);
            this.userTxt.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(380, 34);
            this.userTxt.TabIndex = 0;
            this.userTxt.Enter += new System.EventHandler(this.userTxt_Enter);
            this.userTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userPassTxt_KeyDown);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.okBtn;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(74, 426);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(352, 58);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Aceptar";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.passwordTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(48, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(390, 52);
            this.panel2.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(5, 9);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.Size = new System.Drawing.Size(380, 34);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Enter += new System.EventHandler(this.passwordTxt_Enter);
            this.passwordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userPassTxt_KeyDown);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 35;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.panel3);
            this.bunifuGradientPanel1.Controls.Add(this.incorrectInfoLbl);
            this.bunifuGradientPanel1.Controls.Add(this.okBtn);
            this.bunifuGradientPanel1.Controls.Add(this.upperLeftHiddenBtn);
            this.bunifuGradientPanel1.Controls.Add(this.bottomRightHiddenBtn);
            this.bunifuGradientPanel1.Controls.Add(this.bottomLeftHiddenBtn);
            this.bunifuGradientPanel1.Controls.Add(this.panel5);
            this.bunifuGradientPanel1.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(501, 519);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(31, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 52);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(31, 202);
            this.panel3.Margin = new System.Windows.Forms.Padding(15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 52);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::POS.Properties.Resources.changeUserBtn1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // incorrectInfoLbl
            // 
            this.incorrectInfoLbl.AutoSize = true;
            this.incorrectInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.incorrectInfoLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectInfoLbl.ForeColor = System.Drawing.Color.White;
            this.incorrectInfoLbl.Location = new System.Drawing.Point(162, 375);
            this.incorrectInfoLbl.Name = "incorrectInfoLbl";
            this.incorrectInfoLbl.Size = new System.Drawing.Size(150, 19);
            this.incorrectInfoLbl.TabIndex = 6;
            this.incorrectInfoLbl.Text = "* Datos Incorrectos";
            this.incorrectInfoLbl.Visible = false;
            // 
            // upperLeftHiddenBtn
            // 
            this.upperLeftHiddenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.upperLeftHiddenBtn.FlatAppearance.BorderSize = 0;
            this.upperLeftHiddenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upperLeftHiddenBtn.Location = new System.Drawing.Point(0, 0);
            this.upperLeftHiddenBtn.Name = "upperLeftHiddenBtn";
            this.upperLeftHiddenBtn.Size = new System.Drawing.Size(43, 35);
            this.upperLeftHiddenBtn.TabIndex = 9;
            this.upperLeftHiddenBtn.UseVisualStyleBackColor = false;
            this.upperLeftHiddenBtn.Click += new System.EventHandler(this.upperLeftHiddenBtn_Click);
            this.upperLeftHiddenBtn.Enter += new System.EventHandler(this.HiddenBtn_Enter);
            // 
            // bottomRightHiddenBtn
            // 
            this.bottomRightHiddenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bottomRightHiddenBtn.FlatAppearance.BorderSize = 0;
            this.bottomRightHiddenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomRightHiddenBtn.Location = new System.Drawing.Point(458, 484);
            this.bottomRightHiddenBtn.Name = "bottomRightHiddenBtn";
            this.bottomRightHiddenBtn.Size = new System.Drawing.Size(43, 35);
            this.bottomRightHiddenBtn.TabIndex = 10;
            this.bottomRightHiddenBtn.UseVisualStyleBackColor = false;
            this.bottomRightHiddenBtn.Click += new System.EventHandler(this.bottomRightHiddenBtn_Click);
            this.bottomRightHiddenBtn.Enter += new System.EventHandler(this.HiddenBtn_Enter);
            this.bottomRightHiddenBtn.MouseEnter += new System.EventHandler(this.bottomRightHiddenBtn_MouseEnter);
            // 
            // bottomLeftHiddenBtn
            // 
            this.bottomLeftHiddenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bottomLeftHiddenBtn.FlatAppearance.BorderSize = 0;
            this.bottomLeftHiddenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomLeftHiddenBtn.Location = new System.Drawing.Point(-1, 481);
            this.bottomLeftHiddenBtn.Name = "bottomLeftHiddenBtn";
            this.bottomLeftHiddenBtn.Size = new System.Drawing.Size(43, 35);
            this.bottomLeftHiddenBtn.TabIndex = 8;
            this.bottomLeftHiddenBtn.UseVisualStyleBackColor = false;
            this.bottomLeftHiddenBtn.Click += new System.EventHandler(this.bottomLeftHiddenBtn_Click);
            this.bottomLeftHiddenBtn.Enter += new System.EventHandler(this.HiddenBtn_Enter);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(48, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 147);
            this.panel5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar Sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.SizeChanged += new System.EventHandler(this.label1_SizeChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(467, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(22, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 519);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form_Login";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión | Point of Sale";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button upperLeftHiddenBtn;
        private System.Windows.Forms.Button bottomRightHiddenBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button bottomLeftHiddenBtn;
        private System.Windows.Forms.Label incorrectInfoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private TextBox userTxt;
    }
}