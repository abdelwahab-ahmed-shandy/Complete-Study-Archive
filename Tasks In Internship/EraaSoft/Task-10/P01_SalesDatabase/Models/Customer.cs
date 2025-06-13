using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        
        [Unicode(true)]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Unicode(false)]
        [MaxLength(80)]
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; }
        public int Sales { get; set; }
    }
}
