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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadSampleStaff();
            StyleDataGridView(dataGridViewAllStaffAdmin);
        }
            private void StyleDataGridView(DataGridView dgv)
            {
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.RowHeadersVisible = false;

                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                dgv.ColumnHeadersHeight = 40;

                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv.RowTemplate.Height = 35;

                dgv.GridColor = Color.LightGray;

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            private void LoadSampleStaff()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Staff ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Role");
            dt.Columns.Add("Status");
            dt.Columns.Add("Description");
            dt.Columns.Add("ProfileImagePath");
            dt.Columns.Add("DateCreated");

            // 20 Khmer sample staff
            dt.Rows.Add("S001", "Pisey Sok", "Manager", "Active", "Responsible for shop operations", "pisey.png", "2023-03-01");
            dt.Rows.Add("S002", "Dara Chenda", "Cashier", "Active", "Handles customer payments", "dara.png", "2023-04-10");
            dt.Rows.Add("S003", "Sophea Kim", "Barista", "Active", "Makes coffee drinks", "sophea.png", "2023-02-15");
            dt.Rows.Add("S004", "Rathana Phan", "Cleaner", "Active", "Keeps store clean", "rathana.png", "2023-05-20");
            dt.Rows.Add("S005", "Vuthy Chan", "Cashier", "Inactive", "Left job recently", "vuthy.png", "2022-11-28");
            dt.Rows.Add("S006", "Chamroeun Sea", "Barista", "Active", "Specializes in iced drinks", "chamroeun.png", "2023-01-10");
            dt.Rows.Add("S007", "Leakena Nuch", "Manager", "Active", "Controls daily reports", "leakena.png", "2023-06-25");
            dt.Rows.Add("S008", "Makara Keo", "Security", "Active", "Monitors entrance", "makara.png", "2023-04-01");
            dt.Rows.Add("S009", "Sreypov Nan", "Barista", "Active", "Friendly and fast", "sreypov.png", "2023-07-02");
            dt.Rows.Add("S010", "Rith Dara", "Cashier", "Active", "Good customer service", "rith.png", "2023-03-14");
            dt.Rows.Add("S011", "Kanha Sorn", "Supervisor", "Active", "Supervises staff", "kanha.png", "2023-05-08");
            dt.Rows.Add("S012", "Sokphea Ty", "Cleaner", "Active", "Responsible and neat", "sokphea.png", "2023-01-30");
            dt.Rows.Add("S013", "Dalis Kim", "Barista", "Inactive", "On leave", "dalis.png", "2022-08-22");
            dt.Rows.Add("S014", "Vanda Hok", "Cashier", "Active", "Fast at POS", "vanda.png", "2023-02-11");
            dt.Rows.Add("S015", "Reaksa Yim", "Manager", "Active", "Works morning shift", "reaksa.png", "2023-06-18");
            dt.Rows.Add("S016", "Sokun Mey", "Cleaner", "Active", "Keeps dining area tidy", "sokun.png", "2023-04-27");
            dt.Rows.Add("S017", "Dalin Sam", "Barista", "Active", "Great latte art", "dalin.png", "2023-07-19");
            dt.Rows.Add("S018", "Kimsan Roeun", "Security", "Inactive", "Resigned", "kimsan.png", "2022-10-04");
            dt.Rows.Add("S019", "Pheara Chhim", "Cashier", "Active", "Loves greeting guests", "pheara.png", "2023-03-28");
            dt.Rows.Add("S020", "Sreyneang Oum", "Supervisor", "Active", "Trains new staff", "sreyneang.png", "2023-07-05");

            dataGridViewAllStaffAdmin.DataSource = dt;
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

        private void dataGridViewAllStaffAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxStaffAdmin_Enter(object sender, EventArgs e)
        {

        }
    }
}
