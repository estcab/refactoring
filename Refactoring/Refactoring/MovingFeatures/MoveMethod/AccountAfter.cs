namespace Refactoring.MovingFeatures.MoveMethod
{
    public class AccountAfter
    {
        private readonly AccountTypeAfter _type;
        private readonly int _daysOverdrawn;

        public AccountAfter(AccountTypeAfter type, int daysOverdrawn)
        {
            _type = type;
            _daysOverdrawn = daysOverdrawn;
        }

        public double OverdraftCharge()
        {
            return _type.OverdraftCharge(_daysOverdrawn);
        }

        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0) result += OverdraftCharge();
            return result;
        }

    }
}
