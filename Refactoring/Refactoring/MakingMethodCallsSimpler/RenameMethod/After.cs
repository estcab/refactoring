using System;

namespace Refactoring.MakingMethodCallsSimpler.RenameMethod
{
    public class After
    {
        private readonly string _officeAreaCode;
        private readonly string _officeNumber;

        public After(string officeAreaCode, string officeNumber)
        {
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        [Obsolete("Use GetOfficeTelephoneNumber instead")]
        public string GetTelephoneNumber()
        {
            return GetOfficeTelephoneNumber();
        }

        public string GetOfficeTelephoneNumber()
        {
            return string.Format("({0}) {1}", _officeAreaCode, _officeNumber);
        }
    }
}
