using System;

namespace Refactoring.ComposingMethods.IntroduceExplainingVariable
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
            // price is base price - quantity discount + shipping
            return _quantity * _itemPrice -
                Math.Max(0M, _quantity - 500M) * _itemPrice * 0.05M +
                Math.Min(_quantity * _itemPrice * 0.1M, 100.0M);
        }

    }
}
