using System.Collections.Generic;
using System.Linq;

namespace Refactoring.MakingMethodCallsSimpler.IntroduceParameterObject.After
{
    public class Account
    {
        private readonly List<Entry> _entries = new List<Entry>();

        public double GetFlowBetween(DateRange range)
        {
            return _entries
                .Where(entry => range.Includes(entry.GetDate()))
                .Sum(entry => entry.GetValue());
        }
    }
}
