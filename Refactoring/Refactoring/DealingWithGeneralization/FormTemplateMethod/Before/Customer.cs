using System.Collections.Generic;
using System.Text;

namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.Before
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
            var result = new StringBuilder();

            result.AppendFormat("Rental Record for {0}\n", GetName());

            //show figures for this rental
            foreach (var rental in _rentals)
            {
                result.AppendFormat("\t{0}\t{1}\n", rental.Movie.Title, rental.GetCharge());
            }

            //add footer lines
            result.AppendFormat("Amount owed is {0}\n", GetTotalCharge());
            result.AppendFormat("You earned {0} frequent renter points", Points);


            return result.ToString();
        }

        public string HtmlStatement()
        {
            var result = new StringBuilder();
            result.AppendFormat("<H1>Rentals for <EM> {0}</EM></H1><P>\n", GetName());

            foreach (var rental in _rentals)
            {
                 result.AppendFormat("{0}: {1}<BR>\n", rental.Movie.Title, rental.GetCharge());                                    
            }

            //add footer lines
            result.AppendFormat("<P>You owe <EM>{0}</EM><P>\n", GetTotalCharge());
            result.AppendFormat("On this rental you earned <EM> {0} </EM> frequent renter points<P>", Points);
                                 
            return result.ToString();
        }


        private decimal GetTotalCharge()
        {
            decimal result = 0;
            foreach (var rental in _rentals)
            {
                result += rental.GetCharge();
            }

            return result;
        }

        private string GetName()
        {
            return _name;
        }
    }
}
