namespace Refactoring.DealingWithGeneralization.ExtractSubclass.Before
{
    public class Employee
    {
        private readonly int _rate;

        public Employee(int rate)
        {
            _rate = rate;
        }

        public int Rate
        {
            get { return _rate; }
        }
    }
}
