using System;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            this.Load += AdminDashboardForm_LoadDashboard;
        }
        private User currentUser;

        public void SetCurrentUser(User user)
        {
            this.currentUser = user;
            this.Text = $"Admin Dashboard - Welcome {user.FullName}";
        }
        private void AdminDashboardForm_LoadDashboard(object sender, EventArgs e)
        {
            lvLowStockAdmin.Items.Add(new ListViewItem(new string[]
            {
        "Coffee Beans", "Coffee", "5", "10", "Low Stock", "Supplier A"
            }));

            lvLowStockAdmin.Items.Add(new ListViewItem(new string[]
            {
        "Milk Bottle 1L", "Dairy", "2", "5", "Critical Stock", "Supplier B"
            }));

            lvLowStockAdmin.Items.Add(new ListViewItem(new string[]
            {
        "Syrup", "Ingredients", "4", "6", "Low Stock", "Supplier C"
            }));
        }


        private void dgvInventoryDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelSidebarDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelButtonsDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeaderDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCustomersDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchDashboard_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventoryDashboard_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navInventoryDashboard_Click(object sender, EventArgs e)
        {

        }

        private void navCustomersDashboard_Click(object sender, EventArgs e)
        {

        }

        private void navReportingDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panelSidebarDashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchDashboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void navSettingsDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panelMainDashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalItemsDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblHeaderDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panelHeaderDashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelButtonsDashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInventoryDashboard_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelButtonsDashboard_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dgvInventoryDashboard_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdminDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdminDashboard_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAdminSales_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvAdminDashboard_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAdminTopTitle_Click(object sender, EventArgs e)
        {

        }

        private void chartAdminTopSelling_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            AdminDashboardForm f2 = new AdminDashboardForm();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnProductsSales_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            ProductForm f2 = new ProductForm();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            InventoryForm f2 = new InventoryForm();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            Customer f2 = new Customer();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            MembershipForm f2 = new MembershipForm();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            StaffForm f2 = new StaffForm();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            Report f2 = new Report();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            Settings f2 = new Settings();

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open next form
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvAdminDashboard_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSearchIconDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
