namespace Refactoring.ComposingMethods.ReplaceTempWithQuery
{
    public class After
    {
        private readonly decimal _quantity;
        private readonly decimal _itemPrice;

        public After(decimal itemPrice, decimal quantity)
        {
            _itemPrice = itemPrice;
            _quantity = quantity;
        }

        public decimal GetPrice()
        {
            return GetBasePrice() * GetDiscountFactor();
        }

        private decimal GetDiscountFactor()
        {
            return GetBasePrice() > 1000 ? 0.95M : 0.98M;
        }

        private decimal GetBasePrice()
        {
            return _quantity * _itemPrice;
        }
    }
}
