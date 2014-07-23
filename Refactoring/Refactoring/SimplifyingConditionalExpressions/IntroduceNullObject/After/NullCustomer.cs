namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.After
{
    public class NullCustomer : Customer
    {
        internal NullCustomer()
        {
        }

        public override string GetName()
        {
            return "occupant";
        }

        public override BillingPlan GetPlan()
        {
            return BillingPlan.Basic();
        }

        public override PaymentHistory GetPaymentHistory()
        {
            return new NullPaymentHistory();
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}