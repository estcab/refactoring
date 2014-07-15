namespace Refactoring.ComposingMethods.InlineTemp
{
    public class After
    {
        public bool SampleMethod(Order order)
        {
            return (order.GetBasePrice() > 1000);
        }
    }
}
