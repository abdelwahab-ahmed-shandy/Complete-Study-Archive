using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime TransactionDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
