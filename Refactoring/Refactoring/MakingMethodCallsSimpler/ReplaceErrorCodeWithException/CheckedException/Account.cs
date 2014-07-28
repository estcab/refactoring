namespace Refactoring.MakingMethodCallsSimpler.ReplaceErrorCodeWithException.CheckedException
{
    public class Account
    {
        private int _balance;

        public void Withdraw(int amount)
        {
            if (amount > _balance) throw new BalanceException();

            _balance -= amount;
        }
    }
}
