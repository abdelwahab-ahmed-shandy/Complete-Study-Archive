using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentSystem.Data
{
    internal class StudentSystemContext : DbContext 
    {
        /// <summary>
        /// Connect with DB 
        /// </summary>
        /// <param name="optionsBuilder">On Configuring With Data Base</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystemDB;Integrated Security=True;TrustServerCertificate=True");

        }

        //Create Table In DB
        public DbSet<Models.Student> Students { get; set; } = null!;
        public DbSet<Models.Course> Courses { get; set; } = null!;
        public DbSet<Models.Resource> Resources { get; set; } = null!;
        public DbSet<Models.Homework> Homeworks { get; set; } = null!;
        public DbSet<Models.StudentCourse> StudentCourses { get; set; } = null!;
        // Edit Mode in Table 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Student>(entity => 
            {
                entity.HasKey(entity => entity.StudentId);

                entity.Property(entity => entity.Name)
                .HasMaxLength(100)
                .IsUnicode(true)
                .IsRequired(true);

                entity.Property(entity => entity.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsRequired(false);

                entity.Property(entity => entity.RegisteredOn)
                .IsRequired(true);

                entity.Property(entity => entity.BirthDay)
                .IsRequired(false);

            });

            modelBuilder.Entity<Models.Course>(entity => 
            {
                entity.HasKey(entity => entity.CourseId);

                entity.Property(entity => entity.Name)
                .HasMaxLength(80)
                .IsUnicode(true)
                .IsRequired(true);

                entity.Property(entity => entity.Description)
                .IsUnicode (true)
                .IsRequired(false);

            });

            modelBuilder.Entity<Models.Resource>(entity => 
            {
                entity.HasKey(entity => entity.ResourceId);

                entity.Property(entity => entity.Name)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(true);

                entity.Property(entity => entity.Url)
                .IsUnicode(false)
                .IsRequired(true);

                entity.Property(entity => entity.ResourceType)
                .IsRequired(true);

               

            });

            modelBuilder.Entity<Models.Homework>(entity => 
            {
                entity.HasKey(e => e.HomeworkId);

                entity.Property(e => e.Content)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Models.StudentCourse>(e => 
            { 
                e.HasKey(e => new {e.StudentId , e.CourseId });

                e.HasOne(e => e.Course)
                .WithMany(cs => cs.StudentsEnrolled)
                .HasForeignKey(e => e.CourseId);

                e.HasOne(e=> e.Student)
                .WithMany(sc=> sc.StudentCourses)
                .HasForeignKey(e=> e.StudentId);
            
            });

            // Seed Some Data :

            // In Course :
            modelBuilder.Entity<Models.Course>().HasData(

                new Models.Course
                {
                    CourseId = 1,
                    Name = "C++",
                    Description = "This Good Courese",
                    StartDate = DateTime.Now
                ,
                    EndDate = DateTime.Now.AddMonths(2),
                    Price = 20.0
                },

                new Models.Course
                {
                    CourseId = 2,
                    Name = "C#",
                    Description = "This Nice Courese",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(2),
                    Price = 30.0
                });

            // In Student :
            modelBuilder.Entity<Models.Student>().HasData(

                new Models.Student
                {
                    StudentId = 1,
                    Name = "Abdelwahab Shandy",
                    RegisteredOn = DateTime.Now,
                    PhoneNumber = "01017417",
                    BirthDay = new DateTime(2002, 1, 1)
                },

                new Models.Student
                {
                    StudentId = 2,
                    Name = "Anas Shandy",
                    RegisteredOn = DateTime.Now,
                    PhoneNumber = "902290",
                    BirthDay = new DateTime(2010, 1, 1)
                });

            //In StudentCourse :
            modelBuilder.Entity<Models.StudentCourse>().HasData(

                new Models.StudentCourse { CourseId = 1, StudentId = 1 },

                new Models.StudentCourse { CourseId = 2, StudentId = 2 });

            //In Homework :
            modelBuilder.Entity<Models.Homework>().HasData(

                new Models.Homework
                {
                    HomeworkId = 1,
                    StudentId = 1,
                    ContentType = Models.ContentType.Application,
                    SubmissionTime = DateTime.Now,
                    CourseId = 1,
                    Content = "C++ Mini Project"
                },

                new Models.Homework
                {
                    HomeworkId = 2,
                    StudentId = 2,
                    ContentType = Models.ContentType.Pdf,
                    SubmissionTime = DateTime.Now,
                    CourseId = 2,
                    Content = "C# Mini Project"
                });

            //In Resource :
            modelBuilder.Entity<Models.Resource>().HasData(

                new Models.Resource
                {
                    ResourceId = 1,
                    Name = "C++",
                    Url = "programmingadvices.com",
                    ResourceType = Models.ResourceType.Video,
                    CourseId = 1
                },

                new Models.Resource
                {
                    ResourceId = 2,
                    Name = "C#",
                    Url = "programmingadvices.com",
                    ResourceType = Models.ResourceType.Document,
                    CourseId = 2
                }

                );

        }
    }
}
