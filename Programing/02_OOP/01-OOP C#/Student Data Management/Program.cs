/*
Managing Student Data
Required:

Create a class named Student.
The class has the following properties: Name, Age, Grade.
Make the properties private and use getters and setters to control access to them.
Add constraints to validate the data:
Name cannot be empty.
Age must be between 18 and 30.
Grade must be between 0 and 100.
Add a function to print the student data.
 */

using System.Xml.Linq;
namespace Student_Data_Management
{
    class Student
    {
        private string name { get; set; }
        private int age { get; set; }
        private int grade { get; set; }

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name Can Not Be Empty");
                else
                    name = value;
            }
        }
        public int Grade
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 100)
                    grade = value;
                else
                    throw new ArgumentException("The number must be between 0 and 100.");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 30)
                    age = value;
                else
                    throw new ArgumentException("Age must be between 18 and 30.");
            }
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Grade : {Grade}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();

                student.Name = "Abdelwahab";
                student.Age = 22;
                student.Grade = 99;

                student.PrintStudentInfo();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}
