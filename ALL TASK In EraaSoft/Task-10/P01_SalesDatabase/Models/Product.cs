using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
       
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }
       
        public double? Quantity { get; set; }
        public double Price { get; set; }
        public int Sales {  get; set; }

        public string Description { get; set; }
    }
}
