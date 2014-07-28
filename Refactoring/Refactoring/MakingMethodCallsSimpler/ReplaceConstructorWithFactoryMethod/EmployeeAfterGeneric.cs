using System;

namespace Refactoring.MakingMethodCallsSimpler.ReplaceConstructorWithFactoryMethod
{
    public class EmployeeAfterGeneric
    {
        protected EmployeeAfterGeneric()
        {
        }

        public static T Create<T>() where T : EmployeeAfterGeneric
        {
            return Activator.CreateInstance<T>();
        }
    }

    // Replace Type Code with Subclasses
    public class Manager : EmployeeAfterGeneric
    {
    }

    public class Salesman : EmployeeAfterGeneric
    {
    }

    public class Engineer : EmployeeAfterGeneric
    {
    }
}
