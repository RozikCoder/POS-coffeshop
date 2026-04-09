using System;
using System.Drawing;
using System.Windows.Forms;
using POS_CoffeShop.Moduls;

namespace POS_CoffeShop
{
    public partial class StaffManagementForm : Form
    {
        private StaffModule staffModule;

        public StaffManagementForm()
        {
            InitializeComponent();
            staffModule = new StaffModule();
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            dgvStaff.Rows.Clear();

            foreach (var staff in staffModule.GetAllStaff())
            {
                dgvStaff.Rows.Add(
                    staff.StaffID,
                    staff.FullName,
                    staff.Username,
                    staff.Role,
                    staff.Email,
                    staff.Phone,
                    staff.Status,
                    staff.LastLogin
                );
            }

            ColorCodeStatus();
        }

        private void ColorCodeStatus()
        {
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    if (row.Cells["Status"].Value.ToString() == "Active")
                    {
                        row.Cells["Status"].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.Cells["Status"].Style.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadStaffData();
                return;
            }

            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        found = true;
                        break;
                    }
                }
                row.Visible = found;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadStaffData();
            MessageBox.Show("Staff list refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                string details =
                    $"Staff Details:\n\n" +
                    $"Staff ID: {row.Cells["StaffID"].Value}\n" +
                    $"Name: {row.Cells["FullName"].Value}\n" +
                    $"Username: {row.Cells["Username"].Value}\n" +
                    $"Role: {row.Cells["Role"].Value}\n" +
                    $"Email: {row.Cells["Email"].Value}\n" +
                    $"Phone: {row.Cells["Phone"].Value}\n" +
                    $"Status: {row.Cells["Status"].Value}\n" +
                    $"Last Login: {row.Cells["LastLogin"].Value}";

                MessageBox.Show(details, "Staff Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}