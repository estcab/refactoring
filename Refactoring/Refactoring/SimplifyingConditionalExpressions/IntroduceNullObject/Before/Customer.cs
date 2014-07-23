namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.Before
{
    public class Customer
    {
        public Customer(string name, BillingPlan plan, PaymentHistory paymentHistory)
        {
            PaymentHistory = paymentHistory;
            Plan = plan;
            Name = name;
        }

        public string Name { get; private set; }
        public BillingPlan Plan { get; private set; }
        public PaymentHistory PaymentHistory { get; private set; }
                
    }
}