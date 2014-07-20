namespace Refactoring.OrganizingData.ReplaceTypeCodeWithSubclasses.After
{
    public class Salesman : Employee
    {
        public override EmployeeType GetEmployeeType()
        {
            return EmployeeType.Salesman;
        }
    }
}