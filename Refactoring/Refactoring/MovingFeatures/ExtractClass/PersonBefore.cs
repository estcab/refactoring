using System;

namespace Refactoring.MovingFeatures.ExtractClass
{
    public class PersonBefore
    {
        private readonly string _name;
        private string _officeAreaCode;
        private string _officeNumber;

        public PersonBefore(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetOfficeAreaCode(string value)
        {
            _officeAreaCode = value;
        }

        public string GetOfficeAreaCode()
        {
            return _officeAreaCode;
        }

        public void SetOfficeNumber(string value)
        {
            _officeNumber = value;
        }

        public string GetOfficeNumber()
        {
            return _officeNumber;
        }

        public String GetTelephoneNumber()
        {
            return ("(" + GetOfficeAreaCode() + ") " + GetOfficeNumber());
        }
    }
}
