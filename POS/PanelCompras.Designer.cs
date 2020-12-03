using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class PanelCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PODescriptionPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.arrivalDateLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.employeeName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SupplierLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.POIDlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.paymentDateLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.purchaseDateLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalLbl = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.PayBtn = new System.Windows.Forms.Button();
            this.purchaseStatusLbl = new System.Windows.Forms.Label();
            this.debtLbl = new System.Windows.Forms.Label();
            this.paymantLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeWhoConfirmedLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeliveryStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pdfFileBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.BrowserTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.POsContainerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.PODescriptionPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfFileBtn)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.POsContainerPanel.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1221, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.MimimizeBtn, "Minimizar");
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1247, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.closeBtn, "Cerrar");
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // PODescriptionPanel
            // 
            this.PODescriptionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PODescriptionPanel.BackgroundImage")));
            this.PODescriptionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PODescriptionPanel.Controls.Add(this.headerPanel);
            this.PODescriptionPanel.Controls.Add(this.ConfirmBtn);
            this.PODescriptionPanel.Controls.Add(this.panel1);
            this.PODescriptionPanel.Controls.Add(this.dataGridView1);
            this.PODescriptionPanel.Controls.Add(this.bunifuSeparator1);
            this.PODescriptionPanel.Controls.Add(this.textBox1);
            this.PODescriptionPanel.Controls.Add(this.label6);
            this.PODescriptionPanel.Controls.Add(this.deleteBtn);
            this.PODescriptionPanel.Controls.Add(this.backButton);
            this.PODescriptionPanel.Controls.Add(this.pdfFileBtn);
            this.PODescriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PODescriptionPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.PODescriptionPanel.GradientBottomRight = System.Drawing.Color.White;
            this.PODescriptionPanel.GradientTopLeft = System.Drawing.Color.White;
            this.PODescriptionPanel.GradientTopRight = System.Drawing.Color.White;
            this.PODescriptionPanel.Location = new System.Drawing.Point(0, 25);
            this.PODescriptionPanel.Name = "PODescriptionPanel";
            this.PODescriptionPanel.Quality = 10;
            this.PODescriptionPanel.Size = new System.Drawing.Size(1279, 723);
            this.PODescriptionPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.middlePanel);
            this.headerPanel.Controls.Add(this.leftPanel);
            this.headerPanel.Controls.Add(this.rightPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1279, 100);
            this.headerPanel.TabIndex = 31;
            this.headerPanel.Resize += new System.EventHandler(this.headerPanel_Resize);
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.panel11);
            this.middlePanel.Controls.Add(this.panel10);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(397, 0);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(420, 100);
            this.middlePanel.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.arrivalDateLbl);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(420, 50);
            this.panel11.TabIndex = 23;
            // 
            // arrivalDateLbl
            // 
            this.arrivalDateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrivalDateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDateLbl.Location = new System.Drawing.Point(199, 0);
            this.arrivalDateLbl.Name = "arrivalDateLbl";
            this.arrivalDateLbl.Size = new System.Drawing.Size(221, 50);
            this.arrivalDateLbl.TabIndex = 21;
            this.arrivalDateLbl.Text = "20/Septiembre/2019";
            this.arrivalDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Entrega:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.employeeName);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(420, 50);
            this.panel10.TabIndex = 22;
            // 
            // employeeName
            // 
            this.employeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.Location = new System.Drawing.Point(179, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(241, 50);
            this.employeeName.TabIndex = 20;
            this.employeeName.Text = "Edgar Abel Méndez Arvizu";
            this.employeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 50);
            this.label8.TabIndex = 8;
            this.label8.Text = "Realizó Compra:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(397, 100);
            this.leftPanel.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SupplierLbl);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 50);
            this.panel5.TabIndex = 21;
            // 
            // SupplierLbl
            // 
            this.SupplierLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLbl.Location = new System.Drawing.Point(122, 0);
            this.SupplierLbl.Name = "SupplierLbl";
            this.SupplierLbl.Size = new System.Drawing.Size(275, 50);
            this.SupplierLbl.TabIndex = 19;
            this.SupplierLbl.Text = "Abarrotera de Valles S.A. de C.V.";
            this.SupplierLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proveedor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.POIDlbl);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 50);
            this.panel4.TabIndex = 20;
            // 
            // POIDlbl
            // 
            this.POIDlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POIDlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POIDlbl.Location = new System.Drawing.Point(96, 0);
            this.POIDlbl.Name = "POIDlbl";
            this.POIDlbl.Size = new System.Drawing.Size(301, 50);
            this.POIDlbl.TabIndex = 18;
            this.POIDlbl.Text = "999999999";
            this.POIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Orden #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel8);
            this.rightPanel.Controls.Add(this.panel7);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(817, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(462, 100);
            this.rightPanel.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.paymentDateLbl);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(462, 50);
            this.panel8.TabIndex = 25;
            // 
            // paymentDateLbl
            // 
            this.paymentDateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentDateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDateLbl.Location = new System.Drawing.Point(174, 0);
            this.paymentDateLbl.Name = "paymentDateLbl";
            this.paymentDateLbl.Size = new System.Drawing.Size(288, 50);
            this.paymentDateLbl.TabIndex = 23;
            this.paymentDateLbl.Text = "20/Septiembre/2019";
            this.paymentDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 50);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de Pago:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.purchaseDateLbl);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(462, 50);
            this.panel7.TabIndex = 24;
            // 
            // purchaseDateLbl
            // 
            this.purchaseDateLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseDateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateLbl.Location = new System.Drawing.Point(206, 0);
            this.purchaseDateLbl.Name = "purchaseDateLbl";
            this.purchaseDateLbl.Size = new System.Drawing.Size(256, 50);
            this.purchaseDateLbl.TabIndex = 22;
            this.purchaseDateLbl.Text = "20/Septiembre/2019";
            this.purchaseDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Compra:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(245, 658);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(274, 53);
            this.ConfirmBtn.TabIndex = 20;
            this.ConfirmBtn.Text = "Confirmar Pedido";
            this.toolTip1.SetToolTip(this.ConfirmBtn, "Confirmar pedido");
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TotalLbl);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.PayBtn);
            this.panel1.Controls.Add(this.purchaseStatusLbl);
            this.panel1.Controls.Add(this.debtLbl);
            this.panel1.Controls.Add(this.paymantLbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.EmployeeWhoConfirmedLbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.DeliveryStatus);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(882, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 591);
            this.panel1.TabIndex = 28;
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalLbl.BackColor = System.Drawing.Color.White;
            this.TotalLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.TotalLbl.Location = new System.Drawing.Point(153, 241);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(174, 37);
            this.TotalLbl.TabIndex = 13;
            this.TotalLbl.Text = "$0.00";
            this.TotalLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalLbl.TextChanged += new System.EventHandler(this.TotalLbl_TextChanged);
            this.TotalLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalLbl_KeyDown);
            this.TotalLbl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalLbl_KeyPress);
            this.TotalLbl.Leave += new System.EventHandler(this.TotalLbl_Leave);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 65535;
            this.bunifuSeparator2.Location = new System.Drawing.Point(58, 313);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(278, 10);
            this.bunifuSeparator2.TabIndex = 12;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // PayBtn
            // 
            this.PayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.PayBtn.FlatAppearance.BorderSize = 0;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.Location = new System.Drawing.Point(77, 418);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(240, 108);
            this.PayBtn.TabIndex = 19;
            this.PayBtn.Text = "Abonar";
            this.toolTip1.SetToolTip(this.PayBtn, "Relizar Pago");
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // purchaseStatusLbl
            // 
            this.purchaseStatusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseStatusLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseStatusLbl.Location = new System.Drawing.Point(62, 66);
            this.purchaseStatusLbl.Name = "purchaseStatusLbl";
            this.purchaseStatusLbl.Size = new System.Drawing.Size(270, 24);
            this.purchaseStatusLbl.TabIndex = 17;
            this.purchaseStatusLbl.Text = "Pago Pendiente";
            this.purchaseStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debtLbl
            // 
            this.debtLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.debtLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtLbl.ForeColor = System.Drawing.Color.Tomato;
            this.debtLbl.Location = new System.Drawing.Point(163, 323);
            this.debtLbl.Name = "debtLbl";
            this.debtLbl.Size = new System.Drawing.Size(180, 34);
            this.debtLbl.TabIndex = 15;
            this.debtLbl.Text = "$0.00";
            this.debtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymantLbl
            // 
            this.paymantLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paymantLbl.BackColor = System.Drawing.Color.Transparent;
            this.paymantLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymantLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.paymantLbl.Location = new System.Drawing.Point(157, 279);
            this.paymantLbl.Name = "paymantLbl";
            this.paymantLbl.Size = new System.Drawing.Size(180, 34);
            this.paymantLbl.TabIndex = 14;
            this.paymantLbl.Text = "$0.00";
            this.paymantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(94, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Recibió Mercancia:";
            this.label12.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(57, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Abono:";
            // 
            // EmployeeWhoConfirmedLbl
            // 
            this.EmployeeWhoConfirmedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeWhoConfirmedLbl.AutoEllipsis = true;
            this.EmployeeWhoConfirmedLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeWhoConfirmedLbl.Location = new System.Drawing.Point(22, 187);
            this.EmployeeWhoConfirmedLbl.Name = "EmployeeWhoConfirmedLbl";
            this.EmployeeWhoConfirmedLbl.Size = new System.Drawing.Size(350, 24);
            this.EmployeeWhoConfirmedLbl.TabIndex = 21;
            this.EmployeeWhoConfirmedLbl.Text = "Edgar Abel Mende Arvixu";
            this.EmployeeWhoConfirmedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmployeeWhoConfirmedLbl.Visible = false;
            this.EmployeeWhoConfirmedLbl.TextChanged += new System.EventHandler(this.EmployeeWhoConfirmedLbl_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 30);
            this.label11.TabIndex = 11;
            this.label11.Text = "Adeudo:";
            // 
            // DeliveryStatus
            // 
            this.DeliveryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryStatus.Location = new System.Drawing.Point(62, 101);
            this.DeliveryStatus.Name = "DeliveryStatus";
            this.DeliveryStatus.Size = new System.Drawing.Size(270, 24);
            this.DeliveryStatus.TabIndex = 18;
            this.DeliveryStatus.Text = "Pedido no Recibido";
            this.DeliveryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(98, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 24);
            this.label15.TabIndex = 16;
            this.label15.Text = "Estado del Pedido:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(119, 195);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 444);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_Leave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(237)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 103);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1278, 18);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(198, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(667, 27);
            this.textBox1.TabIndex = 30;
            this.toolTip1.SetToolTip(this.textBox1, "Buscar Producto");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Buscar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Image = global::POS.Properties.Resources.delete;
            this.deleteBtn.ImageActive = null;
            this.deleteBtn.Location = new System.Drawing.Point(12, 258);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(71, 71);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.deleteBtn, "Eliminar Orden de Compra");
            this.deleteBtn.Zoom = 10;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Image = global::POS.Properties.Resources.Back;
            this.backButton.ImageActive = null;
            this.backButton.Location = new System.Drawing.Point(17, 148);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(66, 71);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 26;
            this.backButton.TabStop = false;
            this.toolTip1.SetToolTip(this.backButton, "Atrás");
            this.backButton.Zoom = 10;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pdfFileBtn
            // 
            this.pdfFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.pdfFileBtn.Image = global::POS.Properties.Resources.pdf_file;
            this.pdfFileBtn.ImageActive = null;
            this.pdfFileBtn.Location = new System.Drawing.Point(12, 360);
            this.pdfFileBtn.Name = "pdfFileBtn";
            this.pdfFileBtn.Size = new System.Drawing.Size(71, 71);
            this.pdfFileBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pdfFileBtn.TabIndex = 25;
            this.pdfFileBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.pdfFileBtn, "Abrir Archivo Orden de Compra");
            this.pdfFileBtn.Visible = false;
            this.pdfFileBtn.Zoom = 10;
            this.pdfFileBtn.Click += new System.EventHandler(this.pdfFileBtn_Click);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.searchBtn);
            this.bunifuGradientPanel3.Controls.Add(this.BrowserTxt);
            this.bunifuGradientPanel3.Controls.Add(this.label1);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1279, 100);
            this.bunifuGradientPanel3.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(444, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 35);
            this.searchBtn.TabIndex = 43;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // BrowserTxt
            // 
            this.BrowserTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserTxt.Location = new System.Drawing.Point(119, 33);
            this.BrowserTxt.Name = "BrowserTxt";
            this.BrowserTxt.Size = new System.Drawing.Size(319, 33);
            this.BrowserTxt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BrowserTxt, "Buscar Orden de Compra. Pulse Enter para realizar la busqueda");
            this.BrowserTxt.TextChanged += new System.EventHandler(this.BrowserTxt_TextChanged);
            this.BrowserTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrowserTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // POsContainerPanel
            // 
            this.POsContainerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("POsContainerPanel.BackgroundImage")));
            this.POsContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.POsContainerPanel.Controls.Add(this.flowLayoutPanel1);
            this.POsContainerPanel.Controls.Add(this.bunifuGradientPanel3);
            this.POsContainerPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.POsContainerPanel.GradientBottomRight = System.Drawing.Color.White;
            this.POsContainerPanel.GradientTopLeft = System.Drawing.Color.White;
            this.POsContainerPanel.GradientTopRight = System.Drawing.Color.White;
            this.POsContainerPanel.Location = new System.Drawing.Point(0, 25);
            this.POsContainerPanel.Name = "POsContainerPanel";
            this.POsContainerPanel.Quality = 10;
            this.POsContainerPanel.Size = new System.Drawing.Size(1279, 723);
            this.POsContainerPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1279, 623);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1279, 25);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.DoubleClick += new System.EventHandler(this.bunifuGradientPanel1_DoubleClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.PayBtn;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Khaki;
            this.toolTip1.IsBalloon = true;
            // 
            // PanelCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 748);
            this.Controls.Add(this.PODescriptionPanel);
            this.Controls.Add(this.POsContainerPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelCompras";
            this.ShowInTaskbar = false;
            this.Text = "Compras | Point of Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelCompras_FormClosing);
            this.Load += new System.EventHandler(this.PanelCompras_Load);
            this.Resize += new System.EventHandler(this.PanelCompras_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.PODescriptionPanel.ResumeLayout(false);
            this.PODescriptionPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfFileBtn)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.POsContainerPanel.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel POsContainerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuGradientPanel PODescriptionPanel;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox BrowserTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TotalLbl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Label purchaseStatusLbl;
        private System.Windows.Forms.Label debtLbl;
        private System.Windows.Forms.Label paymantLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EmployeeWhoConfirmedLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DeliveryStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label POIDlbl;
        private System.Windows.Forms.Label SupplierLbl;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label arrivalDateLbl;
        private System.Windows.Forms.Label purchaseDateLbl;
        private System.Windows.Forms.Label paymentDateLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton deleteBtn;
        private Bunifu.Framework.UI.BunifuImageButton backButton;
        private Bunifu.Framework.UI.BunifuImageButton pdfFileBtn;
        private Panel headerPanel;
        private Panel middlePanel;
        private Panel leftPanel;
        private Panel panel5;
        private Panel panel4;
        private Panel rightPanel;
        private Panel panel8;
        private Panel panel7;
        private Panel panel11;
        private Panel panel10;
    }
}