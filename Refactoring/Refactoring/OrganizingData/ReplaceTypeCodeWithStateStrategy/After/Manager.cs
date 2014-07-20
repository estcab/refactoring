namespace Refactoring.OrganizingData.ReplaceTypeCodeWithStateStrategy.After
{
    public class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Manager;
        }
    }
}