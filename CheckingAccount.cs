using System;

namespace Activity5._2._3
{
    public class CheckingAccount : Account
    {
        public int TransactionLimit { get; set; }
        public int TransactionCount { get; private set; } = 0;
        public double TransactionFee { get; set; }
        public double AccountFee { get; set; }

        public override void Deposit(double amount)
        {
           this.Value += amount;
           this.TransactionCount++;
        }

        public override void Withdraw(double amount)
        {
            this.Value -= amount;
            this.TransactionCount++;
        }

        private void UpdateTransactionCount()
        {
           this.TransactionCount = 0;
        }

        public void MonthEnd()
        {
            this.Value -= this.AccountFee;
            if(this.TransactionCount > this.TransactionLimit)
            {
                this.Value -= this.TransactionFee;
            }
            this.UpdateTransactionCount();
        }
    }
}