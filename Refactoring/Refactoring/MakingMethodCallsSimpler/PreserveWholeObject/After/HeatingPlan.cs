namespace Refactoring.MakingMethodCallsSimpler.PreserveWholeObject.After
{
    public class HeatingPlan
    {
        private readonly TempRange _range;

        public HeatingPlan(TempRange range)
        {
            _range = range;
        }

        public bool WithinRange(TempRange roomRange)
        {
            return _range.Includes(roomRange);
        }
    }
}