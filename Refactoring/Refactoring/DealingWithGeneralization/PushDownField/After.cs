// ReSharper disable once CheckNamespace

namespace Refactoring.DealingWithGeneralization.PushDownField.After
{
    class Employee
    {
    }

    class Manager : Employee
    {
    }

    class Salesman : Employee
    {
        public double Quota;
    }
}
