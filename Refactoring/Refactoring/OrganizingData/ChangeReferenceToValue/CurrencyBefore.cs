using System.Collections.Generic;

namespace Refactoring.OrganizingData.ChangeReferenceToValue
{
    public class CurrencyBefore
    {
        private readonly string _code;

        private static readonly Dictionary<string, CurrencyBefore> Currencies = new Dictionary<string, CurrencyBefore>()
        {
            {"USD", new CurrencyBefore("USD")}, {"EU", new CurrencyBefore("EU")}
        };

        private CurrencyBefore(string code)
        {
            _code = code;
        }

        public string GetCode
        {
            get { return _code; }
        }

        public static CurrencyBefore GetCurrency(string code)
        {
            return Currencies[code];
        }
    }
}
