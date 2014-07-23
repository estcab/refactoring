namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.After
{
    public class Client
    {
        public void ExampleUse(Site site)
        {
            var customer = site.GetCustomer();
            var plan = customer.GetPlan();

            // ..

            var customerName = customer.GetName();

            // ..

            int weeksDelinquent = customer.GetPaymentHistory().GetWeeksDelinquentInLastYear();

            // ..
        }
    }
}
