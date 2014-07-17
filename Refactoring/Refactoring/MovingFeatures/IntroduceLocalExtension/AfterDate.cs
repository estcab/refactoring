using System;

namespace Refactoring.MovingFeatures.IntroduceLocalExtension
{
    public class AfterDate
    {
        private readonly DateTime _dateTime;

        public AfterDate(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public DateTime GetNextDay()
        {
            return new DateTime(_dateTime.Year,
                _dateTime.Month, _dateTime.Day + 1);
        }

    }
}