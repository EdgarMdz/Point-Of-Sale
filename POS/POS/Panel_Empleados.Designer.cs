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
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchEmployeeTxt = new System.Windows.Forms.TextBox();
            this.newEmployeeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.employeeListBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.salaryTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateofBirth = new System.Windows.Forms.DateTimePicker();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hirementDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mondayLbl = new System.Windows.Forms.Label();
            this.sundayLbl = new System.Windows.Forms.Label();
            this.saturdayLbl = new System.Windows.Forms.Label();
            this.fridayLbl = new System.Windows.Forms.Label();
            this.thursdayLbl = new System.Windows.Forms.Label();
            this.wednesdayLbl = new System.Windows.Forms.Label();
            this.tuestayLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.customerPaymentDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.topPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBtn)).BeginInit();
            this.EmployeePanel.SuspendLayout();
            this.accionsPanel.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.basicInfoPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1164, 25);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1106, 2);
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
            this.closeBtn.Location = new System.Drawing.Point(1132, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel4);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 25);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.topPanel.Size = new System.Drawing.Size(1164, 52);
            this.topPanel.TabIndex = 2;
            this.topPanel.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.searchBtn);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.searchEmployeeTxt);
            this.panel4.Controls.Add(this.newEmployeeBtn);
            this.panel4.Controls.Add(this.employeeListBtn);
            this.panel4.Controls.Add(this.deleteEmployeeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel4.Size = new System.Drawing.Size(1164, 47);
            this.panel4.TabIndex = 7;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(418, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(126, 37);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // searchEmployeeTxt
            // 
            this.searchEmployeeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEmployeeTxt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.searchEmployeeTxt.Location = new System.Drawing.Point(117, 6);
            this.searchEmployeeTxt.MaximumSize = new System.Drawing.Size(418, 34);
            this.searchEmployeeTxt.MaxLength = 50;
            this.searchEmployeeTxt.Name = "searchEmployeeTxt";
            this.searchEmployeeTxt.Size = new System.Drawing.Size(295, 34);
            this.searchEmployeeTxt.TabIndex = 0;
            this.searchEmployeeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchEmployeeTxt_KeyDown);
            // 
            // newEmployeeBtn
            // 
            this.newEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newEmployeeBtn.BackColor = System.Drawing.Color.Transparent;
            this.newEmployeeBtn.Image = global::POS.Properties.Resources.plus;
            this.newEmployeeBtn.ImageActive = null;
            this.newEmployeeBtn.Location = new System.Drawing.Point(1106, 1);
            this.newEmployeeBtn.Name = "newEmployeeBtn";
            this.newEmployeeBtn.Size = new System.Drawing.Size(45, 45);
            this.newEmployeeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newEmployeeBtn.TabIndex = 2;
            this.newEmployeeBtn.TabStop = false;
            this.newEmployeeBtn.Zoom = 10;
            this.newEmployeeBtn.Click += new System.EventHandler(this.newEmployeeBtn_Click);
            // 
            // employeeListBtn
            // 
            this.employeeListBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.employeeListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.employeeListBtn.FlatAppearance.BorderSize = 0;
            this.employeeListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeListBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.employeeListBtn.ForeColor = System.Drawing.Color.White;
            this.employeeListBtn.Location = new System.Drawing.Point(847, 5);
            this.employeeListBtn.Name = "employeeListBtn";
            this.employeeListBtn.Size = new System.Drawing.Size(236, 37);
            this.employeeListBtn.TabIndex = 3;
            this.employeeListBtn.Text = "Lista de empleados";
            this.employeeListBtn.UseVisualStyleBackColor = false;
            this.employeeListBtn.Click += new System.EventHandler(this.employeeList_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.deleteEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.deleteEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.deleteEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(618, 4);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(199, 37);
            this.deleteEmployeeBtn.TabIndex = 5;
            this.deleteEmployeeBtn.Text = "Borrar Empleado";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = false;
            this.deleteEmployeeBtn.Visible = false;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Controls.Add(this.accionsPanel);
            this.EmployeePanel.Controls.Add(this.basicInfoPanel);
            this.EmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeePanel.Location = new System.Drawing.Point(0, 77);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1164, 691);
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
            this.accionsPanel.Location = new System.Drawing.Point(0, 261);
            this.accionsPanel.Name = "accionsPanel";
            this.accionsPanel.Size = new System.Drawing.Size(1164, 430);
            this.accionsPanel.TabIndex = 1;
            this.accionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accionsPanel_Paint);
            this.accionsPanel.Resize += new System.EventHandler(this.accionsPanel_Resize);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 0;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1164, 4);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.bunifuCards2.Controls.Add(this.loanBtn);
            this.bunifuCards2.Controls.Add(this.Paybtn);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(33, 36);
            this.bunifuCards2.MinimumSize = new System.Drawing.Size(294, 262);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(477, 281);
            this.bunifuCards2.TabIndex = 3;
            // 
            // loanBtn
            // 
            this.loanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.loanBtn.FlatAppearance.BorderSize = 0;
            this.loanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loanBtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanBtn.ForeColor = System.Drawing.Color.White;
            this.loanBtn.Location = new System.Drawing.Point(45, 166);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(386, 63);
            this.loanBtn.TabIndex = 1;
            this.loanBtn.Text = "Préstamo";
            this.loanBtn.UseVisualStyleBackColor = false;
            this.loanBtn.Click += new System.EventHandler(this.loanBtn_Click);
            // 
            // Paybtn
            // 
            this.Paybtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Paybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.Paybtn.FlatAppearance.BorderSize = 0;
            this.Paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paybtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paybtn.ForeColor = System.Drawing.Color.White;
            this.Paybtn.Location = new System.Drawing.Point(45, 61);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(386, 63);
            this.Paybtn.TabIndex = 0;
            this.Paybtn.Text = "Pagar";
            this.Paybtn.UseVisualStyleBackColor = false;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.paymentDebtBtn);
            this.bunifuCards1.Controls.Add(this.debtLbl);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(654, 36);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.bunifuCards1.MinimumSize = new System.Drawing.Size(294, 262);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(477, 281);
            this.bunifuCards1.TabIndex = 1;
            // 
            // paymentDebtBtn
            // 
            this.paymentDebtBtn.ActiveBorderThickness = 1;
            this.paymentDebtBtn.ActiveCornerRadius = 20;
            this.paymentDebtBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.paymentDebtBtn.ActiveForecolor = System.Drawing.Color.White;
            this.paymentDebtBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.paymentDebtBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.paymentDebtBtn.Location = new System.Drawing.Point(148, 199);
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
            this.debtLbl.Location = new System.Drawing.Point(1, 108);
            this.debtLbl.Name = "debtLbl";
            this.debtLbl.Size = new System.Drawing.Size(475, 88);
            this.debtLbl.TabIndex = 2;
            this.debtLbl.Text = "$500.00";
            this.debtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.debtLbl.TextChanged += new System.EventHandler(this.debtLbl_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 40.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(117, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 64);
            this.label9.TabIndex = 1;
            this.label9.Text = "Adeudo";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassBtn.ForeColor = System.Drawing.Color.White;
            this.changePassBtn.Location = new System.Drawing.Point(244, 351);
            this.changePassBtn.MinimumSize = new System.Drawing.Size(451, 53);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(677, 53);
            this.changePassBtn.TabIndex = 2;
            this.changePassBtn.Text = "Cambiar Contraseña";
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // basicInfoPanel
            // 
            this.basicInfoPanel.AutoScroll = true;
            this.basicInfoPanel.Controls.Add(this.panel6);
            this.basicInfoPanel.Controls.Add(this.panel2);
            this.basicInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.basicInfoPanel.Name = "basicInfoPanel";
            this.basicInfoPanel.Size = new System.Drawing.Size(1164, 261);
            this.basicInfoPanel.TabIndex = 0;
            this.basicInfoPanel.SizeChanged += new System.EventHandler(this.basicInfoPanel_SizeChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.salaryTxt);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.dateofBirth);
            this.panel6.Controls.Add(this.nameLbl);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.hirementDate);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.discountTxt);
            this.panel6.Controls.Add(this.phoneTxt);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.nameTxt);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.addressTxt);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.MaximumSize = new System.Drawing.Size(1030, 261);
            this.panel6.MinimumSize = new System.Drawing.Size(740, 261);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(740, 261);
            this.panel6.TabIndex = 17;
            // 
            // salaryTxt
            // 
            this.salaryTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.salaryTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.salaryTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salaryTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.salaryTxt.BorderThickness = 3;
            this.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTxt.Font = new System.Drawing.Font("Century Gothic", 36.75F, System.Drawing.FontStyle.Bold);
            this.salaryTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.salaryTxt.isPassword = false;
            this.salaryTxt.Location = new System.Drawing.Point(491, 153);
            this.salaryTxt.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(241, 87);
            this.salaryTxt.TabIndex = 17;
            this.salaryTxt.Text = "$1512.00";
            this.salaryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salaryTxt.OnValueChanged += new System.EventHandler(this.salaryTxt_OnValueChanged);
            this.salaryTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salaryTxt_KeyDown);
            this.salaryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTxt_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(117, 188);
            this.comboBox1.MinimumSize = new System.Drawing.Size(198, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 27);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateofBirth
            // 
            this.dateofBirth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateofBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 15.25F);
            this.dateofBirth.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofBirth.Location = new System.Drawing.Point(548, 63);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(184, 28);
            this.dateofBirth.TabIndex = 7;
            this.dateofBirth.ValueChanged += new System.EventHandler(this.dateofBirth_ValueChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(21, 44);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(81, 19);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono:";
            // 
            // hirementDate
            // 
            this.hirementDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hirementDate.CalendarFont = new System.Drawing.Font("Century Gothic", 15.25F);
            this.hirementDate.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hirementDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hirementDate.Location = new System.Drawing.Point(548, 110);
            this.hirementDate.Name = "hirementDate";
            this.hirementDate.Size = new System.Drawing.Size(184, 28);
            this.hirementDate.TabIndex = 9;
            this.hirementDate.ValueChanged += new System.EventHandler(this.hirementDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // discountTxt
            // 
            this.discountTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.discountTxt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(548, 22);
            this.discountTxt.MaxLength = 7;
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(184, 28);
            this.discountTxt.TabIndex = 12;
            this.discountTxt.Text = "0%";
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            this.discountTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountTxt_KeyDown);
            this.discountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTxt_KeyPress);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTxt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(117, 139);
            this.phoneTxt.MaxLength = 50;
            this.phoneTxt.MinimumSize = new System.Drawing.Size(198, 32);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(198, 28);
            this.phoneTxt.TabIndex = 5;
            this.phoneTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneTxt_KeyDown);
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(326, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 47);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salario";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cargo:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descuento de empleado:";
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(117, 41);
            this.nameTxt.MaxLength = 50;
            this.nameTxt.MinimumSize = new System.Drawing.Size(198, 32);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(198, 28);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxt_KeyDown);
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // addressTxt
            // 
            this.addressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTxt.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(117, 90);
            this.addressTxt.MaxLength = 50;
            this.addressTxt.MinimumSize = new System.Drawing.Size(198, 32);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(198, 28);
            this.addressTxt.TabIndex = 3;
            this.addressTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTxt_KeyDown);
            this.addressTxt.Leave += new System.EventHandler(this.addressTxt_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Contratación:";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.mondayLbl);
            this.panel2.Controls.Add(this.sundayLbl);
            this.panel2.Controls.Add(this.saturdayLbl);
            this.panel2.Controls.Add(this.fridayLbl);
            this.panel2.Controls.Add(this.thursdayLbl);
            this.panel2.Controls.Add(this.wednesdayLbl);
            this.panel2.Controls.Add(this.tuestayLbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(739, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(425, 261);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mondayLbl
            // 
            this.mondayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mondayLbl.AutoSize = true;
            this.mondayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.mondayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.mondayLbl.Location = new System.Drawing.Point(24, 144);
            this.mondayLbl.Name = "mondayLbl";
            this.mondayLbl.Size = new System.Drawing.Size(38, 47);
            this.mondayLbl.TabIndex = 1;
            this.mondayLbl.Text = "L";
            this.mondayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // sundayLbl
            // 
            this.sundayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sundayLbl.AutoSize = true;
            this.sundayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.sundayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.sundayLbl.Location = new System.Drawing.Point(352, 144);
            this.sundayLbl.Name = "sundayLbl";
            this.sundayLbl.Size = new System.Drawing.Size(49, 47);
            this.sundayLbl.TabIndex = 2;
            this.sundayLbl.Text = "D";
            this.sundayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // saturdayLbl
            // 
            this.saturdayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saturdayLbl.AutoSize = true;
            this.saturdayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.saturdayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.saturdayLbl.Location = new System.Drawing.Point(305, 143);
            this.saturdayLbl.Name = "saturdayLbl";
            this.saturdayLbl.Size = new System.Drawing.Size(41, 47);
            this.saturdayLbl.TabIndex = 3;
            this.saturdayLbl.Text = "S";
            this.saturdayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // fridayLbl
            // 
            this.fridayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fridayLbl.AutoSize = true;
            this.fridayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.fridayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.fridayLbl.Location = new System.Drawing.Point(250, 144);
            this.fridayLbl.Name = "fridayLbl";
            this.fridayLbl.Size = new System.Drawing.Size(49, 47);
            this.fridayLbl.TabIndex = 4;
            this.fridayLbl.Text = "V";
            this.fridayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // thursdayLbl
            // 
            this.thursdayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thursdayLbl.AutoSize = true;
            this.thursdayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.thursdayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.thursdayLbl.Location = new System.Drawing.Point(204, 144);
            this.thursdayLbl.Name = "thursdayLbl";
            this.thursdayLbl.Size = new System.Drawing.Size(40, 47);
            this.thursdayLbl.TabIndex = 5;
            this.thursdayLbl.Text = "J";
            this.thursdayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // wednesdayLbl
            // 
            this.wednesdayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wednesdayLbl.AutoSize = true;
            this.wednesdayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.wednesdayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.wednesdayLbl.Location = new System.Drawing.Point(131, 144);
            this.wednesdayLbl.Name = "wednesdayLbl";
            this.wednesdayLbl.Size = new System.Drawing.Size(67, 47);
            this.wednesdayLbl.TabIndex = 6;
            this.wednesdayLbl.Text = "Mi";
            this.wednesdayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // tuestayLbl
            // 
            this.tuestayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tuestayLbl.AutoSize = true;
            this.tuestayLbl.Font = new System.Drawing.Font("Century Gothic", 30.25F, System.Drawing.FontStyle.Bold);
            this.tuestayLbl.ForeColor = System.Drawing.Color.DimGray;
            this.tuestayLbl.Location = new System.Drawing.Point(68, 144);
            this.tuestayLbl.Name = "tuestayLbl";
            this.tuestayLbl.Size = new System.Drawing.Size(57, 47);
            this.tuestayLbl.TabIndex = 7;
            this.tuestayLbl.Text = "M";
            this.tuestayLbl.Click += new System.EventHandler(this.dayLabel_click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Día de Pago";
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
            this.ClientSize = new System.Drawing.Size(1164, 768);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Panel_Empleados";
            this.ShowInTaskbar = false;
            this.Text = "Empleados | Point of Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_Empleados_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Empleados_Load);
            this.Resize += new System.EventHandler(this.Panel_Empleados_Resize);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeeBtn)).EndInit();
            this.EmployeePanel.ResumeLayout(false);
            this.accionsPanel.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.basicInfoPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel basicInfoPanel;
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
        private System.Windows.Forms.Label debtLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button changePassBtn;
        private Button deleteEmployeeBtn;
        private Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 paymentDebtBtn;
        private Panel panel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox salaryTxt;
    }
}