using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class FormPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagar));
            this.CashLbl = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.paymentTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CashTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // CashLbl
            // 
            this.CashLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CashLbl.AutoSize = true;
            this.CashLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.CashLbl.Location = new System.Drawing.Point(11, 186);
            this.CashLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CashLbl.Name = "CashLbl";
            this.CashLbl.Size = new System.Drawing.Size(160, 41);
            this.CashLbl.TabIndex = 0;
            this.CashLbl.Text = "Efectivo:";
            this.CashLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CashLbl.Visible = false;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.Label2.Location = new System.Drawing.Point(11, 48);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(329, 41);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Cantidad a Pagar:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.TotalLbl.Location = new System.Drawing.Point(609, 48);
            this.TotalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(108, 41);
            this.TotalLbl.TabIndex = 0;
            this.TotalLbl.Text = "$0.00";
            this.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentLbl
            // 
            this.paymentLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.paymentLbl.Location = new System.Drawing.Point(11, 117);
            this.paymentLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(345, 41);
            this.paymentLbl.TabIndex = 0;
            this.paymentLbl.Text = "Cantidad a Abonar";
            this.paymentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OKBtn.AutoSize = true;
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.OKBtn.FlatAppearance.BorderSize = 0;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.OKBtn.ForeColor = System.Drawing.Color.White;
            this.OKBtn.Location = new System.Drawing.Point(132, 211);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(202, 37);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "Aceptar";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            this.OKBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelBtn_KeyDown);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(477, 211);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(202, 37);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            this.CancelBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelBtn_KeyDown);
            // 
            // paymentTxt
            // 
            this.paymentTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paymentTxt.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.paymentTxt.HintForeColor = System.Drawing.Color.Empty;
            this.paymentTxt.HintText = "";
            this.paymentTxt.isPassword = false;
            this.paymentTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.paymentTxt.LineIdleColor = System.Drawing.Color.Transparent;
            this.paymentTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.paymentTxt.LineThickness = 3;
            this.paymentTxt.Location = new System.Drawing.Point(505, 96);
            this.paymentTxt.Margin = new System.Windows.Forms.Padding(6);
            this.paymentTxt.Name = "paymentTxt";
            this.paymentTxt.Size = new System.Drawing.Size(212, 69);
            this.paymentTxt.TabIndex = 1;
            this.paymentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.paymentTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelBtn_KeyDown);
            this.paymentTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.paymentTxt.Leave += new System.EventHandler(this.textBox2_Leave_1);
            // 
            // CashTxt
            // 
            this.CashTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CashTxt.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.CashTxt.HintForeColor = System.Drawing.Color.Empty;
            this.CashTxt.HintText = "";
            this.CashTxt.isPassword = false;
            this.CashTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.CashTxt.LineIdleColor = System.Drawing.Color.Transparent;
            this.CashTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CashTxt.LineThickness = 3;
            this.CashTxt.Location = new System.Drawing.Point(505, 158);
            this.CashTxt.Margin = new System.Windows.Forms.Padding(10);
            this.CashTxt.Name = "CashTxt";
            this.CashTxt.Size = new System.Drawing.Size(212, 69);
            this.CashTxt.TabIndex = 2;
            this.CashTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CashTxt.Visible = false;
            this.CashTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelBtn_KeyDown);
            this.CashTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // FormPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 286);
            this.Controls.Add(this.CashTxt);
            this.Controls.Add(this.paymentTxt);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.CashLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPagar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de Transacción | Point of Sale";
            this.Load += new System.EventHandler(this.FormPagar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPagar_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.Label CashLbl;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label paymentLbl;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox paymentTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CashTxt;
    }
}