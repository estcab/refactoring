namespace Refactoring.MakingMethodCallsSimpler.ReplaceConstructorWithFactoryMethod
{
    public class EmployeeBefore
    {
        public const int Engineer = 0;
        public const int Salesman = 1;
        public const int Manager = 2;

        private int _type;

        public EmployeeBefore(int type)
        {
            _type = type;
        }

    }
}
