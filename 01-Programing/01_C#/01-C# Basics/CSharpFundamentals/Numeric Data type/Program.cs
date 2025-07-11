namespace Numeric_Data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Memory Size      Min Value       Max Value

            Console.WriteLine($"Int Memory Size : {sizeof(int)}");
            Console.WriteLine($"UInt Memory Size : {sizeof(uint)}");
            Console.WriteLine("=========================");
            Console.WriteLine($"Int Min Value : {int.MinValue}");
            Console.WriteLine($"UInt Min Value : {uint.MinValue}");
            Console.WriteLine("=========================");
            Console.WriteLine($"Int Max Value : {int.MaxValue}");
            Console.WriteLine($"UInt Max Value : {uint.MaxValue}");
            Console.WriteLine("=========================");

            float f = 5.5f;
            double d = 9.9;

            int int1 = 0;
            int int2 = 50;
            int int3 = -50;

            // u >> unsigned
            uint uint1 = 0;
            uint uint2 = 50;
           // uint uint3 = -50; // not using (-)


        }   
    }
}




