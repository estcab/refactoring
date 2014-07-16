namespace Refactoring.ComposingMethods.ReplaceMethodWithMethodObject
{
    public class Before
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            int importantValue1 = (inputVal * quantity) + Delta();
            int importantValue2 = (inputVal * yearToDate) + 100;

            if ((yearToDate - importantValue1) > 100)
            {
                importantValue2 -= 20;
            }

            int importantValue3 = importantValue2 * 7;
            // and so on.

            return importantValue3 - 2 * importantValue1;
        }

        private int Delta()
        {
            return 1;
        }
    }
}
