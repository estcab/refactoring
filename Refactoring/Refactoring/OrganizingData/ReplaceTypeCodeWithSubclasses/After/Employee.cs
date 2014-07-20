using System.ComponentModel;

namespace Refactoring.OrganizingData.ReplaceTypeCodeWithSubclasses.After
{
    public abstract class Employee
    {
        public static Employee CreateEmployee(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Engineer:
                    return new Engineer();
                case EmployeeType.Salesman:
                    return new Salesman();
                case EmployeeType.Manager:
                    return new Manager();
                default:
                    throw new InvalidEnumArgumentException("Incorrect type code value");
            }
        }

        public abstract EmployeeType GetEmployeeType();
    }
}
