using System;
using System.Windows.Forms;
using System.Drawing;

namespace CoffeeShopPOS
{
    public partial class ProductForm : Form
    {
        private System.ComponentModel.IContainer componentsProduct = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (componentsProduct != null))
                componentsProduct.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProductsSales = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblHeaderProduct = new System.Windows.Forms.Label();
            this.lblSidebarStatusProduct = new System.Windows.Forms.Label();
            this.lblSearchDashboardProduct = new System.Windows.Forms.Label();
            this.lblSidebarTestingProduct = new System.Windows.Forms.Label();
            this.textBoxSearchBarDashboardProduct = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAllProduct = new System.Windows.Forms.DataGridView();
            this.btnDeleteProductAdmin = new System.Windows.Forms.Button();
            this.btnUpdateProductAdmin = new System.Windows.Forms.Button();
            this.btnAddProductAdmin = new System.Windows.Forms.Button();
            this.btnRemoveProductAdmin = new System.Windows.Forms.Button();
            this.groupProductManagement = new System.Windows.Forms.GroupBox();
            this.btnCreateProductAdmin = new System.Windows.Forms.Button();
            this.btnClearProductAdmin = new System.Windows.Forms.Button();
            this.btnImgUploadProduct = new System.Windows.Forms.Button();
            this.txtDescriptionProduct = new System.Windows.Forms.TextBox();
            this.lblDescriptionProduct = new System.Windows.Forms.Label();
            this.lblDescriptionUploadProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtProductIDProduct = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProductNameProduct = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategoryProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStockProduct = new System.Windows.Forms.TextBox();
            this.lblReorder = new System.Windows.Forms.Label();
            this.txtReorderProduct = new System.Windows.Forms.TextBox();
            this.dgvAdminDashboardProduct = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.panelButtonsProduct = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pictureBoxUploadProductLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchIconDashboardProduct = new System.Windows.Forms.PictureBox();
            this.pictureBoxBellIconDashboardProduct = new System.Windows.Forms.PictureBox();
            this.pictureBoxCartDashboardProduct = new System.Windows.Forms.PictureBox();
            this.pictureBoxAccountDashboardProduct = new System.Windows.Forms.PictureBox();
            this.pbSidebarGreenProduct = new System.Windows.Forms.PictureBox();
            this.pBSidebarProduct = new System.Windows.Forms.PictureBox();
            this.pbPlusProduct = new System.Windows.Forms.PictureBox();
            this.lblUploadProduct = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProduct)).BeginInit();
            this.groupProductManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminDashboardProduct)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelButtonsProduct.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadProductLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconDashboardProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBellIconDashboardProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartDashboardProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountDashboardProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarGreenProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSidebarProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlusProduct)).BeginInit();
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
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProductsSales
            // 
            this.btnProductsSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProductsSales.FlatAppearance.BorderSize = 0;
            this.btnProductsSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsSales.ForeColor = System.Drawing.Color.White;
            this.btnProductsSales.Location = new System.Drawing.Point(12, 160);
            this.btnProductsSales.Name = "btnProductsSales";
            this.btnProductsSales.Size = new System.Drawing.Size(140, 40);
            this.btnProductsSales.TabIndex = 6;
            this.btnProductsSales.Text = "Products and Sales";
            this.btnProductsSales.UseVisualStyleBackColor = false;
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
            // lblHeaderProduct
            // 
            this.lblHeaderProduct.AutoSize = true;
            this.lblHeaderProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderProduct.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderProduct.Name = "lblHeaderProduct";
            this.lblHeaderProduct.Size = new System.Drawing.Size(258, 37);
            this.lblHeaderProduct.TabIndex = 0;
            this.lblHeaderProduct.Text = "Products and Sales";
            // 
            // lblSidebarStatusProduct
            // 
            this.lblSidebarStatusProduct.AutoSize = true;
            this.lblSidebarStatusProduct.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSidebarStatusProduct.Location = new System.Drawing.Point(102, 57);
            this.lblSidebarStatusProduct.Name = "lblSidebarStatusProduct";
            this.lblSidebarStatusProduct.Size = new System.Drawing.Size(49, 17);
            this.lblSidebarStatusProduct.TabIndex = 2;
            this.lblSidebarStatusProduct.Text = "Online";
            // 
            // lblSearchDashboardProduct
            // 
            this.lblSearchDashboardProduct.AutoSize = true;
            this.lblSearchDashboardProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblSearchDashboardProduct.Location = new System.Drawing.Point(652, 21);
            this.lblSearchDashboardProduct.Name = "lblSearchDashboardProduct";
            this.lblSearchDashboardProduct.Size = new System.Drawing.Size(62, 20);
            this.lblSearchDashboardProduct.TabIndex = 25;
            this.lblSearchDashboardProduct.Text = "Search";
            // 
            // lblSidebarTestingProduct
            // 
            this.lblSidebarTestingProduct.AutoSize = true;
            this.lblSidebarTestingProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTestingProduct.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTestingProduct.Location = new System.Drawing.Point(85, 33);
            this.lblSidebarTestingProduct.Name = "lblSidebarTestingProduct";
            this.lblSidebarTestingProduct.Size = new System.Drawing.Size(61, 20);
            this.lblSidebarTestingProduct.TabIndex = 2;
            this.lblSidebarTestingProduct.Text = "Admin";
            // 
            // textBoxSearchBarDashboardProduct
            // 
            this.textBoxSearchBarDashboardProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearchBarDashboardProduct.Location = new System.Drawing.Point(643, 15);
            this.textBoxSearchBarDashboardProduct.Name = "textBoxSearchBarDashboardProduct";
            this.textBoxSearchBarDashboardProduct.Size = new System.Drawing.Size(227, 34);
            this.textBoxSearchBarDashboardProduct.TabIndex = 20;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.groupProductManagement);
            this.panelMain.Controls.Add(this.dgvAdminDashboardProduct);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.panelMain.Location = new System.Drawing.Point(163, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1039, 641);
            this.panelMain.TabIndex = 106;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridViewAllProduct);
            this.groupBox1.Controls.Add(this.btnDeleteProductAdmin);
            this.groupBox1.Controls.Add(this.btnUpdateProductAdmin);
            this.groupBox1.Controls.Add(this.btnAddProductAdmin);
            this.groupBox1.Controls.Add(this.btnRemoveProductAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 297);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(162, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Export CSV";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Import CSV ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAllProduct
            // 
            this.dataGridViewAllProduct.ColumnHeadersHeight = 45;
            this.dataGridViewAllProduct.Location = new System.Drawing.Point(22, 35);
            this.dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            this.dataGridViewAllProduct.RowHeadersWidth = 25;
            this.dataGridViewAllProduct.RowTemplate.Height = 24;
            this.dataGridViewAllProduct.Size = new System.Drawing.Size(952, 170);
            this.dataGridViewAllProduct.TabIndex = 0;
            this.dataGridViewAllProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllProduct_CellContentClick);
            // 
            // btnDeleteProductAdmin
            // 
            this.btnDeleteProductAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteProductAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProductAdmin.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProductAdmin.Location = new System.Drawing.Point(605, 247);
            this.btnDeleteProductAdmin.Name = "btnDeleteProductAdmin";
            this.btnDeleteProductAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteProductAdmin.TabIndex = 14;
            this.btnDeleteProductAdmin.Text = "Delete";
            this.btnDeleteProductAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteProductAdmin.Click += new System.EventHandler(this.btnDeleteProductAdmin_Click);
            // 
            // btnUpdateProductAdmin
            // 
            this.btnUpdateProductAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdateProductAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProductAdmin.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProductAdmin.Location = new System.Drawing.Point(407, 247);
            this.btnUpdateProductAdmin.Name = "btnUpdateProductAdmin";
            this.btnUpdateProductAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnUpdateProductAdmin.TabIndex = 13;
            this.btnUpdateProductAdmin.Text = "Update";
            this.btnUpdateProductAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateProductAdmin.Click += new System.EventHandler(this.btnUpdateProductAdmin_Click);
            // 
            // btnAddProductAdmin
            // 
            this.btnAddProductAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddProductAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddProductAdmin.Location = new System.Drawing.Point(307, 247);
            this.btnAddProductAdmin.Name = "btnAddProductAdmin";
            this.btnAddProductAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnAddProductAdmin.TabIndex = 12;
            this.btnAddProductAdmin.Text = "Add";
            this.btnAddProductAdmin.UseVisualStyleBackColor = false;
            this.btnAddProductAdmin.Click += new System.EventHandler(this.btnAddProductAdmin_Click);
            // 
            // btnRemoveProductAdmin
            // 
            this.btnRemoveProductAdmin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRemoveProductAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProductAdmin.ForeColor = System.Drawing.Color.White;
            this.btnRemoveProductAdmin.Location = new System.Drawing.Point(506, 247);
            this.btnRemoveProductAdmin.Name = "btnRemoveProductAdmin";
            this.btnRemoveProductAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnRemoveProductAdmin.TabIndex = 15;
            this.btnRemoveProductAdmin.Text = "Remove";
            this.btnRemoveProductAdmin.UseVisualStyleBackColor = false;
            this.btnRemoveProductAdmin.Click += new System.EventHandler(this.btnRemoveProductAdmin_Click);
            // 
            // groupProductManagement
            // 
            this.groupProductManagement.BackColor = System.Drawing.Color.White;
            this.groupProductManagement.Controls.Add(this.lblUploadProduct);
            this.groupProductManagement.Controls.Add(this.pbPlusProduct);
            this.groupProductManagement.Controls.Add(this.btnCreateProductAdmin);
            this.groupProductManagement.Controls.Add(this.btnClearProductAdmin);
            this.groupProductManagement.Controls.Add(this.btnImgUploadProduct);
            this.groupProductManagement.Controls.Add(this.txtDescriptionProduct);
            this.groupProductManagement.Controls.Add(this.lblDescriptionProduct);
            this.groupProductManagement.Controls.Add(this.lblDescriptionUploadProduct);
            this.groupProductManagement.Controls.Add(this.label2);
            this.groupProductManagement.Controls.Add(this.pictureBoxUploadProductLeft);
            this.groupProductManagement.Controls.Add(this.lblID);
            this.groupProductManagement.Controls.Add(this.txtProductIDProduct);
            this.groupProductManagement.Controls.Add(this.lblName);
            this.groupProductManagement.Controls.Add(this.txtProductNameProduct);
            this.groupProductManagement.Controls.Add(this.lblCategory);
            this.groupProductManagement.Controls.Add(this.cmbCategoryProduct);
            this.groupProductManagement.Controls.Add(this.lblPrice);
            this.groupProductManagement.Controls.Add(this.txtPriceProduct);
            this.groupProductManagement.Controls.Add(this.lblStock);
            this.groupProductManagement.Controls.Add(this.txtStockProduct);
            this.groupProductManagement.Controls.Add(this.lblReorder);
            this.groupProductManagement.Controls.Add(this.txtReorderProduct);
            this.groupProductManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupProductManagement.Location = new System.Drawing.Point(27, 27);
            this.groupProductManagement.Name = "groupProductManagement";
            this.groupProductManagement.Size = new System.Drawing.Size(980, 273);
            this.groupProductManagement.TabIndex = 2;
            this.groupProductManagement.TabStop = false;
            this.groupProductManagement.Text = "Product Details";
            this.groupProductManagement.Enter += new System.EventHandler(this.groupProductManagement_Enter);
            // 
            // btnCreateProductAdmin
            // 
            this.btnCreateProductAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCreateProductAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProductAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCreateProductAdmin.Location = new System.Drawing.Point(676, 223);
            this.btnCreateProductAdmin.Name = "btnCreateProductAdmin";
            this.btnCreateProductAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnCreateProductAdmin.TabIndex = 24;
            this.btnCreateProductAdmin.Text = "Create";
            this.btnCreateProductAdmin.UseVisualStyleBackColor = false;
            // 
            // btnClearProductAdmin
            // 
            this.btnClearProductAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClearProductAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProductAdmin.ForeColor = System.Drawing.Color.White;
            this.btnClearProductAdmin.Location = new System.Drawing.Point(578, 224);
            this.btnClearProductAdmin.Name = "btnClearProductAdmin";
            this.btnClearProductAdmin.Size = new System.Drawing.Size(90, 35);
            this.btnClearProductAdmin.TabIndex = 25;
            this.btnClearProductAdmin.Text = "Clear";
            this.btnClearProductAdmin.UseVisualStyleBackColor = false;
            // 
            // btnImgUploadProduct
            // 
            this.btnImgUploadProduct.BackColor = System.Drawing.Color.Silver;
            this.btnImgUploadProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgUploadProduct.ForeColor = System.Drawing.Color.White;
            this.btnImgUploadProduct.Location = new System.Drawing.Point(836, 157);
            this.btnImgUploadProduct.Name = "btnImgUploadProduct";
            this.btnImgUploadProduct.Size = new System.Drawing.Size(90, 35);
            this.btnImgUploadProduct.TabIndex = 30;
            this.btnImgUploadProduct.Text = "Upload";
            this.btnImgUploadProduct.UseVisualStyleBackColor = false;
            // 
            // txtDescriptionProduct
            // 
            this.txtDescriptionProduct.Location = new System.Drawing.Point(581, 48);
            this.txtDescriptionProduct.Multiline = true;
            this.txtDescriptionProduct.Name = "txtDescriptionProduct";
            this.txtDescriptionProduct.Size = new System.Drawing.Size(310, 51);
            this.txtDescriptionProduct.TabIndex = 26;
            this.txtDescriptionProduct.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDescriptionProduct
            // 
            this.lblDescriptionProduct.Location = new System.Drawing.Point(577, 27);
            this.lblDescriptionProduct.Name = "lblDescriptionProduct";
            this.lblDescriptionProduct.Size = new System.Drawing.Size(120, 25);
            this.lblDescriptionProduct.TabIndex = 23;
            this.lblDescriptionProduct.Text = "Description: ";
            // 
            // lblDescriptionUploadProduct
            // 
            this.lblDescriptionUploadProduct.AutoSize = true;
            this.lblDescriptionUploadProduct.Location = new System.Drawing.Point(671, 181);
            this.lblDescriptionUploadProduct.Name = "lblDescriptionUploadProduct";
            this.lblDescriptionUploadProduct.Size = new System.Drawing.Size(155, 23);
            this.lblDescriptionUploadProduct.TabIndex = 19;
            this.lblDescriptionUploadProduct.Text = "Image (JPG/PNG) ";
            this.lblDescriptionUploadProduct.Click += new System.EventHandler(this.lblDescriptionUploadProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-32, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(106, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(120, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Product ID:";
            // 
            // txtProductIDProduct
            // 
            this.txtProductIDProduct.Location = new System.Drawing.Point(236, 31);
            this.txtProductIDProduct.Name = "txtProductIDProduct";
            this.txtProductIDProduct.ReadOnly = true;
            this.txtProductIDProduct.Size = new System.Drawing.Size(200, 30);
            this.txtProductIDProduct.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(106, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtProductNameProduct
            // 
            this.txtProductNameProduct.Location = new System.Drawing.Point(236, 71);
            this.txtProductNameProduct.Name = "txtProductNameProduct";
            this.txtProductNameProduct.Size = new System.Drawing.Size(200, 30);
            this.txtProductNameProduct.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(106, 114);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(120, 25);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategoryProduct
            // 
            this.cmbCategoryProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryProduct.Items.AddRange(new object[] {
            "Coffee",
            "Milk Tea",
            "Tea",
            "Bakery",
            "Snacks",
            "Desserts",
            "Frappe / Blended",
            "Smoothies",
            "Ice Cream"});
            this.cmbCategoryProduct.Location = new System.Drawing.Point(236, 111);
            this.cmbCategoryProduct.Name = "cmbCategoryProduct";
            this.cmbCategoryProduct.Size = new System.Drawing.Size(200, 31);
            this.cmbCategoryProduct.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(106, 154);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(236, 151);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(200, 30);
            this.txtPriceProduct.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(106, 194);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(120, 25);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.Location = new System.Drawing.Point(236, 191);
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.Size = new System.Drawing.Size(200, 30);
            this.txtStockProduct.TabIndex = 9;
            // 
            // lblReorder
            // 
            this.lblReorder.Location = new System.Drawing.Point(106, 234);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(120, 25);
            this.lblReorder.TabIndex = 10;
            this.lblReorder.Text = "Reorder Level:";
            // 
            // txtReorderProduct
            // 
            this.txtReorderProduct.Location = new System.Drawing.Point(236, 231);
            this.txtReorderProduct.Name = "txtReorderProduct";
            this.txtReorderProduct.Size = new System.Drawing.Size(200, 30);
            this.txtReorderProduct.TabIndex = 11;
            // 
            // dgvAdminDashboardProduct
            // 
            this.dgvAdminDashboardProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminDashboardProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminDashboardProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminDashboardProduct.Location = new System.Drawing.Point(20, 20);
            this.dgvAdminDashboardProduct.Name = "dgvAdminDashboardProduct";
            this.dgvAdminDashboardProduct.RowHeadersWidth = 51;
            this.dgvAdminDashboardProduct.RowTemplate.Height = 28;
            this.dgvAdminDashboardProduct.Size = new System.Drawing.Size(999, 601);
            this.dgvAdminDashboardProduct.TabIndex = 1;
            this.dgvAdminDashboardProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminDashboardProduct_CellContentClick_1);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblSearchDashboardProduct);
            this.panelHeader.Controls.Add(this.pictureBoxSearchIconDashboardProduct);
            this.panelHeader.Controls.Add(this.pictureBoxBellIconDashboardProduct);
            this.panelHeader.Controls.Add(this.pictureBoxCartDashboardProduct);
            this.panelHeader.Controls.Add(this.pictureBoxAccountDashboardProduct);
            this.panelHeader.Controls.Add(this.lblHeaderProduct);
            this.panelHeader.Controls.Add(this.textBoxSearchBarDashboardProduct);
            this.panelHeader.Location = new System.Drawing.Point(163, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1039, 60);
            this.panelHeader.TabIndex = 104;
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
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchProduct.Location = new System.Drawing.Point(560, 19);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(200, 30);
            this.txtSearchProduct.TabIndex = 5;
            // 
            // panelButtonsProduct
            // 
            this.panelButtonsProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtonsProduct.Controls.Add(this.btnSearchProduct);
            this.panelButtonsProduct.Controls.Add(this.txtSearchProduct);
            this.panelButtonsProduct.Controls.Add(this.lblSearchProduct);
            this.panelButtonsProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonsProduct.Location = new System.Drawing.Point(163, 0);
            this.panelButtonsProduct.Name = "panelButtonsProduct";
            this.panelButtonsProduct.Size = new System.Drawing.Size(1039, 2);
            this.panelButtonsProduct.TabIndex = 105;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(770, 15);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(80, 35);
            this.btnSearchProduct.TabIndex = 6;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchProduct.Location = new System.Drawing.Point(500, 22);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(65, 23);
            this.lblSearchProduct.TabIndex = 4;
            this.lblSearchProduct.Text = "Search:";
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
            this.btnStaffManagement.Text = "Staff Management";
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
            this.btnMembership.Text = "Membership";
            this.btnMembership.UseVisualStyleBackColor = false;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.Controls.Add(this.pbSidebarGreenProduct);
            this.panelSidebar.Controls.Add(this.lblSidebarTestingProduct);
            this.panelSidebar.Controls.Add(this.lblSidebarStatusProduct);
            this.panelSidebar.Controls.Add(this.pBSidebarProduct);
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
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pictureBoxUploadProductLeft
            // 
            this.pictureBoxUploadProductLeft.Image = global::CoffeeShopPOS.Properties.Resources.Image_upload1;
            this.pictureBoxUploadProductLeft.Location = new System.Drawing.Point(571, 129);
            this.pictureBoxUploadProductLeft.Name = "pictureBoxUploadProductLeft";
            this.pictureBoxUploadProductLeft.Size = new System.Drawing.Size(63, 85);
            this.pictureBoxUploadProductLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUploadProductLeft.TabIndex = 16;
            this.pictureBoxUploadProductLeft.TabStop = false;
            // 
            // pictureBoxSearchIconDashboardProduct
            // 
            this.pictureBoxSearchIconDashboardProduct.Image = global::CoffeeShopPOS.Properties.Resources.search1;
            this.pictureBoxSearchIconDashboardProduct.Location = new System.Drawing.Point(831, 16);
            this.pictureBoxSearchIconDashboardProduct.Name = "pictureBoxSearchIconDashboardProduct";
            this.pictureBoxSearchIconDashboardProduct.Size = new System.Drawing.Size(39, 29);
            this.pictureBoxSearchIconDashboardProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchIconDashboardProduct.TabIndex = 24;
            this.pictureBoxSearchIconDashboardProduct.TabStop = false;
            // 
            // pictureBoxBellIconDashboardProduct
            // 
            this.pictureBoxBellIconDashboardProduct.Image = global::CoffeeShopPOS.Properties.Resources.black_notification1;
            this.pictureBoxBellIconDashboardProduct.Location = new System.Drawing.Point(895, 12);
            this.pictureBoxBellIconDashboardProduct.Name = "pictureBoxBellIconDashboardProduct";
            this.pictureBoxBellIconDashboardProduct.Size = new System.Drawing.Size(39, 40);
            this.pictureBoxBellIconDashboardProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBellIconDashboardProduct.TabIndex = 23;
            this.pictureBoxBellIconDashboardProduct.TabStop = false;
            // 
            // pictureBoxCartDashboardProduct
            // 
            this.pictureBoxCartDashboardProduct.Image = global::CoffeeShopPOS.Properties.Resources.balck_cart1;
            this.pictureBoxCartDashboardProduct.Location = new System.Drawing.Point(940, 12);
            this.pictureBoxCartDashboardProduct.Name = "pictureBoxCartDashboardProduct";
            this.pictureBoxCartDashboardProduct.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxCartDashboardProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCartDashboardProduct.TabIndex = 22;
            this.pictureBoxCartDashboardProduct.TabStop = false;
            // 
            // pictureBoxAccountDashboardProduct
            // 
            this.pictureBoxAccountDashboardProduct.Image = global::CoffeeShopPOS.Properties.Resources.blackAccount1;
            this.pictureBoxAccountDashboardProduct.Location = new System.Drawing.Point(983, 12);
            this.pictureBoxAccountDashboardProduct.Name = "pictureBoxAccountDashboardProduct";
            this.pictureBoxAccountDashboardProduct.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxAccountDashboardProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountDashboardProduct.TabIndex = 21;
            this.pictureBoxAccountDashboardProduct.TabStop = false;
            // 
            // pbSidebarGreenProduct
            // 
            this.pbSidebarGreenProduct.Image = global::CoffeeShopPOS.Properties.Resources.green1;
            this.pbSidebarGreenProduct.Location = new System.Drawing.Point(90, 53);
            this.pbSidebarGreenProduct.Name = "pbSidebarGreenProduct";
            this.pbSidebarGreenProduct.Size = new System.Drawing.Size(12, 25);
            this.pbSidebarGreenProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSidebarGreenProduct.TabIndex = 2;
            this.pbSidebarGreenProduct.TabStop = false;
            // 
            // pBSidebarProduct
            // 
            this.pBSidebarProduct.Image = global::CoffeeShopPOS.Properties.Resources.admin;
            this.pBSidebarProduct.Location = new System.Drawing.Point(16, 24);
            this.pBSidebarProduct.Name = "pBSidebarProduct";
            this.pBSidebarProduct.Size = new System.Drawing.Size(65, 61);
            this.pBSidebarProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSidebarProduct.TabIndex = 0;
            this.pBSidebarProduct.TabStop = false;
            // 
            // pbPlusProduct
            // 
            this.pbPlusProduct.Image = global::CoffeeShopPOS.Properties.Resources.Plus1;
            this.pbPlusProduct.Location = new System.Drawing.Point(714, 148);
            this.pbPlusProduct.Name = "pbPlusProduct";
            this.pbPlusProduct.Size = new System.Drawing.Size(31, 29);
            this.pbPlusProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlusProduct.TabIndex = 31;
            this.pbPlusProduct.TabStop = false;
            // 
            // lblUploadProduct
            // 
            this.lblUploadProduct.AutoSize = true;
            this.lblUploadProduct.Location = new System.Drawing.Point(578, 103);
            this.lblUploadProduct.Name = "lblUploadProduct";
            this.lblUploadProduct.Size = new System.Drawing.Size(133, 23);
            this.lblUploadProduct.TabIndex = 32;
            this.lblUploadProduct.Text = "Image Upload: ";
            // 
            // ProductForm
            // 
            this.ClientSize = new System.Drawing.Size(1202, 703);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelButtonsProduct);
            this.Controls.Add(this.panelSidebar);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting Interface";
            this.Load += new System.EventHandler(this.ProductForm_Load_1);
            this.panelMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProduct)).EndInit();
            this.groupProductManagement.ResumeLayout(false);
            this.groupProductManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminDashboardProduct)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtonsProduct.ResumeLayout(false);
            this.panelButtonsProduct.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadProductLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIconDashboardProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBellIconDashboardProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCartDashboardProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountDashboardProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarGreenProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSidebarProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlusProduct)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pBSidebarProduct;
        private PictureBox pictureBoxSearchIconDashboardProduct;
        private PictureBox pictureBoxBellIconDashboardProduct;
        private PictureBox pictureBoxCartDashboardProduct;
        private PictureBox pictureBoxAccountDashboardProduct;
        private Button btnLogout;
        private Button btnCustomer;
        private Button btnProductsSales;
        private Button btnDashboard;
        private Label lblHeaderProduct;
        private Label lblSidebarStatusProduct;
        private Label lblSearchDashboardProduct;
        private Label lblSidebarTestingProduct;
        private TextBox textBoxSearchBarDashboardProduct;
        private PictureBox pbSidebarGreenProduct;
        private Panel panelMain;
        private DataGridView dgvAdminDashboardProduct;
        private Panel panelHeader;
        private Button btnSettings;
        private TextBox txtSearchProduct;
        private Panel panelButtonsProduct;
        private Button btnSearchProduct;
        private Label lblSearchProduct;
        private Button btnReporting;
        private Button btnStaffManagement;
        private Button btnMembership;
        private Panel panelSidebar;
        private GroupBox groupProductManagement;
        private TextBox txtProductIDProduct;
        private TextBox txtProductNameProduct;
        private ComboBox cmbCategoryProduct;
        private TextBox txtPriceProduct;
        private TextBox txtStockProduct;
        private TextBox txtReorderProduct;
        private Button btnAddProductAdmin;
        private Button btnUpdateProductAdmin;
        private Button btnDeleteProductAdmin;
        private Label lblID;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblReorder;
        private Button btnRemoveProductAdmin;
        private GroupBox groupBox1;
        private DataGridView dataGridViewAllProduct;
        private Label lblDescriptionUploadProduct;
        private Label label2;
        private PictureBox pictureBoxUploadProductLeft;
        private DataGridViewTextBoxColumn productIDProduct;
        private DataGridViewTextBoxColumn productNameProduct;
        private DataGridViewTextBoxColumn categoryProduct;
        private DataGridViewTextBoxColumn priceProduct;
        private DataGridViewTextBoxColumn stockProduct;
        private DataGridViewTextBoxColumn imgPathProduct;
        private DataGridViewTextBoxColumn dateProduct;
        private Button button2;
        private Button button1;
        private TextBox txtDescriptionProduct;
        private Label lblDescriptionProduct;
        private Button btnImgUploadProduct;
        private Button btnCreateProductAdmin;
        private Button btnClearProductAdmin;
        private Button btnInventory;
        private PictureBox pbPlusProduct;
        private Label lblUploadProduct;
    }
}
