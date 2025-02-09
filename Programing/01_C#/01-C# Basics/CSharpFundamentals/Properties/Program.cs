namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students Abdo = new Students("Abdelwahab");
            //Abdo.Name = "Abdelwahab";
            Console.WriteLine(Abdo.Name);

            //Abdo.SetName("Abdo");
            //Console.WriteLine(Abdo.GetName());

        }
    }
}
