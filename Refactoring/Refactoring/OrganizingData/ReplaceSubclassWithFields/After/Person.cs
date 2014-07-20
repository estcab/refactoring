namespace Refactoring.OrganizingData.ReplaceSubclassWithFields.After
{
    public class Person
    {
        private readonly bool _isMale;
        private readonly char _code;

        protected Person(bool isMale, char code)
        {
            this._isMale = isMale;
            this._code = code;
        }

        public static Person CreateMale()
        {
            return new Person(true, 'M');
        }

        public static Person CreateFeMale()
        {
            return new Person(false, 'F');
        }

        public bool IsMale()
        {
            return _isMale;
        }

        public char GetCode()
        {
            return _code;
        }
    }
}
