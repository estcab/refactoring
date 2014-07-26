namespace Refactoring.MakingMethodCallsSimpler.ReplaceParameterWithExplicitMethods.After
{
    public class Employee
    {
        public static Employee CreateEngineer()
        {
            return new Engineer();
        }

        public static Employee CreateSalesman()
        {
            return new Salesman();
        }

        public static Employee CreateManager()
        {
            return new Manager();
        }
    }
}
