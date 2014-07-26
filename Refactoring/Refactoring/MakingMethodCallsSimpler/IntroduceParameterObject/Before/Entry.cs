using System;

namespace Refactoring.MakingMethodCallsSimpler.IntroduceParameterObject.Before
{
    public class Entry
    {
        private readonly DateTime _chargeDate;
        private readonly double _value;

        public Entry(double value, DateTime chargeDate)
        {
            _value = value;
            _chargeDate = chargeDate;
        }

        public DateTime GetDate()
        {
            return _chargeDate;
        }

        public double GetValue()
        {
            return _value;
        }
    }
}
