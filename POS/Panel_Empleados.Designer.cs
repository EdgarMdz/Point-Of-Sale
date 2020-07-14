using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Empleados));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.employeeListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchEmployeeTxt = new System.Windows.Forms.TextBox();
            this.newEmployeeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.accionsPanel = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.loanBtn = new System.Windows.Forms.Button();
            this.Paybtn = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.paymentDebtBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.debtLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.basicInfoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mondayLbl = new System.Windows.Forms.Label();
            this.sundayLbl = new System.Windows.Forms.Label();
            this.saturdayLbl = new System.Windows.Forms.Label();
            this.fridayLbl = new System.Windows.Forms.Label();
            this.thursdayLbl = new System.Windows.Forms.Label();
            this.wednesdayLbl = new System.Windows.Forms.Label();
            this.tuestayLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateofBirth = new System.Windows.Forms.DateTimePicker();
            this.salaryTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.hirementDate = new System.Windows.Forms.DateTimePicker();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.customerPaymentDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBtn)).BeginInit();
            this.EmployeePanel.SuspendLayout();
            this.accionsPanel.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.basicInfoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.PowderBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1557, 25);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1499, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1525, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.employeeListBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchEmployeeTxt);
            this.panel1.Controls.Add(this.newEmployeeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 73);
            this.panel1.TabIndex = 2;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(662, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(121, 41);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // employeeListBtn
            // 
            this.employeeListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.employeeListBtn.FlatAppearance.BorderSize = 0;
            this.employeeListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeListBtn.Font = new System.Drawing.Font("Century Gothic", 17.75F, System.Drawing.FontStyle.Bold);
            this.employeeListBtn.ForeColor = System.Drawing.Color.White;
            this.employeeListBtn.Location = new System.Drawing.Point(1256, 12);
            this.employeeListBtn.Name = "employeeListBtn";
            this.employeeListBtn.Size = new System.Drawing.Size(275, 48);
            this.employeeListBtn.TabIndex = 3;
            this.employeeListBtn.Text = "Lista de empleados";
            this.employeeListBtn.UseVisualStyleBackColor = false;
            this.employeeListBtn.Click += new System.EventHandler(this.employeeList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // searchEmployeeTxt
            // 
            this.searchEmployeeTxt.Location = new System.Drawing.Point(132, 16);
            this.searchEmployeeTxt.MaxLength = 50;
            this.searchEmployeeTxt.Name = "searchEmployeeTxt";
            this.searchEmployeeTxt.Size = new System.Drawing.Size(524, 41);
            this.searchEmployeeTxt.TabIndex = 0;
            this.searchEmployeeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchEmployeeTxt_KeyDown);
            // 
            // newEmployeeBtn
            // 
            this.newEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.newEmployeeBtn.Image = global::POS.Properties.Resources.plus;
            this.newEmployeeBtn.ImageActive = null;
            this.newEmployeeBtn.Location = new System.Drawing.Point(1744, 7);
            this.newEmployeeBtn.Name = "newEmployeeBtn";
            this.newEmployeeBtn.Size = new System.Drawing.Size(56, 57);
            this.newEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newEmployeeBtn.TabIndex = 2;
            this.newEmployeeBtn.TabStop = false;
            this.newEmployeeBtn.Zoom = 10;
            this.newEmployeeBtn.Click += new System.EventHandler(this.newEmployeeBtn_Click);
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Controls.Add(this.accionsPanel);
            this.EmployeePanel.Controls.Add(this.basicInfoPanel);
            this.EmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePanel.Location = new System.Drawing.Point(0, 98);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1557, 963);
            this.EmployeePanel.TabIndex = 3;
            this.EmployeePanel.Visible = false;
            // 
            // accionsPanel
            // 
            this.accionsPanel.Controls.Add(this.bunifuSeparator1);
            this.accionsPanel.Controls.Add(this.bunifuCards2);
            this.accionsPanel.Controls.Add(this.bunifuCards1);
            this.accionsPanel.Controls.Add(this.changePassBtn);
            this.accionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accionsPanel.Location = new System.Drawing.Point(0, 231);
            this.accionsPanel.Name = "accionsPanel";
            this.accionsPanel.Size = new System.Drawing.Size(1557, 732);
            this.accionsPanel.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1557, 4);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.bunifuCards2.Controls.Add(this.loanBtn);
            this.bunifuCards2.Controls.Add(this.Paybtn);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(103, 109);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(684, 514);
            this.bunifuCards2.TabIndex = 3;
            // 
            // loanBtn
            // 
            this.loanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.loanBtn.FlatAppearance.BorderSize = 0;
            this.loanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanBtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanBtn.ForeColor = System.Drawing.Color.White;
            this.loanBtn.Location = new System.Drawing.Point(186, 290);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(313, 144);
            this.loanBtn.TabIndex = 1;
            this.loanBtn.Text = "Préstamo";
            this.loanBtn.UseVisualStyleBackColor = false;
            this.loanBtn.Click += new System.EventHandler(this.loanBtn_Click);
            // 
            // Paybtn
            // 
            this.Paybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.Paybtn.FlatAppearance.BorderSize = 0;
            this.Paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paybtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paybtn.ForeColor = System.Drawing.Color.White;
            this.Paybtn.Location = new System.Drawing.Point(186, 80);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(313, 144);
            this.Paybtn.TabIndex = 0;
            this.Paybtn.Text = "Pagar";
            this.Paybtn.UseVisualStyleBackColor = false;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.paymentDebtBtn);
            this.bunifuCards1.Controls.Add(this.debtLbl);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(840, 192);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(613, 349);
            this.bunifuCards1.TabIndex = 1;
            // 
            // paymentDebtBtn
            // 
            this.paymentDebtBtn.ActiveBorderThickness = 1;
            this.paymentDebtBtn.ActiveCornerRadius = 20;
            this.paymentDebtBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.paymentDebtBtn.ActiveForecolor = System.Drawing.Color.White;
            this.paymentDebtBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.paymentDebtBtn.BackColor = System.Drawing.Color.White;
            this.paymentDebtBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paymentDebtBtn.BackgroundImage")));
            this.paymentDebtBtn.ButtonText = "Abonar";
            this.paymentDebtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentDebtBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDebtBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.paymentDebtBtn.IdleBorderThickness = 1;
            this.paymentDebtBtn.IdleCornerRadius = 20;
            this.paymentDebtBtn.IdleFillColor = System.Drawing.Color.White;
            this.paymentDebtBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.paymentDebtBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.paymentDebtBtn.Location = new System.Drawing.Point(221, 267);
            this.paymentDebtBtn.Margin = new System.Windows.Forms.Padding(5);
            this.paymentDebtBtn.Name = "paymentDebtBtn";
            this.paymentDebtBtn.Size = new System.Drawing.Size(181, 41);
            this.paymentDebtBtn.TabIndex = 3;
            this.paymentDebtBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paymentDebtBtn.Click += new System.EventHandler(this.paymentDebtBtn_Click);
            // 
            // debtLbl
            // 
            this.debtLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.debtLbl.AutoEllipsis = true;
            this.debtLbl.Font = new System.Drawing.Font("Century Gothic", 40.25F, System.Drawing.FontStyle.Bold);
            this.debtLbl.Location = new System.Drawing.Point(1, 142);
            this.debtLbl.Name = "debtLbl";
            this.debtLbl.Size = new System.Drawing.Size(611, 88);
            this.debtLbl.TabIndex = 2;
            this.debtLbl.Text = "$500.00";
            this.debtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.debtLbl.TextChanged += new System.EventHandler(this.debtLbl_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 40.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(187, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 64);
            this.label9.TabIndex = 1;
            this.label9.Text = "Adeudo";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassBtn.ForeColor = System.Drawing.Color.White;
            this.changePassBtn.Location = new System.Drawing.Point(513, 638);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(531, 64);
            this.changePassBtn.TabIndex = 2;
            this.changePassBtn.Text = "Cambiar Contraseña";
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // basicInfoPanel
            // 
            this.basicInfoPanel.Controls.Add(this.panel2);
            this.basicInfoPanel.Controls.Add(this.panel3);
            this.basicInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.basicInfoPanel.Name = "basicInfoPanel";
            this.basicInfoPanel.Size = new System.Drawing.Size(1557, 231);
            this.basicInfoPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.mondayLbl);
            this.panel2.Controls.Add(this.sundayLbl);
            this.panel2.Controls.Add(this.saturdayLbl);
            this.panel2.Controls.Add(this.fridayLbl);
            this.panel2.Controls.Add(this.thursdayLbl);
            this.panel2.Controls.Add(this.wednesdayLbl);
            this.panel2.Controls.Add(this.tuestayLbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1010, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 231);
            this.panel2.TabIndex = 10;
            // 
            // mondayLbl
            // 
            this.mondayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mondayLbl.AutoSize = true;
            this.mondayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.mondayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.mondayLbl.Location = new System.Drawing.Point(-3, 115);
            this.mondayLbl.Name = "mondayLbl";
            this.mondayLbl.Size = new System.Drawing.Size(45, 56);
            this.mondayLbl.TabIndex = 1;
            this.mondayLbl.Text = "L";
            this.mondayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // sundayLbl
            // 
            this.sundayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sundayLbl.AutoSize = true;
            this.sundayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.sundayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.sundayLbl.Location = new System.Drawing.Point(488, 115);
            this.sundayLbl.Name = "sundayLbl";
            this.sundayLbl.Size = new System.Drawing.Size(57, 56);
            this.sundayLbl.TabIndex = 2;
            this.sundayLbl.Text = "D";
            this.sundayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // saturdayLbl
            // 
            this.saturdayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saturdayLbl.AutoSize = true;
            this.saturdayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.saturdayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.saturdayLbl.Location = new System.Drawing.Point(416, 115);
            this.saturdayLbl.Name = "saturdayLbl";
            this.saturdayLbl.Size = new System.Drawing.Size(48, 56);
            this.saturdayLbl.TabIndex = 3;
            this.saturdayLbl.Text = "S";
            this.saturdayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // fridayLbl
            // 
            this.fridayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fridayLbl.AutoSize = true;
            this.fridayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.fridayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.fridayLbl.Location = new System.Drawing.Point(334, 115);
            this.fridayLbl.Name = "fridayLbl";
            this.fridayLbl.Size = new System.Drawing.Size(57, 56);
            this.fridayLbl.TabIndex = 4;
            this.fridayLbl.Text = "V";
            this.fridayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // thursdayLbl
            // 
            this.thursdayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thursdayLbl.AutoSize = true;
            this.thursdayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.thursdayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.thursdayLbl.Location = new System.Drawing.Point(262, 115);
            this.thursdayLbl.Name = "thursdayLbl";
            this.thursdayLbl.Size = new System.Drawing.Size(47, 56);
            this.thursdayLbl.TabIndex = 5;
            this.thursdayLbl.Text = "J";
            this.thursdayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // wednesdayLbl
            // 
            this.wednesdayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wednesdayLbl.AutoSize = true;
            this.wednesdayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.wednesdayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.wednesdayLbl.Location = new System.Drawing.Point(160, 115);
            this.wednesdayLbl.Name = "wednesdayLbl";
            this.wednesdayLbl.Size = new System.Drawing.Size(77, 56);
            this.wednesdayLbl.TabIndex = 6;
            this.wednesdayLbl.Text = "Mi";
            this.wednesdayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // tuestayLbl
            // 
            this.tuestayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tuestayLbl.AutoSize = true;
            this.tuestayLbl.Font = new System.Drawing.Font("Century Gothic", 35.25F, System.Drawing.FontStyle.Bold);
            this.tuestayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.tuestayLbl.Location = new System.Drawing.Point(68, 115);
            this.tuestayLbl.Name = "tuestayLbl";
            this.tuestayLbl.Size = new System.Drawing.Size(66, 56);
            this.tuestayLbl.TabIndex = 7;
            this.tuestayLbl.Text = "M";
            this.tuestayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Día de Pago";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.dateofBirth);
            this.panel3.Controls.Add(this.salaryTxt);
            this.panel3.Controls.Add(this.phoneTxt);
            this.panel3.Controls.Add(this.hirementDate);
            this.panel3.Controls.Add(this.addressTxt);
            this.panel3.Controls.Add(this.nameTxt);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.discountTxt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nameLbl);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1557, 231);
            this.panel3.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(147, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 31);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateofBirth
            // 
            this.dateofBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 15.25F);
            this.dateofBirth.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.dateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofBirth.Location = new System.Drawing.Point(837, 47);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(167, 32);
            this.dateofBirth.TabIndex = 7;
            this.dateofBirth.ValueChanged += new System.EventHandler(this.dateofBirth_ValueChanged);
            // 
            // salaryTxt
            // 
            this.salaryTxt.AutoSize = true;
            this.salaryTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.salaryTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salaryTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.salaryTxt.BorderThickness = 3;
            this.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTxt.Font = new System.Drawing.Font("Century Gothic", 35.75F, System.Drawing.FontStyle.Bold);
            this.salaryTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.salaryTxt.isPassword = false;
            this.salaryTxt.Location = new System.Drawing.Point(711, 136);
            this.salaryTxt.Margin = new System.Windows.Forms.Padding(23);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(293, 87);
            this.salaryTxt.TabIndex = 14;
            this.salaryTxt.Text = "$580.00";
            this.salaryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salaryTxt.OnValueChanged += new System.EventHandler(this.salaryTxt_OnValueChanged);
            this.salaryTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salaryTxt_KeyDown);
            this.salaryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTxt_KeyPress);
            this.salaryTxt.Leave += new System.EventHandler(this.salaryTxt_Leave);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.phoneTxt.Location = new System.Drawing.Point(147, 98);
            this.phoneTxt.MaxLength = 50;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(303, 32);
            this.phoneTxt.TabIndex = 5;
            this.phoneTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneTxt_KeyDown);
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // hirementDate
            // 
            this.hirementDate.CalendarFont = new System.Drawing.Font("Century Gothic", 15.25F);
            this.hirementDate.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.hirementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hirementDate.Location = new System.Drawing.Point(837, 94);
            this.hirementDate.Name = "hirementDate";
            this.hirementDate.Size = new System.Drawing.Size(167, 32);
            this.hirementDate.TabIndex = 9;
            this.hirementDate.ValueChanged += new System.EventHandler(this.hirementDate_ValueChanged);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.addressTxt.Location = new System.Drawing.Point(147, 52);
            this.addressTxt.MaxLength = 50;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(304, 32);
            this.addressTxt.TabIndex = 3;
            this.addressTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTxt_KeyDown);
            this.addressTxt.Leave += new System.EventHandler(this.addressTxt_Leave);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.nameTxt.Location = new System.Drawing.Point(147, 6);
            this.nameTxt.MaxLength = 50;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(303, 32);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxt_KeyDown);
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(21, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cargo:";
            // 
            // discountTxt
            // 
            this.discountTxt.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.discountTxt.Location = new System.Drawing.Point(849, 6);
            this.discountTxt.MaxLength = 7;
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(155, 32);
            this.discountTxt.TabIndex = 12;
            this.discountTxt.Text = "0%";
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            this.discountTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountTxt_KeyDown);
            this.discountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTxt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(536, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 47);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(541, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descuento de empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.nameLbl.Location = new System.Drawing.Point(18, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(101, 25);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(543, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(543, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Contratación:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 55;
            this.bunifuElipse1.TargetControl = this.changePassBtn;
            // 
            // Panel_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1557, 1061);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Panel_Empleados";
            this.ShowInTaskbar = false;
            this.Text = "Empleados | Point of Sale";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBtn)).EndInit();
            this.EmployeePanel.ResumeLayout(false);
            this.accionsPanel.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.basicInfoPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel basicInfoPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel accionsPanel;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateofBirth;
        private System.Windows.Forms.DateTimePicker hirementDate;
        private Bunifu.Framework.UI.BunifuMetroTextbox salaryTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument customerPaymentDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button employeeListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchEmployeeTxt;
        private Bunifu.Framework.UI.BunifuImageButton newEmployeeBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label mondayLbl;
        private System.Windows.Forms.Label sundayLbl;
        private System.Windows.Forms.Label saturdayLbl;
        private System.Windows.Forms.Label fridayLbl;
        private System.Windows.Forms.Label thursdayLbl;
        private System.Windows.Forms.Label wednesdayLbl;
        private System.Windows.Forms.Label tuestayLbl;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.Button Paybtn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 paymentDebtBtn;
        private System.Windows.Forms.Label debtLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button changePassBtn;
    }
}