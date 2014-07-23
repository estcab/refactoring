namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.Before
{
    public class Client
    {
        public BillingPlan ExampleUse(Site site)
        {
            Customer customer = site.GetCustomer();

            BillingPlan plan;
            if (customer == null)
                plan = BillingPlan.Basic();
            else
                plan = customer.Plan;

            return plan;
        }

        public string ExampleUse2(Customer customer)
        {
            string customerName;

            if (customer == null)
                customerName = "occupant";
            else
                customerName = customer.Name;

            return customerName;
        }

        public int AnotherExampleUse(Customer customer)
        {
            int weeksDelinquent;
            if (customer == null) 
                weeksDelinquent = 0;
            else 
                weeksDelinquent = customer.PaymentHistory.GetWeeksDelinquentInLastYear();


            return weeksDelinquent;
        }
    }
}
