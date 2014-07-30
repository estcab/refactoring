namespace Refactoring.DealingWithGeneralization.ExtractSubclass.After
{
    public abstract class JobItem
    {
        private readonly int _quantity;

        protected JobItem(int quantity)
        {
            _quantity = quantity;
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public int GetTotalPrice()
        {
            return GetUnitPrice() * _quantity;
        }

        public abstract int GetUnitPrice();
    }
}
