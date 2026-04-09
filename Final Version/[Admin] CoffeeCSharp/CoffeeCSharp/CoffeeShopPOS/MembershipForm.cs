using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    public partial class MembershipForm : Form
    {
        public MembershipForm()
        {
            InitializeComponent();
        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {
            LoadSampleMembers();
            StyleDataGridView(dataGridViewAllAdminMembership);  // <-- APPLY STYLE HERE
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            // Remove borders
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;

            // Column Header Style
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;

            // Row Style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowTemplate.Height = 35;

            // Grid Color
            dgv.GridColor = Color.LightGray;

            // Auto Column Sizing
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ============================================================
        //  LOAD STATIC MEMBERS
        // ============================================================
        private void LoadSampleMembers()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Member ID");
            dt.Columns.Add("Full Name");
            dt.Columns.Add("Membership Type");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Status");
            dt.Columns.Add("Join Date");
            dt.Columns.Add("Description");

            dt.Rows.Add("M006", "Chanthy Lim", "Silver", "093445566", "chanthy@example.com", "Active", "2023-03-11", "Comes every weekend");
            dt.Rows.Add("M007", "Sokun Mey", "Gold", "088112233", "sokunmey@example.com", "Active", "2023-06-02", "Coffee lover");
            dt.Rows.Add("M008", "Kimsan Roeun", "Bronze", "085998877", "kimsan@example.com", "Inactive", "2022-08-19", "Stopped visiting");
            dt.Rows.Add("M009", "Pheara Chhim", "Silver", "096778899", "pheara@example.com", "Active", "2023-01-14", "Regular tea buyer");
            dt.Rows.Add("M010", "Sreyneang Oum", "Gold", "097223344", "sreyneang@example.com", "Active", "2023-04-28", "Friendly customer");
            dt.Rows.Add("M011", "Vichea Ngin", "Platinum", "012556677", "vichea@example.com", "Active", "2023-06-10", "VIP premium member");
            dt.Rows.Add("M012", "Leakena Sath", "Bronze", "099112244", "leakena@example.com", "Inactive", "2022-09-05", "Inactive for long");
            dt.Rows.Add("M013", "Rith Dara", "Silver", "093889900", "rithdara@example.com", "Active", "2023-03-30", "Buys bakery items");
            dt.Rows.Add("M014", "Kanha Sorn", "Gold", "098332211", "kanha@example.com", "Active", "2023-05-17", "Weekly visitor");
            dt.Rows.Add("M015", "Sokphea Ty", "Silver", "010337799", "sokphea@example.com", "Active", "2023-06-25", "Friendly and polite");
            dt.Rows.Add("M016", "Dalis Kim", "Bronze", "011559977", "dalis@example.com", "Inactive", "2022-10-22", "Inactive customer");
            dt.Rows.Add("M017", "Makara Keo", "Gold", "086221133", "makara@example.com", "Active", "2023-02-18", "Prefers cold drinks");
            dt.Rows.Add("M018", "Sreypov Nan", "Platinum", "089774455", "sreypov@example.com", "Active", "2023-07-05", "Premium VIP member");
            dt.Rows.Add("M019", "Vanda Hok", "Silver", "097665544", "vanda@example.com", "Active", "2023-01-27", "Always buys snacks");
            dt.Rows.Add("M020", "Reaksa Yim", "Gold", "015889922", "reaksa@example.com", "Active", "2023-03-06", "Very loyal member");


            dataGridViewAllAdminMembership.DataSource = dt;
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

        private void groupBoxAdminMembership_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewAllAdminMembership_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
