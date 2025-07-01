using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Store
    {
        public int StoreId { get; set; }
        [Unicode(true)]
        [MaxLength(80)]
        public string Name { get; set; }

        public int Sales { get; set; }

    }
}
