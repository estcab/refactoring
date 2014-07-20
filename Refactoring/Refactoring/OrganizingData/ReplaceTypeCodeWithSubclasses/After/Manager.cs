namespace Refactoring.OrganizingData.ReplaceTypeCodeWithSubclasses.After
{
    public class Manager : Employee
    {
        public override EmployeeType GetEmployeeType()
        {
            return EmployeeType.Manager;
        }
    }
}