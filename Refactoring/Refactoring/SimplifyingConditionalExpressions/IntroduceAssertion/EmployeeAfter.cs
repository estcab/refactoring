using System.Diagnostics;

namespace Refactoring.SimplifyingConditionalExpressions.IntroduceAssertion
{
    public class EmployeeAfter
    {
        private const double NullExpense = -1.0;
        private const double ExpenseLimit = NullExpense;
        private readonly Project _primaryProject;

        public EmployeeAfter(Project primaryProject)
        {
            _primaryProject = primaryProject;
        }

        public double GetExpenseLimit()
        {
            Debug.Assert(ExpenseLimit != NullExpense || _primaryProject != null);

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
