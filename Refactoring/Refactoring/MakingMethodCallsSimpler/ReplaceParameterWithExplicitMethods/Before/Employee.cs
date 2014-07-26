using System;

namespace Refactoring.MakingMethodCallsSimpler.ReplaceParameterWithExplicitMethods.Before
{
    public class Employee
    {
        public const int Engineer = 0;
        public const int Salesman = 1;
        public const int Manager = 2;

        public static Employee Create(int type)
        {
            switch (type)
            {
                case Engineer:
                    return new Engineer();
                case Salesman:
                    return new Salesman();
                case Manager:
                    return new Manager();
                default:
                    throw new ArgumentException("Incorrect type code value");
            }
        }
    }
}
