namespace Refactoring.DealingWithGeneralization.ExtractSuperclass.After
{
    public abstract class Party
    {
        private readonly string _name;

        protected Party(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public abstract int GetAnnualCost();
    }
}