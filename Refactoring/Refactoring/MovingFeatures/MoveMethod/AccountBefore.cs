namespace Refactoring.MovingFeatures.MoveMethod
{
    public class AccountBefore
    {
        private readonly AccountTypeBefore _type;
        private readonly int _daysOverdrawn;

        public AccountBefore(AccountTypeBefore type, int daysOverdrawn)
        {
            _type = type;
            _daysOverdrawn = daysOverdrawn;
        }

        double OverdraftCharge()
        {
            if (_type.IsPremium())
            {
                double result = 10;
                if (_daysOverdrawn > 7) result += (_daysOverdrawn - 7) * 0.85;
                return result;
            }
            
            return _daysOverdrawn * 1.75;
        }

        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0) result += OverdraftCharge();
            return result;
        }
       
    }
}
