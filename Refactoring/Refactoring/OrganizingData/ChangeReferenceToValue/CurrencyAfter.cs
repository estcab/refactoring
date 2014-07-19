namespace Refactoring.OrganizingData.ChangeReferenceToValue
{
    public class CurrencyAfter
    {
        private readonly string _code;

        private CurrencyAfter(string code)
        {
            _code = code;
        }

        public string GetCode
        {
            get { return _code; }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CurrencyAfter))
            {
                return false;
            }

            var other = (CurrencyAfter)obj;

            return (_code.Equals(other._code));
        }

        public override int GetHashCode()
        {
            return _code.GetHashCode();
        }
    }
}
