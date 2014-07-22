using System;

namespace Refactoring.SimplifyingConditionalExpressions.RemoveControlFlag.ReplacedWithBreak
{
    public class After
    {
        public void CheckSecurity(String[] people)
        {            
            foreach (var name in people)
            {                
                if (name.Equals("Don"))
                {
                    SendAlert();
                    break;
                }
                if (name.Equals("John"))
                {
                    SendAlert();
                    break;
                }
            }
        }

        private void SendAlert()
        {
            throw new NotImplementedException();
        }

    }
}
