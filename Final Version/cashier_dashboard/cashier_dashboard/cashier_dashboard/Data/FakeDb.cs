using cashier_dashboard.Model;
using System;
using System.Collections.Generic;

namespace cashier_dashboard.Data
{
    public static class FakeDb
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product { Id = 1, Name = "Latte", Price = 3.50M, Stock = 20 },
            new Product { Id = 2, Name = "Americano", Price = 2.50M, Stock = 20 },
            new Product { Id = 3, Name = "Cappuccino", Price = 4.00M, Stock = 20 },
            new Product { Id = 4, Name = "Croissant", Price = 3.20M, Stock = 50 },
            new Product { Id = 5, Name = "Sandwich", Price = 8.00M, Stock = 30 },
            new Product { Id = 6, Name = "Muffin", Price = 2.90M, Stock = 40 },
            new Product { Id = 7, Name = "Iced Tea", Price = 3.80M, Stock = 35 }
        };

        // REAL SALES DATA — WILL SHOW IN REPORTING TABLE!
        public static List<Sale> Sales = new List<Sale>
        {
            new Sale
            {
                SaleDate = DateTime.Today.AddDays(-5),
                TotalAmount = 342.80m,
                MemberId = "M001",
                Items = new List<SaleItem>
                {
                    new SaleItem { ProductName = "Coffee Latte", Qty = 20, Price = 4.50m },
                    new SaleItem { ProductName = "Croissant", Qty = 15, Price = 3.20m },
                    new SaleItem { ProductName = "Cappuccino", Qty = 12, Price = 5.00m }
                }
            },
            new Sale
            {
                SaleDate = DateTime.Today.AddDays(-3),
                TotalAmount = 518.60m,
                MemberId = "M003",
                Items = new List<SaleItem>
                {
                    new SaleItem { ProductName = "Sandwich", Qty = 18, Price = 8.00m },
                    new SaleItem { ProductName = "Iced Tea", Qty = 25, Price = 3.80m },
                    new SaleItem { ProductName = "Muffin", Qty = 30, Price = 2.90m }
                }
            },
            new Sale
            {
                SaleDate = DateTime.Today.AddDays(-1),
                TotalAmount = 289.00m,
                MemberId = null,
                Items = new List<SaleItem>
                {
                    new SaleItem { ProductName = "Coffee Latte", Qty = 35, Price = 4.50m },
                    new SaleItem { ProductName = "Croissant", Qty = 20, Price = 3.20m }
                }
            },
            new Sale
            {
                SaleDate = DateTime.Today,
                TotalAmount = 456.90m,
                MemberId = "M005",
                Items = new List<SaleItem>
                {
                    new SaleItem { ProductName = "Cappuccino", Qty = 28, Price = 5.00m },
                    new SaleItem { ProductName = "Sandwich", Qty = 22, Price = 8.00m },
                    new SaleItem { ProductName = "Muffin", Qty = 18, Price = 2.90m }
                }
            }
        };

        public static List<Member> Members = new List<Member>()
        {
            new Member { MemberId = "M001", Name = "Lida", DiscountRate = 0.10 },
            new Member { MemberId = "M002", Name = "Dara", DiscountRate = 0.05 },
            new Member { MemberId = "M003", Name = "Sok", DiscountRate = 0.15 },
            new Member { MemberId = "M004", Name = "Vannak", DiscountRate = 0.08 },
            new Member { MemberId = "M005", Name = "Srey", DiscountRate = 0.12 }
        };
    }
}