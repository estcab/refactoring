namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.Before
{
    public class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Manager;
        }
    }
}