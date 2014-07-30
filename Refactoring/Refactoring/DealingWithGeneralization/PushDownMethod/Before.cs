// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PushDownMethod.Before
{
    public class Employee
    {
        public double GetQuota()
        {
            return 1.0;
        }
    }

    public class Salesman : Employee
    {
    }

    public class Manager : Employee
    {
    }
}
