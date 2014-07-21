using System;

namespace Refactoring.SimplifyingConditionalExpressions.DecomposeConditional
{
    public class After
    {
        public static readonly string SummerStart = "2014/06/01";
        public static readonly string SummerEnd = "2014/09/22";

        private readonly decimal _winterRate;
        private readonly decimal _summerRate;
        private readonly decimal _winterServiceCharge;

        public After(decimal winterRate, decimal summerRate, decimal winterServiceCharge)
        {
            _winterRate = winterRate;
            _summerRate = summerRate;
            _winterServiceCharge = winterServiceCharge;
        }

        public decimal GetCharge(DateTime date, decimal quantity)
        {
            return NotSummer(date) ? WinterCharge(quantity) : SummerCharge(quantity);
        }

        private decimal SummerCharge(decimal quantity)
        {
            return quantity * _summerRate;
        }

        private decimal WinterCharge(decimal quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private bool NotSummer(DateTime date)
        {
            return date.CompareTo(DateTime.Parse(SummerStart)) < 0
                   || date.CompareTo(DateTime.Parse(SummerEnd)) > 0;
        }
    }
}
