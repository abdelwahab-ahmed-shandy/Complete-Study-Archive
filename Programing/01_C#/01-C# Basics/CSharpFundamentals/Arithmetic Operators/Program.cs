namespace Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 25;
            double Num2 = 10;
            var n = Num1 + Num2;// you can var chosse Data Type your seylf

            Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
            Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
            Console.WriteLine($"{Num1} * {Num2} = {Num1 * Num2}");
            Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
            Console.WriteLine($"{Num1} % {Num2} = {Num1 % Num2}");

            // Operator Precdence
            Console.WriteLine("=================================");
            Console.WriteLine($"5 + 3 * 2 = {5 + 3 * 2}");
            Console.WriteLine($"5 + 50 / 2 = {5 + 50 / 2}");
            Console.WriteLine("=================================");
            Console.WriteLine($"5 * 10 / 2 = {5 * 10 / 2}");
            Console.WriteLine($"50 / 10 * 2 = {50 / 10 * 2}");
            Console.WriteLine("=================================");
            Console.WriteLine($"(5 + 3) * 2 = {(5 + 3) * 2}");
            Console.WriteLine($"(50 + 50) / 2 = {(50 + 50) / 2}");

        }
    }
}
