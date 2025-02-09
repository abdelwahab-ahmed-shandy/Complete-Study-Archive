namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine($"The Number {i} is EVEN");
            //    else
            //        Console.WriteLine($"The NUmber {i} is ODD");
            //}

            //

            for (int i = 1; i <= 10; i++)
            {
                string Statement = (i % 2 == 0 ? $"The Number {i} is EVEN" : $"The Number {i} is ODD");
                Console.WriteLine(Statement);
            }


        }
    }
}
