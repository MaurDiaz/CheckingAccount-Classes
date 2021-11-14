using System;

namespace Activity5._2._3
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Value { get; protected set; } = 0.0;
        public virtual void Deposit(double amount)
        {
            Value += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Value -= amount;
        }
    }
}