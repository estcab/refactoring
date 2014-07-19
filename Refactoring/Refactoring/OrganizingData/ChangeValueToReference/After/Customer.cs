using System.Collections.Generic;

namespace Refactoring.OrganizingData.ChangeValueToReference.After
{
    public class Customer
    {
        private readonly string _name;

        // create a registry object to be the access point.
        private static readonly Dictionary<string, Customer> Customers = new Dictionary<string, Customer>();

        private Customer(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public static Customer GetNamed(string name)
        {
            if (Customers.ContainsKey(name))
            {
                return Customers[name];
            }

            var customer = new Customer(name);
            Customers.Add(name, customer);

            return customer;
        }
    }
}