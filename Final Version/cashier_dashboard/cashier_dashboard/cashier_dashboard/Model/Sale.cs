using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_dashboard.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<SaleItem> Items { get; set; }

        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public decimal DiscountRate { get; set; }




    }
}
