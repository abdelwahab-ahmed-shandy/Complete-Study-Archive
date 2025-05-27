using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }

        // Parent with Resource
        public ICollection<Models.Resource> Resources { get; set; } = new List<Models.Resource>();
        // Parent with Homework
        public ICollection<Models.Homework> HomeworkSubmissions { get; set; } = new List<Models.Homework>();
        // Parent with StudentCourses
        public ICollection<Models.StudentCourse> StudentsEnrolled { get; set; } = new List<Models.StudentCourse>();

    }
}
