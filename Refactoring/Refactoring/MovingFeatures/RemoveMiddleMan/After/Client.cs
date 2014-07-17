namespace Refactoring.MovingFeatures.RemoveMiddleMan.After
{
    public class Client
    {
        private readonly Person _john;

        public Client(Person person)
        {
            _john = person;
        }

        public void Example()
        {
            var manager = _john.GetDepartment().GetManager();

            // ...
        }
    }
}
