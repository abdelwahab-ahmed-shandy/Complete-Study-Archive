namespace Parse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Birth Year : ");
            int Year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your age until 2024 = {2024 - Year }");

        }
    }
}