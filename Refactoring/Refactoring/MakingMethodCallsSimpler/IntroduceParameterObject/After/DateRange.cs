using System;

namespace Refactoring.MakingMethodCallsSimpler.IntroduceParameterObject.After
{
    public class DateRange
    {
        private readonly DateTime _start;
        private readonly DateTime _end;

        public DateRange(DateTime start, DateTime end)
        {
            _start = start;
            _end = end;
        }

        public DateTime Start
        {
            get { return _start; }
        }

        public DateTime End
        {
            get { return _end; }
        }

        public bool Includes(DateTime date)
        {
            return date.Equals(Start) || date.Equals(End) ||
                   (date.CompareTo(Start) > 0 && date.CompareTo(this) < 0);
        }
    }
}