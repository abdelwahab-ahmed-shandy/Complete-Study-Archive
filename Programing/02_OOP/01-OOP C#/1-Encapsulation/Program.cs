// HR System 
namespace _1_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employes = new Employes();
            employes.FName = "Abdelwahab";
            employes.LName = "Shandy";
            employes.BirthDate = new DateOnly (2002,7,15);
            employes.BasicSalary = -5000;
            employes.TexPercentage = 140;

        }
    }
} 
