namespace Refactoring.OrganizingData.ReplaceTypeCodeWithClass.After
{
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0);
        public static readonly BloodGroup A = new BloodGroup(1);
        public static readonly BloodGroup B = new BloodGroup(2);
        public static readonly BloodGroup AB = new BloodGroup(3);

        private static readonly BloodGroup[] Values = { O, A, B, AB };

        private readonly int _code;

        private BloodGroup(int code)
        {
            _code = code;
        }

        private int GetCode()
        {
            return _code;
        }

        private static BloodGroup GetBloodGroup(int code)
        {
            return Values[code];
        }
    }
}