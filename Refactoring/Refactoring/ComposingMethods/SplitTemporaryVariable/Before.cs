using System;

namespace Refactoring.ComposingMethods.SplitTemporaryVariable
{
    public class Before
    {
        private readonly double _primaryForce;
        private readonly double _secondaryForce;
        private readonly double _mass;
        private readonly int _delay;
        
        public Before(double primaryForce, double mass, int delay, double secondaryForce)
        {
            _primaryForce = primaryForce;
            _mass = mass;
            _delay = delay;
            _secondaryForce = secondaryForce;
        }

        double GetDistanceTravelled(int time)
        {
            double result;

            // a temporary variable assigned to more than once
            double acc = _primaryForce / _mass;
            int primaryTime = Math.Min(time, _delay);
            result = 0.5 * acc * primaryTime * primaryTime;
            int secondaryTime = time - _delay;
            if (secondaryTime > 0)
            {
                double primaryVel = acc * _delay;
                // a temporary variable assigned to more than once
                acc = (_primaryForce + _secondaryForce) / _mass;
                result += primaryVel * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
            }

            return result;
        }
    }
}
