using System;

// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PullUpMethod.After
{
    public abstract class Customer
    {
        protected DateTime LastBillDate;

        public void AddBill(DateTime date, double charge)
        {
            throw new NotImplementedException();
        }

        public void CreateBill(DateTime date)
        {
            double chargeAmount = ChargeFor(LastBillDate, date);
            AddBill(date, chargeAmount);
        }

        public abstract double ChargeFor(DateTime lastBillDate, DateTime date);
    }

    public class PreferredCustomer : Customer
    {
        public override double ChargeFor(DateTime lastBillDate, DateTime date)
        {
            // custom implementation

            return 1.0;
        }
    }

    public class RegularCustomer : Customer
    {
        public override double ChargeFor(DateTime lastBillDate, DateTime date)
        {
            // custom implementation

            return 1.0;
        }
    }
}
