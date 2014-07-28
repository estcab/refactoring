using System;

namespace Refactoring.MakingMethodCallsSimpler.ReplaceErrorCodeWithException.UncheckedException
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
            if (!_account.CanWithdraw(amount))
            {
                HandleOverdrawn();
            }
            else
            {
                _account.Withdraw(amount);
                DoTheUsualThing();
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