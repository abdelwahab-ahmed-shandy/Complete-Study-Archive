using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    internal class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string ReviewText { get; set; }
        public double Rating { get; set; }
        public DateTime ReviewDate { get; set; }
        
        public Customer Customer { get; set; }
        public ProductCatalog ProductCatalog { get; set; }

    }
}
