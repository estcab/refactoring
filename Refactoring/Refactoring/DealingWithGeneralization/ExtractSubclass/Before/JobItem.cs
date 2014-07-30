namespace Refactoring.DealingWithGeneralization.ExtractSubclass.Before
{
    public class JobItem
    {
        private readonly int _unitPrice;
        private readonly int _quantity;
        private readonly Employee _employee;
        private readonly bool _isLabor;

        public JobItem(int unitPrice, int quantity, Employee employee, bool isLabor)
        {
            _unitPrice = unitPrice;
            _quantity = quantity;
            _employee = employee;
            _isLabor = isLabor;
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public Employee Employee
        {
            get { return _employee; }
        }

        public int GetTotalPrice()
        {
            return GetUnitPrice() * _quantity;
        }

        public int GetUnitPrice()
        {
            return (_isLabor) ? Employee.Rate : _unitPrice;
        }
    }
}
