namespace Refactoring.DealingWithGeneralization.ExtractSuperclass.After
{
    public class Employee : Party
    {
        private readonly int _annualCost;
        private readonly string _id;

        public Employee(string name, int annualCost, string id)
            : base(name)
        {
            _annualCost = annualCost;
            _id = id;
        }

        public string GetId()
        {
            return _id;
        }

        public override int GetAnnualCost()
        {
            return _annualCost;
        }
    }
}
