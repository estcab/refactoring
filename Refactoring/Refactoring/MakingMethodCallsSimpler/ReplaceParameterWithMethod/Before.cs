namespace Refactoring.MakingMethodCallsSimpler.ReplaceParameterWithMethod
{
    public class Before
    {
        private readonly decimal _quantity;
        private readonly decimal _itemPrice;

        public Before(decimal quantity, decimal itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public decimal GetPrice()
        {
            var basePrice = _quantity * _itemPrice;

            int discountLevel;

            if (_quantity > 100)
            {
                discountLevel = 2;
            }
            else
            {
                discountLevel = 1;
            }

            var finalPrice = discountedPrice(basePrice, discountLevel);
            return finalPrice;
        }

        private decimal discountedPrice(decimal basePrice, decimal discountLevel)
        {
            if (discountLevel == 2)
            {
                return basePrice * 0.1M;
            }
            else
            {
                return basePrice * 0.05M;
            }

        }
    }
}
