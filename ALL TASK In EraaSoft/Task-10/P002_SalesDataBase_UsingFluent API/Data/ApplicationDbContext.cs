using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDataBase_UsingFluent_API.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTest510;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Product>()
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Models.Customer>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsUnicode(true);
            modelBuilder.Entity<Models.Customer>()
                .Property(c => c.Email)
                .HasMaxLength(80)
                .IsUnicode(false);
            modelBuilder.Entity<Models.Store>()
                .Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            modelBuilder.Entity<Models.Sale>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Sales)
                .HasForeignKey(s => s.ProductId);

            modelBuilder.Entity<Models.Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId);
            
            modelBuilder.Entity<Models.Sale>()
                .HasOne(s => s.Store)
                .WithMany(s => s.Sales)
                .HasForeignKey(s => s.StoreId);



        }
    }
}
