namespace Refactoring.OrganizingData.ReplaceSubclassWithFields.Before
{
    public class Female : Person
    {
        public override bool IsMale()
        {
            return false;
        }

        public override char GetCode()
        {
            return 'F';
        }
    }
}