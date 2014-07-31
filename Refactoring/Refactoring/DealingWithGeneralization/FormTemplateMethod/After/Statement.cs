using System.Text;

namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.After
{
    public abstract class Statement
    {
        public string Value(Customer customer)
        {
            var result = new StringBuilder();
            result.Append(GetHeaderString(customer));

            foreach (var rental in customer.Rentals)
            {
                result.Append(GetRentalString(rental));
            }

            result.Append(GetFooterString(customer));

            return result.ToString();
        }

        protected abstract string GetHeaderString(Customer customer);
        protected abstract string GetRentalString(Rental rental);
        protected abstract string GetFooterString(Customer customer);
    }
}
