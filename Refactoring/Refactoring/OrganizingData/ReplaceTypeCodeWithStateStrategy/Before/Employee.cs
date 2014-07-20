using System;

namespace Refactoring.OrganizingData.ReplaceTypeCodeWithStateStrategy.Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        private int _type;
        private readonly int _monthlySalary;
        private readonly int _commission;
        private readonly int _bonus;

        public Employee(int type, int monthlySalary, int commission, int bonus)
        {
            _type = type;
            _monthlySalary = monthlySalary;
            _commission = commission;
            _bonus = bonus;
        }

        public int PayAmount()
        {
            switch (_type)
            {
                case ENGINEER:
                    return _monthlySalary;
                case SALESMAN:
                    return _monthlySalary + _commission;
                case MANAGER:
                    return _monthlySalary + _bonus;
                default:
                    throw new ArgumentException("Incorrect Employee");
            }
        }

    }

}
