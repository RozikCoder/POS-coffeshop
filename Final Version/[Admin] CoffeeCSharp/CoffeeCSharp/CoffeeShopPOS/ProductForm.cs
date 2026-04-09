using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load_1(object sender, EventArgs e)
        {
            LoadSampleProducts();
            StyleDataGridView(dataGridViewAllProduct);
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            // Remove ugly borders
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;

            // Column header style
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;

            // Row style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.RowTemplate.Height = 35;

            // Grid color
            dgv.GridColor = Color.LightGray;

            // Auto-size columns
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadSampleProducts()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Product ID");
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("Price");
            dt.Columns.Add("Stock");
            dt.Columns.Add("Image Path");
            dt.Columns.Add("Status");
            dt.Columns.Add("Date");

            // STATIC SAMPLE DATA (20 PRODUCTS)
            dt.Rows.Add("P001", "Cappuccino", "Coffee", "3.50", "120", "cap.jpg", "Active", "2023-01-10");
            dt.Rows.Add("P002", "Latte", "Coffee", "3.20", "98", "latte.jpg", "Active", "2023-02-05");
            dt.Rows.Add("P003", "Mocha", "Coffee", "3.80", "77", "mocha.jpg", "Active", "2023-03-12");
            dt.Rows.Add("P004", "Espresso", "Coffee", "2.50", "150", "espresso.jpg", "Active", "2023-01-25");

            dt.Rows.Add("P005", "Green Tea", "Tea", "2.10", "64", "green_tea.jpg", "Active", "2023-04-01");
            dt.Rows.Add("P006", "Milk Tea", "Tea", "2.80", "140", "milk_tea.jpg", "Active", "2023-02-15");
            dt.Rows.Add("P007", "Thai Tea", "Tea", "2.90", "87", "thai_tea.jpg", "Active", "2023-04-18");
            dt.Rows.Add("P008", "Lemon Tea", "Tea", "2.40", "92", "lemon_tea.jpg", "Active", "2023-05-02");

            dt.Rows.Add("P009", "Chocolate Cake", "Bakery", "4.50", "33", "cake.jpg", "Active", "2023-03-03");
            dt.Rows.Add("P010", "Croissant", "Bakery", "1.80", "50", "croissant.jpg", "Active", "2023-03-27");
            dt.Rows.Add("P011", "Donut", "Bakery", "1.50", "120", "donut.jpg", "Active", "2023-04-11");
            dt.Rows.Add("P012", "Blueberry Muffin", "Bakery", "2.30", "46", "muffin.jpg", "Active", "2023-02-28");

            dt.Rows.Add("P013", "Cheese Sandwich", "Snacks", "2.50", "38", "sandwich.jpg", "Active", "2023-03-15");
            dt.Rows.Add("P014", "Beef Burger", "Snacks", "4.80", "20", "burger.jpg", "Active", "2023-04-04");
            dt.Rows.Add("P015", "Hotdog", "Snacks", "3.00", "25", "hotdog.jpg", "Active", "2023-05-09");

            dt.Rows.Add("P016", "Strawberry Smoothie", "Beverage", "3.20", "55", "smoothie.jpg", "Active", "2023-01-29");
            dt.Rows.Add("P017", "Mango Shake", "Beverage", "3.40", "61", "mango.jpg", "Active", "2023-02-22");
            dt.Rows.Add("P018", "Orange Juice", "Beverage", "2.60", "70", "orange.jpg", "Active", "2023-03-08");
            dt.Rows.Add("P019", "Water Bottle", "Beverage", "1.00", "200", "water.jpg", "Active", "2023-05-10");
            dt.Rows.Add("P020", "Soda Can", "Beverage", "1.20", "180", "soda.jpg", "Active", "2023-04-14");

            dataGridViewAllProduct.Columns.Clear();
            dataGridViewAllProduct.AutoGenerateColumns = true;
            dataGridViewAllProduct.DataSource = dt;


        }

        private void dgvAdminDashboardProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdminDashboardProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewAllProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDescriptionUploadProduct_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProductAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProductAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveProductAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProductAdmin_Click(object sender, EventArgs e)
        {

        }

        private void groupProductManagement_Enter(object sender, EventArgs e)
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
            this.Hide(); // hide current form

            SigninForm f2 = new SigninForm(); // ⬅ Redirect to SigninForm

            f2.FormClosed += (s, args) => this.Close(); // close previous after new closes

            f2.Show();  // open signin form
        }

    }
}
