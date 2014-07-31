using System.Collections.Generic;

namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.After
{
    public class Customer
    {
        private readonly List<Rental> _rentals;
        private readonly string _name;

        public Customer(List<Rental> rentals, string name)
        {
            _rentals = rentals;
            _name = name;
        }

        public int Points { get; set; }

        public string Statement()
        {
            return new TextStatement().Value(this);
        }

        public string HtmlStatement()
        {
            return new HtmlStatement().Value(this);
        }

        public decimal GetTotalCharge()
        {
            decimal result = 0;
            foreach (var rental in Rentals)
            {
                result += rental.GetCharge();
            }

            return result;
        }

        public string Name
        {
            get { return _name; }
        }

        public List<Rental> Rentals
        {
            get { return _rentals; }
        }
    }
}
