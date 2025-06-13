using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_StudentSystem.Models
{
    public enum ResourceType { Video, Presentation, Document, Other }
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }

        //Child Foregien Key with Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
