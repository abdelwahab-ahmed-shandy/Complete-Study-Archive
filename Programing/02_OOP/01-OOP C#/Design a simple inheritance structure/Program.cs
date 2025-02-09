/*
Design a simple inheritance structure:

Create a class named Person with the following properties:
Name
Age

A Method named DisplayInfo that displays the name and age.
Create a subclass named Student that inherits from Person and has an additional property:
StudentID

A Method that displays all the information including the student number.
 */
namespace Design_a_simple_inheritance_structure
{
    class Person
    {
        public Person(string name, int age)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Can you Enter a String");
            if (age <= 0)
                throw new ArgumentOutOfRangeException("Can you Enter a Year Number");

            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name is {Name} , Age is {Age}");
        }
    }

    class Student : Person
    {
        public Student(int studentID , int age , string name) : base (name , age)
        {
            if (studentID <= 0)
                throw new ArgumentException("You Can Enter A Number ");

            StudentID = studentID;
        }

        public int StudentID { get; set; }

        public void InformationIncluding()
        {
            Console.WriteLine($"ID is {StudentID}, Name : {Name} , Age is {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(3,16,"Anas Shandy");
            Student student2 = new Student(2,19,"Abdelrahman Shandy");
            Student student3 = new Student(1, 22,"Abdelwahab Shandy");

            student1.InformationIncluding();
            student2.InformationIncluding();
            student3.InformationIncluding();
        }
    }
}
