namespace Refactoring.OrganizingData.ReplaceSubclassWithFields.Before
{
    public class Male : Person
    {
        public override bool IsMale()
        {
            return true;
        }

        public override char GetCode()
        {
            return 'M';
        }
    }
}