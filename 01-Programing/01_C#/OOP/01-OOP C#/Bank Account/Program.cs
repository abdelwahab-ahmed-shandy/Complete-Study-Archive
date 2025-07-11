/*
Bank Account

Required:
Create a class named BankAccount.

The class contains:
AccountNumber.
Balance.
OwnerName.

Provide functions to:
Add money to the account (Deposit).
Withdraw money from the account (Withdraw) provided that the withdrawal is not greater than the balance.
Display account information.
Make the balance available only for external reading.
 */
namespace Bank_Account
{
    class BankAccount
    {
        private int accountNumber;
        private string ownerName ;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Error Enter the account number correctly");
                else
                    accountNumber = value;
            }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Error Enter Owner Name correctly");
                else
                    ownerName = value;
            }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit (double value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Error: Deposit amount must be positive");
            balance = balance + value;
        }

        public void Withdraw(double value)
        {
            if (value > balance)
                throw new ArgumentOutOfRangeException("Error: Withdrawal is greater than the balance");
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Error: Withdrawal amount must be positive");
            balance = balance - value;
        }
        public void PrintInfoAccont()
        {
            Console.WriteLine("\n\t(The Account Info)");
            Console.WriteLine($"Accont Number : {AccountNumber}");
            Console.WriteLine($"Owner Name : {OwnerName}");
            Console.WriteLine($"Balance : {Balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bankAccount = new BankAccount();

                bankAccount.AccountNumber = 1572002;
                bankAccount.OwnerName = "Abdelwahab Ahmed Shandy";
                bankAccount.Deposit(10000);

                bankAccount.PrintInfoAccont();

                bankAccount.Withdraw(2000);

                bankAccount.PrintInfoAccont();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }


        }
    }
}
