using System;
using System.Windows.Forms;

namespace POS_CoffeShop.Modules
{
    public class ReportModule
    {
        public void GenerateSalesReport(DataGridView dgv)
        {
            dgv.Columns.Add("Date", "Date");
            dgv.Columns.Add("OrderID", "Order ID");
            dgv.Columns.Add("Customer", "Customer");
            dgv.Columns.Add("Items", "Items");
            dgv.Columns.Add("Total", "Total");
            dgv.Columns.Add("Payment", "Payment Method");

            // Sample data
            dgv.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "ORD-001", "John Doe", "3", "$25.50", "Cash");
            dgv.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "ORD-002", "Jane Smith", "2", "$18.00", "Card");
            dgv.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "ORD-003", "Bob Wilson", "5", "$42.75", "Card");
            dgv.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "ORD-004", "Alice Brown", "1", "$4.50", "Cash");
            dgv.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "ORD-005", "Charlie Davis", "4", "$35.20", "Mobile");
        }

        public void GenerateIncomeReport(DataGridView dgv)
        {
            dgv.Columns.Add("Date", "Date");
            dgv.Columns.Add("Revenue", "Revenue");
            dgv.Columns.Add("Cost", "Cost");
            dgv.Columns.Add("Profit", "Profit");
            dgv.Columns.Add("Margin", "Margin %");

            // Sample data
            dgv.Rows.Add("2024-11-17", "$2,450.50", "$980.20", "$1,470.30", "60%");
            dgv.Rows.Add("2024-11-16", "$2,180.00", "$872.00", "$1,308.00", "60%");
            dgv.Rows.Add("2024-11-15", "$2,650.75", "$1,060.30", "$1,590.45", "60%");
            dgv.Rows.Add("2024-11-14", "$2,320.50", "$928.20", "$1,392.30", "60%");
            dgv.Rows.Add("2024-11-13", "$2,890.00", "$1,156.00", "$1,734.00", "60%");
        }

        public void GenerateProductSalesReport(DataGridView dgv)
        {
            dgv.Columns.Add("Product", "Product");
            dgv.Columns.Add("Category", "Category");
            dgv.Columns.Add("Quantity", "Qty Sold");
            dgv.Columns.Add("Revenue", "Revenue");
            dgv.Columns.Add("Rank", "Rank");

            dgv.Rows.Add("Cappuccino", "Coffee", "156", "$702.00", "1");
            dgv.Rows.Add("Latte", "Coffee", "142", "$568.00", "2");
            dgv.Rows.Add("Espresso", "Coffee", "98", "$343.00", "3");
            dgv.Rows.Add("Croissant", "Pastry", "87", "$217.50", "4");
            dgv.Rows.Add("Muffin", "Pastry", "65", "$130.00", "5");
        }

        public void GenerateInventoryReport(DataGridView dgv)
        {
            dgv.Columns.Add("Product", "Product");
            dgv.Columns.Add("Current", "Current Stock");
            dgv.Columns.Add("Minimum", "Min Stock");
            dgv.Columns.Add("Value", "Stock Value");
            dgv.Columns.Add("Status", "Status");

            dgv.Rows.Add("Coffee Beans", "45 kg", "20 kg", "$540.00", "OK");
            dgv.Rows.Add("Milk", "15 liters", "25 liters", "$45.00", "Low");
            dgv.Rows.Add("Sugar", "30 kg", "15 kg", "$60.00", "OK");
            dgv.Rows.Add("Cups", "500 pcs", "200 pcs", "$100.00", "OK");
        }

        public void GenerateCustomerReport(DataGridView dgv)
        {
            dgv.Columns.Add("Membership", "Membership");
            dgv.Columns.Add("Count", "Count");
            dgv.Columns.Add("TotalSpent", "Total Spent");
            dgv.Columns.Add("AvgSpent", "Avg Spent");
            dgv.Columns.Add("Points", "Total Points");

            dgv.Rows.Add("Platinum", "12", "$45,620.00", "$3,801.67", "15,200");
            dgv.Rows.Add("Gold", "45", "$98,450.00", "$2,187.78", "38,500");
            dgv.Rows.Add("Silver", "125", "$165,000.00", "$1,320.00", "52,800");
            dgv.Rows.Add("Regular", "450", "$245,000.00", "$544.44", "68,500");
        }

        public void GenerateStaffPerformanceReport(DataGridView dgv)
        {
            dgv.Columns.Add("Staff", "Staff Name");
            dgv.Columns.Add("Role", "Role");
            dgv.Columns.Add("Orders", "Orders");
            dgv.Columns.Add("Sales", "Total Sales");
            dgv.Columns.Add("Rating", "Rating");

            dgv.Rows.Add("Sarah Cashier", "Cashier", "245", "$12,450.00", "4.8");
            dgv.Rows.Add("Mike Barista", "Cashier", "198", "$9,850.00", "4.6");
            dgv.Rows.Add("Emma Staff", "Cashier", "156", "$7,320.00", "4.5");
        }
    }
}