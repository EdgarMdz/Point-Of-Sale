using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_Inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Inicio));
            this.WindowSizeControlPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.agendaContainerPanel = new System.Windows.Forms.Panel();
            this.AgendaEventsPanel = new System.Windows.Forms.Panel();
            this.agendaBottomPanel = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.goFurtherBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.goBackBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AgendaHeaderPanel = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.agendaBackgrountPictureBox = new System.Windows.Forms.PictureBox();
            this.startShiftBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endShiftBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WindowSizeControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.agendaContainerPanel.SuspendLayout();
            this.AgendaEventsPanel.SuspendLayout();
            this.agendaBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goFurtherBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goBackBtn)).BeginInit();
            this.AgendaHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBackgrountPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowSizeControlPanel
            // 
            this.WindowSizeControlPanel.BackColor = System.Drawing.Color.White;
            this.WindowSizeControlPanel.Controls.Add(this.pictureBox2);
            this.WindowSizeControlPanel.Controls.Add(this.pictureBox3);
            this.WindowSizeControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowSizeControlPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowSizeControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.WindowSizeControlPanel.Name = "WindowSizeControlPanel";
            this.WindowSizeControlPanel.Size = new System.Drawing.Size(1557, 25);
            this.WindowSizeControlPanel.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::POS.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(1506, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = global::POS.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(1534, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // agendaContainerPanel
            // 
            this.agendaContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agendaContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.agendaContainerPanel.Controls.Add(this.AgendaEventsPanel);
            this.agendaContainerPanel.Location = new System.Drawing.Point(17, 253);
            this.agendaContainerPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.agendaContainerPanel.Name = "agendaContainerPanel";
            this.agendaContainerPanel.Size = new System.Drawing.Size(712, 456);
            this.agendaContainerPanel.TabIndex = 2;
            // 
            // AgendaEventsPanel
            // 
            this.AgendaEventsPanel.Controls.Add(this.agendaBottomPanel);
            this.AgendaEventsPanel.Controls.Add(this.flowLayoutPanel1);
            this.AgendaEventsPanel.Controls.Add(this.AgendaHeaderPanel);
            this.AgendaEventsPanel.Controls.Add(this.agendaBackgrountPictureBox);
            this.AgendaEventsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgendaEventsPanel.Location = new System.Drawing.Point(0, 0);
            this.AgendaEventsPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AgendaEventsPanel.Name = "AgendaEventsPanel";
            this.AgendaEventsPanel.Size = new System.Drawing.Size(712, 456);
            this.AgendaEventsPanel.TabIndex = 2;
            // 
            // agendaBottomPanel
            // 
            this.agendaBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.agendaBottomPanel.Controls.Add(this.DateLbl);
            this.agendaBottomPanel.Controls.Add(this.goFurtherBtn);
            this.agendaBottomPanel.Controls.Add(this.goBackBtn);
            this.agendaBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.agendaBottomPanel.ForeColor = System.Drawing.Color.Black;
            this.agendaBottomPanel.Location = new System.Drawing.Point(0, 405);
            this.agendaBottomPanel.Name = "agendaBottomPanel";
            this.agendaBottomPanel.Size = new System.Drawing.Size(712, 51);
            this.agendaBottomPanel.TabIndex = 7;
            // 
            // DateLbl
            // 
            this.DateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(283, 11);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(138, 28);
            this.DateLbl.TabIndex = 3;
            this.DateLbl.Text = "27/01/2020";
            // 
            // goFurtherBtn
            // 
            this.goFurtherBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goFurtherBtn.BackColor = System.Drawing.Color.Transparent;
            this.goFurtherBtn.Image = global::POS.Properties.Resources.right_arrow;
            this.goFurtherBtn.ImageActive = null;
            this.goFurtherBtn.Location = new System.Drawing.Point(603, 10);
            this.goFurtherBtn.Name = "goFurtherBtn";
            this.goFurtherBtn.Size = new System.Drawing.Size(30, 30);
            this.goFurtherBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goFurtherBtn.TabIndex = 2;
            this.goFurtherBtn.TabStop = false;
            this.goFurtherBtn.Zoom = 10;
            this.goFurtherBtn.Click += new System.EventHandler(this.goFurtherBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.goBackBtn.Image = global::POS.Properties.Resources.left_arrow;
            this.goBackBtn.ImageActive = null;
            this.goBackBtn.Location = new System.Drawing.Point(80, 10);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(30, 30);
            this.goBackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goBackBtn.TabIndex = 1;
            this.goBackBtn.TabStop = false;
            this.goBackBtn.Zoom = 10;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(712, 372);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // AgendaHeaderPanel
            // 
            this.AgendaHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.AgendaHeaderPanel.Controls.Add(this.bunifuSeparator1);
            this.AgendaHeaderPanel.Controls.Add(this.label2);
            this.AgendaHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AgendaHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.AgendaHeaderPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AgendaHeaderPanel.Name = "AgendaHeaderPanel";
            this.AgendaHeaderPanel.Size = new System.Drawing.Size(712, 84);
            this.AgendaHeaderPanel.TabIndex = 9;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(71, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(570, 2);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "AGENDA";
            // 
            // agendaBackgrountPictureBox
            // 
            this.agendaBackgrountPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.agendaBackgrountPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agendaBackgrountPictureBox.Location = new System.Drawing.Point(0, 0);
            this.agendaBackgrountPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.agendaBackgrountPictureBox.Name = "agendaBackgrountPictureBox";
            this.agendaBackgrountPictureBox.Size = new System.Drawing.Size(712, 456);
            this.agendaBackgrountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agendaBackgrountPictureBox.TabIndex = 8;
            this.agendaBackgrountPictureBox.TabStop = false;
            // 
            // startShiftBtn
            // 
            this.startShiftBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startShiftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.startShiftBtn.FlatAppearance.BorderSize = 0;
            this.startShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startShiftBtn.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.startShiftBtn.ForeColor = System.Drawing.Color.White;
            this.startShiftBtn.Location = new System.Drawing.Point(1072, 402);
            this.startShiftBtn.Name = "startShiftBtn";
            this.startShiftBtn.Size = new System.Drawing.Size(339, 169);
            this.startShiftBtn.TabIndex = 6;
            this.startShiftBtn.Text = "Iniciar Turno";
            this.startShiftBtn.UseVisualStyleBackColor = false;
            this.startShiftBtn.Click += new System.EventHandler(this.startShiftBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(955, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 456);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de Turno 07-01-2020 13:00";
            this.groupBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 256);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.endShiftBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 90);
            this.panel1.TabIndex = 6;
            // 
            // endShiftBtn
            // 
            this.endShiftBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endShiftBtn.BackColor = System.Drawing.Color.Red;
            this.endShiftBtn.FlatAppearance.BorderSize = 0;
            this.endShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endShiftBtn.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.endShiftBtn.ForeColor = System.Drawing.Color.White;
            this.endShiftBtn.Location = new System.Drawing.Point(64, 8);
            this.endShiftBtn.Name = "endShiftBtn";
            this.endShiftBtn.Size = new System.Drawing.Size(440, 74);
            this.endShiftBtn.TabIndex = 4;
            this.endShiftBtn.Text = "Corte de Caja";
            this.endShiftBtn.UseVisualStyleBackColor = false;
            this.endShiftBtn.Click += new System.EventHandler(this.endShiftBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(563, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Comenzar Nuevo Turno";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.startShiftBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 74);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(98, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar Efectivo a Caja";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::POS.Properties.Resources.HomePanelBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1557, 738);
            this.Controls.Add(this.startShiftBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.agendaContainerPanel);
            this.Controls.Add(this.WindowSizeControlPanel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Panel_Inicio";
            this.ShowInTaskbar = false;
            this.Text = "Inicio | Point of Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Inicio_Load);
            this.SizeChanged += new System.EventHandler(this.Panel_Inicio_SizeChanged);
            this.WindowSizeControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.agendaContainerPanel.ResumeLayout(false);
            this.AgendaEventsPanel.ResumeLayout(false);
            this.agendaBottomPanel.ResumeLayout(false);
            this.agendaBottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goFurtherBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goBackBtn)).EndInit();
            this.AgendaHeaderPanel.ResumeLayout(false);
            this.AgendaHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBackgrountPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel WindowSizeControlPanel;
        private System.Windows.Forms.Panel agendaContainerPanel;
        private System.Windows.Forms.Button startShiftBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Panel panel1;
        private Button endShiftBtn;
        private Button button2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private Panel AgendaEventsPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel AgendaHeaderPanel;
        private Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Panel agendaBottomPanel;
        private PictureBox agendaBackgrountPictureBox;
        private Button button1;
        private PictureBox pictureBox1;
        private Label DateLbl;
        private Bunifu.Framework.UI.BunifuImageButton goFurtherBtn;
        private Bunifu.Framework.UI.BunifuImageButton goBackBtn;
    }
}