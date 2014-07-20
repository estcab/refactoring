namespace Refactoring.OrganizingData.ReplaceTypeCodeWithSubclasses.After
{
    public class Engineer : Employee
    {
        public override EmployeeType GetEmployeeType()
        {
            return EmployeeType.Engineer;
        }
    }
}