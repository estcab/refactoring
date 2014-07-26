using System;

namespace Refactoring.MakingMethodCallsSimpler.PreserveWholeObject.Before
{
    public class TempRange
    {
        public int GetLow()
        {
            return Int32.MinValue;
        }

        public int GetHigh()
        {
            return Int32.MaxValue;
        }
    }
}