using System;

namespace Refactoring.SimplifyingConditionalExpressions.DecomposeConditional
{
    public class Before
    {
        public static readonly string SummerStart = "2014/06/01";
        public static readonly string SummerEnd = "2014/09/22";

        private readonly decimal _winterRate;
        private readonly decimal _summerRate;
        private readonly decimal _winterServiceCharge;

        public Before(decimal winterRate, decimal summerRate, decimal winterServiceCharge)
        {
            _winterRate = winterRate;
            _summerRate = summerRate;
            _winterServiceCharge = winterServiceCharge;
        }

        public decimal GetCharge(DateTime date, decimal quantity)
        {
            decimal charge;

            if (date.CompareTo(DateTime.Parse(SummerStart)) < 0 
                || date.CompareTo(DateTime.Parse(SummerEnd)) > 0)
            {
                charge = quantity * _winterRate + _winterServiceCharge;
            }
            else
            {
                charge = quantity * _summerRate;
            }

            return charge;
        }
    }
}
