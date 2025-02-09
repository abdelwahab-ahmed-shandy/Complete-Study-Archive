namespace Comparison_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"x == 10 ? {x == 10}"); //True 
            Console.WriteLine($"x == 20 ? {x == 20}"); //False

            Console.WriteLine($"x != 10 ? {x != 10}"); //False 
            Console.WriteLine($"x != 20 ? {x != 20}"); //True

            Console.WriteLine($"x > 9 ? {x > 9}");   //True 
            Console.WriteLine($"x > 10 ? {x > 10}"); //False

            Console.WriteLine($"x < 11 ? {x < 11}");//True 
            Console.WriteLine($"x < 9 ? {x < 9}"); //False

            Console.WriteLine($"x >= 10 ? {x >= 10}"); //True 
            Console.WriteLine($"x >= 20 ? {x >= 20}"); //False

            Console.WriteLine($"x <= 10 ? {x <= 10}"); //True 
            Console.WriteLine($"x <= 9 ? {x <= 9}"); //False
        }
    }
}
