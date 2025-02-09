namespace A_Big_Task_Advaced
{ 
    public class ClsCalculator
    {
        
        public static bool AreEqual<T>(T x ,  T y)
        {
            if (x.Equals(y))
            {
                return true;
            }

            return false;
        }
    }
    class Account
    {
        public Account(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public override bool Equals(Object obj )
        {
            if (obj == null || !(obj is Account))
                return false;
            else
                return this.Email == ((Account)obj).Email;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("test@yahoo.com", "123456");
            Account account2 = new Account("test@yahoo.com", "123456");
            bool IsEqual = ClsCalculator.AreEqual<Account>(account1, account2);

            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            //Console.ReadKey();


            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 10);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            //bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
        }
    }
}
