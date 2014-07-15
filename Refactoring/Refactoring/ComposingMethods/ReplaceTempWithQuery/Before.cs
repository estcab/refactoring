namespace Refactoring.ComposingMethods.ReplaceTempWithQuery
{
    public class Before
    {
        private readonly decimal _quantity;
        private readonly decimal _itemPrice;

        public Before(decimal itemPrice, decimal quantity)
        {
            _itemPrice = itemPrice;
            _quantity = quantity;
        }

        public decimal GetPrice()
        {
            decimal basePrice = _quantity * _itemPrice;
            decimal discountFactor;

            if (basePrice > 1000)
            {
                discountFactor = 0.95M;
            }            
            else
            {
                discountFactor = 0.98M;
            }

            return basePrice * discountFactor;
        }

    }
}
