namespace Refactoring.MovingFeatures.RemoveMiddleMan.After
{
    public class Person
    {
        private Department _department;
        
        public Person(Department department)
        {
            SetDepartment(department);
        }

        private void SetDepartment(Department value)
        {
            _department = value;
        }

        public Department GetDepartment()
        {
            return _department;
        }


    }
}
