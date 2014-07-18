namespace Refactoring.OrganizingData.ReplaceDataValueWithObject.Before
{
    public class Order
    {
        private string _customer;

        public Order(string customer)
        {
            SetCustomer(customer);
        }

        public void SetCustomer(string value)
        {
            _customer = value;
        }

        public string GetCustomer()
        {
            return _customer;
        }
    }
}
