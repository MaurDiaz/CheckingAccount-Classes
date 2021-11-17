using System;

namespace Activity5._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var mySavingsAccount = new SavingsAccount { ID = 5, Name = "My Savings Account", InterestRate = 0.01 };
            mySavingsAccount.Deposit(100.0);
            mySavingsAccount.Withdraw(20.0);
            Console.WriteLine("Current Balance after all transections (Savings Account): "+mySavingsAccount.Value);
            mySavingsAccount.MonthEnd();
            Console.WriteLine("Balance after month end (Savings Account): " + mySavingsAccount.Value);
            */
            var myCheckingAccount = new CheckingAccount {ID = 7, Name = "My Checking Account", TransactionLimit = 2, TransactionFee = 1.5, AccountFee = 5.0};
            myCheckingAccount.Deposit(100.0);
            myCheckingAccount.Withdraw(10.0);
            myCheckingAccount.Withdraw(10.0);
            myCheckingAccount.Withdraw(10.0);
            myCheckingAccount.Deposit(100.0);
            myCheckingAccount.Withdraw(20.0);
            Console.WriteLine("Current Balance after all transections (Checking Account): " + myCheckingAccount.Value);
            myCheckingAccount.MonthEnd();
            Console.WriteLine("Balance after month end (Checking Account):" + myCheckingAccount.Value);



            Console.ReadKey();
        }
    }
}
