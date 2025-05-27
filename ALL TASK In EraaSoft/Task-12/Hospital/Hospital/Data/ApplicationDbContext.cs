
using Hospital.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<CompleteAppintment> CompleteAppintments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            #region Seed Data in Doctor Model :

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Pediatrics", Img = "~/assets/image/doctor/doctor1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Michael Lee", Specialization = "Dermatology", Img = "~/assets/image/doctor/doctor2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Abdulrahaman Shandy", Specialization = "Orthopedics", Img = "~/assets/image/doctor/doctor3.jpg" },
                new Doctor { Id = 4, Name = "Dr. Emily Davis", Specialization = "Neurology", Img = "~/assets/image/doctor/doctor4.jpg" },
                new Doctor { Id = 5, Name = "Dr. Sarah Johnson", Specialization = "Neurology", Img = "~/assets/image/doctor/doctor4.jpg" },
                new Doctor { Id = 6, Name = "Dr. John Smith", Specialization = "Neurology", Img = "~/assets/image/doctor/doctor4.jpg" }
                );
            #endregion

        }



    }
}
