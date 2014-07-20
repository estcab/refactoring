namespace Refactoring.OrganizingData.ReplaceTypeCodeWithStateStrategy.After
{
    public class Salesman : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Salesman;
        }
    }
}