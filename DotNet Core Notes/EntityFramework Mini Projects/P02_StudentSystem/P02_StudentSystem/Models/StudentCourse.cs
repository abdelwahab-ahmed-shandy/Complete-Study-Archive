using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentSystem.Models
{
    internal class StudentCourse
    {
        //Child Foregien Key with Course
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        //Child Foregien Key with Student
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
