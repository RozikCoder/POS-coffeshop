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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            this.Load += Customer_Load;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Customer_Load(object sender, EventArgs e)
        {
            StyleCustomerGrid(dataGridView1);
            AddCustomerColumns();
            AddMockCustomers();
        }
        private void AddCustomerColumns()
        {
            dataGridView1.Columns.Add("CustomerName", "Customer Name");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("JoinDate", "Join Date");
            dataGridView1.Columns.Add("TotalSpent", "Total Spent ($)");
            dataGridView1.Columns.Add("Status", "Status");
        }

        private void AddMockCustomers()
        {
            // FIRST: fixed 20 membership customers (NO active/inactive)
            List<(string, string, string, string, string, string)> membership = new List<(string, string, string, string, string, string)>
    {
        ("Pisey Sok",        "012345678", "pisey@example.com",        "2023-04-10", "350.00", "Gold"),
        ("Dara Chenda",      "098765432", "dara@example.com",         "2023-02-15", "220.50", "Silver"),
        ("Sophea Kim",       "011223344", "sophea@example.com",       "2022-11-03", "120.00", "Bronze"),
        ("Rathana Phan",     "010998877", "rathana@example.com",      "2023-05-21", "410.75", "Gold"),
        ("Vuthy Chan",       "092667788", "vuthy@example.com",        "2023-07-30", "650.00", "Platinum"),

        ("Chanthy Lim",      "093445566", "chanthy@example.com",      "2023-03-11", "200.00", "Silver"),
        ("Sokun Mey",        "088112233", "sokunmey@example.com",     "2023-06-02", "330.50", "Gold"),
        ("Kimsan Roeun",     "085998877", "kimsan@example.com",       "2022-08-19", "80.00",  "Bronze"),
        ("Pheara Chhim",     "096778899", "pheara@example.com",       "2023-01-14", "120.75", "Silver"),
        ("Sreyneang Oum",    "097223344", "sreyneang@example.com",    "2023-04-28", "300.00", "Gold"),

        ("Vichea Ngin",      "012556677", "vichea@example.com",       "2023-06-10", "780.25", "Platinum"),
        ("Leakena Sath",     "099112244", "leakena@example.com",      "2022-09-05", "60.00",  "Bronze"),
        ("Rith Dara",        "093889900", "rithdara@example.com",     "2023-03-30", "150.00", "Silver"),
        ("Kanha Sorn",       "098332211", "kanha@example.com",        "2023-05-17", "270.50", "Gold"),
        ("Sokphea Ty",       "010337799", "sokphea@example.com",      "2023-06-25", "195.00", "Silver"),

        ("Dalis Kim",        "011559977", "dalis@example.com",        "2022-10-22", "90.00",  "Bronze"),
        ("Makara Keo",       "086221133", "makara@example.com",       "2023-02-18", "310.75", "Gold"),
        ("Sreypov Nan",      "089774455", "sreypov@example.com",      "2023-07-05", "880.00", "Platinum"),
        ("Vanda Hok",        "097665544", "vanda@example.com",        "2023-01-27", "165.00", "Silver"),
        ("Reaksa Yim",       "015889922", "reaksa@example.com",       "2023-03-06", "420.90", "Gold")
    };

            foreach (var c in membership)
            {
                dataGridView1.Rows.Add(c.Item1, c.Item2, c.Item3, c.Item4, c.Item5, c.Item6);
            }

            // SECOND: Generate Khmer regular customers (no Active/Inactive)
            List<string> khmerFirst = new List<string>()
    {
        "Sok","Raksmey","Chann","Dara","Vutha","Phanith","Sophal","Kosal","Makara","Reaksa",
        "Linda","Sreypov","Kanha","Dalis","Vichea","Kimleng","Sophea","Rathana","Vutha","Monita"
    };

            List<string> khmerLast = new List<string>()
    {
        "Sok","Kim","Chhim","Chan","Roeun","Ngin","Sath","Hok","Keo","Yim","Oum","Lim","Ty"
    };

            Random rnd = new Random();

            for (int i = 0; i < 40; i++)
            {
                string fullName = khmerFirst[rnd.Next(khmerFirst.Count)] + " " +
                                  khmerLast[rnd.Next(khmerLast.Count)];

                string phone = "09" + rnd.Next(10000000, 99999999).ToString();

                string email = fullName.Replace(" ", "").ToLower() + rnd.Next(1, 99) + "@gmail.com";

                DateTime joinDate = DateTime.Now.AddDays(-rnd.Next(30, 700));

                double spent = Math.Round(rnd.NextDouble() * 200, 2);

                string status = "Regular";

                dataGridView1.Rows.Add(
                    fullName,
                    phone,
                    email,
                    joinDate.ToShortDateString(),
                    spent,
                    status
                );
            }
        }

        private void StyleCustomerGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;

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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Customer_Load_1(object sender, EventArgs e)
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

        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            Report f2 = new Report();

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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdminDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
