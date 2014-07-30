// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PushDownMethod.After
{
    public class Employee
    {
    }

    public class Salesman : Employee
    {
        public double GetQuota()
        {
            return 1.0;
        }
    }

    public class Manager : Employee
    {
    }
}
