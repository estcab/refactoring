using System;

namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.After
{
    public abstract class EmployeeType
    {
        public const int Engineer = 0;
        public const int Salesman = 1;
        public const int Manager = 2;
        
        public static EmployeeType CreateType(int code)
        {
            switch (code)
            {
                case Engineer:
                    return new Engineer();

                case Salesman:
                    return new Salesman();

                case Manager:
                    return new Manager();

                default:
                    throw new ArgumentException("Incorrect Employee Code");
            }
        }

        public abstract int GetTypeCode();
        public abstract int PayAmount(Employee employee);
    }
}