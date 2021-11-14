using System;

namespace Activity5._2._3
{
    public class CheckingAccount : Account
    {
        public int TransactionLimit { get; set; }
        public int TransactionCount { get; private set; }
        public double TransactionFee { get; set; }
        public double AccountFee { get; set; }

        public override void Deposit(double amount)
        {
           //ToDo
        }

        public override void Withdraw(double amount)
        {
            //ToDo
        }

        private void UpdateTransectionCount()
        {
           //ToDo
        }

        public void MonthEnd()
        {
            //ToDo
        }
    }
}