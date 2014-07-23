namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.After
{
    public class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Engineer;
        }

        public int PayAmount(Employee employee)
        {
            return employee.MonthlySalary;
        }
    }
}