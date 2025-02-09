namespace Charachter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ASCII >> American Standard Code Information Interchage
            // 1 >> 49 , 9 >> 57  ||   A >> 65 , Z >> 90  ||  a >> 97 , z >> 122

            char c = 'A';
            Console.WriteLine(c); 
            Console.WriteLine((int) c);

            bool isDigit;
            isDigit = char.IsDigit(c);
            Console.WriteLine(isDigit);

        }
    }
}
