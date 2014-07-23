namespace Refactoring.SimplifyingConditionalExpressions.ReplaceConditionalWithPolymorphism.After
{
    public class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Manager;
        }
        public override int PayAmount(Employee employee)
        {
            return employee.MonthlySalary + employee.Bonus;
        }
    }
}