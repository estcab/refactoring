namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.After
{
    public class Customer
    {
        private readonly string _name;
        private readonly BillingPlan _plan;
        private readonly PaymentHistory _paymentHistory;

        protected Customer()
        {
        }

        public Customer(string name, BillingPlan plan, PaymentHistory paymentHistory)
        {
            _paymentHistory = paymentHistory;
            _plan = plan;
            _name = name;
        }

        public virtual string GetName()
        {
            return _name;
        }

        public virtual BillingPlan GetPlan()
        {
            return _plan;
        }

        public virtual PaymentHistory GetPaymentHistory()
        {
            return _paymentHistory;
        }

        public virtual bool IsNull()
        {
            return false;
        }

        public static Customer NullCustomer()
        {
            return new NullCustomer();
        }
    }
}