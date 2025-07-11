namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vidoes = { 1,2,3,4, 5, 6, 7, 8, 9, 10 };
            int[] vidoes2 = new int[7] ;

            Array.Copy(vidoes, vidoes2, vidoes2.Length );
            Console.WriteLine(vidoes2[3]);

            vidoes[3] = 90;
            Console.WriteLine(vidoes[3]);

            //Console.WriteLine(vidoes[3]);
            //Array.Sort(vidoes);
            // Console.WriteLine(vidoes[3]);
        }
    }
}
