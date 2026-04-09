using System;
using System.Windows.Forms;
using POS_CoffeShop;
using cashier_dashboard;


namespace CoffeeShopPOS
{
    public partial class SigninForm : Form
    {
        private AuthenticationModule authModule;

        public SigninForm()
        {
            InitializeComponent();
            authModule = new AuthenticationModule();
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {
            // Hide the signup section on load
            labelCreateAccountLogin.Visible = false;

            // Set focus to username
            txtUsernameLogin.Focus();

            // Enable password visibility toggle
            panel3Login.Cursor = Cursors.Hand;
            panel3Login.Click += Panel3Login_Click;
        }

        private void Panel3Login_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPasswordLogin.UseSystemPasswordChar = !txtPasswordLogin.UseSystemPasswordChar;
        }

        private void btnSigninLogin_Click(object sender, EventArgs e)
        {
            // Show login section
            label2Login.Visible = true;
            labelCreateAccountLogin.Visible = false;
            groupBox1Login.Visible = true;
        }

        private void btnSignupLeftLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignupForm signup = new SignupForm();
            signup.FormClosed += (s, args) => this.Close(); // close login when signup closes
            signup.Show();
        }


        private void btnSignupLogin_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs())
                return;

            string username = txtUsernameLogin.Text.Trim();
            string password = txtPasswordLogin.Text;

            // Authenticate user
            User authenticatedUser = authModule.AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                MessageBox.Show($"Welcome {authenticatedUser.FullName}!",
                    "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to appropriate dashboard based on role
                RedirectToDashboard(authenticatedUser);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordLogin.Clear();
                txtPasswordLogin.Focus();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsernameLogin.Text))
            {
                MessageBox.Show("Please enter your username.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsernameLogin.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordLogin.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPasswordLogin.Focus();
                return false;
            }

            return true;
        }

        private void RedirectToDashboard(User user)
        {
            this.Hide();

            try
            {
                Form dashboardForm = null;

                // ADMIN
                if (user.Role == "Admin")
                {
                    dashboardForm = new AdminDashboardForm();
                    ((AdminDashboardForm)dashboardForm).SetCurrentUser(user);
                }

                // MANAGER
                else if (user.Role == "Manager")
                {
                    dashboardForm = new POS_CoffeShop.ManagerDashboard();
                }

                // CASHIER
                else if (user.Role == "Cashier")
                {
                    dashboardForm = new cashier_dashboard.Form1();
                }

                if (dashboardForm != null)
                {
                    dashboardForm.FormClosed += Dashboard_FormClosed;
                    dashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user role.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening dashboard: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }


        private Form CreateManagerDashboard(User user)
        {
            // Create a temporary Manager Dashboard form
            Form managerForm = new Form();
            managerForm.Text = $"Manager Dashboard - Welcome {user.FullName}";
            managerForm.Size = new System.Drawing.Size(1000, 600);
            managerForm.StartPosition = FormStartPosition.CenterScreen;

            Label lblWelcome = new Label();
            lblWelcome.Text = $"Welcome, {user.FullName}\nRole: {user.Role}\n\nThis is Manager Dashboard";
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            lblWelcome.Location = new System.Drawing.Point(50, 50);
            lblWelcome.AutoSize = true;

            Button btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new System.Drawing.Size(100, 40);
            btnLogout.Location = new System.Drawing.Point(50, 150);
            btnLogout.Click += (s, e) => managerForm.Close();

            managerForm.Controls.Add(lblWelcome);
            managerForm.Controls.Add(btnLogout);

            return managerForm;
        }

        private Form CreateCashierDashboard(User user)
        {
            // Create a temporary Cashier Dashboard form
            Form cashierForm = new Form();
            cashierForm.Text = $"Cashier Dashboard - Welcome {user.FullName}";
            cashierForm.Size = new System.Drawing.Size(1000, 600);
            cashierForm.StartPosition = FormStartPosition.CenterScreen;

            Label lblWelcome = new Label();
            lblWelcome.Text = $"Welcome, {user.FullName}\nRole: {user.Role}\n\nThis is Cashier Dashboard";
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            lblWelcome.Location = new System.Drawing.Point(50, 50);
            lblWelcome.AutoSize = true;

            Button btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new System.Drawing.Size(100, 40);
            btnLogout.Location = new System.Drawing.Point(50, 150);
            btnLogout.Click += (s, e) => cashierForm.Close();

            cashierForm.Controls.Add(lblWelcome);
            cashierForm.Controls.Add(btnLogout);

            return cashierForm;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Clear inputs and show login form again
            txtUsernameLogin.Clear();
            txtPasswordLogin.Clear();
            this.Show();
            txtUsernameLogin.Focus();
        }

        private void panelRightLogin_Paint(object sender, PaintEventArgs e)
        {
            // Paint event handler (if needed for custom painting)
        }

        // Handle Enter key press for login
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSignupLogin_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    // User Model Class (included in same file to avoid reference issues)
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    // Authentication Module (included in same file to avoid reference issues)
    public class AuthenticationModule
    {
        private System.Collections.Generic.List<User> users;

        public AuthenticationModule()
        {
            users = new System.Collections.Generic.List<User>();
            InitializeDefaultUsers();
        }

        private void InitializeDefaultUsers()
        {
            // Add default Admin user
            users.Add(new User
            {
                UserID = 1,
                Username = "admin",
                Password = "admin123",
                FullName = "System Administrator",
                Role = "Admin",
                Email = "admin@coffeeshop.com",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            // Add default Manager user
            users.Add(new User
            {
                UserID = 2,
                Username = "manager",
                Password = "manager123",
                FullName = "Store Manager",
                Role = "Manager",
                Email = "manager@coffeeshop.com",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            // Add default Cashier user
            users.Add(new User
            {
                UserID = 3,
                Username = "cashier",
                Password = "cashier123",
                FullName = "Cashier User",
                Role = "Cashier",
                Email = "cashier@coffeeshop.com",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            // Additional sample users
            users.Add(new User
            {
                UserID = 4,
                Username = "john.admin",
                Password = "john2024",
                FullName = "John Smith",
                Role = "Admin",
                Email = "john@coffeeshop.com",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            users.Add(new User
            {
                UserID = 5,
                Username = "sarah.manager",
                Password = "sarah2024",
                FullName = "Sarah Johnson",
                Role = "Manager",
                Email = "sarah@coffeeshop.com",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            users.Add(new User
            {
                UserID = 6,
                Username = "mike.cashier",
                Password = "mike2024",
                FullName = "Mike Williams",
                Role = "Cashier",
                Email = "mike@coffeeshop.com",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
        }

        public User AuthenticateUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    user.Password == password &&
                    user.IsActive)
                {
                    return user;
                }
            }
            return null;
        }

        public System.Collections.Generic.List<User> GetAllUsers()
        {
            return users;
        }

        public bool AddUser(User user)
        {
            try
            {
                user.UserID = users.Count > 0 ? users[users.Count - 1].UserID + 1 : 1;
                user.CreatedDate = DateTime.Now;
                user.IsActive = true;
                users.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}