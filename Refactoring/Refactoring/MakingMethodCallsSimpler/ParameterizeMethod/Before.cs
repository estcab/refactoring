using System;

namespace Refactoring.MakingMethodCallsSimpler.ParameterizeMethod
{
    public class Before
    {
        private double _salary;

        public void TenPercentRaise()
        {
            _salary *= 1.1;
        }

        public void FivePercentRaise()
        {
            _salary *= 1.05;
        }


        protected Dollars BaseCharge()
        {
            double result = Math.Min(LastUsage(), 100) * 0.03;
            if (LastUsage() > 100)
            {
                result += (Math.Min(LastUsage(), 200) - 100) * 0.05;
            };
            if (LastUsage() > 200)
            {
                result += (LastUsage() - 200) * 0.07;
            };
            return new Dollars(result);
        }

        private double LastUsage()
        {
            throw new NotImplementedException();
        }
    }
}
