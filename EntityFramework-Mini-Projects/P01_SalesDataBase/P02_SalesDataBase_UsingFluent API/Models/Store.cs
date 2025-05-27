using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDataBase_UsingFluent_API.Models
{
    internal class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
