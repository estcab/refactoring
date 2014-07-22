using System;

namespace Refactoring.SimplifyingConditionalExpressions.RemoveControlFlag.UsingReturn
{
    public class Before
    {
        public void CheckSecurity(String[] people)
        {
            String found = "";
            for (int i = 0; i < people.Length; i++)
            {
                if (found.Equals(""))
                {
                    if (people[i].Equals("Don"))
                    {
                        SendAlert();
                        found = "Don";
                    }
                    if (people[i].Equals("John"))
                    {
                        SendAlert();
                        found = "John";
                    }
                }
            }
            SomeLaterCode(found);
        }

        private void SomeLaterCode(string found)
        {
            throw new NotImplementedException();
        }


        private void SendAlert()
        {
            throw new NotImplementedException();
        }

    }
}
