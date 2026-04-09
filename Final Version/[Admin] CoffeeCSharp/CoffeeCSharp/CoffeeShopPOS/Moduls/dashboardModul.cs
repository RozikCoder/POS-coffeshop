using System;
using System.Collections.Generic;

namespace POS_CoffeShop.Moduls
{
    public class DashboardModule
    {
        public DashboardStatistics GetDashboardStatistics()
        {
            // In a real application, this would fetch from database
            return new DashboardStatistics
            {
                TodayIncome = "$2,450.50",
                MonthlyIncome = "$45,320.00",
                TotalProducts = 156,
                TotalCustomers = 1234,
                YearlyIncome = "$485,450.00",
                TodayOrders = 48,
                MonthlyOrders = 1250
            };
        }

        public List<Transaction> GetRecentTransactions()
        {
            // In a real application, this would fetch from database
            var transactions = new List<Transaction>
            {
                new Transaction
                {
                    OrderID = "ORD-001",
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                    Customer = "John Doe",
                    Items = "3",
                    Total = "$25.50"
                },
                new Transaction
                {
                    OrderID = "ORD-002",
                    Date = DateTime.Now.AddMinutes(-15).ToString("yyyy-MM-dd HH:mm"),
                    Customer = "Jane Smith",
                    Items = "2",
                    Total = "$18.00"
                },
                new Transaction
                {
                    OrderID = "ORD-003",
                    Date = DateTime.Now.AddMinutes(-30).ToString("yyyy-MM-dd HH:mm"),
                    Customer = "Bob Wilson",
                    Items = "5",
                    Total = "$42.75"
                },
                new Transaction
                {
                    OrderID = "ORD-004",
                    Date = DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:mm"),
                    Customer = "Alice Brown",
                    Items = "1",
                    Total = "$4.50"
                },
                new Transaction
                {
                    OrderID = "ORD-005",
                    Date = DateTime.Now.AddHours(-2).ToString("yyyy-MM-dd HH:mm"),
                    Customer = "Charlie Davis",
                    Items = "4",
                    Total = "$35.20"
                }
            };

            return transactions;
        }

        public List<TopProduct> GetTopProducts()
        {
            // Top selling products
            return new List<TopProduct>
            {
                new TopProduct { Name = "Cappuccino", SoldCount = 156, Revenue = "$702.00" },
                new TopProduct { Name = "Latte", SoldCount = 142, Revenue = "$568.00" },
                new TopProduct { Name = "Espresso", SoldCount = 98, Revenue = "$343.00" },
                new TopProduct { Name = "Croissant", SoldCount = 87, Revenue = "$217.50" },
                new TopProduct { Name = "Muffin", SoldCount = 65, Revenue = "$130.00" }
            };
        }

        public List<LowStockItem> GetLowStockItems()
        {
            // Items that are running low
            return new List<LowStockItem>
            {
                new LowStockItem { Product = "Milk", CurrentStock = 15, MinStock = 25, Unit = "liters" },
                new LowStockItem { Product = "Pastries", CurrentStock = 8, MinStock = 15, Unit = "pieces" },
                new LowStockItem { Product = "Chocolate Syrup", CurrentStock = 6, MinStock = 8, Unit = "liters" }
            };
        }

        public SalesAnalytics GetSalesAnalytics(string period)
        {
            // Get sales data for charts/graphs
            // Period can be: "daily", "weekly", "monthly", "yearly"

            return new SalesAnalytics
            {
                Period = period,
                TotalRevenue = 45320.00m,
                TotalCost = 18128.00m,
                TotalProfit = 27192.00m,
                ProfitMargin = 60.0m,
                GrowthRate = 15.5m
            };
        }

        public int GetTodayOrdersCount()
        {
            // Count of orders today
            return 48;
        }

        public decimal GetAverageOrderValue()
        {
            // Average value per order
            return 51.04m;
        }

        public string GetBestSellingCategory()
        {
            // Most popular product category
            return "Coffee";
        }

        public int GetNewCustomersThisMonth()
        {
            // New customer registrations this month
            return 89;
        }
    }

    // Data models
    public class DashboardStatistics
    {
        public string TodayIncome { get; set; }
        public string MonthlyIncome { get; set; }
        public string YearlyIncome { get; set; }
        public int TotalProducts { get; set; }
        public int TotalCustomers { get; set; }
        public int TodayOrders { get; set; }
        public int MonthlyOrders { get; set; }
    }

    public class Transaction
    {
        public string OrderID { get; set; }
        public string Date { get; set; }
        public string Customer { get; set; }
        public string Items { get; set; }
        public string Total { get; set; }
    }

    public class TopProduct
    {
        public string Name { get; set; }
        public int SoldCount { get; set; }
        public string Revenue { get; set; }
    }

    public class LowStockItem
    {
        public string Product { get; set; }
        public int CurrentStock { get; set; }
        public int MinStock { get; set; }
        public string Unit { get; set; }
    }

    public class SalesAnalytics
    {
        public string Period { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalProfit { get; set; }
        public decimal ProfitMargin { get; set; }
        public decimal GrowthRate { get; set; }
    }
}