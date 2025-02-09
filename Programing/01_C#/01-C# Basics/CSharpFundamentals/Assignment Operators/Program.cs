namespace Assignment_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num = 10;
            Console.WriteLine(Num);

            Num = Num + 5;
            Console.WriteLine(Num);

            Num += 5; //Num = Num + 5;
            Console.WriteLine(Num);

            Num -=5; // Num = Num - 5; 
            Console.WriteLine(Num);
            //========================================================
            Console.WriteLine("======================");
            // Increment & Decrement Operators

            int Num6 = 9;
            Console.WriteLine(++Num6); // Pre
            Console.WriteLine(Num6);   // Post

            int Num7 = 10;
            Console.WriteLine(Num7++); // Pre
            Console.WriteLine(Num7);   // Post

            Console.WriteLine("===============================");
            int Num9 = 5;
            Console.WriteLine(--Num9); // Pre
            Console.WriteLine(Num9);   // Post

            int Num0 = 10;
            Console.WriteLine(Num0--); // Pre
            Console.WriteLine(Num0);   // Post

        }
    }
}
