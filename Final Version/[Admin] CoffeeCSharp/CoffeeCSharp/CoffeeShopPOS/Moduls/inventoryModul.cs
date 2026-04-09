using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_CoffeShop.Moduls
{
    public class InventoryModule
    {
        public List<InventoryItem> InventoryList { get; private set; }

        public InventoryModule()
        {
            InventoryList = new List<InventoryItem>();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            InventoryList.Add(new InventoryItem
            {
                ID = 1,
                Product = "Coffee Beans",
                CurrentStock = 45,
                MinStock = 20,
                MaxStock = 100,
                Unit = "kg",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 1,
                Product = "Coffee Beans",
                CurrentStock = 45,
                MinStock = 20,
                MaxStock = 100,
                Unit = "kg",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 2,
                Product = "Milk",
                CurrentStock = 30,
                MinStock = 10,
                MaxStock = 50,
                Unit = "L",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 3,
                Product = "Sugar",
                CurrentStock = 25,
                MinStock = 10,
                MaxStock = 80,
                Unit = "kg",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 4,
                Product = "Chocolate Syrup",
                CurrentStock = 12,
                MinStock = 5,
                MaxStock = 40,
                Unit = "L",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 5,
                Product = "Caramel Syrup",
                CurrentStock = 8,
                MinStock = 3,
                MaxStock = 30,
                Unit = "L",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 6,
                Product = "Disposable Cups",
                CurrentStock = 300,
                MinStock = 150,
                MaxStock = 600,
                Unit = "pcs",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 7,
                Product = "Straws",
                CurrentStock = 500,
                MinStock = 200,
                MaxStock = 1000,
                Unit = "pcs",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 8,
                Product = "Whipping Cream",
                CurrentStock = 18,
                MinStock = 8,
                MaxStock = 40,
                Unit = "L",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 9,
                Product = "Vanilla Powder",
                CurrentStock = 6,
                MinStock = 2,
                MaxStock = 20,
                Unit = "kg",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });

            InventoryList.Add(new InventoryItem
            {
                ID = 10,
                Product = "Ice Cubes",
                CurrentStock = 120,
                MinStock = 50,
                MaxStock = 200,
                Unit = "kg",
                LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            });


            // ... your other sample data
        }

        public void UpdateItem(int id, int currentStock, int minStock, int maxStock, string unit)
        {
            var item = InventoryList.FirstOrDefault(i => i.ID == id);
            if (item != null)
            {
                item.CurrentStock = currentStock;
                item.MinStock = minStock;
                item.MaxStock = maxStock;
                item.Unit = unit;
                item.LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            }
        }

        public void AddItem(InventoryItem item)
        {
            item.ID = InventoryList.Count > 0 ? InventoryList.Max(i => i.ID) + 1 : 1;
            item.LastUpdated = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            InventoryList.Add(item);
        }

        public void DeleteItem(int id)
        {
            var item = InventoryList.FirstOrDefault(i => i.ID == id);
            if (item != null)
            {
                InventoryList.Remove(item);
            }
        }

        public List<InventoryItem> SearchItems(string searchText)
        {
            searchText = searchText.ToLower();
            return InventoryList.Where(i =>
                i.Product.ToLower().Contains(searchText)
            ).ToList();
        }

        public int GetLowStockCount()
        {
            return InventoryList.Count(i => i.CurrentStock < i.MinStock);
        }

        public decimal GetTotalInventoryValue()
        {
            return InventoryList.Sum(i => i.CurrentStock * 10);
        }
    }





    public class InventoryItem
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public int CurrentStock { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string Unit { get; set; }
        public string LastUpdated { get; set; }
    }
}
