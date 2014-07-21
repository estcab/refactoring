namespace Refactoring.SimplifyingConditionalExpressions.ConsolidateConditionalExpression
{
    public class After
    {
        private readonly decimal _seniority;
        private readonly decimal _monthsDisabled;
        private readonly bool _isPartTime;

        public After(decimal seniority, decimal monthsDisabled, bool isPartTime)
        {
            _seniority = seniority;
            _monthsDisabled = monthsDisabled;
            _isPartTime = isPartTime;
        }

        public double DisabilityAmount()
        {
            if (IsNotEligibleForDisability()) return 0;

            // compute the disability amount
            // ...
            return 1;
        }

        private bool IsNotEligibleForDisability()
        {
            return (_seniority < 2) || (_monthsDisabled > 12) || (_isPartTime);
        }

        public double OtherExample()
        {
            return OnVacation() && (LengthOfService() > 10) ? 1 : 0.5;
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
