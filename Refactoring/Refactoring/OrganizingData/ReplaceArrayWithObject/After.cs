namespace Refactoring.OrganizingData.ReplaceArrayWithObject
{
    public class After
    {
        private readonly Performance _performance = new Performance();

        public void SetExample()
        {
            _performance.SetName("Liverpool");
            _performance.SetWins("15");
        }

        public void GetExample()
        {
            string name = _performance.GetName();
            int wins = _performance.GetWins();

            // ..
        }

    }
}
