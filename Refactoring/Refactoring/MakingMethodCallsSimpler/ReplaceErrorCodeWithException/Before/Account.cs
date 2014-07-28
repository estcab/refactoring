namespace Refactoring.MakingMethodCallsSimpler.ReplaceErrorCodeWithException.Before
{
    public class Account
    {
        private int _balance;

        public int Withdraw(int amount)
        {
            if (amount > _balance)
            {
                return -1;
            }

            _balance -= amount;
            return 0;
        }
    }
}
