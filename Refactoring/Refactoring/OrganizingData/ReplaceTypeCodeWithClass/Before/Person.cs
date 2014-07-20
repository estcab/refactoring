namespace Refactoring.OrganizingData.ReplaceTypeCodeWithClass.Before
{
    public class Person
    {
        public static readonly int O = 0;
        public static readonly int A = 1;
        public static readonly int B = 2;
        public static readonly int AB = 3;

        private int _bloodGroup;

        public Person(int bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public int GetBloodGroup()
        {
            return _bloodGroup;
        }

        public void SetBloodGroup(int value)
        {
            _bloodGroup = value;
        }

    }
}
