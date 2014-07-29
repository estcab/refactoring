// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PullUpField.Before
{
    public class Employee
    {
    }

    public class Salesman : Employee
    {
        private string name;
    }

    public class Manager : Employee
    {
        private string name;
    }
}
