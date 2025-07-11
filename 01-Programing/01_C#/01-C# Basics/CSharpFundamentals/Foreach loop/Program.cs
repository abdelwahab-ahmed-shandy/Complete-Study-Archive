namespace Foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// for loop 
            //char[] Numbers = { '1', '2', '3', '4', '5', '6', '7' };

            //for (int i = 0; i <= Numbers.Length; i++)
            //{
            //    Console.WriteLine($"{Numbers[i]} = {(int)Numbers[i]}");
            //}
            // Foreach 
            char[] Numbers = { '1', '2', '3', '4', '5', '6', '7' };
            foreach ( char Digit in Numbers)
            {
                Console.WriteLine($" {Digit} = {(int)Digit}");
            }

        }
    }
}
