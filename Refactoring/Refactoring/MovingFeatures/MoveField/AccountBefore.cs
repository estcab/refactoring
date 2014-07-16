namespace Refactoring.MovingFeatures.MoveField
{
    public class AccountBefore
    {
        private AccountTypeBefore _type;
        private readonly double _interestRate;

        public AccountBefore(AccountTypeBefore type, double interestRate)
        {
            _type = type;
            _interestRate = interestRate;
        }

        public double InterestForAmountDays(double amount, int days)
        {
            return _interestRate * amount * days / 365;
        }

    }

    public class AccountTypeBefore
    {
    }
}
