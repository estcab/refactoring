namespace Refactoring.OrganizingData.SelfEncapsulateField
{
    public class IntRangeAfter
    {
        private int _low;
        private int _high;

        public IntRangeAfter(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public void SetLow(int value)
        {
            _low = value;
        }

        public int GetLow()
        {
            return _low;
        }

        public void SetHigh(int value)
        {
            _high = value;
        }

        public virtual int GetHigh()
        {
            return _high;
        }

        public bool Includes(int arg)
        {
            return arg >= GetLow() && arg <= GetHigh();
        }

        public void Grow(int factor)
        {
            SetHigh(GetHigh() * factor);
        }

    }
}
