using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_CoffeShop
{
    public partial class ManagerDashboard : Form
    {

        private Button currentButton;
        private Form currentChildForm;

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            // Load dashboard view by default
            LoadDashboardView();
        }

        // Method to highlight active button
        private void HighlightButton(Button btn)
        {
            // Reset previous button
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(52, 73, 94);
            }

            // Highlight current button
            currentButton = btn;
            currentButton.BackColor = Color.FromArgb(0, 122, 204);
        }

        // Method to clear main panel
        private void ClearMainPanel()
        {
            panelMain.Controls.Clear();

            // Close current child form if exists
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            }
        }

        // Method to open child form in panel
        private void OpenChildForm(Form childForm, string headerText)
        {
            ClearMainPanel();
            lblHeader.Text = headerText;

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Dashboard View (Home)
        private void LoadDashboardView()
        {
            ClearMainPanel();
            lblHeader.Text = "Dashboard";

            // Create statistics cards
            Panel cardContainer = new Panel
            {
                Location = new Point(20, 20),
                Size = new Size(960, 140),
                BackColor = Color.Transparent
            };

            // Card 1 - Total Sales Today
            Panel card1 = CreateStatCard("Total Sales Today", "$1,250.00", Color.FromArgb(46, 204, 113), 0);
            cardContainer.Controls.Add(card1);

            // Card 2 - Monthly Revenue
            Panel card2 = CreateStatCard("Monthly Revenue", "$38,500.00", Color.FromArgb(52, 152, 219), 240);
            cardContainer.Controls.Add(card2);

            // Card 3 - Total Customers
            Panel card3 = CreateStatCard("Total Customers", "142", Color.FromArgb(155, 89, 182), 480);
            cardContainer.Controls.Add(card3);

            // Card 4 - Active Products
            Panel card4 = CreateStatCard("Active Products", "48", Color.FromArgb(230, 126, 34), 720);
            cardContainer.Controls.Add(card4);

            panelMain.Controls.Add(cardContainer);

            // Recent Activity Section
            Panel activityPanel = new Panel
            {
                Location = new Point(20, 180),
                Size = new Size(960, 400),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label activityTitle = new Label
            {
                Text = "Recent Activity",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true,
                ForeColor = Color.FromArgb(45, 62, 80)
            };
            activityPanel.Controls.Add(activityTitle);

            ListView activityList = new ListView
            {
                Location = new Point(20, 60),
                Size = new Size(920, 320),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Font = new Font("Segoe UI", 10)
            };

            activityList.Columns.Add("Time", 150);
            activityList.Columns.Add("Action", 250);
            activityList.Columns.Add("User", 200);
            activityList.Columns.Add("Status", 150);

            // Sample data
            activityList.Items.Add(new ListViewItem(new[] { "10:30 AM", "New Order #1045", "Cashier John", "Completed" }));
            activityList.Items.Add(new ListViewItem(new[] { "10:15 AM", "Stock Updated", "Manager Sarah", "Success" }));
            activityList.Items.Add(new ListViewItem(new[] { "09:45 AM", "New Customer Registered", "Staff Mike", "Success" }));
            activityList.Items.Add(new ListViewItem(new[] { "09:30 AM", "Product Added", "Manager Sarah", "Success" }));

            activityPanel.Controls.Add(activityList);
            panelMain.Controls.Add(activityPanel);
        }

        // Helper method to create stat cards
        private Panel CreateStatCard(string title, string value, Color bgColor, int xOffset)
        {
            Panel card = new Panel
            {
                Size = new Size(220, 120),
                Location = new Point(xOffset, 0),
                BackColor = bgColor
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(15, 20),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 50),
                AutoSize = true
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }

        // Button Click Events
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            LoadDashboardView();
        }

        private void btnProductsSales_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProductsSales);
            try
            {
                OpenChildForm(new ProductsManagementForm(), "Products Management");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Products form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HighlightButton(btnInventory);
            try
            {
                OpenChildForm(new inventory(), "Inventory Management");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Inventory form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCustomer);
            try
            {
                OpenChildForm(new customer(), "Customer Management");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Customer form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnReporting_Click(object sender, EventArgs e)
        {
            HighlightButton(btnReporting);
            try
            {
                OpenChildForm(new reports(), "Reports & Analytics");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Reports form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HighlightButton(btnSettings);
            try
            {
                OpenChildForm(new settings(), "Settings");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Settings form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Close current form and return to login
                this.Close();

                // Optionally show login form
                // LoginForm loginForm = new LoginForm();
                // loginForm.Show();
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}