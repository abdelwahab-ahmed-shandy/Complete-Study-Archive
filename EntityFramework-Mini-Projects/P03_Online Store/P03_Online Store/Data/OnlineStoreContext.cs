using Microsoft.EntityFrameworkCore;
using P03_Online_Store.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Data
{
    internal class OnlineStoreContext : DbContext
    {
        public DbSet<Models.Payment> Payments { get; set; } = null!;
        public DbSet<Models.Customer> Customers { get; set; } = null!;
        public DbSet<Models.Order> Orders { get; set; } = null!;
        public DbSet<Models.Shipping> Shippings { get; set; } = null!;
        public DbSet<Models.OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Models.Review> Reviews { get; set; } = null!;
        public DbSet<Models.ProductCatalog> ProductCatalogs { get; set; } = null!;
        public DbSet<Models.ProductImage> ProductImages { get; set; } = null!;
        public DbSet<Models.ProductCategory> ProductCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EF_OnlineStore_DB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Payment>(entity =>
            {
                entity.HasKey(entity => entity.PaymentId);

                entity.Property(entity => entity.PaymentMethod)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(50);

                entity.Property(entity => entity.Amount)
                .IsRequired(true);

                entity.Property(entity => entity.TransactionDate)
                .IsRequired(true);
            });

            modelBuilder.Entity<Models.Customer>(entity =>
            {
                entity.HasKey(entity => entity.CustomerId);

                entity.Property(entity => entity.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

                entity.Property(entity => entity.Address)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(200);

                entity.Property(entity => entity.UserName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

                entity.Property(entity => entity.Email)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

                entity.Property(entity => entity.Phone)
                .IsUnicode(true)
                .IsRequired(true)
                .HasMaxLength(20);

                entity.Property(entity => entity.Password)
                .IsRequired(true)
                .HasMaxLength(100)
                .IsUnicode(true);
            });

            modelBuilder.Entity<Models.Order>(entity =>
            {
                entity.HasKey(entity => entity.OrderId);

                entity.Property(entity => entity.OrderDate)
                .IsRequired(true);

                entity.Property(entity => entity.TotalAmount)
                .IsRequired(true);

                entity.Property(entity => entity.Status)
                .IsRequired(true);

            });

            modelBuilder.Entity<Models.Shipping>(entity =>
            {
                entity.HasKey(entity => entity.ShippingId);

                entity.Property(entity => entity.CarrierName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

                entity.Property(entity => entity.TrackingNumber)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(true);

                entity.Property(entity => entity.ShippingStatus)
                .IsRequired(true);

                entity.Property(entity => entity.EstimatedDeliveryDate)
                .IsRequired(true);

                entity.Property(entity => entity.ActualDeliveryDate)
                .IsRequired(true);
            });

            modelBuilder.Entity<Models.OrderItem>(entity =>
            {
                entity.HasKey(entity => new { entity.OrderItemId, entity.ProductId });

                entity.Property(entity => entity.Quantity)
                .IsRequired(true);

                entity.Property(entity => entity.Price)
                .IsRequired(true);

                entity.Property(entity => entity.TotalItemsPrice)
                .IsRequired(true);

            });

            modelBuilder.Entity<Models.Review>(entity =>
            {
                entity.HasKey(entity => entity.ReviewId);

                entity.Property(entity => entity.ReviewText)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(500);

                entity.Property(entity => entity.Rating)
                .IsRequired(true);

                entity.Property(entity => entity.ReviewDate)
                .IsRequired(true);
            });

            modelBuilder.Entity<Models.ProductCatalog>(entity =>
            {
                entity.HasKey(entity => entity.ProductId);

                entity.Property(entity => entity.ProductName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

                entity.Property(entity => entity.Description)
                .IsRequired(false)
                .IsUnicode(true)
                .HasMaxLength(500);

                entity.Property(entity => entity.Price)
                .IsRequired(true);

                entity.Property(entity => entity.QuantityInStock)
                .IsRequired(true);
            });

            modelBuilder.Entity<Models.ProductCategory>(entity =>
            {
                entity.HasKey(entity => entity.CategoryId);

                entity.Property(entity => entity.CategoryName)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(100);

            });

            modelBuilder.Entity<Models.ProductImage>(entity =>
            {
                entity.HasKey(entity => entity.ImageId);

                entity.Property(entity => entity.ImageURL)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(400);
            });


            modelBuilder.Entity<Models.Order>()
                .HasOne(O => O.Customer)
                .WithMany(C => C.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Models.Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<Models.OrderItem>()
                .HasOne(Oi => Oi.Order)
                .WithMany(Oi => Oi.OrderItems)
                .HasForeignKey(Oi => Oi.OrderItemId);

            modelBuilder.Entity<Models.OrderItem>()
                .HasOne(Oi => Oi.ProductCatalog)
                .WithMany(Oi => Oi.OrderItems)
                .HasForeignKey(Oi => Oi.ProductId);

            modelBuilder.Entity<Models.Review>()
                .HasOne(R => R.ProductCatalog)
                .WithMany(P => P.Reviews)
                .HasForeignKey(R => R.ProductId);

            modelBuilder.Entity<Models.Review>()
                .HasOne(R => R.Customer)
                .WithMany(C => C.Reviews)
                .HasForeignKey(R => R.CustomerId);

            modelBuilder.Entity<Models.Payment>()
                .HasOne(p => p.Order)
                .WithMany(o => o.Payments)
                .HasForeignKey(p => p.OrderId);

            modelBuilder.Entity<Models.Shipping>()
                .HasOne(o => o.Order)
                .WithMany(s => s.Shippings)
                .HasForeignKey(o => o.OrderId);

            modelBuilder.Entity<Models.ProductCatalog>()
                .HasOne(c => c.ProductCategory)
                .WithMany(p => p.ProductCatalogs)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Models.ProductImage>()
                .HasOne(i => i.ProductCatalog)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(c => c.ProductId);

            //Seed Data :

            modelBuilder.Entity<Models.Customer>().HasData
                (new Models.Customer
                {
                    CustomerId = 1,
                    Name = "Abdelwahab Shandy",
                    Address = "Cairo",
                    Email = "example@email.com",
                    Phone = "87878798",
                    UserName = "as_Cyber",
                    Password = "*******"
                },

                new Models.Customer
                {
                    CustomerId = 2,
                    Name = "Anas Shandy",
                    Address = "Cairo",
                    Email = "as@mail.org",
                    Phone = "87878798",
                    UserName = "as_ber",
                    Password = "*******"
                }
                );

            modelBuilder.Entity<Models.Order>().HasData
                (
                    new Models.Order
                    {
                        OrderId = 1,
                        OrderDate = DateTime.Now,
                        TotalAmount = 600.5,
                        Status = Models.Status.Success,
                        CustomerId = 1,
                    },
                    new Models.Order
                    {
                        OrderId = 2,
                        OrderDate = DateTime.Now,
                        TotalAmount = 300.5,
                        Status = Models.Status.Failed,
                        CustomerId = 2,
                    }
                );

            modelBuilder.Entity<Models.Shipping>().HasData
                (
                new Models.Shipping
                {
                    ShippingId = 1,
                    CarrierName = "FedEx",
                    TrackingNumber = "123456789",
                    EstimatedDeliveryDate = DateTime.Now,
                    ActualDeliveryDate = DateTime.Now,
                    ShippingStatus = Models.ShippingStatus.Pending,
                    OrderId = 1
                },
                new Models.Shipping
                {
                    ShippingId = 2,
                    CarrierName = "DHL",
                    TrackingNumber = "987654321",
                    EstimatedDeliveryDate = DateTime.Now,
                    ActualDeliveryDate = DateTime.Now,
                    ShippingStatus = Models.ShippingStatus.Cancelled,
                    OrderId = 2
                }
                );

            modelBuilder.Entity<Models.ProductCatalog>().HasData
                (
                    new Models.ProductCatalog
                    {
                        ProductId = 1,
                        ProductName = "Laptop",
                        Description = "Dell",
                        Price = 999.99,
                        QuantityInStock = 50,
                        CategoryId = 1
                    },
                    new Models.ProductCatalog
                    {
                        ProductId = 2,
                        ProductName = "Smartphone",
                        Description = "Iphone12",
                        Price = 1999.99,
                        QuantityInStock = 90,
                        CategoryId = 2
                    }
                );

            modelBuilder.Entity<Models.OrderItem>().HasData
                (
                new Models.OrderItem
                {
                    OrderItemId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 400.40,
                    TotalItemsPrice = 50000.50
                },
                new Models.OrderItem
                {
                    OrderItemId = 2,
                    ProductId = 2,
                    Quantity = 3,
                    Price = 600.40,
                    TotalItemsPrice = 70000.50
                }
                );

            modelBuilder.Entity<Models.ProductCategory>().HasData
                (
                new Models.ProductCategory
                {
                    CategoryId = 1,
                    CategoryName = "Laptops"
                },
                new Models.ProductCategory
                {
                    CategoryId = 2,
                    CategoryName = "Phone"
                }
                );

            modelBuilder.Entity<Models.ProductImage>().HasData
                (
                    new Models.ProductImage
                    {
                        ImageId = 1,
                        ImageURL = "https://example.com/images/laptop.jpg",
                        ImageOrder = 1,
                        ProductId = 1,
                    },
                     new Models.ProductImage
                     {
                         ImageId = 2,
                         ImageURL = "https://example.com/images/phone.jpg",
                         ImageOrder = 2,
                         ProductId = 2,
                     }
                );

            modelBuilder.Entity<Models.Review>().HasData
                (
                new Models.Review
                {
                    ReviewId = 1,
                    ProductId = 1,
                    CustomerId = 1,
                    ReviewText = "This is a great product! Highly recommended.",
                    Rating = 5,
                    ReviewDate = DateTime.Now
                },
                new Models.Review
                {
                    ReviewId = 2,
                    ProductId = 2,
                    CustomerId = 2,
                    ReviewText = "This is a good phone! Highly recommended.",
                    Rating = 4,
                    ReviewDate = DateTime.Now
                }
                );

            modelBuilder.Entity<Models.Payment>().HasData
                (
                new Models.Payment
                {
                    PaymentId = 1,
                    Amount = 1,
                    PaymentMethod = "Credit Card",
                    TransactionDate = DateTime.Now,
                    OrderId = 1,
                },
                new Models.Payment
                {
                    PaymentId = 2,
                    Amount = 2,
                    PaymentMethod = "Chach Money",
                    TransactionDate = DateTime.Now,
                    OrderId = 2,
                }
                );

        }
    }
}
