using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProveedorPromos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProveedorPromos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AddRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteRowBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.PromoGridView = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowBtn)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.AddRowBtn);
            this.bunifuGradientPanel1.Controls.Add(this.EditRowBtn);
            this.bunifuGradientPanel1.Controls.Add(this.DeleteRowBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(109, 593);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddRowBtn.Image = global::POS.Properties.Resources.plus;
            this.AddRowBtn.ImageActive = null;
            this.AddRowBtn.Location = new System.Drawing.Point(30, 99);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(50, 50);
            this.AddRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddRowBtn.TabIndex = 4;
            this.AddRowBtn.TabStop = false;
            this.AddRowBtn.Zoom = 10;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // EditRowBtn
            // 
            this.EditRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditRowBtn.Image = global::POS.Properties.Resources.edit;
            this.EditRowBtn.ImageActive = null;
            this.EditRowBtn.Location = new System.Drawing.Point(28, 271);
            this.EditRowBtn.Name = "EditRowBtn";
            this.EditRowBtn.Size = new System.Drawing.Size(50, 50);
            this.EditRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditRowBtn.TabIndex = 5;
            this.EditRowBtn.TabStop = false;
            this.EditRowBtn.Zoom = 10;
            this.EditRowBtn.Click += new System.EventHandler(this.EditRowBtn_Click);
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRowBtn.Image = global::POS.Properties.Resources.delete;
            this.DeleteRowBtn.ImageActive = null;
            this.DeleteRowBtn.Location = new System.Drawing.Point(28, 443);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(50, 50);
            this.DeleteRowBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteRowBtn.TabIndex = 6;
            this.DeleteRowBtn.TabStop = false;
            this.DeleteRowBtn.Zoom = 10;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel2.Controls.Add(this.PromoGridView);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(109, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(917, 593);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::POS.Properties.Resources.close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(887, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(19, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PromoGridView
            // 
            this.PromoGridView.AllowUserToAddRows = false;
            this.PromoGridView.AllowUserToDeleteRows = false;
            this.PromoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PromoGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PromoGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PromoGridView.BackgroundColor = System.Drawing.Color.White;
            this.PromoGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PromoGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PromoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PromoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PromoGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PromoGridView.EnableHeadersVisualStyles = false;
            this.PromoGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.PromoGridView.Location = new System.Drawing.Point(0, 36);
            this.PromoGridView.Name = "PromoGridView";
            this.PromoGridView.ReadOnly = true;
            this.PromoGridView.RowHeadersVisible = false;
            this.PromoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PromoGridView.Size = new System.Drawing.Size(917, 557);
            this.PromoGridView.TabIndex = 18;
            this.PromoGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PromoGridView_CellContentDoubleClick);
            // 
            // PanelProveedorPromos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 593);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PanelProveedorPromos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ofertas | Point of Sale";
            this.Load += new System.EventHandler(this.PanelProveedorPromos_Load_1);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowBtn)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton AddRowBtn;
        private Bunifu.Framework.UI.BunifuImageButton EditRowBtn;
        private Bunifu.Framework.UI.BunifuImageButton DeleteRowBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.DataGridView PromoGridView;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}