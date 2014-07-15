namespace Refactoring.ComposingMethods.InlineTemp
{
    public class Before
    {
        public bool SampleMethod(Order order)
        {            
            double basePrice = order.GetBasePrice();
            return (basePrice > 1000);
        }
    }
}
