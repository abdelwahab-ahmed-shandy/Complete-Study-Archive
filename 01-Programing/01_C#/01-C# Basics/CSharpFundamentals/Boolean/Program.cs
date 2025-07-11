namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = false;

            //Console.Write("IsAlive = " );
            //Console.WriteLine(isAlive);

            isAlive = true;
            //Console.Write("IsAlive = " );
            //Console.WriteLine(isAlive);
            
            // And == &&, & >> Speed and Preformas

            bool Bolean1 = true , Bolean2 = true;
            bool result1 = Bolean1 & Bolean2;
            //Console.WriteLine(result1);
            bool result2 = Bolean1 && Bolean2;
            //Console.WriteLine(result2);

            // Or == || << |,|| >> Speed and Preformas
            bool Bolean3 = false, Bolean4 = false;
            bool result3 = Bolean3 | Bolean4;
            //Console.WriteLine(result3);
            bool result4 = Bolean3 || Bolean4;
            //Console.WriteLine(result4);

            // Not 
            // if a true >> fales
            bool _true = !true;
            //Console.WriteLine(_true);
            bool _false = !false;
            //Console.WriteLine(_false);

            // XOR = ^ 
            // true and true = false
            // false and false = false 

            // لو احد الاطرف عكس التاني بيجي
            bool xorbool1 = false, xorbool2 = true;
            bool res = xorbool1 ^ xorbool2;
            Console.WriteLine(res);
          


        }
    }
}
