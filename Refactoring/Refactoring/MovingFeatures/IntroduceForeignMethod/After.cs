using System;

namespace Refactoring.MovingFeatures.IntroduceForeignMethod
{
    public class After
    {
        public void Example(DateTime previousEnd)
        {
            // ...

            var newStart = GetNextDay(previousEnd);
            
            // ...
        }

        
        private static DateTime GetNextDay(DateTime dateTime)
        {
            // foreign method, should be on date
            return new DateTime(dateTime.Year, 
                dateTime.Month, dateTime.Day + 1);
        }
    }
}
