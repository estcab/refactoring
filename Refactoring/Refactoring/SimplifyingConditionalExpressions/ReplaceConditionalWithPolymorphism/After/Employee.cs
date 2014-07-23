namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.After
{
    public class Employee
    {
        private EmployeeType _type;

        private readonly int _monthlySalary;
        private readonly int _commission;
        private readonly int _bonus;

        public Employee(int type, int monthlySalary, int commission, int bonus)
        {
            _type = EmployeeType.CreateType(type);
            _monthlySalary = monthlySalary;
            _commission = commission;
            _bonus = bonus;
        }

        public int MonthlySalary
        {
            get { return _monthlySalary; }
        }

        public int Commission
        {
            get { return _commission; }
        }

        public int Bonus
        {
            get { return _bonus; }
        }

        public void SetTypeCode(int value)
        {
            _type = EmployeeType.CreateType(value);
        }

        public int GetTypeCode()
        {
            return _type.GetTypeCode();
        }

        public int PayAmount()
        {
            return _type.PayAmount(this);
        }

    }
}
