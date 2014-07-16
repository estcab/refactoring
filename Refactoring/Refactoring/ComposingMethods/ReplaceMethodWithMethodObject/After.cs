namespace Refactoring.ComposingMethods.ReplaceMethodWithMethodObject
{
    public class After
    {        
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
           return new Gamma(this, inputVal, quantity, yearToDate ).Compute();
        }

        public int Delta()
        {
            return 1;
        }
    }
}
