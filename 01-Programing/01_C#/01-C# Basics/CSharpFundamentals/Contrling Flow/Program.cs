namespace Contrling_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number : ");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 1)
            {
                Console.WriteLine($"{Number} Is ODD");
            }
            else if (Number == 0 )
            {
                Console.WriteLine("Zero is Neither ODD or EVEN.");
            }

            else
            {
                Console.WriteLine($"{Number} Is EVEN");
            }
        }
    }
}
