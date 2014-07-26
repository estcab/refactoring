namespace Refactoring.MakingMethodCallsSimpler.PreserveWholeObject.After
{
    public class Room
    {
        public bool WithinPlan(HeatingPlan plan)
        {
            return plan.WithinRange(DaysTempRange());
        }

        private TempRange DaysTempRange()
        {
            return new TempRange();
        }
    }
}
