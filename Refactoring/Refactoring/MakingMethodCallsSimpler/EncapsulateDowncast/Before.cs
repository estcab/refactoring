using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.MakingMethodCallsSimpler.EncapsulateDowncast
{
    public class Before
    {
        private readonly List<Reading> _readings;

        public Before(List<Reading> readings)
        {
            this._readings = readings;
        }

        public Object LastReading()
        {
            return _readings.Last();
        }

        public void Example()
        {
            Reading last = (Reading)LastReading();

            // ..
        }
    }
}
