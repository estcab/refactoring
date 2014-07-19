namespace Refactoring.OrganizingData.EncapsulateField
{
    public class After
    {
        private string _name;

        public void SetName(string value)
        {
            _name = value;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
