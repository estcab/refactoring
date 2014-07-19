using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.OrganizingData.ChangeValueToReference.Before
{
    public class Client
    {
        private static int NumberOfOrdersFor(IEnumerable<Order> orders, String customer)
        {
            return orders.Count(order => order.GetCustomerName().Equals(customer));
        }
    }
}
