using System;
// ReSharper disable once CheckNamespace


namespace Refactoring.DealingWithGeneralization.PullUpMethod.Before
{
    public class Customer
    {
        protected DateTime LastBillDate;

        public void AddBill(DateTime date, double charge)
        {
            throw new NotImplementedException();
        }
    }

    public class PreferredCustomer : Customer
    {
        public void CreateBill(DateTime date)
        {
            double chargeAmount = ChargeFor(LastBillDate, date);
            AddBill(date, chargeAmount);
        }

        public double ChargeFor(DateTime lastBillDate, DateTime date)
        {
            throw new NotImplementedException();
        }
    }

    public class RegularCustomer : Customer
    {
        public void CreateBill(DateTime date)
        {
            double chargeAmount = ChargeFor(LastBillDate, date);
            AddBill(date, chargeAmount);
        }

        public double ChargeFor(DateTime lastBillDate, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
