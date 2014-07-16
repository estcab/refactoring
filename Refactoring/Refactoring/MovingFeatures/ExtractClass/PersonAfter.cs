using System;

namespace Refactoring.MovingFeatures.ExtractClass
{
    public class PersonAfter
    {
        private readonly string _name;
        private readonly TelephoneNumberAfter _telephoneNumberAfter;

        public PersonAfter(string name)
        {
            _name = name;
            _telephoneNumberAfter = new TelephoneNumberAfter();
        }

        public string GetName()
        {
            return _name;
        }

        public void SetOfficeAreaCode(string value)
        {
            _telephoneNumberAfter.AreaCode = value;
        }

        public string GetOfficeAreaCode()
        {
            return _telephoneNumberAfter.AreaCode;
        }

        public void SetOfficeNumber(string value)
        {
            _telephoneNumberAfter.Number = value;
        }

        public string GetOfficeNumber()
        {
            return _telephoneNumberAfter.Number;
        }

        public String GetTelephoneNumber()
        {
            return ("(" + GetOfficeAreaCode() + ") " + GetOfficeNumber());
        }
    }
}
