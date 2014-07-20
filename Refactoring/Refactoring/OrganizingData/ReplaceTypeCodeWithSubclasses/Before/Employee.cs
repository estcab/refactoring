namespace Refactoring.OrganizingData.ReplaceTypeCodeWithSubclasses.Before
{
    public class Employee
    {
        public static readonly int ENGINEER = 0;
        public static readonly int SALESMAN = 1;
        public static readonly int MANAGER = 2;

        private int _type;

        public Employee(int type)
        {
            _type = type;
        }
    }
}
