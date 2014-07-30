namespace Refactoring.DealingWithGeneralization.ExtractSubclass.After
{
    public class LaborItem : JobItem
    {
        private readonly Employee _employee;

        public LaborItem(int quantity, Employee employee)
            : base(quantity)
        {
            _employee = employee;
        }

        public Employee Employee
        {
            get { return _employee; }
        }

        public override int GetUnitPrice()
        {
            return Employee.Rate;
        }
    }
}