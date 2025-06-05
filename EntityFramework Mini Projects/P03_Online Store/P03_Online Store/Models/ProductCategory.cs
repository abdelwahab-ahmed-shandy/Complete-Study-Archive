using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    internal class ProductCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Models.ProductCatalog> ProductCatalogs { get; set; }
    }
}
