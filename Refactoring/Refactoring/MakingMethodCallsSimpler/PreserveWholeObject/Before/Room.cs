namespace Refactoring.MakingMethodCallsSimpler.PreserveWholeObject.Before
{
    public class Room
    {
        public bool WithinPlan(HeatingPlan plan)
        {
            int low = DaysTempRange().GetLow();
            int high = DaysTempRange().GetHigh();

            return plan.WithinRange(low, high);
        }

        private TempRange DaysTempRange()
        {
            return new TempRange();
        }
    }
}
