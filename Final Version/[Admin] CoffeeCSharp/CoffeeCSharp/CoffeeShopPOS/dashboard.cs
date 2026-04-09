using System;
using System.Drawing;
using System.Windows.Forms;
using POS_CoffeShop.Moduls;

namespace POS_CoffeShop
{
    public partial class dashboard : Form
    {
        private DashboardModule dashboardModule;

        public dashboard()
        {
            InitializeComponent();
            dashboardModule = new DashboardModule();
            InitializeMenu();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void InitializeMenu()
        {
            // Logo Label
            Label lblLogo = new Label();
            lblLogo.Text = "☕ MANAGER\nDASHBOARD";
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            lblLogo.Location = new Point(0, 20);
            lblLogo.Size = new Size(250, 80);
            this.sidePanel.Controls.Add(lblLogo);

            // Menu Buttons
            int yPos = 120;
            AddMenuButton("🏠 Dashboard", yPos, btnDashboard_Click);
            yPos += 50;
            AddMenuButton("👥 Staff Management", yPos, btnStaff_Click);
            yPos += 50;
            AddMenuButton("📦 Products", yPos, btnProducts_Click);
            yPos += 50;
            AddMenuButton("📊 Inventory", yPos, btnInventory_Click);
            yPos += 50;
            AddMenuButton("👤 Customers", yPos, btnCustomers_Click);
            yPos += 50;
            AddMenuButton("📈 Reports", yPos, btnReports_Click);
            yPos += 50;
            AddMenuButton("⚙️ Settings", yPos, btnSettings_Click);
            yPos += 70;
            AddMenuButton("🚪 Logout", yPos, btnLogout_Click);
        }

        private void AddMenuButton(string text, int yPos, System.EventHandler clickHandler)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = new Point(0, yPos);
            btn.Size = new Size(250, 45);
            btn.BackColor = Color.FromArgb(52, 73, 94);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11F);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.Click += clickHandler;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(41, 128, 185);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(52, 73, 94);
            this.sidePanel.Controls.Add(btn);
        }

        private void LoadDashboardData()
        {
            mainPanel.Controls.Clear();

            // Welcome Label
            Label lblTitle = new Label();
            lblTitle.Text = "Dashboard Overview";
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(900, 40);
            mainPanel.Controls.Add(lblTitle);

            // Get statistics from module
            var stats = dashboardModule.GetDashboardStatistics();

            // Statistics Cards
            int xPos = 20;
            int yPos = 80;

            // Today's Income
            AddStatCard("Today's Income", stats.TodayIncome, Color.FromArgb(46, 204, 113), xPos, yPos);
            xPos += 230;

            // Monthly Income
            AddStatCard("Monthly Income", stats.MonthlyIncome, Color.FromArgb(52, 152, 219), xPos, yPos);
            xPos += 230;

            // Total Products
            AddStatCard("Total Products", stats.TotalProducts.ToString(), Color.FromArgb(241, 196, 15), xPos, yPos);
            xPos += 230;

            // Total Customers
            AddStatCard("Total Customers", stats.TotalCustomers.ToString(), Color.FromArgb(155, 89, 182), xPos, yPos);

            // Recent Transactions Table
            yPos = 260;
            Label lblTransactions = new Label();
            lblTransactions.Text = "Recent Transactions";
            lblTransactions.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTransactions.Location = new Point(20, yPos);
            lblTransactions.Size = new Size(900, 30);
            mainPanel.Controls.Add(lblTransactions);

            // DataGridView for transactions
            DataGridView dgvTransactions = new DataGridView();
            dgvTransactions.Location = new Point(20, yPos + 40);
            dgvTransactions.Size = new Size(900, 300);
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ReadOnly = true;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransactions.Columns.Add("OrderID", "Order ID");
            dgvTransactions.Columns.Add("Date", "Date");
            dgvTransactions.Columns.Add("Customer", "Customer");
            dgvTransactions.Columns.Add("Items", "Items");
            dgvTransactions.Columns.Add("Total", "Total");

            // Load recent transactions from module
            var transactions = dashboardModule.GetRecentTransactions();
            foreach (var transaction in transactions)
            {
                dgvTransactions.Rows.Add(
                    transaction.OrderID,
                    transaction.Date,
                    transaction.Customer,
                    transaction.Items,
                    transaction.Total
                );
            }

            mainPanel.Controls.Add(dgvTransactions);
        }

        private void AddStatCard(string title, string value, Color color, int x, int y)
        {
            Panel card = new Panel();
            card.BackColor = color;
            card.Location = new Point(x, y);
            card.Size = new Size(210, 120);

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 15);
            lblTitle.Size = new Size(190, 25);
            card.Controls.Add(lblTitle);

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblValue.ForeColor = Color.White;
            lblValue.Location = new Point(10, 50);
            lblValue.Size = new Size(190, 50);
            card.Controls.Add(lblValue);

            mainPanel.Controls.Add(card);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Management - Coming Soon", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Products Management - Coming Soon", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            try
            {
                inventory inventoryForm = new inventory();
                inventoryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                customer customerForm = new customer();
                customerForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                reports reportsForm = new reports();
                reportsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                settings settingsForm = new settings();
                settingsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}