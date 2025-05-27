/*
    Islam's Carpet Cleaning Service
    Charges:
        $25 per small
        $35 per large
    Sales tax rate is 6%
    Estimates are valid for 30 days

    Prompt the user for the number of small and large rooms they would like cleaned
    and provide an estimate such as:

Estimate for carpet cleaning service
Number of small carpets: 3 <--
Number of large carpets: 1 <--
Price per small room: $25
Price per large room: $35
Cost : $110
Tax: $6.6
===============================
Total estimate: $116.6
This estimate is valid for 30 days
*/

//Start....


using System.Runtime.ConstrainedExecution;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate For Carpet Cleaning Service");
            Console.Write("How Many Small Carpets : ");
            int SmallCarpet = int.Parse(Console.ReadLine());
            
            Console.Write("How Many Large Carpets : ");
            int LargeCarpet = int.Parse(Console.ReadLine());

            const int PriceSmallCarpets = 25;
            const int PriceLargeCarpets = 35;
            const float Tax = 6.6f;
            Console.WriteLine("Price Per Small Room : $25 ");
            Console.WriteLine("Price Per Large Room : $35 ");

            int TotalCost = (SmallCarpet * PriceSmallCarpets) + (LargeCarpet * PriceLargeCarpets);
            Console.WriteLine($"Cost : {TotalCost:C}");
            Console.WriteLine($"Tax : {Tax:C}");
            Console.WriteLine("=================================================================");
            Console.WriteLine($"Total Estimate : {TotalCost + Tax :C}");
            Console.WriteLine("This Estimate Is Valid For 30 Days");
        }
    }
}
