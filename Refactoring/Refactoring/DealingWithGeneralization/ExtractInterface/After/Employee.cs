namespace Refactoring.DealingWithGeneralization.ExtractInterface.After
{
    public class Employee : IBillable
    {
        private readonly Deparment _deparment;
        private readonly int _rate;

        public Employee(int rate, Deparment deparment)
        {
            _rate = rate;
            _deparment = deparment;
        }


        public string SpecialSkill { get; set; }

        public int GetRate()
        {
            return _rate;
        }

        public Deparment GetDeparment()
        {
            return _deparment;
        }

        public bool HasSpecialSkill()
        {
            return string.IsNullOrWhiteSpace(SpecialSkill);
        }
    }
}