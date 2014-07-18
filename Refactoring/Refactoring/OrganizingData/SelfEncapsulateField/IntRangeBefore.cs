namespace Refactoring.OrganizingData.SelfEncapsulateField
{
    public class IntRangeBefore
    {
        private int _low, _high;

        public IntRangeBefore(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public bool Includes(int arg)
        {
            return arg >= _low && arg <= _high;
        }

        public void Grow(int factor)
        {
            _high = _high * factor;
        }

    }
}
