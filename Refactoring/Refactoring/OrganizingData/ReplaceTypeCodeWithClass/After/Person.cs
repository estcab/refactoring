namespace Refactoring.OrganizingData.ReplaceTypeCodeWithClass.After
{
    public class Person
    {
        private BloodGroup _bloodGroup;

        public Person(BloodGroup bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public void SetBloodGroup(BloodGroup value)
        {
            _bloodGroup = value;
        }

        public BloodGroup GetBloodGroup()
        {
            return _bloodGroup;
        }
    }
}
