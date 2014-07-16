namespace Refactoring.MovingFeatures.MoveMethod
{
    public class AccountTypeAfter
    {
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium())
            {
                double result = 10;
                if (daysOverdrawn > 7)
                {
                    result += (daysOverdrawn - 7) * 0.85;
                }
                return result;
            }

            return daysOverdrawn * 1.75;
        }

        public bool IsPremium()
        {
            return true;
        }
    }
}