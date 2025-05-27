using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    internal class ProductCatalog
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public int CategoryId { get; set; }
        
        public ProductCategory ProductCategory { get; set; }

        public ICollection<Models.OrderItem> OrderItems { get; set; }
        public ICollection<Models.ProductImage> ProductImages { get; set; }
        public ICollection<Models.Review> Reviews { get; set; }
    }
}
