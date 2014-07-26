using System;
using System.Collections.Generic;

namespace Refactoring.MakingMethodCallsSimpler.IntroduceParameterObject.Before
{
    public class Account
    {
        private readonly List<Entry> _entries = new List<Entry>();

        public double GetFlowBetween(DateTime start, DateTime end)
        {
            double result = 0;

            foreach (var entry in _entries)
            {
                if (entry.GetDate().Equals(start) || entry.GetDate().Equals(end) ||
                     (entry.GetDate().CompareTo(start) > 0 && entry.GetDate().CompareTo(end) < 0))
                {
                    result += entry.GetValue();
                }
            }

            return result;
        }
    }
}
