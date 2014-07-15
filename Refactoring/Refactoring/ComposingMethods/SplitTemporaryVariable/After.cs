using System;

namespace Refactoring.ComposingMethods.SplitTemporaryVariable
{
    public class After
    {
        private readonly double _primaryForce;
        private readonly double _secondaryForce;
        private readonly double _mass;
        private readonly int _delay;

        public After(double primaryForce, double mass, int delay, double secondaryForce)
        {
            _primaryForce = primaryForce;
            _mass = mass;
            _delay = delay;
            _secondaryForce = secondaryForce;
        }

        double GetDistanceTravelled(int time)
        {
            double result;

            double primaryAcc = _primaryForce / _mass;
            
            int primaryTime = Math.Min(time, _delay);
            result = 0.5 * primaryAcc * primaryTime * primaryTime;
            int secondaryTime = time - _delay;
            if (secondaryTime > 0)
            {
                double primaryVel = primaryAcc * _delay;
                
                double secondaryAcc = (_primaryForce + _secondaryForce) / _mass;
                result += primaryVel * secondaryTime + 0.5 * secondaryAcc * secondaryTime * secondaryTime;
            }

            return result;
        }
    }
}
