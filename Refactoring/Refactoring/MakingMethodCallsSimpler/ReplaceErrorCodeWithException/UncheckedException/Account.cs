using System;

namespace Refactoring.MakingMethodCallsSimpler.ReplaceErrorCodeWithException.UncheckedException
{
    public class Account
    {
        private int _balance;

        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentException("Amount too large");
            }

            _balance -= amount;
        }

        public bool CanWithdraw(int amount)
        {
            return (amount <= _balance);
        }
    }
}
