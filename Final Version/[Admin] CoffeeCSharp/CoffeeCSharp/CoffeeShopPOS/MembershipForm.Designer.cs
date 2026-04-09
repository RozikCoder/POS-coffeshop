using System;
using System.Windows.Forms;
using System.Drawing;

namespace CoffeeShopPOS
{
    public partial class MembershipForm : Form
    {
        private System.ComponentModel.IContainer componentsMembership = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (componentsMembership != null))
                componentsMembership.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProductsSales = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblHeaderMembership = new System.Windows.Forms.Label();
            this.lblSidebarStatusMembership = new System.Windows.Forms.Label();
            this.lblSearchDashboardMembership = new System.Windows.Forms.Label();
            this.lblSidebarTestingMembership = new System.Windows.Forms.Label();
            this.textBoxSearchBarDashboardMembership = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxAdminMembership = new System.Windows.Forms.GroupBox();
            this.btnExportAdminMembership = new System.Windows.Forms.Button();
            this.btnImportAdminMembership = new System.Windows.Forms.Button();
            this.dataGridViewAllAdminMembership = new System.Windows.Forms.DataGridView();
            this.btnUpdateAdminMembership = new System.Windows.Forms.Button();
            this.btnDeleteAdminMembership = new System.Windows.Forms.Button();
            this.btnAddAdminMembership = new System.Windows.Forms.Button();
            this.btnRemoveSAdminMembership = new System.Windows.Forms.Button();
            this.groupAdminMembership = new System.Windows.Forms.GroupBox();
            this.btnCreateMembershipAdmin = new System.Windows.Forms.Button();
            this.txtDescriptionAdminMembership = new System.Windows.Forms.TextBox();
            this.btnClearMembershipAdmin = new System.Windows.Forms.Button();
            this.LblDescriptionAdminMembership = new System.Windows.Forms.Label();
            this.txtStatusAdminMembership = new System.Windows.Forms.TextBox();
            this.lblStatusAdminMembership = new System.Windows.Forms.Label();
            this.txtEmailAdminMembership = new System.Windows.Forms.TextBox();
            this.lblEmailAdminMembership = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIDAdminMembership = new System.Windows.Forms.Label();
            this.txtIDAdminMembership = new System.Windows.Forms.TextBox();
            this.lblNameAdminMembership = new System.Windows.Forms.Label();
            this.txtNameAdminMembership = new System.Windows.Forms.TextBox();
            this.lblTypeAdminMembership = new System.Windows.Forms.Label();
            this.cmbTypeAdminMembership = new System.Windows.Forms.ComboBox();
            this.lblContactAdminMembership = new System.Windows.Forms.Label();
            this.txtContactAdminMembership = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxSearchIconDashboardMembership = new System.Windows.Forms.PictureBox();
            this.pictureBoxBellIconDashboardMembership = new System.Windows.Forms.PictureBox();
            this.pictureBoxCartDashboardMembership = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccountDashboardMembership = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pbSidebarGreenMembership = new System.Windows.Forms.PictureBox();
            this.pBSidebarMembership = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.groupBoxAdminMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAdminMembership)).BeginInit();
            this.groupAdminMembership.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconDashboardMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBellIconDashboardMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartDashboardMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountDashboardMembership)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarGreenMembership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSidebarMembership)).BeginInit();
            this.SuspendLayout();
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
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
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
            // lblHeaderMembership
            // 
            this.lblHeaderMembership.AutoSize = true;
            this.lblHeaderMembership.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderMembership.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderMembership.Name = "lblHeaderMembership";
            this.lblHeaderMembership.Size = new System.Drawing.Size(179, 37);
            this.lblHeaderMembership.TabIndex = 0;
            this.lblHeaderMembership.Text = "Membership";
            // 
            // lblSidebarStatusMembership
            // 
            this.lblSidebarStatusMembership.AutoSize = true;
            this.lblSidebarStatusMembership.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSidebarStatusMembership.Location = new System.Drawing.Point(102, 57);
            this.lblSidebarStatusMembership.Name = "lblSidebarStatusMembership";
            this.lblSidebarStatusMembership.Size = new System.Drawing.Size(49, 17);
            this.lblSidebarStatusMembership.TabIndex = 2;
            this.lblSidebarStatusMembership.Text = "Online";
            // 
            // lblSearchDashboardMembership
            // 
            this.lblSearchDashboardMembership.AutoSize = true;
            this.lblSearchDashboardMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDashboardMembership.Location = new System.Drawing.Point(652, 21);
            this.lblSearchDashboardMembership.Name = "lblSearchDashboardMembership";
            this.lblSearchDashboardMembership.Size = new System.Drawing.Size(62, 20);
            this.lblSearchDashboardMembership.TabIndex = 25;
            this.lblSearchDashboardMembership.Text = "Search";
            // 
            // lblSidebarTestingMembership
            // 
            this.lblSidebarTestingMembership.AutoSize = true;
            this.lblSidebarTestingMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarTestingMembership.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTestingMembership.Location = new System.Drawing.Point(85, 33);
            this.lblSidebarTestingMembership.Name = "lblSidebarTestingMembership";
            this.lblSidebarTestingMembership.Size = new System.Drawing.Size(61, 20);
            this.lblSidebarTestingMembership.TabIndex = 2;
            this.lblSidebarTestingMembership.Text = "Admin";
            // 
            // textBoxSearchBarDashboardMembership
            // 
            this.textBoxSearchBarDashboardMembership.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBarDashboardMembership.Location = new System.Drawing.Point(643, 15);
            this.textBoxSearchBarDashboardMembership.Name = "textBoxSearchBarDashboardMembership";
            this.textBoxSearchBarDashboardMembership.Size = new System.Drawing.Size(227, 34);
            this.textBoxSearchBarDashboardMembership.TabIndex = 20;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.groupBoxAdminMembership);
            this.panelMain.Controls.Add(this.groupAdminMembership);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(163, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1039, 641);
            this.panelMain.TabIndex = 106;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // groupBoxAdminMembership
            // 
            this.groupBoxAdminMembership.Controls.Add(this.btnExportAdminMembership);
            this.groupBoxAdminMembership.Controls.Add(this.btnImportAdminMembership);
            this.groupBoxAdminMembership.Controls.Add(this.dataGridViewAllAdminMembership);
            this.groupBoxAdminMembership.Controls.Add(this.btnUpdateAdminMembership);
            this.groupBoxAdminMembership.Controls.Add(this.btnDeleteAdminMembership);
            this.groupBoxAdminMembership.Controls.Add(this.btnAddAdminMembership);
            this.groupBoxAdminMembership.Controls.Add(this.btnRemoveSAdminMembership);
            this.groupBoxAdminMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdminMembership.Location = new System.Drawing.Point(425, 32);
            this.groupBoxAdminMembership.Name = "groupBoxAdminMembership";
            this.groupBoxAdminMembership.Size = new System.Drawing.Size(583, 575);
            this.groupBoxAdminMembership.TabIndex = 7;
            this.groupBoxAdminMembership.TabStop = false;
            this.groupBoxAdminMembership.Text = "All Memberships";
            this.groupBoxAdminMembership.Enter += new System.EventHandler(this.groupBoxAdminMembership_Enter);
            // 
            // btnExportAdminMembership
            // 
            this.btnExportAdminMembership.BackColor = System.Drawing.Color.Silver;
            this.btnExportAdminMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAdminMembership.ForeColor = System.Drawing.Color.White;
            this.btnExportAdminMembership.Location = new System.Drawing.Point(147, 470);
            this.btnExportAdminMembership.Name = "btnExportAdminMembership";
            this.btnExportAdminMembership.Size = new System.Drawing.Size(130, 35);
            this.btnExportAdminMembership.TabIndex = 22;
            this.btnExportAdminMembership.Text = "Export CSV";
            this.btnExportAdminMembership.UseVisualStyleBackColor = false;
            // 
            // btnImportAdminMembership
            // 
            this.btnImportAdminMembership.BackColor = System.Drawing.Color.Silver;
            this.btnImportAdminMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportAdminMembership.ForeColor = System.Drawing.Color.White;
            this.btnImportAdminMembership.Location = new System.Drawing.Point(7, 470);
            this.btnImportAdminMembership.Name = "btnImportAdminMembership";
            this.btnImportAdminMembership.Size = new System.Drawing.Size(130, 35);
            this.btnImportAdminMembership.TabIndex = 21;
            this.btnImportAdminMembership.Text = "Import CSV ";
            this.btnImportAdminMembership.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAllAdminMembership
            // 
            this.dataGridViewAllAdminMembership.ColumnHeadersHeight = 540;
            this.dataGridViewAllAdminMembership.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewAllAdminMembership.Name = "dataGridViewAllAdminMembership";
            this.dataGridViewAllAdminMembership.RowHeadersWidth = 30;
            this.dataGridViewAllAdminMembership.RowTemplate.Height = 24;
            this.dataGridViewAllAdminMembership.Size = new System.Drawing.Size(571, 420);
            this.dataGridViewAllAdminMembership.TabIndex = 0;
            this.dataGridViewAllAdminMembership.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllAdminMembership_CellContentClick);
            // 
            // btnUpdateAdminMembership
            // 
            this.btnUpdateAdminMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdateAdminMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAdminMembership.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdminMembership.Location = new System.Drawing.Point(194, 520);
            this.btnUpdateAdminMembership.Name = "btnUpdateAdminMembership";
            this.btnUpdateAdminMembership.Size = new System.Drawing.Size(90, 35);
            this.btnUpdateAdminMembership.TabIndex = 13;
            this.btnUpdateAdminMembership.Text = "Update";
            this.btnUpdateAdminMembership.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAdminMembership
            // 
            this.btnDeleteAdminMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteAdminMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAdminMembership.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAdminMembership.Location = new System.Drawing.Point(392, 520);
            this.btnDeleteAdminMembership.Name = "btnDeleteAdminMembership";
            this.btnDeleteAdminMembership.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteAdminMembership.TabIndex = 14;
            this.btnDeleteAdminMembership.Text = "Delete";
            this.btnDeleteAdminMembership.UseVisualStyleBackColor = false;
            // 
            // btnAddAdminMembership
            // 
            this.btnAddAdminMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddAdminMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdminMembership.ForeColor = System.Drawing.Color.White;
            this.btnAddAdminMembership.Location = new System.Drawing.Point(94, 520);
            this.btnAddAdminMembership.Name = "btnAddAdminMembership";
            this.btnAddAdminMembership.Size = new System.Drawing.Size(90, 35);
            this.btnAddAdminMembership.TabIndex = 12;
            this.btnAddAdminMembership.Text = "Add";
            this.btnAddAdminMembership.UseVisualStyleBackColor = false;
            // 
            // btnRemoveSAdminMembership
            // 
            this.btnRemoveSAdminMembership.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRemoveSAdminMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSAdminMembership.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSAdminMembership.Location = new System.Drawing.Point(293, 520);
            this.btnRemoveSAdminMembership.Name = "btnRemoveSAdminMembership";
            this.btnRemoveSAdminMembership.Size = new System.Drawing.Size(90, 35);
            this.btnRemoveSAdminMembership.TabIndex = 15;
            this.btnRemoveSAdminMembership.Text = "Remove";
            this.btnRemoveSAdminMembership.UseVisualStyleBackColor = false;
            // 
            // groupAdminMembership
            // 
            this.groupAdminMembership.BackColor = System.Drawing.Color.White;
            this.groupAdminMembership.Controls.Add(this.btnCreateMembershipAdmin);
            this.groupAdminMembership.Controls.Add(this.txtDescriptionAdminMembership);
            this.groupAdminMembership.Controls.Add(this.btnClearMembershipAdmin);
            this.groupAdminMembership.Controls.Add(this.LblDescriptionAdminMembership);
            this.groupAdminMembership.Controls.Add(this.txtStatusAdminMembership);
            this.groupAdminMembership.Controls.Add(this.lblStatusAdminMembership);
            this.groupAdminMembership.Controls.Add(this.txtEmailAdminMembership);
            this.groupAdminMembership.Controls.Add(this.lblEmailAdminMembership);
            this.groupAdminMembership.Controls.Add(this.label2);
            this.groupAdminMembership.Controls.Add(this.lblIDAdminMembership);
            this.groupAdminMembership.Controls.Add(this.txtIDAdminMembership);
            this.groupAdminMembership.Controls.Add(this.lblNameAdminMembership);
            this.groupAdminMembership.Controls.Add(this.txtNameAdminMembership);
            this.groupAdminMembership.Controls.Add(this.lblTypeAdminMembership);
            this.groupAdminMembership.Controls.Add(this.cmbTypeAdminMembership);
            this.groupAdminMembership.Controls.Add(this.lblContactAdminMembership);
            this.groupAdminMembership.Controls.Add(this.txtContactAdminMembership);
            this.groupAdminMembership.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupAdminMembership.Location = new System.Drawing.Point(29, 32);
            this.groupAdminMembership.Name = "groupAdminMembership";
            this.groupAdminMembership.Size = new System.Drawing.Size(390, 575);
            this.groupAdminMembership.TabIndex = 6;
            this.groupAdminMembership.TabStop = false;
            this.groupAdminMembership.Text = "Membership Management";
            // 
            // btnCreateMembershipAdmin
            // 
            this.btnCreateMembershipAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCreateMembershipAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMembershipAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCreateMembershipAdmin.Location = new System.Drawing.Point(219, 489);
            this.btnCreateMembershipAdmin.Name = "btnCreateMembershipAdmin";
            this.btnCreateMembershipAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnCreateMembershipAdmin.TabIndex = 24;
            this.btnCreateMembershipAdmin.Text = "Create";
            this.btnCreateMembershipAdmin.UseVisualStyleBackColor = false;
            // 
            // txtDescriptionAdminMembership
            // 
            this.txtDescriptionAdminMembership.Location = new System.Drawing.Point(175, 270);
            this.txtDescriptionAdminMembership.Multiline = true;
            this.txtDescriptionAdminMembership.Name = "txtDescriptionAdminMembership";
            this.txtDescriptionAdminMembership.Size = new System.Drawing.Size(200, 180);
            this.txtDescriptionAdminMembership.TabIndex = 34;
            // 
            // btnClearMembershipAdmin
            // 
            this.btnClearMembershipAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClearMembershipAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMembershipAdmin.ForeColor = System.Drawing.Color.White;
            this.btnClearMembershipAdmin.Location = new System.Drawing.Point(121, 489);
            this.btnClearMembershipAdmin.Name = "btnClearMembershipAdmin";
            this.btnClearMembershipAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnClearMembershipAdmin.TabIndex = 25;
            this.btnClearMembershipAdmin.Text = "Clear";
            this.btnClearMembershipAdmin.UseVisualStyleBackColor = false;
            // 
            // LblDescriptionAdminMembership
            // 
            this.LblDescriptionAdminMembership.Location = new System.Drawing.Point(32, 271);
            this.LblDescriptionAdminMembership.Name = "LblDescriptionAdminMembership";
            this.LblDescriptionAdminMembership.Size = new System.Drawing.Size(120, 25);
            this.LblDescriptionAdminMembership.TabIndex = 33;
            this.LblDescriptionAdminMembership.Text = "Description: ";
            // 
            // txtStatusAdminMembership
            // 
            this.txtStatusAdminMembership.Location = new System.Drawing.Point(175, 229);
            this.txtStatusAdminMembership.Name = "txtStatusAdminMembership";
            this.txtStatusAdminMembership.Size = new System.Drawing.Size(200, 30);
            this.txtStatusAdminMembership.TabIndex = 32;
            // 
            // lblStatusAdminMembership
            // 
            this.lblStatusAdminMembership.Location = new System.Drawing.Point(32, 229);
            this.lblStatusAdminMembership.Name = "lblStatusAdminMembership";
            this.lblStatusAdminMembership.Size = new System.Drawing.Size(120, 25);
            this.lblStatusAdminMembership.TabIndex = 31;
            this.lblStatusAdminMembership.Text = "Status:";
            // 
            // txtEmailAdminMembership
            // 
            this.txtEmailAdminMembership.Location = new System.Drawing.Point(175, 190);
            this.txtEmailAdminMembership.Name = "txtEmailAdminMembership";
            this.txtEmailAdminMembership.Size = new System.Drawing.Size(200, 30);
            this.txtEmailAdminMembership.TabIndex = 30;
            // 
            // lblEmailAdminMembership
            // 
            this.lblEmailAdminMembership.Location = new System.Drawing.Point(32, 188);
            this.lblEmailAdminMembership.Name = "lblEmailAdminMembership";
            this.lblEmailAdminMembership.Size = new System.Drawing.Size(120, 25);
            this.lblEmailAdminMembership.TabIndex = 23;
            this.lblEmailAdminMembership.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-32, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 18;
            // 
            // lblIDAdminMembership
            // 
            this.lblIDAdminMembership.Location = new System.Drawing.Point(32, 33);
            this.lblIDAdminMembership.Name = "lblIDAdminMembership";
            this.lblIDAdminMembership.Size = new System.Drawing.Size(120, 25);
            this.lblIDAdminMembership.TabIndex = 0;
            this.lblIDAdminMembership.Text = "Member ID:";
            // 
            // txtIDAdminMembership
            // 
            this.txtIDAdminMembership.Location = new System.Drawing.Point(175, 30);
            this.txtIDAdminMembership.Name = "txtIDAdminMembership";
            this.txtIDAdminMembership.ReadOnly = true;
            this.txtIDAdminMembership.Size = new System.Drawing.Size(200, 30);
            this.txtIDAdminMembership.TabIndex = 1;
            // 
            // lblNameAdminMembership
            // 
            this.lblNameAdminMembership.Location = new System.Drawing.Point(32, 73);
            this.lblNameAdminMembership.Name = "lblNameAdminMembership";
            this.lblNameAdminMembership.Size = new System.Drawing.Size(120, 25);
            this.lblNameAdminMembership.TabIndex = 2;
            this.lblNameAdminMembership.Text = "Full Name:";
            // 
            // txtNameAdminMembership
            // 
            this.txtNameAdminMembership.Location = new System.Drawing.Point(175, 70);
            this.txtNameAdminMembership.Name = "txtNameAdminMembership";
            this.txtNameAdminMembership.Size = new System.Drawing.Size(200, 30);
            this.txtNameAdminMembership.TabIndex = 3;
            // 
            // lblTypeAdminMembership
            // 
            this.lblTypeAdminMembership.Location = new System.Drawing.Point(32, 113);
            this.lblTypeAdminMembership.Name = "lblTypeAdminMembership";
            this.lblTypeAdminMembership.Size = new System.Drawing.Size(137, 25);
            this.lblTypeAdminMembership.TabIndex = 4;
            this.lblTypeAdminMembership.Text = "Member Type:";
            // 
            // cmbTypeAdminMembership
            // 
            this.cmbTypeAdminMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAdminMembership.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeAdminMembership.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.cmbTypeAdminMembership.Location = new System.Drawing.Point(175, 110);
            this.cmbTypeAdminMembership.Name = "cmbTypeAdminMembership";
            this.cmbTypeAdminMembership.Size = new System.Drawing.Size(200, 31);
            this.cmbTypeAdminMembership.TabIndex = 5;
            // 
            // lblContactAdminMembership
            // 
            this.lblContactAdminMembership.Location = new System.Drawing.Point(32, 153);
            this.lblContactAdminMembership.Name = "lblContactAdminMembership";
            this.lblContactAdminMembership.Size = new System.Drawing.Size(120, 25);
            this.lblContactAdminMembership.TabIndex = 6;
            this.lblContactAdminMembership.Text = "Contact:";
            // 
            // txtContactAdminMembership
            // 
            this.txtContactAdminMembership.Location = new System.Drawing.Point(175, 150);
            this.txtContactAdminMembership.Name = "txtContactAdminMembership";
            this.txtContactAdminMembership.Size = new System.Drawing.Size(200, 30);
            this.txtContactAdminMembership.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblSearchDashboardMembership);
            this.panelHeader.Controls.Add(this.pictureBoxSearchIconDashboardMembership);
            this.panelHeader.Controls.Add(this.pictureBoxBellIconDashboardMembership);
            this.panelHeader.Controls.Add(this.pictureBoxCartDashboardMembership);
            this.panelHeader.Controls.Add(this.pictureBoxAccountDashboardMembership);
            this.panelHeader.Controls.Add(this.lblHeaderMembership);
            this.panelHeader.Controls.Add(this.textBoxSearchBarDashboardMembership);
            this.panelHeader.Location = new System.Drawing.Point(163, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1039, 60);
            this.panelHeader.TabIndex = 104;
            // 
            // pictureBoxSearchIconDashboardMembership
            // 
            this.pictureBoxSearchIconDashboardMembership.Image = global::CoffeeShopPOS.Properties.Resources.search1;
            this.pictureBoxSearchIconDashboardMembership.Location = new System.Drawing.Point(831, 16);
            this.pictureBoxSearchIconDashboardMembership.Name = "pictureBoxSearchIconDashboardMembership";
            this.pictureBoxSearchIconDashboardMembership.Size = new System.Drawing.Size(39, 29);
            this.pictureBoxSearchIconDashboardMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchIconDashboardMembership.TabIndex = 24;
            this.pictureBoxSearchIconDashboardMembership.TabStop = false;
            // 
            // pictureBoxBellIconDashboardMembership
            // 
            this.pictureBoxBellIconDashboardMembership.Image = global::CoffeeShopPOS.Properties.Resources.black_notification1;
            this.pictureBoxBellIconDashboardMembership.Location = new System.Drawing.Point(895, 12);
            this.pictureBoxBellIconDashboardMembership.Name = "pictureBoxBellIconDashboardMembership";
            this.pictureBoxBellIconDashboardMembership.Size = new System.Drawing.Size(39, 40);
            this.pictureBoxBellIconDashboardMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBellIconDashboardMembership.TabIndex = 23;
            this.pictureBoxBellIconDashboardMembership.TabStop = false;
            // 
            // pictureBoxCartDashboardMembership
            // 
            this.pictureBoxCartDashboardMembership.Image = global::CoffeeShopPOS.Properties.Resources.balck_cart1;
            this.pictureBoxCartDashboardMembership.Location = new System.Drawing.Point(940, 12);
            this.pictureBoxCartDashboardMembership.Name = "pictureBoxCartDashboardMembership";
            this.pictureBoxCartDashboardMembership.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxCartDashboardMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCartDashboardMembership.TabIndex = 22;
            this.pictureBoxCartDashboardMembership.TabStop = false;
            // 
            // pictureBoxAccountDashboardMembership
            // 
            this.pictureBoxAccountDashboardMembership.Image = global::CoffeeShopPOS.Properties.Resources.blackAccount1;
            this.pictureBoxAccountDashboardMembership.Location = new System.Drawing.Point(983, 12);
            this.pictureBoxAccountDashboardMembership.Name = "pictureBoxAccountDashboardMembership";
            this.pictureBoxAccountDashboardMembership.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxAccountDashboardMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountDashboardMembership.TabIndex = 21;
            this.pictureBoxAccountDashboardMembership.TabStop = false;
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(560, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.btnSearch);
            this.panelButtons.Controls.Add(this.txtSearch);
            this.panelButtons.Controls.Add(this.lblSearch);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(163, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1039, 2);
            this.panelButtons.TabIndex = 105;
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
            this.btnMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMembership.FlatAppearance.BorderSize = 0;
            this.btnMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembership.ForeColor = System.Drawing.Color.White;
            this.btnMembership.Location = new System.Drawing.Point(12, 308);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(140, 40);
            this.btnMembership.TabIndex = 0;
            this.btnMembership.Text = "Membership ";
            this.btnMembership.UseVisualStyleBackColor = false;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.Controls.Add(this.pbSidebarGreenMembership);
            this.panelSidebar.Controls.Add(this.lblSidebarTestingMembership);
            this.panelSidebar.Controls.Add(this.lblSidebarStatusMembership);
            this.panelSidebar.Controls.Add(this.pBSidebarMembership);
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
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(163, 703);
            this.panelSidebar.TabIndex = 107;
            // 
            // pbSidebarGreenMembership
            // 
            this.pbSidebarGreenMembership.Image = global::CoffeeShopPOS.Properties.Resources.green1;
            this.pbSidebarGreenMembership.Location = new System.Drawing.Point(90, 53);
            this.pbSidebarGreenMembership.Name = "pbSidebarGreenMembership";
            this.pbSidebarGreenMembership.Size = new System.Drawing.Size(12, 25);
            this.pbSidebarGreenMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSidebarGreenMembership.TabIndex = 2;
            this.pbSidebarGreenMembership.TabStop = false;
            // 
            // pBSidebarMembership
            // 
            this.pBSidebarMembership.Image = global::CoffeeShopPOS.Properties.Resources.admin;
            this.pBSidebarMembership.Location = new System.Drawing.Point(16, 24);
            this.pBSidebarMembership.Name = "pBSidebarMembership";
            this.pBSidebarMembership.Size = new System.Drawing.Size(65, 61);
            this.pBSidebarMembership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSidebarMembership.TabIndex = 0;
            this.pBSidebarMembership.TabStop = false;
            // 
            // MembershipForm
            // 
            this.ClientSize = new System.Drawing.Size(1202, 703);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelSidebar);
            this.Name = "MembershipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting Interface";
            this.Load += new System.EventHandler(this.MembershipForm_Load);
            this.panelMain.ResumeLayout(false);
            this.groupBoxAdminMembership.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAdminMembership)).EndInit();
            this.groupAdminMembership.ResumeLayout(false);
            this.groupAdminMembership.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconDashboardMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBellIconDashboardMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartDashboardMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountDashboardMembership)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarGreenMembership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSidebarMembership)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pBSidebarMembership;
        private PictureBox pictureBoxSearchIconDashboardMembership;
        private PictureBox pictureBoxBellIconDashboardMembership;
        private PictureBox pictureBoxCartDashboardMembership;
        private PictureBox pictureBoxAccountDashboardMembership;
        private Button btnLogout;
        private Button btnCustomer;
        private Button btnInventory;
        private Button btnProductsSales;
        private Button btnDashboard;
        private Label lblHeaderMembership;
        private Label lblSidebarStatusMembership;
        private Label lblSearchDashboardMembership;
        private Label lblSidebarTestingMembership;
        private TextBox textBoxSearchBarDashboardMembership;
        private PictureBox pbSidebarGreenMembership;
        private Panel panelMain;
        private Panel panelHeader;
        private Button btnSettings;
        private TextBox txtSearch;
        private Panel panelButtons;
        private Button btnSearch;
        private Label lblSearch;
        private Button btnReporting;
        private Button btnStaffManagement;
        private Button btnMembership;
        private Panel panelSidebar;
        private GroupBox groupBoxAdminMembership;
        private Button btnExportAdminMembership;
        private Button btnImportAdminMembership;
        private GroupBox groupAdminMembership;
        private TextBox txtStatusAdminMembership;
        private Label lblStatusAdminMembership;
        private TextBox txtEmailAdminMembership;
        private Label lblEmailAdminMembership;
        private Label label2;
        private Button btnRemoveSAdminMembership;
        private Label lblIDAdminMembership;
        private TextBox txtIDAdminMembership;
        private Label lblNameAdminMembership;
        private TextBox txtNameAdminMembership;
        private Label lblTypeAdminMembership;
        private ComboBox cmbTypeAdminMembership;
        private Label lblContactAdminMembership;
        private TextBox txtContactAdminMembership;
        private Button btnAddAdminMembership;
        private Button btnUpdateAdminMembership;
        private Button btnDeleteAdminMembership;
        private TextBox txtDescriptionAdminMembership;
        private Label LblDescriptionAdminMembership;
        private Button btnCreateMembershipAdmin;
        private Button btnClearMembershipAdmin;
        private DataGridView dataGridViewAllAdminMembership;
    }
}
