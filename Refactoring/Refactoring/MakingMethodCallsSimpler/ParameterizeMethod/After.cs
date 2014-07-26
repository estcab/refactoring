using System;

namespace Refactoring.MakingMethodCallsSimpler.ParameterizeMethod
{
    public class After
    {
        private double _salary;

        public void Raise(double factor)
        {
            _salary *= (1 + factor);
        }

        protected Dollars BaseCharge()
        {
            double result = UsageInRange(0, 100) * 0.03;
            result += UsageInRange(100, 200) * 0.05;
            result += UsageInRange(200, Int32.MaxValue) * 0.07;
            return new Dollars(result);
        }

        protected int UsageInRange(int start, int end)
        {
            if (LastUsage() > start)
            {
                return Math.Min(LastUsage(), end) - start;
            }

            return 0;
        }

        private int LastUsage()
        {
            throw new NotImplementedException();
        }
    }
}
