using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeShopPOS
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void panelAdminCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void Report_Load(object sender, EventArgs e)
        {
            // 1) Build static product list
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

            // 2) Generate mock popularity data and show chart
            var popularity = GenerateMockPopularity(products);
            var top10 = GetTop10PopularItems(popularity);
            ShowTopItemsChart(top10);

            // 3) Load static best-selling items table
            LoadTopSellingStaticData();
        }

        // ======================================================
        //  STATIC TABLE: BEST-SELLING ITEMS (LEFT SIDE)
        // ======================================================
        private void LoadTopSellingStaticData()
        {
            dgvTopItems.Columns.Clear();
            dgvTopItems.Rows.Clear();

            dgvTopItems.Columns.Add("ProductName", "Product Name");
            dgvTopItems.Columns.Add("UnitsSold", "Units Sold");
            dgvTopItems.Columns.Add("Revenue", "Revenue ($)");

            dgvTopItems.Rows.Add("Cappuccino", 520, 1820.50);
            dgvTopItems.Rows.Add("Latte", 488, 1650.20);
            dgvTopItems.Rows.Add("Caramel Macchiato", 450, 1705.10);
            dgvTopItems.Rows.Add("Espresso", 430, 1075.00);
            dgvTopItems.Rows.Add("Mocha", 410, 1450.75);
            dgvTopItems.Rows.Add("Green Tea", 380, 980.30);
            dgvTopItems.Rows.Add("Croissant", 360, 540.00);
            dgvTopItems.Rows.Add("Chocolate Muffin", 345, 517.50);
            dgvTopItems.Rows.Add("Blueberry Muffin", 330, 495.20);
            dgvTopItems.Rows.Add("Milk Tea", 325, 910.10);

            dgvTopItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ======================================================
        //  BAR CHART: TOP POPULAR PRODUCTS (RIGHT SIDE)
        // ======================================================
        private void ShowTopItemsChart(List<KeyValuePair<string, int>> topItems)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Top 10 Most Popular Products");
            chart1.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            chart1.Titles[0].ForeColor = Color.FromArgb(40, 40, 40);

            var area = new ChartArea("Area");
            chart1.ChartAreas.Add(area);

            area.BackColor = Color.White;
            area.BorderColor = Color.Transparent;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;

            var series = chart1.Series.Add("Popularity");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            Color[] colors =
            {
                Color.FromArgb(93,175,240), Color.FromArgb(114,211,174),
                Color.FromArgb(255,203,112), Color.FromArgb(255,140,112),
                Color.FromArgb(155,130,255), Color.FromArgb(255,168,204),
                Color.FromArgb(120,120,120), Color.FromArgb(90,198,255),
                Color.FromArgb(255,122,122), Color.FromArgb(255,219,112)
            };

            for (int i = 0; i < topItems.Count; i++)
            {
                series.Points.AddXY(topItems[i].Key, topItems[i].Value);
                series.Points[i].Color = colors[i % colors.Length];

                if (i == 0)
                {
                    series.Points[i].Color = Color.FromArgb(0, 120, 255);
                    series.Points[i].BorderWidth = 2;
                    series.Points[i].BorderColor = Color.Black;
                }
            }
        }

        // ======================================================
        //  MOCK POPULARITY GENERATOR
        // ======================================================
        private Dictionary<string, int> GenerateMockPopularity(List<string> products)
        {
            Random rnd = new Random();
            var popularity = new Dictionary<string, int>();

            foreach (var p in products)
                popularity[p] = rnd.Next(20, 500);

            return popularity;
        }

        // ======================================================
        //  GET TOP 10 POPULAR ITEMS
        // ======================================================
        private List<KeyValuePair<string, int>> GetTop10PopularItems(Dictionary<string, int> popularity)
        {
            return popularity
                .OrderByDescending(p => p.Value)
                .Take(10)
                .ToList();
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


        private void dgvTopItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvAdminDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
