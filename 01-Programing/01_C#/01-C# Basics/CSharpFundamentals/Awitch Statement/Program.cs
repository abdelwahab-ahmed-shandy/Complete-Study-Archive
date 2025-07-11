// Switch 
namespace Awitch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number  : ");
            int Num = int.Parse(Console.ReadLine());

            switch (Num) 
            {
                case 1:
                    Console.WriteLine("Add");
                    break;
                case 2:
                    Console.WriteLine("22222222222");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }
}
