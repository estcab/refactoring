// ReSharper disable once CheckNamespace
namespace Refactoring.DealingWithGeneralization.ReplaceDelegationWithInheritance.After
{
    public class Employee : Person
    {       
        public override string ToString()
        {
            return "Emp: " + GetLastName();
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
