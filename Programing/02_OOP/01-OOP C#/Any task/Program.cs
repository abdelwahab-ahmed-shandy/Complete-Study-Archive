/*
Class person, student and teacher
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. To do this,
first create a Person class that has a Name property of type string,
a constructor that receives the name as a parameter, 
a destructor that assigns the name to empty and overwrites the ToString () method.

End the program by reading the people and executing the ToString () method on screen.
*/
using System.Xml.Linq;

namespace Any_task
{
    public class Person
    {
        public Person(string name = "Null", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class Student : Person
    {
        public Student 
        public string Study(string name , int age)
        {
            return $"I'm Studying";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
