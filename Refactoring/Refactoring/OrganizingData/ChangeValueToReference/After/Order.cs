namespace Refactoring.OrganizingData.ChangeValueToReference.After
{
    public class Order
    {
        private Customer _customer;

        public Order(string customerName)
        {
            _customer = Customer.GetNamed(customerName);
        }

        public void SetCustomer(string customerName)
        {
            _customer = Customer.GetNamed(customerName);
        }

        public string GetCustomerName()
        {
            return _customer.GetName();
        }
    }
}
