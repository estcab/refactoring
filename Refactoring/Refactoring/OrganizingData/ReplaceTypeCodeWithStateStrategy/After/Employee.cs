using System;

namespace Refactoring.OrganizingData.ReplaceTypeCodeWithStateStrategy.After
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
            // Replace Conditional with Polymorphism
            switch (GetTypeCode())
            {
                case EmployeeType.Engineer:
                    return _monthlySalary;
                case EmployeeType.Salesman:
                    return _monthlySalary + _commission;
                case EmployeeType.Manager:
                    return _monthlySalary + _bonus;
                default:
                    throw new ArgumentException("Incorrect Employee");
            }
        }

    }
}
