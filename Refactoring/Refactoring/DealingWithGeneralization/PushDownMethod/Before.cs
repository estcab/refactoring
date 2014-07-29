// ReSharper disable once CheckNamespace

namespace Refactoring.DealingWithGeneralization.PushDownMethod.Before
{
    class Employee
    {
        public double GetCuota()
        {
            return 100.0;
        }
    }

    class Manager : Employee
    {
    }

    class Salesman : Employee
    {
    }
}
