// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PullUpField.After
{
    public class Employee
    {
        protected string Name;
    }

    public class Salesman : Employee
    {
    }

    public class Manager : Employee
    {
    }
}
