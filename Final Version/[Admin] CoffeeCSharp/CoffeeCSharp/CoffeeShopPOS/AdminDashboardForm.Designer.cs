using System;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 320D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 240D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 180D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 310D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 120D);
            this.lblSidebarTesting = new System.Windows.Forms.Label();
            this.lblSidebarStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProductsSales = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pbSidebarGreen = new System.Windows.Forms.PictureBox();
            this.pBSidebar = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLowStockAdmin = new System.Windows.Forms.Panel();
            this.lvLowStockAdmin = new System.Windows.Forms.ListView();
            this.ColumnHeaderAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAmin1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdmin2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdmin3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdmin4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdmin5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStockTitleAdmin = new System.Windows.Forms.Label();
            this.lblAdminTopTitle = new System.Windows.Forms.Label();
            this.chartAdminTopSelling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelAdminCard4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAdminProductValue = new System.Windows.Forms.Label();
            this.lblAdminProduct = new System.Windows.Forms.Label();
            this.panelAdminCard3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAdminCustomerValue = new System.Windows.Forms.Label();
            this.lblAdminCustomer = new System.Windows.Forms.Label();
            this.panelAdminCard2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminMonth = new System.Windows.Forms.Label();
            this.lblAdminMonthly = new System.Windows.Forms.Label();
            this.panelAdminCard1 = new System.Windows.Forms.Panel();
            this.pbTotalMoneyCardAdmin = new System.Windows.Forms.PictureBox();
            this.lblAdminSales = new System.Windows.Forms.Label();
            this.panelAdminSalesValue = new System.Windows.Forms.Label();
            this.dgvAdminDashboard = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSearchDashboard = new System.Windows.Forms.Label();
            this.pictureBoxSearchIconDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBoxBellIconDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBoxCartDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccountDashboard = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBoxSearchBarDashboard = new System.Windows.Forms.TextBox();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSidebar)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLowStockAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAdminTopSelling)).BeginInit();
            this.panelAdminCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelAdminCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAdminCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAdminCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalMoneyCardAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminDashboard)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBellIconDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSidebarTesting
            // 
            this.lblSidebarTesting.AutoSize = true;
            this.lblSidebarTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarTesting.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTesting.Location = new System.Drawing.Point(85, 33);
            this.lblSidebarTesting.Name = "lblSidebarTesting";
            this.lblSidebarTesting.Size = new System.Drawing.Size(61, 20);
            this.lblSidebarTesting.TabIndex = 2;
            this.lblSidebarTesting.Text = "Admin";
            // 
            // lblSidebarStatus
            // 
            this.lblSidebarStatus.AutoSize = true;
            this.lblSidebarStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSidebarStatus.Location = new System.Drawing.Point(102, 57);
            this.lblSidebarStatus.Name = "lblSidebarStatus";
            this.lblSidebarStatus.Size = new System.Drawing.Size(49, 17);
            this.lblSidebarStatus.TabIndex = 2;
            this.lblSidebarStatus.Text = "Online";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 506);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(12, 259);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(140, 40);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "Customers ";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(12, 210);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(140, 40);
            this.btnInventory.TabIndex = 7;
            this.btnInventory.Text = "Inventory ";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProductsSales
            // 
            this.btnProductsSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnProductsSales.FlatAppearance.BorderSize = 0;
            this.btnProductsSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsSales.ForeColor = System.Drawing.Color.White;
            this.btnProductsSales.Location = new System.Drawing.Point(12, 160);
            this.btnProductsSales.Name = "btnProductsSales";
            this.btnProductsSales.Size = new System.Drawing.Size(140, 40);
            this.btnProductsSales.TabIndex = 6;
            this.btnProductsSales.Text = "Products and Sales ";
            this.btnProductsSales.UseVisualStyleBackColor = false;
            this.btnProductsSales.Click += new System.EventHandler(this.btnProductsSales_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 110);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 40);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.Controls.Add(this.pbSidebarGreen);
            this.panelSidebar.Controls.Add(this.lblSidebarTesting);
            this.panelSidebar.Controls.Add(this.lblSidebarStatus);
            this.panelSidebar.Controls.Add(this.pBSidebar);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnReporting);
            this.panelSidebar.Controls.Add(this.btnStaffManagement);
            this.panelSidebar.Controls.Add(this.btnMembership);
            this.panelSidebar.Controls.Add(this.btnCustomer);
            this.panelSidebar.Controls.Add(this.btnInventory);
            this.panelSidebar.Controls.Add(this.btnProductsSales);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(163, 701);
            this.panelSidebar.TabIndex = 107;
            // 
            // pbSidebarGreen
            // 
            this.pbSidebarGreen.Image = global::CoffeeShopPOS.Properties.Resources.green1;
            this.pbSidebarGreen.Location = new System.Drawing.Point(90, 53);
            this.pbSidebarGreen.Name = "pbSidebarGreen";
            this.pbSidebarGreen.Size = new System.Drawing.Size(12, 25);
            this.pbSidebarGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSidebarGreen.TabIndex = 2;
            this.pbSidebarGreen.TabStop = false;
            // 
            // pBSidebar
            // 
            this.pBSidebar.Image = global::CoffeeShopPOS.Properties.Resources.admin;
            this.pBSidebar.Location = new System.Drawing.Point(16, 24);
            this.pBSidebar.Name = "pBSidebar";
            this.pBSidebar.Size = new System.Drawing.Size(65, 61);
            this.pBSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSidebar.TabIndex = 0;
            this.pBSidebar.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(12, 457);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(140, 40);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.ForeColor = System.Drawing.Color.White;
            this.btnReporting.Location = new System.Drawing.Point(12, 408);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(140, 40);
            this.btnReporting.TabIndex = 2;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.UseVisualStyleBackColor = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStaffManagement.FlatAppearance.BorderSize = 0;
            this.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffManagement.ForeColor = System.Drawing.Color.White;
            this.btnStaffManagement.Location = new System.Drawing.Point(12, 358);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(140, 40);
            this.btnStaffManagement.TabIndex = 1;
            this.btnStaffManagement.Text = "Staff Management ";
            this.btnStaffManagement.UseVisualStyleBackColor = false;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Location = new System.Drawing.Point(12, 308);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(140, 40);
            this.btnMembership.TabIndex = 0;
            this.btnMembership.Text = "Membership ";
            this.btnMembership.UseVisualStyleBackColor = false;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(770, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.btnSearch);
            this.panelButtons.Controls.Add(this.txtSearch);
            this.panelButtons.Controls.Add(this.lblSearch);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1202, 2);
            this.panelButtons.TabIndex = 105;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(560, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(500, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 23);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelLowStockAdmin);
            this.panelMain.Controls.Add(this.lblAdminTopTitle);
            this.panelMain.Controls.Add(this.chartAdminTopSelling);
            this.panelMain.Controls.Add(this.panelAdminCard4);
            this.panelMain.Controls.Add(this.panelAdminCard3);
            this.panelMain.Controls.Add(this.panelAdminCard2);
            this.panelMain.Controls.Add(this.panelAdminCard1);
            this.panelMain.Controls.Add(this.dgvAdminDashboard);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(163, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1039, 643);
            this.panelMain.TabIndex = 109;
            // 
            // panelLowStockAdmin
            // 
            this.panelLowStockAdmin.Controls.Add(this.lvLowStockAdmin);
            this.panelLowStockAdmin.Controls.Add(this.lblLowStockTitleAdmin);
            this.panelLowStockAdmin.Location = new System.Drawing.Point(498, 190);
            this.panelLowStockAdmin.Name = "panelLowStockAdmin";
            this.panelLowStockAdmin.Size = new System.Drawing.Size(469, 410);
            this.panelLowStockAdmin.TabIndex = 36;
            // 
            // lvLowStockAdmin
            // 
            this.lvLowStockAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderAdmin,
            this.columnHeaderAmin1,
            this.columnHeaderAdmin2,
            this.columnHeaderAdmin3,
            this.columnHeaderAdmin4,
            this.columnHeaderAdmin5});
            this.lvLowStockAdmin.FullRowSelect = true;
            this.lvLowStockAdmin.GridLines = true;
            this.lvLowStockAdmin.HideSelection = false;
            this.lvLowStockAdmin.Location = new System.Drawing.Point(3, 38);
            this.lvLowStockAdmin.Name = "lvLowStockAdmin";
            this.lvLowStockAdmin.Size = new System.Drawing.Size(466, 369);
            this.lvLowStockAdmin.TabIndex = 1;
            this.lvLowStockAdmin.UseCompatibleStateImageBehavior = false;
            this.lvLowStockAdmin.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaderAdmin
            // 
            this.ColumnHeaderAdmin.Text = "Product";
            this.ColumnHeaderAdmin.Width = 75;
            // 
            // columnHeaderAmin1
            // 
            this.columnHeaderAmin1.Text = "Category";
            this.columnHeaderAmin1.Width = 80;
            // 
            // columnHeaderAdmin2
            // 
            this.columnHeaderAdmin2.Text = "Stock";
            this.columnHeaderAdmin2.Width = 70;
            // 
            // columnHeaderAdmin3
            // 
            this.columnHeaderAdmin3.Text = "Reorder";
            this.columnHeaderAdmin3.Width = 80;
            // 
            // columnHeaderAdmin4
            // 
            this.columnHeaderAdmin4.Text = "Status";
            this.columnHeaderAdmin4.Width = 70;
            // 
            // columnHeaderAdmin5
            // 
            this.columnHeaderAdmin5.Text = "Supplier";
            this.columnHeaderAdmin5.Width = 85;
            // 
            // lblLowStockTitleAdmin
            // 
            this.lblLowStockTitleAdmin.AutoSize = true;
            this.lblLowStockTitleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockTitleAdmin.Location = new System.Drawing.Point(3, 2);
            this.lblLowStockTitleAdmin.Name = "lblLowStockTitleAdmin";
            this.lblLowStockTitleAdmin.Size = new System.Drawing.Size(152, 20);
            this.lblLowStockTitleAdmin.TabIndex = 0;
            this.lblLowStockTitleAdmin.Text = "Low Stock Alerts";
            // 
            // lblAdminTopTitle
            // 
            this.lblAdminTopTitle.AutoSize = true;
            this.lblAdminTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTopTitle.Location = new System.Drawing.Point(122, 506);
            this.lblAdminTopTitle.Name = "lblAdminTopTitle";
            this.lblAdminTopTitle.Size = new System.Drawing.Size(208, 20);
            this.lblAdminTopTitle.TabIndex = 35;
            this.lblAdminTopTitle.Text = "Best Selling Categories";
            // 
            // chartAdminTopSelling
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAdminTopSelling.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAdminTopSelling.Legends.Add(legend2);
            this.chartAdminTopSelling.Location = new System.Drawing.Point(59, 200);
            this.chartAdminTopSelling.Name = "chartAdminTopSelling";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint6.IsValueShownAsLabel = true;
            dataPoint6.Label = "Coffee";
            dataPoint7.Label = "Milk Tea";
            dataPoint8.Label = "Bakery ";
            dataPoint9.Label = "Iced & Blended";
            dataPoint10.Label = "Desserts";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            this.chartAdminTopSelling.Series.Add(series2);
            this.chartAdminTopSelling.Size = new System.Drawing.Size(420, 283);
            this.chartAdminTopSelling.TabIndex = 34;
            // 
            // panelAdminCard4
            // 
            this.panelAdminCard4.BackColor = System.Drawing.Color.LightBlue;
            this.panelAdminCard4.Controls.Add(this.pictureBox3);
            this.panelAdminCard4.Controls.Add(this.lblAdminProductValue);
            this.panelAdminCard4.Controls.Add(this.lblAdminProduct);
            this.panelAdminCard4.Location = new System.Drawing.Point(767, 41);
            this.panelAdminCard4.Name = "panelAdminCard4";
            this.panelAdminCard4.Size = new System.Drawing.Size(200, 114);
            this.panelAdminCard4.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CoffeeShopPOS.Properties.Resources.producticon;
            this.pictureBox3.Location = new System.Drawing.Point(18, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblAdminProductValue
            // 
            this.lblAdminProductValue.AutoSize = true;
            this.lblAdminProductValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminProductValue.ForeColor = System.Drawing.Color.Black;
            this.lblAdminProductValue.Location = new System.Drawing.Point(76, 61);
            this.lblAdminProductValue.Name = "lblAdminProductValue";
            this.lblAdminProductValue.Size = new System.Drawing.Size(79, 20);
            this.lblAdminProductValue.TabIndex = 2;
            this.lblAdminProductValue.Text = "Value: 78";
            // 
            // lblAdminProduct
            // 
            this.lblAdminProduct.AutoSize = true;
            this.lblAdminProduct.Location = new System.Drawing.Point(77, 30);
            this.lblAdminProduct.Name = "lblAdminProduct";
            this.lblAdminProduct.Size = new System.Drawing.Size(76, 20);
            this.lblAdminProduct.TabIndex = 0;
            this.lblAdminProduct.Text = "Products";
            // 
            // panelAdminCard3
            // 
            this.panelAdminCard3.BackColor = System.Drawing.Color.PaleGreen;
            this.panelAdminCard3.Controls.Add(this.pictureBox2);
            this.panelAdminCard3.Controls.Add(this.lblAdminCustomerValue);
            this.panelAdminCard3.Controls.Add(this.lblAdminCustomer);
            this.panelAdminCard3.Location = new System.Drawing.Point(535, 41);
            this.panelAdminCard3.Name = "panelAdminCard3";
            this.panelAdminCard3.Size = new System.Drawing.Size(200, 114);
            this.panelAdminCard3.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoffeeShopPOS.Properties.Resources.Customer;
            this.pictureBox2.Location = new System.Drawing.Point(20, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblAdminCustomerValue
            // 
            this.lblAdminCustomerValue.AutoSize = true;
            this.lblAdminCustomerValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminCustomerValue.ForeColor = System.Drawing.Color.Black;
            this.lblAdminCustomerValue.Location = new System.Drawing.Point(72, 61);
            this.lblAdminCustomerValue.Name = "lblAdminCustomerValue";
            this.lblAdminCustomerValue.Size = new System.Drawing.Size(88, 20);
            this.lblAdminCustomerValue.TabIndex = 2;
            this.lblAdminCustomerValue.Text = "Value: 230";
            // 
            // lblAdminCustomer
            // 
            this.lblAdminCustomer.AutoSize = true;
            this.lblAdminCustomer.Location = new System.Drawing.Point(71, 30);
            this.lblAdminCustomer.Name = "lblAdminCustomer";
            this.lblAdminCustomer.Size = new System.Drawing.Size(91, 20);
            this.lblAdminCustomer.TabIndex = 0;
            this.lblAdminCustomer.Text = "Customers";
            // 
            // panelAdminCard2
            // 
            this.panelAdminCard2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelAdminCard2.Controls.Add(this.pictureBox1);
            this.panelAdminCard2.Controls.Add(this.lblAdminMonth);
            this.panelAdminCard2.Controls.Add(this.lblAdminMonthly);
            this.panelAdminCard2.Location = new System.Drawing.Point(304, 40);
            this.panelAdminCard2.Name = "panelAdminCard2";
            this.panelAdminCard2.Size = new System.Drawing.Size(200, 115);
            this.panelAdminCard2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShopPOS.Properties.Resources.Monthly_Monthly;
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminMonth
            // 
            this.lblAdminMonth.AutoSize = true;
            this.lblAdminMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminMonth.ForeColor = System.Drawing.Color.Black;
            this.lblAdminMonth.Location = new System.Drawing.Point(64, 62);
            this.lblAdminMonth.Name = "lblAdminMonth";
            this.lblAdminMonth.Size = new System.Drawing.Size(132, 20);
            this.lblAdminMonth.TabIndex = 2;
            this.lblAdminMonth.Text = "Value: $5,643.20";
            // 
            // lblAdminMonthly
            // 
            this.lblAdminMonthly.AutoSize = true;
            this.lblAdminMonthly.Location = new System.Drawing.Point(64, 31);
            this.lblAdminMonthly.Name = "lblAdminMonthly";
            this.lblAdminMonthly.Size = new System.Drawing.Size(114, 20);
            this.lblAdminMonthly.TabIndex = 0;
            this.lblAdminMonthly.Text = "Monthly Sales";
            // 
            // panelAdminCard1
            // 
            this.panelAdminCard1.BackColor = System.Drawing.Color.MistyRose;
            this.panelAdminCard1.Controls.Add(this.pbTotalMoneyCardAdmin);
            this.panelAdminCard1.Controls.Add(this.lblAdminSales);
            this.panelAdminCard1.Controls.Add(this.panelAdminSalesValue);
            this.panelAdminCard1.Location = new System.Drawing.Point(73, 39);
            this.panelAdminCard1.Name = "panelAdminCard1";
            this.panelAdminCard1.Size = new System.Drawing.Size(200, 116);
            this.panelAdminCard1.TabIndex = 30;
            // 
            // pbTotalMoneyCardAdmin
            // 
            this.pbTotalMoneyCardAdmin.Image = global::CoffeeShopPOS.Properties.Resources.Total_Money;
            this.pbTotalMoneyCardAdmin.Location = new System.Drawing.Point(5, 16);
            this.pbTotalMoneyCardAdmin.Name = "pbTotalMoneyCardAdmin";
            this.pbTotalMoneyCardAdmin.Size = new System.Drawing.Size(47, 70);
            this.pbTotalMoneyCardAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTotalMoneyCardAdmin.TabIndex = 2;
            this.pbTotalMoneyCardAdmin.TabStop = false;
            // 
            // lblAdminSales
            // 
            this.lblAdminSales.AutoSize = true;
            this.lblAdminSales.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminSales.ForeColor = System.Drawing.Color.Black;
            this.lblAdminSales.Location = new System.Drawing.Point(57, 32);
            this.lblAdminSales.Name = "lblAdminSales";
            this.lblAdminSales.Size = new System.Drawing.Size(143, 20);
            this.lblAdminSales.TabIndex = 0;
            this.lblAdminSales.Text = "Total Sales Today";
            // 
            // panelAdminSalesValue
            // 
            this.panelAdminSalesValue.AutoSize = true;
            this.panelAdminSalesValue.BackColor = System.Drawing.Color.Transparent;
            this.panelAdminSalesValue.ForeColor = System.Drawing.Color.Black;
            this.panelAdminSalesValue.Location = new System.Drawing.Point(59, 63);
            this.panelAdminSalesValue.Name = "panelAdminSalesValue";
            this.panelAdminSalesValue.Size = new System.Drawing.Size(119, 20);
            this.panelAdminSalesValue.TabIndex = 1;
            this.panelAdminSalesValue.Text = "Value: $123.45";
            // 
            // dgvAdminDashboard
            // 
            this.dgvAdminDashboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminDashboard.Location = new System.Drawing.Point(21, 20);
            this.dgvAdminDashboard.Name = "dgvAdminDashboard";
            this.dgvAdminDashboard.RowHeadersWidth = 51;
            this.dgvAdminDashboard.RowTemplate.Height = 28;
            this.dgvAdminDashboard.Size = new System.Drawing.Size(997, 600);
            this.dgvAdminDashboard.TabIndex = 29;
            this.dgvAdminDashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminDashboard_CellContentClick_3);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblSearchDashboard);
            this.panelHeader.Controls.Add(this.pictureBoxSearchIconDashboard);
            this.panelHeader.Controls.Add(this.pictureBoxBellIconDashboard);
            this.panelHeader.Controls.Add(this.pictureBoxCartDashboard);
            this.panelHeader.Controls.Add(this.pictureBoxAccountDashboard);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.textBoxSearchBarDashboard);
            this.panelHeader.Location = new System.Drawing.Point(163, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1039, 60);
            this.panelHeader.TabIndex = 108;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblSearchDashboard
            // 
            this.lblSearchDashboard.AutoSize = true;
            this.lblSearchDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDashboard.Location = new System.Drawing.Point(652, 21);
            this.lblSearchDashboard.Name = "lblSearchDashboard";
            this.lblSearchDashboard.Size = new System.Drawing.Size(62, 20);
            this.lblSearchDashboard.TabIndex = 25;
            this.lblSearchDashboard.Text = "Search";
            // 
            // pictureBoxSearchIconDashboard
            // 
            this.pictureBoxSearchIconDashboard.Image = global::CoffeeShopPOS.Properties.Resources.search1;
            this.pictureBoxSearchIconDashboard.Location = new System.Drawing.Point(831, 16);
            this.pictureBoxSearchIconDashboard.Name = "pictureBoxSearchIconDashboard";
            this.pictureBoxSearchIconDashboard.Size = new System.Drawing.Size(39, 29);
            this.pictureBoxSearchIconDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchIconDashboard.TabIndex = 24;
            this.pictureBoxSearchIconDashboard.TabStop = false;
            this.pictureBoxSearchIconDashboard.Click += new System.EventHandler(this.pictureBoxSearchIconDashboard_Click);
            // 
            // pictureBoxBellIconDashboard
            // 
            this.pictureBoxBellIconDashboard.Image = global::CoffeeShopPOS.Properties.Resources.black_notification1;
            this.pictureBoxBellIconDashboard.Location = new System.Drawing.Point(895, 12);
            this.pictureBoxBellIconDashboard.Name = "pictureBoxBellIconDashboard";
            this.pictureBoxBellIconDashboard.Size = new System.Drawing.Size(39, 40);
            this.pictureBoxBellIconDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBellIconDashboard.TabIndex = 23;
            this.pictureBoxBellIconDashboard.TabStop = false;
            // 
            // pictureBoxCartDashboard
            // 
            this.pictureBoxCartDashboard.Image = global::CoffeeShopPOS.Properties.Resources.balck_cart1;
            this.pictureBoxCartDashboard.Location = new System.Drawing.Point(940, 12);
            this.pictureBoxCartDashboard.Name = "pictureBoxCartDashboard";
            this.pictureBoxCartDashboard.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxCartDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCartDashboard.TabIndex = 22;
            this.pictureBoxCartDashboard.TabStop = false;
            // 
            // pictureBoxAccountDashboard
            // 
            this.pictureBoxAccountDashboard.Image = global::CoffeeShopPOS.Properties.Resources.blackAccount1;
            this.pictureBoxAccountDashboard.Location = new System.Drawing.Point(983, 12);
            this.pictureBoxAccountDashboard.Name = "pictureBoxAccountDashboard";
            this.pictureBoxAccountDashboard.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxAccountDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountDashboard.TabIndex = 21;
            this.pictureBoxAccountDashboard.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(249, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Admin Dashboard";
            // 
            // textBoxSearchBarDashboard
            // 
            this.textBoxSearchBarDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBarDashboard.Location = new System.Drawing.Point(643, 15);
            this.textBoxSearchBarDashboard.Name = "textBoxSearchBarDashboard";
            this.textBoxSearchBarDashboard.Size = new System.Drawing.Size(227, 34);
            this.textBoxSearchBarDashboard.TabIndex = 20;
            // 
            // AdminDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1202, 703);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelButtons);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_LoadDashboard);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSidebar)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelLowStockAdmin.ResumeLayout(false);
            this.panelLowStockAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAdminTopSelling)).EndInit();
            this.panelAdminCard4.ResumeLayout(false);
            this.panelAdminCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelAdminCard3.ResumeLayout(false);
            this.panelAdminCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAdminCard2.ResumeLayout(false);
            this.panelAdminCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAdminCard1.ResumeLayout(false);
            this.panelAdminCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalMoneyCardAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminDashboard)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBellIconDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pbSidebarGreen;
        private Label lblSidebarTesting;
        private Label lblSidebarStatus;
        private PictureBox pBSidebar;
        private Button btnLogout;
        private Button btnCustomer;
        private Button btnInventory;
        private Button btnProductsSales;
        private Button btnDashboard;
        private Panel panelSidebar;
        private Button btnSettings;
        private Button btnReporting;
        private Button btnStaffManagement;
        private Button btnMembership;
        private Button btnSearch;
        private Panel panelButtons;
        private TextBox txtSearch;
        private Label lblSearch;
        private Panel panelMain;
        private Panel panelHeader;
        private Label lblSearchDashboard;
        private PictureBox pictureBoxSearchIconDashboard;
        private PictureBox pictureBoxBellIconDashboard;
        private PictureBox pictureBoxCartDashboard;
        private PictureBox pictureBoxAccountDashboard;
        private Label lblHeader;
        private TextBox textBoxSearchBarDashboard;
        private Panel panelLowStockAdmin;
        private ListView lvLowStockAdmin;
        private ColumnHeader ColumnHeaderAdmin;
        private ColumnHeader columnHeaderAmin1;
        private ColumnHeader columnHeaderAdmin2;
        private ColumnHeader columnHeaderAdmin3;
        private ColumnHeader columnHeaderAdmin4;
        private ColumnHeader columnHeaderAdmin5;
        private Label lblLowStockTitleAdmin;
        private Label lblAdminTopTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAdminTopSelling;
        private Panel panelAdminCard4;
        private PictureBox pictureBox3;
        private Label lblAdminProductValue;
        private Label lblAdminProduct;
        private Panel panelAdminCard3;
        private PictureBox pictureBox2;
        private Label lblAdminCustomerValue;
        private Label lblAdminCustomer;
        private Panel panelAdminCard2;
        private PictureBox pictureBox1;
        private Label lblAdminMonth;
        private Label lblAdminMonthly;
        private Panel panelAdminCard1;
        private PictureBox pbTotalMoneyCardAdmin;
        private Label lblAdminSales;
        private Label panelAdminSalesValue;
        private DataGridView dgvAdminDashboard;
    }
}
