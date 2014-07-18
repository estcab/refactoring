using System;

namespace Refactoring.OrganizingData.SelfEncapsulateField
{
    public class CappedRangeAfter : IntRangeAfter
    {
        private readonly int _cap;

        public CappedRangeAfter(int low, int high, int cap)
            : base(low, high)
        {
            _cap = cap;
        }

        public int GetCap()
        {
            return _cap;
        }

        public override int GetHigh()
        {
            return Math.Min(base.GetHigh(), GetCap());
        }
    }
}