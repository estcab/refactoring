using System.Text;

namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.After
{
    public class HtmlStatement : Statement
    {
        protected override string GetFooterString(Customer customer)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("<P>You owe <EM>{0}</EM><P>\n", customer.GetTotalCharge());
            sb.AppendFormat("On this rental you earned <EM> {0} </EM> frequent renter points<P>", Points);

            return sb.ToString();
        }

        protected override string GetHeaderString(Customer customer)
        {
            return string.Format("<H1>Rentals for <EM> {0}</EM></H1><P>\n", customer.Name);
        }

        protected override string GetRentalString(Rental rental)
        {
            return string.Format("{0}: {1}<BR>\n", rental.Movie.Title, rental.GetCharge());
        }
    }
}