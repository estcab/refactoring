namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.After
{
    public class Salesman : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Salesman;
        }

        public override int PayAmount(Employee employee)
        {
            return employee.MonthlySalary + employee.Commission;
        }
    }
}