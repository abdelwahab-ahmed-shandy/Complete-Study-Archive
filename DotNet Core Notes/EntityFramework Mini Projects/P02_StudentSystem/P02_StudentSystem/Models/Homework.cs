using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentSystem.Models
{
    public enum ContentType { Application, Pdf , Zip }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public ContentType ContentType { get; set; }
        public string Content { get; set; }
        public DateTime SubmissionTime { get; set; }
        //Child Foregien Key with Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
        //Child Foregien Key with Student
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
