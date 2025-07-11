namespace task_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Orginal String: "); // input >> Abdelwahab Ahmed
            string Orginal = Console.ReadLine();
            Console.Write("Enter Are you Want Replace ?");
            string OrginalValue = Console.ReadLine();
            Console.Write("Enter Are you Want New ?");
            string NewValue = Console.ReadLine();
            Console.WriteLine($"the old is {OrginalValue} , new is {NewValue}");
            Console.WriteLine(Orginal.Replace(OrginalValue, NewValue));

        }
    }
}
