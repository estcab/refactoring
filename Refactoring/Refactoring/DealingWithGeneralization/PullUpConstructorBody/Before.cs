// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.PullUpConstructorBody.Before
{

    public class Employee
    {
        protected string _name;
        protected string _id;
    }

    public class Manager : Employee
    {
        private int _grade;

        public Manager(string name, string id, int grade)
        {
            _name = name;
            _id = id;
            _grade = grade;
        }

    }
}
