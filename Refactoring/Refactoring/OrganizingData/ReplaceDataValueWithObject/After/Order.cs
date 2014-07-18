namespace Refactoring.OrganizingData.ReplaceDataValueWithObject.After
{
    public class Order
    {
        private Customer _customer;

        public Order(string customerName)
        {
            _customer = new Customer(customerName);
        }

        public void SetCustomer(string customerName)
        {
            _customer = new Customer(customerName);
        }

        public string GetCustomerName()
        {
            return _customer.GetName();
        }
    }
}
