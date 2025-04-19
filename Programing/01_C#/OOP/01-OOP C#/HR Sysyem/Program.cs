namespace HR_Sysyem;

internal class Program
{
    static void Main(string[] args)
    {
        var salaryEmploye = new SalaredEmployee();
        salaryEmploye.BasicSalary = 2000;
        salaryEmploye.Housing = 1000;
        salaryEmploye.Transportation = 500;
        Console.WriteLine($"Salary Of Salaried employee is {salaryEmploye.GetSalary():0.00} ");

        var hourlyEmp = new HourlyEmployee();
        hourlyEmp.HourRate = 100;
        hourlyEmp.TotalWorkHours = 60;
        Console.WriteLine($"Salary Of Hourly employee is {hourlyEmp.GetSalary():0.00} ");

        var internalEmp = new InternEmployee();
        Console.WriteLine($"Salary Of Internaly employee is {internalEmp.GetSalary():0.00} ");


    }
}
