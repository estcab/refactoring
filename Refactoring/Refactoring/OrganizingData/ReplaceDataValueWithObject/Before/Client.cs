using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.OrganizingData.ReplaceDataValueWithObject.Before
{
    public class Client
    {
        private static int NumberOfOrdersFor(IEnumerable<Order> orders, String customer)
        {
            return orders.Count(order => order.GetCustomer().Equals(customer));
        }
    }
}
