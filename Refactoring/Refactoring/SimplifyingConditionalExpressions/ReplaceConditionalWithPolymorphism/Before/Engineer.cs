namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.Before
{
    public class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Engineer;
        }
    }
}