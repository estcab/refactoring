namespace Refactoring.DealingWithGeneralization.ExtractSuperclass.Before
{
    public class Employee
    {
        private readonly string _name;
        private readonly int _annualCost;
        private readonly string _id;

        public Employee(string name, int annualCost, string id)
        {
            _name = name;
            _annualCost = annualCost;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
        }

        public int AnnualCost
        {
            get { return _annualCost; }
        }

        public string Id
        {
            get { return _id; }
        }
    }
}
