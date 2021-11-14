using System;

namespace Activity5._2._3
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public void MonthEnd()
        {
            Value += Value * InterestRate;
        }
    }
}