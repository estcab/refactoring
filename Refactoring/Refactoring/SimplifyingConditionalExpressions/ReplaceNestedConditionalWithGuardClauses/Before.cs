namespace Refactoring.SimplifyingConditionalExpressions.ReplaceNestedConditionalWithGuardClauses
{
    public class Before
    {
        private readonly bool _isDead;
        private readonly bool _isSeparated;
        private readonly bool _isRetired;
        private readonly double _capital;
        private readonly double _duration;
        private readonly double _intRate;
        private readonly double _income;
        private const double AdjFactor = 0.92;

        public Before(bool isDead, bool isSeparated, bool isRetired, double capital, double duration, double intRate, double income)
        {
            _isDead = isDead;
            _isSeparated = isSeparated;
            _isRetired = isRetired;
            _capital = capital;
            _duration = duration;
            _intRate = intRate;
            _income = income;
        }

        public double GetPayAmount()
        {
            double result;
            if (_isDead) result = DeadAmount();
            else
            {
                if (_isSeparated) result = SeparatedAmount();
                else
                {
                    if (_isRetired) result = RetiredAmount();
                    else result = NormalPayAmount();
                };
            }
            return result;
        }


        public double GetAdjustedCapital()
        {
            double result = 0.0;
            if (_capital > 0.0)
            {
                if (_intRate > 0.0 && _duration > 0.0)
                {
                    result = (_income / _duration) * AdjFactor;
                }
            }
            return result;
        }


        private double NormalPayAmount()
        {
            throw new System.NotImplementedException();
        }

        private double RetiredAmount()
        {
            throw new System.NotImplementedException();
        }

        private double SeparatedAmount()
        {
            throw new System.NotImplementedException();
        }

        private double DeadAmount()
        {
            throw new System.NotImplementedException();
        }

    }
}
