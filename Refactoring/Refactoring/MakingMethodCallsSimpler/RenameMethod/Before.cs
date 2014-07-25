namespace Refactoring.MakingMethodCallsSimpler.RenameMethod
{
    public class Before
    {
        private readonly string _officeAreaCode;
        private readonly string _officeNumber;

        public Before(string officeAreaCode, string officeNumber)
        {
            _officeAreaCode = officeAreaCode;
            _officeNumber = officeNumber;
        }

        public string GetTelephoneNumber()
        {
            return string.Format("({0}) {1}", _officeAreaCode, _officeNumber);
        }
    }
}
