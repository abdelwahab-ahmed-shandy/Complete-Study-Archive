using System.Security.Cryptography.X509Certificates;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \nWorld!");
            Console.WriteLine("Hello, \tWorld!");
            Console.WriteLine("Hello, \\tWorld!");// out >> Hello, \tWorld! 

            // concatenation 
            string hello = "hello";
            string worled = "worled";
            Console.WriteLine(hello + worled);

            // @ >> using full string and multy line 
            Console.WriteLine(@"Hello, \nWorld!");
            Console.WriteLine(@"Hello, \nWorld!
the new line 
C# Betoo");

            //String Templte
            string firstName = "Abdelwahab";
            string lastName = "Shandy";
            string fullName = $"{firstName} {lastName}";

            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine(fullName);


            //String interpolation 
            Console.Write("Please Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($" {name.StartsWith("A")}");
            Console.WriteLine($" {name.StartsWith("a")}");
            Console.WriteLine($" {name.StartsWith("A" , StringComparison.OrdinalIgnoreCase)}");
            
            Console.WriteLine($" {name.EndsWith("A")}");
            Console.WriteLine($" {name.EndsWith("A" , StringComparison.OrdinalIgnoreCase)}");

            Console.WriteLine($" {name.Contains("A")}");
            Console.WriteLine($" {name.Contains("A" , StringComparison.OrdinalIgnoreCase)}");

            Console.WriteLine($" {name.IndexOf("a")}");
            Console.WriteLine($" {name.IndexOf("A" , StringComparison.OrdinalIgnoreCase)}");
            
            Console.WriteLine($" {name.IndexOf("O")}");
            Console.WriteLine($" {name.LastIndexOf("O", StringComparison.OrdinalIgnoreCase)}");



            //Console.WriteLine($"Welcome {name}");
            //Console.WriteLine($"Lengh {name.Length}");
            //Console.WriteLine($"Upper Case {name.ToUpper()}");

        }
    }
}
