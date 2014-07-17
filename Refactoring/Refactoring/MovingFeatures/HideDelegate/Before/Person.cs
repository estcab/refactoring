namespace Refactoring.MovingFeatures.HideDelegate.Before
{
    public class Person
    {
        Department _department;

        public Department GetDepartment()
        {
            return _department;
        }
        public void SetDepartment(Department arg)
        {
            _department = arg;
        }
    }
}
