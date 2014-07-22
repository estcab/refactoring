using System;
using System.Collections.Generic;

namespace Refactoring.SimplifyingConditionalExpressions.RemoveControlFlag.UsingReturn
{
    public class After
    {
        public void CheckSecurity(String[] people)
        {
            var found = FoundMiscreant(people);
            SomeLaterCode(found);
        }

        // A function with side effects
        private string FoundMiscreant(IEnumerable<string> people)
        {
            foreach (var name in people)
            {
                if (name.Equals("Don"))
                {
                    // Separate Query from Modifier
                    SendAlert();
                    return "Don";
                }

                if (name.Equals("John"))
                {
                    // Separate Query from Modifier
                    SendAlert();
                    return "John";
                }
            }

            return string.Empty;
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
