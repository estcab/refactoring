using System;

namespace Refactoring.ComposingMethods.IntroduceExplainingVariable
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
            decimal basePrice = _quantity * _itemPrice;
            decimal quantityDiscount = Math.Max(0M, _quantity - 500M) * _itemPrice * 0.05M;
            decimal shipping = Math.Min(basePrice * 0.1M, 100.0M);

            return basePrice - quantityDiscount + shipping;
        }

        #region WithExtractMethod
        public decimal GetPriceWithExtractMethod()
        {            
            return GetBasePrice() - GetQuantityDiscount() + GetShipping();
        }

        private decimal GetQuantityDiscount()
        {
            return Math.Max(0M, _quantity - 500M) * _itemPrice * 0.05M;
        }

        private decimal GetShipping()
        {
            return Math.Min(GetBasePrice() * 0.1M, 100.0M);
        }

        private decimal GetBasePrice()
        {
            return _quantity * _itemPrice;
        }
        #endregion
    }
}
