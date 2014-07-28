namespace Refactoring.MakingMethodCallsSimpler.ReplaceErrorCodeWithException.CheckedException
{
    public class Client
    {
        private readonly Account _account;

        public Client(Account account)
        {
            this._account = account;
        }

        public void Example(int amount)
        {
            try
            {
                _account.Withdraw(amount);
                DoTheUsualThing();
            }
            catch (BalanceException exception)
            {
                HandleOverdrawn();
            }
        }

        private void DoTheUsualThing()
        {
            throw new NotImplementedException();
        }

        private void HandleOverdrawn()
        {
            throw new NotImplementedException();
        }
    }
}