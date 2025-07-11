using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    internal class ProductImage
    {
        public int ImageId { get; set; }
        public string ImageURL { get; set; }
        public int ImageOrder { get; set; }
        public int ProductId { get; set; }
        public ProductCatalog ProductCatalog { get; set; }
    }
}
