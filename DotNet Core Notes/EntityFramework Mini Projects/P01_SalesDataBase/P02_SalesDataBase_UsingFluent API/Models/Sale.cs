using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDataBase_UsingFluent_API.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
