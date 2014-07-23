namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.Before
{
    public class Salesman : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Salesman;
        }
    }
}