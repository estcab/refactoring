namespace Refactoring.DealingWithGeneralization.FormTemplateMethod.Before
{
    public class Rental
    {
        private readonly Movie _movie;
        private readonly decimal _charge;

        public Rental(Movie movie, decimal charge)
        {
            _movie = movie;
            _charge = charge;
        }

        public Movie Movie
        {
            get { return _movie; }
        }

        public decimal GetCharge()
        {
            return _charge;
        }
    }
}