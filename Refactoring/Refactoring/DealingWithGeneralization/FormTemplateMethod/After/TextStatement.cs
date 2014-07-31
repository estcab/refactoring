using System.Text;

namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.After
{
    public class TextStatement : Statement
    {
        protected override string GetHeaderString(Customer customer)
        {
            return string.Format("Rental Record for {0}\n", customer.Name);
        }

        protected override string GetRentalString(Rental rental)
        {
            return string.Format("\t{0}\t{1}\n", rental.Movie.Title, rental.GetCharge());
        }

        protected override string GetFooterString(Customer customer)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Amount owed is {0}\n", customer.GetTotalCharge());
            sb.AppendFormat("You earned {0} frequent renter points", customer.Points);

            return sb.ToString();
        }
    }
}