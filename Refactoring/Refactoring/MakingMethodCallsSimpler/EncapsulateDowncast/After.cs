using System.Collections.Generic;
using System.Linq;

namespace Refactoring.MakingMethodCallsSimpler.EncapsulateDowncast
{
    public class After
    {
        private readonly List<Reading> _readings;

        public After(List<Reading> readings)
        {
            this._readings = readings;
        }

        public Reading LastReading()
        {
            return _readings.Last();
        }

        public void Example()
        {
            var last = LastReading();

            // ..
        }
    }
}
