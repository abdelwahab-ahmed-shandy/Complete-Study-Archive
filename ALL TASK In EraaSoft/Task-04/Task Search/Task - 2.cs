/*
2. Write a C# program to create a method that takes a string as input and throws an exception if the string does not contain vowels.
(A, E, I, O, U) contain vowels
*/
namespace Any_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String :");
            string Input = Console.ReadLine().ToUpper();

            foreach (char Charcter in Input)
            {
                if (Charcter == 'A' || Charcter == 'E' || Charcter == 'I' || Charcter == 'O' || Charcter == 'U')
                    throw new Exception("Not Can Add Any Charachter of (A, E, I, O, U)");
            }
            Console.WriteLine($"The String Not Use Any char (A, E, I, O, U) : {Input}");
        }
    }
}