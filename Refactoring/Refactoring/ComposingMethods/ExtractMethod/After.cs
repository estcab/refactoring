using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ComposingMethods.ExtractMethod
{
    public class After
    {
        private readonly IQueryable<Order> _orders;
        private readonly string _name;

        public After(IQueryable<Order> orders, string name)
        {
            _orders = orders;
            _name = name;
        }

        public void PrintOwing()
        {
            PrintBanner();
            PrintDetails(GetOutstanding());
        }

        private double GetOutstanding()
        {
            IList<Order> orders = _orders.ToList();
            return orders.Sum(order => order.Amount);
        }

        private void PrintDetails(double outstanding)
        {
            Console.WriteLine("name:" + _name);
            Console.WriteLine("amount" + outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes ******");
            Console.WriteLine("**************************");
        }
    }
}
