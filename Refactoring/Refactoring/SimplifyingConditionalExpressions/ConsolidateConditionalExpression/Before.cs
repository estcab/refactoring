namespace Refactoring.SimplifyingConditionalExpressions.ConsolidateConditionalExpression
{
    public class Before
    {
        private readonly decimal _seniority;
        private readonly decimal _monthsDisabled;
        private readonly bool _isPartTime;

        public Before(decimal seniority, decimal monthsDisabled, bool isPartTime)
        {
            _seniority = seniority;
            _monthsDisabled = monthsDisabled;
            _isPartTime = isPartTime;
        }

        public double DisabilityAmount()
        {
            if (_seniority < 2) return 0;
            if (_monthsDisabled > 12) return 0;
            if (_isPartTime) return 0;

            // compute the disability amount
            // ...
            return 1;
        }

        public double OtherExample()
        {
            if (OnVacation())
                if (LengthOfService() > 10)
                    return 1;
            return 0.5;
        }

        private double LengthOfService()
        {
            return 3;
        }

        private bool OnVacation()
        {
            return true;
        }
    }
}
