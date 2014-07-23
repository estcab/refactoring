namespace Refactoring.SimplifyingConditionalExpressions.IntroduceAssertion
{
    public class EmployeeBefore
    {
        private const double NullExpense = -1.0;
        private const double ExpenseLimit = NullExpense;
        private readonly Project _primaryProject;

        public EmployeeBefore(Project primaryProject)
        {
            _primaryProject = primaryProject;
        }

        public double GetExpenseLimit()
        {
            return (ExpenseLimit != NullExpense) ?
                ExpenseLimit :
                _primaryProject.GetMemberExpenseLimit();
        }

        public bool WithinLimit(double expenseAmount)
        {
            return (expenseAmount <= GetExpenseLimit());
        }
    }
}
