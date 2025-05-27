/*
1. Write a C# program that reads a list of integers from the user and throws an exception if there are any duplicate numbers. 
 */
namespace Any_task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>();

			Console.WriteLine("Enter numbers separated by spaces:");
			string input = Console.ReadLine();
			string[] inputNumbers = input.Split(' ');

			try
			{
				foreach (string number in inputNumbers)
				{
					int HowNum = int.Parse(number);
					if (numbers.Contains(HowNum))
					{
						throw new Exception($"The {number} of Duplicate");
					}
					numbers.Add(HowNum);
				}
				Console.WriteLine("All numbers No Duplication");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{ex.ToString()}");
			}
		}
	}
}