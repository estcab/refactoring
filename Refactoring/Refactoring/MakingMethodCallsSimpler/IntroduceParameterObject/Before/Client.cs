using System;

namespace Refactoring.MakingMethodCallsSimpler.IntroduceParameterObject.Before
{
    public class Client
    {
        private readonly Account _account;

        public Client(Account account)
        {
            _account = account;
        }

        public void Example(DateTime startDate, DateTime endDate)
        {
            double flow = _account.GetFlowBetween(startDate, endDate);

            // ...
        }
    }
}
