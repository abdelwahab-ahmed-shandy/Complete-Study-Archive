using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=P01_SalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        DbSet<Models.Product> Products { get; set; }
        DbSet<Models.Customer> Customers { get; set; }
        DbSet<Models.Sale> Sales { get; set; }
        DbSet<Models.Store> Stores { get; set; }

    }
}
