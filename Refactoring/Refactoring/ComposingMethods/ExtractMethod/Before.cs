using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ComposingMethods.ExtractMethod
{
    public class Before
    {
        private readonly IQueryable<Order> _orders;
        private readonly string _name;

        public Before(IQueryable<Order> orders, string name)
        {
            _orders = orders;
            _name = name;
        }

        public void PrintOwing()
        {
            IList<Order> orders = _orders.ToList();

            double outstanding = 0.0;

            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes ******");
            Console.WriteLine("**************************");

            // calculate outstanding
            foreach (var order in orders)
            {
                outstanding += order.Amount;
            }


            //print details
            Console.WriteLine("name:" + _name);
            Console.WriteLine("amount" + outstanding);

        }
    }
}
