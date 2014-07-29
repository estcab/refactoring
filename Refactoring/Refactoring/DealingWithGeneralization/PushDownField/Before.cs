// ReSharper disable once CheckNamespace

namespace Refactoring.DealingWithGeneralization.PushDownField.Before
{
    class Employee
    {
        public double Quota;
    }

    class Manager : Employee
    {
    }

    class Salesman : Employee
    {
    }
}
