// ReSharper disable once CheckNamespace

namespace Refactoring.DealingWithGeneralization.PushDownMethod.After
{
    class Employee
    {
    }

    class Manager : Employee
    {
    }

    class Salesman : Employee
    {
        public double GetCuota()
        {
            return 100.0;
        }
    }
}
