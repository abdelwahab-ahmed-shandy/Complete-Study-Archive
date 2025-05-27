/*
 // Inheritance & operator overloading

You are provided with a simple Account class

An Account has a name and a balance.

I have also provided some Account helper functions in AccountUtil
that make it easy to display, deposit to, and withdraw from a list of Accounts.

Your task is the following:

1. Add a Savings Account class to the Account hierarchy and adds an interest rata.

2. Add a Checking account class to the Account hierarchy
    A Checking account has a name and a balance and has a fee of $1.50 per withdrawal transaction.
    Every withdrawal transaction will be assessed this flat fee.

3. Add a Trust account class to the Account hierarchy
    A Trust account has a name, a balance, and an interest rate
    The Trust account deposit works just like a savings account deposit.
    However, any deposits of $5000.00 or more will receive a $50.00 bonus deposited to the account.
   
    The Trust account withdrawal should only allow 3 withdrawals per year and each of these must be less than 20% of the account balance.
    
4. Overload + operator in Account class (to sum the balances of two objects you will be create in Main)


Hints: 
    Reuse existing functionality!!
    override to string always!
 */
using System.Xml.Linq;

namespace Task_4
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string Name = "Unnamed Account", double Balance = 0.0)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name Is {Name} , Balance {Balance}";
        }

        public static Account operator +(Account a, Account b)
        {
            return new Account(a.Name, a.Balance + b.Balance);
        }
    }
    public static class AccountUtil
    {
        // Utility helper functions for Account class

        public static void Display(List<Account> accounts)
        {
            Console.WriteLine("\n=== Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
    public class SavingsAccount : Account
    {
        public double InterstRate { get; set; }

        public SavingsAccount(string name = "null", double balance = 0.0, double interstRate = 0.0) : base(name, balance)
        {
            if (interstRate < 0)
                throw new Exception("Can Not Be Less Than Zero");
            InterstRate = interstRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Interest Rate: {InterstRate}";
        }
    }
    public class CheckingAccount : SavingsAccount
    {
        const double Fee = 1.50;
        public CheckingAccount(string name = "Null", double balance = 0) : base(name, balance)
        {
            balance = balance - Fee;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Balance after fees : {Balance - Fee}";
        }
    }
    public class TrustAccount : SavingsAccount
    {
        private int Count { get; set; }
        private DateTime OverTime { get; set; }

        public TrustAccount(string name = "null", double balance = 0, double interstRate = 0) : base(name, balance)
        {

        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                Console.WriteLine($"Add Bouns {base.Deposit(50)} Account is {Name}");

            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            if (DateTime.Now.Year != OverTime.Year && DateTime.Now.Month == OverTime.Month
                && DateTime.Now.Day == OverTime.Day)
            {
                OverTime = DateTime.Now;
                Count = 3;
                return base.Withdraw(amount);
            }
            if (Count <= 3 && Count >= 0 && amount <= (0.2 * Balance))
            {
                Count--;
                return base.Withdraw(amount);
            }
            return false;
        }
        public override string ToString()
        {
            return $"Trusted Account : {base.ToString()} Rate is {InterstRate}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            Console.WriteLine("Accounts :");
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            Console.WriteLine("Saving Accounts :");
            var savAccounts = new List<Account>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 20000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 50000, 5.0));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            Console.WriteLine("Chascking Accounts :");
            var checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            Console.WriteLine("Trust Accounts :");
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustAccounts);
            Console.WriteLine("Add 5000 Bouns 50 :");
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);

            Console.WriteLine("\nCheck 3 Widthrawal :");
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            //operating overloading
            Account acc1 = new Account();
            Account acc2 = new Account();
            Console.WriteLine(acc1 + acc2);

            Console.WriteLine();
        }
    }
}
