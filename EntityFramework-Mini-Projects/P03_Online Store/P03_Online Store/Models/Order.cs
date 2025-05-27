using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    public enum Status
    {
        Success,
        Failed,
    }
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public Status Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Models.Payment> Payments { get; set; }
        public ICollection<Models.Shipping> Shippings { get; set; }
        public ICollection<Models.OrderItem> OrderItems { get; set; }
    }
}
