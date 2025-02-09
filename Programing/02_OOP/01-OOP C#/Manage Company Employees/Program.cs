/*
Manage Company Employees

Required:
Create a class named Employee.
The class contains the following properties: Name, Position, Salary.

Make Salary private and add a function:
To change the salary if the user has permissions (for example via a password).
To display employee data.
 */
using System.Xml.Linq;

namespace Manage_Company_Employees
{
    class Employee
    {
        public string Name {  get;  set; }
        public string Position { get;  set; }
        public double Salary { get; private set; }
        public bool IsPermaision { get; set; }
        public Employee(string name = "Null", string position = "Null", double salary = 900 , bool isPermaision = false)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("You Must Enter Name");
            if (string.IsNullOrWhiteSpace(position))
                throw new ArgumentNullException("You Must Enter Position");
            if (salary <= 0)
                throw new ArgumentOutOfRangeException("You Must Enter Salary");

            this.Name = name;
            this.Position = position;
            this.Salary = salary;
            IsPermaision = isPermaision;
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Name is {Name} And Position {Position} And Salary Is {Salary}");
        }

        public void ChangeSalary(double value )
        {
            if (IsPermaision)
            {
                Salary = value;
                Console.WriteLine("Change Salary.");
            }
            else
                {
                Console.WriteLine("Can Not Change Salary");
                }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Abdoo" , ".net Dev" , 7000);
            employee1.PrintEmployee();
            employee1.ChangeSalary(10000);

            Console.WriteLine();

            Employee employee2 = new Employee("Admin", "Manager", 5000 , true);
            employee2.PrintEmployee();
            employee2.ChangeSalary(10000);
            employee2.PrintEmployee();
        }
    }
}
