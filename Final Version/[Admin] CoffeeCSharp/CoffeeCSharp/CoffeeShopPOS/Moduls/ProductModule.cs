using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace POS_CoffeShop
{
    // Product Model Class
    public class Product   // <--- must be EXACT NAME
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Supplier { get; set; }
    }

    // Products Management Module with In-Memory Database
    public class ProductsManagementModule
    {
        private List<Product> products;
        private int nextId;

        public ProductsManagementModule()
        {
            products = new List<Product>();
            nextId = 1;
            InitializeSampleData();
        }

        // Initialize with sample data
        private void InitializeSampleData()
        {
            AddProduct(new Product
            {
                ProductName = "Laptop HP Pavilion",
                Category = "Electronics",
                Price = 899.99m,
                Stock = 15,
                Supplier = "Tech Distributors Inc."
            });

            AddProduct(new Product
            {
                ProductName = "Wireless Mouse",
                Category = "Electronics",
                Price = 24.99m,
                Stock = 50,
                Supplier = "Peripheral World"
            });

            AddProduct(new Product
            {
                ProductName = "Office Chair",
                Category = "Office Supplies",
                Price = 149.99m,
                Stock = 30,
                Supplier = "Furniture Plus"
            });

            AddProduct(new Product
            {
                ProductName = "Coffee Maker",
                Category = "Home & Garden",
                Price = 79.99m,
                Stock = 20,
                Supplier = "Kitchen Essentials"
            });

            AddProduct(new Product
            {
                ProductName = "Running Shoes",
                Category = "Sports & Outdoors",
                Price = 89.99m,
                Stock = 40,
                Supplier = "SportGear Ltd."
            });
        }

        // Get all products as DataTable for DataGridView
        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Supplier", typeof(string));

            foreach (var product in products)
            {
                dt.Rows.Add(
                    product.ProductID,
                    product.ProductName,
                    product.Category,
                    product.Price,
                    product.Stock,
                    product.Supplier
                );
            }

            return dt;
        }

        // Add new product
        public bool AddProduct(Product product)
        {
            try
            {
                product.ProductID = nextId++;
                products.Add(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Update existing product
        public bool UpdateProduct(Product updatedProduct)
        {
            try
            {
                var product = products.FirstOrDefault(p => p.ProductID == updatedProduct.ProductID);
                if (product != null)
                {
                    product.ProductName = updatedProduct.ProductName;
                    product.Category = updatedProduct.Category;
                    product.Price = updatedProduct.Price;
                    product.Stock = updatedProduct.Stock;
                    product.Supplier = updatedProduct.Supplier;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Delete product
        public bool DeleteProduct(int productId)
        {
            try
            {
                var product = products.FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    products.Remove(product);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        // Search products by name, category, or supplier
        public DataTable SearchProducts(string searchTerm)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Supplier", typeof(string));

            var searchResults = products.Where(p =>
                p.ProductName.ToLower().Contains(searchTerm.ToLower()) ||
                p.Category.ToLower().Contains(searchTerm.ToLower()) ||
                p.Supplier.ToLower().Contains(searchTerm.ToLower())
            ).ToList();

            foreach (var product in searchResults)
            {
                dt.Rows.Add(
                    product.ProductID,
                    product.ProductName,
                    product.Category,
                    product.Price,
                    product.Stock,
                    product.Supplier
                );
            }

            return dt;
        }

        // Get product by ID
        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.ProductID == productId);
        }

        // Get products by category
        public List<Product> GetProductsByCategory(string category)
        {
            return products.Where(p => p.Category == category).ToList();
        }

        // Get low stock products (stock < 10)
        public List<Product> GetLowStockProducts()
        {
            return products.Where(p => p.Stock < 10).ToList();
        }

        // Get total inventory value
        public decimal GetTotalInventoryValue()
        {
            return products.Sum(p => p.Price * p.Stock);
        }

        // Get product count
        public int GetProductCount()
        {
            return products.Count;
        }
    }
}