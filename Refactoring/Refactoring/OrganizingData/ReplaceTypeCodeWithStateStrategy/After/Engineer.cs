namespace Refactoring.OrganizingData.ReplaceTypeCodeWithStateStrategy.After
{
    public class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Engineer;
        }
    }
}