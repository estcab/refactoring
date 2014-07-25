namespace Refactoring.MakingMethodCallsSimpler.SeparateQueryFromModifier
{
    public class After
    {
        public void SendAlert(string[] people)
        {
            if (!FoundPerson(people).Equals(string.Empty))
            {
                SendAlert();
            }
        }

        public string FoundPerson(string[] people)
        {
            foreach (string person in people)
            {
                if (person.Equals("Don"))
                {
                    return "Don";
                }
                if (person.Equals("John"))
                {
                    return "John";
                }
            }
            return "";
        }

        public void CheckSecurity(string[] people)
        {
            SendAlert(people);
            var found = FoundPerson(people);
            SomeLaterCode(found);
        }


        private void SomeLaterCode(string found)
        {
            throw new System.NotImplementedException();
        }

        private void SendAlert()
        {
            throw new System.NotImplementedException();
        }
    }
}
