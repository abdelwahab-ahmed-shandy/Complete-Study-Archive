/*
Abstract Class
Scenario: Create an application that models different types of employees in a company.

Instructions:

Define an abstract class Employee with:
A string property Name.
An abstract method CalculateSalary() that returns a decimal.

Create two derived classes:
FullTimeEmployee: Takes a fixedSalary and calculates the salary based on it.
PartTimeEmployee: Takes hoursWorked and hourlyRate and calculates the salary as hoursWorked * hourlyRate.

Write a Main method that:
Creates instances of both FullTimeEmployee and PartTimeEmployee.
Calls CalculateSalary() and displays the results.
 */
namespace Abstract
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Enter String Name , Not empty");
            Name = name;
        }

        public abstract decimal GetSalary();
    }
    public class FullTimeEmp : Employee 
    {
        public decimal FixedSalary { get; set; }

        public FullTimeEmp(string name , decimal fixedSalary) : base(name)
        { 
            if (fixedSalary <0)
                throw new ArgumentNullException("Enter Number ");
            FixedSalary = fixedSalary; 
        }

        public override decimal GetSalary()
        {
            return FixedSalary;
        }
    }
    public class PartTimeEmp : Employee
    {
        public decimal HourlyWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmp(string name, decimal hourlyRate , decimal horlyWorked) : base(name)
        {
            if (hourlyRate < 0)
                throw new ArgumentNullException("Enter Poisitve Number ");
            if (horlyWorked < 0)
                throw new ArgumentNullException("Enter Poisitve Number ");
            HourlyWorked = horlyWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal GetSalary()
        {
            return HourlyWorked * HourlyRate;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmp fullTimeEmployee = new FullTimeEmp("Anas", 5000);
            PartTimeEmp partTimeEmployee = new PartTimeEmp("Abdelwahab", 20, 120);

            Console.WriteLine($"Full-Time Salary: {fullTimeEmployee.GetSalary()}");
            Console.WriteLine($"Part-Time Salary: {partTimeEmployee.GetSalary()}");
        }
    }
}
