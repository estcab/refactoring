namespace Refactoring.DealingWithGeneralization.ExtractSubclass.After
{
    public class PartItem : JobItem
    {
        private readonly int _unitPrice;

        public PartItem(int unitPrice, int quantity)
            : base(quantity)
        {
            _unitPrice = unitPrice;
        }

        public override int GetUnitPrice()
        {
            return _unitPrice;
        }
    }
}