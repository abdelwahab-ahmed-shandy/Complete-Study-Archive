/*
 
 */
using System.Drawing;

namespace Enums
{
    internal class Program
    {
        public enum Gender
        {
            Male,
            Female
        }
        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Brown
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Selsect An Option : ");
            Console.WriteLine("[1] Change Backgrond Color \t\t [2] Change Forground Color");
            string selecttedOption = Console.ReadLine();
            foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                {
                Console.WriteLine($"{color}");
                }
           
            Console.WriteLine("Enter Color Name : ");
            string ColorName = Console.ReadLine();

            ConsoleColor selecttedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorName , true);
            if (selecttedOption == "1")
                Console.WriteLine(selecttedColor);
            else if (selecttedOption == "2")
                Console.WriteLine(selecttedColor);
            else if (selecttedOption == "3")
                Console.WriteLine(selecttedColor);
            else if (selecttedOption == "4")
                Console.WriteLine(selecttedColor);
            else if (selecttedOption == "5")
                Console.WriteLine(selecttedColor);
            else 
                Console.WriteLine("Inviled Option !");
        }
    }
}
