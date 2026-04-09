using System;
using System.Data;

namespace CoffeeShopPOS
{
    // Minimal mock data store for interface-only mode.
    internal static class MockDataStore
    {
        internal static DataTable InventoryTable;
        internal static DataTable CustomersTable;
        internal static DataTable SalesTable;
        internal static DataTable SaleItemsTable;
        internal static bool Initialized = false;

        internal static void EnsureInitialized()
        {
            if (Initialized) return;

            InventoryTable = new DataTable();
            InventoryTable.Columns.Add("ItemID", typeof(int));
            InventoryTable.Columns.Add("ItemName");
            InventoryTable.Columns.Add("Category");
            InventoryTable.Columns.Add("Quantity", typeof(int));
            InventoryTable.Columns.Add("UnitPrice", typeof(decimal));

            CustomersTable = new DataTable();
            CustomersTable.Columns.Add("CustomerID", typeof(int));
            CustomersTable.Columns.Add("MemberID");
            CustomersTable.Columns.Add("CustomerName");

            SalesTable = new DataTable();
            SalesTable.Columns.Add("SaleID", typeof(int));
            SalesTable.Columns.Add("SaleDate", typeof(DateTime));
            SalesTable.Columns.Add("TotalAmount", typeof(decimal));

            SaleItemsTable = new DataTable();
            SaleItemsTable.Columns.Add("ItemName");
            SaleItemsTable.Columns.Add("Quantity", typeof(int));
            SaleItemsTable.Columns.Add("Subtotal", typeof(decimal));

            // Optionally add a single row to each table so designers can show a preview.
            InventoryTable.Rows.Add(1, "Espresso", "Coffee", 50, 2.50m);
            CustomersTable.Rows.Add(1, "M001", "Alice Smith");
            SalesTable.Rows.Add(1, DateTime.Today, 25.50m);
            SaleItemsTable.Rows.Add("Espresso", 10, 25.00m);

            Initialized = true;
        }
    }
}
