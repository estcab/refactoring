namespace Refactoring.MovingFeatures.HideDelegate.After
{
    public class Person
    {
        private readonly Department _department;

        public Person(Department department)
        {
            _department = department;
        }

        public Person GetManager()
        {
            return _department.GetManager();
        }
    }
}
