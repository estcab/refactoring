namespace Refactoring.SimplifyingConditionalExpressions.IntroduceNullObject.After
{
    public class NullPaymentHistory : PaymentHistory
    {
        public override int GetWeeksDelinquentInLastYear()
        {
            return 0;
        }
    }
}