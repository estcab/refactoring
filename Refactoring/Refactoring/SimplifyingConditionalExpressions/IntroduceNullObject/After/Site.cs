namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.After
{
    public class Site
    {
        private readonly Customer _customer;

        public Site(Customer customer)
        {
            _customer = customer;
        }

        public Customer GetCustomer()
        {
            return _customer ?? Customer.NullCustomer();
        }
    }
}
