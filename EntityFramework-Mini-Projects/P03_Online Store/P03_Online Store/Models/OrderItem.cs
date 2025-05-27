using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    internal class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalItemsPrice { get; set; }
        public ProductCatalog ProductCatalog { get; set; }
        public Order Order { get; set; }
    }
}
