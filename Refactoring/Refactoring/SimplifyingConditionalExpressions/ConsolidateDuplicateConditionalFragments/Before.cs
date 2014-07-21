namespace Refactoring.SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments
{
    public class Before
    {
        public double Example(double price)
        {
            double total;

            if (IsSpecialDeal())
            {
                total = price * 0.95;
                Send();
            }
            else
            {
                total = price * 0.98;
                Send();
            }

            return total;
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
