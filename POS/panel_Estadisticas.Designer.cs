﻿namespace POS
{
    partial class panel_Estadisticas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel_Estadisticas));
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.scrapNoInfoLbl = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scrapGridView = new System.Windows.Forms.DataGridView();
            this.ProductStatisticsCard = new Bunifu.Framework.UI.BunifuCards();
            this.statisticsProductsProductLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productStatisticsChart = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.StatisticsProductTxt = new System.Windows.Forms.TextBox();
            this.investmentProfitStatisticsCard = new Bunifu.Framework.UI.BunifuCards();
            this.investmentProfitChart = new LiveCharts.WinForms.CartesianChart();
            this.InvestmentProfitLbl = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.bestSellersCard = new Bunifu.Framework.UI.BunifuCards();
            this.bestSellerNoInfoLbl = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bestSellGridView = new System.Windows.Forms.DataGridView();
            this.periodTimeCombo = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.MimimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.StatisticsPanel.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrapGridView)).BeginInit();
            this.ProductStatisticsCard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.investmentProfitStatisticsCard.SuspendLayout();
            this.bestSellersCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellGridView)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.BackColor = System.Drawing.Color.White;
            this.StatisticsPanel.Controls.Add(this.label2);
            this.StatisticsPanel.Controls.Add(this.bunifuCards1);
            this.StatisticsPanel.Controls.Add(this.ProductStatisticsCard);
            this.StatisticsPanel.Controls.Add(this.investmentProfitStatisticsCard);
            this.StatisticsPanel.Controls.Add(this.datePicker);
            this.StatisticsPanel.Controls.Add(this.bestSellersCard);
            this.StatisticsPanel.Controls.Add(this.periodTimeCombo);
            this.StatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsPanel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.StatisticsPanel.Location = new System.Drawing.Point(0, 25);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Size = new System.Drawing.Size(1557, 783);
            this.StatisticsPanel.TabIndex = 14;
            this.StatisticsPanel.Resize += new System.EventHandler(this.StatisticsPanel_Resize);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estadísticos";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 10;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.scrapNoInfoLbl);
            this.bunifuCards1.Controls.Add(this.splitContainer1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 98);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 50;
            this.bunifuCards1.Size = new System.Drawing.Size(389, 655);
            this.bunifuCards1.TabIndex = 0;
            // 
            // scrapNoInfoLbl
            // 
            this.scrapNoInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.scrapNoInfoLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapNoInfoLbl.Location = new System.Drawing.Point(-6, 223);
            this.scrapNoInfoLbl.Name = "scrapNoInfoLbl";
            this.scrapNoInfoLbl.Size = new System.Drawing.Size(400, 98);
            this.scrapNoInfoLbl.TabIndex = 7;
            this.scrapNoInfoLbl.Text = "No se encontró información";
            this.scrapNoInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pieChart2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scrapGridView);
            this.splitContainer1.Size = new System.Drawing.Size(389, 655);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 4;
            // 
            // scrapGridView
            // 
            this.scrapGridView.AllowUserToAddRows = false;
            this.scrapGridView.AllowUserToDeleteRows = false;
            this.scrapGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.scrapGridView.BackgroundColor = System.Drawing.Color.White;
            this.scrapGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scrapGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.scrapGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scrapGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.scrapGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scrapGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.scrapGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrapGridView.EnableHeadersVisualStyles = false;
            this.scrapGridView.GridColor = System.Drawing.Color.White;
            this.scrapGridView.Location = new System.Drawing.Point(0, 0);
            this.scrapGridView.MultiSelect = false;
            this.scrapGridView.Name = "scrapGridView";
            this.scrapGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scrapGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.scrapGridView.RowHeadersVisible = false;
            this.scrapGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scrapGridView.Size = new System.Drawing.Size(389, 251);
            this.scrapGridView.TabIndex = 14;
            this.scrapGridView.DataSourceChanged += new System.EventHandler(this.scrapGridView_DataSourceChanged);
            // 
            // ProductStatisticsCard
            // 
            this.ProductStatisticsCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductStatisticsCard.BackColor = System.Drawing.Color.White;
            this.ProductStatisticsCard.BorderRadius = 5;
            this.ProductStatisticsCard.BottomSahddow = true;
            this.ProductStatisticsCard.color = System.Drawing.Color.CornflowerBlue;
            this.ProductStatisticsCard.Controls.Add(this.statisticsProductsProductLbl);
            this.ProductStatisticsCard.Controls.Add(this.panel2);
            this.ProductStatisticsCard.LeftSahddow = false;
            this.ProductStatisticsCard.Location = new System.Drawing.Point(819, 481);
            this.ProductStatisticsCard.Name = "ProductStatisticsCard";
            this.ProductStatisticsCard.RightSahddow = true;
            this.ProductStatisticsCard.ShadowDepth = 20;
            this.ProductStatisticsCard.Size = new System.Drawing.Size(1004, 272);
            this.ProductStatisticsCard.TabIndex = 8;
            this.ProductStatisticsCard.Resize += new System.EventHandler(this.ProductStatisticsCard_Resize);
            // 
            // statisticsProductsProductLbl
            // 
            this.statisticsProductsProductLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsProductsProductLbl.AutoSize = true;
            this.statisticsProductsProductLbl.BackColor = System.Drawing.Color.Transparent;
            this.statisticsProductsProductLbl.Location = new System.Drawing.Point(302, 60);
            this.statisticsProductsProductLbl.Name = "statisticsProductsProductLbl";
            this.statisticsProductsProductLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statisticsProductsProductLbl.Size = new System.Drawing.Size(95, 32);
            this.statisticsProductsProductLbl.TabIndex = 3;
            this.statisticsProductsProductLbl.Text = "          ";
            this.statisticsProductsProductLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsProductsProductLbl.TextChanged += new System.EventHandler(this.statisticsProductsProductLbl_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productStatisticsChart);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 272);
            this.panel2.TabIndex = 9;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // productStatisticsChart
            // 
            this.productStatisticsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productStatisticsChart.Location = new System.Drawing.Point(0, 54);
            this.productStatisticsChart.Name = "productStatisticsChart";
            this.productStatisticsChart.Size = new System.Drawing.Size(1004, 218);
            this.productStatisticsChart.TabIndex = 2;
            this.productStatisticsChart.Text = "cartesianChart2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StatisticsProductTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 54);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producto:";
            // 
            // StatisticsProductTxt
            // 
            this.StatisticsProductTxt.Location = new System.Drawing.Point(245, 7);
            this.StatisticsProductTxt.Name = "StatisticsProductTxt";
            this.StatisticsProductTxt.Size = new System.Drawing.Size(385, 41);
            this.StatisticsProductTxt.TabIndex = 1;
            this.StatisticsProductTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatisticsProductTxt_KeyDown);
            // 
            // investmentProfitStatisticsCard
            // 
            this.investmentProfitStatisticsCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.investmentProfitStatisticsCard.BackColor = System.Drawing.Color.White;
            this.investmentProfitStatisticsCard.BorderRadius = 5;
            this.investmentProfitStatisticsCard.BottomSahddow = true;
            this.investmentProfitStatisticsCard.color = System.Drawing.Color.Gold;
            this.investmentProfitStatisticsCard.Controls.Add(this.investmentProfitChart);
            this.investmentProfitStatisticsCard.Controls.Add(this.InvestmentProfitLbl);
            this.investmentProfitStatisticsCard.LeftSahddow = false;
            this.investmentProfitStatisticsCard.Location = new System.Drawing.Point(819, 98);
            this.investmentProfitStatisticsCard.Name = "investmentProfitStatisticsCard";
            this.investmentProfitStatisticsCard.RightSahddow = true;
            this.investmentProfitStatisticsCard.ShadowDepth = 20;
            this.investmentProfitStatisticsCard.Size = new System.Drawing.Size(1004, 272);
            this.investmentProfitStatisticsCard.TabIndex = 7;
            this.investmentProfitStatisticsCard.SizeChanged += new System.EventHandler(this.investmentProfitStatisticsCard_SizeChanged);
            // 
            // investmentProfitChart
            // 
            this.investmentProfitChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.investmentProfitChart.Location = new System.Drawing.Point(0, 0);
            this.investmentProfitChart.Name = "investmentProfitChart";
            this.investmentProfitChart.Size = new System.Drawing.Size(1004, 272);
            this.investmentProfitChart.TabIndex = 1;
            this.investmentProfitChart.Text = "cartesianChart1";
            // 
            // InvestmentProfitLbl
            // 
            this.InvestmentProfitLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvestmentProfitLbl.AutoSize = true;
            this.InvestmentProfitLbl.BackColor = System.Drawing.Color.Transparent;
            this.InvestmentProfitLbl.Location = new System.Drawing.Point(451, 8);
            this.InvestmentProfitLbl.Name = "InvestmentProfitLbl";
            this.InvestmentProfitLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvestmentProfitLbl.Size = new System.Drawing.Size(275, 32);
            this.InvestmentProfitLbl.TabIndex = 11;
            this.InvestmentProfitLbl.Text = "Ganancia/Inversión";
            this.InvestmentProfitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(1325, 11);
            this.datePicker.MaxDate = new System.DateTime(2019, 11, 6, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 41);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2019, 11, 6, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // bestSellersCard
            // 
            this.bestSellersCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bestSellersCard.BackColor = System.Drawing.Color.White;
            this.bestSellersCard.BorderRadius = 5;
            this.bestSellersCard.BottomSahddow = true;
            this.bestSellersCard.color = System.Drawing.Color.LimeGreen;
            this.bestSellersCard.Controls.Add(this.bestSellerNoInfoLbl);
            this.bestSellersCard.Controls.Add(this.splitContainer2);
            this.bestSellersCard.LeftSahddow = false;
            this.bestSellersCard.Location = new System.Drawing.Point(417, 98);
            this.bestSellersCard.Name = "bestSellersCard";
            this.bestSellersCard.RightSahddow = true;
            this.bestSellersCard.ShadowDepth = 20;
            this.bestSellersCard.Size = new System.Drawing.Size(392, 655);
            this.bestSellersCard.TabIndex = 4;
            // 
            // bestSellerNoInfoLbl
            // 
            this.bestSellerNoInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.bestSellerNoInfoLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestSellerNoInfoLbl.Location = new System.Drawing.Point(-4, 223);
            this.bestSellerNoInfoLbl.Name = "bestSellerNoInfoLbl";
            this.bestSellerNoInfoLbl.Size = new System.Drawing.Size(400, 98);
            this.bestSellerNoInfoLbl.TabIndex = 6;
            this.bestSellerNoInfoLbl.Text = "No se encontró información";
            this.bestSellerNoInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pieChart1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.bestSellGridView);
            this.splitContainer2.Size = new System.Drawing.Size(392, 655);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.TabIndex = 5;
            // 
            // bestSellGridView
            // 
            this.bestSellGridView.AllowUserToAddRows = false;
            this.bestSellGridView.AllowUserToDeleteRows = false;
            this.bestSellGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bestSellGridView.BackgroundColor = System.Drawing.Color.White;
            this.bestSellGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestSellGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bestSellGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bestSellGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bestSellGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bestSellGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.bestSellGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestSellGridView.EnableHeadersVisualStyles = false;
            this.bestSellGridView.GridColor = System.Drawing.Color.White;
            this.bestSellGridView.Location = new System.Drawing.Point(0, 0);
            this.bestSellGridView.MultiSelect = false;
            this.bestSellGridView.Name = "bestSellGridView";
            this.bestSellGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bestSellGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.bestSellGridView.RowHeadersVisible = false;
            this.bestSellGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bestSellGridView.Size = new System.Drawing.Size(392, 251);
            this.bestSellGridView.TabIndex = 14;
            this.bestSellGridView.DataSourceChanged += new System.EventHandler(this.bestSellGridView_DataSourceChanged);
            this.bestSellGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.bestSellGridView_CellFormatting);
            this.bestSellGridView.SizeChanged += new System.EventHandler(this.bestSellGridView_SizeChanged);
            // 
            // periodTimeCombo
            // 
            this.periodTimeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodTimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodTimeCombo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodTimeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.periodTimeCombo.FormattingEnabled = true;
            this.periodTimeCombo.Items.AddRange(new object[] {
            "Día",
            "Mensual",
            "Anual",
            "Todo"});
            this.periodTimeCombo.Location = new System.Drawing.Point(1322, 58);
            this.periodTimeCombo.Name = "periodTimeCombo";
            this.periodTimeCombo.Size = new System.Drawing.Size(203, 33);
            this.periodTimeCombo.TabIndex = 2;
            this.periodTimeCombo.SelectedIndexChanged += new System.EventHandler(this.periodTimeCombo_SelectedIndexChanged);
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.MimimizeBtn);
            this.bunifuGradientPanel3.Controls.Add(this.closeBtn);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1557, 25);
            this.bunifuGradientPanel3.TabIndex = 15;
            // 
            // MimimizeBtn
            // 
            this.MimimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MimimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MimimizeBtn.Image = global::POS.Properties.Resources.minimize;
            this.MimimizeBtn.ImageActive = null;
            this.MimimizeBtn.Location = new System.Drawing.Point(1505, 2);
            this.MimimizeBtn.Name = "MimimizeBtn";
            this.MimimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MimimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimimizeBtn.TabIndex = 6;
            this.MimimizeBtn.TabStop = false;
            this.MimimizeBtn.Zoom = 10;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::POS.Properties.Resources.close;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1534, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 5;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            // 
            // pieChart2
            // 
            this.pieChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart2.Location = new System.Drawing.Point(0, 0);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(389, 400);
            this.pieChart2.TabIndex = 0;
            this.pieChart2.Text = "pieChart2";
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(392, 400);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // panel_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 808);
            this.Controls.Add(this.StatisticsPanel);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "panel_Estadisticas";
            this.ShowInTaskbar = false;
            this.Text = "Estadísticas | Point of Sale";
            this.StatisticsPanel.ResumeLayout(false);
            this.StatisticsPanel.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scrapGridView)).EndInit();
            this.ProductStatisticsCard.ResumeLayout(false);
            this.ProductStatisticsCard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.investmentProfitStatisticsCard.ResumeLayout(false);
            this.investmentProfitStatisticsCard.PerformLayout();
            this.bestSellersCard.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bestSellGridView)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MimimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StatisticsPanel;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label scrapNoInfoLbl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView scrapGridView;
        private Bunifu.Framework.UI.BunifuCards ProductStatisticsCard;
        private System.Windows.Forms.Panel panel2;
        private LiveCharts.WinForms.CartesianChart productStatisticsChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StatisticsProductTxt;
        private System.Windows.Forms.Label statisticsProductsProductLbl;
        private Bunifu.Framework.UI.BunifuCards investmentProfitStatisticsCard;
        private LiveCharts.WinForms.CartesianChart investmentProfitChart;
        private System.Windows.Forms.Label InvestmentProfitLbl;
        private System.Windows.Forms.DateTimePicker datePicker;
        private Bunifu.Framework.UI.BunifuCards bestSellersCard;
        private System.Windows.Forms.Label bestSellerNoInfoLbl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView bestSellGridView;
        private System.Windows.Forms.ComboBox periodTimeCombo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton MimimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}