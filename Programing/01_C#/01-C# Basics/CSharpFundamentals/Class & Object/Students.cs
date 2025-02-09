using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class___Object
{
    internal class Students
    {
        public Students(string name, int id)
        {
            Console.WriteLine("A New student : ");
            this.Name = name;
            this.Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
