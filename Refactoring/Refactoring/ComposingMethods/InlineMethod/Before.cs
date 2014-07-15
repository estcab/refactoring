namespace Refactoring.ComposingMethods.InlineMethod
{
    public class Before
    {
        private readonly decimal _numberOfLateDeliveries;

        public Before(decimal numberOfLateDeliveries)
        {
            _numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return (MoreThanFiveLateDeliveries()) ? 2 : 1;
        }

        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }

    }
}
