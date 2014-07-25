namespace Refactoring.MakingMethodCallsSimpler.SeparateQueryFromModifier
{
    public class Before
    {
        public string FoundMiscreant(string[] people)
        {
            foreach (string person in people)
            {
                if (person.Equals("Don"))
                {
                    sendAlert();
                    return "Don";
                }
                if (person.Equals("John"))
                {
                    sendAlert();
                    return "John";
                }
            }
            return "";
        }

        public void CheckSecurity(string[] people)
        {
            string found = FoundMiscreant(people);
            SomeLaterCode(found);
        }


        private void SomeLaterCode(string found)
        {
            throw new System.NotImplementedException();
        }

        private void sendAlert()
        {
            throw new System.NotImplementedException();
        }
    }
}
