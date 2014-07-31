// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.ReplaceDelegationWithInheritance.Before
{
    class Employee
    {
        private readonly Person _person = new Person();

        public string Name
        {
            get { return _person.Name; }
            set { _person.Name = value; }
        }
        
        public override string ToString()
        {
            return "Emp: " + _person.GetLastName();
        }
    }


    public class Person
    {
        public string Name { get; set; }

        public string GetLastName()
        {
            return Name.Substring(Name.LastIndexOf(' ') + 1);
        }
    }
}
