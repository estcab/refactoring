namespace Refactoring.SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments
{
    public class After
    {
        private const double SpecialDiscount = 0.95;
        private const double Discount = 0.98;

        public double Example(double price)
        {
            var total = IsSpecialDeal() ? ApplySpecialDiscount(price) : ApplyDiscount(price);

            Send();
            return total;
        }

        private double ApplyDiscount(double price)
        {
            return price * Discount;
        }

        private double ApplySpecialDiscount(double price)
        {
            return price * SpecialDiscount;
        }

        private void Send()
        {
            throw new System.NotImplementedException();
        }

        private bool IsSpecialDeal()
        {
            throw new System.NotImplementedException();
        }
    }
}
