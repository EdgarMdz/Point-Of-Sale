using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelProveedoresNuevoRecordatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelProveedoresNuevoRecordatorio));
            this.StartTimeCombo = new System.Windows.Forms.ComboBox();
            this.EndTimeCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SundayLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.SaturdayLabel = new System.Windows.Forms.Label();
            this.ThursdayLabel = new System.Windows.Forms.Label();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EventNameTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.HeaderTitlePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteButtonTip = new System.Windows.Forms.ToolTip(this.components);
            this.OKBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.HeaderTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // StartTimeCombo
            // 
            this.StartTimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTimeCombo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.StartTimeCombo.FormattingEnabled = true;
            this.StartTimeCombo.Location = new System.Drawing.Point(111, 153);
            this.StartTimeCombo.Name = "StartTimeCombo";
            this.StartTimeCombo.Size = new System.Drawing.Size(176, 31);
            this.StartTimeCombo.TabIndex = 2;
            this.StartTimeCombo.SelectedIndexChanged += new System.EventHandler(this.StartTimeCombo_SelectedIndexChanged);
            // 
            // EndTimeCombo
            // 
            this.EndTimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTimeCombo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.EndTimeCombo.FormattingEnabled = true;
            this.EndTimeCombo.Location = new System.Drawing.Point(382, 153);
            this.EndTimeCombo.Name = "EndTimeCombo";
            this.EndTimeCombo.Size = new System.Drawing.Size(176, 31);
            this.EndTimeCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Repetir:";
            // 
            // SundayLabel
            // 
            this.SundayLabel.AutoSize = true;
            this.SundayLabel.BackColor = System.Drawing.Color.Transparent;
            this.SundayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SundayLabel.Location = new System.Drawing.Point(23, 246);
            this.SundayLabel.Name = "SundayLabel";
            this.SundayLabel.Size = new System.Drawing.Size(41, 39);
            this.SundayLabel.TabIndex = 20;
            this.SundayLabel.Text = "D";
            this.SundayLabel.Click += new System.EventHandler(this.SundayLabel_Click);
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.BackColor = System.Drawing.Color.Transparent;
            this.FridayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.FridayLabel.Location = new System.Drawing.Point(434, 246);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(40, 39);
            this.FridayLabel.TabIndex = 20;
            this.FridayLabel.Text = "V";
            this.FridayLabel.Click += new System.EventHandler(this.FridayLabel_Click);
            // 
            // SaturdayLabel
            // 
            this.SaturdayLabel.AutoSize = true;
            this.SaturdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.SaturdayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SaturdayLabel.Location = new System.Drawing.Point(511, 246);
            this.SaturdayLabel.Name = "SaturdayLabel";
            this.SaturdayLabel.Size = new System.Drawing.Size(33, 39);
            this.SaturdayLabel.TabIndex = 20;
            this.SaturdayLabel.Text = "S";
            this.SaturdayLabel.Click += new System.EventHandler(this.SaturdayLabel_Click);
            // 
            // ThursdayLabel
            // 
            this.ThursdayLabel.AutoSize = true;
            this.ThursdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThursdayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ThursdayLabel.Location = new System.Drawing.Point(365, 246);
            this.ThursdayLabel.Name = "ThursdayLabel";
            this.ThursdayLabel.Size = new System.Drawing.Size(32, 39);
            this.ThursdayLabel.TabIndex = 20;
            this.ThursdayLabel.Text = "J";
            this.ThursdayLabel.Click += new System.EventHandler(this.ThursdayLabel_Click);
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.WednesdayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.WednesdayLabel.Location = new System.Drawing.Point(275, 246);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(53, 39);
            this.WednesdayLabel.TabIndex = 20;
            this.WednesdayLabel.Text = "Mi";
            this.WednesdayLabel.Click += new System.EventHandler(this.WednesdayLabel_Click);
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.TuesdayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TuesdayLabel.Location = new System.Drawing.Point(170, 246);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(68, 39);
            this.TuesdayLabel.TabIndex = 20;
            this.TuesdayLabel.Text = "Ma";
            this.TuesdayLabel.Click += new System.EventHandler(this.TuesdayLabel_Click);
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.BackColor = System.Drawing.Color.Transparent;
            this.MondayLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.MondayLabel.Location = new System.Drawing.Point(101, 246);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(32, 39);
            this.MondayLabel.TabIndex = 20;
            this.MondayLabel.Text = "L";
            this.MondayLabel.Click += new System.EventHandler(this.MondayLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha:";
            // 
            // EventNameTxt
            // 
            this.EventNameTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.EventNameTxt.Location = new System.Drawing.Point(114, 64);
            this.EventNameTxt.Name = "EventNameTxt";
            this.EventNameTxt.Size = new System.Drawing.Size(444, 31);
            this.EventNameTxt.TabIndex = 0;
            this.EventNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OKBtn_KeyDown);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(114, 108);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(444, 31);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OKBtn_KeyDown);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.HeaderTitlePanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // HeaderTitlePanel
            // 
            this.HeaderTitlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderTitlePanel.BackgroundImage")));
            this.HeaderTitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderTitlePanel.Controls.Add(this.label1);
            this.HeaderTitlePanel.Controls.Add(this.closeBtn);
            this.HeaderTitlePanel.Controls.Add(this.DeleteButton);
            this.HeaderTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderTitlePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.HeaderTitlePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.HeaderTitlePanel.GradientTopLeft = System.Drawing.Color.White;
            this.HeaderTitlePanel.GradientTopRight = System.Drawing.Color.DimGray;
            this.HeaderTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderTitlePanel.Name = "HeaderTitlePanel";
            this.HeaderTitlePanel.Quality = 10;
            this.HeaderTitlePanel.Size = new System.Drawing.Size(582, 48);
            this.HeaderTitlePanel.TabIndex = 1;
            this.HeaderTitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderTitlePanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nuevo Recordatorio";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(542, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 27);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 22;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Image = global::POS.Properties.Resources.delete;
            this.DeleteButton.ImageActive = null;
            this.DeleteButton.Location = new System.Drawing.Point(473, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(38, 42);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.TabStop = false;
            this.DeleteButtonTip.SetToolTip(this.DeleteButton, "Borrar Recordatorio");
            this.DeleteButton.Visible = false;
            this.DeleteButton.Zoom = 10;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.ActiveBorderThickness = 1;
            this.OKBtn.ActiveCornerRadius = 20;
            this.OKBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.OKBtn.ActiveForecolor = System.Drawing.Color.White;
            this.OKBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.OKBtn.BackColor = System.Drawing.Color.White;
            this.OKBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OKBtn.BackgroundImage")));
            this.OKBtn.ButtonText = "Aceptar";
            this.OKBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.OKBtn.IdleBorderThickness = 2;
            this.OKBtn.IdleCornerRadius = 20;
            this.OKBtn.IdleFillColor = System.Drawing.Color.White;
            this.OKBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OKBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OKBtn.Location = new System.Drawing.Point(174, 305);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(235, 47);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            this.OKBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OKBtn_KeyDown);
            // 
            // PanelProveedoresNuevoRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 367);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.EventNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.ThursdayLabel);
            this.Controls.Add(this.SaturdayLabel);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.SundayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeaderTitlePanel);
            this.Controls.Add(this.EndTimeCombo);
            this.Controls.Add(this.StartTimeCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelProveedoresNuevoRecordatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordatorio | Point of Sale";
            this.Load += new System.EventHandler(this.PanelProveedoresNuevoRecordatorio_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProveedoresNuevoRecordatorio_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OKBtn_KeyDown);
            this.HeaderTitlePanel.ResumeLayout(false);
            this.HeaderTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox StartTimeCombo;
        private System.Windows.Forms.ComboBox EndTimeCombo;
        private Bunifu.Framework.UI.BunifuGradientPanel HeaderTitlePanel;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton DeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SundayLabel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Label SaturdayLabel;
        private System.Windows.Forms.Label ThursdayLabel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EventNameTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 OKBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolTip DeleteButtonTip;
        private Label label1;
    }
}