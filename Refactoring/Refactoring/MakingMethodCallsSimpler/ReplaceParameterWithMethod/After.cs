namespace Refactoring.MakingMethodCallsSimpler.ReplaceParameterWithMethod
{
    public class After
    {
        private readonly decimal _quantity;
        private readonly decimal _itemPrice;

        public After(decimal quantity, decimal itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public decimal GetPrice()
        {
            return DiscountLevel == 2 ? BasePrice * 0.1M : BasePrice * 0.05M;
        }

        private decimal BasePrice
        {
            get { return _quantity * _itemPrice; }
        }

        private int DiscountLevel
        {
            get { return _quantity > 100 ? 2 : 1; }
        }
    }
}
