using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS
{
    partial class Panel_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Clientes));
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.NombreLbl = new System.Windows.Forms.TextBox();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SaldoLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AbonoLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.InhibitBtn = new System.Windows.Forms.Button();
            this.AbonarBtn = new System.Windows.Forms.Button();
            this.PreciosBtn = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.ListaClientesBtn = new System.Windows.Forms.Button();
            this.PagosBtn = new System.Windows.Forms.Button();
            this.printTicketBtn = new System.Windows.Forms.Button();
            this.DetalleCompraDataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DireccionLbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TelefonoLbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.customerPaymentDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.deleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCompraDataGridView1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxt.Location = new System.Drawing.Point(134, 76);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(505, 30);
            this.SearchTxt.TabIndex = 0;
            this.SearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown_1);
            // 
            // NombreLbl
            // 
            this.NombreLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.NombreLbl.Location = new System.Drawing.Point(12, 157);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(413, 24);
            this.NombreLbl.TabIndex = 29;
            this.NombreLbl.Text = "Nombre";
            this.NombreLbl.Visible = false;
            this.NombreLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            this.NombreLbl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreLbl_KeyPress);
            this.NombreLbl.Leave += new System.EventHandler(this.NombreLbl_Leave);
            // 
            // discountTxt
            // 
            this.discountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.discountTxt.Location = new System.Drawing.Point(667, 28);
            this.discountTxt.MaxLength = 6;
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(117, 30);
            this.discountTxt.TabIndex = 42;
            this.discountTxt.Text = "0%";
            this.discountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountTxt.Visible = false;
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            this.discountTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountTxt_KeyDown);
            this.discountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTxt_KeyPress);
            this.discountTxt.Leave += new System.EventHandler(this.discountTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(4, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado de Cuenta";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(564, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Saldo Actual";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(546, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Estado:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(447, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Saldo Pendiente";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(8, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tel.:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(8, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Dirección:";
            this.label7.Visible = false;
            // 
            // SaldoLbl
            // 
            this.SaldoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaldoLbl.AutoSize = true;
            this.SaldoLbl.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaldoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.SaldoLbl.Location = new System.Drawing.Point(707, 193);
            this.SaldoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaldoLbl.Name = "SaldoLbl";
            this.SaldoLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaldoLbl.Size = new System.Drawing.Size(83, 32);
            this.SaldoLbl.TabIndex = 14;
            this.SaldoLbl.Text = "$0.00";
            this.SaldoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaldoLbl.Visible = false;
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.TotalLbl.Location = new System.Drawing.Point(698, 426);
            this.TotalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLbl.Size = new System.Drawing.Size(83, 32);
            this.TotalLbl.TabIndex = 17;
            this.TotalLbl.Text = "$0.00";
            this.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalLbl.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.label10.Location = new System.Drawing.Point(611, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total";
            this.label10.Visible = false;
            // 
            // AbonoLbl
            // 
            this.AbonoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbonoLbl.AutoSize = true;
            this.AbonoLbl.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbonoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.AbonoLbl.Location = new System.Drawing.Point(698, 471);
            this.AbonoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AbonoLbl.Name = "AbonoLbl";
            this.AbonoLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AbonoLbl.Size = new System.Drawing.Size(83, 32);
            this.AbonoLbl.TabIndex = 27;
            this.AbonoLbl.Text = "$0.00";
            this.AbonoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AbonoLbl.Visible = false;
            // 
            // InfoLbl
            // 
            this.InfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.InfoLbl.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.InfoLbl.Location = new System.Drawing.Point(481, 327);
            this.InfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(275, 64);
            this.InfoLbl.TabIndex = 32;
            this.InfoLbl.Text = "No hay Información\r\nDisponible";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoLbl.Visible = false;
            // 
            // discountLbl
            // 
            this.discountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLbl.AutoSize = true;
            this.discountLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.discountLbl.Location = new System.Drawing.Point(519, 28);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(142, 28);
            this.discountLbl.TabIndex = 40;
            this.discountLbl.Text = "Descuento:";
            this.discountLbl.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(48, 242);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(293, 149);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Nuevo Cliente";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // InhibitBtn
            // 
            this.InhibitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InhibitBtn.AutoSize = true;
            this.InhibitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.InhibitBtn.FlatAppearance.BorderSize = 0;
            this.InhibitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InhibitBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InhibitBtn.ForeColor = System.Drawing.Color.White;
            this.InhibitBtn.Location = new System.Drawing.Point(667, 156);
            this.InhibitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InhibitBtn.Name = "InhibitBtn";
            this.InhibitBtn.Size = new System.Drawing.Size(118, 37);
            this.InhibitBtn.TabIndex = 10;
            this.InhibitBtn.Text = "Inactivo";
            this.InhibitBtn.UseVisualStyleBackColor = false;
            this.InhibitBtn.Visible = false;
            this.InhibitBtn.Click += new System.EventHandler(this.InhibitBtn_Click);
            this.InhibitBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // AbonarBtn
            // 
            this.AbonarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AbonarBtn.AutoSize = true;
            this.AbonarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.AbonarBtn.FlatAppearance.BorderSize = 0;
            this.AbonarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbonarBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbonarBtn.ForeColor = System.Drawing.Color.White;
            this.AbonarBtn.Location = new System.Drawing.Point(355, 551);
            this.AbonarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AbonarBtn.Name = "AbonarBtn";
            this.AbonarBtn.Size = new System.Drawing.Size(214, 65);
            this.AbonarBtn.TabIndex = 19;
            this.AbonarBtn.Text = "Abonar";
            this.AbonarBtn.UseVisualStyleBackColor = false;
            this.AbonarBtn.Visible = false;
            this.AbonarBtn.Click += new System.EventHandler(this.AbonarBtn_Click);
            this.AbonarBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // PreciosBtn
            // 
            this.PreciosBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreciosBtn.AutoSize = true;
            this.PreciosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.PreciosBtn.FlatAppearance.BorderSize = 0;
            this.PreciosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreciosBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciosBtn.ForeColor = System.Drawing.Color.White;
            this.PreciosBtn.Location = new System.Drawing.Point(667, 114);
            this.PreciosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PreciosBtn.Name = "PreciosBtn";
            this.PreciosBtn.Size = new System.Drawing.Size(118, 37);
            this.PreciosBtn.TabIndex = 24;
            this.PreciosBtn.Text = "Precios";
            this.PreciosBtn.UseVisualStyleBackColor = false;
            this.PreciosBtn.Visible = false;
            this.PreciosBtn.Click += new System.EventHandler(this.PreciosBtn_Click);
            this.PreciosBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar.AutoSize = true;
            this.Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.Buscar.FlatAppearance.BorderSize = 0;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(667, 71);
            this.Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(118, 37);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            this.Buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // ListaClientesBtn
            // 
            this.ListaClientesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListaClientesBtn.AutoSize = true;
            this.ListaClientesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.ListaClientesBtn.FlatAppearance.BorderSize = 0;
            this.ListaClientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListaClientesBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientesBtn.ForeColor = System.Drawing.Color.White;
            this.ListaClientesBtn.Location = new System.Drawing.Point(463, 242);
            this.ListaClientesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ListaClientesBtn.Name = "ListaClientesBtn";
            this.ListaClientesBtn.Size = new System.Drawing.Size(293, 149);
            this.ListaClientesBtn.TabIndex = 2;
            this.ListaClientesBtn.Text = "Lista de Clientes";
            this.ListaClientesBtn.UseVisualStyleBackColor = false;
            this.ListaClientesBtn.Click += new System.EventHandler(this.ListaClientesBtn_Click);
            this.ListaClientesBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // PagosBtn
            // 
            this.PagosBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PagosBtn.AutoSize = true;
            this.PagosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.PagosBtn.FlatAppearance.BorderSize = 0;
            this.PagosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagosBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagosBtn.ForeColor = System.Drawing.Color.White;
            this.PagosBtn.Location = new System.Drawing.Point(292, 131);
            this.PagosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PagosBtn.Name = "PagosBtn";
            this.PagosBtn.Size = new System.Drawing.Size(210, 62);
            this.PagosBtn.TabIndex = 39;
            this.PagosBtn.Text = "Historial de Pagos";
            this.PagosBtn.UseVisualStyleBackColor = false;
            this.PagosBtn.Visible = false;
            this.PagosBtn.Click += new System.EventHandler(this.PagosBtn_Click);
            // 
            // printTicketBtn
            // 
            this.printTicketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printTicketBtn.AutoSize = true;
            this.printTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.printTicketBtn.FlatAppearance.BorderSize = 0;
            this.printTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printTicketBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTicketBtn.ForeColor = System.Drawing.Color.White;
            this.printTicketBtn.Location = new System.Drawing.Point(11, 565);
            this.printTicketBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printTicketBtn.Name = "printTicketBtn";
            this.printTicketBtn.Size = new System.Drawing.Size(214, 36);
            this.printTicketBtn.TabIndex = 46;
            this.printTicketBtn.Text = "Imprimir ticket";
            this.printTicketBtn.UseVisualStyleBackColor = false;
            this.printTicketBtn.Visible = false;
            this.printTicketBtn.Click += new System.EventHandler(this.printTicketBtn_Click);
            // 
            // DetalleCompraDataGridView1
            // 
            this.DetalleCompraDataGridView1.AllowUserToAddRows = false;
            this.DetalleCompraDataGridView1.AllowUserToDeleteRows = false;
            this.DetalleCompraDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleCompraDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleCompraDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DetalleCompraDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DetalleCompraDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetalleCompraDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetalleCompraDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetalleCompraDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DetalleCompraDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetalleCompraDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DetalleCompraDataGridView1.Location = new System.Drawing.Point(429, 239);
            this.DetalleCompraDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DetalleCompraDataGridView1.MultiSelect = false;
            this.DetalleCompraDataGridView1.Name = "DetalleCompraDataGridView1";
            this.DetalleCompraDataGridView1.ReadOnly = true;
            this.DetalleCompraDataGridView1.RowHeadersVisible = false;
            this.DetalleCompraDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DetalleCompraDataGridView1.RowTemplate.Height = 24;
            this.DetalleCompraDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleCompraDataGridView1.Size = new System.Drawing.Size(356, 185);
            this.DetalleCompraDataGridView1.TabIndex = 16;
            this.DetalleCompraDataGridView1.Visible = false;
            this.DetalleCompraDataGridView1.DataSourceChanged += new System.EventHandler(this.DetalleCompraDataGridView1_DataSourceChanged);
            this.DetalleCompraDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 238);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(415, 309);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DireccionLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DireccionLbl.HintForeColor = System.Drawing.Color.Silver;
            this.DireccionLbl.HintText = "Dirección";
            this.DireccionLbl.isPassword = false;
            this.DireccionLbl.LineFocusedColor = System.Drawing.Color.Transparent;
            this.DireccionLbl.LineIdleColor = System.Drawing.Color.Gray;
            this.DireccionLbl.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.DireccionLbl.LineThickness = 1;
            this.DireccionLbl.Location = new System.Drawing.Point(108, 206);
            this.DireccionLbl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(317, 29);
            this.DireccionLbl.TabIndex = 38;
            this.DireccionLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DireccionLbl.Visible = false;
            this.DireccionLbl.OnValueChanged += new System.EventHandler(this.DireccionLbl_OnValueChanged);
            this.DireccionLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            this.DireccionLbl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DireccionLbl_KeyPress);
            this.DireccionLbl.Leave += new System.EventHandler(this.DireccionLbl_Leave);
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TelefonoLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TelefonoLbl.HintForeColor = System.Drawing.Color.Silver;
            this.TelefonoLbl.HintText = "Telefono";
            this.TelefonoLbl.isPassword = false;
            this.TelefonoLbl.LineFocusedColor = System.Drawing.Color.Transparent;
            this.TelefonoLbl.LineIdleColor = System.Drawing.Color.Gray;
            this.TelefonoLbl.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.TelefonoLbl.LineThickness = 1;
            this.TelefonoLbl.Location = new System.Drawing.Point(48, 176);
            this.TelefonoLbl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(204, 29);
            this.TelefonoLbl.TabIndex = 37;
            this.TelefonoLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TelefonoLbl.Visible = false;
            this.TelefonoLbl.OnValueChanged += new System.EventHandler(this.TelefonoLbl_OnValueChanged);
            this.TelefonoLbl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            this.TelefonoLbl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoLbl_KeyPress);
            this.TelefonoLbl.Leave += new System.EventHandler(this.telefonoLbl_Leave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 14;
            this.bunifuElipse1.TargetControl = this.AddButton;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 14;
            this.bunifuElipse2.TargetControl = this.ListaClientesBtn;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.InhibitBtn;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(805, 25);
            this.bunifuGradientPanel1.TabIndex = 45;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(773, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(744, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 4;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            this.MimimizeBtn.Click += new System.EventHandler(this.MimimizeBtn_Click);
            // 
            // customerPaymentDocument
            // 
            this.customerPaymentDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.customerPaymentDocument_PrintPage);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCustomer.AutoSize = true;
            this.deleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.deleteCustomer.FlatAppearance.BorderSize = 0;
            this.deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomer.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.deleteCustomer.Location = new System.Drawing.Point(617, 565);
            this.deleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(177, 36);
            this.deleteCustomer.TabIndex = 47;
            this.deleteCustomer.Text = "Borrar Cliente";
            this.deleteCustomer.UseVisualStyleBackColor = false;
            this.deleteCustomer.Visible = false;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // Panel_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 626);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.PagosBtn);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.TelefonoLbl);
            this.Controls.Add(this.DireccionLbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DetalleCompraDataGridView1);
            this.Controls.Add(this.printTicketBtn);
            this.Controls.Add(this.ListaClientesBtn);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.PreciosBtn);
            this.Controls.Add(this.AbonarBtn);
            this.Controls.Add(this.InhibitBtn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.AbonoLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.SaldoLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discountTxt);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.SearchTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Panel_Clientes";
            this.ShowInTaskbar = false;
            this.Text = "Clientes | Point of Sale";
            this.Load += new System.EventHandler(this.Panel_Clientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCompraDataGridView1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.TextBox NombreLbl;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SaldoLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AbonoLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button InhibitBtn;
        private System.Windows.Forms.Button AbonarBtn;
        private System.Windows.Forms.Button PreciosBtn;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button ListaClientesBtn;
        private System.Windows.Forms.Button PagosBtn;
        private System.Windows.Forms.Button printTicketBtn;
        private System.Windows.Forms.DataGridView DetalleCompraDataGridView1;
        private System.Windows.Forms.ListView listView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DireccionLbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TelefonoLbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Drawing.Printing.PrintDocument customerPaymentDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Button deleteCustomer;
    }
}