using System;

namespace Refactoring.MakingMethodCallsSimpler.PreserveWholeObject.After
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

        public bool Includes(TempRange arg)
        {
            return arg.GetLow() >= this.GetLow() && arg.GetHigh() <= this.GetHigh();
        }

    }
}