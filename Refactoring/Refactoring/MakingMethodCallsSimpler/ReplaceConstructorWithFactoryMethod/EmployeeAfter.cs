namespace Refactoring.MakingMethodCallsSimpler.ReplaceConstructorWithFactoryMethod
{
    public class EmployeeAfter
    {
        // Replace Type Code with Subclasses
        public const int Engineer = 0;
        public const int Salesman = 1;
        public const int Manager = 2;

        private int _type;

        private EmployeeAfter(int type)
        {
            _type = type;
        }

        public static EmployeeAfter Create(int type)
        {
            return new EmployeeAfter(type);
        }
    }
}
