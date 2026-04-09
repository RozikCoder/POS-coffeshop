using System;
using System.Collections.Generic;

namespace POS_CoffeShop.Moduls
{
    public class CustomerModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Membership { get; set; }
        public int Points { get; set; }
        public string TotalSpent { get; set; }
        public string JoinDate { get; set; }
    }

    public class CustomerModule
    {
        public List<CustomerModel> Customers { get; private set; }

        public CustomerModule()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            Customers = new List<CustomerModel>()
            {
                new CustomerModel { ID="C001", Name="John Doe", Phone="012-345-6789", Email="john@email.com", Membership="Platinum", Points=2500, TotalSpent="$5,420.00", JoinDate="2023-01-15" },
                new CustomerModel { ID="C002", Name="Jane Smith", Phone="012-345-6790", Email="jane@email.com", Membership="Gold", Points=1200, TotalSpent="$2,840.00", JoinDate="2023-03-20" },
                new CustomerModel { ID="C003", Name="Bob Wilson", Phone="012-345-6791", Email="bob@email.com", Membership="Silver", Points=550, TotalSpent="$1,320.00", JoinDate="2023-05-10" },
                new CustomerModel { ID="C004", Name="Alice Brown", Phone="012-345-6792", Email="alice@email.com", Membership="Regular", Points=180, TotalSpent="$450.00", JoinDate="2024-01-05" },
                new CustomerModel { ID="C005", Name="Charlie Davis", Phone="012-345-6793", Email="charlie@email.com", Membership="Gold", Points=980, TotalSpent="$2,150.00", JoinDate="2023-08-12" },
                new CustomerModel { ID="C006", Name="Diana Miller", Phone="012-345-6794", Email="diana@email.com", Membership="Silver", Points=420, TotalSpent="$980.00", JoinDate="2023-11-22" },
                new CustomerModel { ID="C007", Name="Eva Garcia", Phone="012-345-6795", Email="eva@email.com", Membership="Platinum", Points=3200, TotalSpent="$7,850.00", JoinDate="2022-12-08" },
                new CustomerModel { ID="C008", Name="Frank Martinez", Phone="012-345-6796", Email="frank@email.com", Membership="Regular", Points=95, TotalSpent="$245.00", JoinDate="2024-02-14" }
            };
        }

        public int GetTotalPoints()
        {
            int total = 0;
            foreach (var c in Customers)
                total += c.Points;

            return total;
        }
    }
}
