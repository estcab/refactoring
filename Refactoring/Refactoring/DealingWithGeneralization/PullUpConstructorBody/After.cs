// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PullUpConstructorBody.After
{

    public class Employee
    {
        protected string Name;
        protected string Id;

        public Employee(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }

    public class Manager : Employee
    {
        private int _grade;

        public Manager(string name, string id, int grade)
            : base(name, id)
        {
            _grade = grade;
        }
    }
}
