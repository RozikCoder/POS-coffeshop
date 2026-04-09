using POS_CoffeShop.Moduls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS_CoffeShop
{
    public partial class inventory : Form
    {
        private InventoryModule module = new InventoryModule();
        private int selectedInventoryId = -1;

        public inventory()
        {
            InitializeComponent();

            SetupColumnNames();
            ConnectEventHandlers();
            LoadInventory();
        }

        private void SetupColumnNames()
        {
            dataGridViewTextBoxColumn1.Name = "ID";
            dataGridViewTextBoxColumn2.Name = "Product";
            dataGridViewTextBoxColumn3.Name = "CurrentStock";
            dataGridViewTextBoxColumn4.Name = "MinStock";
            dataGridViewTextBoxColumn5.Name = "MaxStock";
            dataGridViewTextBoxColumn6.Name = "Unit";
            dataGridViewTextBoxColumn7.Name = "Status";
            dataGridViewTextBoxColumn8.Name = "LastUpdated";
        }

        private void ConnectEventHandlers()
        {
            btnUpdate.Click += BtnUpdate_Click;
            btnSearch.Click += BtnSearch_Click;
            btnAdd.Click += BtnRefresh_Click;
            btnDelete.Click += BtnDelete_Click;   // FIXED

            dgvInventory.CellClick += DgvInventory_CellClick;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Validate Product
            if (string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                MessageBox.Show("Please enter a product name!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Numbers
            if (!int.TryParse(txtCurrentStock.Text, out int current) || current < 0)
            {
                MessageBox.Show("Please enter a valid current stock!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMinStock.Text, out int min) || min < 0)
            {
                MessageBox.Show("Please enter a valid minimum stock!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMaxStock.Text, out int max) || max < min)
            {
                MessageBox.Show("Maximum stock must be greater than minimum stock!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbUnit.Text))
            {
                MessageBox.Show("Please select a unit!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new inventory item
            InventoryItem newItem = new InventoryItem
            {
                Product = cmbProduct.Text,
                CurrentStock = current,
                MinStock = min,
                MaxStock = max,
                Unit = cmbUnit.Text
            };


        }

        private void LoadInventory()
        {
            dgvInventory.Rows.Clear();

            foreach (var item in module.InventoryList)
            {
                dgvInventory.Rows.Add(
                    item.ID,
                    item.Product,
                    item.CurrentStock,
                    item.MinStock,
                    item.MaxStock,
                    item.Unit,
                    item.CurrentStock < item.MinStock ? "Low Stock" : "OK",
                    item.LastUpdated
                );
            }

            ColorCodeRows();
        }

        private void ColorCodeRows()
        {
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["CurrentStock"].Value == null ||
                    row.Cells["MinStock"].Value == null)
                    continue;

                int current = Convert.ToInt32(row.Cells["CurrentStock"].Value);
                int min = Convert.ToInt32(row.Cells["MinStock"].Value);

                if (current < min)
                {
                    row.Cells["Status"].Value = "Low Stock";
                    row.Cells["Status"].Style.BackColor = Color.FromArgb(255, 200, 200);
                    row.Cells["Status"].Style.ForeColor = Color.DarkRed;
                }
                else
                {
                    row.Cells["Status"].Value = "OK";
                    row.Cells["Status"].Style.BackColor = Color.FromArgb(200, 255, 200);
                    row.Cells["Status"].Style.ForeColor = Color.DarkGreen;
                }
            }
        }

        // FIXED DeleteItem using correct name: module (NOT inventoryModule)
        private void DeleteItem(int itemId)
        {
            try
            {
                var item = module.InventoryList.FirstOrDefault(i => i.ID == itemId);
                if (item == null)
                {
                    MessageBox.Show("Item not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{item.Product}'?\n\n" +
                    $"Current Stock: {item.CurrentStock} {item.Unit}\n" +
                    $"This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    module.DeleteItem(itemId);

                    MessageBox.Show($"'{item.Product}' has been deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadInventory();  // FIXED name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId == -1)
            {
                MessageBox.Show("Select an item to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteItem(selectedInventoryId);
            ClearForm();
        }

        private void DgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

            selectedInventoryId = Convert.ToInt32(row.Cells["ID"].Value);

            cmbProduct.Text = row.Cells["Product"].Value?.ToString() ?? "";
            txtCurrentStock.Text = row.Cells["CurrentStock"].Value?.ToString() ?? "";
            txtMinStock.Text = row.Cells["MinStock"].Value?.ToString() ?? "";
            txtMaxStock.Text = row.Cells["MaxStock"].Value?.ToString() ?? "";
            cmbUnit.Text = row.Cells["Unit"].Value?.ToString() ?? "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInventoryId == -1)
            {
                MessageBox.Show("Please select an item to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCurrentStock.Text, out int current) || current < 0 ||
                !int.TryParse(txtMinStock.Text, out int min) || min < 0 ||
                !int.TryParse(txtMaxStock.Text, out int max) || max < min)
            {
                MessageBox.Show("Invalid numbers entered!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmbUnit.Text))
            {
                MessageBox.Show("Please select a unit!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            module.UpdateItem(selectedInventoryId, current, min, max, cmbUnit.Text);

            LoadInventory();
            ClearForm();

            MessageBox.Show("Inventory updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                bool match = row.Cells["Product"].Value.ToString().ToLower().Contains(search);
                row.Visible = match || string.IsNullOrEmpty(search);
            }
        }



       


        private void ClearForm()
        {
            selectedInventoryId = -1;

            cmbProduct.SelectedIndex = -1;
            txtCurrentStock.Clear();
            txtMinStock.Clear();
            txtMaxStock.Clear();
            cmbUnit.SelectedIndex = -1;
        }



        private void inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
