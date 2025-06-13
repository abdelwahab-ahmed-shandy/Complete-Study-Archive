using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public String? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? BirthDay { get; set; }
        // Parent with Homework
        public ICollection<Models.Homework> HomeworkSubmissions { get; set; } = new List<Models.Homework>();
        // Parent with StudentCourses
        public ICollection<Models.StudentCourse> StudentCourses { get; set; } = new List<Models.StudentCourse>();
    }
}
