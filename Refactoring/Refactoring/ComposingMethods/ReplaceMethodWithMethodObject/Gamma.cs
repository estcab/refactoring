namespace Refactoring.ComposingMethods.ReplaceMethodWithMethodObject
{
    public class Gamma
    {
        private readonly After _after;
        private readonly int _inputVal;
        private readonly int _quantity;
        private readonly int _yearToDate;
        private int _importantValue2;

        public Gamma(After after, int inputVal, int quantity, int yearToDate)
        {
            _after = after;
            this._inputVal = inputVal;
            this._quantity = quantity;
            this._yearToDate = yearToDate;
        }

        public int Compute()
        {
            _importantValue2 = GetImportantValue2();

            DoImportantThing();
            
            return GetImportantValue3() - 2 * GetImportantValue1();
        }

        private int GetImportantValue3()
        {
            return _importantValue2 * 7;
        }

        private void DoImportantThing()
        {
            if ((_yearToDate - GetImportantValue1()) > 100)
            {
                _importantValue2 -= 20;
            }
        }

        private int GetImportantValue2()
        {
            return (_inputVal * _yearToDate) + 100;
        }

        private int GetImportantValue1()
        {
            return (_inputVal * _quantity) + _after.Delta();
        }
    }
}