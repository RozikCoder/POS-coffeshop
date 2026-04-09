using System;
using System.Windows.Forms;
using POS_CoffeShop.Modules;

namespace POS_CoffeShop
{
    public partial class ProductsManagementForm : Form
    {
        private ProductsManagementModule module;

        public ProductsManagementForm()
        {
            InitializeComponent();
            module = new ProductsManagementModule();
            InitializeFormEvents();
        }

        private void InitializeFormEvents()
        {
            this.Load += ProductsManagementForm_Load;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSearch.Click += BtnSearch_Click;
            btnClear.Click += BtnClear_Click;
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
        }

        private void ProductsManagementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            ClearInputs();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = module.GetAllProducts();
            dgvProducts.Columns["ProductID"].HeaderText = "ID";
            dgvProducts.Columns["ProductName"].HeaderText = "Product Name";
            dgvProducts.Columns["Category"].HeaderText = "Category";
            dgvProducts.Columns["Price"].HeaderText = "Price";
            dgvProducts.Columns["Stock"].HeaderText = "Stock";
            dgvProducts.Columns["Supplier"].HeaderText = "Supplier";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var product = new Product
            {
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text),
                Supplier = txtSupplier.Text.Trim()
            };

            if (module.AddProduct(product))
            {
                MessageBox.Show("Product added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);

            var product = new Product
            {
                ProductID = productId,
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text),
                Supplier = txtSupplier.Text.Trim()
            };

            if (module.UpdateProduct(product))
            {
                MessageBox.Show("Product updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to update product.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);

                if (module.DeleteProduct(productId))
                {
                    MessageBox.Show("Product deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Failed to delete product.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadProducts();
                return;
            }

            dgvProducts.DataSource = module.SearchProducts(searchTerm);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dgvProducts.ClearSelection();
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                cboCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                txtSupplier.Text = row.Cells["Supplier"].Value.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter product name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboCategory.Text))
            {
                MessageBox.Show("Please select a category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Please enter supplier name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplier.Focus();
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtProductName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtStock.Clear();
            txtSupplier.Clear();
            txtSearch.Clear();
            txtProductName.Focus();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}