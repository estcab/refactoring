namespace Refactoring.ComposingMethods.InlineMethod
{
    public class After
    {
        private readonly decimal _numberOfLateDeliveries;

        public After(decimal numberOfLateDeliveries)
        {
            _numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
