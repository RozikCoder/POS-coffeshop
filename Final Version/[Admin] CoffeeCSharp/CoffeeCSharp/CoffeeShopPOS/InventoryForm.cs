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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm2_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dataGridViewAllProduct);

            // Create columns if they don't exist
            dataGridViewAllProduct.Columns.Add("ProductName", "Product Name");
            dataGridViewAllProduct.Columns.Add("Category", "Category");
            dataGridViewAllProduct.Columns.Add("StockQty", "Stock Qty");
            dataGridViewAllProduct.Columns.Add("MinQty", "Min Qty");
            dataGridViewAllProduct.Columns.Add("Status", "Status");
            dataGridViewAllProduct.Columns.Add("Supplier", "Supplier");

            // Load mock data
            AddMockInventoryData();
        }

        private void dataGridViewAllProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void AddMockInventoryData()
        {
            var products = new List<string>()
            {
                "Espresso Beans 1kg", "Arabica Beans 1kg", "Robusta Beans 1kg", "House Blend Beans 1kg",
                "Milk 1L", "Fresh Cream 500ml", "Soy Milk 1L", "Almond Milk 1L",
                "Hazelnut Syrup", "Vanilla Syrup", "Caramel Syrup", "Chocolate Syrup",
                "Strawberry Syrup", "Peppermint Syrup", "Pumpkin Spice Syrup",
                "Sugar 1kg", "Brown Sugar 1kg", "Honey 500ml",
                "Matcha Powder 500g", "Cocoa Powder 500g", "Chai Powder 500g",
                "Whipped Cream Can", "Ice Cubes Pack", "Tapioca Pearls 1kg",
                "Croissant", "Chocolate Muffin", "Blueberry Muffin", "Cheese Cake Slice",
                "Brownies", "Banana Bread Slice", "Bagel", "Donut Chocolate",
                "Donut Sugar", "Lemon Cake Slice", "Cookie Chocolate", "Cookie Oatmeal",
                "Plastic Cups 16oz", "Plastic Cups 22oz", "Paper Cups 12oz", "Paper Cups 16oz",
                "Cup Lids 12oz", "Cup Lids 16oz", "Cup Lids 22oz",
                "Straws Pack", "Napkins Pack", "Coffee Filters", "Stirrers Pack",
                "Takeaway Boxes", "Brown Bags Small", "Brown Bags Medium", "Brown Bags Large",
                "Tea Leaves Black", "Tea Leaves Green", "Chamomile Tea", "Earl Grey Tea",
                "Ice Cream Vanilla", "Ice Cream Chocolate", "Ice Cream Matcha",
                "Caramel Sauce Bottle", "Chocolate Sauce Bottle", "Frappé Base Powder",
                "Cloth Towels Pack", "Cleaning Spray", "Dishwashing Liquid",
                "Sanitizer Gel", "Hand Gloves Box", "Face Masks Box",
                "Espresso Cup", "Latte Cup", "Saucer Plates", "Glass Cup",
                "Milk Pitcher", "Tamper", "Knock Box", "Thermometer",
                "Shot Glass", "Scale Digital"
            };

            Random rnd = new Random();

            foreach (var product in products)
            {
                int stock = rnd.Next(1, 50);         // 1–50 units
                int minQty = rnd.Next(5, 15);        // 5–15
                string status = stock <= minQty ? "Low Stock" : "OK";
                string supplier = "Supplier " + (char)rnd.Next('A', 'F'); // Supplier A–E

                dataGridViewAllProduct.Rows.Add(product, 
                                                 GetCategory(product),
                                                 stock,
                                                 minQty,
                                                 status,
                                                 supplier);
            }
        }
        private string GetCategory(string product)
        {
            if (product.Contains("Beans")) return "Coffee Beans";
            if (product.Contains("Milk") || product.Contains("Cream")) return "Dairy";
            if (product.Contains("Syrup") || product.Contains("Sauce")) return "Syrups";
            if (product.Contains("Sugar") || product.Contains("Honey")) return "Sweeteners";
            if (product.Contains("Powder") || product.Contains("Matcha")) return "Powders";
            if (product.Contains("Croissant") || product.Contains("Muffin") || product.Contains("Cake") || product.Contains("Cookie") || product.Contains("Donut")) return "Bakery";
            if (product.Contains("Cups") || product.Contains("Lids") || product.Contains("Bags") || product.Contains("Filters")) return "Packaging";
            if (product.Contains("Tea")) return "Tea";
            if (product.Contains("Ice Cream")) return "Ice Cream";
            if (product.Contains("Cloth") || product.Contains("Cleaning") || product.Contains("Liquid") || product.Contains("Sanitizer")) return "Cleaning";
            if (product.Contains("Cup") || product.Contains("Pitcher") || product.Contains("Tamper") || product.Contains("Glass") || product.Contains("Thermometer") || product.Contains("Scale")) return "Equipment";
            return "General";
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

        private void dgvAdminDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewAllProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
