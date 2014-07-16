namespace Refactoring.MovingFeatures.MoveField
{
    public class AccountAfter
    {
        private readonly AccountTypeAfter _type;

        public AccountAfter(AccountTypeAfter type, double interestRate)
        {
            _type = type;
        }

        public double InterestForAmountDays(double amount, int days)
        {
            return _type.InterestRate * amount * days / 365;
        }
    }

    public class AccountTypeAfter
    {
        public double InterestRate { get; set; }
    }
}
