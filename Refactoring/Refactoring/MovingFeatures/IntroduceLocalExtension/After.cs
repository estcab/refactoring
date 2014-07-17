namespace Refactoring.MovingFeatures.IntroduceLocalExtension
{
    public class After
    {
        public void Example(AfterDate previousEnd)
        {
            // ...

            var newStart = previousEnd.GetNextDay();

            // ...
        }        
    }
}
